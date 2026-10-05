using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060D1 RID: 24785
	[Token(Token = "0x20060D1")]
	public class CampaignBriefView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023D29 RID: 146729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D29")]
		[Address(RVA = "0x1E6F5F0", Offset = "0x1E6E1F0", VA = "0x181E6F5F0")]
		public void Render(CampaignBriefViewModel viewModel)
		{
		}

		// Token: 0x06023D2A RID: 146730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D2A")]
		[Address(RVA = "0x1E6F820", Offset = "0x1E6E420", VA = "0x181E6F820")]
		public CampaignBriefView()
		{
		}

		// Token: 0x04031AED RID: 203501
		[Token(Token = "0x4031AED")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ScrollRect _scrollRect;

		// Token: 0x04031AEE RID: 203502
		[Token(Token = "0x4031AEE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CampaignBriefRotateGroupView _rotateGroupView;

		// Token: 0x04031AEF RID: 203503
		[Token(Token = "0x4031AEF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CampaignBriefTrainingGroupView _trainingGroupView;

		// Token: 0x04031AF0 RID: 203504
		[Token(Token = "0x4031AF0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CampaignBriefTrainingGroupView _nextTrainingGroupView;

		// Token: 0x04031AF1 RID: 203505
		[Token(Token = "0x4031AF1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031AF2 RID: 203506
		[Token(Token = "0x4031AF2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
