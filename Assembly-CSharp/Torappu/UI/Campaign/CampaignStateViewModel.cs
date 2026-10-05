using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.Stage;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x0200612D RID: 24877
	[Token(Token = "0x200612D")]
	public class CampaignStateViewModel : IHotfixable
	{
		// Token: 0x06023ECB RID: 147147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023ECB")]
		[Address(RVA = "0x1E88F80", Offset = "0x1E87B80", VA = "0x181E88F80")]
		public CampaignStateViewModel(CampaignData campData, CampaignStageType stageType)
		{
		}

		// Token: 0x06023ECC RID: 147148 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023ECC")]
		[Address(RVA = "0x1E88D40", Offset = "0x1E87940", VA = "0x181E88D40")]
		public void SetPlayerData(PlayerCampaign.Stage instance)
		{
		}

		// Token: 0x04031DCE RID: 204238
		[Token(Token = "0x4031DCE")]
		private const string PROGRESS_FORMAT = "{0}/{1}";

		// Token: 0x04031DCF RID: 204239
		[Token(Token = "0x4031DCF")]
		[FieldOffset(Offset = "0x10")]
		public string id;

		// Token: 0x04031DD0 RID: 204240
		[Token(Token = "0x4031DD0")]
		[FieldOffset(Offset = "0x18")]
		public int curMaxKillCnt;

		// Token: 0x04031DD1 RID: 204241
		[Token(Token = "0x4031DD1")]
		[FieldOffset(Offset = "0x20")]
		public StageViewModel stageCommonViewModel;

		// Token: 0x04031DD2 RID: 204242
		[Token(Token = "0x4031DD2")]
		[FieldOffset(Offset = "0x28")]
		public List<CampaignBreakDetailItemViewModel> breakLadders;

		// Token: 0x04031DD3 RID: 204243
		[Token(Token = "0x4031DD3")]
		[FieldOffset(Offset = "0x30")]
		public List<StageRewardViewModel> displayRewards;

		// Token: 0x04031DD4 RID: 204244
		[Token(Token = "0x4031DD4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04031DD5 RID: 204245
		[Token(Token = "0x4031DD5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetPlayerData;
	}
}
