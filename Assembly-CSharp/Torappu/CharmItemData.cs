using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F6E RID: 3950
	[Token(Token = "0x2000F6E")]
	public class CharmItemData
	{
		// Token: 0x17000D0E RID: 3342
		// (get) Token: 0x06006C9E RID: 27806 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D0E")]
		public string charmEffect
		{
			[Token(Token = "0x6006C9E")]
			[Address(RVA = "0x2100090", Offset = "0x20FEC90", VA = "0x182100090")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006C9F RID: 27807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C9F")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CharmItemData()
		{
		}

		// Token: 0x040053DA RID: 21466
		[Token(Token = "0x40053DA")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x040053DB RID: 21467
		[Token(Token = "0x40053DB")]
		[FieldOffset(Offset = "0x18")]
		public int sort;

		// Token: 0x040053DC RID: 21468
		[Token(Token = "0x40053DC")]
		[FieldOffset(Offset = "0x20")]
		public string name;

		// Token: 0x040053DD RID: 21469
		[Token(Token = "0x40053DD")]
		[FieldOffset(Offset = "0x28")]
		public string icon;

		// Token: 0x040053DE RID: 21470
		[Token(Token = "0x40053DE")]
		[FieldOffset(Offset = "0x30")]
		public string itemUsage;

		// Token: 0x040053DF RID: 21471
		[Token(Token = "0x40053DF")]
		[FieldOffset(Offset = "0x38")]
		public string itemDesc;

		// Token: 0x040053E0 RID: 21472
		[Token(Token = "0x40053E0")]
		[FieldOffset(Offset = "0x40")]
		public string itemObtainApproach;

		// Token: 0x040053E1 RID: 21473
		[Token(Token = "0x40053E1")]
		[FieldOffset(Offset = "0x48")]
		public CharmRarity rarity;

		// Token: 0x040053E2 RID: 21474
		[Token(Token = "0x40053E2")]
		[FieldOffset(Offset = "0x50")]
		public string desc;

		// Token: 0x040053E3 RID: 21475
		[Token(Token = "0x40053E3")]
		[FieldOffset(Offset = "0x58")]
		public int price;

		// Token: 0x040053E4 RID: 21476
		[Token(Token = "0x40053E4")]
		[FieldOffset(Offset = "0x60")]
		public string specialObtainApproach;

		// Token: 0x040053E5 RID: 21477
		[Token(Token = "0x40053E5")]
		[FieldOffset(Offset = "0x68")]
		public string charmType;

		// Token: 0x040053E6 RID: 21478
		[Token(Token = "0x40053E6")]
		[FieldOffset(Offset = "0x70")]
		public bool obtainInRandom;

		// Token: 0x040053E7 RID: 21479
		[Token(Token = "0x40053E7")]
		[FieldOffset(Offset = "0x78")]
		public string[] dropStages;

		// Token: 0x040053E8 RID: 21480
		[Token(Token = "0x40053E8")]
		[FieldOffset(Offset = "0x80")]
		public RuneTable.PackedRuneData runeData;
	}
}
