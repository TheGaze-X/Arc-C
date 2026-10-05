using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000A70 RID: 2672
	[Token(Token = "0x2000A70")]
	public class PlayerBuildingTrading
	{
		// Token: 0x0600672D RID: 26413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600672D")]
		[Address(RVA = "0x1EF20E0", Offset = "0x1EF0CE0", VA = "0x181EF20E0")]
		public PlayerBuildingTrading()
		{
		}

		// Token: 0x040038C0 RID: 14528
		[Token(Token = "0x40038C0")]
		[FieldOffset(Offset = "0x10")]
		public PlayerBuildingTradingBuff buff;

		// Token: 0x040038C1 RID: 14529
		[Token(Token = "0x40038C1")]
		[FieldOffset(Offset = "0x18")]
		public PlayerRoomState state;

		// Token: 0x040038C2 RID: 14530
		[Token(Token = "0x40038C2")]
		[FieldOffset(Offset = "0x20")]
		public DateTime lastUpdateTime;

		// Token: 0x040038C3 RID: 14531
		[Token(Token = "0x40038C3")]
		[FieldOffset(Offset = "0x28")]
		[JsonConverter(typeof(StringEnumConverter))]
		public BuildingData.OrderType strategy;

		// Token: 0x040038C4 RID: 14532
		[Token(Token = "0x40038C4")]
		[FieldOffset(Offset = "0x2C")]
		public int stockLimit;

		// Token: 0x040038C5 RID: 14533
		[Token(Token = "0x40038C5")]
		[FieldOffset(Offset = "0x30")]
		public int apCost;

		// Token: 0x040038C6 RID: 14534
		[Token(Token = "0x40038C6")]
		[FieldOffset(Offset = "0x38")]
		public List<PlayerBuildingTradingOrder> stock;

		// Token: 0x040038C7 RID: 14535
		[Token(Token = "0x40038C7")]
		[FieldOffset(Offset = "0x40")]
		public PlayerBuildingTradingNext next;

		// Token: 0x040038C8 RID: 14536
		[Token(Token = "0x40038C8")]
		[FieldOffset(Offset = "0x48")]
		public BuildingBuffDisplay display;

		// Token: 0x040038C9 RID: 14537
		[Token(Token = "0x40038C9")]
		[FieldOffset(Offset = "0x50")]
		public List<List<int>> presetQueue;
	}
}
