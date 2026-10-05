using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028C8 RID: 10440
	[Token(Token = "0x20028C8")]
	public abstract class BasicLevelRune : Rune
	{
		// Token: 0x060115DF RID: 71135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115DF")]
		[Address(RVA = "0x935D20", Offset = "0x934920", VA = "0x180935D20", Slot = "9")]
		public sealed override void PreprocessCharacter(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x060115E0 RID: 71136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115E0")]
		[Address(RVA = "0x935E00", Offset = "0x934A00", VA = "0x180935E00", Slot = "10")]
		public sealed override void PreprocessEnemy(LevelData.EnemyData data, Enemy enemy)
		{
		}

		// Token: 0x060115E1 RID: 71137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115E1")]
		[Address(RVA = "0x935E80", Offset = "0x934A80", VA = "0x180935E80", Slot = "11")]
		public sealed override void PreprocessTile(ref TileData tileData, GridPosition pos, Tile tile)
		{
		}

		// Token: 0x060115E2 RID: 71138 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115E2")]
		[Address(RVA = "0x935DA0", Offset = "0x9349A0", VA = "0x180935DA0", Slot = "12")]
		public sealed override void PreprocessDeck(IList<Deck.Card> cards)
		{
		}

		// Token: 0x060115E3 RID: 71139 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115E3")]
		[Address(RVA = "0x935F10", Offset = "0x934B10", VA = "0x180935F10")]
		protected BasicLevelRune()
		{
		}

		// Token: 0x0401369B RID: 79515
		[Token(Token = "0x401369B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_PreprocessCharacter;

		// Token: 0x0401369C RID: 79516
		[Token(Token = "0x401369C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PreprocessEnemy;

		// Token: 0x0401369D RID: 79517
		[Token(Token = "0x401369D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessTile;

		// Token: 0x0401369E RID: 79518
		[Token(Token = "0x401369E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessDeck;

		// Token: 0x0401369F RID: 79519
		[Token(Token = "0x401369F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
