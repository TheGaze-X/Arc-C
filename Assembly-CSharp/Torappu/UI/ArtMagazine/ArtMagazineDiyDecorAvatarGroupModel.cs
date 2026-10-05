using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006573 RID: 25971
	[Token(Token = "0x2006573")]
	public class ArtMagazineDiyDecorAvatarGroupModel : ArtMagazineDiyDecorGroupModelBase<ArtMagazineDiyDecorAvatarItemModel>
	{
		// Token: 0x17005825 RID: 22565
		// (get) Token: 0x0602557C RID: 152956 RVA: 0x000C77E8 File Offset: 0x000C59E8
		[Token(Token = "0x17005825")]
		public override int itemMaxSelectNum
		{
			[Token(Token = "0x602557C")]
			[Address(RVA = "0x2043080", Offset = "0x2041C80", VA = "0x182043080", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005826 RID: 22566
		// (get) Token: 0x0602557D RID: 152957 RVA: 0x000C7800 File Offset: 0x000C5A00
		// (set) Token: 0x0602557E RID: 152958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005826")]
		public override SorterType sorter
		{
			[Token(Token = "0x602557D")]
			[Address(RVA = "0x20430E0", Offset = "0x2041CE0", VA = "0x1820430E0", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return SorterType.BY_GET_TS_DOWN;
			}
			[Token(Token = "0x602557E")]
			[Address(RVA = "0x20431A0", Offset = "0x2041DA0", VA = "0x1820431A0", Slot = "21")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005827 RID: 22567
		// (get) Token: 0x0602557F RID: 152959 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005827")]
		public override EnumIntDictionary<FilterGroupType, ArtMagazineDiyItemFilterModel> filterDict
		{
			[Token(Token = "0x602557F")]
			[Address(RVA = "0x2043020", Offset = "0x2041C20", VA = "0x182043020", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005828 RID: 22568
		// (get) Token: 0x06025580 RID: 152960 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005828")]
		protected override ListDict<string, ArtMagazineDiyDecorAvatarItemModel> totalItemDict
		{
			[Token(Token = "0x6025580")]
			[Address(RVA = "0x2043140", Offset = "0x2041D40", VA = "0x182043140", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x06025581 RID: 152961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025581")]
		[Address(RVA = "0x2042870", Offset = "0x2041470", VA = "0x182042870", Slot = "24")]
		public override void LoadData(string leafId)
		{
		}

		// Token: 0x06025582 RID: 152962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025582")]
		[Address(RVA = "0x2042A90", Offset = "0x2041690", VA = "0x182042A90", Slot = "25")]
		public override void RefreshData(ArtMagazineLeafData leafData)
		{
		}

		// Token: 0x06025583 RID: 152963 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6025583")]
		[Address(RVA = "0x2042790", Offset = "0x2041390", VA = "0x182042790", Slot = "34")]
		protected override Comparison<ArtMagazineDiyDecorAvatarItemModel> GetComparisonBySortType(SorterType type)
		{
			return null;
		}

		// Token: 0x06025584 RID: 152964 RVA: 0x000C7818 File Offset: 0x000C5A18
		[Token(Token = "0x6025584")]
		[Address(RVA = "0x2042DF0", Offset = "0x20419F0", VA = "0x182042DF0")]
		private static int _SortByTsDown(ArtMagazineDiyDecorAvatarItemModel a, ArtMagazineDiyDecorAvatarItemModel b)
		{
			return 0;
		}

		// Token: 0x06025585 RID: 152965 RVA: 0x000C7830 File Offset: 0x000C5A30
		[Token(Token = "0x6025585")]
		[Address(RVA = "0x2042E80", Offset = "0x2041A80", VA = "0x182042E80")]
		private static int _SortByTsUp(ArtMagazineDiyDecorAvatarItemModel a, ArtMagazineDiyDecorAvatarItemModel b)
		{
			return 0;
		}

		// Token: 0x06025586 RID: 152966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025586")]
		[Address(RVA = "0x2042F10", Offset = "0x2041B10", VA = "0x182042F10")]
		public ArtMagazineDiyDecorAvatarGroupModel()
		{
		}

		// Token: 0x04034671 RID: 214641
		[Token(Token = "0x4034671")]
		[FieldOffset(Offset = "0x20")]
		private EnumIntDictionary<FilterGroupType, ArtMagazineDiyItemFilterModel> m_filterDict;

		// Token: 0x04034672 RID: 214642
		[Token(Token = "0x4034672")]
		[FieldOffset(Offset = "0x28")]
		private int m_itemMaxSelectNum;

		// Token: 0x04034673 RID: 214643
		[Token(Token = "0x4034673")]
		[FieldOffset(Offset = "0x30")]
		private ListDict<string, ArtMagazineDiyDecorAvatarItemModel> m_totalItemDict;

		// Token: 0x04034675 RID: 214645
		[Token(Token = "0x4034675")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemMaxSelectNum;

		// Token: 0x04034676 RID: 214646
		[Token(Token = "0x4034676")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_sorter;

		// Token: 0x04034677 RID: 214647
		[Token(Token = "0x4034677")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_sorter;

		// Token: 0x04034678 RID: 214648
		[Token(Token = "0x4034678")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_filterDict;

		// Token: 0x04034679 RID: 214649
		[Token(Token = "0x4034679")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_totalItemDict;

		// Token: 0x0403467A RID: 214650
		[Token(Token = "0x403467A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403467B RID: 214651
		[Token(Token = "0x403467B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x0403467C RID: 214652
		[Token(Token = "0x403467C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetComparisonBySortType;

		// Token: 0x0403467D RID: 214653
		[Token(Token = "0x403467D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SortByTsDown;

		// Token: 0x0403467E RID: 214654
		[Token(Token = "0x403467E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SortByTsUp;

		// Token: 0x0403467F RID: 214655
		[Token(Token = "0x403467F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006574 RID: 25972
		[Token(Token = "0x2006574")]
		public class AvatarGroupFilterModel : ArtMagazineDiyItemFilterModel
		{
			// Token: 0x17005829 RID: 22569
			// (get) Token: 0x06025587 RID: 152967 RVA: 0x000C7848 File Offset: 0x000C5A48
			[Token(Token = "0x17005829")]
			public override ItemType relateItemType
			{
				[Token(Token = "0x6025587")]
				[Address(RVA = "0x20545E0", Offset = "0x20531E0", VA = "0x1820545E0", Slot = "4")]
				get
				{
					return ItemType.NONE;
				}
			}

			// Token: 0x1700582A RID: 22570
			// (get) Token: 0x06025588 RID: 152968 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700582A")]
			public override string filterDialogResPath
			{
				[Token(Token = "0x6025588")]
				[Address(RVA = "0x2054580", Offset = "0x2053180", VA = "0x182054580", Slot = "5")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700582B RID: 22571
			// (get) Token: 0x06025589 RID: 152969 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700582B")]
			public override string title
			{
				[Token(Token = "0x6025589")]
				[Address(RVA = "0x2054640", Offset = "0x2053240", VA = "0x182054640", Slot = "6")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700582C RID: 22572
			// (get) Token: 0x0602558A RID: 152970 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700582C")]
			public override object activeFilterParam
			{
				[Token(Token = "0x602558A")]
				[Address(RVA = "0x2054520", Offset = "0x2053120", VA = "0x182054520", Slot = "7")]
				get
				{
					return null;
				}
			}

			// Token: 0x0602558B RID: 152971 RVA: 0x000C7860 File Offset: 0x000C5A60
			[Token(Token = "0x602558B")]
			[Address(RVA = "0x2054210", Offset = "0x2052E10", VA = "0x182054210", Slot = "8")]
			public override bool IsValid(ArtMagazineDiyItemModelBase itemModel)
			{
				return default(bool);
			}

			// Token: 0x0602558C RID: 152972 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602558C")]
			[Address(RVA = "0x2054310", Offset = "0x2052F10", VA = "0x182054310", Slot = "9")]
			public override void UpdateParam(object param)
			{
			}

			// Token: 0x0602558D RID: 152973 RVA: 0x000C7878 File Offset: 0x000C5A78
			[Token(Token = "0x602558D")]
			[Address(RVA = "0x20540B0", Offset = "0x2052CB0", VA = "0x1820540B0")]
			public static PlayerAvatarGroupType GetAvatarGroupTypeByFilter(AvatarGroupFilter filter)
			{
				return PlayerAvatarGroupType.NONE;
			}

			// Token: 0x0602558E RID: 152974 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x602558E")]
			[Address(RVA = "0x2054150", Offset = "0x2052D50", VA = "0x182054150")]
			public static string GetTitleByFilter(AvatarGroupFilter filter)
			{
				return null;
			}

			// Token: 0x0602558F RID: 152975 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602558F")]
			[Address(RVA = "0x20544C0", Offset = "0x20530C0", VA = "0x1820544C0")]
			public AvatarGroupFilterModel()
			{
			}

			// Token: 0x04034680 RID: 214656
			[Token(Token = "0x4034680")]
			[FieldOffset(Offset = "0x10")]
			private string m_title;

			// Token: 0x04034681 RID: 214657
			[Token(Token = "0x4034681")]
			[FieldOffset(Offset = "0x18")]
			private AvatarGroupFilter m_filter;

			// Token: 0x04034682 RID: 214658
			[Token(Token = "0x4034682")]
			[FieldOffset(Offset = "0x1C")]
			private PlayerAvatarGroupType m_groupType;

			// Token: 0x04034683 RID: 214659
			[Token(Token = "0x4034683")]
			[FieldOffset(Offset = "0x20")]
			private AvatarGroupFilterParam m_activeFilterParam;

			// Token: 0x04034684 RID: 214660
			[Token(Token = "0x4034684")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_relateItemType;

			// Token: 0x04034685 RID: 214661
			[Token(Token = "0x4034685")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_filterDialogResPath;

			// Token: 0x04034686 RID: 214662
			[Token(Token = "0x4034686")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_title;

			// Token: 0x04034687 RID: 214663
			[Token(Token = "0x4034687")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_activeFilterParam;

			// Token: 0x04034688 RID: 214664
			[Token(Token = "0x4034688")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_IsValid;

			// Token: 0x04034689 RID: 214665
			[Token(Token = "0x4034689")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_UpdateParam;

			// Token: 0x0403468A RID: 214666
			[Token(Token = "0x403468A")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GetAvatarGroupTypeByFilter;

			// Token: 0x0403468B RID: 214667
			[Token(Token = "0x403468B")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_GetTitleByFilter;

			// Token: 0x0403468C RID: 214668
			[Token(Token = "0x403468C")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
