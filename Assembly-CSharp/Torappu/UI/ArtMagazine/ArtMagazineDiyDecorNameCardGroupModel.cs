using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200657A RID: 25978
	[Token(Token = "0x200657A")]
	public class ArtMagazineDiyDecorNameCardGroupModel : ArtMagazineDiyDecorGroupModelBase<ArtMagazineDiyDecorNameCardItemModel>
	{
		// Token: 0x17005844 RID: 22596
		// (get) Token: 0x060255BB RID: 153019 RVA: 0x000C7A28 File Offset: 0x000C5C28
		[Token(Token = "0x17005844")]
		public override int itemMaxSelectNum
		{
			[Token(Token = "0x60255BB")]
			[Address(RVA = "0x20452B0", Offset = "0x2043EB0", VA = "0x1820452B0", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005845 RID: 22597
		// (get) Token: 0x060255BC RID: 153020 RVA: 0x000C7A40 File Offset: 0x000C5C40
		// (set) Token: 0x060255BD RID: 153021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005845")]
		public override SorterType sorter
		{
			[Token(Token = "0x60255BC")]
			[Address(RVA = "0x2045310", Offset = "0x2043F10", VA = "0x182045310", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return SorterType.BY_GET_TS_DOWN;
			}
			[Token(Token = "0x60255BD")]
			[Address(RVA = "0x20453D0", Offset = "0x2043FD0", VA = "0x1820453D0", Slot = "21")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005846 RID: 22598
		// (get) Token: 0x060255BE RID: 153022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005846")]
		public override EnumIntDictionary<FilterGroupType, ArtMagazineDiyItemFilterModel> filterDict
		{
			[Token(Token = "0x60255BE")]
			[Address(RVA = "0x2045250", Offset = "0x2043E50", VA = "0x182045250", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005847 RID: 22599
		// (get) Token: 0x060255BF RID: 153023 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005847")]
		protected override ListDict<string, ArtMagazineDiyDecorNameCardItemModel> totalItemDict
		{
			[Token(Token = "0x60255BF")]
			[Address(RVA = "0x2045370", Offset = "0x2043F70", VA = "0x182045370", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x060255C0 RID: 153024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255C0")]
		[Address(RVA = "0x2044B50", Offset = "0x2043750", VA = "0x182044B50", Slot = "24")]
		public override void LoadData(string leafId)
		{
		}

		// Token: 0x060255C1 RID: 153025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255C1")]
		[Address(RVA = "0x2044C50", Offset = "0x2043850", VA = "0x182044C50", Slot = "25")]
		public override void RefreshData(ArtMagazineLeafData leafData)
		{
		}

		// Token: 0x060255C2 RID: 153026 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60255C2")]
		[Address(RVA = "0x2044A70", Offset = "0x2043670", VA = "0x182044A70", Slot = "34")]
		protected override Comparison<ArtMagazineDiyDecorNameCardItemModel> GetComparisonBySortType(SorterType type)
		{
			return null;
		}

		// Token: 0x060255C3 RID: 153027 RVA: 0x000C7A58 File Offset: 0x000C5C58
		[Token(Token = "0x60255C3")]
		[Address(RVA = "0x2045020", Offset = "0x2043C20", VA = "0x182045020")]
		private static int _SortByTsDown(ArtMagazineDiyDecorNameCardItemModel a, ArtMagazineDiyDecorNameCardItemModel b)
		{
			return 0;
		}

		// Token: 0x060255C4 RID: 153028 RVA: 0x000C7A70 File Offset: 0x000C5C70
		[Token(Token = "0x60255C4")]
		[Address(RVA = "0x20450B0", Offset = "0x2043CB0", VA = "0x1820450B0")]
		private static int _SortByTsUp(ArtMagazineDiyDecorNameCardItemModel a, ArtMagazineDiyDecorNameCardItemModel b)
		{
			return 0;
		}

		// Token: 0x060255C5 RID: 153029 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255C5")]
		[Address(RVA = "0x2045140", Offset = "0x2043D40", VA = "0x182045140")]
		public ArtMagazineDiyDecorNameCardGroupModel()
		{
		}

		// Token: 0x040346CC RID: 214732
		[Token(Token = "0x40346CC")]
		[FieldOffset(Offset = "0x20")]
		private EnumIntDictionary<FilterGroupType, ArtMagazineDiyItemFilterModel> m_filterDict;

		// Token: 0x040346CD RID: 214733
		[Token(Token = "0x40346CD")]
		[FieldOffset(Offset = "0x28")]
		private int m_itemMaxSelectNum;

		// Token: 0x040346CE RID: 214734
		[Token(Token = "0x40346CE")]
		[FieldOffset(Offset = "0x30")]
		private ListDict<string, ArtMagazineDiyDecorNameCardItemModel> m_totalItemDict;

		// Token: 0x040346D0 RID: 214736
		[Token(Token = "0x40346D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemMaxSelectNum;

		// Token: 0x040346D1 RID: 214737
		[Token(Token = "0x40346D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_sorter;

		// Token: 0x040346D2 RID: 214738
		[Token(Token = "0x40346D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_sorter;

		// Token: 0x040346D3 RID: 214739
		[Token(Token = "0x40346D3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_filterDict;

		// Token: 0x040346D4 RID: 214740
		[Token(Token = "0x40346D4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_totalItemDict;

		// Token: 0x040346D5 RID: 214741
		[Token(Token = "0x40346D5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040346D6 RID: 214742
		[Token(Token = "0x40346D6")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x040346D7 RID: 214743
		[Token(Token = "0x40346D7")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetComparisonBySortType;

		// Token: 0x040346D8 RID: 214744
		[Token(Token = "0x40346D8")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SortByTsDown;

		// Token: 0x040346D9 RID: 214745
		[Token(Token = "0x40346D9")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SortByTsUp;

		// Token: 0x040346DA RID: 214746
		[Token(Token = "0x40346DA")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
