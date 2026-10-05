using System;
using Il2CppDummyDll;
using UnityEngine.Rendering;

namespace Torappu.UI.Stencil
{
	// Token: 0x02005A4A RID: 23114
	[Token(Token = "0x2005A4A")]
	public struct ReplaceMatParam
	{
		// Token: 0x0402E02D RID: 188461
		[Token(Token = "0x402E02D")]
		[FieldOffset(Offset = "0x0")]
		public Operation opt;

		// Token: 0x0402E02E RID: 188462
		[Token(Token = "0x402E02E")]
		[FieldOffset(Offset = "0x4")]
		public Comparison comp;

		// Token: 0x0402E02F RID: 188463
		[Token(Token = "0x402E02F")]
		[FieldOffset(Offset = "0x8")]
		public ColorWriteMask colorMask;

		// Token: 0x0402E030 RID: 188464
		[Token(Token = "0x402E030")]
		[FieldOffset(Offset = "0xC")]
		public StencilChannel readChannel;

		// Token: 0x0402E031 RID: 188465
		[Token(Token = "0x402E031")]
		[FieldOffset(Offset = "0x10")]
		public StencilChannel writeChannel;

		// Token: 0x0402E032 RID: 188466
		[Token(Token = "0x402E032")]
		[FieldOffset(Offset = "0x14")]
		public bool isExclusive;
	}
}
