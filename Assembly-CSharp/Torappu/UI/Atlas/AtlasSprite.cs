using System;
using Il2CppDummyDll;

namespace Torappu.UI.Atlas
{
	// Token: 0x02005C30 RID: 23600
	[Token(Token = "0x2005C30")]
	[Serializable]
	public class AtlasSprite
	{
		// Token: 0x06022353 RID: 140115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022353")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public AtlasSprite()
		{
		}

		// Token: 0x0402EEE0 RID: 192224
		[Token(Token = "0x402EEE0")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0402EEE1 RID: 192225
		[Token(Token = "0x402EEE1")]
		[FieldOffset(Offset = "0x18")]
		public string guid;

		// Token: 0x0402EEE2 RID: 192226
		[Token(Token = "0x402EEE2")]
		[FieldOffset(Offset = "0x20")]
		public int atlas;

		// Token: 0x0402EEE3 RID: 192227
		[Token(Token = "0x402EEE3")]
		[FieldOffset(Offset = "0x24")]
		public AtlasCoord rect;

		// Token: 0x0402EEE4 RID: 192228
		[Token(Token = "0x402EEE4")]
		[FieldOffset(Offset = "0x34")]
		public bool rotate;
	}
}
