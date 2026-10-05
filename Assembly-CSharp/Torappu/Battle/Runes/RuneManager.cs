using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Runes
{
	// Token: 0x020028C3 RID: 10435
	[Token(Token = "0x20028C3")]
	public class RuneManager : IHotfixable
	{
		// Token: 0x17002659 RID: 9817
		// (get) Token: 0x060115BE RID: 71102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002659")]
		public IEnumerable<Rune> runes
		{
			[Token(Token = "0x60115BE")]
			[Address(RVA = "0x92C420", Offset = "0x92B020", VA = "0x18092C420")]
			get
			{
				return null;
			}
		}

		// Token: 0x060115BF RID: 71103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115BF")]
		[Address(RVA = "0x92C2F0", Offset = "0x92AEF0", VA = "0x18092C2F0")]
		public RuneManager()
		{
		}

		// Token: 0x060115C0 RID: 71104 RVA: 0x0006AD58 File Offset: 0x00068F58
		[Token(Token = "0x60115C0")]
		[Address(RVA = "0x929640", Offset = "0x928240", VA = "0x180929640")]
		public bool IsRuneKeyValid(string runeKey)
		{
			return default(bool);
		}

		// Token: 0x060115C1 RID: 71105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115C1")]
		[Address(RVA = "0x929150", Offset = "0x927D50", VA = "0x180929150")]
		public void Clear()
		{
		}

		// Token: 0x060115C2 RID: 71106 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60115C2")]
		[Address(RVA = "0x929500", Offset = "0x928100", VA = "0x180929500")]
		public Rune CreateRune(RuneData data)
		{
			return null;
		}

		// Token: 0x060115C3 RID: 71107 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60115C3")]
		[Address(RVA = "0x929340", Offset = "0x927F40", VA = "0x180929340")]
		public Rune CreateLegacyRune(LegacyInLevelRuneData legacyData)
		{
			return null;
		}

		// Token: 0x060115C4 RID: 71108 RVA: 0x0006AD70 File Offset: 0x00068F70
		[Token(Token = "0x60115C4")]
		[Address(RVA = "0x9291F0", Offset = "0x927DF0", VA = "0x1809291F0")]
		public bool ContainsAnyRune(Rune.RuneTarget target)
		{
			return default(bool);
		}

		// Token: 0x060115C5 RID: 71109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115C5")]
		[Address(RVA = "0x92A3F0", Offset = "0x928FF0", VA = "0x18092A3F0")]
		public void PreprocessRuneData()
		{
		}

		// Token: 0x060115C6 RID: 71110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115C6")]
		[Address(RVA = "0x92AA50", Offset = "0x929650", VA = "0x18092AA50")]
		public void RemoveInvalidRunes()
		{
		}

		// Token: 0x060115C7 RID: 71111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115C7")]
		[Address(RVA = "0x9296F0", Offset = "0x9282F0", VA = "0x1809296F0")]
		public void PreprocessBattlePlayerData(List<BattlePlayerData> playerDataList)
		{
		}

		// Token: 0x060115C8 RID: 71112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60115C8")]
		[Address(RVA = "0x92A220", Offset = "0x928E20", VA = "0x18092A220")]
		public LevelData.Options PreprocessLevelOptions(LevelData.Options options)
		{
			return null;
		}

		// Token: 0x060115C9 RID: 71113 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60115C9")]
		[Address(RVA = "0x92A020", Offset = "0x928C20", VA = "0x18092A020")]
		public Rune.RuneLevelExtraOutput PreprocessLevelData(LevelData levelData, MapData mapData)
		{
			return null;
		}

		// Token: 0x060115CA RID: 71114 RVA: 0x0006AD88 File Offset: 0x00068F88
		[Token(Token = "0x60115CA")]
		[Address(RVA = "0x929B10", Offset = "0x928710", VA = "0x180929B10")]
		public Rune.CharacterInOut PreprocessCharacter(Rune.CharacterInOut inOut, Character character)
		{
			return default(Rune.CharacterInOut);
		}

		// Token: 0x060115CB RID: 71115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60115CB")]
		[Address(RVA = "0x929EA0", Offset = "0x928AA0", VA = "0x180929EA0")]
		public LevelData.EnemyData PreprocessEnemy(LevelData.EnemyData enemyData, Enemy enemy)
		{
			return null;
		}

		// Token: 0x060115CC RID: 71116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60115CC")]
		[Address(RVA = "0x92A8A0", Offset = "0x9294A0", VA = "0x18092A8A0")]
		public TileData PreprocessTile(TileData tileData, GridPosition pos, Tile tile)
		{
			return null;
		}

		// Token: 0x060115CD RID: 71117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115CD")]
		[Address(RVA = "0x929980", Offset = "0x928580", VA = "0x180929980")]
		public void PreprocessCardBuff(IList<Deck.Card> cards)
		{
		}

		// Token: 0x060115CE RID: 71118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115CE")]
		[Address(RVA = "0x929CF0", Offset = "0x9288F0", VA = "0x180929CF0")]
		public void PreprocessDeckData(Deck deck)
		{
		}

		// Token: 0x060115CF RID: 71119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115CF")]
		[Address(RVA = "0x92AEC0", Offset = "0x929AC0", VA = "0x18092AEC0")]
		private void _RegisterRuneClasses()
		{
		}

		// Token: 0x060115D0 RID: 71120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115D0")]
		private void _Register<T>(string key) where T : Rune
		{
		}

		// Token: 0x060115D1 RID: 71121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60115D1")]
		public void Register<T>(string key) where T : Rune
		{
		}

		// Token: 0x060115D2 RID: 71122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60115D2")]
		[Address(RVA = "0x92ABC0", Offset = "0x9297C0", VA = "0x18092ABC0")]
		private Rune _CreateInternal(RuneData data)
		{
			return null;
		}

		// Token: 0x0401366B RID: 79467
		[Token(Token = "0x401366B")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string[] RUNE_EXCLUDED_FROM_BATTLE;

		// Token: 0x0401366C RID: 79468
		[Token(Token = "0x401366C")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string RUNE_SQUAD_NUM_LIMIT;

		// Token: 0x0401366D RID: 79469
		[Token(Token = "0x401366D")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string RUNE_SQUAD_NUM_MODIFY;

		// Token: 0x0401366E RID: 79470
		[Token(Token = "0x401366E")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string RUNE_LEVEL_HIDDEN_GROUP_ENABLE;

		// Token: 0x0401366F RID: 79471
		[Token(Token = "0x401366F")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string RUNE_LEVEL_HIDDEN_GROUP_DISABLE;

		// Token: 0x04013670 RID: 79472
		[Token(Token = "0x4013670")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string CHAR_GROUP_TAG_ADD;

		// Token: 0x04013671 RID: 79473
		[Token(Token = "0x4013671")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string GLOBAL_PLACEABLE_CHAR_NUM_ADD;

		// Token: 0x04013672 RID: 79474
		[Token(Token = "0x4013672")]
		[FieldOffset(Offset = "0x10")]
		private Rune.RuneTarget m_targetMask;

		// Token: 0x04013673 RID: 79475
		[Token(Token = "0x4013673")]
		[FieldOffset(Offset = "0x18")]
		private Dictionary<string, Type> m_runeClasses;

		// Token: 0x04013674 RID: 79476
		[Token(Token = "0x4013674")]
		[FieldOffset(Offset = "0x20")]
		private PriorityQueue<Rune> m_runes;

		// Token: 0x04013675 RID: 79477
		[Token(Token = "0x4013675")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_runes;

		// Token: 0x04013676 RID: 79478
		[Token(Token = "0x4013676")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x04013677 RID: 79479
		[Token(Token = "0x4013677")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_IsRuneKeyValid;

		// Token: 0x04013678 RID: 79480
		[Token(Token = "0x4013678")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Clear;

		// Token: 0x04013679 RID: 79481
		[Token(Token = "0x4013679")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_CreateRune;

		// Token: 0x0401367A RID: 79482
		[Token(Token = "0x401367A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CreateLegacyRune;

		// Token: 0x0401367B RID: 79483
		[Token(Token = "0x401367B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_ContainsAnyRune;

		// Token: 0x0401367C RID: 79484
		[Token(Token = "0x401367C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_PreprocessRuneData;

		// Token: 0x0401367D RID: 79485
		[Token(Token = "0x401367D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_RemoveInvalidRunes;

		// Token: 0x0401367E RID: 79486
		[Token(Token = "0x401367E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_PreprocessBattlePlayerData;

		// Token: 0x0401367F RID: 79487
		[Token(Token = "0x401367F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_PreprocessLevelOptions;

		// Token: 0x04013680 RID: 79488
		[Token(Token = "0x4013680")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_PreprocessLevelData;

		// Token: 0x04013681 RID: 79489
		[Token(Token = "0x4013681")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_PreprocessCharacter;

		// Token: 0x04013682 RID: 79490
		[Token(Token = "0x4013682")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_PreprocessEnemy;

		// Token: 0x04013683 RID: 79491
		[Token(Token = "0x4013683")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_PreprocessTile;

		// Token: 0x04013684 RID: 79492
		[Token(Token = "0x4013684")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_PreprocessCardBuff;

		// Token: 0x04013685 RID: 79493
		[Token(Token = "0x4013685")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_PreprocessDeckData;

		// Token: 0x04013686 RID: 79494
		[Token(Token = "0x4013686")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__RegisterRuneClasses;

		// Token: 0x04013687 RID: 79495
		[Token(Token = "0x4013687")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__Register;

		// Token: 0x04013688 RID: 79496
		[Token(Token = "0x4013688")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_Register;

		// Token: 0x04013689 RID: 79497
		[Token(Token = "0x4013689")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__CreateInternal;

		// Token: 0x020028C4 RID: 10436
		[Token(Token = "0x20028C4")]
		public static class PreloadRuneKey
		{
			// Token: 0x0401368A RID: 79498
			[Token(Token = "0x401368A")]
			public const string ENV_SYSTEM_NEW = "env_system_new";

			// Token: 0x0401368B RID: 79499
			[Token(Token = "0x401368B")]
			public const string GLOBAL_BUFF_NEW = "env_gbuff_new";

			// Token: 0x0401368C RID: 79500
			[Token(Token = "0x401368C")]
			public const string ENV_LEVEL_SCRIPT_NEW = "env_level_script_new";

			// Token: 0x0401368D RID: 79501
			[Token(Token = "0x401368D")]
			public const string GLOBAL_BUFF_NEW_WITH_VERTIFY = "env_gbuff_new_with_verify";

			// Token: 0x0401368E RID: 79502
			[Token(Token = "0x401368E")]
			public const string GLOBAL_BUFF_ADD_WITH_HIGHER_PRIORITY = "env_gbuff_add_with_higher_priority";

			// Token: 0x0401368F RID: 79503
			[Token(Token = "0x401368F")]
			public const string RUNE_INSERT_TOKEN_CARD = "insert_token_card";
		}
	}
}
