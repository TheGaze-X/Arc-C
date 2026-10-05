using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Runes;
using UnityEngine;

namespace Torappu.Battle.GameMode
{
	// Token: 0x02002800 RID: 10240
	[Token(Token = "0x2002800")]
	public interface IGameMode : IHotfixable
	{
		// Token: 0x1700257B RID: 9595
		// (get) Token: 0x06011018 RID: 69656
		[Token(Token = "0x1700257B")]
		bool allowManualTick { [Token(Token = "0x6011018")] get; }

		// Token: 0x1700257C RID: 9596
		// (get) Token: 0x06011019 RID: 69657
		[Token(Token = "0x1700257C")]
		bool isOnline { [Token(Token = "0x6011019")] get; }

		// Token: 0x1700257D RID: 9597
		// (get) Token: 0x0601101A RID: 69658
		[Token(Token = "0x1700257D")]
		bool isLargeMap { [Token(Token = "0x601101A")] get; }

		// Token: 0x1700257E RID: 9598
		// (get) Token: 0x0601101B RID: 69659
		[Token(Token = "0x1700257E")]
		bool hasExtraBuildCondition { [Token(Token = "0x601101B")] get; }

		// Token: 0x1700257F RID: 9599
		// (get) Token: 0x0601101C RID: 69660
		[Token(Token = "0x1700257F")]
		bool HookGetNextWave { [Token(Token = "0x601101C")] get; }

		// Token: 0x17002580 RID: 9600
		// (get) Token: 0x0601101D RID: 69661
		[Token(Token = "0x17002580")]
		bool isSupportSlowMotion { [Token(Token = "0x601101D")] get; }

		// Token: 0x17002581 RID: 9601
		// (get) Token: 0x0601101E RID: 69662
		[Token(Token = "0x17002581")]
		bool doDefaultSchedule { [Token(Token = "0x601101E")] get; }

		// Token: 0x17002582 RID: 9602
		// (get) Token: 0x0601101F RID: 69663
		[Token(Token = "0x17002582")]
		bool useLevelBgm { [Token(Token = "0x601101F")] get; }

		// Token: 0x17002583 RID: 9603
		// (get) Token: 0x06011020 RID: 69664
		[Token(Token = "0x17002583")]
		bool allowPoolManagerUnload { [Token(Token = "0x6011020")] get; }

		// Token: 0x17002584 RID: 9604
		// (get) Token: 0x06011021 RID: 69665
		[Token(Token = "0x17002584")]
		bool isLowMemoryGameMode { [Token(Token = "0x6011021")] get; }

		// Token: 0x17002585 RID: 9605
		// (get) Token: 0x06011022 RID: 69666
		[Token(Token = "0x17002585")]
		bool enableParticleEffectManager { [Token(Token = "0x6011022")] get; }

		// Token: 0x17002586 RID: 9606
		// (get) Token: 0x06011023 RID: 69667
		[Token(Token = "0x17002586")]
		bool isInCommonGameStage { [Token(Token = "0x6011023")] get; }

		// Token: 0x17002587 RID: 9607
		// (get) Token: 0x06011024 RID: 69668
		[Token(Token = "0x17002587")]
		bool enableHudSlowTicker { [Token(Token = "0x6011024")] get; }

		// Token: 0x17002588 RID: 9608
		// (get) Token: 0x06011025 RID: 69669
		[Token(Token = "0x17002588")]
		bool enablePause { [Token(Token = "0x6011025")] get; }

		// Token: 0x17002589 RID: 9609
		// (get) Token: 0x06011026 RID: 69670
		[Token(Token = "0x17002589")]
		BattleOutlineConfig outlineConfig { [Token(Token = "0x6011026")] get; }

		// Token: 0x1700258A RID: 9610
		// (get) Token: 0x06011027 RID: 69671
		// (set) Token: 0x06011028 RID: 69672
		[Token(Token = "0x1700258A")]
		Character draggingDummy { [Token(Token = "0x6011027")] get; [Token(Token = "0x6011028")] set; }

		// Token: 0x1700258B RID: 9611
		// (get) Token: 0x06011029 RID: 69673
		[Token(Token = "0x1700258B")]
		GameModeMeta.GameModeType gameModeType { [Token(Token = "0x6011029")] get; }

