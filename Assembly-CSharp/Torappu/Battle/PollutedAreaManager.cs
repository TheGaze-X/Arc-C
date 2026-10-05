using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002341 RID: 9025
	[Token(Token = "0x2002341")]
	public class PollutedAreaManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C96 RID: 7318
		// (get) Token: 0x0600E436 RID: 58422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C96")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E436")]
			[Address(RVA = "0x5942A0", Offset = "0x592EA0", VA = "0x1805942A0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E437 RID: 58423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E437")]
		[Address(RVA = "0x5905D0", Offset = "0x58F1D0", VA = "0x1805905D0", Slot = "8")]
		public override void OnPostInit()
		{
		}

		// Token: 0x0600E438 RID: 58424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E438")]
		[Address(RVA = "0x5906E0", Offset = "0x58F2E0", VA = "0x1805906E0", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E439 RID: 58425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E439")]
		[Address(RVA = "0x590830", Offset = "0x58F430", VA = "0x180590830")]
		public void RebuildCurAreaWithTile(Tile curTile)
		{
		}

		// Token: 0x0600E43A RID: 58426 RVA: 0x00052968 File Offset: 0x00050B68
		[Token(Token = "0x600E43A")]
		[Address(RVA = "0x58FAB0", Offset = "0x58E6B0", VA = "0x18058FAB0")]
		public bool CheckTileIsWaterField(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600E43B RID: 58427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E43B")]
		[Address(RVA = "0x590910", Offset = "0x58F510", VA = "0x180590910")]
		public void RemoveTilesInSameArea(List<Tile> tiles)
		{
		}

		// Token: 0x0600E43C RID: 58428 RVA: 0x00052980 File Offset: 0x00050B80
		[Token(Token = "0x600E43C")]
		[Address(RVA = "0x58F9A0", Offset = "0x58E5A0", VA = "0x18058F9A0")]
		public bool CheckTileIsInPolluteArea(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600E43D RID: 58429 RVA: 0x00052998 File Offset: 0x00050B98
		[Token(Token = "0x600E43D")]
		[Address(RVA = "0x5904C0", Offset = "0x58F0C0", VA = "0x1805904C0")]
		public int GetTilePolluteValue(Tile tile)
		{
			return 0;
		}

		// Token: 0x0600E43E RID: 58430 RVA: 0x000529B0 File Offset: 0x00050BB0
		[Token(Token = "0x600E43E")]
		[Address(RVA = "0x5903A0", Offset = "0x58EFA0", VA = "0x1805903A0")]
		public float GetTilePolluteValueRatio(Tile tile)
		{
			return 0f;
		}

		// Token: 0x0600E43F RID: 58431 RVA: 0x000529C8 File Offset: 0x00050BC8
		[Token(Token = "0x600E43F")]
		[Address(RVA = "0x590170", Offset = "0x58ED70", VA = "0x180590170")]
		public int GetAreaPolluteValueByTile(Tile tile)
		{
			return 0;
		}

		// Token: 0x0600E440 RID: 58432 RVA: 0x000529E0 File Offset: 0x00050BE0
		[Token(Token = "0x600E440")]
		[Address(RVA = "0x590040", Offset = "0x58EC40", VA = "0x180590040")]
		public float GetAreaPolluteVRatioByTile(Tile tile)
		{
			return 0f;
		}

		// Token: 0x0600E441 RID: 58433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E441")]
		[Address(RVA = "0x58F680", Offset = "0x58E280", VA = "0x18058F680")]
		public void AddAreaPolluteValue(Tile tile, int pv)
		{
		}

		// Token: 0x0600E442 RID: 58434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E442")]
		[Address(RVA = "0x58F7A0", Offset = "0x58E3A0", VA = "0x18058F7A0")]
		public void AddTileExtraTgtPollute(Tile tile, int extraPv)
		{
		}

		// Token: 0x0600E443 RID: 58435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E443")]
		[Address(RVA = "0x58FBB0", Offset = "0x58E7B0", VA = "0x18058FBB0")]
		public void FlushArea(List<Tile> tiles, int tgtPv)
		{
		}

		// Token: 0x0600E444 RID: 58436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E444")]
		[Address(RVA = "0x590280", Offset = "0x58EE80", VA = "0x180590280")]
		public PollutedAreaManager.PolluteTileData GetTilePolluteData(Tile tile)
		{
			return null;
		}

		// Token: 0x0600E445 RID: 58437 RVA: 0x000529F8 File Offset: 0x00050BF8
		[Token(Token = "0x600E445")]
		[Address(RVA = "0x58FF80", Offset = "0x58EB80", VA = "0x18058FF80")]
		public int GetAreaIndex(PollutedAreaManager.PolluteAreaData curArea)
		{
			return 0;
		}

		// Token: 0x0600E446 RID: 58438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E446")]
		[Address(RVA = "0x592380", Offset = "0x590F80", VA = "0x180592380")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x0600E447 RID: 58439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E447")]
		[Address(RVA = "0x592210", Offset = "0x590E10", VA = "0x180592210")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600E448 RID: 58440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E448")]
		[Address(RVA = "0x591FB0", Offset = "0x590BB0", VA = "0x180591FB0")]
		private void _OnGameOverLog(object arg)
		{
		}

		// Token: 0x0600E449 RID: 58441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E449")]
		[Address(RVA = "0x590AF0", Offset = "0x58F6F0", VA = "0x180590AF0")]
		private PollutedAreaManager.PolluteAreaData _CreatePolluteAreaData(List<Tile> tiles)
		{
			return null;
		}

		// Token: 0x0600E44A RID: 58442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E44A")]
		[Address(RVA = "0x592B10", Offset = "0x591710", VA = "0x180592B10")]
		private void _RebuildAreas()
		{
		}

		// Token: 0x0600E44B RID: 58443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E44B")]
		[Address(RVA = "0x592620", Offset = "0x591220", VA = "0x180592620")]
		private void _RebuildAreasWithRebuildTiles()
		{
		}

		// Token: 0x0600E44C RID: 58444 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E44C")]
		[Address(RVA = "0x593180", Offset = "0x591D80", VA = "0x180593180")]
		private void _UpdateAreaTgtPolluteValue()
		{
		}

		// Token: 0x0600E44D RID: 58445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E44D")]
		[Address(RVA = "0x593940", Offset = "0x592540", VA = "0x180593940")]
		private void _UpdateTilePolluteValueToTgt()
		{
		}

		// Token: 0x0600E44E RID: 58446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E44E")]
		[Address(RVA = "0x591560", Offset = "0x590160", VA = "0x180591560")]
		private void _HandleFlushData()
		{
		}

		// Token: 0x0600E44F RID: 58447 RVA: 0x00052A10 File Offset: 0x00050C10
		[Token(Token = "0x600E44F")]
		[Address(RVA = "0x5913E0", Offset = "0x58FFE0", VA = "0x1805913E0")]
		private int _GetUpdatePollute(int curP, int tgtP)
		{
			return 0;
		}

		// Token: 0x0600E450 RID: 58448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E450")]
		[Address(RVA = "0x591AB0", Offset = "0x5906B0", VA = "0x180591AB0")]
		private void _InitTileAndPolluteValue()
		{
		}

		// Token: 0x0600E451 RID: 58449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E451")]
		[Address(RVA = "0x5934D0", Offset = "0x5920D0", VA = "0x1805934D0")]
		private void _UpdateAreasPolluteValue(bool isInit = false)
		{
		}

		// Token: 0x0600E452 RID: 58450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E452")]
		[Address(RVA = "0x590D50", Offset = "0x58F950", VA = "0x180590D50")]
		private void _FindAreasRelatedToTile(Tile curTile)
		{
		}

		// Token: 0x0600E453 RID: 58451 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E453")]
		[Address(RVA = "0x58F8C0", Offset = "0x58E4C0", VA = "0x18058F8C0")]
		private void Awake()
		{
		}

		// Token: 0x0600E454 RID: 58452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E454")]
		[Address(RVA = "0x593DE0", Offset = "0x5929E0", VA = "0x180593DE0")]
		public PollutedAreaManager()
		{
		}

		// Token: 0x0600E456 RID: 58454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E456")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E457 RID: 58455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E457")]
		[Address(RVA = "0x590AE0", Offset = "0x58F6E0", VA = "0x180590AE0")]
		private void <>xLuaBaseProxy_OnPostInit()
		{
		}

		// Token: 0x0600E458 RID: 58456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E458")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400FB5C RID: 64348
		[Token(Token = "0x400FB5C")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string EVENT_SYSTEM_KEY;

		// Token: 0x0400FB5D RID: 64349
		[Token(Token = "0x400FB5D")]
		[FieldOffset(Offset = "0x8")]
		private static readonly string[] EXCLUDED_TILE_KEY;

		// Token: 0x0400FB5E RID: 64350
		[Token(Token = "0x400FB5E")]
		[FieldOffset(Offset = "0x10")]
		private static readonly string OBJ_KEYWORD;

		// Token: 0x0400FB5F RID: 64351
		[Token(Token = "0x400FB5F")]
		[FieldOffset(Offset = "0x18")]
		private static readonly string LOG_CLEAN_AREA_CNT;

		// Token: 0x0400FB60 RID: 64352
		[Token(Token = "0x400FB60")]
		[FieldOffset(Offset = "0x20")]
		private static readonly int NEARBY_TILE_CNT;

		// Token: 0x0400FB61 RID: 64353
		[Token(Token = "0x400FB61")]
		[FieldOffset(Offset = "0x28")]
		private static MaterialPropertyBlock m_reusedPropertyBlock;

		// Token: 0x0400FB62 RID: 64354
		[Token(Token = "0x400FB62")]
		private const int MAX_POLLUTE_V = 100;

		// Token: 0x0400FB63 RID: 64355
		[Token(Token = "0x400FB63")]
		private const int MIN_POLLUTE_V = 0;

		// Token: 0x0400FB64 RID: 64356
		[Token(Token = "0x400FB64")]
		private const int FLUSH_VELOCITY = 1;

		// Token: 0x0400FB65 RID: 64357
		[Token(Token = "0x400FB65")]
		private const int EXTRA_TGT_CHANGE_VELOCITY = 1;

		// Token: 0x0400FB66 RID: 64358
		[Token(Token = "0x400FB66")]
		[FieldOffset(Offset = "0x28")]
		private readonly FP TIMER_INTERVAL;

		// Token: 0x0400FB67 RID: 64359
		[Token(Token = "0x400FB67")]
		private const int POLLUTE_LATE_TIMES = 5;

		// Token: 0x0400FB68 RID: 64360
		[Token(Token = "0x400FB68")]
		private const int POLLUTE_V_STEP = 25;

		// Token: 0x0400FB69 RID: 64361
		[Token(Token = "0x400FB69")]
		[FieldOffset(Offset = "0x30")]
		private readonly int[] m_pollutVelocity;

		// Token: 0x0400FB6A RID: 64362
		[Token(Token = "0x400FB6A")]
		private const string TAG_TRAP_DHTL = "trap_dhtl";

		// Token: 0x0400FB6B RID: 64363
		[Token(Token = "0x400FB6B")]
		private const string INIT_POLLUTE_VALUE = "init_pollut_value";

		// Token: 0x0400FB6C RID: 64364
		[Token(Token = "0x400FB6C")]
		[FieldOffset(Offset = "0x38")]
		private readonly char[] INIT_POLLUTE_SEPARATOR;

		// Token: 0x0400FB6D RID: 64365
		[Token(Token = "0x400FB6D")]
		[FieldOffset(Offset = "0x40")]
		private readonly ListDict<Tile, PollutedAreaManager.PolluteTileData> m_polluteTiles;

		// Token: 0x0400FB6E RID: 64366
		[Token(Token = "0x400FB6E")]
		[FieldOffset(Offset = "0x48")]
		private readonly List<PollutedAreaManager.PolluteAreaData> m_areaDatas;

		// Token: 0x0400FB6F RID: 64367
		[Token(Token = "0x400FB6F")]
		[FieldOffset(Offset = "0x50")]
		private readonly List<Tile> m_rebuildTiles;

		// Token: 0x0400FB70 RID: 64368
		[Token(Token = "0x400FB70")]
		[FieldOffset(Offset = "0x58")]
		private readonly Queue<PollutedAreaManager.PolluteAreaData> m_areaDataReusePool;

		// Token: 0x0400FB71 RID: 64369
		[Token(Token = "0x400FB71")]
		[FieldOffset(Offset = "0x60")]
		private PeriodicTimer m_timer;

		// Token: 0x0400FB72 RID: 64370
		[Token(Token = "0x400FB72")]
		[FieldOffset(Offset = "0x68")]
		private PollutedAreaManager.PillarCtrl m_pillarCtrl;

		// Token: 0x0400FB73 RID: 64371
		[Token(Token = "0x400FB73")]
		[FieldOffset(Offset = "0x70")]
		private int m_lateTimes;

		// Token: 0x0400FB74 RID: 64372
		[Token(Token = "0x400FB74")]
		[FieldOffset(Offset = "0x78")]
		private List<Tile> m_visited;

		// Token: 0x0400FB75 RID: 64373
		[Token(Token = "0x400FB75")]
		[FieldOffset(Offset = "0x80")]
		private List<Tile> m_curTiles;

		// Token: 0x0400FB76 RID: 64374
		[Token(Token = "0x400FB76")]
		[FieldOffset(Offset = "0x88")]
		private Queue<Tile> m_queue;

		// Token: 0x0400FB77 RID: 64375
		[Token(Token = "0x400FB77")]
		[FieldOffset(Offset = "0x90")]
		private readonly Vector2Int[] m_dirs;

		// Token: 0x0400FB78 RID: 64376
		[Token(Token = "0x400FB78")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400FB79 RID: 64377
		[Token(Token = "0x400FB79")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnPostInit;

		// Token: 0x0400FB7A RID: 64378
		[Token(Token = "0x400FB7A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400FB7B RID: 64379
		[Token(Token = "0x400FB7B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_RebuildCurAreaWithTile;

		// Token: 0x0400FB7C RID: 64380
		[Token(Token = "0x400FB7C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_CheckTileIsWaterField;

		// Token: 0x0400FB7D RID: 64381
		[Token(Token = "0x400FB7D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_RemoveTilesInSameArea;

		// Token: 0x0400FB7E RID: 64382
		[Token(Token = "0x400FB7E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_CheckTileIsInPolluteArea;

		// Token: 0x0400FB7F RID: 64383
		[Token(Token = "0x400FB7F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetTilePolluteValue;

		// Token: 0x0400FB80 RID: 64384
		[Token(Token = "0x400FB80")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_GetTilePolluteValueRatio;

		// Token: 0x0400FB81 RID: 64385
		[Token(Token = "0x400FB81")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_GetAreaPolluteValueByTile;

		// Token: 0x0400FB82 RID: 64386
		[Token(Token = "0x400FB82")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetAreaPolluteVRatioByTile;

		// Token: 0x0400FB83 RID: 64387
		[Token(Token = "0x400FB83")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_AddAreaPolluteValue;

		// Token: 0x0400FB84 RID: 64388
		[Token(Token = "0x400FB84")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_AddTileExtraTgtPollute;

		// Token: 0x0400FB85 RID: 64389
		[Token(Token = "0x400FB85")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_FlushArea;

		// Token: 0x0400FB86 RID: 64390
		[Token(Token = "0x400FB86")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetTilePolluteData;

		// Token: 0x0400FB87 RID: 64391
		[Token(Token = "0x400FB87")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetAreaIndex;

		// Token: 0x0400FB88 RID: 64392
		[Token(Token = "0x400FB88")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x0400FB89 RID: 64393
		[Token(Token = "0x400FB89")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400FB8A RID: 64394
		[Token(Token = "0x400FB8A")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnGameOverLog;

		// Token: 0x0400FB8B RID: 64395
		[Token(Token = "0x400FB8B")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__CreatePolluteAreaData;

		// Token: 0x0400FB8C RID: 64396
		[Token(Token = "0x400FB8C")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__RebuildAreas;

		// Token: 0x0400FB8D RID: 64397
		[Token(Token = "0x400FB8D")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__RebuildAreasWithRebuildTiles;

		// Token: 0x0400FB8E RID: 64398
		[Token(Token = "0x400FB8E")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__UpdateAreaTgtPolluteValue;

		// Token: 0x0400FB8F RID: 64399
		[Token(Token = "0x400FB8F")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__UpdateTilePolluteValueToTgt;

		// Token: 0x0400FB90 RID: 64400
		[Token(Token = "0x400FB90")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__HandleFlushData;

		// Token: 0x0400FB91 RID: 64401
		[Token(Token = "0x400FB91")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__GetUpdatePollute;

		// Token: 0x0400FB92 RID: 64402
		[Token(Token = "0x400FB92")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__InitTileAndPolluteValue;

		// Token: 0x0400FB93 RID: 64403
		[Token(Token = "0x400FB93")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__UpdateAreasPolluteValue;

		// Token: 0x0400FB94 RID: 64404
		[Token(Token = "0x400FB94")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0__FindAreasRelatedToTile;

		// Token: 0x0400FB95 RID: 64405
		[Token(Token = "0x400FB95")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400FB96 RID: 64406
		[Token(Token = "0x400FB96")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002342 RID: 9026
		[Token(Token = "0x2002342")]
		public class PolluteTileData
		{
			// Token: 0x17001C97 RID: 7319
			// (get) Token: 0x0600E45A RID: 58458 RVA: 0x00052A28 File Offset: 0x00050C28
			// (set) Token: 0x0600E459 RID: 58457 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001C97")]
			public int curPollute
			{
				[Token(Token = "0x600E45A")]
				[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
				get
				{
					return 0;
				}
				[Token(Token = "0x600E459")]
				[Address(RVA = "0x5A4AE0", Offset = "0x5A36E0", VA = "0x1805A4AE0")]
				set
				{
				}
			}

			// Token: 0x17001C98 RID: 7320
			// (get) Token: 0x0600E45B RID: 58459 RVA: 0x00052A40 File Offset: 0x00050C40
			[Token(Token = "0x17001C98")]
			public int areaTgtPollute
			{
				[Token(Token = "0x600E45B")]
				[Address(RVA = "0x5A4AC0", Offset = "0x5A36C0", VA = "0x1805A4AC0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x0600E45C RID: 58460 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600E45C")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			public PollutedAreaManager.PolluteAreaData GetArea()
			{
				return null;
			}

			// Token: 0x0600E45D RID: 58461 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E45D")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
			public void SetArea(PollutedAreaManager.PolluteAreaData area)
			{
			}

			// Token: 0x0600E45E RID: 58462 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E45E")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			public void SetInitPollute(int pv)
			{
			}

			// Token: 0x0600E45F RID: 58463 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E45F")]
			[Address(RVA = "0x5A4A90", Offset = "0x5A3690", VA = "0x1805A4A90")]
			public void VerifyCurPollute()
			{
			}

			// Token: 0x0600E460 RID: 58464 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E460")]
			[Address(RVA = "0x5A49E0", Offset = "0x5A35E0", VA = "0x1805A49E0")]
			public void AddAreaPolluteValue(int pv)
			{
			}

			// Token: 0x0600E461 RID: 58465 RVA: 0x00052A58 File Offset: 0x00050C58
			[Token(Token = "0x600E461")]
			[Address(RVA = "0x5A4A20", Offset = "0x5A3620", VA = "0x1805A4A20")]
			public static bool CheckSameArea(PollutedAreaManager.PolluteTileData tile1, PollutedAreaManager.PolluteTileData tile2)
			{
				return default(bool);
			}

			// Token: 0x0600E462 RID: 58466 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E462")]
			[Address(RVA = "0x5A4A50", Offset = "0x5A3650", VA = "0x1805A4A50")]
			public void Reset()
			{
			}

			// Token: 0x0600E463 RID: 58467 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E463")]
			[Address(RVA = "0x5A4AB0", Offset = "0x5A36B0", VA = "0x1805A4AB0")]
			public PolluteTileData()
			{
			}

			// Token: 0x0400FB97 RID: 64407
			[Token(Token = "0x400FB97")]
			[FieldOffset(Offset = "0x10")]
			private PollutedAreaManager.PolluteAreaData m_area;

			// Token: 0x0400FB98 RID: 64408
			[Token(Token = "0x400FB98")]
			[FieldOffset(Offset = "0x18")]
			private int m_curPollute;

			// Token: 0x0400FB99 RID: 64409
			[Token(Token = "0x400FB99")]
			[FieldOffset(Offset = "0x1C")]
			public int curFlushV;

			// Token: 0x0400FB9A RID: 64410
			[Token(Token = "0x400FB9A")]
			[FieldOffset(Offset = "0x20")]
			public int extraTgtPollute;
		}

		// Token: 0x02002343 RID: 9027
		[Token(Token = "0x2002343")]
		public class PolluteAreaData
		{
			// Token: 0x17001C99 RID: 7321
			// (get) Token: 0x0600E465 RID: 58469 RVA: 0x00052A70 File Offset: 0x00050C70
			// (set) Token: 0x0600E464 RID: 58468 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17001C99")]
			public int tgtPollute
			{
				[Token(Token = "0x600E465")]
				[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
				get
				{
					return 0;
				}
				[Token(Token = "0x600E464")]
				[Address(RVA = "0x5A49C0", Offset = "0x5A35C0", VA = "0x1805A49C0")]
				set
				{
				}
			}

			// Token: 0x0600E466 RID: 58470 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E466")]
			[Address(RVA = "0x5A48C0", Offset = "0x5A34C0", VA = "0x1805A48C0")]
			public void Reset()
			{
			}

			// Token: 0x0600E467 RID: 58471 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E467")]
			[Address(RVA = "0x5A4930", Offset = "0x5A3530", VA = "0x1805A4930")]
			public PolluteAreaData()
			{
			}

			// Token: 0x0400FB9B RID: 64411
			[Token(Token = "0x400FB9B")]
			[FieldOffset(Offset = "0x10")]
			public List<Tile> tiles;

			// Token: 0x0400FB9C RID: 64412
			[Token(Token = "0x400FB9C")]
			[FieldOffset(Offset = "0x18")]
			private int m_tgtPollute;
		}

		// Token: 0x02002344 RID: 9028
		[Token(Token = "0x2002344")]
		private class PillarCtrl
		{
			// Token: 0x0600E468 RID: 58472 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E468")]
			[Address(RVA = "0x5A4030", Offset = "0x5A2C30", VA = "0x1805A4030")]
			public void OnTick()
			{
			}

			// Token: 0x0600E469 RID: 58473 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E469")]
			[Address(RVA = "0x5A38E0", Offset = "0x5A24E0", VA = "0x1805A38E0")]
			public void InitPillarData(PollutedAreaManager manager)
			{
			}

			// Token: 0x0600E46A RID: 58474 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E46A")]
			[Address(RVA = "0x5A4040", Offset = "0x5A2C40", VA = "0x1805A4040")]
			private void _GetNearbyTileData(List<PollutedAreaManager.PolluteTileData> dataList, GridPosition curGrid)
			{
			}

			// Token: 0x0600E46B RID: 58475 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E46B")]
			[Address(RVA = "0x5A41C0", Offset = "0x5A2DC0", VA = "0x1805A41C0")]
			private void _UpdatePillarGraphic()
			{
			}

			// Token: 0x0600E46C RID: 58476 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600E46C")]
			[Address(RVA = "0x5A4480", Offset = "0x5A3080", VA = "0x1805A4480")]
			public PillarCtrl()
			{
			}

			// Token: 0x0400FB9D RID: 64413
			[Token(Token = "0x400FB9D")]
			[FieldOffset(Offset = "0x0")]
			private static readonly int EMISSION_COLOR;

			// Token: 0x0400FB9E RID: 64414
			[Token(Token = "0x400FB9E")]
			[FieldOffset(Offset = "0x10")]
			private PollutedAreaManager m_manager;

			// Token: 0x0400FB9F RID: 64415
			[Token(Token = "0x400FB9F")]
			[FieldOffset(Offset = "0x18")]
			private ListDict<PollutedAreaManager.PillarCtrl.PillarData, List<PollutedAreaManager.PolluteTileData>> m_pillarDatas;

			// Token: 0x0400FBA0 RID: 64416
			[Token(Token = "0x400FBA0")]
			[FieldOffset(Offset = "0x20")]
			private readonly Vector2Int[] m_tileDirs;

			// Token: 0x02002345 RID: 9029
			[Token(Token = "0x2002345")]
			private class PillarData
			{
				// Token: 0x0600E46E RID: 58478 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600E46E")]
				[Address(RVA = "0x5A4830", Offset = "0x5A3430", VA = "0x1805A4830")]
				public PillarData(GameObject obj)
				{
				}

				// Token: 0x0600E46F RID: 58479 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x600E46F")]
				[Address(RVA = "0x5A4630", Offset = "0x5A3230", VA = "0x1805A4630")]
				public void UpdateGraphic()
				{
				}

				// Token: 0x0400FBA1 RID: 64417
				[Token(Token = "0x400FBA1")]
				[FieldOffset(Offset = "0x10")]
				public int maxPV;

				// Token: 0x0400FBA2 RID: 64418
				[Token(Token = "0x400FBA2")]
				[FieldOffset(Offset = "0x18")]
				private GameObject m_pillar;

				// Token: 0x0400FBA3 RID: 64419
				[Token(Token = "0x400FBA3")]
				[FieldOffset(Offset = "0x20")]
				private MeshRenderer m_meshRenderer;
			}
		}
	}
}
