using System;
using Il2CppDummyDll;
using Torappu.UI.ActivityStage;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x020076E9 RID: 30441
	[Token(Token = "0x20076E9")]
	public class Act1VHalfIdleEntryButtonViewModel : TemplateActivityViewModel
	{
		// Token: 0x0602AC89 RID: 175241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC89")]
		[Address(RVA = "0x2686950", Offset = "0x2685550", VA = "0x182686950")]
		public void LoadData()
		{
		}

		// Token: 0x0602AC8A RID: 175242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC8A")]
		[Address(RVA = "0x26869E0", Offset = "0x26855E0", VA = "0x1826869E0")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x0602AC8B RID: 175243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602AC8B")]
		[Address(RVA = "0x2686C20", Offset = "0x2685820", VA = "0x182686C20")]
		public Act1VHalfIdleEntryButtonViewModel(object param)
		{
		}

		// Token: 0x0403DA66 RID: 252518
		[Token(Token = "0x403DA66")]
		[FieldOffset(Offset = "0x20")]
		public bool isTrainingPassed;

		// Token: 0x0403DA67 RID: 252519
		[Token(Token = "0x403DA67")]
		[FieldOffset(Offset = "0x21")]
		public bool isActEnd;

		// Token: 0x0403DA68 RID: 252520
		[Token(Token = "0x403DA68")]
		[FieldOffset(Offset = "0x22")]
		public bool showHarvestTrack;

		// Token: 0x0403DA69 RID: 252521
		[Token(Token = "0x403DA69")]
		[FieldOffset(Offset = "0x23")]
		public bool lockHarvestEntry;

		// Token: 0x0403DA6A RID: 252522
		[Token(Token = "0x403DA6A")]
		[FieldOffset(Offset = "0x24")]
		public bool needSettle;

		// Token: 0x0403DA6B RID: 252523
		[Token(Token = "0x403DA6B")]
		[FieldOffset(Offset = "0x28")]
		public long harvestRemainTime;

		// Token: 0x0403DA6C RID: 252524
		[Token(Token = "0x403DA6C")]
		[FieldOffset(Offset = "0x30")]
		public string harvestAlertText;

		// Token: 0x0403DA6D RID: 252525
		[Token(Token = "0x403DA6D")]
		[FieldOffset(Offset = "0x38")]
		public string milestoneTrackId;

		// Token: 0x0403DA6E RID: 252526
		[Token(Token = "0x403DA6E")]
		[FieldOffset(Offset = "0x40")]
		public int availGachaCnt;

		// Token: 0x0403DA6F RID: 252527
		[Token(Token = "0x403DA6F")]
		[FieldOffset(Offset = "0x48")]
		private string m_actId;

		// Token: 0x0403DA70 RID: 252528
		[Token(Token = "0x403DA70")]
		[FieldOffset(Offset = "0x50")]
		private long m_endTs;

		// Token: 0x0403DA71 RID: 252529
		[Token(Token = "0x403DA71")]
		[FieldOffset(Offset = "0x58")]
		private long m_harvestAlertThreshold;

		// Token: 0x0403DA72 RID: 252530
		[Token(Token = "0x403DA72")]
		[FieldOffset(Offset = "0x60")]
		private long m_maxHarvestTime;

		// Token: 0x0403DA73 RID: 252531
		[Token(Token = "0x403DA73")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0403DA74 RID: 252532
		[Token(Token = "0x403DA74")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x0403DA75 RID: 252533
		[Token(Token = "0x403DA75")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
