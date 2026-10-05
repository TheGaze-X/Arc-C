using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002352 RID: 9042
	[Token(Token = "0x2002352")]
	public class TrapCompositeManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C9E RID: 7326
		// (get) Token: 0x0600E4BF RID: 58559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C9E")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E4BF")]
			[Address(RVA = "0x5AEEE0", Offset = "0x5ADAE0", VA = "0x1805AEEE0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E4C0 RID: 58560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4C0")]
		[Address(RVA = "0x5AD4E0", Offset = "0x5AC0E0", VA = "0x1805AD4E0", Slot = "12")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0600E4C1 RID: 58561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4C1")]
		[Address(RVA = "0x5AD410", Offset = "0x5AC010", VA = "0x1805AD410", Slot = "13")]
		public override void OnEnvDestroy()
		{
		}

		// Token: 0x0600E4C2 RID: 58562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4C2")]
		[Address(RVA = "0x5AEC00", Offset = "0x5AD800", VA = "0x1805AEC00")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600E4C3 RID: 58563 RVA: 0x00052B48 File Offset: 0x00050D48
		[Token(Token = "0x600E4C3")]
		[Address(RVA = "0x5ADC30", Offset = "0x5AC830", VA = "0x1805ADC30")]
		private bool _CheckTrapValid(Character character)
		{
			return default(bool);
		}

		// Token: 0x0600E4C4 RID: 58564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4C4")]
		[Address(RVA = "0x5AE5E0", Offset = "0x5AD1E0", VA = "0x1805AE5E0")]
		private void _FindCompositeTrap()
		{
		}

		// Token: 0x0600E4C5 RID: 58565 RVA: 0x00052B60 File Offset: 0x00050D60
		[Token(Token = "0x600E4C5")]
		[Address(RVA = "0x5AE2D0", Offset = "0x5ACED0", VA = "0x1805AE2D0")]
		private bool _FilterCompositeTrap(ObscuredRect rect, RangeData rangeData, bool isRotated)
		{
			return default(bool);
		}

		// Token: 0x0600E4C6 RID: 58566 RVA: 0x00052B78 File Offset: 0x00050D78
		[Token(Token = "0x600E4C6")]
		[Address(RVA = "0x5AD670", Offset = "0x5AC270", VA = "0x1805AD670")]
		private bool _CheckAllTrapsInRect(ObscuredRect rect, GridPosition rectMapPos, RangeData rangeData, bool isRotated)
		{
			return default(bool);
		}

		// Token: 0x0600E4C7 RID: 58567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4C7")]
		[Address(RVA = "0x5ADCD0", Offset = "0x5AC8D0", VA = "0x1805ADCD0")]
		private void _CompositeTraps(ObscuredRect rect, GridPosition rectMapPos, RangeData rangeData, bool isRotated)
		{
		}

		// Token: 0x0600E4C8 RID: 58568 RVA: 0x00052B90 File Offset: 0x00050D90
		[Token(Token = "0x600E4C8")]
		[Address(RVA = "0x5AD960", Offset = "0x5AC560", VA = "0x1805AD960")]
		private bool _CheckTargetTrap(GridPosition pos)
		{
			return default(bool);
		}

		// Token: 0x0600E4C9 RID: 58569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4C9")]
		[Address(RVA = "0x5AEDD0", Offset = "0x5AD9D0", VA = "0x1805AEDD0")]
		public TrapCompositeManager()
		{
		}

		// Token: 0x0600E4CA RID: 58570 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E4CA")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0600E4CB RID: 58571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4CB")]
		[Address(RVA = "0x550C00", Offset = "0x54F800", VA = "0x180550C00")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x0600E4CC RID: 58572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4CC")]
		[Address(RVA = "0x550BF0", Offset = "0x54F7F0", VA = "0x180550BF0")]
		private void <>xLuaBaseProxy_OnEnvDestroy()
		{
		}

		// Token: 0x0400FC2A RID: 64554
		[Token(Token = "0x400FC2A")]
		private const SharedConsts.Direction DEFAULT_COMPOSITE_DIRECTION = SharedConsts.Direction.RIGHT;

		// Token: 0x0400FC2B RID: 64555
		[Token(Token = "0x400FC2B")]
		private const SharedConsts.Direction ROTATED_COMPOSITE_DIRECTION = SharedConsts.Direction.UP;

		// Token: 0x0400FC2C RID: 64556
		[Token(Token = "0x400FC2C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _filterTag;

		// Token: 0x0400FC2D RID: 64557
		[Token(Token = "0x400FC2D")]
		[FieldOffset(Offset = "0x30")]
		private List<ObjectPtr<Character>> m_removedTraps;

		// Token: 0x0400FC2E RID: 64558
		[Token(Token = "0x400FC2E")]
		[FieldOffset(Offset = "0x38")]
		private List<ObjectPtr<Character>> m_compositeCandidates;

		// Token: 0x0400FC2F RID: 64559
		[Token(Token = "0x400FC2F")]
		[FieldOffset(Offset = "0x40")]
		private ObjectPtr<Character> m_lastTrap;

		// Token: 0x0400FC30 RID: 64560
		[Token(Token = "0x400FC30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400FC31 RID: 64561
		[Token(Token = "0x400FC31")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400FC32 RID: 64562
		[Token(Token = "0x400FC32")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnvDestroy;

		// Token: 0x0400FC33 RID: 64563
		[Token(Token = "0x400FC33")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400FC34 RID: 64564
		[Token(Token = "0x400FC34")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CheckTrapValid;

		// Token: 0x0400FC35 RID: 64565
		[Token(Token = "0x400FC35")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__FindCompositeTrap;

		// Token: 0x0400FC36 RID: 64566
		[Token(Token = "0x400FC36")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__FilterCompositeTrap;

		// Token: 0x0400FC37 RID: 64567
		[Token(Token = "0x400FC37")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckAllTrapsInRect;

		// Token: 0x0400FC38 RID: 64568
		[Token(Token = "0x400FC38")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CompositeTraps;

		// Token: 0x0400FC39 RID: 64569
		[Token(Token = "0x400FC39")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckTargetTrap;

		// Token: 0x0400FC3A RID: 64570
		[Token(Token = "0x400FC3A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
