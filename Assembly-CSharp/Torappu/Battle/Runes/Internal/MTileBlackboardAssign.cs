using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x02002914 RID: 10516
	[Token(Token = "0x2002914")]
	public class MTileBlackboardAssign : BasicMapRune
	{
		// Token: 0x06011706 RID: 71430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011706")]
		[Address(RVA = "0x943A90", Offset = "0x942690", VA = "0x180943A90", Slot = "17")]
		protected override void DoPreprocessTile(ref TileData tData, GridPosition pos, Tile tile)
		{
		}

		// Token: 0x06011707 RID: 71431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011707")]
		[Address(RVA = "0x943B80", Offset = "0x942780", VA = "0x180943B80")]
		public MTileBlackboardAssign()
		{
		}

		// Token: 0x040137AA RID: 79786
		[Token(Token = "0x40137AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessTile;

		// Token: 0x040137AB RID: 79787
		[Token(Token = "0x40137AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
