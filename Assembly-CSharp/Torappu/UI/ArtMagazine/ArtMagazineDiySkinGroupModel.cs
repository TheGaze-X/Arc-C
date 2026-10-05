using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006586 RID: 25990
	[Token(Token = "0x2006586")]
	public class ArtMagazineDiySkinGroupModel : IArtMagazineDiyRecycleGroupViewModel
	{
		// Token: 0x17005864 RID: 22628
		// (get) Token: 0x0602561C RID: 153116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005864")]
		public List<IArtMagazineDiyItemViewModel> displayItemList
		{
			[Token(Token = "0x602561C")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005865 RID: 22629
		// (get) Token: 0x0602561D RID: 153117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005865")]
		public HashSet<string> selectedItem
		{
			[Token(Token = "0x602561D")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005866 RID: 22630
		// (get) Token: 0x0602561E RID: 153118 RVA: 0x000C7C20 File Offset: 0x000C5E20
		[Token(Token = "0x17005866")]
		public int itemMaxSelectNum
		{
			[Token(Token = "0x602561E")]
			[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0602561F RID: 153119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602561F")]
		[Address(RVA = "0x2050F30", Offset = "0x204FB30", VA = "0x182050F30", Slot = "7")]
		public void LoadData(string leafId)
		{
		}

		// Token: 0x06025620 RID: 153120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025620")]
		[Address(RVA = "0x2051140", Offset = "0x204FD40", VA = "0x182051140", Slot = "8")]
		public void RefreshData(ArtMagazineLeafData leafData)
		{
		}

		// Token: 0x06025621 RID: 153121 RVA: 0x000C7C38 File Offset: 0x000C5E38
		[Token(Token = "0x6025621")]
		[Address(RVA = "0x2051670", Offset = "0x2050270", VA = "0x182051670", Slot = "9")]
		public bool SelectItem(string id)
		{
			return default(bool);
		}

		// Token: 0x06025622 RID: 153122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025622")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "10")]
		public void SwitchItemByLeafView(string itemId, ItemType itemType, int oldTemplateId, int newTemplateId)
		{
		}

		// Token: 0x06025623 RID: 153123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025623")]
		[Address(RVA = "0x2051840", Offset = "0x2050440", VA = "0x182051840", Slot = "11")]
		public void UnselectItem(string id)
		{
		}

		// Token: 0x06025624 RID: 153124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025624")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "12")]
		public void UnselectItemByLeafView(string itemId, ItemType itemType, int templateId)
		{
		}

		// Token: 0x06025625 RID: 153125 RVA: 0x000C7C50 File Offset: 0x000C5E50
		[Token(Token = "0x6025625")]
		[Address(RVA = "0x2050DE0", Offset = "0x204F9E0", VA = "0x182050DE0", Slot = "14")]
		public bool IsItemSelected(string itemId, ItemType itemType, int templateId)
		{
			return default(bool);
		}

		// Token: 0x06025626 RID: 153126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025626")]
		[Address(RVA = "0x20517F0", Offset = "0x20503F0", VA = "0x1820517F0", Slot = "13")]
		public void UnselectAll()
		{
		}

		// Token: 0x06025627 RID: 153127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025627")]
		[Address(RVA = "0x20517E0", Offset = "0x20503E0", VA = "0x1820517E0", Slot = "15")]
		public void SetSorter(SorterType sorterType)
		{
		}

		// Token: 0x06025628 RID: 153128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025628")]
		[Address(RVA = "0x2051730", Offset = "0x2050330", VA = "0x182051730", Slot = "16")]
		public void SetFilter(FilterGroupType filterGroupType, object filterParam)
		{
		}

		// Token: 0x06025629 RID: 153129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025629")]
		[Address(RVA = "0x20515C0", Offset = "0x20501C0", VA = "0x1820515C0")]
		public void SelectItemByItemId(string itemId, int templateId)
		{
		}

		// Token: 0x0602562A RID: 153130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602562A")]
		[Address(RVA = "0x2051970", Offset = "0x2050570", VA = "0x182051970")]
		private void _RegenerateDisplayItemList()
		{
		}

		// Token: 0x0602562B RID: 153131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602562B")]
		[Address(RVA = "0x20518D0", Offset = "0x20504D0", VA = "0x1820518D0")]
		private Comparison<ArtMagazineDiySkinItemModel> _GetComparisonBySortType(SorterType type)
		{
			return null;
		}

		// Token: 0x0602562C RID: 153132 RVA: 0x000C7C68 File Offset: 0x000C5E68
		[Token(Token = "0x602562C")]
		[Address(RVA = "0x2051E50", Offset = "0x2050A50", VA = "0x182051E50")]
		private static int _SortByTsDown(ArtMagazineDiySkinItemModel a, ArtMagazineDiySkinItemModel b)
		{
			return 0;
		}

		// Token: 0x0602562D RID: 153133 RVA: 0x000C7C80 File Offset: 0x000C5E80
		[Token(Token = "0x602562D")]
		[Address(RVA = "0x2051E80", Offset = "0x2050A80", VA = "0x182051E80")]
		private static int _SortByTsUp(ArtMagazineDiySkinItemModel a, ArtMagazineDiySkinItemModel b)
		{
			return 0;
		}

		// Token: 0x0602562E RID: 153134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602562E")]
		[Address(RVA = "0x2051EB0", Offset = "0x2050AB0", VA = "0x182051EB0")]
		public ArtMagazineDiySkinGroupModel()
		{
		}

		// Token: 0x04034740 RID: 214848
		[Token(Token = "0x4034740")]
		[FieldOffset(Offset = "0x10")]
		private ListDict<string, IArtMagazineDiyItemViewModel> m_totalSkinDict;

		// Token: 0x04034741 RID: 214849
		[Token(Token = "0x4034741")]
		[FieldOffset(Offset = "0x18")]
		private List<IArtMagazineDiyItemViewModel> m_displayItemList;

		// Token: 0x04034742 RID: 214850
		[Token(Token = "0x4034742")]
		[FieldOffset(Offset = "0x20")]
		private HashSet<string> m_selectedItem;

		// Token: 0x04034743 RID: 214851
		[Token(Token = "0x4034743")]
		[FieldOffset(Offset = "0x28")]
		private long m_cacheDefaultSkinGetTs;

		// Token: 0x04034744 RID: 214852
		[Token(Token = "0x4034744")]
		[FieldOffset(Offset = "0x30")]
		public SorterType sorter;

		// Token: 0x04034745 RID: 214853
		[Token(Token = "0x4034745")]
		[FieldOffset(Offset = "0x38")]
		public EnumIntDictionary<FilterGroupType, ArtMagazineDiyItemFilterModel> filterDict;

		// Token: 0x02006587 RID: 25991
		[Token(Token = "0x2006587")]
		public class RarityFilterModel : ArtMagazineDiyItemFilterModel
		{
			// Token: 0x17005867 RID: 22631
			// (get) Token: 0x0602562F RID: 153135 RVA: 0x000C7C98 File Offset: 0x000C5E98
			[Token(Token = "0x17005867")]
			public override ItemType relateItemType
			{
				[Token(Token = "0x602562F")]
				[Address(RVA = "0x206DBC0", Offset = "0x206C7C0", VA = "0x18206DBC0", Slot = "4")]
				get
				{
					return ItemType.NONE;
				}
			}

			// Token: 0x17005868 RID: 22632
			// (get) Token: 0x06025630 RID: 153136 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005868")]
			public override string filterDialogResPath
			{
				[Token(Token = "0x6025630")]
				[Address(RVA = "0x206DB60", Offset = "0x206C760", VA = "0x18206DB60", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x17005869 RID: 22633
			// (get) Token: 0x06025631 RID: 153137 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17005869")]
			public override string title
			{
				[Token(Token = "0x6025631")]
				[Address(RVA = "0x206DC20", Offset = "0x206C820", VA = "0x18206DC20", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700586A RID: 22634
			// (get) Token: 0x06025632 RID: 153138 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700586A")]
			public override object activeFilterParam
			{
				[Token(Token = "0x6025632")]
				[Address(RVA = "0x206DB00", Offset = "0x206C700", VA = "0x18206DB00", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x06025633 RID: 153139 RVA: 0x000C7CB0 File Offset: 0x000C5EB0
			[Token(Token = "0x6025633")]
			[Address(RVA = "0x206D590", Offset = "0x206C190", VA = "0x18206D590", Slot = "8")]
			public override bool IsValid(ArtMagazineDiyItemModelBase itemModel)
			{
				return default(bool);
			}

			// Token: 0x06025634 RID: 153140 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025634")]
			[Address(RVA = "0x206D680", Offset = "0x206C280", VA = "0x18206D680", Slot = "9")]
			public override void UpdateParam(object param)
			{
			}

			// Token: 0x06025635 RID: 153141 RVA: 0x000C7CC8 File Offset: 0x000C5EC8
			[Token(Token = "0x6025635")]
			[Address(RVA = "0x206D8D0", Offset = "0x206C4D0", VA = "0x18206D8D0")]
			private static RarityRank _GetRarityRankByFilter(CharRarityFilter filter)
			{
				return RarityRank.TIER_1;
			}

			// Token: 0x06025636 RID: 153142 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6025636")]
			[Address(RVA = "0x206D9A0", Offset = "0x206C5A0", VA = "0x18206D9A0")]
			private static string _GetTitleByFilter(CharRarityFilter filter)
			{
				return null;
			}

			// Token: 0x06025637 RID: 153143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025637")]
			[Address(RVA = "0x206DA60", Offset = "0x206C660", VA = "0x18206DA60")]
			public RarityFilterModel()
			{
			}

			// Token: 0x04034746 RID: 214854
			[Token(Token = "0x4034746")]
			[FieldOffset(Offset = "0x10")]
			private string m_title;

			// Token: 0x04034747 RID: 214855
			[Token(Token = "0x4034747")]
			[FieldOffset(Offset = "0x18")]
			private CharRarityFilter m_filter;

			// Token: 0x04034748 RID: 214856
			[Token(Token = "0x4034748")]
			[FieldOffset(Offset = "0x1C")]
			private RarityRank m_rarity;

			// Token: 0x04034749 RID: 214857
			[Token(Token = "0x4034749")]
			[FieldOffset(Offset = "0x20")]
			private CharRarityFilterParam m_activeFilterParam;

			// Token: 0x0403474A RID: 214858
			[Token(Token = "0x403474A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_relateItemType;

			// Token: 0x0403474B RID: 214859
			[Token(Token = "0x403474B")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_filterDialogResPath;

			// Token: 0x0403474C RID: 214860
			[Token(Token = "0x403474C")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_title;

			// Token: 0x0403474D RID: 214861
			[Token(Token = "0x403474D")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_activeFilterParam;

			// Token: 0x0403474E RID: 214862
			[Token(Token = "0x403474E")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IsValid;

			// Token: 0x0403474F RID: 214863
			[Token(Token = "0x403474F")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_UpdateParam;

			// Token: 0x04034750 RID: 214864
			[Token(Token = "0x4034750")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__GetRarityRankByFilter;

			// Token: 0x04034751 RID: 214865
			[Token(Token = "0x4034751")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__GetTitleByFilter;

			// Token: 0x04034752 RID: 214866
			[Token(Token = "0x4034752")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02006588 RID: 25992
		[Token(Token = "0x2006588")]
		public class ProfessionFilterModel : ArtMagazineDiyItemFilterModel
		{
			// Token: 0x1700586B RID: 22635
			// (get) Token: 0x06025638 RID: 153144 RVA: 0x000C7CE0 File Offset: 0x000C5EE0
			[Token(Token = "0x1700586B")]
			public override ItemType relateItemType
			{
				[Token(Token = "0x6025638")]
				[Address(RVA = "0x206D4D0", Offset = "0x206C0D0", VA = "0x18206D4D0", Slot = "4")]
				get
				{
					return ItemType.NONE;
				}
			}

			// Token: 0x1700586C RID: 22636
			// (get) Token: 0x06025639 RID: 153145 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700586C")]
			public override string filterDialogResPath
			{
				[Token(Token = "0x6025639")]
				[Address(RVA = "0x206D470", Offset = "0x206C070", VA = "0x18206D470", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700586D RID: 22637
			// (get) Token: 0x0602563A RID: 153146 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700586D")]
			public override string title
			{
				[Token(Token = "0x602563A")]
				[Address(RVA = "0x206D530", Offset = "0x206C130", VA = "0x18206D530", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700586E RID: 22638
			// (get) Token: 0x0602563B RID: 153147 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700586E")]
			public override object activeFilterParam
			{
				[Token(Token = "0x602563B")]
				[Address(RVA = "0x206D410", Offset = "0x206C010", VA = "0x18206D410", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x0602563C RID: 153148 RVA: 0x000C7CF8 File Offset: 0x000C5EF8
			[Token(Token = "0x602563C")]
			[Address(RVA = "0x206CF80", Offset = "0x206BB80", VA = "0x18206CF80", Slot = "8")]
			public override bool IsValid(ArtMagazineDiyItemModelBase itemModel)
			{
				return default(bool);
			}

			// Token: 0x0602563D RID: 153149 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602563D")]
			[Address(RVA = "0x206D070", Offset = "0x206BC70", VA = "0x18206D070", Slot = "9")]
			public override void UpdateParam(object param)
			{
			}

			// Token: 0x0602563E RID: 153150 RVA: 0x000C7D10 File Offset: 0x000C5F10
			[Token(Token = "0x602563E")]
			[Address(RVA = "0x206D1F0", Offset = "0x206BDF0", VA = "0x18206D1F0")]
			private static ProfessionCategory _GetProfessionByFilter(CharProfessionFilter filter)
			{
				return ProfessionCategory.NONE;
			}

			// Token: 0x0602563F RID: 153151 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602563F")]
			[Address(RVA = "0x206D2E0", Offset = "0x206BEE0", VA = "0x18206D2E0")]
			private static string _GetTitleByFilter(CharProfessionFilter filter)
			{
				return null;
			}

			// Token: 0x06025640 RID: 153152 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6025640")]
			[Address(RVA = "0x206D370", Offset = "0x206BF70", VA = "0x18206D370")]
			public ProfessionFilterModel()
			{
			}

			// Token: 0x04034753 RID: 214867
			[Token(Token = "0x4034753")]
			[FieldOffset(Offset = "0x10")]
			private string m_title;

			// Token: 0x04034754 RID: 214868
			[Token(Token = "0x4034754")]
			[FieldOffset(Offset = "0x18")]
			private CharProfessionFilter m_filter;

			// Token: 0x04034755 RID: 214869
			[Token(Token = "0x4034755")]
			[FieldOffset(Offset = "0x1C")]
			private ProfessionCategory m_profession;

			// Token: 0x04034756 RID: 214870
			[Token(Token = "0x4034756")]
			[FieldOffset(Offset = "0x20")]
			private CharProfessionFilterParam m_activeFilterParam;

			// Token: 0x04034757 RID: 214871
			[Token(Token = "0x4034757")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_relateItemType;

			// Token: 0x04034758 RID: 214872
			[Token(Token = "0x4034758")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_filterDialogResPath;

			// Token: 0x04034759 RID: 214873
			[Token(Token = "0x4034759")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_title;

			// Token: 0x0403475A RID: 214874
			[Token(Token = "0x403475A")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_activeFilterParam;

			// Token: 0x0403475B RID: 214875
			[Token(Token = "0x403475B")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IsValid;

			// Token: 0x0403475C RID: 214876
			[Token(Token = "0x403475C")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_UpdateParam;

			// Token: 0x0403475D RID: 214877
			[Token(Token = "0x403475D")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__GetProfessionByFilter;

			// Token: 0x0403475E RID: 214878
			[Token(Token = "0x403475E")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__GetTitleByFilter;

			// Token: 0x0403475F RID: 214879
			[Token(Token = "0x403475F")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
