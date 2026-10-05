using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002168 RID: 8552
	[Token(Token = "0x2002168")]
	[Hotfix(HotfixFlag.Stateless)]
	[LuaCallCSharp(GenFlag.No)]
	public static class AudioSignals
	{
		// Token: 0x0400E0ED RID: 57581
		[Token(Token = "0x400E0ED")]
		public const string ON_GAME_READY = "ON_GAME_READY";

		// Token: 0x0400E0EE RID: 57582
		[Token(Token = "0x400E0EE")]
		public const string ON_GAME_OVER = "ON_GAME_OVER";

		// Token: 0x0400E0EF RID: 57583
		[Token(Token = "0x400E0EF")]
		public const string ON_CUSTOM_TRIGGER = "ON_CUSTOM_TRIGGER";

		// Token: 0x0400E0F0 RID: 57584
		[Token(Token = "0x400E0F0")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string[] SIGNALS_WITH_BUFF;

		// Token: 0x0400E0F1 RID: 57585
		[Token(Token = "0x400E0F1")]
		public const string ON_BUFF_START = "ON_BUFF_START";

		// Token: 0x0400E0F2 RID: 57586
		[Token(Token = "0x400E0F2")]
		public const string ON_BUFF_TRIGGER = "ON_BUFF_TRIGGER";

		// Token: 0x0400E0F3 RID: 57587
		[Token(Token = "0x400E0F3")]
		public const string ON_BUFF_FINISH = "ON_BUFF_FINISH";

		// Token: 0x0400E0F4 RID: 57588
		[Token(Token = "0x400E0F4")]
		public const string ON_BUFF_SHOW_EFFECT = "ON_BUFF_SHOW_EFFECT";

		// Token: 0x0400E0F5 RID: 57589
		[Token(Token = "0x400E0F5")]
		[FieldOffset(Offset = "0x8")]
		public static readonly string[] SIGNALS_WITH_NO_SUBSIGNAL;

		// Token: 0x0400E0F6 RID: 57590
		[Token(Token = "0x400E0F6")]
		public const string ON_GAME_START = "ON_GAME_START";

		// Token: 0x0400E0F7 RID: 57591
		[Token(Token = "0x400E0F7")]
		public const string ON_GAME_RESTART = "ON_GAME_RESTART";

		// Token: 0x0400E0F8 RID: 57592
		[Token(Token = "0x400E0F8")]
		public const string ON_MODIFIER_HEAL = "ON_MODIFIER_HEAL";

		// Token: 0x0400E0F9 RID: 57593
		[Token(Token = "0x400E0F9")]
		public const string ON_BATTLE_UI_CARD_ANIM_FORMATED = "ON_BATTLE_UI_CARD_ANIM_{0}";

		// Token: 0x0400E0FA RID: 57594
		[Token(Token = "0x400E0FA")]
		public const string ON_MODIFIER_COST = "ON_MODIFIER_COST";

		// Token: 0x0400E0FB RID: 57595
		[Token(Token = "0x400E0FB")]
		public const string ON_SKILL_RETRIGGER_MODIFIER_COST = "ON_SKILL_RETRIGGER_MODIFIER_COST";

		// Token: 0x0400E0FC RID: 57596
		[Token(Token = "0x400E0FC")]
		public const string ON_MODIFIER_MAX_COST = "ON_MODIFIER_MAX_COST";

		// Token: 0x0400E0FD RID: 57597
		[Token(Token = "0x400E0FD")]
		public const string ON_MODIFIER_CHAR_LIMIT = "ON_MODIFIER_CHAR_LIMIT";

		// Token: 0x0400E0FE RID: 57598
		[Token(Token = "0x400E0FE")]
		public const string ON_MODIFIER_LIFE_POINT = "ON_MODIFIER_LIFE_POINT";

		// Token: 0x0400E0FF RID: 57599
		[Token(Token = "0x400E0FF")]
		public const string ON_BOSS_ENTER = "ON_BOSS_ENTER";

		// Token: 0x0400E100 RID: 57600
		[Token(Token = "0x400E100")]
		public const string ON_ENEMY_REACHED_EXIT = "ON_ENEMY_REACHED_EXIT";

		// Token: 0x0400E101 RID: 57601
		[Token(Token = "0x400E101")]
		public const string ON_DAMAGE_BLOCK = "ON_DAMAGE_BLOCK";

		// Token: 0x0400E102 RID: 57602
		[Token(Token = "0x400E102")]
		public const string ON_PREDEFINED_LOCATION = "ON_PREDEFINED_LOCATION";

		// Token: 0x0400E103 RID: 57603
		[Token(Token = "0x400E103")]
		public const string ON_ENV_SHOW = "ON_ENV_SHOW";

		// Token: 0x0400E104 RID: 57604
		[Token(Token = "0x400E104")]
		public const string ON_ENEMY_ALERT = "ON_ENEMY_ALERT";

		// Token: 0x0400E105 RID: 57605
		[Token(Token = "0x400E105")]
		public const string ON_PIN_MARK = "ON_PIN_MARK";

		// Token: 0x0400E106 RID: 57606
		[Token(Token = "0x400E106")]
		public const string ON_ENVSYS_TRIGGER_TILE = "ON_ENVSYS_TRIGGER_TILE";

		// Token: 0x0400E107 RID: 57607
		[Token(Token = "0x400E107")]
		[FieldOffset(Offset = "0x10")]
		public static readonly string[] SIGNALS_WITH_UNIT_CATEGORY;

		// Token: 0x0400E108 RID: 57608
		[Token(Token = "0x400E108")]
		public const string ON_UNIT_BORN = "ON_UNIT_BORN";

		// Token: 0x0400E109 RID: 57609
		[Token(Token = "0x400E109")]
		public const string ON_UNIT_DEAD = "ON_UNIT_DEAD";

		// Token: 0x0400E10A RID: 57610
		[Token(Token = "0x400E10A")]
		public const string ON_CHARACTER_WITHDRAW = "ON_CHARACTER_WITHDRAW";

		// Token: 0x0400E10B RID: 57611
		[Token(Token = "0x400E10B")]
		public const string ON_CHARACTER_LOCATE = "ON_CHARACTER_LOCATE";

		// Token: 0x0400E10C RID: 57612
		[Token(Token = "0x400E10C")]
		[FieldOffset(Offset = "0x18")]
		public static readonly string[] SIGNALS_WITH_ABILITY_ID;

		// Token: 0x0400E10D RID: 57613
		[Token(Token = "0x400E10D")]
		public const string ON_ABILITY_HIT = "ON_ABILITY_HIT";

		// Token: 0x0400E10E RID: 57614
		[Token(Token = "0x400E10E")]
		public const string ON_ABILITY_ON = "ON_ABILITY_ON";

		// Token: 0x0400E10F RID: 57615
		[Token(Token = "0x400E10F")]
		public const string ON_ABILITY_START = "ON_ABILITY_START";

		// Token: 0x0400E110 RID: 57616
		[Token(Token = "0x400E110")]
		public const string ON_ABILITY_ATTACK_FINISH = "ON_ABILITY_ATTACK_FINISH";

		// Token: 0x0400E111 RID: 57617
		[Token(Token = "0x400E111")]
		public const string ON_ABILITY_END = "ON_ABILITY_END";

		// Token: 0x0400E112 RID: 57618
		[Token(Token = "0x400E112")]
		public const string ON_ABILITY_CHECK_POINT = "ON_ABILITY_CHECK_POINT";

		// Token: 0x0400E113 RID: 57619
		[Token(Token = "0x400E113")]
		[FieldOffset(Offset = "0x20")]
		public static readonly string[] SIGNALS_WITH_SKILL_ID;

		// Token: 0x0400E114 RID: 57620
		[Token(Token = "0x400E114")]
		public const string ON_SKILL_START = "ON_SKILL_START";

		// Token: 0x0400E115 RID: 57621
		[Token(Token = "0x400E115")]
		public const string ON_SKILL_FINISH = "ON_SKILL_FINISH";

		// Token: 0x0400E116 RID: 57622
		[Token(Token = "0x400E116")]
		public const string ON_SKILL_FAILED = "ON_SKILL_FAILED";

		// Token: 0x0400E117 RID: 57623
		[Token(Token = "0x400E117")]
		public const string ON_SKILL_SPECIAL_POINT = "ON_SKILL_SPECIAL_POINT";

		// Token: 0x0400E118 RID: 57624
		[Token(Token = "0x400E118")]
		public const string ON_SKILL_SPECIAL_POINT_2 = "ON_SKILL_SPECIAL_POINT_2";

		// Token: 0x0400E119 RID: 57625
		[Token(Token = "0x400E119")]
		public const string ON_SKILL_CHANT_START = "ON_SKILL_CHANT_START";

		// Token: 0x0400E11A RID: 57626
		[Token(Token = "0x400E11A")]
		[FieldOffset(Offset = "0x28")]
		public static readonly string[] SIGNALS_WITH_PROJECTILE_ID;

		// Token: 0x0400E11B RID: 57627
		[Token(Token = "0x400E11B")]
		public const string ON_PROJECTILE_BORN = "ON_PROJECTILE_BORN";

		// Token: 0x0400E11C RID: 57628
		[Token(Token = "0x400E11C")]
		public const string ON_PROJECTILE_HIT = "ON_PROJECTILE_HIT";

		// Token: 0x0400E11D RID: 57629
		[Token(Token = "0x400E11D")]
		public const string ON_PROJECTILE_REACH = "ON_PROJECTILE_REACH";

		// Token: 0x0400E11E RID: 57630
		[Token(Token = "0x400E11E")]
		public const string ON_PROJECTILE_STOP = "ON_PROJECTILE_STOP";

		// Token: 0x0400E11F RID: 57631
		[Token(Token = "0x400E11F")]
		public const string ON_PROJECTILE_BEHAVIOUR_TRIGGER = "ON_PROJECTILE_BEHAVIOUR_TRIGGER";

		// Token: 0x0400E120 RID: 57632
		[Token(Token = "0x400E120")]
		public const string ON_TILE_TRIGGER = "ON_TILE_TRIGGER";

		// Token: 0x0400E121 RID: 57633
		[Token(Token = "0x400E121")]
		public const string ON_SPINE_EVENT_TRIGGER = "ON_SPINE_EVENT_TRIGGER";

		// Token: 0x0400E122 RID: 57634
		[Token(Token = "0x400E122")]
		public const string UNIT_CATEGORY_CHAR = "char";

		// Token: 0x0400E123 RID: 57635
		[Token(Token = "0x400E123")]
		public const string UNIT_CATEGORY_TOKEN = "token";

		// Token: 0x0400E124 RID: 57636
		[Token(Token = "0x400E124")]
		public const string UNIT_CATEGORY_ENEMY = "enemy";

		// Token: 0x0400E125 RID: 57637
		[Token(Token = "0x400E125")]
		public const string ON_OPERA_TRIGGER = "ON_OPERA_TRIGGER";

		// Token: 0x0400E126 RID: 57638
		[Token(Token = "0x400E126")]
		public const string ON_TALENT_TRIGGER = "ON_TALENT_TRIGGER";

		// Token: 0x0400E127 RID: 57639
		[Token(Token = "0x400E127")]
		public const string SPARE_SHOT = "SPARE_SHOT";

		// Token: 0x0400E128 RID: 57640
		[Token(Token = "0x400E128")]
		public const string LARGE_MAP = "large_map";

		// Token: 0x0400E129 RID: 57641
		[Token(Token = "0x400E129")]
		public const string ON_BAVG_ANIM = "ON_BAVG_ANIM";

		// Token: 0x0400E12A RID: 57642
		[Token(Token = "0x400E12A")]
		public const string ON_BAVG_EFF_START = "ON_BAVG_EFF_START";

		// Token: 0x0400E12B RID: 57643
		[Token(Token = "0x400E12B")]
		public const string ON_BAVG_EFF_FINISH = "ON_BAVG_EFF_FINISH";

		// Token: 0x0400E12C RID: 57644
		[Token(Token = "0x400E12C")]
		public const string ON_POPUP = "ON_POPUP";

		// Token: 0x0400E12D RID: 57645
		[Token(Token = "0x400E12D")]
		public const string ON_ENEMY_LEVELUP = "ON_ENEMY_LEVELUP";

		// Token: 0x0400E12E RID: 57646
		[Token(Token = "0x400E12E")]
		public const string ON_STRIFE_NEXT_WAVE = "ON_STRIFE_NEXT_WAVE";

		// Token: 0x0400E12F RID: 57647
		[Token(Token = "0x400E12F")]
		public const string ON_STRIFE_LAST_WAVE = "ON_STRIFE_LAST_WAVE";

		// Token: 0x0400E130 RID: 57648
		[Token(Token = "0x400E130")]
		public const string ACT5FUN_START = "ON_ACT5FUN_START";

		// Token: 0x0400E131 RID: 57649
		[Token(Token = "0x400E131")]
		public const string ACT5FUN_ROUND = "ON_ACT5FUN_ROUND";

		// Token: 0x0400E132 RID: 57650
		[Token(Token = "0x400E132")]
		public const string ACT5FUN_SWITCH = "ON_ACT5FUN_SWITCH";

		// Token: 0x0400E133 RID: 57651
		[Token(Token = "0x400E133")]
		public const string ACT5FUN_WINORLOSE = "ON_ACT5FUN_WINORLOSE";

		// Token: 0x0400E134 RID: 57652
		[Token(Token = "0x400E134")]
		public const string ACT5FUN_WIN = "ON_ACT5FUN_WIN";

		// Token: 0x0400E135 RID: 57653
		[Token(Token = "0x400E135")]
		public const string ACT5FUN_LOSE = "ON_ACT5FUN_LOSE";

		// Token: 0x0400E136 RID: 57654
		[Token(Token = "0x400E136")]
		public const string ACT5FUN_MONEYEXPLODE = "ON_ACT5FUN_MONEYEXPLODE";

		// Token: 0x0400E137 RID: 57655
		[Token(Token = "0x400E137")]
		public const string RACING_START_COUNTDOWN = "RACING_START_COUNTDOWN";

		// Token: 0x0400E138 RID: 57656
		[Token(Token = "0x400E138")]
		public const string RACING_FINISH_COUNTDOWN_START = "RACING_FINISH_COUNTDOWN_START";

		// Token: 0x0400E139 RID: 57657
		[Token(Token = "0x400E139")]
		public const string RACING_FINISH_COUNTDOWN_EVERY_TIME = "RACING_FINISH_COUNTDOWN_EVERY_TIME";

		// Token: 0x0400E13A RID: 57658
		[Token(Token = "0x400E13A")]
		public const string RACING_GAME_FINISH = "RACING_GAME_FINISH";

		// Token: 0x0400E13B RID: 57659
		[Token(Token = "0x400E13B")]
		public const string RACING_COLLISION_AUDIO_SIGNAL = "racing_collided";

		// Token: 0x0400E13C RID: 57660
		[Token(Token = "0x400E13C")]
		public const string RACING_LAST_ROUND_START_AUDIO_SIGNAL = "racing_last_round_start";

		// Token: 0x0400E13D RID: 57661
		[Token(Token = "0x400E13D")]
		public const string ON_PIN_MARK_MULTIV2 = "ON_PIN_MARK_MULTIV2";

		// Token: 0x0400E13E RID: 57662
		[Token(Token = "0x400E13E")]
		public const string ON_SEND_PIN_MARK_MULTIV2 = "ON_SEND_PIN_MARK_MULTIV2";

		// Token: 0x0400E13F RID: 57663
		[Token(Token = "0x400E13F")]
		public const string ON_COOPERATE_MATE_DYING = "ON_COOPERATE_MATE_DYING";

		// Token: 0x0400E140 RID: 57664
		[Token(Token = "0x400E140")]
		public const string ON_COOPERATE_MATE_TIMEOUT = "ON_COOPERATE_MATE_TIMEOUT";

		// Token: 0x0400E141 RID: 57665
		[Token(Token = "0x400E141")]
		public const string ON_COOPERATE_MATE_QUIT = "ON_COOPERATE_MATE_QUIT";

		// Token: 0x0400E142 RID: 57666
		[Token(Token = "0x400E142")]
		public const string ON_COOPERATE_ALLY_SCORED = "ON_COOPERATE_ALLY_SCORED";

		// Token: 0x0400E143 RID: 57667
		[Token(Token = "0x400E143")]
		public const string ON_COOPERATE_ENEMY_SCORED = "ON_COOPERATE_ENEMY_SCORED";

		// Token: 0x0400E144 RID: 57668
		[Token(Token = "0x400E144")]
		public const string ON_COOPERATE_APPLY_BONUS = "ON_COOPERATE_APPLY_BONUS";

		// Token: 0x0400E145 RID: 57669
		[Token(Token = "0x400E145")]
		public const string ON_COOPERATE_DYING = "ON_COOPERATE_DYING";

		// Token: 0x0400E146 RID: 57670
		[Token(Token = "0x400E146")]
		public const string ON_COOPERATE_PAUSE_CONFIRM = "ON_COOPERATE_PAUSE_CONFIRM";

		// Token: 0x0400E147 RID: 57671
		[Token(Token = "0x400E147")]
		public const string ON_COOPERATE_STAGE_COMPLISH = "ON_COOPERATE_STAGE_COMPLISH";

		// Token: 0x0400E148 RID: 57672
		[Token(Token = "0x400E148")]
		public const string ON_COOPERATE_REST_START = "ON_COOPERATE_REST_START";

		// Token: 0x0400E149 RID: 57673
		[Token(Token = "0x400E149")]
		public const string ON_COOPERATE_MATE_SKIP_REST = "ON_COOPERATE_MATE_SKIP_REST";

		// Token: 0x0400E14A RID: 57674
		[Token(Token = "0x400E14A")]
		public const string ON_COOPERATE_STAGE_COMPLETE_1 = "ON_COOPERATE_STAGE_COMPLETE_1";

		// Token: 0x0400E14B RID: 57675
		[Token(Token = "0x400E14B")]
		public const string ON_COOPERATE_STAGE_COMPLETE_2 = "ON_COOPERATE_STAGE_COMPLETE_2";

		// Token: 0x0400E14C RID: 57676
		[Token(Token = "0x400E14C")]
		public const string ON_PLAYER_HOLD_FOOTBALL = "ON_PLAYER_HOLD_FOOTBALL";

		// Token: 0x0400E14D RID: 57677
		[Token(Token = "0x400E14D")]
		public const string DO_PLAYER_LAND_FOOTBALL = "DO_PLAYER_LAND_FOOTBALL";

		// Token: 0x0400E14E RID: 57678
		[Token(Token = "0x400E14E")]
		public const string ON_COOPERATE_COST_REJECT = "ON_COOPERATE_COST_REJECT";

		// Token: 0x0400E14F RID: 57679
		[Token(Token = "0x400E14F")]
		public const string ON_COOPERATE_IDENTITY_SHOW = "ON_COOPERATE_IDENTITY_SHOW";

		// Token: 0x0400E150 RID: 57680
		[Token(Token = "0x400E150")]
		public const string ON_COOPERATE_IDENTITY_INVERSE = "ON_COOPERATE_IDENTITY_INVERSE";

		// Token: 0x0400E151 RID: 57681
		[Token(Token = "0x400E151")]
		public const string ON_COOPERATE_REVIVE = "ON_COOPERATE_REVIVE";

		// Token: 0x0400E152 RID: 57682
		[Token(Token = "0x400E152")]
		public const string ON_COOPERATE_SEND_EMOTICON = "ON_COOPERATE_SEND_EMOTICON";

		// Token: 0x0400E153 RID: 57683
		[Token(Token = "0x400E153")]
		public const string ON_COOPERATE_SPEED_REQUEST = "ON_COOPERATE_SPEED_REQUEST";

		// Token: 0x0400E154 RID: 57684
		[Token(Token = "0x400E154")]
		public const string ON_COOPERATE_RAFT_NEXT_AREA = "ON_COOPERATE_RAFT_NEXT_AREA";

		// Token: 0x0400E155 RID: 57685
		[Token(Token = "0x400E155")]
		public const string ON_COOPERATE_RAFT_GET_SCORE = "ON_COOPERATE_RAFT_GET_SCORE";

		// Token: 0x0400E156 RID: 57686
		[Token(Token = "0x400E156")]
		public const string ON_COOPERATE_RAFT_GET_COIN = "ON_COOPERATE_RAFT_GET_COIN";

		// Token: 0x0400E157 RID: 57687
		[Token(Token = "0x400E157")]
		public const string ON_COOPERATE_RAFT_SHOW_AREA_TIPS = "ON_COOPERATE_RAFT_SHOW_AREA_TIPS";

		// Token: 0x0400E158 RID: 57688
		[Token(Token = "0x400E158")]
		public const string ON_COOPERATE_RAFT_HIDE_AREA_TIPS = "ON_COOPERATE_RAFT_HIDE_AREA_TIPS";

		// Token: 0x0400E159 RID: 57689
		[Token(Token = "0x400E159")]
		public const string ON_COOPERATE_RAFT_SHOW_CONTINUE_TIPS = "ON_COOPERATE_RAFT_SHOW_CONTINUE_TIPS";

		// Token: 0x0400E15A RID: 57690
		[Token(Token = "0x400E15A")]
		public const string ON_COOPERATE_RAFT_HIDE_CONTINUE_TIPS = "ON_COOPERATE_RAFT_HIDE_CONTINUE_TIPS";

		// Token: 0x0400E15B RID: 57691
		[Token(Token = "0x400E15B")]
		public const string ON_COOPERATE_RAFT_WATER_FLOW_DIR = "ON_COOPERATE_RAFT_WATER_FLOW_DIR";

		// Token: 0x0400E15C RID: 57692
		[Token(Token = "0x400E15C")]
		public const string ON_COOPERATE_RAFT_WATER_FLOW_LEVEL = "ON_COOPERATE_RAFT_WATER_FLOW_LEVEL";

		// Token: 0x0400E15D RID: 57693
		[Token(Token = "0x400E15D")]
		public const string ON_ROGUELIKE_DUEL_BATTLE_START = "ON_ROGUELIKE_DUEL_BATTLE_START";

		// Token: 0x0400E15E RID: 57694
		[Token(Token = "0x400E15E")]
		public const string ON_ROGUELIKE_DUEL_BATTLE_WIN = "ON_ROGUELIKE_DUEL_BATTLE_WIN";

		// Token: 0x0400E15F RID: 57695
		[Token(Token = "0x400E15F")]
		public const string ON_ROGUELIKE_DUEL_BATTLE_DRAW = "ON_ROGUELIKE_DUEL_BATTLE_DRAW";

		// Token: 0x0400E160 RID: 57696
		[Token(Token = "0x400E160")]
		public const string ON_ROGUELIKE_DUEL_BATTLE_LOSE = "ON_ROGUELIKE_DUEL_BATTLE_LOSE";

		// Token: 0x0400E161 RID: 57697
		[Token(Token = "0x400E161")]
		public const string ON_ROGUELIKE_DEIFY_BATTLE_START = "ON_ROGUELIKE_DEIFY_BATTLE_START";

		// Token: 0x0400E162 RID: 57698
		[Token(Token = "0x400E162")]
		public const string ON_ROGUELIKE_DEIFY_BATTLE_WIN = "ON_ROGUELIKE_DEIFY_BATTLE_WIN";

		// Token: 0x0400E163 RID: 57699
		[Token(Token = "0x400E163")]
		public const string ON_ROGUELIKE_DEIFY_BATTLE_LOSE = "ON_ROGUELIKE_DEIFY_BATTLE_LOSE";

		// Token: 0x0400E164 RID: 57700
		[Token(Token = "0x400E164")]
		public const string ON_ACT1AUTOCHESS_EQUIP_DONE = "ON_ACT1AUTOCHESS_EQUIP_DONE";

		// Token: 0x0400E165 RID: 57701
		[Token(Token = "0x400E165")]
		public const string ON_ACT1AUTOCHESS_CHAR_BONUS = "ON_ACT1AUTOCHESS_CHAR_BONUS";

		// Token: 0x0400E166 RID: 57702
		[Token(Token = "0x400E166")]
		public const string ON_ACT1AUTOCHESS_EQUIP_BONUS = "ON_ACT1AUTOCHESS_EQUIP_BONUS";

		// Token: 0x0400E167 RID: 57703
		[Token(Token = "0x400E167")]
		public const string ON_ACT1AUTOCHESS_ADD_BOND = "ON_ACT1AUTOCHESS_ADD_BOND";

		// Token: 0x0400E168 RID: 57704
		[Token(Token = "0x400E168")]
		public const string ON_ACT1AUTOCHESS_MAGIC_PLACE_BATTLE = "ON_ACT1AUTOCHESS_MAGIC_PLACE_BATTLE";

		// Token: 0x0400E169 RID: 57705
		[Token(Token = "0x400E169")]
		public const string ON_ACT1AUTOCHESS_MAGIC_PLACE_HAND = "ON_ACT1AUTOCHESS_MAGIC_PLACE_HAND";

		// Token: 0x0400E16A RID: 57706
		[Token(Token = "0x400E16A")]
		public const string ON_ACT1ARCADE_CALCULATESCORE = "ON_ACT1ARCADE_CALCULATESCORE";

		// Token: 0x0400E16B RID: 57707
		[Token(Token = "0x400E16B")]
		public const string ON_ACT1ARCADE_INTERFACESPPEAR = "ON_ACT1ARCADE_INTERFACESPPEAR";

		// Token: 0x0400E16C RID: 57708
		[Token(Token = "0x400E16C")]
		public const string ON_ACT1ARCADE_UNLOCKSEAL = "ON_ACT1ARCADE_UNLOCKSEAL";

		// Token: 0x0400E16D RID: 57709
		[Token(Token = "0x400E16D")]
		public const string ON_ACT1ARCADE_SETTLEMENT = "ON_ACT1ARCADE_SETTLEMENT";

		// Token: 0x0400E16E RID: 57710
		[Token(Token = "0x400E16E")]
		public const string ON_ACT1ARCADE_TOPRECORD = "ON_ACT1ARCADE_TOPRECORD";

		// Token: 0x0400E16F RID: 57711
		[Token(Token = "0x400E16F")]
		public const string ON_ACT1ARCADE_PROGRESSBAR = "ON_ACT1ARCADE_PROGRESSBAR";

		// Token: 0x0400E170 RID: 57712
		[Token(Token = "0x400E170")]
		public const string ON_ACT1ARCADE_TRANSITION = "ON_ACT1ARCADE_TRANSITION";

		// Token: 0x0400E171 RID: 57713
		[Token(Token = "0x400E171")]
		public const string ON_ACT1ARCADE_BATTLE_WAVE_START = "ON_ACT1ARCADE_BATTLE_WAVE_START";

		// Token: 0x0400E172 RID: 57714
		[Token(Token = "0x400E172")]
		public const string ON_ACT1ARCADE_BATTLE_GET_SCORE = "ON_ACT1ARCADE_BATTLE_GET_SCORE";

		// Token: 0x0400E173 RID: 57715
		[Token(Token = "0x400E173")]
		public const string ON_ACT1ARCADE_BATTLE_TIME_WARNING = "ON_ACT1ARCADE_BATTLE_TIME_WARNING";

		// Token: 0x0400E174 RID: 57716
		[Token(Token = "0x400E174")]
		public const string ON_ACT1ARCADE_BATTLE_REST = "ON_ACT1ARCADE_BATTLE_REST";

		// Token: 0x0400E175 RID: 57717
		[Token(Token = "0x400E175")]
		public const string ON_ACT1ARCADE_BATTLE_UPGRADE_LEVEL = "ON_ACT1ARCADE_BATTLE_UPGRADE_LEVEL";

		// Token: 0x0400E176 RID: 57718
		[Token(Token = "0x400E176")]
		public const string ON_ACT1ARCADE_BATTLE_UPGRADE_LEVEL_MAX = "ON_ACT1ARCADE_BATTLE_UPGRADE_LEVEL_MAX";

		// Token: 0x0400E177 RID: 57719
		[Token(Token = "0x400E177")]
		public const string ON_ACT1ARCADE_BATTLE_GAME_OVER = "ON_ACT1ARCADE_BATTLE_GAME_OVER";

		// Token: 0x0400E178 RID: 57720
		[Token(Token = "0x400E178")]
		public const string ON_ACT6FUN_BATTLE_START = "ON_ACT6FUN_BATTLE_START";

		// Token: 0x0400E179 RID: 57721
		[Token(Token = "0x400E179")]
		public const string ON_ACT6FUN_BATTLE_GAME_OVER_WIN = "ON_ACT6FUN_BATTLE_GAME_OVER_WIN";

		// Token: 0x0400E17A RID: 57722
		[Token(Token = "0x400E17A")]
		public const string ON_ACT6FUN_COIN_COLLECT_FEVER = "ON_ACT6FUN_COIN_COLLECT_FEVER";

		// Token: 0x0400E17B RID: 57723
		[Token(Token = "0x400E17B")]
		public const string ON_ACT6FUN_ENEMY_REACHED_EXIT = "ON_ACT6FUN_ENEMY_REACHED_EXIT";

		// Token: 0x0400E17C RID: 57724
		[Token(Token = "0x400E17C")]
		public const string ON_ACT6FUN_CHARACTER_DEAD = "ON_ACT6FUN_CHARACTER_DEAD";

		// Token: 0x0400E17D RID: 57725
		[Token(Token = "0x400E17D")]
		public const string ON_ACT6FUN_DUWU_START = "ON_ACT6FUN_DUWU_START";

		// Token: 0x0400E17E RID: 57726
		[Token(Token = "0x400E17E")]
		public const string ON_ACT6FUN_DUWU_END = "ON_ACT6FUN_DUWU_END";

		// Token: 0x0400E17F RID: 57727
		[Token(Token = "0x400E17F")]
		public const string ON_ACT6FUN_MAIN_ENEMY_IN_COMBAT = "ON_ACT6FUN_MAIN_ENEMY_IN_COMBAT";

		// Token: 0x0400E180 RID: 57728
		[Token(Token = "0x400E180")]
		public const string ON_ACT1VHALFIDLE_WEAR_EQUIP = "ON_ACT1VHALFIDLE_WEAR_EQUIP";

		// Token: 0x0400E181 RID: 57729
		[Token(Token = "0x400E181")]
		public const string ON_ACT1VHALFIDLE_AUTO_EQUIP = "ON_ACT1VHALFIDLE_AUTO_EQUIP";

		// Token: 0x0400E182 RID: 57730
		[Token(Token = "0x400E182")]
		public const string ON_ACT1VHALFIDLE_GAIN_EQUIP = "ON_ACT1VHALFIDLE_GAIN_EQUIP";

		// Token: 0x0400E183 RID: 57731
		[Token(Token = "0x400E183")]
		public const string ON_ACT1VHALFIDLE_LEVEL_OVERLOAD = "ON_ACT1VHALFIDLE_LEVEL_OVERLOAD";

		// Token: 0x0400E184 RID: 57732
		[Token(Token = "0x400E184")]
		public const string ON_ACT1VHALFIDLE_BOSS_RUSH = "ON_ACT1VHALFIDLE_BOSS_RUSH";

		// Token: 0x0400E185 RID: 57733
		[Token(Token = "0x400E185")]
		public const string ON_ACT1VHALFIDLE_ENEMY_RUSH = "ON_ACT1VHALFIDLE_ENEMY_RUSH";

		// Token: 0x0400E186 RID: 57734
		[Token(Token = "0x400E186")]
		public const string ON_ACT1VHALFIDLE_WARN_OVERLOAD = "ON_ACT1VHALFIDLE_WARN_OVERLOAD";

		// Token: 0x0400E187 RID: 57735
		[Token(Token = "0x400E187")]
		public const string ON_ACT1VHALFIDLE_LOSE_LIFE_POINT = "ON_ACT1VHALFIDLE_LOSE_LIFE_POINT";

		// Token: 0x0400E188 RID: 57736
		[Token(Token = "0x400E188")]
		public const string ON_ACT7FUN_BATTLE_GAME_START = "ON_ACT7FUN_BATTLE_GAME_START";

		// Token: 0x0400E189 RID: 57737
		[Token(Token = "0x400E189")]
		public const string ON_ACT7FUN_BATTLE_SYSTEM_MENU = "ON_ACT7FUN_BATTLE_SYSTEM_MENU";

		// Token: 0x0400E18A RID: 57738
		[Token(Token = "0x400E18A")]
		public const string ON_ACT7FUN_BATTLE_FINISH = "ON_ACT7FUN_BATTLE_FINISH";

		// Token: 0x0400E18B RID: 57739
		[Token(Token = "0x400E18B")]
		public const string ON_ACT7FUN_BATTLE_TRAP_BOOM = "ON_ACT7FUN_BATTLE_TRAP_BOOM";

		// Token: 0x0400E18C RID: 57740
		[Token(Token = "0x400E18C")]
		public const string ON_ACT7FUN_BATTLE_AVATAR_BOOM = "ON_ACT7FUN_BATTLE_AVATAR_BOOM";
	}
}
