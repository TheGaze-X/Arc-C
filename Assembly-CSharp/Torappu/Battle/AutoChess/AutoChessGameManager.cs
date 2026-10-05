using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.Battle.DataCenter;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x02002743 RID: 10051
	[Token(Token = "0x2002743")]
	public class AutoChessGameManager : SingletonWithMonoHost<AutoChessGameManager, BattleController>, IDisposable
	{
		// Token: 0x1700239C RID: 9116
		// (get) Token: 0x0601056B RID: 66923 RVA: 0x00063810 File Offset: 0x00061A10
		// (set) Token: 0x0601056C RID: 66924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700239C")]
		public DateTime startTime
		{
			[Token(Token = "0x601056B")]
			[Address(RVA = "0x814010", Offset = "0x812C10", VA = "0x180814010")]
			[CompilerGenerated]
			get
			{
				return default(DateTime);
			}
			[Token(Token = "0x601056C")]
			[Address(RVA = "0x814370", Offset = "0x812F70", VA = "0x180814370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700239D RID: 9117
		// (get) Token: 0x0601056D RID: 66925 RVA: 0x00063828 File Offset: 0x00061A28
		[Token(Token = "0x1700239D")]
		public DateTime currentTime
		{
			[Token(Token = "0x601056D")]
			[Address(RVA = "0x813B80", Offset = "0x812780", VA = "0x180813B80")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x1700239E RID: 9118
		// (get) Token: 0x0601056E RID: 66926 RVA: 0x00063840 File Offset: 0x00061A40
		// (set) Token: 0x0601056F RID: 66927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700239E")]
		public bool isTrainingMode
		{
			[Token(Token = "0x601056E")]
			[Address(RVA = "0x813E50", Offset = "0x812A50", VA = "0x180813E50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601056F")]
			[Address(RVA = "0x814220", Offset = "0x812E20", VA = "0x180814220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700239F RID: 9119
		// (get) Token: 0x06010570 RID: 66928 RVA: 0x00063858 File Offset: 0x00061A58
		// (set) Token: 0x06010571 RID: 66929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700239F")]
		public bool gameWinned
		{
			[Token(Token = "0x6010570")]
			[Address(RVA = "0x813C10", Offset = "0x812810", VA = "0x180813C10")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6010571")]
			[Address(RVA = "0x8140D0", Offset = "0x812CD0", VA = "0x1808140D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170023A0 RID: 9120
		// (get) Token: 0x06010572 RID: 66930 RVA: 0x00063870 File Offset: 0x00061A70
		// (set) Token: 0x06010573 RID: 66931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170023A0")]
		public bool inStepMode
		{
			[Token(Token = "0x6010572")]
			[Address(RVA = "0x813D90", Offset = "0x812990", VA = "0x180813D90")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6010573")]
			[Address(RVA = "0x814140", Offset = "0x812D40", VA = "0x180814140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170023A1 RID: 9121
		// (get) Token: 0x06010574 RID: 66932 RVA: 0x00063888 File Offset: 0x00061A88
		// (set) Token: 0x06010575 RID: 66933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170023A1")]
		public bool paused
		{
			[Token(Token = "0x6010574")]
			[Address(RVA = "0x813F50", Offset = "0x812B50", VA = "0x180813F50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6010575")]
			[Address(RVA = "0x814290", Offset = "0x812E90", VA = "0x180814290")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170023A2 RID: 9122
		// (get) Token: 0x06010576 RID: 66934 RVA: 0x000638A0 File Offset: 0x00061AA0
		// (set) Token: 0x06010577 RID: 66935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170023A2")]
		public AutoChessGameStateType serverState
		{
			[Token(Token = "0x6010576")]
			[Address(RVA = "0x813FB0", Offset = "0x812BB0", VA = "0x180813FB0")]
			[CompilerGenerated]
			get
			{
				return AutoChessGameStateType.NONE;
			}
			[Token(Token = "0x6010577")]
			[Address(RVA = "0x814300", Offset = "0x812F00", VA = "0x180814300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170023A3 RID: 9123
		// (get) Token: 0x06010578 RID: 66936 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06010579 RID: 66937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170023A3")]
		public TrainingModeSettleData trainingSettleData
		{
			[Token(Token = "0x6010578")]
			[Address(RVA = "0x814070", Offset = "0x812C70", VA = "0x180814070")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6010579")]
			[Address(RVA = "0x8143E0", Offset = "0x812FE0", VA = "0x1808143E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170023A4 RID: 9124
		// (get) Token: 0x0601057A RID: 66938 RVA: 0x000638B8 File Offset: 0x00061AB8
		// (set) Token: 0x0601057B RID: 66939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170023A4")]
		public bool isFromUserPause
		{
			[Token(Token = "0x601057A")]
			[Address(RVA = "0x813DF0", Offset = "0x8129F0", VA = "0x180813DF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x601057B")]
			[Address(RVA = "0x8141B0", Offset = "0x812DB0", VA = "0x1808141B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170023A5 RID: 9125
		// (get) Token: 0x0601057C RID: 66940 RVA: 0x000638D0 File Offset: 0x00061AD0
		[Token(Token = "0x170023A5")]
		public SpeedLevel hookSpeedLevel
		{
			[Token(Token = "0x601057C")]
			[Address(RVA = "0x813C70", Offset = "0x812870", VA = "0x180813C70")]
			get
			{
				return SpeedLevel.SLOW_MOTION;
			}
		}

		// Token: 0x0601057D RID: 66941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601057D")]
		[Address(RVA = "0x813500", Offset = "0x812100", VA = "0x180813500")]
		private AutoChessGameManager()
		{
		}

		// Token: 0x170023A6 RID: 9126
		// (get) Token: 0x0601057E RID: 66942 RVA: 0x000638E8 File Offset: 0x00061AE8
		[Token(Token = "0x170023A6")]
		private bool needLogicTick
		{
			[Token(Token = "0x601057E")]
			[Address(RVA = "0x813EB0", Offset = "0x812AB0", VA = "0x180813EB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0601057F RID: 66943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601057F")]
		[Address(RVA = "0x80C480", Offset = "0x80B080", VA = "0x18080C480", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06010580 RID: 66944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010580")]
		[Address(RVA = "0x80DD70", Offset = "0x80C970", VA = "0x18080DD70")]
		public void OnTick(Action doDefaultTick)
		{
		}

		// Token: 0x06010581 RID: 66945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010581")]
		[Address(RVA = "0x80CAA0", Offset = "0x80B6A0", VA = "0x18080CAA0")]
		public void ManualFrameTick()
		{
		}

		// Token: 0x06010582 RID: 66946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010582")]
		[Address(RVA = "0x812F20", Offset = "0x811B20", VA = "0x180812F20")]
		private void _PreTick()
		{
		}

		// Token: 0x06010583 RID: 66947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010583")]
		[Address(RVA = "0x8131C0", Offset = "0x811DC0", VA = "0x1808131C0")]
		private void _TickUnitAnimator()
		{
		}

		// Token: 0x06010584 RID: 66948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010584")]
		[Address(RVA = "0x812C10", Offset = "0x811810", VA = "0x180812C10")]
		private void _OnDataDirty()
		{
		}

		// Token: 0x06010585 RID: 66949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010585")]
		[Address(RVA = "0x8110C0", Offset = "0x80FCC0", VA = "0x1808110C0")]
		public void Start()
		{
		}

		// Token: 0x06010586 RID: 66950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010586")]
		[Address(RVA = "0x80E810", Offset = "0x80D410", VA = "0x18080E810")]
		public void QuitGame(bool isGiveUp = true)
		{
		}

		// Token: 0x06010587 RID: 66951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010587")]
		[Address(RVA = "0x80E910", Offset = "0x80D510", VA = "0x18080E910")]
		public void QuitTrainingGame(bool isWin)
		{
		}

		// Token: 0x06010588 RID: 66952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010588")]
		[Address(RVA = "0x80E0F0", Offset = "0x80CCF0", VA = "0x18080E0F0")]
		public void PauseSingleModeGame()
		{
		}

		// Token: 0x06010589 RID: 66953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010589")]
		[Address(RVA = "0x811EE0", Offset = "0x810AE0", VA = "0x180811EE0")]
		private void _ClosePluginPage()
		{
		}

		// Token: 0x0601058A RID: 66954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601058A")]
		[Address(RVA = "0x80D940", Offset = "0x80C540", VA = "0x18080D940")]
		public void OnFinishGame(BattleController.GameResult result)
		{
		}

		// Token: 0x0601058B RID: 66955 RVA: 0x00063900 File Offset: 0x00061B00
		[Token(Token = "0x601058B")]
		[Address(RVA = "0x80CDE0", Offset = "0x80B9E0", VA = "0x18080CDE0")]
		public bool OnDestroyEntity(Entity entity, Entity.FinishReason reason)
		{
			return default(bool);
		}

		// Token: 0x0601058C RID: 66956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601058C")]
		[Address(RVA = "0x80CF60", Offset = "0x80BB60", VA = "0x18080CF60")]
		public void OnEnemyFirstEnterLeftMap()
		{
		}

		// Token: 0x0601058D RID: 66957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601058D")]
		[Address(RVA = "0x80E6E0", Offset = "0x80D2E0", VA = "0x18080E6E0")]
		public void PreprocessEnemy(LevelData.EnemyData data)
		{
		}

		// Token: 0x0601058E RID: 66958 RVA: 0x00063918 File Offset: 0x00061B18
		[Token(Token = "0x601058E")]
		[Address(RVA = "0x80D730", Offset = "0x80C330", VA = "0x18080D730")]
		public bool OnEntityApplyModifier(Entity entity, ref Modifier modifier)
		{
			return default(bool);
		}

		// Token: 0x0601058F RID: 66959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601058F")]
		[Address(RVA = "0x80D5B0", Offset = "0x80C1B0", VA = "0x18080D5B0")]
		public void OnEnemyRegistered(Enemy enemy)
		{
		}

		// Token: 0x06010590 RID: 66960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010590")]
		[Address(RVA = "0x80CEA0", Offset = "0x80BAA0", VA = "0x18080CEA0")]
		public void OnEnemyFinished(Enemy enemy, Entity.FinishReason reason)
		{
		}

		// Token: 0x06010591 RID: 66961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010591")]
		[Address(RVA = "0x80D000", Offset = "0x80BC00", VA = "0x18080D000")]
		public void OnEnemyKilled(Enemy enemy)
		{
		}

		// Token: 0x06010592 RID: 66962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010592")]
		[Address(RVA = "0x80D2C0", Offset = "0x80BEC0", VA = "0x18080D2C0")]
		public void OnEnemyReachExit(Enemy enemy)
		{
		}

		// Token: 0x06010593 RID: 66963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010593")]
		[Address(RVA = "0x812990", Offset = "0x811590", VA = "0x180812990")]
		private void _OnBossBattleEnemyKilled(Enemy enemy)
		{
		}

		// Token: 0x06010594 RID: 66964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010594")]
		[Address(RVA = "0x812AD0", Offset = "0x8116D0", VA = "0x180812AD0")]
		private void _OnBossBattleEnemyReachExit(Enemy enemy)
		{
		}

		// Token: 0x06010595 RID: 66965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010595")]
		[Address(RVA = "0x80F0A0", Offset = "0x80DCA0", VA = "0x18080F0A0")]
		public void ReqBattleSceneActionUp(int seq, List<AutoChessBattleStepActionData> actions)
		{
		}

		// Token: 0x06010596 RID: 66966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010596")]
		[Address(RVA = "0x811A60", Offset = "0x810660", VA = "0x180811A60")]
		public void UpdateGameState(AutoChessGameStateType newState, bool roundChanged)
		{
		}

		// Token: 0x06010597 RID: 66967 RVA: 0x00063930 File Offset: 0x00061B30
		[Token(Token = "0x6010597")]
		[Address(RVA = "0x812230", Offset = "0x810E30", VA = "0x180812230")]
		private AutoChessGameStateType _GetNextState(AutoChessGameStateType newState, bool roundChanged)
		{
			return AutoChessGameStateType.NONE;
		}

		// Token: 0x06010598 RID: 66968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010598")]
		[Address(RVA = "0x812D70", Offset = "0x811970", VA = "0x180812D70")]
		private void _OnGameStateChanged(int newStateId, int oldStateId)
		{
		}

		// Token: 0x06010599 RID: 66969 RVA: 0x00063948 File Offset: 0x00061B48
		[Token(Token = "0x6010599")]
		[Address(RVA = "0x812610", Offset = "0x811210", VA = "0x180812610")]
		private AutoChessGameStateType _GetRestartState(AutoChessGameStateType state)
		{
			return AutoChessGameStateType.NONE;
		}

		// Token: 0x0601059A RID: 66970 RVA: 0x00063960 File Offset: 0x00061B60
		[Token(Token = "0x601059A")]
		[Address(RVA = "0x8127B0", Offset = "0x8113B0", VA = "0x1808127B0")]
		private bool _IsRestartState(AutoChessGameStateType state)
		{
			return default(bool);
		}

		// Token: 0x0601059B RID: 66971 RVA: 0x00063978 File Offset: 0x00061B78
		[Token(Token = "0x601059B")]
		[Address(RVA = "0x812830", Offset = "0x811430", VA = "0x180812830")]
		private bool _IsStateNeedWaiting(AutoChessGameStateType state)
		{
			return default(bool);
		}

		// Token: 0x0601059C RID: 66972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601059C")]
		[Address(RVA = "0x80DBF0", Offset = "0x80C7F0", VA = "0x18080DBF0")]
		public void OnServerLost(object arg)
		{
		}

		// Token: 0x0601059D RID: 66973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601059D")]
		[Address(RVA = "0x80DA70", Offset = "0x80C670", VA = "0x18080DA70")]
		public void OnReqGiveUp()
		{
		}

		// Token: 0x0601059E RID: 66974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601059E")]
		[Address(RVA = "0x80DB30", Offset = "0x80C730", VA = "0x18080DB30")]
		public void OnReqPrepareReady()
		{
		}

		// Token: 0x0601059F RID: 66975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601059F")]
		[Address(RVA = "0x810B70", Offset = "0x80F770", VA = "0x180810B70")]
		public void SetCharacterMenuShowed(bool enable)
		{
		}

		// Token: 0x060105A0 RID: 66976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105A0")]
		[Address(RVA = "0x810CC0", Offset = "0x80F8C0", VA = "0x180810CC0")]
		public void SetInUserInteract(bool enable)
		{
		}

		// Token: 0x060105A1 RID: 66977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105A1")]
		[Address(RVA = "0x80C510", Offset = "0x80B110", VA = "0x18080C510")]
		protected void DoLoadGameInternal()
		{
		}

		// Token: 0x060105A2 RID: 66978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105A2")]
		[Address(RVA = "0x80E520", Offset = "0x80D120", VA = "0x18080E520")]
		public void PrepareForPrepareState()
		{
		}

		// Token: 0x060105A3 RID: 66979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105A3")]
		[Address(RVA = "0x80CA20", Offset = "0x80B620", VA = "0x18080CA20")]
		public void FinishPrepare()
		{
		}

		// Token: 0x060105A4 RID: 66980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105A4")]
		[Address(RVA = "0x811FC0", Offset = "0x810BC0", VA = "0x180811FC0")]
		private void _FinishAllUnits()
		{
		}

		// Token: 0x060105A5 RID: 66981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105A5")]
		[Address(RVA = "0x80E380", Offset = "0x80CF80", VA = "0x18080E380")]
		public void PrepareForBattleWaiting()
		{
		}

		// Token: 0x060105A6 RID: 66982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105A6")]
		[Address(RVA = "0x80E1A0", Offset = "0x80CDA0", VA = "0x18080E1A0")]
		public void PreloadBattle()
		{
		}

		// Token: 0x060105A7 RID: 66983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105A7")]
		[Address(RVA = "0x8128B0", Offset = "0x8114B0", VA = "0x1808128B0")]
		private void _LoadBattlePlayer()
		{
		}

		// Token: 0x060105A8 RID: 66984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105A8")]
		[Address(RVA = "0x8126E0", Offset = "0x8112E0", VA = "0x1808126E0")]
		private void _InitBattleMapLayer()
		{
		}

		// Token: 0x060105A9 RID: 66985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105A9")]
		[Address(RVA = "0x80E3F0", Offset = "0x80CFF0", VA = "0x18080E3F0")]
		public void PrepareForBattle()
		{
		}

		// Token: 0x060105AA RID: 66986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105AA")]
		[Address(RVA = "0x810E10", Offset = "0x80FA10", VA = "0x180810E10")]
		public void StartBattle()
		{
		}

		// Token: 0x060105AB RID: 66987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105AB")]
		[Address(RVA = "0x80C990", Offset = "0x80B590", VA = "0x18080C990")]
		public void FinishBattle()
		{
		}

		// Token: 0x060105AC RID: 66988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105AC")]
		[Address(RVA = "0x80CD30", Offset = "0x80B930", VA = "0x18080CD30")]
		public void MoveToNextDataState()
		{
		}

		// Token: 0x060105AD RID: 66989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105AD")]
		[Address(RVA = "0x80FDE0", Offset = "0x80E9E0", VA = "0x18080FDE0")]
		public void ReqOpenShop(bool isOpen)
		{
		}

		// Token: 0x060105AE RID: 66990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105AE")]
		[Address(RVA = "0x80F600", Offset = "0x80E200", VA = "0x18080F600")]
		public void ReqChangeShopSelectedSlot(int slotId)
		{
		}

		// Token: 0x060105AF RID: 66991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105AF")]
		[Address(RVA = "0x80F3C0", Offset = "0x80DFC0", VA = "0x18080F3C0")]
		public void ReqChangeBattleMapLayer(bool toRight)
		{
		}

		// Token: 0x060105B0 RID: 66992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105B0")]
		[Address(RVA = "0x811D10", Offset = "0x810910", VA = "0x180811D10")]
		private void _ChangeBattleMapLayer(AutoChessGameStatus.AutoChessBattleMapLayer mapLayer)
		{
		}

		// Token: 0x060105B1 RID: 66993 RVA: 0x00063990 File Offset: 0x00061B90
		[Token(Token = "0x60105B1")]
		[Address(RVA = "0x811C50", Offset = "0x810850", VA = "0x180811C50")]
		private bool _CanChangeBattleMapLayer()
		{
			return default(bool);
		}

		// Token: 0x060105B2 RID: 66994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105B2")]
		[Address(RVA = "0x80DCD0", Offset = "0x80C8D0", VA = "0x18080DCD0")]
		public void OnSetSelectedBond(string bondId)
		{
		}

		// Token: 0x060105B3 RID: 66995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105B3")]
		[Address(RVA = "0x80DF40", Offset = "0x80CB40", VA = "0x18080DF40")]
		public void OnToggleBondPanelDisplay()
		{
		}

		// Token: 0x060105B4 RID: 66996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105B4")]
		[Address(RVA = "0x80E050", Offset = "0x80CC50", VA = "0x18080E050")]
		public void OnToggleHUDPlayerInfo()
		{
		}

		// Token: 0x060105B5 RID: 66997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105B5")]
		[Address(RVA = "0x80DFD0", Offset = "0x80CBD0", VA = "0x18080DFD0")]
		public void OnToggleHUDEnemyInfo()
		{
		}

		// Token: 0x060105B6 RID: 66998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105B6")]
		[Address(RVA = "0x80DA10", Offset = "0x80C610", VA = "0x18080DA10")]
		public void OnHUDCancelDialog()
		{
		}

		// Token: 0x060105B7 RID: 66999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105B7")]
		[Address(RVA = "0x80FAB0", Offset = "0x80E6B0", VA = "0x18080FAB0")]
		public void ReqInEnemyPreview(bool inEnemyPreview)
		{
		}

		// Token: 0x060105B8 RID: 67000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105B8")]
		[Address(RVA = "0x810210", Offset = "0x80EE10", VA = "0x180810210")]
		public void ReqReplaceEquip(int equipInstId, int charInstId)
		{
		}

		// Token: 0x060105B9 RID: 67001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105B9")]
		[Address(RVA = "0x8130F0", Offset = "0x811CF0", VA = "0x1808130F0")]
		private void _ReqHUDTipDisplay(AutoChessGameStatus.AutoChessHUDTipDisplay tipDisplay)
		{
		}

		// Token: 0x060105BA RID: 67002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105BA")]
		[Address(RVA = "0x80FC00", Offset = "0x80E800", VA = "0x18080FC00")]
		public void ReqMoveChess()
		{
		}

		// Token: 0x060105BB RID: 67003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105BB")]
		[Address(RVA = "0x810AD0", Offset = "0x80F6D0", VA = "0x180810AD0")]
		public void ReqUseMagic(int instId)
		{
		}

		// Token: 0x060105BC RID: 67004 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105BC")]
		[Address(RVA = "0x80F7C0", Offset = "0x80E3C0", VA = "0x18080F7C0")]
		public void ReqEquipItem(int equipInst, int targetInst, int replacedEquipInstId)
		{
		}

		// Token: 0x060105BD RID: 67005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105BD")]
		[Address(RVA = "0x810640", Offset = "0x80F240", VA = "0x180810640")]
		public void ReqSellOrDestroy(GridPosition gridPosition)
		{
		}

		// Token: 0x060105BE RID: 67006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105BE")]
		[Address(RVA = "0x810870", Offset = "0x80F470", VA = "0x180810870")]
		public void ReqShopFrozen(bool isFrozen)
		{
		}

		// Token: 0x060105BF RID: 67007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105BF")]
		[Address(RVA = "0x8109A0", Offset = "0x80F5A0", VA = "0x1808109A0")]
		public void ReqShopUpgrade()
		{
		}

		// Token: 0x060105C0 RID: 67008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105C0")]
		[Address(RVA = "0x810910", Offset = "0x80F510", VA = "0x180810910")]
		public void ReqShopRefresh()
		{
		}

		// Token: 0x060105C1 RID: 67009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105C1")]
		[Address(RVA = "0x80F170", Offset = "0x80DD70", VA = "0x18080F170")]
		public void ReqBuyChess(int slotId, bool isSpecial)
		{
		}

		// Token: 0x060105C2 RID: 67010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105C2")]
		[Address(RVA = "0x810070", Offset = "0x80EC70", VA = "0x180810070")]
		public void ReqReplaceEquipFinish(int replaceInstId, bool isCancel)
		{
		}

		// Token: 0x060105C3 RID: 67011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105C3")]
		[Address(RVA = "0x80FFD0", Offset = "0x80EBD0", VA = "0x18080FFD0")]
		public void ReqPrepareReady(bool isCurrReady)
		{
		}

		// Token: 0x060105C4 RID: 67012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105C4")]
		[Address(RVA = "0x810390", Offset = "0x80EF90", VA = "0x180810390")]
		public void ReqSelfBattleEnemyEscape(int enemyInstId, bool isToken)
		{
		}

		// Token: 0x060105C5 RID: 67013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105C5")]
		[Address(RVA = "0x810490", Offset = "0x80F090", VA = "0x180810490")]
		public void ReqSelfBattleEnemyKilled(BattleEnemyKilledInfo killedInfo)
		{
		}

		// Token: 0x060105C6 RID: 67014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105C6")]
		[Address(RVA = "0x80F920", Offset = "0x80E520", VA = "0x18080F920")]
		public void ReqHelpBattleEnemyEscape(int enemyInstId, bool isToken)
		{
		}

		// Token: 0x060105C7 RID: 67015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105C7")]
		[Address(RVA = "0x80F9E0", Offset = "0x80E5E0", VA = "0x18080F9E0")]
		public void ReqHelpBattleEnemyKilled(HelpBattleEnemyKilledInfo killedInfo)
		{
		}

		// Token: 0x060105C8 RID: 67016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105C8")]
		[Address(RVA = "0x80EF70", Offset = "0x80DB70", VA = "0x18080EF70")]
		public void ReqAddBondStackCount(int charInstId, List<string> bondIds, int count)
		{
		}

		// Token: 0x060105C9 RID: 67017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105C9")]
		[Address(RVA = "0x80FCC0", Offset = "0x80E8C0", VA = "0x18080FCC0")]
		public void ReqObOtherPlayer(int playerIndex)
		{
		}

		// Token: 0x060105CA RID: 67018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105CA")]
		[Address(RVA = "0x80F2A0", Offset = "0x80DEA0", VA = "0x18080F2A0")]
		public void ReqCancelOb()
		{
		}

		// Token: 0x060105CB RID: 67019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105CB")]
		[Address(RVA = "0x80F730", Offset = "0x80E330", VA = "0x18080F730")]
		public void ReqDeadAutoOb()
		{
		}

		// Token: 0x060105CC RID: 67020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105CC")]
		[Address(RVA = "0x810A30", Offset = "0x80F630", VA = "0x180810A30")]
		public void ReqSpPrepareSelect(int slotId)
		{
		}

		// Token: 0x060105CD RID: 67021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105CD")]
		[Address(RVA = "0x8105A0", Offset = "0x80F1A0", VA = "0x1808105A0")]
		public void ReqSelfChoiceSelect(int slotId)
		{
		}

		// Token: 0x060105CE RID: 67022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105CE")]
		[Address(RVA = "0x8107B0", Offset = "0x80F3B0", VA = "0x1808107B0")]
		public void ReqSendEmoji(string grp, string id)
		{
		}

		// Token: 0x060105CF RID: 67023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105CF")]
		[Address(RVA = "0x8106E0", Offset = "0x80F2E0", VA = "0x1808106E0")]
		public void ReqSendBroadcast(int playerIdx, string id, params string[] paramList)
		{
		}

		// Token: 0x060105D0 RID: 67024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105D0")]
		[Address(RVA = "0x80F890", Offset = "0x80E490", VA = "0x18080F890")]
		public void ReqGiveUp()
		{
		}

		// Token: 0x060105D1 RID: 67025 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105D1")]
		[Address(RVA = "0x80FF40", Offset = "0x80EB40", VA = "0x18080FF40")]
		public void ReqPauseSingleMode()
		{
		}

		// Token: 0x060105D2 RID: 67026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60105D2")]
		[Address(RVA = "0x810300", Offset = "0x80EF00", VA = "0x180810300")]
		public void ReqResumeSingleMode()
		{
		}

		// Token: 0x0401244F RID: 74831
		[Token(Token = "0x401244F")]
		[FieldOffset(Offset = "0x30")]
		public AutoChessGameStatus gameStatus;

		// Token: 0x04012450 RID: 74832
		[Token(Token = "0x4012450")]
		[FieldOffset(Offset = "0x38")]
		public AutoChessDataCenter dataCenter;

		// Token: 0x04012451 RID: 74833
		[Token(Token = "0x4012451")]
		[FieldOffset(Offset = "0x40")]
		protected AutoChessDataBridge dataBridge;

		// Token: 0x04012452 RID: 74834
		[Token(Token = "0x4012452")]
		[FieldOffset(Offset = "0x48")]
		public AutoChessStepModeManager stepModeManager;

		// Token: 0x04012453 RID: 74835
		[Token(Token = "0x4012453")]
		[FieldOffset(Offset = "0x50")]
		public AutoChessDummyManager dummyManager;

		// Token: 0x04012454 RID: 74836
		[Token(Token = "0x4012454")]
		[FieldOffset(Offset = "0x58")]
		public AutoChessPlayerOpManager playerOpManager;

		// Token: 0x04012455 RID: 74837
		[Token(Token = "0x4012455")]
		[FieldOffset(Offset = "0x60")]
		public AutoChessGarrisonManager garrisonManager;

		// Token: 0x04012456 RID: 74838
		[Token(Token = "0x4012456")]
		[FieldOffset(Offset = "0x68")]
		public AutoChessMapAreaManager mapAreaManager;

		// Token: 0x04012457 RID: 74839
		[Token(Token = "0x4012457")]
		[FieldOffset(Offset = "0x70")]
		public AutoChessTaskManager taskManager;

		// Token: 0x04012458 RID: 74840
		[Token(Token = "0x4012458")]
		[FieldOffset(Offset = "0x78")]
		public AutoChessLevelEnemyManager levelEnemyManager;

		// Token: 0x04012459 RID: 74841
		[Token(Token = "0x4012459")]
		[FieldOffset(Offset = "0x80")]
		public AutoChessEnemyPreviewManager enemyPreviewer;

		// Token: 0x0401245A RID: 74842
		[Token(Token = "0x401245A")]
		[FieldOffset(Offset = "0x88")]
		public AutoChessBroadcastParser broadcastParser;

		// Token: 0x0401245B RID: 74843
		[Token(Token = "0x401245B")]
		[FieldOffset(Offset = "0x90")]
		public AutoChessTutorialManager tutorialManager;

		// Token: 0x0401245C RID: 74844
		[Token(Token = "0x401245C")]
		[FieldOffset(Offset = "0x98")]
		public AutoChessEffectManager effectManager;

		// Token: 0x0401245D RID: 74845
		[Token(Token = "0x401245D")]
		[FieldOffset(Offset = "0xA0")]
		public ResourceCollector.ResourceCollectHandler battleResourceCollecter;

		// Token: 0x0401245E RID: 74846
		[Token(Token = "0x401245E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_startTime;

		// Token: 0x0401245F RID: 74847
		[Token(Token = "0x401245F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_startTime;

		// Token: 0x04012460 RID: 74848
		[Token(Token = "0x4012460")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_currentTime;

		// Token: 0x04012461 RID: 74849
		[Token(Token = "0x4012461")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_isTrainingMode;

		// Token: 0x04012462 RID: 74850
		[Token(Token = "0x4012462")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_set_isTrainingMode;

		// Token: 0x04012463 RID: 74851
		[Token(Token = "0x4012463")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_gameWinned;

		// Token: 0x04012464 RID: 74852
		[Token(Token = "0x4012464")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_set_gameWinned;

		// Token: 0x04012465 RID: 74853
		[Token(Token = "0x4012465")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_inStepMode;

		// Token: 0x04012466 RID: 74854
		[Token(Token = "0x4012466")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_set_inStepMode;

		// Token: 0x04012467 RID: 74855
		[Token(Token = "0x4012467")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_paused;

		// Token: 0x04012468 RID: 74856
		[Token(Token = "0x4012468")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_set_paused;

		// Token: 0x04012469 RID: 74857
		[Token(Token = "0x4012469")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_serverState;

		// Token: 0x0401246A RID: 74858
		[Token(Token = "0x401246A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_set_serverState;

		// Token: 0x0401246B RID: 74859
		[Token(Token = "0x401246B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_get_trainingSettleData;

		// Token: 0x0401246C RID: 74860
		[Token(Token = "0x401246C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_set_trainingSettleData;

		// Token: 0x0401246D RID: 74861
		[Token(Token = "0x401246D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_get_isFromUserPause;

		// Token: 0x0401246E RID: 74862
		[Token(Token = "0x401246E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_set_isFromUserPause;

		// Token: 0x0401246F RID: 74863
		[Token(Token = "0x401246F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_hookSpeedLevel;

		// Token: 0x04012470 RID: 74864
		[Token(Token = "0x4012470")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04012471 RID: 74865
		[Token(Token = "0x4012471")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_get_needLogicTick;

		// Token: 0x04012472 RID: 74866
		[Token(Token = "0x4012472")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_Dispose;

		// Token: 0x04012473 RID: 74867
		[Token(Token = "0x4012473")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04012474 RID: 74868
		[Token(Token = "0x4012474")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ManualFrameTick;

		// Token: 0x04012475 RID: 74869
		[Token(Token = "0x4012475")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__PreTick;

		// Token: 0x04012476 RID: 74870
		[Token(Token = "0x4012476")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__TickUnitAnimator;

		// Token: 0x04012477 RID: 74871
		[Token(Token = "0x4012477")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__OnDataDirty;

		// Token: 0x04012478 RID: 74872
		[Token(Token = "0x4012478")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04012479 RID: 74873
		[Token(Token = "0x4012479")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0_QuitGame;

		// Token: 0x0401247A RID: 74874
		[Token(Token = "0x401247A")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0_QuitTrainingGame;

		// Token: 0x0401247B RID: 74875
		[Token(Token = "0x401247B")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0_PauseSingleModeGame;

		// Token: 0x0401247C RID: 74876
		[Token(Token = "0x401247C")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__ClosePluginPage;

		// Token: 0x0401247D RID: 74877
		[Token(Token = "0x401247D")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0_OnFinishGame;

		// Token: 0x0401247E RID: 74878
		[Token(Token = "0x401247E")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0_OnDestroyEntity;

		// Token: 0x0401247F RID: 74879
		[Token(Token = "0x401247F")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0_OnEnemyFirstEnterLeftMap;

		// Token: 0x04012480 RID: 74880
		[Token(Token = "0x4012480")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_PreprocessEnemy;

		// Token: 0x04012481 RID: 74881
		[Token(Token = "0x4012481")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_OnEntityApplyModifier;

		// Token: 0x04012482 RID: 74882
		[Token(Token = "0x4012482")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_OnEnemyRegistered;

		// Token: 0x04012483 RID: 74883
		[Token(Token = "0x4012483")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_OnEnemyFinished;

		// Token: 0x04012484 RID: 74884
		[Token(Token = "0x4012484")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_OnEnemyKilled;

		// Token: 0x04012485 RID: 74885
		[Token(Token = "0x4012485")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_OnEnemyReachExit;

		// Token: 0x04012486 RID: 74886
		[Token(Token = "0x4012486")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__OnBossBattleEnemyKilled;

		// Token: 0x04012487 RID: 74887
		[Token(Token = "0x4012487")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__OnBossBattleEnemyReachExit;

		// Token: 0x04012488 RID: 74888
		[Token(Token = "0x4012488")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0_ReqBattleSceneActionUp;

		// Token: 0x04012489 RID: 74889
		[Token(Token = "0x4012489")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0_UpdateGameState;

		// Token: 0x0401248A RID: 74890
		[Token(Token = "0x401248A")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__GetNextState;

		// Token: 0x0401248B RID: 74891
		[Token(Token = "0x401248B")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__OnGameStateChanged;

		// Token: 0x0401248C RID: 74892
		[Token(Token = "0x401248C")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge __Hotfix0__GetRestartState;

		// Token: 0x0401248D RID: 74893
		[Token(Token = "0x401248D")]
		[FieldOffset(Offset = "0x178")]
		private static DelegateBridge __Hotfix0__IsRestartState;

		// Token: 0x0401248E RID: 74894
		[Token(Token = "0x401248E")]
		[FieldOffset(Offset = "0x180")]
		private static DelegateBridge __Hotfix0__IsStateNeedWaiting;

		// Token: 0x0401248F RID: 74895
		[Token(Token = "0x401248F")]
		[FieldOffset(Offset = "0x188")]
		private static DelegateBridge __Hotfix0_OnServerLost;

		// Token: 0x04012490 RID: 74896
		[Token(Token = "0x4012490")]
		[FieldOffset(Offset = "0x190")]
		private static DelegateBridge __Hotfix0_OnReqGiveUp;

		// Token: 0x04012491 RID: 74897
		[Token(Token = "0x4012491")]
		[FieldOffset(Offset = "0x198")]
		private static DelegateBridge __Hotfix0_OnReqPrepareReady;

		// Token: 0x04012492 RID: 74898
		[Token(Token = "0x4012492")]
		[FieldOffset(Offset = "0x1A0")]
		private static DelegateBridge __Hotfix0_SetCharacterMenuShowed;

		// Token: 0x04012493 RID: 74899
		[Token(Token = "0x4012493")]
		[FieldOffset(Offset = "0x1A8")]
		private static DelegateBridge __Hotfix0_SetInUserInteract;

		// Token: 0x04012494 RID: 74900
		[Token(Token = "0x4012494")]
		[FieldOffset(Offset = "0x1B0")]
		private static DelegateBridge __Hotfix0_DoLoadGameInternal;

		// Token: 0x04012495 RID: 74901
		[Token(Token = "0x4012495")]
		[FieldOffset(Offset = "0x1B8")]
		private static DelegateBridge __Hotfix0_PrepareForPrepareState;

		// Token: 0x04012496 RID: 74902
		[Token(Token = "0x4012496")]
		[FieldOffset(Offset = "0x1C0")]
		private static DelegateBridge __Hotfix0_FinishPrepare;

		// Token: 0x04012497 RID: 74903
		[Token(Token = "0x4012497")]
		[FieldOffset(Offset = "0x1C8")]
		private static DelegateBridge __Hotfix0__FinishAllUnits;

		// Token: 0x04012498 RID: 74904
		[Token(Token = "0x4012498")]
		[FieldOffset(Offset = "0x1D0")]
		private static DelegateBridge __Hotfix0_PrepareForBattleWaiting;

		// Token: 0x04012499 RID: 74905
		[Token(Token = "0x4012499")]
		[FieldOffset(Offset = "0x1D8")]
		private static DelegateBridge __Hotfix0_PreloadBattle;

		// Token: 0x0401249A RID: 74906
		[Token(Token = "0x401249A")]
		[FieldOffset(Offset = "0x1E0")]
		private static DelegateBridge __Hotfix0__LoadBattlePlayer;

		// Token: 0x0401249B RID: 74907
		[Token(Token = "0x401249B")]
		[FieldOffset(Offset = "0x1E8")]
		private static DelegateBridge __Hotfix0__InitBattleMapLayer;

		// Token: 0x0401249C RID: 74908
		[Token(Token = "0x401249C")]
		[FieldOffset(Offset = "0x1F0")]
		private static DelegateBridge __Hotfix0_PrepareForBattle;

		// Token: 0x0401249D RID: 74909
		[Token(Token = "0x401249D")]
		[FieldOffset(Offset = "0x1F8")]
		private static DelegateBridge __Hotfix0_StartBattle;

		// Token: 0x0401249E RID: 74910
		[Token(Token = "0x401249E")]
		[FieldOffset(Offset = "0x200")]
		private static DelegateBridge __Hotfix0_FinishBattle;

		// Token: 0x0401249F RID: 74911
		[Token(Token = "0x401249F")]
		[FieldOffset(Offset = "0x208")]
		private static DelegateBridge __Hotfix0_MoveToNextDataState;

		// Token: 0x040124A0 RID: 74912
		[Token(Token = "0x40124A0")]
		[FieldOffset(Offset = "0x210")]
		private static DelegateBridge __Hotfix0_ReqOpenShop;

		// Token: 0x040124A1 RID: 74913
		[Token(Token = "0x40124A1")]
		[FieldOffset(Offset = "0x218")]
		private static DelegateBridge __Hotfix0_ReqChangeShopSelectedSlot;

		// Token: 0x040124A2 RID: 74914
		[Token(Token = "0x40124A2")]
		[FieldOffset(Offset = "0x220")]
		private static DelegateBridge __Hotfix0_ReqChangeBattleMapLayer;

		// Token: 0x040124A3 RID: 74915
		[Token(Token = "0x40124A3")]
		[FieldOffset(Offset = "0x228")]
		private static DelegateBridge __Hotfix0__ChangeBattleMapLayer;

		// Token: 0x040124A4 RID: 74916
		[Token(Token = "0x40124A4")]
		[FieldOffset(Offset = "0x230")]
		private static DelegateBridge __Hotfix0__CanChangeBattleMapLayer;

		// Token: 0x040124A5 RID: 74917
		[Token(Token = "0x40124A5")]
		[FieldOffset(Offset = "0x238")]
		private static DelegateBridge __Hotfix0_OnSetSelectedBond;

		// Token: 0x040124A6 RID: 74918
		[Token(Token = "0x40124A6")]
		[FieldOffset(Offset = "0x240")]
		private static DelegateBridge __Hotfix0_OnToggleBondPanelDisplay;

		// Token: 0x040124A7 RID: 74919
		[Token(Token = "0x40124A7")]
		[FieldOffset(Offset = "0x248")]
		private static DelegateBridge __Hotfix0_OnToggleHUDPlayerInfo;

		// Token: 0x040124A8 RID: 74920
		[Token(Token = "0x40124A8")]
		[FieldOffset(Offset = "0x250")]
		private static DelegateBridge __Hotfix0_OnToggleHUDEnemyInfo;

		// Token: 0x040124A9 RID: 74921
		[Token(Token = "0x40124A9")]
		[FieldOffset(Offset = "0x258")]
		private static DelegateBridge __Hotfix0_OnHUDCancelDialog;

		// Token: 0x040124AA RID: 74922
		[Token(Token = "0x40124AA")]
		[FieldOffset(Offset = "0x260")]
		private static DelegateBridge __Hotfix0_ReqInEnemyPreview;

		// Token: 0x040124AB RID: 74923
		[Token(Token = "0x40124AB")]
		[FieldOffset(Offset = "0x268")]
		private static DelegateBridge __Hotfix0_ReqReplaceEquip;

		// Token: 0x040124AC RID: 74924
		[Token(Token = "0x40124AC")]
		[FieldOffset(Offset = "0x270")]
		private static DelegateBridge __Hotfix0__ReqHUDTipDisplay;

		// Token: 0x040124AD RID: 74925
		[Token(Token = "0x40124AD")]
		[FieldOffset(Offset = "0x278")]
		private static DelegateBridge __Hotfix0_ReqMoveChess;

		// Token: 0x040124AE RID: 74926
		[Token(Token = "0x40124AE")]
		[FieldOffset(Offset = "0x280")]
		private static DelegateBridge __Hotfix0_ReqUseMagic;

		// Token: 0x040124AF RID: 74927
		[Token(Token = "0x40124AF")]
		[FieldOffset(Offset = "0x288")]
		private static DelegateBridge __Hotfix0_ReqEquipItem;

		// Token: 0x040124B0 RID: 74928
		[Token(Token = "0x40124B0")]
		[FieldOffset(Offset = "0x290")]
		private static DelegateBridge __Hotfix0_ReqSellOrDestroy;

		// Token: 0x040124B1 RID: 74929
		[Token(Token = "0x40124B1")]
		[FieldOffset(Offset = "0x298")]
		private static DelegateBridge __Hotfix0_ReqShopFrozen;

		// Token: 0x040124B2 RID: 74930
		[Token(Token = "0x40124B2")]
		[FieldOffset(Offset = "0x2A0")]
		private static DelegateBridge __Hotfix0_ReqShopUpgrade;

		// Token: 0x040124B3 RID: 74931
		[Token(Token = "0x40124B3")]
		[FieldOffset(Offset = "0x2A8")]
		private static DelegateBridge __Hotfix0_ReqShopRefresh;

		// Token: 0x040124B4 RID: 74932
		[Token(Token = "0x40124B4")]
		[FieldOffset(Offset = "0x2B0")]
		private static DelegateBridge __Hotfix0_ReqBuyChess;

		// Token: 0x040124B5 RID: 74933
		[Token(Token = "0x40124B5")]
		[FieldOffset(Offset = "0x2B8")]
		private static DelegateBridge __Hotfix0_ReqReplaceEquipFinish;

		// Token: 0x040124B6 RID: 74934
		[Token(Token = "0x40124B6")]
		[FieldOffset(Offset = "0x2C0")]
		private static DelegateBridge __Hotfix0_ReqPrepareReady;

		// Token: 0x040124B7 RID: 74935
		[Token(Token = "0x40124B7")]
		[FieldOffset(Offset = "0x2C8")]
		private static DelegateBridge __Hotfix0_ReqSelfBattleEnemyEscape;

		// Token: 0x040124B8 RID: 74936
		[Token(Token = "0x40124B8")]
		[FieldOffset(Offset = "0x2D0")]
		private static DelegateBridge __Hotfix0_ReqSelfBattleEnemyKilled;

		// Token: 0x040124B9 RID: 74937
		[Token(Token = "0x40124B9")]
		[FieldOffset(Offset = "0x2D8")]
		private static DelegateBridge __Hotfix0_ReqHelpBattleEnemyEscape;

		// Token: 0x040124BA RID: 74938
		[Token(Token = "0x40124BA")]
		[FieldOffset(Offset = "0x2E0")]
		private static DelegateBridge __Hotfix0_ReqHelpBattleEnemyKilled;

		// Token: 0x040124BB RID: 74939
		[Token(Token = "0x40124BB")]
		[FieldOffset(Offset = "0x2E8")]
		private static DelegateBridge __Hotfix0_ReqAddBondStackCount;

		// Token: 0x040124BC RID: 74940
		[Token(Token = "0x40124BC")]
		[FieldOffset(Offset = "0x2F0")]
		private static DelegateBridge __Hotfix0_ReqObOtherPlayer;

		// Token: 0x040124BD RID: 74941
		[Token(Token = "0x40124BD")]
		[FieldOffset(Offset = "0x2F8")]
		private static DelegateBridge __Hotfix0_ReqCancelOb;

		// Token: 0x040124BE RID: 74942
		[Token(Token = "0x40124BE")]
		[FieldOffset(Offset = "0x300")]
		private static DelegateBridge __Hotfix0_ReqDeadAutoOb;

		// Token: 0x040124BF RID: 74943
		[Token(Token = "0x40124BF")]
		[FieldOffset(Offset = "0x308")]
		private static DelegateBridge __Hotfix0_ReqSpPrepareSelect;

		// Token: 0x040124C0 RID: 74944
		[Token(Token = "0x40124C0")]
		[FieldOffset(Offset = "0x310")]
		private static DelegateBridge __Hotfix0_ReqSelfChoiceSelect;

		// Token: 0x040124C1 RID: 74945
		[Token(Token = "0x40124C1")]
		[FieldOffset(Offset = "0x318")]
		private static DelegateBridge __Hotfix0_ReqSendEmoji;

		// Token: 0x040124C2 RID: 74946
		[Token(Token = "0x40124C2")]
		[FieldOffset(Offset = "0x320")]
		private static DelegateBridge __Hotfix0_ReqSendBroadcast;

		// Token: 0x040124C3 RID: 74947
		[Token(Token = "0x40124C3")]
		[FieldOffset(Offset = "0x328")]
		private static DelegateBridge __Hotfix0_ReqGiveUp;

		// Token: 0x040124C4 RID: 74948
		[Token(Token = "0x40124C4")]
		[FieldOffset(Offset = "0x330")]
		private static DelegateBridge __Hotfix0_ReqPauseSingleMode;

		// Token: 0x040124C5 RID: 74949
		[Token(Token = "0x40124C5")]
		[FieldOffset(Offset = "0x338")]
		private static DelegateBridge __Hotfix0_ReqResumeSingleMode;
	}
}
