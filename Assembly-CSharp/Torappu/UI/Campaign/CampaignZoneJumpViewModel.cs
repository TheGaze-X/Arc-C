using System;
using Il2CppDummyDll;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006136 RID: 24886
	[Token(Token = "0x2006136")]
	public class CampaignZoneJumpViewModel
	{
		// Token: 0x170054D4 RID: 21716
		// (get) Token: 0x06023EE3 RID: 147171 RVA: 0x000C26A0 File Offset: 0x000C08A0
		[Token(Token = "0x170054D4")]
		public CampaignStageType stageType
		{
			[Token(Token = "0x6023EE3")]
			[Address(RVA = "0x1E934D0", Offset = "0x1E920D0", VA = "0x181E934D0")]
			get
			{
				return CampaignStageType.NONE;
			}
		}

		// Token: 0x06023EE4 RID: 147172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EE4")]
		[Address(RVA = "0x1E93470", Offset = "0x1E92070", VA = "0x181E93470")]
		public void RefreshInfo()
		{
		}

		// Token: 0x06023EE5 RID: 147173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023EE5")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CampaignZoneJumpViewModel()
		{
		}

		// Token: 0x04031E0F RID: 204303
		[Token(Token = "0x4031E0F")]
		[FieldOffset(Offset = "0x10")]
		public CampaignZoneMapZoneViewModel zoneViewModel;

		// Token: 0x04031E10 RID: 204304
		[Token(Token = "0x4031E10")]
		[FieldOffset(Offset = "0x18")]
		public CampaignZoneMapStageViewModel mapViewModel;

		// Token: 0x04031E11 RID: 204305
		[Token(Token = "0x4031E11")]
		[FieldOffset(Offset = "0x20")]
		public bool isNew;

		// Token: 0x04031E12 RID: 204306
		[Token(Token = "0x4031E12")]
		[FieldOffset(Offset = "0x21")]
		public bool hasRewardToGet;

		// Token: 0x04031E13 RID: 204307
		[Token(Token = "0x4031E13")]
		[FieldOffset(Offset = "0x22")]
		public bool getAllReward;
	}
}
