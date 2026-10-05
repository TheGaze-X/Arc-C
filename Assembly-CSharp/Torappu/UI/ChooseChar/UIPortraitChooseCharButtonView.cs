using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.ChooseChar
{
	// Token: 0x02005A26 RID: 23078
	[Token(Token = "0x2005A26")]
	public class UIPortraitChooseCharButtonView : DataBinder<UIPortraitChooseCharProperty>, IHotfixable
	{
		// Token: 0x060219C2 RID: 137666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219C2")]
		[Address(RVA = "0x1C14510", Offset = "0x1C13110", VA = "0x181C14510", Slot = "7")]
		public override void OnValueChanged(UIPortraitChooseCharProperty property)
		{
		}

		// Token: 0x060219C3 RID: 137667 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219C3")]
		[Address(RVA = "0x1C14370", Offset = "0x1C12F70", VA = "0x181C14370")]
		public void EventOnCancelBtnClicked()
		{
		}

		// Token: 0x060219C4 RID: 137668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219C4")]
		[Address(RVA = "0x1C14490", Offset = "0x1C13090", VA = "0x181C14490")]
		public void EventOnConfirmBtnClicked()
		{
		}

		// Token: 0x060219C5 RID: 137669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219C5")]
		[Address(RVA = "0x1C14400", Offset = "0x1C13000", VA = "0x181C14400")]
		public void EventOnClearBtnClicked()
		{
		}

		// Token: 0x060219C6 RID: 137670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60219C6")]
		[Address(RVA = "0x1C14620", Offset = "0x1C13220", VA = "0x181C14620")]
		public UIPortraitChooseCharButtonView()
		{
		}

		// Token: 0x0402DF2A RID: 188202
		[Token(Token = "0x402DF2A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateFadeSwitcher _confirmBtnSwitcher;

		// Token: 0x0402DF2B RID: 188203
		[Token(Token = "0x402DF2B")]
		[FieldOffset(Offset = "0x28")]
		private int m_cachedSequence;

		// Token: 0x0402DF2C RID: 188204
		[Token(Token = "0x402DF2C")]
		[FieldOffset(Offset = "0x30")]
		private UICompDialogFinder m_dialogFinder;

		// Token: 0x0402DF2D RID: 188205
		[Token(Token = "0x402DF2D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0402DF2E RID: 188206
		[Token(Token = "0x402DF2E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnCancelBtnClicked;

		// Token: 0x0402DF2F RID: 188207
		[Token(Token = "0x402DF2F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnConfirmBtnClicked;

		// Token: 0x0402DF30 RID: 188208
		[Token(Token = "0x402DF30")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnClearBtnClicked;

		// Token: 0x0402DF31 RID: 188209
		[Token(Token = "0x402DF31")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