		// Token: 0x0601102A RID: 69674
		[Token(Token = "0x601102A")]
		bool HookSeed(out int seed);

		// Token: 0x0601102B RID: 69675
		[Token(Token = "0x601102B")]
		float GetCompleteProgress();

		// Token: 0x0601102C RID: 69676
		[Token(Token = "0x601102C")]
		void Init(ref GameModeMeta meta, ref int randomSeed, BattlePlayerData playerData, LevelData levelData);

		// Token: 0x0601102D RID: 69677
		[Token(Token = "0x601102D")]
		void OnPostInit();

		// Token: 0x0601102E RID: 69678
		[Token(Token = "0x601102E")]
		void StartGame(Action doDefaultStart);

		// Token: 0x0601102F RID: 69679
		[Token(Token = "0x601102F")]
		void OnGameOver(ref BattleController.GameResult result);

		// Token: 0x06011030 RID: 69680
		[Token(Token = "0x6011030")]
		void Tick(Action doDefaultTick);

		// Token: 0x06011031 RID: 69681
		[Token(Token = "0x6011031")]
		void OnModifyLifePoint(ref Modifier modifier);

		// Token: 0x06011032 RID: 69682
		[Token(Token = "0x6011032")]
		bool HookPlayerOp_Withdraw(Character character);

		// Token: 0x06011033 RID: 69683
		[Token(Token = "0x6011033")]
		bool HookPlayerOp_Spawn(uint uniqueId, SharedConsts.Direction direction, Tile tile);

		// Token: 0x06011034 RID: 69684
		[Token(Token = "0x6011034")]
		bool HookPlayerOp_TrigSkill(Character character);

		// Token: 0x06011035 RID: 69685
		[Token(Token = "0x6011035")]
		Tile Hook_MapGetTileFromScreenPos(Vector2 screenPos, out Vector2 mapPos);

		// Token: 0x06011036 RID: 69686
		[Token(Token = "0x6011036")]
		bool IsHook_MapGetTileFromScreenPos();

		// Token: 0x06011037 RID: 69687
		[Token(Token = "0x6011037")]
		LevelData.Options PostprocessLevelOptions(LevelData.Options options);

		// Token: 0x06011038 RID: 69688
		[Token(Token = "0x6011038")]
		void PreprocessLevelData(LevelData levelData);

		// Token: 0x06011039 RID: 69689
		[Token(Token = "0x6011039")]
		void PostprocessMap(Map map);

		// Token: 0x0601103A RID: 69690
		[Token(Token = "0x601103A")]
		void PreprocessPlayerData(List<BattlePlayerData> dataList);

		// Token: 0x0601103B RID: 69691
		[Token(Token = "0x601103B")]
		void PreprocessPlayerDeckList(ListDict<PlayerSide, Deck> deckList);

		// Token: 0x0601103C RID: 69692
		[Token(Token = "0x601103C")]
		void PreprocessCharacterCard(BattleCharacterData data, Character character);

		// Token: 0x0601103D RID: 69693
		[Token(Token = "0x601103D")]
		void PreProcessDeckCards(IList<Deck.Card> cards);

		// Token: 0x0601103E RID: 69694
		[Token(Token = "0x601103E")]
		void SortDeck(Deck.Card[] cards);

		// Token: 0x0601103F RID: 69695
		[Token(Token = "0x601103F")]
		void SortDeckRuntime(Deck.Card[] cards);

		// Token: 0x06011040 RID: 69696
		[Token(Token = "0x6011040")]
		void PreprocessEnemy(LevelData.EnemyData data);

		// Token: 0x06011041 RID: 69697
		[Token(Token = "0x6011041")]
		void PreprocessRuneData(RuneManager manager);

		// Token: 0x06011042 RID: 69698
		[Token(Token = "0x6011042")]
		void PreprocessRuneInput(IRuneDataHolder runeInput);

		// Token: 0x06011043 RID: 69699
		[Token(Token = "0x6011043")]
		void PostprocessRuneExtraData(Rune.RuneLevelExtraOutput extraData);

		// Token: 0x06011044 RID: 69700
		[Token(Token = "0x6011044")]
		Scheduler.SchedulerPreprocessor GetSchedulerPreprocessor();

		// Token: 0x1700258C RID: 9612
		// (get) Token: 0x06011045 RID: 69701
		[Token(Token = "0x1700258C")]
		Scheduler.DefaultWaveHandler waveHandler { [Token(Token = "0x6011045")] get; }

