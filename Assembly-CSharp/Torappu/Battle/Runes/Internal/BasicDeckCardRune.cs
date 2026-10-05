using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes.Internal
{
	// Token: 0x020028C5 RID: 10437
	[Token(Token = "0x20028C5")]
	public abstract class BasicDeckCardRune : Rune
	{
		// Token: 0x1700265A RID: 9818
		// (get) Token: 0x060115D4 RID: 71124 RVA: 0x0006ADA0 File Offset: 0x00068FA0
		[Token(Token = "0x1700265A")]
		public override Rune.RuneTarget targetMask
		{
			[Token(Token = "0x60115D4")]
			[Address(RVA = "0x9351A0", Offset = "0x933DA0", VA = "0x1809351A0", Slot = "5")]
			get
			{
				return Rune.RuneTarget.NONE;
			}
		}

		// Token: 0x060115D5 RID: 71125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115D5")]
		[Address(RVA = "0x934EC0", Offset = "0x933AC0", VA = "0x180934EC0", Slot = "9")]
		public sealed override void PreprocessCharacter(ref Rune.CharacterInOut inOut, Character character)
		{
		}

		// Token: 0x060115D6 RID: 71126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115D6")]
		[Address(RVA = "0x934F40", Offset = "0x933B40", VA = "0x180934F40", Slot = "10")]
		public sealed override void PreprocessEnemy(LevelData.EnemyData data, Enemy enemy)
		{
		}

		// Token: 0x060115D7 RID: 71127 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115D7")]
		[Address(RVA = "0x9350B0", Offset = "0x933CB0", VA = "0x1809350B0", Slot = "11")]
		public sealed override void PreprocessTile(ref TileData tileData, GridPosition pos, Tile tile)
		{
		}

		// Token: 0x060115D8 RID: 71128 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115D8")]
		[Address(RVA = "0x935050", Offset = "0x933C50", VA = "0x180935050", Slot = "7")]
		public sealed override void PreprocessLevelOptions(LevelData.Options options)
		{
		}

		// Token: 0x060115D9 RID: 71129 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115D9")]
		[Address(RVA = "0x934FC0", Offset = "0x933BC0", VA = "0x180934FC0", Slot = "8")]
		public sealed override void PreprocessLevelData(LevelData levelData, MapData mapData, ref Rune.RuneLevelExtraOutput extraData)
		{
		}

		// Token: 0x060115DA RID: 71130 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115DA")]
		[Address(RVA = "0x935140", Offset = "0x933D40", VA = "0x180935140")]
		protected BasicDeckCardRune()
		{
		}

		// Token: 0x04013690 RID: 79504
		[Token(Token = "0x4013690")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_targetMask;

		// Token: 0x04013691 RID: 79505
		[Token(Token = "0x4013691")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_PreprocessCharacter;

		// Token: 0x04013692 RID: 79506
		[Token(Token = "0x4013692")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_PreprocessEnemy;

		// Token: 0x04013693 RID: 79507
		[Token(Token = "0x4013693")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_PreprocessTile;

		// Token: 0x04013694 RID: 79508
		[Token(Token = "0x4013694")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;

		// Token: 0x04013695 RID: 79509
		[Token(Token = "0x4013695")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x04013696 RID: 79510
		[Token(Token = "0x4013696")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
