using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building
{
	// Token: 0x0200181C RID: 6172
	[Token(Token = "0x200181C")]
	[Serializable]
	public struct TradingOrderStruct : IHotfixable
	{
		// Token: 0x06009C1E RID: 39966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C1E")]
		[Address(RVA = "0x3189580", Offset = "0x3188180", VA = "0x183189580")]
		public void LoadData(PlayerBuildingTradingOrder playerOrder)
		{
		}

		// Token: 0x04009307 RID: 37639
		[Token(Token = "0x4009307")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		public static readonly TradingOrderStruct EMPTY;

		// Token: 0x04009308 RID: 37640
		[Token(Token = "0x4009308")]
		[FieldOffset(Offset = "0x0")]
		public long orderId;

		// Token: 0x04009309 RID: 37641
		[Token(Token = "0x4009309")]
		[FieldOffset(Offset = "0x8")]
		public BuildingData.OrderType type;

		// Token: 0x0400930A RID: 37642
		[Token(Token = "0x400930A")]
		[FieldOffset(Offset = "0x10")]
		public ShallowEqualArray<TradingOrderRequireStruct> requires;

		// Token: 0x0400930B RID: 37643
		[Token(Token = "0x400930B")]
		[FieldOffset(Offset = "0x18")]
		public TradingOrderReward rewardType;

		// Token: 0x0400930C RID: 37644
		[Token(Token = "0x400930C")]
		[FieldOffset(Offset = "0x1C")]
		public int rewardCount;

		// Token: 0x0400930D RID: 37645
		[Token(Token = "0x400930D")]
		[FieldOffset(Offset = "0x20")]
		public long sortId;

		// Token: 0x0400930E RID: 37646
		[Token(Token = "0x400930E")]
		[FieldOffset(Offset = "0x28")]
		public bool isComplete;

		// Token: 0x0400930F RID: 37647
		[Token(Token = "0x400930F")]
		[FieldOffset(Offset = "0x30")]
		public ShallowEqualArray<TradingOrderBuffStruct> buffs;

		// Token: 0x04009310 RID: 37648
		[Token(Token = "0x4009310")]
		[FieldOffset(Offset = "0x38")]
		public bool extraCost;

		// Token: 0x04009311 RID: 37649
		[Token(Token = "0x4009311")]
		[FieldOffset(Offset = "0x40")]
		public PlayerBuildingTradingOrder.TradingGoldTag tradingTag;

		// Token: 0x04009312 RID: 37650
		[Token(Token = "0x4009312")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_LoadData;
	}
}
