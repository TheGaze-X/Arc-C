using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000062 RID: 98
	[Token(Token = "0x2000062")]
	[NativeHeader("Runtime/Export/Debug/Debug.bindings.h")]
	public class Debug
	{
		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001CE RID: 462 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700007C")]
		public static ILogger unityLogger
		{
			[Token(Token = "0x60001CE")]
			[Address(RVA = "0x59282A0", Offset = "0x5926EA0", VA = "0x1859282A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001CF")]
		[Address(RVA = "0x5926560", Offset = "0x5925160", VA = "0x185926560")]
		[ExcludeFromDocs]
		public static void DrawLine(Vector3 start, Vector3 end, Color color, float duration)
		{
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D0")]
		[Address(RVA = "0x5926660", Offset = "0x5925260", VA = "0x185926660")]
		[ExcludeFromDocs]
		public static void DrawLine(Vector3 start, Vector3 end, Color color)
		{
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D1")]
		[Address(RVA = "0x5926750", Offset = "0x5925350", VA = "0x185926750")]
		[ExcludeFromDocs]
		public static void DrawLine(Vector3 start, Vector3 end)
		{
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D2")]
		[Address(RVA = "0x59264C0", Offset = "0x59250C0", VA = "0x1859264C0")]
		[FreeFunction("DebugDrawLine", IsThreadSafe = true)]
		public static void DrawLine(Vector3 start, Vector3 end, [UnityEngine.Internal.DefaultValue("Color.white")] Color color, [UnityEngine.Internal.DefaultValue("0.0f")] float duration, [UnityEngine.Internal.DefaultValue("true")] bool depthTest)
		{
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D3")]
		[Address(RVA = "0x5926850", Offset = "0x5925450", VA = "0x185926850")]
		[ExcludeFromDocs]
		public static void DrawRay(Vector3 start, Vector3 dir, Color color, float duration)
		{
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D4")]
		[Address(RVA = "0x5926B30", Offset = "0x5925730", VA = "0x185926B30")]
		[ExcludeFromDocs]
		public static void DrawRay(Vector3 start, Vector3 dir, Color color)
		{
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D5")]
		[Address(RVA = "0x5926A80", Offset = "0x5925680", VA = "0x185926A80")]
		[ExcludeFromDocs]
		public static void DrawRay(Vector3 start, Vector3 dir)
		{
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D6")]
		[Address(RVA = "0x5926910", Offset = "0x5925510", VA = "0x185926910")]
		public static void DrawRay(Vector3 start, Vector3 dir, [UnityEngine.Internal.DefaultValue("Color.white")] Color color, [UnityEngine.Internal.DefaultValue("0.0f")] float duration, [UnityEngine.Internal.DefaultValue("true")] bool depthTest)
		{
		}

		// Token: 0x060001D7 RID: 471
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x5926130", Offset = "0x5924D30", VA = "0x185926130")]
		[FreeFunction("PauseEditor")]
		[MethodImpl(4096)]
		public static extern void Break();

		// Token: 0x060001D8 RID: 472
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x5926420", Offset = "0x5925020", VA = "0x185926420")]
		[MethodImpl(4096)]
		public static extern void DebugBreak();

		// Token: 0x060001D9 RID: 473
		[Token(Token = "0x60001D9")]
		[Address(RVA = "0x5926BE0", Offset = "0x59257E0", VA = "0x185926BE0")]
		[ThreadSafe]
		[MethodImpl(4096)]
		public unsafe static extern int ExtractStackTraceNoAlloc(byte* buffer, int bufferMax, string projectFolder);

		// Token: 0x060001DA RID: 474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DA")]
		[Address(RVA = "0x5927FA0", Offset = "0x5926BA0", VA = "0x185927FA0")]
		public static void Log(object message)
		{
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DB")]
		[Address(RVA = "0x5927ED0", Offset = "0x5926AD0", VA = "0x185927ED0")]
		public static void Log(object message, Object context)
		{
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DC")]
		[Address(RVA = "0x59279E0", Offset = "0x59265E0", VA = "0x1859279E0")]
		public static void LogFormat(string format, params object[] args)
		{
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DD")]
		[Address(RVA = "0x5927AB0", Offset = "0x59266B0", VA = "0x185927AB0")]
		public static void LogFormat(Object context, string format, params object[] args)
		{
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DE")]
		[Address(RVA = "0x59276F0", Offset = "0x59262F0", VA = "0x1859276F0")]
		public static void LogFormat(LogType logType, LogOption logOptions, Object context, string format, params object[] args)
		{
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001DF")]
		[Address(RVA = "0x59274B0", Offset = "0x59260B0", VA = "0x1859274B0")]
		public static void LogError(object message)
		{
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E0")]
		[Address(RVA = "0x59273E0", Offset = "0x5925FE0", VA = "0x1859273E0")]
		public static void LogError(object message, Object context)
		{
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E1")]
		[Address(RVA = "0x5927310", Offset = "0x5925F10", VA = "0x185927310")]
		public static void LogErrorFormat(string format, params object[] args)
		{
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E2")]
		[Address(RVA = "0x5927230", Offset = "0x5925E30", VA = "0x185927230")]
		public static void LogErrorFormat(Object context, string format, params object[] args)
		{
		}

		// Token: 0x060001E3 RID: 483
		[Token(Token = "0x60001E3")]
		[Address(RVA = "0x59263F0", Offset = "0x5924FF0", VA = "0x1859263F0")]
		[MethodImpl(4096)]
		public static extern void ClearDeveloperConsole();

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001E4 RID: 484
		// (set) Token: 0x060001E5 RID: 485
		[Token(Token = "0x1700007D")]
		public static extern bool developerConsoleVisible { [Token(Token = "0x60001E4")] [Address(RVA = "0x59281C0", Offset = "0x5926DC0", VA = "0x1859281C0")] [MethodImpl(4096)] get; [Token(Token = "0x60001E5")] [Address(RVA = "0x59282F0", Offset = "0x5926EF0", VA = "0x1859282F0")] [MethodImpl(4096)] set; }

		// Token: 0x060001E6 RID: 486 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E6")]
		[Address(RVA = "0x5927570", Offset = "0x5926170", VA = "0x185927570")]
		public static void LogException(Exception exception)
		{
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E7")]
		[Address(RVA = "0x5927630", Offset = "0x5926230", VA = "0x185927630")]
		public static void LogException(Exception exception, Object context)
		{
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E8")]
		[Address(RVA = "0x5927E10", Offset = "0x5926A10", VA = "0x185927E10")]
		public static void LogWarning(object message)
		{
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001E9")]
		[Address(RVA = "0x5927D40", Offset = "0x5926940", VA = "0x185927D40")]
		public static void LogWarning(object message, Object context)
		{
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EA")]
		[Address(RVA = "0x5927B90", Offset = "0x5926790", VA = "0x185927B90")]
		public static void LogWarningFormat(string format, params object[] args)
		{
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EB")]
		[Address(RVA = "0x5927C60", Offset = "0x5926860", VA = "0x185927C60")]
		public static void LogWarningFormat(Object context, string format, params object[] args)
		{
		}

		// Token: 0x060001EC RID: 492 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EC")]
		[Address(RVA = "0x5925C20", Offset = "0x5924820", VA = "0x185925C20")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition)
		{
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001ED")]
		[Address(RVA = "0x5925F70", Offset = "0x5924B70", VA = "0x185925F70")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, Object context)
		{
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EE")]
		[Address(RVA = "0x5925CF0", Offset = "0x59248F0", VA = "0x185925CF0")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, object message)
		{
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001EF")]
		[Address(RVA = "0x5925DC0", Offset = "0x59249C0", VA = "0x185925DC0")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, string message)
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F0")]
		[Address(RVA = "0x5925B40", Offset = "0x5924740", VA = "0x185925B40")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, object message, Object context)
		{
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F1")]
		[Address(RVA = "0x5925E90", Offset = "0x5924A90", VA = "0x185925E90")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void Assert(bool condition, string message, Object context)
		{
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F2")]
		[Address(RVA = "0x5925A60", Offset = "0x5924660", VA = "0x185925A60")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void AssertFormat(bool condition, string format, params object[] args)
		{
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F3")]
		[Address(RVA = "0x5925970", Offset = "0x5924570", VA = "0x185925970")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void AssertFormat(bool condition, Object context, string format, params object[] args)
		{
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F4")]
		[Address(RVA = "0x59270A0", Offset = "0x5925CA0", VA = "0x1859270A0")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertion(object message)
		{
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F5")]
		[Address(RVA = "0x5927160", Offset = "0x5925D60", VA = "0x185927160")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertion(object message, Object context)
		{
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F6")]
		[Address(RVA = "0x5926FD0", Offset = "0x5925BD0", VA = "0x185926FD0")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertionFormat(string format, params object[] args)
		{
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001F7")]
		[Address(RVA = "0x5926EF0", Offset = "0x5925AF0", VA = "0x185926EF0")]
		[Conditional("UNITY_ASSERTIONS")]
		public static void LogAssertionFormat(Object context, string format, params object[] args)
		{
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001F8 RID: 504
		[Token(Token = "0x1700007E")]
		[NativeProperty(TargetType = 1)]
		[StaticAccessor("GetBuildSettings()", StaticAccessorType.Dot)]
		public static extern bool isDebugBuild { [Token(Token = "0x60001F8")] [Address(RVA = "0x5928220", Offset = "0x5926E20", VA = "0x185928220")] [MethodImpl(4096)] get; }

		// Token: 0x060001F9 RID: 505
		[Token(Token = "0x60001F9")]
		[Address(RVA = "0x5928060", Offset = "0x5926C60", VA = "0x185928060")]
		[FreeFunction("DeveloperConsole_OpenConsoleFile")]
		[MethodImpl(4096)]
		internal static extern void OpenConsoleFile();

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001FA RID: 506
		[Token(Token = "0x1700007F")]
		[NativeThrows]
		internal static extern DiagnosticSwitch[] diagnosticSwitches { [Token(Token = "0x60001FA")] [Address(RVA = "0x59281F0", Offset = "0x5926DF0", VA = "0x1859281F0")] [MethodImpl(4096)] get; }

		// Token: 0x060001FB RID: 507 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60001FB")]
		[Address(RVA = "0x5926C30", Offset = "0x5925830", VA = "0x185926C30")]
		internal static DiagnosticSwitch GetDiagnosticSwitch(string name)
		{
			return null;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00002898 File Offset: 0x00000A98
		[Token(Token = "0x60001FC")]
		[Address(RVA = "0x5926160", Offset = "0x5924D60", VA = "0x185926160")]
		[RequiredByNativeCode]
		internal static bool CallOverridenDebugHandler(Exception exception, Object obj)
		{
			return default(bool);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x000028B0 File Offset: 0x00000AB0
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x5926D80", Offset = "0x5925980", VA = "0x185926D80")]
		[RequiredByNativeCode]
		internal static bool IsLoggingEnabled()
		{
			return default(bool);
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FE")]
		[Address(RVA = "0x5926050", Offset = "0x5924C50", VA = "0x185926050")]
		[Conditional("UNITY_ASSERTIONS")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Assert(bool, string, params object[]) is obsolete. Use AssertFormat(bool, string, params object[]) (UnityUpgradable) -> AssertFormat(*)", true)]
		public static void Assert(bool condition, string format, params object[] args)
		{
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001FF RID: 511 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000080")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Obsolete("Debug.logger is obsolete. Please use Debug.unityLogger instead (UnityUpgradable) -> unityLogger")]
		public static ILogger logger
		{
			[Token(Token = "0x60001FF")]
			[Address(RVA = "0x5928250", Offset = "0x5926E50", VA = "0x185928250")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000200")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Debug()
		{
		}

		// Token: 0x06000202 RID: 514
		[Token(Token = "0x6000202")]
		[Address(RVA = "0x5926450", Offset = "0x5925050", VA = "0x185926450")]
		[MethodImpl(4096)]
		private static extern void DrawLine_Injected(ref Vector3 start, ref Vector3 end, [UnityEngine.Internal.DefaultValue("Color.white")] ref Color color, [UnityEngine.Internal.DefaultValue("0.0f")] float duration, [UnityEngine.Internal.DefaultValue("true")] bool depthTest);

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x0")]
		internal static readonly ILogger s_DefaultLogger;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x8")]
		internal static ILogger s_Logger;
	}
}
