using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.Analytics
{
	// Token: 0x02000009 RID: 9
	[Token(Token = "0x2000009")]
	[NativeHeader("Modules/UnityAnalytics/Public/UnityAnalytics.h")]
	[RequiredByNativeCode]
	[NativeHeader("UnityAnalyticsScriptingClasses.h")]
	public static class AnalyticsSessionInfo
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x5B97FC0", Offset = "0x5B96BC0", VA = "0x185B97FC0")]
		[RequiredByNativeCode]
		internal static void CallSessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged)
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x5B97F60", Offset = "0x5B96B60", VA = "0x185B97F60")]
		[RequiredByNativeCode]
		internal static void CallIdentityTokenChanged(string token)
		{
		}

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x0")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static AnalyticsSessionInfo.SessionStateChanged sessionStateChanged;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x8")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static AnalyticsSessionInfo.IdentityTokenChanged identityTokenChanged;

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x0600000A RID: 10
		[Token(Token = "0x200000A")]
		public delegate void SessionStateChanged(AnalyticsSessionState sessionState, long sessionId, long sessionElapsedTime, bool sessionChanged);

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x0600000C RID: 12
		[Token(Token = "0x200000B")]
		public delegate void IdentityTokenChanged(string token);
	}
}
