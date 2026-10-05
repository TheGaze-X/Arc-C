using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building.DIY.UI
{
	// Token: 0x020019FB RID: 6651
	[Token(Token = "0x20019FB")]
	public class DIYSortMethodViewModel : IHotfixable
	{
		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x0600A6CC RID: 42700 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A6CD RID: 42701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700133A")]
		public ListDict<string, long> recentThemes
		{
			[Token(Token = "0x600A6CC")]
			[Address(RVA = "0x321F310", Offset = "0x321DF10", VA = "0x18321F310")]
			get
			{
				return null;
			}
			[Token(Token = "0x600A6CD")]
			[Address(RVA = "0x321F410", Offset = "0x321E010", VA = "0x18321F410")]
			set
			{
			}
		}

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x0600A6CE RID: 42702 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A6CF RID: 42703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700133B")]
		public ListDict<string, long> recentFurnitures
		{
			[Token(Token = "0x600A6CE")]
			[Address(RVA = "0x321F2A0", Offset = "0x321DEA0", VA = "0x18321F2A0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600A6CF")]
			[Address(RVA = "0x321F380", Offset = "0x321DF80", VA = "0x18321F380")]
			set
			{
			}
		}

		// Token: 0x0600A6D0 RID: 42704 RVA: 0x00040830 File Offset: 0x0003EA30
		[Token(Token = "0x600A6D0")]
		[Address(RVA = "0x321D6E0", Offset = "0x321C2E0", VA = "0x18321D6E0")]
		public bool UpdateSortMethod(DIYListViewStateBean.DIYListViewConfig config, DIYViewListModel.UIExpandListState expandState)
		{
			return default(bool);
		}

		// Token: 0x0600A6D1 RID: 42705 RVA: 0x00040848 File Offset: 0x0003EA48
		[Token(Token = "0x600A6D1")]
		[Address(RVA = "0x321D410", Offset = "0x321C010", VA = "0x18321D410")]
		public bool OnSortPanelItemClicked(BuildingData.DiySortType diySortType, int index)
		{
			return default(bool);
		}

		// Token: 0x0600A6D2 RID: 42706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A6D2")]
		[Address(RVA = "0x321E390", Offset = "0x321CF90", VA = "0x18321E390")]
		private void _SetCurrSelectedIndex(int index)
		{
		}

		// Token: 0x0600A6D3 RID: 42707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A6D3")]
		[Address(RVA = "0x321E870", Offset = "0x321D470", VA = "0x18321E870")]
		private void _ToggleSortOrder(int index)
		{
		}

		// Token: 0x0600A6D4 RID: 42708 RVA: 0x00040860 File Offset: 0x0003EA60
		[Token(Token = "0x600A6D4")]
		[Address(RVA = "0x321DBC0", Offset = "0x321C7C0", VA = "0x18321DBC0")]
		private BuildingData.DiySortType _GetDIYSortType(BuildingData.DiyUIType diyUIType)
		{
			return BuildingData.DiySortType.NONE;
		}

		// Token: 0x0600A6D5 RID: 42709 RVA: 0x00040878 File Offset: 0x0003EA78
		[Token(Token = "0x600A6D5")]
		[Address(RVA = "0x321EAB0", Offset = "0x321D6B0", VA = "0x18321EAB0")]
		private bool _UpdateComparers()
		{
			return default(bool);
		}

		// Token: 0x0600A6D6 RID: 42710 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A6D6")]
		[Address(RVA = "0x321DDF0", Offset = "0x321C9F0", VA = "0x18321DDF0")]
		private static DIYSortMethodViewModel.DIYItemViewComparer _GetDiyUISortComparer(string sortTemplate, BuildingData.DiyUISortOrder sortOrder)
		{
			return null;
		}

		// Token: 0x0600A6D7 RID: 42711 RVA: 0x00040890 File Offset: 0x0003EA90
		[Token(Token = "0x600A6D7")]
		[Address(RVA = "0x321E1C0", Offset = "0x321CDC0", VA = "0x18321E1C0")]
		private static bool _IsEqual(List<DIYSortMethodViewModel.DIYItemViewComparer> a, List<DIYSortMethodViewModel.DIYItemViewComparer> b)
		{
			return default(bool);
		}

		// Token: 0x0600A6D8 RID: 42712 RVA: 0x000408A8 File Offset: 0x0003EAA8
		[Token(Token = "0x600A6D8")]
		[Address(RVA = "0x321DFE0", Offset = "0x321CBE0", VA = "0x18321DFE0")]
		private int _GetSelectedIndexFromCache(int defaultIndex)
		{
			return 0;
		}

		// Token: 0x0600A6D9 RID: 42713 RVA: 0x000408C0 File Offset: 0x0003EAC0
		[Token(Token = "0x600A6D9")]
		[Address(RVA = "0x321E0B0", Offset = "0x321CCB0", VA = "0x18321E0B0")]
		private BuildingData.DiyUISortOrder _GetSortOrderFromCache(int methodIndex, BuildingData.DiyUISortOrder defaultOrder)
		{
			return BuildingData.DiyUISortOrder.DESC;
		}

		// Token: 0x0600A6DA RID: 42714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A6DA")]
		[Address(RVA = "0x321E560", Offset = "0x321D160", VA = "0x18321E560")]
		private void _SetSelectedIndexToCache(int index)
		{
		}

		// Token: 0x0600A6DB RID: 42715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A6DB")]
		[Address(RVA = "0x321E6D0", Offset = "0x321D2D0", VA = "0x18321E6D0")]
		private void _SetSortOrderToCache(int methodIndex, BuildingData.DiyUISortOrder sortOrder)
		{
		}

		// Token: 0x0600A6DC RID: 42716 RVA: 0x000408D8 File Offset: 0x0003EAD8
		[Token(Token = "0x600A6DC")]
		[Address(RVA = "0x321D190", Offset = "0x321BD90", VA = "0x18321D190")]
		public int Compare(DIYItemViewData x, DIYItemViewData y)
		{
			return 0;
		}

		// Token: 0x0600A6DD RID: 42717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A6DD")]
		[Address(RVA = "0x321F0B0", Offset = "0x321DCB0", VA = "0x18321F0B0")]
		public DIYSortMethodViewModel()
		{
		}

		// Token: 0x04009EE8 RID: 40680
		[Token(Token = "0x4009EE8")]
		public const string FALLBACK_SORT_TEMPLATE_NAME = "None";

		// Token: 0x04009EE9 RID: 40681
		[Token(Token = "0x4009EE9")]
		[FieldOffset(Offset = "0x0")]
		public static Dictionary<string, IDIYItemViewComparer> SORT_TEMPLATES;

		// Token: 0x04009EEA RID: 40682
		[Token(Token = "0x4009EEA")]
		[FieldOffset(Offset = "0x10")]
		public List<DIYSortMethodModel> sortMethods;

		// Token: 0x04009EEB RID: 40683
		[Token(Token = "0x4009EEB")]
		[FieldOffset(Offset = "0x18")]
		public BuildingData.CustomData.DiyUISortTemplateListData currDiyUISortConfig;

		// Token: 0x04009EEC RID: 40684
		[Token(Token = "0x4009EEC")]
		[FieldOffset(Offset = "0x20")]
		public int currSelectedIndex;

		// Token: 0x04009EED RID: 40685
		[Token(Token = "0x4009EED")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<BuildingData.DiySortType, DIYSortMethodViewModel.DIYSortMethodConfigCache> sortConfigCaches;

		// Token: 0x04009EEE RID: 40686
		[Token(Token = "0x4009EEE")]
		[FieldOffset(Offset = "0x30")]
		private List<DIYSortMethodViewModel.DIYItemViewComparer> m_comparers;

		// Token: 0x04009EEF RID: 40687
		[Token(Token = "0x4009EEF")]
		[FieldOffset(Offset = "0x38")]
		private ListDict<string, long> m_recentThemes;

		// Token: 0x04009EF0 RID: 40688
		[Token(Token = "0x4009EF0")]
		[FieldOffset(Offset = "0x40")]
		private ListDict<string, long> m_recentFurnitures;

		// Token: 0x04009EF1 RID: 40689
		[Token(Token = "0x4009EF1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_recentThemes;

		// Token: 0x04009EF2 RID: 40690
		[Token(Token = "0x4009EF2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_recentThemes;

		// Token: 0x04009EF3 RID: 40691
		[Token(Token = "0x4009EF3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_recentFurnitures;

		// Token: 0x04009EF4 RID: 40692
		[Token(Token = "0x4009EF4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_recentFurnitures;

		// Token: 0x04009EF5 RID: 40693
		[Token(Token = "0x4009EF5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_UpdateSortMethod;

		// Token: 0x04009EF6 RID: 40694
		[Token(Token = "0x4009EF6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnSortPanelItemClicked;

		// Token: 0x04009EF7 RID: 40695
		[Token(Token = "0x4009EF7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__SetCurrSelectedIndex;

		// Token: 0x04009EF8 RID: 40696
		[Token(Token = "0x4009EF8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ToggleSortOrder;

		// Token: 0x04009EF9 RID: 40697
		[Token(Token = "0x4009EF9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetDIYSortType;

		// Token: 0x04009EFA RID: 40698
		[Token(Token = "0x4009EFA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateComparers;

		// Token: 0x04009EFB RID: 40699
		[Token(Token = "0x4009EFB")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetDiyUISortComparer;

		// Token: 0x04009EFC RID: 40700
		[Token(Token = "0x4009EFC")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__IsEqual;

		// Token: 0x04009EFD RID: 40701
		[Token(Token = "0x4009EFD")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__GetSelectedIndexFromCache;

		// Token: 0x04009EFE RID: 40702
		[Token(Token = "0x4009EFE")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GetSortOrderFromCache;

		// Token: 0x04009EFF RID: 40703
		[Token(Token = "0x4009EFF")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__SetSelectedIndexToCache;

		// Token: 0x04009F00 RID: 40704
		[Token(Token = "0x4009F00")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__SetSortOrderToCache;

		// Token: 0x04009F01 RID: 40705
		[Token(Token = "0x4009F01")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_Compare;

		// Token: 0x04009F02 RID: 40706
		[Token(Token = "0x4009F02")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020019FC RID: 6652
		[Token(Token = "0x20019FC")]
		public class DIYSortMethodConfigCache : IHotfixable
		{
			// Token: 0x0600A6DF RID: 42719 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6DF")]
			[Address(RVA = "0x321D080", Offset = "0x321BC80", VA = "0x18321D080")]
			public DIYSortMethodConfigCache()
			{
			}

			// Token: 0x04009F03 RID: 40707
			[Token(Token = "0x4009F03")]
			[FieldOffset(Offset = "0x10")]
			public int selectedIndex;

			// Token: 0x04009F04 RID: 40708
			[Token(Token = "0x4009F04")]
			[FieldOffset(Offset = "0x18")]
			public Dictionary<int, BuildingData.DiyUISortOrder> sortOrderConfig;

			// Token: 0x04009F05 RID: 40709
			[Token(Token = "0x4009F05")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020019FD RID: 6653
		[Token(Token = "0x20019FD")]
		public class DIYItemViewComparer : IHotfixable
		{
			// Token: 0x0600A6E0 RID: 42720 RVA: 0x000408F0 File Offset: 0x0003EAF0
			[Token(Token = "0x600A6E0")]
			[Address(RVA = "0x321B370", Offset = "0x3219F70", VA = "0x18321B370")]
			public bool Equals(DIYSortMethodViewModel.DIYItemViewComparer comp)
			{
				return default(bool);
			}

			// Token: 0x0600A6E1 RID: 42721 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A6E1")]
			[Address(RVA = "0x321B400", Offset = "0x321A000", VA = "0x18321B400")]
			public DIYItemViewComparer()
			{
			}

			// Token: 0x04009F06 RID: 40710
			[Token(Token = "0x4009F06")]
			[FieldOffset(Offset = "0x10")]
			public BuildingData.DiyUISortOrder sortOrder;

			// Token: 0x04009F07 RID: 40711
			[Token(Token = "0x4009F07")]
			[FieldOffset(Offset = "0x18")]
			public IDIYItemViewComparer comparer;

			// Token: 0x04009F08 RID: 40712
			[Token(Token = "0x4009F08")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Equals;

			// Token: 0x04009F09 RID: 40713
			[Token(Token = "0x4009F09")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
