using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000E74 RID: 3700
	[Token(Token = "0x2000E74")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ActivityType
	{
		// Token: 0x04004D81 RID: 19841
		[Token(Token = "0x4004D81")]
		DEFAULT,
		// Token: 0x04004D82 RID: 19842
		[Token(Token = "0x4004D82")]
		MISSION_ONLY,
		// Token: 0x04004D83 RID: 19843
		[Token(Token = "0x4004D83")]
		CHECKIN_ONLY,
		// Token: 0x04004D84 RID: 19844
		[Token(Token = "0x4004D84")]
		CHECKIN_ALL_PLAYER,
		// Token: 0x04004D85 RID: 19845
		[Token(Token = "0x4004D85")]
		TYPE_ACT3D0,
		// Token: 0x04004D86 RID: 19846
		[Token(Token = "0x4004D86")]
		TYPE_ACT4D0,
		// Token: 0x04004D87 RID: 19847
		[Token(Token = "0x4004D87")]
		TYPE_ACT5D0,
		// Token: 0x04004D88 RID: 19848
		[Token(Token = "0x4004D88")]
		TYPE_ACT5D1,
		// Token: 0x04004D89 RID: 19849
		[Token(Token = "0x4004D89")]
		COLLECTION,
		// Token: 0x04004D8A RID: 19850
		[Token(Token = "0x4004D8A")]
		AVG_ONLY,
		// Token: 0x04004D8B RID: 19851
		[Token(Token = "0x4004D8B")]
		TYPE_ACT9D0,
		// Token: 0x04004D8C RID: 19852
		[Token(Token = "0x4004D8C")]
		TYPE_ACT12SIDE,
		// Token: 0x04004D8D RID: 19853
		[Token(Token = "0x4004D8D")]
		TYPE_ACT13SIDE,
		// Token: 0x04004D8E RID: 19854
		[Token(Token = "0x4004D8E")]
		TYPE_ACT17SIDE,
		// Token: 0x04004D8F RID: 19855
		[Token(Token = "0x4004D8F")]
		LOGIN_ONLY,
		// Token: 0x04004D90 RID: 19856
		[Token(Token = "0x4004D90")]
		MINISTORY,
		// Token: 0x04004D91 RID: 19857
		[Token(Token = "0x4004D91")]
		ROGUELIKE,
		// Token: 0x04004D92 RID: 19858
		[Token(Token = "0x4004D92")]
		PRAY_ONLY,
		// Token: 0x04004D93 RID: 19859
		[Token(Token = "0x4004D93")]
		MULTIPLAY,
		// Token: 0x04004D94 RID: 19860
		[Token(Token = "0x4004D94")]
		MULTIPLAY_VERIFY2,
		// Token: 0x04004D95 RID: 19861
		[Token(Token = "0x4004D95")]
		TYPE_ACT17D7,
		// Token: 0x04004D96 RID: 19862
		[Token(Token = "0x4004D96")]
		GRID_GACHA,
		// Token: 0x04004D97 RID: 19863
		[Token(Token = "0x4004D97")]
		GRID_GACHA_V2,
		// Token: 0x04004D98 RID: 19864
		[Token(Token = "0x4004D98")]
		INTERLOCK,
		// Token: 0x04004D99 RID: 19865
		[Token(Token = "0x4004D99")]
		APRIL_FOOL,
		// Token: 0x04004D9A RID: 19866
		[Token(Token = "0x4004D9A")]
		BOSS_RUSH,
		// Token: 0x04004D9B RID: 19867
		[Token(Token = "0x4004D9B")]
		TYPE_ACT20SIDE,
		// Token: 0x04004D9C RID: 19868
		[Token(Token = "0x4004D9C")]
		FLOAT_PARADE,
		// Token: 0x04004D9D RID: 19869
		[Token(Token = "0x4004D9D")]
		TYPE_ACT21SIDE,
		// Token: 0x04004D9E RID: 19870
		[Token(Token = "0x4004D9E")]
		MAIN_BUFF,
		// Token: 0x04004D9F RID: 19871
		[Token(Token = "0x4004D9F")]
		TYPE_ACT24SIDE,
		// Token: 0x04004DA0 RID: 19872
		[Token(Token = "0x4004DA0")]
		FLIP_ONLY,
		// Token: 0x04004DA1 RID: 19873
		[Token(Token = "0x4004DA1")]
		TYPE_ACT25SIDE,
		// Token: 0x04004DA2 RID: 19874
		[Token(Token = "0x4004DA2")]
		CHECKIN_VS,
		// Token: 0x04004DA3 RID: 19875
		[Token(Token = "0x4004DA3")]
		SWITCH_ONLY,
		// Token: 0x04004DA4 RID: 19876
		[Token(Token = "0x4004DA4")]
		TYPE_ACT27SIDE,
		// Token: 0x04004DA5 RID: 19877
		[Token(Token = "0x4004DA5")]
		UNIQUE_ONLY,
		// Token: 0x04004DA6 RID: 19878
		[Token(Token = "0x4004DA6")]
		MAINLINE_BP,
		// Token: 0x04004DA7 RID: 19879
		[Token(Token = "0x4004DA7")]
		TYPE_ACT42D0,
		// Token: 0x04004DA8 RID: 19880
		[Token(Token = "0x4004DA8")]
		TYPE_ACT29SIDE,
		// Token: 0x04004DA9 RID: 19881
		[Token(Token = "0x4004DA9")]
		BLESS_ONLY,
		// Token: 0x04004DAA RID: 19882
		[Token(Token = "0x4004DAA")]
		CHECKIN_ACCESS,
		// Token: 0x04004DAB RID: 19883
		[Token(Token = "0x4004DAB")]
		YEAR_5_GENERAL,
		// Token: 0x04004DAC RID: 19884
		[Token(Token = "0x4004DAC")]
		TYPE_ACT35SIDE,
		// Token: 0x04004DAD RID: 19885
		[Token(Token = "0x4004DAD")]
		VEC_BREAK,
		// Token: 0x04004DAE RID: 19886
		[Token(Token = "0x4004DAE")]
		TYPE_ACT36SIDE,
		// Token: 0x04004DAF RID: 19887
		[Token(Token = "0x4004DAF")]
		TYPE_ACT38SIDE,
		// Token: 0x04004DB0 RID: 19888
		[Token(Token = "0x4004DB0")]
		AUTOCHESS_VERIFY1,
		// Token: 0x04004DB1 RID: 19889
		[Token(Token = "0x4004DB1")]
		CHECKIN_VIDEO,
		// Token: 0x04004DB2 RID: 19890
		[Token(Token = "0x4004DB2")]
		ARCADE,
		// Token: 0x04004DB3 RID: 19891
		[Token(Token = "0x4004DB3")]
		MULTIPLAY_V3,
		// Token: 0x04004DB4 RID: 19892
		[Token(Token = "0x4004DB4")]
		TYPE_MAINSS,
		// Token: 0x04004DB5 RID: 19893
		[Token(Token = "0x4004DB5")]
		ENEMY_DUEL,
		// Token: 0x04004DB6 RID: 19894
		[Token(Token = "0x4004DB6")]
		VEC_BREAK_V2,
		// Token: 0x04004DB7 RID: 19895
		[Token(Token = "0x4004DB7")]
		TYPE_ACT42SIDE,
		// Token: 0x04004DB8 RID: 19896
		[Token(Token = "0x4004DB8")]
		TYPE_ACT44SIDE,
		// Token: 0x04004DB9 RID: 19897
		[Token(Token = "0x4004DB9")]
		HALFIDLE_VERIFY1,
		// Token: 0x04004DBA RID: 19898
		[Token(Token = "0x4004DBA")]
		TYPE_ACT45SIDE,
		// Token: 0x04004DBB RID: 19899
		[Token(Token = "0x4004DBB")]
		TEAM_QUEST,
		// Token: 0x04004DBC RID: 19900
		[Token(Token = "0x4004DBC")]
		RECRUIT_ONLY,
		// Token: 0x04004DBD RID: 19901
		[Token(Token = "0x4004DBD")]
		TYPE_ACT46SIDE,
		// Token: 0x04004DBE RID: 19902
		[Token(Token = "0x4004DBE")]
		AUTOCHESS_SEASON,
		// Token: 0x04004DBF RID: 19903
		[Token(Token = "0x4004DBF")]
		ENUM
	}
}
