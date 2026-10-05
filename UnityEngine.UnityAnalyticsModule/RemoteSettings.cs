using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[NativeHeader("UnityAnalyticsScriptingClasses.h")]
	[NativeHeader("Modules/UnityAnalytics/RemoteSettings/RemoteSettings.h")]
	public static class RemoteSettings
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x5B98150", Offset = "0x5B96D50", VA = "0x185B98150")]
		[RequiredByNativeCode]
		internal static void RemoteSettingsUpdated(bool wasLastUpdatedFromServer)
		{
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x5B98080", Offset = "0x5B96C80", VA = "0x185B98080")]
		[RequiredByNativeCode]
		internal static void RemoteSettingsBeforeFetchFromServer()
		{
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000003")]
		[Address(RVA = "0x5B980D0", Offset = "0x5B96CD0", VA = "0x185B980D0")]
		[RequiredByNativeCode]
		internal static void RemoteSettingsUpdateCompleted(bool wasLastUpdatedFromServer, bool settingsChanged, int response)
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[FieldOffset(Offset = "0x0")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static RemoteSettings.UpdatedEventHandler Updated;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[FieldOffset(Offset = "0x8")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action BeforeFetchFromServer;

		// Token: 0x04000003 RID: 3
		[Token(Token = "0x4000003")]
		[FieldOffset(Offset = "0x10")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action<bool, bool, int> Completed;

		// Token: 0x02000003 RID: 3
		// (Invoke) Token: 0x06000005 RID: 5
		[Token(Token = "0x2000003")]
		public delegate void UpdatedEventHandler();
	}
}
