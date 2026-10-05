using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x02002915 RID: 10517
	[Token(Token = "0x2002915")]
	public abstract class BasicPreprocessRuneDataRune : Rune
	{
		// Token: 0x1700268D RID: 9869
		// (get) Token: 0x06011708 RID: 71432 RVA: 0x0006B478 File Offset: 0x00069678
		[Token(Token = "0x1700268D")]
		public sealed override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x6011708")]
			[Address(RVA = "0x936950", Offset = "0x935550", VA = "0x180936950", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x06011709 RID: 71433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011709")]
		[Address(RVA = "0x936610", Offset = "0x935210", VA = "0x180936610", Slot = "9")]
		public sealed override void PreprocessCharacter(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x0601170A RID: 71434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601170A")]
		[Address(RVA = "0x9366F0", Offset = "0x9352F0", VA = "0x1809366F0", Slot = "10")]
		public sealed override void PreprocessEnemy(LevelData.EnemyData data, Enemy enemy)
		{
		}

		// Token: 0x0601170B RID: 71435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601170B")]
		[Address(RVA = "0x936860", Offset = "0x935460", VA = "0x180936860", Slot = "11")]
		public sealed override void PreprocessTile(ref TileData tileData, GridPosition pos, Tile tile)
		{
		}

		// Token: 0x0601170C RID: 71436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601170C")]
		[Address(RVA = "0x936800", Offset = "0x935400", VA = "0x180936800", Slot = "7")]
		public sealed override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x0601170D RID: 71437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601170D")]
		[Address(RVA = "0x936770", Offset = "0x935370", VA = "0x180936770", Slot = "8")]
		public sealed override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x0601170E RID: 71438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601170E")]
		[Address(RVA = "0x936690", Offset = "0x935290", VA = "0x180936690", Slot = "12")]
		public sealed override void PreprocessDeck(IList<Deck.Card> cards)
		{
		}

		// Token: 0x0601170F RID: 71439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601170F")]
		[Address(RVA = "0x9368F0", Offset = "0x9354F0", VA = "0x1809368F0")]
		protected BasicPreprocessRuneDataRune()
		{
		}

		// Token: 0x040137AC RID: 79788
		[Token(Token = "0x40137AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040137AD RID: 79789
		[Token(Token = "0x40137AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PreprocessCharacter;

		// Token: 0x040137AE RID: 79790
		[Token(Token = "0x40137AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessEnemy;

		// Token: 0x040137AF RID: 79791
		[Token(Token = "0x40137AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessTile;

		// Token: 0x040137B0 RID: 79792
		[Token(Token = "0x40137B0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;

		// Token: 0x040137B1 RID: 79793
		[Token(Token = "0x40137B1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x040137B2 RID: 79794
		[Token(Token = "0x40137B2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PreprocessDeck;

		// Token: 0x040137B3 RID: 79795
		[Token(Token = "0x40137B3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
