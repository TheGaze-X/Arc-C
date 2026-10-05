using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x0200108B RID: 4235
	[Token(Token = "0x200108B")]
	public class HalfIdleBattleData : IHotfixable
	{
		// Token: 0x06006E1A RID: 28186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E1A")]
		[Address(RVA = "0x2105500", Offset = "0x2104100", VA = "0x182105500")]
		public HalfIdleBattleData()
		{
		}

		// Token: 0x04005A5A RID: 23130
		[Token(Token = "0x4005A5A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200108C RID: 4236
		[Token(Token = "0x200108C")]
		public enum BossState
		{
			// Token: 0x04005A5C RID: 23132
			[Token(Token = "0x4005A5C")]
			NOT_SUMMONED,
			// Token: 0x04005A5D RID: 23133
			[Token(Token = "0x4005A5D")]
			SUMMONED,
			// Token: 0x04005A5E RID: 23134
			[Token(Token = "0x4005A5E")]
			DEAD
		}

		// Token: 0x0200108D RID: 4237
		[Token(Token = "0x200108D")]
		public static class HalfIdleConsts
		{
			// Token: 0x04005A5F RID: 23135
			[Token(Token = "0x4005A5F")]
			public const string HALF_IDLE_CAMERA_PLUGIN_PATH = "Activity/[UC]act1vhalfidle/Prefabs/Battle/halfidle_battle_camera_plugin.prefab";

			// Token: 0x04005A60 RID: 23136
			[Token(Token = "0x4005A60")]
			public const string HALF_IDLE_UI_PLUGIN_PATH = "Activity/[UC]act1vhalfidle/Prefabs/Battle/halfidle_battle_ui_plugin.prefab";

			// Token: 0x04005A61 RID: 23137
			[Token(Token = "0x4005A61")]
			public const string HALF_IDLE_BASIC_ENV = "env_032_act1vhalfidle";

			// Token: 0x04005A62 RID: 23138
			[Token(Token = "0x4005A62")]
			public const string MYLSS_WTRMAN_ID = "token_10030_mlyss_wtrman";

			// Token: 0x04005A63 RID: 23139
			[Token(Token = "0x4005A63")]
			public const string HALFIDLE_BATTLE_PAGE = "act1vhalfidle_battle_page";

			// Token: 0x04005A64 RID: 23140
			[Token(Token = "0x4005A64")]
			public const string EMPTY_EQUIP_ICON_NAME_FORMAT = "equip_{0}";

			// Token: 0x04005A65 RID: 23141
			[Token(Token = "0x4005A65")]
			public const string LHHE_TAG = "LHHE";

			// Token: 0x04005A66 RID: 23142
			[Token(Token = "0x4005A66")]
			public const string LHPORT_TAG = "LHPORT";

			// Token: 0x04005A67 RID: 23143
			[Token(Token = "0x4005A67")]
			[FieldOffset(Offset = "0x0")]
			public static string[] MYLSS_WTRMAN_TRANSFORM_BUFFS;

			// Token: 0x0200108E RID: 4238
			[Token(Token = "0x200108E")]
			public static class BlackboardKeys
			{
				// Token: 0x04005A68 RID: 23144
				[Token(Token = "0x4005A68")]
				public const string BOSS_BRANCH_TRIGGER_TIME_BB_KEY = "boss_branch_trigger_time";

				// Token: 0x04005A69 RID: 23145
				[Token(Token = "0x4005A69")]
				public const string ENEMY_WAVE_APPEAR_TIME_BB_KEY = "enemy_wave_appear_time";

				// Token: 0x04005A6A RID: 23146
				[Token(Token = "0x4005A6A")]
				public const string MAX_ENEMY_CAPACITY_BB_KEY = "max_enemy_capacity";

				// Token: 0x04005A6B RID: 23147
				[Token(Token = "0x4005A6B")]
				public const string LEVEL_CAPACITY_BB_KEY = "level_capacity";

				// Token: 0x04005A6C RID: 23148
				[Token(Token = "0x4005A6C")]
				public const string COMBINE_PLOT_BB_KEY = "combine_plot";
			}
		}

		// Token: 0x0200108F RID: 4239
		[Token(Token = "0x200108F")]
		public enum HalfIdleBattleEvent
		{
			// Token: 0x04005A6E RID: 23150
			[Token(Token = "0x4005A6E")]
			ON_HALF_IDLE_EQUIP_DIRTY,
			// Token: 0x04005A6F RID: 23151
			[Token(Token = "0x4005A6F")]
			ON_HALF_IDLE_CARD_LIST_DIRTY,
			// Token: 0x04005A70 RID: 23152
			[Token(Token = "0x4005A70")]
			ON_HALF_IDLE_GAIN_CARD
		}
	}
}
