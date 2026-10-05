using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028E7 RID: 10471
	[Token(Token = "0x20028E7")]
	public abstract class BasicCharacterRune : Rune
	{
		// Token: 0x1700267B RID: 9851
		// (get) Token: 0x06011670 RID: 71280 RVA: 0x0006B130 File Offset: 0x00069330
		[Token(Token = "0x1700267B")]
		public sealed override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x6011670")]
			[Address(RVA = "0x934E60", Offset = "0x933A60", VA = "0x180934E60", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x06011671 RID: 71281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011671")]
		[Address(RVA = "0x934AE0", Offset = "0x9336E0", VA = "0x180934AE0", Slot = "9")]
		public override void PreprocessCharacter(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x06011672 RID: 71282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011672")]
		[Address(RVA = "0x934D10", Offset = "0x933910", VA = "0x180934D10", Slot = "7")]
		public sealed override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x06011673 RID: 71283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011673")]
		[Address(RVA = "0x934C80", Offset = "0x933880", VA = "0x180934C80", Slot = "8")]
		public sealed override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x06011674 RID: 71284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011674")]
		[Address(RVA = "0x934C00", Offset = "0x933800", VA = "0x180934C00", Slot = "10")]
		public sealed override void PreprocessEnemy(LevelData.EnemyData data, Enemy enemy)
		{
		}

		// Token: 0x06011675 RID: 71285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011675")]
		[Address(RVA = "0x934D70", Offset = "0x933970", VA = "0x180934D70", Slot = "11")]
		public sealed override void PreprocessTile(ref TileData tileData, GridPosition pos, Tile tile)
		{
		}

		// Token: 0x06011676 RID: 71286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011676")]
		[Address(RVA = "0x934BA0", Offset = "0x9337A0", VA = "0x180934BA0", Slot = "12")]
		public sealed override void PreprocessDeck(IList<Deck.Card> cards)
		{
		}

		// Token: 0x06011677 RID: 71287
		[Token(Token = "0x6011677")]
		protected abstract void DoPreprocessChar(ref Rune.CharacterInOut inOut, Character character);

		// Token: 0x06011678 RID: 71288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011678")]
		[Address(RVA = "0x934E00", Offset = "0x933A00", VA = "0x180934E00")]
		protected BasicCharacterRune()
		{
		}

		// Token: 0x04013725 RID: 79653
		[Token(Token = "0x4013725")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x04013726 RID: 79654
		[Token(Token = "0x4013726")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PreprocessCharacter;

		// Token: 0x04013727 RID: 79655
		[Token(Token = "0x4013727")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;

		// Token: 0x04013728 RID: 79656
		[Token(Token = "0x4013728")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x04013729 RID: 79657
		[Token(Token = "0x4013729")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PreprocessEnemy;

		// Token: 0x0401372A RID: 79658
		[Token(Token = "0x401372A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PreprocessTile;

		// Token: 0x0401372B RID: 79659
		[Token(Token = "0x401372B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PreprocessDeck;

		// Token: 0x0401372C RID: 79660
		[Token(Token = "0x401372C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
