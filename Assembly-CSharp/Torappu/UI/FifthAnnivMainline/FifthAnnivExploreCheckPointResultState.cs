using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004E98 RID: 20120
	[Token(Token = "0x2004E98")]
	public class FifthAnnivExploreCheckPointResultState : PopupFadeState, IHotfixable
	{
		// Token: 0x0601E040 RID: 122944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E040")]
		[Address(RVA = "0x17B4570", Offset = "0x17B3170", VA = "0x1817B4570")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E041 RID: 122945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E041")]
		[Address(RVA = "0x17B4370", Offset = "0x17B2F70", VA = "0x1817B4370", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601E042 RID: 122946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601E042")]
		[Address(RVA = "0x17B4310", Offset = "0x17B2F10", VA = "0x1817B4310", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601E043 RID: 122947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E043")]
		[Address(RVA = "0x17B4980", Offset = "0x17B3580", VA = "0x1817B4980")]
		private void _OnNextBtnClick()
		{
		}

		// Token: 0x0601E044 RID: 122948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E044")]
		[Address(RVA = "0x17B4740", Offset = "0x17B3340", VA = "0x1817B4740")]
		private void _OnConfirmPassTarget()
		{
		}

		// Token: 0x0601E045 RID: 122949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E045")]
		[Address(RVA = "0x17B4B50", Offset = "0x17B3750", VA = "0x1817B4B50")]
		private void _OnSettleGame()
		{
		}

		// Token: 0x0601E046 RID: 122950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E046")]
		[Address(RVA = "0x17B4D90", Offset = "0x17B3990", VA = "0x1817B4D90")]
		public FifthAnnivExploreCheckPointResultState()
		{
		}

		// Token: 0x0601E049 RID: 122953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E049")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04027E62 RID: 163426
		[Token(Token = "0x4027E62")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private FifthAnnivExploreCheckPointResultView _view;

		// Token: 0x04027E63 RID: 163427
		[Token(Token = "0x4027E63")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIBlendRTImage _blurImg;

		// Token: 0x04027E64 RID: 163428
		[Token(Token = "0x4027E64")]
		[FieldOffset(Offset = "0x80")]
		private FifthAnnivExploreCheckPointResultViewModel m_viewModel;

		// Token: 0x04027E65 RID: 163429
		[Token(Token = "0x4027E65")]
		[FieldOffset(Offset = "0x88")]
		private bool m_isInited;

		// Token: 0x04027E66 RID: 163430
		[Token(Token = "0x4027E66")]
		[FieldOffset(Offset = "0x90")]
		private FifthAnnivExploreMapController m_mapController;

		// Token: 0x04027E67 RID: 163431
		[Token(Token = "0x4027E67")]
		[FieldOffset(Offset = "0x98")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04027E68 RID: 163432
		[Token(Token = "0x4027E68")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04027E69 RID: 163433
		[Token(Token = "0x4027E69")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04027E6A RID: 163434
		[Token(Token = "0x4027E6A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04027E6B RID: 163435
		[Token(Token = "0x4027E6B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnNextBtnClick;

		// Token: 0x04027E6C RID: 163436
		[Token(Token = "0x4027E6C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnConfirmPassTarget;

		// Token: 0x04027E6D RID: 163437
		[Token(Token = "0x4027E6D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnSettleGame;

		// Token: 0x04027E6E RID: 163438
		[Token(Token = "0x4027E6E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
