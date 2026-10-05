using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002331 RID: 9009
	[Token(Token = "0x2002331")]
	public class Mainline14LrdeadP2Manager : GlobalEnvSystem.EnvManager, IBuffSource, IHotfixable, IAudioSource
	{
		// Token: 0x17001C89 RID: 7305
		// (get) Token: 0x0600E39E RID: 58270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C89")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E39E")]
			[Address(RVA = "0x587560", Offset = "0x586160", VA = "0x180587560", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E39F RID: 58271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E39F")]
		[Address(RVA = "0x581C20", Offset = "0x580820", VA = "0x180581C20", Slot = "7")]
		public override void Init(GlobalEnvSystem owner)
		{
		}

		// Token: 0x0600E3A0 RID: 58272 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3A0")]
		[Address(RVA = "0x581F80", Offset = "0x580B80", VA = "0x180581F80", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E3A1 RID: 58273 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3A1")]
		[Address(RVA = "0x581BA0", Offset = "0x5807A0", VA = "0x180581BA0", Slot = "10")]
		public override void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x0600E3A2 RID: 58274 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3A2")]
		[Address(RVA = "0x582200", Offset = "0x580E00", VA = "0x180582200")]
		public void TriggerSkill(bool isEnemy)
		{
		}

		// Token: 0x0600E3A3 RID: 58275 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3A3")]
		[Address(RVA = "0x584F50", Offset = "0x583B50", VA = "0x180584F50")]
		private void _StartTimer()
		{
		}

		// Token: 0x0600E3A4 RID: 58276 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3A4")]
		[Address(RVA = "0x581EE0", Offset = "0x580AE0", VA = "0x180581EE0")]
		public void LrdeadDead()
		{
		}

		// Token: 0x0600E3A5 RID: 58277 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3A5")]
		[Address(RVA = "0x584910", Offset = "0x583510", VA = "0x180584910")]
		private void _OnGameOver(object arg)
		{
		}

		// Token: 0x0600E3A6 RID: 58278 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3A6")]
		[Address(RVA = "0x5848A0", Offset = "0x5834A0", VA = "0x1805848A0")]
		private void _OnGameGiveUp(object arg)
		{
		}

		// Token: 0x0600E3A7 RID: 58279 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3A7")]
		[Address(RVA = "0x584980", Offset = "0x583580", VA = "0x180584980")]
		private void _ProcessBlackboard()
		{
		}

		// Token: 0x0600E3A8 RID: 58280 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3A8")]
		[Address(RVA = "0x585010", Offset = "0x583C10", VA = "0x180585010")]
		private void _TriggerAudioSignal(float oldEffectOffset, bool isTriggeredByEnemy)
		{
		}

		// Token: 0x0600E3A9 RID: 58281 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3A9")]
		[Address(RVA = "0x581A20", Offset = "0x580620", VA = "0x180581A20", Slot = "16")]
		public void GatherAudio(List<string> results)
		{
		}

		// Token: 0x0600E3AA RID: 58282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3AA")]
		[Address(RVA = "0x582530", Offset = "0x581130", VA = "0x180582530")]
		private void _ClearEffects()
		{
		}

		// Token: 0x0600E3AB RID: 58283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3AB")]
		[Address(RVA = "0x582FE0", Offset = "0x581BE0", VA = "0x180582FE0")]
		private void _CreateEffects(int level, bool isAlly)
		{
		}

		// Token: 0x0600E3AC RID: 58284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3AC")]
		[Address(RVA = "0x584690", Offset = "0x583290", VA = "0x180584690")]
		private void _InitEffectPos(Mainline14LrdeadP2Manager.EffectWithLineRenderer effectPair, int row, bool isAlly)
		{
		}

		// Token: 0x0600E3AD RID: 58285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3AD")]
		[Address(RVA = "0x585D90", Offset = "0x584990", VA = "0x180585D90")]
		private void _UpdateEnemyEffectDestination(int level)
		{
		}

		// Token: 0x0600E3AE RID: 58286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3AE")]
		[Address(RVA = "0x5854C0", Offset = "0x5840C0", VA = "0x1805854C0")]
		private void _UpdateAllyEffectDestination(int level)
		{
		}

		// Token: 0x0600E3AF RID: 58287 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3AF")]
		[Address(RVA = "0x585B70", Offset = "0x584770", VA = "0x180585B70")]
		private void _UpdateEffectCrossCol()
		{
		}

		// Token: 0x0600E3B0 RID: 58288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3B0")]
		[Address(RVA = "0x584470", Offset = "0x583070", VA = "0x180584470")]
		private void _HideEffect(int level, bool isAlly)
		{
		}

		// Token: 0x0600E3B1 RID: 58289 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3B1")]
		[Address(RVA = "0x586030", Offset = "0x584C30", VA = "0x180586030")]
		private void _UpdateEnemyStartEffect()
		{
		}

		// Token: 0x0600E3B2 RID: 58290 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3B2")]
		[Address(RVA = "0x586480", Offset = "0x585080", VA = "0x180586480")]
		private void _UpdateHitEffectCol()
		{
		}

		// Token: 0x0600E3B3 RID: 58291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3B3")]
		[Address(RVA = "0x582E50", Offset = "0x581A50", VA = "0x180582E50")]
		private void _CreateAllyOneShotStartEffect()
		{
		}

		// Token: 0x0600E3B4 RID: 58292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3B4")]
		[Address(RVA = "0x585750", Offset = "0x584350", VA = "0x180585750")]
		private void _UpdateAllyStartEffect()
		{
		}

		// Token: 0x0600E3B5 RID: 58293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3B5")]
		[Address(RVA = "0x583960", Offset = "0x582560", VA = "0x180583960")]
		private void _DealEnemyToAllyDamage(FP deltaTime)
		{
		}

		// Token: 0x0600E3B6 RID: 58294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3B6")]
		[Address(RVA = "0x583F20", Offset = "0x582B20", VA = "0x180583F20")]
		private void _DealEnemyToLrcoreDamage(FP deltaTime)
		{
		}

		// Token: 0x0600E3B7 RID: 58295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3B7")]
		[Address(RVA = "0x583380", Offset = "0x581F80", VA = "0x180583380")]
		private void _DealAllyToEnemyDamage(FP deltaTime)
		{
		}

		// Token: 0x0600E3B8 RID: 58296 RVA: 0x000525F0 File Offset: 0x000507F0
		[Token(Token = "0x600E3B8")]
		[Address(RVA = "0x586F20", Offset = "0x585B20", VA = "0x180586F20")]
		private bool _ValidEntityShoulTakeDamage(Entity target, bool isAlly)
		{
			return default(bool);
		}

		// Token: 0x0600E3B9 RID: 58297 RVA: 0x00052608 File Offset: 0x00050808
		[Token(Token = "0x600E3B9")]
		[Address(RVA = "0x5870C0", Offset = "0x585CC0", VA = "0x1805870C0")]
		private bool _ValidateCharacter(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600E3BA RID: 58298 RVA: 0x00052620 File Offset: 0x00050820
		[Token(Token = "0x600E3BA")]
		[Address(RVA = "0x5871A0", Offset = "0x585DA0", VA = "0x1805871A0")]
		private bool _ValidateEnemy(Enemy enemy)
		{
			return default(bool);
		}

		// Token: 0x0600E3BB RID: 58299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3BB")]
		[Address(RVA = "0x587290", Offset = "0x585E90", VA = "0x180587290")]
		public Mainline14LrdeadP2Manager()
		{
		}

		// Token: 0x0600E3BC RID: 58300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E3BC")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E3BD RID: 58301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3BD")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E3BE RID: 58302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3BE")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600E3BF RID: 58303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E3BF")]
		[Address(RVA = "0x550BC0", Offset = "0x54F7C0", VA = "0x180550BC0")]
		private void <>xLuaBaseProxy_GatherBuffs(List<BuffData> P0)
		{
		}

		// Token: 0x0400FA25 RID: 64037
		[Token(Token = "0x400FA25")]
		private const int EFFECT_LEVEL = 3;

		// Token: 0x0400FA26 RID: 64038
		[Token(Token = "0x400FA26")]
		private const float ENEMY_EXCEED_OFFSET = -100f;

		// Token: 0x0400FA27 RID: 64039
		[Token(Token = "0x400FA27")]
		private const float ENEMY_EXCEED_OFFSET_WHEN_SKILL_TRIGGERED = 0.5f;

		// Token: 0x0400FA28 RID: 64040
		[Token(Token = "0x400FA28")]
		private const float ALLY_EXCEED_OFFSET = 2f;

		// Token: 0x0400FA29 RID: 64041
		[Token(Token = "0x400FA29")]
		private const float ALLY_EXCEED_OFFSET_WHEN_BOSS_DEAD = 100f;

		// Token: 0x0400FA2A RID: 64042
		[Token(Token = "0x400FA2A")]
		private const string ROW_KEY = "row";

		// Token: 0x0400FA2B RID: 64043
		[Token(Token = "0x400FA2B")]
		private const string LRDEAD_CUSTOM_KEY = "lrdead";

		// Token: 0x0400FA2C RID: 64044
		[Token(Token = "0x400FA2C")]
		private const string LRCORE_MARK_KEY = "trap_lrcore[decrease_lifpoint_when_dead]";

		// Token: 0x0400FA2D RID: 64045
		[Token(Token = "0x400FA2D")]
		private const string ENEMY_AUDIO_START_LEVEL_1 = "enemy_audio_start_level_1";

		// Token: 0x0400FA2E RID: 64046
		[Token(Token = "0x400FA2E")]
		private const string ENEMY_AUDIO_START_LEVEL_2 = "enemy_audio_start_level_2";

		// Token: 0x0400FA2F RID: 64047
		[Token(Token = "0x400FA2F")]
		private const string ENEMY_AUDIO_START_LEVEL_3 = "enemy_audio_start_level_3";

		// Token: 0x0400FA30 RID: 64048
		[Token(Token = "0x400FA30")]
		private const string ENEMY_AUDIO_END_LEVEL_1 = "enemy_audio_end_level_1";

		// Token: 0x0400FA31 RID: 64049
		[Token(Token = "0x400FA31")]
		private const string ENEMY_AUDIO_END_LEVEL_2 = "enemy_audio_end_level_2";

		// Token: 0x0400FA32 RID: 64050
		[Token(Token = "0x400FA32")]
		private const string ENEMY_AUDIO_END_LEVEL_3 = "enemy_audio_end_level_3";

		// Token: 0x0400FA33 RID: 64051
		[Token(Token = "0x400FA33")]
		private const string ALLY_AUDIO = "ally_audio";

		// Token: 0x0400FA34 RID: 64052
		[Token(Token = "0x400FA34")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string[] _allyEffectKeys;

		// Token: 0x0400FA35 RID: 64053
		[Token(Token = "0x400FA35")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string[] _enemyEffectKeys;

		// Token: 0x0400FA36 RID: 64054
		[Token(Token = "0x400FA36")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _enemyEffectStartCol;

		// Token: 0x0400FA37 RID: 64055
		[Token(Token = "0x400FA37")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _allyEffectStartCol;

		// Token: 0x0400FA38 RID: 64056
		[Token(Token = "0x400FA38")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Vector3 _enemyEffStartPointOffset;

		// Token: 0x0400FA39 RID: 64057
		[Token(Token = "0x400FA39")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Vector3 _allyEffStartPointOffset;

		// Token: 0x0400FA3A RID: 64058
		[Token(Token = "0x400FA3A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Vector3 _enemyStartEffOffset;

		// Token: 0x0400FA3B RID: 64059
		[Token(Token = "0x400FA3B")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private string _markBuffKey;

		// Token: 0x0400FA3C RID: 64060
		[Token(Token = "0x400FA3C")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private string _excludeBuffKey;

		// Token: 0x0400FA3D RID: 64061
		[Token(Token = "0x400FA3D")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private string _allyCrossHitEffectKey;

		// Token: 0x0400FA3E RID: 64062
		[Token(Token = "0x400FA3E")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private string _enemyCrossHitEffectKey;

		// Token: 0x0400FA3F RID: 64063
		[Token(Token = "0x400FA3F")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private string _enemyHitAllyEffectKey;

		// Token: 0x0400FA40 RID: 64064
		[Token(Token = "0x400FA40")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string _enemyStartEffectKey;

		// Token: 0x0400FA41 RID: 64065
		[Token(Token = "0x400FA41")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private string _allyStartEffectKey;

		// Token: 0x0400FA42 RID: 64066
		[Token(Token = "0x400FA42")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private string _allyOneShotStartEffectKey;

		// Token: 0x0400FA43 RID: 64067
		[Token(Token = "0x400FA43")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private float _allyStartEffectDelay;

		// Token: 0x0400FA44 RID: 64068
		[Token(Token = "0x400FA44")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		private float _allyHitEffectXAxisOffset;

		// Token: 0x0400FA45 RID: 64069
		[Token(Token = "0x400FA45")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private float _enemyHitEffectXAxisOffset;

		// Token: 0x0400FA46 RID: 64070
		[Token(Token = "0x400FA46")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		private float _hitEffectZAxisOffset;

		// Token: 0x0400FA47 RID: 64071
		[Token(Token = "0x400FA47")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private float _crossPositionXAxisOffset;

		// Token: 0x0400FA48 RID: 64072
		[Token(Token = "0x400FA48")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		private int _row;

		// Token: 0x0400FA49 RID: 64073
		[Token(Token = "0x400FA49")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isEnemySkillActived;

		// Token: 0x0400FA4A RID: 64074
		[Token(Token = "0x400FA4A")]
		[FieldOffset(Offset = "0xC1")]
		private bool m_isAllySkillActived;

		// Token: 0x0400FA4B RID: 64075
		[Token(Token = "0x400FA4B")]
		[FieldOffset(Offset = "0xC2")]
		private bool m_isBossDead;

		// Token: 0x0400FA4C RID: 64076
		[Token(Token = "0x400FA4C")]
		[FieldOffset(Offset = "0xC4")]
		private float m_targetCenterXOffset;

		// Token: 0x0400FA4D RID: 64077
		[Token(Token = "0x400FA4D")]
		[FieldOffset(Offset = "0xC8")]
		private float m_allyExceedOffset;

		// Token: 0x0400FA4E RID: 64078
		[Token(Token = "0x400FA4E")]
		[FieldOffset(Offset = "0xCC")]
		private int m_allySkillTriggerCount;

		// Token: 0x0400FA4F RID: 64079
		[Token(Token = "0x400FA4F")]
		[FieldOffset(Offset = "0xD0")]
		private int m_enemySkillTriggerCount;

		// Token: 0x0400FA50 RID: 64080
		[Token(Token = "0x400FA50")]
		[FieldOffset(Offset = "0xD4")]
		private float m_enemyEffectStartCol;

		// Token: 0x0400FA51 RID: 64081
		[Token(Token = "0x400FA51")]
		[FieldOffset(Offset = "0xD8")]
		private float m_allyEffectStartCol;

		// Token: 0x0400FA52 RID: 64082
		[Token(Token = "0x400FA52")]
		[FieldOffset(Offset = "0xE0")]
		private List<int> m_difs;

		// Token: 0x0400FA53 RID: 64083
		[Token(Token = "0x400FA53")]
		[FieldOffset(Offset = "0xE8")]
		private List<int> m_offsets;

		// Token: 0x0400FA54 RID: 64084
		[Token(Token = "0x400FA54")]
		[FieldOffset(Offset = "0xF0")]
		private int m_curEnemyEffectLevel;

		// Token: 0x0400FA55 RID: 64085
		[Token(Token = "0x400FA55")]
		[FieldOffset(Offset = "0xF4")]
		private int m_curAllyEffectLevel;

		// Token: 0x0400FA56 RID: 64086
		[Token(Token = "0x400FA56")]
		[FieldOffset(Offset = "0xF8")]
		private int m_row;

		// Token: 0x0400FA57 RID: 64087
		[Token(Token = "0x400FA57")]
		[FieldOffset(Offset = "0x100")]
		private PeriodicTimer m_allySkillTimer;

		// Token: 0x0400FA58 RID: 64088
		[Token(Token = "0x400FA58")]
		[FieldOffset(Offset = "0x108")]
		private float m_allyAtk;

		// Token: 0x0400FA59 RID: 64089
		[Token(Token = "0x400FA59")]
		[FieldOffset(Offset = "0x10C")]
		private float m_allyAtkStep;

		// Token: 0x0400FA5A RID: 64090
		[Token(Token = "0x400FA5A")]
		[FieldOffset(Offset = "0x110")]
		private float m_allyAtkBound;

		// Token: 0x0400FA5B RID: 64091
		[Token(Token = "0x400FA5B")]
		[FieldOffset(Offset = "0x114")]
		private float m_atkScaleToBoss;

		// Token: 0x0400FA5C RID: 64092
		[Token(Token = "0x400FA5C")]
		[FieldOffset(Offset = "0x118")]
		private float m_enemyAtk;

		// Token: 0x0400FA5D RID: 64093
		[Token(Token = "0x400FA5D")]
		[FieldOffset(Offset = "0x11C")]
		private float m_enemyAtkStep;

		// Token: 0x0400FA5E RID: 64094
		[Token(Token = "0x400FA5E")]
		[FieldOffset(Offset = "0x120")]
		private float m_enemyAtkBound;

		// Token: 0x0400FA5F RID: 64095
		[Token(Token = "0x400FA5F")]
		[FieldOffset(Offset = "0x128")]
		private PeriodicTimer m_dmgTickTimer;

		// Token: 0x0400FA60 RID: 64096
		[Token(Token = "0x400FA60")]
		[FieldOffset(Offset = "0x130")]
		private float m_dmgInterval;

		// Token: 0x0400FA61 RID: 64097
		[Token(Token = "0x400FA61")]
		[FieldOffset(Offset = "0x134")]
		private bool m_applyDamageToLrcores;

		// Token: 0x0400FA62 RID: 64098
		[Token(Token = "0x400FA62")]
		[FieldOffset(Offset = "0x138")]
		private Dictionary<int, List<Mainline14LrdeadP2Manager.EffectWithLineRenderer>> m_allyEffectsDict;

		// Token: 0x0400FA63 RID: 64099
		[Token(Token = "0x400FA63")]
		[FieldOffset(Offset = "0x140")]
		private Dictionary<int, List<Mainline14LrdeadP2Manager.EffectWithLineRenderer>> m_enemyEffectsDict;

		// Token: 0x0400FA64 RID: 64100
		[Token(Token = "0x400FA64")]
		[FieldOffset(Offset = "0x148")]
		private List<Effect> m_enemyHitEffectsList;

		// Token: 0x0400FA65 RID: 64101
		[Token(Token = "0x400FA65")]
		[FieldOffset(Offset = "0x150")]
		private List<Effect> m_allyHitEffectsList;

		// Token: 0x0400FA66 RID: 64102
		[Token(Token = "0x400FA66")]
		[FieldOffset(Offset = "0x158")]
		private List<Effect> m_enemyStartEffectsList;

		// Token: 0x0400FA67 RID: 64103
		[Token(Token = "0x400FA67")]
		[FieldOffset(Offset = "0x160")]
		private List<Effect> m_allyStartEffectsList;

		// Token: 0x0400FA68 RID: 64104
		[Token(Token = "0x400FA68")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400FA69 RID: 64105
		[Token(Token = "0x400FA69")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FA6A RID: 64106
		[Token(Token = "0x400FA6A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400FA6B RID: 64107
		[Token(Token = "0x400FA6B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0400FA6C RID: 64108
		[Token(Token = "0x400FA6C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TriggerSkill;

		// Token: 0x0400FA6D RID: 64109
		[Token(Token = "0x400FA6D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__StartTimer;

		// Token: 0x0400FA6E RID: 64110
		[Token(Token = "0x400FA6E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LrdeadDead;

		// Token: 0x0400FA6F RID: 64111
		[Token(Token = "0x400FA6F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnGameOver;

		// Token: 0x0400FA70 RID: 64112
		[Token(Token = "0x400FA70")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnGameGiveUp;

		// Token: 0x0400FA71 RID: 64113
		[Token(Token = "0x400FA71")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ProcessBlackboard;

		// Token: 0x0400FA72 RID: 64114
		[Token(Token = "0x400FA72")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TriggerAudioSignal;

		// Token: 0x0400FA73 RID: 64115
		[Token(Token = "0x400FA73")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GatherAudio;

		// Token: 0x0400FA74 RID: 64116
		[Token(Token = "0x400FA74")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ClearEffects;

		// Token: 0x0400FA75 RID: 64117
		[Token(Token = "0x400FA75")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__CreateEffects;

		// Token: 0x0400FA76 RID: 64118
		[Token(Token = "0x400FA76")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__InitEffectPos;

		// Token: 0x0400FA77 RID: 64119
		[Token(Token = "0x400FA77")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__UpdateEnemyEffectDestination;

		// Token: 0x0400FA78 RID: 64120
		[Token(Token = "0x400FA78")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__UpdateAllyEffectDestination;

		// Token: 0x0400FA79 RID: 64121
		[Token(Token = "0x400FA79")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateEffectCrossCol;

		// Token: 0x0400FA7A RID: 64122
		[Token(Token = "0x400FA7A")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__HideEffect;

		// Token: 0x0400FA7B RID: 64123
		[Token(Token = "0x400FA7B")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__UpdateEnemyStartEffect;

		// Token: 0x0400FA7C RID: 64124
		[Token(Token = "0x400FA7C")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__UpdateHitEffectCol;

		// Token: 0x0400FA7D RID: 64125
		[Token(Token = "0x400FA7D")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__CreateAllyOneShotStartEffect;

		// Token: 0x0400FA7E RID: 64126
		[Token(Token = "0x400FA7E")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__UpdateAllyStartEffect;

		// Token: 0x0400FA7F RID: 64127
		[Token(Token = "0x400FA7F")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__DealEnemyToAllyDamage;

		// Token: 0x0400FA80 RID: 64128
		[Token(Token = "0x400FA80")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__DealEnemyToLrcoreDamage;

		// Token: 0x0400FA81 RID: 64129
		[Token(Token = "0x400FA81")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__DealAllyToEnemyDamage;

		// Token: 0x0400FA82 RID: 64130
		[Token(Token = "0x400FA82")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__ValidEntityShoulTakeDamage;

		// Token: 0x0400FA83 RID: 64131
		[Token(Token = "0x400FA83")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__ValidateCharacter;

		// Token: 0x0400FA84 RID: 64132
		[Token(Token = "0x400FA84")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__ValidateEnemy;

		// Token: 0x0400FA85 RID: 64133
		[Token(Token = "0x400FA85")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002332 RID: 9010
		[Token(Token = "0x2002332")]
		private class EffectWithLineRenderer
		{
			// Token: 0x0600E3C0 RID: 58304 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E3C0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EffectWithLineRenderer()
			{
			}

			// Token: 0x0400FA86 RID: 64134
			[Token(Token = "0x400FA86")]
			[FieldOffset(Offset = "0x10")]
			public Effect effect;

			// Token: 0x0400FA87 RID: 64135
			[Token(Token = "0x400FA87")]
			[FieldOffset(Offset = "0x18")]
			public LineRenderer[] lineRenderers;
		}
	}
}
