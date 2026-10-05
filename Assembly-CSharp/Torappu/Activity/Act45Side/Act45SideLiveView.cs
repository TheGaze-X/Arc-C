using System;
using System.Runtime.InteropServices;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.Act45Side
{
	// Token: 0x020072C3 RID: 29379
	[Token(Token = "0x20072C3")]
	public class Act45SideLiveView : DataBinder<Act45SideLiveProperty>
	{
		// Token: 0x0602995A RID: 170330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602995A")]
		[Address(RVA = "0x24F8110", Offset = "0x24F6D10", VA = "0x1824F8110", Slot = "7")]
		public override void OnValueChanged(Act45SideLiveProperty property)
		{
		}

		// Token: 0x0602995B RID: 170331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602995B")]
		[Address(RVA = "0x24F8DA0", Offset = "0x24F79A0", VA = "0x1824F8DA0")]
		public void PlaySwitchBtnAnim(Act45SideLiveViewModel.StageState state)
		{
		}

		// Token: 0x0602995C RID: 170332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602995C")]
		[Address(RVA = "0x24F8900", Offset = "0x24F7500", VA = "0x1824F8900")]
		public void PlayCurtainInAnim(bool isEnter, [Optional] Action onComplete)
		{
		}

		// Token: 0x0602995D RID: 170333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602995D")]
		[Address(RVA = "0x24F8B90", Offset = "0x24F7790", VA = "0x1824F8B90")]
		public void PlayCurtainOutAnim()
		{
		}

		// Token: 0x0602995E RID: 170334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602995E")]
		[Address(RVA = "0x24F8070", Offset = "0x24F6C70", VA = "0x1824F8070")]
		public void OnBgmReplay()
		{
		}

		// Token: 0x0602995F RID: 170335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602995F")]
		[Address(RVA = "0x24F9140", Offset = "0x24F7D40", VA = "0x1824F9140")]
		private void _PlayCallAnim()
		{
		}

		// Token: 0x06029960 RID: 170336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029960")]
		[Address(RVA = "0x24F9310", Offset = "0x24F7F10", VA = "0x1824F9310")]
		private void _RenderLockPanel(string clickCharId, string currText)
		{
		}

		// Token: 0x06029961 RID: 170337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029961")]
		[Address(RVA = "0x24F9430", Offset = "0x24F8030", VA = "0x1824F9430")]
		private void _ResetCallStatus()
		{
		}

		// Token: 0x06029962 RID: 170338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029962")]
		[Address(RVA = "0x24F8EB0", Offset = "0x24F7AB0", VA = "0x1824F8EB0")]
		private void _InitIfNot(Act45SideLiveViewModel viewModel)
		{
		}

		// Token: 0x06029963 RID: 170339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029963")]
		[Address(RVA = "0x24F94E0", Offset = "0x24F80E0", VA = "0x1824F94E0")]
		public Act45SideLiveView()
		{
		}

		// Token: 0x0403B762 RID: 243554
		[Token(Token = "0x403B762")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Panel")]
		private GameObject _panelStage;

		// Token: 0x0403B763 RID: 243555
		[Token(Token = "0x403B763")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Panel")]
		private Act45SideStageBaseView _panelLive;

		// Token: 0x0403B764 RID: 243556
		[Token(Token = "0x403B764")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Panel")]
		private Act45SideStageBaseView _panelRehearse;

		// Token: 0x0403B765 RID: 243557
		[Token(Token = "0x403B765")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Panel")]
		private Act45SideStageBaseView _panelSleep;

		// Token: 0x0403B766 RID: 243558
		[Token(Token = "0x403B766")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Btn")]
		private Text _mailTimeText;

		// Token: 0x0403B767 RID: 243559
		[Token(Token = "0x403B767")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Btn")]
		private RectTransform _timeTextLayout;

		// Token: 0x0403B768 RID: 243560
		[Token(Token = "0x403B768")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Btn")]
		private TwoStateToggle _mailBtnToggle;

		// Token: 0x0403B769 RID: 243561
		[Token(Token = "0x403B769")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Btn")]
		private TwoStateToggle _switchBtnBgToggle;

		// Token: 0x0403B76A RID: 243562
		[Token(Token = "0x403B76A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Btn")]
		private GameObject _panelCall;

		// Token: 0x0403B76B RID: 243563
		[Token(Token = "0x403B76B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Btn")]
		private GameObject _btnCall;

		// Token: 0x0403B76C RID: 243564
		[Token(Token = "0x403B76C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Lock Note")]
		private Text _noteText;

		// Token: 0x0403B76D RID: 243565
		[Token(Token = "0x403B76D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Lock Note")]
		private CanvasGroup _notePanel;

		// Token: 0x0403B76E RID: 243566
		[Token(Token = "0x403B76E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0403B76F RID: 243567
		[Token(Token = "0x403B76F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _outAnim;

		// Token: 0x0403B770 RID: 243568
		[Token(Token = "0x403B770")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Anim")]
		private UISpineLocation _enterSpine;

		// Token: 0x0403B771 RID: 243569
		[Token(Token = "0x403B771")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Anim")]
		private UISpineLocation _outSpine;

		// Token: 0x0403B772 RID: 243570
		[Token(Token = "0x403B772")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _switchBtnAnim;

		// Token: 0x0403B773 RID: 243571
		[Token(Token = "0x403B773")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xD0")]
		[SerializeField]
		[Group("Anim")]
		private UIAnimationLocation _callAnim;

		// Token: 0x0403B774 RID: 243572
		[Token(Token = "0x403B774")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE0")]
		private bool m_isInited;

		// Token: 0x0403B775 RID: 243573
		[Token(Token = "0x403B775")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xE8")]
		private string m_cachedLockPanelId;

		// Token: 0x0403B776 RID: 243574
		[Token(Token = "0x403B776")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF0")]
		private bool m_cachedIsCalling;

		// Token: 0x0403B777 RID: 243575
		[Token(Token = "0x403B777")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF4")]
		private Act45SideLiveViewModel.StageState m_cachedState;

		// Token: 0x0403B778 RID: 243576
		[Token(Token = "0x403B778")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xF8")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403B779 RID: 243577
		[Token(Token = "0x403B779")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x108")]
		private Tween m_enterTween;

		// Token: 0x0403B77A RID: 243578
		[Token(Token = "0x403B77A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x110")]
		private Tween m_outTween;

		// Token: 0x0403B77B RID: 243579
		[Token(Token = "0x403B77B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x118")]
		private Tween m_callTween;

		// Token: 0x0403B77C RID: 243580
		[Token(Token = "0x403B77C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x120")]
		private FadeSwitchTween m_lockPanelTween;

		// Token: 0x0403B77D RID: 243581
		[Token(Token = "0x403B77D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x128")]
		private AnimationSwitchTween m_switchBtnTween;

		// Token: 0x0403B77E RID: 243582
		[Token(Token = "0x403B77E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403B77F RID: 243583
		[Token(Token = "0x403B77F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PlaySwitchBtnAnim;

		// Token: 0x0403B780 RID: 243584
		[Token(Token = "0x403B780")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PlayCurtainInAnim;

		// Token: 0x0403B781 RID: 243585
		[Token(Token = "0x403B781")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PlayCurtainOutAnim;

		// Token: 0x0403B782 RID: 243586
		[Token(Token = "0x403B782")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnBgmReplay;

		// Token: 0x0403B783 RID: 243587
		[Token(Token = "0x403B783")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__PlayCallAnim;

		// Token: 0x0403B784 RID: 243588
		[Token(Token = "0x403B784")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RenderLockPanel;

		// Token: 0x0403B785 RID: 243589
		[Token(Token = "0x403B785")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ResetCallStatus;

		// Token: 0x0403B786 RID: 243590
		[Token(Token = "0x403B786")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403B787 RID: 243591
		[Token(Token = "0x403B787")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
