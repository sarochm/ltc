using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;

namespace LtcService
{
    public class OsUsersReader
    {
        public static List<string> GetAdmins()
        {
            return GetGroupMembers("administrators");
        }

        public static List<string> GetGroupMembers(string group)
        {
            var userNames = new List<string>();

            var localMachine = new DirectoryEntry("WinNT://" + Environment.MachineName);
            var admGroup = localMachine.Children.Find(group, "group");
            var members = admGroup.Invoke("members", null);
            foreach (var groupMember in (IEnumerable) members)
            {
                var member = new DirectoryEntry(groupMember);
                userNames.Add(member.Name.ToUpper());
            }
            return userNames;
        }
    }
}