using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200240C RID: 9228
	[Token(Token = "0x200240C")]
	public class Scheduler : MonoBehaviour, IBattleModule, IHotfixable
	{
		// Token: 0x17001E28 RID: 7720
		// (get) Token: 0x0600EBE0 RID: 60384 RVA: 0x000563B8 File Offset: 0x000545B8
		// (set) Token: 0x0600EBE1 RID: 60385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001E28")]
		public int totalEnemiesCnt
		{
			[Token(Token = "0x600EBE0")]
			[Address(RVA = "0x62D9C0", Offset = "0x62C5C0", VA = "0x18062D9C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600EBE1")]
			[Address(RVA = "0x62DEA0", Offset = "0x62CAA0", VA = "0x18062DEA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001E29 RID: 7721
		// (get) Token: 0x0600EBE2 RID: 60386 RVA: 0x000563D0 File Offset: 0x000545D0
		[Token(Token = "0x17001E29")]
		public int totalWavesCnt
		{
			[Token(Token = "0x600EBE2")]
			[Address(RVA = "0x62DA30", Offset = "0x62C630", VA = "0x18062DA30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001E2A RID: 7722
		// (get) Token: 0x0600EBE3 RID: 60387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001E2A")]
		public LevelData.WaveData[] waves
		{
			[Token(Token = "0x600EBE3")]
			[Address(RVA = "0x62DCF0", Offset = "0x62C8F0", VA = "0x18062DCF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E2B RID: 7723
		// (get) Token: 0x0600EBE4 RID: 60388 RVA: 0x000563E8 File Offset: 0x000545E8
		[Token(Token = "0x17001E2B")]
		public int remainingEnemiesCnt
		{
			[Token(Token = "0x600EBE4")]
			[Address(RVA = "0x62D810", Offset = "0x62C410", VA = "0x18062D810")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001E2C RID: 7724
		// (get) Token: 0x0600EBE5 RID: 60389 RVA: 0x00056400 File Offset: 0x00054600
		[Token(Token = "0x17001E2C")]
		public int finishedEnemiesCnt
		{
			[Token(Token = "0x600EBE5")]
			[Address(RVA = "0x62D510", Offset = "0x62C110", VA = "0x18062D510")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001E2D RID: 7725
		// (get) Token: 0x0600EBE6 RID: 60390 RVA: 0x00056418 File Offset: 0x00054618
		[Token(Token = "0x17001E2D")]
		public uint spawnedEnemiesCnt
		{
			[Token(Token = "0x600EBE6")]
			[Address(RVA = "0x62D8E0", Offset = "0x62C4E0", VA = "0x18062D8E0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001E2E RID: 7726
		// (get) Token: 0x0600EBE7 RID: 60391 RVA: 0x00056430 File Offset: 0x00054630
		[Token(Token = "0x17001E2E")]
		public int spawnedWavesCnt
		{
			[Token(Token = "0x600EBE7")]
			[Address(RVA = "0x62D950", Offset = "0x62C550", VA = "0x18062D950")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001E2F RID: 7727
		// (get) Token: 0x0600EBE8 RID: 60392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001E2F")]
		public List<Enemy> managedWaveEnemies
		{
			[Token(Token = "0x600EBE8")]
			[Address(RVA = "0x62D790", Offset = "0x62C390", VA = "0x18062D790")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E30 RID: 7728
		// (get) Token: 0x0600EBE9 RID: 60393 RVA: 0x00056448 File Offset: 0x00054648
		[Token(Token = "0x17001E30")]
		public int killedEnemiesCnt
		{
			[Token(Token = "0x600EBE9")]
			[Address(RVA = "0x62D650", Offset = "0x62C250", VA = "0x18062D650")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001E31 RID: 7729
		// (get) Token: 0x0600EBEA RID: 60394 RVA: 0x00056460 File Offset: 0x00054660
		[Token(Token = "0x17001E31")]
		public int validKilledEnemiesCnt
		{
			[Token(Token = "0x600EBEA")]
			[Address(RVA = "0x62DB70", Offset = "0x62C770", VA = "0x18062DB70")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001E32 RID: 7730
		// (get) Token: 0x0600EBEB RID: 60395 RVA: 0x00056478 File Offset: 0x00054678
		[Token(Token = "0x17001E32")]
		public int validFinishedEnemiesCnt
		{
			[Token(Token = "0x600EBEB")]
			[Address(RVA = "0x62DAB0", Offset = "0x62C6B0", VA = "0x18062DAB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001E33 RID: 7731
		// (get) Token: 0x0600EBEC RID: 60396 RVA: 0x00056490 File Offset: 0x00054690
		[Token(Token = "0x17001E33")]
		public int validMissedEnemiesCnt
		{
			[Token(Token = "0x600EBEC")]
			[Address(RVA = "0x62DC30", Offset = "0x62C830", VA = "0x18062DC30")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001E34 RID: 7732
		// (get) Token: 0x0600EBED RID: 60397 RVA: 0x000564A8 File Offset: 0x000546A8
		[Token(Token = "0x17001E34")]
		public float completeProgress
		{
			[Token(Token = "0x600EBED")]
			[Address(RVA = "0x62D400", Offset = "0x62C000", VA = "0x18062D400")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001E35 RID: 7733
		// (get) Token: 0x0600EBEE RID: 60398 RVA: 0x000564C0 File Offset: 0x000546C0
		[Token(Token = "0x17001E35")]
		public bool inWavePostDelay
		{
			[Token(Token = "0x600EBEE")]
			[Address(RVA = "0x62D5D0", Offset = "0x62C1D0", VA = "0x18062D5D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001E36 RID: 7734
		// (get) Token: 0x0600EBEF RID: 60399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001E36")]
		public List<Enemy> managedFinalEnemies
		{
			[Token(Token = "0x600EBEF")]
			[Address(RVA = "0x62D710", Offset = "0x62C310", VA = "0x18062D710")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001E37 RID: 7735
		// (get) Token: 0x0600EBF0 RID: 60400 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600EBF1 RID: 60401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001E37")]
		private BattleController battleController
		{
			[Token(Token = "0x600EBF0")]
			[Address(RVA = "0x62D380", Offset = "0x62BF80", VA = "0x18062D380")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600EBF1")]
			[Address(RVA = "0x62DE00", Offset = "0x62CA00", VA = "0x18062DE00")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17001E38 RID: 7736
		// (get) Token: 0x0600EBF2 RID: 60402 RVA: 0x000564D8 File Offset: 0x000546D8
		// (set) Token: 0x0600EBF3 RID: 60403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001E38")]
		public bool allowSummonSpawnEnemy
		{
			[Token(Token = "0x600EBF2")]
			[Address(RVA = "0x62D300", Offset = "0x62BF00", VA = "0x18062D300")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600EBF3")]
			[Address(RVA = "0x62DD70", Offset = "0x62C970", VA = "0x18062DD70")]
			set
			{
			}
		}

		// Token: 0x0600EBF4 RID: 60404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBF4")]
		[Address(RVA = "0x623FE0", Offset = "0x622BE0", VA = "0x180623FE0")]
		public void Init(LevelData levelData, IList<string> enabledHiddenGroups, IList<string> disabledHiddenGroups)
		{
		}

		// Token: 0x0600EBF5 RID: 60405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBF5")]
		[Address(RVA = "0x625BD0", Offset = "0x6247D0", VA = "0x180625BD0")]
		public void Reset()
		{
		}

		// Token: 0x0600EBF6 RID: 60406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBF6")]
		[Address(RVA = "0x629550", Offset = "0x628150", VA = "0x180629550")]
		public void UpdateWaves(LevelData.WaveData[] newWaves)
		{
		}

		// Token: 0x0600EBF7 RID: 60407 RVA: 0x000564F0 File Offset: 0x000546F0
		[Token(Token = "0x600EBF7")]
		[Address(RVA = "0x62BA80", Offset = "0x62A680", VA = "0x18062BA80")]
		private bool _NotCountInTotal(LevelData.WaveData.FragmentData.ActionData actionData)
		{
			return default(bool);
		}

		// Token: 0x0600EBF8 RID: 60408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBF8")]
		[Address(RVA = "0x625140", Offset = "0x623D40", VA = "0x180625140", Slot = "5")]
		public void OnGameInit(LevelData.Options levelOptions)
		{
		}

		// Token: 0x0600EBF9 RID: 60409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBF9")]
		[Address(RVA = "0x625270", Offset = "0x623E70", VA = "0x180625270", Slot = "6")]
		public void OnGameReady()
		{
		}

		// Token: 0x0600EBFA RID: 60410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBFA")]
		[Address(RVA = "0x625510", Offset = "0x624110", VA = "0x180625510", Slot = "7")]
		public void OnGameStart()
		{
		}

		// Token: 0x0600EBFB RID: 60411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBFB")]
		[Address(RVA = "0x625740", Offset = "0x624340", VA = "0x180625740")]
		public void RegisterPlugin(Scheduler.IWavePlugin wavePlugin)
		{
		}

		// Token: 0x0600EBFC RID: 60412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBFC")]
		[Address(RVA = "0x6252E0", Offset = "0x623EE0", VA = "0x1806252E0", Slot = "4")]
		public void OnGameReset(BattleController controller)
		{
		}

		// Token: 0x0600EBFD RID: 60413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EBFD")]
		[Address(RVA = "0x6251C0", Offset = "0x623DC0", VA = "0x1806251C0", Slot = "8")]
		public void OnGameOver(BattleController.GameResult result)
		{
		}

		// Token: 0x0600EBFE RID: 60414 RVA: 0x00056508 File Offset: 0x00054708
		[Token(Token = "0x600EBFE")]
		[Address(RVA = "0x623710", Offset = "0x622310", VA = "0x180623710")]
		public bool CheckBranchIsReadyToMoveNext(string branchId)
		{
			return default(bool);
		}

		// Token: 0x0600EBFF RID: 60415 RVA: 0x00056520 File Offset: 0x00054720
		[Token(Token = "0x600EBFF")]
		[Address(RVA = "0x623610", Offset = "0x622210", VA = "0x180623610")]
		public bool CheckBranchIsNotEmpty(string branchId)
		{
			return default(bool);
		}

		// Token: 0x0600EC00 RID: 60416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC00")]
		[Address(RVA = "0x623390", Offset = "0x621F90", VA = "0x180623390")]
		public static void AddBlockGameKey(string key)
		{
		}

		// Token: 0x0600EC01 RID: 60417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC01")]
		[Address(RVA = "0x625A10", Offset = "0x624610", VA = "0x180625A10")]
		public static void RemoveBlockGameKey(string key)
		{
		}

		// Token: 0x0600EC02 RID: 60418 RVA: 0x00056538 File Offset: 0x00054738
		[Token(Token = "0x600EC02")]
		[Address(RVA = "0x628DD0", Offset = "0x6279D0", VA = "0x180628DD0")]
		public bool TryMoveNextBranch(string branchId, bool isLoop)
		{
			return default(bool);
		}

		// Token: 0x0600EC03 RID: 60419 RVA: 0x00056550 File Offset: 0x00054750
		[Token(Token = "0x600EC03")]
		[Address(RVA = "0x629230", Offset = "0x627E30", VA = "0x180629230")]
		public bool TryPickRandomBranch(string branchId, bool blockGameFinish = false)
		{
			return default(bool);
		}

		// Token: 0x0600EC04 RID: 60420 RVA: 0x00056568 File Offset: 0x00054768
		[Token(Token = "0x600EC04")]
		[Address(RVA = "0x629010", Offset = "0x627C10", VA = "0x180629010")]
		public bool TryPickRandomBranchNotRepeat(string branchId, bool blockGameFinish = false)
		{
			return default(bool);
		}

		// Token: 0x0600EC05 RID: 60421 RVA: 0x00056580 File Offset: 0x00054780
		[Token(Token = "0x600EC05")]
		[Address(RVA = "0x628A50", Offset = "0x627650", VA = "0x180628A50")]
		public bool TryGetEnemyRouteFromBranch(string branchId, int actionIndex, out Route route, out string enemyKey)
		{
			return default(bool);
		}

		// Token: 0x0600EC06 RID: 60422 RVA: 0x00056598 File Offset: 0x00054798
		[Token(Token = "0x600EC06")]
		[Address(RVA = "0x628BA0", Offset = "0x6277A0", VA = "0x180628BA0")]
		public bool TryGetEnemyRouteFromBranch(string branchId, int actionIndex, out int routeIndex, out string enemyKey)
		{
			return default(bool);
		}

		// Token: 0x0600EC07 RID: 60423 RVA: 0x000565B0 File Offset: 0x000547B0
		[Token(Token = "0x600EC07")]
		[Address(RVA = "0x628930", Offset = "0x627530", VA = "0x180628930")]
		public bool TryGetBranch(string branchId, out LevelData.BranchData branchData)
		{
			return default(bool);
		}

		// Token: 0x0600EC08 RID: 60424 RVA: 0x000565C8 File Offset: 0x000547C8
		[Token(Token = "0x600EC08")]
		[Address(RVA = "0x628120", Offset = "0x626D20", VA = "0x180628120")]
		public Scheduler.SchedulerSnapshot TakeSnapshot()
		{
			return default(Scheduler.SchedulerSnapshot);
		}

		// Token: 0x0600EC09 RID: 60425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC09")]
		[Address(RVA = "0x623D50", Offset = "0x622950", VA = "0x180623D50")]
		public void FinishCurrentWave(bool alsoFinishFinalEnemies = false)
		{
		}

		// Token: 0x0600EC0A RID: 60426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC0A")]
		[Address(RVA = "0x623C60", Offset = "0x622860", VA = "0x180623C60")]
		public void FinishCurrentWaveDeeply()
		{
		}

		// Token: 0x0600EC0B RID: 60427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC0B")]
		[Address(RVA = "0x6257F0", Offset = "0x6243F0", VA = "0x1806257F0")]
		public void ReleaseEnemyFromCurrentWave(Enemy enemy, bool removeWaveCache = false)
		{
		}

		// Token: 0x0600EC0C RID: 60428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC0C")]
		[Address(RVA = "0x6282A0", Offset = "0x626EA0", VA = "0x1806282A0")]
		public void TrackEnemyAtNextWave(Enemy enemy, int waveDelta)
		{
		}

		// Token: 0x0600EC0D RID: 60429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC0D")]
		[Address(RVA = "0x628380", Offset = "0x626F80", VA = "0x180628380")]
		public void TrackEnemyAtSpecificWave(Enemy enemy, int waveDelta)
		{
		}

		// Token: 0x0600EC0E RID: 60430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC0E")]
		[Address(RVA = "0x6281E0", Offset = "0x626DE0", VA = "0x1806281E0")]
		public void TrackAllManagedEnemiesAtNextWave(int waveDelta)
		{
		}

		// Token: 0x0600EC0F RID: 60431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC0F")]
		[Address(RVA = "0x623AF0", Offset = "0x6226F0", VA = "0x180623AF0")]
		public void DoSchedule()
		{
		}

		// Token: 0x0600EC10 RID: 60432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC10")]
		[Address(RVA = "0x62AF20", Offset = "0x629B20", VA = "0x18062AF20")]
		private IEnumerator _DoSchedule()
		{
			return null;
		}

		// Token: 0x0600EC11 RID: 60433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC11")]
		[Address(RVA = "0x623920", Offset = "0x622520", VA = "0x180623920")]
		public void DoFinishGame(Action callback)
		{
		}

		// Token: 0x0600EC12 RID: 60434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC12")]
		[Address(RVA = "0x623830", Offset = "0x622430", VA = "0x180623830")]
		public IEnumerator DealWithAfterBattleWaveFromPluginIfValid(Action callback)
		{
			return null;
		}

		// Token: 0x0600EC13 RID: 60435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC13")]
		[Address(RVA = "0x62A380", Offset = "0x628F80", VA = "0x18062A380")]
		private IEnumerator _DealAfterBattleWaveFromPlugin()
		{
			return null;
		}

		// Token: 0x0600EC14 RID: 60436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC14")]
		[Address(RVA = "0x62A6E0", Offset = "0x6292E0", VA = "0x18062A6E0")]
		private IEnumerator _DealWave(LevelData.WaveData wave, LevelData.WaveData nextWave)
		{
			return null;
		}

		// Token: 0x0600EC15 RID: 60437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC15")]
		[Address(RVA = "0x62A5F0", Offset = "0x6291F0", VA = "0x18062A5F0")]
		private IEnumerator _DealFragment(LevelData.WaveData.FragmentData fragment)
		{
			return null;
		}

		// Token: 0x0600EC16 RID: 60438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC16")]
		[Address(RVA = "0x62A440", Offset = "0x629040", VA = "0x18062A440")]
		private static IEnumerator _DealBranchPhase(LevelData.BranchData.PhaseData phase, Scheduler.DefaultWaveHandler handler, Dictionary<string, Scheduler.EnemyItem> enemyMap, Func<LevelData.WaveData.FragmentData.ActionData, Action<LevelData.WaveData.FragmentData.ActionData>, IEnumerator>[] actionExecutors, Func<LevelData.WaveData.FragmentData.ActionData, bool> actionValidator, [Optional] string branchId, bool blockGameFinish = false, [Optional] Func<float> actionBlockTimer)
		{
			return null;
		}

		// Token: 0x0600EC17 RID: 60439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC17")]
		[Address(RVA = "0x629EE0", Offset = "0x628AE0", VA = "0x180629EE0")]
		private static void _DealAction(LevelData.WaveData.FragmentData.ActionData action, float fragmentPreDelay, Dictionary<string, Scheduler.EnemyItem> enemyMap, List<Scheduler.ActionItem> actionQueue, ref int blockCounter, bool fromBranch)
		{
		}

		// Token: 0x0600EC18 RID: 60440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC18")]
		[Address(RVA = "0x628810", Offset = "0x627410", VA = "0x180628810")]
		public IEnumerator TryDealDynamicPhase(LevelData.BranchData.PhaseData phaseData, [Optional] Func<float> actionBlockTimer, bool includeInTotalEnemy = true)
		{
			return null;
		}

		// Token: 0x0600EC19 RID: 60441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC19")]
		[Address(RVA = "0x62B570", Offset = "0x62A170", VA = "0x18062B570")]
		private IEnumerator _DoSpawn(LevelData.WaveData.FragmentData.ActionData data, Action<LevelData.WaveData.FragmentData.ActionData> cb)
		{
			return null;
		}

		// Token: 0x0600EC1A RID: 60442 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC1A")]
		[Address(RVA = "0x626990", Offset = "0x625590", VA = "0x180626990")]
		public IEnumerator SpawnSummonedEnemyTrackedInGameMode(string enemyKey, Enemy host, bool managedByScheduler, bool dontBlockWave, Vector2 summonPos, FP randomOffset, FP delayTime, bool ignoreOffset, bool unharmful, bool stopSummonIfHostDead = false, bool addBuffToEnemy = false, [Optional] Blackboard blackboard, [Optional] BuffData buffData, MotionMask _checkMotionMode = MotionMask.ALL)
		{
			return null;
		}

		// Token: 0x0600EC1B RID: 60443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC1B")]
		[Address(RVA = "0x626740", Offset = "0x625340", VA = "0x180626740")]
		public IEnumerator SpawnSummonedEnemyTrackedInGameModeWithRuntimeRoute(string enemyKey, Enemy host, GridPosition sourcePos, GridPosition targetPos, bool managedByScheduler, bool dontBlockWave, FP delayTime, float waitTime, bool unharmful, MotionMode motionMode, bool stopSummonIfHostDead = false, bool addBuffToEnemy = false, [Optional] Blackboard blackboard, [Optional] BuffData buffData)
		{
			return null;
		}

		// Token: 0x0600EC1C RID: 60444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC1C")]
		[Address(RVA = "0x626BF0", Offset = "0x6257F0", VA = "0x180626BF0")]
		public IEnumerator SpawnSummonedEnemyTrackedInGameMode(Scheduler.SpawnSummonedEnemyTrackedInGameModeParams param)
		{
			return null;
		}

		// Token: 0x0600EC1D RID: 60445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC1D")]
		[Address(RVA = "0x6277B0", Offset = "0x6263B0", VA = "0x1806277B0")]
		public Enemy SpawnSummonedEnemyWithRuntimeRoute(string enemyKey, Entity host, GridPosition sourcePos, GridPosition targetPos, MotionMode motionMode, bool unharmful, bool alwaysCountAsKilled, float waitTime, float offset, bool managedByScheduler = false, bool avoidHighland = false, bool addBuffToEnemy = false, [Optional] Blackboard blackboard, [Optional] BuffData buffData, bool withOutHost = false)
		{
			return null;
		}

		// Token: 0x0600EC1E RID: 60446 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC1E")]
		[Address(RVA = "0x626D60", Offset = "0x625960", VA = "0x180626D60")]
		public Enemy SpawnSummonedEnemyWithBranchRoute(string branchId, int actionIndex, bool dontBlockWave, bool unharmful, bool alwaysCountAsKilled, bool isSummon, bool managedByScheduler, bool disableBornTweenColor, string overrideEnemyKey)
		{
			return null;
		}

		// Token: 0x0600EC1F RID: 60447 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC1F")]
		[Address(RVA = "0x626530", Offset = "0x625130", VA = "0x180626530")]
		public Enemy SpawnEnemyWithRoute(string enemyKey, Entity host, Route route, bool unharmful, bool alwaysCountAsKilled, bool managedByScheduler)
		{
			return null;
		}

		// Token: 0x0600EC20 RID: 60448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC20")]
		[Address(RVA = "0x627DD0", Offset = "0x6269D0", VA = "0x180627DD0")]
		public void SpawnSummonedEnemyWithRuntimeRoute(string enemyKey, Entity host, GridPosition startGridPos, GridPosition endGridPos, MotionMode motionMode, bool unharmful, bool alwaysCountAsKilled, RouteData.CheckpointData[] checkPointDataArray, bool addBuffToEnemy = false, [Optional] Blackboard blackboard, [Optional] BuffData buffData)
		{
		}

		// Token: 0x0600EC21 RID: 60449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC21")]
		[Address(RVA = "0x627110", Offset = "0x625D10", VA = "0x180627110")]
		public void SpawnSummonedEnemyWithFixedDirection(string enemyKey, Enemy host, MotionMode motionMode, bool unharmful, bool alwaysCountAsKilled, float offset, float startAngle, float endAngle, int summonCnt)
		{
		}

		// Token: 0x0600EC22 RID: 60450 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC22")]
		[Address(RVA = "0x625D30", Offset = "0x624930", VA = "0x180625D30")]
		public Enemy SpawnEnemyNpc(string enemyKey, GridPosition targetPos, GridPosition endPos, MotionMode motionMode = MotionMode.WALK, bool unharmful = true, bool alwaysCountAsKilled = false, [Optional] string alias, bool randomOffset = false)
		{
			return null;
		}

		// Token: 0x0600EC23 RID: 60451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC23")]
		[Address(RVA = "0x62B0E0", Offset = "0x629CE0", VA = "0x18062B0E0")]
		private Enemy _DoSpawnEnemyInternal(string enemyKey, int routeIndex, Enemy.Options options, bool isExtraRoute)
		{
			return null;
		}

		// Token: 0x0600EC24 RID: 60452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC24")]
		[Address(RVA = "0x62B330", Offset = "0x629F30", VA = "0x18062B330")]
		private Enemy _DoSpawnEnemyInternal(string enemyKey, Route route, Enemy.Options options)
		{
			return null;
		}

		// Token: 0x0600EC25 RID: 60453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC25")]
		[Address(RVA = "0x629610", Offset = "0x628210", VA = "0x180629610")]
		private void _AlertSpawnError(string enemyKey)
		{
		}

		// Token: 0x0600EC26 RID: 60454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC26")]
		[Address(RVA = "0x623E50", Offset = "0x622A50", VA = "0x180623E50")]
		public Route GenerateRuntimeRoute(RouteData data)
		{
			return null;
		}

		// Token: 0x0600EC27 RID: 60455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC27")]
		[Address(RVA = "0x623F10", Offset = "0x622B10", VA = "0x180623F10")]
		public Route GenerateRuntimeTraceRoute(GridPosition tracePosition, MotionMode motionMode)
		{
			return null;
		}

		// Token: 0x0600EC28 RID: 60456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC28")]
		[Address(RVA = "0x62AE10", Offset = "0x629A10", VA = "0x18062AE10")]
		private IEnumerator _DoPreviewCursor(LevelData.WaveData.FragmentData.ActionData data, Action<LevelData.WaveData.FragmentData.ActionData> cb)
		{
			return null;
		}

		// Token: 0x0600EC29 RID: 60457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC29")]
		[Address(RVA = "0x62B680", Offset = "0x62A280", VA = "0x18062B680")]
		private IEnumerator _DoStory(LevelData.WaveData.FragmentData.ActionData data, Action<LevelData.WaveData.FragmentData.ActionData> cb)
		{
			return null;
		}

		// Token: 0x0600EC2A RID: 60458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC2A")]
		[Address(RVA = "0x62A900", Offset = "0x629500", VA = "0x18062A900")]
		private IEnumerator _DoDialog(LevelData.WaveData.FragmentData.ActionData data, Action<LevelData.WaveData.FragmentData.ActionData> cb)
		{
			return null;
		}

		// Token: 0x0600EC2B RID: 60459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC2B")]
		[Address(RVA = "0x62B880", Offset = "0x62A480", VA = "0x18062B880")]
		private IEnumerator _DoTutorial(LevelData.WaveData.FragmentData.ActionData data, Action<LevelData.WaveData.FragmentData.ActionData> cb)
		{
			return null;
		}

		// Token: 0x0600EC2C RID: 60460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC2C")]
		[Address(RVA = "0x62AC10", Offset = "0x629810", VA = "0x18062AC10")]
		private IEnumerator _DoPlayBGM(LevelData.WaveData.FragmentData.ActionData data, Action<LevelData.WaveData.FragmentData.ActionData> cb)
		{
			return null;
		}

		// Token: 0x0600EC2D RID: 60461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC2D")]
		[Address(RVA = "0x62AB00", Offset = "0x629700", VA = "0x18062AB00")]
		private IEnumerator _DoParseBattleEvents(LevelData.WaveData.FragmentData.ActionData data, Action<LevelData.WaveData.FragmentData.ActionData> cb)
		{
			return null;
		}

		// Token: 0x0600EC2E RID: 60462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC2E")]
		[Address(RVA = "0x62A9F0", Offset = "0x6295F0", VA = "0x18062A9F0")]
		private IEnumerator _DoDisplayEnemyInfo(LevelData.WaveData.FragmentData.ActionData data, Action<LevelData.WaveData.FragmentData.ActionData> cb)
		{
			return null;
		}

		// Token: 0x0600EC2F RID: 60463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC2F")]
		[Address(RVA = "0x62A7F0", Offset = "0x6293F0", VA = "0x18062A7F0")]
		private IEnumerator _DoActivatePredefined(LevelData.WaveData.FragmentData.ActionData data, Action<LevelData.WaveData.FragmentData.ActionData> cb)
		{
			return null;
		}

		// Token: 0x0600EC30 RID: 60464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC30")]
		[Address(RVA = "0x62B980", Offset = "0x62A580", VA = "0x18062B980")]
		private IEnumerator _DoWithdrawPredefined(LevelData.WaveData.FragmentData.ActionData data, Action<LevelData.WaveData.FragmentData.ActionData> cb)
		{
			return null;
		}

		// Token: 0x0600EC31 RID: 60465 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC31")]
		[Address(RVA = "0x62AFE0", Offset = "0x629BE0", VA = "0x18062AFE0")]
		private IEnumerator _DoShowAllHiddenCards(LevelData.WaveData.FragmentData.ActionData data, Action<LevelData.WaveData.FragmentData.ActionData> cb)
		{
			return null;
		}

		// Token: 0x0600EC32 RID: 60466 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC32")]
		[Address(RVA = "0x62AD10", Offset = "0x629910", VA = "0x18062AD10")]
		private IEnumerator _DoPlayOpera(LevelData.WaveData.FragmentData.ActionData data, Action<LevelData.WaveData.FragmentData.ActionData> cb)
		{
			return null;
		}

		// Token: 0x0600EC33 RID: 60467 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EC33")]
		[Address(RVA = "0x62B780", Offset = "0x62A380", VA = "0x18062B780")]
		private IEnumerator _DoTriggerPredefined(LevelData.WaveData.FragmentData.ActionData data, Action<LevelData.WaveData.FragmentData.ActionData> cb)
		{
			return null;
		}

		// Token: 0x0600EC34 RID: 60468 RVA: 0x000565E0 File Offset: 0x000547E0
		[Token(Token = "0x600EC34")]
		[Address(RVA = "0x629A20", Offset = "0x628620", VA = "0x180629A20")]
		private Scheduler.EnemyItem _CreateEnemyItem(LevelData.EnemyData enemyData)
		{
			return default(Scheduler.EnemyItem);
		}

		// Token: 0x0600EC35 RID: 60469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC35")]
		[Address(RVA = "0x62BBA0", Offset = "0x62A7A0", VA = "0x18062BBA0")]
		private void _OnActionExecuted(LevelData.WaveData.FragmentData.ActionData data)
		{
		}

		// Token: 0x0600EC36 RID: 60470 RVA: 0x000565F8 File Offset: 0x000547F8
		[Token(Token = "0x600EC36")]
		[Address(RVA = "0x629880", Offset = "0x628480", VA = "0x180629880")]
		private bool _CheckWaveNotFinish()
		{
			return default(bool);
		}

		// Token: 0x0600EC37 RID: 60471 RVA: 0x00056610 File Offset: 0x00054810
		[Token(Token = "0x600EC37")]
		[Address(RVA = "0x629750", Offset = "0x628350", VA = "0x180629750")]
		private bool _CheckFinalNotFinish()
		{
			return default(bool);
		}

		// Token: 0x0600EC38 RID: 60472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC38")]
		[Address(RVA = "0x62BD90", Offset = "0x62A990", VA = "0x18062BD90")]
		private void _OnUnitDestroyed(object arg)
		{
		}

		// Token: 0x0600EC39 RID: 60473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC39")]
		[Address(RVA = "0x624DD0", Offset = "0x6239D0", VA = "0x180624DD0")]
		public void MarkEnemyKilled(Enemy enemy, bool markAsNotManaged = false)
		{
		}

		// Token: 0x0600EC3A RID: 60474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC3A")]
		[Address(RVA = "0x62BC40", Offset = "0x62A840", VA = "0x18062BC40")]
		private void _OnEnemyRecycled(object arg)
		{
		}

		// Token: 0x0600EC3B RID: 60475 RVA: 0x00056628 File Offset: 0x00054828
		[Token(Token = "0x600EC3B")]
		[Address(RVA = "0x628670", Offset = "0x627270", VA = "0x180628670")]
		public bool TryActivePredefined(string alias, string hiddenCardKey)
		{
			return default(bool);
		}

		// Token: 0x0600EC3C RID: 60476 RVA: 0x00056640 File Offset: 0x00054840
		[Token(Token = "0x600EC3C")]
		[Address(RVA = "0x623540", Offset = "0x622140", VA = "0x180623540")]
		public bool CheckActionEnabled(LevelData.WaveData.FragmentData.ActionData actionData)
		{
			return default(bool);
		}

		// Token: 0x0600EC3D RID: 60477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC3D")]
		[Address(RVA = "0x62C690", Offset = "0x62B290", VA = "0x18062C690")]
		private void _RegisterActionExecutors()
		{
		}

		// Token: 0x0600EC3E RID: 60478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EC3E")]
		[Address(RVA = "0x62CED0", Offset = "0x62BAD0", VA = "0x18062CED0")]
		public Scheduler()
		{
		}

		// Token: 0x040104B4 RID: 66740
		[Token(Token = "0x40104B4")]
		private const int PREVIEW_CURSOR_COUNT = 2;

		// Token: 0x040104B5 RID: 66741
		[Token(Token = "0x40104B5")]
		private const float PREVIEW_CURSOR_PRE_DELAY = 3f;

		// Token: 0x040104B6 RID: 66742
		[Token(Token = "0x40104B6")]
		private const float PREVIEW_CURSOR_INTERVAL = 0.3f;

		// Token: 0x040104B7 RID: 66743
		[Token(Token = "0x40104B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static Dictionary<string, int> s_dictGameFinishBlocker;

		// Token: 0x040104B8 RID: 66744
		[Token(Token = "0x40104B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private int m_blockCounter;

		// Token: 0x040104B9 RID: 66745
		[Token(Token = "0x40104B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
		private uint m_spawnedEnemiesCnt;

		// Token: 0x040104BA RID: 66746
		[Token(Token = "0x40104BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private int m_spawnedWavesCnt;

		// Token: 0x040104BB RID: 66747
		[Token(Token = "0x40104BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
		private ObscuredInt m_finishedEnemiesCnt;

		// Token: 0x040104BC RID: 66748
		[Token(Token = "0x40104BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private ObscuredInt m_killedEnemiesCnt;

		// Token: 0x040104BD RID: 66749
		[Token(Token = "0x40104BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C")]
		private ObscuredInt m_validFinishedEnemiesCnt;

		// Token: 0x040104BE RID: 66750
		[Token(Token = "0x40104BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private ObscuredInt m_validKilledEnemiesCnt;

		// Token: 0x040104BF RID: 66751
		[Token(Token = "0x40104BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x74")]
		private ObscuredInt m_validMissedEnemiesCnt;

		// Token: 0x040104C0 RID: 66752
		[Token(Token = "0x40104C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private FP m_waveStartTime;

		// Token: 0x040104C1 RID: 66753
		[Token(Token = "0x40104C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private FP m_fragmentStartTime;

		// Token: 0x040104C2 RID: 66754
		[Token(Token = "0x40104C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private LevelData.WaveData[] m_waves;

		// Token: 0x040104C3 RID: 66755
		[Token(Token = "0x40104C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private Dictionary<string, Scheduler.EnemyItem> m_enemyMap;

		// Token: 0x040104C4 RID: 66756
		[Token(Token = "0x40104C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private Func<LevelData.WaveData.FragmentData.ActionData, Action<LevelData.WaveData.FragmentData.ActionData>, IEnumerator>[] m_actionExecutors;

		// Token: 0x040104C5 RID: 66757
		[Token(Token = "0x40104C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private List<Scheduler.ActionItem> m_actionQueue;

		// Token: 0x040104C6 RID: 66758
		[Token(Token = "0x40104C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private List<Enemy> m_managedWaveEnemies;

		// Token: 0x040104C7 RID: 66759
		[Token(Token = "0x40104C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private List<Enemy> m_managedFinalEnemies;

		// Token: 0x040104C8 RID: 66760
		[Token(Token = "0x40104C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private ListDict<string, Scheduler.BranchRuntime> m_brancheMap;

		// Token: 0x040104C9 RID: 66761
		[Token(Token = "0x40104C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private ListSet<string> m_enabledHiddenGroups;

		// Token: 0x040104CA RID: 66762
		[Token(Token = "0x40104CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private ListSet<Enemy> m_cachedEnemies;

		// Token: 0x040104CB RID: 66763
		[Token(Token = "0x40104CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private int m_cachedEnemiesWaveToAdd;

		// Token: 0x040104CC RID: 66764
		[Token(Token = "0x40104CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private Dictionary<int, ListSet<Enemy>> m_waveCachedEnemies;

		// Token: 0x040104CD RID: 66765
		[Token(Token = "0x40104CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool m_inWavePostDelay;

		// Token: 0x040104CE RID: 66766
		[Token(Token = "0x40104CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private CoroutineId m_mainCoroutine;

		// Token: 0x040104CF RID: 66767
		[Token(Token = "0x40104CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private bool m_allowSummonSpawnEnemy;

		// Token: 0x040104D0 RID: 66768
		[Token(Token = "0x40104D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Scheduler.DefaultWaveHandler m_waveHandler;

		// Token: 0x040104D1 RID: 66769
		[Token(Token = "0x40104D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private List<Scheduler.IWavePlugin> m_wavePlugin;

		// Token: 0x040104D4 RID: 66772
		[Token(Token = "0x40104D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_totalEnemiesCnt;

		// Token: 0x040104D5 RID: 66773
		[Token(Token = "0x40104D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_totalEnemiesCnt;

		// Token: 0x040104D6 RID: 66774
		[Token(Token = "0x40104D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_totalWavesCnt;

		// Token: 0x040104D7 RID: 66775
		[Token(Token = "0x40104D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_waves;

		// Token: 0x040104D8 RID: 66776
		[Token(Token = "0x40104D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_remainingEnemiesCnt;

		// Token: 0x040104D9 RID: 66777
		[Token(Token = "0x40104D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_finishedEnemiesCnt;

		// Token: 0x040104DA RID: 66778
		[Token(Token = "0x40104DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_spawnedEnemiesCnt;

		// Token: 0x040104DB RID: 66779
		[Token(Token = "0x40104DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_spawnedWavesCnt;

		// Token: 0x040104DC RID: 66780
		[Token(Token = "0x40104DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_managedWaveEnemies;

		// Token: 0x040104DD RID: 66781
		[Token(Token = "0x40104DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_killedEnemiesCnt;

		// Token: 0x040104DE RID: 66782
		[Token(Token = "0x40104DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_validKilledEnemiesCnt;

		// Token: 0x040104DF RID: 66783
		[Token(Token = "0x40104DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_validFinishedEnemiesCnt;

		// Token: 0x040104E0 RID: 66784
		[Token(Token = "0x40104E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_validMissedEnemiesCnt;

		// Token: 0x040104E1 RID: 66785
		[Token(Token = "0x40104E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_completeProgress;

		// Token: 0x040104E2 RID: 66786
		[Token(Token = "0x40104E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_inWavePostDelay;

		// Token: 0x040104E3 RID: 66787
		[Token(Token = "0x40104E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_managedFinalEnemies;

		// Token: 0x040104E4 RID: 66788
		[Token(Token = "0x40104E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_battleController;

		// Token: 0x040104E5 RID: 66789
		[Token(Token = "0x40104E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_set_battleController;

		// Token: 0x040104E6 RID: 66790
		[Token(Token = "0x40104E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_allowSummonSpawnEnemy;

		// Token: 0x040104E7 RID: 66791
		[Token(Token = "0x40104E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_set_allowSummonSpawnEnemy;

		// Token: 0x040104E8 RID: 66792
		[Token(Token = "0x40104E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x040104E9 RID: 66793
		[Token(Token = "0x40104E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040104EA RID: 66794
		[Token(Token = "0x40104EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_UpdateWaves;

		// Token: 0x040104EB RID: 66795
		[Token(Token = "0x40104EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__NotCountInTotal;

		// Token: 0x040104EC RID: 66796
		[Token(Token = "0x40104EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnGameInit;

		// Token: 0x040104ED RID: 66797
		[Token(Token = "0x40104ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_OnGameReady;

		// Token: 0x040104EE RID: 66798
		[Token(Token = "0x40104EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_OnGameStart;

		// Token: 0x040104EF RID: 66799
		[Token(Token = "0x40104EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_RegisterPlugin;

		// Token: 0x040104F0 RID: 66800
		[Token(Token = "0x40104F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_OnGameReset;

		// Token: 0x040104F1 RID: 66801
		[Token(Token = "0x40104F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_OnGameOver;

		// Token: 0x040104F2 RID: 66802
		[Token(Token = "0x40104F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_CheckBranchIsReadyToMoveNext;

		// Token: 0x040104F3 RID: 66803
		[Token(Token = "0x40104F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_CheckBranchIsNotEmpty;

		// Token: 0x040104F4 RID: 66804
		[Token(Token = "0x40104F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_AddBlockGameKey;

		// Token: 0x040104F5 RID: 66805
		[Token(Token = "0x40104F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_RemoveBlockGameKey;

		// Token: 0x040104F6 RID: 66806
		[Token(Token = "0x40104F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_TryMoveNextBranch;

		// Token: 0x040104F7 RID: 66807
		[Token(Token = "0x40104F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_TryPickRandomBranch;

		// Token: 0x040104F8 RID: 66808
		[Token(Token = "0x40104F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_TryPickRandomBranchNotRepeat;

		// Token: 0x040104F9 RID: 66809
		[Token(Token = "0x40104F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_TryGetEnemyRouteFromBranch;

		// Token: 0x040104FA RID: 66810
		[Token(Token = "0x40104FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix1_TryGetEnemyRouteFromBranch;

		// Token: 0x040104FB RID: 66811
		[Token(Token = "0x40104FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_TryGetBranch;

		// Token: 0x040104FC RID: 66812
		[Token(Token = "0x40104FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_TakeSnapshot;

		// Token: 0x040104FD RID: 66813
		[Token(Token = "0x40104FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_FinishCurrentWave;

		// Token: 0x040104FE RID: 66814
		[Token(Token = "0x40104FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_FinishCurrentWaveDeeply;

		// Token: 0x040104FF RID: 66815
		[Token(Token = "0x40104FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_ReleaseEnemyFromCurrentWave;

		// Token: 0x04010500 RID: 66816
		[Token(Token = "0x4010500")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_TrackEnemyAtNextWave;

		// Token: 0x04010501 RID: 66817
		[Token(Token = "0x4010501")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_TrackEnemyAtSpecificWave;

		// Token: 0x04010502 RID: 66818
		[Token(Token = "0x4010502")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_TrackAllManagedEnemiesAtNextWave;

		// Token: 0x04010503 RID: 66819
		[Token(Token = "0x4010503")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_DoSchedule;

		// Token: 0x04010504 RID: 66820
		[Token(Token = "0x4010504")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0__DoSchedule;

		// Token: 0x04010505 RID: 66821
		[Token(Token = "0x4010505")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_DoFinishGame;

		// Token: 0x04010506 RID: 66822
		[Token(Token = "0x4010506")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_DealWithAfterBattleWaveFromPluginIfValid;

		// Token: 0x04010507 RID: 66823
		[Token(Token = "0x4010507")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0__DealAfterBattleWaveFromPlugin;

		// Token: 0x04010508 RID: 66824
		[Token(Token = "0x4010508")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0__DealWave;

		// Token: 0x04010509 RID: 66825
		[Token(Token = "0x4010509")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0__DealFragment;

		// Token: 0x0401050A RID: 66826
		[Token(Token = "0x401050A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0__DealBranchPhase;

		// Token: 0x0401050B RID: 66827
		[Token(Token = "0x401050B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0__DealAction;

		// Token: 0x0401050C RID: 66828
		[Token(Token = "0x401050C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_TryDealDynamicPhase;

		// Token: 0x0401050D RID: 66829
		[Token(Token = "0x401050D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0__DoSpawn;

		// Token: 0x0401050E RID: 66830
		[Token(Token = "0x401050E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_SpawnSummonedEnemyTrackedInGameMode;

		// Token: 0x0401050F RID: 66831
		[Token(Token = "0x401050F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_SpawnSummonedEnemyTrackedInGameModeWithRuntimeRoute;

		// Token: 0x04010510 RID: 66832
		[Token(Token = "0x4010510")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix1_SpawnSummonedEnemyTrackedInGameMode;

		// Token: 0x04010511 RID: 66833
		[Token(Token = "0x4010511")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_SpawnSummonedEnemyWithRuntimeRoute;

		// Token: 0x04010512 RID: 66834
		[Token(Token = "0x4010512")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_SpawnSummonedEnemyWithBranchRoute;

		// Token: 0x04010513 RID: 66835
		[Token(Token = "0x4010513")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_SpawnEnemyWithRoute;

		// Token: 0x04010514 RID: 66836
		[Token(Token = "0x4010514")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix1_SpawnSummonedEnemyWithRuntimeRoute;

		// Token: 0x04010515 RID: 66837
		[Token(Token = "0x4010515")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_SpawnSummonedEnemyWithFixedDirection;

		// Token: 0x04010516 RID: 66838
		[Token(Token = "0x4010516")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_SpawnEnemyNpc;

		// Token: 0x04010517 RID: 66839
		[Token(Token = "0x4010517")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0__DoSpawnEnemyInternal;

		// Token: 0x04010518 RID: 66840
		[Token(Token = "0x4010518")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix1__DoSpawnEnemyInternal;

		// Token: 0x04010519 RID: 66841
		[Token(Token = "0x4010519")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0__AlertSpawnError;

		// Token: 0x0401051A RID: 66842
		[Token(Token = "0x401051A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_GenerateRuntimeRoute;

		// Token: 0x0401051B RID: 66843
		[Token(Token = "0x401051B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_GenerateRuntimeTraceRoute;

		// Token: 0x0401051C RID: 66844
		[Token(Token = "0x401051C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0__DoPreviewCursor;

		// Token: 0x0401051D RID: 66845
		[Token(Token = "0x401051D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0__DoStory;

		// Token: 0x0401051E RID: 66846
		[Token(Token = "0x401051E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0__DoDialog;

		// Token: 0x0401051F RID: 66847
		[Token(Token = "0x401051F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0__DoTutorial;

		// Token: 0x04010520 RID: 66848
		[Token(Token = "0x4010520")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0__DoPlayBGM;

		// Token: 0x04010521 RID: 66849
		[Token(Token = "0x4010521")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0__DoParseBattleEvents;

		// Token: 0x04010522 RID: 66850
		[Token(Token = "0x4010522")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0__DoDisplayEnemyInfo;

		// Token: 0x04010523 RID: 66851
		[Token(Token = "0x4010523")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0__DoActivatePredefined;

		// Token: 0x04010524 RID: 66852
		[Token(Token = "0x4010524")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0__DoWithdrawPredefined;

		// Token: 0x04010525 RID: 66853
		[Token(Token = "0x4010525")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0__DoShowAllHiddenCards;

		// Token: 0x04010526 RID: 66854
		[Token(Token = "0x4010526")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0__DoPlayOpera;

		// Token: 0x04010527 RID: 66855
		[Token(Token = "0x4010527")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0__DoTriggerPredefined;

		// Token: 0x04010528 RID: 66856
		[Token(Token = "0x4010528")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0__CreateEnemyItem;

		// Token: 0x04010529 RID: 66857
		[Token(Token = "0x4010529")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0__OnActionExecuted;

		// Token: 0x0401052A RID: 66858
		[Token(Token = "0x401052A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0__CheckWaveNotFinish;

		// Token: 0x0401052B RID: 66859
		[Token(Token = "0x401052B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0__CheckFinalNotFinish;

		// Token: 0x0401052C RID: 66860
		[Token(Token = "0x401052C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0__OnUnitDestroyed;

		// Token: 0x0401052D RID: 66861
		[Token(Token = "0x401052D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_MarkEnemyKilled;

		// Token: 0x0401052E RID: 66862
		[Token(Token = "0x401052E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0__OnEnemyRecycled;

		// Token: 0x0401052F RID: 66863
		[Token(Token = "0x401052F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_TryActivePredefined;

		// Token: 0x04010530 RID: 66864
		[Token(Token = "0x4010530")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_CheckActionEnabled;

		// Token: 0x04010531 RID: 66865
		[Token(Token = "0x4010531")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0__RegisterActionExecutors;

		// Token: 0x04010532 RID: 66866
		[Token(Token = "0x4010532")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200240D RID: 9229
		[Token(Token = "0x200240D")]
		public interface IWavePlugin
		{
			// Token: 0x17001E39 RID: 7737
			// (get) Token: 0x0600EC41 RID: 60481
			[Token(Token = "0x17001E39")]
			bool hasWaveBeforeBattle { [Token(Token = "0x600EC41")] get; }

			// Token: 0x17001E3A RID: 7738
			// (get) Token: 0x0600EC42 RID: 60482
			[Token(Token = "0x17001E3A")]
			bool hasWaveAfterBattle { [Token(Token = "0x600EC42")] get; }

			// Token: 0x0600EC43 RID: 60483
			[Token(Token = "0x600EC43")]
			IEnumerator WaveBeforeBattle();

			// Token: 0x0600EC44 RID: 60484
			[Token(Token = "0x600EC44")]
			IEnumerator WaveAfterBattle();
		}

		// Token: 0x0200240E RID: 9230
		[Token(Token = "0x200240E")]
		public struct SchedulerSnapshot
		{
			// Token: 0x04010533 RID: 66867
			[Token(Token = "0x4010533")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public FP waveStartTime;

			// Token: 0x04010534 RID: 66868
			[Token(Token = "0x4010534")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public FP fragmentStartTime;

			// Token: 0x04010535 RID: 66869
			[Token(Token = "0x4010535")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float actionStartTime;
		}

		// Token: 0x0200240F RID: 9231
		[Token(Token = "0x200240F")]
		public struct SpawnSummonedEnemyTrackedInGameModeParams
		{
			// Token: 0x04010536 RID: 66870
			[Token(Token = "0x4010536")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public string enemyKey;

			// Token: 0x04010537 RID: 66871
			[Token(Token = "0x4010537")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public Enemy host;

			// Token: 0x04010538 RID: 66872
			[Token(Token = "0x4010538")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public bool managedByScheduler;

			// Token: 0x04010539 RID: 66873
			[Token(Token = "0x4010539")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			public bool dontBlockWave;

			// Token: 0x0401053A RID: 66874
			[Token(Token = "0x401053A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public Vector2 summonPos;

			// Token: 0x0401053B RID: 66875
			[Token(Token = "0x401053B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public FP randomOffset;

			// Token: 0x0401053C RID: 66876
			[Token(Token = "0x401053C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			public FP delayTime;

			// Token: 0x0401053D RID: 66877
			[Token(Token = "0x401053D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			public bool ignoreOffset;

			// Token: 0x0401053E RID: 66878
			[Token(Token = "0x401053E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x31")]
			public bool unharmful;

			// Token: 0x0401053F RID: 66879
			[Token(Token = "0x401053F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x32")]
			public bool stopSummonIfHostDead;

			// Token: 0x04010540 RID: 66880
			[Token(Token = "0x4010540")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x33")]
			public bool addNoSourceBuffImmediately;

			// Token: 0x04010541 RID: 66881
			[Token(Token = "0x4010541")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			public Blackboard blackboard;

			// Token: 0x04010542 RID: 66882
			[Token(Token = "0x4010542")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			public BuffData noSourceBuff;

			// Token: 0x04010543 RID: 66883
			[Token(Token = "0x4010543")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
			public MotionMask checkMotionMode;

			// Token: 0x04010544 RID: 66884
			[Token(Token = "0x4010544")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
			public Action<Enemy> spawnCallback;

			// Token: 0x04010545 RID: 66885
			[Token(Token = "0x4010545")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
			public bool skipCheckPoints;
		}

		// Token: 0x02002410 RID: 9232
		[Token(Token = "0x2002410")]
		public struct ActionItem
		{
			// Token: 0x04010546 RID: 66886
			[Token(Token = "0x4010546")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LevelData.WaveData.FragmentData.ActionData data;

			// Token: 0x04010547 RID: 66887
			[Token(Token = "0x4010547")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public float timeOffset;
		}

		// Token: 0x02002411 RID: 9233
		[Token(Token = "0x2002411")]
		private struct EnemyItem
		{
			// Token: 0x04010548 RID: 66888
			[Token(Token = "0x4010548")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public LevelData.EnemyData data;

			// Token: 0x04010549 RID: 66889
			[Token(Token = "0x4010549")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			public EnemyHandBookData handbook;

			// Token: 0x0401054A RID: 66890
			[Token(Token = "0x401054A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float delayToBorn;
		}

		// Token: 0x02002412 RID: 9234
		[Token(Token = "0x2002412")]
		private class BranchRuntime
		{
			// Token: 0x17001E3B RID: 7739
			// (get) Token: 0x0600EC45 RID: 60485 RVA: 0x00056670 File Offset: 0x00054870
			[Token(Token = "0x17001E3B")]
			public bool hasNext
			{
				[Token(Token = "0x600EC45")]
				[Address(RVA = "0x61DBE0", Offset = "0x61C7E0", VA = "0x18061DBE0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600EC46 RID: 60486 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EC46")]
			[Address(RVA = "0x61DBA0", Offset = "0x61C7A0", VA = "0x18061DBA0")]
			public BranchRuntime(LevelData.BranchData branchData)
			{
			}

			// Token: 0x0600EC47 RID: 60487 RVA: 0x00056688 File Offset: 0x00054888
			[Token(Token = "0x600EC47")]
			[Address(RVA = "0x61D780", Offset = "0x61C380", VA = "0x18061D780")]
			public bool TryPickNextPhase(out LevelData.BranchData.PhaseData result, bool isLoop)
			{
				return default(bool);
			}

			// Token: 0x0600EC48 RID: 60488 RVA: 0x000566A0 File Offset: 0x000548A0
			[Token(Token = "0x600EC48")]
			[Address(RVA = "0x61DA70", Offset = "0x61C670", VA = "0x18061DA70")]
			public bool TryPickRandomPhase(out LevelData.BranchData.PhaseData result)
			{
				return default(bool);
			}

			// Token: 0x0600EC49 RID: 60489 RVA: 0x000566B8 File Offset: 0x000548B8
			[Token(Token = "0x600EC49")]
			[Address(RVA = "0x61D8A0", Offset = "0x61C4A0", VA = "0x18061D8A0")]
			public bool TryPickRandomPhaseNotRepeat(out LevelData.BranchData.PhaseData result)
			{
				return default(bool);
			}

			// Token: 0x0401054B RID: 66891
			[Token(Token = "0x401054B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public LevelData.BranchData data;

			// Token: 0x0401054C RID: 66892
			[Token(Token = "0x401054C")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public int cursor;

			// Token: 0x0401054D RID: 66893
			[Token(Token = "0x401054D")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			public List<LevelData.BranchData.PhaseData> playList;
		}

		// Token: 0x02002413 RID: 9235
		[Token(Token = "0x2002413")]
		public abstract class SchedulerPreprocessor : IDisposable, IHotfixable
		{
			// Token: 0x0600EC4A RID: 60490
			[Token(Token = "0x600EC4A")]
			public abstract void DoPreprocess(LevelData levelData);

			// Token: 0x0600EC4B RID: 60491
			[Token(Token = "0x600EC4B")]
			public abstract void Dispose();

			// Token: 0x0600EC4C RID: 60492 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EC4C")]
			[Address(RVA = "0x623330", Offset = "0x621F30", VA = "0x180623330")]
			protected SchedulerPreprocessor()
			{
			}

			// Token: 0x0401054E RID: 66894
			[Token(Token = "0x401054E")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002414 RID: 9236
		[Token(Token = "0x2002414")]
		public class DefaultSchedulerPreprocessor : Scheduler.SchedulerPreprocessor
		{
			// Token: 0x0600EC4D RID: 60493 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EC4D")]
			[Address(RVA = "0x620340", Offset = "0x61EF40", VA = "0x180620340", Slot = "5")]
			public override void DoPreprocess(LevelData levelData)
			{
			}

			// Token: 0x0600EC4E RID: 60494 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EC4E")]
			[Address(RVA = "0x6202E0", Offset = "0x61EEE0", VA = "0x1806202E0", Slot = "6")]
			public override void Dispose()
			{
			}

			// Token: 0x0600EC4F RID: 60495 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EC4F")]
			[Address(RVA = "0x621800", Offset = "0x620400", VA = "0x180621800")]
			public DefaultSchedulerPreprocessor()
			{
			}

			// Token: 0x0401054F RID: 66895
			[Token(Token = "0x401054F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_DoPreprocess;

			// Token: 0x04010550 RID: 66896
			[Token(Token = "0x4010550")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Dispose;

			// Token: 0x04010551 RID: 66897
			[Token(Token = "0x4010551")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02002415 RID: 9237
		[Token(Token = "0x2002415")]
		public class DefaultWaveHandler : IHotfixable
		{
			// Token: 0x17001E3C RID: 7740
			// (get) Token: 0x0600EC50 RID: 60496 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001E3C")]
			protected Scheduler scheduler
			{
				[Token(Token = "0x600EC50")]
				[Address(RVA = "0x621CD0", Offset = "0x6208D0", VA = "0x180621CD0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001E3D RID: 7741
			// (get) Token: 0x0600EC51 RID: 60497 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001E3D")]
			protected Func<LevelData.WaveData.FragmentData.ActionData, Action<LevelData.WaveData.FragmentData.ActionData>, IEnumerator>[] actionExecutors
			{
				[Token(Token = "0x600EC51")]
				[Address(RVA = "0x621BF0", Offset = "0x6207F0", VA = "0x180621BF0")]
				get
				{
					return null;
				}
			}

			// Token: 0x0600EC52 RID: 60498 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EC52")]
			[Address(RVA = "0x621950", Offset = "0x620550", VA = "0x180621950")]
			public void OnActionExecuted(LevelData.WaveData.FragmentData.ActionData data)
			{
			}

			// Token: 0x17001E3E RID: 7742
			// (get) Token: 0x0600EC53 RID: 60499 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17001E3E")]
			protected List<Scheduler.ActionItem> actionQueue
			{
				[Token(Token = "0x600EC53")]
				[Address(RVA = "0x621C60", Offset = "0x620860", VA = "0x180621C60")]
				get
				{
					return null;
				}
			}

			// Token: 0x17001E3F RID: 7743
			// (get) Token: 0x0600EC54 RID: 60500 RVA: 0x000566D0 File Offset: 0x000548D0
			[Token(Token = "0x17001E3F")]
			public virtual bool skipCurWave
			{
				[Token(Token = "0x600EC54")]
				[Address(RVA = "0x621D80", Offset = "0x620980", VA = "0x180621D80", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600EC55 RID: 60501 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600EC55")]
			[Address(RVA = "0x621AE0", Offset = "0x6206E0", VA = "0x180621AE0", Slot = "5")]
			public virtual IEnumerator WaitForPredelay(LevelData.WaveData wave)
			{
				return null;
			}

			// Token: 0x0600EC56 RID: 60502 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600EC56")]
			[Address(RVA = "0x621A30", Offset = "0x620630", VA = "0x180621A30", Slot = "6")]
			public virtual IEnumerator WaitForPostDelay(LevelData.WaveData wave)
			{
				return null;
			}

			// Token: 0x0600EC57 RID: 60503 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600EC57")]
			[Address(RVA = "0x6218A0", Offset = "0x6204A0", VA = "0x1806218A0", Slot = "7")]
			public virtual IEnumerator ExecuteActionQueue()
			{
				return null;
			}

			// Token: 0x0600EC58 RID: 60504 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EC58")]
			[Address(RVA = "0x621B90", Offset = "0x620790", VA = "0x180621B90")]
			public DefaultWaveHandler()
			{
			}

			// Token: 0x04010552 RID: 66898
			[Token(Token = "0x4010552")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Scheduler m_scheduler;

			// Token: 0x04010553 RID: 66899
			[Token(Token = "0x4010553")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_scheduler;

			// Token: 0x04010554 RID: 66900
			[Token(Token = "0x4010554")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_actionExecutors;

			// Token: 0x04010555 RID: 66901
			[Token(Token = "0x4010555")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_OnActionExecuted;

			// Token: 0x04010556 RID: 66902
			[Token(Token = "0x4010556")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_get_actionQueue;

			// Token: 0x04010557 RID: 66903
			[Token(Token = "0x4010557")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_get_skipCurWave;

			// Token: 0x04010558 RID: 66904
			[Token(Token = "0x4010558")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_WaitForPredelay;

			// Token: 0x04010559 RID: 66905
			[Token(Token = "0x4010559")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_WaitForPostDelay;

			// Token: 0x0401055A RID: 66906
			[Token(Token = "0x401055A")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_ExecuteActionQueue;

			// Token: 0x0401055B RID: 66907
			[Token(Token = "0x401055B")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
