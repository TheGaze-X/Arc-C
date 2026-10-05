using System;
using Il2CppDummyDll;

namespace Torappu.UI.Atlas
{
	// Token: 0x02005C2F RID: 23599
	[Token(Token = "0x2005C2F")]
	[Serializable]
	public struct AtlasCoord
	{
		// Token: 0x06022352 RID: 140114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022352")]
		[Address(RVA = "0x1CA1750", Offset = "0x1CA0350", VA = "0x181CA1750")]
		public AtlasCoord(int x, int y, int w, int h)
		{
		}

		// Token: 0x0402EEDC RID: 192220
		[Token(Token = "0x402EEDC")]
		[FieldOffset(Offset = "0x0")]
		public int x;

		// Token: 0x0402EEDD RID: 192221
		[Token(Token = "0x402EEDD")]
		[FieldOffset(Offset = "0x4")]
		public int y;

		// Token: 0x0402EEDE RID: 192222
		[Token(Token = "0x402EEDE")]
		[FieldOffset(Offset = "0x8")]
		public int w;

		// Token: 0x0402EEDF RID: 192223
		[Token(Token = "0x402EEDF")]
		[FieldOffset(Offset = "0xC")]
		public int h;
	}
}