		// Token: 0x06011046 RID: 69702
		[Token(Token = "0x6011046")]
		void PreprocessLevelWithScheduler(LevelData levelData);

		// Token: 0x06011047 RID: 69703
		[Token(Token = "0x6011047")]
		List<LevelData.GlobalBuffData> GatherGlobalBuffs();

		// Token: 0x06011048 RID: 69704
		[Token(Token = "0x6011048")]
		List<GlobalEnvSystemData> GatherEnvSystems();

		// Token: 0x06011049 RID: 69705
		[Token(Token = "0x6011049")]
		bool NeedPreprocessPredefinedCharacter();

		// Token: 0x0601104A RID: 69706
		[Token(Token = "0x601104A")]
		SpeedLevel HookSpeedLevel(SpeedLevel originSpeedLevel);

		// Token: 0x0601104B RID: 69707
		[Token(Token = "0x601104B")]
		void OnApplyingGlobalModifier(ref Modifier modifier);

		// Token: 0x0601104C RID: 69708
		[Token(Token = "0x601104C")]
		void OnUnitRegistered(Unit unit);

		// Token: 0x0601104D RID: 69709
		[Token(Token = "0x601104D")]
		void OnUnitUnregistered(Unit unit);

		// Token: 0x0601104E RID: 69710
		[Token(Token = "0x601104E")]
		void OnCharacterFinished(Character character, Entity.FinishReason reason);

		// Token: 0x0601104F RID: 69711
		[Token(Token = "0x601104F")]
		void OnEnemyFinished(Enemy enemy, Entity.FinishReason reason);

		// Token: 0x06011050 RID: 69712
		[Token(Token = "0x6011050")]
		void OnWaveWillStart(LevelData.WaveData waveData);

		// Token: 0x06011051 RID: 69713
		[Token(Token = "0x6011051")]
		void OnWaveWillFinish(LevelData.WaveData waveData);

		// Token: 0x06011052 RID: 69714
		[Token(Token = "0x6011052")]
		void ParseBattleEvents(LevelData.WaveData.FragmentData.ActionData data);

		// Token: 0x06011053 RID: 69715
		[Token(Token = "0x6011053")]
		bool CheckTileValid(int row, int col);

		// Token: 0x06011054 RID: 69716
		[Token(Token = "0x6011054")]
		string HookTileEffect(string originEffectKey);

		// Token: 0x06011055 RID: 69717
		[Token(Token = "0x6011055")]
		string GetModeTileEffect(Tile tile);

		// Token: 0x06011056 RID: 69718
		[Token(Token = "0x6011056")]
		string HookTileAppendInfoKey(string originTileKey);

		// Token: 0x06011057 RID: 69719
		[Token(Token = "0x6011057")]
		bool GameNotFinishCondition();

		// Token: 0x06011058 RID: 69720
		[Token(Token = "0x6011058")]
		bool CheckCardReadyToSpawn(Deck.Card card);

		// Token: 0x06011059 RID: 69721
		[Token(Token = "0x6011059")]
		void OnCardRecycle(Deck.Card card);

		// Token: 0x0601105A RID: 69722
		[Token(Token = "0x601105A")]
		void OnCardSpawned(Deck.Card card, bool spawnManually);

		// Token: 0x0601105B RID: 69723
		[Token(Token = "0x601105B")]
		void OnCardListChanged(Deck.Card card);

		// Token: 0x0601105C RID: 69724
		[Token(Token = "0x601105C")]
		bool HookBattleFinishAudio(BattleController.GameResult result);

		// Token: 0x0601105D RID: 69725
		[Token(Token = "0x601105D")]
		bool HookPlayAudioSignal(string ev, Unit unit, bool ignorePredefined);

		// Token: 0x0601105E RID: 69726
		[Token(Token = "0x601105E")]
		bool HookEnemyReachedExitAudio(Enemy enemy);

		// Token: 0x0601105F RID: 69727
		[Token(Token = "0x601105F")]
		bool EnableGlobalBuffExtraData(GlobalBuff buff, LevelData.GlobalBuffData data);

		// Token: 0x06011060 RID: 69728
		[Token(Token = "0x6011060")]
		bool TryHookCheckWaveNotFinish(bool schedulerResult, out bool result);

