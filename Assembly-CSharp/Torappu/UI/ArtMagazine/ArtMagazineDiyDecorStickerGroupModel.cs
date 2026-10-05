using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x0200657C RID: 25980
	[Token(Token = "0x200657C")]
	public class ArtMagazineDiyDecorStickerGroupModel : ArtMagazineDiyDecorGroupModelBase<ArtMagazineDiyDecorStickerItemModel>
	{
		// Token: 0x1700584D RID: 22605
		// (get) Token: 0x060255CD RID: 153037 RVA: 0x000C7AD0 File Offset: 0x000C5CD0
		[Token(Token = "0x1700584D")]
		public override int itemMaxSelectNum
		{
			[Token(Token = "0x60255CD")]
			[Address(RVA = "0x2046310", Offset = "0x2044F10", VA = "0x182046310", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700584E RID: 22606
		// (get) Token: 0x060255CE RID: 153038 RVA: 0x000C7AE8 File Offset: 0x000C5CE8
		// (set) Token: 0x060255CF RID: 153039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700584E")]
		public override SorterType sorter
		{
			[Token(Token = "0x60255CE")]
			[Address(RVA = "0x2046370", Offset = "0x2044F70", VA = "0x182046370", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return SorterType.BY_GET_TS_DOWN;
			}
			[Token(Token = "0x60255CF")]
			[Address(RVA = "0x2046430", Offset = "0x2045030", VA = "0x182046430", Slot = "21")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700584F RID: 22607
		// (get) Token: 0x060255D0 RID: 153040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700584F")]
		public override EnumIntDictionary<FilterGroupType, ArtMagazineDiyItemFilterModel> filterDict
		{
			[Token(Token = "0x60255D0")]
			[Address(RVA = "0x20462B0", Offset = "0x2044EB0", VA = "0x1820462B0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005850 RID: 22608
		// (get) Token: 0x060255D1 RID: 153041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005850")]
		protected override ListDict<string, ArtMagazineDiyDecorStickerItemModel> totalItemDict
		{
			[Token(Token = "0x60255D1")]
			[Address(RVA = "0x20463D0", Offset = "0x2044FD0", VA = "0x1820463D0", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x060255D2 RID: 153042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255D2")]
		[Address(RVA = "0x2045C20", Offset = "0x2044820", VA = "0x182045C20", Slot = "24")]
		public override void LoadData(string leafId)
		{
		}

		// Token: 0x060255D3 RID: 153043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255D3")]
		[Address(RVA = "0x2045D20", Offset = "0x2044920", VA = "0x182045D20", Slot = "25")]
		public override void RefreshData(ArtMagazineLeafData leafData)
		{
		}

		// Token: 0x060255D4 RID: 153044 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60255D4")]
		[Address(RVA = "0x2045B40", Offset = "0x2044740", VA = "0x182045B40", Slot = "34")]
		protected override Comparison<ArtMagazineDiyDecorStickerItemModel> GetComparisonBySortType(SorterType type)
		{
			return null;
		}

		// Token: 0x060255D5 RID: 153045 RVA: 0x000C7B00 File Offset: 0x000C5D00
		[Token(Token = "0x60255D5")]
		[Address(RVA = "0x2046080", Offset = "0x2044C80", VA = "0x182046080")]
		private static int _SortByTsDown(ArtMagazineDiyDecorStickerItemModel a, ArtMagazineDiyDecorStickerItemModel b)
		{
			return 0;
		}

		// Token: 0x060255D6 RID: 153046 RVA: 0x000C7B18 File Offset: 0x000C5D18
		[Token(Token = "0x60255D6")]
		[Address(RVA = "0x2046110", Offset = "0x2044D10", VA = "0x182046110")]
		private static int _SortByTsUp(ArtMagazineDiyDecorStickerItemModel a, ArtMagazineDiyDecorStickerItemModel b)
		{
			return 0;
		}

		// Token: 0x060255D7 RID: 153047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255D7")]
		[Address(RVA = "0x20461A0", Offset = "0x2044DA0", VA = "0x1820461A0")]
		public ArtMagazineDiyDecorStickerGroupModel()
		{
		}

		// Token: 0x040346E6 RID: 214758
		[Token(Token = "0x40346E6")]
		[FieldOffset(Offset = "0x20")]
		private EnumIntDictionary<FilterGroupType, ArtMagazineDiyItemFilterModel> m_filterDict;

		// Token: 0x040346E7 RID: 214759
		[Token(Token = "0x40346E7")]
		[FieldOffset(Offset = "0x28")]
		private int m_itemMaxSelectNum;

		// Token: 0x040346E8 RID: 214760
		[Token(Token = "0x40346E8")]
		[FieldOffset(Offset = "0x30")]
		private ListDict<string, ArtMagazineDiyDecorStickerItemModel> m_totalItemDict;

		// Token: 0x040346EA RID: 214762
		[Token(Token = "0x40346EA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemMaxSelectNum;

		// Token: 0x040346EB RID: 214763
		[Token(Token = "0x40346EB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_sorter;

		// Token: 0x040346EC RID: 214764
		[Token(Token = "0x40346EC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_sorter;

		// Token: 0x040346ED RID: 214765
		[Token(Token = "0x40346ED")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_filterDict;

		// Token: 0x040346EE RID: 214766
		[Token(Token = "0x40346EE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_totalItemDict;

		// Token: 0x040346EF RID: 214767
		[Token(Token = "0x40346EF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040346F0 RID: 214768
		[Token(Token = "0x40346F0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x040346F1 RID: 214769
		[Token(Token = "0x40346F1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetComparisonBySortType;

		// Token: 0x040346F2 RID: 214770
		[Token(Token = "0x40346F2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SortByTsDown;

		// Token: 0x040346F3 RID: 214771
		[Token(Token = "0x40346F3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SortByTsUp;

		// Token: 0x040346F4 RID: 214772
		[Token(Token = "0x40346F4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
