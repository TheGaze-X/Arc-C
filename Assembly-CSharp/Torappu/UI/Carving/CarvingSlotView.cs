using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x02006049 RID: 24649
	[Token(Token = "0x2006049")]
	public class CarvingSlotView : MonoBehaviour, IHotfixable
	{
		// Token: 0x17005425 RID: 21541
		// (get) Token: 0x06023A47 RID: 145991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005425")]
		public RectTransform dragBoundRect
		{
			[Token(Token = "0x6023A47")]
			[Address(RVA = "0x1E502C0", Offset = "0x1E4EEC0", VA = "0x181E502C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06023A48 RID: 145992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A48")]
		[Address(RVA = "0x1E50110", Offset = "0x1E4ED10", VA = "0x181E50110")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06023A49 RID: 145993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023A49")]
		[Address(RVA = "0x1E4FC50", Offset = "0x1E4E850", VA = "0x181E4FC50")]
		public Tween GenerateShowAnim()
		{
			return null;
		}

		// Token: 0x06023A4A RID: 145994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A4A")]
		[Address(RVA = "0x1E4FDE0", Offset = "0x1E4E9E0", VA = "0x181E4FDE0")]
		public void Render(CarvingMainViewModel model, int idx)
		{
		}

		// Token: 0x06023A4B RID: 145995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A4B")]
		[Address(RVA = "0x1E4FD40", Offset = "0x1E4E940", VA = "0x181E4FD40")]
		public void OnSlotClicked()
		{
		}

		// Token: 0x06023A4C RID: 145996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023A4C")]
		[Address(RVA = "0x1E50260", Offset = "0x1E4EE60", VA = "0x181E50260")]
		public CarvingSlotView()
		{
		}

		// Token: 0x040315CF RID: 202191
		[Token(Token = "0x40315CF")]
		private const float LOCK_ALPHA = 0.19607843f;

		// Token: 0x040315D0 RID: 202192
		[Token(Token = "0x40315D0")]
		private const float UNLOCK_ALPHA = 1f;

		// Token: 0x040315D1 RID: 202193
		[Token(Token = "0x40315D1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private UIAnimationLocation _animEnter;

		// Token: 0x040315D2 RID: 202194
		[Token(Token = "0x40315D2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _canvasHighlight;

		// Token: 0x040315D3 RID: 202195
		[Token(Token = "0x40315D3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _pnlLocked;

		// Token: 0x040315D4 RID: 202196
		[Token(Token = "0x40315D4")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private CanvasGroup _raycastHandler;

		// Token: 0x040315D5 RID: 202197
		[Token(Token = "0x40315D5")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _dragBoundRect;

		// Token: 0x040315D6 RID: 202198
		[Token(Token = "0x40315D6")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private CanvasGroup _canvasHovering;

		// Token: 0x040315D7 RID: 202199
		[Token(Token = "0x40315D7")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private UIAtlasImage _emptyBg;

		// Token: 0x040315D8 RID: 202200
		[Token(Token = "0x40315D8")]
		[FieldOffset(Offset = "0x58")]
		private int m_cachedIdx;

		// Token: 0x040315D9 RID: 202201
		[Token(Token = "0x40315D9")]
		[FieldOffset(Offset = "0x5C")]
		private bool m_cachedHandCardSelected;

		// Token: 0x040315DA RID: 202202
		[Token(Token = "0x40315DA")]
		[FieldOffset(Offset = "0x60")]
		private UISwitchTween m_highlightTween;

		// Token: 0x040315DB RID: 202203
		[Token(Token = "0x40315DB")]
		[FieldOffset(Offset = "0x68")]
		private bool m_inited;

		// Token: 0x040315DC RID: 202204
		[Token(Token = "0x40315DC")]
		[FieldOffset(Offset = "0x70")]
		private UIPageFinder m_pageFinder;

		// Token: 0x040315DD RID: 202205
		[Token(Token = "0x40315DD")]
		[FieldOffset(Offset = "0x80")]
		private UISwitchTween m_hoveringTween;

		// Token: 0x040315DE RID: 202206
		[Token(Token = "0x40315DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_dragBoundRect;

		// Token: 0x040315DF RID: 202207
		[Token(Token = "0x40315DF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040315E0 RID: 202208
		[Token(Token = "0x40315E0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GenerateShowAnim;

		// Token: 0x040315E1 RID: 202209
		[Token(Token = "0x40315E1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040315E2 RID: 202210
		[Token(Token = "0x40315E2")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSlotClicked;

		// Token: 0x040315E3 RID: 202211
		[Token(Token = "0x40315E3")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
