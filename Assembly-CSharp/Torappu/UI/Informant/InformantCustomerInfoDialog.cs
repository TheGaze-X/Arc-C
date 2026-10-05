using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x020049FC RID: 18940
	[Token(Token = "0x20049FC")]
	public class InformantCustomerInfoDialog : UICompDialog<InformantDialogCommonInput>, IHotfixable
	{
		// Token: 0x0601C828 RID: 116776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C828")]
		[Address(RVA = "0x15F5850", Offset = "0x15F4450", VA = "0x1815F5850", Slot = "18")]
		protected override void OnRender(InformantDialogCommonInput input)
		{
		}

		// Token: 0x0601C829 RID: 116777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C829")]
		[Address(RVA = "0x15F5780", Offset = "0x15F4380", VA = "0x1815F5780")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x0601C82A RID: 116778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C82A")]
		[Address(RVA = "0x15F58F0", Offset = "0x15F44F0", VA = "0x1815F58F0")]
		public InformantCustomerInfoDialog()
		{
		}

		// Token: 0x040255B8 RID: 153016
		[Token(Token = "0x40255B8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private InformantCustomerInfoView _customerInfo;

		// Token: 0x040255B9 RID: 153017
		[Token(Token = "0x40255B9")]
		[FieldOffset(Offset = "0x78")]
		private InformantCustomerInfoViewModel m_viewModel;

		// Token: 0x040255BA RID: 153018
		[Token(Token = "0x40255BA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnRender;

		// Token: 0x040255BB RID: 153019
		[Token(Token = "0x40255BB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x040255BC RID: 153020
		[Token(Token = "0x40255BC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
