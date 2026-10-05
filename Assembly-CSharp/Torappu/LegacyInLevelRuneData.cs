using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001260 RID: 4704
	[Token(Token = "0x2001260")]
	[Serializable]
	public class LegacyInLevelRuneData
	{
		// Token: 0x060071D6 RID: 29142 RVA: 0x00032BB0 File Offset: 0x00030DB0
		[Token(Token = "0x60071D6")]
		[Address(RVA = "0x2207750", Offset = "0x2206350", VA = "0x182207750")]
		public bool CheckValidForDifficulty(LevelData.Difficulty difficulty)
		{
			return default(bool);
		}

		// Token: 0x060071D7 RID: 29143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60071D7")]
		[Address(RVA = "0x2207930", Offset = "0x2206530", VA = "0x182207930")]
		public LegacyInLevelRuneData()
		{
		}

		// Token: 0x040067C1 RID: 26561
		[Token(Token = "0x40067C1")]
		[FieldOffset(Offset = "0x10")]
		public LevelData.Difficulty difficultyMask;

		// Token: 0x040067C2 RID: 26562
		[Token(Token = "0x40067C2")]
		[FieldOffset(Offset = "0x0")]
		public static List<List<string>> SIX_STAR_RUNE_NAMES;

		// Token: 0x040067C3 RID: 26563
		[Token(Token = "0x40067C3")]
		[FieldOffset(Offset = "0x18")]
		public string key;

		// Token: 0x040067C4 RID: 26564
		[Token(Token = "0x40067C4")]
		[FieldOffset(Offset = "0x20")]
		[Enum(true, EnumDisplay.Checkbox)]
		public ProfessionCategory professionMask;

		// Token: 0x040067C5 RID: 26565
		[Token(Token = "0x40067C5")]
		[FieldOffset(Offset = "0x24")]
		public BuildableType buildableMask;

		// Token: 0x040067C6 RID: 26566
		[Token(Token = "0x40067C6")]
		[FieldOffset(Offset = "0x28")]
		public Blackboard blackboard;
	}
}
