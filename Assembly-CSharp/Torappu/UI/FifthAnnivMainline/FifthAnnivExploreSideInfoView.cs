using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004F0E RID: 20238
	[Token(Token = "0x2004F0E")]
	public class FifthAnnivExploreSideInfoView : DataBinder<FifthAnnivExploreProperty>, IHotfixable
	{
		// Token: 0x0601E2A1 RID: 123553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2A1")]
		[Address(RVA = "0x17D81A0", Offset = "0x17D6DA0", VA = "0x1817D81A0", Slot = "7")]
		public override void OnValueChanged(FifthAnnivExploreProperty property)
		{
		}

		// Token: 0x0601E2A2 RID: 123554 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2A2")]
		[Address(RVA = "0x17D8640", Offset = "0x17D7240", VA = "0x1817D8640")]
		private void _OnBeforeStateTransition(object arg)
		{
		}

		// Token: 0x0601E2A3 RID: 123555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2A3")]
		[Address(RVA = "0x17D8790", Offset = "0x17D7390", VA = "0x1817D8790")]
		private void _OnStateChanged(object arg)
		{
		}

		// Token: 0x0601E2A4 RID: 123556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2A4")]
		[Address(RVA = "0x17D8A10", Offset = "0x17D7610", VA = "0x1817D8A10")]
		private void _SetViewActive()
		{
		}

		// Token: 0x0601E2A5 RID: 123557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2A5")]
		[Address(RVA = "0x17D8280", Offset = "0x17D6E80", VA = "0x1817D8280")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601E2A6 RID: 123558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E2A6")]
		[Address(RVA = "0x17D8BE0", Offset = "0x17D77E0", VA = "0x1817D8BE0")]
		public FifthAnnivExploreSideInfoView()
		{
		}

		// Token: 0x0402828A RID: 164490
		[Token(Token = "0x402828A")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Type[] STATES_WITH_SIMPLE_VIEW;

		// Token: 0x0402828B RID: 164491
		[Token(Token = "0x402828B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private FifthAnnivExploreSideInfoExpandSubView _expandSubView;

		// Token: 0x0402828C RID: 164492
		[Token(Token = "0x402828C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private FifthAnnivExploreSideInfoSimpleSubView _simpleSubView;

		// Token: 0x0402828D RID: 164493
		[Token(Token = "0x402828D")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _fadeDuration;

		// Token: 0x0402828E RID: 164494
		[Token(Token = "0x402828E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x0402828F RID: 164495
		[Token(Token = "0x402828F")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x04028290 RID: 164496
		[Token(Token = "0x4028290")]
		[FieldOffset(Offset = "0x50")]
		private UIPageFinder m_pageFinder;

		// Token: 0x04028291 RID: 164497
		[Token(Token = "0x4028291")]
		[FieldOffset(Offset = "0x60")]
		private AnimationSwitchTween m_switchTween;

		// Token: 0x04028292 RID: 164498
		[Token(Token = "0x4028292")]
		[FieldOffset(Offset = "0x68")]
		private FifthAnnivExploreViewModel m_cachedViewModel;

		// Token: 0x04028293 RID: 164499
		[Token(Token = "0x4028293")]
		[FieldOffset(Offset = "0x70")]
		private StateEngine m_bindStateEngine;

		// Token: 0x04028294 RID: 164500
		[Token(Token = "0x4028294")]
		[FieldOffset(Offset = "0x78")]
		private FifthAnnivExploreSideInfoView.StateTransitionParam m_currTransParam;

		// Token: 0x04028295 RID: 164501
		[Token(Token = "0x4028295")]
		[FieldOffset(Offset = "0x80")]
		private FifthAnnivExploreSideInfoView.ViewType m_cachedViewType;

		// Token: 0x04028296 RID: 164502
		[Token(Token = "0x4028296")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04028297 RID: 164503
		[Token(Token = "0x4028297")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnBeforeStateTransition;

		// Token: 0x04028298 RID: 164504
		[Token(Token = "0x4028298")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnStateChanged;

		// Token: 0x04028299 RID: 164505
		[Token(Token = "0x4028299")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetViewActive;

		// Token: 0x0402829A RID: 164506
		[Token(Token = "0x402829A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402829B RID: 164507
		[Token(Token = "0x402829B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004F0F RID: 20239
		[Token(Token = "0x2004F0F")]
		private enum ViewType
		{
			// Token: 0x0402829D RID: 164509
			[Token(Token = "0x402829D")]
			VIEW_EXPAND,
			// Token: 0x0402829E RID: 164510
			[Token(Token = "0x402829E")]
			VIEW_SIMPLE
		}

		// Token: 0x02004F10 RID: 20240
		[Token(Token = "0x2004F10")]
		public class StateTransitionParam
		{
			// Token: 0x0601E2A8 RID: 123560 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601E2A8")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StateTransitionParam()
			{
			}

			// Token: 0x0402829F RID: 164511
			[Token(Token = "0x402829F")]
			[FieldOffset(Offset = "0x10")]
			public Type transitionDestType;
		}
	}
}
