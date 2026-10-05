using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x0200209F RID: 8351
	[Token(Token = "0x200209F")]
	public struct BattleStageInfo
	{
		// Token: 0x0600CD95 RID: 52629 RVA: 0x0004A1F0 File Offset: 0x000483F0
		[Token(Token = "0x600CD95")]
		[Address(RVA = "0x7F69A0", Offset = "0x7F55A0", VA = "0x1807F69A0")]
		public bool IsEmpty()
		{
			return default(bool);
		}

		// Token: 0x0600CD96 RID: 52630 RVA: 0x0004A208 File Offset: 0x00048408
		[Token(Token = "0x600CD96")]
		[Address(RVA = "0x34FA8D0", Offset = "0x34F94D0", VA = "0x1834FA8D0")]
		public bool IsCampaign()
		{
			return default(bool);
		}

		// Token: 0x0600CD97 RID: 52631 RVA: 0x0004A220 File Offset: 0x00048420
		[Token(Token = "0x600CD97")]
		[Address(RVA = "0x34FA250", Offset = "0x34F8E50", VA = "0x1834FA250")]
		public static BattleStageInfo CreateWithApCost(StageData stageData, int ap)
		{
			return default(BattleStageInfo);
		}

		// Token: 0x0600CD98 RID: 52632 RVA: 0x0004A238 File Offset: 0x00048438
		[Token(Token = "0x600CD98")]
		[Address(RVA = "0x34FA680", Offset = "0x34F9280", VA = "0x1834FA680")]
		public static BattleStageInfo Create(StageData stageData)
		{
			return default(BattleStageInfo);
		}

		// Token: 0x0600CD99 RID: 52633 RVA: 0x0004A250 File Offset: 0x00048450
		[Token(Token = "0x600CD99")]
		[Address(RVA = "0x34FA4F0", Offset = "0x34F90F0", VA = "0x1834FA4F0")]
		public static BattleStageInfo CreateWithAprilFoolStage(AprilFoolStageData stageData)
		{
			return default(BattleStageInfo);
		}

		// Token: 0x0400D8E8 RID: 55528
		[Token(Token = "0x400D8E8")]
		[FieldOffset(Offset = "0x0")]
		public static readonly BattleStageInfo EMPTY;

		// Token: 0x0400D8E9 RID: 55529
		[Token(Token = "0x400D8E9")]
		[FieldOffset(Offset = "0x0")]
		public string stageId;

		// Token: 0x0400D8EA RID: 55530
		[Token(Token = "0x400D8EA")]
		[FieldOffset(Offset = "0x8")]
		public string code;

		// Token: 0x0400D8EB RID: 55531
		[Token(Token = "0x400D8EB")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x0400D8EC RID: 55532
		[Token(Token = "0x400D8EC")]
		[FieldOffset(Offset = "0x18")]
		public string levelId;

		// Token: 0x0400D8ED RID: 55533
		[Token(Token = "0x400D8ED")]
		[FieldOffset(Offset = "0x20")]
		public string zoneId;

		// Token: 0x0400D8EE RID: 55534
		[Token(Token = "0x400D8EE")]
		[FieldOffset(Offset = "0x28")]
		public bool canBattleReplay;

		// Token: 0x0400D8EF RID: 55535
		[Token(Token = "0x400D8EF")]
		[FieldOffset(Offset = "0x2C")]
		public LevelData.Difficulty difficulty;

		// Token: 0x0400D8F0 RID: 55536
		[Token(Token = "0x400D8F0")]
		[FieldOffset(Offset = "0x30")]
		public int apCost;

		// Token: 0x0400D8F1 RID: 55537
		[Token(Token = "0x400D8F1")]
		[FieldOffset(Offset = "0x34")]
		public int etCost;

		// Token: 0x0400D8F2 RID: 55538
		[Token(Token = "0x400D8F2")]
		[FieldOffset(Offset = "0x38")]
		public int etFailReturn;

		// Token: 0x0400D8F3 RID: 55539
		[Token(Token = "0x400D8F3")]
		[FieldOffset(Offset = "0x40")]
		public string etItemId;

		// Token: 0x0400D8F4 RID: 55540
		[Token(Token = "0x400D8F4")]
		[FieldOffset(Offset = "0x48")]
		public StageType stageType;

		// Token: 0x0400D8F5 RID: 55541
		[Token(Token = "0x400D8F5")]
		[FieldOffset(Offset = "0x50")]
		public string loadingPicId;

		// Token: 0x0400D8F6 RID: 55542
		[Token(Token = "0x400D8F6")]
		[FieldOffset(Offset = "0x58")]
		public bool useLoadingDecor;

		// Token: 0x0400D8F7 RID: 55543
		[Token(Token = "0x400D8F7")]
		[FieldOffset(Offset = "0x59")]
		public bool canPractice;

		// Token: 0x0400D8F8 RID: 55544
		[Token(Token = "0x400D8F8")]
		[FieldOffset(Offset = "0x5C")]
		public int loseGoldGain;

		// Token: 0x0400D8F9 RID: 55545
		[Token(Token = "0x400D8F9")]
		[FieldOffset(Offset = "0x60")]
		public int loseExpGain;

		// Token: 0x0400D8FA RID: 55546
		[Token(Token = "0x400D8FA")]
		[FieldOffset(Offset = "0x64")]
		public PlayerStageState stateBeforeBattle;

		// Token: 0x0400D8FB RID: 55547
		[Token(Token = "0x400D8FB")]
		[FieldOffset(Offset = "0x68")]
		public bool isPredefineFlag;
	}
}
