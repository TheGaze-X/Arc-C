using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x0200711C RID: 28956
	[Token(Token = "0x200711C")]
	public class ActAutoChessHandbookTempBondTitleView : UISimpleRecycleLayoutItemView<ActAutoChessHandbookTempBondTitleModel>, IHotfixable
	{
		// Token: 0x0602921F RID: 168479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602921F")]
		[Address(RVA = "0x2487780", Offset = "0x2486380", VA = "0x182487780", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x06029220 RID: 168480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029220")]
		[Address(RVA = "0x24877F0", Offset = "0x24863F0", VA = "0x1824877F0")]
		public ActAutoChessHandbookTempBondTitleView()
		{
		}

		// Token: 0x0403ABCB RID: 240587
		[Token(Token = "0x403ABCB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0403ABCC RID: 240588
		[Token(Token = "0x403ABCC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
