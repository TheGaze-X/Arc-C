using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001227 RID: 4647
	[Token(Token = "0x2001227")]
	public class RoguelikeGameItemData
	{
		// Token: 0x06007025 RID: 28709 RVA: 0x00032B50 File Offset: 0x00030D50
		[Token(Token = "0x6007025")]
		[Address(RVA = "0x2111A60", Offset = "0x2110660", VA = "0x182111A60")]
		public bool ShouldSerializetinyIconColor()
		{
			return default(bool);
		}

		// Token: 0x06007026 RID: 28710 RVA: 0x00032B68 File Offset: 0x00030D68
		[Token(Token = "0x6007026")]
		[Address(RVA = "0x2111A40", Offset = "0x2110640", VA = "0x182111A40")]
		public bool ShouldSerializeshortUsage()
		{
			return default(bool);
		}

		// Token: 0x06007027 RID: 28711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007027")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeGameItemData()
		{
		}

		// Token: 0x04006455 RID: 25685
		[Token(Token = "0x4006455")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04006456 RID: 25686
		[Token(Token = "0x4006456")]
		[FieldOffset(Offset = "0x18")]
		public string name;

		// Token: 0x04006457 RID: 25687
		[Token(Token = "0x4006457")]
		[FieldOffset(Offset = "0x20")]
		public string description;

		// Token: 0x04006458 RID: 25688
		[Token(Token = "0x4006458")]
		[FieldOffset(Offset = "0x28")]
		public string usage;

		// Token: 0x04006459 RID: 25689
		[Token(Token = "0x4006459")]
		[FieldOffset(Offset = "0x30")]
		public string obtainApproach;

		// Token: 0x0400645A RID: 25690
		[Token(Token = "0x400645A")]
		[FieldOffset(Offset = "0x38")]
		public string iconId;

		// Token: 0x0400645B RID: 25691
		[Token(Token = "0x400645B")]
		[FieldOffset(Offset = "0x40")]
		public string itemIconGroupId;

		// Token: 0x0400645C RID: 25692
		[Token(Token = "0x400645C")]
		[FieldOffset(Offset = "0x48")]
		public RoguelikeGameItemType type;

		// Token: 0x0400645D RID: 25693
		[Token(Token = "0x400645D")]
		[FieldOffset(Offset = "0x4C")]
		public RoguelikeGameItemSubType subType;

		// Token: 0x0400645E RID: 25694
		[Token(Token = "0x400645E")]
		[FieldOffset(Offset = "0x50")]
		public RoguelikeGameItemRarity rarity;

		// Token: 0x0400645F RID: 25695
		[Token(Token = "0x400645F")]
		[FieldOffset(Offset = "0x54")]
		public int sortId;

		// Token: 0x04006460 RID: 25696
		[Token(Token = "0x4006460")]
		[FieldOffset(Offset = "0x58")]
		public bool canSacrifice;

		// Token: 0x04006461 RID: 25697
		[Token(Token = "0x4006461")]
		[FieldOffset(Offset = "0x60")]
		public string tinyIconColor;

		// Token: 0x04006462 RID: 25698
		[Token(Token = "0x4006462")]
		[FieldOffset(Offset = "0x68")]
		public string unlockCondDesc;

		// Token: 0x04006463 RID: 25699
		[Token(Token = "0x4006463")]
		[FieldOffset(Offset = "0x70")]
		public string shortUsage;
	}
}
