using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Monopoly
{
	// Token: 0x020047EC RID: 18412
	[Token(Token = "0x20047EC")]
	public class MonopolyEntryStageModel : IHotfixable
	{
		// Token: 0x0601BDA2 RID: 114082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDA2")]
		[Address(RVA = "0x1524D90", Offset = "0x1523990", VA = "0x181524D90")]
		public void LoadData(string actId, Act46SideData.Act46SideMonopolyStageData stageData, PlayerActivity.PlayerAct46SideActivity.PlayerMonopolyStage playerStage)
		{
		}

		// Token: 0x0601BDA3 RID: 114083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDA3")]
		[Address(RVA = "0x1525070", Offset = "0x1523C70", VA = "0x181525070")]
		public void RefreshNew(string actId)
		{
		}

		// Token: 0x0601BDA4 RID: 114084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601BDA4")]
		[Address(RVA = "0x1525140", Offset = "0x1523D40", VA = "0x181525140")]
		public MonopolyEntryStageModel()
		{
		}

		// Token: 0x040243F5 RID: 148469
		[Token(Token = "0x40243F5")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x040243F6 RID: 148470
		[Token(Token = "0x40243F6")]
		[FieldOffset(Offset = "0x18")]
		public string stageName;

		// Token: 0x040243F7 RID: 148471
		[Token(Token = "0x40243F7")]
		[FieldOffset(Offset = "0x20")]
		public string stageDesc;

		// Token: 0x040243F8 RID: 148472
		[Token(Token = "0x40243F8")]
		[FieldOffset(Offset = "0x28")]
		public int sortId;

		// Token: 0x040243F9 RID: 148473
		[Token(Token = "0x40243F9")]
		[FieldOffset(Offset = "0x30")]
		public long startTs;

		// Token: 0x040243FA RID: 148474
		[Token(Token = "0x40243FA")]
		[FieldOffset(Offset = "0x38")]
		public int targetMissionCnt;

		// Token: 0x040243FB RID: 148475
		[Token(Token = "0x40243FB")]
		[FieldOffset(Offset = "0x40")]
		public List<UIItemViewModel> rewardList;

		// Token: 0x040243FC RID: 148476
		[Token(Token = "0x40243FC")]
		[FieldOffset(Offset = "0x48")]
		public int highestRecord;

		// Token: 0x040243FD RID: 148477
		[Token(Token = "0x40243FD")]
		[FieldOffset(Offset = "0x4C")]
		public bool isInTime;

		// Token: 0x040243FE RID: 148478
		[Token(Token = "0x40243FE")]
		[FieldOffset(Offset = "0x50")]
		public string unlockTimeDesc;

		// Token: 0x040243FF RID: 148479
		[Token(Token = "0x40243FF")]
		[FieldOffset(Offset = "0x58")]
		public bool isUnlock;

		// Token: 0x04024400 RID: 148480
		[Token(Token = "0x4024400")]
		[FieldOffset(Offset = "0x59")]
		public bool isPassed;

		// Token: 0x04024401 RID: 148481
		[Token(Token = "0x4024401")]
		[FieldOffset(Offset = "0x5A")]
		public bool isNewAndOpen;

		// Token: 0x04024402 RID: 148482
		[Token(Token = "0x4024402")]
		[FieldOffset(Offset = "0x5C")]
		public MonopolyEntryStageModel.StageTaskStatus taskStatus;

		// Token: 0x04024403 RID: 148483
		[Token(Token = "0x4024403")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04024404 RID: 148484
		[Token(Token = "0x4024404")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RefreshNew;

		// Token: 0x04024405 RID: 148485
		[Token(Token = "0x4024405")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020047ED RID: 18413
		[Token(Token = "0x20047ED")]
		public enum StageTaskStatus
		{
			// Token: 0x04024407 RID: 148487
			[Token(Token = "0x4024407")]
			FAIL,
			// Token: 0x04024408 RID: 148488
			[Token(Token = "0x4024408")]
			NORMAL,
			// Token: 0x04024409 RID: 148489
			[Token(Token = "0x4024409")]
			EXCELLENT
		}
	}
}
