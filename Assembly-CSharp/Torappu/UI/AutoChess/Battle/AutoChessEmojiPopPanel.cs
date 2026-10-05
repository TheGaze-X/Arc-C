using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI.Emoticon;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x020064F3 RID: 25843
	[Token(Token = "0x20064F3")]
	public class AutoChessEmojiPopPanel : EmoticonPopEmojiItemBaseView
	{
		// Token: 0x0602522C RID: 152108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602522C")]
		[Address(RVA = "0x20242C0", Offset = "0x2022EC0", VA = "0x1820242C0", Slot = "4")]
		public override void ShowPopupEmojiItem(EmojiItemModel model, GOPositionHolder showPos, ILoadAsset assetLoader, PlayerIndex playerIndex)
		{
		}

		// Token: 0x0602522D RID: 152109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602522D")]
		[Address(RVA = "0x2024210", Offset = "0x2022E10", VA = "0x182024210", Slot = "5")]
		public override void HidePopupEmojiItem(bool isFastMode)
		{
		}

		// Token: 0x0602522E RID: 152110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602522E")]
		[Address(RVA = "0x20246C0", Offset = "0x20232C0", VA = "0x1820246C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602522F RID: 152111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602522F")]
		[Address(RVA = "0x20247A0", Offset = "0x20233A0", VA = "0x1820247A0")]
		private void _TryToShowItem()
		{
		}

		// Token: 0x06025230 RID: 152112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025230")]
		[Address(RVA = "0x2024850", Offset = "0x2023450", VA = "0x182024850")]
		public AutoChessEmojiPopPanel()
		{
		}

		// Token: 0x04034103 RID: 213251
		[Token(Token = "0x4034103")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _rectPos;

		// Token: 0x04034104 RID: 213252
		[Token(Token = "0x4034104")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIAnimationLocation _chatItemAnim;

		// Token: 0x04034105 RID: 213253
		[Token(Token = "0x4034105")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CanvasGroup _itemCanvasGroup;

		// Token: 0x04034106 RID: 213254
		[Token(Token = "0x4034106")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _popupTime;

		// Token: 0x04034107 RID: 213255
		[Token(Token = "0x4034107")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _emojiIcon;

		// Token: 0x04034108 RID: 213256
		[Token(Token = "0x4034108")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x04034109 RID: 213257
		[Token(Token = "0x4034109")]
		[FieldOffset(Offset = "0x50")]
		private Tween m_showTween;

		// Token: 0x0403410A RID: 213258
		[Token(Token = "0x403410A")]
		[FieldOffset(Offset = "0x58")]
		private FadeSwitchTween m_switchTween;

		// Token: 0x0403410B RID: 213259
		[Token(Token = "0x403410B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowPopupEmojiItem;

		// Token: 0x0403410C RID: 213260
		[Token(Token = "0x403410C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HidePopupEmojiItem;

		// Token: 0x0403410D RID: 213261
		[Token(Token = "0x403410D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403410E RID: 213262
		[Token(Token = "0x403410E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__TryToShowItem;

		// Token: 0x0403410F RID: 213263
		[Token(Token = "0x403410F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
