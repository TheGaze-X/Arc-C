using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Emoticon
{
	// Token: 0x020050E5 RID: 20709
	[Token(Token = "0x20050E5")]
	public class EmoticonSimplePopEmojiItemView : EmoticonPopEmojiItemBaseView
	{
		// Token: 0x0601E9DC RID: 125404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9DC")]
		[Address(RVA = "0x18617D0", Offset = "0x18603D0", VA = "0x1818617D0", Slot = "4")]
		public override void ShowPopupEmojiItem(EmojiItemModel model, GOPositionHolder showPos, ILoadAsset assetLoader, PlayerIndex playerIndex)
		{
		}

		// Token: 0x0601E9DD RID: 125405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9DD")]
		[Address(RVA = "0x1861720", Offset = "0x1860320", VA = "0x181861720", Slot = "5")]
		public override void HidePopupEmojiItem(bool isFastMode)
		{
		}

		// Token: 0x0601E9DE RID: 125406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9DE")]
		[Address(RVA = "0x1861B90", Offset = "0x1860790", VA = "0x181861B90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E9DF RID: 125407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E9DF")]
		[Address(RVA = "0x1861D00", Offset = "0x1860900", VA = "0x181861D00")]
		public EmoticonSimplePopEmojiItemView()
		{
		}

		// Token: 0x04029088 RID: 168072
		[Token(Token = "0x4029088")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private EmoticonSimpleEmojiItemView _itemPrefab;

		// Token: 0x04029089 RID: 168073
		[Token(Token = "0x4029089")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x0402908A RID: 168074
		[Token(Token = "0x402908A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _rectPos;

		// Token: 0x0402908B RID: 168075
		[Token(Token = "0x402908B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _chatItemAnim;

		// Token: 0x0402908C RID: 168076
		[Token(Token = "0x402908C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _itemCanvasGroup;

		// Token: 0x0402908D RID: 168077
		[Token(Token = "0x402908D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private float _popupTime;

		// Token: 0x0402908E RID: 168078
		[Token(Token = "0x402908E")]
		[FieldOffset(Offset = "0x50")]
		private EmoticonSimpleEmojiItemView m_item;

		// Token: 0x0402908F RID: 168079
		[Token(Token = "0x402908F")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x04029090 RID: 168080
		[Token(Token = "0x4029090")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_showTween;

		// Token: 0x04029091 RID: 168081
		[Token(Token = "0x4029091")]
		[FieldOffset(Offset = "0x68")]
		private FadeSwitchTween m_switchTween;

		// Token: 0x04029092 RID: 168082
		[Token(Token = "0x4029092")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ShowPopupEmojiItem;

		// Token: 0x04029093 RID: 168083
		[Token(Token = "0x4029093")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HidePopupEmojiItem;

		// Token: 0x04029094 RID: 168084
		[Token(Token = "0x4029094")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029095 RID: 168085
		[Token(Token = "0x4029095")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
