using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x02002353 RID: 9043
	[Token(Token = "0x2002353")]
	public class UnitBornFinishManager : GlobalEnvSystem.EnvManager
	{
		// Token: 0x17001C9F RID: 7327
		// (get) Token: 0x0600E4CD RID: 58573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001C9F")]
		public override IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> eventGroups
		{
			[Token(Token = "0x600E4CD")]
			[Address(RVA = "0x5AF590", Offset = "0x5AE190", VA = "0x1805AF590", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600E4CE RID: 58574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4CE")]
		[Address(RVA = "0x5AF160", Offset = "0x5ADD60", VA = "0x1805AF160")]
		private void _OnUnitBorn(object arg)
		{
		}

		// Token: 0x0600E4CF RID: 58575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4CF")]
		[Address(RVA = "0x5AF2A0", Offset = "0x5ADEA0", VA = "0x1805AF2A0")]
		private void _OnUnitFinish(object arg)
		{
		}

		// Token: 0x0600E4D0 RID: 58576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4D0")]
		[Address(RVA = "0x5AF3E0", Offset = "0x5ADFE0", VA = "0x1805AF3E0")]
		private void _OnUnitReborn(object arg)
		{
		}

		// Token: 0x0600E4D1 RID: 58577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600E4D1")]
		[Address(RVA = "0x5AF530", Offset = "0x5AE130", VA = "0x1805AF530")]
		public UnitBornFinishManager()
		{
		}

		// Token: 0x0600E4D2 RID: 58578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600E4D2")]
		[Address(RVA = "0x550C20", Offset = "0x54F820", VA = "0x180550C20")]
		private IEnumerable<GlobalEnvSystem.EnvManager.BattleEventGroup> <>xLuaBaseProxy_get_eventGroups()
		{
			return null;
		}

		// Token: 0x0400FC3B RID: 64571
		[Token(Token = "0x400FC3B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string _bornEvent;

		// Token: 0x0400FC3C RID: 64572
		[Token(Token = "0x400FC3C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string _finishEvent;

		// Token: 0x0400FC3D RID: 64573
		[Token(Token = "0x400FC3D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string _rebornEvent;

		// Token: 0x0400FC3E RID: 64574
		[Token(Token = "0x400FC3E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_eventGroups;

		// Token: 0x0400FC3F RID: 64575
		[Token(Token = "0x400FC3F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnUnitBorn;

		// Token: 0x0400FC40 RID: 64576
		[Token(Token = "0x400FC40")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnUnitFinish;

		// Token: 0x0400FC41 RID: 64577
		[Token(Token = "0x400FC41")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnUnitReborn;

		// Token: 0x0400FC42 RID: 64578
		[Token(Token = "0x400FC42")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
