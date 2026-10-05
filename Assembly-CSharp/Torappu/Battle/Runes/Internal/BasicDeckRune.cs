using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x02002919 RID: 10521
	[Token(Token = "0x2002919")]
	public abstract class BasicDeckRune : Rune
	{
		// Token: 0x17002690 RID: 9872
		// (get) Token: 0x0601171D RID: 71453 RVA: 0x0006B4F0 File Offset: 0x000696F0
		[Token(Token = "0x17002690")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x601171D")]
			[Address(RVA = "0x9355F0", Offset = "0x9341F0", VA = "0x1809355F0", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x0601171E RID: 71454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601171E")]
		[Address(RVA = "0x935200", Offset = "0x933E00", VA = "0x180935200", Slot = "9")]
		public sealed override void PreprocessCharacter(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x0601171F RID: 71455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601171F")]
		[Address(RVA = "0x9352E0", Offset = "0x933EE0", VA = "0x1809352E0", Slot = "10")]
		public sealed override void PreprocessEnemy(LevelData.EnemyData data, Enemy enemy)
		{
		}

		// Token: 0x06011720 RID: 71456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011720")]
		[Address(RVA = "0x935450", Offset = "0x934050", VA = "0x180935450", Slot = "11")]
		public sealed override void PreprocessTile(ref TileData tileData, GridPosition pos, Tile tile)
		{
		}

		// Token: 0x06011721 RID: 71457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011721")]
		[Address(RVA = "0x935280", Offset = "0x933E80", VA = "0x180935280", Slot = "12")]
		public sealed override void PreprocessDeck(IList<Deck.Card> cards)
		{
		}

		// Token: 0x06011722 RID: 71458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011722")]
		[Address(RVA = "0x9353F0", Offset = "0x933FF0", VA = "0x1809353F0", Slot = "7")]
		public sealed override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x06011723 RID: 71459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011723")]
		[Address(RVA = "0x935360", Offset = "0x933F60", VA = "0x180935360", Slot = "8")]
		public sealed override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x06011724 RID: 71460 RVA: 0x0006B508 File Offset: 0x00069708
		[Token(Token = "0x6011724")]
		[Address(RVA = "0x9354E0", Offset = "0x9340E0", VA = "0x1809354E0")]
		public bool VerifyDeckPlayerSide(Deck deck)
		{
			return default(bool);
		}

		// Token: 0x06011725 RID: 71461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011725")]
		[Address(RVA = "0x935590", Offset = "0x934190", VA = "0x180935590")]
		protected BasicDeckRune()
		{
		}

		// Token: 0x040137BC RID: 79804
		[Token(Token = "0x40137BC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x040137BD RID: 79805
		[Token(Token = "0x40137BD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PreprocessCharacter;

		// Token: 0x040137BE RID: 79806
		[Token(Token = "0x40137BE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessEnemy;

		// Token: 0x040137BF RID: 79807
		[Token(Token = "0x40137BF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessTile;

		// Token: 0x040137C0 RID: 79808
		[Token(Token = "0x40137C0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PreprocessDeck;

		// Token: 0x040137C1 RID: 79809
		[Token(Token = "0x40137C1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;

		// Token: 0x040137C2 RID: 79810
		[Token(Token = "0x40137C2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x040137C3 RID: 79811
		[Token(Token = "0x40137C3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_VerifyDeckPlayerSide;

		// Token: 0x040137C4 RID: 79812
		[Token(Token = "0x40137C4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
