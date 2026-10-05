using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028FB RID: 10491
	[Token(Token = "0x20028FB")]
	public abstract class BasicEnemyRune : Rune
	{
		// Token: 0x17002680 RID: 9856
		// (get) Token: 0x060116AB RID: 71339 RVA: 0x0006B208 File Offset: 0x00069408
		[Token(Token = "0x17002680")]
		public sealed override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x60116AB")]
			[Address(RVA = "0x9359D0", Offset = "0x9345D0", VA = "0x1809359D0", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x060116AC RID: 71340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116AC")]
		[Address(RVA = "0x935730", Offset = "0x934330", VA = "0x180935730", Slot = "10")]
		public sealed override void PreprocessEnemy(LevelData.EnemyData data, Enemy enemy)
		{
		}

		// Token: 0x060116AD RID: 71341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116AD")]
		[Address(RVA = "0x935650", Offset = "0x934250", VA = "0x180935650", Slot = "9")]
		public sealed override void PreprocessCharacter(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x060116AE RID: 71342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116AE")]
		[Address(RVA = "0x935880", Offset = "0x934480", VA = "0x180935880", Slot = "7")]
		public sealed override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x060116AF RID: 71343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116AF")]
		[Address(RVA = "0x9357F0", Offset = "0x9343F0", VA = "0x1809357F0", Slot = "8")]
		public sealed override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x060116B0 RID: 71344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116B0")]
		[Address(RVA = "0x9358E0", Offset = "0x9344E0", VA = "0x1809358E0", Slot = "11")]
		public sealed override void PreprocessTile(ref TileData tileData, GridPosition pos, Tile tile)
		{
		}

		// Token: 0x060116B1 RID: 71345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116B1")]
		[Address(RVA = "0x9356D0", Offset = "0x9342D0", VA = "0x1809356D0", Slot = "12")]
		public sealed override void PreprocessDeck(IList<Deck.Card> cards)
		{
		}

		// Token: 0x060116B2 RID: 71346
		[Token(Token = "0x60116B2")]
		protected abstract void DoPreprocessEnemy(LevelData.EnemyData data, Enemy enemy);

		// Token: 0x060116B3 RID: 71347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116B3")]
		[Address(RVA = "0x935970", Offset = "0x934570", VA = "0x180935970")]
		protected BasicEnemyRune()
		{
		}

		// Token: 0x0401375D RID: 79709
		[Token(Token = "0x401375D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x0401375E RID: 79710
		[Token(Token = "0x401375E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PreprocessEnemy;

		// Token: 0x0401375F RID: 79711
		[Token(Token = "0x401375F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessCharacter;

		// Token: 0x04013760 RID: 79712
		[Token(Token = "0x4013760")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;

		// Token: 0x04013761 RID: 79713
		[Token(Token = "0x4013761")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x04013762 RID: 79714
		[Token(Token = "0x4013762")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PreprocessTile;

		// Token: 0x04013763 RID: 79715
		[Token(Token = "0x4013763")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PreprocessDeck;

		// Token: 0x04013764 RID: 79716
		[Token(Token = "0x4013764")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
