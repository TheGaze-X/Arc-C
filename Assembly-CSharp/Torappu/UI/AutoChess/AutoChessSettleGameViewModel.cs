using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x0200630A RID: 25354
	[Token(Token = "0x200630A")]
	public class AutoChessSettleGameViewModel : IHotfixable
	{
		// Token: 0x0602489B RID: 149659 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602489B")]
		[Address(RVA = "0x1F63890", Offset = "0x1F62490", VA = "0x181F63890")]
		public void LoadData(AutoChessPrepareModel prepareModel, AutoChessSeasonSettleGameInfo settleGameInfo)
		{
		}

		// Token: 0x0602489C RID: 149660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602489C")]
		[Address(RVA = "0x1F63E50", Offset = "0x1F62A50", VA = "0x181F63E50")]
		public void ShowTeamView()
		{
		}

		// Token: 0x0602489D RID: 149661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602489D")]
		[Address(RVA = "0x1F63A90", Offset = "0x1F62690", VA = "0x181F63A90")]
		public void RefreshFriendsInfo(AutoChessPrepareModel prepareModel)
		{
		}

		// Token: 0x0602489E RID: 149662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602489E")]
		[Address(RVA = "0x1F63C50", Offset = "0x1F62850", VA = "0x181F63C50")]
		public void ReportedPlayer(string uid)
		{
		}

		// Token: 0x0602489F RID: 149663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602489F")]
		[Address(RVA = "0x1F63DC0", Offset = "0x1F629C0", VA = "0x181F63DC0")]
		public void ShowReportPlayerBtns(bool show)
		{
		}

		// Token: 0x060248A0 RID: 149664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60248A0")]
		[Address(RVA = "0x1F63EB0", Offset = "0x1F62AB0", VA = "0x181F63EB0")]
		private void _LoadModeInfo(string modeId)
		{
		}

		// Token: 0x060248A1 RID: 149665 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60248A1")]
		[Address(RVA = "0x1F63F70", Offset = "0x1F62B70", VA = "0x181F63F70")]
		public AutoChessSettleGameViewModel()
		{
		}

		// Token: 0x04032F9B RID: 208795
		[Token(Token = "0x4032F9B")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04032F9C RID: 208796
		[Token(Token = "0x4032F9C")]
		[FieldOffset(Offset = "0x18")]
		public ActAutoChessModeDifficultyType modeDiffType;

		// Token: 0x04032F9D RID: 208797
		[Token(Token = "0x4032F9D")]
		[FieldOffset(Offset = "0x20")]
		public string modeName;

		// Token: 0x04032F9E RID: 208798
		[Token(Token = "0x4032F9E")]
		[FieldOffset(Offset = "0x28")]
		public ActAutoChessModeType modeType;

		// Token: 0x04032F9F RID: 208799
		[Token(Token = "0x4032F9F")]
		[FieldOffset(Offset = "0x2C")]
		public bool isPersonalViewShowing;

		// Token: 0x04032FA0 RID: 208800
		[Token(Token = "0x4032FA0")]
		[FieldOffset(Offset = "0x2D")]
		public bool isTeamViewShowing;

		// Token: 0x04032FA1 RID: 208801
		[Token(Token = "0x4032FA1")]
		[FieldOffset(Offset = "0x30")]
		public AutoChessSettleGamePersonalViewModel personalViewModel;

		// Token: 0x04032FA2 RID: 208802
		[Token(Token = "0x4032FA2")]
		[FieldOffset(Offset = "0x38")]
		public AutoChessSettleGameTeamViewModel teamViewModel;

		// Token: 0x04032FA3 RID: 208803
		[Token(Token = "0x4032FA3")]
		public const string SEASON_LOGO_ICON_ID = "season_logo_settle_game";

		// Token: 0x04032FA4 RID: 208804
		[Token(Token = "0x4032FA4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04032FA5 RID: 208805
		[Token(Token = "0x4032FA5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowTeamView;

		// Token: 0x04032FA6 RID: 208806
		[Token(Token = "0x4032FA6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RefreshFriendsInfo;

		// Token: 0x04032FA7 RID: 208807
		[Token(Token = "0x4032FA7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ReportedPlayer;

		// Token: 0x04032FA8 RID: 208808
		[Token(Token = "0x4032FA8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShowReportPlayerBtns;

		// Token: 0x04032FA9 RID: 208809
		[Token(Token = "0x4032FA9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadModeInfo;

		// Token: 0x04032FAA RID: 208810
		[Token(Token = "0x4032FAA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
