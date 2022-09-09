#if KOGANE_DISABLE_DEBUG_LOG

using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Kogane.Internal
{
    internal readonly struct DisabledLogHandler : ILogHandler
    {
        void ILogHandler.LogFormat( LogType logType, Object context, string format, params object[] args )
        {
        }

        void ILogHandler.LogException( Exception exception, Object context )
        {
        }
    }
}

#endif