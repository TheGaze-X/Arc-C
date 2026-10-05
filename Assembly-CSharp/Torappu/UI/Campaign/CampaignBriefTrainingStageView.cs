using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060D0 RID: 24784
	[Token(Token = "0x20060D0")]
	public class CampaignBriefTrainingStageView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023D27 RID: 146727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D27")]
		[Address(RVA = "0x1E6E390", Offset = "0x1E6CF90", VA = "0x181E6E390")]
		public void Render(CampaignBriefTrainingViewModel.StageInfoViewModel viewModel)
		{
		}

		// Token: 0x06023D28 RID: 146728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D28")]
		[Address(RVA = "0x1E6E4A0", Offset = "0x1E6D0A0", VA = "0x181E6E4A0")]
		public CampaignBriefTrainingStageView()
		{
		}

		// Token: 0x04031AE9 RID: 203497
		[Token(Token = "0x4031AE9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textZoneName;

		// Token: 0x04031AEA RID: 203498
		[Token(Token = "0x4031AEA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textStageNames;

		// Token: 0x04031AEB RID: 203499
		[Token(Token = "0x4031AEB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031AEC RID: 203500
		[Token(Token = "0x4031AEC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
