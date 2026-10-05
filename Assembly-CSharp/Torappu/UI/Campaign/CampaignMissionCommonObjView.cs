using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060E6 RID: 24806
	[Token(Token = "0x20060E6")]
	public class CampaignMissionCommonObjView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170054B5 RID: 21685
		// (get) Token: 0x06023DAF RID: 146863 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023DB0 RID: 146864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170054B5")]
		public Action<CampaignCommonMissionViewModel> onClicked
		{
			[Token(Token = "0x6023DAF")]
			[Address(RVA = "0x1E70F80", Offset = "0x1E6FB80", VA = "0x181E70F80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6023DB0")]
			[Address(RVA = "0x1E70FE0", Offset = "0x1E6FBE0", VA = "0x181E70FE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06023DB1 RID: 146865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DB1")]
		[Address(RVA = "0x1E70BB0", Offset = "0x1E6F7B0", VA = "0x181E70BB0")]
		public void Render(CampaignCommonMissionViewModel viewModel)
		{
		}

		// Token: 0x06023DB2 RID: 146866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DB2")]
		[Address(RVA = "0x1E70AD0", Offset = "0x1E6F6D0", VA = "0x181E70AD0")]
		public void EventOnClicked()
		{
		}

		// Token: 0x06023DB3 RID: 146867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DB3")]
		[Address(RVA = "0x1E70F20", Offset = "0x1E6FB20", VA = "0x181E70F20")]
		public CampaignMissionCommonObjView()
		{
		}

		// Token: 0x04031B8E RID: 203662
		[Token(Token = "0x4031B8E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04031B8F RID: 203663
		[Token(Token = "0x4031B8F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x04031B90 RID: 203664
		[Token(Token = "0x4031B90")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Slider _sliderProgress;

		// Token: 0x04031B91 RID: 203665
		[Token(Token = "0x4031B91")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textBreakFeeAdd;

		// Token: 0x04031B92 RID: 203666
		[Token(Token = "0x4031B92")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RectTransform _panelLocked;

		// Token: 0x04031B93 RID: 203667
		[Token(Token = "0x4031B93")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textUnlock;

		// Token: 0x04031B94 RID: 203668
		[Token(Token = "0x4031B94")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private RectTransform _panelFinished;

		// Token: 0x04031B95 RID: 203669
		[Token(Token = "0x4031B95")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _panelConfirm;

		// Token: 0x04031B96 RID: 203670
		[Token(Token = "0x4031B96")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _buttonSelf;

		// Token: 0x04031B97 RID: 203671
		[Token(Token = "0x4031B97")]
		[FieldOffset(Offset = "0x60")]
		private CampaignCommonMissionViewModel m_cacheModel;

		// Token: 0x04031B99 RID: 203673
		[Token(Token = "0x4031B99")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x04031B9A RID: 203674
		[Token(Token = "0x4031B9A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x04031B9B RID: 203675
		[Token(Token = "0x4031B9B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031B9C RID: 203676
		[Token(Token = "0x4031B9C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x04031B9D RID: 203677
		[Token(Token = "0x4031B9D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
