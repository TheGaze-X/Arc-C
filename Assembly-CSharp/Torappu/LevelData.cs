using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Torappu.Battle;
using Torappu.ObjectPool;

namespace Torappu
{
	// Token: 0x020010C2 RID: 4290
	[Token(Token = "0x20010C2")]
	[Serializable]
	public class LevelData
	{
		// Token: 0x06006E5C RID: 28252 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006E5C")]
		[Address(RVA = "0x2106560", Offset = "0x2105160", VA = "0x182106560")]
		public string GetSceneName()
		{
			return null;
		}

		// Token: 0x06006E5D RID: 28253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006E5D")]
		[Address(RVA = "0x2106590", Offset = "0x2105190", VA = "0x182106590")]
		public LevelData()
		{
		}

		// Token: 0x04005BC5 RID: 23493
		[Token(Token = "0x4005BC5")]
		[FieldOffset(Offset = "0x10")]
		public LevelData.Options options;

		// Token: 0x04005BC6 RID: 23494
		[Token(Token = "0x4005BC6")]
		[FieldOffset(Offset = "0x18")]
		public string levelId;

		// Token: 0x04005BC7 RID: 23495
		[Token(Token = "0x4005BC7")]
		[FieldOffset(Offset = "0x20")]
		public string mapId;

		// Token: 0x04005BC8 RID: 23496
		[Token(Token = "0x4005BC8")]
		[FieldOffset(Offset = "0x28")]
		public string bgmEvent;

		// Token: 0x04005BC9 RID: 23497
		[Token(Token = "0x4005BC9")]
		[FieldOffset(Offset = "0x30")]
		public string environmentSe;

		// Token: 0x04005BCA RID: 23498
		[Token(Token = "0x4005BCA")]
		[FieldOffset(Offset = "0x38")]
		public MapData mapData;

		// Token: 0x04005BCB RID: 23499
		[Token(Token = "0x4005BCB")]
		[FieldOffset(Offset = "0x40")]
		public List<GridPosition> tilesDisallowToLocate;

		// Token: 0x04005BCC RID: 23500
		[Token(Token = "0x4005BCC")]
		[FieldOffset(Offset = "0x48")]
		public LegacyInLevelRuneData[] runes;

		// Token: 0x04005BCD RID: 23501
		[Token(Token = "0x4005BCD")]
		[FieldOffset(Offset = "0x50")]
		[JsonProperty(DefaultValueHandling = 3, NullValueHandling = 1)]
		public Dictionary<string, List<LegacyInLevelRuneData>> optionalRunes;

		// Token: 0x04005BCE RID: 23502
		[Token(Token = "0x4005BCE")]
		[FieldOffset(Offset = "0x58")]
		public LevelData.GlobalBuffData[] globalBuffs;

		// Token: 0x04005BCF RID: 23503
		[Token(Token = "0x4005BCF")]
		[FieldOffset(Offset = "0x60")]
		public RouteData[] routes;

		// Token: 0x04005BD0 RID: 23504
		[Token(Token = "0x4005BD0")]
		[FieldOffset(Offset = "0x68")]
		public RouteData[] extraRoutes;

		// Token: 0x04005BD1 RID: 23505
		[Token(Token = "0x4005BD1")]
		[FieldOffset(Offset = "0x70")]
		public LevelData.EnemyData[] enemies;

		// Token: 0x04005BD2 RID: 23506
		[Token(Token = "0x4005BD2")]
		[FieldOffset(Offset = "0x78")]
		public LevelData.EnemyDataDbReference[] enemyDbRefs;

		// Token: 0x04005BD3 RID: 23507
		[Token(Token = "0x4005BD3")]
		[FieldOffset(Offset = "0x80")]
		public LevelData.WaveData[] waves;

		// Token: 0x04005BD4 RID: 23508
		[Token(Token = "0x4005BD4")]
		[FieldOffset(Offset = "0x88")]
		public ListDict<string, LevelData.BranchData> branches;

		// Token: 0x04005BD5 RID: 23509
		[Token(Token = "0x4005BD5")]
		[FieldOffset(Offset = "0x90")]
		public LevelData.PredefinedData predefines;

		// Token: 0x04005BD6 RID: 23510
		[Token(Token = "0x4005BD6")]
		[FieldOffset(Offset = "0x98")]
		public LevelData.PredefinedData hardPredefines;

		// Token: 0x04005BD7 RID: 23511
		[Token(Token = "0x4005BD7")]
		[FieldOffset(Offset = "0xA0")]
		public string[] excludeCharIdList;

		// Token: 0x04005BD8 RID: 23512
		[Token(Token = "0x4005BD8")]
		[FieldOffset(Offset = "0xA8")]
		public int randomSeed;

		// Token: 0x04005BD9 RID: 23513
		[Token(Token = "0x4005BD9")]
		[FieldOffset(Offset = "0xB0")]
		public string operaConfig;

		// Token: 0x04005BDA RID: 23514
		[Token(Token = "0x4005BDA")]
		[FieldOffset(Offset = "0xB8")]
		public string cameraPlugin;

