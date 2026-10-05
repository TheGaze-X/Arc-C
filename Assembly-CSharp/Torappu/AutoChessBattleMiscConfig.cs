using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;

namespace Torappu
{
	// Token: 0x02000494 RID: 1172
	[Token(Token = "0x2000494")]
	[Serializable]
	public class AutoChessBattleMiscConfig
	{
		// Token: 0x06004CDC RID: 19676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004CDC")]
		[Address(RVA = "0x1786000", Offset = "0x1784C00", VA = "0x181786000")]
		public AutoChessBattleMiscConfig()
		{
		}

		// Token: 0x040010AC RID: 4268
		[Token(Token = "0x40010AC")]
		[FieldOffset(Offset = "0x10")]
		public int initialHp;

		// Token: 0x040010AD RID: 4269
		[Token(Token = "0x40010AD")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, string> idleEffectMap;

		// Token: 0x040010AE RID: 4270
		[Token(Token = "0x40010AE")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, string> defaultAnimMap;

		// Token: 0x040010AF RID: 4271
		[Token(Token = "0x40010AF")]
		[FieldOffset(Offset = "0x28")]
		public List<string> forceUseFirstModeIds;

		// Token: 0x040010B0 RID: 4272
		[Token(Token = "0x40010B0")]
		[FieldOffset(Offset = "0x30")]
		public BuffData enemyPreviewBuff;

		// Token: 0x040010B1 RID: 4273
		[Token(Token = "0x40010B1")]
		[FieldOffset(Offset = "0x38")]
		public string mlyssWtrmanTransformBuff;

		// Token: 0x040010B2 RID: 4274
		[Token(Token = "0x40010B2")]
		[FieldOffset(Offset = "0x40")]
		public List<AutoChessBattleMiscConfig.TrainingNPCInfo> trainingNPCInfos;

		// Token: 0x040010B3 RID: 4275
		[Token(Token = "0x40010B3")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<int, AutoChessBattleMiscConfig.TrainingRoundInfo> trainingRoundInfos;

		// Token: 0x040010B4 RID: 4276
		[Token(Token = "0x40010B4")]
		[FieldOffset(Offset = "0x50")]
		public Dictionary<int, List<AutoChessBattleMiscConfig.TrainingShopInfo>> trainingShopInfos;

		// Token: 0x040010B5 RID: 4277
		[Token(Token = "0x40010B5")]
		[FieldOffset(Offset = "0x58")]
		public List<int> helpBattleNpcPlayers;

		// Token: 0x040010B6 RID: 4278
		[Token(Token = "0x40010B6")]
		[FieldOffset(Offset = "0x60")]
		public AutoChessBattleMiscConfig.EffectConfig effectConfig;

		// Token: 0x040010B7 RID: 4279
		[Token(Token = "0x40010B7")]
		[FieldOffset(Offset = "0x68")]
		public AutoChessTutorialManager.AutoChessTutorialManagerConfig tutorialManagerCfg;

		// Token: 0x02000495 RID: 1173
		[Token(Token = "0x2000495")]
		public class EffectConfig
		{
			// Token: 0x06004CDD RID: 19677 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CDD")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EffectConfig()
			{
			}

			// Token: 0x040010B8 RID: 4280
			[Token(Token = "0x40010B8")]
			[FieldOffset(Offset = "0x10")]
			public string goldenEffectId;

			// Token: 0x040010B9 RID: 4281
			[Token(Token = "0x40010B9")]
			[FieldOffset(Offset = "0x18")]
			public string buildableTileHintEffect;

			// Token: 0x040010BA RID: 4282
			[Token(Token = "0x40010BA")]
			[FieldOffset(Offset = "0x20")]
			public string maskEffectWhenGainChess;

			// Token: 0x040010BB RID: 4283
			[Token(Token = "0x40010BB")]
			[FieldOffset(Offset = "0x28")]
			public string deckRegionEffect;

			// Token: 0x040010BC RID: 4284
			[Token(Token = "0x40010BC")]
			[FieldOffset(Offset = "0x30")]
			public string tempChessRegionClearWarningEffect;

			// Token: 0x040010BD RID: 4285
			[Token(Token = "0x40010BD")]
			[FieldOffset(Offset = "0x38")]
			public string garrisonHintEffect;

			// Token: 0x040010BE RID: 4286
			[Token(Token = "0x40010BE")]
			[FieldOffset(Offset = "0x40")]
			public string chessUpgradeHintEffect;

			// Token: 0x040010BF RID: 4287
			[Token(Token = "0x40010BF")]
			[FieldOffset(Offset = "0x48")]
			public string equipComboHintEffect;
		}

		// Token: 0x02000496 RID: 1174
		[Token(Token = "0x2000496")]
		public class TrainingNPCInfo
		{
			// Token: 0x06004CDE RID: 19678 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CDE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TrainingNPCInfo()
			{
			}

			// Token: 0x040010C0 RID: 4288
			[Token(Token = "0x40010C0")]
			[FieldOffset(Offset = "0x10")]
			public int uidIndex;

			// Token: 0x040010C1 RID: 4289
			[Token(Token = "0x40010C1")]
			[FieldOffset(Offset = "0x14")]
			public int playerLevel;
		}

		// Token: 0x02000497 RID: 1175
		[Token(Token = "0x2000497")]
		public class TrainingRoundInfo
		{
			// Token: 0x06004CDF RID: 19679 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CDF")]
			[Address(RVA = "0x1796410", Offset = "0x1795010", VA = "0x181796410")]
			public TrainingRoundInfo()
			{
			}

			// Token: 0x040010C2 RID: 4290
			[Token(Token = "0x40010C2")]
			[FieldOffset(Offset = "0x10")]
			public int coin;

			// Token: 0x040010C3 RID: 4291
			[Token(Token = "0x40010C3")]
			[FieldOffset(Offset = "0x14")]
			public bool isBoss;

			// Token: 0x040010C4 RID: 4292
			[Token(Token = "0x40010C4")]
			[FieldOffset(Offset = "0x18")]
			public SpPrepareStateData spPrepareStateData;

			// Token: 0x040010C5 RID: 4293
			[Token(Token = "0x40010C5")]
			[FieldOffset(Offset = "0x20")]
			public BossRoundInfo bossRoundInfo;

			// Token: 0x040010C6 RID: 4294
			[Token(Token = "0x40010C6")]
			[FieldOffset(Offset = "0x28")]
			public BossBattleData bossBattleData;

			// Token: 0x040010C7 RID: 4295
			[Token(Token = "0x40010C7")]
			[FieldOffset(Offset = "0x30")]
			public Dictionary<int, RunTimeScenePlayerData> npcPlayerData;
		}

		// Token: 0x02000498 RID: 1176
		[Token(Token = "0x2000498")]
		public class TrainingShopInfo
		{
			// Token: 0x06004CE0 RID: 19680 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004CE0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public TrainingShopInfo()
			{
			}

			// Token: 0x040010C8 RID: 4296
			[Token(Token = "0x40010C8")]
			[FieldOffset(Offset = "0x10")]
			public string chessId;

			// Token: 0x040010C9 RID: 4297
			[Token(Token = "0x40010C9")]
			[FieldOffset(Offset = "0x18")]
			public int count;
		}
	}
}
