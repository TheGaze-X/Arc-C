using System;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.TemplateCharSelect;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1VHalfIdle
{
	// Token: 0x02007703 RID: 30467
	[Token(Token = "0x2007703")]
	public class Act1VHalfIdleCharSelectEnsureView : TemplateCharSelectEnsureView
	{
		// Token: 0x0602ACE0 RID: 175328 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACE0")]
		[Address(RVA = "0x2699180", Offset = "0x2697D80", VA = "0x182699180")]
		public void EventOnClear()
		{
		}

		// Token: 0x0602ACE1 RID: 175329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACE1")]
		[Address(RVA = "0x2699210", Offset = "0x2697E10", VA = "0x182699210")]
		public void EventOnConfirm()
		{
		}

		// Token: 0x0602ACE2 RID: 175330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACE2")]
		[Address(RVA = "0x26992A0", Offset = "0x2697EA0", VA = "0x1826992A0", Slot = "10")]
		protected override void OnRenderViewModel(TemplateCharSelectMainViewModel templateModel)
		{
		}

		// Token: 0x0602ACE3 RID: 175331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACE3")]
		[Address(RVA = "0x2699430", Offset = "0x2698030", VA = "0x182699430")]
		private void _UpdateConfirmBtn(TemplateCharSelectMainViewModel templateModel)
		{
		}

		// Token: 0x0602ACE4 RID: 175332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACE4")]
		[Address(RVA = "0x2699540", Offset = "0x2698140", VA = "0x182699540")]
		public Act1VHalfIdleCharSelectEnsureView()
		{
		}

		// Token: 0x0602ACE5 RID: 175333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602ACE5")]
		[Address(RVA = "0x1CACD40", Offset = "0x1CAB940", VA = "0x181CACD40")]
		private void <>xLuaBaseProxy_OnRenderViewModel(TemplateCharSelectMainViewModel P0)
		{
		}

		// Token: 0x0403DAF7 RID: 252663
		[Token(Token = "0x403DAF7")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _clearBtn;

		// Token: 0x0403DAF8 RID: 252664
		[Token(Token = "0x403DAF8")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private TwoStateToggle _confirmBtnState;

		// Token: 0x0403DAF9 RID: 252665
		[Token(Token = "0x403DAF9")]
		[FieldOffset(Offset = "0x40")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0403DAFA RID: 252666
		[Token(Token = "0x403DAFA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_EventOnClear;

		// Token: 0x0403DAFB RID: 252667
		[Token(Token = "0x403DAFB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnConfirm;

		// Token: 0x0403DAFC RID: 252668
		[Token(Token = "0x403DAFC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRenderViewModel;

		// Token: 0x0403DAFD RID: 252669
		[Token(Token = "0x403DAFD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateConfirmBtn;

		// Token: 0x0403DAFE RID: 252670
		[Token(Token = "0x403DAFE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
