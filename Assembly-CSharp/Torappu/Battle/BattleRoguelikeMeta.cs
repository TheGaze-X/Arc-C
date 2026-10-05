using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020020A1 RID: 8353
	[Token(Token = "0x20020A1")]
	public struct BattleRoguelikeMeta
	{
		// Token: 0x0400D900 RID: 55552
		[Token(Token = "0x400D900")]
		[FieldOffset(Offset = "0x0")]
		public string topicId;

		// Token: 0x0400D901 RID: 55553
		[Token(Token = "0x400D901")]
		[FieldOffset(Offset = "0x8")]
		public int gold;

		// Token: 0x0400D902 RID: 55554
		[Token(Token = "0x400D902")]
		[FieldOffset(Offset = "0xC")]
		public int remainPopulation;

		// Token: 0x0400D903 RID: 55555
		[Token(Token = "0x400D903")]
		[FieldOffset(Offset = "0x10")]
		public int chestCnt;

		// Token: 0x0400D904 RID: 55556
		[Token(Token = "0x400D904")]
		[FieldOffset(Offset = "0x14")]
		public int goldTrapCnt;

		// Token: 0x0400D905 RID: 55557
		[Token(Token = "0x400D905")]
		[FieldOffset(Offset = "0x18")]
		public int san;

		// Token: 0x0400D906 RID: 55558
		[Token(Token = "0x400D906")]
		[FieldOffset(Offset = "0x1C")]
		public RoguelikeTopicMode mode;

		// Token: 0x0400D907 RID: 55559
		[Token(Token = "0x400D907")]
		[FieldOffset(Offset = "0x20")]
		public List<AdvancedCharacterInst> tmpCharList;

		// Token: 0x0400D908 RID: 55560
		[Token(Token = "0x400D908")]
		[FieldOffset(Offset = "0x28")]
		public BattlePlayerData exBattlePlayerData;

		// Token: 0x0400D909 RID: 55561
		[Token(Token = "0x400D909")]
		[FieldOffset(Offset = "0x30")]
		public List<RoguelikeGameCharBuffBattleData> charBuffs;

		// Token: 0x0400D90A RID: 55562
		[Token(Token = "0x400D90A")]
		[FieldOffset(Offset = "0x38")]
		public List<int> diceRoll;

		// Token: 0x0400D90B RID: 55563
		[Token(Token = "0x400D90B")]
		[FieldOffset(Offset = "0x40")]
		public Dictionary<string, int> boxInfo;

		// Token: 0x0400D90C RID: 55564
		[Token(Token = "0x400D90C")]
		[FieldOffset(Offset = "0x48")]
		public List<uint> fragmentCarryCharUniqueList;

		// Token: 0x0400D90D RID: 55565
		[Token(Token = "0x400D90D")]
		[FieldOffset(Offset = "0x50")]
		public PlayerNodeForesightType foresightType;

		// Token: 0x0400D90E RID: 55566
		[Token(Token = "0x400D90E")]
		[FieldOffset(Offset = "0x54")]
		public RoguelikeEventType nodeType;

		// Token: 0x0400D90F RID: 55567
		[Token(Token = "0x400D90F")]
		[FieldOffset(Offset = "0x58")]
		public bool isSpecialExpStyle;

		// Token: 0x0400D910 RID: 55568
		[Token(Token = "0x400D910")]
		[FieldOffset(Offset = "0x59")]
		public bool isFailProtect;

		// Token: 0x0400D911 RID: 55569
		[Token(Token = "0x400D911")]
		[FieldOffset(Offset = "0x5A")]
		public bool isFragmentWeightLimit;

		// Token: 0x0400D912 RID: 55570
		[Token(Token = "0x400D912")]
		[FieldOffset(Offset = "0x5C")]
		public int fragmentCount;

		// Token: 0x0400D913 RID: 55571
		[Token(Token = "0x400D913")]
		[FieldOffset(Offset = "0x60")]
		public bool hasInspiration;

		// Token: 0x0400D914 RID: 55572
		[Token(Token = "0x400D914")]
		[FieldOffset(Offset = "0x64")]
		public int seed;

		// Token: 0x0400D915 RID: 55573
		[Token(Token = "0x400D915")]
		[FieldOffset(Offset = "0x68")]
		public Dictionary<string, float> enemyHpInfo;

		// Token: 0x0400D916 RID: 55574
		[Token(Token = "0x400D916")]
		[FieldOffset(Offset = "0x70")]
		public string battleSnapshot;

		// Token: 0x0400D917 RID: 55575
		[Token(Token = "0x400D917")]
		[FieldOffset(Offset = "0x78")]
		public PlayerRoguelikeZoneType zoneType;

		// Token: 0x0400D918 RID: 55576
		[Token(Token = "0x400D918")]
		[FieldOffset(Offset = "0x7C")]
		public RoguelikeSpZoneNodeType spZoneNodeType;

		// Token: 0x0400D919 RID: 55577
		[Token(Token = "0x400D919")]
		[FieldOffset(Offset = "0x80")]
		public string nodeTypeString;

		// Token: 0x0400D91A RID: 55578
		[Token(Token = "0x400D91A")]
		[FieldOffset(Offset = "0x88")]
		public Dictionary<string, int> hasCandleHolderBuffCharDict;

		// Token: 0x0400D91B RID: 55579
		[Token(Token = "0x400D91B")]
		[FieldOffset(Offset = "0x90")]
		public RoguelikeBattleFailDisplay battleFailDisplay;
	}
}
