using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x0200614D RID: 24909
	[Token(Token = "0x200614D")]
	public class CampaignZoneMapViewModel : IHotfixable
	{
		// Token: 0x06023F66 RID: 147302 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023F66")]
		[Address(RVA = "0x1EADD00", Offset = "0x1EAC900", VA = "0x181EADD00")]
		public CampaignZoneMapStageViewModel GetSelectedStageModel()
		{
			return null;
		}

		// Token: 0x06023F67 RID: 147303 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023F67")]
		[Address(RVA = "0x1EADF40", Offset = "0x1EACB40", VA = "0x181EADF40")]
		public string SetSelectedStage(string stageId)
		{
			return null;
		}

		// Token: 0x06023F68 RID: 147304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F68")]
		[Address(RVA = "0x1EADDC0", Offset = "0x1EAC9C0", VA = "0x181EADDC0")]
		public void LoadData(string zoneId)
		{
		}

		// Token: 0x06023F69 RID: 147305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F69")]
		[Address(RVA = "0x1EADEC0", Offset = "0x1EACAC0", VA = "0x181EADEC0")]
		public void RefreshPlayerData()
		{
		}

		// Token: 0x06023F6A RID: 147306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023F6A")]
		[Address(RVA = "0x1EAE0F0", Offset = "0x1EACCF0", VA = "0x181EAE0F0")]
		public CampaignZoneMapViewModel()
		{
		}

		// Token: 0x04031EFB RID: 204539
		[Token(Token = "0x4031EFB")]
		public const int DEFAULT_SEQUENCE_NUM = 0;

		// Token: 0x04031EFC RID: 204540
		[Token(Token = "0x4031EFC")]
		[FieldOffset(Offset = "0x10")]
		public int sequenceNum;

		// Token: 0x04031EFD RID: 204541
		[Token(Token = "0x4031EFD")]
		[FieldOffset(Offset = "0x18")]
		public CampaignZoneMapZoneViewModel zoneModel;

		// Token: 0x04031EFE RID: 204542
		[Token(Token = "0x4031EFE")]
		[FieldOffset(Offset = "0x20")]
		public AutoCampConfigModel autoBattleModel;

		// Token: 0x04031EFF RID: 204543
		[Token(Token = "0x4031EFF")]
		[FieldOffset(Offset = "0x28")]
		public bool isTrainingAllOpen;

		// Token: 0x04031F00 RID: 204544
		[Token(Token = "0x4031F00")]
		[FieldOffset(Offset = "0x29")]
		public bool showRewardTrackpoint;

		// Token: 0x04031F01 RID: 204545
		[Token(Token = "0x4031F01")]
		[FieldOffset(Offset = "0x30")]
		private string m_selectedStageId;

		// Token: 0x04031F02 RID: 204546
		[Token(Token = "0x4031F02")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetSelectedStageModel;

		// Token: 0x04031F03 RID: 204547
		[Token(Token = "0x4031F03")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetSelectedStage;

		// Token: 0x04031F04 RID: 204548
		[Token(Token = "0x4031F04")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04031F05 RID: 204549
		[Token(Token = "0x4031F05")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RefreshPlayerData;

		// Token: 0x04031F06 RID: 204550
		[Token(Token = "0x4031F06")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
