using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000AAD RID: 2733
	[Token(Token = "0x2000AAD")]
	public class PlayerRoguelikeStatus
	{
		// Token: 0x0600676B RID: 26475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600676B")]
		[Address(RVA = "0x1EFCF20", Offset = "0x1EFBB20", VA = "0x181EFCF20")]
		public PlayerRoguelikeStatus()
		{
		}

		// Token: 0x04003995 RID: 14741
		[Token(Token = "0x4003995")]
		[FieldOffset(Offset = "0x10")]
		public string uuid;

		// Token: 0x04003996 RID: 14742
		[Token(Token = "0x4003996")]
		[FieldOffset(Offset = "0x18")]
		public int level;

		// Token: 0x04003997 RID: 14743
		[Token(Token = "0x4003997")]
		[FieldOffset(Offset = "0x1C")]
		public int exp;

		// Token: 0x04003998 RID: 14744
		[Token(Token = "0x4003998")]
		[FieldOffset(Offset = "0x20")]
		public int hp;

		// Token: 0x04003999 RID: 14745
		[Token(Token = "0x4003999")]
		[FieldOffset(Offset = "0x24")]
		public int gold;

		// Token: 0x0400399A RID: 14746
		[Token(Token = "0x400399A")]
		[FieldOffset(Offset = "0x28")]
		public int squadCapacity;

		// Token: 0x0400399B RID: 14747
		[Token(Token = "0x400399B")]
		[FieldOffset(Offset = "0x2C")]
		public int populationCost;

		// Token: 0x0400399C RID: 14748
		[Token(Token = "0x400399C")]
		[FieldOffset(Offset = "0x30")]
		public int populationMax;

		// Token: 0x0400399D RID: 14749
		[Token(Token = "0x400399D")]
		[FieldOffset(Offset = "0x38")]
		public PlayerRoguelikeCursor cursor;

		// Token: 0x0400399E RID: 14750
		[Token(Token = "0x400399E")]
		[FieldOffset(Offset = "0x40")]
		public int perfectWinStreak;

		// Token: 0x0400399F RID: 14751
		[Token(Token = "0x400399F")]
		[FieldOffset(Offset = "0x48")]
		public string mode;

		// Token: 0x040039A0 RID: 14752
		[Token(Token = "0x40039A0")]
		[FieldOffset(Offset = "0x50")]
		public string ending;

		// Token: 0x040039A1 RID: 14753
		[Token(Token = "0x40039A1")]
		[FieldOffset(Offset = "0x58")]
		public int showBattleCharInstId;

		// Token: 0x040039A2 RID: 14754
		[Token(Token = "0x40039A2")]
		[FieldOffset(Offset = "0x60")]
		public long startTime;

		// Token: 0x040039A3 RID: 14755
		[Token(Token = "0x40039A3")]
		[FieldOffset(Offset = "0x68")]
		public long endTime;
	}
}
