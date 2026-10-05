using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.AutoChess
{
	// Token: 0x0200276C RID: 10092
	[Token(Token = "0x200276C")]
	public class AutoChessMapAreaManager : IHotfixable
	{
		// Token: 0x170023ED RID: 9197
		// (get) Token: 0x06010744 RID: 67396 RVA: 0x00064350 File Offset: 0x00062550
		[Token(Token = "0x170023ED")]
		public int mapLRBoundaryCol
		{
			[Token(Token = "0x6010744")]
			[Address(RVA = "0x835DC0", Offset = "0x8349C0", VA = "0x180835DC0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06010745 RID: 67397 RVA: 0x00064368 File Offset: 0x00062568
		[Token(Token = "0x6010745")]
		[Address(RVA = "0x8330D0", Offset = "0x831CD0", VA = "0x1808330D0")]
		public bool IsLeftNormalMap(GridPosition gridPosition)
		{
			return default(bool);
		}

		// Token: 0x06010746 RID: 67398 RVA: 0x00064380 File Offset: 0x00062580
		[Token(Token = "0x6010746")]
		[Address(RVA = "0x8333F0", Offset = "0x831FF0", VA = "0x1808333F0")]
		public bool IsRightNormalMap(GridPosition gridPosition)
		{
			return default(bool);
		}

		// Token: 0x06010747 RID: 67399 RVA: 0x00064398 File Offset: 0x00062598
		[Token(Token = "0x6010747")]
		[Address(RVA = "0x832F40", Offset = "0x831B40", VA = "0x180832F40")]
		public bool IsLeftBossMap(GridPosition gridPosition)
		{
			return default(bool);
		}

		// Token: 0x06010748 RID: 67400 RVA: 0x000643B0 File Offset: 0x000625B0
		[Token(Token = "0x6010748")]
		[Address(RVA = "0x833260", Offset = "0x831E60", VA = "0x180833260")]
		public bool IsRightBossMap(GridPosition gridPosition)
		{
			return default(bool);
		}

		// Token: 0x06010749 RID: 67401 RVA: 0x000643C8 File Offset: 0x000625C8
		[Token(Token = "0x6010749")]
		[Address(RVA = "0x833030", Offset = "0x831C30", VA = "0x180833030")]
		public bool IsLeftMap(GridPosition gridPosition)
		{
			return default(bool);
		}

		// Token: 0x0601074A RID: 67402 RVA: 0x000643E0 File Offset: 0x000625E0
		[Token(Token = "0x601074A")]
		[Address(RVA = "0x833350", Offset = "0x831F50", VA = "0x180833350")]
		public bool IsRightMap(GridPosition gridPosition)
		{
			return default(bool);
		}

		// Token: 0x0601074B RID: 67403 RVA: 0x000643F8 File Offset: 0x000625F8
		[Token(Token = "0x601074B")]
		[Address(RVA = "0x8331C0", Offset = "0x831DC0", VA = "0x1808331C0")]
		public bool IsNormalMap(GridPosition gridPosition)
		{
			return default(bool);
		}

		// Token: 0x0601074C RID: 67404 RVA: 0x00064410 File Offset: 0x00062610
		[Token(Token = "0x601074C")]
		[Address(RVA = "0x832EA0", Offset = "0x831AA0", VA = "0x180832EA0")]
		public bool IsBossMap(GridPosition gridPosition)
		{
			return default(bool);
		}

		// Token: 0x0601074D RID: 67405 RVA: 0x00064428 File Offset: 0x00062628
		[Token(Token = "0x601074D")]
		[Address(RVA = "0x832D50", Offset = "0x831950", VA = "0x180832D50")]
		public GridPosition GetDefaultChessInstPosition(ChessInst chessInst)
		{
			return default(GridPosition);
		}

		// Token: 0x0601074E RID: 67406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601074E")]
		[Address(RVA = "0x8329F0", Offset = "0x8315F0", VA = "0x1808329F0")]
		public void ConvertChessPositionInfoToDefault(ChessPositionInfo positionInfo)
		{
		}

		// Token: 0x0601074F RID: 67407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601074F")]
		[Address(RVA = "0x8328D0", Offset = "0x8314D0", VA = "0x1808328D0")]
		public void ConvertChessPositionInfoToBossMap(ChessPositionInfo positionInfo)
		{
		}

		// Token: 0x06010750 RID: 67408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010750")]
		[Address(RVA = "0x832BC0", Offset = "0x8317C0", VA = "0x180832BC0")]
		public void ConvertChessPositionInfoToRightMap(ChessPositionInfo positionInfo)
		{
		}

		// Token: 0x06010751 RID: 67409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010751")]
		[Address(RVA = "0x833790", Offset = "0x832390", VA = "0x180833790")]
		public void Start()
		{
		}

		// Token: 0x06010752 RID: 67410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6010752")]
		[Address(RVA = "0x832CF0", Offset = "0x8318F0", VA = "0x180832CF0")]
		public HashSet<GridPosition> FetchBattleValidMapGrids()
		{
			return null;
		}

		// Token: 0x06010753 RID: 67411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010753")]
		[Address(RVA = "0x833870", Offset = "0x832470", VA = "0x180833870")]
		public void UpdateMapState(AutoChessGameStateType state)
		{
		}

		// Token: 0x06010754 RID: 67412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010754")]
		[Address(RVA = "0x8334E0", Offset = "0x8320E0", VA = "0x1808334E0")]
		public void ResetTileIndexer(AutoChessGameStateType state)
		{
		}

		// Token: 0x06010755 RID: 67413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010755")]
		[Address(RVA = "0x833AF0", Offset = "0x8326F0", VA = "0x180833AF0")]
		public void UpdateTileIndexerFromOb()
		{
		}

		// Token: 0x06010756 RID: 67414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010756")]
		[Address(RVA = "0x835840", Offset = "0x834440", VA = "0x180835840")]
		private void _SwitchToSelfBattleMap()
		{
		}

		// Token: 0x06010757 RID: 67415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010757")]
		[Address(RVA = "0x8356A0", Offset = "0x8342A0", VA = "0x1808356A0")]
		private void _SwitchToHelpBattleMap()
		{
		}

		// Token: 0x06010758 RID: 67416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010758")]
		[Address(RVA = "0x835530", Offset = "0x834130", VA = "0x180835530")]
		private void _SwitchToBossBattleMap()
		{
		}

		// Token: 0x06010759 RID: 67417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010759")]
		[Address(RVA = "0x8359B0", Offset = "0x8345B0", VA = "0x1808359B0")]
		private void _UpdateMapGraphic(string graphicKey, bool isHide)
		{
		}

		// Token: 0x0601075A RID: 67418 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601075A")]
		[Address(RVA = "0x833B90", Offset = "0x832790", VA = "0x180833B90")]
		private void _EnableArea(string areaKey, bool isEnable)
		{
		}

		// Token: 0x0601075B RID: 67419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601075B")]
		[Address(RVA = "0x833E10", Offset = "0x832A10", VA = "0x180833E10")]
		private void _EnableTile(Tile tile, bool enable)
		{
		}

		// Token: 0x0601075C RID: 67420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601075C")]
		[Address(RVA = "0x834640", Offset = "0x833240", VA = "0x180834640")]
		private void _InitContainer()
		{
		}

		// Token: 0x0601075D RID: 67421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601075D")]
		[Address(RVA = "0x834710", Offset = "0x833310", VA = "0x180834710")]
		private void _Init()
		{
		}

		// Token: 0x0601075E RID: 67422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601075E")]
		[Address(RVA = "0x8349A0", Offset = "0x8335A0", VA = "0x1808349A0")]
		private void _ParseRect(string areaKey, Blackboard blackboard)
		{
		}

		// Token: 0x0601075F RID: 67423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601075F")]
		[Address(RVA = "0x833EF0", Offset = "0x832AF0", VA = "0x180833EF0")]
		private void _HideEntity(Entity entity)
		{
		}

		// Token: 0x06010760 RID: 67424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010760")]
		[Address(RVA = "0x834D70", Offset = "0x833970", VA = "0x180834D70")]
		private void _ShowEntity(Entity entity)
		{
		}

		// Token: 0x06010761 RID: 67425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010761")]
		[Address(RVA = "0x833FB0", Offset = "0x832BB0", VA = "0x180833FB0")]
		private void _HideTile(Tile tile)
		{
		}

		// Token: 0x06010762 RID: 67426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010762")]
		[Address(RVA = "0x834F80", Offset = "0x833B80", VA = "0x180834F80")]
		private void _ShowTile(Tile tile)
		{
		}

		// Token: 0x06010763 RID: 67427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010763")]
		[Address(RVA = "0x835B30", Offset = "0x834730", VA = "0x180835B30")]
		public AutoChessMapAreaManager()
		{
		}

		// Token: 0x040126E3 RID: 75491
		[Token(Token = "0x40126E3")]
		[FieldOffset(Offset = "0x10")]
		public AutoChessMapAreaManager.TileIndexer tileIndexer;

		// Token: 0x040126E4 RID: 75492
		[Token(Token = "0x40126E4")]
		[FieldOffset(Offset = "0x18")]
		private ListDict<string, HashSet<GridPosition>> m_hiddenAreaDict;

		// Token: 0x040126E5 RID: 75493
		[Token(Token = "0x40126E5")]
		[FieldOffset(Offset = "0x20")]
		private List<ObjectPtr<Entity>> m_entitiesOnTile;

		// Token: 0x040126E6 RID: 75494
		[Token(Token = "0x40126E6")]
		[FieldOffset(Offset = "0x28")]
		private HashSet<GridPosition> m_mapBattleValidGrids;

		// Token: 0x040126E7 RID: 75495
		[Token(Token = "0x40126E7")]
		private const string LEFT_NORMAL_AREA_KEY = "leftNormal";

		// Token: 0x040126E8 RID: 75496
		[Token(Token = "0x40126E8")]
		private const string RIGHT_NORMAL_AREA_KEY = "rightNormal";

		// Token: 0x040126E9 RID: 75497
		[Token(Token = "0x40126E9")]
		private const string LEFT_BOSS_AREA_KEY = "leftBoss";

		// Token: 0x040126EA RID: 75498
		[Token(Token = "0x40126EA")]
		private const string RIGHT_BOSS_AREA_KEY = "rightBoss";

		// Token: 0x040126EB RID: 75499
		[Token(Token = "0x40126EB")]
		private const string GRAPHIC_KEY_LEFT_NORMAL = "HIDDEN@1";

		// Token: 0x040126EC RID: 75500
		[Token(Token = "0x40126EC")]
		private const string GRAPHIC_KEY_RIGHT_NORMAL = "HIDDEN@2";

		// Token: 0x040126ED RID: 75501
		[Token(Token = "0x40126ED")]
		private const string GRAPHIC_KEY_BOSS = "HIDDEN@3";

		// Token: 0x040126EE RID: 75502
		[Token(Token = "0x40126EE")]
		[FieldOffset(Offset = "0x30")]
		private int m_mapLROffset;

		// Token: 0x040126EF RID: 75503
		[Token(Token = "0x40126EF")]
		[FieldOffset(Offset = "0x34")]
		private int m_mapUDOffset;

		// Token: 0x040126F0 RID: 75504
		[Token(Token = "0x40126F0")]
		[FieldOffset(Offset = "0x38")]
		private int m_mapLRBoundaryCol;

		// Token: 0x040126F1 RID: 75505
		[Token(Token = "0x40126F1")]
		[FieldOffset(Offset = "0x3C")]
		private bool m_refreshOptionOnly;

		// Token: 0x040126F2 RID: 75506
		[Token(Token = "0x40126F2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_mapLRBoundaryCol;

		// Token: 0x040126F3 RID: 75507
		[Token(Token = "0x40126F3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_IsLeftNormalMap;

		// Token: 0x040126F4 RID: 75508
		[Token(Token = "0x40126F4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_IsRightNormalMap;

		// Token: 0x040126F5 RID: 75509
		[Token(Token = "0x40126F5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_IsLeftBossMap;

		// Token: 0x040126F6 RID: 75510
		[Token(Token = "0x40126F6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_IsRightBossMap;

		// Token: 0x040126F7 RID: 75511
		[Token(Token = "0x40126F7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsLeftMap;

		// Token: 0x040126F8 RID: 75512
		[Token(Token = "0x40126F8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_IsRightMap;

		// Token: 0x040126F9 RID: 75513
		[Token(Token = "0x40126F9")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_IsNormalMap;

		// Token: 0x040126FA RID: 75514
		[Token(Token = "0x40126FA")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_IsBossMap;

		// Token: 0x040126FB RID: 75515
		[Token(Token = "0x40126FB")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_GetDefaultChessInstPosition;

		// Token: 0x040126FC RID: 75516
		[Token(Token = "0x40126FC")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ConvertChessPositionInfoToDefault;

		// Token: 0x040126FD RID: 75517
		[Token(Token = "0x40126FD")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_ConvertChessPositionInfoToBossMap;

		// Token: 0x040126FE RID: 75518
		[Token(Token = "0x40126FE")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ConvertChessPositionInfoToRightMap;

		// Token: 0x040126FF RID: 75519
		[Token(Token = "0x40126FF")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x04012700 RID: 75520
		[Token(Token = "0x4012700")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_FetchBattleValidMapGrids;

		// Token: 0x04012701 RID: 75521
		[Token(Token = "0x4012701")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_UpdateMapState;

		// Token: 0x04012702 RID: 75522
		[Token(Token = "0x4012702")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_ResetTileIndexer;

		// Token: 0x04012703 RID: 75523
		[Token(Token = "0x4012703")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_UpdateTileIndexerFromOb;

		// Token: 0x04012704 RID: 75524
		[Token(Token = "0x4012704")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__SwitchToSelfBattleMap;

		// Token: 0x04012705 RID: 75525
		[Token(Token = "0x4012705")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__SwitchToHelpBattleMap;

		// Token: 0x04012706 RID: 75526
		[Token(Token = "0x4012706")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__SwitchToBossBattleMap;

		// Token: 0x04012707 RID: 75527
		[Token(Token = "0x4012707")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__UpdateMapGraphic;

		// Token: 0x04012708 RID: 75528
		[Token(Token = "0x4012708")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__EnableArea;

		// Token: 0x04012709 RID: 75529
		[Token(Token = "0x4012709")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__EnableTile;

		// Token: 0x0401270A RID: 75530
		[Token(Token = "0x401270A")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__InitContainer;

		// Token: 0x0401270B RID: 75531
		[Token(Token = "0x401270B")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x0401270C RID: 75532
		[Token(Token = "0x401270C")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__ParseRect;

		// Token: 0x0401270D RID: 75533
		[Token(Token = "0x401270D")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__HideEntity;

		// Token: 0x0401270E RID: 75534
		[Token(Token = "0x401270E")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__ShowEntity;

		// Token: 0x0401270F RID: 75535
		[Token(Token = "0x401270F")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__HideTile;

		// Token: 0x04012710 RID: 75536
		[Token(Token = "0x4012710")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__ShowTile;

		// Token: 0x04012711 RID: 75537
		[Token(Token = "0x4012711")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x0200276D RID: 10093
		[Token(Token = "0x200276D")]
		public class TileIndexer : IHotfixable
		{
			// Token: 0x06010764 RID: 67428 RVA: 0x00064440 File Offset: 0x00062640
			[Token(Token = "0x6010764")]
			[Address(RVA = "0x83CAC0", Offset = "0x83B6C0", VA = "0x18083CAC0")]
			private bool _IsHand(Tile tile)
			{
				return default(bool);
			}

			// Token: 0x06010765 RID: 67429 RVA: 0x00064458 File Offset: 0x00062658
			[Token(Token = "0x6010765")]
			[Address(RVA = "0x83CBA0", Offset = "0x83B7A0", VA = "0x18083CBA0")]
			private bool _IsValidHand(Tile tile)
			{
				return default(bool);
			}

			// Token: 0x06010766 RID: 67430 RVA: 0x00064470 File Offset: 0x00062670
			[Token(Token = "0x6010766")]
			[Address(RVA = "0x83C9E0", Offset = "0x83B5E0", VA = "0x18083C9E0")]
			private bool _IsBattleField(Tile tile)
			{
				return default(bool);
			}

			// Token: 0x06010767 RID: 67431 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6010767")]
			[Address(RVA = "0x83C6F0", Offset = "0x83B2F0", VA = "0x18083C6F0")]
			public void ResetExtraValidator(Func<GridPosition, bool> extraValidator)
			{
			}

			// Token: 0x06010768 RID: 67432 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010768")]
			[Address(RVA = "0x83C2B0", Offset = "0x83AEB0", VA = "0x18083C2B0")]
			public List<GridPosition> GetTilePositionsList(AutoChessMapAreaManager.TileIndexer.TileCacheType cacheType)
			{
				return null;
			}

			// Token: 0x06010769 RID: 67433 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6010769")]
			[Address(RVA = "0x83C540", Offset = "0x83B140", VA = "0x18083C540")]
			public HashSet<GridPosition> GetTilePositions(AutoChessMapAreaManager.TileIndexer.TileCacheType cacheType)
			{
				return null;
			}

			// Token: 0x0601076A RID: 67434 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601076A")]
			[Address(RVA = "0x83C7B0", Offset = "0x83B3B0", VA = "0x18083C7B0")]
			private HashSet<GridPosition> _CollectTilePositions(Func<Tile, bool> validator)
			{
				return null;
			}

			// Token: 0x0601076B RID: 67435 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601076B")]
			[Address(RVA = "0x83CD00", Offset = "0x83B900", VA = "0x18083CD00")]
			public TileIndexer()
			{
			}

			// Token: 0x04012712 RID: 75538
			[Token(Token = "0x4012712")]
			[FieldOffset(Offset = "0x10")]
			private Func<GridPosition, bool> m_extraValidator;

			// Token: 0x04012713 RID: 75539
			[Token(Token = "0x4012713")]
			[FieldOffset(Offset = "0x18")]
			private Dictionary<AutoChessMapAreaManager.TileIndexer.TileCacheType, HashSet<GridPosition>> m_cachedTilePos;

			// Token: 0x04012714 RID: 75540
			[Token(Token = "0x4012714")]
			[FieldOffset(Offset = "0x20")]
			private Dictionary<AutoChessMapAreaManager.TileIndexer.TileCacheType, List<GridPosition>> m_cachedTilePosList;

			// Token: 0x04012715 RID: 75541
			[Token(Token = "0x4012715")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0__IsHand;

			// Token: 0x04012716 RID: 75542
			[Token(Token = "0x4012716")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__IsValidHand;

			// Token: 0x04012717 RID: 75543
			[Token(Token = "0x4012717")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0__IsBattleField;

			// Token: 0x04012718 RID: 75544
			[Token(Token = "0x4012718")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_ResetExtraValidator;

			// Token: 0x04012719 RID: 75545
			[Token(Token = "0x4012719")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_GetTilePositionsList;

			// Token: 0x0401271A RID: 75546
			[Token(Token = "0x401271A")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_GetTilePositions;

			// Token: 0x0401271B RID: 75547
			[Token(Token = "0x401271B")]
			[FieldOffset(Offset = "0x30")]
			private static DelegateBridge __Hotfix0__CollectTilePositions;

			// Token: 0x0401271C RID: 75548
			[Token(Token = "0x401271C")]
			[FieldOffset(Offset = "0x38")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x0200276E RID: 10094
			[Token(Token = "0x200276E")]
			public enum TileCacheType
			{
				// Token: 0x0401271E RID: 75550
				[Token(Token = "0x401271E")]
				BATTLE_FIELD,
				// Token: 0x0401271F RID: 75551
				[Token(Token = "0x401271F")]
				HAND,
				// Token: 0x04012720 RID: 75552
				[Token(Token = "0x4012720")]
				VALID_HAND
			}
		}
	}
}
