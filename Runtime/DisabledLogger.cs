#if KOGANE_DISABLE_DEBUG_LOG

using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Kogane.Internal
{
    internal readonly struct DisabledLogger : ILogger
    {
        ILogHandler ILogger.logHandler
        {
            get => new DisabledLogHandler();
            set
            {
            }
        }

        bool ILogger.logEnabled
        {
            get => false;
            set
            {
            }
        }

        LogType ILogger.filterLogType
        {
            get => 0;
            set
            {
            }
        }

        void ILogHandler.LogFormat( LogType logType, Object context, string format, params object[] args )
        {
        }

        void ILogHandler.LogException( Exception exception, Object context )
        {
        }

        bool ILogger.IsLogTypeAllowed( LogType logType )
        {
            return false;
        }

        void ILogger.Log( LogType logType, object message )
        {
        }

        void ILogger.Log( LogType logType, object message, Object context )
        {
        }

        void ILogger.Log( LogType logType, string tag, object message )
        {
        }

        void ILogger.Log( LogType logType, string tag, object message, Object context )
        {
        }

        void ILogger.Log( object message )
        {
        }

        void ILogger.Log( string tag, object message )
        {
        }

        void ILogger.Log( string tag, object message, Object context )
        {
        }

        void ILogger.LogWarning( string tag, object message )
        {
        }

        void ILogger.LogWarning( string tag, object message, Object context )
        {
        }

        void ILogger.LogError( string tag, object message )
        {
        }

        void ILogger.LogError( string tag, object message, Object context )
        {
        }

        void ILogger.LogFormat( LogType logType, string format, params object[] args )
        {
        }

        void ILogger.LogException( Exception exception )
        {
        }
    }
}

#endif