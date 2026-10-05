using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Arcade
{
	// Token: 0x0200798F RID: 31119
	[Token(Token = "0x200798F")]
	public class Act1ArcadeStageScoreInfoDialog : UICompDialog<Act1ArcadeStageScoreInfoDialog.Input>
	{
		// Token: 0x0602BA9D RID: 178845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA9D")]
		[Address(RVA = "0x278C270", Offset = "0x278AE70", VA = "0x18278C270")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602BA9E RID: 178846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BA9E")]
		[Address(RVA = "0x278BDF0", Offset = "0x278A9F0", VA = "0x18278BDF0")]
		public void EventOnCloseClicked()
		{
		}

		// Token: 0x0602BA9F RID: 178847 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BA9F")]
		[Address(RVA = "0x278C440", Offset = "0x278B040", VA = "0x18278C440")]
		private IEnumerator _OnShowCoroutine()
		{
			return null;
		}

		// Token: 0x0602BAA0 RID: 178848 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602BAA0")]
		[Address(RVA = "0x278C390", Offset = "0x278AF90", VA = "0x18278C390")]
		private IEnumerator _OnHideCoroutine()
		{
			return null;
		}

		// Token: 0x0602BAA1 RID: 178849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAA1")]
		[Address(RVA = "0x278BF00", Offset = "0x278AB00", VA = "0x18278BF00", Slot = "18")]
		protected override void OnRender(Act1ArcadeStageScoreInfoDialog.Input input)
		{
		}

		// Token: 0x0602BAA2 RID: 178850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BAA2")]
		[Address(RVA = "0x278C4F0", Offset = "0x278B0F0", VA = "0x18278C4F0")]
		public Act1ArcadeStageScoreInfoDialog()
		{
		}

		// Token: 0x0403F2AB RID: 258731
		[Token(Token = "0x403F2AB")]
		private const float FADE_DURATION = 0.2f;

		// Token: 0x0403F2AC RID: 258732
		[Token(Token = "0x403F2AC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private List<Act1ArcadeStageScoreInfoItemView> _itemViews;

		// Token: 0x0403F2AD RID: 258733
		[Token(Token = "0x403F2AD")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _bgRect;

		// Token: 0x0403F2AE RID: 258734
		[Token(Token = "0x403F2AE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private CanvasGroup _canvasGroup;

		// Token: 0x0403F2AF RID: 258735
		[Token(Token = "0x403F2AF")]
		[FieldOffset(Offset = "0x88")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403F2B0 RID: 258736
		[Token(Token = "0x403F2B0")]
		[FieldOffset(Offset = "0x98")]
		private bool m_isInited;

		// Token: 0x0403F2B1 RID: 258737
		[Token(Token = "0x403F2B1")]
		[FieldOffset(Offset = "0x99")]
		private bool m_isBlockClick;

		// Token: 0x0403F2B2 RID: 258738
		[Token(Token = "0x403F2B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403F2B3 RID: 258739
		[Token(Token = "0x403F2B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnCloseClicked;

		// Token: 0x0403F2B4 RID: 258740
		[Token(Token = "0x403F2B4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnShowCoroutine;

		// Token: 0x0403F2B5 RID: 258741
		[Token(Token = "0x403F2B5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnHideCoroutine;

		// Token: 0x0403F2B6 RID: 258742
		[Token(Token = "0x403F2B6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x0403F2B7 RID: 258743
		[Token(Token = "0x403F2B7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007990 RID: 31120
		[Token(Token = "0x2007990")]
		public class Input
		{
			// Token: 0x0602BAA3 RID: 178851 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602BAA3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Input()
			{
			}

			// Token: 0x0403F2B8 RID: 258744
			[Token(Token = "0x403F2B8")]
			[FieldOffset(Offset = "0x10")]
			public Act1ArcadeStageSelectViewModel stageSelectModel;
		}
	}
}