		// Token: 0x04005BDB RID: 23515
		[Token(Token = "0x4005BDB")]
		[FieldOffset(Offset = "0xC0")]
		[NonSerialized]
		public LevelData.RuntimeData runtimeData;

		// Token: 0x020010C3 RID: 4291
		[Token(Token = "0x20010C3")]
		public enum Difficulty
		{
			// Token: 0x04005BDD RID: 23517
			[Token(Token = "0x4005BDD")]
			NONE,
			// Token: 0x04005BDE RID: 23518
			[Token(Token = "0x4005BDE")]
			NORMAL,
			// Token: 0x04005BDF RID: 23519
			[Token(Token = "0x4005BDF")]
			FOUR_STAR,
			// Token: 0x04005BE0 RID: 23520
			[Token(Token = "0x4005BE0")]
			EASY = 4,
			// Token: 0x04005BE1 RID: 23521
			[Token(Token = "0x4005BE1")]
			SIX_STAR = 8,
			// Token: 0x04005BE2 RID: 23522
			[Token(Token = "0x4005BE2")]
			ALL = 15
		}

		// Token: 0x020010C4 RID: 4292
		[Token(Token = "0x20010C4")]
		public struct ActionID
		{
			// Token: 0x04005BE3 RID: 23523
			[Token(Token = "0x4005BE3")]
			[FieldOffset(Offset = "0x0")]
			public int waveI;

			// Token: 0x04005BE4 RID: 23524
			[Token(Token = "0x4005BE4")]
			[FieldOffset(Offset = "0x4")]
			public int fragI;

			// Token: 0x04005BE5 RID: 23525
			[Token(Token = "0x4005BE5")]
			[FieldOffset(Offset = "0x8")]
			public int actionI;
		}

		// Token: 0x020010C5 RID: 4293
		[Token(Token = "0x20010C5")]
		[Serializable]
		public class Options
		{
			// Token: 0x06006E5E RID: 28254 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E5E")]
			[Address(RVA = "0x2109060", Offset = "0x2107C60", VA = "0x182109060")]
			public Options()
			{
			}

			// Token: 0x04005BE6 RID: 23526
			[Token(Token = "0x4005BE6")]
			[FieldOffset(Offset = "0x10")]
			public int characterLimit;

			// Token: 0x04005BE7 RID: 23527
			[Token(Token = "0x4005BE7")]
			[FieldOffset(Offset = "0x14")]
			public int maxLifePoint;

			// Token: 0x04005BE8 RID: 23528
			[Token(Token = "0x4005BE8")]
			[FieldOffset(Offset = "0x18")]
			public int initialCost;

			// Token: 0x04005BE9 RID: 23529
			[Token(Token = "0x4005BE9")]
			[FieldOffset(Offset = "0x1C")]
			public int maxCost;

			// Token: 0x04005BEA RID: 23530
			[Token(Token = "0x4005BEA")]
			[FieldOffset(Offset = "0x20")]
			public float costIncreaseTime;

			// Token: 0x04005BEB RID: 23531
			[Token(Token = "0x4005BEB")]
			[FieldOffset(Offset = "0x24")]
			public float moveMultiplier;

			// Token: 0x04005BEC RID: 23532
			[Token(Token = "0x4005BEC")]
			[FieldOffset(Offset = "0x28")]
			public bool steeringEnabled;

			// Token: 0x04005BED RID: 23533
			[Token(Token = "0x4005BED")]
			[FieldOffset(Offset = "0x29")]
			public bool isTrainingLevel;

			// Token: 0x04005BEE RID: 23534
			[Token(Token = "0x4005BEE")]
			[FieldOffset(Offset = "0x2A")]
			public bool isHardTrainingLevel;

			// Token: 0x04005BEF RID: 23535
			[Token(Token = "0x4005BEF")]
			[FieldOffset(Offset = "0x2B")]
			public bool isPredefinedCardsSelectable;

			// Token: 0x04005BF0 RID: 23536
			[Token(Token = "0x4005BF0")]
			[FieldOffset(Offset = "0x2C")]
			public bool displayRestTime;

			// Token: 0x04005BF1 RID: 23537
			[Token(Token = "0x4005BF1")]
			[FieldOffset(Offset = "0x30")]
			public float maxPlayTime;

			// Token: 0x04005BF2 RID: 23538
			[Token(Token = "0x4005BF2")]
			[FieldOffset(Offset = "0x34")]
			public BattleFunctionDisableMask functionDisableMask;

			// Token: 0x04005BF3 RID: 23539
			[Token(Token = "0x4005BF3")]
			[FieldOffset(Offset = "0x38")]
			public Blackboard configBlackBoard;

			// Token: 0x04005BF4 RID: 23540
			[Token(Token = "0x4005BF4")]
			[FieldOffset(Offset = "0x40")]
			[NonSerialized]
			public int enemyTauntLevelPow;
		}

