using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Campaign
{
	// Token: 0x020060E7 RID: 24807
	[Token(Token = "0x20060E7")]
	public class CampaignMissionPermObjView : MonoBehaviour, IHotfixable
	{
		// Token: 0x170054B6 RID: 21686
		// (get) Token: 0x06023DB4 RID: 146868 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06023DB5 RID: 146869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170054B6")]
		public Action<CampaignPermanentMissionViewModel> onClicked
		{
			[Token(Token = "0x6023DB4")]
			[Address(RVA = "0x1E71510", Offset = "0x1E70110", VA = "0x181E71510")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6023DB5")]
			[Address(RVA = "0x1E71570", Offset = "0x1E70170", VA = "0x181E71570")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06023DB6 RID: 146870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DB6")]
		[Address(RVA = "0x1E71170", Offset = "0x1E6FD70", VA = "0x181E71170")]
		public void Render(CampaignPermanentMissionViewModel viewModel)
		{
		}

		// Token: 0x06023DB7 RID: 146871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DB7")]
		[Address(RVA = "0x1E71060", Offset = "0x1E6FC60", VA = "0x181E71060")]
		public void EventOnClicked()
		{
		}

		// Token: 0x06023DB8 RID: 146872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023DB8")]
		[Address(RVA = "0x1E714B0", Offset = "0x1E700B0", VA = "0x181E714B0")]
		public CampaignMissionPermObjView()
		{
		}

		// Token: 0x04031B9E RID: 203678
		[Token(Token = "0x4031B9E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textCode;

		// Token: 0x04031B9F RID: 203679
		[Token(Token = "0x4031B9F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x04031BA0 RID: 203680
		[Token(Token = "0x4031BA0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textProgress;

		// Token: 0x04031BA1 RID: 203681
		[Token(Token = "0x4031BA1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Slider _sliderProgress;

		// Token: 0x04031BA2 RID: 203682
		[Token(Token = "0x4031BA2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textRemainBreakFeeAdd;

		// Token: 0x04031BA3 RID: 203683
		[Token(Token = "0x4031BA3")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RectTransform _panelLocked;

		// Token: 0x04031BA4 RID: 203684
		[Token(Token = "0x4031BA4")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textUnlock;

		// Token: 0x04031BA5 RID: 203685
		[Token(Token = "0x4031BA5")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _panelFinished;

		// Token: 0x04031BA6 RID: 203686
		[Token(Token = "0x4031BA6")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Button _buttonSelf;

		// Token: 0x04031BA7 RID: 203687
		[Token(Token = "0x4031BA7")]
		[FieldOffset(Offset = "0x60")]
		private CampaignPermanentMissionViewModel m_cacheModel;

		// Token: 0x04031BA9 RID: 203689
		[Token(Token = "0x4031BA9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_onClicked;

		// Token: 0x04031BAA RID: 203690
		[Token(Token = "0x4031BAA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_onClicked;

		// Token: 0x04031BAB RID: 203691
		[Token(Token = "0x4031BAB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04031BAC RID: 203692
		[Token(Token = "0x4031BAC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClicked;

		// Token: 0x04031BAD RID: 203693
		[Token(Token = "0x4031BAD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
