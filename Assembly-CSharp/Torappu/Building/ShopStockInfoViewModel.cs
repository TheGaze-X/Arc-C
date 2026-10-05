using System;
using Il2CppDummyDll;

namespace Torappu.Building
{
	// Token: 0x02001816 RID: 6166
	[Token(Token = "0x2001816")]
	public class ShopStockInfoViewModel
	{
		// Token: 0x06009C0C RID: 39948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C0C")]
		[Address(RVA = "0x3187EE0", Offset = "0x3186AE0", VA = "0x183187EE0")]
		public void LoadData(int index, RoomSlotModel slotModel, BuildingData.ShopPhase shopData, PlayerBuildingShopStock playerStock)
		{
		}

		// Token: 0x06009C0D RID: 39949 RVA: 0x0003CCF0 File Offset: 0x0003AEF0
		[Token(Token = "0x6009C0D")]
		[Address(RVA = "0x3187B90", Offset = "0x3186790", VA = "0x183187B90")]
		public ShopStockSnapshot CurrentSnapshot()
		{
			return default(ShopStockSnapshot);
		}

		// Token: 0x06009C0E RID: 39950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6009C0E")]
		[Address(RVA = "0x31883D0", Offset = "0x3186FD0", VA = "0x1831883D0")]
		public ShopStockInfoViewModel()
		{
		}

		// Token: 0x040092D7 RID: 37591
		[Token(Token = "0x40092D7")]
		[FieldOffset(Offset = "0x10")]
		public ShopStockSnapshot serviceSnapshot;

		// Token: 0x040092D8 RID: 37592
		[Token(Token = "0x40092D8")]
		[FieldOffset(Offset = "0x48")]
		public int index;

		// Token: 0x040092D9 RID: 37593
		[Token(Token = "0x40092D9")]
		[FieldOffset(Offset = "0x4C")]
		public float buffSpeed;

		// Token: 0x040092DA RID: 37594
		[Token(Token = "0x40092DA")]
		[FieldOffset(Offset = "0x50")]
		public float baseSpeed;

		// Token: 0x040092DB RID: 37595
		[Token(Token = "0x40092DB")]
		[FieldOffset(Offset = "0x54")]
		public bool isWorking;

		// Token: 0x040092DC RID: 37596
		[Token(Token = "0x40092DC")]
		[FieldOffset(Offset = "0x58")]
		public BuildingCharModel character;

		// Token: 0x040092DD RID: 37597
		[Token(Token = "0x40092DD")]
		[FieldOffset(Offset = "0xD0")]
		public BuildingData.ShopFormula formula;

		// Token: 0x040092DE RID: 37598
		[Token(Token = "0x40092DE")]
		[FieldOffset(Offset = "0xD8")]
		public int maxCount;

		// Token: 0x040092DF RID: 37599
		[Token(Token = "0x40092DF")]
		[FieldOffset(Offset = "0xDC")]
		public bool isUnlocked;

		// Token: 0x040092E0 RID: 37600
		[Token(Token = "0x40092E0")]
		[FieldOffset(Offset = "0xE0")]
		public int secsPerItem;
	}
}
