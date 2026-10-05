using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020023A5 RID: 9125
	[Token(Token = "0x20023A5")]
	public interface ITileBuildableChecker
	{
		// Token: 0x0600E77F RID: 59263 RVA: 0x00054588 File Offset: 0x00052788
		[Token(Token = "0x600E77F")]
		[Address(RVA = "0x5D2CF0", Offset = "0x5D18F0", VA = "0x1805D2CF0", Slot = "0")]
		bool IsCharacterBuildableOnTile(Tile tile, BattleCharacterData sourceData)
		{
			return default(bool);
		}

		// Token: 0x0600E780 RID: 59264 RVA: 0x000545A0 File Offset: 0x000527A0
		[Token(Token = "0x600E780")]
		[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "1")]
		bool IsTileBuildable(Tile tile)
		{
			return default(bool);
		}
	}
}
