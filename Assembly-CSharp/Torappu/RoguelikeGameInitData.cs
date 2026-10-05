using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200121A RID: 4634
	[Token(Token = "0x200121A")]
	public class RoguelikeGameInitData
	{
		// Token: 0x06007018 RID: 28696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007018")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeGameInitData()
		{
		}

		// Token: 0x04006419 RID: 25625
		[Token(Token = "0x4006419")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeTopicMode modeId;

		// Token: 0x0400641A RID: 25626
		[Token(Token = "0x400641A")]
		[FieldOffset(Offset = "0x14")]
		public int modeGrade;

		// Token: 0x0400641B RID: 25627
		[Token(Token = "0x400641B")]
		[FieldOffset(Offset = "0x18")]
		public string predefinedId;

		// Token: 0x0400641C RID: 25628
		[Token(Token = "0x400641C")]
		[FieldOffset(Offset = "0x20")]
		public string predefinedStyle;

		// Token: 0x0400641D RID: 25629
		[Token(Token = "0x400641D")]
		[FieldOffset(Offset = "0x28")]
		public string[] initialBandRelic;

		// Token: 0x0400641E RID: 25630
		[Token(Token = "0x400641E")]
		[FieldOffset(Offset = "0x30")]
		public string[] initialRecruitGroup;

		// Token: 0x0400641F RID: 25631
		[Token(Token = "0x400641F")]
		[FieldOffset(Offset = "0x38")]
		public int initialHp;

		// Token: 0x04006420 RID: 25632
		[Token(Token = "0x4006420")]
		[FieldOffset(Offset = "0x3C")]
		public int initialPopulation;

		// Token: 0x04006421 RID: 25633
		[Token(Token = "0x4006421")]
		[FieldOffset(Offset = "0x40")]
		public int initialGold;

		// Token: 0x04006422 RID: 25634
		[Token(Token = "0x4006422")]
		[FieldOffset(Offset = "0x44")]
		public int initialSquadCapacity;

		// Token: 0x04006423 RID: 25635
		[Token(Token = "0x4006423")]
		[FieldOffset(Offset = "0x48")]
		public int initialShield;

		// Token: 0x04006424 RID: 25636
		[Token(Token = "0x4006424")]
		[FieldOffset(Offset = "0x4C")]
		public int initialMaxHp;

		// Token: 0x04006425 RID: 25637
		[Token(Token = "0x4006425")]
		[FieldOffset(Offset = "0x50")]
		public int initialKey;
	}
}
