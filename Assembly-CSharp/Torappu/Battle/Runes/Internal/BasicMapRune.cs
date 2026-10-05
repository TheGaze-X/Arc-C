using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x02002911 RID: 10513
	[Token(Token = "0x2002911")]
	public abstract class BasicMapRune : Rune
	{
		// Token: 0x1700268B RID: 9867
		// (get) Token: 0x060116F4 RID: 71412 RVA: 0x0006B418 File Offset: 0x00069618
		[Token(Token = "0x1700268B")]
		public sealed override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x60116F4")]
			[Address(RVA = "0x9365B0", Offset = "0x9351B0", VA = "0x1809365B0", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x060116F5 RID: 71413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116F5")]
		[Address(RVA = "0x935F70", Offset = "0x934B70", VA = "0x180935F70", Slot = "16")]
		protected override void OnInit()
		{
		}

		// Token: 0x060116F6 RID: 71414 RVA: 0x0006B430 File Offset: 0x00069630
		[Token(Token = "0x60116F6")]
		[Address(RVA = "0x936430", Offset = "0x935030", VA = "0x180936430")]
		protected bool Verify(TileData tData, GridPosition pos, Tile tile)
		{
			return default(bool);
		}

		// Token: 0x060116F7 RID: 71415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116F7")]
		[Address(RVA = "0x936260", Offset = "0x934E60", VA = "0x180936260", Slot = "11")]
		public sealed override void PreprocessTile(ref TileData tData, GridPosition pos, Tile tile)
		{
		}

		// Token: 0x060116F8 RID: 71416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116F8")]
		[Address(RVA = "0x936010", Offset = "0x934C10", VA = "0x180936010", Slot = "9")]
		public sealed override void PreprocessCharacter(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x060116F9 RID: 71417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116F9")]
		[Address(RVA = "0x936200", Offset = "0x934E00", VA = "0x180936200", Slot = "7")]
		public sealed override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x060116FA RID: 71418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116FA")]
		[Address(RVA = "0x936170", Offset = "0x934D70", VA = "0x180936170", Slot = "8")]
		public sealed override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x060116FB RID: 71419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116FB")]
		[Address(RVA = "0x9360F0", Offset = "0x934CF0", VA = "0x1809360F0", Slot = "10")]
		public sealed override void PreprocessEnemy(LevelData.EnemyData data, Enemy enemy)
		{
		}

		// Token: 0x060116FC RID: 71420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116FC")]
		[Address(RVA = "0x936090", Offset = "0x934C90", VA = "0x180936090", Slot = "12")]
		public sealed override void PreprocessDeck(IList<Deck.Card> cards)
		{
		}

		// Token: 0x060116FD RID: 71421
		[Token(Token = "0x60116FD")]
		protected abstract void DoPreprocessTile(ref TileData tData, GridPosition pos, Tile tile);

		// Token: 0x060116FE RID: 71422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116FE")]
		[Address(RVA = "0x936550", Offset = "0x935150", VA = "0x180936550")]
		protected BasicMapRune()
		{
		}

		// Token: 0x060116FF RID: 71423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60116FF")]
		[Address(RVA = "0x936420", Offset = "0x935020", VA = "0x180936420")]
		private void <>xLuaBaseProxy_OnInit()
		{
		}

		// Token: 0x0401379A RID: 79770
		[Token(Token = "0x401379A")]
		[FieldOffset(Offset = "0x20")]
		private List<GridPosition> m_locationList;

		// Token: 0x0401379B RID: 79771
		[Token(Token = "0x401379B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x0401379C RID: 79772
		[Token(Token = "0x401379C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0401379D RID: 79773
		[Token(Token = "0x401379D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Verify;

		// Token: 0x0401379E RID: 79774
		[Token(Token = "0x401379E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessTile;

		// Token: 0x0401379F RID: 79775
		[Token(Token = "0x401379F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PreprocessCharacter;

		// Token: 0x040137A0 RID: 79776
		[Token(Token = "0x40137A0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;

		// Token: 0x040137A1 RID: 79777
		[Token(Token = "0x40137A1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x040137A2 RID: 79778
		[Token(Token = "0x40137A2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_PreprocessEnemy;

		// Token: 0x040137A3 RID: 79779
		[Token(Token = "0x40137A3")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_PreprocessDeck;

		// Token: 0x040137A4 RID: 79780
		[Token(Token = "0x40137A4")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
