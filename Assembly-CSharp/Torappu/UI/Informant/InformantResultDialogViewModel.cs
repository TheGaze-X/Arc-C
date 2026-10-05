using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Informant
{
	// Token: 0x02004A28 RID: 18984
	[Token(Token = "0x2004A28")]
	public class InformantResultDialogViewModel : IHotfixable
	{
		// Token: 0x0601C8E3 RID: 116963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8E3")]
		[Address(RVA = "0x1615070", Offset = "0x1613C70", VA = "0x181615070")]
		public void LoadData(string actId)
		{
		}

		// Token: 0x0601C8E4 RID: 116964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C8E4")]
		[Address(RVA = "0x16154E0", Offset = "0x16140E0", VA = "0x1816154E0")]
		public InformantResultDialogViewModel()
		{
		}

		// Token: 0x0402573F RID: 153407
		[Token(Token = "0x402573F")]
		[FieldOffset(Offset = "0x10")]
		public string actId;

		// Token: 0x04025740 RID: 153408
		[Token(Token = "0x4025740")]
		[FieldOffset(Offset = "0x18")]
		public int day;

		// Token: 0x04025741 RID: 153409
		[Token(Token = "0x4025741")]
		[FieldOffset(Offset = "0x1C")]
		public int curDayGetCount;

		// Token: 0x04025742 RID: 153410
		[Token(Token = "0x4025742")]
		[FieldOffset(Offset = "0x20")]
		public int totalGetCount;

		// Token: 0x04025743 RID: 153411
		[Token(Token = "0x4025743")]
		[FieldOffset(Offset = "0x28")]
		public List<InformantResultCustomerItemViewModel> customerItems;

		// Token: 0x04025744 RID: 153412
		[Token(Token = "0x4025744")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04025745 RID: 153413
		[Token(Token = "0x4025745")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
