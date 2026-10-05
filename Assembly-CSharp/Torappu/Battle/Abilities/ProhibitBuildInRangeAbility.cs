using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B4B RID: 11083
	[Token(Token = "0x2002B4B")]
	public class ProhibitBuildInRangeAbility : PassiveBuffAbility
	{
		// Token: 0x060129AC RID: 76204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129AC")]
		[Address(RVA = "0xAA40B0", Offset = "0xAA2CB0", VA = "0x180AA40B0", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060129AD RID: 76205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129AD")]
		[Address(RVA = "0xAA42A0", Offset = "0xAA2EA0", VA = "0x180AA42A0", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x060129AE RID: 76206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129AE")]
		[Address(RVA = "0xAA3E80", Offset = "0xAA2A80", VA = "0x180AA3E80", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x060129AF RID: 76207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129AF")]
		[Address(RVA = "0xAA3E10", Offset = "0xAA2A10", VA = "0x180AA3E10")]
		protected void OnDestroy()
		{
		}

		// Token: 0x060129B0 RID: 76208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129B0")]
		[Address(RVA = "0xAA4360", Offset = "0xAA2F60", VA = "0x180AA4360")]
		private void _UpdateManagedTilesInRange()
		{
		}

		// Token: 0x060129B1 RID: 76209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129B1")]
		[Address(RVA = "0xAA4980", Offset = "0xAA3580", VA = "0x180AA4980")]
		public ProhibitBuildInRangeAbility()
		{
		}

		// Token: 0x060129B2 RID: 76210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129B2")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x060129B3 RID: 76211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129B3")]
		[Address(RVA = "0xA4B0B0", Offset = "0xA49CB0", VA = "0x180A4B0B0")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x060129B4 RID: 76212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60129B4")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x0401503B RID: 86075
		[Token(Token = "0x401503B")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		private List<GridPosition> _rangeGridPositions;

		// Token: 0x0401503C RID: 86076
		[Token(Token = "0x401503C")]
		[FieldOffset(Offset = "0x120")]
		private ProhibitBuildInRangeAbility.BuildBlockChecker m_checker;

		// Token: 0x0401503D RID: 86077
		[Token(Token = "0x401503D")]
		[FieldOffset(Offset = "0x128")]
		private readonly List<ObjectPtr<Tile>> m_managedTiles;

		// Token: 0x0401503E RID: 86078
		[Token(Token = "0x401503E")]
		[FieldOffset(Offset = "0x130")]
		private readonly HashSet<ObjectPtr<Tile>> m_curInRangeTiles;

		// Token: 0x0401503F RID: 86079
		[Token(Token = "0x401503F")]
		[FieldOffset(Offset = "0x138")]
		private ObjectPtr<Tile> m_rootTile;

		// Token: 0x04015040 RID: 86080
		[Token(Token = "0x4015040")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04015041 RID: 86081
		[Token(Token = "0x4015041")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04015042 RID: 86082
		[Token(Token = "0x4015042")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04015043 RID: 86083
		[Token(Token = "0x4015043")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04015044 RID: 86084
		[Token(Token = "0x4015044")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateManagedTilesInRange;

		// Token: 0x04015045 RID: 86085
		[Token(Token = "0x4015045")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002B4C RID: 11084
		[Token(Token = "0x2002B4C")]
		private class BuildBlockChecker : ITileBuildableChecker, IHotfixable
		{
			// Token: 0x060129B5 RID: 76213 RVA: 0x00071EE0 File Offset: 0x000700E0
			[Token(Token = "0x60129B5")]
			[Address(RVA = "0xA9EF80", Offset = "0xA9DB80", VA = "0x180A9EF80", Slot = "5")]
			public bool IsTileBuildable(Tile tile)
			{
				return default(bool);
			}

			// Token: 0x060129B6 RID: 76214 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60129B6")]
			[Address(RVA = "0xA9F030", Offset = "0xA9DC30", VA = "0x180A9F030")]
			public BuildBlockChecker()
			{
			}

			// Token: 0x04015046 RID: 86086
			[Token(Token = "0x4015046")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_IsTileBuildable;

			// Token: 0x04015047 RID: 86087
			[Token(Token = "0x4015047")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
