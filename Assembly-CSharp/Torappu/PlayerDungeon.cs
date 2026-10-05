using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020009F6 RID: 2550
	[Token(Token = "0x20009F6")]
	public class PlayerDungeon
	{
		// Token: 0x060066BC RID: 26300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066BC")]
		[Address(RVA = "0x1EF9B70", Offset = "0x1EF8770", VA = "0x181EF9B70")]
		public PlayerDungeon()
		{
		}

		// Token: 0x04003734 RID: 14132
		[Token(Token = "0x4003734")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, PlayerStage> stages;

		// Token: 0x04003735 RID: 14133
		[Token(Token = "0x4003735")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, PlayerZone> zones;

		// Token: 0x04003736 RID: 14134
		[Token(Token = "0x4003736")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, PlayerSpecialStage> cowLevel;

		// Token: 0x04003737 RID: 14135
		[Token(Token = "0x4003737")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, PlayerHiddenStage> hideStages;

		// Token: 0x04003738 RID: 14136
		[Token(Token = "0x4003738")]
		[FieldOffset(Offset = "0x30")]
		public List<string> mainlineBannedStages;

		// Token: 0x04003739 RID: 14137
		[Token(Token = "0x4003739")]
		[FieldOffset(Offset = "0x38")]
		public PlayerSixStar sixStar;
	}
}
