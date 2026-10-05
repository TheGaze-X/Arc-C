using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E56 RID: 24150
	[Token(Token = "0x2005E56")]
	public class ItemRepoIssueVoucherStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06022FD1 RID: 143313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FD1")]
		[Address(RVA = "0x1D82C50", Offset = "0x1D81850", VA = "0x181D82C50")]
		public ItemRepoIssueVoucherStateBean()
		{
		}

		// Token: 0x04030332 RID: 197426
		[Token(Token = "0x4030332")]
		[FieldOffset(Offset = "0x10")]
		public UIItemViewModel voucherItem;

		// Token: 0x04030333 RID: 197427
		[Token(Token = "0x4030333")]
		[FieldOffset(Offset = "0x18")]
		public ItemRepoIssueVoucherViewProperty viewProperty;

		// Token: 0x04030334 RID: 197428
		[Token(Token = "0x4030334")]
		[FieldOffset(Offset = "0x20")]
		public string cacheFocusId;

		// Token: 0x04030335 RID: 197429
		[Token(Token = "0x4030335")]
		[FieldOffset(Offset = "0x28")]
		public long cacheFocusCount;

		// Token: 0x04030336 RID: 197430
		[Token(Token = "0x4030336")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
