using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007106 RID: 28934
	[Token(Token = "0x2007106")]
	public class ActAutoChessHandbookEnemyGroupModel : ActAutoChessHandbookGroupModelBase<ActAutoChessHandbookEnemyViewModel>
	{
		// Token: 0x060291DE RID: 168414 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60291DE")]
		[Address(RVA = "0x2484CE0", Offset = "0x24838E0", VA = "0x182484CE0", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x060291DF RID: 168415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291DF")]
		[Address(RVA = "0x2484D50", Offset = "0x2483950", VA = "0x182484D50")]
		public ActAutoChessHandbookEnemyGroupModel()
		{
		}

		// Token: 0x0403AB2D RID: 240429
		[Token(Token = "0x403AB2D")]
		public const int ITEM_COUNT_PER_ROW = 5;

		// Token: 0x0403AB2E RID: 240430
		[Token(Token = "0x403AB2E")]
		public const string VIEW_TYPE = "ENEMY";

		// Token: 0x0403AB2F RID: 240431
		[Token(Token = "0x403AB2F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0403AB30 RID: 240432
		[Token(Token = "0x403AB30")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
