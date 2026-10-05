using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002769 RID: 10089
	[Token(Token = "0x2002769")]
	public class AutoChessLevelEnemyManager : IHotfixable
	{
		// Token: 0x170023EC RID: 9196
		// (get) Token: 0x0601071C RID: 67356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170023EC")]
		public Dictionary<int, List<SceneRoundEnemyData.RoundEnemy>> allRoundEnemyData
		{
			[Token(Token = "0x601071C")]
			[Address(RVA = "0x832870", Offset = "0x831470", VA = "0x180832870")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601071D RID: 67357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601071D")]
		[Address(RVA = "0x82FDE0", Offset = "0x82E9E0", VA = "0x18082FDE0")]
		public void Init(SceneRoundEnemyData data)
		{
		}

		// Token: 0x0601071E RID: 67358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601071E")]
		[Address(RVA = "0x82FB50", Offset = "0x82E750", VA = "0x18082FB50")]
		public string GetLevelIdByRound(int round)
		{
			return null;
		}

		// Token: 0x0601071F RID: 67359 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601071F")]
		[Address(RVA = "0x82FC70", Offset = "0x82E870", VA = "0x18082FC70")]
		public List<SceneRoundEnemyData.RoundEnemy> GetRoundEnemies(int round)
		{
			return null;
		}

		// Token: 0x06010720 RID: 67360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010720")]
		[Address(RVA = "0x8300D0", Offset = "0x82ECD0", VA = "0x1808300D0")]
		public void UpdateRoundEnemies(SceneRoundEnemyData data)
		{
		}

		// Token: 0x06010721 RID: 67361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010721")]
		[Address(RVA = "0x8317F0", Offset = "0x8303F0", VA = "0x1808317F0")]
		private void _GenerateAllBattleLevelIds()
		{
		}

		// Token: 0x06010722 RID: 67362 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010722")]
		[Address(RVA = "0x82E760", Offset = "0x82D360", VA = "0x18082E760")]
		private List<LevelData.WaveData.FragmentData.ActionData> AttachLevelOriginData(LevelData levelData)
		{
			return null;
		}

		// Token: 0x06010723 RID: 67363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010723")]
		[Address(RVA = "0x830BF0", Offset = "0x82F7F0", VA = "0x180830BF0")]
		private void _CalculateActionPredelay(Dictionary<int, List<LevelData.WaveData.FragmentData.ActionData>> targetActions, List<LevelData.WaveData.FragmentData.ActionData> originActionDatas)
		{
		}

		// Token: 0x06010724 RID: 67364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010724")]
		[Address(RVA = "0x830570", Offset = "0x82F170", VA = "0x180830570")]
		private void _CalculateActionPredelayConsiderUid(Dictionary<int, Dictionary<int, List<LevelData.WaveData.FragmentData.ActionData>>> targetActions, List<LevelData.WaveData.FragmentData.ActionData> originActionDatas)
		{
		}

		// Token: 0x06010725 RID: 67365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010725")]
		[Address(RVA = "0x830450", Offset = "0x82F050", VA = "0x180830450")]
		private void _ApplyRealActionData(List<LevelData.WaveData.FragmentData.ActionData> realActionDatas, LevelData levelData)
		{
		}

		// Token: 0x06010726 RID: 67366 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010726")]
		[Address(RVA = "0x831F20", Offset = "0x830B20", VA = "0x180831F20")]
		private LevelData.WaveData.FragmentData.ActionData _GetSpEnemyActionData(string enemyKey, List<LevelData.WaveData.FragmentData.ActionData> originActionDatas, bool isToken, out int actionIndex)
		{
			return null;
		}

		// Token: 0x06010727 RID: 67367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010727")]
		[Address(RVA = "0x831E60", Offset = "0x830A60", VA = "0x180831E60")]
		private AutoChessData.AutoChessRandomEnemyAttributeData _GetEnemyEntry(string enemyKey)
		{
			return null;
		}

		// Token: 0x06010728 RID: 67368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010728")]
		[Address(RVA = "0x831160", Offset = "0x82FD60", VA = "0x180831160")]
		private void _DoLoadLevelEnemy(LevelData levelData, List<LevelData.WaveData.FragmentData.ActionData> actionDatas)
		{
		}

		// Token: 0x06010729 RID: 67369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010729")]
		[Address(RVA = "0x82FF20", Offset = "0x82EB20", VA = "0x18082FF20")]
		public void LoadRunTimeEnemy(LevelData levelData, string enemyKey)
		{
		}

		// Token: 0x0601072A RID: 67370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601072A")]
		[Address(RVA = "0x830F40", Offset = "0x82FB40", VA = "0x180830F40")]
		private void _DoLoadEnemy(LevelData levelData, string enemyKey)
		{
		}

		// Token: 0x0601072B RID: 67371 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601072B")]
		[Address(RVA = "0x831710", Offset = "0x830310", VA = "0x180831710")]
		private LevelData.WaveData.FragmentData.ActionData _GenerateAction(string enemyId, int routeIndex)
		{
			return null;
		}

		// Token: 0x0601072C RID: 67372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601072C")]
		[Address(RVA = "0x8313F0", Offset = "0x82FFF0", VA = "0x1808313F0")]
		private LevelData.WaveData.FragmentData.ActionData _GenerateActionFromEnemyInfo(List<LevelData.WaveData.FragmentData.ActionData> originActionDatas, string enemyId, int actionIndex)
		{
			return null;
		}

		// Token: 0x0601072D RID: 67373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601072D")]
		[Address(RVA = "0x832290", Offset = "0x830E90", VA = "0x180832290")]
		private void _InsertSpActionToNormal()
		{
		}

		// Token: 0x0601072E RID: 67374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601072E")]
		[Address(RVA = "0x832100", Offset = "0x830D00", VA = "0x180832100")]
		private void _InsertLocalActions(List<LevelData.WaveData.FragmentData.ActionData> originActionDatas, List<LevelData.WaveData.FragmentData.ActionData> targetActions)
		{
		}

		// Token: 0x0601072F RID: 67375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601072F")]
		[Address(RVA = "0x82F740", Offset = "0x82E340", VA = "0x18082F740")]
		public void GenerateSelfBattleEnemyData(LevelData levelData, List<SelfEnemyInfo> enemyInfos)
		{
		}

		// Token: 0x06010730 RID: 67376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010730")]
		[Address(RVA = "0x82EFC0", Offset = "0x82DBC0", VA = "0x18082EFC0")]
		public void GenerateHelpBattleEnemyData(LevelData levelData, List<EscapedEnemyInfo> escapedEnemyInfos)
		{
		}

		// Token: 0x06010731 RID: 67377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010731")]
		[Address(RVA = "0x82EAC0", Offset = "0x82D6C0", VA = "0x18082EAC0")]
		public void GenerateBossBattleEnemyData(LevelData levelData, List<BossBattleEnemyInfo> enemyInfos, BossPlayerGroup playerGroup)
		{
		}

		// Token: 0x06010732 RID: 67378 RVA: 0x00064290 File Offset: 0x00062490
		[Token(Token = "0x6010732")]
		[Address(RVA = "0x82E8D0", Offset = "0x82D4D0", VA = "0x18082E8D0")]
		public bool BossRoundSpawnEscapedEnemy(BossBattleEnemyInfo bossBattleEnemyInfo)
		{
			return default(bool);
		}

		// Token: 0x06010733 RID: 67379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010733")]
		[Address(RVA = "0x832580", Offset = "0x831180", VA = "0x180832580")]
		public AutoChessLevelEnemyManager()
		{
		}

		// Token: 0x0401269E RID: 75422
		[Token(Token = "0x401269E")]
		[FieldOffset(Offset = "0x10")]
		private AutoChessLevelEnemyManager.RandomEnemyGenerater m_randomEnemyGenerater;

		// Token: 0x0401269F RID: 75423
		[Token(Token = "0x401269F")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<int, List<SceneRoundEnemyData.RoundEnemy>> m_roundEnemyData;

		// Token: 0x040126A0 RID: 75424
		[Token(Token = "0x40126A0")]
		[FieldOffset(Offset = "0x20")]
		private Dictionary<int, string> m_allBattleLevelIds;

		// Token: 0x040126A1 RID: 75425
		[Token(Token = "0x40126A1")]
		private const string BOSS_ROUND_WALK_ESCAPED_ENEMY_BRANCH_NAME = "boss_escaped_walk";

		// Token: 0x040126A2 RID: 75426
		[Token(Token = "0x40126A2")]
		private const string BOSS_ROUND_FLY_ESCAPED_ENEMY_BRANCH_NAME = "boss_escaped_fly";

		// Token: 0x040126A3 RID: 75427
		[Token(Token = "0x40126A3")]
		private const float MIN_ACTION_INTERVAL_RATIO = 0.05f;

		// Token: 0x040126A4 RID: 75428
		[Token(Token = "0x40126A4")]
		private const float ACTION_INTERVAL_FOR_UID = 0.5f;

		// Token: 0x040126A5 RID: 75429
		[Token(Token = "0x40126A5")]
		private const float MAX_ACTION_INTERVAL_FOR_UID = 5f;

		// Token: 0x040126A6 RID: 75430
		[Token(Token = "0x40126A6")]
		[FieldOffset(Offset = "0x28")]
		private AutoChessData m_gameData;

		// Token: 0x040126A7 RID: 75431
		[Token(Token = "0x40126A7")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<string, List<LevelData.WaveData.FragmentData.ActionData>> m_originActionDatas;

		// Token: 0x040126A8 RID: 75432
		[Token(Token = "0x40126A8")]
		[FieldOffset(Offset = "0x38")]
		private List<LevelData.WaveData.FragmentData.ActionData> m_realActionDatas;

		// Token: 0x040126A9 RID: 75433
		[Token(Token = "0x40126A9")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<int, List<LevelData.WaveData.FragmentData.ActionData>> m_levelActionDatas;

		// Token: 0x040126AA RID: 75434
		[Token(Token = "0x40126AA")]
		[FieldOffset(Offset = "0x48")]
		private Dictionary<int, Dictionary<int, List<LevelData.WaveData.FragmentData.ActionData>>> m_levelActionDatasWithUid;

		// Token: 0x040126AB RID: 75435
		[Token(Token = "0x40126AB")]
		[FieldOffset(Offset = "0x50")]
		private Dictionary<int, List<LevelData.WaveData.FragmentData.ActionData>> m_levelSpActionDatas;

		// Token: 0x040126AC RID: 75436
		[Token(Token = "0x40126AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_allRoundEnemyData;

		// Token: 0x040126AD RID: 75437
		[Token(Token = "0x40126AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040126AE RID: 75438
		[Token(Token = "0x40126AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetLevelIdByRound;

		// Token: 0x040126AF RID: 75439
		[Token(Token = "0x40126AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetRoundEnemies;

		// Token: 0x040126B0 RID: 75440
		[Token(Token = "0x40126B0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateRoundEnemies;

		// Token: 0x040126B1 RID: 75441
		[Token(Token = "0x40126B1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__GenerateAllBattleLevelIds;

		// Token: 0x040126B2 RID: 75442
		[Token(Token = "0x40126B2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_AttachLevelOriginData;

		// Token: 0x040126B3 RID: 75443
		[Token(Token = "0x40126B3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CalculateActionPredelay;

		// Token: 0x040126B4 RID: 75444
		[Token(Token = "0x40126B4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CalculateActionPredelayConsiderUid;

		// Token: 0x040126B5 RID: 75445
		[Token(Token = "0x40126B5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ApplyRealActionData;

		// Token: 0x040126B6 RID: 75446
		[Token(Token = "0x40126B6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetSpEnemyActionData;

		// Token: 0x040126B7 RID: 75447
		[Token(Token = "0x40126B7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetEnemyEntry;

		// Token: 0x040126B8 RID: 75448
		[Token(Token = "0x40126B8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__DoLoadLevelEnemy;

		// Token: 0x040126B9 RID: 75449
		[Token(Token = "0x40126B9")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_LoadRunTimeEnemy;

		// Token: 0x040126BA RID: 75450
		[Token(Token = "0x40126BA")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__DoLoadEnemy;

		// Token: 0x040126BB RID: 75451
		[Token(Token = "0x40126BB")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__GenerateAction;

		// Token: 0x040126BC RID: 75452
		[Token(Token = "0x40126BC")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__GenerateActionFromEnemyInfo;

		// Token: 0x040126BD RID: 75453
		[Token(Token = "0x40126BD")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__InsertSpActionToNormal;

		// Token: 0x040126BE RID: 75454
		[Token(Token = "0x40126BE")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__InsertLocalActions;

		// Token: 0x040126BF RID: 75455
		[Token(Token = "0x40126BF")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_GenerateSelfBattleEnemyData;

		// Token: 0x040126C0 RID: 75456
		[Token(Token = "0x40126C0")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GenerateHelpBattleEnemyData;

		// Token: 0x040126C1 RID: 75457
		[Token(Token = "0x40126C1")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GenerateBossBattleEnemyData;

		// Token: 0x040126C2 RID: 75458
		[Token(Token = "0x40126C2")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_BossRoundSpawnEscapedEnemy;

		// Token: 0x040126C3 RID: 75459
		[Token(Token = "0x40126C3")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200276A RID: 10090
		[Token(Token = "0x200276A")]
		public class RandomEnemyGenerater : IHotfixable
		{
			// Token: 0x06010734 RID: 67380 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010734")]
			[Address(RVA = "0x8395F0", Offset = "0x8381F0", VA = "0x1808395F0")]
			public void GenerateRandomEnemyData(List<SceneRoundEnemyData.RoundEnemy> roundEnemies, Dictionary<int, List<SceneRoundEnemyData.RoundEnemy>> roundEnemyData, Dictionary<int, string> allBattleLevelIds)
			{
			}

			// Token: 0x06010735 RID: 67381 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010735")]
			[Address(RVA = "0x83BE40", Offset = "0x83AA40", VA = "0x18083BE40")]
			private void _InitData()
			{
			}

			// Token: 0x06010736 RID: 67382 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010736")]
			[Address(RVA = "0x83B000", Offset = "0x839C00", VA = "0x18083B000")]
			private void _GenerateSpecialEnemyTypesLocal()
			{
			}

			// Token: 0x06010737 RID: 67383 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010737")]
			[Address(RVA = "0x83B5C0", Offset = "0x83A1C0", VA = "0x18083B5C0")]
			private void _GenerateSpecialEnemyTypes(List<SceneRoundEnemyData.RoundEnemy> roundEnemies)
			{
			}

			// Token: 0x06010738 RID: 67384 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010738")]
			[Address(RVA = "0x83A2B0", Offset = "0x838EB0", VA = "0x18083A2B0")]
			private void _GenerateRandomEnemyData()
			{
			}

			// Token: 0x06010739 RID: 67385 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010739")]
			[Address(RVA = "0x83AAD0", Offset = "0x8396D0", VA = "0x18083AAD0")]
			private void _GenerateRoundEnemyData(Dictionary<int, List<SceneRoundEnemyData.RoundEnemy>> outputData, Dictionary<int, string> allBattleLevelIds)
			{
			}

			// Token: 0x0601073A RID: 67386 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601073A")]
			[Address(RVA = "0x839FC0", Offset = "0x838BC0", VA = "0x180839FC0")]
			private void _DoReplaceLevelDataClient(LevelData levelData, int round)
			{
			}

			// Token: 0x0601073B RID: 67387 RVA: 0x000642A8 File Offset: 0x000624A8
			[Token(Token = "0x601073B")]
			[Address(RVA = "0x839A30", Offset = "0x838630", VA = "0x180839A30")]
			private bool _DoReplaceActionDataClient(LevelData levelData, LevelData.WaveData.FragmentData.ActionData actionData, int round)
			{
				return default(bool);
			}

			// Token: 0x0601073C RID: 67388 RVA: 0x000642C0 File Offset: 0x000624C0
			[Token(Token = "0x601073C")]
			[Address(RVA = "0x83B870", Offset = "0x83A470", VA = "0x18083B870")]
			private float _GetEnemyAttrPower(LevelData levelData, string enemyKey)
			{
				return 0f;
			}

			// Token: 0x0601073D RID: 67389 RVA: 0x000642D8 File Offset: 0x000624D8
			[Token(Token = "0x601073D")]
			[Address(RVA = "0x839760", Offset = "0x838360", VA = "0x180839760")]
			public float _CalculateActionBattleEffectiveness(LevelData levelData, LevelData.WaveData.FragmentData.ActionData actionData)
			{
				return 0f;
			}

			// Token: 0x0601073E RID: 67390 RVA: 0x000642F0 File Offset: 0x000624F0
			[Token(Token = "0x601073E")]
			[Address(RVA = "0x839880", Offset = "0x838480", VA = "0x180839880")]
			public int _CalculateEnemyCountByBattleEffectiveness(LevelData levelData, string enemyKey, float originBattleEffectiveness)
			{
				return 0;
			}

			// Token: 0x0601073F RID: 67391 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601073F")]
			[Address(RVA = "0x83BCC0", Offset = "0x83A8C0", VA = "0x18083BCC0")]
			private AutoChessData.AutoChessRandomEnemyAttributeData _GetTemplateEnemyAttr(int round, AutoChessLevelEnemyManager.RandomEnemyGenerater.AutoChessRandomEnemyType enemyType)
			{
				return null;
			}

			// Token: 0x06010740 RID: 67392 RVA: 0x00064308 File Offset: 0x00062508
			[Token(Token = "0x6010740")]
			[Address(RVA = "0x83C030", Offset = "0x83AC30", VA = "0x18083C030")]
			private bool _IsTemplateEnemy(string enemyKey)
			{
				return default(bool);
			}

			// Token: 0x06010741 RID: 67393 RVA: 0x00064320 File Offset: 0x00062520
			[Token(Token = "0x6010741")]
			[Address(RVA = "0x8399C0", Offset = "0x8385C0", VA = "0x1808399C0")]
			private bool _CheckNeedReplace(int levelIndex)
			{
				return default(bool);
			}

			// Token: 0x06010742 RID: 67394 RVA: 0x00064338 File Offset: 0x00062538
			[Token(Token = "0x6010742")]
			[Address(RVA = "0x8396B0", Offset = "0x8382B0", VA = "0x1808396B0")]
			public bool ShouldActionUpToServer(LevelData.WaveData.FragmentData.ActionData actionData)
			{
				return default(bool);
			}

			// Token: 0x06010743 RID: 67395 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010743")]
			[Address(RVA = "0x83C0C0", Offset = "0x83ACC0", VA = "0x18083C0C0")]
			public RandomEnemyGenerater()
			{
			}

			// Token: 0x040126C4 RID: 75460
			[Token(Token = "0x40126C4")]
			[FieldOffset(Offset = "0x10")]
			private AutoChessData m_gameData;

			// Token: 0x040126C5 RID: 75461
			[Token(Token = "0x40126C5")]
			[FieldOffset(Offset = "0x18")]
			private Dictionary<string, AutoChessLevelEnemyManager.RandomEnemyGenerater.AutoChessRandomEnemyType> m_templateEnemyInfo;

			// Token: 0x040126C6 RID: 75462
			[Token(Token = "0x40126C6")]
			[FieldOffset(Offset = "0x20")]
			private List<int> m_specialEnemyTypeResultTypeList;

			// Token: 0x040126C7 RID: 75463
			[Token(Token = "0x40126C7")]
			[FieldOffset(Offset = "0x28")]
			private Dictionary<int, string> m_randomSpecialEnemyResult;

			// Token: 0x040126C8 RID: 75464
			[Token(Token = "0x40126C8")]
			[FieldOffset(Offset = "0x30")]
			private Dictionary<int, string> m_randomEliteEnemyResult;

			// Token: 0x040126C9 RID: 75465
			[Token(Token = "0x40126C9")]
			[FieldOffset(Offset = "0x38")]
			private Dictionary<int, string> m_randomNormalEnemyResult;

			// Token: 0x040126CA RID: 75466
			[Token(Token = "0x40126CA")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_GenerateRandomEnemyData;

			// Token: 0x040126CB RID: 75467
			[Token(Token = "0x40126CB")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__InitData;

			// Token: 0x040126CC RID: 75468
			[Token(Token = "0x40126CC")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__GenerateSpecialEnemyTypesLocal;

			// Token: 0x040126CD RID: 75469
			[Token(Token = "0x40126CD")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__GenerateSpecialEnemyTypes;

			// Token: 0x040126CE RID: 75470
			[Token(Token = "0x40126CE")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0__GenerateRandomEnemyData;

			// Token: 0x040126CF RID: 75471
			[Token(Token = "0x40126CF")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__GenerateRoundEnemyData;

			// Token: 0x040126D0 RID: 75472
			[Token(Token = "0x40126D0")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__DoReplaceLevelDataClient;

			// Token: 0x040126D1 RID: 75473
			[Token(Token = "0x40126D1")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0__DoReplaceActionDataClient;

			// Token: 0x040126D2 RID: 75474
			[Token(Token = "0x40126D2")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0__GetEnemyAttrPower;

			// Token: 0x040126D3 RID: 75475
			[Token(Token = "0x40126D3")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__CalculateActionBattleEffectiveness;

			// Token: 0x040126D4 RID: 75476
			[Token(Token = "0x40126D4")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0__CalculateEnemyCountByBattleEffectiveness;

			// Token: 0x040126D5 RID: 75477
			[Token(Token = "0x40126D5")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0__GetTemplateEnemyAttr;

			// Token: 0x040126D6 RID: 75478
			[Token(Token = "0x40126D6")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0__IsTemplateEnemy;

			// Token: 0x040126D7 RID: 75479
			[Token(Token = "0x40126D7")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix0__CheckNeedReplace;

			// Token: 0x040126D8 RID: 75480
			[Token(Token = "0x40126D8")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_ShouldActionUpToServer;

			// Token: 0x040126D9 RID: 75481
			[Token(Token = "0x40126D9")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0200276B RID: 10091
			[Token(Token = "0x200276B")]
			public enum AutoChessRandomEnemyType
			{
				// Token: 0x040126DB RID: 75483
				[Token(Token = "0x40126DB")]
				NormalWalk,
				// Token: 0x040126DC RID: 75484
				[Token(Token = "0x40126DC")]
				NormalFly,
				// Token: 0x040126DD RID: 75485
				[Token(Token = "0x40126DD")]
				EliteWalk,
				// Token: 0x040126DE RID: 75486
				[Token(Token = "0x40126DE")]
				EliteFly,
				// Token: 0x040126DF RID: 75487
				[Token(Token = "0x40126DF")]
				SpecialWalk,
				// Token: 0x040126E0 RID: 75488
				[Token(Token = "0x40126E0")]
				SpecialFly,
				// Token: 0x040126E1 RID: 75489
				[Token(Token = "0x40126E1")]
				NonTemplateWalk,
				// Token: 0x040126E2 RID: 75490
				[Token(Token = "0x40126E2")]
				NonTemplateFly
			}
		}
	}
}
