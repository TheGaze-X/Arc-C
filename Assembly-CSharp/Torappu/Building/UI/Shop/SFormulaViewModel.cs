using System;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001CE3 RID: 7395
	[Token(Token = "0x2001CE3")]
	public class SFormulaViewModel
	{
		// Token: 0x0600B6CE RID: 46798 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6CE")]
		[Address(RVA = "0x334E2F0", Offset = "0x334CEF0", VA = "0x18334E2F0")]
		public void LoadData(BuildingData.ShopFormula formula, ShopStockSnapshot snapshot, float speed)
		{
		}

		// Token: 0x0600B6CF RID: 46799 RVA: 0x00045030 File Offset: 0x00043230
		[Token(Token = "0x600B6CF")]
		[Address(RVA = "0x334E0A0", Offset = "0x334CCA0", VA = "0x18334E0A0")]
		public static int CompareShopFormula(SFormulaViewModel a, SFormulaViewModel b, FormulaSortType focusType, bool isInverse)
		{
			return 0;
		}

		// Token: 0x0600B6D0 RID: 46800 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6D0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SFormulaViewModel()
		{
		}

		// Token: 0x0400B487 RID: 46215
		[Token(Token = "0x400B487")]
		[FieldOffset(Offset = "0x10")]
		public int formulaSortId;

		// Token: 0x0400B488 RID: 46216
		[Token(Token = "0x400B488")]
		[FieldOffset(Offset = "0x18")]
		public BuildingData.ShopFormula formula;

		// Token: 0x0400B489 RID: 46217
		[Token(Token = "0x400B489")]
		[FieldOffset(Offset = "0x20")]
		public string itemId;

		// Token: 0x0400B48A RID: 46218
		[Token(Token = "0x400B48A")]
		[FieldOffset(Offset = "0x28")]
		public ItemType itemType;

		// Token: 0x0400B48B RID: 46219
		[Token(Token = "0x400B48B")]
		[FieldOffset(Offset = "0x30")]
		public ItemBundle gainItem;

		// Token: 0x0400B48C RID: 46220
		[Token(Token = "0x400B48C")]
		[FieldOffset(Offset = "0x38")]
		public bool isUnlocked;

		// Token: 0x0400B48D RID: 46221
		[Token(Token = "0x400B48D")]
		[FieldOffset(Offset = "0x3C")]
		public ItemRarity rarity;

		// Token: 0x0400B48E RID: 46222
		[Token(Token = "0x400B48E")]
		[FieldOffset(Offset = "0x40")]
		public long costTime;

		// Token: 0x0400B48F RID: 46223
		[Token(Token = "0x400B48F")]
		[FieldOffset(Offset = "0x48")]
		public int availableCount;

		// Token: 0x0400B490 RID: 46224
		[Token(Token = "0x400B490")]
		[FieldOffset(Offset = "0x50")]
		public string name;

		// Token: 0x0400B491 RID: 46225
		[Token(Token = "0x400B491")]
		[FieldOffset(Offset = "0x58")]
		public string unlockCond;

		// Token: 0x0400B492 RID: 46226
		[Token(Token = "0x400B492")]
		[FieldOffset(Offset = "0x60")]
		public bool isAccelerated;
	}
}
