using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.CharacterInfo
{
	// Token: 0x02005F6F RID: 24431
	[Token(Token = "0x2005F6F")]
	public class CharacterLvlupWheelPickerView : MonoBehaviour, IHotfixable
	{
		// Token: 0x060235D8 RID: 144856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235D8")]
		[Address(RVA = "0x1E0E350", Offset = "0x1E0CF50", VA = "0x181E0E350")]
		public void SetActionDelegate(CharacterLvlupWheelPickerView.ActionDelegate actionDelegate)
		{
		}

		// Token: 0x060235D9 RID: 144857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235D9")]
		[Address(RVA = "0x1E0E150", Offset = "0x1E0CD50", VA = "0x181E0E150")]
		public void Render(CharacterLvlupWheelViewModel viewModel)
		{
		}

		// Token: 0x060235DA RID: 144858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235DA")]
		[Address(RVA = "0x1E0E3D0", Offset = "0x1E0CFD0", VA = "0x181E0E3D0")]
		private void Update()
		{
		}

		// Token: 0x060235DB RID: 144859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235DB")]
		[Address(RVA = "0x1E0E5A0", Offset = "0x1E0D1A0", VA = "0x181E0E5A0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060235DC RID: 144860 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235DC")]
		[Address(RVA = "0x1E0E9B0", Offset = "0x1E0D5B0", VA = "0x181E0E9B0")]
		private void _OnScrollPagerStateChanged(InertiaScrollViewPager.State state)
		{
		}

		// Token: 0x060235DD RID: 144861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235DD")]
		[Address(RVA = "0x1E0E920", Offset = "0x1E0D520", VA = "0x181E0E920")]
		private void _OnPageChangeEnd(int itemIndex)
		{
		}

		// Token: 0x060235DE RID: 144862 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235DE")]
		[Address(RVA = "0x1E0E890", Offset = "0x1E0D490", VA = "0x181E0E890")]
		private void _OnItemClicked(int pageIndex)
		{
		}

		// Token: 0x060235DF RID: 144863 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235DF")]
		[Address(RVA = "0x1E0EAF0", Offset = "0x1E0D6F0", VA = "0x181E0EAF0")]
		private void _ResetScrollIfNecessary(CharacterLvlupWheelViewModel viewModel)
		{
		}

		// Token: 0x060235E0 RID: 144864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60235E0")]
		[Address(RVA = "0x1E0EBE0", Offset = "0x1E0D7E0", VA = "0x181E0EBE0")]
		public CharacterLvlupWheelPickerView()
		{
		}

		// Token: 0x04030D70 RID: 200048
		[Token(Token = "0x4030D70")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private InertiaScrollViewPager _wheelPager;

		// Token: 0x04030D71 RID: 200049
		[Token(Token = "0x4030D71")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIRecycleLayoutGroup _content;

		// Token: 0x04030D72 RID: 200050
		[Token(Token = "0x4030D72")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CharacterLvlupWheelItemView _itemPrefab;

		// Token: 0x04030D73 RID: 200051
		[Token(Token = "0x4030D73")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Color")]
		private Color _colorAttainableNum;

		// Token: 0x04030D74 RID: 200052
		[Token(Token = "0x4030D74")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Color")]
		private Color _colorAttainableShadow;

		// Token: 0x04030D75 RID: 200053
		[Token(Token = "0x4030D75")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Color")]
		private Color _colorAttainableNumSelected;

		// Token: 0x04030D76 RID: 200054
		[Token(Token = "0x4030D76")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Color")]
		private Color _colorAttainableShadowSelected;

		// Token: 0x04030D77 RID: 200055
		[Token(Token = "0x4030D77")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Color")]
		private Color _colorUnattainableNum;

		// Token: 0x04030D78 RID: 200056
		[Token(Token = "0x4030D78")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Color")]
		private Color _colorUnattainableShadow;

		// Token: 0x04030D79 RID: 200057
		[Token(Token = "0x4030D79")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Color")]
		private Color _colorUnattainableNumSelected;

		// Token: 0x04030D7A RID: 200058
		[Token(Token = "0x4030D7A")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Color")]
		private Color _colorUnattainableShadowSelected;

		// Token: 0x04030D7B RID: 200059
		[Token(Token = "0x4030D7B")]
		[FieldOffset(Offset = "0xB0")]
		private bool m_isInited;

		// Token: 0x04030D7C RID: 200060
		[Token(Token = "0x4030D7C")]
		[FieldOffset(Offset = "0xB8")]
		private CharacterLvlupWheelPickerView.PagerAdapter m_adapter;

		// Token: 0x04030D7D RID: 200061
		[Token(Token = "0x4030D7D")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isScrolling;

		// Token: 0x04030D7E RID: 200062
		[Token(Token = "0x4030D7E")]
		[FieldOffset(Offset = "0xC4")]
		private CharacterLvlupWheelItemView.ColorParam m_colorParam;

		// Token: 0x04030D7F RID: 200063
		[Token(Token = "0x4030D7F")]
		[FieldOffset(Offset = "0x148")]
		private CharacterLvlupWheelPickerView.ActionDelegate m_actionDelegate;

		// Token: 0x04030D80 RID: 200064
		[Token(Token = "0x4030D80")]
		[FieldOffset(Offset = "0x150")]
		private long m_dragContextID;

		// Token: 0x04030D81 RID: 200065
		[Token(Token = "0x4030D81")]
		[FieldOffset(Offset = "0x158")]
		private List<int> m_maxAttainableFrameList;

		// Token: 0x04030D82 RID: 200066
		[Token(Token = "0x4030D82")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetActionDelegate;

		// Token: 0x04030D83 RID: 200067
		[Token(Token = "0x4030D83")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04030D84 RID: 200068
		[Token(Token = "0x4030D84")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04030D85 RID: 200069
		[Token(Token = "0x4030D85")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04030D86 RID: 200070
		[Token(Token = "0x4030D86")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnScrollPagerStateChanged;

		// Token: 0x04030D87 RID: 200071
		[Token(Token = "0x4030D87")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnPageChangeEnd;

		// Token: 0x04030D88 RID: 200072
		[Token(Token = "0x4030D88")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnItemClicked;

		// Token: 0x04030D89 RID: 200073
		[Token(Token = "0x4030D89")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ResetScrollIfNecessary;

		// Token: 0x04030D8A RID: 200074
		[Token(Token = "0x4030D8A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005F70 RID: 24432
		[Token(Token = "0x2005F70")]
		public class ActionDelegate
		{
			// Token: 0x060235E1 RID: 144865 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60235E1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ActionDelegate()
			{
			}

			// Token: 0x04030D8B RID: 200075
			[Token(Token = "0x4030D8B")]
			[FieldOffset(Offset = "0x10")]
			public Action onBeginDragAction;

			// Token: 0x04030D8C RID: 200076
			[Token(Token = "0x4030D8C")]
			[FieldOffset(Offset = "0x18")]
			public Action<int> onScrollEnd;

			// Token: 0x04030D8D RID: 200077
			[Token(Token = "0x4030D8D")]
			[FieldOffset(Offset = "0x20")]
			public Action<int> onItemClicked;
		}

		// Token: 0x02005F71 RID: 24433
		[Token(Token = "0x2005F71")]
		private class PagerAdapter : UIRecycleLayoutAdapter
		{
			// Token: 0x060235E2 RID: 144866 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60235E2")]
			[Address(RVA = "0x1E10DE0", Offset = "0x1E0F9E0", VA = "0x181E10DE0")]
			public PagerAdapter(CharacterLvlupWheelPickerView closure)
			{
			}

			// Token: 0x060235E3 RID: 144867 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60235E3")]
			[Address(RVA = "0x1E108B0", Offset = "0x1E0F4B0", VA = "0x181E108B0")]
			public void RebuildListIfNeeded(CharacterLvlupWheelViewModel viewModel)
			{
			}

			// Token: 0x060235E4 RID: 144868 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60235E4")]
			[Address(RVA = "0x1E10620", Offset = "0x1E0F220", VA = "0x181E10620", Slot = "4")]
			public override IList<UIRecycleLayoutAdapter.IVirtualView> GenerateViewsForRebuild()
			{
				return null;
			}

			// Token: 0x060235E5 RID: 144869 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60235E5")]
			[Address(RVA = "0x1E10750", Offset = "0x1E0F350", VA = "0x181E10750")]
			public void NotifyFocusPage(float pageIndex)
			{
			}

			// Token: 0x04030D8E RID: 200078
			[Token(Token = "0x4030D8E")]
			[FieldOffset(Offset = "0x18")]
			private CharacterLvlupWheelPickerView m_closure;

			// Token: 0x04030D8F RID: 200079
			[Token(Token = "0x4030D8F")]
			[FieldOffset(Offset = "0x20")]
			private float m_focusPageIndex;

			// Token: 0x04030D90 RID: 200080
			[Token(Token = "0x4030D90")]
			[FieldOffset(Offset = "0x28")]
			private string m_curWidgetID;

			// Token: 0x04030D91 RID: 200081
			[Token(Token = "0x4030D91")]
			[FieldOffset(Offset = "0x30")]
			private List<CharacterLvlupWheelItemView.VirtualView> m_cells;

			// Token: 0x04030D92 RID: 200082
			[Token(Token = "0x4030D92")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04030D93 RID: 200083
			[Token(Token = "0x4030D93")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_RebuildListIfNeeded;

			// Token: 0x04030D94 RID: 200084
			[Token(Token = "0x4030D94")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateViewsForRebuild;

			// Token: 0x04030D95 RID: 200085
			[Token(Token = "0x4030D95")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_NotifyFocusPage;
		}
	}
}
