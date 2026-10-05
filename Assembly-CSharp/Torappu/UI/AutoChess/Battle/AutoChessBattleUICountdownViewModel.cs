using System;
using Il2CppDummyDll;
using Torappu.Battle.AutoChess;
using Torappu.Battle.DataCenter;
using XLua;

namespace Torappu.UI.AutoChess.Battle
{
	// Token: 0x02006493 RID: 25747
	[Token(Token = "0x2006493")]
	public class AutoChessBattleUICountdownViewModel : IHotfixable
	{
		// Token: 0x17005768 RID: 22376
		// (get) Token: 0x06025076 RID: 151670 RVA: 0x000C6378 File Offset: 0x000C4578
		[Token(Token = "0x17005768")]
		public bool isPanelShow
		{
			[Token(Token = "0x6025076")]
			[Address(RVA = "0x1FE7E40", Offset = "0x1FE6A40", VA = "0x181FE7E40")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06025077 RID: 151671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025077")]
		[Address(RVA = "0x1FE7290", Offset = "0x1FE5E90", VA = "0x181FE7290")]
		public void Init(AutoChessData autoChessData)
		{
		}

		// Token: 0x06025078 RID: 151672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025078")]
		[Address(RVA = "0x1FE7310", Offset = "0x1FE5F10", VA = "0x181FE7310")]
		public void LoadData(AutoChessBattleUICountdownViewModel.LoadParam loadParam)
		{
		}

		// Token: 0x06025079 RID: 151673 RVA: 0x000C6390 File Offset: 0x000C4590
		[Token(Token = "0x6025079")]
		[Address(RVA = "0x1FE6D70", Offset = "0x1FE5970", VA = "0x181FE6D70")]
		public AutoChessBattleUICountdownViewModel.TimeInfo GetCurrentTimeInfo(DateTime currentTime)
		{
			return default(AutoChessBattleUICountdownViewModel.TimeInfo);
		}

		// Token: 0x0602507A RID: 151674 RVA: 0x000C63A8 File Offset: 0x000C45A8
		[Token(Token = "0x602507A")]
		[Address(RVA = "0x1FE7CD0", Offset = "0x1FE68D0", VA = "0x181FE7CD0")]
		private bool _IsPanelShow()
		{
			return default(bool);
		}

		// Token: 0x0602507B RID: 151675 RVA: 0x000C63C0 File Offset: 0x000C45C0
		[Token(Token = "0x602507B")]
		[Address(RVA = "0x1FE7C50", Offset = "0x1FE6850", VA = "0x181FE7C50")]
		private bool _IsPanelShowInSingleMode()
		{
			return default(bool);
		}

		// Token: 0x0602507C RID: 151676 RVA: 0x000C63D8 File Offset: 0x000C45D8
		[Token(Token = "0x602507C")]
		[Address(RVA = "0x1FE7BD0", Offset = "0x1FE67D0", VA = "0x181FE7BD0")]
		private bool _IsPanelShowInMultiMode()
		{
			return default(bool);
		}

		// Token: 0x0602507D RID: 151677 RVA: 0x000C63F0 File Offset: 0x000C45F0
		[Token(Token = "0x602507D")]
		[Address(RVA = "0x1FE79C0", Offset = "0x1FE65C0", VA = "0x181FE79C0")]
		private AutoChessBattleUICountdownViewModel.TimeInfo _GetPreparationTimeInfo()
		{
			return default(AutoChessBattleUICountdownViewModel.TimeInfo);
		}

		// Token: 0x0602507E RID: 151678 RVA: 0x000C6408 File Offset: 0x000C4608
		[Token(Token = "0x602507E")]
		[Address(RVA = "0x1FE7B00", Offset = "0x1FE6700", VA = "0x181FE7B00")]
		private AutoChessBattleUICountdownViewModel.TimeInfo _GetSpPreparationTimeInfo()
		{
			return default(AutoChessBattleUICountdownViewModel.TimeInfo);
		}

		// Token: 0x0602507F RID: 151679 RVA: 0x000C6420 File Offset: 0x000C4620
		[Token(Token = "0x602507F")]
		[Address(RVA = "0x1FE7860", Offset = "0x1FE6460", VA = "0x181FE7860")]
		private AutoChessBattleUICountdownViewModel.TimeInfo _GetNormalBattleTimeInfo(DateTime currentTime)
		{
			return default(AutoChessBattleUICountdownViewModel.TimeInfo);
		}

		// Token: 0x06025080 RID: 151680 RVA: 0x000C6438 File Offset: 0x000C4638
		[Token(Token = "0x6025080")]
		[Address(RVA = "0x1FE75C0", Offset = "0x1FE61C0", VA = "0x181FE75C0")]
		private AutoChessBattleUICountdownViewModel.TimeInfo _GetBossBattleTimeInfo()
		{
			return default(AutoChessBattleUICountdownViewModel.TimeInfo);
		}

		// Token: 0x06025081 RID: 151681 RVA: 0x000C6450 File Offset: 0x000C4650
		[Token(Token = "0x6025081")]
		[Address(RVA = "0x1FE7770", Offset = "0x1FE6370", VA = "0x181FE7770")]
		private int _GetBossTurnHpReduceTime()
		{
			return 0;
		}

		// Token: 0x06025082 RID: 151682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025082")]
		[Address(RVA = "0x1FE7DE0", Offset = "0x1FE69E0", VA = "0x181FE7DE0")]
		public AutoChessBattleUICountdownViewModel()
		{
		}

		// Token: 0x04033D6B RID: 212331
		[Token(Token = "0x4033D6B")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessGameStatus.SubState subStatusState;

		// Token: 0x04033D6C RID: 212332
		[Token(Token = "0x4033D6C")]
		[FieldOffset(Offset = "0x14")]
		public AutoChessGameStateType statusState;

		// Token: 0x04033D6D RID: 212333
		[Token(Token = "0x4033D6D")]
		[FieldOffset(Offset = "0x18")]
		private AutoChessData m_autoChessData;

		// Token: 0x04033D6E RID: 212334
		[Token(Token = "0x4033D6E")]
		[FieldOffset(Offset = "0x20")]
		private string m_actId;

		// Token: 0x04033D6F RID: 212335
		[Token(Token = "0x4033D6F")]
		[FieldOffset(Offset = "0x28")]
		private string m_modeId;

		// Token: 0x04033D70 RID: 212336
		[Token(Token = "0x4033D70")]
		[FieldOffset(Offset = "0x30")]
		private int m_round;

		// Token: 0x04033D71 RID: 212337
		[Token(Token = "0x4033D71")]
		[FieldOffset(Offset = "0x38")]
		private long m_stateForceEndTime;

		// Token: 0x04033D72 RID: 212338
		[Token(Token = "0x4033D72")]
		[FieldOffset(Offset = "0x40")]
		private long m_battleStartTime;

		// Token: 0x04033D73 RID: 212339
		[Token(Token = "0x4033D73")]
		[FieldOffset(Offset = "0x48")]
		private long m_battleNormalEndTime;

		// Token: 0x04033D74 RID: 212340
		[Token(Token = "0x4033D74")]
		[FieldOffset(Offset = "0x50")]
		private AutoChessEffectChooseDataModel m_effectChooseData;

		// Token: 0x04033D75 RID: 212341
		[Token(Token = "0x4033D75")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isPanelShow;

		// Token: 0x04033D76 RID: 212342
		[Token(Token = "0x4033D76")]
		[FieldOffset(Offset = "0x5C")]
		private ActAutoChessModeType m_modeType;

		// Token: 0x04033D77 RID: 212343
		[Token(Token = "0x4033D77")]
		[FieldOffset(Offset = "0x60")]
		private int m_specialPhaseTime;

		// Token: 0x04033D78 RID: 212344
		[Token(Token = "0x4033D78")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_isPanelShow;

		// Token: 0x04033D79 RID: 212345
		[Token(Token = "0x4033D79")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04033D7A RID: 212346
		[Token(Token = "0x4033D7A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04033D7B RID: 212347
		[Token(Token = "0x4033D7B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCurrentTimeInfo;

		// Token: 0x04033D7C RID: 212348
		[Token(Token = "0x4033D7C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__IsPanelShow;

		// Token: 0x04033D7D RID: 212349
		[Token(Token = "0x4033D7D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__IsPanelShowInSingleMode;

		// Token: 0x04033D7E RID: 212350
		[Token(Token = "0x4033D7E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__IsPanelShowInMultiMode;

		// Token: 0x04033D7F RID: 212351
		[Token(Token = "0x4033D7F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetPreparationTimeInfo;

		// Token: 0x04033D80 RID: 212352
		[Token(Token = "0x4033D80")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GetSpPreparationTimeInfo;

		// Token: 0x04033D81 RID: 212353
		[Token(Token = "0x4033D81")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__GetNormalBattleTimeInfo;

		// Token: 0x04033D82 RID: 212354
		[Token(Token = "0x4033D82")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__GetBossBattleTimeInfo;

		// Token: 0x04033D83 RID: 212355
		[Token(Token = "0x4033D83")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__GetBossTurnHpReduceTime;

		// Token: 0x04033D84 RID: 212356
		[Token(Token = "0x4033D84")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006494 RID: 25748
		[Token(Token = "0x2006494")]
		public struct LoadParam
		{
			// Token: 0x04033D85 RID: 212357
			[Token(Token = "0x4033D85")]
			[FieldOffset(Offset = "0x0")]
			public string actId;

			// Token: 0x04033D86 RID: 212358
			[Token(Token = "0x4033D86")]
			[FieldOffset(Offset = "0x8")]
			public string modeId;

			// Token: 0x04033D87 RID: 212359
			[Token(Token = "0x4033D87")]
			[FieldOffset(Offset = "0x10")]
			public int currentRound;

			// Token: 0x04033D88 RID: 212360
			[Token(Token = "0x4033D88")]
			[FieldOffset(Offset = "0x14")]
			public AutoChessGameStatus.SubState subState;

			// Token: 0x04033D89 RID: 212361
			[Token(Token = "0x4033D89")]
			[FieldOffset(Offset = "0x18")]
			public AutoChessGameStateType state;

			// Token: 0x04033D8A RID: 212362
			[Token(Token = "0x4033D8A")]
			[FieldOffset(Offset = "0x20")]
			public AutoChessDataCenter dataCenter;

			// Token: 0x04033D8B RID: 212363
			[Token(Token = "0x4033D8B")]
			[FieldOffset(Offset = "0x28")]
			public AutoChessEffectChooseDataModel effectChooseData;
		}

		// Token: 0x02006495 RID: 25749
		[Token(Token = "0x2006495")]
		public struct TimeInfo : IHotfixable
		{
			// Token: 0x06025083 RID: 151683 RVA: 0x000C6468 File Offset: 0x000C4668
			[Token(Token = "0x6025083")]
			[Address(RVA = "0x1FF15B0", Offset = "0x1FF01B0", VA = "0x181FF15B0")]
			public bool isEqual(AutoChessBattleUICountdownViewModel.TimeInfo timeInfo)
			{
				return default(bool);
			}

			// Token: 0x04033D8C RID: 212364
			[Token(Token = "0x4033D8C")]
			[FieldOffset(Offset = "0x0")]
			public static AutoChessBattleUICountdownViewModel.TimeInfo EMPTY;

			// Token: 0x04033D8D RID: 212365
			[Token(Token = "0x4033D8D")]
			[FieldOffset(Offset = "0x0")]
			public long endTs;

			// Token: 0x04033D8E RID: 212366
			[Token(Token = "0x4033D8E")]
			[FieldOffset(Offset = "0x8")]
			public int totalTime;

			// Token: 0x04033D8F RID: 212367
			[Token(Token = "0x4033D8F")]
			[FieldOffset(Offset = "0xC")]
			public int hintTime;

			// Token: 0x04033D90 RID: 212368
			[Token(Token = "0x4033D90")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_isEqual;
		}
	}
}
