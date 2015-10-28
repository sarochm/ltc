using System.Diagnostics;

namespace Common
{
    public class EventLogger : IEventLogger
    {
        private readonly EventLog _eventLog;

        public EventLogger(string appName)
        {
            _eventLog = new EventLog {Source = appName};
        }

        public void Debug(string message)
        {
            _eventLog.WriteEntry("Debug: "+message, EventLogEntryType.Information);
        }

        public void Info(string message)
        {
            _eventLog.WriteEntry(message,EventLogEntryType.Information);
        }

        public void Warning(string message)
        {
            _eventLog.WriteEntry(message, EventLogEntryType.Warning);
        }

        public void Error(string message)
        {
            _eventLog.WriteEntry(message, EventLogEntryType.Error);
        }
    }
}