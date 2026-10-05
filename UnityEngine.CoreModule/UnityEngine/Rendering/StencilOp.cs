using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	// Token: 0x0200024B RID: 587
	[Token(Token = "0x200024B")]
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	public enum StencilOp
	{
		// Token: 0x0400066A RID: 1642
		[Token(Token = "0x400066A")]
		Keep,
		// Token: 0x0400066B RID: 1643
		[Token(Token = "0x400066B")]
		Zero,
		// Token: 0x0400066C RID: 1644
		[Token(Token = "0x400066C")]
		Replace,
		// Token: 0x0400066D RID: 1645
		[Token(Token = "0x400066D")]
		IncrementSaturate,
		// Token: 0x0400066E RID: 1646
		[Token(Token = "0x400066E")]
		DecrementSaturate,
		// Token: 0x0400066F RID: 1647
		[Token(Token = "0x400066F")]
		Invert,
		// Token: 0x04000670 RID: 1648
		[Token(Token = "0x4000670")]
		IncrementWrap,
		// Token: 0x04000671 RID: 1649
		[Token(Token = "0x4000671")]
		DecrementWrap
	}
}
