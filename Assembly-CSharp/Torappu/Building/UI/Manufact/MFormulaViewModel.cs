using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001D88 RID: 7560
	[Token(Token = "0x2001D88")]
	public class MFormulaViewModel
	{
		// Token: 0x0600BA88 RID: 47752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA88")]
		[Address(RVA = "0x3373BF0", Offset = "0x33727F0", VA = "0x183373BF0")]
		public void LoadData(BuildingData.ManufactFormula formula, ManufactSnapshot snapshot, float speed)
		{
		}

		// Token: 0x0600BA89 RID: 47753 RVA: 0x00045C48 File Offset: 0x00043E48
		[Token(Token = "0x600BA89")]
		[Address(RVA = "0x3373990", Offset = "0x3372590", VA = "0x183373990")]
		public static int CompareManufactFormula(MFormulaViewModel a, MFormulaViewModel b, FormulaSortType focusType, bool isInverse)
		{
			return 0;
		}

		// Token: 0x0600BA8A RID: 47754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BA8A")]
		[Address(RVA = "0x3374000", Offset = "0x3372C00", VA = "0x183374000")]
		public MFormulaViewModel()
		{
		}

		// Token: 0x0400B9BE RID: 47550
		[Token(Token = "0x400B9BE")]
		[FieldOffset(Offset = "0x10")]
		public int formulaSortId;

		// Token: 0x0400B9BF RID: 47551
		[Token(Token = "0x400B9BF")]
		[FieldOffset(Offset = "0x18")]
		public BuildingData.ManufactFormula formula;

		// Token: 0x0400B9C0 RID: 47552
		[Token(Token = "0x400B9C0")]
		[FieldOffset(Offset = "0x20")]
		public List<FormulaCostStruct> costs;

		// Token: 0x0400B9C1 RID: 47553
		[Token(Token = "0x400B9C1")]
		[FieldOffset(Offset = "0x28")]
		public BuildingData.FormulaItemType formulaType;

		// Token: 0x0400B9C2 RID: 47554
		[Token(Token = "0x400B9C2")]
		[FieldOffset(Offset = "0x2C")]
		public bool isUnlocked;

		// Token: 0x0400B9C3 RID: 47555
		[Token(Token = "0x400B9C3")]
		[FieldOffset(Offset = "0x30")]
		public ItemRarity rarity;

		// Token: 0x0400B9C4 RID: 47556
		[Token(Token = "0x400B9C4")]
		[FieldOffset(Offset = "0x38")]
		public long costTime;

		// Token: 0x0400B9C5 RID: 47557
		[Token(Token = "0x400B9C5")]
		[FieldOffset(Offset = "0x40")]
		public int availableCount;

		// Token: 0x0400B9C6 RID: 47558
		[Token(Token = "0x400B9C6")]
		[FieldOffset(Offset = "0x48")]
		public string name;

		// Token: 0x0400B9C7 RID: 47559
		[Token(Token = "0x400B9C7")]
		[FieldOffset(Offset = "0x50")]
		public string unlockCond;

		// Token: 0x0400B9C8 RID: 47560
		[Token(Token = "0x400B9C8")]
		[FieldOffset(Offset = "0x58")]
		public bool isAccelerated;
	}
}
