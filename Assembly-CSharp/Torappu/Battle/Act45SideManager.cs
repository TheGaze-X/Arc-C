using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020022D4 RID: 8916
	[Token(Token = "0x20022D4")]
	public class Act45SideManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x0600E0AE RID: 57518 RVA: 0x00051858 File Offset: 0x0004FA58
		[Token(Token = "0x600E0AE")]
		[Address(RVA = "0x3678530", Offset = "0x3677130", VA = "0x183678530")]
		public bool CheckTileInLight(GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x17001C32 RID: 7218
		// (get) Token: 0x0600E0AF RID: 57519 RVA: 0x00051870 File Offset: 0x0004FA70
		[Token(Token = "0x17001C32")]
		public SharedConsts.Direction lightSourceDirection
		{
			[Token(Token = "0x600E0AF")]
			[Address(RVA = "0x367AA30", Offset = "0x3679630", VA = "0x18367AA30")]
			get
			{
				return SharedConsts.Direction.UP;
			}
		}

		// Token: 0x17001C33 RID: 7219
		// (get) Token: 0x0600E0B0 RID: 57520 RVA: 0x00051888 File Offset: 0x0004FA88
		[Token(Token = "0x17001C33")]
		public float lightProgeress
		{
			[Token(Token = "0x600E0B0")]
			[Address(RVA = "0x367A970", Offset = "0x3679570", VA = "0x18367A970")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17001C34 RID: 7220
		// (get) Token: 0x0600E0B1 RID: 57521 RVA: 0x000518A0 File Offset: 0x0004FAA0
		[Token(Token = "0x17001C34")]
		public bool isCw
		{
			[Token(Token = "0x600E0B1")]
			[Address(RVA = "0x367A900", Offset = "0x3679500", VA = "0x18367A900")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17001C35 RID: 7221
		// (get) Token: 0x0600E0B2 RID: 57522 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C35")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E0B2")]
			[Address(RVA = "0x367A630", Offset = "0x3679230", VA = "0x18367A630", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E0B3 RID: 57523 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0B3")]
		[Address(RVA = "0x3678610", Offset = "0x3677210", VA = "0x183678610", Slot = "7")]
		public override void Init(GlobalEnvSystem system)
		{
		}

		// Token: 0x0600E0B4 RID: 57524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0B4")]
		[Address(RVA = "0x3678C00", Offset = "0x3677800", VA = "0x183678C00", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E0B5 RID: 57525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0B5")]
		[Address(RVA = "0x3678DC0", Offset = "0x36779C0", VA = "0x183678DC0", Slot = "15")]
		public override void OnTrigger(object param)
		{
		}

		// Token: 0x0600E0B6 RID: 57526 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0B6")]
		[Address(RVA = "0x3678E90", Offset = "0x3677A90", VA = "0x183678E90")]
		private void _ChangeLightDirection(SharedConsts.Direction direction, bool force = false)
		{
		}

		// Token: 0x0600E0B7 RID: 57527 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0B7")]
		[Address(RVA = "0x367A2A0", Offset = "0x3678EA0", VA = "0x18367A2A0")]
		private void _UpdateUnitTile(GridPosition pos)
		{
		}

		// Token: 0x0600E0B8 RID: 57528 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0B8")]
		[Address(RVA = "0x3679A70", Offset = "0x3678670", VA = "0x183679A70")]
		private void _UpdateLightTilesLeft(int row)
		{
		}

		// Token: 0x0600E0B9 RID: 57529 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0B9")]
		[Address(RVA = "0x3679CD0", Offset = "0x36788D0", VA = "0x183679CD0")]
		private void _UpdateLightTilesRight(int row)
		{
		}

		// Token: 0x0600E0BA RID: 57530 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0BA")]
		[Address(RVA = "0x3679810", Offset = "0x3678410", VA = "0x183679810")]
		private void _UpdateLightTilesDown(int col)
		{
		}

		// Token: 0x0600E0BB RID: 57531 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0BB")]
		[Address(RVA = "0x3679ED0", Offset = "0x3678AD0", VA = "0x183679ED0")]
		private void _UpdateLightTilesUp(int col)
		{
		}

		// Token: 0x0600E0BC RID: 57532 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0BC")]
		[Address(RVA = "0x3679660", Offset = "0x3678260", VA = "0x183679660")]
		private void _ResetTileDic()
		{
		}

		// Token: 0x0600E0BD RID: 57533 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0BD")]
		[Address(RVA = "0x36793A0", Offset = "0x3677FA0", VA = "0x1836793A0")]
		private void _OnUnitBornOrFinish(object param)
		{
		}

		// Token: 0x0600E0BE RID: 57534 RVA: 0x000518B8 File Offset: 0x0004FAB8
		[Token(Token = "0x600E0BE")]
		[Address(RVA = "0x36791A0", Offset = "0x3677DA0", VA = "0x1836791A0")]
		private bool _CheckTileValid(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600E0BF RID: 57535 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0BF")]
		[Address(RVA = "0x367A0D0", Offset = "0x3678CD0", VA = "0x18367A0D0")]
		private void _UpdateTile(Tile tile, bool isLight)
		{
		}

		// Token: 0x0600E0C0 RID: 57536 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0C0")]
		[Address(RVA = "0x367A4D0", Offset = "0x36790D0", VA = "0x18367A4D0")]
		public Act45SideManager()
		{
		}

		// Token: 0x0600E0C2 RID: 57538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E0C2")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E0C3 RID: 57539 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0C3")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E0C4 RID: 57540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0C4")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600E0C5 RID: 57541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E0C5")]
		[Address(RVA = "0x550C10", Offset = "0x54F810", VA = "0x180550C10")]
		private void <>xLuaBaseProxy_OnTrigger(object P0)
		{
		}

		// Token: 0x0400F50E RID: 62734
		[Token(Token = "0x400F50E")]
		private const string FILTER_TAG_TRAP = "MJCSDW";

		// Token: 0x0400F50F RID: 62735
		[Token(Token = "0x400F50F")]
		private const string CHANGE_DIRECTION_WARING_KEY = "act45side_light_warning";

		// Token: 0x0400F510 RID: 62736
		[Token(Token = "0x400F510")]
		private const float CHANGE_DIRECTION_AUDIO_TIME = 10f;

		// Token: 0x0400F511 RID: 62737
		[Token(Token = "0x400F511")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Dictionary<SharedConsts.Direction, string> s_directionKeysForMesh;

		// Token: 0x0400F512 RID: 62738
		[Token(Token = "0x400F512")]
		[FieldOffset(Offset = "0x28")]
		private FP m_lightDuration;

		// Token: 0x0400F513 RID: 62739
		[Token(Token = "0x400F513")]
		[FieldOffset(Offset = "0x30")]
		private bool isWarning;

		// Token: 0x0400F514 RID: 62740
		[Token(Token = "0x400F514")]
		[FieldOffset(Offset = "0x31")]
		private bool m_isCW;

		// Token: 0x0400F515 RID: 62741
		[Token(Token = "0x400F515")]
		[FieldOffset(Offset = "0x34")]
		private SharedConsts.Direction m_lightSourceDirection;

		// Token: 0x0400F516 RID: 62742
		[Token(Token = "0x400F516")]
		[FieldOffset(Offset = "0x38")]
		private PeriodicTimer m_timer;

		// Token: 0x0400F517 RID: 62743
		[Token(Token = "0x400F517")]
		[FieldOffset(Offset = "0x40")]
		private Dictionary<int, int> m_lightPos;

		// Token: 0x0400F518 RID: 62744
		[Token(Token = "0x400F518")]
		[FieldOffset(Offset = "0x48")]
		private ListDict<GridPosition, bool> m_tiles;

		// Token: 0x0400F519 RID: 62745
		[Token(Token = "0x400F519")]
		[FieldOffset(Offset = "0x50")]
		private MapSubGraphicHolder m_subGraphicHolder;

		// Token: 0x0400F51A RID: 62746
		[Token(Token = "0x400F51A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckTileInLight;

		// Token: 0x0400F51B RID: 62747
		[Token(Token = "0x400F51B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_lightSourceDirection;

		// Token: 0x0400F51C RID: 62748
		[Token(Token = "0x400F51C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_lightProgeress;

		// Token: 0x0400F51D RID: 62749
		[Token(Token = "0x400F51D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isCw;

		// Token: 0x0400F51E RID: 62750
		[Token(Token = "0x400F51E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F51F RID: 62751
		[Token(Token = "0x400F51F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F520 RID: 62752
		[Token(Token = "0x400F520")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F521 RID: 62753
		[Token(Token = "0x400F521")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnTrigger;

		// Token: 0x0400F522 RID: 62754
		[Token(Token = "0x400F522")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ChangeLightDirection;

		// Token: 0x0400F523 RID: 62755
		[Token(Token = "0x400F523")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateUnitTile;

		// Token: 0x0400F524 RID: 62756
		[Token(Token = "0x400F524")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateLightTilesLeft;

		// Token: 0x0400F525 RID: 62757
		[Token(Token = "0x400F525")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__UpdateLightTilesRight;

		// Token: 0x0400F526 RID: 62758
		[Token(Token = "0x400F526")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__UpdateLightTilesDown;

		// Token: 0x0400F527 RID: 62759
		[Token(Token = "0x400F527")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__UpdateLightTilesUp;

		// Token: 0x0400F528 RID: 62760
		[Token(Token = "0x400F528")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__ResetTileDic;

		// Token: 0x0400F529 RID: 62761
		[Token(Token = "0x400F529")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnUnitBornOrFinish;

		// Token: 0x0400F52A RID: 62762
		[Token(Token = "0x400F52A")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__CheckTileValid;

		// Token: 0x0400F52B RID: 62763
		[Token(Token = "0x400F52B")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__UpdateTile;

		// Token: 0x0400F52C RID: 62764
		[Token(Token = "0x400F52C")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
