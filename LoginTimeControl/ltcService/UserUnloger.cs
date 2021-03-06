﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace LtcService
{
    public class UserUnloger : IUserUnloger
    {
        [DllImport("wtsapi32.dll", SetLastError = true)]
        private static extern bool WTSLogoffSession(IntPtr hServer, int SessionId, bool bWait);

        [DllImport("Wtsapi32.dll")]
        private static extern bool WTSQuerySessionInformation(
            IntPtr hServer, int sessionId, WTS_INFO_CLASS wtsInfoClass, out IntPtr ppBuffer, out uint pBytesReturned);

        [DllImport("wtsapi32.dll", SetLastError = true)]
        private static extern IntPtr WTSOpenServer([MarshalAs(UnmanagedType.LPStr)] string pServerName);

        [DllImport("wtsapi32.dll")]
        private static extern void WTSCloseServer(IntPtr hServer);

        [DllImport("wtsapi32.dll", SetLastError = true)]
        private static extern int WTSEnumerateSessions(IntPtr hServer, [MarshalAs(UnmanagedType.U4)] int Reserved,
            [MarshalAs(UnmanagedType.U4)] int Version, ref IntPtr ppSessionInfo,
            [MarshalAs(UnmanagedType.U4)] ref int pCount);

        [DllImport("wtsapi32.dll")]
        private static extern void WTSFreeMemory(IntPtr pMemory);

        private List<int> GetSessionIDs(IntPtr server)
        {
            var sessionIds = new List<int>();
            var buffer = IntPtr.Zero;
            var count = 0;
            var retval = WTSEnumerateSessions(server, 0, 1, ref buffer, ref count);
            var dataSize = Marshal.SizeOf(typeof (WTS_SESSION_INFO));
            long current = (int) buffer;

            if (retval != 0)
            {
                for (var i = 0; i < count; i++)
                {
                    var si = (WTS_SESSION_INFO) Marshal.PtrToStructure((IntPtr) current, typeof (WTS_SESSION_INFO));
                    current += dataSize;
                    sessionIds.Add(si.SessionID);
                }
                WTSFreeMemory(buffer);
            }
            return sessionIds;
        }

        internal bool LogOffUser(string userName, IntPtr server)
        {
            userName = userName.Trim().ToUpper();
            var sessions = GetSessionIDs(server);
            var userSessionDictionary = GetUserSessionDictionary(server, sessions);
            if (userSessionDictionary.ContainsKey(userName))
                return WTSLogoffSession(server, userSessionDictionary[userName], true);
            return false;
        }

        private Dictionary<string, int> GetUserSessionDictionary(IntPtr server, List<int> sessions)
        {
            var userSession = new Dictionary<string, int>();

            foreach (var sessionId in sessions)
            {
                var uName = GetUserName(sessionId, server);
                if (!string.IsNullOrWhiteSpace(uName))
                    userSession.Add(uName, sessionId);
            }
            return userSession;
        }

        internal string GetUserName(int sessionId, IntPtr server)
        {
            var buffer = IntPtr.Zero;
            uint count = 0;
            var userName = string.Empty;
            try
            {
                WTSQuerySessionInformation(server, sessionId, WTS_INFO_CLASS.WTSUserName, out buffer, out count);
                userName = Marshal.PtrToStringAnsi(buffer).ToUpper().Trim();
            }
            finally
            {
                WTSFreeMemory(buffer);
            }
            return userName;
        }

        public bool IsSomeOneLogedOn()
        {
            var users = GetLogedUsers();
            return users.Any();
        }

        public void LogOffAll()
        {
            var server = WTSOpenServer(Environment.MachineName);
            try
            {
                var users = GetLogedUsers();
                foreach (var user in users)
                {
                    LogOffUser(user, server);
                }
            }
            finally
            {
                WTSCloseServer(server);
            }
        }

        public List<string> GetLogedUsers()
        {
            var server = WTSOpenServer(Environment.MachineName);
            List<string> userNames;
            try
            {
                var ids = GetSessionIDs(server);
                userNames =
                    ids.Select(i => GetUserName(i, server))
                        .Distinct()
                        .Where(n => !string.IsNullOrWhiteSpace(n))
                        .ToList();
            }
            finally
            {
                WTSCloseServer(server);
            }
            return userNames;
        }
    }

    [StructLayout(LayoutKind.Sequential)]
    internal struct WTS_SESSION_INFO
    {
        public int SessionID;
        [MarshalAs(UnmanagedType.LPStr)] public string pWinStationName;
        public WTS_CONNECTSTATE_CLASS State;
    }

    internal enum WTS_CONNECTSTATE_CLASS
    {
        WTSActive,
        WTSConnected,
        WTSConnectQuery,
        WTSShadow,
        WTSDisconnected,
        WTSIdle,
        WTSListen,
        WTSReset,
        WTSDown,
        WTSInit
    }

    internal enum WTS_INFO_CLASS
    {
        WTSInitialProgram,
        WTSApplicationName,
        WTSWorkingDirectory,
        WTSOEMId,
        WTSSessionId,
        WTSUserName,
        WTSWinStationName,
        WTSDomainName,
        WTSConnectState,
        WTSClientBuildNumber,
        WTSClientName,
        WTSClientDirectory,
        WTSClientProductId,
        WTSClientHardwareId,
        WTSClientAddress,
        WTSClientDisplay,
        WTSClientProtocolType,
        WTSIdleTime,
        WTSLogonTime,
        WTSIncomingBytes,
        WTSOutgoingBytes,
        WTSIncomingFrames,
        WTSOutgoingFrames,
        WTSClientInfo,
        WTSSessionInfo
    }
}