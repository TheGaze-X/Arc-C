using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200220F RID: 8719
	[Token(Token = "0x200220F")]
	public class BattleEventConst : IHotfixable
	{
		// Token: 0x0600DBB0 RID: 56240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DBB0")]
		[Address(RVA = "0x3611100", Offset = "0x360FD00", VA = "0x183611100")]
		public BattleEventConst()
		{
		}

		// Token: 0x0400ED7F RID: 60799
		[Token(Token = "0x400ED7F")]
		public const int PLUGIN_OFFSET = 10000;

		// Token: 0x0400ED80 RID: 60800
		[Token(Token = "0x400ED80")]
		public const int ON_BATTLE_CONTROLLER_INIT = 1;

		// Token: 0x0400ED81 RID: 60801
		[Token(Token = "0x400ED81")]
		public const int OPEN_UI_PAGE = 2;

		// Token: 0x0400ED82 RID: 60802
		[Token(Token = "0x400ED82")]
		public const int OPEN_ACTIVITY_PAGE = 3;

		// Token: 0x0400ED83 RID: 60803
		[Token(Token = "0x400ED83")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002210 RID: 8720
		[Token(Token = "0x2002210")]
		public class SandboxV2EventConst
		{
			// Token: 0x0600DBB1 RID: 56241 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBB1")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public SandboxV2EventConst()
			{
			}

			// Token: 0x0400ED84 RID: 60804
			[Token(Token = "0x400ED84")]
			public const int SHOW_CONFIRM_DIALOG = 1;

			// Token: 0x0400ED85 RID: 60805
			[Token(Token = "0x400ED85")]
			public const int ON_CONFIRM_DIALOG_CANCEL = 2;

			// Token: 0x0400ED86 RID: 60806
			[Token(Token = "0x400ED86")]
			public const int ON_CONFIRM_DIALOG_CONFIRM = 3;
		}

		// Token: 0x02002211 RID: 8721
		[Token(Token = "0x2002211")]
		public class AutoChessEventConst
		{
			// Token: 0x0600DBB2 RID: 56242 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBB2")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AutoChessEventConst()
			{
			}

			// Token: 0x0400ED87 RID: 60807
			[Token(Token = "0x400ED87")]
			public const int ON_DATA_CHANGED = 1001;

			// Token: 0x0400ED88 RID: 60808
			[Token(Token = "0x400ED88")]
			public const int ON_REV_CHAT = 1002;

			// Token: 0x0400ED89 RID: 60809
			[Token(Token = "0x400ED89")]
			public const int ON_REV_BROADCAST = 1003;

			// Token: 0x0400ED8A RID: 60810
			[Token(Token = "0x400ED8A")]
			public const int ON_SERVER_LOST = 1004;

			// Token: 0x0400ED8B RID: 60811
			[Token(Token = "0x400ED8B")]
			public const int ON_DUMMY_UPDATE_HUD = 1101;

			// Token: 0x0400ED8C RID: 60812
			[Token(Token = "0x400ED8C")]
			public const int ON_DUMMY_REMOVED = 1102;

			// Token: 0x0400ED8D RID: 60813
			[Token(Token = "0x400ED8D")]
			public const int ON_DRAG_STATE_TILE_UPDATED = 1201;

			// Token: 0x0400ED8E RID: 60814
			[Token(Token = "0x400ED8E")]
			public const int ON_EXIT_AUTOCHESS_DRAG_STATE = 1202;

			// Token: 0x0400ED8F RID: 60815
			[Token(Token = "0x400ED8F")]
			public const int ON_ENTER_AUTOCHESS_DRAG_STATE = 1203;

			// Token: 0x0400ED90 RID: 60816
			[Token(Token = "0x400ED90")]
			public const int ON_ADD_BOND_COUNT = 1204;

			// Token: 0x0400ED91 RID: 60817
			[Token(Token = "0x400ED91")]
			public const int ON_CHESS_UPGRADE = 1205;

			// Token: 0x0400ED92 RID: 60818
			[Token(Token = "0x400ED92")]
			public const int ON_PLACE_AT_BATTLE_FIELD = 1206;

			// Token: 0x0400ED93 RID: 60819
			[Token(Token = "0x400ED93")]
			public const int ON_PLACE_AT_HAND_FIELD = 1207;

			// Token: 0x0400ED94 RID: 60820
			[Token(Token = "0x400ED94")]
			public const int ON_CHARACTER_HIGHLIGHTED = 1208;

			// Token: 0x0400ED95 RID: 60821
			[Token(Token = "0x400ED95")]
			public const int ON_TUTORIAL_LOCK_IN_DRAG = 1209;

			// Token: 0x0400ED96 RID: 60822
			[Token(Token = "0x400ED96")]
			public const int ON_TUTORIAL_UNLOCK_IN_DRAG = 1210;

			// Token: 0x0400ED97 RID: 60823
			[Token(Token = "0x400ED97")]
			public const int ON_BATTLE_STARTED = 1211;

			// Token: 0x0400ED98 RID: 60824
			[Token(Token = "0x400ED98")]
			public const int ON_TUTORIAL_LOCK_BOND_EXPAND = 1212;

			// Token: 0x0400ED99 RID: 60825
			[Token(Token = "0x400ED99")]
			public const int ON_TUTORIAL_UNLOCK_BOND_EXPAND = 1213;

			// Token: 0x0400ED9A RID: 60826
			[Token(Token = "0x400ED9A")]
			public const int ON_SELF_GAIN_NEW_CHESS = 1214;
		}

		// Token: 0x02002212 RID: 8722
		[Token(Token = "0x2002212")]
		public class CooperateEventConst
		{
			// Token: 0x0600DBB3 RID: 56243 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBB3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CooperateEventConst()
			{
			}

			// Token: 0x0400ED9B RID: 60827
			[Token(Token = "0x400ED9B")]
			public const int ON_RECEIVE_MULTIPLAYER_BATTLE_START_EVENT = 2001;

			// Token: 0x0400ED9C RID: 60828
			[Token(Token = "0x400ED9C")]
			public const int ON_RECEIVE_MAP_MARK_EVENT = 2002;

			// Token: 0x0400ED9D RID: 60829
			[Token(Token = "0x400ED9D")]
			public const int ON_GIVE_UP_GAME = 2003;

			// Token: 0x0400ED9E RID: 60830
			[Token(Token = "0x400ED9E")]
			public const int ON_RECEIVE_COST_EVENT = 2004;

			// Token: 0x0400ED9F RID: 60831
			[Token(Token = "0x400ED9F")]
			public const int ON_SPEED_STATE_CHANGED = 2005;

			// Token: 0x0400EDA0 RID: 60832
			[Token(Token = "0x400EDA0")]
			public const int ON_SCORE_A_GOAL = 2006;

			// Token: 0x0400EDA1 RID: 60833
			[Token(Token = "0x400EDA1")]
			public const int ON_PIN_BEGIN_EVENT = 2007;

			// Token: 0x0400EDA2 RID: 60834
			[Token(Token = "0x400EDA2")]
			public const int ON_PIN_END_EVENT = 2008;

			// Token: 0x0400EDA3 RID: 60835
			[Token(Token = "0x400EDA3")]
			public const int ON_RESTING_STATE_CHANGED = 2009;

			// Token: 0x0400EDA4 RID: 60836
			[Token(Token = "0x400EDA4")]
			public const int ON_NEXT_FRAME_IN_PAUSE = 2010;

			// Token: 0x0400EDA5 RID: 60837
			[Token(Token = "0x400EDA5")]
			public const int ON_PLAYER_DIE = 2011;

			// Token: 0x0400EDA6 RID: 60838
			[Token(Token = "0x400EDA6")]
			public const int ON_PLAYER_REVIVE = 2012;

			// Token: 0x0400EDA7 RID: 60839
			[Token(Token = "0x400EDA7")]
			public const int ON_MATE_ONLINE_STATE_CHANGED = 2013;

			// Token: 0x0400EDA8 RID: 60840
			[Token(Token = "0x400EDA8")]
			public const int ON_RECEIVE_PAUSE_REQUEST = 2014;

			// Token: 0x0400EDA9 RID: 60841
			[Token(Token = "0x400EDA9")]
			public const int ON_PAUSE_REQUEST_STATE_CHANGED = 2015;

			// Token: 0x0400EDAA RID: 60842
			[Token(Token = "0x400EDAA")]
			public const int ON_ACCEPT_PAUSE_REQUEST = 2016;

			// Token: 0x0400EDAB RID: 60843
			[Token(Token = "0x400EDAB")]
			public const int ON_REFUSE_PAUSE_REQUEST = 2017;

			// Token: 0x0400EDAC RID: 60844
			[Token(Token = "0x400EDAC")]
			public const int ON_RESUME_PAUSE_REQUEST = 2018;

			// Token: 0x0400EDAD RID: 60845
			[Token(Token = "0x400EDAD")]
			public const int ON_SKIP_RESTING = 2019;

			// Token: 0x0400EDAE RID: 60846
			[Token(Token = "0x400EDAE")]
			public const int ON_RESTING_START = 2020;

			// Token: 0x0400EDAF RID: 60847
			[Token(Token = "0x400EDAF")]
			public const int ON_GET_NORMAL_PROGRESS = 2021;

			// Token: 0x0400EDB0 RID: 60848
			[Token(Token = "0x400EDB0")]
			public const int ON_DEFENCE_OR_FOOTBALL_WAVE_FINISHED = 2022;

			// Token: 0x0400EDB1 RID: 60849
			[Token(Token = "0x400EDB1")]
			public const int ON_BEFORE_FIRST_WAVE = 2023;

			// Token: 0x0400EDB2 RID: 60850
			[Token(Token = "0x400EDB2")]
			public const int ON_BEFORE_NEXT_STAGE = 2024;

			// Token: 0x0400EDB3 RID: 60851
			[Token(Token = "0x400EDB3")]
			public const int ON_FINISH_GAME = 2025;

			// Token: 0x0400EDB4 RID: 60852
			[Token(Token = "0x400EDB4")]
			public const int ON_SAIL_BOAT_SCORE_CHANGED = 2026;

			// Token: 0x0400EDB5 RID: 60853
			[Token(Token = "0x400EDB5")]
			public const int ON_SAIL_BOAT_TRANSITION_AREA = 2027;

			// Token: 0x0400EDB6 RID: 60854
			[Token(Token = "0x400EDB6")]
			public const int ON_SAIL_BOAT_WATER_FORCE_CHANGED = 2028;

			// Token: 0x0400EDB7 RID: 60855
			[Token(Token = "0x400EDB7")]
			public const int ON_SAIL_BOAT_WAVE_START = 2029;

			// Token: 0x0400EDB8 RID: 60856
			[Token(Token = "0x400EDB8")]
			public const int ON_RECEIVE_BOAT_MARK_EVENT = 2030;

			// Token: 0x0400EDB9 RID: 60857
			[Token(Token = "0x400EDB9")]
			public const int ON_SAIL_BOAT_REAL_START_EVENT = 2031;
		}

		// Token: 0x02002213 RID: 8723
		[Token(Token = "0x2002213")]
		public class EnemyDuelEventConst
		{
			// Token: 0x0600DBB4 RID: 56244 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBB4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EnemyDuelEventConst()
			{
			}

			// Token: 0x0400EDBA RID: 60858
			[Token(Token = "0x400EDBA")]
			public const int ENEMY_DUEL_ROUND_STATE_CHANGED = 3001;

			// Token: 0x0400EDBB RID: 60859
			[Token(Token = "0x400EDBB")]
			public const int ENEMY_DUEL_FINISH_GAME = 3002;

			// Token: 0x0400EDBC RID: 60860
			[Token(Token = "0x400EDBC")]
			public const int ENEMY_DUEL_PERFORM_FINISH_WAIT = 3003;

			// Token: 0x0400EDBD RID: 60861
			[Token(Token = "0x400EDBD")]
			public const int ENEMY_DUEL_BET = 3004;

			// Token: 0x0400EDBE RID: 60862
			[Token(Token = "0x400EDBE")]
			public const int ENEMY_DUEL_EMOJI_REV = 3005;

			// Token: 0x0400EDBF RID: 60863
			[Token(Token = "0x400EDBF")]
			public const int ENEMY_DUEL_EMOJI_SEND = 3006;

			// Token: 0x0400EDC0 RID: 60864
			[Token(Token = "0x400EDC0")]
			public const int ENEMY_DUEL_BATTLE_START_EVENT = 3007;

			// Token: 0x0400EDC1 RID: 60865
			[Token(Token = "0x400EDC1")]
			public const int ENEMY_DUEL_BATTLE_NET_CHANGED = 3008;

			// Token: 0x0400EDC2 RID: 60866
			[Token(Token = "0x400EDC2")]
			public const int ENEMY_DUEL_BATTLE_ABNORMAL_END = 3009;

			// Token: 0x0400EDC3 RID: 60867
			[Token(Token = "0x400EDC3")]
			public const int ENEMY_DUEL_ROUND_CHANGED = 3010;
		}

		// Token: 0x02002214 RID: 8724
		[Token(Token = "0x2002214")]
		public class HalfIdleEventConst
		{
			// Token: 0x0600DBB5 RID: 56245 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBB5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public HalfIdleEventConst()
			{
			}

			// Token: 0x0400EDC4 RID: 60868
			[Token(Token = "0x400EDC4")]
			public const int HALF_IDLE_GAIN_EQUIP = 4001;

			// Token: 0x0400EDC5 RID: 60869
			[Token(Token = "0x400EDC5")]
			public const int HALF_IDLE_NORMAL_TIP_SHOW = 4002;

			// Token: 0x0400EDC6 RID: 60870
			[Token(Token = "0x400EDC6")]
			public const int HALF_IDLE_TIP_CHANGED = 4003;

			// Token: 0x0400EDC7 RID: 60871
			[Token(Token = "0x400EDC7")]
			public const int HALF_IDLE_BATTLE_STATUS_CHANGED = 4004;

			// Token: 0x0400EDC8 RID: 60872
			[Token(Token = "0x400EDC8")]
			public const int HALF_IDLE_BATTLE_SYSTEM_MENU_CLICKED = 4006;

			// Token: 0x0400EDC9 RID: 60873
			[Token(Token = "0x400EDC9")]
			public const int HALF_IDLE_BATTLE_SYSTEM_MENU_CLOSED = 4007;

			// Token: 0x0400EDCA RID: 60874
			[Token(Token = "0x400EDCA")]
			public const int HALF_IDLE_BATTLE_SYSTEM_MENU_CONFIRMED = 4008;

			// Token: 0x0400EDCB RID: 60875
			[Token(Token = "0x400EDCB")]
			public const int HALF_IDLE_BATTLE_ITEM_UPDATED = 4009;

			// Token: 0x0400EDCC RID: 60876
			[Token(Token = "0x400EDCC")]
			public const int HALF_IDLE_SET_ITEM_PANEL_VISIBLE_MANUALLY = 4010;

			// Token: 0x0400EDCD RID: 60877
			[Token(Token = "0x400EDCD")]
			public const int HALF_IDLE_HUD_PANEL_VISIBLE_CHANGED = 4011;

			// Token: 0x0400EDCE RID: 60878
			[Token(Token = "0x400EDCE")]
			public const int HALF_IDLE_EQUIP_PANEL_ITEM_CHANGED = 4012;

			// Token: 0x0400EDCF RID: 60879
			[Token(Token = "0x400EDCF")]
			public const int HALF_IDLE_EQUIP_PANEL_UNFOLD = 4013;

			// Token: 0x0400EDD0 RID: 60880
			[Token(Token = "0x400EDD0")]
			public const int HALF_IDLE_EQUIP_WEARED = 4014;

			// Token: 0x0400EDD1 RID: 60881
			[Token(Token = "0x400EDD1")]
			public const int HALF_IDLE_EQUIP_AUTO_UPGRADE_TOGGLE = 4015;

			// Token: 0x0400EDD2 RID: 60882
			[Token(Token = "0x400EDD2")]
			public const int HALF_IDLE_BATTLE_HIDE_DIALOG = 4017;
		}

		// Token: 0x02002215 RID: 8725
		[Token(Token = "0x2002215")]
		public class StrifeModeEventConst
		{
			// Token: 0x0600DBB6 RID: 56246 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBB6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public StrifeModeEventConst()
			{
			}

			// Token: 0x0400EDD3 RID: 60883
			[Token(Token = "0x400EDD3")]
			public const int STRIFE_UPDATE_WAVE_DURATION = 5001;
		}

		// Token: 0x02002216 RID: 8726
		[Token(Token = "0x2002216")]
		public class act7FunEventConst
		{
			// Token: 0x0600DBB7 RID: 56247 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DBB7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public act7FunEventConst()
			{
			}

			// Token: 0x0400EDD4 RID: 60884
			[Token(Token = "0x400EDD4")]
			public const int ACT7FUN_ON_TRAP_KILLED = 6001;

			// Token: 0x0400EDD5 RID: 60885
			[Token(Token = "0x400EDD5")]
			public const int ACT7FUN_ON_START_STATE_EXIT = 6002;
		}
	}
}
