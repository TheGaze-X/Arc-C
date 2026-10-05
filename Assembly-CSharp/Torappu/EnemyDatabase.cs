using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200102D RID: 4141
	[Token(Token = "0x200102D")]
	public class EnemyDatabase
	{
		// Token: 0x06006D7D RID: 28029 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D7D")]
		[Address(RVA = "0x21022F0", Offset = "0x2100EF0", VA = "0x1821022F0")]
		public EnemyDatabase.EnemyData GetEnemyLevelData(string id, int level, out bool isDefaultLevel)
		{
			return null;
		}

		// Token: 0x06006D7E RID: 28030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D7E")]
		[Address(RVA = "0x21025B0", Offset = "0x21011B0", VA = "0x1821025B0")]
		public static void OverwriteEnemyData(EnemyDatabase.EnemyData levelData, EnemyDatabase.EnemyData overwrittenData, out bool isOverwritten)
		{
		}

		// Token: 0x06006D7F RID: 28031 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D7F")]
		[Address(RVA = "0x2101FF0", Offset = "0x2100BF0", VA = "0x182101FF0")]
		public LevelData.EnemyData GetComputedEnemyData(string id, int level = -1)
		{
			return null;
		}

		// Token: 0x06006D80 RID: 28032 RVA: 0x00031C98 File Offset: 0x0002FE98
		[Token(Token = "0x6006D80")]
		[Address(RVA = "0x2102480", Offset = "0x2101080", VA = "0x182102480")]
		public bool IsEnemyExist(string id, int level)
		{
			return default(bool);
		}

		// Token: 0x06006D81 RID: 28033 RVA: 0x00031CB0 File Offset: 0x0002FEB0
		[Token(Token = "0x6006D81")]
		[Address(RVA = "0x2102530", Offset = "0x2101130", VA = "0x182102530")]
		public bool IsEnemyLevelsExist(string id)
		{
			return default(bool);
		}

		// Token: 0x06006D82 RID: 28034 RVA: 0x00031CC8 File Offset: 0x0002FEC8
		[Token(Token = "0x6006D82")]
		[Address(RVA = "0x2101ED0", Offset = "0x2100AD0", VA = "0x182101ED0")]
		public KeyValuePair<string, List<EnemyDatabase.EnemyLevel>> FindEnemyLevelsById(string id)
		{
			return default(KeyValuePair<string, List<EnemyDatabase.EnemyLevel>>);
		}

		// Token: 0x06006D83 RID: 28035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D83")]
		[Address(RVA = "0x2101CF0", Offset = "0x21008F0", VA = "0x182101CF0")]
		public static void ApplyDefinedData(LevelData.EnemyData data, EnemyDatabase.EnemyData delta)
		{
		}

		// Token: 0x06006D84 RID: 28036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D84")]
		[Address(RVA = "0x21033F0", Offset = "0x2101FF0", VA = "0x1821033F0")]
		private static void _ApplyUndefinableData(object data, object delta)
		{
		}

		// Token: 0x06006D85 RID: 28037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D85")]
		[Address(RVA = "0x2103800", Offset = "0x2102400", VA = "0x182103800")]
		private static void _ConvertEnemyAttributes(Torappu.AttributesData target, EnemyDatabase.AttributesData source)
		{
		}

		// Token: 0x06006D86 RID: 28038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D86")]
		[Address(RVA = "0x2102C80", Offset = "0x2101880", VA = "0x182102C80")]
		private static void _ApplyBlackboardData(Blackboard data, Blackboard delta)
		{
		}

		// Token: 0x06006D87 RID: 28039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D87")]
		[Address(RVA = "0x2102F50", Offset = "0x2101B50", VA = "0x182102F50")]
		private static void _ApplySkillData(List<LevelData.EnemyData.ESkillData> data, IEnumerable<LevelData.EnemyData.ESkillData> delta)
		{
		}

		// Token: 0x06006D88 RID: 28040 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006D88")]
		[Address(RVA = "0x2103D30", Offset = "0x2102930", VA = "0x182103D30")]
		private EnemyDatabase.EnemyData _FindEnemyLevel(List<EnemyDatabase.EnemyLevel> enemyLevels, int targetLevel)
		{
			return null;
		}

		// Token: 0x06006D89 RID: 28041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D89")]
		[Address(RVA = "0x2103DE0", Offset = "0x21029E0", VA = "0x182103DE0")]
		public EnemyDatabase()
		{
		}

		// Token: 0x040057EF RID: 22511
		[Token(Token = "0x40057EF")]
		[FieldOffset(Offset = "0x10")]
		public List<KeyValuePair<string, List<EnemyDatabase.EnemyLevel>>> enemies;

		// Token: 0x0200102E RID: 4142
		[Token(Token = "0x200102E")]
		[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
		public class EnemyDataMetaAttribute : Attribute
		{
			// Token: 0x06006D8A RID: 28042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006D8A")]
			[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
			public EnemyDataMetaAttribute()
			{
			}

			// Token: 0x06006D8B RID: 28043 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006D8B")]
			[Address(RVA = "0x50BD60", Offset = "0x50A960", VA = "0x18050BD60")]
			public EnemyDataMetaAttribute(string assignName)
			{
			}

			// Token: 0x040057F0 RID: 22512
			[Token(Token = "0x40057F0")]
			[FieldOffset(Offset = "0x10")]
			public string AssignName;
		}

		// Token: 0x0200102F RID: 4143
		[Token(Token = "0x200102F")]
		[Serializable]
		public class EnemyData
		{
			// Token: 0x06006D8C RID: 28044 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006D8C")]
			[Address(RVA = "0x2101AB0", Offset = "0x21006B0", VA = "0x182101AB0")]
			public EnemyData()
			{
			}

			// Token: 0x040057F1 RID: 22513
			[Token(Token = "0x40057F1")]
			[FieldOffset(Offset = "0x10")]
			public Undefinable<string> name;

			// Token: 0x040057F2 RID: 22514
			[Token(Token = "0x40057F2")]
			[FieldOffset(Offset = "0x20")]
			public Undefinable<string> description;

			// Token: 0x040057F3 RID: 22515
			[Token(Token = "0x40057F3")]
			[FieldOffset(Offset = "0x30")]
			[EnemyDatabase.EnemyDataMetaAttribute(AssignName = "key")]
			public Undefinable<string> prefabKey;

			// Token: 0x040057F4 RID: 22516
			[Token(Token = "0x40057F4")]
			[FieldOffset(Offset = "0x40")]
			public EnemyDatabase.AttributesData attributes;

			// Token: 0x040057F5 RID: 22517
			[Token(Token = "0x40057F5")]
			[FieldOffset(Offset = "0x48")]
			public Undefinable<SourceApplyWay> applyWay;

			// Token: 0x040057F6 RID: 22518
			[Token(Token = "0x40057F6")]
			[FieldOffset(Offset = "0x50")]
			public Undefinable<MotionMode> motion;

			// Token: 0x040057F7 RID: 22519
			[Token(Token = "0x40057F7")]
			[FieldOffset(Offset = "0x58")]
			public Undefinable<string[]> enemyTags;

			// Token: 0x040057F8 RID: 22520
			[Token(Token = "0x40057F8")]
			[FieldOffset(Offset = "0x68")]
			public Undefinable<int> lifePointReduce;

			// Token: 0x040057F9 RID: 22521
			[Token(Token = "0x40057F9")]
			[FieldOffset(Offset = "0x70")]
			public Undefinable<EnemyLevelType> levelType;

			// Token: 0x040057FA RID: 22522
			[Token(Token = "0x40057FA")]
			[FieldOffset(Offset = "0x78")]
			public Undefinable<float> rangeRadius;

			// Token: 0x040057FB RID: 22523
			[Token(Token = "0x40057FB")]
			[FieldOffset(Offset = "0x80")]
			public Undefinable<int> numOfExtraDrops;

			// Token: 0x040057FC RID: 22524
			[Token(Token = "0x40057FC")]
			[FieldOffset(Offset = "0x88")]
			public Undefinable<float> viewRadius;

			// Token: 0x040057FD RID: 22525
			[Token(Token = "0x40057FD")]
			[FieldOffset(Offset = "0x90")]
			public Undefinable<bool> notCountInTotal;

			// Token: 0x040057FE RID: 22526
			[Token(Token = "0x40057FE")]
			[FieldOffset(Offset = "0x98")]
			public Blackboard talentBlackboard;

			// Token: 0x040057FF RID: 22527
			[Token(Token = "0x40057FF")]
			[FieldOffset(Offset = "0xA0")]
			public LevelData.EnemyData.ESkillData[] skills;

			// Token: 0x04005800 RID: 22528
			[Token(Token = "0x4005800")]
			[FieldOffset(Offset = "0xA8")]
			public LevelData.EnemyData.ESpData spData;
		}

		// Token: 0x02001030 RID: 4144
		[Token(Token = "0x2001030")]
		[Serializable]
		public class EnemyLevel
		{
			// Token: 0x06006D8D RID: 28045 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006D8D")]
			[Address(RVA = "0x2103F00", Offset = "0x2102B00", VA = "0x182103F00")]
			public EnemyLevel()
			{
			}

			// Token: 0x04005801 RID: 22529
			[Token(Token = "0x4005801")]
			[FieldOffset(Offset = "0x10")]
			public int level;

			// Token: 0x04005802 RID: 22530
			[Token(Token = "0x4005802")]
			[FieldOffset(Offset = "0x18")]
			public EnemyDatabase.EnemyData enemyData;
		}

		// Token: 0x02001031 RID: 4145
		[Token(Token = "0x2001031")]
		[Serializable]
		public class AttributesData
		{
			// Token: 0x06006D8E RID: 28046 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006D8E")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public AttributesData()
			{
			}

			// Token: 0x04005803 RID: 22531
			[Token(Token = "0x4005803")]
			[FieldOffset(Offset = "0x10")]
			[AttributeMeta(AttributeType.MAX_HP)]
			public Undefinable<int> maxHp;

			// Token: 0x04005804 RID: 22532
			[Token(Token = "0x4005804")]
			[FieldOffset(Offset = "0x18")]
			[AttributeMeta(AttributeType.ATK)]
			public Undefinable<int> atk;

			// Token: 0x04005805 RID: 22533
			[Token(Token = "0x4005805")]
			[FieldOffset(Offset = "0x20")]
			[AttributeMeta(AttributeType.DEF)]
			public Undefinable<int> def;

			// Token: 0x04005806 RID: 22534
			[Token(Token = "0x4005806")]
			[FieldOffset(Offset = "0x28")]
			[AttributeMeta(AttributeType.MAGIC_RESISTANCE)]
			public Undefinable<float> magicResistance;

			// Token: 0x04005807 RID: 22535
			[Token(Token = "0x4005807")]
			[FieldOffset(Offset = "0x30")]
			[AttributeMeta(AttributeType.COST)]
			public Undefinable<int> cost;

			// Token: 0x04005808 RID: 22536
			[Token(Token = "0x4005808")]
			[FieldOffset(Offset = "0x38")]
			[AttributeMeta(AttributeType.BLOCK_CNT)]
			public Undefinable<int> blockCnt;

			// Token: 0x04005809 RID: 22537
			[Token(Token = "0x4005809")]
			[FieldOffset(Offset = "0x40")]
			[AttributeMeta(AttributeType.MOVE_SPEED)]
			public Undefinable<float> moveSpeed;

			// Token: 0x0400580A RID: 22538
			[Token(Token = "0x400580A")]
			[FieldOffset(Offset = "0x48")]
			[AttributeMeta(AttributeType.ATTACK_SPEED)]
			public Undefinable<float> attackSpeed;

			// Token: 0x0400580B RID: 22539
			[Token(Token = "0x400580B")]
			[FieldOffset(Offset = "0x50")]
			[AttributeMeta(AttributeType.BASE_ATTACK_TIME)]
			public Undefinable<float> baseAttackTime;

			// Token: 0x0400580C RID: 22540
			[Token(Token = "0x400580C")]
			[FieldOffset(Offset = "0x58")]
			[AttributeMeta(AttributeType.RESPAWN_TIME)]
			public Undefinable<int> respawnTime;

			// Token: 0x0400580D RID: 22541
			[Token(Token = "0x400580D")]
			[FieldOffset(Offset = "0x60")]
			[AttributeMeta(AttributeType.HP_RECOVERY_PER_SEC)]
			public Undefinable<float> hpRecoveryPerSec;

			// Token: 0x0400580E RID: 22542
			[Token(Token = "0x400580E")]
			[FieldOffset(Offset = "0x68")]
			[AttributeMeta(AttributeType.SP_RECOVERY_PER_SEC)]
			public Undefinable<float> spRecoveryPerSec;

			// Token: 0x0400580F RID: 22543
			[Token(Token = "0x400580F")]
			[FieldOffset(Offset = "0x70")]
			[AttributeMeta(AttributeType.MAX_DEPLOY_COUNT)]
			public Undefinable<int> maxDeployCount;

			// Token: 0x04005810 RID: 22544
			[Token(Token = "0x4005810")]
			[FieldOffset(Offset = "0x78")]
			[AttributeMeta(AttributeType.MASS_LEVEL)]
			public Undefinable<int> massLevel;

			// Token: 0x04005811 RID: 22545
			[Token(Token = "0x4005811")]
			[FieldOffset(Offset = "0x80")]
			[AttributeMeta(AttributeType.BASE_FORCE_LEVEL)]
			public Undefinable<int> baseForceLevel;

			// Token: 0x04005812 RID: 22546
			[Token(Token = "0x4005812")]
			[FieldOffset(Offset = "0x88")]
			[AttributeMeta(AttributeType.TAUNT_LEVEL)]
			public Undefinable<int> tauntLevel;

			// Token: 0x04005813 RID: 22547
			[Token(Token = "0x4005813")]
			[FieldOffset(Offset = "0x90")]
			[AttributeMeta(AttributeType.EP_DAMAGE_RESISTANCE)]
			public Undefinable<float> epDamageResistance;

			// Token: 0x04005814 RID: 22548
			[Token(Token = "0x4005814")]
			[FieldOffset(Offset = "0x98")]
			[AttributeMeta(AttributeType.EP_RESISTANCE)]
			public Undefinable<float> epResistance;

			// Token: 0x04005815 RID: 22549
			[Token(Token = "0x4005815")]
			[FieldOffset(Offset = "0xA0")]
			[AttributeMeta(AttributeType.DAMAGE_HITRATE_PHYSICAL)]
			public Undefinable<float> damageHitratePhysical;

			// Token: 0x04005816 RID: 22550
			[Token(Token = "0x4005816")]
			[FieldOffset(Offset = "0xA8")]
			[AttributeMeta(AttributeType.DAMAGE_HITRATE_MAGICAL)]
			public Undefinable<float> damageHitrateMagical;

			// Token: 0x04005817 RID: 22551
			[Token(Token = "0x4005817")]
			[FieldOffset(Offset = "0xB0")]
			[AttributeMeta(AttributeType.EP_BREAK_RECOVER_SPEED)]
			public Undefinable<float> epBreakRecoverSpeed;

			// Token: 0x04005818 RID: 22552
			[Token(Token = "0x4005818")]
			[FieldOffset(Offset = "0xB8")]
			[AbnormalImmuneMeta(AbnormalFlag.STUNNED)]
			public Undefinable<bool> stunImmune;

			// Token: 0x04005819 RID: 22553
			[Token(Token = "0x4005819")]
			[FieldOffset(Offset = "0xBA")]
			[AbnormalImmuneMeta(AbnormalFlag.SILENCED)]
			public Undefinable<bool> silenceImmune;

			// Token: 0x0400581A RID: 22554
			[Token(Token = "0x400581A")]
			[FieldOffset(Offset = "0xBC")]
			[AbnormalComboImmuneMeta(AbnormalCombo.SLEEPING)]
			public Undefinable<bool> sleepImmune;

			// Token: 0x0400581B RID: 22555
			[Token(Token = "0x400581B")]
			[FieldOffset(Offset = "0xBE")]
			[AbnormalImmuneMeta(AbnormalFlag.FROZEN)]
			public Undefinable<bool> frozenImmune;

			// Token: 0x0400581C RID: 22556
			[Token(Token = "0x400581C")]
			[FieldOffset(Offset = "0xC0")]
			[AbnormalImmuneMeta(AbnormalFlag.LEVITATE)]
			public Undefinable<bool> levitateImmune;

			// Token: 0x0400581D RID: 22557
			[Token(Token = "0x400581D")]
			[FieldOffset(Offset = "0xC2")]
			[AbnormalImmuneMeta(AbnormalFlag.DISARMED_COMBAT)]
			public Undefinable<bool> disarmedCombatImmune;

			// Token: 0x0400581E RID: 22558
			[Token(Token = "0x400581E")]
			[FieldOffset(Offset = "0xC4")]
			[AbnormalImmuneMeta(AbnormalFlag.FEARED)]
			public Undefinable<bool> fearedImmune;

			// Token: 0x0400581F RID: 22559
			[Token(Token = "0x400581F")]
			[FieldOffset(Offset = "0xC6")]
			[AbnormalImmuneMeta(AbnormalFlag.PALSY)]
			public Undefinable<bool> palsyImmune;

			// Token: 0x04005820 RID: 22560
			[Token(Token = "0x4005820")]
			[FieldOffset(Offset = "0xC8")]
			[AbnormalImmuneMeta(AbnormalFlag.ATTRACTED)]
			public Undefinable<bool> attractImmune;
		}
	}
}
