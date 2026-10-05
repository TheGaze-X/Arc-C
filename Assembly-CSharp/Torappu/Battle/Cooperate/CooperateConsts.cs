using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Cooperate
{
	// Token: 0x020026D9 RID: 9945
	[Token(Token = "0x20026D9")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class CooperateConsts
	{
		// Token: 0x0401212F RID: 74031
		[Token(Token = "0x401212F")]
		public const string BATTLE_UI_PLUGIN_PATH = "UI/Cooperate/Battle/cooperate_battle_ui_plugin.prefab";

		// Token: 0x04012130 RID: 74032
		[Token(Token = "0x4012130")]
		public const string CAMERA_FORTRESS_PLUGIN_PATH = "UI/Cooperate/Battle/Widgets/cooperate_fortress_battle_camera_plugin.prefab";

		// Token: 0x04012131 RID: 74033
		[Token(Token = "0x4012131")]
		public const string PLAYER_DIE_GLOBAL_BUFF_KEY = "cooperate_player_die";

		// Token: 0x04012132 RID: 74034
		[Token(Token = "0x4012132")]
		public const string BB_ALL_SIDE = "all_side";

		// Token: 0x04012133 RID: 74035
		[Token(Token = "0x4012133")]
		public const string COOPERATE_COMMON_GLOBAL_BUFF = "cooperate_common_global_buff";

		// Token: 0x04012134 RID: 74036
		[Token(Token = "0x4012134")]
		public const string PLAYER_SIDE_TILE_EFFECT_ALLOW = "mapeff_multiplayer_01";

		// Token: 0x04012135 RID: 74037
		[Token(Token = "0x4012135")]
		public const string PLAYER_SIDE_TILE_EFFECT_FORBIDDEN = "mapeff_multiplayer_02";

		// Token: 0x04012136 RID: 74038
		[Token(Token = "0x4012136")]
		public const string WATER_FLOW_FORCE_STEP = "water_flow_force_step";

		// Token: 0x04012137 RID: 74039
		[Token(Token = "0x4012137")]
		public const string WATER_FLOW_FORCE_INTERVAL = "water_flow_force_interval";

		// Token: 0x04012138 RID: 74040
		[Token(Token = "0x4012138")]
		public const string SCORE_GOAL_STEP = "score_goal_step";

		// Token: 0x04012139 RID: 74041
		[Token(Token = "0x4012139")]
		public const string SCORE_THROUGH_BLOCK = "score_through_block";

		// Token: 0x0401213A RID: 74042
		[Token(Token = "0x401213A")]
		public const string BUILDABLE_TILE_KEY = "can_buildable_deck_tile";

		// Token: 0x0401213B RID: 74043
		[Token(Token = "0x401213B")]
		public const string BUILDABLE_TILE_VALUE = "can_buildable";

		// Token: 0x0401213C RID: 74044
		[Token(Token = "0x401213C")]
		public const string BOAT_TOTAL_TIME = "boat_total_time";

		// Token: 0x0401213D RID: 74045
		[Token(Token = "0x401213D")]
		public const string BOAT_EXTRA_TIME = "boat_extra_time";

		// Token: 0x0401213E RID: 74046
		[Token(Token = "0x401213E")]
		public const string BOAT_ENEMY_MARK = "enemy_mark";

		// Token: 0x0401213F RID: 74047
		[Token(Token = "0x401213F")]
		public const string BOAT_ITEM_MARK = "item_mark";

		// Token: 0x04012140 RID: 74048
		[Token(Token = "0x4012140")]
		public const string ENEMY_TRACE_ABILITY_NAME = "TraceTargetAbility[coop]";

		// Token: 0x04012141 RID: 74049
		[Token(Token = "0x4012141")]
		public const int FAIL_TIME = 3;

		// Token: 0x04012142 RID: 74050
		[Token(Token = "0x4012142")]
		public const string RESTING_TIME = "rest_time";

		// Token: 0x04012143 RID: 74051
		[Token(Token = "0x4012143")]
		public const int BASIC_WIN_SCORE = 3;

		// Token: 0x04012144 RID: 74052
		[Token(Token = "0x4012144")]
		public const int ADVANCE_WIN_SCORE = 4;

		// Token: 0x04012145 RID: 74053
		[Token(Token = "0x4012145")]
		public const int DUMMY_MOVE_UPDATE_INTERVAL_FRAME = 1;

		// Token: 0x04012146 RID: 74054
		[Token(Token = "0x4012146")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string[] MY_PIN_EFFECT;

		// Token: 0x04012147 RID: 74055
		[Token(Token = "0x4012147")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string[] MATE_PIN_EFFECT;

		// Token: 0x04012148 RID: 74056
		[Token(Token = "0x4012148")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string[] COOP_PRELOAD_EFFECT;

		// Token: 0x04012149 RID: 74057
		[Token(Token = "0x4012149")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string[] FOOTBALL_PRELOAD_EFFECT;

		// Token: 0x0401214A RID: 74058
		[Token(Token = "0x401214A")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string[] SAIL_BOAT_PRELOAD_EFFECT;

		// Token: 0x0401214B RID: 74059
		[Token(Token = "0x401214B")]
		public const string FOOT_EASY_HIT = "common_V050_hit_1";

		// Token: 0x0401214C RID: 74060
		[Token(Token = "0x401214C")]
		private const string FOOT_COMMON_HIT = "common_V050_hit_2";

		// Token: 0x0401214D RID: 74061
		[Token(Token = "0x401214D")]
		public const string FOOT_HARD_HIT = "common_V050_hit_3";

		// Token: 0x0401214E RID: 74062
		[Token(Token = "0x401214E")]
		public const string WITHDRAW_EFFECT = "map_bossrush_retreat_02";

		// Token: 0x0401214F RID: 74063
		[Token(Token = "0x401214F")]
		public const string DUMMY_DIRECTION_EFFECT = "common_direction_hint_1";

		// Token: 0x04012150 RID: 74064
		[Token(Token = "0x4012150")]
		public const string ALLY_LOWLAND_EFFECT = "common_direction_hint_2";

		// Token: 0x04012151 RID: 74065
		[Token(Token = "0x4012151")]
		public const string ALLY_HIGHLAND_EFFECT = "common_direction_hint_3";

		// Token: 0x04012152 RID: 74066
		[Token(Token = "0x4012152")]
		public const string LAND_FOOTBALL_EFFECT = "common_V050_hint_1";

		// Token: 0x04012153 RID: 74067
		[Token(Token = "0x4012153")]
		public const string FORTRESS_FIXER_TILE_BUILDABLE_KEY = "muwork_buildable[mark]";

		// Token: 0x04012154 RID: 74068
		[Token(Token = "0x4012154")]
		public const string NEXT_EDGE = "map_V066_S2_next_01";

		// Token: 0x04012155 RID: 74069
		[Token(Token = "0x4012155")]
		public const string FORBIDDEN_EDGE = "map_V066_S2_forbidden_01";

		// Token: 0x04012156 RID: 74070
		[Token(Token = "0x4012156")]
		public const string NO_TURN_BACK_EDGE = "map_V066_S2_NoTurnBack_01";

		// Token: 0x04012157 RID: 74071
		[Token(Token = "0x4012157")]
		public const string BOAT_START_EFFECT = "map_V066_S2_start_01";

		// Token: 0x04012158 RID: 74072
		[Token(Token = "0x4012158")]
		public const string LAND_BALL_TRAP_KEY = "trap_165_muftbl";

		// Token: 0x04012159 RID: 74073
		[Token(Token = "0x4012159")]
		public const string TAG_TRAP_MUGTPS = "trap_mugtps";

		// Token: 0x0401215A RID: 74074
		[Token(Token = "0x401215A")]
		public const string BOAT_BUILDABLE_TAG = "sail_boat_buildable";

		// Token: 0x0401215B RID: 74075
		[Token(Token = "0x401215B")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string[] CLEAR_TRAP_AFTER_STAGE;

		// Token: 0x0401215C RID: 74076
		[Token(Token = "0x401215C")]
		[FieldOffset(Offset = "0x30")]
		public static readonly string[] CAR_STAGE_TARGET;

		// Token: 0x0401215D RID: 74077
		[Token(Token = "0x401215D")]
		[FieldOffset(Offset = "0x38")]
		public static Dictionary<ProfessionCategory, int> BUFF_CARD_INDEX;
	}
}
