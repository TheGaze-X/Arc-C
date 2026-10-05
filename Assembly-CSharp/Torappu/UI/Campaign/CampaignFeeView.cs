using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060E3 RID: 24803
	[Token(Token = "0x20060E3")]
	public class CampaignFeeView : DataBinder<CampaignFeeViewProperty>
	{
		// Token: 0x170054B4 RID: 21684
		// (get) Token: 0x06023DA5 RID: 146853 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023DA6 RID: 146854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170054B4")]
		public Action onClicked
		{
			[Token(Token = "0x6023DA5")]
			[Address(RVA = "0x1E709F0", Offset = "0x1E6F5F0", VA = "0x181E709F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6023DA6")]
			[Address(RVA = "0x1E70A50", Offset = "0x1E6F650", VA = "0x181E70A50")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06023DA7 RID: 146855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DA7")]
		[Address(RVA = "0x1E705E0", Offset = "0x1E6F1E0", VA = "0x181E705E0", Slot = "7")]
		public override void OnValueChanged(CampaignFeeViewProperty prop)
		{
		}

		// Token: 0x06023DA8 RID: 146856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DA8")]
		[Address(RVA = "0x1E704D0", Offset = "0x1E6F0D0", VA = "0x181E704D0")]
		public void EventOnClicked()
		{
		}

		// Token: 0x06023DA9 RID: 146857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DA9")]
		[Address(RVA = "0x1E70730", Offset = "0x1E6F330", VA = "0x181E70730")]
		private void _Render(CampaignFeeViewModel viewModel)
		{
		}

		// Token: 0x06023DAA RID: 146858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DAA")]
		[Address(RVA = "0x1E70670", Offset = "0x1E6F270", VA = "0x181E70670")]
		public void RegisterTutorialGo()
		{
		}

		// Token: 0x06023DAB RID: 146859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DAB")]
		[Address(RVA = "0x1E70980", Offset = "0x1E6F580", VA = "0x181E70980")]
		public CampaignFeeView()
		{
		}

		// Token: 0x04031B78 RID: 203640
		[Token(Token = "0x4031B78")]
		private const string TEXT_PROGRESS_FORMAT = "{0}<size=21>/{1}</size>";

		// Token: 0x04031B79 RID: 203641
		[Token(Token = "0x4031B79")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textCountDown;

		// Token: 0x04031B7A RID: 203642
		[Token(Token = "0x4031B7A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x04031B7B RID: 203643
		[Token(Token = "0x4031B7B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider _sliderProgress;

		// Token: 0x04031B7C RID: 203644
		[Token(Token = "0x4031B7C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Image _imageNotFull;

		// Token: 0x04031B7D RID: 203645
		[Token(Token = "0x4031B7D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _imageHasUnconfirmed;

		// Token: 0x04031B7E RID: 203646
		[Token(Token = "0x4031B7E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _panelTutorial;

		// Token: 0x04031B80 RID: 203648
		[Token(Token = "0x4031B80")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x04031B81 RID: 203649
		[Token(Token = "0x4031B81")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x04031B82 RID: 203650
		[Token(Token = "0x4031B82")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04031B83 RID: 203651
		[Token(Token = "0x4031B83")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x04031B84 RID: 203652
		[Token(Token = "0x4031B84")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__Render;

		// Token: 0x04031B85 RID: 203653
		[Token(Token = "0x4031B85")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RegisterTutorialGo;

		// Token: 0x04031B86 RID: 203654
		[Token(Token = "0x4031B86")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
