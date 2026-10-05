using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006101 RID: 24833
	[Token(Token = "0x2006101")]
	public class CampaignWorldViewModel : IHotfixable
	{
		// Token: 0x06023E47 RID: 147015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E47")]
		[Address(RVA = "0x1E8F220", Offset = "0x1E8DE20", VA = "0x181E8F220")]
		public void LoadData()
		{
		}

		// Token: 0x06023E48 RID: 147016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E48")]
		[Address(RVA = "0x1E8FA30", Offset = "0x1E8E630", VA = "0x181E8FA30")]
		private void _PostProcessData()
		{
		}

		// Token: 0x06023E49 RID: 147017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023E49")]
		[Address(RVA = "0x1E8F940", Offset = "0x1E8E540", VA = "0x181E8F940")]
		private string _CalcBriefId()
		{
			return null;
		}

		// Token: 0x06023E4A RID: 147018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E4A")]
		[Address(RVA = "0x1E904F0", Offset = "0x1E8F0F0", VA = "0x181E904F0")]
		public CampaignWorldViewModel()
		{
		}

		// Token: 0x04031CBB RID: 203963
		[Token(Token = "0x4031CBB")]
		[FieldOffset(Offset = "0x10")]
		public string curRotateStageId;

		// Token: 0x04031CBC RID: 203964
		[Token(Token = "0x4031CBC")]
		[FieldOffset(Offset = "0x18")]
		public string curTrainingGroupId;

		// Token: 0x04031CBD RID: 203965
		[Token(Token = "0x4031CBD")]
		[FieldOffset(Offset = "0x20")]
		public string curTrainingAllOpenGroupId;

		// Token: 0x04031CBE RID: 203966
		[Token(Token = "0x4031CBE")]
		[FieldOffset(Offset = "0x28")]
		public string briefId;

		// Token: 0x04031CBF RID: 203967
		[Token(Token = "0x4031CBF")]
		[FieldOffset(Offset = "0x30")]
		public string focusStartStageId;

		// Token: 0x04031CC0 RID: 203968
		[Token(Token = "0x4031CC0")]
		[FieldOffset(Offset = "0x38")]
		public string focusTargetStageId;

		// Token: 0x04031CC1 RID: 203969
		[Token(Token = "0x4031CC1")]
		[FieldOffset(Offset = "0x40")]
		public string focusTargetRegionId;

		// Token: 0x04031CC2 RID: 203970
		[Token(Token = "0x4031CC2")]
		[FieldOffset(Offset = "0x48")]
		public bool needFocus;

		// Token: 0x04031CC3 RID: 203971
		[Token(Token = "0x4031CC3")]
		[FieldOffset(Offset = "0x49")]
		public bool needPlayFogDisappear;

		// Token: 0x04031CC4 RID: 203972
		[Token(Token = "0x4031CC4")]
		[FieldOffset(Offset = "0x4A")]
		public bool needShowBrief;

		// Token: 0x04031CC5 RID: 203973
		[Token(Token = "0x4031CC5")]
		[FieldOffset(Offset = "0x50")]
		public List<Sprite> worldMapPieceSprites;

		// Token: 0x04031CC6 RID: 203974
		[Token(Token = "0x4031CC6")]
		[FieldOffset(Offset = "0x58")]
		public List<CampaignWorldRegionViewModel> regionModels;

		// Token: 0x04031CC7 RID: 203975
		[Token(Token = "0x4031CC7")]
		[FieldOffset(Offset = "0x60")]
		public List<CampaignWorldZoneViewModel> zoneModels;

		// Token: 0x04031CC8 RID: 203976
		[Token(Token = "0x4031CC8")]
		[FieldOffset(Offset = "0x68")]
		public List<CampaignWorldStageViewModel> stageModels;

		// Token: 0x04031CC9 RID: 203977
		[Token(Token = "0x4031CC9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04031CCA RID: 203978
		[Token(Token = "0x4031CCA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__PostProcessData;

		// Token: 0x04031CCB RID: 203979
		[Token(Token = "0x4031CCB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CalcBriefId;

		// Token: 0x04031CCC RID: 203980
		[Token(Token = "0x4031CCC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
