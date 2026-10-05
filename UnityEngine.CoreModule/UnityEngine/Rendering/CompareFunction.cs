using System;
using Il2CppDummyDll;
using UnityEngine.Bindings;

namespace UnityEngine.Rendering
{
	// Token: 0x02000249 RID: 585
	[Token(Token = "0x2000249")]
	[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
	public enum CompareFunction
	{
		// Token: 0x0400065A RID: 1626
		[Token(Token = "0x400065A")]
		Disabled,
		// Token: 0x0400065B RID: 1627
		[Token(Token = "0x400065B")]
		Never,
		// Token: 0x0400065C RID: 1628
		[Token(Token = "0x400065C")]
		Less,
		// Token: 0x0400065D RID: 1629
		[Token(Token = "0x400065D")]
		Equal,
		// Token: 0x0400065E RID: 1630
		[Token(Token = "0x400065E")]
		LessEqual,
		// Token: 0x0400065F RID: 1631
		[Token(Token = "0x400065F")]
		Greater,
		// Token: 0x04000660 RID: 1632
		[Token(Token = "0x4000660")]
		NotEqual,
		// Token: 0x04000661 RID: 1633
		[Token(Token = "0x4000661")]
		GreaterEqual,
		// Token: 0x04000662 RID: 1634
		[Token(Token = "0x4000662")]
		Always
	}
}
