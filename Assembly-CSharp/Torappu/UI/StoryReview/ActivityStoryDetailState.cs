using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048D4 RID: 18644
	[Token(Token = "0x20048D4")]
	public class ActivityStoryDetailState : PopupFadeState
	{
		// Token: 0x0601C1F2 RID: 115186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C1F2")]
		[Address(RVA = "0x15924B0", Offset = "0x15910B0", VA = "0x1815924B0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x170042D1 RID: 17105
		// (get) Token: 0x0601C1F3 RID: 115187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042D1")]
		public override IStateCacheHandler cacheHandler
		{
			[Token(Token = "0x601C1F3")]
			[Address(RVA = "0x15936C0", Offset = "0x15922C0", VA = "0x1815936C0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C1F4 RID: 115188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1F4")]
		[Address(RVA = "0x1592510", Offset = "0x1591110", VA = "0x181592510", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601C1F5 RID: 115189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1F5")]
		[Address(RVA = "0x1592B20", Offset = "0x1591720", VA = "0x181592B20")]
		private void _OnScrollRectTween(float pos)
		{
		}

		// Token: 0x0601C1F6 RID: 115190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1F6")]
		[Address(RVA = "0x1592950", Offset = "0x1591550", VA = "0x181592950")]
		private void _OnBackClick()
		{
		}

		// Token: 0x0601C1F7 RID: 115191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1F7")]
		[Address(RVA = "0x1593150", Offset = "0x1591D50", VA = "0x181593150")]
		private void _OnStoryRead(string storyId)
		{
		}

		// Token: 0x0601C1F8 RID: 115192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1F8")]
		[Address(RVA = "0x1593090", Offset = "0x1591C90", VA = "0x181593090")]
		private void _OnStoryReadSuc()
		{
		}

		// Token: 0x0601C1F9 RID: 115193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1F9")]
		[Address(RVA = "0x1592E50", Offset = "0x1591A50", VA = "0x181592E50")]
		private void _OnStoryClicked(string storyId)
		{
		}

		// Token: 0x0601C1FA RID: 115194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1FA")]
		[Address(RVA = "0x15933B0", Offset = "0x1591FB0", VA = "0x1815933B0")]
		private void _OnUnlockClicked(string storyId)
		{
		}

		// Token: 0x0601C1FB RID: 115195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1FB")]
		[Address(RVA = "0x1593220", Offset = "0x1591E20", VA = "0x181593220")]
		private void _OnStoryUnlock(StoryReviewViewModel viewModel)
		{
		}

		// Token: 0x0601C1FC RID: 115196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1FC")]
		[Address(RVA = "0x15932F0", Offset = "0x1591EF0", VA = "0x1815932F0")]
		private void _OnStoryUnlocked()
		{
		}

		// Token: 0x0601C1FD RID: 115197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1FD")]
		[Address(RVA = "0x1592A70", Offset = "0x1591670", VA = "0x181592A70")]
		private void _OnBlurShot()
		{
		}

		// Token: 0x0601C1FE RID: 115198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1FE")]
		[Address(RVA = "0x1592C90", Offset = "0x1591890", VA = "0x181592C90")]
		private void _OnScrollReset()
		{
		}

		// Token: 0x0601C1FF RID: 115199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C1FF")]
		[Address(RVA = "0x1593610", Offset = "0x1592210", VA = "0x181593610")]
		public ActivityStoryDetailState()
		{
		}

		// Token: 0x0601C204 RID: 115204 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C204")]
		[Address(RVA = "0x12DC030", Offset = "0x12DAC30", VA = "0x1812DC030")]
		private IStateCacheHandler <>xLuaBaseProxy_get_cacheHandler()
		{
			return null;
		}

		// Token: 0x0601C205 RID: 115205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C205")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04024C45 RID: 150597
		[Token(Token = "0x4024C45")]
		private const float DEFAULT_SCROLL_POS = 1f;

		// Token: 0x04024C46 RID: 150598
		[Token(Token = "0x4024C46")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TopMenuDynamicPrefabInstHolder _topMenuHolder;

		// Token: 0x04024C47 RID: 150599
		[Token(Token = "0x4024C47")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActivityReviewDetailBinder _activityStoryDetailBinder;

		// Token: 0x04024C48 RID: 150600
		[Token(Token = "0x4024C48")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private LoopVerticalScrollRect _scrollRect;

		// Token: 0x04024C49 RID: 150601
		[Token(Token = "0x4024C49")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _maskPanel;

		// Token: 0x04024C4A RID: 150602
		[Token(Token = "0x4024C4A")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _blurBackground;

		// Token: 0x04024C4B RID: 150603
		[Token(Token = "0x4024C4B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _chapterImage;

		// Token: 0x04024C4C RID: 150604
		[Token(Token = "0x4024C4C")]
		[FieldOffset(Offset = "0xA0")]
		private ActivityReviewDetailStateBean m_stateBean;

		// Token: 0x04024C4D RID: 150605
		[Token(Token = "0x4024C4D")]
		[FieldOffset(Offset = "0xA8")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04024C4E RID: 150606
		[Token(Token = "0x4024C4E")]
		[FieldOffset(Offset = "0xB8")]
		private StateCacheHandler<ActivityStoryDetailState.StateRuntime> m_cacheHandler;

		// Token: 0x04024C4F RID: 150607
		[Token(Token = "0x4024C4F")]
		[FieldOffset(Offset = "0xC0")]
		private float m_startScrollPos;

		// Token: 0x04024C50 RID: 150608
		[Token(Token = "0x4024C50")]
		[FieldOffset(Offset = "0xC4")]
		private bool m_backToStage;

		// Token: 0x04024C51 RID: 150609
		[Token(Token = "0x4024C51")]
		[FieldOffset(Offset = "0xC8")]
		private StoryReviewPage.FastExit m_fastExit;

		// Token: 0x04024C52 RID: 150610
		[Token(Token = "0x4024C52")]
		private const float SCROLL_DURATION = 0.23f;

		// Token: 0x04024C53 RID: 150611
		[Token(Token = "0x4024C53")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04024C54 RID: 150612
		[Token(Token = "0x4024C54")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cacheHandler;

		// Token: 0x04024C55 RID: 150613
		[Token(Token = "0x4024C55")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04024C56 RID: 150614
		[Token(Token = "0x4024C56")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnScrollRectTween;

		// Token: 0x04024C57 RID: 150615
		[Token(Token = "0x4024C57")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnBackClick;

		// Token: 0x04024C58 RID: 150616
		[Token(Token = "0x4024C58")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnStoryRead;

		// Token: 0x04024C59 RID: 150617
		[Token(Token = "0x4024C59")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnStoryReadSuc;

		// Token: 0x04024C5A RID: 150618
		[Token(Token = "0x4024C5A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnStoryClicked;

		// Token: 0x04024C5B RID: 150619
		[Token(Token = "0x4024C5B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnUnlockClicked;

		// Token: 0x04024C5C RID: 150620
		[Token(Token = "0x4024C5C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnStoryUnlock;

		// Token: 0x04024C5D RID: 150621
		[Token(Token = "0x4024C5D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnStoryUnlocked;

		// Token: 0x04024C5E RID: 150622
		[Token(Token = "0x4024C5E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OnBlurShot;

		// Token: 0x04024C5F RID: 150623
		[Token(Token = "0x4024C5F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__OnScrollReset;

		// Token: 0x04024C60 RID: 150624
		[Token(Token = "0x4024C60")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020048D5 RID: 18645
		[Token(Token = "0x20048D5")]
		public struct StateRuntime
		{
			// Token: 0x04024C61 RID: 150625
			[Token(Token = "0x4024C61")]
			[FieldOffset(Offset = "0x0")]
			public float detailScrollPos;

			// Token: 0x04024C62 RID: 150626
			[Token(Token = "0x4024C62")]
			[FieldOffset(Offset = "0x4")]
			public bool backToStage;

			// Token: 0x04024C63 RID: 150627
			[Token(Token = "0x4024C63")]
			[FieldOffset(Offset = "0x8")]
			public StoryReviewPage.FastExit fastExit;
		}
	}
}
