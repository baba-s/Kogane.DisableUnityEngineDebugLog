#if KOGANE_DISABLE_DEBUG_LOG

using System.Diagnostics;
using UnityEngine;

public class Debug
{
    private const string CONDITION_STRING = "zUp55nZJ3vdL"; // 絶対に定義されないであろうシンボル

    public static ILogger unityLogger => UnityEngine.Debug.unityLogger;

    [Conditional( CONDITION_STRING )] public static void Assert( bool condition, string message, Object context )
    {
    }

    [Conditional( CONDITION_STRING )] public static void Assert( bool condition, object message, Object context )
    {
    }

    [Conditional( CONDITION_STRING )] public static void Assert( bool condition, string message )
    {
    }

    [Conditional( CONDITION_STRING )] public static void Assert( bool condition, object message )
    {
    }

    [Conditional( CONDITION_STRING )] public static void Assert( bool condition, Object context )
    {
    }

    [Conditional( CONDITION_STRING )] public static void Assert( bool condition )
    {
    }

    [Conditional( CONDITION_STRING )] public static void Assert( bool condition, string format, params object[] args )
    {
    }

    [Conditional( CONDITION_STRING )] public static void AssertFormat( bool condition, string format, params object[] args )
    {
    }

    [Conditional( CONDITION_STRING )] public static void AssertFormat( bool condition, Object context, string format, params object[] args )
    {
    }

    [Conditional( CONDITION_STRING )] public static void Break()
    {
    }

    [Conditional( CONDITION_STRING )] public static void ClearDeveloperConsole()
    {
    }

    [Conditional( CONDITION_STRING )] public static void DebugBreak()
    {
    }

    [Conditional( CONDITION_STRING )] public static void DrawLine
    (
        Vector3 start,
        Vector3 end,
        Color   color,
        float   duration,
        bool    depthTest
    )
    {
    }

    [Conditional( CONDITION_STRING )] public static void DrawLine( Vector3 start, Vector3 end, Color color, float duration )
    {
    }

    [Conditional( CONDITION_STRING )] public static void DrawLine( Vector3 start, Vector3 end )
    {
    }

    [Conditional( CONDITION_STRING )] public static void DrawLine( Vector3 start, Vector3 end, Color color )
    {
    }

    [Conditional( CONDITION_STRING )] public static void DrawRay( Vector3 start, Vector3 dir, Color color, float duration )
    {
    }

    [Conditional( CONDITION_STRING )] public static void DrawRay
    (
        Vector3 start,
        Vector3 dir,
        Color   color,
        float   duration,
        bool    depthTest
    )
    {
    }

    [Conditional( CONDITION_STRING )] public static void DrawRay( Vector3 start, Vector3 dir )
    {
    }

    [Conditional( CONDITION_STRING )] public static void DrawRay( Vector3 start, Vector3 dir, Color color )
    {
    }

    [Conditional( CONDITION_STRING )] public static void Log( object message )
    {
    }

    [Conditional( CONDITION_STRING )] public static void Log( object message, Object context )
    {
    }

    [Conditional( CONDITION_STRING )] public static void LogAssertion( object message, Object context )
    {
    }

    [Conditional( CONDITION_STRING )] public static void LogAssertion( object message )
    {
    }

    [Conditional( CONDITION_STRING )] public static void LogAssertionFormat( Object context, string format, params object[] args )
    {
    }

    [Conditional( CONDITION_STRING )] public static void LogAssertionFormat( string format, params object[] args )
    {
    }

    [Conditional( CONDITION_STRING )] public static void LogError( object message, Object context )
    {
    }

    [Conditional( CONDITION_STRING )] public static void LogError( object message )
    {
    }

    [Conditional( CONDITION_STRING )] public static void LogErrorFormat( string format, params object[] args )
    {
    }

    [Conditional( CONDITION_STRING )] public static void LogErrorFormat( Object context, string format, params object[] args )
    {
    }

    [Conditional( CONDITION_STRING )] public static void LogException( System.Exception exception, Object context )
    {
    }

    [Conditional( CONDITION_STRING )] public static void LogException( System.Exception exception )
    {
    }

    [Conditional( CONDITION_STRING )] public static void LogFormat( Object context, string format, params object[] args )
    {
    }

    [Conditional( CONDITION_STRING )] public static void LogFormat( string format, params object[] args )
    {
    }

    [Conditional( CONDITION_STRING )] public static void LogWarning( object message )
    {
    }

    [Conditional( CONDITION_STRING )] public static void LogWarning( object message, Object context )
    {
    }

    [Conditional( CONDITION_STRING )] public static void LogWarningFormat( string format, params object[] args )
    {
    }

    [Conditional( CONDITION_STRING )] public static void LogWarningFormat( Object context, string format, params object[] args )
    {
    }
}

#endif