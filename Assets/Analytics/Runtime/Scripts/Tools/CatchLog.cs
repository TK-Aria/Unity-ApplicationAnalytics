using System;
using UnityEngine;
using UnityEngine.Events;


namespace Analytics
{

    [DisallowMultipleComponent]
    public class CatchLog : MonoBehaviour
    {


        #region Event

        [Serializable]
        public class Handler : UnityEvent<string, string, LogType> { }
        //public class Handler : UnityEvent<LogInfo> { }

        [SerializeField]
        private Handler onCatchLogHandler = new Handler();

        #endregion // Event End.


        #region Type

        [Serializable]
        public class LogInfo
        {
            public string logMessage;
            public string stackTrace;
            public LogType logType;
        }

        #endregion // Type End.

        //private LogInfo logInfo = new LogInfo();
        //private string receiveLogMessage;
        //private string receiveStackTrace;


        private void OnEnable()
        {
            Application.logMessageReceived += HandleLog;
        }

        private void OnDisable()
        {
            Application.logMessageReceived -= HandleLog;
        }

        // Todo : stringのコピーで重くなる... 主にstacktrace...
        //private void HandleLog(string logMessage, string stackTrace, LogType logType)
        private void HandleLog(string logMessage, string stackTrace, LogType logType)
        {

            if (string.IsNullOrEmpty(logMessage)) return;

            //var receiveLogMessage += logMessage + Environment.NewLine;
            //receiveStackTrace += stackTrace + Environment.NewLine;

            onCatchLogHandler.Invoke(
                logMessage + Environment.NewLine,
                stackTrace + Environment.NewLine, 
                logType);

            /*
            var logInfo = new LogInfo()
            {
                logMessage = logMessage,
                stackTrace = stackTrace,
                logType = logType,
            };
            onCatchLogHandler.Invoke(logInfo);
            */

        }

    }

}

