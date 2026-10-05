using System;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using UnityEngine;

namespace Torappu.Battle
{
	// Token: 0x020020BB RID: 8379
	[Token(Token = "0x20020BB")]
	public static class BattleOptions
	{
		// Token: 0x0600CDBA RID: 52666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CDBA")]
		[Address(RVA = "0x34F9600", Offset = "0x34F8200", VA = "0x1834F9600")]
		public static void LoadOptions(LevelData.Options options, MapThemeController mapTheme)
		{
		}

		// Token: 0x0600CDBB RID: 52667 RVA: 0x0004A388 File Offset: 0x00048588
		[Token(Token = "0x600CDBB")]
		[Address(RVA = "0x34F9C80", Offset = "0x34F8880", VA = "0x1834F9C80")]
		public static bool ModifyMaxCost(int newMaxCost)
		{
			return default(bool);
		}

		// Token: 0x0600CDBC RID: 52668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600CDBC")]
		[Address(RVA = "0x34F9D30", Offset = "0x34F8930", VA = "0x1834F9D30")]
		private static void _LoadMapTheme(MapThemeController mapTheme)
		{
		}

		// Token: 0x0400D9D0 RID: 55760
		[Token(Token = "0x400D9D0")]
		[FieldOffset(Offset = "0x0")]
		public static ObscuredFloat MOVE_MULTIPLIER;

		// Token: 0x0400D9D1 RID: 55761
		[Token(Token = "0x400D9D1")]
		[FieldOffset(Offset = "0x18")]
		public static ObscuredFloat COST_INCREASE_TIME;

		// Token: 0x0400D9D2 RID: 55762
		[Token(Token = "0x400D9D2")]
		[FieldOffset(Offset = "0x30")]
		public static ObscuredInt MAX_COST;

		// Token: 0x0400D9D3 RID: 55763
		[Token(Token = "0x400D9D3")]
		[FieldOffset(Offset = "0x44")]
		public static ObscuredInt MAX_COST_CEIL;

		// Token: 0x0400D9D4 RID: 55764
		[Token(Token = "0x400D9D4")]
		[FieldOffset(Offset = "0x58")]
		public static ObscuredInt INITIAL_COST;

		// Token: 0x0400D9D5 RID: 55765
		[Token(Token = "0x400D9D5")]
		[FieldOffset(Offset = "0x6C")]
		public static ObscuredInt CHARACTER_LIMIT;

		// Token: 0x0400D9D6 RID: 55766
		[Token(Token = "0x400D9D6")]
		[FieldOffset(Offset = "0x80")]
		public static ObscuredInt MAX_LIFE_POINT;

		// Token: 0x0400D9D7 RID: 55767
		[Token(Token = "0x400D9D7")]
		[FieldOffset(Offset = "0x94")]
		public static ObscuredInt ENEMY_TAUNT_LEVEL_MUL;

		// Token: 0x0400D9D8 RID: 55768
		[Token(Token = "0x400D9D8")]
		[FieldOffset(Offset = "0xA8")]
		public static bool BATTLE_ROLLBACK_SPEED;

		// Token: 0x0400D9D9 RID: 55769
		[Token(Token = "0x400D9D9")]
		[FieldOffset(Offset = "0xA9")]
		public static bool STEERING_ENABLED;

		// Token: 0x0400D9DA RID: 55770
		[Token(Token = "0x400D9DA")]
		[FieldOffset(Offset = "0xAA")]
		public static bool IS_TRAINING_LEVEL;

		// Token: 0x0400D9DB RID: 55771
		[Token(Token = "0x400D9DB")]
		[FieldOffset(Offset = "0xAB")]
		public static bool IS_LIMIT_FPS;

		// Token: 0x0400D9DC RID: 55772
		[Token(Token = "0x400D9DC")]
		[FieldOffset(Offset = "0xAC")]
		public static bool SYNC_MAXCOST_CEIL_WITH_MAXCOST;

		// Token: 0x0400D9DD RID: 55773
		[Token(Token = "0x400D9DD")]
		[FieldOffset(Offset = "0xB0")]
		public static Color GLOBAL_UNIT_COLOR;

		// Token: 0x0400D9DE RID: 55774
		[Token(Token = "0x400D9DE")]
		[FieldOffset(Offset = "0xC0")]
		public static Color GLOBAL_BUILDABLE_COLOR;

		// Token: 0x0400D9DF RID: 55775
		[Token(Token = "0x400D9DF")]
		[FieldOffset(Offset = "0xD0")]
		public static Color GLOBAL_TRAP_TINT_COLOR;

		// Token: 0x0400D9E0 RID: 55776
		[Token(Token = "0x400D9E0")]
		[FieldOffset(Offset = "0xE0")]
		public static Color GLOBAL_EMISSION_COLOR;
	}
}
