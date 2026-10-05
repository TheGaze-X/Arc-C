using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x02002913 RID: 10515
	[Token(Token = "0x2002913")]
	public class MTileBlackboardAdd : BasicMapRune
	{
		// Token: 0x06011704 RID: 71428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011704")]
		[Address(RVA = "0x943940", Offset = "0x942540", VA = "0x180943940", Slot = "17")]
		protected override void DoPreprocessTile(ref TileData tData, GridPosition pos, Tile tile)
		{
		}

		// Token: 0x06011705 RID: 71429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011705")]
		[Address(RVA = "0x9439F0", Offset = "0x9425F0", VA = "0x1809439F0")]
		public MTileBlackboardAdd()
		{
		}

		// Token: 0x040137A8 RID: 79784
		[Token(Token = "0x40137A8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoPreprocessTile;

		// Token: 0x040137A9 RID: 79785
		[Token(Token = "0x40137A9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
