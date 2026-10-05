using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A44 RID: 19012
	[Token(Token = "0x2004A44")]
	public class InformantSingleSettlementDialog : UICompDialog<InformantDialogCommonInput>, IHotfixable
	{
		// Token: 0x0601C949 RID: 117065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C949")]
		[Address(RVA = "0x161A2A0", Offset = "0x1618EA0", VA = "0x18161A2A0", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601C94A RID: 117066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C94A")]
		[Address(RVA = "0x161A3F0", Offset = "0x1618FF0", VA = "0x18161A3F0", Slot = "18")]
		protected override void OnRender(InformantDialogCommonInput input)
		{
		}

		// Token: 0x0601C94B RID: 117067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C94B")]
		[Address(RVA = "0x161AA70", Offset = "0x1619670", VA = "0x18161AA70")]
		private void _PlayFirstAnim()
		{
		}

		// Token: 0x0601C94C RID: 117068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C94C")]
		[Address(RVA = "0x161AC70", Offset = "0x1619870", VA = "0x18161AC70")]
		private void _PlaySecondAnim()
		{
		}

		// Token: 0x0601C94D RID: 117069 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C94D")]
		[Address(RVA = "0x161A9A0", Offset = "0x16195A0", VA = "0x18161A9A0")]
		private IEnumerator _PlayAudioWithDelay(string signal, float delay)
		{
			return null;
		}

		// Token: 0x0601C94E RID: 117070 RVA: 0x000A8AB0 File Offset: 0x000A6CB0
		[Token(Token = "0x601C94E")]
		[Address(RVA = "0x161A940", Offset = "0x1619540", VA = "0x18161A940")]
		private int _Getter()
		{
			return 0;
		}

		// Token: 0x0601C94F RID: 117071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C94F")]
		[Address(RVA = "0x161B150", Offset = "0x1619D50", VA = "0x18161B150")]
		private void _Setter(int value)
		{
		}

		// Token: 0x0601C950 RID: 117072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C950")]
		[Address(RVA = "0x161B1E0", Offset = "0x1619DE0", VA = "0x18161B1E0")]
		private void _TryTriggerTutorial()
		{
		}

		// Token: 0x0601C951 RID: 117073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C951")]
		[Address(RVA = "0x161B2C0", Offset = "0x1619EC0", VA = "0x18161B2C0")]
		private void _TutorialOnly_SecondAnimRouted()
		{
		}

		// Token: 0x0601C952 RID: 117074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C952")]
		[Address(RVA = "0x161A180", Offset = "0x1618D80", VA = "0x18161A180")]
		public void EventOnBackgroundClick()
		{
		}

		// Token: 0x0601C953 RID: 117075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C953")]
		[Address(RVA = "0x161B370", Offset = "0x1619F70", VA = "0x18161B370")]
		public InformantSingleSettlementDialog()
		{
		}

		// Token: 0x0601C954 RID: 117076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C954")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0402583F RID: 153663
		[Token(Token = "0x402583F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private UIAnimationLocation _checkSuccessAnim;

		// Token: 0x04025840 RID: 153664
		[Token(Token = "0x4025840")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _checkFailureAnim;

		// Token: 0x04025841 RID: 153665
		[Token(Token = "0x4025841")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _settleSuccessAnim;

		// Token: 0x04025842 RID: 153666
		[Token(Token = "0x4025842")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIAnimationLocation _settleFailureAnim;

		// Token: 0x04025843 RID: 153667
		[Token(Token = "0x4025843")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private UIAnimationLocation _noPatienceAnim;

		// Token: 0x04025844 RID: 153668
		[Token(Token = "0x4025844")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private float _checkAudioDelay;

		// Token: 0x04025845 RID: 153669
		[Token(Token = "0x4025845")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private InformantMilestonePointItemView _checkSuccessRate;

		// Token: 0x04025846 RID: 153670
		[Token(Token = "0x4025846")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private InformantInsightBarView _checkInsightBar;

		// Token: 0x04025847 RID: 153671
		[Token(Token = "0x4025847")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Text _settleSuccessRate;

		// Token: 0x04025848 RID: 153672
		[Token(Token = "0x4025848")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Text _settleIncomeRate;

		// Token: 0x04025849 RID: 153673
		[Token(Token = "0x4025849")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		private Text _accountBasicIncome;

		// Token: 0x0402584A RID: 153674
		[Token(Token = "0x402584A")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		private Text _accountIncomeRate;

		// Token: 0x0402584B RID: 153675
		[Token(Token = "0x402584B")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		private GameObject _accountBonusObject;

		// Token: 0x0402584C RID: 153676
		[Token(Token = "0x402584C")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		private Text _accountBonusRate;

		// Token: 0x0402584D RID: 153677
		[Token(Token = "0x402584D")]
		[FieldOffset(Offset = "0x108")]
		[SerializeField]
		private InformantMilestonePointItemView _milestonePointPrefab;

		// Token: 0x0402584E RID: 153678
		[Token(Token = "0x402584E")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private RectTransform _milestoneContainer;

		// Token: 0x0402584F RID: 153679
		[Token(Token = "0x402584F")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private float _milestoneTweenDuration;

		// Token: 0x04025850 RID: 153680
		[Token(Token = "0x4025850")]
		[FieldOffset(Offset = "0x11C")]
		[SerializeField]
		private float _milestoneTweenSuccessDelay;

		// Token: 0x04025851 RID: 153681
		[Token(Token = "0x4025851")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private float _milestoneTweenFailDelay;

		// Token: 0x04025852 RID: 153682
		[Token(Token = "0x4025852")]
		[FieldOffset(Offset = "0x128")]
		[SerializeField]
		private Text _keeperDialog;

		// Token: 0x04025853 RID: 153683
		[Token(Token = "0x4025853")]
		[FieldOffset(Offset = "0x130")]
		[SerializeField]
		private InformantInsightBarView _settleInsightBar;

		// Token: 0x04025854 RID: 153684
		[Token(Token = "0x4025854")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		private InformantCustomerBarView _customerBarPrefab;

		// Token: 0x04025855 RID: 153685
		[Token(Token = "0x4025855")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private RectTransform _customerBarContainer;

		// Token: 0x04025856 RID: 153686
		[Token(Token = "0x4025856")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private Font _successRateFont;

		// Token: 0x04025857 RID: 153687
		[Token(Token = "0x4025857")]
		[FieldOffset(Offset = "0x150")]
		private InformantSingleSettlementViewModel m_viewModel;

		// Token: 0x04025858 RID: 153688
		[Token(Token = "0x4025858")]
		[FieldOffset(Offset = "0x158")]
		private InformantMilestonePointItemView m_milestoneView;

		// Token: 0x04025859 RID: 153689
		[Token(Token = "0x4025859")]
		[FieldOffset(Offset = "0x160")]
		private Tween m_enterAnimTween;

		// Token: 0x0402585A RID: 153690
		[Token(Token = "0x402585A")]
		[FieldOffset(Offset = "0x168")]
		private Tween m_milestonePointTween;

		// Token: 0x0402585B RID: 153691
		[Token(Token = "0x402585B")]
		[FieldOffset(Offset = "0x170")]
		private int m_cachePointNum;

		// Token: 0x0402585C RID: 153692
		[Token(Token = "0x402585C")]
		[FieldOffset(Offset = "0x178")]
		private InformantCustomerBarProperty m_customerBarProperty;

		// Token: 0x0402585D RID: 153693
		[Token(Token = "0x402585D")]
		[FieldOffset(Offset = "0x180")]
		private UIPageFinder m_pageFinder;

		// Token: 0x0402585E RID: 153694
		[Token(Token = "0x402585E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0402585F RID: 153695
		[Token(Token = "0x402585F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04025860 RID: 153696
		[Token(Token = "0x4025860")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayFirstAnim;

		// Token: 0x04025861 RID: 153697
		[Token(Token = "0x4025861")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__PlaySecondAnim;

		// Token: 0x04025862 RID: 153698
		[Token(Token = "0x4025862")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__PlayAudioWithDelay;

		// Token: 0x04025863 RID: 153699
		[Token(Token = "0x4025863")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__Getter;

		// Token: 0x04025864 RID: 153700
		[Token(Token = "0x4025864")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__Setter;

		// Token: 0x04025865 RID: 153701
		[Token(Token = "0x4025865")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__TryTriggerTutorial;

		// Token: 0x04025866 RID: 153702
		[Token(Token = "0x4025866")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TutorialOnly_SecondAnimRouted;

		// Token: 0x04025867 RID: 153703
		[Token(Token = "0x4025867")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_EventOnBackgroundClick;

		// Token: 0x04025868 RID: 153704
		[Token(Token = "0x4025868")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
