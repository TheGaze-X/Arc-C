using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CDC RID: 19676
	[Token(Token = "0x2004CDC")]
	public class GroceryOrderSelfShopViewModel : IHotfixable
	{
		// Token: 0x17004522 RID: 17698
		// (get) Token: 0x0601D797 RID: 120727 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D798 RID: 120728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004522")]
		public string goodId
		{
			[Token(Token = "0x601D797")]
			[Address(RVA = "0x1702DF0", Offset = "0x17019F0", VA = "0x181702DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601D798")]
			[Address(RVA = "0x1703290", Offset = "0x1701E90", VA = "0x181703290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004523 RID: 17699
		// (get) Token: 0x0601D799 RID: 120729 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601D79A RID: 120730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004523")]
		public string shopId
		{
			[Token(Token = "0x601D799")]
			[Address(RVA = "0x1703030", Offset = "0x1701C30", VA = "0x181703030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601D79A")]
			[Address(RVA = "0x1703540", Offset = "0x1702140", VA = "0x181703540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004524 RID: 17700
		// (get) Token: 0x0601D79B RID: 120731 RVA: 0x000AB918 File Offset: 0x000A9B18
		// (set) Token: 0x0601D79C RID: 120732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004524")]
		public int curSelectingStrategyIndex
		{
			[Token(Token = "0x601D79B")]
			[Address(RVA = "0x1702D30", Offset = "0x1701930", VA = "0x181702D30")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601D79C")]
			[Address(RVA = "0x17031B0", Offset = "0x1701DB0", VA = "0x1817031B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004525 RID: 17701
		// (get) Token: 0x0601D79D RID: 120733 RVA: 0x000AB930 File Offset: 0x000A9B30
		// (set) Token: 0x0601D79E RID: 120734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004525")]
		public bool isExactOrderCount
		{
			[Token(Token = "0x601D79D")]
			[Address(RVA = "0x1702E50", Offset = "0x1701A50", VA = "0x181702E50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601D79E")]
			[Address(RVA = "0x1703310", Offset = "0x1701F10", VA = "0x181703310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004526 RID: 17702
		// (get) Token: 0x0601D79F RID: 120735 RVA: 0x000AB948 File Offset: 0x000A9B48
		// (set) Token: 0x0601D7A0 RID: 120736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004526")]
		public int exactOrderCount
		{
			[Token(Token = "0x601D79F")]
			[Address(RVA = "0x1702D90", Offset = "0x1701990", VA = "0x181702D90")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601D7A0")]
			[Address(RVA = "0x1703220", Offset = "0x1701E20", VA = "0x181703220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004527 RID: 17703
		// (get) Token: 0x0601D7A1 RID: 120737 RVA: 0x000AB960 File Offset: 0x000A9B60
		// (set) Token: 0x0601D7A2 RID: 120738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004527")]
		public bool isSectionOrderCount
		{
			[Token(Token = "0x601D7A1")]
			[Address(RVA = "0x1702F10", Offset = "0x1701B10", VA = "0x181702F10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601D7A2")]
			[Address(RVA = "0x17033F0", Offset = "0x1701FF0", VA = "0x1817033F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004528 RID: 17704
		// (get) Token: 0x0601D7A3 RID: 120739 RVA: 0x000AB978 File Offset: 0x000A9B78
		// (set) Token: 0x0601D7A4 RID: 120740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004528")]
		public int sectionDownCount
		{
			[Token(Token = "0x601D7A3")]
			[Address(RVA = "0x1702F70", Offset = "0x1701B70", VA = "0x181702F70")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601D7A4")]
			[Address(RVA = "0x1703460", Offset = "0x1702060", VA = "0x181703460")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004529 RID: 17705
		// (get) Token: 0x0601D7A5 RID: 120741 RVA: 0x000AB990 File Offset: 0x000A9B90
		// (set) Token: 0x0601D7A6 RID: 120742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004529")]
		public int sectionUpCount
		{
			[Token(Token = "0x601D7A5")]
			[Address(RVA = "0x1702FD0", Offset = "0x1701BD0", VA = "0x181702FD0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601D7A6")]
			[Address(RVA = "0x17034D0", Offset = "0x17020D0", VA = "0x1817034D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700452A RID: 17706
		// (get) Token: 0x0601D7A7 RID: 120743 RVA: 0x000AB9A8 File Offset: 0x000A9BA8
		// (set) Token: 0x0601D7A8 RID: 120744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700452A")]
		public bool isPermanentGood
		{
			[Token(Token = "0x601D7A7")]
			[Address(RVA = "0x1702EB0", Offset = "0x1701AB0", VA = "0x181702EB0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601D7A8")]
			[Address(RVA = "0x1703380", Offset = "0x1701F80", VA = "0x181703380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700452B RID: 17707
		// (get) Token: 0x0601D7A9 RID: 120745 RVA: 0x000AB9C0 File Offset: 0x000A9BC0
		// (set) Token: 0x0601D7AA RID: 120746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700452B")]
		public int stockCount
		{
			[Token(Token = "0x601D7A9")]
			[Address(RVA = "0x17030F0", Offset = "0x1701CF0", VA = "0x1817030F0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601D7AA")]
			[Address(RVA = "0x17035C0", Offset = "0x17021C0", VA = "0x1817035C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700452C RID: 17708
		// (get) Token: 0x0601D7AB RID: 120747 RVA: 0x000AB9D8 File Offset: 0x000A9BD8
		[Token(Token = "0x1700452C")]
		public GroceryOrderMyShopStatus status
		{
			[Token(Token = "0x601D7AB")]
			[Address(RVA = "0x1703090", Offset = "0x1701C90", VA = "0x181703090")]
			get
			{
				return GroceryOrderMyShopStatus.NONE;
			}
		}

		// Token: 0x1700452D RID: 17709
		// (get) Token: 0x0601D7AC RID: 120748 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700452D")]
		public List<GroceryOrderSelfShopStrategyItemViewModel> strategyItemViewModelList
		{
			[Token(Token = "0x601D7AC")]
			[Address(RVA = "0x1703150", Offset = "0x1701D50", VA = "0x181703150")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601D7AD RID: 120749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7AD")]
		[Address(RVA = "0x1702220", Offset = "0x1700E20", VA = "0x181702220")]
		public void LoadData(Act27SideData.Act27SideGoodData goodData, Act27SideData.Act27SideShopData shopData, List<string> strategyList)
		{
		}

		// Token: 0x0601D7AE RID: 120750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7AE")]
		[Address(RVA = "0x1702750", Offset = "0x1701350", VA = "0x181702750")]
		public void RefreshShopExpectedOrder(int[] order)
		{
		}

		// Token: 0x0601D7AF RID: 120751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7AF")]
		[Address(RVA = "0x1702B50", Offset = "0x1701750", VA = "0x181702B50")]
		public void RefreshShopGoodStockCount(int stock)
		{
		}

		// Token: 0x0601D7B0 RID: 120752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7B0")]
		[Address(RVA = "0x1702600", Offset = "0x1701200", VA = "0x181702600")]
		public void RefreshCurSelectIndex(int index)
		{
		}

		// Token: 0x0601D7B1 RID: 120753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D7B1")]
		[Address(RVA = "0x1702C20", Offset = "0x1701820", VA = "0x181702C20")]
		public GroceryOrderSelfShopViewModel()
		{
		}

		// Token: 0x04026E07 RID: 159239
		[Token(Token = "0x4026E07")]
		[FieldOffset(Offset = "0x40")]
		private GroceryOrderMyShopStatus m_status;

		// Token: 0x04026E08 RID: 159240
		[Token(Token = "0x4026E08")]
		[FieldOffset(Offset = "0x48")]
		private List<GroceryOrderSelfShopStrategyItemViewModel> m_strategyItemViewModelList;

		// Token: 0x04026E09 RID: 159241
		[Token(Token = "0x4026E09")]
		[FieldOffset(Offset = "0x50")]
		private List<int> m_orderCount;

		// Token: 0x04026E0A RID: 159242
		[Token(Token = "0x4026E0A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_goodId;

		// Token: 0x04026E0B RID: 159243
		[Token(Token = "0x4026E0B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_goodId;

		// Token: 0x04026E0C RID: 159244
		[Token(Token = "0x4026E0C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_shopId;

		// Token: 0x04026E0D RID: 159245
		[Token(Token = "0x4026E0D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_shopId;

		// Token: 0x04026E0E RID: 159246
		[Token(Token = "0x4026E0E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_curSelectingStrategyIndex;

		// Token: 0x04026E0F RID: 159247
		[Token(Token = "0x4026E0F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_curSelectingStrategyIndex;

		// Token: 0x04026E10 RID: 159248
		[Token(Token = "0x4026E10")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isExactOrderCount;

		// Token: 0x04026E11 RID: 159249
		[Token(Token = "0x4026E11")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_isExactOrderCount;

		// Token: 0x04026E12 RID: 159250
		[Token(Token = "0x4026E12")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_exactOrderCount;

		// Token: 0x04026E13 RID: 159251
		[Token(Token = "0x4026E13")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_exactOrderCount;

		// Token: 0x04026E14 RID: 159252
		[Token(Token = "0x4026E14")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_isSectionOrderCount;

		// Token: 0x04026E15 RID: 159253
		[Token(Token = "0x4026E15")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_set_isSectionOrderCount;

		// Token: 0x04026E16 RID: 159254
		[Token(Token = "0x4026E16")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_sectionDownCount;

		// Token: 0x04026E17 RID: 159255
		[Token(Token = "0x4026E17")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_set_sectionDownCount;

		// Token: 0x04026E18 RID: 159256
		[Token(Token = "0x4026E18")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_sectionUpCount;

		// Token: 0x04026E19 RID: 159257
		[Token(Token = "0x4026E19")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_sectionUpCount;

		// Token: 0x04026E1A RID: 159258
		[Token(Token = "0x4026E1A")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_isPermanentGood;

		// Token: 0x04026E1B RID: 159259
		[Token(Token = "0x4026E1B")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_set_isPermanentGood;

		// Token: 0x04026E1C RID: 159260
		[Token(Token = "0x4026E1C")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_stockCount;

		// Token: 0x04026E1D RID: 159261
		[Token(Token = "0x4026E1D")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_set_stockCount;

		// Token: 0x04026E1E RID: 159262
		[Token(Token = "0x4026E1E")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_status;

		// Token: 0x04026E1F RID: 159263
		[Token(Token = "0x4026E1F")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_strategyItemViewModelList;

		// Token: 0x04026E20 RID: 159264
		[Token(Token = "0x4026E20")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04026E21 RID: 159265
		[Token(Token = "0x4026E21")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_RefreshShopExpectedOrder;

		// Token: 0x04026E22 RID: 159266
		[Token(Token = "0x4026E22")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_RefreshShopGoodStockCount;

		// Token: 0x04026E23 RID: 159267
		[Token(Token = "0x4026E23")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_RefreshCurSelectIndex;

		// Token: 0x04026E24 RID: 159268
		[Token(Token = "0x4026E24")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
