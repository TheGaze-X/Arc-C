using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007126 RID: 28966
	[Token(Token = "0x2007126")]
	public class ActAutoChessHandbookEnemyTitleView : UISimpleRecycleLayoutItemView<ActAutoChessHandbookEnemyTitleModel>, IHotfixable
	{
		// Token: 0x06029237 RID: 168503 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6029237")]
		[Address(RVA = "0x24850A0", Offset = "0x2483CA0", VA = "0x1824850A0", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x06029238 RID: 168504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029238")]
		[Address(RVA = "0x2485110", Offset = "0x2483D10", VA = "0x182485110")]
		public ActAutoChessHandbookEnemyTitleView()
		{
		}

		// Token: 0x0403ABF7 RID: 240631
		[Token(Token = "0x403ABF7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0403ABF8 RID: 240632
		[Token(Token = "0x403ABF8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
