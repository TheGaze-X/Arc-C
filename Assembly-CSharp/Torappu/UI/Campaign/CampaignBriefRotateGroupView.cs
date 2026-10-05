using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060C6 RID: 24774
	[Token(Token = "0x20060C6")]
	public class CampaignBriefRotateGroupView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06023D05 RID: 146693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D05")]
		[Address(RVA = "0x1E6D170", Offset = "0x1E6BD70", VA = "0x181E6D170")]
		public void Render(CampaignBriefRotateViewModel viewModel)
		{
		}

		// Token: 0x06023D06 RID: 146694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023D06")]
		[Address(RVA = "0x1E6D2D0", Offset = "0x1E6BED0", VA = "0x181E6D2D0")]
		public CampaignBriefRotateGroupView()
		{
		}

		// Token: 0x04031AA3 RID: 203427
		[Token(Token = "0x4031AA3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textRemainTime;

		// Token: 0x04031AA4 RID: 203428
		[Token(Token = "0x4031AA4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textZoneName;

		// Token: 0x04031AA5 RID: 203429
		[Token(Token = "0x4031AA5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textStageName;

		// Token: 0x04031AA6 RID: 203430
		[Token(Token = "0x4031AA6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Image _imageZoneIcon;

		// Token: 0x04031AA7 RID: 203431
		[Token(Token = "0x4031AA7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031AA8 RID: 203432
		[Token(Token = "0x4031AA8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
