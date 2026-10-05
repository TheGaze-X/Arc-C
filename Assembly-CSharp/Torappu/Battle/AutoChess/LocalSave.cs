using System;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002737 RID: 10039
	[Token(Token = "0x2002737")]
	public class LocalSave
	{
		// Token: 0x060104AE RID: 66734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60104AE")]
		[Address(RVA = "0x808050", Offset = "0x806C50", VA = "0x180808050")]
		public LocalSave()
		{
		}

		// Token: 0x0401236D RID: 74605
		[Token(Token = "0x401236D")]
		[FieldOffset(Offset = "0x10")]
		public SceneGameData sceneGameData;

		// Token: 0x0401236E RID: 74606
		[Token(Token = "0x401236E")]
		[FieldOffset(Offset = "0x18")]
		public ScenePlayerStaticData playerStaticData;

		// Token: 0x0401236F RID: 74607
		[Token(Token = "0x401236F")]
		[FieldOffset(Offset = "0x20")]
		public SceneStateData sceneStateData;

		// Token: 0x04012370 RID: 74608
		[Token(Token = "0x4012370")]
		[FieldOffset(Offset = "0x28")]
		public PrepareStateData prepareStateData;

		// Token: 0x04012371 RID: 74609
		[Token(Token = "0x4012371")]
		[FieldOffset(Offset = "0x30")]
		public SpPrepareStateData spPrepareStateData;

		// Token: 0x04012372 RID: 74610
		[Token(Token = "0x4012372")]
		[FieldOffset(Offset = "0x38")]
		public SelfBattleData selfBattleData;

		// Token: 0x04012373 RID: 74611
		[Token(Token = "0x4012373")]
		[FieldOffset(Offset = "0x40")]
		public HelpBattleData helpBattleData;

		// Token: 0x04012374 RID: 74612
		[Token(Token = "0x4012374")]
		[FieldOffset(Offset = "0x48")]
		public BossRoundInfo bossRoundInfo;

		// Token: 0x04012375 RID: 74613
		[Token(Token = "0x4012375")]
		[FieldOffset(Offset = "0x50")]
		public BossBattleData bossBattleData;

		// Token: 0x04012376 RID: 74614
		[Token(Token = "0x4012376")]
		[FieldOffset(Offset = "0x58")]
		public ScenePlayerRunTimeData playerRunTimeData;

		// Token: 0x04012377 RID: 74615
		[Token(Token = "0x4012377")]
		[FieldOffset(Offset = "0x60")]
		public SettleData settleData;

		// Token: 0x04012378 RID: 74616
		[Token(Token = "0x4012378")]
		[FieldOffset(Offset = "0x68")]
		public SceneRoundEnemyData sceneRoundEnemyData;
	}
}
