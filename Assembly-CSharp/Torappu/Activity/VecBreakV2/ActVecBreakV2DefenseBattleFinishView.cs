using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.BattleFinish;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.VecBreakV2
{
	// Token: 0x02006DE4 RID: 28132
	[Token(Token = "0x2006DE4")]
	public class ActVecBreakV2DefenseBattleFinishView : DynBattleFinishView
	{
		// Token: 0x060280DE RID: 164062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280DE")]
		[Address(RVA = "0x234E0A0", Offset = "0x234CCA0", VA = "0x18234E0A0", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x060280DF RID: 164063 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60280DF")]
		[Address(RVA = "0x234E2D0", Offset = "0x234CED0", VA = "0x18234E2D0", Slot = "7")]
		public override IEnumerator ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x060280E0 RID: 164064 RVA: 0x000D0950 File Offset: 0x000CEB50
		[Token(Token = "0x60280E0")]
		[Address(RVA = "0x234E3C0", Offset = "0x234CFC0", VA = "0x18234E3C0")]
		private int _MilestoneTweenGetter()
		{
			return 0;
		}

		// Token: 0x060280E1 RID: 164065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280E1")]
		[Address(RVA = "0x234E420", Offset = "0x234D020", VA = "0x18234E420")]
		private void _MilestoneTweenSetter(int value)
		{
		}

		// Token: 0x060280E2 RID: 164066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280E2")]
		[Address(RVA = "0x234F0B0", Offset = "0x234DCB0", VA = "0x18234F0B0")]
		private void _RenderStageSquadInfo()
		{
		}

		// Token: 0x060280E3 RID: 164067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280E3")]
		[Address(RVA = "0x234ECF0", Offset = "0x234D8F0", VA = "0x18234ECF0")]
		private void _RenderMilestone()
		{
		}

		// Token: 0x060280E4 RID: 164068 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280E4")]
		[Address(RVA = "0x234EDF0", Offset = "0x234D9F0", VA = "0x18234EDF0")]
		private void _RenderSaveSquadPanel()
		{
		}

		// Token: 0x060280E5 RID: 164069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280E5")]
		[Address(RVA = "0x234E4E0", Offset = "0x234D0E0", VA = "0x18234E4E0")]
		private void _OnEnterAnimComplete()
		{
		}

		// Token: 0x060280E6 RID: 164070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280E6")]
		[Address(RVA = "0x234EAC0", Offset = "0x234D6C0", VA = "0x18234EAC0")]
		private void _PlayMilestoneTween()
		{
		}

		// Token: 0x060280E7 RID: 164071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280E7")]
		[Address(RVA = "0x234F530", Offset = "0x234E130", VA = "0x18234F530")]
		private void _TryPlaySaveSquadPanelAnim()
		{
		}

		// Token: 0x060280E8 RID: 164072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280E8")]
		[Address(RVA = "0x234E6B0", Offset = "0x234D2B0", VA = "0x18234E6B0")]
		private void _PlayEnterAnim()
		{
		}

		// Token: 0x060280E9 RID: 164073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280E9")]
		[Address(RVA = "0x234F4A0", Offset = "0x234E0A0", VA = "0x18234F4A0")]
		private void _ShowStageCompleteToast()
		{
		}

		// Token: 0x060280EA RID: 164074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280EA")]
		[Address(RVA = "0x234E8B0", Offset = "0x234D4B0", VA = "0x18234E8B0")]
		private void _PlayIllustVoice()
		{
		}

		// Token: 0x060280EB RID: 164075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280EB")]
		[Address(RVA = "0x234DCB0", Offset = "0x234C8B0", VA = "0x18234DCB0")]
		public void EventSaveSquad()
		{
		}

		// Token: 0x060280EC RID: 164076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280EC")]
		[Address(RVA = "0x234DC50", Offset = "0x234C850", VA = "0x18234DC50")]
		public void EventCancelSaveSquad()
		{
		}

		// Token: 0x060280ED RID: 164077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280ED")]
		[Address(RVA = "0x234DBD0", Offset = "0x234C7D0", VA = "0x18234DBD0")]
		public void EventBackToDefensePage()
		{
		}

		// Token: 0x060280EE RID: 164078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60280EE")]
		[Address(RVA = "0x234F680", Offset = "0x234E280", VA = "0x18234F680")]
		public ActVecBreakV2DefenseBattleFinishView()
		{
		}

		// Token: 0x060280F0 RID: 164080 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60280F0")]
		[Address(RVA = "0x17E4700", Offset = "0x17E3300", VA = "0x1817E4700")]
		private IEnumerator <>xLuaBaseProxy_ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x04038CEB RID: 232683
		[Token(Token = "0x4038CEB")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _playerNameWithNumber;

		// Token: 0x04038CEC RID: 232684
		[Token(Token = "0x4038CEC")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _completeTime;

		// Token: 0x04038CED RID: 232685
		[Token(Token = "0x4038CED")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _stageCode;

		// Token: 0x04038CEE RID: 232686
		[Token(Token = "0x4038CEE")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _stageName;

		// Token: 0x04038CEF RID: 232687
		[Token(Token = "0x4038CEF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Image _buffIcon;

		// Token: 0x04038CF0 RID: 232688
		[Token(Token = "0x4038CF0")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _buffIconBottom;

		// Token: 0x04038CF1 RID: 232689
		[Token(Token = "0x4038CF1")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private ActVecBreakV2DefenseBattleFinishCharCardView[] _cardViewList;

		// Token: 0x04038CF2 RID: 232690
		[Token(Token = "0x4038CF2")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private ActVecBreakV2BattleFinishMilestoneView _milestoneView;

		// Token: 0x04038CF3 RID: 232691
		[Token(Token = "0x4038CF3")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _tweenDelay;

		// Token: 0x04038CF4 RID: 232692
		[Token(Token = "0x4038CF4")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _tweenDuration;

		// Token: 0x04038CF5 RID: 232693
		[Token(Token = "0x4038CF5")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _rootSaveSquadPanel;

		// Token: 0x04038CF6 RID: 232694
		[Token(Token = "0x4038CF6")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ActVecBreakV2DefenseBattleFinishCharAvatarView[] _prevCharAvatarList;

		// Token: 0x04038CF7 RID: 232695
		[Token(Token = "0x4038CF7")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ActVecBreakV2DefenseBattleFinishCharAvatarView[] _newCharAvatarList;

		// Token: 0x04038CF8 RID: 232696
		[Token(Token = "0x4038CF8")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x04038CF9 RID: 232697
		[Token(Token = "0x4038CF9")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private UIAnimationLocation _savePanelAnim;

		// Token: 0x04038CFA RID: 232698
		[Token(Token = "0x4038CFA")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private UIButton _backgroundButton;

		// Token: 0x04038CFB RID: 232699
		[Token(Token = "0x4038CFB")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _illustVoiceDelay;

		// Token: 0x04038CFC RID: 232700
		[Token(Token = "0x4038CFC")]
		[FieldOffset(Offset = "0xB0")]
		private ActVecBreakV2DefenseBattleFinishViewModel m_viewModel;

		// Token: 0x04038CFD RID: 232701
		[Token(Token = "0x4038CFD")]
		[FieldOffset(Offset = "0xB8")]
		private int m_cacheMilestonePoint;

		// Token: 0x04038CFE RID: 232702
		[Token(Token = "0x4038CFE")]
		[FieldOffset(Offset = "0xC0")]
		private Tween m_milestoneTween;

		// Token: 0x04038CFF RID: 232703
		[Token(Token = "0x4038CFF")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_enterAnimTween;

		// Token: 0x04038D00 RID: 232704
		[Token(Token = "0x4038D00")]
		[FieldOffset(Offset = "0xD0")]
		private Tween m_saveSquadPanelAnimTween;

		// Token: 0x04038D01 RID: 232705
		[Token(Token = "0x4038D01")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04038D02 RID: 232706
		[Token(Token = "0x4038D02")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowEnterEffectCoroutine;

		// Token: 0x04038D03 RID: 232707
		[Token(Token = "0x4038D03")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__MilestoneTweenGetter;

		// Token: 0x04038D04 RID: 232708
		[Token(Token = "0x4038D04")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__MilestoneTweenSetter;

		// Token: 0x04038D05 RID: 232709
		[Token(Token = "0x4038D05")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderStageSquadInfo;

		// Token: 0x04038D06 RID: 232710
		[Token(Token = "0x4038D06")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderMilestone;

		// Token: 0x04038D07 RID: 232711
		[Token(Token = "0x4038D07")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderSaveSquadPanel;

		// Token: 0x04038D08 RID: 232712
		[Token(Token = "0x4038D08")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnEnterAnimComplete;

		// Token: 0x04038D09 RID: 232713
		[Token(Token = "0x4038D09")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlayMilestoneTween;

		// Token: 0x04038D0A RID: 232714
		[Token(Token = "0x4038D0A")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__TryPlaySaveSquadPanelAnim;

		// Token: 0x04038D0B RID: 232715
		[Token(Token = "0x4038D0B")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__PlayEnterAnim;

		// Token: 0x04038D0C RID: 232716
		[Token(Token = "0x4038D0C")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ShowStageCompleteToast;

		// Token: 0x04038D0D RID: 232717
		[Token(Token = "0x4038D0D")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__PlayIllustVoice;

		// Token: 0x04038D0E RID: 232718
		[Token(Token = "0x4038D0E")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_EventSaveSquad;

		// Token: 0x04038D0F RID: 232719
		[Token(Token = "0x4038D0F")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_EventCancelSaveSquad;

		// Token: 0x04038D10 RID: 232720
		[Token(Token = "0x4038D10")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventBackToDefensePage;

		// Token: 0x04038D11 RID: 232721
		[Token(Token = "0x4038D11")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
