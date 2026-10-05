using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A84 RID: 10884
	[Token(Token = "0x2002A84")]
	public static class SandboxConsts
	{
		// Token: 0x04014737 RID: 83767
		[Token(Token = "0x4014737")]
		public const string HIDDEN_AREA_RECT_STR = "rect_";

		// Token: 0x04014738 RID: 83768
		[Token(Token = "0x4014738")]
		public const string HIDDEN_AREA_GRAPHIC_STR = "HIDDEN@";

		// Token: 0x04014739 RID: 83769
		[Token(Token = "0x4014739")]
		public const float FOG_RUNE_FINISH_VIEW_TIME = 3f;

		// Token: 0x0401473A RID: 83770
		[Token(Token = "0x401473A")]
		public const float RECORD_HPRATIO_SCALE = 10000f;

		// Token: 0x0401473B RID: 83771
		[Token(Token = "0x401473B")]
		public const float CONSTRUCT_HPRATIO_SCALE = 100f;

		// Token: 0x0401473C RID: 83772
		[Token(Token = "0x401473C")]
		public const float RES_TOAST_TIME = 2f;

		// Token: 0x0401473D RID: 83773
		[Token(Token = "0x401473D")]
		public const string DEFAULT_TOAST_COLOR = "b1d600";

		// Token: 0x0401473E RID: 83774
		[Token(Token = "0x401473E")]
		public const string CAMERA_PLUGIN_PATH = "UI/SandboxV2/[UC]Common/Battle/sandbox_battle_camera_plugin.prefab";

		// Token: 0x0401473F RID: 83775
		[Token(Token = "0x401473F")]
		public const string SANDBOX_UI_PLUGIN_PATH = "UI/SandboxV2/[UC]Common/Battle/sandbox_battle_ui_plugin.prefab";

		// Token: 0x04014740 RID: 83776
		[Token(Token = "0x4014740")]
		public const string SANDBOX_HIDDEN_STONE_KEY = "trap_413_hiddenstone";

		// Token: 0x04014741 RID: 83777
		[Token(Token = "0x4014741")]
		public const string ENEMY_TRACE_ABILITY_NAME = "TraceTargetAbility";

		// Token: 0x04014742 RID: 83778
		[Token(Token = "0x4014742")]
		public const string TEAM_TACTICAL_EFFECT = "screen_V053_trap_activited";

		// Token: 0x04014743 RID: 83779
		[Token(Token = "0x4014743")]
		public const string FOG_COMMON_KEY = "env_004_fog";

		// Token: 0x04014744 RID: 83780
		[Token(Token = "0x4014744")]
		public const string FOG_RUNE_ALIAS_KEY = "sandbox_env_fog";

		// Token: 0x04014745 RID: 83781
		[Token(Token = "0x4014745")]
		public const string FOG_RUNE_FINISH_VIEW_TIME_KEY = "finish_view_time";

		// Token: 0x04014746 RID: 83782
		[Token(Token = "0x4014746")]
		public const string ENEMY_REPLACE_RUNE_KEY = "sandbox_multi_enemy_replace";

		// Token: 0x04014747 RID: 83783
		[Token(Token = "0x4014747")]
		public const string RUNE_FILTER_WEATHER_KEY = "filter_sandbox_weather_type";

		// Token: 0x04014748 RID: 83784
		[Token(Token = "0x4014748")]
		public const string RUNE_FILTER_SEASON_KEY = "filter_sandbox_season_type";

		// Token: 0x04014749 RID: 83785
		[Token(Token = "0x4014749")]
		public const string RUNE_DISABLE_IN_BUILD = "disable_in_sandbox_build";

		// Token: 0x0401474A RID: 83786
		[Token(Token = "0x401474A")]
		public const string CONSTRUCT_MANAGER_KEY = "env_011_sandbox_1_construct";

		// Token: 0x0401474B RID: 83787
		[Token(Token = "0x401474B")]
		public const string F00D = "sandbox_food";

		// Token: 0x0401474C RID: 83788
		[Token(Token = "0x401474C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string[] FOG_GLOBAL_BUFF_KEYS;

		// Token: 0x0401474D RID: 83789
		[Token(Token = "0x401474D")]
		public const string ENEMY_GLOBAL_BUFF_KEY = "sandbox_enemy_buff";

		// Token: 0x0401474E RID: 83790
		[Token(Token = "0x401474E")]
		public const string CHAR_GLOBAL_BUFF_KEY = "sandbox_character_buff";

		// Token: 0x0401474F RID: 83791
		[Token(Token = "0x401474F")]
		public const string TRAP_GLOBAL_BUFF_KEY = "sandbox_trap_buff";

		// Token: 0x04014750 RID: 83792
		[Token(Token = "0x4014750")]
		public const string HIGHLAND_TAG = "sandbox_hidden_tile";

		// Token: 0x04014751 RID: 83793
		[Token(Token = "0x4014751")]
		public const string SANDBOX_NPC_LOCATABLE_BLACKBOARD = "sandbox_npc";

		// Token: 0x04014752 RID: 83794
		[Token(Token = "0x4014752")]
		public const string SANDBOX_NPC_LOCATABLE_DIRECTION_BLACKBOARD = "sandbox_npc_direction";

		// Token: 0x04014753 RID: 83795
		[Token(Token = "0x4014753")]
		[FieldOffset(Offset = "0x8")]
		public static Dictionary<string, string> HOOKED_TILE_EFFECT;

		// Token: 0x04014754 RID: 83796
		[Token(Token = "0x4014754")]
		[FieldOffset(Offset = "0x10")]
		public static Dictionary<string, string> HOOKED_TILE_APPEND_INFO;

		// Token: 0x02002A85 RID: 10885
		[Token(Token = "0x2002A85")]
		public static class SandboxLevelConfigKeys
		{
			// Token: 0x04014755 RID: 83797
			[Token(Token = "0x4014755")]
			public const string ENABLE_WAR_FOG = "enable_war_fog";

			// Token: 0x04014756 RID: 83798
			[Token(Token = "0x4014756")]
			public const string DISABLE_CHARACTER_GBUFF = "disable_character_gbuff";

			// Token: 0x04014757 RID: 83799
			[Token(Token = "0x4014757")]
			public const string DISABLE_TRAP_GBUFF = "disable_trap_gbuff";

			// Token: 0x04014758 RID: 83800
			[Token(Token = "0x4014758")]
			public const string DISABLE_ENEMY_GBUFF = "disable_enemy_gbuff";

			// Token: 0x04014759 RID: 83801
			[Token(Token = "0x4014759")]
			public const string ENABLE_NORMAL_ENEMY_WHEN_RUSH = "enable_normal_enemy_when_rush";

			// Token: 0x0401475A RID: 83802
			[Token(Token = "0x401475A")]
			public const string CONSTRUCT_VIEW_SCALE = "construct_view_scale";
		}

		// Token: 0x02002A86 RID: 10886
		[Token(Token = "0x2002A86")]
		public static class BlackboardKeys
		{
			// Token: 0x0401475B RID: 83803
			[Token(Token = "0x401475B")]
			public const string STOCK_CNT = "stock_cnt";

			// Token: 0x0401475C RID: 83804
			[Token(Token = "0x401475C")]
			public const string RECORD_HP_RATIO = "record_hp_ratio";

			// Token: 0x0401475D RID: 83805
			[Token(Token = "0x401475D")]
			public const string RECORD_DEAD = "record_dead";

			// Token: 0x0401475E RID: 83806
			[Token(Token = "0x401475E")]
			public const string RECORD_RES_TRAP = "record_res_trap";

			// Token: 0x0401475F RID: 83807
			[Token(Token = "0x401475F")]
			public const string RECORD_MODE = "record_mode";

			// Token: 0x04014760 RID: 83808
			[Token(Token = "0x4014760")]
			public const string MULTIPLIER = "multiplier";
		}
	}
}
