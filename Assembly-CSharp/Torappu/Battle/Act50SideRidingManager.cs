using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002302 RID: 8962
	[Token(Token = "0x2002302")]
	public class Act50SideRidingManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C6F RID: 7279
		// (get) Token: 0x0600E25E RID: 57950 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C6F")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E25E")]
			[Address(RVA = "0x55BDA0", Offset = "0x55A9A0", VA = "0x18055BDA0", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E25F RID: 57951 RVA: 0x00052248 File Offset: 0x00050448
		[Token(Token = "0x600E25F")]
		[Address(RVA = "0x55B7C0", Offset = "0x55A3C0", VA = "0x18055B7C0")]
		public bool TryAddRidingValue(Enemy enemy, FP value)
		{
			return default(bool);
		}

		// Token: 0x0600E260 RID: 57952 RVA: 0x00052260 File Offset: 0x00050460
		[Token(Token = "0x600E260")]
		[Address(RVA = "0x55B6C0", Offset = "0x55A2C0", VA = "0x18055B6C0")]
		public bool TriggerRiding(Enemy enemy)
		{
			return default(bool);
		}

		// Token: 0x0600E261 RID: 57953 RVA: 0x00052278 File Offset: 0x00050478
		[Token(Token = "0x600E261")]
		[Address(RVA = "0x55B4A0", Offset = "0x55A0A0", VA = "0x18055B4A0")]
		public bool FinishRiding(Enemy enemy)
		{
			return default(bool);
		}

		// Token: 0x0600E262 RID: 57954 RVA: 0x00052290 File Offset: 0x00050490
		[Token(Token = "0x600E262")]
		[Address(RVA = "0x55B5A0", Offset = "0x55A1A0", VA = "0x18055B5A0")]
		public bool SetRidingCumulatingValid(Enemy enemy, bool isValid)
		{
			return default(bool);
		}

		// Token: 0x0600E263 RID: 57955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E263")]
		[Address(RVA = "0x55B8E0", Offset = "0x55A4E0", VA = "0x18055B8E0")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600E264 RID: 57956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E264")]
		[Address(RVA = "0x55BBE0", Offset = "0x55A7E0", VA = "0x18055BBE0")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x0600E265 RID: 57957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E265")]
		[Address(RVA = "0x55BD40", Offset = "0x55A940", VA = "0x18055BD40")]
		public Act50SideRidingManager()
		{
		}

		// Token: 0x0600E266 RID: 57958 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E266")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0400F815 RID: 63509
		[Token(Token = "0x400F815")]
		[FieldOffset(Offset = "0x28")]
		private Dictionary<Enemy, Mh2RidingHudPluginTalent> m_rideableEnemyDict;

		// Token: 0x0400F816 RID: 63510
		[Token(Token = "0x400F816")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400F817 RID: 63511
		[Token(Token = "0x400F817")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_TryAddRidingValue;

		// Token: 0x0400F818 RID: 63512
		[Token(Token = "0x400F818")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TriggerRiding;

		// Token: 0x0400F819 RID: 63513
		[Token(Token = "0x400F819")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_FinishRiding;

		// Token: 0x0400F81A RID: 63514
		[Token(Token = "0x400F81A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetRidingCumulatingValid;

		// Token: 0x0400F81B RID: 63515
		[Token(Token = "0x400F81B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400F81C RID: 63516
		[Token(Token = "0x400F81C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x0400F81D RID: 63517
		[Token(Token = "0x400F81D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
