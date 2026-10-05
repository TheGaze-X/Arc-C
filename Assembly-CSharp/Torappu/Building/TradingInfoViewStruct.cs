using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Building
{
	// Token: 0x02001819 RID: 6169
	[Token(Token = "0x2001819")]
	public struct TradingInfoViewStruct : IHotfixable
	{
		// Token: 0x06009C14 RID: 39956 RVA: 0x0003CD20 File Offset: 0x0003AF20
		[Token(Token = "0x6009C14")]
		[Address(RVA = "0x3188FB0", Offset = "0x3187BB0", VA = "0x183188FB0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x06009C15 RID: 39957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C15")]
		[Address(RVA = "0x3189080", Offset = "0x3187C80", VA = "0x183189080")]
		public void LoadData(RoomSlotModel slotModel, PlayerBuildingTrading playerTrading)
		{
		}

		// Token: 0x040092E9 RID: 37609
		[Token(Token = "0x40092E9")]
		[FieldOffset(Offset = "0x0")]
		public static readonly TradingInfoViewStruct EMPTY;

		// Token: 0x040092EA RID: 37610
		[Token(Token = "0x40092EA")]
		[FieldOffset(Offset = "0x0")]
		public string roomSlotId;

		// Token: 0x040092EB RID: 37611
		[Token(Token = "0x40092EB")]
		[FieldOffset(Offset = "0x8")]
		public int maxChars;

		// Token: 0x040092EC RID: 37612
		[Token(Token = "0x40092EC")]
		[FieldOffset(Offset = "0xC")]
		public int finalMaxChars;

		// Token: 0x040092ED RID: 37613
		[Token(Token = "0x40092ED")]
		[FieldOffset(Offset = "0x10")]
		public BuildingCharModel[] chars;

		// Token: 0x040092EE RID: 37614
		[Token(Token = "0x40092EE")]
		[FieldOffset(Offset = "0x18")]
		public long mpCostPerHourBase;

		// Token: 0x040092EF RID: 37615
		[Token(Token = "0x40092EF")]
		[FieldOffset(Offset = "0x20")]
		public long mpCostPerHourBuffSpec;

		// Token: 0x040092F0 RID: 37616
		[Token(Token = "0x40092F0")]
		[FieldOffset(Offset = "0x28")]
		public long mpCostPerHourBuffBase;

		// Token: 0x040092F1 RID: 37617
		[Token(Token = "0x40092F1")]
		[FieldOffset(Offset = "0x30")]
		public float orderSpeedBuffBase;

		// Token: 0x040092F2 RID: 37618
		[Token(Token = "0x40092F2")]
		[FieldOffset(Offset = "0x34")]
		public float orderSpeedBuffSpec;

		// Token: 0x040092F3 RID: 37619
		[Token(Token = "0x40092F3")]
		[FieldOffset(Offset = "0x38")]
		public BuildingData.OrderType preferredType;

		// Token: 0x040092F4 RID: 37620
		[Token(Token = "0x40092F4")]
		[FieldOffset(Offset = "0x3C")]
		public bool isStrategyEnabled;

		// Token: 0x040092F5 RID: 37621
		[Token(Token = "0x40092F5")]
		[FieldOffset(Offset = "0x40")]
		public int orderNumLimit;

		// Token: 0x040092F6 RID: 37622
		[Token(Token = "0x40092F6")]
		[FieldOffset(Offset = "0x48")]
		public ListDict<long, TradingOrderStruct> orders;

		// Token: 0x040092F7 RID: 37623
		[Token(Token = "0x40092F7")]
		[FieldOffset(Offset = "0x50")]
		public long nextOrder;

		// Token: 0x040092F8 RID: 37624
		[Token(Token = "0x40092F8")]
		[FieldOffset(Offset = "0x58")]
		public TradingGainOrderSnapshot gainSnapshot;

		// Token: 0x040092F9 RID: 37625
		[Token(Token = "0x40092F9")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_IsEmpty;

		// Token: 0x040092FA RID: 37626
		[Token(Token = "0x40092FA")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_LoadData;
	}
}
