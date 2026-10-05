using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050DA RID: 20698
	[Token(Token = "0x20050DA")]
	public abstract class EmoticonPopEmojiItemBaseView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601E9B0 RID: 125360
		[Token(Token = "0x601E9B0")]
		public abstract void ShowPopupEmojiItem(EmojiItemModel model, GOPositionHolder showPos, ILoadAsset assetLoader, PlayerIndex playerIndex);

		// Token: 0x0601E9B1 RID: 125361
		[Token(Token = "0x601E9B1")]
		public abstract void HidePopupEmojiItem(bool isFastMode);

		// Token: 0x0601E9B2 RID: 125362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9B2")]
		[Address(RVA = "0x183C440", Offset = "0x183B040", VA = "0x18183C440")]
		protected EmoticonPopEmojiItemBaseView()
		{
		}

		// Token: 0x0402903A RID: 167994
		[Token(Token = "0x402903A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
