using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x020020C7 RID: 8391
	[Token(Token = "0x20020C7")]
	public enum BattleEvent
	{
		// Token: 0x0400DA8A RID: 55946
		[Token(Token = "0x400DA8A")]
		ON_GAME_READY,
		// Token: 0x0400DA8B RID: 55947
		[Token(Token = "0x400DA8B")]
		ON_GAME_PRE_START,
		// Token: 0x0400DA8C RID: 55948
		[Token(Token = "0x400DA8C")]
		ON_GAME_START,
		// Token: 0x0400DA8D RID: 55949
		[Token(Token = "0x400DA8D")]
		ON_GAME_OVER,
		// Token: 0x0400DA8E RID: 55950
		[Token(Token = "0x400DA8E")]
		ON_UNIT_POST_BORN,
		// Token: 0x0400DA8F RID: 55951
		[Token(Token = "0x400DA8F")]
		ON_UNIT_BORN,
		// Token: 0x0400DA90 RID: 55952
		[Token(Token = "0x400DA90")]
		ON_UNIT_FINISH,
		// Token: 0x0400DA91 RID: 55953
		[Token(Token = "0x400DA91")]
		ON_ENEMY_REACHED_EXIT,
		// Token: 0x0400DA92 RID: 55954
		[Token(Token = "0x400DA92")]
		ON_ENEMY_RECYCLED,
		// Token: 0x0400DA93 RID: 55955
		[Token(Token = "0x400DA93")]
		ON_BOSS_ENTER,
		// Token: 0x0400DA94 RID: 55956
		[Token(Token = "0x400DA94")]
		ON_GIANTBOSS_HUD_USED,
		// Token: 0x0400DA95 RID: 55957
		[Token(Token = "0x400DA95")]
		ON_CHARACTER_LOCATE,
		// Token: 0x0400DA96 RID: 55958
		[Token(Token = "0x400DA96")]
		ON_BEFORE_APPLYING_MODIFIER,
		// Token: 0x0400DA97 RID: 55959
		[Token(Token = "0x400DA97")]
		ON_APPLYING_MODIFIER,
		// Token: 0x0400DA98 RID: 55960
		[Token(Token = "0x400DA98")]
		ON_APPLIED_MODIFIER,
		// Token: 0x0400DA99 RID: 55961
		[Token(Token = "0x400DA99")]
		ON_ABILITY_CASTED,
		// Token: 0x0400DA9A RID: 55962
		[Token(Token = "0x400DA9A")]
		ON_STATE_CHANGED,
		// Token: 0x0400DA9B RID: 55963
		[Token(Token = "0x400DA9B")]
		ON_PAUSE_TOGGLED,
		// Token: 0x0400DA9C RID: 55964
		[Token(Token = "0x400DA9C")]
		ON_AUTO_REPLAY_TOGGLED,
		// Token: 0x0400DA9D RID: 55965
		[Token(Token = "0x400DA9D")]
		ON_AUTO_REPLAY_FINISHED,
		// Token: 0x0400DA9E RID: 55966
		[Token(Token = "0x400DA9E")]
		ON_SPEED_LEVEL_CHANGED,
		// Token: 0x0400DA9F RID: 55967
		[Token(Token = "0x400DA9F")]
		ON_PREDEFINED_LOCATION_REACHED,
		// Token: 0x0400DAA0 RID: 55968
		[Token(Token = "0x400DAA0")]
		ON_DISPLAY_ENEMY_INFO,
		// Token: 0x0400DAA1 RID: 55969
		[Token(Token = "0x400DAA1")]
		ON_BLOCK_ANY_ROUTES,
		// Token: 0x0400DAA2 RID: 55970
		[Token(Token = "0x400DAA2")]
		ON_PREVIEW_CURSOR_SPAWND,
		// Token: 0x0400DAA3 RID: 55971
		[Token(Token = "0x400DAA3")]
		ON_SKILL_CASTED,
		// Token: 0x0400DAA4 RID: 55972
		[Token(Token = "0x400DAA4")]
		ON_CHARACTER_ATK_OR_CBT,
		// Token: 0x0400DAA5 RID: 55973
		[Token(Token = "0x400DAA5")]
		ON_ACTIVATE_INTERNAL_HIDDEN_CARD,
		// Token: 0x0400DAA6 RID: 55974
		[Token(Token = "0x400DAA6")]
		ON_RALLYPOINT_REBORN,
		// Token: 0x0400DAA7 RID: 55975
		[Token(Token = "0x400DAA7")]
		ON_RALLYPOINT_DEAD,
		// Token: 0x0400DAA8 RID: 55976
		[Token(Token = "0x400DAA8")]
		ON_RALLYPOINTLIKE_SWITCH,
		// Token: 0x0400DAA9 RID: 55977
		[Token(Token = "0x400DAA9")]
		ON_SNAP_SHOT,
		// Token: 0x0400DAAA RID: 55978
		[Token(Token = "0x400DAAA")]
		ON_PLAYER_OPERATION,
		// Token: 0x0400DAAB RID: 55979
		[Token(Token = "0x400DAAB")]
		ON_GAME_GIVE_UP,
		// Token: 0x0400DAAC RID: 55980
		[Token(Token = "0x400DAAC")]
		ON_LIFE_POINT_CHANGED,
		// Token: 0x0400DAAD RID: 55981
		[Token(Token = "0x400DAAD")]
		ON_UNIT_SWITCH_SIDE,
		// Token: 0x0400DAAE RID: 55982
		[Token(Token = "0x400DAAE")]
		ON_UNIT_REPLACED,
		// Token: 0x0400DAAF RID: 55983
		[Token(Token = "0x400DAAF")]
		ON_WAVE_WILL_FINISH,
		// Token: 0x0400DAB0 RID: 55984
		[Token(Token = "0x400DAB0")]
		ON_SPECIAL_UI_TRIGGER,
		// Token: 0x0400DAB1 RID: 55985
		[Token(Token = "0x400DAB1")]
		ON_DISPLAY_LEGION_BLAST_CARD,
		// Token: 0x0400DAB2 RID: 55986
		[Token(Token = "0x400DAB2")]
		ON_DISPLAY_DECK_BUFF_EFFECT,
		// Token: 0x0400DAB3 RID: 55987
		[Token(Token = "0x400DAB3")]
		ON_DIALOGUE_START,
		// Token: 0x0400DAB4 RID: 55988
		[Token(Token = "0x400DAB4")]
		ON_ATTACK_RANGE_UPDATED,
		// Token: 0x0400DAB5 RID: 55989
		[Token(Token = "0x400DAB5")]
		ON_UNIT_REBORN,
		// Token: 0x0400DAB6 RID: 55990
		[Token(Token = "0x400DAB6")]
		ON_WAVE_WILL_START,
		// Token: 0x0400DAB7 RID: 55991
		[Token(Token = "0x400DAB7")]
		ON_DUMMY_LOCATE,
		// Token: 0x0400DAB8 RID: 55992
		[Token(Token = "0x400DAB8")]
		ON_COOPERATE_LEVEL_UP,
		// Token: 0x0400DAB9 RID: 55993
		[Token(Token = "0x400DAB9")]
		ON_COOPERATE_PLAYER_LIFE_TO_ZERO,
		// Token: 0x0400DABA RID: 55994
		[Token(Token = "0x400DABA")]
		ON_COOPERATE_PLAYER_REVIVE,
		// Token: 0x0400DABB RID: 55995
		[Token(Token = "0x400DABB")]
		ON_BATTLE_CTRL_DISPOSE,
		// Token: 0x0400DABC RID: 55996
		[Token(Token = "0x400DABC")]
		ON_DECK_CREATED,
		// Token: 0x0400DABD RID: 55997
		[Token(Token = "0x400DABD")]
		ON_GAMECITY_SCORE_CHANGE,
		// Token: 0x0400DABE RID: 55998
		[Token(Token = "0x400DABE")]
		ON_BEFORE_LEVEL_ACTION_EXECUTE,
		// Token: 0x0400DABF RID: 55999
		[Token(Token = "0x400DABF")]
		ON_AMMO_CONSUME,
		// Token: 0x0400DAC0 RID: 56000
		[Token(Token = "0x400DAC0")]
		ON_TILE_CLICKED,
		// Token: 0x0400DAC1 RID: 56001
		[Token(Token = "0x400DAC1")]
		ON_CHAR_MENU_ENTER,
		// Token: 0x0400DAC2 RID: 56002
		[Token(Token = "0x400DAC2")]
		ON_CHAR_MENU_EXIT,
		// Token: 0x0400DAC3 RID: 56003
		[Token(Token = "0x400DAC3")]
		ON_TILE_HIGHLIGHT_CHANGED,
		// Token: 0x0400DAC4 RID: 56004
		[Token(Token = "0x400DAC4")]
		ON_CHARACTER_DYING,
		// Token: 0x0400DAC5 RID: 56005
		[Token(Token = "0x400DAC5")]
		ON_TRAP_POST_FINISH,
		// Token: 0x0400DAC6 RID: 56006
		[Token(Token = "0x400DAC6")]
		ON_TILE_LISTENER_REMOVED
	}
}
