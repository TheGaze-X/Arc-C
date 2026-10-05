using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020020BC RID: 8380
	[Token(Token = "0x20020BC")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Consts
	{
		// Token: 0x0400D9E1 RID: 55777
		[Token(Token = "0x400D9E1")]
		public const float MODIFIER_CRIT_THRESHOLD = 1.5f;

		// Token: 0x0400D9E2 RID: 55778
		[Token(Token = "0x400D9E2")]
		public const string BLACKBOARD_PREFIX_TO_STRIP_FORMAT = "{0}.";

		// Token: 0x0400D9E3 RID: 55779
		[Token(Token = "0x400D9E3")]
		public const string BUFF_INDEPENDENT_FLAG = "^";

		// Token: 0x0400D9E4 RID: 55780
		[Token(Token = "0x400D9E4")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector3[] CAMERA_VIEWS;

		// Token: 0x0400D9E5 RID: 55781
		[Token(Token = "0x400D9E5")]
		[FieldOffset(Offset = "0x8")]
		public static FP MAP_MAX_SQRMAGNITUDE;

		// Token: 0x0400D9E6 RID: 55782
		[Token(Token = "0x400D9E6")]
		[FieldOffset(Offset = "0x10")]
		public static FP MAP_MAX_MAGNITUDE;

		// Token: 0x0400D9E7 RID: 55783
		[Token(Token = "0x400D9E7")]
		public const string TILE_START_POS_KEY = "tile_start";

		// Token: 0x0400D9E8 RID: 55784
		[Token(Token = "0x400D9E8")]
		public const string TILE_END_POS_KEY = "tile_end";

		// Token: 0x0400D9E9 RID: 55785
		[Token(Token = "0x400D9E9")]
		public const string TILE_TELOUT_POS_KEY = "tile_telout";

		// Token: 0x0400D9EA RID: 55786
		[Token(Token = "0x400D9EA")]
		public const string TILE_TELIN_POS_KEY = "tile_telin";

		// Token: 0x0400D9EB RID: 55787
		[Token(Token = "0x400D9EB")]
		public const int MAX_UNITS = 512;

		// Token: 0x0400D9EC RID: 55788
		[Token(Token = "0x400D9EC")]
		public const int MAX_SELECTED_TARGET = 128;

		// Token: 0x0400D9ED RID: 55789
		[Token(Token = "0x400D9ED")]
		public const int MAX_SELECTED_TILE = 256;

		// Token: 0x0400D9EE RID: 55790
		[Token(Token = "0x400D9EE")]
		public const int MAX_PROJECTILES = 2048;

		// Token: 0x0400D9EF RID: 55791
		[Token(Token = "0x400D9EF")]
		public const float UNIT_HP_RECOVERY_DELTA = 1f;

		// Token: 0x0400D9F0 RID: 55792
		[Token(Token = "0x400D9F0")]
		public const float UNIT_EP_RECOVERY_DELTA = 1f;

		// Token: 0x0400D9F1 RID: 55793
		[Token(Token = "0x400D9F1")]
		public const float MIN_UNIT_BORN_MAX_HP = 1f;

		// Token: 0x0400D9F2 RID: 55794
		[Token(Token = "0x400D9F2")]
		public const float BLOCK_RADIUS = 0.7071f;

		// Token: 0x0400D9F3 RID: 55795
		[Token(Token = "0x400D9F3")]
		public const float BLOCK_RADIUS_SQUARE = 0.49999037f;

		// Token: 0x0400D9F4 RID: 55796
		[Token(Token = "0x400D9F4")]
		public const float BLOCK_RADIUS_LARGE = 0.8944f;

		// Token: 0x0400D9F5 RID: 55797
		[Token(Token = "0x400D9F5")]
		public const float BLOCK_RADIUS_LARGE_SQUARE = 0.7999514f;

		// Token: 0x0400D9F6 RID: 55798
		[Token(Token = "0x400D9F6")]
		public const float MIN_BLOCK_DIST_TO_TAREGT = 0.5f;

		// Token: 0x0400D9F7 RID: 55799
		[Token(Token = "0x400D9F7")]
		public const float CHARACTER_DEAD_TIME = 1f;

		// Token: 0x0400D9F8 RID: 55800
		[Token(Token = "0x400D9F8")]
		public const float CHARACTER_BORN_TIME = 1f;

		// Token: 0x0400D9F9 RID: 55801
		[Token(Token = "0x400D9F9")]
		public const float ENEMY_DEAD_TIME = 1f;

		// Token: 0x0400D9FA RID: 55802
		[Token(Token = "0x400D9FA")]
		public const float ENEMY_BORN_TIME = 1f;

		// Token: 0x0400D9FB RID: 55803
		[Token(Token = "0x400D9FB")]
		public const float CHARACTER_RESPAWN_COST_MULTIPLIER = 0.5f;

		// Token: 0x0400D9FC RID: 55804
		[Token(Token = "0x400D9FC")]
		public const float CHARACTER_RESPAWN_COST_MAX_MULTIPLIER = 2f;

		// Token: 0x0400D9FD RID: 55805
		[Token(Token = "0x400D9FD")]
		public const string CHARACTER_SKILL_RETRIGGER_KEY = "skill_retrigger";

		// Token: 0x0400D9FE RID: 55806
		[Token(Token = "0x400D9FE")]
		public const float MIN_ANIM_SPEED = 0.01f;

		// Token: 0x0400D9FF RID: 55807
		[Token(Token = "0x400D9FF")]
		public const float MAX_ANIM_SPEED = 100f;

		// Token: 0x0400DA00 RID: 55808
		[Token(Token = "0x400DA00")]
		public const int PRELOAD_ENTITY_LIST_POOL_SIZE = 2;

		// Token: 0x0400DA01 RID: 55809
		[Token(Token = "0x400DA01")]
		public const int SPINE_VERTEX_COUNT_FOR_CHARACTER_RECOMMEND = 1000;

		// Token: 0x0400DA02 RID: 55810
		[Token(Token = "0x400DA02")]
		public const int SPINE_VERTEX_COUNT_FOR_CHARACTER_MAX = 1400;

		// Token: 0x0400DA03 RID: 55811
		[Token(Token = "0x400DA03")]
		public const int SPINE_VERTEX_COUNT_FOR_ENEMY_MAX = 300;

		// Token: 0x0400DA04 RID: 55812
		[Token(Token = "0x400DA04")]
		public const int SPINE_VERTEX_COUNT_FOR_TOKEN_MAX = 300;

		// Token: 0x0400DA05 RID: 55813
		[Token(Token = "0x400DA05")]
		public const int LEVITATE_TIME_REDUCE_MASS_LEVEL = 3;

		// Token: 0x0400DA06 RID: 55814
		[Token(Token = "0x400DA06")]
		public const int LEVITATE_TIME_REDUCE_RATIO = 2;

		// Token: 0x0400DA07 RID: 55815
		[Token(Token = "0x400DA07")]
		[FieldOffset(Offset = "0x18")]
		public static readonly int[] ENEMY_EXTRA_EP;

		// Token: 0x0400DA08 RID: 55816
		[Token(Token = "0x400DA08")]
		public const string IS_HEIGHT_UNCHANGEABLE_TRAP = "is_height_unchangeable_trap";

		// Token: 0x0400DA09 RID: 55817
		[Token(Token = "0x400DA09")]
		public const string IS_OVERLAP_BUILDABLE_TRAP = "is_overlap_buildable_trap";

		// Token: 0x0400DA0A RID: 55818
		[Token(Token = "0x400DA0A")]
		public const float ROUTE_REACH_DISTANCE = 0.05f;

		// Token: 0x0400DA0B RID: 55819
		[Token(Token = "0x400DA0B")]
		public const float ROUTE_MIN_CHANGE_FACE_DISTANCE_SQR = 0.0625f;

		// Token: 0x0400DA0C RID: 55820
		[Token(Token = "0x400DA0C")]
		public const float ROUTE_GOPASS_DISTANCE = 0.25f;

		// Token: 0x0400DA0D RID: 55821
		[Token(Token = "0x400DA0D")]
		public const float TILE_HALF_SIZE = 0.5f;

		// Token: 0x0400DA0E RID: 55822
		[Token(Token = "0x400DA0E")]
		public const float TILE_CENTER_HALF_SIZE = 0.25f;

		// Token: 0x0400DA0F RID: 55823
		[Token(Token = "0x400DA0F")]
		public const float MAX_STEERING_FACTOR = 100f;

		// Token: 0x0400DA10 RID: 55824
		[Token(Token = "0x400DA10")]
		public const float MAX_STEERING_FORCE = 100f;

		// Token: 0x0400DA11 RID: 55825
		[Token(Token = "0x400DA11")]
		public const int TILE_OBSTACLE_LIKE_MOVE_COST = 1000;

		// Token: 0x0400DA12 RID: 55826
		[Token(Token = "0x400DA12")]
		public const int TILE_DANGEROUS_OBSTACLE_LIKE_MOVE_COST = 1000000;

		// Token: 0x0400DA13 RID: 55827
		[Token(Token = "0x400DA13")]
		public const float TILE_COLLIDE_DISTANCE = 0.005f;

		// Token: 0x0400DA14 RID: 55828
		[Token(Token = "0x400DA14")]
		public const float TILE_COLLIDE_DISTANCE_WIDE = 0.01f;

		// Token: 0x0400DA15 RID: 55829
		[Token(Token = "0x400DA15")]
		[FieldOffset(Offset = "0x20")]
		public static readonly FP INFINITY_TIME;

		// Token: 0x0400DA16 RID: 55830
		[Token(Token = "0x400DA16")]
		[FieldOffset(Offset = "0x28")]
		public static readonly FP LARGE_TIME;

		// Token: 0x0400DA17 RID: 55831
		[Token(Token = "0x400DA17")]
		public const float OVERLOAD_RATIO = 0.5f;

		// Token: 0x0400DA18 RID: 55832
		[Token(Token = "0x400DA18")]
		public const float PROJECTILE_REACHED_DISTANCE = 0.1f;

		// Token: 0x0400DA19 RID: 55833
		[Token(Token = "0x400DA19")]
		[FieldOffset(Offset = "0x30")]
		public static readonly float[] TIMESCALE_PER_SPEED_LEVELS;

		// Token: 0x0400DA1A RID: 55834
		[Token(Token = "0x400DA1A")]
		public const EntityCategory ALL_ENTITY_CATEGORIES = EntityCategory.DEFAULT | EntityCategory.TRAP_OR_ITEM | EntityCategory.OBSTACLE;

		// Token: 0x0400DA1B RID: 55835
		[Token(Token = "0x400DA1B")]
		public const int DEFAULT_RESOURCE_POOL_COUNT = 500;

		// Token: 0x0400DA1C RID: 55836
		[Token(Token = "0x400DA1C")]
		public const int LOAD_POOL_CNT_PER_FRAME_INITED_BUT_NOT_START = 2;

		// Token: 0x0400DA1D RID: 55837
		[Token(Token = "0x400DA1D")]
		public const int LOAD_POOL_CNT_PER_FRAME_PLAYING = 1;

		// Token: 0x0400DA1E RID: 55838
		[Token(Token = "0x400DA1E")]
		public const float UNIT_GRAPHIC_BOUND_RADIUS = 1f;

		// Token: 0x0400DA1F RID: 55839
		[Token(Token = "0x400DA1F")]
		public const string ILLUST_OFFSET = "ILLUST_OFFSET";

		// Token: 0x0400DA20 RID: 55840
		[Token(Token = "0x400DA20")]
		public const string ILLUST_SIZE = "ILLUST_SIZE";

		// Token: 0x0400DA21 RID: 55841
		[Token(Token = "0x400DA21")]
		public const string DYNAMIC_ABILITY_AT_ROOT = "DYNAMIC_ABILITY_AT_ROOT";

		// Token: 0x0400DA22 RID: 55842
		[Token(Token = "0x400DA22")]
		[FieldOffset(Offset = "0x38")]
		public static readonly float GRAVITY;

		// Token: 0x0400DA23 RID: 55843
		[Token(Token = "0x400DA23")]
		public const float FRICTION_FACTOR = 0.5f;

		// Token: 0x0400DA24 RID: 55844
		[Token(Token = "0x400DA24")]
		public const float UNBALANCE_MIN_SPEED = 0.1f;

		// Token: 0x0400DA25 RID: 55845
		[Token(Token = "0x400DA25")]
		public const float UNBALANCE_PROTECT_TIME = 0.1f;

		// Token: 0x0400DA26 RID: 55846
		[Token(Token = "0x400DA26")]
		public const float KNOCKBACK_FACTOR = 0.02f;

		// Token: 0x0400DA27 RID: 55847
		[Token(Token = "0x400DA27")]
		public const float PULL_FACTOR = 1f;

		// Token: 0x0400DA28 RID: 55848
		[Token(Token = "0x400DA28")]
		public const float HARPOON_BROKEN_FORCE_LEVEL_OFFSET = -2f;

		// Token: 0x0400DA29 RID: 55849
		[Token(Token = "0x400DA29")]
		public const float HARPOON_BROKEN_DURATION = 0.5f;

		// Token: 0x0400DA2A RID: 55850
		[Token(Token = "0x400DA2A")]
		[FieldOffset(Offset = "0x40")]
		public static readonly string[] PROJECTILE_NAME_REFIX;

		// Token: 0x0400DA2B RID: 55851
		[Token(Token = "0x400DA2B")]
		public const string COMMON_EFFECT_PREFIX = "common_";

		// Token: 0x0400DA2C RID: 55852
		[Token(Token = "0x400DA2C")]
		public const int TARGET_EXIT_WEIGHT = 2000;

		// Token: 0x0400DA2D RID: 55853
		[Token(Token = "0x400DA2D")]
		public const int TARGET_ENTER_WEIGHT = 1000;

		// Token: 0x0400DA2E RID: 55854
		[Token(Token = "0x400DA2E")]
		public const int TARGET_STAY_WEIGHT = 0;

		// Token: 0x0400DA2F RID: 55855
		[Token(Token = "0x400DA2F")]
		public const string DECK_DEFAULT_HIDDEN_KEY = "deck_default_hidden";

		// Token: 0x0400DA30 RID: 55856
		[Token(Token = "0x400DA30")]
		public const string SANDBOX_HIDDEN_IN_HAND = "sandbox_hidden_in_hand";

		// Token: 0x0400DA31 RID: 55857
		[Token(Token = "0x400DA31")]
		public const string LEGION_HIDDEN_IN_HAND = "legion_hidden_in_hand";

		// Token: 0x0400DA32 RID: 55858
		[Token(Token = "0x400DA32")]
		public const string HALFIDLE_HIDDEN_IN_HAND = "halfidle_hidden_in_hand";

		// Token: 0x0400DA33 RID: 55859
		[Token(Token = "0x400DA33")]
		public const string ROGUELIKE_DUEL_HIDDEN_IN_HAND = "roguelike_duel_hidden_in_hand";

		// Token: 0x0400DA34 RID: 55860
		[Token(Token = "0x400DA34")]
		public const string ACT47SIDE_HIDE_HAND_REBUILD = "act47side_hide_hand_rebuild";

		// Token: 0x0400DA35 RID: 55861
		[Token(Token = "0x400DA35")]
		public const string DECK_FALLBACK_HIDDEN_KEY = "deck_fallback_hidden";

		// Token: 0x020020BD RID: 8381
		[Token(Token = "0x20020BD")]
		public enum BattlePauseKey
		{
			// Token: 0x0400DA37 RID: 55863
			[Token(Token = "0x400DA37")]
			UI_CONTROLLER,
			// Token: 0x0400DA38 RID: 55864
			[Token(Token = "0x400DA38")]
			CANCEL_AUTO_BATTLE,
			// Token: 0x0400DA39 RID: 55865
			[Token(Token = "0x400DA39")]
			INTERNAL,
			// Token: 0x0400DA3A RID: 55866
			[Token(Token = "0x400DA3A")]
			GAMEMODE_UI_CONTROLLER,
			// Token: 0x0400DA3B RID: 55867
			[Token(Token = "0x400DA3B")]
			BOSSRUSH_MOVE_CAMERA,
			// Token: 0x0400DA3C RID: 55868
			[Token(Token = "0x400DA3C")]
			UI_BRIDGE,
			// Token: 0x0400DA3D RID: 55869
			[Token(Token = "0x400DA3D")]
			DIALOG_STATE,
			// Token: 0x0400DA3E RID: 55870
			[Token(Token = "0x400DA3E")]
			AUTOCHESS_ROUND_BATTLE_SERVICE_INTERNAL
		}

		// Token: 0x020020BE RID: 8382
		[Token(Token = "0x20020BE")]
		public static class PriorityLevel
		{
			// Token: 0x0400DA3F RID: 55871
			[Token(Token = "0x400DA3F")]
			public const int LOW = 0;

			// Token: 0x0400DA40 RID: 55872
			[Token(Token = "0x400DA40")]
			public const int MIDDLE = 100;

			// Token: 0x0400DA41 RID: 55873
			[Token(Token = "0x400DA41")]
			public const int HIGH = 10000;
		}
	}
}
