using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using Torappu.ObjectPool;
using XLua;

namespace Torappu.Battle.DataCenter
{
	// Token: 0x020026F0 RID: 9968
	[Token(Token = "0x20026F0")]
	public class AutoChessDataCenter : IHotfixable
	{
		// Token: 0x1700234F RID: 9039
		// (get) Token: 0x0601031A RID: 66330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700234F")]
		public static AutoChessDataCenter instanceOrNull
		{
			[Token(Token = "0x601031A")]
			[Address(RVA = "0x7DDAD0", Offset = "0x7DC6D0", VA = "0x1807DDAD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002350 RID: 9040
		// (get) Token: 0x0601031B RID: 66331 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601031C RID: 66332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002350")]
		public string actId
		{
			[Token(Token = "0x601031B")]
			[Address(RVA = "0x7DCFD0", Offset = "0x7DBBD0", VA = "0x1807DCFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601031C")]
			[Address(RVA = "0x7DE840", Offset = "0x7DD440", VA = "0x1807DE840")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002351 RID: 9041
		// (get) Token: 0x0601031D RID: 66333 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601031E RID: 66334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002351")]
		public ActAutoChessData actData
		{
			[Token(Token = "0x601031D")]
			[Address(RVA = "0x7DCF70", Offset = "0x7DBB70", VA = "0x1807DCF70")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601031E")]
			[Address(RVA = "0x7DE7C0", Offset = "0x7DD3C0", VA = "0x1807DE7C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002352 RID: 9042
		// (get) Token: 0x0601031F RID: 66335 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06010320 RID: 66336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002352")]
		public AutoChessBattleMiscConfig miscConfig
		{
			[Token(Token = "0x601031F")]
			[Address(RVA = "0x7DE110", Offset = "0x7DCD10", VA = "0x1807DE110")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6010320")]
			[Address(RVA = "0x7DEE20", Offset = "0x7DDA20", VA = "0x1807DEE20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002353 RID: 9043
		// (get) Token: 0x06010321 RID: 66337 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06010322 RID: 66338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002353")]
		public ActAutoChessData.ActAutoChessModeData currentModeData
		{
			[Token(Token = "0x6010321")]
			[Address(RVA = "0x7DD5E0", Offset = "0x7DC1E0", VA = "0x1807DD5E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6010322")]
			[Address(RVA = "0x7DEB40", Offset = "0x7DD740", VA = "0x1807DEB40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002354 RID: 9044
		// (get) Token: 0x06010323 RID: 66339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002354")]
		public List<int> battlePlayerIndex
		{
			[Token(Token = "0x6010323")]
			[Address(RVA = "0x7DD130", Offset = "0x7DBD30", VA = "0x1807DD130")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002355 RID: 9045
		// (get) Token: 0x06010324 RID: 66340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002355")]
		public HashSet<int> rightMapPlayerIndex
		{
			[Token(Token = "0x6010324")]
			[Address(RVA = "0x7DE380", Offset = "0x7DCF80", VA = "0x1807DE380")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002356 RID: 9046
		// (get) Token: 0x06010325 RID: 66341 RVA: 0x00062C10 File Offset: 0x00060E10
		[Token(Token = "0x17002356")]
		public bool isViewRightMapInPrepare
		{
			[Token(Token = "0x6010325")]
			[Address(RVA = "0x7DDE60", Offset = "0x7DCA60", VA = "0x1807DDE60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002357 RID: 9047
		// (get) Token: 0x06010326 RID: 66342 RVA: 0x00062C28 File Offset: 0x00060E28
		[Token(Token = "0x17002357")]
		public bool isMultiPlayerBattle
		{
			[Token(Token = "0x6010326")]
			[Address(RVA = "0x7DDC40", Offset = "0x7DC840", VA = "0x1807DDC40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002358 RID: 9048
		// (get) Token: 0x06010327 RID: 66343 RVA: 0x00062C40 File Offset: 0x00060E40
		[Token(Token = "0x17002358")]
		public bool isMultiPlayerHelp
		{
			[Token(Token = "0x6010327")]
			[Address(RVA = "0x7DDD00", Offset = "0x7DC900", VA = "0x1807DDD00")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002359 RID: 9049
		// (get) Token: 0x06010328 RID: 66344 RVA: 0x00062C58 File Offset: 0x00060E58
		// (set) Token: 0x06010329 RID: 66345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002359")]
		public int selfPlayerIndex
		{
			[Token(Token = "0x6010328")]
			[Address(RVA = "0x7DE5C0", Offset = "0x7DD1C0", VA = "0x1807DE5C0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6010329")]
			[Address(RVA = "0x7DF010", Offset = "0x7DDC10", VA = "0x1807DF010")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700235A RID: 9050
		// (get) Token: 0x0601032A RID: 66346 RVA: 0x00062C70 File Offset: 0x00060E70
		[Token(Token = "0x1700235A")]
		public bool inObMode
		{
			[Token(Token = "0x601032A")]
			[Address(RVA = "0x7DD9C0", Offset = "0x7DC5C0", VA = "0x1807DD9C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700235B RID: 9051
		// (get) Token: 0x0601032B RID: 66347 RVA: 0x00062C88 File Offset: 0x00060E88
		[Token(Token = "0x1700235B")]
		public int realPlayerIndex
		{
			[Token(Token = "0x601032B")]
			[Address(RVA = "0x7DE290", Offset = "0x7DCE90", VA = "0x1807DE290")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700235C RID: 9052
		// (get) Token: 0x0601032C RID: 66348 RVA: 0x00062CA0 File Offset: 0x00060EA0
		[Token(Token = "0x1700235C")]
		public bool hasDeadObIndex
		{
			[Token(Token = "0x601032C")]
			[Address(RVA = "0x7DD7D0", Offset = "0x7DC3D0", VA = "0x1807DD7D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700235D RID: 9053
		// (get) Token: 0x0601032D RID: 66349 RVA: 0x00062CB8 File Offset: 0x00060EB8
		[Token(Token = "0x1700235D")]
		public int playerViewIndex
		{
			[Token(Token = "0x601032D")]
			[Address(RVA = "0x7DE1D0", Offset = "0x7DCDD0", VA = "0x1807DE1D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700235E RID: 9054
		// (get) Token: 0x0601032E RID: 66350 RVA: 0x00062CD0 File Offset: 0x00060ED0
		[Token(Token = "0x1700235E")]
		public int maxDeckChessCnt
		{
			[Token(Token = "0x601032E")]
			[Address(RVA = "0x7DE050", Offset = "0x7DCC50", VA = "0x1807DE050")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700235F RID: 9055
		// (get) Token: 0x0601032F RID: 66351 RVA: 0x00062CE8 File Offset: 0x00060EE8
		// (set) Token: 0x06010330 RID: 66352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700235F")]
		public PlayerSide playerViewSide
		{
			[Token(Token = "0x601032F")]
			[Address(RVA = "0x7DE230", Offset = "0x7DCE30", VA = "0x1807DE230")]
			[CompilerGenerated]
			get
			{
				return PlayerSide.DEFAULT;
			}
			[Token(Token = "0x6010330")]
			[Address(RVA = "0x7DEF20", Offset = "0x7DDB20", VA = "0x1807DEF20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002360 RID: 9056
		// (get) Token: 0x06010331 RID: 66353 RVA: 0x00062D00 File Offset: 0x00060F00
		// (set) Token: 0x06010332 RID: 66354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002360")]
		public int currentRound
		{
			[Token(Token = "0x6010331")]
			[Address(RVA = "0x7DD640", Offset = "0x7DC240", VA = "0x1807DD640")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6010332")]
			[Address(RVA = "0x7DEBC0", Offset = "0x7DD7C0", VA = "0x1807DEBC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002361 RID: 9057
		// (get) Token: 0x06010333 RID: 66355 RVA: 0x00062D18 File Offset: 0x00060F18
		[Token(Token = "0x17002361")]
		public bool inBossRound
		{
			[Token(Token = "0x6010333")]
			[Address(RVA = "0x7DD8F0", Offset = "0x7DC4F0", VA = "0x1807DD8F0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002362 RID: 9058
		// (get) Token: 0x06010334 RID: 66356 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06010335 RID: 66357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002362")]
		public List<BattleSpecialEffect> battleSpecialEffects
		{
			[Token(Token = "0x6010334")]
			[Address(RVA = "0x7DD190", Offset = "0x7DBD90", VA = "0x1807DD190")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6010335")]
			[Address(RVA = "0x7DE940", Offset = "0x7DD540", VA = "0x1807DE940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002363 RID: 9059
		// (get) Token: 0x06010336 RID: 66358 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06010337 RID: 66359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002363")]
		public Dictionary<int, int> lastBattleResult
		{
			[Token(Token = "0x6010336")]
			[Address(RVA = "0x7DDF80", Offset = "0x7DCB80", VA = "0x1807DDF80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6010337")]
			[Address(RVA = "0x7DEDA0", Offset = "0x7DD9A0", VA = "0x1807DEDA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002364 RID: 9060
		// (get) Token: 0x06010338 RID: 66360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002364")]
		public LevelData currentLevelData
		{
			[Token(Token = "0x6010338")]
			[Address(RVA = "0x7DD570", Offset = "0x7DC170", VA = "0x1807DD570")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002365 RID: 9061
		// (get) Token: 0x06010339 RID: 66361 RVA: 0x00062D30 File Offset: 0x00060F30
		[Token(Token = "0x17002365")]
		public int currentCoin
		{
			[Token(Token = "0x6010339")]
			[Address(RVA = "0x7DD500", Offset = "0x7DC100", VA = "0x1807DD500")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17002366 RID: 9062
		// (get) Token: 0x0601033A RID: 66362 RVA: 0x00062D48 File Offset: 0x00060F48
		[Token(Token = "0x17002366")]
		public int shopLevel
		{
			[Token(Token = "0x601033A")]
			[Address(RVA = "0x7DE620", Offset = "0x7DD220", VA = "0x1807DE620")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17002367 RID: 9063
		// (get) Token: 0x0601033B RID: 66363 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601033C RID: 66364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002367")]
		public string modeId
		{
			[Token(Token = "0x601033B")]
			[Address(RVA = "0x7DE170", Offset = "0x7DCD70", VA = "0x1807DE170")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601033C")]
			[Address(RVA = "0x7DEEA0", Offset = "0x7DDAA0", VA = "0x1807DEEA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002368 RID: 9064
		// (get) Token: 0x0601033D RID: 66365 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601033E RID: 66366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002368")]
		public List<string> bannedBonds
		{
			[Token(Token = "0x601033D")]
			[Address(RVA = "0x7DD030", Offset = "0x7DBC30", VA = "0x1807DD030")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601033E")]
			[Address(RVA = "0x7DE8C0", Offset = "0x7DD4C0", VA = "0x1807DE8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002369 RID: 9065
		// (get) Token: 0x0601033F RID: 66367 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06010340 RID: 66368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002369")]
		public string bossId
		{
			[Token(Token = "0x601033F")]
			[Address(RVA = "0x7DD2F0", Offset = "0x7DBEF0", VA = "0x1807DD2F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6010340")]
			[Address(RVA = "0x7DEA40", Offset = "0x7DD640", VA = "0x1807DEA40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700236A RID: 9066
		// (get) Token: 0x06010341 RID: 66369 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06010342 RID: 66370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700236A")]
		public string hiddenBossId
		{
			[Token(Token = "0x6010341")]
			[Address(RVA = "0x7DD890", Offset = "0x7DC490", VA = "0x1807DD890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6010342")]
			[Address(RVA = "0x7DED20", Offset = "0x7DD920", VA = "0x1807DED20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700236B RID: 9067
		// (get) Token: 0x06010343 RID: 66371 RVA: 0x00062D60 File Offset: 0x00060F60
		// (set) Token: 0x06010344 RID: 66372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700236B")]
		public long forceEndTime
		{
			[Token(Token = "0x6010343")]
			[Address(RVA = "0x7DD770", Offset = "0x7DC370", VA = "0x1807DD770")]
			[CompilerGenerated]
			get
			{
				return 0L;
			}
			[Token(Token = "0x6010344")]
			[Address(RVA = "0x7DEC30", Offset = "0x7DD830", VA = "0x1807DEC30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700236C RID: 9068
		// (get) Token: 0x06010345 RID: 66373 RVA: 0x00062D78 File Offset: 0x00060F78
		[Token(Token = "0x1700236C")]
		public long battleStartTime
		{
			[Token(Token = "0x6010345")]
			[Address(RVA = "0x7DD1F0", Offset = "0x7DBDF0", VA = "0x1807DD1F0")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700236D RID: 9069
		// (get) Token: 0x06010346 RID: 66374 RVA: 0x00062D90 File Offset: 0x00060F90
		[Token(Token = "0x1700236D")]
		public long battleNormalEndTime
		{
			[Token(Token = "0x6010346")]
			[Address(RVA = "0x7DD090", Offset = "0x7DBC90", VA = "0x1807DD090")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700236E RID: 9070
		// (get) Token: 0x06010347 RID: 66375 RVA: 0x00062DA8 File Offset: 0x00060FA8
		[Token(Token = "0x1700236E")]
		public bool isSelfReady
		{
			[Token(Token = "0x6010347")]
			[Address(RVA = "0x7DDDE0", Offset = "0x7DC9E0", VA = "0x1807DDDE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700236F RID: 9071
		// (get) Token: 0x06010348 RID: 66376 RVA: 0x00062DC0 File Offset: 0x00060FC0
		[Token(Token = "0x1700236F")]
		public int chessCountInHand
		{
			[Token(Token = "0x6010348")]
			[Address(RVA = "0x7DD3B0", Offset = "0x7DBFB0", VA = "0x1807DD3B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17002370 RID: 9072
		// (get) Token: 0x06010349 RID: 66377 RVA: 0x00062DD8 File Offset: 0x00060FD8
		[Token(Token = "0x17002370")]
		public bool isHandOverflow
		{
			[Token(Token = "0x6010349")]
			[Address(RVA = "0x7DDBC0", Offset = "0x7DC7C0", VA = "0x1807DDBC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002371 RID: 9073
		// (get) Token: 0x0601034A RID: 66378 RVA: 0x00062DF0 File Offset: 0x00060FF0
		[Token(Token = "0x17002371")]
		public bool isHandCntFull
		{
			[Token(Token = "0x601034A")]
			[Address(RVA = "0x7DDB40", Offset = "0x7DC740", VA = "0x1807DDB40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17002372 RID: 9074
		// (get) Token: 0x0601034B RID: 66379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002372")]
		public List<PoolManager.ObjectConfig> chessPoolConfigs
		{
			[Token(Token = "0x601034B")]
			[Address(RVA = "0x7DD430", Offset = "0x7DC030", VA = "0x1807DD430")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002373 RID: 9075
		// (get) Token: 0x0601034C RID: 66380 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002373")]
		public AutoChessSquadModel chessSquadModel
		{
			[Token(Token = "0x601034C")]
			[Address(RVA = "0x7DD4A0", Offset = "0x7DC0A0", VA = "0x1807DD4A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002374 RID: 9076
		// (get) Token: 0x0601034D RID: 66381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002374")]
		public AutoChessPlayerDataModel.ScenePlayerData selfPlayerData
		{
			[Token(Token = "0x601034D")]
			[Address(RVA = "0x7DE500", Offset = "0x7DD100", VA = "0x1807DE500")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002375 RID: 9077
		// (get) Token: 0x0601034E RID: 66382 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002375")]
		public AutoChessPlayerDataModel.ScenePlayerData viewPlayerData
		{
			[Token(Token = "0x601034E")]
			[Address(RVA = "0x7DE6F0", Offset = "0x7DD2F0", VA = "0x1807DE6F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002376 RID: 9078
		// (get) Token: 0x0601034F RID: 66383 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002376")]
		public PlayerBattleData selfPlayerBattleData
		{
			[Token(Token = "0x601034F")]
			[Address(RVA = "0x7DE440", Offset = "0x7DD040", VA = "0x1807DE440")]
			get
			{
				return null;
			}
		}

		// Token: 0x17002377 RID: 9079
		// (get) Token: 0x06010350 RID: 66384 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06010351 RID: 66385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002377")]
		public SelfBattleData selfBattleData
		{
			[Token(Token = "0x6010350")]
			[Address(RVA = "0x7DE3E0", Offset = "0x7DCFE0", VA = "0x1807DE3E0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6010351")]
			[Address(RVA = "0x7DEF90", Offset = "0x7DDB90", VA = "0x1807DEF90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002378 RID: 9080
		// (get) Token: 0x06010352 RID: 66386 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06010353 RID: 66387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002378")]
		public HelpBattleData helpBattleData
		{
			[Token(Token = "0x6010352")]
			[Address(RVA = "0x7DD830", Offset = "0x7DC430", VA = "0x1807DD830")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6010353")]
			[Address(RVA = "0x7DECA0", Offset = "0x7DD8A0", VA = "0x1807DECA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17002379 RID: 9081
		// (get) Token: 0x06010354 RID: 66388 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06010355 RID: 66389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17002379")]
		public BossBattleData bossBattleData
		{
			[Token(Token = "0x6010354")]
			[Address(RVA = "0x7DD290", Offset = "0x7DBE90", VA = "0x1807DD290")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6010355")]
			[Address(RVA = "0x7DE9C0", Offset = "0x7DD5C0", VA = "0x1807DE9C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700237A RID: 9082
		// (get) Token: 0x06010356 RID: 66390 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06010357 RID: 66391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700237A")]
		public BossRoundInfo bossRoundInfo
		{
			[Token(Token = "0x6010356")]
			[Address(RVA = "0x7DD350", Offset = "0x7DBF50", VA = "0x1807DD350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6010357")]
			[Address(RVA = "0x7DEAC0", Offset = "0x7DD6C0", VA = "0x1807DEAC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700237B RID: 9083
		// (get) Token: 0x06010358 RID: 66392 RVA: 0x00062E08 File Offset: 0x00061008
		// (set) Token: 0x06010359 RID: 66393 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700237B")]
		public int stageRandomSeed
		{
			[Token(Token = "0x6010358")]
			[Address(RVA = "0x7DE690", Offset = "0x7DD290", VA = "0x1807DE690")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6010359")]
			[Address(RVA = "0x7DF080", Offset = "0x7DDC80", VA = "0x1807DF080")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700237C RID: 9084
		// (get) Token: 0x0601035A RID: 66394 RVA: 0x00062E20 File Offset: 0x00061020
		[Token(Token = "0x1700237C")]
		public bool lockedOnPlayerDead
		{
			[Token(Token = "0x601035A")]
			[Address(RVA = "0x7DDFE0", Offset = "0x7DCBE0", VA = "0x1807DDFE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700237D RID: 9085
		// (get) Token: 0x0601035B RID: 66395 RVA: 0x00062E38 File Offset: 0x00061038
		[Token(Token = "0x1700237D")]
		public bool dataLocked
		{
			[Token(Token = "0x601035B")]
			[Address(RVA = "0x7DD700", Offset = "0x7DC300", VA = "0x1807DD700")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700237E RID: 9086
		// (get) Token: 0x0601035C RID: 66396 RVA: 0x00062E50 File Offset: 0x00061050
		[Token(Token = "0x1700237E")]
		public bool dataDirty
		{
			[Token(Token = "0x601035C")]
			[Address(RVA = "0x7DD6A0", Offset = "0x7DC2A0", VA = "0x1807DD6A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601035D RID: 66397 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601035D")]
		[Address(RVA = "0x7DB260", Offset = "0x7D9E60", VA = "0x1807DB260")]
		public void Start(string activityId)
		{
		}

		// Token: 0x0601035E RID: 66398 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601035E")]
		[Address(RVA = "0x7DA740", Offset = "0x7D9340", VA = "0x1807DA740")]
		public void MarkDirty()
		{
		}

		// Token: 0x0601035F RID: 66399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601035F")]
		[Address(RVA = "0x7D94F0", Offset = "0x7D80F0", VA = "0x1807D94F0")]
		public ActAutoChessData GetAutoChessActData(string actId)
		{
			return null;
		}

		// Token: 0x06010360 RID: 66400 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010360")]
		[Address(RVA = "0x7D9690", Offset = "0x7D8290", VA = "0x1807D9690")]
		public AutoChessBattleMiscConfig GetAutoChessMiscConfig(string actId)
		{
			return null;
		}

		// Token: 0x06010361 RID: 66401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010361")]
		[Address(RVA = "0x7D9900", Offset = "0x7D8500", VA = "0x1807D9900")]
		public Dictionary<string, ChessSquad> GetChessSquadDB(int playerIndex)
		{
			return null;
		}

		// Token: 0x06010362 RID: 66402 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010362")]
		[Address(RVA = "0x7D9990", Offset = "0x7D8590", VA = "0x1807D9990")]
		public ChessSquad GetChessSquad(string chessId, int playerIndex)
		{
			return null;
		}

		// Token: 0x06010363 RID: 66403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010363")]
		[Address(RVA = "0x7D9B90", Offset = "0x7D8790", VA = "0x1807D9B90")]
		public void InitData(SceneGameData data, ScenePlayerStaticData playerStaticData)
		{
		}

		// Token: 0x06010364 RID: 66404 RVA: 0x00062E68 File Offset: 0x00061068
		[Token(Token = "0x6010364")]
		[Address(RVA = "0x7DB1C0", Offset = "0x7D9DC0", VA = "0x1807DB1C0")]
		public bool SetCurrentPlayerView(int index)
		{
			return default(bool);
		}

		// Token: 0x06010365 RID: 66405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010365")]
		[Address(RVA = "0x7DB750", Offset = "0x7DA350", VA = "0x1807DB750")]
		public void UpdateData(SceneStateData data)
		{
		}

		// Token: 0x06010366 RID: 66406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010366")]
		[Address(RVA = "0x7DBB30", Offset = "0x7DA730", VA = "0x1807DBB30")]
		public void UpdateData(SelfBattleData data)
		{
		}

		// Token: 0x06010367 RID: 66407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010367")]
		[Address(RVA = "0x7DBE00", Offset = "0x7DAA00", VA = "0x1807DBE00")]
		public void UpdateData(HelpBattleData data)
		{
		}

		// Token: 0x06010368 RID: 66408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010368")]
		[Address(RVA = "0x7DBA80", Offset = "0x7DA680", VA = "0x1807DBA80")]
		public void UpdateData(BossBattleData data)
		{
		}

		// Token: 0x06010369 RID: 66409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010369")]
		[Address(RVA = "0x7DBF60", Offset = "0x7DAB60", VA = "0x1807DBF60")]
		public void UpdateData(ScenePlayerRunTimeData data)
		{
		}

		// Token: 0x0601036A RID: 66410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601036A")]
		[Address(RVA = "0x7DC0D0", Offset = "0x7DACD0", VA = "0x1807DC0D0")]
		public void UpdatePlayerBattleData(int playerIndex)
		{
		}

		// Token: 0x0601036B RID: 66411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601036B")]
		[Address(RVA = "0x7DC920", Offset = "0x7DB520", VA = "0x1807DC920")]
		private void _SetPlayerMaxDeploymentCnt(int realCharLimit, PlayerSide side)
		{
		}

		// Token: 0x0601036C RID: 66412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601036C")]
		[Address(RVA = "0x7DBEB0", Offset = "0x7DAAB0", VA = "0x1807DBEB0")]
		public void UpdateData(PrepareStateData data)
		{
		}

		// Token: 0x0601036D RID: 66413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601036D")]
		[Address(RVA = "0x7DB9F0", Offset = "0x7DA5F0", VA = "0x1807DB9F0")]
		public void UpdateData(SpPrepareStateData data)
		{
		}

		// Token: 0x0601036E RID: 66414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601036E")]
		[Address(RVA = "0x7DBD20", Offset = "0x7DA920", VA = "0x1807DBD20")]
		public void UpdateData(SettleData data)
		{
		}

		// Token: 0x0601036F RID: 66415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601036F")]
		[Address(RVA = "0x7DBBE0", Offset = "0x7DA7E0", VA = "0x1807DBBE0")]
		public void UpdateData(BossRoundInfo data)
		{
		}

		// Token: 0x06010370 RID: 66416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010370")]
		[Address(RVA = "0x7DAF60", Offset = "0x7D9B60", VA = "0x1807DAF60")]
		public void PrepareForPrepareState()
		{
		}

		// Token: 0x06010371 RID: 66417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010371")]
		[Address(RVA = "0x7DB130", Offset = "0x7D9D30", VA = "0x1807DB130")]
		public void ResetPlayerView()
		{
		}

		// Token: 0x06010372 RID: 66418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010372")]
		[Address(RVA = "0x7DAD40", Offset = "0x7D9940", VA = "0x1807DAD40")]
		public void PrepareForBattleWaiting()
		{
		}

		// Token: 0x06010373 RID: 66419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010373")]
		[Address(RVA = "0x7DCA10", Offset = "0x7DB610", VA = "0x1807DCA10")]
		private void _UpdateBattlePlayerMaxDeploymentCnt()
		{
		}

		// Token: 0x06010374 RID: 66420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010374")]
		[Address(RVA = "0x7DA860", Offset = "0x7D9460", VA = "0x1807DA860")]
		public void OnPrepareGameLoaded()
		{
		}

		// Token: 0x06010375 RID: 66421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010375")]
		[Address(RVA = "0x7DA7A0", Offset = "0x7D93A0", VA = "0x1807DA7A0")]
		public void OnBattleStart()
		{
		}

		// Token: 0x06010376 RID: 66422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010376")]
		[Address(RVA = "0x7DC610", Offset = "0x7DB210", VA = "0x1807DC610")]
		public void _RefreshRightMapPlayer()
		{
		}

		// Token: 0x06010377 RID: 66423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010377")]
		[Address(RVA = "0x7DA5D0", Offset = "0x7D91D0", VA = "0x1807DA5D0")]
		public void LoadSelfBattlePlayer()
		{
		}

		// Token: 0x06010378 RID: 66424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010378")]
		[Address(RVA = "0x7DA390", Offset = "0x7D8F90", VA = "0x1807DA390")]
		public void LoadHelpBattlePlayer()
		{
		}

		// Token: 0x06010379 RID: 66425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010379")]
		[Address(RVA = "0x7D9F90", Offset = "0x7D8B90", VA = "0x1807D9F90")]
		public void LoadBossBattlePlayer()
		{
		}

		// Token: 0x0601037A RID: 66426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601037A")]
		[Address(RVA = "0x7DB030", Offset = "0x7D9C30", VA = "0x1807DB030")]
		public void PrepareForSelfBattle()
		{
		}

		// Token: 0x0601037B RID: 66427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601037B")]
		[Address(RVA = "0x7DAEB0", Offset = "0x7D9AB0", VA = "0x1807DAEB0")]
		public void PrepareForHelpBattle()
		{
		}

		// Token: 0x0601037C RID: 66428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601037C")]
		[Address(RVA = "0x7DADB0", Offset = "0x7D99B0", VA = "0x1807DADB0")]
		public void PrepareForBossBattle()
		{
		}

		// Token: 0x0601037D RID: 66429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601037D")]
		[Address(RVA = "0x7DC220", Offset = "0x7DAE20", VA = "0x1807DC220")]
		private void _PrepareMultiPlayerBattleData(List<int> players)
		{
		}

		// Token: 0x0601037E RID: 66430 RVA: 0x00062E80 File Offset: 0x00061080
		[Token(Token = "0x601037E")]
		[Address(RVA = "0x7D9820", Offset = "0x7D8420", VA = "0x1807D9820")]
		public int GetBondStackCount(string bondId, uint uid)
		{
			return 0;
		}

		// Token: 0x0601037F RID: 66431 RVA: 0x00062E98 File Offset: 0x00061098
		[Token(Token = "0x601037F")]
		[Address(RVA = "0x7D9420", Offset = "0x7D8020", VA = "0x1807D9420")]
		public int GetActiveBondCount(uint uid)
		{
			return 0;
		}

		// Token: 0x06010380 RID: 66432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010380")]
		[Address(RVA = "0x7D9A60", Offset = "0x7D8660", VA = "0x1807D9A60")]
		public AutoChessPlayerDataModel.ScenePlayerData GetScenePlayerData(uint uid)
		{
			return null;
		}

		// Token: 0x06010381 RID: 66433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010381")]
		[Address(RVA = "0x7DC060", Offset = "0x7DAC60", VA = "0x1807DC060")]
		public void UpdateLockState()
		{
		}

		// Token: 0x06010382 RID: 66434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010382")]
		[Address(RVA = "0x7DABF0", Offset = "0x7D97F0", VA = "0x1807DABF0")]
		public void OnTick()
		{
		}

		// Token: 0x06010383 RID: 66435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010383")]
		[Address(RVA = "0x7DAA30", Offset = "0x7D9630", VA = "0x1807DAA30")]
		public void OnRevChat(object arg)
		{
		}

		// Token: 0x06010384 RID: 66436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010384")]
		[Address(RVA = "0x7DA950", Offset = "0x7D9550", VA = "0x1807DA950")]
		public void OnRevBroadcast(object arg)
		{
		}

		// Token: 0x06010385 RID: 66437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010385")]
		[Address(RVA = "0x7DAB10", Offset = "0x7D9710", VA = "0x1807DAB10")]
		public void OnServerLost(object arg)
		{
		}

		// Token: 0x06010386 RID: 66438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010386")]
		[Address(RVA = "0x7DCAA0", Offset = "0x7DB6A0", VA = "0x1807DCAA0")]
		public AutoChessDataCenter()
		{
		}

		// Token: 0x040121D1 RID: 74193
		[Token(Token = "0x40121D1")]
		[FieldOffset(Offset = "0x9C")]
		private bool m_isDirty;

		// Token: 0x040121D2 RID: 74194
		[Token(Token = "0x40121D2")]
		[FieldOffset(Offset = "0xA0")]
		private AutoChessDataCenter.DataChecker m_lockChecker;

		// Token: 0x040121D3 RID: 74195
		[Token(Token = "0x40121D3")]
		[FieldOffset(Offset = "0xA8")]
		private AutoChessSquadModel m_chessSquadModel;

		// Token: 0x040121D4 RID: 74196
		[Token(Token = "0x40121D4")]
		[FieldOffset(Offset = "0xB0")]
		private PlayerBattleData m_multiPlayerBattleData;

		// Token: 0x040121D5 RID: 74197
		[Token(Token = "0x40121D5")]
		[FieldOffset(Offset = "0xB8")]
		private List<int> m_battlePlayerIndex;

		// Token: 0x040121D6 RID: 74198
		[Token(Token = "0x40121D6")]
		[FieldOffset(Offset = "0xC0")]
		private HashSet<int> m_rightMapPlayerIndex;

		// Token: 0x040121D7 RID: 74199
		[Token(Token = "0x40121D7")]
		[FieldOffset(Offset = "0xC8")]
		private int m_deadObIndex;

		// Token: 0x040121D8 RID: 74200
		[Token(Token = "0x40121D8")]
		[FieldOffset(Offset = "0xCC")]
		private int m_playerViewIndex;

		// Token: 0x040121D9 RID: 74201
		[Token(Token = "0x40121D9")]
		[FieldOffset(Offset = "0xD0")]
		public AutoChessDataLockModel lockModel;

		// Token: 0x040121DA RID: 74202
		[Token(Token = "0x40121DA")]
		[FieldOffset(Offset = "0xD8")]
		public AutoChessBattleDataModel battleData;

		// Token: 0x040121DB RID: 74203
		[Token(Token = "0x40121DB")]
		[FieldOffset(Offset = "0xE0")]
		public AutoChessBattleStatusDataModel battleStatus;

		// Token: 0x040121DC RID: 74204
		[Token(Token = "0x40121DC")]
		[FieldOffset(Offset = "0xE8")]
		public AutoChessPlayerDataModel playerDataModel;

		// Token: 0x040121DD RID: 74205
		[Token(Token = "0x40121DD")]
		[FieldOffset(Offset = "0xF0")]
		public AutoChessShopDataModel shopDataModel;

		// Token: 0x040121DE RID: 74206
		[Token(Token = "0x40121DE")]
		[FieldOffset(Offset = "0xF8")]
		public AutoChessEffectChooseDataModel effectChooseDataModel;

		// Token: 0x040121DF RID: 74207
		[Token(Token = "0x40121DF")]
		[FieldOffset(Offset = "0x100")]
		public AutoChessSettleDataModel settleDataModel;

		// Token: 0x040121E0 RID: 74208
		[Token(Token = "0x40121E0")]
		[FieldOffset(Offset = "0x108")]
		public AutoChessDataIndexer indexer;

		// Token: 0x040121E1 RID: 74209
		[Token(Token = "0x40121E1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_instanceOrNull;

		// Token: 0x040121E2 RID: 74210
		[Token(Token = "0x40121E2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_actId;

		// Token: 0x040121E3 RID: 74211
		[Token(Token = "0x40121E3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_actId;

		// Token: 0x040121E4 RID: 74212
		[Token(Token = "0x40121E4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_actData;

		// Token: 0x040121E5 RID: 74213
		[Token(Token = "0x40121E5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_actData;

		// Token: 0x040121E6 RID: 74214
		[Token(Token = "0x40121E6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_miscConfig;

		// Token: 0x040121E7 RID: 74215
		[Token(Token = "0x40121E7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_miscConfig;

		// Token: 0x040121E8 RID: 74216
		[Token(Token = "0x40121E8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_currentModeData;

		// Token: 0x040121E9 RID: 74217
		[Token(Token = "0x40121E9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_currentModeData;

		// Token: 0x040121EA RID: 74218
		[Token(Token = "0x40121EA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_battlePlayerIndex;

		// Token: 0x040121EB RID: 74219
		[Token(Token = "0x40121EB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_rightMapPlayerIndex;

		// Token: 0x040121EC RID: 74220
		[Token(Token = "0x40121EC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_isViewRightMapInPrepare;

		// Token: 0x040121ED RID: 74221
		[Token(Token = "0x40121ED")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_get_isMultiPlayerBattle;

		// Token: 0x040121EE RID: 74222
		[Token(Token = "0x40121EE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_isMultiPlayerHelp;

		// Token: 0x040121EF RID: 74223
		[Token(Token = "0x40121EF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_get_selfPlayerIndex;

		// Token: 0x040121F0 RID: 74224
		[Token(Token = "0x40121F0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_set_selfPlayerIndex;

		// Token: 0x040121F1 RID: 74225
		[Token(Token = "0x40121F1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_get_inObMode;

		// Token: 0x040121F2 RID: 74226
		[Token(Token = "0x40121F2")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_realPlayerIndex;

		// Token: 0x040121F3 RID: 74227
		[Token(Token = "0x40121F3")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_get_hasDeadObIndex;

		// Token: 0x040121F4 RID: 74228
		[Token(Token = "0x40121F4")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_playerViewIndex;

		// Token: 0x040121F5 RID: 74229
		[Token(Token = "0x40121F5")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_get_maxDeckChessCnt;

		// Token: 0x040121F6 RID: 74230
		[Token(Token = "0x40121F6")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_get_playerViewSide;

		// Token: 0x040121F7 RID: 74231
		[Token(Token = "0x40121F7")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_set_playerViewSide;

		// Token: 0x040121F8 RID: 74232
		[Token(Token = "0x40121F8")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_get_currentRound;

		// Token: 0x040121F9 RID: 74233
		[Token(Token = "0x40121F9")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_set_currentRound;

		// Token: 0x040121FA RID: 74234
		[Token(Token = "0x40121FA")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_get_inBossRound;

		// Token: 0x040121FB RID: 74235
		[Token(Token = "0x40121FB")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_get_battleSpecialEffects;

		// Token: 0x040121FC RID: 74236
		[Token(Token = "0x40121FC")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_set_battleSpecialEffects;

		// Token: 0x040121FD RID: 74237
		[Token(Token = "0x40121FD")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_get_lastBattleResult;

		// Token: 0x040121FE RID: 74238
		[Token(Token = "0x40121FE")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_set_lastBattleResult;

		// Token: 0x040121FF RID: 74239
		[Token(Token = "0x40121FF")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_get_currentLevelData;

		// Token: 0x04012200 RID: 74240
		[Token(Token = "0x4012200")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_get_currentCoin;

		// Token: 0x04012201 RID: 74241
		[Token(Token = "0x4012201")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_get_shopLevel;

		// Token: 0x04012202 RID: 74242
		[Token(Token = "0x4012202")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_get_modeId;

		// Token: 0x04012203 RID: 74243
		[Token(Token = "0x4012203")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_set_modeId;

		// Token: 0x04012204 RID: 74244
		[Token(Token = "0x4012204")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_get_bannedBonds;

		// Token: 0x04012205 RID: 74245
		[Token(Token = "0x4012205")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_set_bannedBonds;

		// Token: 0x04012206 RID: 74246
		[Token(Token = "0x4012206")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_get_bossId;

		// Token: 0x04012207 RID: 74247
		[Token(Token = "0x4012207")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_set_bossId;

		// Token: 0x04012208 RID: 74248
		[Token(Token = "0x4012208")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_get_hiddenBossId;

		// Token: 0x04012209 RID: 74249
		[Token(Token = "0x4012209")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_set_hiddenBossId;

		// Token: 0x0401220A RID: 74250
		[Token(Token = "0x401220A")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0_get_forceEndTime;

		// Token: 0x0401220B RID: 74251
		[Token(Token = "0x401220B")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_set_forceEndTime;

		// Token: 0x0401220C RID: 74252
		[Token(Token = "0x401220C")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_get_battleStartTime;

		// Token: 0x0401220D RID: 74253
		[Token(Token = "0x401220D")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0_get_battleNormalEndTime;

		// Token: 0x0401220E RID: 74254
		[Token(Token = "0x401220E")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0_get_isSelfReady;

		// Token: 0x0401220F RID: 74255
		[Token(Token = "0x401220F")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0_get_chessCountInHand;

		// Token: 0x04012210 RID: 74256
		[Token(Token = "0x4012210")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0_get_isHandOverflow;

		// Token: 0x04012211 RID: 74257
		[Token(Token = "0x4012211")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0_get_isHandCntFull;

		// Token: 0x04012212 RID: 74258
		[Token(Token = "0x4012212")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_get_chessPoolConfigs;

		// Token: 0x04012213 RID: 74259
		[Token(Token = "0x4012213")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_get_chessSquadModel;

		// Token: 0x04012214 RID: 74260
		[Token(Token = "0x4012214")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_get_selfPlayerData;

		// Token: 0x04012215 RID: 74261
		[Token(Token = "0x4012215")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_get_viewPlayerData;

		// Token: 0x04012216 RID: 74262
		[Token(Token = "0x4012216")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_get_selfPlayerBattleData;

		// Token: 0x04012217 RID: 74263
		[Token(Token = "0x4012217")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_get_selfBattleData;

		// Token: 0x04012218 RID: 74264
		[Token(Token = "0x4012218")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_set_selfBattleData;

		// Token: 0x04012219 RID: 74265
		[Token(Token = "0x4012219")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_get_helpBattleData;

		// Token: 0x0401221A RID: 74266
		[Token(Token = "0x401221A")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0_set_helpBattleData;

		// Token: 0x0401221B RID: 74267
		[Token(Token = "0x401221B")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_get_bossBattleData;

		// Token: 0x0401221C RID: 74268
		[Token(Token = "0x401221C")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_set_bossBattleData;

		// Token: 0x0401221D RID: 74269
		[Token(Token = "0x401221D")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0_get_bossRoundInfo;

		// Token: 0x0401221E RID: 74270
		[Token(Token = "0x401221E")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0_set_bossRoundInfo;

		// Token: 0x0401221F RID: 74271
		[Token(Token = "0x401221F")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_get_stageRandomSeed;

		// Token: 0x04012220 RID: 74272
		[Token(Token = "0x4012220")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_set_stageRandomSeed;

		// Token: 0x04012221 RID: 74273
		[Token(Token = "0x4012221")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_get_lockedOnPlayerDead;

		// Token: 0x04012222 RID: 74274
		[Token(Token = "0x4012222")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_get_dataLocked;

		// Token: 0x04012223 RID: 74275
		[Token(Token = "0x4012223")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_get_dataDirty;

		// Token: 0x04012224 RID: 74276
		[Token(Token = "0x4012224")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04012225 RID: 74277
		[Token(Token = "0x4012225")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_MarkDirty;

		// Token: 0x04012226 RID: 74278
		[Token(Token = "0x4012226")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0_GetAutoChessActData;

		// Token: 0x04012227 RID: 74279
		[Token(Token = "0x4012227")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0_GetAutoChessMiscConfig;

		// Token: 0x04012228 RID: 74280
		[Token(Token = "0x4012228")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_GetChessSquadDB;

		// Token: 0x04012229 RID: 74281
		[Token(Token = "0x4012229")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_GetChessSquad;

		// Token: 0x0401222A RID: 74282
		[Token(Token = "0x401222A")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0401222B RID: 74283
		[Token(Token = "0x401222B")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_SetCurrentPlayerView;

		// Token: 0x0401222C RID: 74284
		[Token(Token = "0x401222C")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_UpdateData;

		// Token: 0x0401222D RID: 74285
		[Token(Token = "0x401222D")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix1_UpdateData;

		// Token: 0x0401222E RID: 74286
		[Token(Token = "0x401222E")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix2_UpdateData;

		// Token: 0x0401222F RID: 74287
		[Token(Token = "0x401222F")]
		[FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix3_UpdateData;

		// Token: 0x04012230 RID: 74288
		[Token(Token = "0x4012230")]
		[FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix4_UpdateData;

		// Token: 0x04012231 RID: 74289
		[Token(Token = "0x4012231")]
		[FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_UpdatePlayerBattleData;

		// Token: 0x04012232 RID: 74290
		[Token(Token = "0x4012232")]
		[FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0__SetPlayerMaxDeploymentCnt;

		// Token: 0x04012233 RID: 74291
		[Token(Token = "0x4012233")]
		[FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix5_UpdateData;

		// Token: 0x04012234 RID: 74292
		[Token(Token = "0x4012234")]
		[FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix6_UpdateData;

		// Token: 0x04012235 RID: 74293
		[Token(Token = "0x4012235")]
		[FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix7_UpdateData;

		// Token: 0x04012236 RID: 74294
		[Token(Token = "0x4012236")]
		[FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix8_UpdateData;

		// Token: 0x04012237 RID: 74295
		[Token(Token = "0x4012237")]
		[FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_PrepareForPrepareState;

		// Token: 0x04012238 RID: 74296
		[Token(Token = "0x4012238")]
		[FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_ResetPlayerView;

		// Token: 0x04012239 RID: 74297
		[Token(Token = "0x4012239")]
		[FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_PrepareForBattleWaiting;

		// Token: 0x0401223A RID: 74298
		[Token(Token = "0x401223A")]
		[FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0__UpdateBattlePlayerMaxDeploymentCnt;

		// Token: 0x0401223B RID: 74299
		[Token(Token = "0x401223B")]
		[FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_OnPrepareGameLoaded;

		// Token: 0x0401223C RID: 74300
		[Token(Token = "0x401223C")]
		[FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0_OnBattleStart;

		// Token: 0x0401223D RID: 74301
		[Token(Token = "0x401223D")]
		[FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0__RefreshRightMapPlayer;

		// Token: 0x0401223E RID: 74302
		[Token(Token = "0x401223E")]
		[FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_LoadSelfBattlePlayer;

		// Token: 0x0401223F RID: 74303
		[Token(Token = "0x401223F")]
		[FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_LoadHelpBattlePlayer;

		// Token: 0x04012240 RID: 74304
		[Token(Token = "0x4012240")]
		[FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0_LoadBossBattlePlayer;

		// Token: 0x04012241 RID: 74305
		[Token(Token = "0x4012241")]
		[FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0_PrepareForSelfBattle;

		// Token: 0x04012242 RID: 74306
		[Token(Token = "0x4012242")]
		[FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_PrepareForHelpBattle;

		// Token: 0x04012243 RID: 74307
		[Token(Token = "0x4012243")]
		[FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0_PrepareForBossBattle;

		// Token: 0x04012244 RID: 74308
		[Token(Token = "0x4012244")]
		[FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0__PrepareMultiPlayerBattleData;

		// Token: 0x04012245 RID: 74309
		[Token(Token = "0x4012245")]
		[FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_GetBondStackCount;

		// Token: 0x04012246 RID: 74310
		[Token(Token = "0x4012246")]
		[FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_GetActiveBondCount;

		// Token: 0x04012247 RID: 74311
		[Token(Token = "0x4012247")]
		[FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_GetScenePlayerData;

		// Token: 0x04012248 RID: 74312
		[Token(Token = "0x4012248")]
		[FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_UpdateLockState;

		// Token: 0x04012249 RID: 74313
		[Token(Token = "0x4012249")]
		[FieldOffset(Offset = "0x340")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0401224A RID: 74314
		[Token(Token = "0x401224A")]
		[FieldOffset(Offset = "0x348")]
		private static DelegateBridge __Hotfix0_OnRevChat;

		// Token: 0x0401224B RID: 74315
		[Token(Token = "0x401224B")]
		[FieldOffset(Offset = "0x350")]
		private static DelegateBridge __Hotfix0_OnRevBroadcast;

		// Token: 0x0401224C RID: 74316
		[Token(Token = "0x401224C")]
		[FieldOffset(Offset = "0x358")]
		private static DelegateBridge __Hotfix0_OnServerLost;

		// Token: 0x0401224D RID: 74317
		[Token(Token = "0x401224D")]
		[FieldOffset(Offset = "0x360")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020026F1 RID: 9969
		[Token(Token = "0x20026F1")]
		public interface AutoChessDataModelIgnoreLock
		{
		}

		// Token: 0x020026F2 RID: 9970
		[Token(Token = "0x20026F2")]
		public abstract class AutoChessDataModelBase : IHotfixable
		{
			// Token: 0x06010387 RID: 66439 RVA: 0x00062EB0 File Offset: 0x000610B0
			[Token(Token = "0x6010387")]
			[Address(RVA = "0x7E1BE0", Offset = "0x7E07E0", VA = "0x1807E1BE0", Slot = "4")]
			public virtual bool CheckDirty(ref int checkSeq)
			{
				return default(bool);
			}

			// Token: 0x06010388 RID: 66440 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010388")]
			[Address(RVA = "0x7E1C60", Offset = "0x7E0860", VA = "0x1807E1C60")]
			public void MarkDirty()
			{
			}

			// Token: 0x06010389 RID: 66441 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010389")]
			[Address(RVA = "0x7E1D30", Offset = "0x7E0930", VA = "0x1807E1D30")]
			protected AutoChessDataModelBase()
			{
			}

			// Token: 0x0401224E RID: 74318
			[Token(Token = "0x401224E")]
			[FieldOffset(Offset = "0x10")]
			private int m_seqNum;

			// Token: 0x0401224F RID: 74319
			[Token(Token = "0x401224F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CheckDirty;

			// Token: 0x04012250 RID: 74320
			[Token(Token = "0x4012250")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_MarkDirty;

			// Token: 0x04012251 RID: 74321
			[Token(Token = "0x4012251")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020026F3 RID: 9971
		[Token(Token = "0x20026F3")]
		public class DataChecker : IHotfixable
		{
			// Token: 0x0601038A RID: 66442 RVA: 0x00062EC8 File Offset: 0x000610C8
			[Token(Token = "0x601038A")]
			[Address(RVA = "0x7E6990", Offset = "0x7E5590", VA = "0x1807E6990")]
			public bool IsDirty(AutoChessDataCenter.AutoChessDataModelBase model)
			{
				return default(bool);
			}

			// Token: 0x0601038B RID: 66443 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601038B")]
			[Address(RVA = "0x7E6A70", Offset = "0x7E5670", VA = "0x1807E6A70")]
			public DataChecker()
			{
			}

			// Token: 0x04012252 RID: 74322
			[Token(Token = "0x4012252")]
			[FieldOffset(Offset = "0x10")]
			private int m_seqNum;

			// Token: 0x04012253 RID: 74323
			[Token(Token = "0x4012253")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsDirty;

			// Token: 0x04012254 RID: 74324
			[Token(Token = "0x4012254")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
