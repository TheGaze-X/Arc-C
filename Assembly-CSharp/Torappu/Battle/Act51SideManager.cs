using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002303 RID: 8963
	[Token(Token = "0x2002303")]
	public class Act51SideManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x0600E267 RID: 57959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E267")]
		[Address(RVA = "0x55C110", Offset = "0x55AD10", VA = "0x18055C110", Slot = "7")]
		public override void Init(GlobalEnvSystem system)
		{
		}

		// Token: 0x0600E268 RID: 57960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E268")]
		[Address(RVA = "0x55C600", Offset = "0x55B200", VA = "0x18055C600", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E269 RID: 57961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E269")]
		[Address(RVA = "0x55C520", Offset = "0x55B120", VA = "0x18055C520", Slot = "13")]
		public override void OnEnvDestroy()
		{
		}

		// Token: 0x0600E26A RID: 57962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E26A")]
		[Address(RVA = "0x55BFC0", Offset = "0x55ABC0", VA = "0x18055BFC0")]
		public void AddTower(Trap tower, int state)
		{
		}

		// Token: 0x0600E26B RID: 57963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E26B")]
		[Address(RVA = "0x55C6B0", Offset = "0x55B2B0", VA = "0x18055C6B0")]
		public void RemoveTower(Trap tower)
		{
		}

		// Token: 0x0600E26C RID: 57964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E26C")]
		[Address(RVA = "0x55C900", Offset = "0x55B500", VA = "0x18055C900")]
		private void _UpdateTowerRange()
		{
		}

		// Token: 0x0600E26D RID: 57965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E26D")]
		[Address(RVA = "0x55C7E0", Offset = "0x55B3E0", VA = "0x18055C7E0")]
		public void SetTileFire(Tile tile, bool fire)
		{
		}

		// Token: 0x0600E26E RID: 57966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E26E")]
		[Address(RVA = "0x55D0C0", Offset = "0x55BCC0", VA = "0x18055D0C0")]
		public Act51SideManager()
		{
		}

		// Token: 0x0600E270 RID: 57968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E270")]
		[Address(RVA = "0x550BE0", Offset = "0x54F7E0", VA = "0x180550BE0")]
		private void <>xLuaBaseProxy_Init(GlobalEnvSystem P0)
		{
		}

		// Token: 0x0600E271 RID: 57969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E271")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600E272 RID: 57970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E272")]
		[Address(RVA = "0x550BF0", Offset = "0x54F7F0", VA = "0x180550BF0")]
		private void <>xLuaBaseProxy_OnEnvDestroy()
		{
		}

		// Token: 0x0400F81E RID: 63518
		[Token(Token = "0x400F81E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _disableBlackboardKey;

		// Token: 0x0400F81F RID: 63519
		[Token(Token = "0x400F81F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _heightOffset;

		// Token: 0x0400F820 RID: 63520
		[Token(Token = "0x400F820")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Vector3 _lineOffsetToMapCenter;

		// Token: 0x0400F821 RID: 63521
		[Token(Token = "0x400F821")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<Act51SideManager.EffectKeyByStatus> _effectConfigs;

		// Token: 0x0400F822 RID: 63522
		[Token(Token = "0x400F822")]
		[FieldOffset(Offset = "0x48")]
		private RangeLineEffectByStatusHandler m_rangeLineEffectHandler;

		// Token: 0x0400F823 RID: 63523
		[Token(Token = "0x400F823")]
		[FieldOffset(Offset = "0x50")]
		private readonly Dictionary<ObjectPtr<Trap>, Act51SideManager.WarningState> m_towerState;

		// Token: 0x0400F824 RID: 63524
		[Token(Token = "0x400F824")]
		[FieldOffset(Offset = "0x58")]
		private readonly Dictionary<Tile, Act51SideManager.WarningState> m_tileState;

		// Token: 0x0400F825 RID: 63525
		[Token(Token = "0x400F825")]
		[FieldOffset(Offset = "0x60")]
		private readonly Dictionary<Tile, Act51SideManager.WarningState> m_tileStateTemp;

		// Token: 0x0400F826 RID: 63526
		[Token(Token = "0x400F826")]
		public const string ENV_SYSTEM_KEY = "env_044_act51side";

		// Token: 0x0400F827 RID: 63527
		[Token(Token = "0x400F827")]
		[FieldOffset(Offset = "0x0")]
		public static readonly string[] WARNING_STATES;

		// Token: 0x0400F828 RID: 63528
		[Token(Token = "0x400F828")]
		public const string TILE_FIRE_ON = "tile_fire_on";

		// Token: 0x0400F829 RID: 63529
		[Token(Token = "0x400F829")]
		public const string TILE_FIRE_OFF = "tile_fire_off";

		// Token: 0x0400F82A RID: 63530
		[Token(Token = "0x400F82A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400F82B RID: 63531
		[Token(Token = "0x400F82B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400F82C RID: 63532
		[Token(Token = "0x400F82C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEnvDestroy;

		// Token: 0x0400F82D RID: 63533
		[Token(Token = "0x400F82D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_AddTower;

		// Token: 0x0400F82E RID: 63534
		[Token(Token = "0x400F82E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_RemoveTower;

		// Token: 0x0400F82F RID: 63535
		[Token(Token = "0x400F82F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__UpdateTowerRange;

		// Token: 0x0400F830 RID: 63536
		[Token(Token = "0x400F830")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SetTileFire;

		// Token: 0x0400F831 RID: 63537
		[Token(Token = "0x400F831")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002304 RID: 8964
		[Token(Token = "0x2002304")]
		public enum WarningState
		{
			// Token: 0x0400F833 RID: 63539
			[Token(Token = "0x400F833")]
			None,
			// Token: 0x0400F834 RID: 63540
			[Token(Token = "0x400F834")]
			Normal,
			// Token: 0x0400F835 RID: 63541
			[Token(Token = "0x400F835")]
			Warning
		}

		// Token: 0x02002305 RID: 8965
		[Token(Token = "0x2002305")]
		[Serializable]
		private struct EffectKeyByStatus
		{
			// Token: 0x0400F836 RID: 63542
			[Token(Token = "0x400F836")]
			[FieldOffset(Offset = "0x0")]
			public int status;

			// Token: 0x0400F837 RID: 63543
			[Token(Token = "0x400F837")]
			[FieldOffset(Offset = "0x8")]
			public string effectKey;
		}
	}
}
