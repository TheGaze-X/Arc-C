using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x020049F3 RID: 18931
	[Token(Token = "0x20049F3")]
	public class InformantChoiceEndDialog : UICompDialog<InformantChoiceEndDialogInput>, IValueMsgReceiver
	{
		// Token: 0x0601C805 RID: 116741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C805")]
		[Address(RVA = "0x15F3370", Offset = "0x15F1F70", VA = "0x1815F3370", Slot = "9")]
		protected override void OnInit()
		{
		}

		// Token: 0x0601C806 RID: 116742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C806")]
		[Address(RVA = "0x15F34A0", Offset = "0x15F20A0", VA = "0x1815F34A0", Slot = "18")]
		protected override void OnRender(InformantChoiceEndDialogInput input)
		{
		}

		// Token: 0x0601C807 RID: 116743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C807")]
		[Address(RVA = "0x15F33F0", Offset = "0x15F1FF0", VA = "0x1815F33F0", Slot = "19")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601C808 RID: 116744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C808")]
		[Address(RVA = "0x15F3860", Offset = "0x15F2460", VA = "0x1815F3860")]
		private void _EventOnSettle()
		{
		}

		// Token: 0x0601C809 RID: 116745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C809")]
		[Address(RVA = "0x15F3AC0", Offset = "0x15F26C0", VA = "0x1815F3AC0")]
		private void _NextState(InformantNextStateResponse resp)
		{
		}

		// Token: 0x0601C80A RID: 116746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C80A")]
		[Address(RVA = "0x15F3C60", Offset = "0x15F2860", VA = "0x1815F3C60")]
		private void _TryTriggerTutorial()
		{
		}

		// Token: 0x0601C80B RID: 116747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C80B")]
		[Address(RVA = "0x15F3D90", Offset = "0x15F2990", VA = "0x1815F3D90")]
		private void _TutorialOnly_EntryAnimRouted()
		{
		}

		// Token: 0x0601C80C RID: 116748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C80C")]
		[Address(RVA = "0x15F3E20", Offset = "0x15F2A20", VA = "0x1815F3E20")]
		public InformantChoiceEndDialog()
		{
		}

		// Token: 0x0601C80E RID: 116750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C80E")]
		[Address(RVA = "0xE613C0", Offset = "0xE5FFC0", VA = "0x180E613C0")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0402556C RID: 152940
		[Token(Token = "0x402556C")]
		[NonSerialized]
		public const int EVENT_ON_SETTLE = 0;

		// Token: 0x0402556D RID: 152941
		[Token(Token = "0x402556D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private InformantChoiceEndView _view;

		// Token: 0x0402556E RID: 152942
		[Token(Token = "0x402556E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _enterAnim;

		// Token: 0x0402556F RID: 152943
		[Token(Token = "0x402556F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private UIAnimationLocation _enterAnimSimple;

		// Token: 0x04025570 RID: 152944
		[Token(Token = "0x4025570")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private UIAnimationLocation _quitAnim;

		// Token: 0x04025571 RID: 152945
		[Token(Token = "0x4025571")]
		[FieldOffset(Offset = "0xA8")]
		private InformantChoiceEndViewModel m_viewModel;

		// Token: 0x04025572 RID: 152946
		[Token(Token = "0x4025572")]
		[FieldOffset(Offset = "0xB0")]
		private string m_actId;

		// Token: 0x04025573 RID: 152947
		[Token(Token = "0x4025573")]
		[FieldOffset(Offset = "0xB8")]
		private Tween m_enterAnimTween;

		// Token: 0x04025574 RID: 152948
		[Token(Token = "0x4025574")]
		[FieldOffset(Offset = "0xC0")]
		private Tween m_quitAnimTween;

		// Token: 0x04025575 RID: 152949
		[Token(Token = "0x4025575")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04025576 RID: 152950
		[Token(Token = "0x4025576")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x04025577 RID: 152951
		[Token(Token = "0x4025577")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04025578 RID: 152952
		[Token(Token = "0x4025578")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnSettle;

		// Token: 0x04025579 RID: 152953
		[Token(Token = "0x4025579")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__NextState;

		// Token: 0x0402557A RID: 152954
		[Token(Token = "0x402557A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TryTriggerTutorial;

		// Token: 0x0402557B RID: 152955
		[Token(Token = "0x402557B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TutorialOnly_EntryAnimRouted;

		// Token: 0x0402557C RID: 152956
		[Token(Token = "0x402557C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
