using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x02006106 RID: 24838
	[Token(Token = "0x2006106")]
	public class CampaignWolrdHomeBriefViewModel : IHotfixable
	{
		// Token: 0x06023E52 RID: 147026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E52")]
		[Address(RVA = "0x1E89700", Offset = "0x1E88300", VA = "0x181E89700")]
		public void LoadData()
		{
		}

		// Token: 0x06023E53 RID: 147027 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023E53")]
		[Address(RVA = "0x1E89760", Offset = "0x1E88360", VA = "0x181E89760")]
		public CampaignWolrdHomeBriefViewModel()
		{
		}

		// Token: 0x04031CE8 RID: 204008
		[Token(Token = "0x4031CE8")]
		[FieldOffset(Offset = "0x10")]
		public bool isTrainingAllOpen;

		// Token: 0x04031CE9 RID: 204009
		[Token(Token = "0x4031CE9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04031CEA RID: 204010
		[Token(Token = "0x4031CEA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
