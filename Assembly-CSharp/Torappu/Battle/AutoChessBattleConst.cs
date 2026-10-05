using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002676 RID: 9846
	[Token(Token = "0x2002676")]
	public static class AutoChessBattleConst
	{
		// Token: 0x04011E7C RID: 73340
		[Token(Token = "0x4011E7C")]
		public const string TRIGGER_SKILL_ON_TAKE_DAMAGE = "autochess_trigger_skill[on_take_damage]";

		// Token: 0x04011E7D RID: 73341
		[Token(Token = "0x4011E7D")]
		public const string ENEMY_PREVIEW_BUFF_KEY = "autochess_enemy_preview_buff";

		// Token: 0x04011E7E RID: 73342
		[Token(Token = "0x4011E7E")]
		public const string COMMON_BOSS_BUFF_KEY = "autochess_common_boss_buff";

		// Token: 0x04011E7F RID: 73343
		[Token(Token = "0x4011E7F")]
		public const string HAND_TILE_KEY = "tile_achand";

		// Token: 0x04011E80 RID: 73344
		[Token(Token = "0x4011E80")]
		public const string PREDEFINE_SINGLE_ONLY_POSTFIX = "single_only";

		// Token: 0x04011E81 RID: 73345
		[Token(Token = "0x4011E81")]
		public const string PREDEFINE_MULTI_ONLY_POSTFIX = "multi_only";

		// Token: 0x04011E82 RID: 73346
		[Token(Token = "0x4011E82")]
		public const string RUNE_KEY_CHANGE_MAP = "auto_chess_change_map";

		// Token: 0x04011E83 RID: 73347
		[Token(Token = "0x4011E83")]
		public const string RUNE_KEY_GIVE_GARRISON_TO_FRONT = "give_garrison_to_front";

		// Token: 0x04011E84 RID: 73348
		[Token(Token = "0x4011E84")]
		public const string RUNE_KEY_GIVE_GARRISON_TO_BACK = "give_garrison_to_back";

		// Token: 0x04011E85 RID: 73349
		[Token(Token = "0x4011E85")]
		public const string RUNE_KEY_GIVE_GARRISON_TO_MOST_RIGHT = "give_garrison_to_most_right";

		// Token: 0x04011E86 RID: 73350
		[Token(Token = "0x4011E86")]
		public const string RUNE_KEY_GIVE_GARRISON_TO_ALL = "give_garrison_to_all";

		// Token: 0x04011E87 RID: 73351
		[Token(Token = "0x4011E87")]
		public const string GIVE_GARRISON_ID_KEY = "give_garrison_id";

		// Token: 0x04011E88 RID: 73352
		[Token(Token = "0x4011E88")]
		public const string GIVE_GARRISON_CHECK_BOND = "check_bond_id";

		// Token: 0x04011E89 RID: 73353
		[Token(Token = "0x4011E89")]
		public const string MANI_SHIP = "maniShip";

		// Token: 0x04011E8A RID: 73354
		[Token(Token = "0x4011E8A")]
		public const string COMMON_CONDITION_KEY = "common_condition";

		// Token: 0x04011E8B RID: 73355
		[Token(Token = "0x4011E8B")]
		public const string CONDITION_GOLDEN_CHESS_GE = "condition_golden_chess_ge";

		// Token: 0x04011E8C RID: 73356
		[Token(Token = "0x4011E8C")]
		public const string CONDITION_GOLDEN_CHESS_LE = "condition_golden_chess_le";

		// Token: 0x04011E8D RID: 73357
		[Token(Token = "0x4011E8D")]
		public const int MAX_GARRISON_STACK = 999;

		// Token: 0x04011E8E RID: 73358
		[Token(Token = "0x4011E8E")]
		public const float PRELOAD_WAIT_CAMERA_TIME = 0.3f;

		// Token: 0x04011E8F RID: 73359
		[Token(Token = "0x4011E8F")]
		public const int MAX_BATTLE_DAMAGE = 300000;

		// Token: 0x04011E90 RID: 73360
		[Token(Token = "0x4011E90")]
		public const int MAX_BATTLE_DEPLOY_CNT = 12;

		// Token: 0x04011E91 RID: 73361
		[Token(Token = "0x4011E91")]
		public const float RATIO_PARAM = 100f;

		// Token: 0x04011E92 RID: 73362
		[Token(Token = "0x4011E92")]
		public const int MAX_WEAR_EQUIP_CNT = 2;

		// Token: 0x04011E93 RID: 73363
		[Token(Token = "0x4011E93")]
		public const float BATTLE_WAIT_UI_TIME = 1.5f;

		// Token: 0x04011E94 RID: 73364
		[Token(Token = "0x4011E94")]
		public const float HELP_BATTLE_WAIT_UI_TIME = 2.5f;

		// Token: 0x04011E95 RID: 73365
		[Token(Token = "0x4011E95")]
		public const SpeedLevel SPEED_LEVEL_IN_BATTLE = SpeedLevel.FAST;

		// Token: 0x04011E96 RID: 73366
		[Token(Token = "0x4011E96")]
		public const string BOND_EMPTY_ID_KEY = "emptyShip";

		// Token: 0x04011E97 RID: 73367
		[Token(Token = "0x4011E97")]
		public const string BOSS_BATTLE_MULTI_PLAYER_BRANCH = "boss_battle_multi_player";

		// Token: 0x04011E98 RID: 73368
		[Token(Token = "0x4011E98")]
		[FieldOffset(Offset = "0x0")]
		public static readonly FP DELTA_TIME_FP_IN_STEPMODE;

		// Token: 0x02002677 RID: 9847
		[Token(Token = "0x2002677")]
		public static class BlackboardKeys
		{
			// Token: 0x04011E99 RID: 73369
			[Token(Token = "0x4011E99")]
			public const string CAMERA_PARAM_L_PREPARE = "left_prepare_camera_param";

			// Token: 0x04011E9A RID: 73370
			[Token(Token = "0x4011E9A")]
			public const string CAMERA_PARAM_L_SHOP = "left_shop_camera_param";

			// Token: 0x04011E9B RID: 73371
			[Token(Token = "0x4011E9B")]
			public const string CAMERA_PARAM_L_BATTLE = "left_battle_camera_param";

			// Token: 0x04011E9C RID: 73372
			[Token(Token = "0x4011E9C")]
			public const string CAMERA_PARAM_R_BATTLE = "right_battle_camera_param";

			// Token: 0x04011E9D RID: 73373
			[Token(Token = "0x4011E9D")]
			public const string CAMERA_PARAM_M_BATTLE = "mid_battle_camera_param";

			// Token: 0x04011E9E RID: 73374
			[Token(Token = "0x4011E9E")]
			public const string CAMERA_PARAM_L_BOSS_PREPARE = "left_boss_prepare_camera_param";

			// Token: 0x04011E9F RID: 73375
			[Token(Token = "0x4011E9F")]
			public const string CAMERA_PARAM_L_BOSS_SHOP = "left_boss_shop_camera_param";

			// Token: 0x04011EA0 RID: 73376
			[Token(Token = "0x4011EA0")]
			public const string CAMERA_PARAM_L_BOSS_BATTLE = "left_boss_battle_camera_param";

			// Token: 0x04011EA1 RID: 73377
			[Token(Token = "0x4011EA1")]
			public const string CAMERA_PARAM_R_BOSS_BATTLE = "right_boss_battle_camera_param";

			// Token: 0x04011EA2 RID: 73378
			[Token(Token = "0x4011EA2")]
			public const string CAMERA_PARAM_M_BOSS_BATTLE = "mid_boss_battle_camera_param";

			// Token: 0x04011EA3 RID: 73379
			[Token(Token = "0x4011EA3")]
			public const string CAMERA_PARAM_R_BOSS_PREPARE = "right_boss_prepare_camera_param";

			// Token: 0x04011EA4 RID: 73380
			[Token(Token = "0x4011EA4")]
			public const string CAMERA_PARAM_R_BOSS_SHOP = "right_boss_shop_camera_param";

			// Token: 0x04011EA5 RID: 73381
			[Token(Token = "0x4011EA5")]
			public const string CAMERA_PARAM_ENEMY = "enemy_camera_param";

			// Token: 0x04011EA6 RID: 73382
			[Token(Token = "0x4011EA6")]
			public const string CAMERA_MOVE_TIME = "move_time";

			// Token: 0x04011EA7 RID: 73383
			[Token(Token = "0x4011EA7")]
			public const string ENEMY_PLACE_RECT = "enemy_place_rect";

			// Token: 0x04011EA8 RID: 73384
			[Token(Token = "0x4011EA8")]
			public const string ENEMY_PREVIEW_ROW_OFFSET = "enemy_preview_row_offset";

			// Token: 0x04011EA9 RID: 73385
			[Token(Token = "0x4011EA9")]
			public const string ENEMY_PREVIEW_ROW_OFFSET_BOSS = "enemy_preview_row_offset_boss";

			// Token: 0x04011EAA RID: 73386
			[Token(Token = "0x4011EAA")]
			public const string ENEMY_ID = "enemy_id";

			// Token: 0x04011EAB RID: 73387
			[Token(Token = "0x4011EAB")]
			public const string HAND_TILE_IS_VALID_KEY = "isValidHand";

			// Token: 0x04011EAC RID: 73388
			[Token(Token = "0x4011EAC")]
			public const string PREVIEW_NOT_ALLOWED = "previewNotAlloed";

			// Token: 0x04011EAD RID: 73389
			[Token(Token = "0x4011EAD")]
			public const string CHARACTER_EXTRA_BOND_ADD_KEY = "extra_bond_add";

			// Token: 0x04011EAE RID: 73390
			[Token(Token = "0x4011EAE")]
			public const string PLAYER_MAP_LR_OFFSET = "player_map_lr_offset";

			// Token: 0x04011EAF RID: 73391
			[Token(Token = "0x4011EAF")]
			public const string PLAYER_MAP_UD_OFFSET = "player_map_ud_offset";

			// Token: 0x04011EB0 RID: 73392
			[Token(Token = "0x4011EB0")]
			public const string PLAYER_MAP_LR_BOUNDARY_COL = "player_map_lr_boundary_col";

			// Token: 0x04011EB1 RID: 73393
			[Token(Token = "0x4011EB1")]
			public const string RUNE_INVALID_IN_BAND = "invalid_in_band";

			// Token: 0x04011EB2 RID: 73394
			[Token(Token = "0x4011EB2")]
			public const string RUNE_VALID_IN_BAND = "valid_in_band";

			// Token: 0x04011EB3 RID: 73395
			[Token(Token = "0x4011EB3")]
			public const string RUNE_EQUIP_COMBO = "equip_chess_id";
		}
	}
}
