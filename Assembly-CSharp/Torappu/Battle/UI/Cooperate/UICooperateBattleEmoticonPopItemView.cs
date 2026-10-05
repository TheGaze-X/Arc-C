using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.Emoticon;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI.Cooperate
{
	// Token: 0x0200340B RID: 13323
	[Token(Token = "0x200340B")]
	public class UICooperateBattleEmoticonPopItemView : EmoticonPopEmojiItemBaseView
	{
		// Token: 0x060154A1 RID: 87201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154A1")]
		[Address(RVA = "0xDB0BE0", Offset = "0xDAF7E0", VA = "0x180DB0BE0", Slot = "4")]
		public override void ShowPopupEmojiItem(EmojiItemModel model, GOPositionHolder showPos, ILoadAsset assetLoader, PlayerIndex playerIndex)
		{
		}

		// Token: 0x060154A2 RID: 87202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154A2")]
		[Address(RVA = "0xDB0B80", Offset = "0xDAF780", VA = "0x180DB0B80", Slot = "5")]
		public override void HidePopupEmojiItem(bool isFastMode)
		{
		}

		// Token: 0x060154A3 RID: 87203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60154A3")]
		[Address(RVA = "0xDB0FE0", Offset = "0xDAFBE0", VA = "0x180DB0FE0")]
		public UICooperateBattleEmoticonPopItemView()
		{
		}

		// Token: 0x040196FC RID: 104188
		[Token(Token = "0x40196FC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UICooperateBattleEmoticonItemView _itemSelf;

		// Token: 0x040196FD RID: 104189
		[Token(Token = "0x40196FD")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UICooperateBattleEmoticonItemView _itemMate;

		// Token: 0x040196FE RID: 104190
		[Token(Token = "0x40196FE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UIAnimationLocation _popEmojiAnimSelf;

		// Token: 0x040196FF RID: 104191
		[Token(Token = "0x40196FF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _popEmojiAnimMate;

		// Token: 0x04019700 RID: 104192
		[Token(Token = "0x4019700")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _posHandler;

		// Token: 0x04019701 RID: 104193
		[Token(Token = "0x4019701")]
		[FieldOffset(Offset = "0x50")]
		private Tween m_tween;

		// Token: 0x04019702 RID: 104194
		[Token(Token = "0x4019702")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowPopupEmojiItem;

		// Token: 0x04019703 RID: 104195
		[Token(Token = "0x4019703")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HidePopupEmojiItem;

		// Token: 0x04019704 RID: 104196
		[Token(Token = "0x4019704")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
