using System;
using Il2CppDummyDll;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E79 RID: 24185
	[Token(Token = "0x2005E79")]
	public class ItemRepoIssueVoucherItemViewModel
	{
		// Token: 0x060230CC RID: 143564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230CC")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ItemRepoIssueVoucherItemViewModel()
		{
		}

		// Token: 0x0403043E RID: 197694
		[Token(Token = "0x403043E")]
		[FieldOffset(Offset = "0x10")]
		public ItemBundle itemBundle;

		// Token: 0x0403043F RID: 197695
		[Token(Token = "0x403043F")]
		[FieldOffset(Offset = "0x18")]
		public UIItemViewModel itemModel;

		// Token: 0x04030440 RID: 197696
		[Token(Token = "0x4030440")]
		[FieldOffset(Offset = "0x20")]
		public int selectLimit;

		// Token: 0x04030441 RID: 197697
		[Token(Token = "0x4030441")]
		[FieldOffset(Offset = "0x24")]
		public int selectedCount;

		// Token: 0x04030442 RID: 197698
		[Token(Token = "0x4030442")]
		[FieldOffset(Offset = "0x28")]
		public int possessCount;

		// Token: 0x04030443 RID: 197699
		[Token(Token = "0x4030443")]
		[FieldOffset(Offset = "0x2C")]
		public int outputCount;

		// Token: 0x04030444 RID: 197700
		[Token(Token = "0x4030444")]
		[FieldOffset(Offset = "0x30")]
		public bool isFocus;
	}
}
