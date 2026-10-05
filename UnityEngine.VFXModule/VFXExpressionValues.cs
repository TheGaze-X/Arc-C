using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine.VFX
{
	// Token: 0x02000003 RID: 3
	[Token(Token = "0x2000003")]
	[RequiredByNativeCode]
	[NativeType(Header = "Modules/VFX/Public/VFXExpressionValues.h")]
	[StructLayout(0)]
	public class VFXExpressionValues
	{
		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private VFXExpressionValues()
		{
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600000C")]
		[Address(RVA = "0x5BA0B90", Offset = "0x5B9F790", VA = "0x185BA0B90")]
		[RequiredByNativeCode]
		internal static VFXExpressionValues CreateExpressionValuesWrapper(IntPtr ptr)
		{
			return null;
		}

		// Token: 0x04000004 RID: 4
		[Token(Token = "0x4000004")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		internal IntPtr m_Ptr;
	}
}
