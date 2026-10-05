using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x02006578 RID: 25976
	[Token(Token = "0x2006578")]
	public class ArtMagazineDitDecorHomeThemeGroupModel : ArtMagazineDiyDecorGroupModelBase<ArtMagazineDiyDecorHomeThemeItemModel>
	{
		// Token: 0x1700583B RID: 22587
		// (get) Token: 0x060255A9 RID: 153001 RVA: 0x000C7980 File Offset: 0x000C5B80
		[Token(Token = "0x1700583B")]
		public override int itemMaxSelectNum
		{
			[Token(Token = "0x60255A9")]
			[Address(RVA = "0x2041E10", Offset = "0x2040A10", VA = "0x182041E10", Slot = "19")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700583C RID: 22588
		// (get) Token: 0x060255AA RID: 153002 RVA: 0x000C7998 File Offset: 0x000C5B98
		// (set) Token: 0x060255AB RID: 153003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700583C")]
		public override SorterType sorter
		{
			[Token(Token = "0x60255AA")]
			[Address(RVA = "0x2041E70", Offset = "0x2040A70", VA = "0x182041E70", Slot = "20")]
			[CompilerGenerated]
			get
			{
				return SorterType.BY_GET_TS_DOWN;
			}
			[Token(Token = "0x60255AB")]
			[Address(RVA = "0x2041F30", Offset = "0x2040B30", VA = "0x182041F30", Slot = "21")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700583D RID: 22589
		// (get) Token: 0x060255AC RID: 153004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700583D")]
		public override EnumIntDictionary<FilterGroupType, ArtMagazineDiyItemFilterModel> filterDict
		{
			[Token(Token = "0x60255AC")]
			[Address(RVA = "0x2041DB0", Offset = "0x20409B0", VA = "0x182041DB0", Slot = "22")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700583E RID: 22590
		// (get) Token: 0x060255AD RID: 153005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700583E")]
		protected override ListDict<string, ArtMagazineDiyDecorHomeThemeItemModel> totalItemDict
		{
			[Token(Token = "0x60255AD")]
			[Address(RVA = "0x2041ED0", Offset = "0x2040AD0", VA = "0x182041ED0", Slot = "33")]
			get
			{
				return null;
			}
		}

		// Token: 0x060255AE RID: 153006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255AE")]
		[Address(RVA = "0x2041700", Offset = "0x2040300", VA = "0x182041700", Slot = "24")]
		public override void LoadData(string leafId)
		{
		}

		// Token: 0x060255AF RID: 153007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255AF")]
		[Address(RVA = "0x2041800", Offset = "0x2040400", VA = "0x182041800", Slot = "25")]
		public override void RefreshData(ArtMagazineLeafData leafData)
		{
		}

		// Token: 0x060255B0 RID: 153008 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60255B0")]
		[Address(RVA = "0x2041620", Offset = "0x2040220", VA = "0x182041620", Slot = "34")]
		protected override Comparison<ArtMagazineDiyDecorHomeThemeItemModel> GetComparisonBySortType(SorterType type)
		{
			return null;
		}

		// Token: 0x060255B1 RID: 153009 RVA: 0x000C79B0 File Offset: 0x000C5BB0
		[Token(Token = "0x60255B1")]
		[Address(RVA = "0x2041B80", Offset = "0x2040780", VA = "0x182041B80")]
		private static int _SortByTsDown(ArtMagazineDiyDecorHomeThemeItemModel a, ArtMagazineDiyDecorHomeThemeItemModel b)
		{
			return 0;
		}

		// Token: 0x060255B2 RID: 153010 RVA: 0x000C79C8 File Offset: 0x000C5BC8
		[Token(Token = "0x60255B2")]
		[Address(RVA = "0x2041C10", Offset = "0x2040810", VA = "0x182041C10")]
		private static int _SortByTsUp(ArtMagazineDiyDecorHomeThemeItemModel a, ArtMagazineDiyDecorHomeThemeItemModel b)
		{
			return 0;
		}

		// Token: 0x060255B3 RID: 153011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60255B3")]
		[Address(RVA = "0x2041CA0", Offset = "0x20408A0", VA = "0x182041CA0")]
		public ArtMagazineDitDecorHomeThemeGroupModel()
		{
		}

		// Token: 0x040346B2 RID: 214706
		[Token(Token = "0x40346B2")]
		[FieldOffset(Offset = "0x20")]
		private EnumIntDictionary<FilterGroupType, ArtMagazineDiyItemFilterModel> m_filterDict;

		// Token: 0x040346B3 RID: 214707
		[Token(Token = "0x40346B3")]
		[FieldOffset(Offset = "0x28")]
		private int m_itemMaxSelectNum;

		// Token: 0x040346B4 RID: 214708
		[Token(Token = "0x40346B4")]
		[FieldOffset(Offset = "0x30")]
		private ListDict<string, ArtMagazineDiyDecorHomeThemeItemModel> m_totalItemDict;

		// Token: 0x040346B6 RID: 214710
		[Token(Token = "0x40346B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_itemMaxSelectNum;

		// Token: 0x040346B7 RID: 214711
		[Token(Token = "0x40346B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_sorter;

		// Token: 0x040346B8 RID: 214712
		[Token(Token = "0x40346B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_sorter;

		// Token: 0x040346B9 RID: 214713
		[Token(Token = "0x40346B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_filterDict;

		// Token: 0x040346BA RID: 214714
		[Token(Token = "0x40346BA")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_totalItemDict;

		// Token: 0x040346BB RID: 214715
		[Token(Token = "0x40346BB")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040346BC RID: 214716
		[Token(Token = "0x40346BC")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_RefreshData;

		// Token: 0x040346BD RID: 214717
		[Token(Token = "0x40346BD")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetComparisonBySortType;

		// Token: 0x040346BE RID: 214718
		[Token(Token = "0x40346BE")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__SortByTsDown;

		// Token: 0x040346BF RID: 214719
		[Token(Token = "0x40346BF")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SortByTsUp;

		// Token: 0x040346C0 RID: 214720
		[Token(Token = "0x40346C0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
