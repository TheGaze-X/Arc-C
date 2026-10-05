using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060CD RID: 24781
	[Token(Token = "0x20060CD")]
	public class CampaignBriefStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06023D1D RID: 146717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D1D")]
		[Address(RVA = "0x1E6D6D0", Offset = "0x1E6C2D0", VA = "0x181E6D6D0")]
		public void LoadData()
		{
		}

		// Token: 0x06023D1E RID: 146718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D1E")]
		[Address(RVA = "0x1E6D740", Offset = "0x1E6C340", VA = "0x181E6D740")]
		public CampaignBriefStateBean()
		{
		}

		// Token: 0x04031AD1 RID: 203473
		[Token(Token = "0x4031AD1")]
		[FieldOffset(Offset = "0x10")]
		public CampaignBriefViewModel viewModel;

		// Token: 0x04031AD2 RID: 203474
		[Token(Token = "0x4031AD2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04031AD3 RID: 203475
		[Token(Token = "0x4031AD3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
