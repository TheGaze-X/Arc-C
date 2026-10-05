using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060CC RID: 24780
	[Token(Token = "0x20060CC")]
	public class CampaignBriefViewModel : IHotfixable
	{
		// Token: 0x06023D1B RID: 146715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D1B")]
		[Address(RVA = "0x1E6F190", Offset = "0x1E6DD90", VA = "0x181E6F190")]
		public void LoadData()
		{
		}

		// Token: 0x06023D1C RID: 146716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D1C")]
		[Address(RVA = "0x1E6F4A0", Offset = "0x1E6E0A0", VA = "0x181E6F4A0")]
		public CampaignBriefViewModel()
		{
		}

		// Token: 0x04031ACC RID: 203468
		[Token(Token = "0x4031ACC")]
		[FieldOffset(Offset = "0x10")]
		public CampaignBriefRotateViewModel rotateModel;

		// Token: 0x04031ACD RID: 203469
		[Token(Token = "0x4031ACD")]
		[FieldOffset(Offset = "0x18")]
		public CampaignBriefTrainingViewModel trainingModel;

		// Token: 0x04031ACE RID: 203470
		[Token(Token = "0x4031ACE")]
		[FieldOffset(Offset = "0x20")]
		public CampaignBriefTrainingViewModel nextTrainingModel;

		// Token: 0x04031ACF RID: 203471
		[Token(Token = "0x4031ACF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04031AD0 RID: 203472
		[Token(Token = "0x4031AD0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
