using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000002 RID: 2
	[Token(Token = "0x2000002")]
	[UsedByNativeCode]
	[NativeHeader("Modules/Subsystems/Subsystem.h")]
	[StructLayout(0)]
	public class IntegratedSubsystem
	{
		// Token: 0x06000001 RID: 1
		[Token(Token = "0x6000001")]
		[Address(RVA = "0x59CC150", Offset = "0x59CAD50", VA = "0x1859CC150")]
		[MethodImpl(4096)]
		internal extern void SetHandle(IntegratedSubsystem subsystem);

		// Token: 0x06000002 RID: 2 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000002")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public IntegratedSubsystem()
		{
		}

		// Token: 0x04000001 RID: 1
		[Token(Token = "0x4000001")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;

		// Token: 0x04000002 RID: 2
		[Token(Token = "0x4000002")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		internal ISubsystemDescriptor m_SubsystemDescriptor;
	}
}
