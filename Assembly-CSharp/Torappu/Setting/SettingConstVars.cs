using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Setting
{
	// Token: 0x02001E0D RID: 7693
	[Token(Token = "0x2001E0D")]
	public class SettingConstVars
	{
		// Token: 0x0600BDE0 RID: 48608 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BDE0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SettingConstVars()
		{
		}

		// Token: 0x0400BE9F RID: 48799
		[Token(Token = "0x400BE9F")]
		public const string PERSONAL_SETTING = "{0}_personal_setting";

		// Token: 0x0400BEA0 RID: 48800
		[Token(Token = "0x400BEA0")]
		public const string COMMON_SETTING = "common_setting";

		// Token: 0x0400BEA1 RID: 48801
		[Token(Token = "0x400BEA1")]
		public const string HOTUPDATE_PREFERENCE = "key_hotupdate_preference";

		// Token: 0x0400BEA2 RID: 48802
		[Token(Token = "0x400BEA2")]
		public const string HOTUPDATE_RES_SETTING = "key_hotupdate_res_setting";

		// Token: 0x0400BEA3 RID: 48803
		[Token(Token = "0x400BEA3")]
		public const string HOTUPDATE_VOICE_PACK_FLAG = "key_hotupdate_voice_pack_flag";

		// Token: 0x0400BEA4 RID: 48804
		[Token(Token = "0x400BEA4")]
		public const string BUTTON_ANIM = "button";

		// Token: 0x0400BEA5 RID: 48805
		[Token(Token = "0x400BEA5")]
		public const string TAB_ANIM = "tab";

		// Token: 0x0400BEA6 RID: 48806
		[Token(Token = "0x400BEA6")]
		public const string AVAILABLE_ANIM = "available";

		// Token: 0x0400BEA7 RID: 48807
		[Token(Token = "0x400BEA7")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Dictionary<int, string> FLOAT_SHOW_PARAM;

		// Token: 0x02001E0E RID: 7694
		[Token(Token = "0x2001E0E")]
		public enum SettingType
		{
			// Token: 0x0400BEA9 RID: 48809
			[Token(Token = "0x400BEA9")]
			ALL,
			// Token: 0x0400BEAA RID: 48810
			[Token(Token = "0x400BEAA")]
			NONE,
			// Token: 0x0400BEAB RID: 48811
			[Token(Token = "0x400BEAB")]
			MUSIC_VOLUMN,
			// Token: 0x0400BEAC RID: 48812
			[Token(Token = "0x400BEAC")]
			SE_VOLUMN,
			// Token: 0x0400BEAD RID: 48813
			[Token(Token = "0x400BEAD")]
			MUSIC_FLAG,
			// Token: 0x0400BEAE RID: 48814
			[Token(Token = "0x400BEAE")]
			SE_FLAG,
			// Token: 0x0400BEAF RID: 48815
			[Token(Token = "0x400BEAF")]
			LIMIT_FPS,
			// Token: 0x0400BEB0 RID: 48816
			[Token(Token = "0x400BEB0")]
			BATTLE_ROLLBACK_SPEED,
			// Token: 0x0400BEB1 RID: 48817
			[Token(Token = "0x400BEB1")]
			VOICE_VOLUMN,
			// Token: 0x0400BEB2 RID: 48818
			[Token(Token = "0x400BEB2")]
			VOICE_FLAG,
			// Token: 0x0400BEB3 RID: 48819
			[Token(Token = "0x400BEB3")]
			BUILDING_BLOOM_FLAG,
			// Token: 0x0400BEB4 RID: 48820
			[Token(Token = "0x400BEB4")]
			BUILDING_CHAR_TIRED,
			// Token: 0x0400BEB5 RID: 48821
			[Token(Token = "0x400BEB5")]
			BUILDING_TRADE_FINISH,
			// Token: 0x0400BEB6 RID: 48822
			[Token(Token = "0x400BEB6")]
			BUILDING_MANUF_FINISH,
			// Token: 0x0400BEB7 RID: 48823
			[Token(Token = "0x400BEB7")]
			BUILDING_EXIT,
			// Token: 0x0400BEB8 RID: 48824
			[Token(Token = "0x400BEB8")]
			NOTCH_PADDING,
			// Token: 0x0400BEB9 RID: 48825
			[Token(Token = "0x400BEB9")]
			BATTLE_CANCEL_DIRECTION_SELECT_HINT_FLAG,
			// Token: 0x0400BEBA RID: 48826
			[Token(Token = "0x400BEBA")]
			BUILDING_MANUF_AUTO,
			// Token: 0x0400BEBB RID: 48827
			[Token(Token = "0x400BEBB")]
			DYNAMIC_ILLUST_LOAD_STRATEGY,
			// Token: 0x0400BEBC RID: 48828
			[Token(Token = "0x400BEBC")]
			AVG_SKIP_DECISION,
			// Token: 0x0400BEBD RID: 48829
			[Token(Token = "0x400BEBD")]
			PERFORMANCE_RATE,
			// Token: 0x0400BEBE RID: 48830
			[Token(Token = "0x400BEBE")]
			FPS_STRATEGY,
			// Token: 0x0400BEBF RID: 48831
			[Token(Token = "0x400BEBF")]
			POWER_SAVING_FLAG,
			// Token: 0x0400BEC0 RID: 48832
			[Token(Token = "0x400BEC0")]
			DYN_ENTRANCE,
			// Token: 0x0400BEC1 RID: 48833
			[Token(Token = "0x400BEC1")]
			DYN_ENTRANCE_LOGIN_STRATEGY,
			// Token: 0x0400BEC2 RID: 48834
			[Token(Token = "0x400BEC2")]
			ANTIALIASING_FLAG,
			// Token: 0x0400BEC3 RID: 48835
			[Token(Token = "0x400BEC3")]
			CHAR_ROTATION_UPDATE,
			// Token: 0x0400BEC4 RID: 48836
			[Token(Token = "0x400BEC4")]
			BUILDING_BATCH_NOTIFY,
			// Token: 0x0400BEC5 RID: 48837
			[Token(Token = "0x400BEC5")]
			BATTLE_KEY_DISPLAY,
			// Token: 0x0400BEC6 RID: 48838
			[Token(Token = "0x400BEC6")]
			RESOLUTION,
			// Token: 0x0400BEC7 RID: 48839
			[Token(Token = "0x400BEC7")]
			UI_SCALER,
			// Token: 0x0400BEC8 RID: 48840
			[Token(Token = "0x400BEC8")]
			NO_BGM_WHEN_HIDE,
			// Token: 0x0400BEC9 RID: 48841
			[Token(Token = "0x400BEC9")]
			VSYNC_SETTING,
			// Token: 0x0400BECA RID: 48842
			[Token(Token = "0x400BECA")]
			CURSOR_SIZE
		}

		// Token: 0x02001E0F RID: 7695
		[Token(Token = "0x2001E0F")]
		public enum InstantFlag
		{
			// Token: 0x0400BECC RID: 48844
			[Token(Token = "0x400BECC")]
			INSTANT,
			// Token: 0x0400BECD RID: 48845
			[Token(Token = "0x400BECD")]
			DELAY
		}

		// Token: 0x02001E10 RID: 7696
		[Token(Token = "0x2001E10")]
		public enum DataType
		{
			// Token: 0x0400BECF RID: 48847
			[Token(Token = "0x400BECF")]
			BOOL,
			// Token: 0x0400BED0 RID: 48848
			[Token(Token = "0x400BED0")]
			SLIDER,
			// Token: 0x0400BED1 RID: 48849
			[Token(Token = "0x400BED1")]
			STATE,
			// Token: 0x0400BED2 RID: 48850
			[Token(Token = "0x400BED2")]
			CUSTOM
		}

		// Token: 0x02001E11 RID: 7697
		[Token(Token = "0x2001E11")]
		public enum IllustStyleWhenFocusChar
		{
			// Token: 0x0400BED4 RID: 48852
			[Token(Token = "0x400BED4")]
			FULL,
			// Token: 0x0400BED5 RID: 48853
			[Token(Token = "0x400BED5")]
			TRANSPARENT,
			// Token: 0x0400BED6 RID: 48854
			[Token(Token = "0x400BED6")]
			HIDDEN
		}
	}
}
