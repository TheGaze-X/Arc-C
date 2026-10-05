using System;
using Il2CppDummyDll;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050D3 RID: 20691
	[Token(Token = "0x20050D3")]
	public class PanelInputParam
	{
		// Token: 0x0601E99B RID: 125339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E99B")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PanelInputParam()
		{
		}

		// Token: 0x04029011 RID: 167953
		[Token(Token = "0x4029011")]
		[FieldOffset(Offset = "0x10")]
		public Type emoticonModelConfigType;

		// Token: 0x04029012 RID: 167954
		[Token(Token = "0x4029012")]
		[FieldOffset(Offset = "0x18")]
		public ValueBundle configInput;

		// Token: 0x04029013 RID: 167955
		[Token(Token = "0x4029013")]
		[FieldOffset(Offset = "0x38")]
		public EmojiSceneType chatSceneType;

		// Token: 0x04029014 RID: 167956
		[Token(Token = "0x4029014")]
		[FieldOffset(Offset = "0x40")]
		public GOPositionHolder showPos;

		// Token: 0x04029015 RID: 167957
		[Token(Token = "0x4029015")]
		[FieldOffset(Offset = "0x48")]
		public ILoadAsset assetLoader;

		// Token: 0x04029016 RID: 167958
		[Token(Token = "0x4029016")]
		[FieldOffset(Offset = "0x50")]
		public Action emojiCoolDown;
	}
}
