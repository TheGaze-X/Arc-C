using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.SubsystemsImplementation;

namespace UnityEngine
{
	// Token: 0x0200000B RID: 11
	[Token(Token = "0x200000B")]
	[NativeHeader("Modules/Subsystems/SubsystemManager.h")]
	public static class SubsystemManager
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000D")]
		[Address(RVA = "0x59CCC40", Offset = "0x59CB840", VA = "0x1859CCC40")]
		[RequiredByNativeCode]
		private static void ReloadSubsystemsStarted()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000E")]
		[Address(RVA = "0x59CCB50", Offset = "0x59CB750", VA = "0x1859CCB50")]
		[RequiredByNativeCode]
		private static void ReloadSubsystemsCompleted()
		{
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000F")]
		[Address(RVA = "0x59CCA90", Offset = "0x59CB690", VA = "0x1859CCA90")]
		[RequiredByNativeCode]
		private static void InitializeIntegratedSubsystem(IntPtr ptr, IntegratedSubsystem subsystem)
		{
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000010")]
		[Address(RVA = "0x59CC6E0", Offset = "0x59CB2E0", VA = "0x1859CC6E0")]
		[RequiredByNativeCode]
		private static void ClearSubsystems()
		{
		}

		// Token: 0x06000011 RID: 17
		[Token(Token = "0x6000011")]
		[Address(RVA = "0x59CCD30", Offset = "0x59CB930", VA = "0x1859CCD30")]
		[MethodImpl(4096)]
		private static extern void StaticConstructScriptingClassMap();

		// Token: 0x06000013 RID: 19 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6000013")]
		[Address(RVA = "0x59CC920", Offset = "0x59CB520", VA = "0x1859CC920")]
		internal static IntegratedSubsystem GetIntegratedSubsystemByPtr(IntPtr ptr)
		{
			return null;
		}

		// Token: 0x04000005 RID: 5
		[Token(Token = "0x4000005")]
		[FieldOffset(Offset = "0x0")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action beforeReloadSubsystems;

		// Token: 0x04000006 RID: 6
		[Token(Token = "0x4000006")]
		[FieldOffset(Offset = "0x8")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action afterReloadSubsystems;

		// Token: 0x04000007 RID: 7
		[Token(Token = "0x4000007")]
		[FieldOffset(Offset = "0x10")]
		private static List<IntegratedSubsystem> s_IntegratedSubsystems;

		// Token: 0x04000008 RID: 8
		[Token(Token = "0x4000008")]
		[FieldOffset(Offset = "0x18")]
		private static List<SubsystemWithProvider> s_StandaloneSubsystems;

		// Token: 0x04000009 RID: 9
		[Token(Token = "0x4000009")]
		[FieldOffset(Offset = "0x20")]
		private static List<Subsystem> s_DeprecatedSubsystems;

		// Token: 0x0400000A RID: 10
		[Token(Token = "0x400000A")]
		[FieldOffset(Offset = "0x28")]
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private static Action reloadSubsytemsStarted;

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x30")]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		private static Action reloadSubsytemsCompleted;
	}
}
