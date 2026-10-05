using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006576 RID: 25974
	[Token(Token = "0x2006576")]
	public class ArtMagazineDiyDecorHomeBackgroundGroupModel : ArtMagazineDiyDecorGroupModelBase<ArtMagazineDiyDecorHomeBackgroundItemModel>
	{
		// Token: 0x17005832 RID: 22578
		// (get) Token: 0x06025597 RID: 152983 RVA: 0x000C78D8 File Offset: 0x000C5AD8
		// (set) Token: 0x06025598 RID: 152984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17005832")]
		public override SorterType sorter
		{
			[Token(Token = "0x6025597")]
			[Address(RVA = "0x2044240", Offset = "0x2042E40", VA = "0x182044240", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return SorterType.BY_GET_TS_DOWN;
			}
			[Token(Token = "0x6025598")]
			[Address(RVA = "0x2044300", Offset = "0x2042F00", VA = "0x182044300", Slot = "21")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17005833 RID: 22579
		// (get) Token: 0x06025599 RID: 152985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005833")]
		public override EnumIntDictionary<FilterGroupType, ArtMagazineDiyItemFilterModel> filterDict
		{
			[Token(Token = "0x6025599")]
			[Address(RVA = "0x2044180", Offset = "0x2042D80", VA = "0x182044180", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005834 RID: 22580
		// (get) Token: 0x0602559A RID: 152986 RVA: 0x000C78F0 File Offset: 0x000C5AF0
		[Token(Token = "0x17005834")]
		public override int itemMaxSelectNum
		{
			[Token(Token = "0x602559A")]
			[Address(RVA = "0x20441E0", Offset = "0x2042DE0", VA = "0x1820441E0", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005835 RID: 22581
		// (get) Token: 0x0602559B RID: 152987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005835")]
		protected override ListDict<string, ArtMagazineDiyDecorHomeBackgroundItemModel> totalItemDict
		{
			[Token(Token = "0x602559B")]
			[Address(RVA = "0x20442A0", Offset = "0x2042EA0", VA = "0x1820442A0", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602559C RID: 152988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602559C")]
		[Address(RVA = "0x2043AD0", Offset = "0x20426D0", VA = "0x182043AD0", Slot = "24")]
		public override void LoadData(string leafId)
		{
		}

		// Token: 0x0602559D RID: 152989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602559D")]
		[Address(RVA = "0x2043BD0", Offset = "0x20427D0", VA = "0x182043BD0", Slot = "25")]
		public override void RefreshData(ArtMagazineLeafData leafData)
		{
		}

		// Token: 0x0602559E RID: 152990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602559E")]
		[Address(RVA = "0x20439F0", Offset = "0x20425F0", VA = "0x1820439F0", Slot = "34")]
		protected override Comparison<ArtMagazineDiyDecorHomeBackgroundItemModel> GetComparisonBySortType(SorterType type)
		{
			return null;
		}

		// Token: 0x0602559F RID: 152991 RVA: 0x000C7908 File Offset: 0x000C5B08
		[Token(Token = "0x602559F")]
		[Address(RVA = "0x2043F50", Offset = "0x2042B50", VA = "0x182043F50")]
		private static int _SortByTsDown(ArtMagazineDiyDecorHomeBackgroundItemModel a, ArtMagazineDiyDecorHomeBackgroundItemModel b)
		{
			return 0;
		}

		// Token: 0x060255A0 RID: 152992 RVA: 0x000C7920 File Offset: 0x000C5B20
		[Token(Token = "0x60255A0")]
		[Address(RVA = "0x2043FE0", Offset = "0x2042BE0", VA = "0x182043FE0")]
		private static int _SortByTsUp(ArtMagazineDiyDecorHomeBackgroundItemModel a, ArtMagazineDiyDecorHomeBackgroundItemModel b)
		{
			return 0;
		}

		// Token: 0x060255A1 RID: 152993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255A1")]
		[Address(RVA = "0x2044070", Offset = "0x2042C70", VA = "0x182044070")]
		public ArtMagazineDiyDecorHomeBackgroundGroupModel()
		{
		}

		// Token: 0x04034698 RID: 214680
		[Token(Token = "0x4034698")]
		[FieldOffset(Offset = "0x20")]
		private EnumIntDictionary<FilterGroupType, ArtMagazineDiyItemFilterModel> m_filterDict;

		// Token: 0x04034699 RID: 214681
		[Token(Token = "0x4034699")]
		[FieldOffset(Offset = "0x28")]
		private int m_itemMaxSelectNum;

		// Token: 0x0403469A RID: 214682
		[Token(Token = "0x403469A")]
		[FieldOffset(Offset = "0x30")]
		private ListDict<string, ArtMagazineDiyDecorHomeBackgroundItemModel> m_totalItemDict;

		// Token: 0x0403469C RID: 214684
		[Token(Token = "0x403469C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_sorter;

		// Token: 0x0403469D RID: 214685
		[Token(Token = "0x403469D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_sorter;

		// Token: 0x0403469E RID: 214686
		[Token(Token = "0x403469E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_filterDict;

		// Token: 0x0403469F RID: 214687
		[Token(Token = "0x403469F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_itemMaxSelectNum;

		// Token: 0x040346A0 RID: 214688
		[Token(Token = "0x40346A0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_totalItemDict;

		// Token: 0x040346A1 RID: 214689
		[Token(Token = "0x40346A1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040346A2 RID: 214690
		[Token(Token = "0x40346A2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x040346A3 RID: 214691
		[Token(Token = "0x40346A3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetComparisonBySortType;

		// Token: 0x040346A4 RID: 214692
		[Token(Token = "0x40346A4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SortByTsDown;

		// Token: 0x040346A5 RID: 214693
		[Token(Token = "0x40346A5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SortByTsUp;

		// Token: 0x040346A6 RID: 214694
		[Token(Token = "0x40346A6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