		// Token: 0x06011061 RID: 69729
		[Token(Token = "0x6011061")]
		void OnSpawnSummonedEnemy();

		// Token: 0x06011062 RID: 69730
		[Token(Token = "0x6011062")]
		void OnSpawnSummonedEnemyFinished();

		// Token: 0x06011063 RID: 69731
		[Token(Token = "0x6011063")]
		bool CheckRenderInvisible(Entity entity, BattleRenderInvisibleMask mask);

		// Token: 0x06011064 RID: 69732
		[Token(Token = "0x6011064")]
		void FinishGame(Action<BattleController.GameResult, bool> gameFinishCallback, BattleController.GameResult result, bool silent = false);

		// Token: 0x06011065 RID: 69733
		[Token(Token = "0x6011065")]
		IEnumerator FinalSchedule();

		// Token: 0x06011066 RID: 69734
		[Token(Token = "0x6011066")]
		bool TryGetNextWaveIndexInGameMode(out int index);

		// Token: 0x06011067 RID: 69735
		[Token(Token = "0x6011067")]
		void OnDummyTouchedToTile(Character character, Tile tile, Vector3 dummyPos);

		// Token: 0x06011068 RID: 69736
		[Token(Token = "0x6011068")]
		bool Hook_OnDummyDragging();

		// Token: 0x06011069 RID: 69737
		[Token(Token = "0x6011069")]
		void OnDummySetBodyAndFaceDirection(Character character, SharedConsts.Direction direction);

		// Token: 0x0601106A RID: 69738
		[Token(Token = "0x601106A")]
		bool OnEntityApplyModifier(Entity entity, ref Modifier modifier);

		// Token: 0x0601106B RID: 69739
		[Token(Token = "0x601106B")]
		void DestroyEntity(Entity entity, Entity.FinishReason reason);

		// Token: 0x0601106C RID: 69740
		[Token(Token = "0x601106C")]
		bool CheckBuildable(BuildCondition buildCondition, Tile tile, SharedConsts.Direction direction, bool spawnManually, bool overflowOccupiedCnt, BattleCharacterData sourceData, PlayerSide operationSide = PlayerSide.DEFAULT);

		// Token: 0x0601106D RID: 69741
		[Token(Token = "0x601106D")]
		bool AllowNoneBuildableType(BattleCharacterData sourceData);

		// Token: 0x0601106E RID: 69742
		[Token(Token = "0x601106E")]
		bool IsSkillClickable();

		// Token: 0x0601106F RID: 69743
		[Token(Token = "0x601106F")]
		PlayerBattleRank GetBattleCompleteRank();

		// Token: 0x06011070 RID: 69744
		[Token(Token = "0x6011070")]
		object GetActMeta();

		// Token: 0x06011071 RID: 69745
		[Token(Token = "0x6011071")]
		void OnPlayerLifeToZero(PlayerSide side);

		// Token: 0x06011072 RID: 69746
		[Token(Token = "0x6011072")]
		bool IsMultiplayerLocal();

		// Token: 0x06011073 RID: 69747
		[Token(Token = "0x6011073")]
		void OnEnemyReachExit(Enemy enemy, Tile cacheTile);

		// Token: 0x06011074 RID: 69748
		[Token(Token = "0x6011074")]
		bool TryShowTileInfoToast(Tile tile, out int id);

		// Token: 0x06011075 RID: 69749
		[Token(Token = "0x6011075")]
		bool TrySetTileHighlightType(Tile tile, bool isBuildable, BattleCharacterData sourceData);

		// Token: 0x06011076 RID: 69750
		[Token(Token = "0x6011076")]
		bool TryGetCustomTileHighlightColor(out Color customColor, out Color emissionColor);

		// Token: 0x06011077 RID: 69751
		[Token(Token = "0x6011077")]
		bool CheckUnitValidHudPlugin(Unit unit);

		// Token: 0x06011078 RID: 69752
		[Token(Token = "0x6011078")]
		void OnCharacterRespawnFailed(Character character, Deck.Card card, PlayerSide playerSide);

		// Token: 0x06011079 RID: 69753
		[Token(Token = "0x6011079")]
		void OnDestroy();

		// Token: 0x0601107A RID: 69754
		[Token(Token = "0x601107A")]
		HashSet<GridPosition> FetchValidMapGrids();
	}
}
