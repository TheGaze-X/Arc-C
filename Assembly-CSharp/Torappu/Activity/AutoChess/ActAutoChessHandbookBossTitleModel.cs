using System;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Activity.AutoChess
{
	// Token: 0x02007104 RID: 28932
	[Token(Token = "0x2007104")]
	public class ActAutoChessHandbookBossTitleModel : UISimpleRecycleLayoutItemViewModel
	{
		// Token: 0x060291DA RID: 168410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60291DA")]
		[Address(RVA = "0x2483D50", Offset = "0x2482950", VA = "0x182483D50", Slot = "4")]
		public override string GetViewType()
		{
			return null;
		}

		// Token: 0x060291DB RID: 168411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60291DB")]
		[Address(RVA = "0x2483DC0", Offset = "0x24829C0", VA = "0x182483DC0")]
		public ActAutoChessHandbookBossTitleModel()
		{
		}

		// Token: 0x0403AB27 RID: 240423
		[Token(Token = "0x403AB27")]
		public const string VIEW_TYPE = "ENEMY_BOSS_TITLE";

		// Token: 0x0403AB28 RID: 240424
		[Token(Token = "0x403AB28")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0403AB29 RID: 240425
		[Token(Token = "0x403AB29")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
