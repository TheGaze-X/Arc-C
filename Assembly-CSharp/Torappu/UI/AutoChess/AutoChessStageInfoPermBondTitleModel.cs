using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020063A6 RID: 25510
	[Token(Token = "0x20063A6")]
	public class AutoChessStageInfoPermBondTitleModel : UISimpleRecycleLayoutItemViewModel
	{
		// Token: 0x06024C74 RID: 150644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C74")]
		[Address(RVA = "0x1FA9FB0", Offset = "0x1FA8BB0", VA = "0x181FA9FB0", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x06024C75 RID: 150645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C75")]
		[Address(RVA = "0x1FAA020", Offset = "0x1FA8C20", VA = "0x181FAA020")]
		public AutoChessStageInfoPermBondTitleModel()
		{
		}

		// Token: 0x04033662 RID: 210530
		[Token(Token = "0x4033662")]
		public const string VIEW_TYPE = "PERM_BOND_TITLE";

		// Token: 0x04033663 RID: 210531
		[Token(Token = "0x4033663")]
		[FieldOffset(Offset = "0x10")]
		public bool hasBondBanned;

		// Token: 0x04033664 RID: 210532
		[Token(Token = "0x4033664")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x04033665 RID: 210533
		[Token(Token = "0x4033665")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
