using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtGallery
{
	// Token: 0x020065F4 RID: 26100
	[Token(Token = "0x20065F4")]
	public class ArtGalleryDisplayListTypeDialog : UICompDialog<ArtGalleryDisplayTypeDialogCommonInput>, ICompDialogCallBack
	{
		// Token: 0x06025823 RID: 153635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025823")]
		[Address(RVA = "0x207F5E0", Offset = "0x207E1E0", VA = "0x18207F5E0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x06025824 RID: 153636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025824")]
		[Address(RVA = "0x207F650", Offset = "0x207E250", VA = "0x18207F650", Slot = "18")]
		protected override void OnRender(ArtGalleryDisplayTypeDialogCommonInput input)
		{
		}

		// Token: 0x06025825 RID: 153637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025825")]
		[Address(RVA = "0x207F540", Offset = "0x207E140", VA = "0x18207F540")]
		public void OnClearItemSelect()
		{
		}

		// Token: 0x06025826 RID: 153638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025826")]
		[Address(RVA = "0x207FB90", Offset = "0x207E790", VA = "0x18207FB90")]
		private void _InitTabPagerModel()
		{
		}

		// Token: 0x06025827 RID: 153639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025827")]
		[Address(RVA = "0x2080580", Offset = "0x207F180", VA = "0x182080580")]
		private void _RefreshItemSelectModel(ArtGalleryTabType currTab, ArtGalleryDisplayViewModel.ArtGalleryItemSelectParam selectParam)
		{
		}

		// Token: 0x06025828 RID: 153640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025828")]
		[Address(RVA = "0x2080450", Offset = "0x207F050", VA = "0x182080450")]
		private void _RefreshItemFocusModel(ArtGalleryTabType currTab, ArtGalleryDisplayViewModel.ArtGalleryFocusParam focusParam)
		{
		}

		// Token: 0x06025829 RID: 153641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025829")]
		[Address(RVA = "0x2080710", Offset = "0x207F310", VA = "0x182080710")]
		private void _RefreshTabPagerModel(ArtGalleryDisplayViewModel.ArtGalleryShuffleRule curShuffleRule)
		{
		}

		// Token: 0x0602582A RID: 153642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602582A")]
		[Address(RVA = "0x20802B0", Offset = "0x207EEB0", VA = "0x1820802B0")]
		private void _NotifyTabPagerUpdate(ArtGalleryTabType currTab, bool fastMode)
		{
		}

		// Token: 0x0602582B RID: 153643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602582B")]
		[Address(RVA = "0x207F4B0", Offset = "0x207E0B0", VA = "0x18207F4B0", Slot = "19")]
		public void HandleCallBack(int instId, ValueBundle output)
		{
		}

		// Token: 0x0602582C RID: 153644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602582C")]
		[Address(RVA = "0x2080810", Offset = "0x207F410", VA = "0x182080810")]
		public ArtGalleryDisplayListTypeDialog()
		{
		}

		// Token: 0x0602582D RID: 153645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602582D")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x04034ABA RID: 215738
		[Token(Token = "0x4034ABA")]
		private const ArtGalleryDisplayType DISPLAY_TYPE_LIST = ArtGalleryDisplayType.LIST;

		// Token: 0x04034ABB RID: 215739
		[Token(Token = "0x4034ABB")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UITabPager _tabPager;

		// Token: 0x04034ABC RID: 215740
		[Token(Token = "0x4034ABC")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ArtGalleryDisplayTabItemView[] _tabItemList;

		// Token: 0x04034ABD RID: 215741
		[Token(Token = "0x4034ABD")]
		[FieldOffset(Offset = "0x80")]
		private ListDict<string, ArtGalleryDisplayListTypeDialog.TabModelBase> m_tabPageModels;

		// Token: 0x04034ABE RID: 215742
		[Token(Token = "0x4034ABE")]
		[FieldOffset(Offset = "0x88")]
		private UITabPager.Core m_tabPagerCore;

		// Token: 0x04034ABF RID: 215743
		[Token(Token = "0x4034ABF")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isFastMode;

		// Token: 0x04034AC0 RID: 215744
		[Token(Token = "0x4034AC0")]
		[FieldOffset(Offset = "0x98")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04034AC1 RID: 215745
		[Token(Token = "0x4034AC1")]
		private const string TAB_HOME_THEME = "tab_home_theme";

		// Token: 0x04034AC2 RID: 215746
		[Token(Token = "0x4034AC2")]
		private const string TAB_HOME_BACKGROUND = "tab_home_background";

		// Token: 0x04034AC3 RID: 215747
		[Token(Token = "0x4034AC3")]
		private const string TAB_NAME_CARD = "tab_name_card";

		// Token: 0x04034AC4 RID: 215748
		[Token(Token = "0x4034AC4")]
		private const string TAB_AVATAR = "tab_avatar";

		// Token: 0x04034AC5 RID: 215749
		[Token(Token = "0x4034AC5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04034AC6 RID: 215750
		[Token(Token = "0x4034AC6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04034AC7 RID: 215751
		[Token(Token = "0x4034AC7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClearItemSelect;

		// Token: 0x04034AC8 RID: 215752
		[Token(Token = "0x4034AC8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitTabPagerModel;

		// Token: 0x04034AC9 RID: 215753
		[Token(Token = "0x4034AC9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RefreshItemSelectModel;

		// Token: 0x04034ACA RID: 215754
		[Token(Token = "0x4034ACA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RefreshItemFocusModel;

		// Token: 0x04034ACB RID: 215755
		[Token(Token = "0x4034ACB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshTabPagerModel;

		// Token: 0x04034ACC RID: 215756
		[Token(Token = "0x4034ACC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__NotifyTabPagerUpdate;

		// Token: 0x04034ACD RID: 215757
		[Token(Token = "0x4034ACD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_HandleCallBack;

		// Token: 0x04034ACE RID: 215758
		[Token(Token = "0x4034ACE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020065F5 RID: 26101
		[Token(Token = "0x20065F5")]
		private abstract class TabModelBase : UITabPager.TabPageViewModel
		{
			// Token: 0x1700589B RID: 22683
			// (get) Token: 0x0602582E RID: 153646
			[Token(Token = "0x1700589B")]
			public abstract ArtGalleryTabType tabType { [Token(Token = "0x602582E")] get; }

			// Token: 0x0602582F RID: 153647 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602582F")]
			[Address(RVA = "0x20881E0", Offset = "0x2086DE0", VA = "0x1820881E0", Slot = "4")]
			public override object GetDialogInput()
			{
				return null;
			}

			// Token: 0x06025830 RID: 153648 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025830")]
			[Address(RVA = "0x2088290", Offset = "0x2086E90", VA = "0x182088290")]
			protected TabModelBase()
			{
			}

			// Token: 0x06025831 RID: 153649 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025831")]
			[Address(RVA = "0x16071F0", Offset = "0x1605DF0", VA = "0x1816071F0")]
			private object <>xLuaBaseProxy_GetDialogInput()
			{
				return null;
			}

			// Token: 0x04034ACF RID: 215759
			[Token(Token = "0x4034ACF")]
			[FieldOffset(Offset = "0x30")]
			public ArtGalleryDisplayViewModel.ArtGalleryShuffleRule curShuffleRule;

			// Token: 0x04034AD0 RID: 215760
			[Token(Token = "0x4034AD0")]
			[FieldOffset(Offset = "0x38")]
			public ArtGalleryDisplayViewModel.ArtGalleryItemSelectParam curSelectParam;

			// Token: 0x04034AD1 RID: 215761
			[Token(Token = "0x4034AD1")]
			[FieldOffset(Offset = "0x48")]
			public ArtGalleryDisplayViewModel.ArtGalleryFocusParam curFocusParam;

			// Token: 0x04034AD2 RID: 215762
			[Token(Token = "0x4034AD2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GetDialogInput;

			// Token: 0x04034AD3 RID: 215763
			[Token(Token = "0x4034AD3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020065F6 RID: 26102
		[Token(Token = "0x20065F6")]
		private class TabHomeThemeModel : ArtGalleryDisplayListTypeDialog.TabModelBase
		{
			// Token: 0x1700589C RID: 22684
			// (get) Token: 0x06025832 RID: 153650 RVA: 0x000C8130 File Offset: 0x000C6330
			[Token(Token = "0x1700589C")]
			public override ArtGalleryTabType tabType
			{
				[Token(Token = "0x6025832")]
				[Address(RVA = "0x2088180", Offset = "0x2086D80", VA = "0x182088180", Slot = "5")]
				get
				{
					return ArtGalleryTabType.HOME_THEME;
				}
			}

			// Token: 0x06025833 RID: 153651 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025833")]
			[Address(RVA = "0x20880E0", Offset = "0x2086CE0", VA = "0x1820880E0")]
			public TabHomeThemeModel()
			{
			}

			// Token: 0x04034AD4 RID: 215764
			[Token(Token = "0x4034AD4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_tabType;

			// Token: 0x04034AD5 RID: 215765
			[Token(Token = "0x4034AD5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020065F7 RID: 26103
		[Token(Token = "0x20065F7")]
		private class TabHomeBackgroundModel : ArtGalleryDisplayListTypeDialog.TabModelBase
		{
			// Token: 0x1700589D RID: 22685
			// (get) Token: 0x06025834 RID: 153652 RVA: 0x000C8148 File Offset: 0x000C6348
			[Token(Token = "0x1700589D")]
			public override ArtGalleryTabType tabType
			{
				[Token(Token = "0x6025834")]
				[Address(RVA = "0x2088080", Offset = "0x2086C80", VA = "0x182088080", Slot = "5")]
				get
				{
					return ArtGalleryTabType.HOME_THEME;
				}
			}

			// Token: 0x06025835 RID: 153653 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025835")]
			[Address(RVA = "0x2087FE0", Offset = "0x2086BE0", VA = "0x182087FE0")]
			public TabHomeBackgroundModel()
			{
			}

			// Token: 0x04034AD6 RID: 215766
			[Token(Token = "0x4034AD6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_tabType;

			// Token: 0x04034AD7 RID: 215767
			[Token(Token = "0x4034AD7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020065F8 RID: 26104
		[Token(Token = "0x20065F8")]
		private class TabNameCardModel : ArtGalleryDisplayListTypeDialog.TabModelBase
		{
			// Token: 0x1700589E RID: 22686
			// (get) Token: 0x06025836 RID: 153654 RVA: 0x000C8160 File Offset: 0x000C6360
			[Token(Token = "0x1700589E")]
			public override ArtGalleryTabType tabType
			{
				[Token(Token = "0x6025836")]
				[Address(RVA = "0x2088390", Offset = "0x2086F90", VA = "0x182088390", Slot = "5")]
				get
				{
					return ArtGalleryTabType.HOME_THEME;
				}
			}

			// Token: 0x06025837 RID: 153655 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025837")]
			[Address(RVA = "0x20882F0", Offset = "0x2086EF0", VA = "0x1820882F0")]
			public TabNameCardModel()
			{
			}

			// Token: 0x04034AD8 RID: 215768
			[Token(Token = "0x4034AD8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_tabType;

			// Token: 0x04034AD9 RID: 215769
			[Token(Token = "0x4034AD9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020065F9 RID: 26105
		[Token(Token = "0x20065F9")]
		private class TabAvatarModel : ArtGalleryDisplayListTypeDialog.TabModelBase
		{
			// Token: 0x1700589F RID: 22687
			// (get) Token: 0x06025838 RID: 153656 RVA: 0x000C8178 File Offset: 0x000C6378
			[Token(Token = "0x1700589F")]
			public override ArtGalleryTabType tabType
			{
				[Token(Token = "0x6025838")]
				[Address(RVA = "0x2087D70", Offset = "0x2086970", VA = "0x182087D70", Slot = "5")]
				get
				{
					return ArtGalleryTabType.HOME_THEME;
				}
			}

			// Token: 0x06025839 RID: 153657 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025839")]
			[Address(RVA = "0x2087CD0", Offset = "0x20868D0", VA = "0x182087CD0")]
			public TabAvatarModel()
			{
			}

			// Token: 0x04034ADA RID: 215770
			[Token(Token = "0x4034ADA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_tabType;

			// Token: 0x04034ADB RID: 215771
			[Token(Token = "0x4034ADB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020065FA RID: 26106
		[Token(Token = "0x20065FA")]
		private class TabDataSource : UITabPager.TabDataSource
		{
			// Token: 0x0602583A RID: 153658 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602583A")]
			[Address(RVA = "0x2087F60", Offset = "0x2086B60", VA = "0x182087F60")]
			public TabDataSource(ArtGalleryDisplayListTypeDialog closure)
			{
			}

			// Token: 0x0602583B RID: 153659 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602583B")]
			[Address(RVA = "0x2087EA0", Offset = "0x2086AA0", VA = "0x182087EA0", Slot = "5")]
			public override UITabPager.TabPageViewModel GetTab(int index)
			{
				return null;
			}

			// Token: 0x0602583C RID: 153660 RVA: 0x000C8190 File Offset: 0x000C6390
			[Token(Token = "0x602583C")]
			[Address(RVA = "0x2087DD0", Offset = "0x20869D0", VA = "0x182087DD0", Slot = "4")]
			public override int GetTabCount()
			{
				return 0;
			}

			// Token: 0x04034ADC RID: 215772
			[Token(Token = "0x4034ADC")]
			[FieldOffset(Offset = "0x10")]
			private ArtGalleryDisplayListTypeDialog m_closure;

			// Token: 0x04034ADD RID: 215773
			[Token(Token = "0x4034ADD")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04034ADE RID: 215774
			[Token(Token = "0x4034ADE")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GetTab;

			// Token: 0x04034ADF RID: 215775
			[Token(Token = "0x4034ADF")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GetTabCount;
		}
	}
}
