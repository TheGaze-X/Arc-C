using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020063A5 RID: 25509
	[Token(Token = "0x20063A5")]
	public class AutoChessStageInfoTempBondTitleModel : UISimpleRecycleLayoutItemViewModel
	{
		// Token: 0x06024C72 RID: 150642 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C72")]
		[Address(RVA = "0x1FAB580", Offset = "0x1FAA180", VA = "0x181FAB580", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x06024C73 RID: 150643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C73")]
		[Address(RVA = "0x1FAB5F0", Offset = "0x1FAA1F0", VA = "0x181FAB5F0")]
		public AutoChessStageInfoTempBondTitleModel()
		{
		}

		// Token: 0x0403365E RID: 210526
		[Token(Token = "0x403365E")]
		public const string VIEW_TYPE = "TEMP_BOND_TITLE";

		// Token: 0x0403365F RID: 210527
		[Token(Token = "0x403365F")]
		[FieldOffset(Offset = "0x10")]
		public bool hasBondBanned;

		// Token: 0x04033660 RID: 210528
		[Token(Token = "0x4033660")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x04033661 RID: 210529
		[Token(Token = "0x4033661")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
