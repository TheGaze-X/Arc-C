using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020022D2 RID: 8914
	[Token(Token = "0x20022D2")]
	public class Act44SideBattleManager : GlobalEnvSystem.EnvManager, IAudioSource
	{
		// Token: 0x17001C28 RID: 7208
		// (get) Token: 0x0600E081 RID: 57473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C28")]
		public List<Trap> pckstpList
		{
			[Token(Token = "0x600E081")]
			[Address(RVA = "0x3674660", Offset = "0x3673260", VA = "0x183674660")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001C29 RID: 7209
		// (get) Token: 0x0600E082 RID: 57474 RVA: 0x00051798 File Offset: 0x0004F998
		[Token(Token = "0x17001C29")]
		public bool isInRushTime
		{
			[Token(Token = "0x600E082")]
			[Address(RVA = "0x36745A0", Offset = "0x36731A0", VA = "0x1836745A0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001C2A RID: 7210
		// (get) Token: 0x0600E083 RID: 57475 RVA: 0x000517B0 File Offset: 0x0004F9B0
		[Token(Token = "0x17001C2A")]
		public int curScore
		{
			[Token(Token = "0x600E083")]
			[Address(RVA = "0x3674210", Offset = "0x3672E10", VA = "0x183674210")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001C2B RID: 7211
		// (get) Token: 0x0600E084 RID: 57476 RVA: 0x000517C8 File Offset: 0x0004F9C8
		[Token(Token = "0x17001C2B")]
		public int totalScore
		{
			[Token(Token = "0x600E084")]
			[Address(RVA = "0x3674780", Offset = "0x3673380", VA = "0x183674780")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001C2C RID: 7212
		// (get) Token: 0x0600E085 RID: 57477 RVA: 0x000517E0 File Offset: 0x0004F9E0
		[Token(Token = "0x17001C2C")]
		public float rushTimeRemainingRate
		{
			[Token(Token = "0x600E085")]
			[Address(RVA = "0x36746F0", Offset = "0x36732F0", VA = "0x1836746F0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001C2D RID: 7213
		// (get) Token: 0x0600E086 RID: 57478 RVA: 0x000517F8 File Offset: 0x0004F9F8
		[Token(Token = "0x17001C2D")]
		public int curProgressMultiValue
		{
			[Token(Token = "0x600E086")]
			[Address(RVA = "0x36741B0", Offset = "0x3672DB0", VA = "0x1836741B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001C2E RID: 7214
		// (get) Token: 0x0600E087 RID: 57479 RVA: 0x00051810 File Offset: 0x0004FA10
		[Token(Token = "0x17001C2E")]
		public bool isExtraGameType
		{
			[Token(Token = "0x600E087")]
			[Address(RVA = "0x3674540", Offset = "0x3673140", VA = "0x183674540")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001C2F RID: 7215
		// (get) Token: 0x0600E088 RID: 57480 RVA: 0x00051828 File Offset: 0x0004FA28
		[Token(Token = "0x17001C2F")]
		public int maxPlayTime
		{
			[Token(Token = "0x600E088")]
			[Address(RVA = "0x3674600", Offset = "0x3673200", VA = "0x183674600")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17001C30 RID: 7216
		// (get) Token: 0x0600E089 RID: 57481 RVA: 0x00051840 File Offset: 0x0004FA40
		[Token(Token = "0x17001C30")]
		public float curGrade
		{
			[Token(Token = "0x600E089")]
			[Address(RVA = "0x3674150", Offset = "0x3672D50", VA = "0x183674150")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001C31 RID: 7217
		// (get) Token: 0x0600E08A RID: 57482 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C31")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E08A")]
			[Address(RVA = "0x3674270", Offset = "0x3672E70", VA = "0x183674270", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E08B RID: 57483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E08B")]
		[Address(RVA = "0x3670500", Offset = "0x366F100", VA = "0x183670500", Slot = "7")]
		public override void Init(GlobalEnvSystem owner)
		{
		}

		// Token: 0x0600E08C RID: 57484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E08C")]
		[Address(RVA = "0x3670590", Offset = "0x366F190", VA = "0x183670590", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E08D RID: 57485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E08D")]
		[Address(RVA = "0x3672E00", Offset = "0x3671A00", VA = "0x183672E00")]
		private void _InitParams()
		{
		}

		// Token: 0x0600E08E RID: 57486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E08E")]
		[Address(RVA = "0x3672A00", Offset = "0x3671600", VA = "0x183672A00")]
		private void _InitEnemyGradeDictionary()
		{
		}

		// Token: 0x0600E08F RID: 57487 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E08F")]
		[Address(RVA = "0x3671360", Offset = "0x366FF60", VA = "0x183671360")]
		private List<Trap> _CollectPckstp()
		{
			return null;
		}

		// Token: 0x0600E090 RID: 57488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E090")]
		[Address(RVA = "0x3671150", Offset = "0x366FD50", VA = "0x183671150")]
		private void _CollectBonusTile()
		{
		}

		// Token: 0x0600E091 RID: 57489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E091")]
		[Address(RVA = "0x3671E10", Offset = "0x3670A10", VA = "0x183671E10")]
		private void _DoCheckEndRushTimeStage(FP deltaTime)
		{
		}

		// Token: 0x0600E092 RID: 57490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E092")]
		[Address(RVA = "0x3671EE0", Offset = "0x3670AE0", VA = "0x183671EE0")]
		private void _DoUpdateBonusTileEffect(FP deltaTime)
		{
		}

		// Token: 0x0600E093 RID: 57491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E093")]
		[Address(RVA = "0x3673F40", Offset = "0x3672B40", VA = "0x183673F40")]
		private void _SwitchAllPckstpMode(bool isRushTime, bool exceptActive = false)
		{
		}

		// Token: 0x0600E094 RID: 57492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E094")]
		[Address(RVA = "0x36738D0", Offset = "0x36724D0", VA = "0x1836738D0")]
		private void _RecordActivePckstp()
		{
		}

		// Token: 0x0600E095 RID: 57493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E095")]
		[Address(RVA = "0x3673CA0", Offset = "0x36728A0", VA = "0x183673CA0")]
		private void _StartRushTime()
		{
		}

		// Token: 0x0600E096 RID: 57494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E096")]
		[Address(RVA = "0x3671620", Offset = "0x3670220", VA = "0x183671620")]
		private void _ContinueRushTime()
		{
		}

		// Token: 0x0600E097 RID: 57495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E097")]
		[Address(RVA = "0x3672690", Offset = "0x3671290", VA = "0x183672690")]
		private void _EndRushTime(bool exceptActive = false)
		{
		}

		// Token: 0x0600E098 RID: 57496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E098")]
		[Address(RVA = "0x36739D0", Offset = "0x36725D0", VA = "0x1836739D0")]
		private void _ResetScoreState()
		{
		}

		// Token: 0x0600E099 RID: 57497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E099")]
		[Address(RVA = "0x3671690", Offset = "0x3670290", VA = "0x183671690")]
		private void _ControlScreenEffect(bool isActive)
		{
		}

		// Token: 0x0600E09A RID: 57498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E09A")]
		[Address(RVA = "0x36728E0", Offset = "0x36714E0", VA = "0x1836728E0")]
		private void _GainScore(int score)
		{
		}

		// Token: 0x0600E09B RID: 57499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E09B")]
		[Address(RVA = "0x3672810", Offset = "0x3671410", VA = "0x183672810")]
		private void _GainGrade(float grade)
		{
		}

		// Token: 0x0600E09C RID: 57500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E09C")]
		[Address(RVA = "0x3673A40", Offset = "0x3672640", VA = "0x183673A40")]
		private void _StartRushTimeBonusToCostMostCard()
		{
		}

		// Token: 0x0600E09D RID: 57501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E09D")]
		[Address(RVA = "0x36717B0", Offset = "0x36703B0", VA = "0x1836717B0")]
		private void _CreateDeployCardBuff(Deck.Card chosenCard)
		{
		}

		// Token: 0x0600E09E RID: 57502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E09E")]
		[Address(RVA = "0x3671C50", Offset = "0x3670850", VA = "0x183671C50")]
		private void _CreateRespawnCardBuff(Deck.Card chosenCard)
		{
		}

		// Token: 0x0600E09F RID: 57503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E09F")]
		[Address(RVA = "0x3671A20", Offset = "0x3670620", VA = "0x183671A20")]
		private void _CreateDeployDeckBuff(Deck.Card chosenCard, bool dontAddSp = false)
		{
		}

		// Token: 0x0600E0A0 RID: 57504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0A0")]
		[Address(RVA = "0x3672330", Offset = "0x3670F30", VA = "0x183672330")]
		private void _EndAllCardRushTimeBonus()
		{
		}

		// Token: 0x0600E0A1 RID: 57505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0A1")]
		[Address(RVA = "0x3670FC0", Offset = "0x366FBC0", VA = "0x183670FC0")]
		private void _CheckGameFinish()
		{
		}

		// Token: 0x0600E0A2 RID: 57506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0A2")]
		[Address(RVA = "0x3673330", Offset = "0x3671F30", VA = "0x183673330")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600E0A3 RID: 57507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0A3")]
		[Address(RVA = "0x3673530", Offset = "0x3672130", VA = "0x183673530")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x0600E0A4 RID: 57508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0A4")]
		[Address(RVA = "0x3673250", Offset = "0x3671E50", VA = "0x183673250")]
		private void _OnGameOver(object arg)
		{
		}

		// Token: 0x0600E0A5 RID: 57509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0A5")]
		[Address(RVA = "0x3670430", Offset = "0x366F030", VA = "0x183670430", Slot = "16")]
		public void GatherAudio(List<string> results)
		{
		}

		// Token: 0x0600E0A6 RID: 57510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0A6")]
		[Address(RVA = "0x3670B50", Offset = "0x366F750", VA = "0x183670B50")]
		public void TouchWithEntityGainScore(Entity entity, float tileEffectTime = 2f)
		{
		}

		// Token: 0x0600E0A7 RID: 57511 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0A7")]
		[Address(RVA = "0x36702F0", Offset = "0x366EEF0", VA = "0x1836702F0")]
		public void EndRushTimeByBoss()
		{
		}

		// Token: 0x0600E0A8 RID: 57512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0A8")]
		[Address(RVA = "0x3670880", Offset = "0x366F480", VA = "0x183670880")]
		public void TouchWithEntityGainGrade(Entity entity, int hitCount = 1)
		{
		}

		// Token: 0x0600E0A9 RID: 57513 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0A9")]
		[Address(RVA = "0x3670350", Offset = "0x366EF50", VA = "0x183670350")]
		public void EnemyFallDownGainGrade(Enemy enemy)
		{
		}

		// Token: 0x0600E0AA RID: 57514 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0AA")]
		[Address(RVA = "0x36740F0", Offset = "0x3672CF0", VA = "0x1836740F0")]
		public Act44SideBattleManager()
		{
		}

		// Token: 0x0600E0AB RID: 57515 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E0AB")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E0AC RID: 57516 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0AC")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E0AD RID: 57517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0AD")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400F4A0 RID: 62624
		[Token(Token = "0x400F4A0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _screenEffectKey;

		// Token: 0x0400F4A1 RID: 62625
		[Token(Token = "0x400F4A1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _cardBuffEffectPluginKey;

		// Token: 0x0400F4A2 RID: 62626
		[Token(Token = "0x400F4A2")]
		private const string TRAP_PCKSTP_ID = "trap_252_pckstp";

		// Token: 0x0400F4A3 RID: 62627
		[Token(Token = "0x400F4A3")]
		private const string BONUS_TILE_ID = "tile_bnspck_road";

		// Token: 0x0400F4A4 RID: 62628
		[Token(Token = "0x400F4A4")]
		private const string INIT_SCORE_STR = "init_score";

		// Token: 0x0400F4A5 RID: 62629
		[Token(Token = "0x400F4A5")]
		private const string TOTAL_SCORE_STR = "total_score";

		// Token: 0x0400F4A6 RID: 62630
		[Token(Token = "0x400F4A6")]
		private const string TOTAL_SCORE_ADD_EACH_TIME = "total_score_add_each_time";

		// Token: 0x0400F4A7 RID: 62631
		[Token(Token = "0x400F4A7")]
		private const string CHARACTER_SCORE_STR = "character_score";

		// Token: 0x0400F4A8 RID: 62632
		[Token(Token = "0x400F4A8")]
		private const string CHARACTER_GRADE_STR = "character_grade";

		// Token: 0x0400F4A9 RID: 62633
		[Token(Token = "0x400F4A9")]
		private const string ENEMY_SCORE_STR = "enemy_score";

		// Token: 0x0400F4AA RID: 62634
		[Token(Token = "0x400F4AA")]
		private const string DEPLOY_CARD_BUFF_STR = "deploy_card_buff";

		// Token: 0x0400F4AB RID: 62635
		[Token(Token = "0x400F4AB")]
		private const string DEPLOY_DECK_BUFF_STR = "deploy_deck_buff";

		// Token: 0x0400F4AC RID: 62636
		[Token(Token = "0x400F4AC")]
		private const string DEPLOY_DECK_BUFF_TEMPLATE_KEY = "act44side_deploy_cnt_free";

		// Token: 0x0400F4AD RID: 62637
		[Token(Token = "0x400F4AD")]
		private const string RESPAWN_DEC_RACIO_STR = "respawn_dec_racio";

		// Token: 0x0400F4AE RID: 62638
		[Token(Token = "0x400F4AE")]
		private const string ENEMY_FALLDOWN_GRADE_STR = "enemy_falldown_grade";

		// Token: 0x0400F4AF RID: 62639
		[Token(Token = "0x400F4AF")]
		private const string ENEMY_PUSH_YMGPCK_GRADE_STR = "enemy_push_ymgpck_grade";

		// Token: 0x0400F4B0 RID: 62640
		[Token(Token = "0x400F4B0")]
		private const string ENEMY_PUSH_YMGPCK_ADD_GRADE_RATE_STR = "enemy_push_ymgpck_add_grade_rate";

		// Token: 0x0400F4B1 RID: 62641
		[Token(Token = "0x400F4B1")]
		private const string ENEMY_PUSH_YMGPCK_ADD_MAX_GRADE_RATE_STR = "enemy_push_ymgpck_add_max_grade_rate";

		// Token: 0x0400F4B2 RID: 62642
		[Token(Token = "0x400F4B2")]
		private const string BONUS_TILE_START_BY_CHARACTER = "bonus_tile_start_by_character";

		// Token: 0x0400F4B3 RID: 62643
		[Token(Token = "0x400F4B3")]
		private const string BONUS_TILE_GAIN_SCORE_AUDIO_STR = "bonus_tile_gain_score_audio";

		// Token: 0x0400F4B4 RID: 62644
		[Token(Token = "0x400F4B4")]
		private const string RUSHTIME_START_AUDIO_STR = "rushtime_start_audio";

		// Token: 0x0400F4B5 RID: 62645
		[Token(Token = "0x400F4B5")]
		private const int DEFAULT_INIT_SCORE = 1;

		// Token: 0x0400F4B6 RID: 62646
		[Token(Token = "0x400F4B6")]
		private const int DEFAULT_TOTAL_SCORE = 1000;

		// Token: 0x0400F4B7 RID: 62647
		[Token(Token = "0x400F4B7")]
		private const int DEFAULT_TOTAL_SCORE_ADD_EACH_TIME = 1000;

		// Token: 0x0400F4B8 RID: 62648
		[Token(Token = "0x400F4B8")]
		private const float DEFAULT_RUSHTIME_DURATION = 30f;

		// Token: 0x0400F4B9 RID: 62649
		[Token(Token = "0x400F4B9")]
		private const int DEFAULT_ENEMY_SCORE_FACTOR = 10;

		// Token: 0x0400F4BA RID: 62650
		[Token(Token = "0x400F4BA")]
		private const int DEFAULT_BONUS_CHARACTERS_SCORE_FACTOR = 50;

		// Token: 0x0400F4BB RID: 62651
		[Token(Token = "0x400F4BB")]
		private const int DEFAULT_BONUS_CHARACTERS_GRADE_FACTOR = 1;

		// Token: 0x0400F4BC RID: 62652
		[Token(Token = "0x400F4BC")]
		private const int DEFAULT_COST_DELTA = 0;

		// Token: 0x0400F4BD RID: 62653
		[Token(Token = "0x400F4BD")]
		private const float DEFAULT_RESPAWN_DEC_FACTOR = -0.5f;

		// Token: 0x0400F4BE RID: 62654
		[Token(Token = "0x400F4BE")]
		private const int DEFAULT_GAME_TYPE_FLAG = 0;

		// Token: 0x0400F4BF RID: 62655
		[Token(Token = "0x400F4BF")]
		private const int EXTRA_GAME_TYPE_MAX_TIME = 10;

		// Token: 0x0400F4C0 RID: 62656
		[Token(Token = "0x400F4C0")]
		private const float EXTRA_GAME_TYPE_MAX_GRADE = 99999f;

		// Token: 0x0400F4C1 RID: 62657
		[Token(Token = "0x400F4C1")]
		private const float ENEMY_PUSH_YMGPCK_ADD_GRADE_RATE = 0f;

		// Token: 0x0400F4C2 RID: 62658
		[Token(Token = "0x400F4C2")]
		private const float ENEMY_PUSH_YMGPCK_ADD_MAX_GRADE_RATE = 3f;

		// Token: 0x0400F4C3 RID: 62659
		[Token(Token = "0x400F4C3")]
		private const int MAX_PROGRESS_MULTI_VALUE = 9;

		// Token: 0x0400F4C4 RID: 62660
		[Token(Token = "0x400F4C4")]
		private const float MY_EPS = 0.0001f;

		// Token: 0x0400F4C5 RID: 62661
		[Token(Token = "0x400F4C5")]
		private const bool EXTRA_LEVEL_USE_LEVEL_EDITOR = true;

		// Token: 0x0400F4C6 RID: 62662
		[Token(Token = "0x400F4C6")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isExtraGameType;

		// Token: 0x0400F4C7 RID: 62663
		[Token(Token = "0x400F4C7")]
		[FieldOffset(Offset = "0x3C")]
		private int m_curScore;

		// Token: 0x0400F4C8 RID: 62664
		[Token(Token = "0x400F4C8")]
		[FieldOffset(Offset = "0x40")]
		private int m_totalScore;

		// Token: 0x0400F4C9 RID: 62665
		[Token(Token = "0x400F4C9")]
		[FieldOffset(Offset = "0x44")]
		private int m_curProgressMultiValue;

		// Token: 0x0400F4CA RID: 62666
		[Token(Token = "0x400F4CA")]
		[FieldOffset(Offset = "0x48")]
		private int m_originTotalScore;

		// Token: 0x0400F4CB RID: 62667
		[Token(Token = "0x400F4CB")]
		[FieldOffset(Offset = "0x4C")]
		private int m_totalScoreAddEachTime;

		// Token: 0x0400F4CC RID: 62668
		[Token(Token = "0x400F4CC")]
		[FieldOffset(Offset = "0x50")]
		private float m_rushTimer;

		// Token: 0x0400F4CD RID: 62669
		[Token(Token = "0x400F4CD")]
		[FieldOffset(Offset = "0x54")]
		private float m_rushTimeDuration;

		// Token: 0x0400F4CE RID: 62670
		[Token(Token = "0x400F4CE")]
		[FieldOffset(Offset = "0x58")]
		private float m_rushTimeCardCostDelta;

		// Token: 0x0400F4CF RID: 62671
		[Token(Token = "0x400F4CF")]
		[FieldOffset(Offset = "0x5C")]
		private float m_rushTimeRespawnDecFactor;

		// Token: 0x0400F4D0 RID: 62672
		[Token(Token = "0x400F4D0")]
		[FieldOffset(Offset = "0x60")]
		private int m_bonusCharacterScoreFactor;

		// Token: 0x0400F4D1 RID: 62673
		[Token(Token = "0x400F4D1")]
		[FieldOffset(Offset = "0x64")]
		private int m_enemyScoreFactor;

		// Token: 0x0400F4D2 RID: 62674
		[Token(Token = "0x400F4D2")]
		[FieldOffset(Offset = "0x68")]
		private int m_activePckstpIndex;

		// Token: 0x0400F4D3 RID: 62675
		[Token(Token = "0x400F4D3")]
		[FieldOffset(Offset = "0x70")]
		private CameraEffect m_screenEffect;

		// Token: 0x0400F4D4 RID: 62676
		[Token(Token = "0x400F4D4")]
		[FieldOffset(Offset = "0x78")]
		private Act44SideBattleManager.GameStage m_curGameStage;

		// Token: 0x0400F4D5 RID: 62677
		[Token(Token = "0x400F4D5")]
		[FieldOffset(Offset = "0x80")]
		private List<Trap> m_pckstpList;

		// Token: 0x0400F4D6 RID: 62678
		[Token(Token = "0x400F4D6")]
		[FieldOffset(Offset = "0x88")]
		private List<Deck.Card> m_chosenCardDeployCntFree;

		// Token: 0x0400F4D7 RID: 62679
		[Token(Token = "0x400F4D7")]
		[FieldOffset(Offset = "0x90")]
		private List<Deck.Card> m_cardRespawnTimeDecNeeded;

		// Token: 0x0400F4D8 RID: 62680
		[Token(Token = "0x400F4D8")]
		[FieldOffset(Offset = "0x98")]
		private Dictionary<DynamicBuffTileFixed, float> m_bonusTileEffectDict;

		// Token: 0x0400F4D9 RID: 62681
		[Token(Token = "0x400F4D9")]
		[FieldOffset(Offset = "0xA0")]
		private List<DynamicBuffTileFixed> m_bonusTileList;

		// Token: 0x0400F4DA RID: 62682
		[Token(Token = "0x400F4DA")]
		[FieldOffset(Offset = "0xA8")]
		private float m_curGrade;

		// Token: 0x0400F4DB RID: 62683
		[Token(Token = "0x400F4DB")]
		[FieldOffset(Offset = "0xAC")]
		private int m_maxPlayTime;

		// Token: 0x0400F4DC RID: 62684
		[Token(Token = "0x400F4DC")]
		[FieldOffset(Offset = "0xB0")]
		private int m_bonusCharacterGradeFactor;

		// Token: 0x0400F4DD RID: 62685
		[Token(Token = "0x400F4DD")]
		[FieldOffset(Offset = "0xB4")]
		private float m_pushYmgpckEachAddGradeRate;

		// Token: 0x0400F4DE RID: 62686
		[Token(Token = "0x400F4DE")]
		[FieldOffset(Offset = "0xB8")]
		private float m_pushYmgpckEachAddMaxGradeRate;

		// Token: 0x0400F4DF RID: 62687
		[Token(Token = "0x400F4DF")]
		[FieldOffset(Offset = "0xC0")]
		private Dictionary<string, int> m_enemyFallDownGrade;

		// Token: 0x0400F4E0 RID: 62688
		[Token(Token = "0x400F4E0")]
		[FieldOffset(Offset = "0xC8")]
		private Dictionary<string, int> m_enemyPushYmgpckGrade;

		// Token: 0x0400F4E1 RID: 62689
		[Token(Token = "0x400F4E1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_pckstpList;

		// Token: 0x0400F4E2 RID: 62690
		[Token(Token = "0x400F4E2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isInRushTime;

		// Token: 0x0400F4E3 RID: 62691
		[Token(Token = "0x400F4E3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_curScore;

		// Token: 0x0400F4E4 RID: 62692
		[Token(Token = "0x400F4E4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_totalScore;

		// Token: 0x0400F4E5 RID: 62693
		[Token(Token = "0x400F4E5")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_rushTimeRemainingRate;

		// Token: 0x0400F4E6 RID: 62694
		[Token(Token = "0x400F4E6")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_curProgressMultiValue;

		// Token: 0x0400F4E7 RID: 62695
		[Token(Token = "0x400F4E7")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isExtraGameType;

		// Token: 0x0400F4E8 RID: 62696
		[Token(Token = "0x400F4E8")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_maxPlayTime;

		// Token: 0x0400F4E9 RID: 62697
		[Token(Token = "0x400F4E9")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_curGrade;

		// Token: 0x0400F4EA RID: 62698
		[Token(Token = "0x400F4EA")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F4EB RID: 62699
		[Token(Token = "0x400F4EB")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F4EC RID: 62700
		[Token(Token = "0x400F4EC")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F4ED RID: 62701
		[Token(Token = "0x400F4ED")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitParams;

		// Token: 0x0400F4EE RID: 62702
		[Token(Token = "0x400F4EE")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__InitEnemyGradeDictionary;

		// Token: 0x0400F4EF RID: 62703
		[Token(Token = "0x400F4EF")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__CollectPckstp;

		// Token: 0x0400F4F0 RID: 62704
		[Token(Token = "0x400F4F0")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CollectBonusTile;

		// Token: 0x0400F4F1 RID: 62705
		[Token(Token = "0x400F4F1")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__DoCheckEndRushTimeStage;

		// Token: 0x0400F4F2 RID: 62706
		[Token(Token = "0x400F4F2")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__DoUpdateBonusTileEffect;

		// Token: 0x0400F4F3 RID: 62707
		[Token(Token = "0x400F4F3")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SwitchAllPckstpMode;

		// Token: 0x0400F4F4 RID: 62708
		[Token(Token = "0x400F4F4")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__RecordActivePckstp;

		// Token: 0x0400F4F5 RID: 62709
		[Token(Token = "0x400F4F5")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__StartRushTime;

		// Token: 0x0400F4F6 RID: 62710
		[Token(Token = "0x400F4F6")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__ContinueRushTime;

		// Token: 0x0400F4F7 RID: 62711
		[Token(Token = "0x400F4F7")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__EndRushTime;

		// Token: 0x0400F4F8 RID: 62712
		[Token(Token = "0x400F4F8")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__ResetScoreState;

		// Token: 0x0400F4F9 RID: 62713
		[Token(Token = "0x400F4F9")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__ControlScreenEffect;

		// Token: 0x0400F4FA RID: 62714
		[Token(Token = "0x400F4FA")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__GainScore;

		// Token: 0x0400F4FB RID: 62715
		[Token(Token = "0x400F4FB")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__GainGrade;

		// Token: 0x0400F4FC RID: 62716
		[Token(Token = "0x400F4FC")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__StartRushTimeBonusToCostMostCard;

		// Token: 0x0400F4FD RID: 62717
		[Token(Token = "0x400F4FD")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__CreateDeployCardBuff;

		// Token: 0x0400F4FE RID: 62718
		[Token(Token = "0x400F4FE")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__CreateRespawnCardBuff;

		// Token: 0x0400F4FF RID: 62719
		[Token(Token = "0x400F4FF")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__CreateDeployDeckBuff;

		// Token: 0x0400F500 RID: 62720
		[Token(Token = "0x400F500")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__EndAllCardRushTimeBonus;

		// Token: 0x0400F501 RID: 62721
		[Token(Token = "0x400F501")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__CheckGameFinish;

		// Token: 0x0400F502 RID: 62722
		[Token(Token = "0x400F502")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400F503 RID: 62723
		[Token(Token = "0x400F503")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x0400F504 RID: 62724
		[Token(Token = "0x400F504")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__OnGameOver;

		// Token: 0x0400F505 RID: 62725
		[Token(Token = "0x400F505")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_GatherAudio;

		// Token: 0x0400F506 RID: 62726
		[Token(Token = "0x400F506")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_TouchWithEntityGainScore;

		// Token: 0x0400F507 RID: 62727
		[Token(Token = "0x400F507")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_EndRushTimeByBoss;

		// Token: 0x0400F508 RID: 62728
		[Token(Token = "0x400F508")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_TouchWithEntityGainGrade;

		// Token: 0x0400F509 RID: 62729
		[Token(Token = "0x400F509")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_EnemyFallDownGainGrade;

		// Token: 0x0400F50A RID: 62730
		[Token(Token = "0x400F50A")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020022D3 RID: 8915
		[Token(Token = "0x20022D3")]
		public enum GameStage
		{
			// Token: 0x0400F50C RID: 62732
			[Token(Token = "0x400F50C")]
			NORMAL,
			// Token: 0x0400F50D RID: 62733
			[Token(Token = "0x400F50D")]
			RUSHTIME
		}
	}
}
