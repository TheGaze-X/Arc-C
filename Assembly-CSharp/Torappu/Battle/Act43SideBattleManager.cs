using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020022D1 RID: 8913
	[Token(Token = "0x20022D1")]
	public class Act43SideBattleManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C26 RID: 7206
		// (get) Token: 0x0600E064 RID: 57444 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C26")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E064")]
			[Address(RVA = "0x366FE60", Offset = "0x366EA60", VA = "0x18366FE60", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E065 RID: 57445 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E065")]
		[Address(RVA = "0x366D620", Offset = "0x366C220", VA = "0x18366D620", Slot = "7")]
		public override void Init(GlobalEnvSystem envSystem)
		{
		}

		// Token: 0x0600E066 RID: 57446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E066")]
		[Address(RVA = "0x366F4D0", Offset = "0x366E0D0", VA = "0x18366F4D0")]
		private void _OnUnitBorn(object obj)
		{
		}

		// Token: 0x0600E067 RID: 57447 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E067")]
		[Address(RVA = "0x366F330", Offset = "0x366DF30", VA = "0x18366F330")]
		private void _OnRallyPointChanged(object obj)
		{
		}

		// Token: 0x0600E068 RID: 57448 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E068")]
		[Address(RVA = "0x366F1C0", Offset = "0x366DDC0", VA = "0x18366F1C0")]
		private void _OnGameOver(object obj)
		{
		}

		// Token: 0x0600E069 RID: 57449 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E069")]
		[Address(RVA = "0x366F010", Offset = "0x366DC10", VA = "0x18366F010")]
		private void _OnCharacterBorn(Character character)
		{
		}

		// Token: 0x0600E06A RID: 57450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E06A")]
		[Address(RVA = "0x366F120", Offset = "0x366DD20", VA = "0x18366F120")]
		private void _OnEnemyBorn(Enemy enemy)
		{
		}

		// Token: 0x17001C27 RID: 7207
		// (get) Token: 0x0600E06B RID: 57451 RVA: 0x000516F0 File Offset: 0x0004F8F0
		[Token(Token = "0x17001C27")]
		public FP shootingAreaSpeedScale
		{
			[Token(Token = "0x600E06B")]
			[Address(RVA = "0x3670290", Offset = "0x366EE90", VA = "0x183670290")]
			get
			{
				return default(FP);
			}
		}

		// Token: 0x0600E06C RID: 57452 RVA: 0x00051708 File Offset: 0x0004F908
		[Token(Token = "0x600E06C")]
		[Address(RVA = "0x366D380", Offset = "0x366BF80", VA = "0x18366D380")]
		public bool CheckIfFaceToCamera(Entity source, Entity target)
		{
			return default(bool);
		}

		// Token: 0x0600E06D RID: 57453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E06D")]
		[Address(RVA = "0x366DB00", Offset = "0x366C700", VA = "0x18366DB00")]
		public void UpdateShootingArea(Entity target, bool isActivate)
		{
		}

		// Token: 0x0600E06E RID: 57454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E06E")]
		[Address(RVA = "0x366D920", Offset = "0x366C520", VA = "0x18366D920")]
		public void OnBlockChanged(GridPosition gridPosition, bool isActivate)
		{
		}

		// Token: 0x0600E06F RID: 57455 RVA: 0x00051720 File Offset: 0x0004F920
		[Token(Token = "0x600E06F")]
		[Address(RVA = "0x366D810", Offset = "0x366C410", VA = "0x18366D810")]
		public bool IsShootingArea(GridPosition gridPosition)
		{
			return default(bool);
		}

		// Token: 0x0600E070 RID: 57456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E070")]
		[Address(RVA = "0x366DA40", Offset = "0x366C640", VA = "0x18366DA40")]
		public void OnEnemyInteractWithShootingArea(Entity enemy, bool isEnter)
		{
		}

		// Token: 0x0600E071 RID: 57457 RVA: 0x00051738 File Offset: 0x0004F938
		[Token(Token = "0x600E071")]
		[Address(RVA = "0x366D530", Offset = "0x366C130", VA = "0x18366D530")]
		public SharedConsts.Direction GetShootingAreaDirection(GridPosition gridPosition)
		{
			return SharedConsts.Direction.UP;
		}

		// Token: 0x0600E072 RID: 57458 RVA: 0x00051750 File Offset: 0x0004F950
		[Token(Token = "0x600E072")]
		[Address(RVA = "0x366EF20", Offset = "0x366DB20", VA = "0x18366EF20")]
		private bool _IsShootingArea(int row, int col)
		{
			return default(bool);
		}

		// Token: 0x0600E073 RID: 57459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E073")]
		[Address(RVA = "0x366DC40", Offset = "0x366C840", VA = "0x18366DC40")]
		private void _AssignCameraRangeByDirection(GridPosition source, SharedConsts.Direction direction)
		{
		}

		// Token: 0x0600E074 RID: 57460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E074")]
		[Address(RVA = "0x366DE00", Offset = "0x366CA00", VA = "0x18366DE00")]
		private void _AssignSingleLineByDirection(GridPosition source, SharedConsts.Direction direction)
		{
		}

		// Token: 0x0600E075 RID: 57461 RVA: 0x00051768 File Offset: 0x0004F968
		[Token(Token = "0x600E075")]
		[Address(RVA = "0x366DFE0", Offset = "0x366CBE0", VA = "0x18366DFE0")]
		private bool _CheckGridValid(int row, int col)
		{
			return default(bool);
		}

		// Token: 0x0600E076 RID: 57462 RVA: 0x00051780 File Offset: 0x0004F980
		[Token(Token = "0x600E076")]
		[Address(RVA = "0x366E090", Offset = "0x366CC90", VA = "0x18366E090")]
		private bool _CheckGridValid(GridPosition gridPosition)
		{
			return default(bool);
		}

		// Token: 0x0600E077 RID: 57463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E077")]
		[Address(RVA = "0x366EA20", Offset = "0x366D620", VA = "0x18366EA20")]
		private void _DoUpdate()
		{
		}

		// Token: 0x0600E078 RID: 57464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E078")]
		[Address(RVA = "0x366E9B0", Offset = "0x366D5B0", VA = "0x18366E9B0")]
		private void _DealWithEntityInShootingArea()
		{
		}

		// Token: 0x0600E079 RID: 57465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E079")]
		[Address(RVA = "0x366E580", Offset = "0x366D180", VA = "0x18366E580")]
		private void _DealWithEnemyInShootingArea()
		{
		}

		// Token: 0x0600E07A RID: 57466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E07A")]
		[Address(RVA = "0x366E150", Offset = "0x366CD50", VA = "0x18366E150")]
		private void _DealWithCharacterInShootingArea()
		{
		}

		// Token: 0x0600E07B RID: 57467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E07B")]
		[Address(RVA = "0x366F870", Offset = "0x366E470", VA = "0x18366F870")]
		private void _UpdateGridEffect(int row, int col)
		{
		}

		// Token: 0x0600E07C RID: 57468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E07C")]
		[Address(RVA = "0x366FA10", Offset = "0x366E610", VA = "0x18366FA10")]
		private void _UpdateTileLine(Tile tile)
		{
		}

		// Token: 0x0600E07D RID: 57469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E07D")]
		[Address(RVA = "0x366F810", Offset = "0x366E410", VA = "0x18366F810")]
		private void _PrintAreaMap()
		{
		}

		// Token: 0x0600E07E RID: 57470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E07E")]
		[Address(RVA = "0x366FB60", Offset = "0x366E760", VA = "0x18366FB60")]
		public Act43SideBattleManager()
		{
		}

		// Token: 0x0600E07F RID: 57471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E07F")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E080 RID: 57472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E080")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0400F46E RID: 62574
		[Token(Token = "0x400F46E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _characterEnterShootingAreaStatus;

		// Token: 0x0400F46F RID: 62575
		[Token(Token = "0x400F46F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _characterLeaveShootingAreaStatus;

		// Token: 0x0400F470 RID: 62576
		[Token(Token = "0x400F470")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _enemyEnterShootingAreaStatus;

		// Token: 0x0400F471 RID: 62577
		[Token(Token = "0x400F471")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private string _enemyLeaveShootingAreaStatus;

		// Token: 0x0400F472 RID: 62578
		[Token(Token = "0x400F472")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private string _enemyBornStatus;

		// Token: 0x0400F473 RID: 62579
		[Token(Token = "0x400F473")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _tileOnStatus;

		// Token: 0x0400F474 RID: 62580
		[Token(Token = "0x400F474")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _tileOffStatus;

		// Token: 0x0400F475 RID: 62581
		[Token(Token = "0x400F475")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private int _extraShootingWidth;

		// Token: 0x0400F476 RID: 62582
		[Token(Token = "0x400F476")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _shootingAreaSpeedScale;

		// Token: 0x0400F477 RID: 62583
		[Token(Token = "0x400F477")]
		[FieldOffset(Offset = "0x68")]
		private int m_mapWidth;

		// Token: 0x0400F478 RID: 62584
		[Token(Token = "0x400F478")]
		[FieldOffset(Offset = "0x6C")]
		private int m_mapHeight;

		// Token: 0x0400F479 RID: 62585
		[Token(Token = "0x400F479")]
		[FieldOffset(Offset = "0x70")]
		private FP m_shootingAreaSpeedScale;

		// Token: 0x0400F47A RID: 62586
		[Token(Token = "0x400F47A")]
		[FieldOffset(Offset = "0x78")]
		private int[,] m_shootingArea;

		// Token: 0x0400F47B RID: 62587
		[Token(Token = "0x400F47B")]
		[FieldOffset(Offset = "0x80")]
		private readonly ListDict<uint, ObjectPtr<Entity>> m_cameraList;

		// Token: 0x0400F47C RID: 62588
		[Token(Token = "0x400F47C")]
		[FieldOffset(Offset = "0x88")]
		private readonly List<ObjectPtr<Entity>> m_cEnter;

		// Token: 0x0400F47D RID: 62589
		[Token(Token = "0x400F47D")]
		[FieldOffset(Offset = "0x90")]
		private readonly List<ObjectPtr<Entity>> m_cLeave;

		// Token: 0x0400F47E RID: 62590
		[Token(Token = "0x400F47E")]
		[FieldOffset(Offset = "0x98")]
		private readonly List<ObjectPtr<Entity>> m_eEnter;

		// Token: 0x0400F47F RID: 62591
		[Token(Token = "0x400F47F")]
		[FieldOffset(Offset = "0xA0")]
		private readonly List<ObjectPtr<Entity>> m_eLeave;

		// Token: 0x0400F480 RID: 62592
		[Token(Token = "0x400F480")]
		[FieldOffset(Offset = "0xA8")]
		private readonly GridPosition m_gridOffset;

		// Token: 0x0400F481 RID: 62593
		[Token(Token = "0x400F481")]
		public const string ENV_SYSTEM_KEY = "env_031_act43side";

		// Token: 0x0400F482 RID: 62594
		[Token(Token = "0x400F482")]
		private const int BLOCKER_FLAG = -2;

		// Token: 0x0400F483 RID: 62595
		[Token(Token = "0x400F483")]
		private const int DARK_AREA_FLAG = -1;

		// Token: 0x0400F484 RID: 62596
		[Token(Token = "0x400F484")]
		private const int BOUNDARY_EXTENSION_LENGTH = 10;

		// Token: 0x0400F485 RID: 62597
		[Token(Token = "0x400F485")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F486 RID: 62598
		[Token(Token = "0x400F486")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F487 RID: 62599
		[Token(Token = "0x400F487")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400F488 RID: 62600
		[Token(Token = "0x400F488")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnRallyPointChanged;

		// Token: 0x0400F489 RID: 62601
		[Token(Token = "0x400F489")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnGameOver;

		// Token: 0x0400F48A RID: 62602
		[Token(Token = "0x400F48A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnCharacterBorn;

		// Token: 0x0400F48B RID: 62603
		[Token(Token = "0x400F48B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnEnemyBorn;

		// Token: 0x0400F48C RID: 62604
		[Token(Token = "0x400F48C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_shootingAreaSpeedScale;

		// Token: 0x0400F48D RID: 62605
		[Token(Token = "0x400F48D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_CheckIfFaceToCamera;

		// Token: 0x0400F48E RID: 62606
		[Token(Token = "0x400F48E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_UpdateShootingArea;

		// Token: 0x0400F48F RID: 62607
		[Token(Token = "0x400F48F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnBlockChanged;

		// Token: 0x0400F490 RID: 62608
		[Token(Token = "0x400F490")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_IsShootingArea;

		// Token: 0x0400F491 RID: 62609
		[Token(Token = "0x400F491")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnEnemyInteractWithShootingArea;

		// Token: 0x0400F492 RID: 62610
		[Token(Token = "0x400F492")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_GetShootingAreaDirection;

		// Token: 0x0400F493 RID: 62611
		[Token(Token = "0x400F493")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__IsShootingArea;

		// Token: 0x0400F494 RID: 62612
		[Token(Token = "0x400F494")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__AssignCameraRangeByDirection;

		// Token: 0x0400F495 RID: 62613
		[Token(Token = "0x400F495")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__AssignSingleLineByDirection;

		// Token: 0x0400F496 RID: 62614
		[Token(Token = "0x400F496")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CheckGridValid;

		// Token: 0x0400F497 RID: 62615
		[Token(Token = "0x400F497")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix1__CheckGridValid;

		// Token: 0x0400F498 RID: 62616
		[Token(Token = "0x400F498")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__DoUpdate;

		// Token: 0x0400F499 RID: 62617
		[Token(Token = "0x400F499")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__DealWithEntityInShootingArea;

		// Token: 0x0400F49A RID: 62618
		[Token(Token = "0x400F49A")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__DealWithEnemyInShootingArea;

		// Token: 0x0400F49B RID: 62619
		[Token(Token = "0x400F49B")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__DealWithCharacterInShootingArea;

		// Token: 0x0400F49C RID: 62620
		[Token(Token = "0x400F49C")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__UpdateGridEffect;

		// Token: 0x0400F49D RID: 62621
		[Token(Token = "0x400F49D")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__UpdateTileLine;

		// Token: 0x0400F49E RID: 62622
		[Token(Token = "0x400F49E")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__PrintAreaMap;

		// Token: 0x0400F49F RID: 62623
		[Token(Token = "0x400F49F")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
