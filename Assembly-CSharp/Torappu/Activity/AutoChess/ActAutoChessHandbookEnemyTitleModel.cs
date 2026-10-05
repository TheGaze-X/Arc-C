using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007105 RID: 28933
	[Token(Token = "0x2007105")]
	public class ActAutoChessHandbookEnemyTitleModel : UISimpleRecycleLayoutItemViewModel
	{
		// Token: 0x060291DC RID: 168412 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60291DC")]
		[Address(RVA = "0x2484FD0", Offset = "0x2483BD0", VA = "0x182484FD0", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x060291DD RID: 168413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291DD")]
		[Address(RVA = "0x2485040", Offset = "0x2483C40", VA = "0x182485040")]
		public ActAutoChessHandbookEnemyTitleModel()
		{
		}

		// Token: 0x0403AB2A RID: 240426
		[Token(Token = "0x403AB2A")]
		public const string VIEW_TYPE = "ENEMY_TITLE";

		// Token: 0x0403AB2B RID: 240427
		[Token(Token = "0x403AB2B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0403AB2C RID: 240428
		[Token(Token = "0x403AB2C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
