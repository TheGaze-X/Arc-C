using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D03 RID: 19715
	[Token(Token = "0x2004D03")]
	public class GrocerySellViewModel : IHotfixable
	{
		// Token: 0x17004561 RID: 17761
		// (get) Token: 0x0601D8C8 RID: 121032 RVA: 0x000ABDF8 File Offset: 0x000A9FF8
		// (set) Token: 0x0601D8C9 RID: 121033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004561")]
		public int selectPrice
		{
			[Token(Token = "0x601D8C8")]
			[Address(RVA = "0x1720BA0", Offset = "0x171F7A0", VA = "0x181720BA0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601D8C9")]
			[Address(RVA = "0x1720C70", Offset = "0x171F870", VA = "0x181720C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004562 RID: 17762
		// (get) Token: 0x0601D8CA RID: 121034 RVA: 0x000ABE10 File Offset: 0x000AA010
		// (set) Token: 0x0601D8CB RID: 121035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17004562")]
		public int resetPriceSelection
		{
			[Token(Token = "0x601D8CA")]
			[Address(RVA = "0x1720B40", Offset = "0x171F740", VA = "0x181720B40")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x601D8CB")]
			[Address(RVA = "0x1720C00", Offset = "0x171F800", VA = "0x181720C00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17004563 RID: 17763
		// (get) Token: 0x0601D8CC RID: 121036 RVA: 0x000ABE28 File Offset: 0x000AA028
		[Token(Token = "0x17004563")]
		public GrocerySellViewModel.InquireStatus inquireStatus
		{
			[Token(Token = "0x601D8CC")]
			[Address(RVA = "0x17209F0", Offset = "0x171F5F0", VA = "0x1817209F0")]
			get
			{
				return GrocerySellViewModel.InquireStatus.UNKNOWN;
			}
		}

		// Token: 0x17004564 RID: 17764
		// (get) Token: 0x0601D8CD RID: 121037 RVA: 0x000ABE40 File Offset: 0x000AA040
		[Token(Token = "0x17004564")]
		public bool needInquire
		{
			[Token(Token = "0x601D8CD")]
			[Address(RVA = "0x1720AA0", Offset = "0x171F6A0", VA = "0x181720AA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601D8CE RID: 121038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8CE")]
		[Address(RVA = "0x171F370", Offset = "0x171DF70", VA = "0x18171F370")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0601D8CF RID: 121039 RVA: 0x000ABE58 File Offset: 0x000AA058
		[Token(Token = "0x601D8CF")]
		[Address(RVA = "0x171F2D0", Offset = "0x171DED0", VA = "0x18171F2D0")]
		public int GetDefaultPrice()
		{
			return 0;
		}

		// Token: 0x0601D8D0 RID: 121040 RVA: 0x000ABE70 File Offset: 0x000AA070
		[Token(Token = "0x601D8D0")]
		[Address(RVA = "0x171F1F0", Offset = "0x171DDF0", VA = "0x18171F1F0")]
		public int FindSelectPriceIndex()
		{
			return 0;
		}

		// Token: 0x0601D8D1 RID: 121041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8D1")]
		[Address(RVA = "0x171F6E0", Offset = "0x171E2E0", VA = "0x18171F6E0")]
		public void UpdateSelectPrice(int selectPrice, bool markForceResetPrice = false)
		{
		}

		// Token: 0x0601D8D2 RID: 121042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D8D2")]
		[Address(RVA = "0x171FCC0", Offset = "0x171E8C0", VA = "0x18171FCC0")]
		private Act27SideData.Act27SideGoodData _LoadGoodData(Act27SideData.Act27SideGoodLaunchData launchData, Act27SideData gameData, PlayerActivity.PlayerAct27SideActivity playerData)
		{
			return null;
		}

		// Token: 0x0601D8D3 RID: 121043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D8D3")]
		[Address(RVA = "0x1720180", Offset = "0x171ED80", VA = "0x181720180")]
		private Act27SideData.Act27SideGoodLaunchData _LoadLaunchData(Act27SideData gameData, PlayerActivity.PlayerAct27SideActivity playerData)
		{
			return null;
		}

		// Token: 0x0601D8D4 RID: 121044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8D4")]
		[Address(RVA = "0x17202D0", Offset = "0x171EED0", VA = "0x1817202D0")]
		private void _LoadShopDataAndPriceData(Act27SideData.Act27SideGoodData goodData, Act27SideData gameData, PlayerActivity.PlayerAct27SideActivity playerData)
		{
		}

		// Token: 0x0601D8D5 RID: 121045 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D8D5")]
		[Address(RVA = "0x171FAB0", Offset = "0x171E6B0", VA = "0x18171FAB0")]
		private PlayerActivity.PlayerAct27SideActivity.PreSellInfo _FindPreSellInfo(int price, PlayerActivity.PlayerAct27SideActivity playerData)
		{
			return null;
		}

		// Token: 0x0601D8D6 RID: 121046 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D8D6")]
		[Address(RVA = "0x171FBF0", Offset = "0x171E7F0", VA = "0x18171FBF0")]
		private int[] _GetCustomerCountArray(PlayerActivity.PlayerAct27SideActivity.PreSellInfo sellInfo, string shopId)
		{
			return null;
		}

		// Token: 0x0601D8D7 RID: 121047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8D7")]
		[Address(RVA = "0x17208E0", Offset = "0x171F4E0", VA = "0x1817208E0")]
		public GrocerySellViewModel()
		{
		}

		// Token: 0x04026FF0 RID: 159728
		[Token(Token = "0x4026FF0")]
		[FieldOffset(Offset = "0x14")]
		public int totalCustomer;

		// Token: 0x04026FF1 RID: 159729
		[Token(Token = "0x4026FF1")]
		[FieldOffset(Offset = "0x18")]
		public PlayerActivity.PlayerAct27SideActivity.SellGoodState currentSellGood;

		// Token: 0x04026FF2 RID: 159730
		[Token(Token = "0x4026FF2")]
		[FieldOffset(Offset = "0x1C")]
		public int maxProgressCount;

		// Token: 0x04026FF3 RID: 159731
		[Token(Token = "0x4026FF3")]
		[FieldOffset(Offset = "0x20")]
		public string goodId;

		// Token: 0x04026FF4 RID: 159732
		[Token(Token = "0x4026FF4")]
		[FieldOffset(Offset = "0x28")]
		public string goodName;

		// Token: 0x04026FF5 RID: 159733
		[Token(Token = "0x4026FF5")]
		[FieldOffset(Offset = "0x30")]
		public string goodIconId;

		// Token: 0x04026FF6 RID: 159734
		[Token(Token = "0x4026FF6")]
		[FieldOffset(Offset = "0x38")]
		public string sellDesc;

		// Token: 0x04026FF7 RID: 159735
		[Token(Token = "0x4026FF7")]
		[FieldOffset(Offset = "0x40")]
		public List<int> goodPriceList;

		// Token: 0x04026FF8 RID: 159736
		[Token(Token = "0x4026FF8")]
		[FieldOffset(Offset = "0x48")]
		public int goodStock;

		// Token: 0x04026FF9 RID: 159737
		[Token(Token = "0x4026FF9")]
		[FieldOffset(Offset = "0x50")]
		public string actId;

		// Token: 0x04026FFA RID: 159738
		[Token(Token = "0x4026FFA")]
		[FieldOffset(Offset = "0x58")]
		public int inquireCount;

		// Token: 0x04026FFB RID: 159739
		[Token(Token = "0x4026FFB")]
		[FieldOffset(Offset = "0x5C")]
		public int inquireTotal;

		// Token: 0x04026FFC RID: 159740
		[Token(Token = "0x4026FFC")]
		[FieldOffset(Offset = "0x60")]
		public bool hasSold;

		// Token: 0x04026FFE RID: 159742
		[Token(Token = "0x4026FFE")]
		[FieldOffset(Offset = "0x68")]
		public List<GrocerySellResultShopModel> shopList;

		// Token: 0x04026FFF RID: 159743
		[Token(Token = "0x4026FFF")]
		[FieldOffset(Offset = "0x70")]
		public GrocerySellCustomerModel currCustomerInfo;

		// Token: 0x04027000 RID: 159744
		[Token(Token = "0x4027000")]
		[FieldOffset(Offset = "0x78")]
		private string m_playerShopId;

		// Token: 0x04027001 RID: 159745
		[Token(Token = "0x4027001")]
		[FieldOffset(Offset = "0x80")]
		private List<GrocerySellCustomerModel> m_customerInfoList;

		// Token: 0x04027002 RID: 159746
		[Token(Token = "0x4027002")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectPrice;

		// Token: 0x04027003 RID: 159747
		[Token(Token = "0x4027003")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectPrice;

		// Token: 0x04027004 RID: 159748
		[Token(Token = "0x4027004")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_resetPriceSelection;

		// Token: 0x04027005 RID: 159749
		[Token(Token = "0x4027005")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_resetPriceSelection;

		// Token: 0x04027006 RID: 159750
		[Token(Token = "0x4027006")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_inquireStatus;

		// Token: 0x04027007 RID: 159751
		[Token(Token = "0x4027007")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_needInquire;

		// Token: 0x04027008 RID: 159752
		[Token(Token = "0x4027008")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04027009 RID: 159753
		[Token(Token = "0x4027009")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_GetDefaultPrice;

		// Token: 0x0402700A RID: 159754
		[Token(Token = "0x402700A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_FindSelectPriceIndex;

		// Token: 0x0402700B RID: 159755
		[Token(Token = "0x402700B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateSelectPrice;

		// Token: 0x0402700C RID: 159756
		[Token(Token = "0x402700C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__LoadGoodData;

		// Token: 0x0402700D RID: 159757
		[Token(Token = "0x402700D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LoadLaunchData;

		// Token: 0x0402700E RID: 159758
		[Token(Token = "0x402700E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__LoadShopDataAndPriceData;

		// Token: 0x0402700F RID: 159759
		[Token(Token = "0x402700F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__FindPreSellInfo;

		// Token: 0x04027010 RID: 159760
		[Token(Token = "0x4027010")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__GetCustomerCountArray;

		// Token: 0x04027011 RID: 159761
		[Token(Token = "0x4027011")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004D04 RID: 19716
		[Token(Token = "0x2004D04")]
		public enum InquireStatus
		{
			// Token: 0x04027013 RID: 159763
			[Token(Token = "0x4027013")]
			UNKNOWN,
			// Token: 0x04027014 RID: 159764
			[Token(Token = "0x4027014")]
			KNOWN
		}
	}
}