		// Token: 0x020010C6 RID: 4294
		[Token(Token = "0x20010C6")]
		[Serializable]
		public class EnemyData
		{
			// Token: 0x17000D21 RID: 3361
			// (get) Token: 0x06006E5F RID: 28255 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000D21")]
			[JsonIgnore]
			public string keyInLevel
			{
				[Token(Token = "0x6006E5F")]
				[Address(RVA = "0x2101CC0", Offset = "0x21008C0", VA = "0x182101CC0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000D22 RID: 3362
			// (get) Token: 0x06006E60 RID: 28256 RVA: 0x000320B8 File Offset: 0x000302B8
			[Token(Token = "0x17000D22")]
			[JsonIgnore]
			public bool isBoss
			{
				[Token(Token = "0x6006E60")]
				[Address(RVA = "0x2101CB0", Offset = "0x21008B0", VA = "0x182101CB0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17000D23 RID: 3363
			// (get) Token: 0x06006E61 RID: 28257 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000D23")]
			[JsonIgnore]
			public LevelData.EnemyData.RuntimeData runtimeData
			{
				[Token(Token = "0x6006E61")]
				[Address(RVA = "0xEB4B50", Offset = "0xEB3750", VA = "0x180EB4B50")]
				get
				{
					return null;
				}
			}

			// Token: 0x06006E62 RID: 28258 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E62")]
			[Address(RVA = "0x2101B20", Offset = "0x2100720", VA = "0x182101B20")]
			public EnemyData()
			{
			}

			// Token: 0x04005BF5 RID: 23541
			[Token(Token = "0x4005BF5")]
			[FieldOffset(Offset = "0x10")]
			public string name;

			// Token: 0x04005BF6 RID: 23542
			[Token(Token = "0x4005BF6")]
			[FieldOffset(Offset = "0x18")]
			public string description;

			// Token: 0x04005BF7 RID: 23543
			[Token(Token = "0x4005BF7")]
			[FieldOffset(Offset = "0x20")]
			public string key;

			// Token: 0x04005BF8 RID: 23544
			[Token(Token = "0x4005BF8")]
			[FieldOffset(Offset = "0x28")]
			public AttributesData attributes;

			// Token: 0x04005BF9 RID: 23545
			[Token(Token = "0x4005BF9")]
			[FieldOffset(Offset = "0x30")]
			public SourceApplyWay applyWay;

			// Token: 0x04005BFA RID: 23546
			[Token(Token = "0x4005BFA")]
			[FieldOffset(Offset = "0x34")]
			public MotionMode motion;

			// Token: 0x04005BFB RID: 23547
			[Token(Token = "0x4005BFB")]
			[FieldOffset(Offset = "0x38")]
			public string[] enemyTags;

			// Token: 0x04005BFC RID: 23548
			[Token(Token = "0x4005BFC")]
			[FieldOffset(Offset = "0x40")]
			public bool notCountInTotal;

			// Token: 0x04005BFD RID: 23549
			[Token(Token = "0x4005BFD")]
			[FieldOffset(Offset = "0x48")]
			public string alias;

			// Token: 0x04005BFE RID: 23550
			[Token(Token = "0x4005BFE")]
			[FieldOffset(Offset = "0x50")]
			public int lifePointReduce;

			// Token: 0x04005BFF RID: 23551
			[Token(Token = "0x4005BFF")]
			[FieldOffset(Offset = "0x54")]
			public float rangeRadius;

			// Token: 0x04005C00 RID: 23552
			[Token(Token = "0x4005C00")]
			[FieldOffset(Offset = "0x58")]
			public int numOfExtraDrops;

			// Token: 0x04005C01 RID: 23553
			[Token(Token = "0x4005C01")]
			[FieldOffset(Offset = "0x5C")]
			public float viewRadius;

			// Token: 0x04005C02 RID: 23554
			[Token(Token = "0x4005C02")]
			[FieldOffset(Offset = "0x60")]
			public EnemyLevelType levelType;

			// Token: 0x04005C03 RID: 23555
			[Token(Token = "0x4005C03")]
			[FieldOffset(Offset = "0x68")]
			public Blackboard talentBlackboard;

			// Token: 0x04005C04 RID: 23556
			[Token(Token = "0x4005C04")]
			[FieldOffset(Offset = "0x70")]
			public LevelData.EnemyData.ESkillData[] skills;

			// Token: 0x04005C05 RID: 23557
			[Token(Token = "0x4005C05")]
			[FieldOffset(Offset = "0x78")]
			public LevelData.EnemyData.ESpData spData;

			// Token: 0x04005C06 RID: 23558
			[Token(Token = "0x4005C06")]
			[FieldOffset(Offset = "0x80")]
			private LevelData.EnemyData.RuntimeData m_runtimeData;

			// Token: 0x020010C7 RID: 4295
			[Token(Token = "0x20010C7")]
			[Serializable]
			public class ESkillData
			{
				// Token: 0x06006E63 RID: 28259 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006E63")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ESkillData()
				{
				}

				// Token: 0x04005C07 RID: 23559
				[Token(Token = "0x4005C07")]
				[FieldOffset(Offset = "0x10")]
				public string prefabKey;

				// Token: 0x04005C08 RID: 23560
				[Token(Token = "0x4005C08")]
				[FieldOffset(Offset = "0x18")]
				public int priority;

				// Token: 0x04005C09 RID: 23561
				[Token(Token = "0x4005C09")]
				[FieldOffset(Offset = "0x1C")]
				public float cooldown;

				// Token: 0x04005C0A RID: 23562
				[Token(Token = "0x4005C0A")]
				[FieldOffset(Offset = "0x20")]
				public float initCooldown;

				// Token: 0x04005C0B RID: 23563
				[Token(Token = "0x4005C0B")]
				[FieldOffset(Offset = "0x24")]
				public int spCost;

				// Token: 0x04005C0C RID: 23564
				[Token(Token = "0x4005C0C")]
				[FieldOffset(Offset = "0x28")]
				public Blackboard blackboard;
			}

			// Token: 0x020010C8 RID: 4296
			[Token(Token = "0x20010C8")]
			[Serializable]
			public class ESpData
			{
				// Token: 0x06006E64 RID: 28260 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006E64")]
				[Address(RVA = "0x21019D0", Offset = "0x21005D0", VA = "0x1821019D0")]
				public ESpData()
				{
				}

				// Token: 0x04005C0D RID: 23565
				[Token(Token = "0x4005C0D")]
				[FieldOffset(Offset = "0x10")]
				public SpType spType;

				// Token: 0x04005C0E RID: 23566
				[Token(Token = "0x4005C0E")]
				[FieldOffset(Offset = "0x14")]
				public int maxSp;

				// Token: 0x04005C0F RID: 23567
				[Token(Token = "0x4005C0F")]
				[FieldOffset(Offset = "0x18")]
				public int initSp;

				// Token: 0x04005C10 RID: 23568
				[Token(Token = "0x4005C10")]
				[FieldOffset(Offset = "0x1C")]
				public float increment;
			}

			// Token: 0x020010C9 RID: 4297
			[Token(Token = "0x20010C9")]
			[Serializable]
			public class RuntimeData
			{
				// Token: 0x06006E65 RID: 28261 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006E65")]
				[Address(RVA = "0x2114CF0", Offset = "0x21138F0", VA = "0x182114CF0")]
				public RuntimeData()
				{
				}

				// Token: 0x04005C11 RID: 23569
				[Token(Token = "0x4005C11")]
				[FieldOffset(Offset = "0x10")]
				public List<DynamicAbilityData> dynamicAbilities;

				// Token: 0x04005C12 RID: 23570
				[Token(Token = "0x4005C12")]
				[FieldOffset(Offset = "0x18")]
				public List<string> skinData;
			}
		}

		// Token: 0x020010CA RID: 4298
		[Token(Token = "0x20010CA")]
		[Serializable]
		public class EnemyDataDbReference
		{
			// Token: 0x06006E66 RID: 28262 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E66")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EnemyDataDbReference()
			{
			}

			// Token: 0x04005C13 RID: 23571
			[Token(Token = "0x4005C13")]
			[FieldOffset(Offset = "0x10")]
			public bool useDb;

			// Token: 0x04005C14 RID: 23572
			[Token(Token = "0x4005C14")]
			[FieldOffset(Offset = "0x18")]
			public string id;

			// Token: 0x04005C15 RID: 23573
			[Token(Token = "0x4005C15")]
			[FieldOffset(Offset = "0x20")]
			public int level;

			// Token: 0x04005C16 RID: 23574
			[Token(Token = "0x4005C16")]
			[FieldOffset(Offset = "0x28")]
			public EnemyDatabase.EnemyData overwrittenData;
		}

		// Token: 0x020010CB RID: 4299
		[Token(Token = "0x20010CB")]
		[Serializable]
		public class WaveData
		{
			// Token: 0x06006E67 RID: 28263 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E67")]
			[Address(RVA = "0x21179C0", Offset = "0x21165C0", VA = "0x1821179C0")]
			public WaveData()
			{
			}

			// Token: 0x04005C17 RID: 23575
			[Token(Token = "0x4005C17")]
			[FieldOffset(Offset = "0x10")]
			public float preDelay;

			// Token: 0x04005C18 RID: 23576
			[Token(Token = "0x4005C18")]
			[FieldOffset(Offset = "0x14")]
			public float postDelay;

			// Token: 0x04005C19 RID: 23577
			[Token(Token = "0x4005C19")]
			[FieldOffset(Offset = "0x18")]
			public float maxTimeWaitingForNextWave;

			// Token: 0x04005C1A RID: 23578
			[Token(Token = "0x4005C1A")]
			[FieldOffset(Offset = "0x20")]
			public LevelData.WaveData.FragmentData[] fragments;

			// Token: 0x04005C1B RID: 23579
			[Token(Token = "0x4005C1B")]
			[FieldOffset(Offset = "0x28")]
			public string advancedWaveTag;

			// Token: 0x020010CC RID: 4300
			[Token(Token = "0x20010CC")]
			[Serializable]
			public class FragmentData
			{
				// Token: 0x06006E68 RID: 28264 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006E68")]
				[Address(RVA = "0x2104AC0", Offset = "0x21036C0", VA = "0x182104AC0")]
				public FragmentData()
				{
				}

				// Token: 0x04005C1C RID: 23580
				[Token(Token = "0x4005C1C")]
				[FieldOffset(Offset = "0x10")]
				public float preDelay;

				// Token: 0x04005C1D RID: 23581
				[Token(Token = "0x4005C1D")]
				[FieldOffset(Offset = "0x18")]
				public LevelData.WaveData.FragmentData.ActionData[] actions;

				// Token: 0x020010CD RID: 4301
				[Token(Token = "0x20010CD")]
				[Serializable]
				public class ActionData : IItemWithWeight, IReusable
				{
					// Token: 0x06006E69 RID: 28265 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006E69")]
					[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
					public void OnAllocate()
					{
					}

					// Token: 0x06006E6A RID: 28266 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006E6A")]
					[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
					public void OnRecycle()
					{
					}

					// Token: 0x17000D24 RID: 3364
					// (get) Token: 0x06006E6B RID: 28267 RVA: 0x000320D0 File Offset: 0x000302D0
					[Token(Token = "0x17000D24")]
					[JsonIgnore]
					public float weightValue
					{
						[Token(Token = "0x6006E6B")]
						[Address(RVA = "0x20FE400", Offset = "0x20FD000", VA = "0x1820FE400", Slot = "4")]
						get
						{
							return 0f;
						}
					}

					// Token: 0x06006E6C RID: 28268 RVA: 0x00002053 File Offset: 0x00000253
					[Token(Token = "0x6006E6C")]
					[Address(RVA = "0x20FE3E0", Offset = "0x20FCFE0", VA = "0x1820FE3E0")]
					public ActionData()
					{
					}

					// Token: 0x04005C1E RID: 23582
					[Token(Token = "0x4005C1E")]
					[FieldOffset(Offset = "0x10")]
					public LevelData.WaveData.FragmentData.ActionData.ActionType actionType;

					// Token: 0x04005C1F RID: 23583
					[Token(Token = "0x4005C1F")]
					[FieldOffset(Offset = "0x14")]
					public bool managedByScheduler;

					// Token: 0x04005C20 RID: 23584
					[Token(Token = "0x4005C20")]
					[FieldOffset(Offset = "0x18")]
					public string key;

					// Token: 0x04005C21 RID: 23585
					[Token(Token = "0x4005C21")]
					[FieldOffset(Offset = "0x20")]
					public int count;

					// Token: 0x04005C22 RID: 23586
					[Token(Token = "0x4005C22")]
					[FieldOffset(Offset = "0x24")]
					public float preDelay;

					// Token: 0x04005C23 RID: 23587
					[Token(Token = "0x4005C23")]
					[FieldOffset(Offset = "0x28")]
					public float interval;

					// Token: 0x04005C24 RID: 23588
					[Token(Token = "0x4005C24")]
					[FieldOffset(Offset = "0x2C")]
					[NonSerialized]
					public bool useExtraRoute;

					// Token: 0x04005C25 RID: 23589
					[Token(Token = "0x4005C25")]
					[FieldOffset(Offset = "0x30")]
					public int routeIndex;

					// Token: 0x04005C26 RID: 23590
					[Token(Token = "0x4005C26")]
					[FieldOffset(Offset = "0x34")]
					public bool blockFragment;

					// Token: 0x04005C27 RID: 23591
					[Token(Token = "0x4005C27")]
					[FieldOffset(Offset = "0x35")]
					public bool autoPreviewRoute;

					// Token: 0x04005C28 RID: 23592
					[Token(Token = "0x4005C28")]
					[FieldOffset(Offset = "0x36")]
					public bool autoDisplayEnemyInfo;

					// Token: 0x04005C29 RID: 23593
					[Token(Token = "0x4005C29")]
					[FieldOffset(Offset = "0x37")]
					public bool isUnharmfulAndAlwaysCountAsKilled;

					// Token: 0x04005C2A RID: 23594
					[Token(Token = "0x4005C2A")]
					[FieldOffset(Offset = "0x38")]
					public string hiddenGroup;

					// Token: 0x04005C2B RID: 23595
					[Token(Token = "0x4005C2B")]
					[FieldOffset(Offset = "0x40")]
					public string randomSpawnGroupKey;

					// Token: 0x04005C2C RID: 23596
					[Token(Token = "0x4005C2C")]
					[FieldOffset(Offset = "0x48")]
					public string randomSpawnGroupPackKey;

					// Token: 0x04005C2D RID: 23597
					[Token(Token = "0x4005C2D")]
					[FieldOffset(Offset = "0x50")]
					public LevelData.WaveData.FragmentData.ActionData.RandomType randomType;

					// Token: 0x04005C2E RID: 23598
					[Token(Token = "0x4005C2E")]
					[FieldOffset(Offset = "0x54")]
					public LevelData.WaveData.FragmentData.ActionData.RefreshType refreshType;

					// Token: 0x04005C2F RID: 23599
					[Token(Token = "0x4005C2F")]
					[FieldOffset(Offset = "0x58")]
					public int weight;

					// Token: 0x04005C30 RID: 23600
					[Token(Token = "0x4005C30")]
					[FieldOffset(Offset = "0x5C")]
					public bool dontBlockWave;

					// Token: 0x04005C31 RID: 23601
					[Token(Token = "0x4005C31")]
					[FieldOffset(Offset = "0x5D")]
					public bool forceBlockWaveInBranch;

					// Token: 0x04005C32 RID: 23602
					[Token(Token = "0x4005C32")]
					[FieldOffset(Offset = "0x5E")]
					[NonSerialized]
					public bool isValid;

					// Token: 0x04005C33 RID: 23603
					[Token(Token = "0x4005C33")]
					[FieldOffset(Offset = "0x5F")]
					[NonSerialized]
					public bool notCountInTotal;

					// Token: 0x04005C34 RID: 23604
					[Token(Token = "0x4005C34")]
					[FieldOffset(Offset = "0x60")]
					[NonSerialized]
					public object extraMeta;

					// Token: 0x04005C35 RID: 23605
					[Token(Token = "0x4005C35")]
					[FieldOffset(Offset = "0x68")]
					[NonSerialized]
					public LevelData.ActionID actionId;

					// Token: 0x020010CE RID: 4302
					[Token(Token = "0x20010CE")]
					public enum ActionType
					{
						// Token: 0x04005C37 RID: 23607
						[Token(Token = "0x4005C37")]
						SPAWN,
						// Token: 0x04005C38 RID: 23608
						[Token(Token = "0x4005C38")]
						PREVIEW_CURSOR,
						// Token: 0x04005C39 RID: 23609
						[Token(Token = "0x4005C39")]
						STORY,
						// Token: 0x04005C3A RID: 23610
						[Token(Token = "0x4005C3A")]
						TUTORIAL,
						// Token: 0x04005C3B RID: 23611
						[Token(Token = "0x4005C3B")]
						PLAY_BGM,
						// Token: 0x04005C3C RID: 23612
						[Token(Token = "0x4005C3C")]
						DISPLAY_ENEMY_INFO,
						// Token: 0x04005C3D RID: 23613
						[Token(Token = "0x4005C3D")]
						ACTIVATE_PREDEFINED,
						// Token: 0x04005C3E RID: 23614
						[Token(Token = "0x4005C3E")]
						PLAY_OPERA,
						// Token: 0x04005C3F RID: 23615
						[Token(Token = "0x4005C3F")]
						TRIGGER_PREDEFINED,
						// Token: 0x04005C40 RID: 23616
						[Token(Token = "0x4005C40")]
						BATTLE_EVENTS,
						// Token: 0x04005C41 RID: 23617
						[Token(Token = "0x4005C41")]
						WITHDRAW_PREDEFINED,
						// Token: 0x04005C42 RID: 23618
						[Token(Token = "0x4005C42")]
						DIALOG,
						// Token: 0x04005C43 RID: 23619
						[Token(Token = "0x4005C43")]
						SHOW_ALL_HIDDEN_CARDS,
						// Token: 0x04005C44 RID: 23620
						[Token(Token = "0x4005C44")]
						EMPTY,
						// Token: 0x04005C45 RID: 23621
						[Token(Token = "0x4005C45")]
						E_NUM
					}

					// Token: 0x020010CF RID: 4303
					[Token(Token = "0x20010CF")]
					public enum RandomType
					{
						// Token: 0x04005C47 RID: 23623
						[Token(Token = "0x4005C47")]
						ALWAYS,
						// Token: 0x04005C48 RID: 23624
						[Token(Token = "0x4005C48")]
						PER_DAY,
						// Token: 0x04005C49 RID: 23625
						[Token(Token = "0x4005C49")]
						NEVER,
						// Token: 0x04005C4A RID: 23626
						[Token(Token = "0x4005C4A")]
						PER_SETTLE_DAY,
						// Token: 0x04005C4B RID: 23627
						[Token(Token = "0x4005C4B")]
						PER_SEASON
					}

					// Token: 0x020010D0 RID: 4304
					[Token(Token = "0x20010D0")]
					public enum RefreshType
					{
						// Token: 0x04005C4D RID: 23629
						[Token(Token = "0x4005C4D")]
						ALWAYS,
						// Token: 0x04005C4E RID: 23630
						[Token(Token = "0x4005C4E")]
						PER_DAY,
						// Token: 0x04005C4F RID: 23631
						[Token(Token = "0x4005C4F")]
						NEVER,
						// Token: 0x04005C50 RID: 23632
						[Token(Token = "0x4005C50")]
						PER_SETTLE_DAY,
						// Token: 0x04005C51 RID: 23633
						[Token(Token = "0x4005C51")]
						PER_SEASON
					}
				}
			}
		}

		// Token: 0x020010D1 RID: 4305
		[Token(Token = "0x20010D1")]
		[Serializable]
		public class BranchData
		{
			// Token: 0x06006E6D RID: 28269 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E6D")]
			[Address(RVA = "0x20FF1F0", Offset = "0x20FDDF0", VA = "0x1820FF1F0")]
			public BranchData()
			{
			}

			// Token: 0x04005C52 RID: 23634
			[Token(Token = "0x4005C52")]
			[FieldOffset(Offset = "0x10")]
			public LevelData.BranchData.PhaseData[] phases;

			// Token: 0x020010D2 RID: 4306
			[Token(Token = "0x20010D2")]
			[Serializable]
			public class PhaseData
			{
				// Token: 0x17000D25 RID: 3365
				// (get) Token: 0x06006E6E RID: 28270 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000D25")]
				private Dictionary<string, List<LevelData.WaveData.FragmentData.ActionData>> randomActionGroups
				{
					[Token(Token = "0x6006E6E")]
					[Address(RVA = "0x2109760", Offset = "0x2108360", VA = "0x182109760")]
					get
					{
						return null;
					}
				}

				// Token: 0x06006E6F RID: 28271 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6006E6F")]
				[Address(RVA = "0x2109260", Offset = "0x2107E60", VA = "0x182109260")]
				public List<LevelData.WaveData.FragmentData.ActionData> FetchActionsWithRandomSpawn(bool refreshResult)
				{
					return null;
				}

				// Token: 0x06006E70 RID: 28272 RVA: 0x000320E8 File Offset: 0x000302E8
				[Token(Token = "0x6006E70")]
				[Address(RVA = "0x21095B0", Offset = "0x21081B0", VA = "0x1821095B0")]
				public int GetEnemiesCnt()
				{
					return 0;
				}

				// Token: 0x06006E71 RID: 28273 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006E71")]
				[Address(RVA = "0x2109610", Offset = "0x2108210", VA = "0x182109610")]
				public PhaseData()
				{
				}

				// Token: 0x04005C53 RID: 23635
				[Token(Token = "0x4005C53")]
				[FieldOffset(Offset = "0x10")]
				public float preDelay;

				// Token: 0x04005C54 RID: 23636
				[Token(Token = "0x4005C54")]
				[FieldOffset(Offset = "0x18")]
				public LevelData.WaveData.FragmentData.ActionData[] actions;

				// Token: 0x04005C55 RID: 23637
				[Token(Token = "0x4005C55")]
				[FieldOffset(Offset = "0x20")]
				[NonSerialized]
				private readonly Dictionary<string, List<LevelData.WaveData.FragmentData.ActionData>> m_randomActionGroups;

				// Token: 0x04005C56 RID: 23638
				[Token(Token = "0x4005C56")]
				[FieldOffset(Offset = "0x28")]
				[NonSerialized]
				private readonly List<LevelData.WaveData.FragmentData.ActionData> m_actionWithRandomSpawn;

				// Token: 0x04005C57 RID: 23639
				[Token(Token = "0x4005C57")]
				[FieldOffset(Offset = "0x30")]
				[NonSerialized]
				private readonly HashSet<string> m_validActionPackKeys;
			}
		}

		// Token: 0x020010D3 RID: 4307
		[Token(Token = "0x20010D3")]
		[Serializable]
		public class GlobalBuffData
		{
			// Token: 0x06006E72 RID: 28274 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E72")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public GlobalBuffData()
			{
			}

			// Token: 0x04005C58 RID: 23640
			[Token(Token = "0x4005C58")]
			[FieldOffset(Offset = "0x10")]
			public string prefabKey;

			// Token: 0x04005C59 RID: 23641
			[Token(Token = "0x4005C59")]
			[FieldOffset(Offset = "0x18")]
			public Blackboard blackboard;

			// Token: 0x04005C5A RID: 23642
			[Token(Token = "0x4005C5A")]
			[FieldOffset(Offset = "0x20")]
			public string overrideCameraEffect;

			// Token: 0x04005C5B RID: 23643
			[Token(Token = "0x4005C5B")]
			[FieldOffset(Offset = "0x28")]
			public bool passProfessionMaskFlag;

			// Token: 0x04005C5C RID: 23644
			[Token(Token = "0x4005C5C")]
			[FieldOffset(Offset = "0x2C")]
			public ProfessionCategory professionMask;

			// Token: 0x04005C5D RID: 23645
			[Token(Token = "0x4005C5D")]
			[FieldOffset(Offset = "0x30")]
			public PlayerSideMask playerSideMask;

			// Token: 0x04005C5E RID: 23646
			[Token(Token = "0x4005C5E")]
			[FieldOffset(Offset = "0x31")]
			[NonSerialized]
			public bool useExtraData;

			// Token: 0x04005C5F RID: 23647
			[Token(Token = "0x4005C5F")]
			[FieldOffset(Offset = "0x38")]
			[NonSerialized]
			public LevelData.GlobalBuffData.ExtraRuntimeData extraRuntimeData;

			// Token: 0x020010D4 RID: 4308
			[Token(Token = "0x20010D4")]
			public class ExtraRuntimeData
			{
				// Token: 0x06006E73 RID: 28275 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006E73")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public ExtraRuntimeData()
				{
				}

				// Token: 0x04005C60 RID: 23648
				[Token(Token = "0x4005C60")]
				[FieldOffset(Offset = "0x10")]
				public SideType sideType;

				// Token: 0x04005C61 RID: 23649
				[Token(Token = "0x4005C61")]
				[FieldOffset(Offset = "0x18")]
				public GlobalBuff.GlobalBuffExtraValidatorDelegate extraValidator;

				// Token: 0x04005C62 RID: 23650
				[Token(Token = "0x4005C62")]
				[FieldOffset(Offset = "0x20")]
				public bool checkExtraProfession;
			}
		}

		// Token: 0x020010D5 RID: 4309
		[Token(Token = "0x20010D5")]
		[Serializable]
		public class PredefinedData
		{
			// Token: 0x06006E74 RID: 28276 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E74")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PredefinedData()
			{
			}

			// Token: 0x04005C63 RID: 23651
			[Token(Token = "0x4005C63")]
			[FieldOffset(Offset = "0x10")]
			public LevelData.PredefinedData.PredefinedCharacter[] characterInsts;

			// Token: 0x04005C64 RID: 23652
			[Token(Token = "0x4005C64")]
			[FieldOffset(Offset = "0x18")]
			public LevelData.PredefinedData.PredefinedCharacter[] tokenInsts;

			// Token: 0x04005C65 RID: 23653
			[Token(Token = "0x4005C65")]
			[FieldOffset(Offset = "0x20")]
			public LevelData.PredefinedData.PredefinedCard[] characterCards;

			// Token: 0x04005C66 RID: 23654
			[Token(Token = "0x4005C66")]
			[FieldOffset(Offset = "0x28")]
			public LevelData.PredefinedData.PredefinedTokenCard[] tokenCards;

			// Token: 0x020010D6 RID: 4310
			[Token(Token = "0x20010D6")]
			[Serializable]
			public class PredefinedInst : AdvancedCharacterInst
			{
				// Token: 0x17000D26 RID: 3366
				// (get) Token: 0x06006E75 RID: 28277 RVA: 0x00032100 File Offset: 0x00030300
				[Token(Token = "0x17000D26")]
				public override bool isPredefined
				{
					[Token(Token = "0x6006E75")]
					[Address(RVA = "0x508E70", Offset = "0x507A70", VA = "0x180508E70", Slot = "4")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17000D27 RID: 3367
				// (get) Token: 0x06006E76 RID: 28278 RVA: 0x00032118 File Offset: 0x00030318
				[Token(Token = "0x17000D27")]
				public override bool isHidden
				{
					[Token(Token = "0x6006E76")]
					[Address(RVA = "0x2109C30", Offset = "0x2108830", VA = "0x182109C30", Slot = "5")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x06006E77 RID: 28279 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x6006E77")]
				[Address(RVA = "0x2109C00", Offset = "0x2108800", VA = "0x182109C00", Slot = "6")]
				public override string GetAliasId()
				{
					return null;
				}

				// Token: 0x06006E78 RID: 28280 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006E78")]
				[Address(RVA = "0x20FE580", Offset = "0x20FD180", VA = "0x1820FE580")]
				public PredefinedInst()
				{
				}

				// Token: 0x04005C67 RID: 23655
				[Token(Token = "0x4005C67")]
				[FieldOffset(Offset = "0x70")]
				public bool hidden;

				// Token: 0x04005C68 RID: 23656
				[Token(Token = "0x4005C68")]
				[FieldOffset(Offset = "0x78")]
				public string alias;
			}

			// Token: 0x020010D7 RID: 4311
			[Token(Token = "0x20010D7")]
			[Serializable]
			public class PredefinedCharacter : LevelData.PredefinedData.PredefinedInst
			{
				// Token: 0x06006E79 RID: 28281 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006E79")]
				[Address(RVA = "0x2109BE0", Offset = "0x21087E0", VA = "0x182109BE0")]
				public PredefinedCharacter()
				{
				}

				// Token: 0x04005C69 RID: 23657
				[Token(Token = "0x4005C69")]
				[FieldOffset(Offset = "0x80")]
				public GridPosition position;

				// Token: 0x04005C6A RID: 23658
				[Token(Token = "0x4005C6A")]
				[FieldOffset(Offset = "0x88")]
				public SharedConsts.Direction direction;
			}

			// Token: 0x020010D8 RID: 4312
			[Token(Token = "0x20010D8")]
			[Serializable]
			public class PredefinedCard : LevelData.PredefinedData.PredefinedInst
			{
				// Token: 0x06006E7A RID: 28282 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006E7A")]
				[Address(RVA = "0x20FE580", Offset = "0x20FD180", VA = "0x1820FE580")]
				public PredefinedCard()
				{
				}
			}

			// Token: 0x020010D9 RID: 4313
			[Token(Token = "0x20010D9")]
			[Serializable]
			public class PredefinedTokenCard : LevelData.PredefinedData.PredefinedCard
			{
				// Token: 0x06006E7B RID: 28283 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6006E7B")]
				[Address(RVA = "0x20FE580", Offset = "0x20FD180", VA = "0x1820FE580")]
				public PredefinedTokenCard()
				{
				}

				// Token: 0x04005C6B RID: 23659
				[Token(Token = "0x4005C6B")]
				[FieldOffset(Offset = "0x80")]
				public int initialCnt;
			}
		}

		// Token: 0x020010DA RID: 4314
		[Token(Token = "0x20010DA")]
		public class RuntimeData
		{
			// Token: 0x06006E7C RID: 28284 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6006E7C")]
			[Address(RVA = "0x2114C60", Offset = "0x2113860", VA = "0x182114C60")]
			public RuntimeData()
			{
			}

			// Token: 0x04005C6C RID: 23660
			[Token(Token = "0x4005C6C")]
			[FieldOffset(Offset = "0x10")]
			public List<LevelData.EnemyDataDbReference> extraLoadEnemies;
		}
	}
}
