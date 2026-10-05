using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004417 RID: 17431
	[Token(Token = "0x2004417")]
	public static class SandboxV2Const
	{
		// Token: 0x04021EEA RID: 138986
		[Token(Token = "0x4021EEA")]
		public const string PARAM_NODE_ID = "nodeId";

		// Token: 0x04021EEB RID: 138987
		[Token(Token = "0x4021EEB")]
		public const string PARAM_TOPIC_ID = "topicId";

		// Token: 0x04021EEC RID: 138988
		[Token(Token = "0x4021EEC")]
		public const string PARAM_IS_MONTH = "isMonth";

		// Token: 0x04021EED RID: 138989
		[Token(Token = "0x4021EED")]
		public const string PARAM_MONTH_RUSH_ID = "monthRushId";

		// Token: 0x04021EEE RID: 138990
		[Token(Token = "0x4021EEE")]
		public const string PARAM_FROM_READ_ARCHIVE = "fromReadArchive";

		// Token: 0x04021EEF RID: 138991
		[Token(Token = "0x4021EEF")]
		public const string IMG_HP_SPRITE_NAME = "img_hp_bar_enemy_rush";

		// Token: 0x04021EF0 RID: 138992
		[Token(Token = "0x4021EF0")]
		public const string IMG_SHADOW_SPRITE_NAME = "img_shadow";

		// Token: 0x04021EF1 RID: 138993
		[Token(Token = "0x4021EF1")]
		public const string IMG_BKG_SPRITE_NAME = "img_bkg_circle";

		// Token: 0x04021EF2 RID: 138994
		[Token(Token = "0x4021EF2")]
		public const string IMG_FRAME_SPRITE_NAME = "img_frame";

		// Token: 0x04021EF3 RID: 138995
		[Token(Token = "0x4021EF3")]
		public const string SANDBOX_CONSTRUCT_SCENE_FORMAT = "{0}_construct";

		// Token: 0x04021EF4 RID: 138996
		[Token(Token = "0x4021EF4")]
		public const int HP_RATIO_BASE = 10000;

		// Token: 0x04021EF5 RID: 138997
		[Token(Token = "0x4021EF5")]
		public const int DEFAULT_REPAIR_DISCOUNT = 100;

		// Token: 0x04021EF6 RID: 138998
		[Token(Token = "0x4021EF6")]
		public const float HP_RATIO_DIVISOR = 10000f;

		// Token: 0x04021EF7 RID: 138999
		[Token(Token = "0x4021EF7")]
		public const float HOME_SEVERELY_DAMAGED_THRESHOLD = 0.25f;

		// Token: 0x04021EF8 RID: 139000
		[Token(Token = "0x4021EF8")]
		public const float DUNGEON_ENTER_ANIM_WAIT_INTERVAL = 2.5f;

		// Token: 0x04021EF9 RID: 139001
		[Token(Token = "0x4021EF9")]
		public const float DUNGEON_LINE_ENTER_ANIM_SPEED = 2000f;

		// Token: 0x04021EFA RID: 139002
		[Token(Token = "0x4021EFA")]
		public const float DUNGEON_HOME_ENTER_ANIM_DELAY = 0.6f;

		// Token: 0x04021EFB RID: 139003
		[Token(Token = "0x4021EFB")]
		public const float DUNGEON_HOME_PORTABLE_RIFT_ENTER_ANIM_DELAY = 0.3f;

		// Token: 0x04021EFC RID: 139004
		[Token(Token = "0x4021EFC")]
		public const int MAT_BAR_STOCK_DISPLAY_MAXIMUM = 999;

		// Token: 0x04021EFD RID: 139005
		[Token(Token = "0x4021EFD")]
		public const string MAT_BAR_STOCK_DISPLAY_MAXIMUM_TEXT = "999+";

		// Token: 0x04021EFE RID: 139006
		[Token(Token = "0x4021EFE")]
		public const int GOLD_STOCK_DISPLAY_MAXIMUM = 99999;

		// Token: 0x04021EFF RID: 139007
		[Token(Token = "0x4021EFF")]
		public const string GOLD_STOCK_DISPLAY_MAXIMUM_TEXT = "99999+";

		// Token: 0x04021F00 RID: 139008
		[Token(Token = "0x4021F00")]
		public const int FOOD_MAIN_MAT_SLOT_COUNT = 4;

		// Token: 0x04021F01 RID: 139009
		[Token(Token = "0x4021F01")]
		public const int FOOD_SUB_MAT_SLOT_COUNT = 2;

		// Token: 0x04021F02 RID: 139010
		[Token(Token = "0x4021F02")]
		public const int FOOD_VARIANT_VALID_COUNT = 2;

		// Token: 0x04021F03 RID: 139011
		[Token(Token = "0x4021F03")]
		public const string SHOP_UPDATE_TRACK = "shop_update_track";

		// Token: 0x04021F04 RID: 139012
		[Token(Token = "0x4021F04")]
		public const string MONTH_UPDATE_TRACK = "month_update_track";

		// Token: 0x04021F05 RID: 139013
		[Token(Token = "0x4021F05")]
		public const string MODE_FORMAT = "mode_{0}";

		// Token: 0x04021F06 RID: 139014
		[Token(Token = "0x4021F06")]
		public const string RACER_NAME_FORMAT = "{0}{1}";

		// Token: 0x04021F07 RID: 139015
		[Token(Token = "0x4021F07")]
		public const int RACER_TALENT_REFRESH_TOKEN_CONSUME = 1;

		// Token: 0x04021F08 RID: 139016
		[Token(Token = "0x4021F08")]
		[FieldOffset(Offset = "0x0")]
		public static readonly List<ProfessionCategory> PROFESSION_ORDER_LIST;

		// Token: 0x02004418 RID: 17432
		[Token(Token = "0x2004418")]
		public enum SandboxV2ToastType
		{
			// Token: 0x04021F0A RID: 139018
			[Token(Token = "0x4021F0A")]
			NONE,
			// Token: 0x04021F0B RID: 139019
			[Token(Token = "0x4021F0B")]
			COMMON,
			// Token: 0x04021F0C RID: 139020
			[Token(Token = "0x4021F0C")]
			COOK,
			// Token: 0x04021F0D RID: 139021
			[Token(Token = "0x4021F0D")]
			BUILD,
			// Token: 0x04021F0E RID: 139022
			[Token(Token = "0x4021F0E")]
			ARCHIEVEMENT
		}

		// Token: 0x02004419 RID: 17433
		[Token(Token = "0x2004419")]
		public enum SandboxV2BattleBgmType
		{
			// Token: 0x04021F10 RID: 139024
			[Token(Token = "0x4021F10")]
			NONE,
			// Token: 0x04021F11 RID: 139025
			[Token(Token = "0x4021F11")]
			ENEMY_RUSH,
			// Token: 0x04021F12 RID: 139026
			[Token(Token = "0x4021F12")]
			BOSS_RUSH,
			// Token: 0x04021F13 RID: 139027
			[Token(Token = "0x4021F13")]
			COLLECT,
			// Token: 0x04021F14 RID: 139028
			[Token(Token = "0x4021F14")]
			HUNT
		}
	}
}
