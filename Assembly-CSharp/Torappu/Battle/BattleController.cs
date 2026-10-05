using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using AdvancedInspector;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using Torappu.Battle.Dialog;
using Torappu.Battle.Effects;
using Torappu.Battle.GameMode;
using Torappu.Battle.LevelScript;
using Torappu.Battle.Runes;
using Torappu.Battle.TPhysic2D;
using Torappu.CharWord;
using Torappu.Multiplayer;
using Torappu.ObjectPool;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200217D RID: 8573
	[Token(Token = "0x200217D")]
	public class BattleController : SingletonMonoBehaviour<BattleController>, ILuaCallCSharp, IHotfixable, ISingletonMonoHost
	{
		// Token: 0x1700195F RID: 6495
		// (get) Token: 0x0600D30E RID: 54030 RVA: 0x0004C0C8 File Offset: 0x0004A2C8
		// (set) Token: 0x0600D30F RID: 54031 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700195F")]
		public static bool isDeterministic
		{
			[Token(Token = "0x600D30E")]
			[Address(RVA = "0x35627B0", Offset = "0x35613B0", VA = "0x1835627B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D30F")]
			[Address(RVA = "0x3564C40", Offset = "0x3563840", VA = "0x183564C40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001960 RID: 6496
		// (get) Token: 0x0600D310 RID: 54032 RVA: 0x0004C0E0 File Offset: 0x0004A2E0
		[Token(Token = "0x17001960")]
		public bool isOnline
		{
			[Token(Token = "0x600D310")]
			[Address(RVA = "0x3562DA0", Offset = "0x35619A0", VA = "0x183562DA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001961 RID: 6497
		// (get) Token: 0x0600D311 RID: 54033 RVA: 0x0004C0F8 File Offset: 0x0004A2F8
		[Token(Token = "0x17001961")]
		public bool isMultiActivePlayers
		{
			[Token(Token = "0x600D311")]
			[Address(RVA = "0x3562D00", Offset = "0x3561900", VA = "0x183562D00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001962 RID: 6498
		// (get) Token: 0x0600D312 RID: 54034 RVA: 0x0004C110 File Offset: 0x0004A310
		// (set) Token: 0x0600D313 RID: 54035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001962")]
		public PlayerSide playerSide
		{
			[Token(Token = "0x600D312")]
			[Address(RVA = "0x3563B40", Offset = "0x3562740", VA = "0x183563B40")]
			[CompilerGenerated]
			get
			{
				return PlayerSide.DEFAULT;
			}
			[Token(Token = "0x600D313")]
			[Address(RVA = "0x3564E50", Offset = "0x3563A50", VA = "0x183564E50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001963 RID: 6499
		// (get) Token: 0x0600D314 RID: 54036 RVA: 0x0004C128 File Offset: 0x0004A328
		[Token(Token = "0x17001963")]
		public PlayerSide playerSideNext
		{
			[Token(Token = "0x600D314")]
			[Address(RVA = "0x3563A10", Offset = "0x3562610", VA = "0x183563A10")]
			get
			{
				return PlayerSide.DEFAULT;
			}
		}

		// Token: 0x17001964 RID: 6500
		// (get) Token: 0x0600D315 RID: 54037 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001964")]
		public List<PlayerSide> sortedActivePlayers
		{
			[Token(Token = "0x600D315")]
			[Address(RVA = "0x3564190", Offset = "0x3562D90", VA = "0x183564190")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001965 RID: 6501
		// (get) Token: 0x0600D316 RID: 54038 RVA: 0x0004C140 File Offset: 0x0004A340
		[Token(Token = "0x17001965")]
		public MapLayer playerLayer
		{
			[Token(Token = "0x600D316")]
			[Address(RVA = "0x3563950", Offset = "0x3562550", VA = "0x183563950")]
			get
			{
				return MapLayer.LAYER_A;
			}
		}

		// Token: 0x17001966 RID: 6502
		// (get) Token: 0x0600D317 RID: 54039 RVA: 0x0004C158 File Offset: 0x0004A358
		[Token(Token = "0x17001966")]
		public bool isAtOwnLayer
		{
			[Token(Token = "0x600D317")]
			[Address(RVA = "0x3562400", Offset = "0x3561000", VA = "0x183562400")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001967 RID: 6503
		// (get) Token: 0x0600D318 RID: 54040 RVA: 0x0004C170 File Offset: 0x0004A370
		[Token(Token = "0x17001967")]
		private MapLayer currentLayer
		{
			[Token(Token = "0x600D318")]
			[Address(RVA = "0x3561520", Offset = "0x3560120", VA = "0x183561520")]
			get
			{
				return MapLayer.LAYER_A;
			}
		}

		// Token: 0x17001968 RID: 6504
		// (get) Token: 0x0600D319 RID: 54041 RVA: 0x0004C188 File Offset: 0x0004A388
		[Token(Token = "0x17001968")]
		public bool isLegionMode
		{
			[Token(Token = "0x600D319")]
			[Address(RVA = "0x3562C50", Offset = "0x3561850", VA = "0x183562C50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001969 RID: 6505
		// (get) Token: 0x0600D31A RID: 54042 RVA: 0x0004C1A0 File Offset: 0x0004A3A0
		[Token(Token = "0x17001969")]
		public bool isSandBox
		{
			[Token(Token = "0x600D31A")]
			[Address(RVA = "0x3563130", Offset = "0x3561D30", VA = "0x183563130")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700196A RID: 6506
		// (get) Token: 0x0600D31B RID: 54043 RVA: 0x0004C1B8 File Offset: 0x0004A3B8
		[Token(Token = "0x1700196A")]
		public bool isFunLivePlayMode
		{
			[Token(Token = "0x600D31B")]
			[Address(RVA = "0x3562AF0", Offset = "0x35616F0", VA = "0x183562AF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700196B RID: 6507
		// (get) Token: 0x0600D31C RID: 54044 RVA: 0x0004C1D0 File Offset: 0x0004A3D0
		[Token(Token = "0x1700196B")]
		public bool isStrifeMode
		{
			[Token(Token = "0x600D31C")]
			[Address(RVA = "0x3563260", Offset = "0x3561E60", VA = "0x183563260")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700196C RID: 6508
		// (get) Token: 0x0600D31D RID: 54045 RVA: 0x0004C1E8 File Offset: 0x0004A3E8
		[Token(Token = "0x1700196C")]
		public bool isRacingMode
		{
			[Token(Token = "0x600D31D")]
			[Address(RVA = "0x3563080", Offset = "0x3561C80", VA = "0x183563080")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700196D RID: 6509
		// (get) Token: 0x0600D31E RID: 54046 RVA: 0x0004C200 File Offset: 0x0004A400
		[Token(Token = "0x1700196D")]
		public bool isDouququMode
		{
			[Token(Token = "0x600D31E")]
			[Address(RVA = "0x3562910", Offset = "0x3561510", VA = "0x183562910")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700196E RID: 6510
		// (get) Token: 0x0600D31F RID: 54047 RVA: 0x0004C218 File Offset: 0x0004A418
		[Token(Token = "0x1700196E")]
		public bool isEnemyDuel
		{
			[Token(Token = "0x600D31F")]
			[Address(RVA = "0x35629C0", Offset = "0x35615C0", VA = "0x1835629C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700196F RID: 6511
		// (get) Token: 0x0600D320 RID: 54048 RVA: 0x0004C230 File Offset: 0x0004A430
		[Token(Token = "0x1700196F")]
		public bool isCooperateMode
		{
			[Token(Token = "0x600D320")]
			[Address(RVA = "0x3562680", Offset = "0x3561280", VA = "0x183562680")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001970 RID: 6512
		// (get) Token: 0x0600D321 RID: 54049 RVA: 0x0004C248 File Offset: 0x0004A448
		[Token(Token = "0x17001970")]
		public bool isAutoChessMode
		{
			[Token(Token = "0x600D321")]
			[Address(RVA = "0x3562550", Offset = "0x3561150", VA = "0x183562550")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001971 RID: 6513
		// (get) Token: 0x0600D322 RID: 54050 RVA: 0x0004C260 File Offset: 0x0004A460
		[Token(Token = "0x17001971")]
		public bool isPvpOrSeperateMode
		{
			[Token(Token = "0x600D322")]
			[Address(RVA = "0x3563010", Offset = "0x3561C10", VA = "0x183563010")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001972 RID: 6514
		// (get) Token: 0x0600D323 RID: 54051 RVA: 0x0004C278 File Offset: 0x0004A478
		[Token(Token = "0x17001972")]
		public bool isGameCityMode
		{
			[Token(Token = "0x600D323")]
			[Address(RVA = "0x3562BA0", Offset = "0x35617A0", VA = "0x183562BA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001973 RID: 6515
		// (get) Token: 0x0600D324 RID: 54052 RVA: 0x0004C290 File Offset: 0x0004A490
		[Token(Token = "0x17001973")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		public static uint fixedFrameCnt
		{
			[Token(Token = "0x600D324")]
			[Address(RVA = "0x3561E10", Offset = "0x3560A10", VA = "0x183561E10")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17001974 RID: 6516
		// (get) Token: 0x0600D325 RID: 54053 RVA: 0x0004C2A8 File Offset: 0x0004A4A8
		[Token(Token = "0x17001974")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		public static FP fixedPlayTime
		{
			[Token(Token = "0x600D325")]
			[Address(RVA = "0x3561EA0", Offset = "0x3560AA0", VA = "0x183561EA0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001975 RID: 6517
		// (get) Token: 0x0600D326 RID: 54054 RVA: 0x0004C2C0 File Offset: 0x0004A4C0
		[Token(Token = "0x17001975")]
		public static FP userFixedPlayTime
		{
			[Token(Token = "0x600D326")]
			[Address(RVA = "0x35645B0", Offset = "0x35631B0", VA = "0x1835645B0")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x17001976 RID: 6518
		// (get) Token: 0x0600D327 RID: 54055 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001976")]
		public static System.Random randomImp
		{
			[Token(Token = "0x600D327")]
			[Address(RVA = "0x3563BB0", Offset = "0x35627B0", VA = "0x183563BB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001977 RID: 6519
		// (get) Token: 0x0600D328 RID: 54056 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001977")]
		public static System.Random randomTrivial
		{
			[Token(Token = "0x600D328")]
			[Address(RVA = "0x3563CE0", Offset = "0x35628E0", VA = "0x183563CE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600D329 RID: 54057 RVA: 0x0004C2D8 File Offset: 0x0004A4D8
		[Token(Token = "0x600D329")]
		[Address(RVA = "0x35477E0", Offset = "0x35463E0", VA = "0x1835477E0")]
		public static uint GenNextUniqueId()
		{
			return 0U;
		}

		// Token: 0x0600D32A RID: 54058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D32A")]
		[Address(RVA = "0x353F000", Offset = "0x353DC00", VA = "0x18353F000")]
		public static ReusableList<Entity> AllocateEntityList_DISPOSE()
		{
			return null;
		}

		// Token: 0x0600D32B RID: 54059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D32B")]
		[Address(RVA = "0x353F100", Offset = "0x353DD00", VA = "0x18353F100")]
		public static ReusableList<Projectile> AllocateProjectileList_DISPOSE()
		{
			return null;
		}

		// Token: 0x17001978 RID: 6520
		// (get) Token: 0x0600D32C RID: 54060 RVA: 0x0004C2F0 File Offset: 0x0004A4F0
		[Token(Token = "0x17001978")]
		public bool enemyBossCountDownActivated
		{
			[Token(Token = "0x600D32C")]
			[Address(RVA = "0x3561BD0", Offset = "0x35607D0", VA = "0x183561BD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001979 RID: 6521
		// (get) Token: 0x0600D32D RID: 54061 RVA: 0x0004C308 File Offset: 0x0004A508
		// (set) Token: 0x0600D32E RID: 54062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001979")]
		public float enemyBossCountDown
		{
			[Token(Token = "0x600D32D")]
			[Address(RVA = "0x3561C90", Offset = "0x3560890", VA = "0x183561C90")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600D32E")]
			[Address(RVA = "0x35649E0", Offset = "0x35635E0", VA = "0x1835649E0")]
			set
			{
			}
		}

		// Token: 0x1700197A RID: 6522
		// (get) Token: 0x0600D32F RID: 54063 RVA: 0x0004C320 File Offset: 0x0004A520
		// (set) Token: 0x0600D330 RID: 54064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700197A")]
		public float enemyBossConntDownTurnRedFloor
		{
			[Token(Token = "0x600D32F")]
			[Address(RVA = "0x3561B50", Offset = "0x3560750", VA = "0x183561B50")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600D330")]
			[Address(RVA = "0x3564950", Offset = "0x3563550", VA = "0x183564950")]
			set
			{
			}
		}

		// Token: 0x1700197B RID: 6523
		// (get) Token: 0x0600D331 RID: 54065 RVA: 0x0004C338 File Offset: 0x0004A538
		// (set) Token: 0x0600D332 RID: 54066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700197B")]
		public float enemyBossConntDownTurnRedFloorVal
		{
			[Token(Token = "0x600D331")]
			[Address(RVA = "0x3561AD0", Offset = "0x35606D0", VA = "0x183561AD0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600D332")]
			[Address(RVA = "0x35648C0", Offset = "0x35634C0", VA = "0x1835648C0")]
			set
			{
			}
		}

		// Token: 0x1700197C RID: 6524
		// (get) Token: 0x0600D333 RID: 54067 RVA: 0x0004C350 File Offset: 0x0004A550
		[Token(Token = "0x1700197C")]
		public int randomSeed
		{
			[Token(Token = "0x600D333")]
			[Address(RVA = "0x3563C40", Offset = "0x3562840", VA = "0x183563C40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700197D RID: 6525
		// (get) Token: 0x0600D334 RID: 54068 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700197D")]
		private BattleTweenMgr battleTweenMgr
		{
			[Token(Token = "0x600D334")]
			[Address(RVA = "0x3560E80", Offset = "0x355FA80", VA = "0x183560E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700197E RID: 6526
		// (get) Token: 0x0600D335 RID: 54069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700197E")]
		public BattleAttackRangeController attackRangeController
		{
			[Token(Token = "0x600D335")]
			[Address(RVA = "0x3560CC0", Offset = "0x355F8C0", VA = "0x183560CC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700197F RID: 6527
		// (get) Token: 0x0600D336 RID: 54070 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700197F")]
		public BattleBGMManager bgmManager
		{
			[Token(Token = "0x600D336")]
			[Address(RVA = "0x3560F50", Offset = "0x355FB50", VA = "0x183560F50")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001980 RID: 6528
		// (get) Token: 0x0600D337 RID: 54071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001980")]
		public Map map
		{
			[Token(Token = "0x600D337")]
			[Address(RVA = "0x3563610", Offset = "0x3562210", VA = "0x183563610")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001981 RID: 6529
		// (get) Token: 0x0600D338 RID: 54072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001981")]
		public MapData mapData
		{
			[Token(Token = "0x600D338")]
			[Address(RVA = "0x3563590", Offset = "0x3562190", VA = "0x183563590")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001982 RID: 6530
		// (get) Token: 0x0600D339 RID: 54073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001982")]
		public LevelData levelData
		{
			[Token(Token = "0x600D339")]
			[Address(RVA = "0x3563310", Offset = "0x3561F10", VA = "0x183563310")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001983 RID: 6531
		// (get) Token: 0x0600D33A RID: 54074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001983")]
		public List<BattlePlayerData> playerDataList
		{
			[Token(Token = "0x600D33A")]
			[Address(RVA = "0x35638D0", Offset = "0x35624D0", VA = "0x1835638D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001984 RID: 6532
		// (get) Token: 0x0600D33B RID: 54075 RVA: 0x0004C368 File Offset: 0x0004A568
		[Token(Token = "0x17001984")]
		public bool shouldQueueOps
		{
			[Token(Token = "0x600D33B")]
			[Address(RVA = "0x3564100", Offset = "0x3562D00", VA = "0x183564100")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001985 RID: 6533
		// (get) Token: 0x0600D33C RID: 54076 RVA: 0x0004C380 File Offset: 0x0004A580
		// (set) Token: 0x0600D33D RID: 54077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001985")]
		public bool buildableHighLightUpdaterDirty
		{
			[Token(Token = "0x600D33C")]
			[Address(RVA = "0x3561050", Offset = "0x355FC50", VA = "0x183561050")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D33D")]
			[Address(RVA = "0x3564680", Offset = "0x3563280", VA = "0x183564680")]
			set
			{
			}
		}

		// Token: 0x0600D33E RID: 54078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D33E")]
		[Address(RVA = "0x3547ED0", Offset = "0x3546AD0", VA = "0x183547ED0")]
		public Deck GetDeck(PlayerSide side)
		{
			return null;
		}

		// Token: 0x0600D33F RID: 54079 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D33F")]
		[Address(RVA = "0x3547DE0", Offset = "0x35469E0", VA = "0x183547DE0")]
		public Deck GetDeck(Entity entity)
		{
			return null;
		}

		// Token: 0x0600D340 RID: 54080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D340")]
		[Address(RVA = "0x3547420", Offset = "0x3546020", VA = "0x183547420")]
		public void ForeachActiveDecks(Action<Deck> action)
		{
		}

		// Token: 0x0600D341 RID: 54081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D341")]
		[Address(RVA = "0x35475A0", Offset = "0x35461A0", VA = "0x1835475A0")]
		public void ForeachCard(PlayerSide selectSide, Action<Deck.Card[]> action)
		{
		}

		// Token: 0x17001986 RID: 6534
		// (get) Token: 0x0600D342 RID: 54082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001986")]
		public Scheduler scheduler
		{
			[Token(Token = "0x600D342")]
			[Address(RVA = "0x3564080", Offset = "0x3562C80", VA = "0x183564080")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001987 RID: 6535
		// (get) Token: 0x0600D343 RID: 54083 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D344 RID: 54084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001987")]
		public GridRangeDrawer gridRangeDrawer
		{
			[Token(Token = "0x600D343")]
			[Address(RVA = "0x3562170", Offset = "0x3560D70", VA = "0x183562170")]
			get
			{
				return null;
			}
			[Token(Token = "0x600D344")]
			[Address(RVA = "0x3564A70", Offset = "0x3563670", VA = "0x183564A70")]
			set
			{
			}
		}

		// Token: 0x17001988 RID: 6536
		// (get) Token: 0x0600D345 RID: 54085 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D346 RID: 54086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001988")]
		public UnitManager unitManager
		{
			[Token(Token = "0x600D345")]
			[Address(RVA = "0x3564530", Offset = "0x3563130", VA = "0x183564530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600D346")]
			[Address(RVA = "0x3565560", Offset = "0x3564160", VA = "0x183565560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001989 RID: 6537
		// (get) Token: 0x0600D347 RID: 54087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001989")]
		public EventPool<BattleEvent> eventPool
		{
			[Token(Token = "0x600D347")]
			[Address(RVA = "0x3561D10", Offset = "0x3560910", VA = "0x183561D10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700198A RID: 6538
		// (get) Token: 0x0600D348 RID: 54088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700198A")]
		public Context context
		{
			[Token(Token = "0x600D348")]
			[Address(RVA = "0x35612B0", Offset = "0x355FEB0", VA = "0x1835612B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700198B RID: 6539
		// (get) Token: 0x0600D349 RID: 54089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700198B")]
		public BattleFactory factory
		{
			[Token(Token = "0x600D349")]
			[Address(RVA = "0x3561D90", Offset = "0x3560990", VA = "0x183561D90")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700198C RID: 6540
		// (get) Token: 0x0600D34A RID: 54090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700198C")]
		public BattleLogger logger
		{
			[Token(Token = "0x600D34A")]
			[Address(RVA = "0x3563510", Offset = "0x3562110", VA = "0x183563510")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700198D RID: 6541
		// (get) Token: 0x0600D34B RID: 54091 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700198D")]
		public Transform dragPlane
		{
			[Token(Token = "0x600D34B")]
			[Address(RVA = "0x35619B0", Offset = "0x35605B0", VA = "0x1835619B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700198E RID: 6542
		// (get) Token: 0x0600D34C RID: 54092 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700198E")]
		public RuneManager runeManager
		{
			[Token(Token = "0x600D34C")]
			[Address(RVA = "0x3563F00", Offset = "0x3562B00", VA = "0x183563F00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700198F RID: 6543
		// (get) Token: 0x0600D34D RID: 54093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700198F")]
		public ObjectPool<Buff> buffPool
		{
			[Token(Token = "0x600D34D")]
			[Address(RVA = "0x3560FD0", Offset = "0x355FBD0", VA = "0x183560FD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001990 RID: 6544
		// (get) Token: 0x0600D34E RID: 54094 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001990")]
		public ObjectPool<Deck.Card.DeckBuffWrapper> deckBuffPool
		{
			[Token(Token = "0x600D34E")]
			[Address(RVA = "0x35615F0", Offset = "0x35601F0", VA = "0x1835615F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001991 RID: 6545
		// (get) Token: 0x0600D34F RID: 54095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001991")]
		public ObjectPool<CachePointData> cachePointPool
		{
			[Token(Token = "0x600D34F")]
			[Address(RVA = "0x35610E0", Offset = "0x355FCE0", VA = "0x1835610E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001992 RID: 6546
		// (get) Token: 0x0600D350 RID: 54096 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001992")]
		public BattleController.ReplayController replayController
		{
			[Token(Token = "0x600D350")]
			[Address(RVA = "0x3563E80", Offset = "0x3562A80", VA = "0x183563E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001993 RID: 6547
		// (get) Token: 0x0600D351 RID: 54097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001993")]
		public IGameMode gameMode
		{
			[Token(Token = "0x600D351")]
			[Address(RVA = "0x3561FF0", Offset = "0x3560BF0", VA = "0x183561FF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001994 RID: 6548
		// (get) Token: 0x0600D352 RID: 54098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001994")]
		public GameModeFactory.SandboxGameMode sandboxGameMode
		{
			[Token(Token = "0x600D352")]
			[Address(RVA = "0x3563F80", Offset = "0x3562B80", VA = "0x183563F80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001995 RID: 6549
		// (get) Token: 0x0600D353 RID: 54099 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001995")]
		public GameModeFactory.CooperateGameMode cooperateGameMode
		{
			[Token(Token = "0x600D353")]
			[Address(RVA = "0x3561330", Offset = "0x355FF30", VA = "0x183561330")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001996 RID: 6550
		// (get) Token: 0x0600D354 RID: 54100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001996")]
		public ClientAntiCheatChecker antiCheatChecker
		{
			[Token(Token = "0x600D354")]
			[Address(RVA = "0x3560C40", Offset = "0x355F840", VA = "0x183560C40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001997 RID: 6551
		// (get) Token: 0x0600D355 RID: 54101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001997")]
		public OperaController operaController
		{
			[Token(Token = "0x600D355")]
			[Address(RVA = "0x35637D0", Offset = "0x35623D0", VA = "0x1835637D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001998 RID: 6552
		// (get) Token: 0x0600D356 RID: 54102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001998")]
		public SpineShaderManager spineShaderManager
		{
			[Token(Token = "0x600D356")]
			[Address(RVA = "0x3564320", Offset = "0x3562F20", VA = "0x183564320")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001999 RID: 6553
		// (get) Token: 0x0600D357 RID: 54103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001999")]
		public BattleSpineOutlineManager spineOutlineManager
		{
			[Token(Token = "0x600D357")]
			[Address(RVA = "0x35642A0", Offset = "0x3562EA0", VA = "0x1835642A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700199A RID: 6554
		// (get) Token: 0x0600D358 RID: 54104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700199A")]
		public LevelScriptManager levelScriptManager
		{
			[Token(Token = "0x600D358")]
			[Address(RVA = "0x3563490", Offset = "0x3562090", VA = "0x183563490")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700199B RID: 6555
		// (get) Token: 0x0600D359 RID: 54105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700199B")]
		public TPhysicManager physicManager
		{
			[Token(Token = "0x600D359")]
			[Address(RVA = "0x3563850", Offset = "0x3562450", VA = "0x183563850")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700199C RID: 6556
		// (get) Token: 0x0600D35A RID: 54106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700199C")]
		public ActionExecutorManager actionExecutorManager
		{
			[Token(Token = "0x600D35A")]
			[Address(RVA = "0x3560A60", Offset = "0x355F660", VA = "0x183560A60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700199D RID: 6557
		// (get) Token: 0x0600D35B RID: 54107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700199D")]
		public LevelScriptEventManager levelScriptEventManager
		{
			[Token(Token = "0x600D35B")]
			[Address(RVA = "0x3563410", Offset = "0x3562010", VA = "0x183563410")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700199E RID: 6558
		// (get) Token: 0x0600D35C RID: 54108 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700199E")]
		public DialogController dialogController
		{
			[Token(Token = "0x600D35C")]
			[Address(RVA = "0x35617B0", Offset = "0x35603B0", VA = "0x1835617B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700199F RID: 6559
		// (get) Token: 0x0600D35D RID: 54109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700199F")]
		public ObjectManager objectManager
		{
			[Token(Token = "0x600D35D")]
			[Address(RVA = "0x3563750", Offset = "0x3562350", VA = "0x183563750")]
			get
			{
				return null;
			}
		}

		// Token: 0x170019A0 RID: 6560
		// (get) Token: 0x0600D35E RID: 54110 RVA: 0x0004C398 File Offset: 0x0004A598
		[Token(Token = "0x170019A0")]
		public bool isPlaying
		{
			[Token(Token = "0x600D35E")]
			[Address(RVA = "0x3562F90", Offset = "0x3561B90", VA = "0x183562F90")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170019A1 RID: 6561
		// (get) Token: 0x0600D35F RID: 54111 RVA: 0x0004C3B0 File Offset: 0x0004A5B0
		[Token(Token = "0x170019A1")]
		public bool isFinished
		{
			[Token(Token = "0x600D35F")]
			[Address(RVA = "0x3562A70", Offset = "0x3561670", VA = "0x183562A70")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170019A2 RID: 6562
		// (get) Token: 0x0600D360 RID: 54112 RVA: 0x0004C3C8 File Offset: 0x0004A5C8
		[Token(Token = "0x170019A2")]
		public bool isPausedOrNotPlaying
		{
			[Token(Token = "0x600D360")]
			[Address(RVA = "0x3562E60", Offset = "0x3561A60", VA = "0x183562E60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170019A3 RID: 6563
		// (get) Token: 0x0600D361 RID: 54113 RVA: 0x0004C3E0 File Offset: 0x0004A5E0
		// (set) Token: 0x0600D362 RID: 54114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019A3")]
		public bool isAutoReplayOn
		{
			[Token(Token = "0x600D361")]
			[Address(RVA = "0x3562600", Offset = "0x3561200", VA = "0x183562600")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D362")]
			[Address(RVA = "0x3564BB0", Offset = "0x35637B0", VA = "0x183564BB0")]
			private set
			{
			}
		}

		// Token: 0x170019A4 RID: 6564
		// (get) Token: 0x0600D363 RID: 54115 RVA: 0x0004C3F8 File Offset: 0x0004A5F8
		[Token(Token = "0x170019A4")]
		public bool isDisableSlowMotion
		{
			[Token(Token = "0x600D363")]
			[Address(RVA = "0x3562830", Offset = "0x3561430", VA = "0x183562830")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170019A5 RID: 6565
		// (get) Token: 0x0600D364 RID: 54116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170019A5")]
		[Inspect(Level = 2)]
		[ReadOnly]
		public BattleGlobalBlackboard globalBlackboard
		{
			[Token(Token = "0x600D364")]
			[Address(RVA = "0x35620F0", Offset = "0x3560CF0", VA = "0x1835620F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170019A6 RID: 6566
		// (get) Token: 0x0600D365 RID: 54117 RVA: 0x0004C410 File Offset: 0x0004A610
		// (set) Token: 0x0600D366 RID: 54118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019A6")]
		public bool disableDragCard
		{
			[Token(Token = "0x600D365")]
			[Address(RVA = "0x35618B0", Offset = "0x35604B0", VA = "0x1835618B0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D366")]
			[Address(RVA = "0x35647A0", Offset = "0x35633A0", VA = "0x1835647A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170019A7 RID: 6567
		// (get) Token: 0x0600D367 RID: 54119 RVA: 0x0004C428 File Offset: 0x0004A628
		// (set) Token: 0x0600D368 RID: 54120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019A7")]
		public bool disableDragCardForced
		{
			[Token(Token = "0x600D367")]
			[Address(RVA = "0x3561830", Offset = "0x3560430", VA = "0x183561830")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D368")]
			[Address(RVA = "0x3564710", Offset = "0x3563310", VA = "0x183564710")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170019A8 RID: 6568
		// (get) Token: 0x0600D369 RID: 54121 RVA: 0x0004C440 File Offset: 0x0004A640
		// (set) Token: 0x0600D36A RID: 54122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019A8")]
		public bool disableToggleCard
		{
			[Token(Token = "0x600D369")]
			[Address(RVA = "0x3561930", Offset = "0x3560530", VA = "0x183561930")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D36A")]
			[Address(RVA = "0x3564830", Offset = "0x3563430", VA = "0x183564830")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170019A9 RID: 6569
		// (get) Token: 0x0600D36B RID: 54123 RVA: 0x0004C458 File Offset: 0x0004A658
		[Token(Token = "0x170019A9")]
		public bool isCostLocked
		{
			[Token(Token = "0x600D36B")]
			[Address(RVA = "0x3562730", Offset = "0x3561330", VA = "0x183562730")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170019AA RID: 6570
		// (get) Token: 0x0600D36C RID: 54124 RVA: 0x0004C470 File Offset: 0x0004A670
		// (set) Token: 0x0600D36D RID: 54125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019AA")]
		public bool isSelectCardMode
		{
			[Token(Token = "0x600D36C")]
			[Address(RVA = "0x35631E0", Offset = "0x3561DE0", VA = "0x1835631E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D36D")]
			[Address(RVA = "0x3564CD0", Offset = "0x35638D0", VA = "0x183564CD0")]
			set
			{
			}
		}

		// Token: 0x170019AB RID: 6571
		// (get) Token: 0x0600D36E RID: 54126 RVA: 0x0004C488 File Offset: 0x0004A688
		[Token(Token = "0x170019AB")]
		public bool isAdditionalFrame
		{
			[Token(Token = "0x600D36E")]
			[Address(RVA = "0x3562380", Offset = "0x3560F80", VA = "0x183562380")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600D36F RID: 54127 RVA: 0x0004C4A0 File Offset: 0x0004A6A0
		[Token(Token = "0x600D36F")]
		[Address(RVA = "0x3548550", Offset = "0x3547150", VA = "0x183548550")]
		public int GetNumCharacterLimit(PlayerSide side = PlayerSide.DEFAULT)
		{
			return 0;
		}

		// Token: 0x0600D370 RID: 54128 RVA: 0x0004C4B8 File Offset: 0x0004A6B8
		[Token(Token = "0x600D370")]
		[Address(RVA = "0x355E840", Offset = "0x355D440", VA = "0x18355E840")]
		private int _SetNumCharacterLimit(int value, PlayerSide side = PlayerSide.DEFAULT)
		{
			return 0;
		}

		// Token: 0x170019AC RID: 6572
		// (get) Token: 0x0600D371 RID: 54129 RVA: 0x0004C4D0 File Offset: 0x0004A6D0
		[Token(Token = "0x170019AC")]
		public bool haveGameLoaded
		{
			[Token(Token = "0x600D371")]
			[Address(RVA = "0x35621F0", Offset = "0x3560DF0", VA = "0x1835621F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600D372 RID: 54130 RVA: 0x0004C4E8 File Offset: 0x0004A6E8
		[Token(Token = "0x600D372")]
		[Address(RVA = "0x3548980", Offset = "0x3547580", VA = "0x183548980")]
		public int GetRemainingAvailableCharacterCnt(PlayerSide playerSide = PlayerSide.DEFAULT)
		{
			return 0;
		}

		// Token: 0x170019AD RID: 6573
		// (get) Token: 0x0600D373 RID: 54131 RVA: 0x0004C500 File Offset: 0x0004A700
		// (set) Token: 0x0600D374 RID: 54132 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019AD")]
		public BattleController.State state
		{
			[Token(Token = "0x600D373")]
			[Address(RVA = "0x35643A0", Offset = "0x3562FA0", VA = "0x1835643A0")]
			get
			{
				return BattleController.State.NONE;
			}
			[Token(Token = "0x600D374")]
			[Address(RVA = "0x3565330", Offset = "0x3563F30", VA = "0x183565330")]
			private set
			{
			}
		}

		// Token: 0x170019AE RID: 6574
		// (get) Token: 0x0600D375 RID: 54133 RVA: 0x0004C518 File Offset: 0x0004A718
		[Token(Token = "0x170019AE")]
		public float realPlayTime
		{
			[Token(Token = "0x600D375")]
			[Address(RVA = "0x3563D70", Offset = "0x3562970", VA = "0x183563D70")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170019AF RID: 6575
		// (get) Token: 0x0600D376 RID: 54134 RVA: 0x0004C530 File Offset: 0x0004A730
		[Token(Token = "0x170019AF")]
		public FP timeDeltaNoEnemy
		{
			[Token(Token = "0x600D376")]
			[Address(RVA = "0x3564420", Offset = "0x3563020", VA = "0x183564420")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170019B0 RID: 6576
		// (get) Token: 0x0600D377 RID: 54135 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600D378 RID: 54136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019B0")]
		public string levelId
		{
			[Token(Token = "0x600D377")]
			[Address(RVA = "0x3563390", Offset = "0x3561F90", VA = "0x183563390")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600D378")]
			[Address(RVA = "0x3564DB0", Offset = "0x35639B0", VA = "0x183564DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170019B1 RID: 6577
		// (get) Token: 0x0600D379 RID: 54137 RVA: 0x0004C548 File Offset: 0x0004A748
		// (set) Token: 0x0600D37A RID: 54138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019B1")]
		public bool isActive
		{
			[Token(Token = "0x600D379")]
			[Address(RVA = "0x35622F0", Offset = "0x3560EF0", VA = "0x1835622F0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600D37A")]
			[Address(RVA = "0x3564B00", Offset = "0x3563700", VA = "0x183564B00")]
			set
			{
			}
		}

		// Token: 0x170019B2 RID: 6578
		// (get) Token: 0x0600D37B RID: 54139 RVA: 0x0004C560 File Offset: 0x0004A760
		[Token(Token = "0x170019B2")]
		public bool isPaused
		{
			[Token(Token = "0x600D37B")]
			[Address(RVA = "0x3562EF0", Offset = "0x3561AF0", VA = "0x183562EF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170019B3 RID: 6579
		// (get) Token: 0x0600D37C RID: 54140 RVA: 0x0004C578 File Offset: 0x0004A778
		// (set) Token: 0x0600D37D RID: 54141 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019B3")]
		public SpeedLevel speedLevel
		{
			[Token(Token = "0x600D37C")]
			[Address(RVA = "0x3564210", Offset = "0x3562E10", VA = "0x183564210")]
			get
			{
				return SpeedLevel.SLOW_MOTION;
			}
			[Token(Token = "0x600D37D")]
			[Address(RVA = "0x3564EE0", Offset = "0x3563AE0", VA = "0x183564EE0")]
			set
			{
			}
		}

		// Token: 0x170019B4 RID: 6580
		// (get) Token: 0x0600D37E RID: 54142 RVA: 0x0004C590 File Offset: 0x0004A790
		[Token(Token = "0x170019B4")]
		public bool inSlowMotion
		{
			[Token(Token = "0x600D37E")]
			[Address(RVA = "0x3562270", Offset = "0x3560E70", VA = "0x183562270")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170019B5 RID: 6581
		// (get) Token: 0x0600D37F RID: 54143 RVA: 0x0004C5A8 File Offset: 0x0004A7A8
		[Token(Token = "0x170019B5")]
		public int maxLifePoint
		{
			[Token(Token = "0x600D37F")]
			[Address(RVA = "0x3563690", Offset = "0x3562290", VA = "0x183563690")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170019B6 RID: 6582
		// (get) Token: 0x0600D380 RID: 54144 RVA: 0x0004C5C0 File Offset: 0x0004A7C0
		[Token(Token = "0x170019B6")]
		public bool alwaysWinWhenFinish
		{
			[Token(Token = "0x600D380")]
			[Address(RVA = "0x3560AE0", Offset = "0x355F6E0", VA = "0x183560AE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600D381 RID: 54145 RVA: 0x0004C5D8 File Offset: 0x0004A7D8
		[Token(Token = "0x600D381")]
		[Address(RVA = "0x3548420", Offset = "0x3547020", VA = "0x183548420")]
		public int GetLifePoint(PlayerSide side = PlayerSide.DEFAULT)
		{
			return 0;
		}

		// Token: 0x0600D382 RID: 54146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D382")]
		[Address(RVA = "0x3552E30", Offset = "0x3551A30", VA = "0x183552E30")]
		public void SetLifePoint(int value, PlayerSide side, bool force = false)
		{
		}

		// Token: 0x0600D383 RID: 54147 RVA: 0x0004C5F0 File Offset: 0x0004A7F0
		[Token(Token = "0x600D383")]
		[Address(RVA = "0x3548AB0", Offset = "0x35476B0", VA = "0x183548AB0")]
		public int GetTempLifePoint(PlayerSide side = PlayerSide.DEFAULT)
		{
			return 0;
		}

		// Token: 0x0600D384 RID: 54148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D384")]
		[Address(RVA = "0x35536D0", Offset = "0x35522D0", VA = "0x1835536D0")]
		public void SetTempLifePoint(int value, PlayerSide side)
		{
		}

		// Token: 0x0600D385 RID: 54149 RVA: 0x0004C608 File Offset: 0x0004A808
		[Token(Token = "0x600D385")]
		[Address(RVA = "0x35494A0", Offset = "0x35480A0", VA = "0x1835494A0")]
		public int LifePointToShow(PlayerSide side = PlayerSide.DEFAULT)
		{
			return 0;
		}

		// Token: 0x0600D386 RID: 54150 RVA: 0x0004C620 File Offset: 0x0004A820
		[Token(Token = "0x600D386")]
		[Address(RVA = "0x3548200", Offset = "0x3546E00", VA = "0x183548200")]
		public int GetLifePointLossByEnemy(PlayerSide side = PlayerSide.DEFAULT)
		{
			return 0;
		}

		// Token: 0x0600D387 RID: 54151 RVA: 0x0004C638 File Offset: 0x0004A838
		[Token(Token = "0x600D387")]
		[Address(RVA = "0x3548310", Offset = "0x3546F10", VA = "0x183548310")]
		public int GetLifePointLossByOthers(PlayerSide side = PlayerSide.DEFAULT)
		{
			return 0;
		}

		// Token: 0x0600D388 RID: 54152 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D388")]
		[Address(RVA = "0x354B730", Offset = "0x354A330", VA = "0x18354B730")]
		public void MarkAlwaysWinWhenFinish(bool enable)
		{
		}

		// Token: 0x170019B7 RID: 6583
		// (get) Token: 0x0600D389 RID: 54153 RVA: 0x0004C650 File Offset: 0x0004A850
		[Token(Token = "0x170019B7")]
		public BattleController.GameResult gameResult
		{
			[Token(Token = "0x600D389")]
			[Address(RVA = "0x3562070", Offset = "0x3560C70", VA = "0x183562070")]
			get
			{
				return BattleController.GameResult.NOT_YET;
			}
		}

		// Token: 0x170019B8 RID: 6584
		// (get) Token: 0x0600D38A RID: 54154 RVA: 0x0004C668 File Offset: 0x0004A868
		[Token(Token = "0x170019B8")]
		public PlayerBattleRank battleRank
		{
			[Token(Token = "0x600D38A")]
			[Address(RVA = "0x3560D90", Offset = "0x355F990", VA = "0x183560D90")]
			get
			{
				return (PlayerBattleRank)0;
			}
		}

		// Token: 0x0600D38B RID: 54155 RVA: 0x0004C680 File Offset: 0x0004A880
		[Token(Token = "0x600D38B")]
		[Address(RVA = "0x3547CB0", Offset = "0x35468B0", VA = "0x183547CB0")]
		public int GetCost(PlayerSide side = PlayerSide.DEFAULT)
		{
			return 0;
		}

		// Token: 0x0600D38C RID: 54156 RVA: 0x0004C698 File Offset: 0x0004A898
		[Token(Token = "0x600D38C")]
		[Address(RVA = "0x3552B10", Offset = "0x3551710", VA = "0x183552B10")]
		public int SetCost(int value, PlayerSide side = PlayerSide.DEFAULT)
		{
			return 0;
		}

		// Token: 0x0600D38D RID: 54157 RVA: 0x0004C6B0 File Offset: 0x0004A8B0
		[Token(Token = "0x600D38D")]
		[Address(RVA = "0x3553060", Offset = "0x3551C60", VA = "0x183553060")]
		public int SetMaxCost(int value, PlayerSide side = PlayerSide.DEFAULT)
		{
			return 0;
		}

		// Token: 0x0600D38E RID: 54158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D38E")]
		[Address(RVA = "0x354B1F0", Offset = "0x3549DF0", VA = "0x18354B1F0")]
		public void LockCostIncreasement(bool isLock, CostLockReason reason)
		{
		}

		// Token: 0x0600D38F RID: 54159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D38F")]
		[Address(RVA = "0x3547BD0", Offset = "0x35467D0", VA = "0x183547BD0")]
		public PrecisePeriodicTimer GetCostTimer(PlayerSide side = PlayerSide.DEFAULT)
		{
			return null;
		}

		// Token: 0x0600D390 RID: 54160 RVA: 0x0004C6C8 File Offset: 0x0004A8C8
		[Token(Token = "0x600D390")]
		[Address(RVA = "0x3547870", Offset = "0x3546470", VA = "0x183547870")]
		public FP GetCostTimerProgress(bool next)
		{
			return default(FP);
		}

		// Token: 0x0600D391 RID: 54161 RVA: 0x0004C6E0 File Offset: 0x0004A8E0
		[Token(Token = "0x600D391")]
		[Address(RVA = "0x3547A40", Offset = "0x3546640", VA = "0x183547A40")]
		public FP GetCostTimerProgress(PlayerSide side = PlayerSide.DEFAULT)
		{
			return default(FP);
		}

		// Token: 0x170019B9 RID: 6585
		// (get) Token: 0x0600D392 RID: 54162 RVA: 0x0004C6F8 File Offset: 0x0004A8F8
		[Token(Token = "0x170019B9")]
		public float costTimerPeriodTime
		{
			[Token(Token = "0x600D392")]
			[Address(RVA = "0x3561430", Offset = "0x3560030", VA = "0x183561430")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170019BA RID: 6586
		// (get) Token: 0x0600D393 RID: 54163 RVA: 0x0004C710 File Offset: 0x0004A910
		[Token(Token = "0x170019BA")]
		public int remainingEnemiesCnt
		{
			[Token(Token = "0x600D393")]
			[Address(RVA = "0x3563DF0", Offset = "0x35629F0", VA = "0x183563DF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170019BB RID: 6587
		// (get) Token: 0x0600D394 RID: 54164 RVA: 0x0004C728 File Offset: 0x0004A928
		[Token(Token = "0x170019BB")]
		public float completeProgress
		{
			[Token(Token = "0x600D394")]
			[Address(RVA = "0x3561160", Offset = "0x355FD60", VA = "0x183561160")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170019BC RID: 6588
		// (get) Token: 0x0600D395 RID: 54165 RVA: 0x0004C740 File Offset: 0x0004A940
		[Token(Token = "0x170019BC")]
		public bool enablePause
		{
			[Token(Token = "0x600D395")]
			[Address(RVA = "0x3561A30", Offset = "0x3560630", VA = "0x183561A30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170019BD RID: 6589
		// (get) Token: 0x0600D396 RID: 54166 RVA: 0x0004C758 File Offset: 0x0004A958
		// (set) Token: 0x0600D397 RID: 54167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170019BD")]
		private float timeScale
		{
			[Token(Token = "0x600D396")]
			[Address(RVA = "0x35644A0", Offset = "0x35630A0", VA = "0x1835644A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600D397")]
			[Address(RVA = "0x35654B0", Offset = "0x35640B0", VA = "0x1835654B0")]
			set
			{
			}
		}

		// Token: 0x170019BE RID: 6590
		// (get) Token: 0x0600D398 RID: 54168 RVA: 0x0004C770 File Offset: 0x0004A970
		[Token(Token = "0x170019BE")]
		public static FP deltaPlayTimeFP
		{
			[Token(Token = "0x600D398")]
			[Address(RVA = "0x3561670", Offset = "0x3560270", VA = "0x183561670")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x170019BF RID: 6591
		// (get) Token: 0x0600D399 RID: 54169 RVA: 0x0004C788 File Offset: 0x0004A988
		[Token(Token = "0x170019BF")]
		public static float deltaPlayTime
		{
			[Token(Token = "0x600D399")]
			[Address(RVA = "0x3561700", Offset = "0x3560300", VA = "0x183561700")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600D39A RID: 54170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D39A")]
		[Address(RVA = "0x355FB70", Offset = "0x355E770", VA = "0x18355FB70")]
		public BattleController()
		{
		}

		// Token: 0x0600D39B RID: 54171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D39B")]
		[Address(RVA = "0x3553270", Offset = "0x3551E70", VA = "0x183553270")]
		public void SetPaused(bool value, Consts.BattlePauseKey pauseKey)
		{
		}

		// Token: 0x0600D39C RID: 54172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D39C")]
		[Address(RVA = "0x354EF10", Offset = "0x354DB10", VA = "0x18354EF10")]
		public void OnTileClicked(Tile tile)
		{
		}

		// Token: 0x0600D39D RID: 54173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D39D")]
		[Address(RVA = "0x3553810", Offset = "0x3552410", VA = "0x183553810")]
		public void SetTimeScale_DialogControllerOnly(float value)
		{
		}

		// Token: 0x0600D39E RID: 54174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D39E")]
		[Address(RVA = "0x354B050", Offset = "0x3549C50", VA = "0x18354B050")]
		public void LoadGame(List<BattlePlayerData> playerDataList, LevelData levelData, MapData mapData, LevelData.Difficulty difficulty)
		{
		}

		// Token: 0x0600D39F RID: 54175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D39F")]
		[Address(RVA = "0x3549680", Offset = "0x3548280", VA = "0x183549680")]
		public void LoadAutoReplayGame(List<BattlePlayerData> playerDataList, LevelData levelData, MapData mapData, BattleLogger.Journal journal, LevelData.Difficulty difficulty)
		{
		}

		// Token: 0x0600D3A0 RID: 54176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3A0")]
		[Address(RVA = "0x3554E00", Offset = "0x3553A00", VA = "0x183554E00")]
		public void StartGame()
		{
		}

		// Token: 0x0600D3A1 RID: 54177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3A1")]
		[Address(RVA = "0x35515E0", Offset = "0x35501E0", VA = "0x1835515E0")]
		public void ResetAll()
		{
		}

		// Token: 0x0600D3A2 RID: 54178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3A2")]
		[Address(RVA = "0x3546E90", Offset = "0x3545A90", VA = "0x183546E90")]
		public void FinishGame(BattleController.GameResult result, bool silent = false, [Optional] Action gameDoFinishCallback)
		{
		}

		// Token: 0x0600D3A3 RID: 54179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3A3")]
		[Address(RVA = "0x3558B80", Offset = "0x3557780", VA = "0x183558B80")]
		private void _DoFinishGame(BattleController.GameResult result, bool silent)
		{
		}

		// Token: 0x0600D3A4 RID: 54180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3A4")]
		[Address(RVA = "0x3548BE0", Offset = "0x35477E0", VA = "0x183548BE0")]
		public void GiveUpGame()
		{
		}

		// Token: 0x0600D3A5 RID: 54181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3A5")]
		[Address(RVA = "0x35498E0", Offset = "0x35484E0", VA = "0x1835498E0")]
		public void LoadCamera(bool needPostprocess)
		{
		}

		// Token: 0x0600D3A6 RID: 54182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3A6")]
		[Address(RVA = "0x355D990", Offset = "0x355C590", VA = "0x18355D990")]
		private void _PreLoadGameInternal(LevelData data, MapData mapData)
		{
		}

		// Token: 0x0600D3A7 RID: 54183 RVA: 0x0004C7A0 File Offset: 0x0004A9A0
		[Token(Token = "0x600D3A7")]
		[Address(RVA = "0x354BB90", Offset = "0x354A790", VA = "0x18354BB90")]
		public bool ModifyCost(int value, Entity source, PlayerSide side = PlayerSide.DEFAULT, bool forceToDisplayNumber = false, bool forceToDisplayNegativeNumber = false, bool isRetriggerSkill = false, bool isCastSkillWithCost = false)
		{
			return default(bool);
		}

		// Token: 0x0600D3A8 RID: 54184 RVA: 0x0004C7B8 File Offset: 0x0004A9B8
		[Token(Token = "0x600D3A8")]
		[Address(RVA = "0x354B980", Offset = "0x354A580", VA = "0x18354B980")]
		public bool ModifyCostIncreaseTime(float mulValue, PlayerSide side = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600D3A9 RID: 54185 RVA: 0x0004C7D0 File Offset: 0x0004A9D0
		[Token(Token = "0x600D3A9")]
		[Address(RVA = "0x353EAC0", Offset = "0x353D6C0", VA = "0x18353EAC0")]
		public bool AddCostTimerModifier(float mulValue, Entity source, int priority, bool costAddLocked, PlayerSide side = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600D3AA RID: 54186 RVA: 0x0004C7E8 File Offset: 0x0004A9E8
		[Token(Token = "0x600D3AA")]
		[Address(RVA = "0x3550EF0", Offset = "0x354FAF0", VA = "0x183550EF0")]
		public bool RemoveCostTimerModifier(Entity source, PlayerSide side = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600D3AB RID: 54187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3AB")]
		[Address(RVA = "0x355E290", Offset = "0x355CE90", VA = "0x18355E290")]
		private void _RefreshCostTimerModifier(PlayerSide side)
		{
		}

		// Token: 0x0600D3AC RID: 54188 RVA: 0x0004C800 File Offset: 0x0004AA00
		[Token(Token = "0x600D3AC")]
		[Address(RVA = "0x3552920", Offset = "0x3551520", VA = "0x183552920")]
		public bool SetCostIncreaseTime(float value = 1f, PlayerSide side = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600D3AD RID: 54189 RVA: 0x0004C818 File Offset: 0x0004AA18
		[Token(Token = "0x600D3AD")]
		[Address(RVA = "0x354C2E0", Offset = "0x354AEE0", VA = "0x18354C2E0")]
		public bool ModifyMaxCost(int value, Entity source, PlayerSide side = PlayerSide.DEFAULT, bool ensureCurCostNotExceedMax = false, bool playAudio = true)
		{
			return default(bool);
		}

		// Token: 0x0600D3AE RID: 54190 RVA: 0x0004C830 File Offset: 0x0004AA30
		[Token(Token = "0x600D3AE")]
		[Address(RVA = "0x354BE90", Offset = "0x354AA90", VA = "0x18354BE90")]
		public bool ModifyLegionGold(int value)
		{
			return default(bool);
		}

		// Token: 0x0600D3AF RID: 54191 RVA: 0x0004C848 File Offset: 0x0004AA48
		[Token(Token = "0x600D3AF")]
		[Address(RVA = "0x354B7C0", Offset = "0x354A3C0", VA = "0x18354B7C0")]
		public bool ModifyCharacterLimit(int value, Entity source, PlayerSide side = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600D3B0 RID: 54192 RVA: 0x0004C860 File Offset: 0x0004AA60
		[Token(Token = "0x600D3B0")]
		[Address(RVA = "0x354C020", Offset = "0x354AC20", VA = "0x18354C020")]
		public bool ModifyLifePoint(int value, Entity source, PlayerSide side = PlayerSide.DEFAULT, bool isReachExit = false)
		{
			return default(bool);
		}

		// Token: 0x0600D3B1 RID: 54193 RVA: 0x0004C878 File Offset: 0x0004AA78
		[Token(Token = "0x600D3B1")]
		[Address(RVA = "0x353EE60", Offset = "0x353DA60", VA = "0x18353EE60")]
		public bool AddTempLifePoint(int value, Entity source, PlayerSide side = PlayerSide.DEFAULT)
		{
			return default(bool);
		}

		// Token: 0x0600D3B2 RID: 54194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3B2")]
		[Address(RVA = "0x3546DE0", Offset = "0x35459E0", VA = "0x183546DE0")]
		public void EnsureMinCost(int cost)
		{
		}

		// Token: 0x0600D3B3 RID: 54195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3B3")]
		[Address(RVA = "0x354FC80", Offset = "0x354E880", VA = "0x18354FC80")]
		public void PlayAudioSignal(string ev, Unit unit, bool ignorePredefined = false)
		{
		}

		// Token: 0x0600D3B4 RID: 54196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3B4")]
		[Address(RVA = "0x354FE70", Offset = "0x354EA70", VA = "0x18354FE70")]
		public void PlayBAVGAudioSignal(string ev, string signalKey, Vector3 worldPos)
		{
		}

		// Token: 0x0600D3B5 RID: 54197 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3B5")]
		[Address(RVA = "0x3546C70", Offset = "0x3545870", VA = "0x183546C70")]
		public void EnableBuildableHighlight(Func<Tile, bool> checker)
		{
		}

		// Token: 0x0600D3B6 RID: 54198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3B6")]
		[Address(RVA = "0x3546A30", Offset = "0x3545630", VA = "0x183546A30")]
		public void EnableBuildableHighlight(BattleCharacterData sourceData, BuildCondition condition, bool overflowOccupiedCnt)
		{
		}

		// Token: 0x0600D3B7 RID: 54199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3B7")]
		[Address(RVA = "0x3546740", Offset = "0x3545340", VA = "0x183546740")]
		public void DisableBuildableHighlight()
		{
		}

		// Token: 0x0600D3B8 RID: 54200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3B8")]
		[Address(RVA = "0x3556E10", Offset = "0x3555A10", VA = "0x183556E10")]
		private void _ChangeTileHighlightType(Tile tile, bool isBuildable, [Optional] BattleCharacterData sourceData)
		{
		}

		// Token: 0x0600D3B9 RID: 54201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3B9")]
		[Address(RVA = "0x3556BE0", Offset = "0x35557E0", VA = "0x183556BE0")]
		private void _ChangeOverlapTargetColor(Character target, bool enable)
		{
		}

		// Token: 0x0600D3BA RID: 54202 RVA: 0x0004C890 File Offset: 0x0004AA90
		[Token(Token = "0x600D3BA")]
		[Address(RVA = "0x35487B0", Offset = "0x35473B0", VA = "0x1835487B0")]
		public Vector3 GetPredefinedLocationPosition(PredefinedLocation predefinedLocation)
		{
			return default(Vector3);
		}

		// Token: 0x0600D3BB RID: 54203 RVA: 0x0004C8A8 File Offset: 0x0004AAA8
		[Token(Token = "0x600D3BB")]
		[Address(RVA = "0x3555C50", Offset = "0x3554850", VA = "0x183555C50")]
		public bool TryGetCardPositionByUI(uint uniqueId, out Vector3 position)
		{
			return default(bool);
		}

		// Token: 0x0600D3BC RID: 54204 RVA: 0x0004C8C0 File Offset: 0x0004AAC0
		[Token(Token = "0x600D3BC")]
		[Address(RVA = "0x3552620", Offset = "0x3551220", VA = "0x183552620")]
		public Vector3 ScreenPointToWorldPositionAtMapHeight(Vector3 screenPoint, float heightOffset = 0f)
		{
			return default(Vector3);
		}

		// Token: 0x0600D3BD RID: 54205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D3BD")]
		[Address(RVA = "0x3547FB0", Offset = "0x3546BB0", VA = "0x183547FB0")]
		public GlobalEnvSystem GetEnvSystemByKey(string key, bool tryRuntimeLoad = false, [Optional] Blackboard blackboard)
		{
			return null;
		}

		// Token: 0x0600D3BE RID: 54206 RVA: 0x0004C8D8 File Offset: 0x0004AAD8
		[Token(Token = "0x600D3BE")]
		[Address(RVA = "0x3555F60", Offset = "0x3554B60", VA = "0x183555F60")]
		public bool TryGetEnvSystemByKey(string key, out GlobalEnvSystem envSystem)
		{
			return default(bool);
		}

		// Token: 0x0600D3BF RID: 54207 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D3BF")]
		public T GetEnvSystemManager<T>() where T : GlobalEnvSystem.EnvManager
		{
			return null;
		}

		// Token: 0x0600D3C0 RID: 54208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D3C0")]
		public T GetEnvSystemManagerByKey<T>(string key, bool allowRuntimeLoad = false) where T : GlobalEnvSystem.EnvManager
		{
			return null;
		}

		// Token: 0x0600D3C1 RID: 54209 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D3C1")]
		public T GetEnvSystemManagerByKeyNullable<T>(string key) where T : GlobalEnvSystem.EnvManager
		{
			return null;
		}

		// Token: 0x0600D3C2 RID: 54210 RVA: 0x0004C8F0 File Offset: 0x0004AAF0
		[Token(Token = "0x600D3C2")]
		public bool TryGetEnvSystemManagerByKey<T>(string key, out T manager) where T : GlobalEnvSystem.EnvManager
		{
			return default(bool);
		}

		// Token: 0x0600D3C3 RID: 54211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3C3")]
		[Address(RVA = "0x3553500", Offset = "0x3552100", VA = "0x183553500")]
		public void SetRuntimeMapTag(string mapTag, bool isSet)
		{
		}

		// Token: 0x0600D3C4 RID: 54212 RVA: 0x0004C908 File Offset: 0x0004AB08
		[Token(Token = "0x600D3C4")]
		[Address(RVA = "0x353FF20", Offset = "0x353EB20", VA = "0x18353FF20")]
		public bool ContainsMapTag(string mapTag)
		{
			return default(bool);
		}

		// Token: 0x0600D3C5 RID: 54213 RVA: 0x0004C920 File Offset: 0x0004AB20
		[Token(Token = "0x600D3C5")]
		[Address(RVA = "0x3540020", Offset = "0x353EC20", VA = "0x183540020")]
		public bool ContainsOneOfMapTag(IList<string> mapTags)
		{
			return default(bool);
		}

		// Token: 0x0600D3C6 RID: 54214 RVA: 0x0004C938 File Offset: 0x0004AB38
		[Token(Token = "0x600D3C6")]
		[Address(RVA = "0x353E950", Offset = "0x353D550", VA = "0x18353E950")]
		public bool ActivateInternalHiddenCard(string alias, string hiddenKey)
		{
			return default(bool);
		}

		// Token: 0x0600D3C7 RID: 54215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3C7")]
		[Address(RVA = "0x3550A00", Offset = "0x354F600", VA = "0x183550A00")]
		public void RefreshDeck(ref List<BattlePlayerData> data)
		{
		}

		// Token: 0x0600D3C8 RID: 54216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3C8")]
		[Address(RVA = "0x35521D0", Offset = "0x3550DD0", VA = "0x1835521D0")]
		public void ResetSeed()
		{
		}

		// Token: 0x0600D3C9 RID: 54217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3C9")]
		[Address(RVA = "0x3552020", Offset = "0x3550C20", VA = "0x183552020")]
		public void ResetSeed(int newSeed)
		{
		}

		// Token: 0x0600D3CA RID: 54218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3CA")]
		[Address(RVA = "0x3546580", Offset = "0x3545180", VA = "0x183546580")]
		public void CriticalAlertAndForceExit(string content, string sceneName)
		{
		}

		// Token: 0x0600D3CB RID: 54219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3CB")]
		[Address(RVA = "0x354F670", Offset = "0x354E270", VA = "0x18354F670")]
		public void PaddingPreload(PoolManager.ObjectConfig config)
		{
		}

		// Token: 0x0600D3CC RID: 54220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3CC")]
		[Address(RVA = "0x353F650", Offset = "0x353E250", VA = "0x18353F650")]
		public void ClearPadding()
		{
		}

		// Token: 0x0600D3CD RID: 54221 RVA: 0x0004C950 File Offset: 0x0004AB50
		[Token(Token = "0x600D3CD")]
		[Address(RVA = "0x3548E20", Offset = "0x3547A20", VA = "0x183548E20")]
		public bool IsPadding()
		{
			return default(bool);
		}

		// Token: 0x0600D3CE RID: 54222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3CE")]
		[Address(RVA = "0x3555960", Offset = "0x3554560", VA = "0x183555960")]
		public void TrigOrQueueFixedEntityEvent(Entity target, uint secondaryCompareUid, uint thirdCompareWeight, Action<Entity> callback)
		{
		}

		// Token: 0x0600D3CF RID: 54223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3CF")]
		[Address(RVA = "0x3555B30", Offset = "0x3554730", VA = "0x183555B30")]
		public void TrigOrQueueFixedPtrEvent(IPtrObject target, uint secondaryCompareUid, uint thirdCompareWeight, Action<IPtrObject> callback)
		{
		}

		// Token: 0x0600D3D0 RID: 54224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3D0")]
		[Address(RVA = "0x3555E30", Offset = "0x3554A30", VA = "0x183555E30")]
		public void TryGetDeckBuffFromGlobalBuff(Unit unit, ref List<DeckBuff> deckBuff, ref List<Blackboard> blackboardList)
		{
		}

		// Token: 0x0600D3D1 RID: 54225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3D1")]
		[Address(RVA = "0x354B630", Offset = "0x354A230", VA = "0x18354B630")]
		public void ManualFrameTick(BattleController.FrameData frameData, bool additionalFrame)
		{
		}

		// Token: 0x0600D3D2 RID: 54226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3D2")]
		[Address(RVA = "0x354B150", Offset = "0x3549D50", VA = "0x18354B150")]
		public void LoadPredefinedData(LevelData.PredefinedData predefinedData)
		{
		}

		// Token: 0x0600D3D3 RID: 54227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3D3")]
		[Address(RVA = "0x3550590", Offset = "0x354F190", VA = "0x183550590")]
		public void ReDoPostInit()
		{
		}

		// Token: 0x0600D3D4 RID: 54228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3D4")]
		[Address(RVA = "0x353F320", Offset = "0x353DF20", VA = "0x18353F320")]
		public static void BattleInitializerOnly_EarlyInit(GameModeMeta meta)
		{
		}

		// Token: 0x0600D3D5 RID: 54229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3D5")]
		[Address(RVA = "0x3550AA0", Offset = "0x354F6A0", VA = "0x183550AA0")]
		public void RegisterBObject(BObject obj)
		{
		}

		// Token: 0x0600D3D6 RID: 54230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3D6")]
		[Address(RVA = "0x3556320", Offset = "0x3554F20", VA = "0x183556320")]
		public void UnregisterBObject(BObject obj)
		{
		}

		// Token: 0x0600D3D7 RID: 54231 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3D7")]
		[Address(RVA = "0x3550D50", Offset = "0x354F950", VA = "0x183550D50")]
		public void RegisterUnit(Unit unit)
		{
		}

		// Token: 0x0600D3D8 RID: 54232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3D8")]
		[Address(RVA = "0x354E0C0", Offset = "0x354CCC0", VA = "0x18354E0C0")]
		public void OnRallyPointLikeReborn(Unit unit)
		{
		}

		// Token: 0x0600D3D9 RID: 54233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3D9")]
		[Address(RVA = "0x354D8A0", Offset = "0x354C4A0", VA = "0x18354D8A0")]
		public void OnEnemyRebornAfterFakeDeath(Unit unit)
		{
		}

		// Token: 0x0600D3DA RID: 54234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3DA")]
		[Address(RVA = "0x354EFD0", Offset = "0x354DBD0", VA = "0x18354EFD0")]
		public void OnTokenCategoryChanged(Unit unit)
		{
		}

		// Token: 0x0600D3DB RID: 54235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3DB")]
		[Address(RVA = "0x3556480", Offset = "0x3555080", VA = "0x183556480")]
		public void UnregisterUnit(Unit unit)
		{
		}

		// Token: 0x0600D3DC RID: 54236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3DC")]
		[Address(RVA = "0x3550B50", Offset = "0x354F750", VA = "0x183550B50")]
		public void RegisterModule(IBattleModule module)
		{
		}

		// Token: 0x0600D3DD RID: 54237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3DD")]
		[Address(RVA = "0x35563D0", Offset = "0x3554FD0", VA = "0x1835563D0")]
		public void UnregisterModule(IBattleModule module)
		{
		}

		// Token: 0x0600D3DE RID: 54238 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D3DE")]
		[Address(RVA = "0x3550C00", Offset = "0x354F800", VA = "0x183550C00")]
		public void RegisterMustInvokeGameReadyCallback(Action callback)
		{
		}

		// Token: 0x0600D3DF RID: 54239 RVA: 0x0004C968 File Offset: 0x0004AB68
		[Token(Token = "0x600D3DF")]
		[Address(RVA = "0x3550440", Offset = "0x354F040", VA = "0x183550440")]
		public bool PlayerOp_Withdraw(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600D3E0 RID: 54240 RVA: 0x0004C980 File Offset: 0x0004AB80
		[Token(Token = "0x600D3E0")]
		[Address(RVA = "0x354FFA0", Offset = "0x354EBA0", VA = "0x18354FFA0")]
		public bool PlayerOp_Spawn(uint uniqueId, SharedConsts.Direction direction, Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600D3E1 RID: 54241 RVA: 0x0004C998 File Offset: 0x0004AB98
		[Token(Token = "0x600D3E1")]
		[Address(RVA = "0x3550180", Offset = "0x354ED80", VA = "0x183550180")]
		public bool PlayerOp_TrigSkill(Character character, [Optional] string extraInfo)
		{
			return default(bool);
		}

		// Token: 0x0600D3E2 RID: 54242 RVA: 0x0004C9B0 File Offset: 0x0004ABB0
		[Token(Token = "0x600D3E2")]
		[Address(RVA = "0x3553C10", Offset = "0x3552810", VA = "0x183553C10")]
		public bool SpawnPredefinedInstanceByAlias(string alias)
		{
			return default(bool);
		}

		// Token: 0x0600D3E3 RID: 54243 RVA: 0x0004C9C8 File Offset: 0x0004ABC8
		[Token(Token = "0x600D3E3")]
		[Address(RVA = "0x35544D0", Offset = "0x35530D0", VA = "0x1835544D0")]
		public bool SpawnPredefinedInstance(bool isCharacter, GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x0600D3E4 RID: 54244 RVA: 0x0004C9E0 File Offset: 0x0004ABE0
		[Token(Token = "0x600D3E4")]
		[Address(RVA = "0x3553F00", Offset = "0x3552B00", VA = "0x183553F00")]
		public bool SpawnPredefinedInstanceByAlias(string alias, LevelData.PredefinedData predefines)
		{
			return default(bool);
		}

		// Token: 0x0600D3E5 RID: 54245 RVA: 0x0004C9F8 File Offset: 0x0004ABF8
		[Token(Token = "0x600D3E5")]
		[Address(RVA = "0x3556830", Offset = "0x3555430", VA = "0x183556830")]
		public bool WithdrawPredefinedInstByAlias(string alias)
		{
			return default(bool);
		}

		// Token: 0x0600D3E6 RID: 54246 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D3E6")]
		[Address(RVA = "0x3554190", Offset = "0x3552D90", VA = "0x183554190")]
		public Character SpawnPredefinedInstanceWithTile(string alias, Tile tile, SharedConsts.Direction direction)
		{
			return null;
		}

		// Token: 0x0600D3E7 RID: 54247 RVA: 0x0004CA10 File Offset: 0x0004AC10
		[Token(Token = "0x600D3E7")]
		[Address(RVA = "0x3548EC0", Offset = "0x3547AC0", VA = "0x183548EC0")]
		public bool IsPredefinedAndNeedToTakeSnapshot(string characterId)
		{
			return default(bool);
		}

		// Token: 0x0600D3E8 RID: 54248 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D3E8")]
		[Address(RVA = "0x3548680", Offset = "0x3547280", VA = "0x183548680")]
		public LevelData.PredefinedData.PredefinedInst GetPredefineCharacter(string charId)
		{
			return null;
		}

		// Token: 0x0600D3E9 RID: 54249 RVA: 0x0004CA28 File Offset: 0x0004AC28
		[Token(Token = "0x600D3E9")]
		[Address(RVA = "0x3549220", Offset = "0x3547E20", VA = "0x183549220")]
		public bool IsPredefinedAssistCharacter(string charId)
		{
			return default(bool);
		}

		// Token: 0x0600D3EA RID: 54250 RVA: 0x0004CA40 File Offset: 0x0004AC40
		[Token(Token = "0x600D3EA")]
		[Address(RVA = "0x35547D0", Offset = "0x35533D0", VA = "0x1835547D0")]
		public bool SpawnTokenBySkillFreely(string key, Character host, SharedConsts.Direction direction, Tile tile, out Character token, PlayerSide side, bool refreshCooldown, bool ignoreAdvancedBuildableMask = false, bool forceSpawn = false, bool dontUpdateState = false)
		{
			return default(bool);
		}

		// Token: 0x0600D3EB RID: 54251 RVA: 0x0004CA58 File Offset: 0x0004AC58
		[Token(Token = "0x600D3EB")]
		[Address(RVA = "0x355EB70", Offset = "0x355D770", VA = "0x18355EB70")]
		[Obsolete]
		private bool _SpawnInternal(BattleCharacterData.Signiture signiture, SharedConsts.Direction direction, Tile tile, bool strict, bool spawnManually)
		{
			return default(bool);
		}

		// Token: 0x0600D3EC RID: 54252 RVA: 0x0004CA70 File Offset: 0x0004AC70
		[Token(Token = "0x600D3EC")]
		[Address(RVA = "0x355EA10", Offset = "0x355D610", VA = "0x18355EA10")]
		private bool _SpawnInternal(uint uniqueId, SharedConsts.Direction direction, Tile tile, bool strict, bool spawnManually, PlayerSide opSide)
		{
			return default(bool);
		}

		// Token: 0x0600D3ED RID: 54253 RVA: 0x0004CA88 File Offset: 0x0004AC88
		[Token(Token = "0x600D3ED")]
		[Address(RVA = "0x355F620", Offset = "0x355E220", VA = "0x18355F620")]
		private bool _WithdrawInternal(BattleCharacterData.Signiture signiture, GridPosition gridPos)
		{
			return default(bool);
		}

		// Token: 0x0600D3EE RID: 54254 RVA: 0x0004CAA0 File Offset: 0x0004ACA0
		[Token(Token = "0x600D3EE")]
		[Address(RVA = "0x355F4D0", Offset = "0x355E0D0", VA = "0x18355F4D0")]
		private bool _WithdrawInternal(Character character, PlayerSide opSide)
		{
			return default(bool);
		}

		// Token: 0x0600D3EF RID: 54255 RVA: 0x0004CAB8 File Offset: 0x0004ACB8
		[Token(Token = "0x600D3EF")]
		[Address(RVA = "0x355CED0", Offset = "0x355BAD0", VA = "0x18355CED0")]
		private bool _OpTrigSkillInternal(BattleCharacterData.Signiture signiture, GridPosition gridPos, bool requireNotHidden, [Optional] string extraInfo)
		{
			return default(bool);
		}

		// Token: 0x0600D3F0 RID: 54256 RVA: 0x0004CAD0 File Offset: 0x0004ACD0
		[Token(Token = "0x600D3F0")]
		[Address(RVA = "0x355D060", Offset = "0x355BC60", VA = "0x18355D060")]
		private bool _OpTrigSkillInternal(Character character, bool requireNotHidden, PlayerSide side, [Optional] string extraInfo)
		{
			return default(bool);
		}

		// Token: 0x0600D3F1 RID: 54257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D3F1")]
		[Address(RVA = "0x3559260", Offset = "0x3557E60", VA = "0x183559260")]
		private Character _FindCharacterBySignitureAndPos(BattleCharacterData.Signiture signiture, GridPosition gridPos)
		{
			return null;
		}

		// Token: 0x0600D3F2 RID: 54258 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D3F2")]
		[Address(RVA = "0x3559100", Offset = "0x3557D00", VA = "0x183559100")]
		public Character _FindCharacterByIdAndPos(string id, GridPosition gridPos)
		{
			return null;
		}

		// Token: 0x0600D3F3 RID: 54259 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D3F3")]
		[Address(RVA = "0x3544C60", Offset = "0x3543860", VA = "0x183544C60")]
		public PreviewCursor CreatePreviewCursor(int routeIndex, bool isExtraRoute, Scheduler.SchedulerSnapshot snapshot, Action finishCb, [Optional] string overrideEffect)
		{
			return null;
		}

		// Token: 0x0600D3F4 RID: 54260 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D3F4")]
		[Address(RVA = "0x3543FC0", Offset = "0x3542BC0", VA = "0x183543FC0")]
		public Enemy CreateEnemy(LevelData.EnemyData enemyData, EnemyHandBookData handbookData, Scheduler.SchedulerSnapshot snapshot, int routeIndex, Enemy.Options options, bool isExtraRoute)
		{
			return null;
		}

		// Token: 0x0600D3F5 RID: 54261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D3F5")]
		[Address(RVA = "0x3543D70", Offset = "0x3542970", VA = "0x183543D70")]
		public Enemy CreateEnemy(LevelData.EnemyData enemyData, EnemyHandBookData handbookData, Scheduler.SchedulerSnapshot snapshot, Route route, Enemy.Options options)
		{
			return null;
		}

		// Token: 0x0600D3F6 RID: 54262 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D3F6")]
		[Address(RVA = "0x3541150", Offset = "0x353FD50", VA = "0x183541150")]
		public Character CreateCharacter(Deck.Card characterCard, SharedConsts.Direction direction, Tile tile, bool spawnManually, Deck.SpawnDetailsTracker spawnDetailsTracker, bool force = false)
		{
			return null;
		}

		// Token: 0x0600D3F7 RID: 54263 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D3F7")]
		[Address(RVA = "0x3546340", Offset = "0x3544F40", VA = "0x183546340")]
		public Character CreateToken(Deck.Card tokenCard, SharedConsts.Direction direction, Tile tile, bool spawnManually, Deck.SpawnDetailsTracker spawnDetailsTracker)
		{
			return null;
		}

		// Token: 0x0600D3F8 RID: 54264 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D3F8")]
		[Address(RVA = "0x3544960", Offset = "0x3543560", VA = "0x183544960")]
		public Character CreateNpc(string npcId, SharedConsts.Direction direction, GridPosition gridPosition, bool isToken, int skillIndex = -1)
		{
			return null;
		}

		// Token: 0x0600D3F9 RID: 54265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D3F9")]
		[Address(RVA = "0x3545980", Offset = "0x3544580", VA = "0x183545980")]
		public Character CreateRuntimeInst(SharedConsts.Direction direction, GridPosition gridPosition, bool isToken, AdvancedCharacterInst inst, bool isDialogTarget = false, [Optional] Blackboard skillBlackboard)
		{
			return null;
		}

		// Token: 0x0600D3FA RID: 54266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D3FA")]
		[Address(RVA = "0x3545CC0", Offset = "0x35448C0", VA = "0x183545CC0")]
		public Character CreateRuntimeInstance(AdvancedCharacterInst inst, SharedConsts.Direction direction, Tile tile, bool isToken, SideType sideType, PlayerSide pSide, bool checkBuildValid, bool force = false)
		{
			return null;
		}

		// Token: 0x0600D3FB RID: 54267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D3FB")]
		[Address(RVA = "0x3545E20", Offset = "0x3544A20", VA = "0x183545E20")]
		public Character CreateRuntimeInstance(BattleCharacterData data, SharedConsts.Direction direction, Tile tile, bool isToken, SideType sideType, PlayerSide pSide, bool checkBuildValid, bool force = false)
		{
			return null;
		}

		// Token: 0x0600D3FC RID: 54268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D3FC")]
		[Address(RVA = "0x3545540", Offset = "0x3544140", VA = "0x183545540")]
		public Projectile CreateProjectile(string key, Entity source, ILocatable start, ILocatable target, Ability ability, out Projectile graphicProjectile)
		{
			return null;
		}

		// Token: 0x0600D3FD RID: 54269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D3FD")]
		[Address(RVA = "0x35450F0", Offset = "0x3543CF0", VA = "0x1835450F0")]
		public Projectile CreateProjectileUseSourceAsProjectileSource(string key, Entity source, ILocatable start, ILocatable target, Ability ability, out Projectile graphicProjectile)
		{
			return null;
		}

		// Token: 0x0600D3FE RID: 54270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D3FE")]
		[Address(RVA = "0x3544F80", Offset = "0x3543B80", VA = "0x183544F80")]
		public Projectile CreateProjectileFromProjectile(string key, Projectile sourceProjectile, ILocatable target, Projectile.Type type, string originalKey, EffectReplacePair[] effectReplacePairs)
		{
			return null;
		}

		// Token: 0x0600D3FF RID: 54271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D3FF")]
		[Address(RVA = "0x3540FE0", Offset = "0x353FBE0", VA = "0x183540FE0")]
		public Character CreateCharacterDummy(BattleCharacterData characterData, AdditionalBuildCondition additionalBuildCondition, bool useOutline = false)
		{
			return null;
		}

		// Token: 0x0600D400 RID: 54272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D400")]
		[Address(RVA = "0x35461D0", Offset = "0x3544DD0", VA = "0x1835461D0")]
		public Character CreateTokenDummy(BattleCharacterData tokenData, AdditionalBuildCondition additionalBuildCondition, bool useOutline = false)
		{
			return null;
		}

		// Token: 0x0600D401 RID: 54273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D401")]
		[Address(RVA = "0x3546110", Offset = "0x3544D10", VA = "0x183546110")]
		public BasicSkill CreateSkill(SkillData skillData)
		{
			return null;
		}

		// Token: 0x0600D402 RID: 54274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D402")]
		[Address(RVA = "0x3542750", Offset = "0x3541350", VA = "0x183542750")]
		public Effect CreateEffect(string key, ILocatable locatable, Entity source, float playbackSpeed = 1f)
		{
			return null;
		}

		// Token: 0x0600D403 RID: 54275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D403")]
		[Address(RVA = "0x3542970", Offset = "0x3541570", VA = "0x183542970")]
		public Effect CreateEffect(string key, ILocatable locatable, Entity source, Vector3 direction, float playbackSpeed = 1f)
		{
			return null;
		}

		// Token: 0x0600D404 RID: 54276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D404")]
		[Address(RVA = "0x35420F0", Offset = "0x3540CF0", VA = "0x1835420F0")]
		public Effect CreateEffectHoldBySource(string key, ILocatable locatable, Entity source, float playbackSpeed = 1f)
		{
			return null;
		}

		// Token: 0x0600D405 RID: 54277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D405")]
		[Address(RVA = "0x3542470", Offset = "0x3541070", VA = "0x183542470")]
		public Effect CreateEffect(string key, Transform transform, Entity source, bool setAsParent, float playbackSpeed = 1f)
		{
			return null;
		}

		// Token: 0x0600D406 RID: 54278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D406")]
		[Address(RVA = "0x3541E80", Offset = "0x3540A80", VA = "0x183541E80")]
		public Effect CreateEffectAtWorldPos(string key, Vector3 position, Entity source, float playbackSpeed = 1f, PlayerSide side = PlayerSide.DEFAULT)
		{
			return null;
		}

		// Token: 0x0600D407 RID: 54279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D407")]
		[Address(RVA = "0x3541BB0", Offset = "0x35407B0", VA = "0x183541BB0")]
		public Effect CreateEffectAtWorldPos(string key, Vector3 position, Vector3 direction, Entity source, float playbackSpeed = 1f, bool useOverwriteHeight = false)
		{
			return null;
		}

		// Token: 0x0600D408 RID: 54280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D408")]
		[Address(RVA = "0x35416C0", Offset = "0x35402C0", VA = "0x1835416C0")]
		public Effect CreateEffectAtMapPos(string key, Vector3 mapPos, Entity source, float playbackSpeed = 1f)
		{
			return null;
		}

		// Token: 0x0600D409 RID: 54281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D409")]
		[Address(RVA = "0x3541910", Offset = "0x3540510", VA = "0x183541910")]
		public Effect CreateEffectAtMapPos(string key, Vector3 mapPos, Entity source, Vector3 direction, float playbackSpeed = 1f)
		{
			return null;
		}

		// Token: 0x0600D40A RID: 54282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D40A")]
		[Address(RVA = "0x3541580", Offset = "0x3540180", VA = "0x183541580")]
		public Effect CreateEffectAtMapPosAndHold(string key, Vector3 mapPos, Entity source, float playbackSpeed = 1f)
		{
			return null;
		}

		// Token: 0x0600D40B RID: 54283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D40B")]
		[Address(RVA = "0x35471E0", Offset = "0x3545DE0", VA = "0x1835471E0")]
		public void FinishOperaHoldEffectIfExist()
		{
		}

		// Token: 0x0600D40C RID: 54284 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D40C")]
		[Address(RVA = "0x35443A0", Offset = "0x3542FA0", VA = "0x1835443A0")]
		public Effect CreateMapEffect(MapEffectData data, ILocatable locator, Transform parent)
		{
			return null;
		}

		// Token: 0x0600D40D RID: 54285 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D40D")]
		[Address(RVA = "0x3542B60", Offset = "0x3541760", VA = "0x183542B60")]
		public Effect CreateEffect(string key, Entity target, Entity source, float playSpeed = 1f)
		{
			return null;
		}

		// Token: 0x0600D40E RID: 54286 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D40E")]
		[Address(RVA = "0x3542CF0", Offset = "0x35418F0", VA = "0x183542CF0")]
		public Effect CreateEffect(string key, Entity target, Entity source, Vector3 direction, float playbackSpeed = 1f)
		{
			return null;
		}

		// Token: 0x0600D40F RID: 54287 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D40F")]
		[Address(RVA = "0x3540560", Offset = "0x353F160", VA = "0x183540560")]
		public CameraEffect CreateCameraEffect(string key)
		{
			return null;
		}

		// Token: 0x0600D410 RID: 54288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D410")]
		[Address(RVA = "0x35432F0", Offset = "0x3541EF0", VA = "0x1835432F0")]
		public void CreateEffects(IList<string> keys, ILocatable position, Entity source, float playbackSpeed = 1f)
		{
		}

		// Token: 0x0600D411 RID: 54289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D411")]
		[Address(RVA = "0x35439E0", Offset = "0x35425E0", VA = "0x1835439E0")]
		public void CreateEffects(IList<string> keys, Entity entity, Entity source)
		{
		}

		// Token: 0x0600D412 RID: 54290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D412")]
		[Address(RVA = "0x3543720", Offset = "0x3542320", VA = "0x183543720")]
		public void CreateEffects(IList<string> keys, Entity target, Entity source, Vector3 direction, float playbackSpeed = 1f)
		{
		}

		// Token: 0x0600D413 RID: 54291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D413")]
		[Address(RVA = "0x3543050", Offset = "0x3541C50", VA = "0x183543050")]
		public void CreateEffectsAtMapPos(IList<string> keys, Vector3 mapPos, Entity source, float playbackSpeed = 1f)
		{
		}

		// Token: 0x0600D414 RID: 54292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D414")]
		[Address(RVA = "0x3544700", Offset = "0x3543300", VA = "0x183544700")]
		public void CreateMapEffects(IList<MapEffectData> effects, ILocatable locator, Transform parent)
		{
		}

		// Token: 0x0600D415 RID: 54293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D415")]
		[Address(RVA = "0x35538B0", Offset = "0x35524B0", VA = "0x1835538B0")]
		public void SortDeckRuntime(PlayerSide side, [Optional] IComparer<Deck.Card> sorter)
		{
		}

		// Token: 0x0600D416 RID: 54294 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D416")]
		[Address(RVA = "0x3542310", Offset = "0x3540F10", VA = "0x183542310")]
		public Effect CreateEffectOn(string key, Transform parent)
		{
			return null;
		}

		// Token: 0x0600D417 RID: 54295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D417")]
		[Address(RVA = "0x3555850", Offset = "0x3554450", VA = "0x183555850")]
		public void ThrowEffect(ObjectPtr<Effect> effect)
		{
		}

		// Token: 0x0600D418 RID: 54296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D418")]
		[Address(RVA = "0x354F780", Offset = "0x354E380", VA = "0x18354F780")]
		public static void PlayAudioAtPos(string signal, string key, Vector3 worldPosition, Entity bindTo)
		{
		}

		// Token: 0x0600D419 RID: 54297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D419")]
		[Address(RVA = "0x355D280", Offset = "0x355BE80", VA = "0x18355D280")]
		private static void _PlayBattleCharFX(string signal, string key, Vector3 worldPosition, VoiceQuery query)
		{
		}

		// Token: 0x0600D41A RID: 54298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D41A")]
		[Address(RVA = "0x355D460", Offset = "0x355C060", VA = "0x18355D460")]
		private void _PlayBattleFinishAudio(BattleController.GameResult result)
		{
		}

		// Token: 0x0600D41B RID: 54299 RVA: 0x0004CAE8 File Offset: 0x0004ACE8
		[Token(Token = "0x600D41B")]
		[Address(RVA = "0x3554980", Offset = "0x3553580", VA = "0x183554980")]
		public static CoroutineId StartBattleCoroutine(MonoBehaviour mono, IEnumerator routine)
		{
			return default(CoroutineId);
		}

		// Token: 0x0600D41C RID: 54300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D41C")]
		[Address(RVA = "0x3555080", Offset = "0x3553C80", VA = "0x183555080")]
		public static void StopBattleCoroutine(MonoBehaviour mono, CoroutineId coroutineId)
		{
		}

		// Token: 0x0600D41D RID: 54301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D41D")]
		[Address(RVA = "0x3554F00", Offset = "0x3553B00", VA = "0x183554F00")]
		public static void StopAllBattleCoroutines(MonoBehaviour mono, bool checkInstance = true)
		{
		}

		// Token: 0x0600D41E RID: 54302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D41E")]
		[Address(RVA = "0x3552490", Offset = "0x3551090", VA = "0x183552490")]
		public static void RestoreDeltaTimeScale()
		{
		}

		// Token: 0x0600D41F RID: 54303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D41F")]
		[Address(RVA = "0x3551550", Offset = "0x3550150", VA = "0x183551550")]
		public static void ReqChangeDeltaTimeFPInStepMode(FP deltaTime)
		{
		}

		// Token: 0x0600D420 RID: 54304 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D420")]
		[Address(RVA = "0x3554B70", Offset = "0x3553770", VA = "0x183554B70")]
		public static BattleTweenMgr.Tween StartBattleTween(FP startValue, Action<FP> func, FP endValue, FP duration)
		{
			return null;
		}

		// Token: 0x0600D421 RID: 54305 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D421")]
		[Address(RVA = "0x3554CB0", Offset = "0x35538B0", VA = "0x183554CB0")]
		public static BattleTweenMgr.Tween StartBattleTween(Vector2 startPos, Action<Vector2> func, Vector2 endPos, FP duration)
		{
			return null;
		}

		// Token: 0x0600D422 RID: 54306 RVA: 0x0004CB00 File Offset: 0x0004AD00
		[Token(Token = "0x600D422")]
		[Address(RVA = "0x35551F0", Offset = "0x3553DF0", VA = "0x1835551F0")]
		public uint TakeSnapshotAsHashCode()
		{
			return 0U;
		}

		// Token: 0x0600D423 RID: 54307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D423")]
		[Address(RVA = "0x355BDC0", Offset = "0x355A9C0", VA = "0x18355BDC0")]
		private void _LogSnapshot(uint hash)
		{
		}

		// Token: 0x0600D424 RID: 54308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D424")]
		[Address(RVA = "0x3550620", Offset = "0x354F220", VA = "0x183550620")]
		public void RecycleBuffNextFrame(ObjectPtr<Buff> buff)
		{
		}

		// Token: 0x0600D425 RID: 54309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D425")]
		[Address(RVA = "0x355F050", Offset = "0x355DC50", VA = "0x18355F050")]
		private void _UpdateDelayToRecycleBuffContainer()
		{
		}

		// Token: 0x0600D426 RID: 54310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D426")]
		[Address(RVA = "0x355DF30", Offset = "0x355CB30", VA = "0x18355DF30")]
		private void _RecycleBuffContainerImmediatelly()
		{
		}

		// Token: 0x0600D427 RID: 54311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D427")]
		[Address(RVA = "0x3553620", Offset = "0x3552220", VA = "0x183553620")]
		public void SetSlowMotion(SlowMotionReason reason)
		{
		}

		// Token: 0x0600D428 RID: 54312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D428")]
		[Address(RVA = "0x3552560", Offset = "0x3551160", VA = "0x183552560")]
		public void RevertSlowMotion(SlowMotionReason reason)
		{
		}

		// Token: 0x0600D429 RID: 54313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D429")]
		[Address(RVA = "0x354B2C0", Offset = "0x3549EC0", VA = "0x18354B2C0")]
		public void LogPlayerOperation(PlayerOprtData oprt)
		{
		}

		// Token: 0x0600D42A RID: 54314 RVA: 0x0004CB18 File Offset: 0x0004AD18
		[Token(Token = "0x600D42A")]
		[Address(RVA = "0x353E870", Offset = "0x353D470", VA = "0x18353E870")]
		public BattleLogger.Journal AchieveBattleJournal()
		{
			return default(BattleLogger.Journal);
		}

		// Token: 0x0600D42B RID: 54315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D42B")]
		[Address(RVA = "0x353F470", Offset = "0x353E070", VA = "0x18353F470")]
		public void CancelAutoReplayIfOn()
		{
		}

		// Token: 0x0600D42C RID: 54316 RVA: 0x0004CB30 File Offset: 0x0004AD30
		[Token(Token = "0x600D42C")]
		[Address(RVA = "0x3548D80", Offset = "0x3547980", VA = "0x183548D80")]
		public bool IsAutoBattleUnsync()
		{
			return default(bool);
		}

		// Token: 0x0600D42D RID: 54317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D42D")]
		[Address(RVA = "0x354DD90", Offset = "0x354C990", VA = "0x18354DD90")]
		public void OnPhysicObjectInit(IPhysicObject obj)
		{
		}

		// Token: 0x0600D42E RID: 54318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D42E")]
		[Address(RVA = "0x354DE40", Offset = "0x354CA40", VA = "0x18354DE40")]
		public void OnPhysicObjectRecycle(IPhysicObject obj)
		{
		}

		// Token: 0x0600D42F RID: 54319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D42F")]
		[Address(RVA = "0x354F1A0", Offset = "0x354DDA0", VA = "0x18354F1A0")]
		public void OnUnitBorn(Unit unit)
		{
		}

		// Token: 0x0600D430 RID: 54320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D430")]
		[Address(RVA = "0x354F2B0", Offset = "0x354DEB0", VA = "0x18354F2B0")]
		public void OnUnitFinished(Unit unit, Entity.FinishReason reason)
		{
		}

		// Token: 0x0600D431 RID: 54321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D431")]
		[Address(RVA = "0x354CA60", Offset = "0x354B660", VA = "0x18354CA60")]
		public void OnCharacterLocate(Character character)
		{
		}

		// Token: 0x0600D432 RID: 54322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D432")]
		[Address(RVA = "0x354C7F0", Offset = "0x354B3F0", VA = "0x18354C7F0")]
		public void OnCharacterFinished(Character character, Entity.FinishReason reason)
		{
		}

		// Token: 0x0600D433 RID: 54323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D433")]
		[Address(RVA = "0x3550890", Offset = "0x354F490", VA = "0x183550890")]
		public void RecycleCard(Character character)
		{
		}

		// Token: 0x0600D434 RID: 54324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D434")]
		[Address(RVA = "0x354C730", Offset = "0x354B330", VA = "0x18354C730")]
		public void OnCharacterAtkOrCbt(Character character)
		{
		}

		// Token: 0x0600D435 RID: 54325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D435")]
		[Address(RVA = "0x354CFC0", Offset = "0x354BBC0", VA = "0x18354CFC0")]
		public void OnDummyTouchedToTile(Character character, Tile tile)
		{
		}

		// Token: 0x0600D436 RID: 54326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D436")]
		[Address(RVA = "0x354D0C0", Offset = "0x354BCC0", VA = "0x18354D0C0")]
		public void OnDummyTouchedToTile(Character character, Tile tile, Vector3 dummyPos)
		{
		}

		// Token: 0x0600D437 RID: 54327 RVA: 0x0004CB48 File Offset: 0x0004AD48
		[Token(Token = "0x600D437")]
		[Address(RVA = "0x3548CD0", Offset = "0x35478D0", VA = "0x183548CD0")]
		public bool Hook_OnDummyDragging()
		{
			return default(bool);
		}

		// Token: 0x0600D438 RID: 54328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D438")]
		[Address(RVA = "0x354D420", Offset = "0x354C020", VA = "0x18354D420")]
		public void OnEnemyFinished(Enemy enemy, Entity.FinishReason reason)
		{
		}

		// Token: 0x0600D439 RID: 54329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D439")]
		[Address(RVA = "0x354D600", Offset = "0x354C200", VA = "0x18354D600")]
		public void OnEnemyReachedExit(Enemy enemy, Tile tile)
		{
		}

		// Token: 0x0600D43A RID: 54330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D43A")]
		[Address(RVA = "0x354DA70", Offset = "0x354C670", VA = "0x18354DA70")]
		public void OnEnemyRecycled(Enemy enemy)
		{
		}

		// Token: 0x0600D43B RID: 54331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D43B")]
		[Address(RVA = "0x354C5A0", Offset = "0x354B1A0", VA = "0x18354C5A0")]
		public void OnBossEnter(Enemy enemy)
		{
		}

		// Token: 0x0600D43C RID: 54332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D43C")]
		[Address(RVA = "0x354DB30", Offset = "0x354C730", VA = "0x18354DB30")]
		public void OnGiantBossHudUsed(IUseGiantBossInfoPanel target)
		{
		}

		// Token: 0x0600D43D RID: 54333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D43D")]
		[Address(RVA = "0x354DEF0", Offset = "0x354CAF0", VA = "0x18354DEF0")]
		public void OnPredefinedLocationReached(object info)
		{
		}

		// Token: 0x0600D43E RID: 54334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D43E")]
		[Address(RVA = "0x355CD10", Offset = "0x355B910", VA = "0x18355CD10")]
		private void _OnPauseToggled(bool isPaused)
		{
		}

		// Token: 0x0600D43F RID: 54335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D43F")]
		[Address(RVA = "0x355CDF0", Offset = "0x355B9F0", VA = "0x18355CDF0")]
		private void _OnSpeedLevelChanged(SpeedLevel level)
		{
		}

		// Token: 0x0600D440 RID: 54336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D440")]
		[Address(RVA = "0x354F550", Offset = "0x354E150", VA = "0x18354F550")]
		public void OnWaveWillStart(LevelData.WaveData wave)
		{
		}

		// Token: 0x0600D441 RID: 54337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D441")]
		[Address(RVA = "0x354F430", Offset = "0x354E030", VA = "0x18354F430")]
		public void OnWaveWillFinish(LevelData.WaveData wave)
		{
		}

		// Token: 0x0600D442 RID: 54338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D442")]
		[Address(RVA = "0x354E290", Offset = "0x354CE90", VA = "0x18354E290")]
		public void OnSpecialUITrigger(object param)
		{
		}

		// Token: 0x0600D443 RID: 54339 RVA: 0x0004CB60 File Offset: 0x0004AD60
		[Token(Token = "0x600D443")]
		[Address(RVA = "0x355D1E0", Offset = "0x355BDE0", VA = "0x18355D1E0")]
		private PlayerBattleRank _ParseBattleRank()
		{
			return (PlayerBattleRank)0;
		}

		// Token: 0x0600D444 RID: 54340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D444")]
		[Address(RVA = "0x3557960", Offset = "0x3556560", VA = "0x183557960")]
		private Character _CreatePredefinedCharacter(LevelData.PredefinedData.PredefinedCharacter slot, bool isToken, out bool isExcluded)
		{
			return null;
		}

		// Token: 0x0600D445 RID: 54341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D445")]
		[Address(RVA = "0x355F780", Offset = "0x355E380", VA = "0x18355F780")]
		private void _WithdrawPredefinedCharacter(LevelData.PredefinedData.PredefinedCharacter slot)
		{
		}

		// Token: 0x0600D446 RID: 54342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D446")]
		[Address(RVA = "0x355DAE0", Offset = "0x355C6E0", VA = "0x18355DAE0")]
		private void _PreprocessPredefinedCharacter(BattleCharacterData data, bool isToken, out bool isExcluded)
		{
		}

		// Token: 0x0600D447 RID: 54343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D447")]
		[Address(RVA = "0x355BAC0", Offset = "0x355A6C0", VA = "0x18355BAC0")]
		private void _LoadPredefinedData(LevelData.PredefinedData predefines)
		{
		}

		// Token: 0x0600D448 RID: 54344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D448")]
		[Address(RVA = "0x355A3A0", Offset = "0x3558FA0", VA = "0x18355A3A0")]
		private void _InitRunes(IRuneDataHolder runeInput, IList<LegacyInLevelRuneData> legacyRunes, LevelData.Difficulty difficulty)
		{
		}

		// Token: 0x0600D449 RID: 54345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D449")]
		[Address(RVA = "0x3557530", Offset = "0x3556130", VA = "0x183557530")]
		private void _CreateAndInitGlobalBuffs(IList<LevelData.GlobalBuffData> data)
		{
		}

		// Token: 0x0600D44A RID: 54346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D44A")]
		[Address(RVA = "0x35403C0", Offset = "0x353EFC0", VA = "0x1835403C0")]
		public GlobalBuff CreateAndInitGlobalBuff(LevelData.GlobalBuffData globalBuffData)
		{
			return null;
		}

		// Token: 0x0600D44B RID: 54347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D44B")]
		[Address(RVA = "0x3548080", Offset = "0x3546C80", VA = "0x183548080")]
		public GlobalBuff GetFirstGlobalBuffByKey(string key)
		{
			return null;
		}

		// Token: 0x0600D44C RID: 54348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D44C")]
		[Address(RVA = "0x3557840", Offset = "0x3556440", VA = "0x183557840")]
		private void _CreateAndInitGlobalEnvSystem(IList<GlobalEnvSystemData> globalEnvSystemData)
		{
		}

		// Token: 0x0600D44D RID: 54349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D44D")]
		[Address(RVA = "0x353F6F0", Offset = "0x353E2F0", VA = "0x18353F6F0")]
		public void ClearRunTimeData()
		{
		}

		// Token: 0x0600D44E RID: 54350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D44E")]
		[Address(RVA = "0x3557040", Offset = "0x3555C40", VA = "0x183557040")]
		private void _ClearResourcesInHolder()
		{
		}

		// Token: 0x0600D44F RID: 54351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D44F")]
		[Address(RVA = "0x3551E80", Offset = "0x3550A80", VA = "0x183551E80")]
		public void ResetGlobalBuff()
		{
		}

		// Token: 0x0600D450 RID: 54352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D450")]
		[Address(RVA = "0x3551390", Offset = "0x354FF90", VA = "0x183551390")]
		public void RemoveGlobalBuff(uint instanceUid)
		{
		}

		// Token: 0x0600D451 RID: 54353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D451")]
		[Address(RVA = "0x3551160", Offset = "0x354FD60", VA = "0x183551160")]
		public void RemoveGlobalBuffByAlias(string alias)
		{
		}

		// Token: 0x0600D452 RID: 54354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D452")]
		[Address(RVA = "0x355E780", Offset = "0x355D380", VA = "0x18355E780")]
		private void _ResetGlobalBuffStatics()
		{
		}

		// Token: 0x0600D453 RID: 54355 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D453")]
		[Address(RVA = "0x35409B0", Offset = "0x353F5B0", VA = "0x1835409B0")]
		public Deck.Card.CardBuff CreateCardBuffWithBlackboardByCardBuffKey(string cardBuffKey, Blackboard blackboard, Deck.Card card, Deck.Card.CardBuff.LifeType lifeType, bool isRatio)
		{
			return null;
		}

		// Token: 0x0600D454 RID: 54356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D454")]
		[Address(RVA = "0x3540CC0", Offset = "0x353F8C0", VA = "0x183540CC0")]
		public Deck.Card.CardBuff CreateCardBuffWithBlackboard(Buff sourceBuff, Blackboard blackboard, Deck.Card card, Deck.Card.CardBuff.LifeType lifeType, bool isRatio, [Optional] string key)
		{
			return null;
		}

		// Token: 0x0600D455 RID: 54357 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D455")]
		[Address(RVA = "0x3540690", Offset = "0x353F290", VA = "0x183540690")]
		public Deck.Card.CardBuff CreateCardBuffByCardWithBlackboard(Deck.Card sourceCard, Blackboard blackboard, Deck.Card card, Deck.Card.CardBuff.LifeType lifeType, bool isRatio, [Optional] string key)
		{
			return null;
		}

		// Token: 0x0600D456 RID: 54358 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D456")]
		[Address(RVA = "0x353ED60", Offset = "0x353D960", VA = "0x18353ED60")]
		public void AddDeckBuff(Deck.Card card, DeckBuff deckBuff, Blackboard nullableBlackboard)
		{
		}

		// Token: 0x0600D457 RID: 54359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D457")]
		[Address(RVA = "0x355ECD0", Offset = "0x355D8D0", VA = "0x18355ECD0")]
		private void _SwitchState(BattleController.State newState, BattleController.State oldState)
		{
		}

		// Token: 0x0600D458 RID: 54360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D458")]
		[Address(RVA = "0x355E6D0", Offset = "0x355D2D0", VA = "0x18355E6D0")]
		private void _RegisterModules()
		{
		}

		// Token: 0x0600D459 RID: 54361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D459")]
		[Address(RVA = "0x355F2E0", Offset = "0x355DEE0", VA = "0x18355F2E0")]
		private void _UpdateGameInfo(FP deltaTime)
		{
		}

		// Token: 0x0600D45A RID: 54362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D45A")]
		[Address(RVA = "0x355EDE0", Offset = "0x355D9E0", VA = "0x18355EDE0")]
		private void _UpdateCost(FP fixedDeltaTime, PlayerSide side)
		{
		}

		// Token: 0x0600D45B RID: 54363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D45B")]
		[Address(RVA = "0x355F400", Offset = "0x355E000", VA = "0x18355F400")]
		private void _UpdatePlayerOrReplayInput()
		{
		}

		// Token: 0x0600D45C RID: 54364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D45C")]
		[Address(RVA = "0x355A720", Offset = "0x3559320", VA = "0x18355A720")]
		private void _LoadGameInternal(List<BattlePlayerData> playerDataList, LevelData levelData, MapData mapData, LevelData.Difficulty difficulty, int randomSeed)
		{
		}

		// Token: 0x0600D45D RID: 54365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D45D")]
		[Address(RVA = "0x3549AB0", Offset = "0x35486B0", VA = "0x183549AB0")]
		public void LoadGameWithRune(List<BattlePlayerData> playerDataList, LevelData levelData, MapData mapData, LevelData.Difficulty difficulty, IRuneDataHolder runeInput, out LevelData.Options levelOptions, out Rune.RuneLevelExtraOutput runeExtraData)
		{
		}

		// Token: 0x0600D45E RID: 54366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D45E")]
		[Address(RVA = "0x35593B0", Offset = "0x3557FB0", VA = "0x1835593B0")]
		private void _GenerateDeckDict(ref List<BattlePlayerData> playerDataList, LevelData levelData)
		{
		}

		// Token: 0x0600D45F RID: 54367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D45F")]
		[Address(RVA = "0x355C6D0", Offset = "0x355B2D0", VA = "0x18355C6D0")]
		private void _MergeDeckModifiers(ref List<BattlePlayerData> playerDataList)
		{
		}

		// Token: 0x0600D460 RID: 54368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D460")]
		[Address(RVA = "0x355D7D0", Offset = "0x355C3D0", VA = "0x18355D7D0")]
		private void _PostProcessCharacters()
		{
		}

		// Token: 0x0600D461 RID: 54369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D461")]
		[Address(RVA = "0x3559BC0", Offset = "0x35587C0", VA = "0x183559BC0")]
		private void _InitCameraAndMapEffects(MapData mapData, Map map, IList<GridPosition> extraDisableLocations)
		{
		}

		// Token: 0x0600D462 RID: 54370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D462")]
		[Address(RVA = "0x3559AA0", Offset = "0x35586A0", VA = "0x183559AA0")]
		private string _GetFinalCameraEffect(string originCameraEffect)
		{
			return null;
		}

		// Token: 0x0600D463 RID: 54371 RVA: 0x0004CB78 File Offset: 0x0004AD78
		[Token(Token = "0x600D463")]
		[Address(RVA = "0x3557DD0", Offset = "0x35569D0", VA = "0x183557DD0")]
		private bool _DoApplyGlobalModifier(ref Modifier modifier, Entity source)
		{
			return default(bool);
		}

		// Token: 0x0600D464 RID: 54372 RVA: 0x0004CB90 File Offset: 0x0004AD90
		[Token(Token = "0x600D464")]
		[Address(RVA = "0x3556AA0", Offset = "0x35556A0", VA = "0x183556AA0")]
		private bool _ApplyGlobalModifier(ref Modifier modifier, Entity source)
		{
			return default(bool);
		}

		// Token: 0x0600D465 RID: 54373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D465")]
		[Address(RVA = "0x355CC50", Offset = "0x355B850", VA = "0x18355CC50")]
		private void _OnApplyingGlobalModifier(ref Modifier modifier)
		{
		}

		// Token: 0x0600D466 RID: 54374 RVA: 0x0004CBA8 File Offset: 0x0004ADA8
		[Token(Token = "0x600D466")]
		[Address(RVA = "0x355A130", Offset = "0x3558D30", VA = "0x18355A130")]
		private bool _InitPostprocessSettings(CameraController.PostprocessMask mask)
		{
			return default(bool);
		}

		// Token: 0x0600D467 RID: 54375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D467")]
		[Address(RVA = "0x355B900", Offset = "0x355A500", VA = "0x18355B900")]
		private void _LoadPools()
		{
		}

		// Token: 0x0600D468 RID: 54376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D468")]
		[Address(RVA = "0x353F200", Offset = "0x353DE00", VA = "0x18353F200", Slot = "6")]
		protected override void Awake()
		{
		}

		// Token: 0x0600D469 RID: 54377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D469")]
		[Address(RVA = "0x3556570", Offset = "0x3555170", VA = "0x183556570")]
		private void Update()
		{
		}

		// Token: 0x0600D46A RID: 54378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D46A")]
		[Address(RVA = "0x35472B0", Offset = "0x3545EB0", VA = "0x1835472B0")]
		private void FixedUpdate()
		{
		}

		// Token: 0x0600D46B RID: 54379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D46B")]
		[Address(RVA = "0x354E350", Offset = "0x354CF50", VA = "0x18354E350")]
		protected void OnTick()
		{
		}

		// Token: 0x0600D46C RID: 54380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D46C")]
		[Address(RVA = "0x354DBF0", Offset = "0x354C7F0", VA = "0x18354DBF0", Slot = "4")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600D46D RID: 54381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D46D")]
		[Address(RVA = "0x35495A0", Offset = "0x35481A0", VA = "0x1835495A0")]
		public static IEnumerator LiteDisposeBattle(Coroutine showMaskCoro, LatchUtils.InvokeWhenUnlock enableNextScene)
		{
			return null;
		}

		// Token: 0x0600D46E RID: 54382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D46E")]
		[Address(RVA = "0x353F980", Offset = "0x353E580", VA = "0x18353F980")]
		private void ClearTweensIfNecessary()
		{
		}

		// Token: 0x0600D46F RID: 54383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D46F")]
		[Address(RVA = "0x3557270", Offset = "0x3555E70", VA = "0x183557270")]
		private void _ClearStaticVariables()
		{
		}

		// Token: 0x0600D470 RID: 54384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D470")]
		[Address(RVA = "0x354CB50", Offset = "0x354B750", VA = "0x18354CB50", Slot = "7")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600D471 RID: 54385 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D471")]
		public TSingleton GetOrCreateSingleton<TSingleton, THost>(Func<TSingleton> creator) where TSingleton : class where THost : SingletonMonoBehaviour<THost>, ISingletonMonoHost
		{
			return null;
		}

		// Token: 0x0400E220 RID: 57888
		[Token(Token = "0x400E220")]
		[NonSerialized]
		public const int INITIAL_OBJECT_CAPACITY = 1024;

		// Token: 0x0400E221 RID: 57889
		[Token(Token = "0x400E221")]
		[NonSerialized]
		public const int INITIAL_BUFF_PRELOAD_CNT = 100;

		// Token: 0x0400E222 RID: 57890
		[Token(Token = "0x400E222")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static GameModeMeta s_cachedModeMeta;

		// Token: 0x0400E225 RID: 57893
		[Token(Token = "0x400E225")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
		private static uint s_fixedFrameCnt;

		// Token: 0x0400E226 RID: 57894
		[Token(Token = "0x400E226")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static FP s_fixedPlayTime;

		// Token: 0x0400E227 RID: 57895
		[Token(Token = "0x400E227")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static FP s_fixedPlayTimeIgnored;

		// Token: 0x0400E228 RID: 57896
		[Token(Token = "0x400E228")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static float s_fixedPlayTimeFloat;

		// Token: 0x0400E229 RID: 57897
		[Token(Token = "0x400E229")]
		private const RandomFactory.AlgorithmType RANDOM_ALGORITHM = RandomFactory.AlgorithmType.DEFAULT;

		// Token: 0x0400E22A RID: 57898
		[Token(Token = "0x400E22A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static System.Random s_randomImp;

		// Token: 0x0400E22B RID: 57899
		[Token(Token = "0x400E22B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static System.Random s_randomTrivial;

		// Token: 0x0400E22C RID: 57900
		[Token(Token = "0x400E22C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static uint s_battleUidCounter;

		// Token: 0x0400E22D RID: 57901
		[Token(Token = "0x400E22D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static FP s_deltaPlayTimeFP;

		// Token: 0x0400E22E RID: 57902
		[Token(Token = "0x400E22E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		public static int s_buildCountInOneFrame;

		// Token: 0x0400E22F RID: 57903
		[Token(Token = "0x400E22F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static ListPool<Entity> s_entityListPool;

		// Token: 0x0400E230 RID: 57904
		[Token(Token = "0x400E230")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static ListPool<Projectile> s_projectileListPool;

		// Token: 0x0400E231 RID: 57905
		[Token(Token = "0x400E231")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ListDict<uint, List<ObjectPtr<Buff>>> m_delayToRecycleBuffContainer;

		// Token: 0x0400E232 RID: 57906
		[Token(Token = "0x400E232")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Map _map;

		// Token: 0x0400E233 RID: 57907
		[Token(Token = "0x400E233")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Scheduler _scheduler;

		// Token: 0x0400E234 RID: 57908
		[Token(Token = "0x400E234")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BattleFactory _factory;

		// Token: 0x0400E235 RID: 57909
		[Token(Token = "0x400E235")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GridRangeDrawer _gridRangeDrawer;

		// Token: 0x0400E236 RID: 57910
		[Token(Token = "0x400E236")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Transform _dragPlane;

		// Token: 0x0400E237 RID: 57911
		[Token(Token = "0x400E237")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Collection(typeof(PredefinedLocation), Sortable = false)]
		private Transform[] _predefinedLocations;

		// Token: 0x0400E238 RID: 57912
		[Token(Token = "0x400E238")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private List<IBattleModule> m_modules;

		// Token: 0x0400E239 RID: 57913
		[Token(Token = "0x400E239")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private EventPool<BattleEvent> m_eventPool;

		// Token: 0x0400E23A RID: 57914
		[Token(Token = "0x400E23A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private List<GlobalBuff> m_globalBuffs;

		// Token: 0x0400E23B RID: 57915
		[Token(Token = "0x400E23B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private GlobalEnvSystemController m_globalEnvSystemController;

		// Token: 0x0400E23C RID: 57916
		[Token(Token = "0x400E23C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private ObjectManager m_objectManger;

		// Token: 0x0400E23D RID: 57917
		[Token(Token = "0x400E23D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private BattleBGMManager m_bgmManager;

		// Token: 0x0400E23E RID: 57918
		[Token(Token = "0x400E23E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private Context m_context;

		// Token: 0x0400E23F RID: 57919
		[Token(Token = "0x400E23F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private ObjectPool<Buff> m_buffPool;

		// Token: 0x0400E240 RID: 57920
		[Token(Token = "0x400E240")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private ObjectPool<Deck.Card.DeckBuffWrapper> m_deckBuffPool;

		// Token: 0x0400E241 RID: 57921
		[Token(Token = "0x400E241")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private ObjectPool<CachePointData> m_cachePointPool;

		// Token: 0x0400E242 RID: 57922
		[Token(Token = "0x400E242")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private readonly List<PlayerSide> m_sortedActivePlayers;

		// Token: 0x0400E243 RID: 57923
		[Token(Token = "0x400E243")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private readonly ListDict<PlayerSide, Deck> m_deckDict;

		// Token: 0x0400E244 RID: 57924
		[Token(Token = "0x400E244")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private float m_originCostIncreaseTime;

		// Token: 0x0400E245 RID: 57925
		[Token(Token = "0x400E245")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private readonly ListDict<PlayerSide, ObscuredInt> m_costDict;

		// Token: 0x0400E246 RID: 57926
		[Token(Token = "0x400E246")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private readonly ListDict<PlayerSide, PrecisePeriodicTimer> m_costTimerDict;

		// Token: 0x0400E247 RID: 57927
		[Token(Token = "0x400E247")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private readonly ListDict<PlayerSide, ObscuredInt> m_lifePointDict;

		// Token: 0x0400E248 RID: 57928
		[Token(Token = "0x400E248")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private readonly ListDict<PlayerSide, ObscuredInt> m_characterLimitDict;

		// Token: 0x0400E249 RID: 57929
		[Token(Token = "0x400E249")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private readonly List<IPhysicObject> m_physicObjects;

		// Token: 0x0400E24A RID: 57930
		[Token(Token = "0x400E24A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private readonly ListDict<PlayerSide, PriorityQueue<BattleController.CostTimerModifier>> m_costTimerModifiers;

		// Token: 0x0400E24B RID: 57931
		[Token(Token = "0x400E24B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool m_costAddLocked;

		// Token: 0x0400E24C RID: 57932
		[Token(Token = "0x400E24C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private readonly ListDict<PlayerSide, ObscuredInt> m_tempLifePointDict;

		// Token: 0x0400E24D RID: 57933
		[Token(Token = "0x400E24D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private BattleLogger m_logger;

		// Token: 0x0400E24E RID: 57934
		[Token(Token = "0x400E24E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		[Inspect(InspectorLevel.Debug)]
		[ReadOnly]
		private BattleController.ReplayController m_replayController;

		// Token: 0x0400E24F RID: 57935
		[Token(Token = "0x400E24F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private BattleAttackRangeController m_attackRangeController;

		// Token: 0x0400E250 RID: 57936
		[Token(Token = "0x400E250")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private LevelData.PredefinedData m_predefines;

		// Token: 0x0400E251 RID: 57937
		[Token(Token = "0x400E251")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private RuneManager m_runeManager;

		// Token: 0x0400E252 RID: 57938
		[Token(Token = "0x400E252")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private SpineShaderManager m_spineShaderManager;

		// Token: 0x0400E253 RID: 57939
		[Token(Token = "0x400E253")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private BattleController.PlayerOperationQueue m_playerOpQueue;

		// Token: 0x0400E254 RID: 57940
		[Token(Token = "0x400E254")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private bool m_additionalFrame;

		// Token: 0x0400E255 RID: 57941
		[Token(Token = "0x400E255")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private FixedEventHandler<IPtrObject> m_fixedEventHandler;

		// Token: 0x0400E256 RID: 57942
		[Token(Token = "0x400E256")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private Action m_pendingGameReadyCallbacks;

		// Token: 0x0400E257 RID: 57943
		[Token(Token = "0x400E257")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private CoroutineSimulator m_coroutineSimulator;

		// Token: 0x0400E258 RID: 57944
		[Token(Token = "0x400E258")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private HashCodeBuilder m_hashCodeBuilder;

		// Token: 0x0400E259 RID: 57945
		[Token(Token = "0x400E259")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private StringBuilder m_snapshotBuilder;

		// Token: 0x0400E25A RID: 57946
		[Token(Token = "0x400E25A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private StringBuilder m_playerOperationBuilder;

		// Token: 0x0400E25B RID: 57947
		[Token(Token = "0x400E25B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private BattleTweenMgr m_battleTweenMgr;

		// Token: 0x0400E25C RID: 57948
		[Token(Token = "0x400E25C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private LevelData m_levelData;

		// Token: 0x0400E25D RID: 57949
		[Token(Token = "0x400E25D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private MapData m_mapData;

		// Token: 0x0400E25E RID: 57950
		[Token(Token = "0x400E25E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private List<BattlePlayerData> m_playerDataList;

		// Token: 0x0400E25F RID: 57951
		[Token(Token = "0x400E25F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private IGameMode m_gameMode;

		// Token: 0x0400E260 RID: 57952
		[Token(Token = "0x400E260")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private ObscuredInt m_randomSeed;

		// Token: 0x0400E261 RID: 57953
		[Token(Token = "0x400E261")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private ClientAntiCheatChecker m_antiCheatChecker;

		// Token: 0x0400E262 RID: 57954
		[Token(Token = "0x400E262")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private OperaController m_operaController;

		// Token: 0x0400E263 RID: 57955
		[Token(Token = "0x400E263")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private ObjectPtr<Effect> m_operaHoldEffect;

		// Token: 0x0400E264 RID: 57956
		[Token(Token = "0x400E264")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private Action m_tick;

		// Token: 0x0400E265 RID: 57957
		[Token(Token = "0x400E265")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private DialogController m_dialogController;

		// Token: 0x0400E266 RID: 57958
		[Token(Token = "0x400E266")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private BattleSpineOutlineManager m_spineOutlineManager;

		// Token: 0x0400E267 RID: 57959
		[Token(Token = "0x400E267")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private TPhysicManager m_physicManager;

		// Token: 0x0400E268 RID: 57960
		[Token(Token = "0x400E268")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private LevelScriptManager m_levelScriptManager;

		// Token: 0x0400E269 RID: 57961
		[Token(Token = "0x400E269")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private ActionExecutorManager m_actionExecutorManager;

		// Token: 0x0400E26A RID: 57962
		[Token(Token = "0x400E26A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private LevelScriptEventManager m_levelScriptEventManager;

		// Token: 0x0400E26B RID: 57963
		[Token(Token = "0x400E26B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private int m_slowMotionReason;

		// Token: 0x0400E26C RID: 57964
		[Token(Token = "0x400E26C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20C")]
		private int m_costLockReason;

		// Token: 0x0400E26D RID: 57965
		[Token(Token = "0x400E26D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private Action m_onGameDoFinish;

		// Token: 0x0400E26E RID: 57966
		[Token(Token = "0x400E26E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private bool m_haveGameLoaded;

		// Token: 0x0400E26F RID: 57967
		[Token(Token = "0x400E26F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private BattlePluginExternalHost m_externalPluginHost;

		// Token: 0x0400E270 RID: 57968
		[Token(Token = "0x400E270")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private bool m_buildableHighLightUpdaterDirty;

		// Token: 0x0400E271 RID: 57969
		[Token(Token = "0x400E271")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x22C")]
		private BattleController.State m_state;

		// Token: 0x0400E272 RID: 57970
		[Token(Token = "0x400E272")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private BattleController.GameResult m_result;

		// Token: 0x0400E273 RID: 57971
		[Token(Token = "0x400E273")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x234")]
		private SpeedLevel m_speedLevel;

		// Token: 0x0400E274 RID: 57972
		[Token(Token = "0x400E274")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private bool m_speedLevelSlowFlag;

		// Token: 0x0400E275 RID: 57973
		[Token(Token = "0x400E275")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x239")]
		private bool m_alwaysWinWhenFinish;

		// Token: 0x0400E276 RID: 57974
		[Token(Token = "0x400E276")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private BattleGlobalBlackboard m_globalBlackboard;

		// Token: 0x0400E277 RID: 57975
		[Token(Token = "0x400E277")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private ObscuredInt m_maxLeftPoint;

		// Token: 0x0400E278 RID: 57976
		[Token(Token = "0x400E278")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x25C")]
		private ObscuredInt m_lifePoint;

		// Token: 0x0400E279 RID: 57977
		[Token(Token = "0x400E279")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private ObscuredInt m_tempLifePoint;

		// Token: 0x0400E27A RID: 57978
		[Token(Token = "0x400E27A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private EnableStateWithKey<Consts.BattlePauseKey> m_pauseState;

		// Token: 0x0400E27B RID: 57979
		[Token(Token = "0x400E27B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private float m_originTimeScale;

		// Token: 0x0400E27C RID: 57980
		[Token(Token = "0x400E27C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x294")]
		private float m_realPlayTime;

		// Token: 0x0400E27D RID: 57981
		[Token(Token = "0x400E27D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private FP m_timeDeltaNoEnemy;

		// Token: 0x0400E27E RID: 57982
		[Token(Token = "0x400E27E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private Queue<PoolManager.ObjectConfig> m_paddingPools;

		// Token: 0x0400E27F RID: 57983
		[Token(Token = "0x400E27F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private Func<object[], bool> m_unloadCb;

		// Token: 0x0400E280 RID: 57984
		[Token(Token = "0x400E280")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private bool m_isAutoReplayOn;

		// Token: 0x0400E281 RID: 57985
		[Token(Token = "0x400E281")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B4")]
		private float m_enemyBossCountDown;

		// Token: 0x0400E282 RID: 57986
		[Token(Token = "0x400E282")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private float m_enemyBossConntDownTurnRedFloor;

		// Token: 0x0400E283 RID: 57987
		[Token(Token = "0x400E283")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2BC")]
		private float m_enemyBossConntDownTurnRedFloorVal;

		// Token: 0x0400E288 RID: 57992
		[Token(Token = "0x400E288")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2CB")]
		private bool m_isSelectCardMode;

		// Token: 0x0400E28A RID: 57994
		[Token(Token = "0x400E28A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private readonly ListDict<PlayerSide, ObscuredInt> m_lifePointLossByEnemy;

		// Token: 0x0400E28B RID: 57995
		[Token(Token = "0x400E28B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private readonly ListDict<PlayerSide, ObscuredInt> m_lifePointLossByOthers;

		// Token: 0x0400E28C RID: 57996
		[Token(Token = "0x400E28C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private BattleController.SingletonHost m_singletonHost;

		// Token: 0x0400E28D RID: 57997
		[Token(Token = "0x400E28D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_isDeterministic;

		// Token: 0x0400E28E RID: 57998
		[Token(Token = "0x400E28E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_isDeterministic;

		// Token: 0x0400E28F RID: 57999
		[Token(Token = "0x400E28F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_isOnline;

		// Token: 0x0400E290 RID: 58000
		[Token(Token = "0x400E290")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_isMultiActivePlayers;

		// Token: 0x0400E291 RID: 58001
		[Token(Token = "0x400E291")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_playerSide;

		// Token: 0x0400E292 RID: 58002
		[Token(Token = "0x400E292")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_set_playerSide;

		// Token: 0x0400E293 RID: 58003
		[Token(Token = "0x400E293")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_playerSideNext;

		// Token: 0x0400E294 RID: 58004
		[Token(Token = "0x400E294")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_sortedActivePlayers;

		// Token: 0x0400E295 RID: 58005
		[Token(Token = "0x400E295")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_playerLayer;

		// Token: 0x0400E296 RID: 58006
		[Token(Token = "0x400E296")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_get_isAtOwnLayer;

		// Token: 0x0400E297 RID: 58007
		[Token(Token = "0x400E297")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_currentLayer;

		// Token: 0x0400E298 RID: 58008
		[Token(Token = "0x400E298")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_get_isLegionMode;

		// Token: 0x0400E299 RID: 58009
		[Token(Token = "0x400E299")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_isSandBox;

		// Token: 0x0400E29A RID: 58010
		[Token(Token = "0x400E29A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_isFunLivePlayMode;

		// Token: 0x0400E29B RID: 58011
		[Token(Token = "0x400E29B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_get_isStrifeMode;

		// Token: 0x0400E29C RID: 58012
		[Token(Token = "0x400E29C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_isRacingMode;

		// Token: 0x0400E29D RID: 58013
		[Token(Token = "0x400E29D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_get_isDouququMode;

		// Token: 0x0400E29E RID: 58014
		[Token(Token = "0x400E29E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_isEnemyDuel;

		// Token: 0x0400E29F RID: 58015
		[Token(Token = "0x400E29F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_isCooperateMode;

		// Token: 0x0400E2A0 RID: 58016
		[Token(Token = "0x400E2A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_isAutoChessMode;

		// Token: 0x0400E2A1 RID: 58017
		[Token(Token = "0x400E2A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_isPvpOrSeperateMode;

		// Token: 0x0400E2A2 RID: 58018
		[Token(Token = "0x400E2A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_get_isGameCityMode;

		// Token: 0x0400E2A3 RID: 58019
		[Token(Token = "0x400E2A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_get_fixedFrameCnt;

		// Token: 0x0400E2A4 RID: 58020
		[Token(Token = "0x400E2A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_get_fixedPlayTime;

		// Token: 0x0400E2A5 RID: 58021
		[Token(Token = "0x400E2A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_get_userFixedPlayTime;

		// Token: 0x0400E2A6 RID: 58022
		[Token(Token = "0x400E2A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_get_randomImp;

		// Token: 0x0400E2A7 RID: 58023
		[Token(Token = "0x400E2A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_get_randomTrivial;

		// Token: 0x0400E2A8 RID: 58024
		[Token(Token = "0x400E2A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_GenNextUniqueId;

		// Token: 0x0400E2A9 RID: 58025
		[Token(Token = "0x400E2A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_AllocateEntityList_DISPOSE;

		// Token: 0x0400E2AA RID: 58026
		[Token(Token = "0x400E2AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_AllocateProjectileList_DISPOSE;

		// Token: 0x0400E2AB RID: 58027
		[Token(Token = "0x400E2AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_get_enemyBossCountDownActivated;

		// Token: 0x0400E2AC RID: 58028
		[Token(Token = "0x400E2AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_get_enemyBossCountDown;

		// Token: 0x0400E2AD RID: 58029
		[Token(Token = "0x400E2AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_set_enemyBossCountDown;

		// Token: 0x0400E2AE RID: 58030
		[Token(Token = "0x400E2AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_get_enemyBossConntDownTurnRedFloor;

		// Token: 0x0400E2AF RID: 58031
		[Token(Token = "0x400E2AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_set_enemyBossConntDownTurnRedFloor;

		// Token: 0x0400E2B0 RID: 58032
		[Token(Token = "0x400E2B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_get_enemyBossConntDownTurnRedFloorVal;

		// Token: 0x0400E2B1 RID: 58033
		[Token(Token = "0x400E2B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_set_enemyBossConntDownTurnRedFloorVal;

		// Token: 0x0400E2B2 RID: 58034
		[Token(Token = "0x400E2B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_get_randomSeed;

		// Token: 0x0400E2B3 RID: 58035
		[Token(Token = "0x400E2B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_get_battleTweenMgr;

		// Token: 0x0400E2B4 RID: 58036
		[Token(Token = "0x400E2B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_get_attackRangeController;

		// Token: 0x0400E2B5 RID: 58037
		[Token(Token = "0x400E2B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_get_bgmManager;

		// Token: 0x0400E2B6 RID: 58038
		[Token(Token = "0x400E2B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_get_map;

		// Token: 0x0400E2B7 RID: 58039
		[Token(Token = "0x400E2B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_get_mapData;

		// Token: 0x0400E2B8 RID: 58040
		[Token(Token = "0x400E2B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_get_levelData;

		// Token: 0x0400E2B9 RID: 58041
		[Token(Token = "0x400E2B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_get_playerDataList;

		// Token: 0x0400E2BA RID: 58042
		[Token(Token = "0x400E2BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_get_shouldQueueOps;

		// Token: 0x0400E2BB RID: 58043
		[Token(Token = "0x400E2BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_get_buildableHighLightUpdaterDirty;

		// Token: 0x0400E2BC RID: 58044
		[Token(Token = "0x400E2BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_set_buildableHighLightUpdaterDirty;

		// Token: 0x0400E2BD RID: 58045
		[Token(Token = "0x400E2BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_GetDeck;

		// Token: 0x0400E2BE RID: 58046
		[Token(Token = "0x400E2BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix1_GetDeck;

		// Token: 0x0400E2BF RID: 58047
		[Token(Token = "0x400E2BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_ForeachActiveDecks;

		// Token: 0x0400E2C0 RID: 58048
		[Token(Token = "0x400E2C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_ForeachCard;

		// Token: 0x0400E2C1 RID: 58049
		[Token(Token = "0x400E2C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_get_scheduler;

		// Token: 0x0400E2C2 RID: 58050
		[Token(Token = "0x400E2C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_get_gridRangeDrawer;

		// Token: 0x0400E2C3 RID: 58051
		[Token(Token = "0x400E2C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_set_gridRangeDrawer;

		// Token: 0x0400E2C4 RID: 58052
		[Token(Token = "0x400E2C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_get_unitManager;

		// Token: 0x0400E2C5 RID: 58053
		[Token(Token = "0x400E2C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_set_unitManager;

		// Token: 0x0400E2C6 RID: 58054
		[Token(Token = "0x400E2C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_get_eventPool;

		// Token: 0x0400E2C7 RID: 58055
		[Token(Token = "0x400E2C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_get_context;

		// Token: 0x0400E2C8 RID: 58056
		[Token(Token = "0x400E2C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_get_factory;

		// Token: 0x0400E2C9 RID: 58057
		[Token(Token = "0x400E2C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_get_logger;

		// Token: 0x0400E2CA RID: 58058
		[Token(Token = "0x400E2CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_get_dragPlane;

		// Token: 0x0400E2CB RID: 58059
		[Token(Token = "0x400E2CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_get_runeManager;

		// Token: 0x0400E2CC RID: 58060
		[Token(Token = "0x400E2CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_get_buffPool;

		// Token: 0x0400E2CD RID: 58061
		[Token(Token = "0x400E2CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_get_deckBuffPool;

		// Token: 0x0400E2CE RID: 58062
		[Token(Token = "0x400E2CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0_get_cachePointPool;

		// Token: 0x0400E2CF RID: 58063
		[Token(Token = "0x400E2CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_get_replayController;

		// Token: 0x0400E2D0 RID: 58064
		[Token(Token = "0x400E2D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_get_gameMode;

		// Token: 0x0400E2D1 RID: 58065
		[Token(Token = "0x400E2D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_get_sandboxGameMode;

		// Token: 0x0400E2D2 RID: 58066
		[Token(Token = "0x400E2D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_get_cooperateGameMode;

		// Token: 0x0400E2D3 RID: 58067
		[Token(Token = "0x400E2D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_get_antiCheatChecker;

		// Token: 0x0400E2D4 RID: 58068
		[Token(Token = "0x400E2D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0_get_operaController;

		// Token: 0x0400E2D5 RID: 58069
		[Token(Token = "0x400E2D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0_get_spineShaderManager;

		// Token: 0x0400E2D6 RID: 58070
		[Token(Token = "0x400E2D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_get_spineOutlineManager;

		// Token: 0x0400E2D7 RID: 58071
		[Token(Token = "0x400E2D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_get_levelScriptManager;

		// Token: 0x0400E2D8 RID: 58072
		[Token(Token = "0x400E2D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_get_physicManager;

		// Token: 0x0400E2D9 RID: 58073
		[Token(Token = "0x400E2D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_get_actionExecutorManager;

		// Token: 0x0400E2DA RID: 58074
		[Token(Token = "0x400E2DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_get_levelScriptEventManager;

		// Token: 0x0400E2DB RID: 58075
		[Token(Token = "0x400E2DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0_get_dialogController;

		// Token: 0x0400E2DC RID: 58076
		[Token(Token = "0x400E2DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_get_objectManager;

		// Token: 0x0400E2DD RID: 58077
		[Token(Token = "0x400E2DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_get_isPlaying;

		// Token: 0x0400E2DE RID: 58078
		[Token(Token = "0x400E2DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_get_isFinished;

		// Token: 0x0400E2DF RID: 58079
		[Token(Token = "0x400E2DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0_get_isPausedOrNotPlaying;

		// Token: 0x0400E2E0 RID: 58080
		[Token(Token = "0x400E2E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0_get_isAutoReplayOn;

		// Token: 0x0400E2E1 RID: 58081
		[Token(Token = "0x400E2E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_set_isAutoReplayOn;

		// Token: 0x0400E2E2 RID: 58082
		[Token(Token = "0x400E2E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0_get_isDisableSlowMotion;

		// Token: 0x0400E2E3 RID: 58083
		[Token(Token = "0x400E2E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0_get_globalBlackboard;

		// Token: 0x0400E2E4 RID: 58084
		[Token(Token = "0x400E2E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_get_disableDragCard;

		// Token: 0x0400E2E5 RID: 58085
		[Token(Token = "0x400E2E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_set_disableDragCard;

		// Token: 0x0400E2E6 RID: 58086
		[Token(Token = "0x400E2E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_get_disableDragCardForced;

		// Token: 0x0400E2E7 RID: 58087
		[Token(Token = "0x400E2E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_set_disableDragCardForced;

		// Token: 0x0400E2E8 RID: 58088
		[Token(Token = "0x400E2E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_get_disableToggleCard;

		// Token: 0x0400E2E9 RID: 58089
		[Token(Token = "0x400E2E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0_set_disableToggleCard;

		// Token: 0x0400E2EA RID: 58090
		[Token(Token = "0x400E2EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_get_isCostLocked;

		// Token: 0x0400E2EB RID: 58091
		[Token(Token = "0x400E2EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0_get_isSelectCardMode;

		// Token: 0x0400E2EC RID: 58092
		[Token(Token = "0x400E2EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x360")]
		private static DelegateBridge __Hotfix0_set_isSelectCardMode;

		// Token: 0x0400E2ED RID: 58093
		[Token(Token = "0x400E2ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x368")]
		private static DelegateBridge __Hotfix0_get_isAdditionalFrame;

		// Token: 0x0400E2EE RID: 58094
		[Token(Token = "0x400E2EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x370")]
		private static DelegateBridge __Hotfix0_GetNumCharacterLimit;

		// Token: 0x0400E2EF RID: 58095
		[Token(Token = "0x400E2EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x378")]
		private static DelegateBridge __Hotfix0__SetNumCharacterLimit;

		// Token: 0x0400E2F0 RID: 58096
		[Token(Token = "0x400E2F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x380")]
		private static DelegateBridge __Hotfix0_get_haveGameLoaded;

		// Token: 0x0400E2F1 RID: 58097
		[Token(Token = "0x400E2F1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x388")]
		private static DelegateBridge __Hotfix0_GetRemainingAvailableCharacterCnt;

		// Token: 0x0400E2F2 RID: 58098
		[Token(Token = "0x400E2F2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x390")]
		private static DelegateBridge __Hotfix0_get_state;

		// Token: 0x0400E2F3 RID: 58099
		[Token(Token = "0x400E2F3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x398")]
		private static DelegateBridge __Hotfix0_set_state;

		// Token: 0x0400E2F4 RID: 58100
		[Token(Token = "0x400E2F4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A0")]
		private static DelegateBridge __Hotfix0_get_realPlayTime;

		// Token: 0x0400E2F5 RID: 58101
		[Token(Token = "0x400E2F5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3A8")]
		private static DelegateBridge __Hotfix0_get_timeDeltaNoEnemy;

		// Token: 0x0400E2F6 RID: 58102
		[Token(Token = "0x400E2F6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B0")]
		private static DelegateBridge __Hotfix0_get_levelId;

		// Token: 0x0400E2F7 RID: 58103
		[Token(Token = "0x400E2F7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3B8")]
		private static DelegateBridge __Hotfix0_set_levelId;

		// Token: 0x0400E2F8 RID: 58104
		[Token(Token = "0x400E2F8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C0")]
		private static DelegateBridge __Hotfix0_get_isActive;

		// Token: 0x0400E2F9 RID: 58105
		[Token(Token = "0x400E2F9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3C8")]
		private static DelegateBridge __Hotfix0_set_isActive;

		// Token: 0x0400E2FA RID: 58106
		[Token(Token = "0x400E2FA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D0")]
		private static DelegateBridge __Hotfix0_get_isPaused;

		// Token: 0x0400E2FB RID: 58107
		[Token(Token = "0x400E2FB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3D8")]
		private static DelegateBridge __Hotfix0_get_speedLevel;

		// Token: 0x0400E2FC RID: 58108
		[Token(Token = "0x400E2FC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E0")]
		private static DelegateBridge __Hotfix0_set_speedLevel;

		// Token: 0x0400E2FD RID: 58109
		[Token(Token = "0x400E2FD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3E8")]
		private static DelegateBridge __Hotfix0_get_inSlowMotion;

		// Token: 0x0400E2FE RID: 58110
		[Token(Token = "0x400E2FE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F0")]
		private static DelegateBridge __Hotfix0_get_maxLifePoint;

		// Token: 0x0400E2FF RID: 58111
		[Token(Token = "0x400E2FF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x3F8")]
		private static DelegateBridge __Hotfix0_get_alwaysWinWhenFinish;

		// Token: 0x0400E300 RID: 58112
		[Token(Token = "0x400E300")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x400")]
		private static DelegateBridge __Hotfix0_GetLifePoint;

		// Token: 0x0400E301 RID: 58113
		[Token(Token = "0x400E301")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x408")]
		private static DelegateBridge __Hotfix0_SetLifePoint;

		// Token: 0x0400E302 RID: 58114
		[Token(Token = "0x400E302")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x410")]
		private static DelegateBridge __Hotfix0_GetTempLifePoint;

		// Token: 0x0400E303 RID: 58115
		[Token(Token = "0x400E303")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x418")]
		private static DelegateBridge __Hotfix0_SetTempLifePoint;

		// Token: 0x0400E304 RID: 58116
		[Token(Token = "0x400E304")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x420")]
		private static DelegateBridge __Hotfix0_LifePointToShow;

		// Token: 0x0400E305 RID: 58117
		[Token(Token = "0x400E305")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x428")]
		private static DelegateBridge __Hotfix0_GetLifePointLossByEnemy;

		// Token: 0x0400E306 RID: 58118
		[Token(Token = "0x400E306")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x430")]
		private static DelegateBridge __Hotfix0_GetLifePointLossByOthers;

		// Token: 0x0400E307 RID: 58119
		[Token(Token = "0x400E307")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x438")]
		private static DelegateBridge __Hotfix0_MarkAlwaysWinWhenFinish;

		// Token: 0x0400E308 RID: 58120
		[Token(Token = "0x400E308")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x440")]
		private static DelegateBridge __Hotfix0_get_gameResult;

		// Token: 0x0400E309 RID: 58121
		[Token(Token = "0x400E309")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x448")]
		private static DelegateBridge __Hotfix0_get_battleRank;

		// Token: 0x0400E30A RID: 58122
		[Token(Token = "0x400E30A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x450")]
		private static DelegateBridge __Hotfix0_GetCost;

		// Token: 0x0400E30B RID: 58123
		[Token(Token = "0x400E30B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x458")]
		private static DelegateBridge __Hotfix0_SetCost;

		// Token: 0x0400E30C RID: 58124
		[Token(Token = "0x400E30C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x460")]
		private static DelegateBridge __Hotfix0_SetMaxCost;

		// Token: 0x0400E30D RID: 58125
		[Token(Token = "0x400E30D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x468")]
		private static DelegateBridge __Hotfix0_LockCostIncreasement;

		// Token: 0x0400E30E RID: 58126
		[Token(Token = "0x400E30E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x470")]
		private static DelegateBridge __Hotfix0_GetCostTimer;

		// Token: 0x0400E30F RID: 58127
		[Token(Token = "0x400E30F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x478")]
		private static DelegateBridge __Hotfix0_GetCostTimerProgress;

		// Token: 0x0400E310 RID: 58128
		[Token(Token = "0x400E310")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x480")]
		private static DelegateBridge __Hotfix1_GetCostTimerProgress;

		// Token: 0x0400E311 RID: 58129
		[Token(Token = "0x400E311")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x488")]
		private static DelegateBridge __Hotfix0_get_costTimerPeriodTime;

		// Token: 0x0400E312 RID: 58130
		[Token(Token = "0x400E312")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x490")]
		private static DelegateBridge __Hotfix0_get_remainingEnemiesCnt;

		// Token: 0x0400E313 RID: 58131
		[Token(Token = "0x400E313")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x498")]
		private static DelegateBridge __Hotfix0_get_completeProgress;

		// Token: 0x0400E314 RID: 58132
		[Token(Token = "0x400E314")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A0")]
		private static DelegateBridge __Hotfix0_get_enablePause;

		// Token: 0x0400E315 RID: 58133
		[Token(Token = "0x400E315")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4A8")]
		private static DelegateBridge __Hotfix0_get_timeScale;

		// Token: 0x0400E316 RID: 58134
		[Token(Token = "0x400E316")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B0")]
		private static DelegateBridge __Hotfix0_set_timeScale;

		// Token: 0x0400E317 RID: 58135
		[Token(Token = "0x400E317")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4B8")]
		private static DelegateBridge __Hotfix0_get_deltaPlayTimeFP;

		// Token: 0x0400E318 RID: 58136
		[Token(Token = "0x400E318")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C0")]
		private static DelegateBridge __Hotfix0_get_deltaPlayTime;

		// Token: 0x0400E319 RID: 58137
		[Token(Token = "0x400E319")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4C8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0400E31A RID: 58138
		[Token(Token = "0x400E31A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D0")]
		private static DelegateBridge __Hotfix0_SetPaused;

		// Token: 0x0400E31B RID: 58139
		[Token(Token = "0x400E31B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4D8")]
		private static DelegateBridge __Hotfix0_OnTileClicked;

		// Token: 0x0400E31C RID: 58140
		[Token(Token = "0x400E31C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E0")]
		private static DelegateBridge __Hotfix0_SetTimeScale_DialogControllerOnly;

		// Token: 0x0400E31D RID: 58141
		[Token(Token = "0x400E31D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4E8")]
		private static DelegateBridge __Hotfix0_LoadGame;

		// Token: 0x0400E31E RID: 58142
		[Token(Token = "0x400E31E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F0")]
		private static DelegateBridge __Hotfix0_LoadAutoReplayGame;

		// Token: 0x0400E31F RID: 58143
		[Token(Token = "0x400E31F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x4F8")]
		private static DelegateBridge __Hotfix0_StartGame;

		// Token: 0x0400E320 RID: 58144
		[Token(Token = "0x400E320")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x500")]
		private static DelegateBridge __Hotfix0_ResetAll;

		// Token: 0x0400E321 RID: 58145
		[Token(Token = "0x400E321")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x508")]
		private static DelegateBridge __Hotfix0_FinishGame;

		// Token: 0x0400E322 RID: 58146
		[Token(Token = "0x400E322")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x510")]
		private static DelegateBridge __Hotfix0__DoFinishGame;

		// Token: 0x0400E323 RID: 58147
		[Token(Token = "0x400E323")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x518")]
		private static DelegateBridge __Hotfix0_GiveUpGame;

		// Token: 0x0400E324 RID: 58148
		[Token(Token = "0x400E324")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x520")]
		private static DelegateBridge __Hotfix0_LoadCamera;

		// Token: 0x0400E325 RID: 58149
		[Token(Token = "0x400E325")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x528")]
		private static DelegateBridge __Hotfix0__PreLoadGameInternal;

		// Token: 0x0400E326 RID: 58150
		[Token(Token = "0x400E326")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x530")]
		private static DelegateBridge __Hotfix0_ModifyCost;

		// Token: 0x0400E327 RID: 58151
		[Token(Token = "0x400E327")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x538")]
		private static DelegateBridge __Hotfix0_ModifyCostIncreaseTime;

		// Token: 0x0400E328 RID: 58152
		[Token(Token = "0x400E328")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x540")]
		private static DelegateBridge __Hotfix0_AddCostTimerModifier;

		// Token: 0x0400E329 RID: 58153
		[Token(Token = "0x400E329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x548")]
		private static DelegateBridge __Hotfix0_RemoveCostTimerModifier;

		// Token: 0x0400E32A RID: 58154
		[Token(Token = "0x400E32A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x550")]
		private static DelegateBridge __Hotfix0__RefreshCostTimerModifier;

		// Token: 0x0400E32B RID: 58155
		[Token(Token = "0x400E32B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x558")]
		private static DelegateBridge __Hotfix0_SetCostIncreaseTime;

		// Token: 0x0400E32C RID: 58156
		[Token(Token = "0x400E32C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x560")]
		private static DelegateBridge __Hotfix0_ModifyMaxCost;

		// Token: 0x0400E32D RID: 58157
		[Token(Token = "0x400E32D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x568")]
		private static DelegateBridge __Hotfix0_ModifyLegionGold;

		// Token: 0x0400E32E RID: 58158
		[Token(Token = "0x400E32E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x570")]
		private static DelegateBridge __Hotfix0_ModifyCharacterLimit;

		// Token: 0x0400E32F RID: 58159
		[Token(Token = "0x400E32F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x578")]
		private static DelegateBridge __Hotfix0_ModifyLifePoint;

		// Token: 0x0400E330 RID: 58160
		[Token(Token = "0x400E330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x580")]
		private static DelegateBridge __Hotfix0_AddTempLifePoint;

		// Token: 0x0400E331 RID: 58161
		[Token(Token = "0x400E331")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x588")]
		private static DelegateBridge __Hotfix0_EnsureMinCost;

		// Token: 0x0400E332 RID: 58162
		[Token(Token = "0x400E332")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x590")]
		private static DelegateBridge __Hotfix0_PlayAudioSignal;

		// Token: 0x0400E333 RID: 58163
		[Token(Token = "0x400E333")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x598")]
		private static DelegateBridge __Hotfix0_PlayBAVGAudioSignal;

		// Token: 0x0400E334 RID: 58164
		[Token(Token = "0x400E334")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A0")]
		private static DelegateBridge __Hotfix0_EnableBuildableHighlight;

		// Token: 0x0400E335 RID: 58165
		[Token(Token = "0x400E335")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5A8")]
		private static DelegateBridge __Hotfix1_EnableBuildableHighlight;

		// Token: 0x0400E336 RID: 58166
		[Token(Token = "0x400E336")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B0")]
		private static DelegateBridge __Hotfix0_DisableBuildableHighlight;

		// Token: 0x0400E337 RID: 58167
		[Token(Token = "0x400E337")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5B8")]
		private static DelegateBridge __Hotfix0__ChangeTileHighlightType;

		// Token: 0x0400E338 RID: 58168
		[Token(Token = "0x400E338")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C0")]
		private static DelegateBridge __Hotfix0__ChangeOverlapTargetColor;

		// Token: 0x0400E339 RID: 58169
		[Token(Token = "0x400E339")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5C8")]
		private static DelegateBridge __Hotfix0_GetPredefinedLocationPosition;

		// Token: 0x0400E33A RID: 58170
		[Token(Token = "0x400E33A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D0")]
		private static DelegateBridge __Hotfix0_TryGetCardPositionByUI;

		// Token: 0x0400E33B RID: 58171
		[Token(Token = "0x400E33B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5D8")]
		private static DelegateBridge __Hotfix0_ScreenPointToWorldPositionAtMapHeight;

		// Token: 0x0400E33C RID: 58172
		[Token(Token = "0x400E33C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E0")]
		private static DelegateBridge __Hotfix0_GetEnvSystemByKey;

		// Token: 0x0400E33D RID: 58173
		[Token(Token = "0x400E33D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5E8")]
		private static DelegateBridge __Hotfix0_TryGetEnvSystemByKey;

		// Token: 0x0400E33E RID: 58174
		[Token(Token = "0x400E33E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F0")]
		private static DelegateBridge __Hotfix0_GetEnvSystemManager;

		// Token: 0x0400E33F RID: 58175
		[Token(Token = "0x400E33F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x5F8")]
		private static DelegateBridge __Hotfix0_GetEnvSystemManagerByKey;

		// Token: 0x0400E340 RID: 58176
		[Token(Token = "0x400E340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x600")]
		private static DelegateBridge __Hotfix0_GetEnvSystemManagerByKeyNullable;

		// Token: 0x0400E341 RID: 58177
		[Token(Token = "0x400E341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x608")]
		private static DelegateBridge __Hotfix0_TryGetEnvSystemManagerByKey;

		// Token: 0x0400E342 RID: 58178
		[Token(Token = "0x400E342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x610")]
		private static DelegateBridge __Hotfix0_SetRuntimeMapTag;

		// Token: 0x0400E343 RID: 58179
		[Token(Token = "0x400E343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x618")]
		private static DelegateBridge __Hotfix0_ContainsMapTag;

		// Token: 0x0400E344 RID: 58180
		[Token(Token = "0x400E344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x620")]
		private static DelegateBridge __Hotfix0_ContainsOneOfMapTag;

		// Token: 0x0400E345 RID: 58181
		[Token(Token = "0x400E345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x628")]
		private static DelegateBridge __Hotfix0_ActivateInternalHiddenCard;

		// Token: 0x0400E346 RID: 58182
		[Token(Token = "0x400E346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x630")]
		private static DelegateBridge __Hotfix0_RefreshDeck;

		// Token: 0x0400E347 RID: 58183
		[Token(Token = "0x400E347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x638")]
		private static DelegateBridge __Hotfix0_ResetSeed;

		// Token: 0x0400E348 RID: 58184
		[Token(Token = "0x400E348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x640")]
		private static DelegateBridge __Hotfix1_ResetSeed;

		// Token: 0x0400E349 RID: 58185
		[Token(Token = "0x400E349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x648")]
		private static DelegateBridge __Hotfix0_CriticalAlertAndForceExit;

		// Token: 0x0400E34A RID: 58186
		[Token(Token = "0x400E34A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x650")]
		private static DelegateBridge __Hotfix0_PaddingPreload;

		// Token: 0x0400E34B RID: 58187
		[Token(Token = "0x400E34B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x658")]
		private static DelegateBridge __Hotfix0_ClearPadding;

		// Token: 0x0400E34C RID: 58188
		[Token(Token = "0x400E34C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x660")]
		private static DelegateBridge __Hotfix0_IsPadding;

		// Token: 0x0400E34D RID: 58189
		[Token(Token = "0x400E34D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x668")]
		private static DelegateBridge __Hotfix0_TrigOrQueueFixedEntityEvent;

		// Token: 0x0400E34E RID: 58190
		[Token(Token = "0x400E34E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x670")]
		private static DelegateBridge __Hotfix0_TrigOrQueueFixedPtrEvent;

		// Token: 0x0400E34F RID: 58191
		[Token(Token = "0x400E34F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x678")]
		private static DelegateBridge __Hotfix0_TryGetDeckBuffFromGlobalBuff;

		// Token: 0x0400E350 RID: 58192
		[Token(Token = "0x400E350")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x680")]
		private static DelegateBridge __Hotfix0_ManualFrameTick;

		// Token: 0x0400E351 RID: 58193
		[Token(Token = "0x400E351")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x688")]
		private static DelegateBridge __Hotfix0_LoadPredefinedData;

		// Token: 0x0400E352 RID: 58194
		[Token(Token = "0x400E352")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x690")]
		private static DelegateBridge __Hotfix0_ReDoPostInit;

		// Token: 0x0400E353 RID: 58195
		[Token(Token = "0x400E353")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x698")]
		private static DelegateBridge __Hotfix0_BattleInitializerOnly_EarlyInit;

		// Token: 0x0400E354 RID: 58196
		[Token(Token = "0x400E354")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A0")]
		private static DelegateBridge __Hotfix0_RegisterBObject;

		// Token: 0x0400E355 RID: 58197
		[Token(Token = "0x400E355")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6A8")]
		private static DelegateBridge __Hotfix0_UnregisterBObject;

		// Token: 0x0400E356 RID: 58198
		[Token(Token = "0x400E356")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B0")]
		private static DelegateBridge __Hotfix0_RegisterUnit;

		// Token: 0x0400E357 RID: 58199
		[Token(Token = "0x400E357")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6B8")]
		private static DelegateBridge __Hotfix0_OnRallyPointLikeReborn;

		// Token: 0x0400E358 RID: 58200
		[Token(Token = "0x400E358")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C0")]
		private static DelegateBridge __Hotfix0_OnEnemyRebornAfterFakeDeath;

		// Token: 0x0400E359 RID: 58201
		[Token(Token = "0x400E359")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6C8")]
		private static DelegateBridge __Hotfix0_OnTokenCategoryChanged;

		// Token: 0x0400E35A RID: 58202
		[Token(Token = "0x400E35A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D0")]
		private static DelegateBridge __Hotfix0_UnregisterUnit;

		// Token: 0x0400E35B RID: 58203
		[Token(Token = "0x400E35B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6D8")]
		private static DelegateBridge __Hotfix0_RegisterModule;

		// Token: 0x0400E35C RID: 58204
		[Token(Token = "0x400E35C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E0")]
		private static DelegateBridge __Hotfix0_UnregisterModule;

		// Token: 0x0400E35D RID: 58205
		[Token(Token = "0x400E35D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6E8")]
		private static DelegateBridge __Hotfix0_RegisterMustInvokeGameReadyCallback;

		// Token: 0x0400E35E RID: 58206
		[Token(Token = "0x400E35E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F0")]
		private static DelegateBridge __Hotfix0_PlayerOp_Withdraw;

		// Token: 0x0400E35F RID: 58207
		[Token(Token = "0x400E35F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x6F8")]
		private static DelegateBridge __Hotfix0_PlayerOp_Spawn;

		// Token: 0x0400E360 RID: 58208
		[Token(Token = "0x400E360")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x700")]
		private static DelegateBridge __Hotfix0_PlayerOp_TrigSkill;

		// Token: 0x0400E361 RID: 58209
		[Token(Token = "0x400E361")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x708")]
		private static DelegateBridge __Hotfix0_SpawnPredefinedInstanceByAlias;

		// Token: 0x0400E362 RID: 58210
		[Token(Token = "0x400E362")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x710")]
		private static DelegateBridge __Hotfix0_SpawnPredefinedInstance;

		// Token: 0x0400E363 RID: 58211
		[Token(Token = "0x400E363")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x718")]
		private static DelegateBridge __Hotfix1_SpawnPredefinedInstanceByAlias;

		// Token: 0x0400E364 RID: 58212
		[Token(Token = "0x400E364")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x720")]
		private static DelegateBridge __Hotfix0_WithdrawPredefinedInstByAlias;

		// Token: 0x0400E365 RID: 58213
		[Token(Token = "0x400E365")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x728")]
		private static DelegateBridge __Hotfix0_SpawnPredefinedInstanceWithTile;

		// Token: 0x0400E366 RID: 58214
		[Token(Token = "0x400E366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x730")]
		private static DelegateBridge __Hotfix0_IsPredefinedAndNeedToTakeSnapshot;

		// Token: 0x0400E367 RID: 58215
		[Token(Token = "0x400E367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x738")]
		private static DelegateBridge __Hotfix0_GetPredefineCharacter;

		// Token: 0x0400E368 RID: 58216
		[Token(Token = "0x400E368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x740")]
		private static DelegateBridge __Hotfix0_IsPredefinedAssistCharacter;

		// Token: 0x0400E369 RID: 58217
		[Token(Token = "0x400E369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x748")]
		private static DelegateBridge __Hotfix0_SpawnTokenBySkillFreely;

		// Token: 0x0400E36A RID: 58218
		[Token(Token = "0x400E36A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x750")]
		private static DelegateBridge __Hotfix0__SpawnInternal;

		// Token: 0x0400E36B RID: 58219
		[Token(Token = "0x400E36B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x758")]
		private static DelegateBridge __Hotfix1__SpawnInternal;

		// Token: 0x0400E36C RID: 58220
		[Token(Token = "0x400E36C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x760")]
		private static DelegateBridge __Hotfix0__WithdrawInternal;

		// Token: 0x0400E36D RID: 58221
		[Token(Token = "0x400E36D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x768")]
		private static DelegateBridge __Hotfix1__WithdrawInternal;

		// Token: 0x0400E36E RID: 58222
		[Token(Token = "0x400E36E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x770")]
		private static DelegateBridge __Hotfix0__OpTrigSkillInternal;

		// Token: 0x0400E36F RID: 58223
		[Token(Token = "0x400E36F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x778")]
		private static DelegateBridge __Hotfix1__OpTrigSkillInternal;

		// Token: 0x0400E370 RID: 58224
		[Token(Token = "0x400E370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x780")]
		private static DelegateBridge __Hotfix0__FindCharacterBySignitureAndPos;

		// Token: 0x0400E371 RID: 58225
		[Token(Token = "0x400E371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x788")]
		private static DelegateBridge __Hotfix0__FindCharacterByIdAndPos;

		// Token: 0x0400E372 RID: 58226
		[Token(Token = "0x400E372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x790")]
		private static DelegateBridge __Hotfix0_CreatePreviewCursor;

		// Token: 0x0400E373 RID: 58227
		[Token(Token = "0x400E373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x798")]
		private static DelegateBridge __Hotfix0_CreateEnemy;

		// Token: 0x0400E374 RID: 58228
		[Token(Token = "0x400E374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A0")]
		private static DelegateBridge __Hotfix1_CreateEnemy;

		// Token: 0x0400E375 RID: 58229
		[Token(Token = "0x400E375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7A8")]
		private static DelegateBridge __Hotfix0_CreateCharacter;

		// Token: 0x0400E376 RID: 58230
		[Token(Token = "0x400E376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B0")]
		private static DelegateBridge __Hotfix0_CreateToken;

		// Token: 0x0400E377 RID: 58231
		[Token(Token = "0x400E377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7B8")]
		private static DelegateBridge __Hotfix0_CreateNpc;

		// Token: 0x0400E378 RID: 58232
		[Token(Token = "0x400E378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C0")]
		private static DelegateBridge __Hotfix0_CreateRuntimeInst;

		// Token: 0x0400E379 RID: 58233
		[Token(Token = "0x400E379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7C8")]
		private static DelegateBridge __Hotfix0_CreateRuntimeInstance;

		// Token: 0x0400E37A RID: 58234
		[Token(Token = "0x400E37A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D0")]
		private static DelegateBridge __Hotfix1_CreateRuntimeInstance;

		// Token: 0x0400E37B RID: 58235
		[Token(Token = "0x400E37B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7D8")]
		private static DelegateBridge __Hotfix0_CreateProjectile;

		// Token: 0x0400E37C RID: 58236
		[Token(Token = "0x400E37C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E0")]
		private static DelegateBridge __Hotfix0_CreateProjectileUseSourceAsProjectileSource;

		// Token: 0x0400E37D RID: 58237
		[Token(Token = "0x400E37D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7E8")]
		private static DelegateBridge __Hotfix0_CreateProjectileFromProjectile;

		// Token: 0x0400E37E RID: 58238
		[Token(Token = "0x400E37E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7F0")]
		private static DelegateBridge __Hotfix0_CreateCharacterDummy;

		// Token: 0x0400E37F RID: 58239
		[Token(Token = "0x400E37F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x7F8")]
		private static DelegateBridge __Hotfix0_CreateTokenDummy;

		// Token: 0x0400E380 RID: 58240
		[Token(Token = "0x400E380")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x800")]
		private static DelegateBridge __Hotfix0_CreateSkill;

		// Token: 0x0400E381 RID: 58241
		[Token(Token = "0x400E381")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x808")]
		private static DelegateBridge __Hotfix0_CreateEffect;

		// Token: 0x0400E382 RID: 58242
		[Token(Token = "0x400E382")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x810")]
		private static DelegateBridge __Hotfix1_CreateEffect;

		// Token: 0x0400E383 RID: 58243
		[Token(Token = "0x400E383")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x818")]
		private static DelegateBridge __Hotfix0_CreateEffectHoldBySource;

		// Token: 0x0400E384 RID: 58244
		[Token(Token = "0x400E384")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x820")]
		private static DelegateBridge __Hotfix2_CreateEffect;

		// Token: 0x0400E385 RID: 58245
		[Token(Token = "0x400E385")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x828")]
		private static DelegateBridge __Hotfix0_CreateEffectAtWorldPos;

		// Token: 0x0400E386 RID: 58246
		[Token(Token = "0x400E386")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x830")]
		private static DelegateBridge __Hotfix1_CreateEffectAtWorldPos;

		// Token: 0x0400E387 RID: 58247
		[Token(Token = "0x400E387")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x838")]
		private static DelegateBridge __Hotfix0_CreateEffectAtMapPos;

		// Token: 0x0400E388 RID: 58248
		[Token(Token = "0x400E388")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x840")]
		private static DelegateBridge __Hotfix1_CreateEffectAtMapPos;

		// Token: 0x0400E389 RID: 58249
		[Token(Token = "0x400E389")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x848")]
		private static DelegateBridge __Hotfix0_CreateEffectAtMapPosAndHold;

		// Token: 0x0400E38A RID: 58250
		[Token(Token = "0x400E38A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x850")]
		private static DelegateBridge __Hotfix0_FinishOperaHoldEffectIfExist;

		// Token: 0x0400E38B RID: 58251
		[Token(Token = "0x400E38B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x858")]
		private static DelegateBridge __Hotfix0_CreateMapEffect;

		// Token: 0x0400E38C RID: 58252
		[Token(Token = "0x400E38C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x860")]
		private static DelegateBridge __Hotfix3_CreateEffect;

		// Token: 0x0400E38D RID: 58253
		[Token(Token = "0x400E38D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x868")]
		private static DelegateBridge __Hotfix4_CreateEffect;

		// Token: 0x0400E38E RID: 58254
		[Token(Token = "0x400E38E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x870")]
		private static DelegateBridge __Hotfix0_CreateCameraEffect;

		// Token: 0x0400E38F RID: 58255
		[Token(Token = "0x400E38F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x878")]
		private static DelegateBridge __Hotfix0_CreateEffects;

		// Token: 0x0400E390 RID: 58256
		[Token(Token = "0x400E390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x880")]
		private static DelegateBridge __Hotfix1_CreateEffects;

		// Token: 0x0400E391 RID: 58257
		[Token(Token = "0x400E391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x888")]
		private static DelegateBridge __Hotfix2_CreateEffects;

		// Token: 0x0400E392 RID: 58258
		[Token(Token = "0x400E392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x890")]
		private static DelegateBridge __Hotfix0_CreateEffectsAtMapPos;

		// Token: 0x0400E393 RID: 58259
		[Token(Token = "0x400E393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x898")]
		private static DelegateBridge __Hotfix0_CreateMapEffects;

		// Token: 0x0400E394 RID: 58260
		[Token(Token = "0x400E394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A0")]
		private static DelegateBridge __Hotfix0_SortDeckRuntime;

		// Token: 0x0400E395 RID: 58261
		[Token(Token = "0x400E395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8A8")]
		private static DelegateBridge __Hotfix0_CreateEffectOn;

		// Token: 0x0400E396 RID: 58262
		[Token(Token = "0x400E396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B0")]
		private static DelegateBridge __Hotfix0_ThrowEffect;

		// Token: 0x0400E397 RID: 58263
		[Token(Token = "0x400E397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8B8")]
		private static DelegateBridge __Hotfix0_PlayAudioAtPos;

		// Token: 0x0400E398 RID: 58264
		[Token(Token = "0x400E398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C0")]
		private static DelegateBridge __Hotfix0__PlayBattleCharFX;

		// Token: 0x0400E399 RID: 58265
		[Token(Token = "0x400E399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8C8")]
		private static DelegateBridge __Hotfix0__PlayBattleFinishAudio;

		// Token: 0x0400E39A RID: 58266
		[Token(Token = "0x400E39A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D0")]
		private static DelegateBridge __Hotfix0_StartBattleCoroutine;

		// Token: 0x0400E39B RID: 58267
		[Token(Token = "0x400E39B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8D8")]
		private static DelegateBridge __Hotfix0_StopBattleCoroutine;

		// Token: 0x0400E39C RID: 58268
		[Token(Token = "0x400E39C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8E0")]
		private static DelegateBridge __Hotfix0_StopAllBattleCoroutines;

		// Token: 0x0400E39D RID: 58269
		[Token(Token = "0x400E39D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8E8")]
		private static DelegateBridge __Hotfix0_RestoreDeltaTimeScale;

		// Token: 0x0400E39E RID: 58270
		[Token(Token = "0x400E39E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8F0")]
		private static DelegateBridge __Hotfix0_ReqChangeDeltaTimeFPInStepMode;

		// Token: 0x0400E39F RID: 58271
		[Token(Token = "0x400E39F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8F8")]
		private static DelegateBridge __Hotfix0_StartBattleTween;

		// Token: 0x0400E3A0 RID: 58272
		[Token(Token = "0x400E3A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x900")]
		private static DelegateBridge __Hotfix1_StartBattleTween;

		// Token: 0x0400E3A1 RID: 58273
		[Token(Token = "0x400E3A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x908")]
		private static DelegateBridge __Hotfix0_TakeSnapshotAsHashCode;

		// Token: 0x0400E3A2 RID: 58274
		[Token(Token = "0x400E3A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x910")]
		private static DelegateBridge __Hotfix0__LogSnapshot;

		// Token: 0x0400E3A3 RID: 58275
		[Token(Token = "0x400E3A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x918")]
		private static DelegateBridge __Hotfix0_RecycleBuffNextFrame;

		// Token: 0x0400E3A4 RID: 58276
		[Token(Token = "0x400E3A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x920")]
		private static DelegateBridge __Hotfix0__UpdateDelayToRecycleBuffContainer;

		// Token: 0x0400E3A5 RID: 58277
		[Token(Token = "0x400E3A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x928")]
		private static DelegateBridge __Hotfix0__RecycleBuffContainerImmediatelly;

		// Token: 0x0400E3A6 RID: 58278
		[Token(Token = "0x400E3A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x930")]
		private static DelegateBridge __Hotfix0_SetSlowMotion;

		// Token: 0x0400E3A7 RID: 58279
		[Token(Token = "0x400E3A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x938")]
		private static DelegateBridge __Hotfix0_RevertSlowMotion;

		// Token: 0x0400E3A8 RID: 58280
		[Token(Token = "0x400E3A8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x940")]
		private static DelegateBridge __Hotfix0_LogPlayerOperation;

		// Token: 0x0400E3A9 RID: 58281
		[Token(Token = "0x400E3A9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x948")]
		private static DelegateBridge __Hotfix0_AchieveBattleJournal;

		// Token: 0x0400E3AA RID: 58282
		[Token(Token = "0x400E3AA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x950")]
		private static DelegateBridge __Hotfix0_CancelAutoReplayIfOn;

		// Token: 0x0400E3AB RID: 58283
		[Token(Token = "0x400E3AB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x958")]
		private static DelegateBridge __Hotfix0_IsAutoBattleUnsync;

		// Token: 0x0400E3AC RID: 58284
		[Token(Token = "0x400E3AC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x960")]
		private static DelegateBridge __Hotfix0_OnPhysicObjectInit;

		// Token: 0x0400E3AD RID: 58285
		[Token(Token = "0x400E3AD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x968")]
		private static DelegateBridge __Hotfix0_OnPhysicObjectRecycle;

		// Token: 0x0400E3AE RID: 58286
		[Token(Token = "0x400E3AE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x970")]
		private static DelegateBridge __Hotfix0_OnUnitBorn;

		// Token: 0x0400E3AF RID: 58287
		[Token(Token = "0x400E3AF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x978")]
		private static DelegateBridge __Hotfix0_OnUnitFinished;

		// Token: 0x0400E3B0 RID: 58288
		[Token(Token = "0x400E3B0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x980")]
		private static DelegateBridge __Hotfix0_OnCharacterLocate;

		// Token: 0x0400E3B1 RID: 58289
		[Token(Token = "0x400E3B1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x988")]
		private static DelegateBridge __Hotfix0_OnCharacterFinished;

		// Token: 0x0400E3B2 RID: 58290
		[Token(Token = "0x400E3B2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x990")]
		private static DelegateBridge __Hotfix0_RecycleCard;

		// Token: 0x0400E3B3 RID: 58291
		[Token(Token = "0x400E3B3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x998")]
		private static DelegateBridge __Hotfix0_OnCharacterAtkOrCbt;

		// Token: 0x0400E3B4 RID: 58292
		[Token(Token = "0x400E3B4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A0")]
		private static DelegateBridge __Hotfix0_OnDummyTouchedToTile;

		// Token: 0x0400E3B5 RID: 58293
		[Token(Token = "0x400E3B5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9A8")]
		private static DelegateBridge __Hotfix1_OnDummyTouchedToTile;

		// Token: 0x0400E3B6 RID: 58294
		[Token(Token = "0x400E3B6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9B0")]
		private static DelegateBridge __Hotfix0_Hook_OnDummyDragging;

		// Token: 0x0400E3B7 RID: 58295
		[Token(Token = "0x400E3B7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9B8")]
		private static DelegateBridge __Hotfix0_OnEnemyFinished;

		// Token: 0x0400E3B8 RID: 58296
		[Token(Token = "0x400E3B8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C0")]
		private static DelegateBridge __Hotfix0_OnEnemyReachedExit;

		// Token: 0x0400E3B9 RID: 58297
		[Token(Token = "0x400E3B9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9C8")]
		private static DelegateBridge __Hotfix0_OnEnemyRecycled;

		// Token: 0x0400E3BA RID: 58298
		[Token(Token = "0x400E3BA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D0")]
		private static DelegateBridge __Hotfix0_OnBossEnter;

		// Token: 0x0400E3BB RID: 58299
		[Token(Token = "0x400E3BB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9D8")]
		private static DelegateBridge __Hotfix0_OnGiantBossHudUsed;

		// Token: 0x0400E3BC RID: 58300
		[Token(Token = "0x400E3BC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9E0")]
		private static DelegateBridge __Hotfix0_OnPredefinedLocationReached;

		// Token: 0x0400E3BD RID: 58301
		[Token(Token = "0x400E3BD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9E8")]
		private static DelegateBridge __Hotfix0__OnPauseToggled;

		// Token: 0x0400E3BE RID: 58302
		[Token(Token = "0x400E3BE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9F0")]
		private static DelegateBridge __Hotfix0__OnSpeedLevelChanged;

		// Token: 0x0400E3BF RID: 58303
		[Token(Token = "0x400E3BF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x9F8")]
		private static DelegateBridge __Hotfix0_OnWaveWillStart;

		// Token: 0x0400E3C0 RID: 58304
		[Token(Token = "0x400E3C0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA00")]
		private static DelegateBridge __Hotfix0_OnWaveWillFinish;

		// Token: 0x0400E3C1 RID: 58305
		[Token(Token = "0x400E3C1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA08")]
		private static DelegateBridge __Hotfix0_OnSpecialUITrigger;

		// Token: 0x0400E3C2 RID: 58306
		[Token(Token = "0x400E3C2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA10")]
		private static DelegateBridge __Hotfix0__ParseBattleRank;

		// Token: 0x0400E3C3 RID: 58307
		[Token(Token = "0x400E3C3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA18")]
		private static DelegateBridge __Hotfix0__CreatePredefinedCharacter;

		// Token: 0x0400E3C4 RID: 58308
		[Token(Token = "0x400E3C4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA20")]
		private static DelegateBridge __Hotfix0__WithdrawPredefinedCharacter;

		// Token: 0x0400E3C5 RID: 58309
		[Token(Token = "0x400E3C5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA28")]
		private static DelegateBridge __Hotfix0__PreprocessPredefinedCharacter;

		// Token: 0x0400E3C6 RID: 58310
		[Token(Token = "0x400E3C6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA30")]
		private static DelegateBridge __Hotfix0__LoadPredefinedData;

		// Token: 0x0400E3C7 RID: 58311
		[Token(Token = "0x400E3C7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA38")]
		private static DelegateBridge __Hotfix0__InitRunes;

		// Token: 0x0400E3C8 RID: 58312
		[Token(Token = "0x400E3C8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA40")]
		private static DelegateBridge __Hotfix0__CreateAndInitGlobalBuffs;

		// Token: 0x0400E3C9 RID: 58313
		[Token(Token = "0x400E3C9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA48")]
		private static DelegateBridge __Hotfix0_CreateAndInitGlobalBuff;

		// Token: 0x0400E3CA RID: 58314
		[Token(Token = "0x400E3CA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA50")]
		private static DelegateBridge __Hotfix0_GetFirstGlobalBuffByKey;

		// Token: 0x0400E3CB RID: 58315
		[Token(Token = "0x400E3CB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA58")]
		private static DelegateBridge __Hotfix0__CreateAndInitGlobalEnvSystem;

		// Token: 0x0400E3CC RID: 58316
		[Token(Token = "0x400E3CC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA60")]
		private static DelegateBridge __Hotfix0_ClearRunTimeData;

		// Token: 0x0400E3CD RID: 58317
		[Token(Token = "0x400E3CD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA68")]
		private static DelegateBridge __Hotfix0__ClearResourcesInHolder;

		// Token: 0x0400E3CE RID: 58318
		[Token(Token = "0x400E3CE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA70")]
		private static DelegateBridge __Hotfix0_ResetGlobalBuff;

		// Token: 0x0400E3CF RID: 58319
		[Token(Token = "0x400E3CF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA78")]
		private static DelegateBridge __Hotfix0_RemoveGlobalBuff;

		// Token: 0x0400E3D0 RID: 58320
		[Token(Token = "0x400E3D0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA80")]
		private static DelegateBridge __Hotfix0_RemoveGlobalBuffByAlias;

		// Token: 0x0400E3D1 RID: 58321
		[Token(Token = "0x400E3D1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA88")]
		private static DelegateBridge __Hotfix0__ResetGlobalBuffStatics;

		// Token: 0x0400E3D2 RID: 58322
		[Token(Token = "0x400E3D2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA90")]
		private static DelegateBridge __Hotfix0_CreateCardBuffWithBlackboardByCardBuffKey;

		// Token: 0x0400E3D3 RID: 58323
		[Token(Token = "0x400E3D3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA98")]
		private static DelegateBridge __Hotfix0_CreateCardBuffWithBlackboard;

		// Token: 0x0400E3D4 RID: 58324
		[Token(Token = "0x400E3D4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA0")]
		private static DelegateBridge __Hotfix0_CreateCardBuffByCardWithBlackboard;

		// Token: 0x0400E3D5 RID: 58325
		[Token(Token = "0x400E3D5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAA8")]
		private static DelegateBridge __Hotfix0_AddDeckBuff;

		// Token: 0x0400E3D6 RID: 58326
		[Token(Token = "0x400E3D6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAB0")]
		private static DelegateBridge __Hotfix0__SwitchState;

		// Token: 0x0400E3D7 RID: 58327
		[Token(Token = "0x400E3D7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAB8")]
		private static DelegateBridge __Hotfix0__RegisterModules;

		// Token: 0x0400E3D8 RID: 58328
		[Token(Token = "0x400E3D8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC0")]
		private static DelegateBridge __Hotfix0__UpdateGameInfo;

		// Token: 0x0400E3D9 RID: 58329
		[Token(Token = "0x400E3D9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAC8")]
		private static DelegateBridge __Hotfix0__UpdateCost;

		// Token: 0x0400E3DA RID: 58330
		[Token(Token = "0x400E3DA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD0")]
		private static DelegateBridge __Hotfix0__UpdatePlayerOrReplayInput;

		// Token: 0x0400E3DB RID: 58331
		[Token(Token = "0x400E3DB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAD8")]
		private static DelegateBridge __Hotfix0__LoadGameInternal;

		// Token: 0x0400E3DC RID: 58332
		[Token(Token = "0x400E3DC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAE0")]
		private static DelegateBridge __Hotfix0_LoadGameWithRune;

		// Token: 0x0400E3DD RID: 58333
		[Token(Token = "0x400E3DD")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAE8")]
		private static DelegateBridge __Hotfix0__GenerateDeckDict;

		// Token: 0x0400E3DE RID: 58334
		[Token(Token = "0x400E3DE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAF0")]
		private static DelegateBridge __Hotfix0__MergeDeckModifiers;

		// Token: 0x0400E3DF RID: 58335
		[Token(Token = "0x400E3DF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xAF8")]
		private static DelegateBridge __Hotfix0__PostProcessCharacters;

		// Token: 0x0400E3E0 RID: 58336
		[Token(Token = "0x400E3E0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB00")]
		private static DelegateBridge __Hotfix0__InitCameraAndMapEffects;

		// Token: 0x0400E3E1 RID: 58337
		[Token(Token = "0x400E3E1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB08")]
		private static DelegateBridge __Hotfix0__GetFinalCameraEffect;

		// Token: 0x0400E3E2 RID: 58338
		[Token(Token = "0x400E3E2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB10")]
		private static DelegateBridge __Hotfix0__DoApplyGlobalModifier;

		// Token: 0x0400E3E3 RID: 58339
		[Token(Token = "0x400E3E3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB18")]
		private static DelegateBridge __Hotfix0__ApplyGlobalModifier;

		// Token: 0x0400E3E4 RID: 58340
		[Token(Token = "0x400E3E4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB20")]
		private static DelegateBridge __Hotfix0__OnApplyingGlobalModifier;

		// Token: 0x0400E3E5 RID: 58341
		[Token(Token = "0x400E3E5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB28")]
		private static DelegateBridge __Hotfix0__InitPostprocessSettings;

		// Token: 0x0400E3E6 RID: 58342
		[Token(Token = "0x400E3E6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB30")]
		private static DelegateBridge __Hotfix0__LoadPools;

		// Token: 0x0400E3E7 RID: 58343
		[Token(Token = "0x400E3E7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB38")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400E3E8 RID: 58344
		[Token(Token = "0x400E3E8")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB40")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400E3E9 RID: 58345
		[Token(Token = "0x400E3E9")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB48")]
		private static DelegateBridge __Hotfix0_FixedUpdate;

		// Token: 0x0400E3EA RID: 58346
		[Token(Token = "0x400E3EA")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB50")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400E3EB RID: 58347
		[Token(Token = "0x400E3EB")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB58")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0400E3EC RID: 58348
		[Token(Token = "0x400E3EC")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB60")]
		private static DelegateBridge __Hotfix0_LiteDisposeBattle;

		// Token: 0x0400E3ED RID: 58349
		[Token(Token = "0x400E3ED")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB68")]
		private static DelegateBridge __Hotfix0_ClearTweensIfNecessary;

		// Token: 0x0400E3EE RID: 58350
		[Token(Token = "0x400E3EE")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB70")]
		private static DelegateBridge __Hotfix0__ClearStaticVariables;

		// Token: 0x0400E3EF RID: 58351
		[Token(Token = "0x400E3EF")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB78")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400E3F0 RID: 58352
		[Token(Token = "0x400E3F0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB80")]
		private static DelegateBridge __Hotfix0_GetOrCreateSingleton;

		// Token: 0x0200217E RID: 8574
		[Token(Token = "0x200217E")]
		public enum State
		{
			// Token: 0x0400E3F2 RID: 58354
			[Token(Token = "0x400E3F2")]
			NONE,
			// Token: 0x0400E3F3 RID: 58355
			[Token(Token = "0x400E3F3")]
			INITED_BUT_NOT_START,
			// Token: 0x0400E3F4 RID: 58356
			[Token(Token = "0x400E3F4")]
			PLAYING,
			// Token: 0x0400E3F5 RID: 58357
			[Token(Token = "0x400E3F5")]
			FINISHED
		}

		// Token: 0x0200217F RID: 8575
		[Token(Token = "0x200217F")]
		public enum GameResult
		{
			// Token: 0x0400E3F7 RID: 58359
			[Token(Token = "0x400E3F7")]
			NOT_YET,
			// Token: 0x0400E3F8 RID: 58360
			[Token(Token = "0x400E3F8")]
			WIN,
			// Token: 0x0400E3F9 RID: 58361
			[Token(Token = "0x400E3F9")]
			LOSE
		}

		// Token: 0x02002180 RID: 8576
		[Token(Token = "0x2002180")]
		public class ReplayController
		{
			// Token: 0x170019C0 RID: 6592
			// (get) Token: 0x0600D476 RID: 54390 RVA: 0x0004CBC0 File Offset: 0x0004ADC0
			// (set) Token: 0x0600D477 RID: 54391 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170019C0")]
			public bool isEnabled
			{
				[Token(Token = "0x600D476")]
				[Address(RVA = "0x906A30", Offset = "0x905630", VA = "0x180906A30")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600D477")]
				[Address(RVA = "0x906A90", Offset = "0x905690", VA = "0x180906A90")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170019C1 RID: 6593
			// (get) Token: 0x0600D478 RID: 54392 RVA: 0x0004CBD8 File Offset: 0x0004ADD8
			[Token(Token = "0x170019C1")]
			public int savedRemainingLifePoint
			{
				[Token(Token = "0x600D478")]
				[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600D479 RID: 54393 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D479")]
			[Address(RVA = "0x359AB00", Offset = "0x3599700", VA = "0x18359AB00")]
			public ReplayController(BattleLogger.Journal journal, BattleController.ReplayController.Options options)
			{
			}

			// Token: 0x0600D47A RID: 54394 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D47A")]
			[Address(RVA = "0x359A130", Offset = "0x3598D30", VA = "0x18359A130")]
			public void Tick(FP playTime)
			{
			}

			// Token: 0x170019C2 RID: 6594
			// (get) Token: 0x0600D47B RID: 54395 RVA: 0x0004CBF0 File Offset: 0x0004ADF0
			[Token(Token = "0x170019C2")]
			public bool hasUnsyncLogs
			{
				[Token(Token = "0x600D47B")]
				[Address(RVA = "0x359AD30", Offset = "0x3599930", VA = "0x18359AD30")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600D47C RID: 54396 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D47C")]
			[Address(RVA = "0x359A0A0", Offset = "0x3598CA0", VA = "0x18359A0A0")]
			public void Cancel()
			{
			}

			// Token: 0x0600D47D RID: 54397 RVA: 0x0004CC08 File Offset: 0x0004AE08
			[Token(Token = "0x600D47D")]
			[Address(RVA = "0x359A510", Offset = "0x3599110", VA = "0x18359A510")]
			[Obsolete]
			private bool _TryExecuteOperation(BattleLogger.LogItem log, ref int indexInReadyLogsQueue)
			{
				return default(bool);
			}

			// Token: 0x0400E3FA RID: 58362
			[Token(Token = "0x400E3FA")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool m_isEarlyFinished;

			// Token: 0x0400E3FB RID: 58363
			[Token(Token = "0x400E3FB")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x11")]
			private BattleController.ReplayController.Options m_options;

			// Token: 0x0400E3FC RID: 58364
			[Token(Token = "0x400E3FC")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private BattleLogger.Journal m_journal;

			// Token: 0x0400E3FD RID: 58365
			[Token(Token = "0x400E3FD")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
			private Queue<BattleLogger.LogItem> m_pendingLogs;

			// Token: 0x0400E3FE RID: 58366
			[Token(Token = "0x400E3FE")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
			[Inspect(InspectorLevel.Debug)]
			[ReadOnly]
			private List<BattleLogger.LogItem> m_readyLogs;

			// Token: 0x0400E3FF RID: 58367
			[Token(Token = "0x400E3FF")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
			private FP m_playTimeCheckCorrection;

			// Token: 0x02002181 RID: 8577
			[Token(Token = "0x2002181")]
			public struct Options
			{
				// Token: 0x0400E401 RID: 58369
				[Token(Token = "0x400E401")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public static readonly BattleController.ReplayController.Options DEFAULT;

				// Token: 0x0400E402 RID: 58370
				[Token(Token = "0x400E402")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public bool retryFailedLogs;

				// Token: 0x0400E403 RID: 58371
				[Token(Token = "0x400E403")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1")]
				public bool manualTrigSkill;
			}
		}

		// Token: 0x02002182 RID: 8578
		[Token(Token = "0x2002182")]
		public class PlayerOperationQueue
		{
			// Token: 0x170019C3 RID: 6595
			// (get) Token: 0x0600D47F RID: 54399 RVA: 0x0004CC20 File Offset: 0x0004AE20
			// (set) Token: 0x0600D480 RID: 54400 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170019C3")]
			public bool shouldQueueOps
			{
				[Token(Token = "0x600D47F")]
				[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x600D480")]
				[Address(RVA = "0x4E63E0", Offset = "0x4E4FE0", VA = "0x1804E63E0")]
				set
				{
				}
			}

			// Token: 0x0600D481 RID: 54401 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D481")]
			[Address(RVA = "0x3599FF0", Offset = "0x3598BF0", VA = "0x183599FF0")]
			public PlayerOperationQueue(BattleController controller, bool shouldQueueOps)
			{
			}

			// Token: 0x0600D482 RID: 54402 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D482")]
			[Address(RVA = "0x3599B60", Offset = "0x3598760", VA = "0x183599B60")]
			public void Clear()
			{
			}

			// Token: 0x0600D483 RID: 54403 RVA: 0x0004CC38 File Offset: 0x0004AE38
			[Token(Token = "0x600D483")]
			[Address(RVA = "0x3599760", Offset = "0x3598360", VA = "0x183599760")]
			public bool AppendSpawn(uint uniqueId, SharedConsts.Direction direction, Tile tile, PlayerSide side = PlayerSide.DEFAULT)
			{
				return default(bool);
			}

			// Token: 0x0600D484 RID: 54404 RVA: 0x0004CC50 File Offset: 0x0004AE50
			[Token(Token = "0x600D484")]
			[Address(RVA = "0x3599A20", Offset = "0x3598620", VA = "0x183599A20")]
			public bool AppendWithdraw(Character target, PlayerSide side = PlayerSide.DEFAULT)
			{
				return default(bool);
			}

			// Token: 0x0600D485 RID: 54405 RVA: 0x0004CC68 File Offset: 0x0004AE68
			[Token(Token = "0x600D485")]
			[Address(RVA = "0x35998C0", Offset = "0x35984C0", VA = "0x1835998C0")]
			public bool AppendTrigSkill(Character target, PlayerSide side = PlayerSide.DEFAULT, [Optional] string extraInfo)
			{
				return default(bool);
			}

			// Token: 0x0600D486 RID: 54406 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D486")]
			[Address(RVA = "0x3599BB0", Offset = "0x35987B0", VA = "0x183599BB0")]
			public void Drain()
			{
			}

			// Token: 0x0600D487 RID: 54407 RVA: 0x0004CC80 File Offset: 0x0004AE80
			[Token(Token = "0x600D487")]
			[Address(RVA = "0x3599E20", Offset = "0x3598A20", VA = "0x183599E20")]
			private bool _DoExecuteOperation(ref BattleController.PlayerOperationQueue.OperationEntry entry)
			{
				return default(bool);
			}

			// Token: 0x0400E404 RID: 58372
			[Token(Token = "0x400E404")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private bool m_shouldQueueOps;

			// Token: 0x0400E405 RID: 58373
			[Token(Token = "0x400E405")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			private BattleController m_controller;

			// Token: 0x0400E406 RID: 58374
			[Token(Token = "0x400E406")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
			private Queue<BattleController.PlayerOperationQueue.OperationEntry> m_queue;

			// Token: 0x02002183 RID: 8579
			[Token(Token = "0x2002183")]
			[StructLayout(2)]
			private struct TargetUnion
			{
				// Token: 0x0600D488 RID: 54408 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D488")]
				[Address(RVA = "0x359AFB0", Offset = "0x3599BB0", VA = "0x18359AFB0")]
				public TargetUnion(Character target_)
				{
				}

				// Token: 0x0600D489 RID: 54409 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D489")]
				[Address(RVA = "0x4F7EA0", Offset = "0x4F6AA0", VA = "0x1804F7EA0")]
				public TargetUnion(ObjectPtr<Character> target_)
				{
				}

				// Token: 0x0600D48A RID: 54410 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600D48A")]
				[Address(RVA = "0x359B020", Offset = "0x3599C20", VA = "0x18359B020")]
				public TargetUnion(uint uniqueId_)
				{
				}

				// Token: 0x0400E407 RID: 58375
				[Token(Token = "0x400E407")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public ObjectPtr<Character> target;

				// Token: 0x0400E408 RID: 58376
				[Token(Token = "0x400E408")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public uint uniqueId;
			}

			// Token: 0x02002184 RID: 8580
			[Token(Token = "0x2002184")]
			private struct OperationEntry
			{
				// Token: 0x0600D48B RID: 54411 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600D48B")]
				[Address(RVA = "0x35996D0", Offset = "0x35982D0", VA = "0x1835996D0")]
				public Character GetTargetOrNull()
				{
					return null;
				}

				// Token: 0x0400E409 RID: 58377
				[Token(Token = "0x400E409")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public PlayerOperationType opType;

				// Token: 0x0400E40A RID: 58378
				[Token(Token = "0x400E40A")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public BattleController.PlayerOperationQueue.TargetUnion target;

				// Token: 0x0400E40B RID: 58379
				[Token(Token = "0x400E40B")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public SharedConsts.Direction direction;

				// Token: 0x0400E40C RID: 58380
				[Token(Token = "0x400E40C")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
				public Tile tile;

				// Token: 0x0400E40D RID: 58381
				[Token(Token = "0x400E40D")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
				public PlayerSide side;

				// Token: 0x0400E40E RID: 58382
				[Token(Token = "0x400E40E")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
				public string extraInfo;
			}
		}

		// Token: 0x02002185 RID: 8581
		[Token(Token = "0x2002185")]
		public class FrameData
		{
			// Token: 0x0600D48C RID: 54412 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D48C")]
			[Address(RVA = "0x3598C30", Offset = "0x3597830", VA = "0x183598C30")]
			public void AppendWithdraw(BattleCharacterData.Signiture sig, GridPosition pos, PlayerSide side)
			{
			}

			// Token: 0x0600D48D RID: 54413 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D48D")]
			[Address(RVA = "0x3598B50", Offset = "0x3597750", VA = "0x183598B50")]
			public void AppendSpawn(BattleCharacterData.Signiture sig, SharedConsts.Direction direction, GridPosition pos, PlayerSide side)
			{
			}

			// Token: 0x0600D48E RID: 54414 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D48E")]
			[Address(RVA = "0x3598A80", Offset = "0x3597680", VA = "0x183598A80")]
			public void AppendSkill(BattleCharacterData.Signiture sig, GridPosition pos, PlayerSide side)
			{
			}

			// Token: 0x0600D48F RID: 54415 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D48F")]
			[Address(RVA = "0x35988E0", Offset = "0x35974E0", VA = "0x1835988E0")]
			public void AppendCheat(BattleCharacterData.Signiture sig, PlayerSide side)
			{
			}

			// Token: 0x0600D490 RID: 54416 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D490")]
			[Address(RVA = "0x35989A0", Offset = "0x35975A0", VA = "0x1835989A0")]
			public void AppendCheat(BattleCharacterData.Signiture sig, PlayerSide side, GridPosition grid, SharedConsts.Direction dir)
			{
			}

			// Token: 0x0600D491 RID: 54417 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D491")]
			[Address(RVA = "0x3598ED0", Offset = "0x3597AD0", VA = "0x183598ED0")]
			public void Reset()
			{
			}

			// Token: 0x0600D492 RID: 54418 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D492")]
			[Address(RVA = "0x3598D00", Offset = "0x3597900", VA = "0x183598D00")]
			public void DumpToPlayerOpQueue(BattleController.PlayerOperationQueue target)
			{
			}

			// Token: 0x0600D493 RID: 54419 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D493")]
			[Address(RVA = "0x3598F20", Offset = "0x3597B20", VA = "0x183598F20")]
			public FrameData()
			{
			}

			// Token: 0x0400E40F RID: 58383
			[Token(Token = "0x400E40F")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public Queue<BattleController.FrameData.Operation> opQueue;

			// Token: 0x02002186 RID: 8582
			[Token(Token = "0x2002186")]
			public struct Operation
			{
				// Token: 0x0400E410 RID: 58384
				[Token(Token = "0x400E410")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
				public PlayerOperationType op;

				// Token: 0x0400E411 RID: 58385
				[Token(Token = "0x400E411")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
				public BattleCharacterData.Signiture signiture;

				// Token: 0x0400E412 RID: 58386
				[Token(Token = "0x400E412")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
				public SharedConsts.Direction direction;

				// Token: 0x0400E413 RID: 58387
				[Token(Token = "0x400E413")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x1C")]
				public GridPosition pos;

				// Token: 0x0400E414 RID: 58388
				[Token(Token = "0x400E414")]
				[Il2CppDummyDll.FieldOffset(Offset = "0x24")]
				public PlayerSide side;
			}
		}

		// Token: 0x02002187 RID: 8583
		[Token(Token = "0x2002187")]
		public struct CostTimerModifier : IComparable<BattleController.CostTimerModifier>
		{
			// Token: 0x0600D494 RID: 54420 RVA: 0x0004CC98 File Offset: 0x0004AE98
			[Token(Token = "0x600D494")]
			[Address(RVA = "0x35988D0", Offset = "0x35974D0", VA = "0x1835988D0", Slot = "4")]
			public int CompareTo(BattleController.CostTimerModifier other)
			{
				return 0;
			}

			// Token: 0x0400E415 RID: 58389
			[Token(Token = "0x400E415")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
			public ObjectPtr<Entity> source;

			// Token: 0x0400E416 RID: 58390
			[Token(Token = "0x400E416")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			public float value;

			// Token: 0x0400E417 RID: 58391
			[Token(Token = "0x400E417")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x14")]
			public int priority;

			// Token: 0x0400E418 RID: 58392
			[Token(Token = "0x400E418")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
			public bool costAddLocked;
		}

		// Token: 0x02002188 RID: 8584
		[Token(Token = "0x2002188")]
		private class SingletonHost : IDisposable
		{
			// Token: 0x0600D495 RID: 54421 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600D495")]
			public T GetOrCreate<T>(Func<T> creator) where T : class
			{
				return null;
			}

			// Token: 0x0600D496 RID: 54422 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D496")]
			[Address(RVA = "0x359AD80", Offset = "0x3599980", VA = "0x18359AD80", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x0600D497 RID: 54423 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D497")]
			[Address(RVA = "0x359AF20", Offset = "0x3599B20", VA = "0x18359AF20")]
			public SingletonHost()
			{
			}

			// Token: 0x0400E419 RID: 58393
			[Token(Token = "0x400E419")]
			[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
			private Dictionary<Type, object> m_instStore;
		}
	}
}
