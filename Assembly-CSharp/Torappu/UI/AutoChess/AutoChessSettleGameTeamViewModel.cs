using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.ReportPlayer;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x02006309 RID: 25353
	[Token(Token = "0x2006309")]
	public class AutoChessSettleGameTeamViewModel : IHotfixable
	{
		// Token: 0x0602488E RID: 149646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602488E")]
		[Address(RVA = "0x1F604B0", Offset = "0x1F5F0B0", VA = "0x181F604B0")]
		public void LoadData(AutoChessPrepareModel prepareModel, AutoChessSeasonSettleGameInfo settleGameInfo, Dictionary<string, ActAutoChessData.ActAutoChessPlayerTitleData> titleDict)
		{
		}

		// Token: 0x0602488F RID: 149647 RVA: 0x000C4848 File Offset: 0x000C2A48
		[Token(Token = "0x602488F")]
		[Address(RVA = "0x1F5FFD0", Offset = "0x1F5EBD0", VA = "0x181F5FFD0")]
		public ReportPlayerPanelInputParam GenReportPanelInputParam(string uid)
		{
			return default(ReportPlayerPanelInputParam);
		}

		// Token: 0x06024890 RID: 149648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024890")]
		[Address(RVA = "0x1F60870", Offset = "0x1F5F470", VA = "0x181F60870")]
		public void RefreshFriendsInfo(AutoChessPrepareModel prepareModel)
		{
		}

		// Token: 0x06024891 RID: 149649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024891")]
		[Address(RVA = "0x1F60AF0", Offset = "0x1F5F6F0", VA = "0x181F60AF0")]
		public void ReportPlayer(string uid)
		{
		}

		// Token: 0x06024892 RID: 149650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024892")]
		[Address(RVA = "0x1F609E0", Offset = "0x1F5F5E0", VA = "0x181F609E0")]
		public void RefreshReportBtnsShowState(bool showReportBtns)
		{
		}

		// Token: 0x06024893 RID: 149651 RVA: 0x000C4860 File Offset: 0x000C2A60
		[Token(Token = "0x6024893")]
		[Address(RVA = "0x1F60F30", Offset = "0x1F5FB30", VA = "0x181F60F30")]
		private bool _IsPlayerReported(string uid)
		{
			return default(bool);
		}

		// Token: 0x06024894 RID: 149652 RVA: 0x000C4878 File Offset: 0x000C2A78
		[Token(Token = "0x6024894")]
		[Address(RVA = "0x1F60C10", Offset = "0x1F5F810", VA = "0x181F60C10")]
		private ReportPlayerInfo _GenReportPlayerInfo(string uid)
		{
			return default(ReportPlayerInfo);
		}

		// Token: 0x06024895 RID: 149653 RVA: 0x000C4890 File Offset: 0x000C2A90
		[Token(Token = "0x6024895")]
		[Address(RVA = "0x1F60E20", Offset = "0x1F5FA20", VA = "0x181F60E20")]
		private AutoChessSettleGameTeamStateType _GetTeamState(AutoChessSeasonSettleGameInfo settleGameInfo)
		{
			return AutoChessSettleGameTeamStateType.NONE;
		}

		// Token: 0x06024896 RID: 149654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024896")]
		[Address(RVA = "0x1F61280", Offset = "0x1F5FE80", VA = "0x181F61280")]
		private void _LoadTeamMaxPassRoundInfo(AutoChessSeasonSettleGameInfo settleGameInfo)
		{
		}

		// Token: 0x06024897 RID: 149655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024897")]
		[Address(RVA = "0x1F61820", Offset = "0x1F60420", VA = "0x181F61820")]
		private void _LoadTeamTimeInfo(AutoChessSeasonSettleGameInfo settleGameInfo)
		{
		}

		// Token: 0x06024898 RID: 149656 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024898")]
		[Address(RVA = "0x1F61410", Offset = "0x1F60010", VA = "0x181F61410")]
		private void _LoadTeamPlayerInfo(AutoChessPrepareModel prepareModel, AutoChessSeasonSettleGameInfo settleGameInfo, Dictionary<string, ActAutoChessData.ActAutoChessPlayerTitleData> titleDict)
		{
		}

		// Token: 0x06024899 RID: 149657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024899")]
		[Address(RVA = "0x1F61050", Offset = "0x1F5FC50", VA = "0x181F61050")]
		private void _LoadOtherPlayerAvatarInfoForSelf()
		{
		}

		// Token: 0x0602489A RID: 149658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602489A")]
		[Address(RVA = "0x1F61CD0", Offset = "0x1F608D0", VA = "0x181F61CD0")]
		public AutoChessSettleGameTeamViewModel()
		{
		}

		// Token: 0x04032F7F RID: 208767
		[Token(Token = "0x4032F7F")]
		[FieldOffset(Offset = "0x10")]
		public ActAutoChessModeType modeType;

		// Token: 0x04032F80 RID: 208768
		[Token(Token = "0x4032F80")]
		[FieldOffset(Offset = "0x14")]
		public ActAutoChessMultiModeSubType multiModeSubType;

		// Token: 0x04032F81 RID: 208769
		[Token(Token = "0x4032F81")]
		[FieldOffset(Offset = "0x18")]
		public bool isFromBattle;

		// Token: 0x04032F82 RID: 208770
		[Token(Token = "0x4032F82")]
		[FieldOffset(Offset = "0x19")]
		public bool isGameFinished;

		// Token: 0x04032F83 RID: 208771
		[Token(Token = "0x4032F83")]
		[FieldOffset(Offset = "0x1C")]
		public AutoChessSettleGameTeamStateType teamState;

		// Token: 0x04032F84 RID: 208772
		[Token(Token = "0x4032F84")]
		[FieldOffset(Offset = "0x20")]
		public AutoChessSettleGameTeamRoundType roundType;

		// Token: 0x04032F85 RID: 208773
		[Token(Token = "0x4032F85")]
		[FieldOffset(Offset = "0x24")]
		public int teamMaxPassRound;

		// Token: 0x04032F86 RID: 208774
		[Token(Token = "0x4032F86")]
		[FieldOffset(Offset = "0x28")]
		public string endTs;

		// Token: 0x04032F87 RID: 208775
		[Token(Token = "0x4032F87")]
		[FieldOffset(Offset = "0x30")]
		public string battleUseTs;

		// Token: 0x04032F88 RID: 208776
		[Token(Token = "0x4032F88")]
		[FieldOffset(Offset = "0x38")]
		public List<AutoChessSettleGameTeamPlayerCardViewModel> playerCardList;

		// Token: 0x04032F89 RID: 208777
		[Token(Token = "0x4032F89")]
		[FieldOffset(Offset = "0x40")]
		public bool isCanReportMode;

		// Token: 0x04032F8A RID: 208778
		[Token(Token = "0x4032F8A")]
		[FieldOffset(Offset = "0x41")]
		public bool reportBtnsShowing;

		// Token: 0x04032F8B RID: 208779
		[Token(Token = "0x4032F8B")]
		[FieldOffset(Offset = "0x44")]
		private int m_maxReportNum;

		// Token: 0x04032F8C RID: 208780
		[Token(Token = "0x4032F8C")]
		[FieldOffset(Offset = "0x48")]
		private List<CommonReportPlayerData> m_reportDataList;

		// Token: 0x04032F8D RID: 208781
		[Token(Token = "0x4032F8D")]
		[FieldOffset(Offset = "0x50")]
		private string m_actId;

		// Token: 0x04032F8E RID: 208782
		[Token(Token = "0x4032F8E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04032F8F RID: 208783
		[Token(Token = "0x4032F8F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GenReportPanelInputParam;

		// Token: 0x04032F90 RID: 208784
		[Token(Token = "0x4032F90")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshFriendsInfo;

		// Token: 0x04032F91 RID: 208785
		[Token(Token = "0x4032F91")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ReportPlayer;

		// Token: 0x04032F92 RID: 208786
		[Token(Token = "0x4032F92")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_RefreshReportBtnsShowState;

		// Token: 0x04032F93 RID: 208787
		[Token(Token = "0x4032F93")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__IsPlayerReported;

		// Token: 0x04032F94 RID: 208788
		[Token(Token = "0x4032F94")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GenReportPlayerInfo;

		// Token: 0x04032F95 RID: 208789
		[Token(Token = "0x4032F95")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetTeamState;

		// Token: 0x04032F96 RID: 208790
		[Token(Token = "0x4032F96")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__LoadTeamMaxPassRoundInfo;

		// Token: 0x04032F97 RID: 208791
		[Token(Token = "0x4032F97")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadTeamTimeInfo;

		// Token: 0x04032F98 RID: 208792
		[Token(Token = "0x4032F98")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__LoadTeamPlayerInfo;

		// Token: 0x04032F99 RID: 208793
		[Token(Token = "0x4032F99")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__LoadOtherPlayerAvatarInfoForSelf;

		// Token: 0x04032F9A RID: 208794
		[Token(Token = "0x4032F9A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
