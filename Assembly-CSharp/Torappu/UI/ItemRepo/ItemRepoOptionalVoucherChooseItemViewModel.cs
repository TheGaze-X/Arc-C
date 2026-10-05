using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E7E RID: 24190
	[Token(Token = "0x2005E7E")]
	public class ItemRepoOptionalVoucherChooseItemViewModel : IHotfixable
	{
		// Token: 0x060230E8 RID: 143592 RVA: 0x000BFCB8 File Offset: 0x000BDEB8
		[Token(Token = "0x60230E8")]
		[Address(RVA = "0x1D9ACB0", Offset = "0x1D998B0", VA = "0x181D9ACB0")]
		public bool CheckIfCanAdd()
		{
			return default(bool);
		}

		// Token: 0x060230E9 RID: 143593 RVA: 0x000BFCD0 File Offset: 0x000BDED0
		[Token(Token = "0x60230E9")]
		[Address(RVA = "0x1D9AD30", Offset = "0x1D99930", VA = "0x181D9AD30")]
		public int GetTotalPickCount()
		{
			return 0;
		}

		// Token: 0x060230EA RID: 143594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60230EA")]
		[Address(RVA = "0x1D9AD90", Offset = "0x1D99990", VA = "0x181D9AD90")]
		public ItemRepoOptionalVoucherChooseItemViewModel()
		{
		}

		// Token: 0x04030471 RID: 197745
		[Token(Token = "0x4030471")]
		[FieldOffset(Offset = "0x10")]
		public UIItemViewModel itemViewModel;

		// Token: 0x04030472 RID: 197746
		[Token(Token = "0x4030472")]
		[FieldOffset(Offset = "0x18")]
		public int curPickNum;

		// Token: 0x04030473 RID: 197747
		[Token(Token = "0x4030473")]
		[FieldOffset(Offset = "0x1C")]
		public int perPickCount;

		// Token: 0x04030474 RID: 197748
		[Token(Token = "0x4030474")]
		[FieldOffset(Offset = "0x20")]
		public OptionalVoucherExtraData extraData;

		// Token: 0x04030475 RID: 197749
		[Token(Token = "0x4030475")]
		[FieldOffset(Offset = "0x28")]
		public bool isFocus;

		// Token: 0x04030476 RID: 197750
		[Token(Token = "0x4030476")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckIfCanAdd;

		// Token: 0x04030477 RID: 197751
		[Token(Token = "0x4030477")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetTotalPickCount;

		// Token: 0x04030478 RID: 197752
		[Token(Token = "0x4030478")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
