using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000A6B RID: 2667
	[Token(Token = "0x2000A6B")]
	public class PlayerBuildingTradingOrder
	{
		// Token: 0x06006729 RID: 26409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006729")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerBuildingTradingOrder()
		{
		}

		// Token: 0x040038AF RID: 14511
		[Token(Token = "0x40038AF")]
		[FieldOffset(Offset = "0x10")]
		public long instId;

		// Token: 0x040038B0 RID: 14512
		[Token(Token = "0x40038B0")]
		[FieldOffset(Offset = "0x18")]
		[JsonConverter(typeof(StringEnumConverter))]
		public BuildingData.OrderType type;

		// Token: 0x040038B1 RID: 14513
		[Token(Token = "0x40038B1")]
		[FieldOffset(Offset = "0x20")]
		public ItemBundle[] delivery;

		// Token: 0x040038B2 RID: 14514
		[Token(Token = "0x40038B2")]
		[FieldOffset(Offset = "0x28")]
		public ItemBundle gain;

		// Token: 0x040038B3 RID: 14515
		[Token(Token = "0x40038B3")]
		[FieldOffset(Offset = "0x30")]
		public PlayerBuildingTradingOrder.TradingOrderBuff[] buff;

		// Token: 0x040038B4 RID: 14516
		[Token(Token = "0x40038B4")]
		[FieldOffset(Offset = "0x38")]
		[JsonProperty("isViolated")]
		public bool extraCost;

		// Token: 0x040038B5 RID: 14517
		[Token(Token = "0x40038B5")]
		[FieldOffset(Offset = "0x40")]
		public PlayerBuildingTradingOrder.TradingGoldTag specGoldTag;

		// Token: 0x02000A6C RID: 2668
		[Token(Token = "0x2000A6C")]
		public class TradingOrderBuff
		{
			// Token: 0x0600672A RID: 26410 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600672A")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TradingOrderBuff()
			{
			}

			// Token: 0x040038B6 RID: 14518
			[Token(Token = "0x40038B6")]
			[FieldOffset(Offset = "0x10")]
			public string from;

			// Token: 0x040038B7 RID: 14519
			[Token(Token = "0x40038B7")]
			[FieldOffset(Offset = "0x18")]
			public int param;
		}

		// Token: 0x02000A6D RID: 2669
		[Token(Token = "0x2000A6D")]
		[Serializable]
		public struct TradingGoldTag
		{
			// Token: 0x040038B8 RID: 14520
			[Token(Token = "0x40038B8")]
			[FieldOffset(Offset = "0x0")]
			public bool activated;

			// Token: 0x040038B9 RID: 14521
			[Token(Token = "0x40038B9")]
			[FieldOffset(Offset = "0x8")]
			public string from;
		}
	}
}
