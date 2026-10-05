using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x0200233F RID: 9023
	[Token(Token = "0x200233F")]
	public class Mainline16Manager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C95 RID: 7317
		// (get) Token: 0x0600E410 RID: 58384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C95")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E410")]
			[Address(RVA = "0x58EAD0", Offset = "0x58D6D0", VA = "0x18058EAD0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E411 RID: 58385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E411")]
		[Address(RVA = "0x58C690", Offset = "0x58B290", VA = "0x18058C690", Slot = "7")]
		public override void Init(GlobalEnvSystem owner)
		{
		}

		// Token: 0x0600E412 RID: 58386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E412")]
		[Address(RVA = "0x58C800", Offset = "0x58B400", VA = "0x18058C800", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E413 RID: 58387 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E413")]
		[Address(RVA = "0x58C420", Offset = "0x58B020", VA = "0x18058C420")]
		public void ChangeTileShadowStateViaRangeId(string rangeId, GridPosition centerPos, SharedConsts.Direction direction, bool toShadow = true)
		{
		}

		// Token: 0x0600E414 RID: 58388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E414")]
		[Address(RVA = "0x58C270", Offset = "0x58AE70", VA = "0x18058C270")]
		public void ChangeTileShadowStateViaArea(int rowL, int colL, int rowR, int colR, bool toShadow = true)
		{
		}

		// Token: 0x0600E415 RID: 58389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E415")]
		[Address(RVA = "0x58C070", Offset = "0x58AC70", VA = "0x18058C070")]
		public void ChangeShadowTileEscapeTimeViaRangeId(string rangeId, GridPosition centerPos, SharedConsts.Direction direction, float time)
		{
		}

		// Token: 0x0600E416 RID: 58390 RVA: 0x00052908 File Offset: 0x00050B08
		[Token(Token = "0x600E416")]
		[Address(RVA = "0x58C600", Offset = "0x58B200", VA = "0x18058C600")]
		public bool CheckTileInShadowState(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600E417 RID: 58391 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E417")]
		[Address(RVA = "0x58D530", Offset = "0x58C130", VA = "0x18058D530")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600E418 RID: 58392 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E418")]
		[Address(RVA = "0x58D790", Offset = "0x58C390", VA = "0x18058D790")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x0600E419 RID: 58393 RVA: 0x00052920 File Offset: 0x00050B20
		[Token(Token = "0x600E419")]
		[Address(RVA = "0x58D0A0", Offset = "0x58BCA0", VA = "0x18058D0A0")]
		private bool _CheckProperCharacter(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600E41A RID: 58394 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E41A")]
		[Address(RVA = "0x58D230", Offset = "0x58BE30", VA = "0x18058D230")]
		private void _InitParams()
		{
		}

		// Token: 0x0600E41B RID: 58395 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E41B")]
		[Address(RVA = "0x58D150", Offset = "0x58BD50", VA = "0x18058D150")]
		private void _InitMapEffect()
		{
		}

		// Token: 0x0600E41C RID: 58396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E41C")]
		private static void _ResizeList<T>(List<List<T>> target, int height, int width)
		{
		}

		// Token: 0x0600E41D RID: 58397 RVA: 0x00052938 File Offset: 0x00050B38
		[Token(Token = "0x600E41D")]
		[Address(RVA = "0x58E9E0", Offset = "0x58D5E0", VA = "0x18058E9E0")]
		private bool _isShadowTile(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600E41E RID: 58398 RVA: 0x00052950 File Offset: 0x00050B50
		[Token(Token = "0x600E41E")]
		[Address(RVA = "0x58E840", Offset = "0x58D440", VA = "0x18058E840")]
		private bool _isShadowTileInShadowState(Tile tile)
		{
			return default(bool);
		}

		// Token: 0x0600E41F RID: 58399 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E41F")]
		[Address(RVA = "0x58CC60", Offset = "0x58B860", VA = "0x18058CC60")]
		private void _ChangeOneTileToShadowState(Tile tile, bool toShadow = true)
		{
		}

		// Token: 0x0600E420 RID: 58400 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E420")]
		[Address(RVA = "0x58E200", Offset = "0x58CE00", VA = "0x18058E200")]
		private void _UpdateOneTileEscapeTime(Tile tile, float time)
		{
		}

		// Token: 0x0600E421 RID: 58401 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E421")]
		[Address(RVA = "0x58E3F0", Offset = "0x58CFF0", VA = "0x18058E3F0")]
		private void _UpdateTileState(Tile tile)
		{
		}

		// Token: 0x0600E422 RID: 58402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E422")]
		[Address(RVA = "0x58CAC0", Offset = "0x58B6C0", VA = "0x18058CAC0")]
		private void _ChangeBuildableState(Tile tile, bool notBuildable)
		{
		}

		// Token: 0x0600E423 RID: 58403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E423")]
		[Address(RVA = "0x58E030", Offset = "0x58CC30", VA = "0x18058E030")]
		private void _SetTileBoarderEffectDirty(GridPosition gridPos)
		{
		}

		// Token: 0x0600E424 RID: 58404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E424")]
		[Address(RVA = "0x58D9F0", Offset = "0x58C5F0", VA = "0x18058D9F0")]
		private void _RefreshTileBoarderEffect()
		{
		}

		// Token: 0x0600E425 RID: 58405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E425")]
		[Address(RVA = "0x58CE90", Offset = "0x58BA90", VA = "0x18058CE90")]
		private void _CheckGameFinish()
		{
		}

		// Token: 0x0600E426 RID: 58406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E426")]
		[Address(RVA = "0x58E740", Offset = "0x58D340", VA = "0x18058E740")]
		public Mainline16Manager()
		{
		}

		// Token: 0x0600E428 RID: 58408 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E428")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E429 RID: 58409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E429")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E42A RID: 58410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E42A")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0400FB1D RID: 64285
		[Token(Token = "0x400FB1D")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _tileInside;

		// Token: 0x0400FB1E RID: 64286
		[Token(Token = "0x400FB1E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _tileOutside;

		// Token: 0x0400FB1F RID: 64287
		[Token(Token = "0x400FB1F")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _mapEffectKey;

		// Token: 0x0400FB20 RID: 64288
		[Token(Token = "0x400FB20")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<string> _tileBorderEffects;

		// Token: 0x0400FB21 RID: 64289
		[Token(Token = "0x400FB21")]
		[FieldOffset(Offset = "0x48")]
		private List<List<int>> m_isShadowTile;

		// Token: 0x0400FB22 RID: 64290
		[Token(Token = "0x400FB22")]
		[FieldOffset(Offset = "0x50")]
		private List<List<float>> m_shadowTileRemainingTime;

		// Token: 0x0400FB23 RID: 64291
		[Token(Token = "0x400FB23")]
		[FieldOffset(Offset = "0x58")]
		private List<List<bool>> m_isShadowTileInShadowState;

		// Token: 0x0400FB24 RID: 64292
		[Token(Token = "0x400FB24")]
		[FieldOffset(Offset = "0x60")]
		private List<List<bool>> m_shadowTileDeployed;

		// Token: 0x0400FB25 RID: 64293
		[Token(Token = "0x400FB25")]
		[FieldOffset(Offset = "0x68")]
		private HashSet<GridPosition> m_tileBoardEffectDirtySet;

		// Token: 0x0400FB26 RID: 64294
		[Token(Token = "0x400FB26")]
		[FieldOffset(Offset = "0x70")]
		private int m_mapHeight;

		// Token: 0x0400FB27 RID: 64295
		[Token(Token = "0x400FB27")]
		[FieldOffset(Offset = "0x74")]
		private int m_mapWidth;

		// Token: 0x0400FB28 RID: 64296
		[Token(Token = "0x400FB28")]
		[FieldOffset(Offset = "0x78")]
		private bool m_recordTimer;

		// Token: 0x0400FB29 RID: 64297
		[Token(Token = "0x400FB29")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string ENV_SYSTEM_KEY;

		// Token: 0x0400FB2A RID: 64298
		[Token(Token = "0x400FB2A")]
		private const string IS_RECORD_TIME = "is_record_time";

		// Token: 0x0400FB2B RID: 64299
		[Token(Token = "0x400FB2B")]
		private const float FLOAT_EPSILON = 0.001f;

		// Token: 0x0400FB2C RID: 64300
		[Token(Token = "0x400FB2C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400FB2D RID: 64301
		[Token(Token = "0x400FB2D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400FB2E RID: 64302
		[Token(Token = "0x400FB2E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400FB2F RID: 64303
		[Token(Token = "0x400FB2F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ChangeTileShadowStateViaRangeId;

		// Token: 0x0400FB30 RID: 64304
		[Token(Token = "0x400FB30")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_ChangeTileShadowStateViaArea;

		// Token: 0x0400FB31 RID: 64305
		[Token(Token = "0x400FB31")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ChangeShadowTileEscapeTimeViaRangeId;

		// Token: 0x0400FB32 RID: 64306
		[Token(Token = "0x400FB32")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_CheckTileInShadowState;

		// Token: 0x0400FB33 RID: 64307
		[Token(Token = "0x400FB33")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400FB34 RID: 64308
		[Token(Token = "0x400FB34")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x0400FB35 RID: 64309
		[Token(Token = "0x400FB35")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CheckProperCharacter;

		// Token: 0x0400FB36 RID: 64310
		[Token(Token = "0x400FB36")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__InitParams;

		// Token: 0x0400FB37 RID: 64311
		[Token(Token = "0x400FB37")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__InitMapEffect;

		// Token: 0x0400FB38 RID: 64312
		[Token(Token = "0x400FB38")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ResizeList;

		// Token: 0x0400FB39 RID: 64313
		[Token(Token = "0x400FB39")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__isShadowTile;

		// Token: 0x0400FB3A RID: 64314
		[Token(Token = "0x400FB3A")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__isShadowTileInShadowState;

		// Token: 0x0400FB3B RID: 64315
		[Token(Token = "0x400FB3B")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__ChangeOneTileToShadowState;

		// Token: 0x0400FB3C RID: 64316
		[Token(Token = "0x400FB3C")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__UpdateOneTileEscapeTime;

		// Token: 0x0400FB3D RID: 64317
		[Token(Token = "0x400FB3D")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__UpdateTileState;

		// Token: 0x0400FB3E RID: 64318
		[Token(Token = "0x400FB3E")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__ChangeBuildableState;

		// Token: 0x0400FB3F RID: 64319
		[Token(Token = "0x400FB3F")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__SetTileBoarderEffectDirty;

		// Token: 0x0400FB40 RID: 64320
		[Token(Token = "0x400FB40")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__RefreshTileBoarderEffect;

		// Token: 0x0400FB41 RID: 64321
		[Token(Token = "0x400FB41")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__CheckGameFinish;

		// Token: 0x0400FB42 RID: 64322
		[Token(Token = "0x400FB42")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
