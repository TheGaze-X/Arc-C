using System;
using Il2CppDummyDll;
using Torappu.UI.Stencil;

namespace Torappu.UI
{
	// Token: 0x0200369D RID: 13981
	[Token(Token = "0x200369D")]
	public class CutinElementParam
	{
		// Token: 0x060163B5 RID: 91061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60163B5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CutinElementParam()
		{
		}

		// Token: 0x0401AB9D RID: 109469
		[Token(Token = "0x401AB9D")]
		[FieldOffset(Offset = "0x10")]
		public StencilChannel channel;

		// Token: 0x0401AB9E RID: 109470
		[Token(Token = "0x401AB9E")]
		[FieldOffset(Offset = "0x18")]
		public string spriteName;

		// Token: 0x0401AB9F RID: 109471
		[Token(Token = "0x401AB9F")]
		[FieldOffset(Offset = "0x20")]
		public float aFrom;

		// Token: 0x0401ABA0 RID: 109472
		[Token(Token = "0x401ABA0")]
		[FieldOffset(Offset = "0x24")]
		public float aTo;

		// Token: 0x0401ABA1 RID: 109473
		[Token(Token = "0x401ABA1")]
		[FieldOffset(Offset = "0x28")]
		public float aDuration;

		// Token: 0x0401ABA2 RID: 109474
		[Token(Token = "0x401ABA2")]
		[FieldOffset(Offset = "0x2C")]
		public CutinParam.ParamType paramType;
	}
}
