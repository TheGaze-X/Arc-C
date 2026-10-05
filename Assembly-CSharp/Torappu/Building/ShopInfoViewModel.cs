using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building
{
	// Token: 0x02001817 RID: 6167
	[Token(Token = "0x2001817")]
	public class ShopInfoViewModel
	{
		// Token: 0x06009C0F RID: 39951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C0F")]
		[Address(RVA = "0x3186F30", Offset = "0x3185B30", VA = "0x183186F30")]
		public void LoadData(RoomSlotModel slotModel, PlayerBuildingShop playerShop)
		{
		}

		// Token: 0x06009C10 RID: 39952 RVA: 0x0003CD08 File Offset: 0x0003AF08
		[Token(Token = "0x6009C10")]
		[Address(RVA = "0x3186B20", Offset = "0x3185720", VA = "0x183186B20")]
		public int CalcTotalOutputCount()
		{
			return 0;
		}

		// Token: 0x06009C11 RID: 39953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C11")]
		[Address(RVA = "0x31877D0", Offset = "0x31863D0", VA = "0x1831877D0")]
		public void UpdateCountDownForStocks(ref CountDownTask[] countDowns, ref ShopStockSnapshot[] snapshots, Action onCountDownTimeout)
		{
		}

		// Token: 0x06009C12 RID: 39954 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6009C12")]
		[Address(RVA = "0x3186CA0", Offset = "0x31858A0", VA = "0x183186CA0")]
		public ListDict<ItemType, int> CalcTotalOutputE()
		{
			return null;
		}

		// Token: 0x06009C13 RID: 39955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C13")]
		[Address(RVA = "0x3187AC0", Offset = "0x31866C0", VA = "0x183187AC0")]
		public ShopInfoViewModel()
		{
		}

		// Token: 0x040092E1 RID: 37601
		[Token(Token = "0x40092E1")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<ItemType, int> serverOutput;

		// Token: 0x040092E2 RID: 37602
		[Token(Token = "0x40092E2")]
		[FieldOffset(Offset = "0x18")]
		public int capacity;

		// Token: 0x040092E3 RID: 37603
		[Token(Token = "0x40092E3")]
		[FieldOffset(Offset = "0x1C")]
		public int unlockStockNum;

		// Token: 0x040092E4 RID: 37604
		[Token(Token = "0x40092E4")]
		[FieldOffset(Offset = "0x20")]
		public List<ShopStockInfoViewModel> stocks;
	}
}
