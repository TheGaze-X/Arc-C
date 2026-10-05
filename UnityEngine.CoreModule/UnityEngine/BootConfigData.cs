using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x02000051 RID: 81
	[Token(Token = "0x2000051")]
	[NativeHeader("Runtime/Export/Bootstrap/BootConfig.bindings.h")]
	internal class BootConfigData
	{
		// Token: 0x060000E8 RID: 232 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60000E8")]
		[Address(RVA = "0x591FD80", Offset = "0x591E980", VA = "0x18591FD80")]
		[RequiredByNativeCode]
		private static BootConfigData WrapBootConfigData(IntPtr nativeHandle)
		{
			return null;
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000E9")]
		[Address(RVA = "0x591FE70", Offset = "0x591EA70", VA = "0x18591FE70")]
		private BootConfigData(IntPtr nativeHandle)
		{
		}

		// Token: 0x04000110 RID: 272
		[Token(Token = "0x4000110")]
		[FieldOffset(Offset = "0x10")]
		private IntPtr m_Ptr;
	}
}
