using System;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020077F7 RID: 30711
	[Token(Token = "0x20077F7")]
	public class Act1VHalfIdleRecruitTabListView : DataBinder<UITabPager.TabPageGroupProperty>
	{
		// Token: 0x0602B155 RID: 176469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B155")]
		[Address(RVA = "0x26E31D0", Offset = "0x26E1DD0", VA = "0x1826E31D0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602B156 RID: 176470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B156")]
		[Address(RVA = "0x26E2730", Offset = "0x26E1330", VA = "0x1826E2730", Slot = "7")]
		public override void OnValueChanged(UITabPager.TabPageGroupProperty property)
		{
		}

		// Token: 0x0602B157 RID: 176471 RVA: 0x000DAC40 File Offset: 0x000D8E40
		[Token(Token = "0x602B157")]
		[Address(RVA = "0x26E2DD0", Offset = "0x26E19D0", VA = "0x1826E2DD0")]
		private float _GetTabHeight(Act1VHalfIdleGachaPoolType poolType)
		{
			return 0f;
		}

		// Token: 0x0602B158 RID: 176472 RVA: 0x000DAC58 File Offset: 0x000D8E58
		[Token(Token = "0x602B158")]
		[Address(RVA = "0x26E2E60", Offset = "0x26E1A60", VA = "0x1826E2E60")]
		private float _GetTabPosition(string tabId)
		{
			return 0f;
		}

		// Token: 0x0602B159 RID: 176473 RVA: 0x000DAC70 File Offset: 0x000D8E70
		[Token(Token = "0x602B159")]
		[Address(RVA = "0x26E3030", Offset = "0x26E1C30", VA = "0x1826E3030")]
		private float _GetTotalHeight()
		{
			return 0f;
		}

		// Token: 0x0602B15A RID: 176474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B15A")]
		[Address(RVA = "0x26E2A50", Offset = "0x26E1650", VA = "0x1826E2A50")]
		private void _FocusOnTab(string tabId)
		{
		}

		// Token: 0x0602B15B RID: 176475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B15B")]
		[Address(RVA = "0x26E32F0", Offset = "0x26E1EF0", VA = "0x1826E32F0")]
		public Act1VHalfIdleRecruitTabListView()
		{
		}

		// Token: 0x0403E40E RID: 254990
		[Token(Token = "0x403E40E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SimpleLayoutContent _layoutTabGroup;

		// Token: 0x0403E40F RID: 254991
		[Token(Token = "0x403E40F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Focus")]
		private ScrollRect _scrollView;

		// Token: 0x0403E410 RID: 254992
		[Token(Token = "0x403E410")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Focus")]
		private RectTransform _scrollViewRect;

		// Token: 0x0403E411 RID: 254993
		[Token(Token = "0x403E411")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Focus")]
		private float _itemSpacing;

		// Token: 0x0403E412 RID: 254994
		[Token(Token = "0x403E412")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Group("Focus")]
		private float _paddingTop;

		// Token: 0x0403E413 RID: 254995
		[Token(Token = "0x403E413")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Focus")]
		private float _paddingBottom;

		// Token: 0x0403E414 RID: 254996
		[Token(Token = "0x403E414")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Group("Focus")]
		private float _focusDuration;

		// Token: 0x0403E415 RID: 254997
		[Token(Token = "0x403E415")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Focus")]
		private UILayoutDimensionListener _listener;

		// Token: 0x0403E416 RID: 254998
		[Token(Token = "0x403E416")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Focus")]
		private float[] _tabHeightConfig;

		// Token: 0x0403E417 RID: 254999
		[Token(Token = "0x403E417")]
		[FieldOffset(Offset = "0x58")]
		private UITabPager.TabPageGroupViewModel m_cachedViewModel;

		// Token: 0x0403E418 RID: 255000
		[Token(Token = "0x403E418")]
		[FieldOffset(Offset = "0x60")]
		private Act1VHalfIdleRecruitTabListView.Adapter m_adapter;

		// Token: 0x0403E419 RID: 255001
		[Token(Token = "0x403E419")]
		[FieldOffset(Offset = "0x68")]
		private bool m_inited;

		// Token: 0x0403E41A RID: 255002
		[Token(Token = "0x403E41A")]
		[FieldOffset(Offset = "0x6C")]
		private int m_cachedInitSeq;

		// Token: 0x0403E41B RID: 255003
		[Token(Token = "0x403E41B")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_focusTween;

		// Token: 0x0403E41C RID: 255004
		[Token(Token = "0x403E41C")]
		[FieldOffset(Offset = "0x78")]
		private string m_cachedSelectedTabId;

		// Token: 0x0403E41D RID: 255005
		[Token(Token = "0x403E41D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403E41E RID: 255006
		[Token(Token = "0x403E41E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403E41F RID: 255007
		[Token(Token = "0x403E41F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetTabHeight;

		// Token: 0x0403E420 RID: 255008
		[Token(Token = "0x403E420")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__GetTabPosition;

		// Token: 0x0403E421 RID: 255009
		[Token(Token = "0x403E421")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetTotalHeight;

		// Token: 0x0403E422 RID: 255010
		[Token(Token = "0x403E422")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FocusOnTab;

		// Token: 0x0403E423 RID: 255011
		[Token(Token = "0x403E423")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020077F8 RID: 30712
		[Token(Token = "0x20077F8")]
		private class Adapter : SimpleLayoutAdapter
		{
			// Token: 0x0602B15C RID: 176476 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B15C")]
			[Address(RVA = "0x26E9AB0", Offset = "0x26E86B0", VA = "0x1826E9AB0")]
			public Adapter(Act1VHalfIdleRecruitTabListView closure)
			{
			}

			// Token: 0x170064CF RID: 25807
			// (get) Token: 0x0602B15D RID: 176477 RVA: 0x000DAC88 File Offset: 0x000D8E88
			[Token(Token = "0x170064CF")]
			public override int count
			{
				[Token(Token = "0x602B15D")]
				[Address(RVA = "0x26E9F30", Offset = "0x26E8B30", VA = "0x1826E9F30", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0602B15E RID: 176478 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602B15E")]
			[Address(RVA = "0x26E8D50", Offset = "0x26E7950", VA = "0x1826E8D50", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x0403E424 RID: 255012
			[Token(Token = "0x403E424")]
			[FieldOffset(Offset = "0x20")]
			private Act1VHalfIdleRecruitTabListView m_closure;

			// Token: 0x0403E425 RID: 255013
			[Token(Token = "0x403E425")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0403E426 RID: 255014
			[Token(Token = "0x403E426")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x0403E427 RID: 255015
			[Token(Token = "0x403E427")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;
		}

		// Token: 0x020077F9 RID: 30713
		[Token(Token = "0x20077F9")]
		private class PostLayoutAction : UILayoutDimensionListener.IAction
		{
			// Token: 0x0602B15F RID: 176479 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B15F")]
			[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
			public PostLayoutAction(Act1VHalfIdleRecruitTabListView closure, string focusTabId)
			{
			}

			// Token: 0x0602B160 RID: 176480 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602B160")]
			[Address(RVA = "0x26EC240", Offset = "0x26EAE40", VA = "0x1826EC240", Slot = "4")]
			public void DoAction()
			{
			}

			// Token: 0x0403E428 RID: 255016
			[Token(Token = "0x403E428")]
			[FieldOffset(Offset = "0x10")]
			private Act1VHalfIdleRecruitTabListView m_closure;

			// Token: 0x0403E429 RID: 255017
			[Token(Token = "0x403E429")]
			[FieldOffset(Offset = "0x18")]
			private string m_focusTabId;
		}
	}
}
