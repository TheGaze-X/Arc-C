using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.AutoChess
{
	// Token: 0x020063A9 RID: 25513
	[Token(Token = "0x20063A9")]
	public class AutoChessStageInfoChessTitleModel : UISimpleRecycleLayoutItemViewModel
	{
		// Token: 0x06024C7A RID: 150650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6024C7A")]
		[Address(RVA = "0x1FA6A80", Offset = "0x1FA5680", VA = "0x181FA6A80", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x06024C7B RID: 150651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024C7B")]
		[Address(RVA = "0x1FA6AF0", Offset = "0x1FA56F0", VA = "0x181FA6AF0")]
		public AutoChessStageInfoChessTitleModel()
		{
		}

		// Token: 0x04033671 RID: 210545
		[Token(Token = "0x4033671")]
		public const string VIEW_TYPE = "CHESS_TITLE";

		// Token: 0x04033672 RID: 210546
		[Token(Token = "0x4033672")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x04033673 RID: 210547
		[Token(Token = "0x4033673")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
