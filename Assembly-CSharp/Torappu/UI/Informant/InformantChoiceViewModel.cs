using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A2F RID: 18991
	[Token(Token = "0x2004A2F")]
	public class InformantChoiceViewModel : IHotfixable
	{
		// Token: 0x0601C903 RID: 116995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C903")]
		[Address(RVA = "0x1614B60", Offset = "0x1613760", VA = "0x181614B60")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0601C904 RID: 116996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C904")]
		[Address(RVA = "0x1614EA0", Offset = "0x1613AA0", VA = "0x181614EA0")]
		public InformantChoiceViewModel()
		{
		}

		// Token: 0x0402578D RID: 153485
		[Token(Token = "0x402578D")]
		[FieldOffset(Offset = "0x10")]
		public string customerId;

		// Token: 0x0402578E RID: 153486
		[Token(Token = "0x402578E")]
		[FieldOffset(Offset = "0x18")]
		public bool isSpCustomer;

		// Token: 0x0402578F RID: 153487
		[Token(Token = "0x402578F")]
		[FieldOffset(Offset = "0x20")]
		public string tagId;

		// Token: 0x04025790 RID: 153488
		[Token(Token = "0x4025790")]
		[FieldOffset(Offset = "0x28")]
		public string customerName;

		// Token: 0x04025791 RID: 153489
		[Token(Token = "0x4025791")]
		[FieldOffset(Offset = "0x30")]
		public string tagName;

		// Token: 0x04025792 RID: 153490
		[Token(Token = "0x4025792")]
		[FieldOffset(Offset = "0x38")]
		public string customerDesc;

		// Token: 0x04025793 RID: 153491
		[Token(Token = "0x4025793")]
		[FieldOffset(Offset = "0x40")]
		public string tagDesc;

		// Token: 0x04025794 RID: 153492
		[Token(Token = "0x4025794")]
		[FieldOffset(Offset = "0x48")]
		public string customerIllustId;

		// Token: 0x04025795 RID: 153493
		[Token(Token = "0x4025795")]
		[FieldOffset(Offset = "0x50")]
		public string customerDialogText;

		// Token: 0x04025796 RID: 153494
		[Token(Token = "0x4025796")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04025797 RID: 153495
		[Token(Token = "0x4025797")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
