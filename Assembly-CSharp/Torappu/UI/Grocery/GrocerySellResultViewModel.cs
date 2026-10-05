using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D0A RID: 19722
	[Token(Token = "0x2004D0A")]
	public class GrocerySellResultViewModel : IHotfixable
	{
		// Token: 0x17004566 RID: 17766
		// (get) Token: 0x0601D8EC RID: 121068 RVA: 0x000ABED0 File Offset: 0x000AA0D0
		[Token(Token = "0x17004566")]
		public bool isLastSellState
		{
			[Token(Token = "0x601D8EC")]
			[Address(RVA = "0x171B9B0", Offset = "0x171A5B0", VA = "0x18171B9B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17004567 RID: 17767
		// (get) Token: 0x0601D8ED RID: 121069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004567")]
		public List<RewardItemModel> cachedRewards
		{
			[Token(Token = "0x601D8ED")]
			[Address(RVA = "0x171B950", Offset = "0x171A550", VA = "0x18171B950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17004568 RID: 17768
		// (get) Token: 0x0601D8EE RID: 121070 RVA: 0x000ABEE8 File Offset: 0x000AA0E8
		[Token(Token = "0x17004568")]
		public PlayerActivity.PlayerAct27SideActivity.SellGoodState activeState
		{
			[Token(Token = "0x601D8EE")]
			[Address(RVA = "0x171B8F0", Offset = "0x171A4F0", VA = "0x18171B8F0")]
			get
			{
				return PlayerActivity.PlayerAct27SideActivity.SellGoodState.NONE;
			}
		}

		// Token: 0x0601D8EF RID: 121071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8EF")]
		[Address(RVA = "0x171B2A0", Offset = "0x1719EA0", VA = "0x18171B2A0")]
		public void LoadData(string actId, PlayerActivity.PlayerAct27SideActivity.SellGoodState activeState)
		{
		}

		// Token: 0x0601D8F0 RID: 121072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8F0")]
		[Address(RVA = "0x171B500", Offset = "0x171A100", VA = "0x18171B500")]
		public void UpdateDataByResponce(int lastFund, List<RewardItemModel> rewards)
		{
		}

		// Token: 0x0601D8F1 RID: 121073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D8F1")]
		[Address(RVA = "0x171AE80", Offset = "0x1719A80", VA = "0x18171AE80")]
		public GrocerySellResultStateSellViewModel GetActiveStateSellModel()
		{
			return null;
		}

		// Token: 0x0601D8F2 RID: 121074 RVA: 0x000ABF00 File Offset: 0x000AA100
		[Token(Token = "0x601D8F2")]
		[Address(RVA = "0x171AF30", Offset = "0x1719B30", VA = "0x18171AF30")]
		public GrocerySellResultViewModel.IncomingLogData GetIncomingLogDataNotNull()
		{
			return default(GrocerySellResultViewModel.IncomingLogData);
		}

		// Token: 0x0601D8F3 RID: 121075 RVA: 0x000ABF18 File Offset: 0x000AA118
		[Token(Token = "0x601D8F3")]
		[Address(RVA = "0x171B5A0", Offset = "0x171A1A0", VA = "0x18171B5A0")]
		private bool _TryGetGoodIdFromSellGoodState(string actId, string groupId, PlayerActivity.PlayerAct27SideActivity.SellGoodState state, out string goodId)
		{
			return default(bool);
		}

		// Token: 0x0601D8F4 RID: 121076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D8F4")]
		[Address(RVA = "0x171B840", Offset = "0x171A440", VA = "0x18171B840")]
		public GrocerySellResultViewModel()
		{
		}

		// Token: 0x0402704F RID: 159823
		[Token(Token = "0x402704F")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<PlayerActivity.PlayerAct27SideActivity.SellGoodState, GrocerySellResultStateSellViewModel> sellGoodViewModelDict;

		// Token: 0x04027050 RID: 159824
		[Token(Token = "0x4027050")]
		[FieldOffset(Offset = "0x18")]
		public int day;

		// Token: 0x04027051 RID: 159825
		[Token(Token = "0x4027051")]
		[FieldOffset(Offset = "0x20")]
		public ItemBundle dailyReward;

		// Token: 0x04027052 RID: 159826
		[Token(Token = "0x4027052")]
		[FieldOffset(Offset = "0x28")]
		private PlayerActivity.PlayerAct27SideActivity.SellGoodState m_activeState;

		// Token: 0x04027053 RID: 159827
		[Token(Token = "0x4027053")]
		[FieldOffset(Offset = "0x2C")]
		private int m_lastDayFund;

		// Token: 0x04027054 RID: 159828
		[Token(Token = "0x4027054")]
		[FieldOffset(Offset = "0x30")]
		private List<RewardItemModel> m_cachedRewards;

		// Token: 0x04027055 RID: 159829
		[Token(Token = "0x4027055")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isLastSellState;

		// Token: 0x04027056 RID: 159830
		[Token(Token = "0x4027056")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cachedRewards;

		// Token: 0x04027057 RID: 159831
		[Token(Token = "0x4027057")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_activeState;

		// Token: 0x04027058 RID: 159832
		[Token(Token = "0x4027058")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04027059 RID: 159833
		[Token(Token = "0x4027059")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateDataByResponce;

		// Token: 0x0402705A RID: 159834
		[Token(Token = "0x402705A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetActiveStateSellModel;

		// Token: 0x0402705B RID: 159835
		[Token(Token = "0x402705B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GetIncomingLogDataNotNull;

		// Token: 0x0402705C RID: 159836
		[Token(Token = "0x402705C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryGetGoodIdFromSellGoodState;

		// Token: 0x0402705D RID: 159837
		[Token(Token = "0x402705D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004D0B RID: 19723
		[Token(Token = "0x2004D0B")]
		public struct IncomingLogData
		{
			// Token: 0x0402705E RID: 159838
			[Token(Token = "0x402705E")]
			[FieldOffset(Offset = "0x0")]
			public int lastDayFund;

			// Token: 0x0402705F RID: 159839
			[Token(Token = "0x402705F")]
			[FieldOffset(Offset = "0x4")]
			public int thisDayFund;

			// Token: 0x04027060 RID: 159840
			[Token(Token = "0x4027060")]
			[FieldOffset(Offset = "0x8")]
			public int purchaseCostTotal;

			// Token: 0x04027061 RID: 159841
			[Token(Token = "0x4027061")]
			[FieldOffset(Offset = "0xC")]
			public int sellIncomeTotal;

			// Token: 0x04027062 RID: 159842
			[Token(Token = "0x4027062")]
			[FieldOffset(Offset = "0x10")]
			public int prizeIncomeTotal;

			// Token: 0x04027063 RID: 159843
			[Token(Token = "0x4027063")]
			[FieldOffset(Offset = "0x14")]
			public int netIncome;
		}
	}
}
