using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x02002912 RID: 10514
	[Token(Token = "0x2002912")]
	public class MTileBlackboardMul : BasicMapRune
	{
		// Token: 0x1700268C RID: 9868
		// (get) Token: 0x06011700 RID: 71424 RVA: 0x0006B448 File Offset: 0x00069648
		[Token(Token = "0x1700268C")]
		public override int priorityQueue
		{
			[Token(Token = "0x6011700")]
			[Address(RVA = "0x943D70", Offset = "0x942970", VA = "0x180943D70", Slot = "6")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06011701 RID: 71425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011701")]
		[Address(RVA = "0x943C20", Offset = "0x942820", VA = "0x180943C20", Slot = "17")]
		protected override void DoPreprocessTile(ref TileData tData, GridPosition pos, Tile tile)
		{
		}

		// Token: 0x06011702 RID: 71426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011702")]
		[Address(RVA = "0x943CD0", Offset = "0x9428D0", VA = "0x180943CD0")]
		public MTileBlackboardMul()
		{
		}

		// Token: 0x06011703 RID: 71427 RVA: 0x0006B460 File Offset: 0x00069660
		[Token(Token = "0x6011703")]
		[Address(RVA = "0x937E80", Offset = "0x936A80", VA = "0x180937E80")]
		private int <>xLuaBaseProxy_get_priorityQueue()
		{
			return 0;
		}

		// Token: 0x040137A5 RID: 79781
		[Token(Token = "0x40137A5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_priorityQueue;

		// Token: 0x040137A6 RID: 79782
		[Token(Token = "0x40137A6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoPreprocessTile;

		// Token: 0x040137A7 RID: 79783
		[Token(Token = "0x40137A7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
