using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F2F RID: 28463
	[Token(Token = "0x2006F2F")]
	public class ActMultiV3EntryViewModel : IHotfixable
	{
		// Token: 0x060286E1 RID: 165601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286E1")]
		[Address(RVA = "0x23B56F0", Offset = "0x23B42F0", VA = "0x1823B56F0")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x060286E2 RID: 165602 RVA: 0x000D1C88 File Offset: 0x000CFE88
		[Token(Token = "0x60286E2")]
		[Address(RVA = "0x23B6210", Offset = "0x23B4E10", VA = "0x1823B6210")]
		private ActMultiV3EntryViewModel.MatchButtonStatus _GetMatchButtonStatus()
		{
			return ActMultiV3EntryViewModel.MatchButtonStatus.NONE;
		}

		// Token: 0x060286E3 RID: 165603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286E3")]
		[Address(RVA = "0x23B6190", Offset = "0x23B4D90", VA = "0x1823B6190")]
		public void SetInputTeamId(string inputVal)
		{
		}

		// Token: 0x060286E4 RID: 165604 RVA: 0x000D1CA0 File Offset: 0x000CFEA0
		[Token(Token = "0x60286E4")]
		[Address(RVA = "0x23B5660", Offset = "0x23B4260", VA = "0x1823B5660")]
		public bool CheckIsBanned()
		{
			return default(bool);
		}

		// Token: 0x060286E5 RID: 165605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60286E5")]
		[Address(RVA = "0x23B62A0", Offset = "0x23B4EA0", VA = "0x1823B62A0")]
		public ActMultiV3EntryViewModel()
		{
		}

		// Token: 0x0403980C RID: 235532
		[Token(Token = "0x403980C")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x0403980D RID: 235533
		[Token(Token = "0x403980D")]
		[FieldOffset(Offset = "0x18")]
		public ActMultiV3LifeCycleViewModel lifeCycleViewModel;

		// Token: 0x0403980E RID: 235534
		[Token(Token = "0x403980E")]
		[FieldOffset(Offset = "0x20")]
		public ActMultiV3EntryMilestoneViewModel milestoneViewModel;

		// Token: 0x0403980F RID: 235535
		[Token(Token = "0x403980F")]
		[FieldOffset(Offset = "0x28")]
		public ActMultiV3DailyMissionViewModel dailyViewModel;

		// Token: 0x04039810 RID: 235536
		[Token(Token = "0x4039810")]
		[FieldOffset(Offset = "0x30")]
		public ActMultiV3EntryManualViewModel manualViewModel;

		// Token: 0x04039811 RID: 235537
		[Token(Token = "0x4039811")]
		[FieldOffset(Offset = "0x38")]
		public string titlePrefix;

		// Token: 0x04039812 RID: 235538
		[Token(Token = "0x4039812")]
		[FieldOffset(Offset = "0x40")]
		public string titleSuffix;

		// Token: 0x04039813 RID: 235539
		[Token(Token = "0x4039813")]
		[FieldOffset(Offset = "0x48")]
		public ActMultiV3EntrySquadViewModel squadViewModel;

		// Token: 0x04039814 RID: 235540
		[Token(Token = "0x4039814")]
		[FieldOffset(Offset = "0x50")]
		public ActMultiV3EntryStageViewModel stageViewModel;

		// Token: 0x04039815 RID: 235541
		[Token(Token = "0x4039815")]
		[FieldOffset(Offset = "0x58")]
		public ActMultiV3EntryMatchViewModel matchViewModel;

		// Token: 0x04039816 RID: 235542
		[Token(Token = "0x4039816")]
		[FieldOffset(Offset = "0x60")]
		public int minSquadCount;

		// Token: 0x04039817 RID: 235543
		[Token(Token = "0x4039817")]
		[FieldOffset(Offset = "0x64")]
		public bool isSquadValid;

		// Token: 0x04039818 RID: 235544
		[Token(Token = "0x4039818")]
		[FieldOffset(Offset = "0x65")]
		public bool tutorialStageCompleted;

		// Token: 0x04039819 RID: 235545
		[Token(Token = "0x4039819")]
		[FieldOffset(Offset = "0x68")]
		public long bannedUntilTs;

		// Token: 0x0403981A RID: 235546
		[Token(Token = "0x403981A")]
		[FieldOffset(Offset = "0x70")]
		public string teamId;

		// Token: 0x0403981B RID: 235547
		[Token(Token = "0x403981B")]
		[FieldOffset(Offset = "0x78")]
		public ActMultiV3EntryViewModel.MatchButtonStatus matchButtonStatus;

		// Token: 0x0403981C RID: 235548
		[Token(Token = "0x403981C")]
		[FieldOffset(Offset = "0x80")]
		public ActMultiV3ConstToastData constToastData;

		// Token: 0x0403981D RID: 235549
		[Token(Token = "0x403981D")]
		[FieldOffset(Offset = "0x88")]
		public double joinRoomLongTimeThreshold;

		// Token: 0x0403981E RID: 235550
		[Token(Token = "0x403981E")]
		[FieldOffset(Offset = "0x90")]
		public bool hasTrainingGroundTrackpoint;

		// Token: 0x0403981F RID: 235551
		[Token(Token = "0x403981F")]
		[FieldOffset(Offset = "0x91")]
		public bool hasInvitedTrackpoint;

		// Token: 0x04039820 RID: 235552
		[Token(Token = "0x4039820")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04039821 RID: 235553
		[Token(Token = "0x4039821")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__GetMatchButtonStatus;

		// Token: 0x04039822 RID: 235554
		[Token(Token = "0x4039822")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetInputTeamId;

		// Token: 0x04039823 RID: 235555
		[Token(Token = "0x4039823")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckIsBanned;

		// Token: 0x04039824 RID: 235556
		[Token(Token = "0x4039824")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F30 RID: 28464
		[Token(Token = "0x2006F30")]
		public enum MatchButtonStatus
		{
			// Token: 0x04039826 RID: 235558
			[Token(Token = "0x4039826")]
			NONE,
			// Token: 0x04039827 RID: 235559
			[Token(Token = "0x4039827")]
			ACT_ENDED,
			// Token: 0x04039828 RID: 235560
			[Token(Token = "0x4039828")]
			TUTORIAL_INCOMPLETED,
			// Token: 0x04039829 RID: 235561
			[Token(Token = "0x4039829")]
			SQUAD_COUNT_INVALID,
			// Token: 0x0403982A RID: 235562
			[Token(Token = "0x403982A")]
			NORMAL
		}
	}
}
