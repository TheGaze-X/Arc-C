using System;
using System.Collections.Generic;
using System.Reflection;
using CodeStage.AntiCheat.ObscuredTypes;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000ECF RID: 3791
	[Token(Token = "0x2000ECF")]
	[Serializable]
	public class AttributesData
	{
		// Token: 0x17000D03 RID: 3331
		// (get) Token: 0x06006BA7 RID: 27559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000D03")]
		public static List<AttributesData.FieldMeta> fieldMetas
		{
			[Token(Token = "0x6006BA7")]
			[Address(RVA = "0x2000930", Offset = "0x1FFF530", VA = "0x182000930")]
			get
			{
				return null;
			}
		}

		// Token: 0x06006BA8 RID: 27560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA8")]
		[Address(RVA = "0x1FFF210", Offset = "0x1FFDE10", VA = "0x181FFF210")]
		public void Assign(AttributesData other)
		{
		}

		// Token: 0x06006BA9 RID: 27561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BA9")]
		[Address(RVA = "0x1FFF020", Offset = "0x1FFDC20", VA = "0x181FFF020")]
		public void ApplyDelta(AttributesData delta)
		{
		}

		// Token: 0x06006BAA RID: 27562 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006BAA")]
		[Address(RVA = "0x1FFF5F0", Offset = "0x1FFE1F0", VA = "0x181FFF5F0")]
		public static AttributesData Lerp(AttributesData a, AttributesData b, float t)
		{
			return null;
		}

		// Token: 0x06006BAB RID: 27563 RVA: 0x00031410 File Offset: 0x0002F610
		[Token(Token = "0x6006BAB")]
		[Address(RVA = "0x1FFF930", Offset = "0x1FFE530", VA = "0x181FFF930")]
		public static float ReadAttributesField(object fieldVal)
		{
			return 0f;
		}

		// Token: 0x06006BAC RID: 27564 RVA: 0x00031428 File Offset: 0x0002F628
		[Token(Token = "0x6006BAC")]
		[Address(RVA = "0x1FFFB90", Offset = "0x1FFE790", VA = "0x181FFFB90")]
		public static bool WriteAttributesField(FieldInfo field, AttributesData attr, float value)
		{
			return default(bool);
		}

		// Token: 0x06006BAD RID: 27565 RVA: 0x00031440 File Offset: 0x0002F640
		[Token(Token = "0x6006BAD")]
		[Address(RVA = "0x1FFFEC0", Offset = "0x1FFEAC0", VA = "0x181FFFEC0")]
		public static bool WriteAttributesField(FieldInfo field, AttributesData attr, FP value)
		{
			return default(bool);
		}

		// Token: 0x06006BAE RID: 27566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006BAE")]
		[Address(RVA = "0x2000460", Offset = "0x1FFF060", VA = "0x182000460")]
		public AttributesData()
		{
		}

		// Token: 0x0400500C RID: 20492
		[Token(Token = "0x400500C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly AttributesData ZERO;

		// Token: 0x0400500D RID: 20493
		[Token(Token = "0x400500D")]
		[FieldOffset(Offset = "0x8")]
		private static List<AttributesData.FieldMeta> s_fieldMetas;

		// Token: 0x0400500E RID: 20494
		[Token(Token = "0x400500E")]
		[FieldOffset(Offset = "0x10")]
		[AttributeMeta(AttributeType.MAX_HP, 1f)]
		public ObscuredInt maxHp;

		// Token: 0x0400500F RID: 20495
		[Token(Token = "0x400500F")]
		[FieldOffset(Offset = "0x24")]
		[AttributeMeta(AttributeType.ATK, 0f)]
		public ObscuredInt atk;

		// Token: 0x04005010 RID: 20496
		[Token(Token = "0x4005010")]
		[FieldOffset(Offset = "0x38")]
		[AttributeMeta(AttributeType.DEF, 0f)]
		public ObscuredInt def;

		// Token: 0x04005011 RID: 20497
		[Token(Token = "0x4005011")]
		[FieldOffset(Offset = "0x4C")]
		[AttributeMeta(AttributeType.MAGIC_RESISTANCE, 0f, 100f)]
		public ObscuredFloat magicResistance;

		// Token: 0x04005012 RID: 20498
		[Token(Token = "0x4005012")]
		[FieldOffset(Offset = "0x64")]
		[AttributeMeta(AttributeType.COST, 0f)]
		public ObscuredInt cost;

		// Token: 0x04005013 RID: 20499
		[Token(Token = "0x4005013")]
		[FieldOffset(Offset = "0x78")]
		[AttributeMeta(AttributeType.BLOCK_CNT, 0f)]
		public ObscuredInt blockCnt;

		// Token: 0x04005014 RID: 20500
		[Token(Token = "0x4005014")]
		[FieldOffset(Offset = "0x8C")]
		[AttributeMeta(AttributeType.MOVE_SPEED, 0.1f)]
		public ObscuredFloat moveSpeed;

		// Token: 0x04005015 RID: 20501
		[Token(Token = "0x4005015")]
		[FieldOffset(Offset = "0xA4")]
		[AttributeMeta(AttributeType.ATTACK_SPEED, 20f)]
		public ObscuredFloat attackSpeed;

		// Token: 0x04005016 RID: 20502
		[Token(Token = "0x4005016")]
		[FieldOffset(Offset = "0xBC")]
		[AttributeMeta(AttributeType.BASE_ATTACK_TIME, 0f)]
		public ObscuredFloat baseAttackTime;

		// Token: 0x04005017 RID: 20503
		[Token(Token = "0x4005017")]
		[FieldOffset(Offset = "0xD4")]
		[AttributeMeta(AttributeType.RESPAWN_TIME, 0f)]
		public ObscuredInt respawnTime;

		// Token: 0x04005018 RID: 20504
		[Token(Token = "0x4005018")]
		[FieldOffset(Offset = "0xE8")]
		[AttributeMeta(AttributeType.HP_RECOVERY_PER_SEC, 0f)]
		public ObscuredFloat hpRecoveryPerSec;

		// Token: 0x04005019 RID: 20505
		[Token(Token = "0x4005019")]
		[FieldOffset(Offset = "0x100")]
		[AttributeMeta(AttributeType.SP_RECOVERY_PER_SEC, 0f)]
		public ObscuredFloat spRecoveryPerSec;

		// Token: 0x0400501A RID: 20506
		[Token(Token = "0x400501A")]
		[FieldOffset(Offset = "0x118")]
		[AttributeMeta(AttributeType.MAX_DEPLOY_COUNT, 0f)]
		public ObscuredInt maxDeployCount;

		// Token: 0x0400501B RID: 20507
		[Token(Token = "0x400501B")]
		[FieldOffset(Offset = "0x12C")]
		[AttributeMeta(AttributeType.MAX_DECK_STACK_CNT, 0f)]
		public ObscuredInt maxDeckStackCnt;

		// Token: 0x0400501C RID: 20508
		[Token(Token = "0x400501C")]
		[FieldOffset(Offset = "0x140")]
		[AttributeMeta(AttributeType.TAUNT_LEVEL, -2f, 2f)]
		public ObscuredInt tauntLevel;

		// Token: 0x0400501D RID: 20509
		[Token(Token = "0x400501D")]
		[FieldOffset(Offset = "0x154")]
		[AttributeMeta(AttributeType.MASS_LEVEL)]
		public ObscuredInt massLevel;

		// Token: 0x0400501E RID: 20510
		[Token(Token = "0x400501E")]
		[FieldOffset(Offset = "0x168")]
		[AttributeMeta(AttributeType.BASE_FORCE_LEVEL)]
		public ObscuredInt baseForceLevel;

		// Token: 0x0400501F RID: 20511
		[Token(Token = "0x400501F")]
		[FieldOffset(Offset = "0x17C")]
		[AttributeMeta(AttributeType.EP_DAMAGE_RESISTANCE, 0f, 100f)]
		[JsonIgnore]
		public ObscuredFloat epDamageResistance;

		// Token: 0x04005020 RID: 20512
		[Token(Token = "0x4005020")]
		[FieldOffset(Offset = "0x194")]
		[AttributeMeta(AttributeType.EP_RESISTANCE, 0f, 100f)]
		[JsonIgnore]
		public ObscuredFloat epResistance;

		// Token: 0x04005021 RID: 20513
		[Token(Token = "0x4005021")]
		[FieldOffset(Offset = "0x1AC")]
		[AttributeMeta(AttributeType.DAMAGE_HITRATE_PHYSICAL, 0f, 1f)]
		[JsonIgnore]
		public ObscuredFloat damageHitratePhysical;

		// Token: 0x04005022 RID: 20514
		[Token(Token = "0x4005022")]
		[FieldOffset(Offset = "0x1C4")]
		[AttributeMeta(AttributeType.DAMAGE_HITRATE_MAGICAL, 0f, 1f)]
		[JsonIgnore]
		public ObscuredFloat damageHitrateMagical;

		// Token: 0x04005023 RID: 20515
		[Token(Token = "0x4005023")]
		[FieldOffset(Offset = "0x1DC")]
		[AttributeMeta(AttributeType.ABILITY_RANGE_FORWARD_EXTEND)]
		[JsonIgnore]
		private ObscuredFloat abilityRangeForwardExtend;

		// Token: 0x04005024 RID: 20516
		[Token(Token = "0x4005024")]
		[FieldOffset(Offset = "0x1F4")]
		[AttributeMeta(AttributeType.DEF_PENETRATE, 0f, 1f)]
		[JsonIgnore]
		private ObscuredFloat defPenetrate;

		// Token: 0x04005025 RID: 20517
		[Token(Token = "0x4005025")]
		[FieldOffset(Offset = "0x20C")]
		[AttributeMeta(AttributeType.MAGIC_RESIST_PENETRATE, 0f, 1f)]
		[JsonIgnore]
		private ObscuredFloat magicResistPenetrate;

		// Token: 0x04005026 RID: 20518
		[Token(Token = "0x4005026")]
		[FieldOffset(Offset = "0x224")]
		[AttributeMeta(AttributeType.HP_RECOVERY_PER_SEC_BY_MAX_HP_RATIO, 0f, 1f)]
		[JsonIgnore]
		private ObscuredFloat hpRecoveryPerSecByMaxHpRatio;

		// Token: 0x04005027 RID: 20519
		[Token(Token = "0x4005027")]
		[FieldOffset(Offset = "0x23C")]
		[AttributeMeta(AttributeType.DEF_PENETRATE_FIXED, 0f)]
		[JsonIgnore]
		private ObscuredFloat defPenetrateFixed;

		// Token: 0x04005028 RID: 20520
		[Token(Token = "0x4005028")]
		[FieldOffset(Offset = "0x254")]
		[AttributeMeta(AttributeType.ONE_MINUS_STATUS_RESISTANCE, 0.001f, 1000f)]
		[JsonIgnore]
		private ObscuredFloat oneMinusStatusResistance;

		// Token: 0x04005029 RID: 20521
		[Token(Token = "0x4005029")]
		[FieldOffset(Offset = "0x26C")]
		[AttributeMeta(AttributeType.MAGIC_RESIST_PENETRATE_FIXED, 0f)]
		[JsonIgnore]
		private ObscuredFloat magicResistPenetrateFixed;

		// Token: 0x0400502A RID: 20522
		[Token(Token = "0x400502A")]
		[FieldOffset(Offset = "0x284")]
		[AttributeMeta(AttributeType.MAX_EP, 0f, 1000f)]
		[JsonIgnore]
		public ObscuredInt maxEp;

		// Token: 0x0400502B RID: 20523
		[Token(Token = "0x400502B")]
		[FieldOffset(Offset = "0x298")]
		[AttributeMeta(AttributeType.EP_RECOVERY_PER_SEC, 0f)]
		[JsonIgnore]
		public ObscuredFloat epRecoveryPerSec;

		// Token: 0x0400502C RID: 20524
		[Token(Token = "0x400502C")]
		[FieldOffset(Offset = "0x2B0")]
		[AttributeMeta(AttributeType.SP_RECOVER_RATIO, 0f)]
		[JsonIgnore]
		private ObscuredFloat spRecoverRatio;

		// Token: 0x0400502D RID: 20525
		[Token(Token = "0x400502D")]
		[FieldOffset(Offset = "0x2C8")]
		[AttributeMeta(AttributeType.EP_BREAK_RECOVER_SPEED, 0f)]
		[JsonIgnore]
		private ObscuredFloat epBreakRecoverSpeed;

		// Token: 0x0400502E RID: 20526
		[Token(Token = "0x400502E")]
		[FieldOffset(Offset = "0x2E0")]
		[AbnormalImmuneMeta(AbnormalFlag.STUNNED)]
		public bool stunImmune;

		// Token: 0x0400502F RID: 20527
		[Token(Token = "0x400502F")]
		[FieldOffset(Offset = "0x2E1")]
		[AbnormalImmuneMeta(AbnormalFlag.SILENCED)]
		public bool silenceImmune;

		// Token: 0x04005030 RID: 20528
		[Token(Token = "0x4005030")]
		[FieldOffset(Offset = "0x2E2")]
		[AbnormalComboImmuneMeta(AbnormalCombo.SLEEPING)]
		public bool sleepImmune;

		// Token: 0x04005031 RID: 20529
		[Token(Token = "0x4005031")]
		[FieldOffset(Offset = "0x2E3")]
		[AbnormalImmuneMeta(AbnormalFlag.FROZEN)]
		public bool frozenImmune;

		// Token: 0x04005032 RID: 20530
		[Token(Token = "0x4005032")]
		[FieldOffset(Offset = "0x2E4")]
		[AbnormalImmuneMeta(AbnormalFlag.LEVITATE)]
		public bool levitateImmune;

		// Token: 0x04005033 RID: 20531
		[Token(Token = "0x4005033")]
		[FieldOffset(Offset = "0x2E5")]
		[AbnormalImmuneMeta(AbnormalFlag.DISARMED_COMBAT)]
		public bool disarmedCombatImmune;

		// Token: 0x04005034 RID: 20532
		[Token(Token = "0x4005034")]
		[FieldOffset(Offset = "0x2E6")]
		[AbnormalImmuneMeta(AbnormalFlag.FEARED)]
		public bool fearedImmune;

		// Token: 0x04005035 RID: 20533
		[Token(Token = "0x4005035")]
		[FieldOffset(Offset = "0x2E7")]
		[AbnormalImmuneMeta(AbnormalFlag.PALSY)]
		public bool palsyImmune;

		// Token: 0x04005036 RID: 20534
		[Token(Token = "0x4005036")]
		[FieldOffset(Offset = "0x2E8")]
		[AbnormalImmuneMeta(AbnormalFlag.ATTRACTED)]
		public bool attractImmune;

		// Token: 0x02000ED0 RID: 3792
		[Token(Token = "0x2000ED0")]
		public class FieldMeta
		{
			// Token: 0x06006BB0 RID: 27568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006BB0")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public FieldMeta()
			{
			}

			// Token: 0x04005037 RID: 20535
			[Token(Token = "0x4005037")]
			[FieldOffset(Offset = "0x10")]
			public FieldInfo field;

			// Token: 0x04005038 RID: 20536
			[Token(Token = "0x4005038")]
			[FieldOffset(Offset = "0x18")]
			public bool isPrivate;

			// Token: 0x04005039 RID: 20537
			[Token(Token = "0x4005039")]
			[FieldOffset(Offset = "0x20")]
			public AttributeMetaAttribute attributeMeta;

			// Token: 0x0400503A RID: 20538
			[Token(Token = "0x400503A")]
			[FieldOffset(Offset = "0x28")]
			public AbnormalImmuneMetaAttribute abnormalImmuneMeta;

			// Token: 0x0400503B RID: 20539
			[Token(Token = "0x400503B")]
			[FieldOffset(Offset = "0x30")]
			public AbnormalComboImmuneMetaAttribute abnormalComboImmuneMeta;
		}
	}
}
