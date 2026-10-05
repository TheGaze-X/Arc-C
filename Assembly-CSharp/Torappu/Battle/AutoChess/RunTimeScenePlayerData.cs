using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002716 RID: 10006
	[Token(Token = "0x2002716")]
	public class RunTimeScenePlayerData
	{
		// Token: 0x06010470 RID: 66672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010470")]
		[Address(RVA = "0x80AC90", Offset = "0x809890", VA = "0x18080AC90")]
		public RunTimeScenePlayerData()
		{
		}

		// Token: 0x040122F8 RID: 74488
		[Token(Token = "0x40122F8")]
		[FieldOffset(Offset = "0x10")]
		public int index;

		// Token: 0x040122F9 RID: 74489
		[Token(Token = "0x40122F9")]
		[FieldOffset(Offset = "0x14")]
		public int hp;

		// Token: 0x040122FA RID: 74490
		[Token(Token = "0x40122FA")]
		[FieldOffset(Offset = "0x18")]
		public bool gameFinish;

		// Token: 0x040122FB RID: 74491
		[Token(Token = "0x40122FB")]
		[FieldOffset(Offset = "0x1C")]
		public int shopLv;

		// Token: 0x040122FC RID: 74492
		[Token(Token = "0x40122FC")]
		[FieldOffset(Offset = "0x20")]
		public int shopCoin;

		// Token: 0x040122FD RID: 74493
		[Token(Token = "0x40122FD")]
		[FieldOffset(Offset = "0x24")]
		public int maxDeploymentCnt;

		// Token: 0x040122FE RID: 74494
		[Token(Token = "0x40122FE")]
		[FieldOffset(Offset = "0x28")]
		public AutoChessPlayerGameStateType gameState;

		// Token: 0x040122FF RID: 74495
		[Token(Token = "0x40122FF")]
		[FieldOffset(Offset = "0x2C")]
		public AutoChessPlayerConnectStateType connectStateType;

		// Token: 0x04012300 RID: 74496
		[Token(Token = "0x4012300")]
		[FieldOffset(Offset = "0x30")]
		public PlayerBattleData playerBattleData;

		// Token: 0x04012301 RID: 74497
		[Token(Token = "0x4012301")]
		[FieldOffset(Offset = "0x38")]
		public List<BattleEffectEnemyInfo> effectEnemies;

		// Token: 0x04012302 RID: 74498
		[Token(Token = "0x4012302")]
		[FieldOffset(Offset = "0x40")]
		public PreparationRoundAnalytics roundAnalytics;
	}
}
