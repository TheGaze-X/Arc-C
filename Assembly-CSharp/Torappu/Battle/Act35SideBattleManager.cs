using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020022C1 RID: 8897
	[Token(Token = "0x20022C1")]
	public class Act35SideBattleManager : GlobalEnvSystem.EnvManager, IAudioSource
	{
		// Token: 0x17001C16 RID: 7190
		// (get) Token: 0x0600DFC1 RID: 57281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C16")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600DFC1")]
			[Address(RVA = "0x3665140", Offset = "0x3663D40", VA = "0x183665140", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600DFC2 RID: 57282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFC2")]
		[Address(RVA = "0x365F590", Offset = "0x365E190", VA = "0x18365F590", Slot = "7")]
		public override void Init(GlobalEnvSystem envSystem)
		{
		}

		// Token: 0x0600DFC3 RID: 57283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFC3")]
		[Address(RVA = "0x365F880", Offset = "0x365E480", VA = "0x18365F880", Slot = "15")]
		public override void OnTrigger(object param)
		{
		}

		// Token: 0x0600DFC4 RID: 57284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFC4")]
		[Address(RVA = "0x365F2C0", Offset = "0x365DEC0", VA = "0x18365F2C0", Slot = "16")]
		public void GatherAudio(List<string> results)
		{
		}

		// Token: 0x0600DFC5 RID: 57285 RVA: 0x00051468 File Offset: 0x0004F668
		[Token(Token = "0x600DFC5")]
		[Address(RVA = "0x365F3A0", Offset = "0x365DFA0", VA = "0x18365F3A0")]
		public int GetGemsCount(bool excludeLinkGems = false)
		{
			return 0;
		}

		// Token: 0x0600DFC6 RID: 57286 RVA: 0x00051480 File Offset: 0x0004F680
		[Token(Token = "0x600DFC6")]
		[Address(RVA = "0x365EC30", Offset = "0x365D830", VA = "0x18365EC30")]
		public bool CheckIfOnGemsTile(GridPosition gridPosition, bool excludeLinkGems = false)
		{
			return default(bool);
		}

		// Token: 0x0600DFC7 RID: 57287 RVA: 0x00051498 File Offset: 0x0004F698
		[Token(Token = "0x600DFC7")]
		[Address(RVA = "0x365EB20", Offset = "0x365D720", VA = "0x18365EB20")]
		public static bool CheckIfOnExcludedTile(GridPosition gridPosition)
		{
			return default(bool);
		}

		// Token: 0x0600DFC8 RID: 57288 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFC8")]
		[Address(RVA = "0x365ED60", Offset = "0x365D960", VA = "0x18365ED60")]
		public void EliminateGemsByPositionAndDirection(int row, int col, SharedConsts.Direction direction)
		{
		}

		// Token: 0x0600DFC9 RID: 57289 RVA: 0x000514B0 File Offset: 0x0004F6B0
		[Token(Token = "0x600DFC9")]
		[Address(RVA = "0x36600A0", Offset = "0x365ECA0", VA = "0x1836600A0")]
		public bool SummonGemsEnemyOnTileWithoutRefresh(int row, int col, Act35SideBattleManager.GemsType type)
		{
			return default(bool);
		}

		// Token: 0x0600DFCA RID: 57290 RVA: 0x000514C8 File Offset: 0x0004F6C8
		[Token(Token = "0x600DFCA")]
		[Address(RVA = "0x365FFD0", Offset = "0x365EBD0", VA = "0x18365FFD0")]
		public bool SummonGemsEnemyOnTileAndRefresh(int row, int col, Act35SideBattleManager.GemsType type)
		{
			return default(bool);
		}

		// Token: 0x0600DFCB RID: 57291 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFCB")]
		[Address(RVA = "0x365FDC0", Offset = "0x365E9C0", VA = "0x18365FDC0")]
		public void SummonGemsEnemyOnLine(int row, int col, Act35SideBattleManager.GemsType type, SharedConsts.Direction direction)
		{
		}

		// Token: 0x0600DFCC RID: 57292 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFCC")]
		[Address(RVA = "0x365FCD0", Offset = "0x365E8D0", VA = "0x18365FCD0")]
		public void RefreshAndCheckMap()
		{
		}

		// Token: 0x0600DFCD RID: 57293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFCD")]
		[Address(RVA = "0x365FA60", Offset = "0x365E660", VA = "0x18365FA60")]
		public void RefreshAndCheckMapByPos(int row, int col)
		{
		}

		// Token: 0x0600DFCE RID: 57294 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFCE")]
		[Address(RVA = "0x36608D0", Offset = "0x365F4D0", VA = "0x1836608D0")]
		public void UpdateMaxLinkedGemsCount(int row, int col)
		{
		}

		// Token: 0x0600DFCF RID: 57295 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFCF")]
		[Address(RVA = "0x3663330", Offset = "0x3661F30", VA = "0x183663330")]
		private void _OnGameStart(object arg)
		{
		}

		// Token: 0x0600DFD0 RID: 57296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFD0")]
		[Address(RVA = "0x36635C0", Offset = "0x36621C0", VA = "0x1836635C0")]
		private void _OnGemsClear(Enemy enemy)
		{
		}

		// Token: 0x0600DFD1 RID: 57297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFD1")]
		[Address(RVA = "0x3662A00", Offset = "0x3661600", VA = "0x183662A00")]
		private void _OnClearGemsTakeDamage(Entity entity)
		{
		}

		// Token: 0x0600DFD2 RID: 57298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFD2")]
		[Address(RVA = "0x36639E0", Offset = "0x36625E0", VA = "0x1836639E0")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600DFD3 RID: 57299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFD3")]
		[Address(RVA = "0x3662F80", Offset = "0x3661B80", VA = "0x183662F80")]
		private void _OnEnemyBorn(Enemy enemy)
		{
		}

		// Token: 0x0600DFD4 RID: 57300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFD4")]
		[Address(RVA = "0x3662740", Offset = "0x3661340", VA = "0x183662740")]
		private void _OnCharacterBorn(Character character)
		{
		}

		// Token: 0x0600DFD5 RID: 57301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFD5")]
		[Address(RVA = "0x36631E0", Offset = "0x3661DE0", VA = "0x1836631E0")]
		private void _OnGameOver(object arg)
		{
		}

		// Token: 0x0600DFD6 RID: 57302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFD6")]
		[Address(RVA = "0x36623E0", Offset = "0x3660FE0", VA = "0x1836623E0")]
		private void _CountAndRemoveGems(Act35SideBattleManager.GemsEnemy gemsEnemy)
		{
		}

		// Token: 0x0600DFD7 RID: 57303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFD7")]
		[Address(RVA = "0x3663BF0", Offset = "0x36627F0", VA = "0x183663BF0")]
		private void _RemoveDeBuffsFromCharacter(Enemy enemy)
		{
		}

		// Token: 0x0600DFD8 RID: 57304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFD8")]
		[Address(RVA = "0x36609F0", Offset = "0x365F5F0", VA = "0x1836609F0")]
		private void _AddLinkEffectBuff(Entity owner, int row, int col)
		{
		}

		// Token: 0x0600DFD9 RID: 57305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFD9")]
		[Address(RVA = "0x3660CD0", Offset = "0x365F8D0", VA = "0x183660CD0")]
		private void _AddTransEffectBuff(Entity owner, Act35SideBattleManager.Area.SubClearArea subClearArea, int row, int col)
		{
		}

		// Token: 0x0600DFDA RID: 57306 RVA: 0x000514E0 File Offset: 0x0004F6E0
		[Token(Token = "0x600DFDA")]
		[Address(RVA = "0x3662650", Offset = "0x3661250", VA = "0x183662650")]
		private int _GetAreaId(int row, int col)
		{
			return 0;
		}

		// Token: 0x0600DFDB RID: 57307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFDB")]
		[Address(RVA = "0x3663F50", Offset = "0x3662B50", VA = "0x183663F50")]
		private void _RemoveInvalidAreasFromMap()
		{
		}

		// Token: 0x0600DFDC RID: 57308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFDC")]
		[Address(RVA = "0x3661B70", Offset = "0x3660770", VA = "0x183661B70")]
		private void _CheckAndEliminateGemsInMap()
		{
		}

		// Token: 0x0600DFDD RID: 57309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFDD")]
		[Address(RVA = "0x36618B0", Offset = "0x36604B0", VA = "0x1836618B0")]
		private void _CheckAndEliminateGemsByPos(int row, int col)
		{
		}

		// Token: 0x0600DFDE RID: 57310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFDE")]
		[Address(RVA = "0x36619E0", Offset = "0x36605E0", VA = "0x1836619E0")]
		private void _CheckAndEliminateGemsInArea(Act35SideBattleManager.Area area)
		{
		}

		// Token: 0x0600DFDF RID: 57311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFDF")]
		[Address(RVA = "0x3661CF0", Offset = "0x36608F0", VA = "0x183661CF0")]
		private void _CheckAndEliminateGemsInSubArea(Act35SideBattleManager.Area area, Act35SideBattleManager.Area.SubClearArea subClearArea)
		{
		}

		// Token: 0x0600DFE0 RID: 57312 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFE0")]
		[Address(RVA = "0x3664640", Offset = "0x3663240", VA = "0x183664640")]
		private void _ResetAreaIdMap()
		{
		}

		// Token: 0x0600DFE1 RID: 57313 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFE1")]
		[Address(RVA = "0x36641D0", Offset = "0x3662DD0", VA = "0x1836641D0")]
		private void _ResetAreaIdMapByArea(Act35SideBattleManager.Area area)
		{
		}

		// Token: 0x0600DFE2 RID: 57314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFE2")]
		[Address(RVA = "0x3664410", Offset = "0x3663010", VA = "0x183664410")]
		private void _ResetAreaIdMapByPos(int row, int col, bool checkNear = false)
		{
		}

		// Token: 0x0600DFE3 RID: 57315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFE3")]
		[Address(RVA = "0x3664A20", Offset = "0x3663620", VA = "0x183664A20")]
		private void _UpdateAreaMap()
		{
		}

		// Token: 0x0600DFE4 RID: 57316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFE4")]
		[Address(RVA = "0x3664960", Offset = "0x3663560", VA = "0x183664960")]
		private void _UpdateAreaMapByPos(int row, int col)
		{
		}

		// Token: 0x0600DFE5 RID: 57317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFE5")]
		[Address(RVA = "0x36647E0", Offset = "0x36633E0", VA = "0x1836647E0")]
		private void _UpdateAllSubArea()
		{
		}

		// Token: 0x0600DFE6 RID: 57318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFE6")]
		[Address(RVA = "0x3664B70", Offset = "0x3663770", VA = "0x183664B70")]
		private void _UpdateSubArea(Act35SideBattleManager.Area area)
		{
		}

		// Token: 0x0600DFE7 RID: 57319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFE7")]
		[Address(RVA = "0x3663B80", Offset = "0x3662780", VA = "0x183663B80")]
		private void _PrintAreaMap()
		{
		}

		// Token: 0x0600DFE8 RID: 57320 RVA: 0x000514F8 File Offset: 0x0004F6F8
		[Token(Token = "0x600DFE8")]
		[Address(RVA = "0x3662490", Offset = "0x3661090", VA = "0x183662490")]
		private static int _GenerateAreaId(int row, int col)
		{
			return 0;
		}

		// Token: 0x0600DFE9 RID: 57321 RVA: 0x00051510 File Offset: 0x0004F710
		[Token(Token = "0x600DFE9")]
		[Address(RVA = "0x3662520", Offset = "0x3661120", VA = "0x183662520")]
		private int _GenerateSubAreaId(int id)
		{
			return 0;
		}

		// Token: 0x0600DFEA RID: 57322 RVA: 0x00051528 File Offset: 0x0004F728
		[Token(Token = "0x600DFEA")]
		[Address(RVA = "0x3662180", Offset = "0x3660D80", VA = "0x183662180")]
		private bool _CheckIfSubAreaIsUninitialized(int row, int col)
		{
			return default(bool);
		}

		// Token: 0x0600DFEB RID: 57323 RVA: 0x00051540 File Offset: 0x0004F740
		[Token(Token = "0x600DFEB")]
		[Address(RVA = "0x36622D0", Offset = "0x3660ED0", VA = "0x1836622D0")]
		private bool _CheckIfTileIsSpecificGemsType(int row, int col, Act35SideBattleManager.GemsType type)
		{
			return default(bool);
		}

		// Token: 0x0600DFEC RID: 57324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFEC")]
		[Address(RVA = "0x36610B0", Offset = "0x365FCB0", VA = "0x1836610B0")]
		private void _AssignAreaIdsInPrimaryMap(int i, int j, int newId)
		{
		}

		// Token: 0x0600DFED RID: 57325 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFED")]
		[Address(RVA = "0x3661450", Offset = "0x3660050", VA = "0x183661450")]
		private void _AssignSubAreaIdsWithinArea(int i, int j, Act35SideBattleManager.Area area, int subId)
		{
		}

		// Token: 0x0600DFEE RID: 57326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFEE")]
		[Address(RVA = "0x3664EF0", Offset = "0x3663AF0", VA = "0x183664EF0")]
		public Act35SideBattleManager()
		{
		}

		// Token: 0x0600DFF0 RID: 57328 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600DFF0")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600DFF1 RID: 57329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFF1")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600DFF2 RID: 57330 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600DFF2")]
		[Address(RVA = "0x550C10", Offset = "0x54F810", VA = "0x180550C10")]
		private void <>xLuaBaseProxy_OnTrigger(object P0)
		{
		}

		// Token: 0x0400F346 RID: 62278
		[Token(Token = "0x400F346")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("Character Born")]
		[Tooltip("角色落地buff")]
		private List<BuffData> _charNotLocatedBuffs;

		// Token: 0x0400F347 RID: 62279
		[Token(Token = "0x400F347")]
		[FieldOffset(Offset = "0x30")]
		[Group("Character Born")]
		[Tooltip("角色已落地buff")]
		[SerializeField]
		private List<BuffData> _charLocatedBuffs;

		// Token: 0x0400F348 RID: 62280
		[Token(Token = "0x400F348")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Enemy")]
		[Tooltip("敌人常驻buff")]
		private List<BuffData> _enemyBuffs;

		// Token: 0x0400F349 RID: 62281
		[Token(Token = "0x400F349")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("连接宝石buff")]
		[SerializeField]
		[Group("Gems")]
		private List<BuffData> _linkBuffs;

		// Token: 0x0400F34A RID: 62282
		[Token(Token = "0x400F34A")]
		[FieldOffset(Offset = "0x48")]
		[Group("Effect")]
		[Tooltip("连接宝石特效")]
		[SerializeField]
		private BuffData _linkEffectKeyUp;

		// Token: 0x0400F34B RID: 62283
		[Token(Token = "0x400F34B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Effect")]
		[Tooltip("连接宝石特效")]
		private BuffData _linkEffectKeyDown;

		// Token: 0x0400F34C RID: 62284
		[Token(Token = "0x400F34C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Effect")]
		[Tooltip("连接宝石特效")]
		private BuffData _linkEffectKeyLeft;

		// Token: 0x0400F34D RID: 62285
		[Token(Token = "0x400F34D")]
		[FieldOffset(Offset = "0x60")]
		[Group("Effect")]
		[Tooltip("连接宝石特效")]
		[SerializeField]
		private BuffData _linkEffectKeyRight;

		// Token: 0x0400F34E RID: 62286
		[Token(Token = "0x400F34E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Effect")]
		[Tooltip("伤害传递特效")]
		private BuffData _transEffectKeyUp;

		// Token: 0x0400F34F RID: 62287
		[Token(Token = "0x400F34F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Effect")]
		[Tooltip("伤害传递特效")]
		private BuffData _transEffectKeyDown;

		// Token: 0x0400F350 RID: 62288
		[Token(Token = "0x400F350")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Effect")]
		[Tooltip("伤害传递特效")]
		private BuffData _transEffectKeyLeft;

		// Token: 0x0400F351 RID: 62289
		[Token(Token = "0x400F351")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Effect")]
		[Tooltip("伤害传递特效")]
		private BuffData _transEffectKeyRight;

		// Token: 0x0400F352 RID: 62290
		[Token(Token = "0x400F352")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Audio")]
		private string _gemsBornAudioKey;

		// Token: 0x0400F353 RID: 62291
		[Token(Token = "0x400F353")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Audio")]
		private int _gemsEliminatedAudioLimit;

		// Token: 0x0400F354 RID: 62292
		[Token(Token = "0x400F354")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Audio")]
		private string _gemsBigEliminatedAudioKey;

		// Token: 0x0400F355 RID: 62293
		[Token(Token = "0x400F355")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Audio")]
		private string _gemsEliminatedAudioKey;

		// Token: 0x0400F356 RID: 62294
		[Token(Token = "0x400F356")]
		[FieldOffset(Offset = "0xA8")]
		private int[,] m_areaIdMap;

		// Token: 0x0400F357 RID: 62295
		[Token(Token = "0x400F357")]
		[FieldOffset(Offset = "0xB0")]
		private int[,] m_gemsTypeMap;

		// Token: 0x0400F358 RID: 62296
		[Token(Token = "0x400F358")]
		[FieldOffset(Offset = "0xB8")]
		private int m_mapWidth;

		// Token: 0x0400F359 RID: 62297
		[Token(Token = "0x400F359")]
		[FieldOffset(Offset = "0xBC")]
		private int m_mapHeight;

		// Token: 0x0400F35A RID: 62298
		[Token(Token = "0x400F35A")]
		[FieldOffset(Offset = "0xC0")]
		private bool m_isGameStart;

		// Token: 0x0400F35B RID: 62299
		[Token(Token = "0x400F35B")]
		[FieldOffset(Offset = "0xC4")]
		private int m_eliminatedGemsCount;

		// Token: 0x0400F35C RID: 62300
		[Token(Token = "0x400F35C")]
		[FieldOffset(Offset = "0xC8")]
		private int m_linkedGemsCount;

		// Token: 0x0400F35D RID: 62301
		[Token(Token = "0x400F35D")]
		[FieldOffset(Offset = "0xD0")]
		private Act35SideBattleManager.Act35SideGemsTileBuildableChecker m_tileBuildableChecker;

		// Token: 0x0400F35E RID: 62302
		[Token(Token = "0x400F35E")]
		[FieldOffset(Offset = "0xD8")]
		private readonly Dictionary<int, Act35SideBattleManager.Area> m_areaIdToArea;

		// Token: 0x0400F35F RID: 62303
		[Token(Token = "0x400F35F")]
		[FieldOffset(Offset = "0xE0")]
		private readonly Dictionary<int, int> m_areaIdToSubAreaCount;

		// Token: 0x0400F360 RID: 62304
		[Token(Token = "0x400F360")]
		[FieldOffset(Offset = "0xE8")]
		private readonly Dictionary<GridPosition, Act35SideBattleManager.GemsEnemy> m_gemsPosToEnemy;

		// Token: 0x0400F361 RID: 62305
		[Token(Token = "0x400F361")]
		[FieldOffset(Offset = "0xF0")]
		private readonly List<Act35SideBattleManager.Area> m_invalidAreas;

		// Token: 0x0400F362 RID: 62306
		[Token(Token = "0x400F362")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<string> ExcludedTileKey;

		// Token: 0x0400F363 RID: 62307
		[Token(Token = "0x400F363")]
		public const string EVENT_SYSTEM_KEY = "env_017_act35side";

		// Token: 0x0400F364 RID: 62308
		[Token(Token = "0x400F364")]
		private const int AREA_ID_PARAM = 1000;

		// Token: 0x0400F365 RID: 62309
		[Token(Token = "0x400F365")]
		private const int INIT_AREA_FLAG = -1;

		// Token: 0x0400F366 RID: 62310
		[Token(Token = "0x400F366")]
		private const float WAIT_TIME = 9999999f;

		// Token: 0x0400F367 RID: 62311
		[Token(Token = "0x400F367")]
		private const string GEMS_TYPE_KEY = "gems_type";

		// Token: 0x0400F368 RID: 62312
		[Token(Token = "0x400F368")]
		private const string GEMS_ENEMY_ID = "enemy_10009_sggem";

		// Token: 0x0400F369 RID: 62313
		[Token(Token = "0x400F369")]
		private const string LINK_TRAP_ID = "trap_182_sglink";

		// Token: 0x0400F36A RID: 62314
		[Token(Token = "0x400F36A")]
		private const string EVENT_SWITCH_TO_CLEAR = "event_switch_to_clear";

		// Token: 0x0400F36B RID: 62315
		[Token(Token = "0x400F36B")]
		private const string EVENT_TAKE_DAMAGE_CLEAR = "event_take_damage_clear";

		// Token: 0x0400F36C RID: 62316
		[Token(Token = "0x400F36C")]
		private const int CONDUCTED_DAMAGE = 1;

		// Token: 0x0400F36D RID: 62317
		[Token(Token = "0x400F36D")]
		private const string LOG_ELIMINATE = "SIMPLE,,eliminate";

		// Token: 0x0400F36E RID: 62318
		[Token(Token = "0x400F36E")]
		private const string LOG_LINK = "SIMPLE,,link";

		// Token: 0x0400F36F RID: 62319
		[Token(Token = "0x400F36F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F370 RID: 62320
		[Token(Token = "0x400F370")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F371 RID: 62321
		[Token(Token = "0x400F371")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTrigger;

		// Token: 0x0400F372 RID: 62322
		[Token(Token = "0x400F372")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GatherAudio;

		// Token: 0x0400F373 RID: 62323
		[Token(Token = "0x400F373")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetGemsCount;

		// Token: 0x0400F374 RID: 62324
		[Token(Token = "0x400F374")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_CheckIfOnGemsTile;

		// Token: 0x0400F375 RID: 62325
		[Token(Token = "0x400F375")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckIfOnExcludedTile;

		// Token: 0x0400F376 RID: 62326
		[Token(Token = "0x400F376")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EliminateGemsByPositionAndDirection;

		// Token: 0x0400F377 RID: 62327
		[Token(Token = "0x400F377")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SummonGemsEnemyOnTileWithoutRefresh;

		// Token: 0x0400F378 RID: 62328
		[Token(Token = "0x400F378")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_SummonGemsEnemyOnTileAndRefresh;

		// Token: 0x0400F379 RID: 62329
		[Token(Token = "0x400F379")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_SummonGemsEnemyOnLine;

		// Token: 0x0400F37A RID: 62330
		[Token(Token = "0x400F37A")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_RefreshAndCheckMap;

		// Token: 0x0400F37B RID: 62331
		[Token(Token = "0x400F37B")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_RefreshAndCheckMapByPos;

		// Token: 0x0400F37C RID: 62332
		[Token(Token = "0x400F37C")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_UpdateMaxLinkedGemsCount;

		// Token: 0x0400F37D RID: 62333
		[Token(Token = "0x400F37D")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__OnGameStart;

		// Token: 0x0400F37E RID: 62334
		[Token(Token = "0x400F37E")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnGemsClear;

		// Token: 0x0400F37F RID: 62335
		[Token(Token = "0x400F37F")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnClearGemsTakeDamage;

		// Token: 0x0400F380 RID: 62336
		[Token(Token = "0x400F380")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400F381 RID: 62337
		[Token(Token = "0x400F381")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnEnemyBorn;

		// Token: 0x0400F382 RID: 62338
		[Token(Token = "0x400F382")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnCharacterBorn;

		// Token: 0x0400F383 RID: 62339
		[Token(Token = "0x400F383")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnGameOver;

		// Token: 0x0400F384 RID: 62340
		[Token(Token = "0x400F384")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CountAndRemoveGems;

		// Token: 0x0400F385 RID: 62341
		[Token(Token = "0x400F385")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__RemoveDeBuffsFromCharacter;

		// Token: 0x0400F386 RID: 62342
		[Token(Token = "0x400F386")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__AddLinkEffectBuff;

		// Token: 0x0400F387 RID: 62343
		[Token(Token = "0x400F387")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__AddTransEffectBuff;

		// Token: 0x0400F388 RID: 62344
		[Token(Token = "0x400F388")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__GetAreaId;

		// Token: 0x0400F389 RID: 62345
		[Token(Token = "0x400F389")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__RemoveInvalidAreasFromMap;

		// Token: 0x0400F38A RID: 62346
		[Token(Token = "0x400F38A")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__CheckAndEliminateGemsInMap;

		// Token: 0x0400F38B RID: 62347
		[Token(Token = "0x400F38B")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__CheckAndEliminateGemsByPos;

		// Token: 0x0400F38C RID: 62348
		[Token(Token = "0x400F38C")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__CheckAndEliminateGemsInArea;

		// Token: 0x0400F38D RID: 62349
		[Token(Token = "0x400F38D")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__CheckAndEliminateGemsInSubArea;

		// Token: 0x0400F38E RID: 62350
		[Token(Token = "0x400F38E")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__ResetAreaIdMap;

		// Token: 0x0400F38F RID: 62351
		[Token(Token = "0x400F38F")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__ResetAreaIdMapByArea;

		// Token: 0x0400F390 RID: 62352
		[Token(Token = "0x400F390")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__ResetAreaIdMapByPos;

		// Token: 0x0400F391 RID: 62353
		[Token(Token = "0x400F391")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__UpdateAreaMap;

		// Token: 0x0400F392 RID: 62354
		[Token(Token = "0x400F392")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0__UpdateAreaMapByPos;

		// Token: 0x0400F393 RID: 62355
		[Token(Token = "0x400F393")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0__UpdateAllSubArea;

		// Token: 0x0400F394 RID: 62356
		[Token(Token = "0x400F394")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0__UpdateSubArea;

		// Token: 0x0400F395 RID: 62357
		[Token(Token = "0x400F395")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0__PrintAreaMap;

		// Token: 0x0400F396 RID: 62358
		[Token(Token = "0x400F396")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0__GenerateAreaId;

		// Token: 0x0400F397 RID: 62359
		[Token(Token = "0x400F397")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge __Hotfix0__GenerateSubAreaId;

		// Token: 0x0400F398 RID: 62360
		[Token(Token = "0x400F398")]
		[FieldOffset(Offset = "0x150")]
		private static DelegateBridge __Hotfix0__CheckIfSubAreaIsUninitialized;

		// Token: 0x0400F399 RID: 62361
		[Token(Token = "0x400F399")]
		[FieldOffset(Offset = "0x158")]
		private static DelegateBridge __Hotfix0__CheckIfTileIsSpecificGemsType;

		// Token: 0x0400F39A RID: 62362
		[Token(Token = "0x400F39A")]
		[FieldOffset(Offset = "0x160")]
		private static DelegateBridge __Hotfix0__AssignAreaIdsInPrimaryMap;

		// Token: 0x0400F39B RID: 62363
		[Token(Token = "0x400F39B")]
		[FieldOffset(Offset = "0x168")]
		private static DelegateBridge __Hotfix0__AssignSubAreaIdsWithinArea;

		// Token: 0x0400F39C RID: 62364
		[Token(Token = "0x400F39C")]
		[FieldOffset(Offset = "0x170")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020022C2 RID: 8898
		[Token(Token = "0x20022C2")]
		public enum GemsType
		{
			// Token: 0x0400F39E RID: 62366
			[Token(Token = "0x400F39E")]
			Null,
			// Token: 0x0400F39F RID: 62367
			[Token(Token = "0x400F39F")]
			Clear,
			// Token: 0x0400F3A0 RID: 62368
			[Token(Token = "0x400F3A0")]
			Polluted
		}

		// Token: 0x020022C3 RID: 8899
		[Token(Token = "0x20022C3")]
		private class Area
		{
			// Token: 0x0600DFF3 RID: 57331 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DFF3")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Area()
			{
			}

			// Token: 0x0400F3A1 RID: 62369
			[Token(Token = "0x400F3A1")]
			[FieldOffset(Offset = "0x10")]
			public int areaId;

			// Token: 0x0400F3A2 RID: 62370
			[Token(Token = "0x400F3A2")]
			[FieldOffset(Offset = "0x18")]
			public HashSet<GridPosition> gemsPosList;

			// Token: 0x0400F3A3 RID: 62371
			[Token(Token = "0x400F3A3")]
			[FieldOffset(Offset = "0x20")]
			public Dictionary<int, Act35SideBattleManager.Area.SubClearArea> subClearAreaDir;

			// Token: 0x020022C4 RID: 8900
			[Token(Token = "0x20022C4")]
			internal class SubClearArea
			{
				// Token: 0x0600DFF4 RID: 57332 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600DFF4")]
				[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
				public SubClearArea()
				{
				}

				// Token: 0x0400F3A4 RID: 62372
				[Token(Token = "0x400F3A4")]
				[FieldOffset(Offset = "0x10")]
				public HashSet<GridPosition> clearGridPositionList;

				// Token: 0x0400F3A5 RID: 62373
				[Token(Token = "0x400F3A5")]
				[FieldOffset(Offset = "0x18")]
				public HashSet<GridPosition> nearGridPositionList;
			}
		}

		// Token: 0x020022C5 RID: 8901
		[Token(Token = "0x20022C5")]
		private class GemsEnemy
		{
			// Token: 0x0600DFF5 RID: 57333 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DFF5")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public GemsEnemy()
			{
			}

			// Token: 0x0400F3A6 RID: 62374
			[Token(Token = "0x400F3A6")]
			[FieldOffset(Offset = "0x10")]
			public Enemy enemy;

			// Token: 0x0400F3A7 RID: 62375
			[Token(Token = "0x400F3A7")]
			[FieldOffset(Offset = "0x18")]
			public bool isLink;
		}

		// Token: 0x020022C6 RID: 8902
		[Token(Token = "0x20022C6")]
		private class Act35SideGemsTileBuildableChecker : ITileBuildableChecker, IHotfixable
		{
			// Token: 0x0600DFF6 RID: 57334 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600DFF6")]
			[Address(RVA = "0x36655F0", Offset = "0x36641F0", VA = "0x1836655F0")]
			public Act35SideGemsTileBuildableChecker(Act35SideBattleManager manager)
			{
			}

			// Token: 0x0600DFF7 RID: 57335 RVA: 0x00051558 File Offset: 0x0004F758
			[Token(Token = "0x600DFF7")]
			[Address(RVA = "0x3665430", Offset = "0x3664030", VA = "0x183665430", Slot = "4")]
			public bool IsCharacterBuildableOnTile(Tile tile, BattleCharacterData sourceData)
			{
				return default(bool);
			}

			// Token: 0x0400F3A8 RID: 62376
			[Token(Token = "0x400F3A8")]
			[FieldOffset(Offset = "0x10")]
			private readonly Act35SideBattleManager m_manager;

			// Token: 0x0400F3A9 RID: 62377
			[Token(Token = "0x400F3A9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0400F3AA RID: 62378
			[Token(Token = "0x400F3AA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_IsCharacterBuildableOnTile;
		}
	}
}
