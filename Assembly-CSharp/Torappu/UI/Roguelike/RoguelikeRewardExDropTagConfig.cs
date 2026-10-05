using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.UI.Roguelike
{
	// Token: 0x020053E4 RID: 21476
	[Token(Token = "0x20053E4")]
	[Serializable]
	public class RoguelikeRewardExDropTagConfig
	{
		// Token: 0x0601F99F RID: 129439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F99F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeRewardExDropTagConfig()
		{
		}

		// Token: 0x0402A8FB RID: 174331
		[Token(Token = "0x402A8FB")]
		[FieldOffset(Offset = "0x10")]
		public Color tagColor;

		// Token: 0x0402A8FC RID: 174332
		[Token(Token = "0x402A8FC")]
		[FieldOffset(Offset = "0x20")]
		public Color tagTextColor;

		// Token: 0x0402A8FD RID: 174333
		[Token(Token = "0x402A8FD")]
		[FieldOffset(Offset = "0x30")]
		public RoguelikeRewardExDropTagSrcType tagType;

		// Token: 0x0402A8FE RID: 174334
		[Token(Token = "0x402A8FE")]
		[FieldOffset(Offset = "0x38")]
		public Sprite tagBgSprite;
	}
}
