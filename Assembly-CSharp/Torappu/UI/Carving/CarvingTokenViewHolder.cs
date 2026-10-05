using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x0200604A RID: 24650
	[Token(Token = "0x200604A")]
	public class CarvingTokenViewHolder : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005426 RID: 21542
		// (get) Token: 0x06023A4D RID: 145997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005426")]
		public RectTransform dragBoundRect
		{
			[Token(Token = "0x6023A4D")]
			[Address(RVA = "0x1E50EE0", Offset = "0x1E4FAE0", VA = "0x181E50EE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023A4E RID: 145998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A4E")]
		[Address(RVA = "0x1E50D90", Offset = "0x1E4F990", VA = "0x181E50D90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023A4F RID: 145999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A4F")]
		[Address(RVA = "0x1E50D10", Offset = "0x1E4F910", VA = "0x181E50D10")]
		private void _ClearTween()
		{
		}

		// Token: 0x06023A50 RID: 146000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A50")]
		[Address(RVA = "0x1E509B0", Offset = "0x1E4F5B0", VA = "0x181E509B0")]
		public void OnShow(float startScale)
		{
		}

		// Token: 0x06023A51 RID: 146001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A51")]
		[Address(RVA = "0x1E506D0", Offset = "0x1E4F2D0", VA = "0x181E506D0")]
		public void OnHide()
		{
		}

		// Token: 0x06023A52 RID: 146002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A52")]
		[Address(RVA = "0x1E50320", Offset = "0x1E4EF20", VA = "0x181E50320")]
		public void OnHideToSlot(string cardId, Vector2 targetPos)
		{
		}

		// Token: 0x06023A53 RID: 146003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A53")]
		[Address(RVA = "0x1E50C40", Offset = "0x1E4F840", VA = "0x181E50C40")]
		public void Render(CarvingMainCardViewModel viewModel)
		{
		}

		// Token: 0x06023A54 RID: 146004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A54")]
		[Address(RVA = "0x1E50E60", Offset = "0x1E4FA60", VA = "0x181E50E60")]
		public CarvingTokenViewHolder()
		{
		}

		// Token: 0x040315E4 RID: 202212
		[Token(Token = "0x40315E4")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CarvingMainCardView _prefabCard;

		// Token: 0x040315E5 RID: 202213
		[Token(Token = "0x40315E5")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _cardContainer;

		// Token: 0x040315E6 RID: 202214
		[Token(Token = "0x40315E6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _alphaHandler;

		// Token: 0x040315E7 RID: 202215
		[Token(Token = "0x40315E7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _tweenDuration;

		// Token: 0x040315E8 RID: 202216
		[Token(Token = "0x40315E8")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _hideMoveDuration;

		// Token: 0x040315E9 RID: 202217
		[Token(Token = "0x40315E9")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Ease _tweenEase;

		// Token: 0x040315EA RID: 202218
		[Token(Token = "0x40315EA")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _scaleHide;

		// Token: 0x040315EB RID: 202219
		[Token(Token = "0x40315EB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _dragBoundRect;

		// Token: 0x040315EC RID: 202220
		[Token(Token = "0x40315EC")]
		[FieldOffset(Offset = "0x48")]
		private bool m_inited;

		// Token: 0x040315ED RID: 202221
		[Token(Token = "0x40315ED")]
		[FieldOffset(Offset = "0x50")]
		private CarvingMainCardView m_cardView;

		// Token: 0x040315EE RID: 202222
		[Token(Token = "0x40315EE")]
		[FieldOffset(Offset = "0x58")]
		private Tween m_tween;

		// Token: 0x040315EF RID: 202223
		[Token(Token = "0x40315EF")]
		[FieldOffset(Offset = "0x60")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040315F0 RID: 202224
		[Token(Token = "0x40315F0")]
		[FieldOffset(Offset = "0x70")]
		private CarvingMainCardViewModel m_cachedCardViewModel;

		// Token: 0x040315F1 RID: 202225
		[Token(Token = "0x40315F1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dragBoundRect;

		// Token: 0x040315F2 RID: 202226
		[Token(Token = "0x40315F2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040315F3 RID: 202227
		[Token(Token = "0x40315F3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ClearTween;

		// Token: 0x040315F4 RID: 202228
		[Token(Token = "0x40315F4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnShow;

		// Token: 0x040315F5 RID: 202229
		[Token(Token = "0x40315F5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnHide;

		// Token: 0x040315F6 RID: 202230
		[Token(Token = "0x40315F6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnHideToSlot;

		// Token: 0x040315F7 RID: 202231
		[Token(Token = "0x40315F7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040315F8 RID: 202232
		[Token(Token = "0x40315F8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
