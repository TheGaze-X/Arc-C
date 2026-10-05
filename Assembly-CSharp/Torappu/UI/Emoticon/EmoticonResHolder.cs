using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050DB RID: 20699
	[Token(Token = "0x20050DB")]
	public class EmoticonResHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E9B3 RID: 125363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E9B3")]
		[Address(RVA = "0x183C4A0", Offset = "0x183B0A0", VA = "0x18183C4A0")]
		public Sprite GetEmojiBgSprite()
		{
			return null;
		}

		// Token: 0x0601E9B4 RID: 125364 RVA: 0x000AF0F8 File Offset: 0x000AD2F8
		[Token(Token = "0x601E9B4")]
		[Address(RVA = "0x183C660", Offset = "0x183B260", VA = "0x18183C660")]
		public Color GetEmojiTxtColor()
		{
			return default(Color);
		}

		// Token: 0x0601E9B5 RID: 125365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E9B5")]
		[Address(RVA = "0x183C500", Offset = "0x183B100", VA = "0x18183C500")]
		public Sprite GetEmojiIconFromHub(string iconId, ILoadAsset assetLoader)
		{
			return null;
		}

		// Token: 0x0601E9B6 RID: 125366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9B6")]
		[Address(RVA = "0x183C6E0", Offset = "0x183B2E0", VA = "0x18183C6E0")]
		public EmoticonResHolder()
		{
		}

		// Token: 0x0402903B RID: 167995
		[Token(Token = "0x402903B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Sprite _emojiBgSprite;

		// Token: 0x0402903C RID: 167996
		[Token(Token = "0x402903C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AutoPackSpriteHub _emojiIconHub;

		// Token: 0x0402903D RID: 167997
		[Token(Token = "0x402903D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Color _emojiTxtColor;

		// Token: 0x0402903E RID: 167998
		[Token(Token = "0x402903E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetEmojiBgSprite;

		// Token: 0x0402903F RID: 167999
		[Token(Token = "0x402903F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetEmojiTxtColor;

		// Token: 0x04029040 RID: 168000
		[Token(Token = "0x4029040")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetEmojiIconFromHub;

		// Token: 0x04029041 RID: 168001
		[Token(Token = "0x4029041")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
