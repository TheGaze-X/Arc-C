using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007103 RID: 28931
	[Token(Token = "0x2007103")]
	public class ActAutoChessHandbookBandGroupModel : ActAutoChessHandbookGroupModelBase<ActAutoChessHandbookBandViewModel>
	{
		// Token: 0x060291D8 RID: 168408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60291D8")]
		[Address(RVA = "0x24824D0", Offset = "0x24810D0", VA = "0x1824824D0", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x060291D9 RID: 168409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291D9")]
		[Address(RVA = "0x2482540", Offset = "0x2481140", VA = "0x182482540")]
		public ActAutoChessHandbookBandGroupModel()
		{
		}

		// Token: 0x0403AB23 RID: 240419
		[Token(Token = "0x403AB23")]
		public const int ITEM_COUNT_PER_ROW = 5;

		// Token: 0x0403AB24 RID: 240420
		[Token(Token = "0x403AB24")]
		public const string VIEW_TYPE = "BAND";

		// Token: 0x0403AB25 RID: 240421
		[Token(Token = "0x403AB25")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0403AB26 RID: 240422
		[Token(Token = "0x403AB26")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
