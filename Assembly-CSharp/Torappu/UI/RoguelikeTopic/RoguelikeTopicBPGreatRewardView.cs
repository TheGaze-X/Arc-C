using System;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x020044A4 RID: 17572
	[Token(Token = "0x20044A4")]
	public class RoguelikeTopicBPGreatRewardView : DataBinder<RoguelikeTopicBPGreatPrizeProperty>
	{
		// Token: 0x17003FB6 RID: 16310
		// (get) Token: 0x0601AD7C RID: 109948 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0601AD7D RID: 109949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003FB6")]
		private RoguelikeTopicBattlePassState bindState
		{
			[Token(Token = "0x601AD7C")]
			[Address(RVA = "0x13F0990", Offset = "0x13EF590", VA = "0x1813F0990")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x601AD7D")]
			[Address(RVA = "0x13F09F0", Offset = "0x13EF5F0", VA = "0x1813F09F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0601AD7E RID: 109950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD7E")]
		[Address(RVA = "0x13EFB70", Offset = "0x13EE770", VA = "0x1813EFB70")]
		public void Init(RoguelikeTopicBattlePassState state)
		{
		}

		// Token: 0x0601AD7F RID: 109951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD7F")]
		[Address(RVA = "0x13EFE80", Offset = "0x13EEA80", VA = "0x1813EFE80", Slot = "7")]
		public override void OnValueChanged(RoguelikeTopicBPGreatPrizeProperty property)
		{
		}

		// Token: 0x0601AD80 RID: 109952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD80")]
		[Address(RVA = "0x13F02C0", Offset = "0x13EEEC0", VA = "0x1813F02C0")]
		private void _RenderView(RoguelikeTopicBPGrandPrizeViewModel viewModel)
		{
		}

		// Token: 0x0601AD81 RID: 109953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD81")]
		[Address(RVA = "0x13F0110", Offset = "0x13EED10", VA = "0x1813F0110")]
		private void _RenderGrandPrizeState(RoguelikeTopicBPGrandPrizeViewModel viewModel)
		{
		}

		// Token: 0x0601AD82 RID: 109954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD82")]
		[Address(RVA = "0x13EFF70", Offset = "0x13EEB70", VA = "0x1813EFF70")]
		public void PlaySwitchAnim(bool isReverse, TweenCallback callback)
		{
		}

		// Token: 0x0601AD83 RID: 109955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD83")]
		[Address(RVA = "0x13EFCA0", Offset = "0x13EE8A0", VA = "0x1813EFCA0")]
		public void OnCheckBtnClick()
		{
		}

		// Token: 0x0601AD84 RID: 109956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD84")]
		[Address(RVA = "0x13EFD20", Offset = "0x13EE920", VA = "0x1813EFD20")]
		public void OnLeftArrowClick()
		{
		}

		// Token: 0x0601AD85 RID: 109957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD85")]
		[Address(RVA = "0x13EFE10", Offset = "0x13EEA10", VA = "0x1813EFE10")]
		public void OnRightArrowClick()
		{
		}

		// Token: 0x0601AD86 RID: 109958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD86")]
		[Address(RVA = "0x13EFC20", Offset = "0x13EE820", VA = "0x1813EFC20")]
		public void OnBtnRewardDetailClick()
		{
		}

		// Token: 0x0601AD87 RID: 109959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD87")]
		[Address(RVA = "0x13EFD90", Offset = "0x13EE990", VA = "0x1813EFD90")]
		public void OnPurchaseGrandPrizeClick()
		{
		}

		// Token: 0x0601AD88 RID: 109960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601AD88")]
		[Address(RVA = "0x13F0910", Offset = "0x13EF510", VA = "0x1813F0910")]
		public RoguelikeTopicBPGreatRewardView()
		{
		}

		// Token: 0x040225E2 RID: 140770
		[Token(Token = "0x40225E2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelReward;

		// Token: 0x040225E3 RID: 140771
		[Token(Token = "0x40225E3")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _rewardImg;

		// Token: 0x040225E4 RID: 140772
		[Token(Token = "0x40225E4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAtlasImage _dustImg;

		// Token: 0x040225E5 RID: 140773
		[Token(Token = "0x40225E5")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _panelValidLevel;

		// Token: 0x040225E6 RID: 140774
		[Token(Token = "0x40225E6")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelValidDate;

		// Token: 0x040225E7 RID: 140775
		[Token(Token = "0x40225E7")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _levelLabel;

		// Token: 0x040225E8 RID: 140776
		[Token(Token = "0x40225E8")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Text _levelText;

		// Token: 0x040225E9 RID: 140777
		[Token(Token = "0x40225E9")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _yearText;

		// Token: 0x040225EA RID: 140778
		[Token(Token = "0x40225EA")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _monthText;

		// Token: 0x040225EB RID: 140779
		[Token(Token = "0x40225EB")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Text _acquireTitleText;

		// Token: 0x040225EC RID: 140780
		[Token(Token = "0x40225EC")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _rewardNameText;

		// Token: 0x040225ED RID: 140781
		[Token(Token = "0x40225ED")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Text _rewardInfoText;

		// Token: 0x040225EE RID: 140782
		[Token(Token = "0x40225EE")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _panelCheckBtn;

		// Token: 0x040225EF RID: 140783
		[Token(Token = "0x40225EF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelReceivedState;

		// Token: 0x040225F0 RID: 140784
		[Token(Token = "0x40225F0")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _panelLeftArrow;

		// Token: 0x040225F1 RID: 140785
		[Token(Token = "0x40225F1")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _panelRightArrow;

		// Token: 0x040225F2 RID: 140786
		[Token(Token = "0x40225F2")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _btnRewardDetailGo;

		// Token: 0x040225F3 RID: 140787
		[Token(Token = "0x40225F3")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private UIAnimationLocation _switchAnim;

		// Token: 0x040225F4 RID: 140788
		[Token(Token = "0x40225F4")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _panelNotReceived;

		// Token: 0x040225F5 RID: 140789
		[Token(Token = "0x40225F5")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private GameObject _panelCanReceive;

		// Token: 0x040225F6 RID: 140790
		[Token(Token = "0x40225F6")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private GameObject _panelPurchase;

		// Token: 0x040225F7 RID: 140791
		[Token(Token = "0x40225F7")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private Text _textReceive;

		// Token: 0x040225F8 RID: 140792
		[Token(Token = "0x40225F8")]
		[FieldOffset(Offset = "0xD8")]
		[NonSerialized]
		public Action<int> onCheckBtnClick;

		// Token: 0x040225F9 RID: 140793
		[Token(Token = "0x40225F9")]
		[FieldOffset(Offset = "0xE0")]
		[NonSerialized]
		public Action onLeftArrowClick;

		// Token: 0x040225FA RID: 140794
		[Token(Token = "0x40225FA")]
		[FieldOffset(Offset = "0xE8")]
		[NonSerialized]
		public Action onRightArrowClick;

		// Token: 0x040225FB RID: 140795
		[Token(Token = "0x40225FB")]
		[FieldOffset(Offset = "0xF0")]
		[NonSerialized]
		public Action<RoguelikeTopicBPPrizeViewModel> onRewardDetailClick;

		// Token: 0x040225FC RID: 140796
		[Token(Token = "0x40225FC")]
		[FieldOffset(Offset = "0xF8")]
		[NonSerialized]
		public Action<RoguelikeTopicBPPrizeViewModel> onPurchaseGrandPrizeClick;

		// Token: 0x040225FD RID: 140797
		[Token(Token = "0x40225FD")]
		[FieldOffset(Offset = "0x100")]
		private int m_cachedSelectPos;

		// Token: 0x040225FE RID: 140798
		[Token(Token = "0x40225FE")]
		[FieldOffset(Offset = "0x104")]
		private int m_milestoneLevel;

		// Token: 0x040225FF RID: 140799
		[Token(Token = "0x40225FF")]
		[FieldOffset(Offset = "0x108")]
		private CharUISkinStruct m_charUISkinStruct;

		// Token: 0x04022600 RID: 140800
		[Token(Token = "0x4022600")]
		[FieldOffset(Offset = "0x120")]
		private UICharacterIllust m_charIllust;

		// Token: 0x04022601 RID: 140801
		[Token(Token = "0x4022601")]
		[FieldOffset(Offset = "0x128")]
		private RoguelikeTopicBPPrizeViewModel m_cachedSelectPrizeModel;

		// Token: 0x04022603 RID: 140803
		[Token(Token = "0x4022603")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bindState;

		// Token: 0x04022604 RID: 140804
		[Token(Token = "0x4022604")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_bindState;

		// Token: 0x04022605 RID: 140805
		[Token(Token = "0x4022605")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04022606 RID: 140806
		[Token(Token = "0x4022606")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04022607 RID: 140807
		[Token(Token = "0x4022607")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x04022608 RID: 140808
		[Token(Token = "0x4022608")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderGrandPrizeState;

		// Token: 0x04022609 RID: 140809
		[Token(Token = "0x4022609")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PlaySwitchAnim;

		// Token: 0x0402260A RID: 140810
		[Token(Token = "0x402260A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnCheckBtnClick;

		// Token: 0x0402260B RID: 140811
		[Token(Token = "0x402260B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnLeftArrowClick;

		// Token: 0x0402260C RID: 140812
		[Token(Token = "0x402260C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnRightArrowClick;

		// Token: 0x0402260D RID: 140813
		[Token(Token = "0x402260D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnBtnRewardDetailClick;

		// Token: 0x0402260E RID: 140814
		[Token(Token = "0x402260E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnPurchaseGrandPrizeClick;

		// Token: 0x0402260F RID: 140815
		[Token(Token = "0x402260F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
