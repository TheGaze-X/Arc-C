using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007102 RID: 28930
	[Token(Token = "0x2007102")]
	public class ActAutoChessHandbookBondGroupModel : ActAutoChessHandbookGroupModelBase<ActAutoChessHandbookBondViewModel>
	{
		// Token: 0x060291D6 RID: 168406 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60291D6")]
		[Address(RVA = "0x2483290", Offset = "0x2481E90", VA = "0x182483290", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x060291D7 RID: 168407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291D7")]
		[Address(RVA = "0x2483300", Offset = "0x2481F00", VA = "0x182483300")]
		public ActAutoChessHandbookBondGroupModel()
		{
		}

		// Token: 0x0403AB1F RID: 240415
		[Token(Token = "0x403AB1F")]
		public const int ITEM_COUNT_PER_ROW = 5;

		// Token: 0x0403AB20 RID: 240416
		[Token(Token = "0x403AB20")]
		public const string VIEW_TYPE = "BOND";

		// Token: 0x0403AB21 RID: 240417
		[Token(Token = "0x403AB21")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0403AB22 RID: 240418
		[Token(Token = "0x403AB22")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
