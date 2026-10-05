using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007366 RID: 29542
	[Token(Token = "0x2007366")]
	public class Act42D0EffectDetailGroupView : UICustomAdapterLayout<Act42D0EffectItemViewModel, Act42D0EffectDetailItemView>, IHotfixable
	{
		// Token: 0x06029C65 RID: 171109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C65")]
		[Address(RVA = "0x25581D0", Offset = "0x2556DD0", VA = "0x1825581D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06029C66 RID: 171110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C66")]
		[Address(RVA = "0x2557FA0", Offset = "0x2556BA0", VA = "0x182557FA0")]
		public void Render(Act42D0EffectViewModel viewModel)
		{
		}

		// Token: 0x06029C67 RID: 171111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C67")]
		[Address(RVA = "0x2557EF0", Offset = "0x2556AF0", VA = "0x182557EF0")]
		public void OnClearEffect()
		{
		}

		// Token: 0x06029C68 RID: 171112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029C68")]
		[Address(RVA = "0x25584C0", Offset = "0x25570C0", VA = "0x1825584C0")]
		public Act42D0EffectDetailGroupView()
		{
		}

		// Token: 0x0403BCEA RID: 244970
		[Token(Token = "0x403BCEA")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act42D0EffectDetailItemView _itemViewPrefab;

		// Token: 0x0403BCEB RID: 244971
		[Token(Token = "0x403BCEB")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private float _showHideDuration;

		// Token: 0x0403BCEC RID: 244972
		[Token(Token = "0x403BCEC")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		private float _moveDuration;

		// Token: 0x0403BCED RID: 244973
		[Token(Token = "0x403BCED")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Rect _padding;

		// Token: 0x0403BCEE RID: 244974
		[Token(Token = "0x403BCEE")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private float _spacing;

		// Token: 0x0403BCEF RID: 244975
		[Token(Token = "0x403BCEF")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private RectTransform _viewPort;

		// Token: 0x0403BCF0 RID: 244976
		[Token(Token = "0x403BCF0")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x0403BCF1 RID: 244977
		[Token(Token = "0x403BCF1")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private CanvasGroup _noInfoCanvasGroup;

		// Token: 0x0403BCF2 RID: 244978
		[Token(Token = "0x403BCF2")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private CanvasGroup _detailCanvasGroup;

		// Token: 0x0403BCF3 RID: 244979
		[Token(Token = "0x403BCF3")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isInited;

		// Token: 0x0403BCF4 RID: 244980
		[Token(Token = "0x403BCF4")]
		[FieldOffset(Offset = "0xC8")]
		private Act42D0EffectViewModel m_cachedViewModel;

		// Token: 0x0403BCF5 RID: 244981
		[Token(Token = "0x403BCF5")]
		[FieldOffset(Offset = "0xD0")]
		private Act42D0EffectDetailGroupView.InnerLayouter m_layouter;

		// Token: 0x0403BCF6 RID: 244982
		[Token(Token = "0x403BCF6")]
		[FieldOffset(Offset = "0xD8")]
		private Act42D0EffectDetailGroupView.InnerAdapter m_adapter;

		// Token: 0x0403BCF7 RID: 244983
		[Token(Token = "0x403BCF7")]
		[FieldOffset(Offset = "0xE0")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0403BCF8 RID: 244984
		[Token(Token = "0x403BCF8")]
		[FieldOffset(Offset = "0xF0")]
		private FadeSwitchTween m_noInfoFadeTween;

		// Token: 0x0403BCF9 RID: 244985
		[Token(Token = "0x403BCF9")]
		[FieldOffset(Offset = "0xF8")]
		private Act42D0EffectDetailGroupView.GroupFadeSwitchTween m_detailGroupFadeTween;

		// Token: 0x0403BCFA RID: 244986
		[Token(Token = "0x403BCFA")]
		[FieldOffset(Offset = "0x100")]
		private int m_cachedSequenceNum;

		// Token: 0x0403BCFB RID: 244987
		[Token(Token = "0x403BCFB")]
		[FieldOffset(Offset = "0x104")]
		private bool m_cachedNeedReset;

		// Token: 0x0403BCFC RID: 244988
		[Token(Token = "0x403BCFC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403BCFD RID: 244989
		[Token(Token = "0x403BCFD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0403BCFE RID: 244990
		[Token(Token = "0x403BCFE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClearEffect;

		// Token: 0x0403BCFF RID: 244991
		[Token(Token = "0x403BCFF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007367 RID: 29543
		[Token(Token = "0x2007367")]
		private class InnerAdapter : UICustomAdapterLayout<Act42D0EffectItemViewModel, Act42D0EffectDetailItemView>.Adapter
		{
			// Token: 0x06029C69 RID: 171113 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C69")]
			[Address(RVA = "0x25655C0", Offset = "0x25641C0", VA = "0x1825655C0")]
			public InnerAdapter(Act42D0EffectDetailGroupView closure)
			{
			}

			// Token: 0x06029C6A RID: 171114 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029C6A")]
			[Address(RVA = "0x25653D0", Offset = "0x2563FD0", VA = "0x1825653D0", Slot = "4")]
			public override IList<Act42D0EffectItemViewModel> GetData()
			{
				return null;
			}

			// Token: 0x06029C6B RID: 171115 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029C6B")]
			[Address(RVA = "0x2565450", Offset = "0x2564050", VA = "0x182565450", Slot = "5")]
			public override string GetId(Act42D0EffectItemViewModel data)
			{
				return null;
			}

			// Token: 0x06029C6C RID: 171116 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029C6C")]
			[Address(RVA = "0x25652F0", Offset = "0x2563EF0", VA = "0x1825652F0", Slot = "6")]
			public override Act42D0EffectDetailItemView CreateInst(Act42D0EffectItemViewModel data, RectTransform parent)
			{
				return null;
			}

			// Token: 0x06029C6D RID: 171117 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C6D")]
			[Address(RVA = "0x2565510", Offset = "0x2564110", VA = "0x182565510", Slot = "7")]
			public override void UpdateView(Act42D0EffectDetailItemView view, Act42D0EffectItemViewModel data)
			{
			}

			// Token: 0x0403BD00 RID: 244992
			[Token(Token = "0x403BD00")]
			[FieldOffset(Offset = "0x20")]
			private Act42D0EffectDetailGroupView m_closure;

			// Token: 0x0403BD01 RID: 244993
			[Token(Token = "0x403BD01")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403BD02 RID: 244994
			[Token(Token = "0x403BD02")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetData;

			// Token: 0x0403BD03 RID: 244995
			[Token(Token = "0x403BD03")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetId;

			// Token: 0x0403BD04 RID: 244996
			[Token(Token = "0x403BD04")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_CreateInst;

			// Token: 0x0403BD05 RID: 244997
			[Token(Token = "0x403BD05")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_UpdateView;
		}

		// Token: 0x02007368 RID: 29544
		[Token(Token = "0x2007368")]
		private class InnerLayouter : UICustomSingleOrientationLayouter<Act42D0EffectItemViewModel, Act42D0EffectDetailItemView>
		{
			// Token: 0x06029C6E RID: 171118 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C6E")]
			[Address(RVA = "0x2566DB0", Offset = "0x25659B0", VA = "0x182566DB0")]
			public InnerLayouter(Act42D0EffectDetailGroupView closure)
			{
			}

			// Token: 0x06029C6F RID: 171119 RVA: 0x000D68A8 File Offset: 0x000D4AA8
			[Token(Token = "0x6029C6F")]
			[Address(RVA = "0x2565650", Offset = "0x2564250", VA = "0x182565650", Slot = "6")]
			protected override int DataComparison(Act42D0EffectItemViewModel lhs, Act42D0EffectItemViewModel rhs)
			{
				return 0;
			}

			// Token: 0x06029C70 RID: 171120 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C70")]
			[Address(RVA = "0x2565980", Offset = "0x2564580", VA = "0x182565980", Slot = "7")]
			protected override void LayoutTransitionImpl()
			{
			}

			// Token: 0x06029C71 RID: 171121 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C71")]
			[Address(RVA = "0x25656F0", Offset = "0x25642F0", VA = "0x1825656F0", Slot = "8")]
			protected override void LayoutImmediatelyImpl()
			{
			}

			// Token: 0x06029C72 RID: 171122 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C72")]
			[Address(RVA = "0x2566A70", Offset = "0x2565670", VA = "0x182566A70")]
			private void _TransitionRemoved(UICustomAdapterLayout<Act42D0EffectItemViewModel, Act42D0EffectDetailItemView>.Layouter.LayoutElement ele, bool needReset)
			{
			}

			// Token: 0x06029C73 RID: 171123 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C73")]
			[Address(RVA = "0x2566510", Offset = "0x2565110", VA = "0x182566510")]
			private void _TransitionNewlyAdded(UICustomAdapterLayout<Act42D0EffectItemViewModel, Act42D0EffectDetailItemView>.Layouter.LayoutElement ele, UICustomSingleOrientationLayouter<Act42D0EffectItemViewModel, Act42D0EffectDetailItemView>.LayoutMeta meta, RectTransform rectTrans, bool needReset)
			{
			}

			// Token: 0x06029C74 RID: 171124 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C74")]
			[Address(RVA = "0x2565CC0", Offset = "0x25648C0", VA = "0x182565CC0")]
			private void _FocusNewlyAdded(UICustomSingleOrientationLayouter<Act42D0EffectItemViewModel, Act42D0EffectDetailItemView>.LayoutMeta meta, RectTransform rectTrans)
			{
			}

			// Token: 0x06029C75 RID: 171125 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C75")]
			[Address(RVA = "0x2566210", Offset = "0x2564E10", VA = "0x182566210")]
			private void _TransitionMove(UICustomSingleOrientationLayouter<Act42D0EffectItemViewModel, Act42D0EffectDetailItemView>.LayoutMeta meta, RectTransform rectTrans, bool needReset)
			{
			}

			// Token: 0x0403BD06 RID: 244998
			[Token(Token = "0x403BD06")]
			[FieldOffset(Offset = "0x70")]
			private Act42D0EffectDetailGroupView m_closure;

			// Token: 0x0403BD07 RID: 244999
			[Token(Token = "0x403BD07")]
			[FieldOffset(Offset = "0x78")]
			private int m_cachedSequenceNum;

			// Token: 0x0403BD08 RID: 245000
			[Token(Token = "0x403BD08")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403BD09 RID: 245001
			[Token(Token = "0x403BD09")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_DataComparison;

			// Token: 0x0403BD0A RID: 245002
			[Token(Token = "0x403BD0A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_LayoutTransitionImpl;

			// Token: 0x0403BD0B RID: 245003
			[Token(Token = "0x403BD0B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_LayoutImmediatelyImpl;

			// Token: 0x0403BD0C RID: 245004
			[Token(Token = "0x403BD0C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__TransitionRemoved;

			// Token: 0x0403BD0D RID: 245005
			[Token(Token = "0x403BD0D")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__TransitionNewlyAdded;

			// Token: 0x0403BD0E RID: 245006
			[Token(Token = "0x403BD0E")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__FocusNewlyAdded;

			// Token: 0x0403BD0F RID: 245007
			[Token(Token = "0x403BD0F")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__TransitionMove;
		}

		// Token: 0x0200736F RID: 29551
		[Token(Token = "0x200736F")]
		private class GroupFadeSwitchTween : UISwitchTween
		{
			// Token: 0x06029C81 RID: 171137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C81")]
			[Address(RVA = "0x2565270", Offset = "0x2563E70", VA = "0x182565270")]
			public GroupFadeSwitchTween(Act42D0EffectDetailGroupView closrue)
			{
			}

			// Token: 0x06029C82 RID: 171138 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029C82")]
			[Address(RVA = "0x25650E0", Offset = "0x2563CE0", VA = "0x1825650E0", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x06029C83 RID: 171139 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6029C83")]
			[Address(RVA = "0x2565020", Offset = "0x2563C20", VA = "0x182565020", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x06029C84 RID: 171140 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C84")]
			[Address(RVA = "0x2564FA0", Offset = "0x2563BA0", VA = "0x182564FA0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x06029C85 RID: 171141 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C85")]
			[Address(RVA = "0x2564F20", Offset = "0x2563B20", VA = "0x182564F20", Slot = "7")]
			protected override void BeforeHideEffect()
			{
			}

			// Token: 0x06029C86 RID: 171142 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C86")]
			[Address(RVA = "0x25651A0", Offset = "0x2563DA0", VA = "0x1825651A0", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x06029C87 RID: 171143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C87")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x06029C88 RID: 171144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C88")]
			[Address(RVA = "0x10A4B70", Offset = "0x10A3770", VA = "0x1810A4B70")]
			private void <>xLuaBaseProxy_BeforeHideEffect()
			{
			}

			// Token: 0x06029C89 RID: 171145 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6029C89")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x0403BD1D RID: 245021
			[Token(Token = "0x403BD1D")]
			[FieldOffset(Offset = "0x48")]
			private Act42D0EffectDetailGroupView m_closure;

			// Token: 0x0403BD1E RID: 245022
			[Token(Token = "0x403BD1E")]
			private const float ANIM_DURATION = 0.16f;

			// Token: 0x0403BD1F RID: 245023
			[Token(Token = "0x403BD1F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403BD20 RID: 245024
			[Token(Token = "0x403BD20")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x0403BD21 RID: 245025
			[Token(Token = "0x403BD21")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x0403BD22 RID: 245026
			[Token(Token = "0x403BD22")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x0403BD23 RID: 245027
			[Token(Token = "0x403BD23")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeHideEffect;

			// Token: 0x0403BD24 RID: 245028
			[Token(Token = "0x403BD24")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}
	}
}
