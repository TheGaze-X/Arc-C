using System;
using Il2CppDummyDll;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050D4 RID: 20692
	[Token(Token = "0x20050D4")]
	public class PopEmojiItemInputParam
	{
		// Token: 0x0601E99C RID: 125340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E99C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PopEmojiItemInputParam()
		{
		}

		// Token: 0x04029017 RID: 167959
		[Token(Token = "0x4029017")]
		[FieldOffset(Offset = "0x10")]
		public string themeId;

		// Token: 0x04029018 RID: 167960
		[Token(Token = "0x4029018")]
		[FieldOffset(Offset = "0x18")]
		public string chatEmojiId;

		// Token: 0x04029019 RID: 167961
		[Token(Token = "0x4029019")]
		[FieldOffset(Offset = "0x20")]
		public GOPositionHolder showPos;

		// Token: 0x0402901A RID: 167962
		[Token(Token = "0x402901A")]
		[FieldOffset(Offset = "0x28")]
		public PlayerIndex index;

		// Token: 0x0402901B RID: 167963
		[Token(Token = "0x402901B")]
		[FieldOffset(Offset = "0x30")]
		public ILoadAsset assetLoader;
	}
}
