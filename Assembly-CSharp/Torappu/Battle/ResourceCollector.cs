using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using Torappu.Battle.Effects;
using Torappu.ObjectPool;
using Torappu.Resource;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020023F0 RID: 9200
	[Token(Token = "0x20023F0")]
	public class ResourceCollector : MonoBehaviour, IHotfixable
	{
		// Token: 0x17001DFC RID: 7676
		// (get) Token: 0x0600EB14 RID: 60180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001DFC")]
		public BattleAudioLoader audioLoader
		{
			[Token(Token = "0x600EB14")]
			[Address(RVA = "0x613730", Offset = "0x612330", VA = "0x180613730")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600EB15 RID: 60181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB15")]
		[Address(RVA = "0x612F30", Offset = "0x611B30", VA = "0x180612F30")]
		public IEnumerator Gather(LevelData levelData, List<BattlePlayerData> playerDataList, AbstractAssetLoader assetLoader, LevelData.Difficulty difficulty)
		{
			return null;
		}

		// Token: 0x0600EB16 RID: 60182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB16")]
		[Address(RVA = "0x613050", Offset = "0x611C50", VA = "0x180613050")]
		public PoolManager.ObjectConfig[] GetPreloadConfigs()
		{
			return null;
		}

		// Token: 0x0600EB17 RID: 60183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600EB17")]
		[Address(RVA = "0x613120", Offset = "0x611D20", VA = "0x180613120")]
		public List<PoolManager.ObjectConfig> GetRuntimeLoadConfigs()
		{
			return null;
		}

		// Token: 0x0600EB18 RID: 60184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB18")]
		[Address(RVA = "0x612E90", Offset = "0x611A90", VA = "0x180612E90")]
		public static void GatherEffectsFromBuff(List<string> effects, IBuffSource source)
		{
		}

		// Token: 0x0600EB19 RID: 60185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB19")]
		[Address(RVA = "0x612DF0", Offset = "0x6119F0", VA = "0x180612DF0")]
		public static void GatherActionNodesFromBuff(List<ActionNode> actions, IBuffSource source)
		{
		}

		// Token: 0x0600EB1A RID: 60186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB1A")]
		[Address(RVA = "0x6131D0", Offset = "0x611DD0", VA = "0x1806131D0")]
		public static void PreloadSingleEffect(string effect, bool allowAutoReuse, int preloadCnt = 10)
		{
		}

		// Token: 0x0600EB1B RID: 60187 RVA: 0x00056100 File Offset: 0x00054300
		[Token(Token = "0x600EB1B")]
		[Address(RVA = "0x613430", Offset = "0x612030", VA = "0x180613430")]
		public static bool TryGetEquipSetting(CharacterData.UniqueEquipPair query, out BattleUniEquipSetting equipSetting)
		{
			return default(bool);
		}

		// Token: 0x0600EB1C RID: 60188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600EB1C")]
		[Address(RVA = "0x613690", Offset = "0x612290", VA = "0x180613690")]
		public ResourceCollector()
		{
		}

		// Token: 0x0401039F RID: 66463
		[Token(Token = "0x401039F")]
		public const int EFFECT_PRELOAD_DEFAULT_CNT = 10;

		// Token: 0x040103A0 RID: 66464
		[Token(Token = "0x40103A0")]
		public const int ENEMY_PRELOAD_CNT = 10;

		// Token: 0x040103A1 RID: 66465
		[Token(Token = "0x40103A1")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private string[] _extraEffects;

		// Token: 0x040103A2 RID: 66466
		[Token(Token = "0x40103A2")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BattleAudioLoader _audioLoader;

		// Token: 0x040103A3 RID: 66467
		[Token(Token = "0x40103A3")]
		[FieldOffset(Offset = "0x28")]
		private ResourceCollector.ResourceCollectHandler m_handler;

		// Token: 0x040103A4 RID: 66468
		[Token(Token = "0x40103A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_audioLoader;

		// Token: 0x040103A5 RID: 66469
		[Token(Token = "0x40103A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Gather;

		// Token: 0x040103A6 RID: 66470
		[Token(Token = "0x40103A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetPreloadConfigs;

		// Token: 0x040103A7 RID: 66471
		[Token(Token = "0x40103A7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetRuntimeLoadConfigs;

		// Token: 0x040103A8 RID: 66472
		[Token(Token = "0x40103A8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GatherEffectsFromBuff;

		// Token: 0x040103A9 RID: 66473
		[Token(Token = "0x40103A9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GatherActionNodesFromBuff;

		// Token: 0x040103AA RID: 66474
		[Token(Token = "0x40103AA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_PreloadSingleEffect;

		// Token: 0x040103AB RID: 66475
		[Token(Token = "0x40103AB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_TryGetEquipSetting;

		// Token: 0x040103AC RID: 66476
		[Token(Token = "0x40103AC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020023F1 RID: 9201
		[Token(Token = "0x20023F1")]
		public enum PreloadType
		{
			// Token: 0x040103AE RID: 66478
			[Token(Token = "0x40103AE")]
			CHARACTER,
			// Token: 0x040103AF RID: 66479
			[Token(Token = "0x40103AF")]
			TOKEN,
			// Token: 0x040103B0 RID: 66480
			[Token(Token = "0x40103B0")]
			ENEMY,
			// Token: 0x040103B1 RID: 66481
			[Token(Token = "0x40103B1")]
			PROJECTILE,
			// Token: 0x040103B2 RID: 66482
			[Token(Token = "0x40103B2")]
			EFFECT,
			// Token: 0x040103B3 RID: 66483
			[Token(Token = "0x40103B3")]
			DYNAMIC_ABILITY,
			// Token: 0x040103B4 RID: 66484
			[Token(Token = "0x40103B4")]
			ENV_SYSTEM,
			// Token: 0x040103B5 RID: 66485
			[Token(Token = "0x40103B5")]
			GLOBAL_BUFF
		}

		// Token: 0x020023F2 RID: 9202
		[Token(Token = "0x20023F2")]
		public class ResourceCollectHandler : IHotfixable
		{
			// Token: 0x17001DFD RID: 7677
			// (get) Token: 0x0600EB1D RID: 60189 RVA: 0x00056118 File Offset: 0x00054318
			[Token(Token = "0x17001DFD")]
			private bool m_isComplete
			{
				[Token(Token = "0x600EB1D")]
				[Address(RVA = "0x612C70", Offset = "0x611870", VA = "0x180612C70")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x0600EB1E RID: 60190 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB1E")]
			[Address(RVA = "0x60FF80", Offset = "0x60EB80", VA = "0x18060FF80")]
			public void Reset()
			{
			}

			// Token: 0x0600EB1F RID: 60191 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600EB1F")]
			[Address(RVA = "0x60FB00", Offset = "0x60E700", VA = "0x18060FB00")]
			public IEnumerator Gather(MonoBehaviour host, BattleAudioLoader audioLoader, LevelData levelData, List<BattlePlayerData> playerDataList, AbstractAssetLoader assetLoader, LevelData.Difficulty difficulty)
			{
				return null;
			}

			// Token: 0x0600EB20 RID: 60192 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB20")]
			[Address(RVA = "0x6124A0", Offset = "0x6110A0", VA = "0x1806124A0")]
			private void _GetOperaPreloadRes(string key, string configPath, List<string> operaAudioList, List<string> operaEffectList)
			{
			}

			// Token: 0x0600EB21 RID: 60193 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600EB21")]
			[Address(RVA = "0x60FC80", Offset = "0x60E880", VA = "0x18060FC80")]
			public PoolManager.ObjectConfig[] GetPreloadConfigs()
			{
				return null;
			}

			// Token: 0x0600EB22 RID: 60194 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600EB22")]
			[Address(RVA = "0x60FD10", Offset = "0x60E910", VA = "0x18060FD10")]
			public List<PoolManager.ObjectConfig> GetRuntimeLoadConfigs()
			{
				return null;
			}

			// Token: 0x0600EB23 RID: 60195 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB23")]
			[Address(RVA = "0x60E2F0", Offset = "0x60CEF0", VA = "0x18060E2F0")]
			public static void GatherEffectsFromBuff(List<string> effects, IBuffSource source)
			{
			}

			// Token: 0x0600EB24 RID: 60196 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB24")]
			[Address(RVA = "0x611250", Offset = "0x60FE50", VA = "0x180611250")]
			private static void _GatherEffectsFromBuff(List<string> effects, List<BuffData> buffs)
			{
			}

			// Token: 0x0600EB25 RID: 60197 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB25")]
			[Address(RVA = "0x611CC0", Offset = "0x6108C0", VA = "0x180611CC0")]
			private static void _GatherEffectsFromSingleBuff(List<string> effects, BuffData buffData, bool searchInside)
			{
			}

			// Token: 0x0600EB26 RID: 60198 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB26")]
			[Address(RVA = "0x611FC0", Offset = "0x610BC0", VA = "0x180611FC0")]
			private static void _GatherEffectsInsideTemplate(List<string> effects, BuffTemplate template)
			{
			}

			// Token: 0x0600EB27 RID: 60199 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB27")]
			[Address(RVA = "0x60D2C0", Offset = "0x60BEC0", VA = "0x18060D2C0")]
			public static void GatherActionNodesFromBuff(List<ActionNode> actions, IBuffSource source)
			{
			}

			// Token: 0x0600EB28 RID: 60200 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB28")]
			[Address(RVA = "0x60D150", Offset = "0x60BD50", VA = "0x18060D150")]
			protected static void GatherActionNodesFromBuff(List<ActionNode> actions, BuffData buff)
			{
			}

			// Token: 0x0600EB29 RID: 60201 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600EB29")]
			[Address(RVA = "0x60E460", Offset = "0x60D060", VA = "0x18060E460")]
			protected IEnumerator GatherEnemy(LevelData.EnemyData enemyData, ResourceCollector.ResourceCollectHandler.TaskWrapper task)
			{
				return null;
			}

			// Token: 0x0600EB2A RID: 60202 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600EB2A")]
			[Address(RVA = "0x60DFC0", Offset = "0x60CBC0", VA = "0x18060DFC0")]
			protected IEnumerator GatherCharacter(BattleCharacterData characterData, ResourceCollector.ResourceCollectHandler.TaskWrapper task)
			{
				return null;
			}

			// Token: 0x0600EB2B RID: 60203 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600EB2B")]
			[Address(RVA = "0x60F910", Offset = "0x60E510", VA = "0x18060F910")]
			protected IEnumerator GatherToken(BattleCharacterData characterData, ResourceCollector.ResourceCollectHandler.TaskWrapper task)
			{
				return null;
			}

			// Token: 0x0600EB2C RID: 60204 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600EB2C")]
			[Address(RVA = "0x60F820", Offset = "0x60E420", VA = "0x18060F820")]
			protected IEnumerator GatherSkin(CharSkinData skinData)
			{
				return null;
			}

			// Token: 0x0600EB2D RID: 60205 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB2D")]
			[Address(RVA = "0x60FA20", Offset = "0x60E620", VA = "0x18060FA20")]
			protected void GatherUniEquip(List<BattleUniEquipSetting> settings)
			{
			}

			// Token: 0x0600EB2E RID: 60206 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB2E")]
			[Address(RVA = "0x60E7A0", Offset = "0x60D3A0", VA = "0x18060E7A0")]
			protected void GatherExtraEnemyFromTalent(List<TalentData> talentDataList, int mainSkillIndex)
			{
			}

			// Token: 0x0600EB2F RID: 60207 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600EB2F")]
			[Address(RVA = "0x60F730", Offset = "0x60E330", VA = "0x18060F730")]
			protected IEnumerator GatherSkill(SkillData skillData)
			{
				return null;
			}

			// Token: 0x0600EB30 RID: 60208 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600EB30")]
			[Address(RVA = "0x60F640", Offset = "0x60E240", VA = "0x18060F640")]
			protected IEnumerator GatherSkillRelatedEffectBlacklist(SkillData skillData)
			{
				return null;
			}

			// Token: 0x0600EB31 RID: 60209 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB31")]
			[Address(RVA = "0x6106A0", Offset = "0x60F2A0", VA = "0x1806106A0")]
			private void _CheckDisableGatherEffect()
			{
			}

			// Token: 0x0600EB32 RID: 60210 RVA: 0x00056130 File Offset: 0x00054330
			[Token(Token = "0x600EB32")]
			[Address(RVA = "0x6105A0", Offset = "0x60F1A0", VA = "0x1806105A0")]
			private int _CalcEffectPreloadSize(int cfgSize)
			{
				return 0;
			}

			// Token: 0x0600EB33 RID: 60211 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600EB33")]
			[Address(RVA = "0x60E1E0", Offset = "0x60CDE0", VA = "0x18060E1E0")]
			protected IEnumerator GatherEffect(string effectKey, ResourceCollector.ResourceCollectHandler.TaskWrapper taskWrapper)
			{
				return null;
			}

			// Token: 0x0600EB34 RID: 60212 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600EB34")]
			[Address(RVA = "0x60F530", Offset = "0x60E130", VA = "0x18060F530")]
			protected IEnumerator GatherProjectile(string projectileKey, ResourceCollector.ResourceCollectHandler.TaskWrapper task)
			{
				return null;
			}

			// Token: 0x0600EB35 RID: 60213 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600EB35")]
			[Address(RVA = "0x60E0D0", Offset = "0x60CCD0", VA = "0x18060E0D0")]
			protected IEnumerator GatherDynamicAbility(List<object> abilityName, ResourceCollector.ResourceCollectHandler.TaskWrapper task)
			{
				return null;
			}

			// Token: 0x0600EB36 RID: 60214 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB36")]
			[Address(RVA = "0x60E680", Offset = "0x60D280", VA = "0x18060E680")]
			protected void GatherExtraEffects()
			{
			}

			// Token: 0x0600EB37 RID: 60215 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB37")]
			[Address(RVA = "0x612150", Offset = "0x610D50", VA = "0x180612150")]
			private void _GatherEpBreakBuffEffects()
			{
			}

			// Token: 0x0600EB38 RID: 60216 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600EB38")]
			[Address(RVA = "0x60E570", Offset = "0x60D170", VA = "0x18060E570")]
			protected IEnumerator GatherEnvSystem(string envSystemPrefab, ResourceCollector.ResourceCollectHandler.TaskWrapper task)
			{
				return null;
			}

			// Token: 0x0600EB39 RID: 60217 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600EB39")]
			[Address(RVA = "0x60EF30", Offset = "0x60DB30", VA = "0x18060EF30")]
			protected IEnumerator GatherGlobalBuff(string globalBuffPrefab, ResourceCollector.ResourceCollectHandler.TaskWrapper task)
			{
				return null;
			}

			// Token: 0x0600EB3A RID: 60218 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB3A")]
			[Address(RVA = "0x60D4D0", Offset = "0x60C0D0", VA = "0x18060D4D0")]
			protected void GatherAssetsFromGameMode()
			{
			}

			// Token: 0x0600EB3B RID: 60219 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB3B")]
			[Address(RVA = "0x60F040", Offset = "0x60DC40", VA = "0x18060F040")]
			protected void GatherInputAndLevelRunes(LevelData levelData)
			{
			}

			// Token: 0x0600EB3C RID: 60220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB3C")]
			protected void GatherAssetsInternal<T>(T obj) where T : IEffectSource, IProjectileSource, IActionNodeSource
			{
			}

			// Token: 0x0600EB3D RID: 60221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB3D")]
			[Address(RVA = "0x6114A0", Offset = "0x6100A0", VA = "0x1806114A0")]
			private void _GatherEffectsFromBuffsRecursively(int depth, ref List<BuffData> buffList, ref List<string> assetList)
			{
			}

			// Token: 0x0600EB3E RID: 60222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB3E")]
			[Address(RVA = "0x60DE90", Offset = "0x60CA90", VA = "0x18060DE90")]
			protected void GatherAssetsInsideEffect(Effect effect)
			{
			}

			// Token: 0x0600EB3F RID: 60223 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB3F")]
			[Address(RVA = "0x60ECB0", Offset = "0x60D8B0", VA = "0x18060ECB0")]
			protected void GatherFromEffectSource(IEffectSource source)
			{
			}

			// Token: 0x0600EB40 RID: 60224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB40")]
			[Address(RVA = "0x60EDF0", Offset = "0x60D9F0", VA = "0x18060EDF0")]
			protected void GatherFromProjectileSource(IProjectileSource source)
			{
			}

			// Token: 0x0600EB41 RID: 60225 RVA: 0x00056148 File Offset: 0x00054348
			[Token(Token = "0x600EB41")]
			[Address(RVA = "0x60CF70", Offset = "0x60BB70", VA = "0x18060CF70")]
			protected bool AppendRes(PoolManager.ObjectConfig config, bool alreadyInHashSet = false, bool preload = true)
			{
				return default(bool);
			}

			// Token: 0x0600EB42 RID: 60226 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB42")]
			[Address(RVA = "0x610B50", Offset = "0x60F750", VA = "0x180610B50")]
			private void _CreateTask(ResourceCollector.PreloadType type, object arg)
			{
			}

			// Token: 0x0600EB43 RID: 60227 RVA: 0x00056160 File Offset: 0x00054360
			[Token(Token = "0x600EB43")]
			[Address(RVA = "0x610A10", Offset = "0x60F610", VA = "0x180610A10")]
			private static PoolManager.ObjectConfig _CreateConfig(string path, GameObjectPool.Options options)
			{
				return default(PoolManager.ObjectConfig);
			}

			// Token: 0x0600EB44 RID: 60228 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB44")]
			[Address(RVA = "0x60FD80", Offset = "0x60E980", VA = "0x18060FD80")]
			public static void PreloadSingleEffect(string effect, bool allowAutoReuse, int preloadCnt = 10)
			{
			}

			// Token: 0x0600EB45 RID: 60229 RVA: 0x00056178 File Offset: 0x00054378
			[Token(Token = "0x600EB45")]
			[Address(RVA = "0x6100E0", Offset = "0x60ECE0", VA = "0x1806100E0")]
			public static bool TryGetEquipSetting(CharacterData.UniqueEquipPair query, out BattleUniEquipSetting equipSetting)
			{
				return default(bool);
			}

			// Token: 0x0600EB46 RID: 60230 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB46")]
			[Address(RVA = "0x6127A0", Offset = "0x6113A0", VA = "0x1806127A0")]
			private void _StartPreloadTask(MonoBehaviour host)
			{
			}

			// Token: 0x0600EB47 RID: 60231 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600EB47")]
			[Address(RVA = "0x6129F0", Offset = "0x6115F0", VA = "0x1806129F0")]
			public ResourceCollectHandler()
			{
			}

			// Token: 0x040103B6 RID: 66486
			[Token(Token = "0x40103B6")]
			private const int PROJECTILE_PRELOAD_CNT = 10;

			// Token: 0x040103B7 RID: 66487
			[Token(Token = "0x40103B7")]
			private const int EFFECT_AUTO_REUSE_CAPACITY = 10;

			// Token: 0x040103B8 RID: 66488
			[Token(Token = "0x40103B8")]
			private const int DYNAMIC_ABILITY_CNT = 10;

			// Token: 0x040103B9 RID: 66489
			[Token(Token = "0x40103B9")]
			private const int ENV_SYSTEM_CNT = 1;

			// Token: 0x040103BA RID: 66490
			[Token(Token = "0x40103BA")]
			private const int GLOBAL_BUFF_CNT = 1;

			// Token: 0x040103BB RID: 66491
			[Token(Token = "0x40103BB")]
			private const string BUFF_TEMPLATE_EMPTY_KEY = "empty";

			// Token: 0x040103BC RID: 66492
			[Token(Token = "0x40103BC")]
			[FieldOffset(Offset = "0x0")]
			private static List<BuffData> s_sharedBuffList;

			// Token: 0x040103BD RID: 66493
			[Token(Token = "0x40103BD")]
			[FieldOffset(Offset = "0x8")]
			private static List<ActionNode> s_sharedActionList;

			// Token: 0x040103BE RID: 66494
			[Token(Token = "0x40103BE")]
			[FieldOffset(Offset = "0x10")]
			private AbstractAssetLoader m_assetLoader;

			// Token: 0x040103BF RID: 66495
			[Token(Token = "0x40103BF")]
			[FieldOffset(Offset = "0x18")]
			private List<PoolManager.ObjectConfig> m_preloadConfigs;

			// Token: 0x040103C0 RID: 66496
			[Token(Token = "0x40103C0")]
			[FieldOffset(Offset = "0x20")]
			private List<PoolManager.ObjectConfig> m_runtimeLoadConfigs;

			// Token: 0x040103C1 RID: 66497
			[Token(Token = "0x40103C1")]
			[FieldOffset(Offset = "0x28")]
			private HashSet<string> m_hashSet;

			// Token: 0x040103C2 RID: 66498
			[Token(Token = "0x40103C2")]
			[FieldOffset(Offset = "0x30")]
			private Queue<ResourceCollector.ResourceCollectHandler.TaskWrapper> m_paddingTasks;

			// Token: 0x040103C3 RID: 66499
			[Token(Token = "0x40103C3")]
			[FieldOffset(Offset = "0x38")]
			private List<ResourceCollector.ResourceCollectHandler.TaskWrapper> m_runningTasks;

			// Token: 0x040103C4 RID: 66500
			[Token(Token = "0x40103C4")]
			[FieldOffset(Offset = "0x40")]
			private List<string> m_effectBlackList;

			// Token: 0x040103C5 RID: 66501
			[Token(Token = "0x40103C5")]
			[FieldOffset(Offset = "0x48")]
			private List<string> m_effectBlackListIncludeSkin;

			// Token: 0x040103C6 RID: 66502
			[Token(Token = "0x40103C6")]
			[FieldOffset(Offset = "0x50")]
			private BattleAudioLoader m_audioLoader;

			// Token: 0x040103C7 RID: 66503
			[Token(Token = "0x40103C7")]
			[FieldOffset(Offset = "0x58")]
			private int m_yieldCnt;

			// Token: 0x040103C8 RID: 66504
			[Token(Token = "0x40103C8")]
			[FieldOffset(Offset = "0x5C")]
			private bool m_disableGatherEffect;

			// Token: 0x040103C9 RID: 66505
			[Token(Token = "0x40103C9")]
			[FieldOffset(Offset = "0x60")]
			private float m_startTime;

			// Token: 0x040103CA RID: 66506
			[Token(Token = "0x40103CA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_m_isComplete;

			// Token: 0x040103CB RID: 66507
			[Token(Token = "0x40103CB")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_Reset;

			// Token: 0x040103CC RID: 66508
			[Token(Token = "0x40103CC")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_Gather;

			// Token: 0x040103CD RID: 66509
			[Token(Token = "0x40103CD")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0__GetOperaPreloadRes;

			// Token: 0x040103CE RID: 66510
			[Token(Token = "0x40103CE")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0_GetPreloadConfigs;

			// Token: 0x040103CF RID: 66511
			[Token(Token = "0x40103CF")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge __Hotfix0_GetRuntimeLoadConfigs;

			// Token: 0x040103D0 RID: 66512
			[Token(Token = "0x40103D0")]
			[FieldOffset(Offset = "0x40")]
			private static DelegateBridge __Hotfix0_GatherEffectsFromBuff;

			// Token: 0x040103D1 RID: 66513
			[Token(Token = "0x40103D1")]
			[FieldOffset(Offset = "0x48")]
			private static DelegateBridge __Hotfix0__GatherEffectsFromBuff;

			// Token: 0x040103D2 RID: 66514
			[Token(Token = "0x40103D2")]
			[FieldOffset(Offset = "0x50")]
			private static DelegateBridge __Hotfix0__GatherEffectsFromSingleBuff;

			// Token: 0x040103D3 RID: 66515
			[Token(Token = "0x40103D3")]
			[FieldOffset(Offset = "0x58")]
			private static DelegateBridge __Hotfix0__GatherEffectsInsideTemplate;

			// Token: 0x040103D4 RID: 66516
			[Token(Token = "0x40103D4")]
			[FieldOffset(Offset = "0x60")]
			private static DelegateBridge __Hotfix0_GatherActionNodesFromBuff;

			// Token: 0x040103D5 RID: 66517
			[Token(Token = "0x40103D5")]
			[FieldOffset(Offset = "0x68")]
			private static DelegateBridge __Hotfix1_GatherActionNodesFromBuff;

			// Token: 0x040103D6 RID: 66518
			[Token(Token = "0x40103D6")]
			[FieldOffset(Offset = "0x70")]
			private static DelegateBridge __Hotfix0_GatherEnemy;

			// Token: 0x040103D7 RID: 66519
			[Token(Token = "0x40103D7")]
			[FieldOffset(Offset = "0x78")]
			private static DelegateBridge __Hotfix0_GatherCharacter;

			// Token: 0x040103D8 RID: 66520
			[Token(Token = "0x40103D8")]
			[FieldOffset(Offset = "0x80")]
			private static DelegateBridge __Hotfix0_GatherToken;

			// Token: 0x040103D9 RID: 66521
			[Token(Token = "0x40103D9")]
			[FieldOffset(Offset = "0x88")]
			private static DelegateBridge __Hotfix0_GatherSkin;

			// Token: 0x040103DA RID: 66522
			[Token(Token = "0x40103DA")]
			[FieldOffset(Offset = "0x90")]
			private static DelegateBridge __Hotfix0_GatherUniEquip;

			// Token: 0x040103DB RID: 66523
			[Token(Token = "0x40103DB")]
			[FieldOffset(Offset = "0x98")]
			private static DelegateBridge __Hotfix0_GatherExtraEnemyFromTalent;

			// Token: 0x040103DC RID: 66524
			[Token(Token = "0x40103DC")]
			[FieldOffset(Offset = "0xA0")]
			private static DelegateBridge __Hotfix0_GatherSkill;

			// Token: 0x040103DD RID: 66525
			[Token(Token = "0x40103DD")]
			[FieldOffset(Offset = "0xA8")]
			private static DelegateBridge __Hotfix0_GatherSkillRelatedEffectBlacklist;

			// Token: 0x040103DE RID: 66526
			[Token(Token = "0x40103DE")]
			[FieldOffset(Offset = "0xB0")]
			private static DelegateBridge __Hotfix0__CheckDisableGatherEffect;

			// Token: 0x040103DF RID: 66527
			[Token(Token = "0x40103DF")]
			[FieldOffset(Offset = "0xB8")]
			private static DelegateBridge __Hotfix0__CalcEffectPreloadSize;

			// Token: 0x040103E0 RID: 66528
			[Token(Token = "0x40103E0")]
			[FieldOffset(Offset = "0xC0")]
			private static DelegateBridge __Hotfix0_GatherEffect;

			// Token: 0x040103E1 RID: 66529
			[Token(Token = "0x40103E1")]
			[FieldOffset(Offset = "0xC8")]
			private static DelegateBridge __Hotfix0_GatherProjectile;

			// Token: 0x040103E2 RID: 66530
			[Token(Token = "0x40103E2")]
			[FieldOffset(Offset = "0xD0")]
			private static DelegateBridge __Hotfix0_GatherDynamicAbility;

			// Token: 0x040103E3 RID: 66531
			[Token(Token = "0x40103E3")]
			[FieldOffset(Offset = "0xD8")]
			private static DelegateBridge __Hotfix0_GatherExtraEffects;

			// Token: 0x040103E4 RID: 66532
			[Token(Token = "0x40103E4")]
			[FieldOffset(Offset = "0xE0")]
			private static DelegateBridge __Hotfix0__GatherEpBreakBuffEffects;

			// Token: 0x040103E5 RID: 66533
			[Token(Token = "0x40103E5")]
			[FieldOffset(Offset = "0xE8")]
			private static DelegateBridge __Hotfix0_GatherEnvSystem;

			// Token: 0x040103E6 RID: 66534
			[Token(Token = "0x40103E6")]
			[FieldOffset(Offset = "0xF0")]
			private static DelegateBridge __Hotfix0_GatherGlobalBuff;

			// Token: 0x040103E7 RID: 66535
			[Token(Token = "0x40103E7")]
			[FieldOffset(Offset = "0xF8")]
			private static DelegateBridge __Hotfix0_GatherAssetsFromGameMode;

			// Token: 0x040103E8 RID: 66536
			[Token(Token = "0x40103E8")]
			[FieldOffset(Offset = "0x100")]
			private static DelegateBridge __Hotfix0_GatherInputAndLevelRunes;

			// Token: 0x040103E9 RID: 66537
			[Token(Token = "0x40103E9")]
			[FieldOffset(Offset = "0x108")]
			private static DelegateBridge __Hotfix0_GatherAssetsInternal;

			// Token: 0x040103EA RID: 66538
			[Token(Token = "0x40103EA")]
			[FieldOffset(Offset = "0x110")]
			private static DelegateBridge __Hotfix0__GatherEffectsFromBuffsRecursively;

			// Token: 0x040103EB RID: 66539
			[Token(Token = "0x40103EB")]
			[FieldOffset(Offset = "0x118")]
			private static DelegateBridge __Hotfix0_GatherAssetsInsideEffect;

			// Token: 0x040103EC RID: 66540
			[Token(Token = "0x40103EC")]
			[FieldOffset(Offset = "0x120")]
			private static DelegateBridge __Hotfix0_GatherFromEffectSource;

			// Token: 0x040103ED RID: 66541
			[Token(Token = "0x40103ED")]
			[FieldOffset(Offset = "0x128")]
			private static DelegateBridge __Hotfix0_GatherFromProjectileSource;

			// Token: 0x040103EE RID: 66542
			[Token(Token = "0x40103EE")]
			[FieldOffset(Offset = "0x130")]
			private static DelegateBridge __Hotfix0_AppendRes;

			// Token: 0x040103EF RID: 66543
			[Token(Token = "0x40103EF")]
			[FieldOffset(Offset = "0x138")]
			private static DelegateBridge __Hotfix0__CreateTask;

			// Token: 0x040103F0 RID: 66544
			[Token(Token = "0x40103F0")]
			[FieldOffset(Offset = "0x140")]
			private static DelegateBridge __Hotfix0__CreateConfig;

			// Token: 0x040103F1 RID: 66545
			[Token(Token = "0x40103F1")]
			[FieldOffset(Offset = "0x148")]
			private static DelegateBridge __Hotfix0_PreloadSingleEffect;

			// Token: 0x040103F2 RID: 66546
			[Token(Token = "0x40103F2")]
			[FieldOffset(Offset = "0x150")]
			private static DelegateBridge __Hotfix0_TryGetEquipSetting;

			// Token: 0x040103F3 RID: 66547
			[Token(Token = "0x40103F3")]
			[FieldOffset(Offset = "0x158")]
			private static DelegateBridge __Hotfix0__StartPreloadTask;

			// Token: 0x040103F4 RID: 66548
			[Token(Token = "0x40103F4")]
			[FieldOffset(Offset = "0x160")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x020023F3 RID: 9203
			[Token(Token = "0x20023F3")]
			public class TaskWrapper
			{
				// Token: 0x0600EB4B RID: 60235 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600EB4B")]
				[Address(RVA = "0x618DD0", Offset = "0x6179D0", VA = "0x180618DD0")]
				public TaskWrapper()
				{
				}

				// Token: 0x17001DFE RID: 7678
				// (get) Token: 0x0600EB4C RID: 60236 RVA: 0x00056190 File Offset: 0x00054390
				[Token(Token = "0x17001DFE")]
				public bool isComplete
				{
					[Token(Token = "0x600EB4C")]
					[Address(RVA = "0x4E6310", Offset = "0x4E4F10", VA = "0x1804E6310")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x17001DFF RID: 7679
				// (get) Token: 0x0600EB4D RID: 60237 RVA: 0x000561A8 File Offset: 0x000543A8
				[Token(Token = "0x17001DFF")]
				public bool isRunning
				{
					[Token(Token = "0x600EB4D")]
					[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
					get
					{
						return default(bool);
					}
				}

				// Token: 0x0600EB4E RID: 60238 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600EB4E")]
				[Address(RVA = "0x618D70", Offset = "0x617970", VA = "0x180618D70")]
				public void CompleteTask()
				{
				}

				// Token: 0x0600EB4F RID: 60239 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600EB4F")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				public void HoldTask(IEnumerator task)
				{
				}

				// Token: 0x0600EB50 RID: 60240 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x600EB50")]
				[Address(RVA = "0x618D80", Offset = "0x617980", VA = "0x180618D80")]
				public Coroutine StartTask(MonoBehaviour mono)
				{
					return null;
				}

				// Token: 0x040103F5 RID: 66549
				[Token(Token = "0x40103F5")]
				[FieldOffset(Offset = "0x10")]
				private bool m_isRunning;

				// Token: 0x040103F6 RID: 66550
				[Token(Token = "0x40103F6")]
				[FieldOffset(Offset = "0x11")]
				private bool m_isComplete;

				// Token: 0x040103F7 RID: 66551
				[Token(Token = "0x40103F7")]
				[FieldOffset(Offset = "0x18")]
				private IEnumerator m_task;
			}
		}
	}
}
