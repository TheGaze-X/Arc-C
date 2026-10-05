using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C41 RID: 11329
	[Token(Token = "0x2002C41")]
	public class RacingOnModeSwitchTrigger : RacingBaseEventListener, IBuffSource
	{
		// Token: 0x17002A0A RID: 10762
		// (get) Token: 0x06013222 RID: 78370 RVA: 0x00074AA8 File Offset: 0x00072CA8
		[Token(Token = "0x17002A0A")]
		protected override RacingEnemy.RacingEvent racingEvent
		{
			[Token(Token = "0x6013222")]
			[Address(RVA = "0xB23A60", Offset = "0xB22660", VA = "0x180B23A60", Slot = "16")]
			get
			{
				return RacingEnemy.RacingEvent.ON_SWITCH_RACING_MODE;
			}
		}

		// Token: 0x06013223 RID: 78371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013223")]
		[Address(RVA = "0xB23700", Offset = "0xB22300", VA = "0x180B23700", Slot = "20")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06013224 RID: 78372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013224")]
		[Address(RVA = "0xB23790", Offset = "0xB22390", VA = "0x180B23790", Slot = "19")]
		protected override void OnRacingEvent(object arg)
		{
		}

		// Token: 0x06013225 RID: 78373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013225")]
		[Address(RVA = "0xB23990", Offset = "0xB22590", VA = "0x180B23990")]
		public RacingOnModeSwitchTrigger()
		{
		}

		// Token: 0x06013226 RID: 78374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013226")]
		[Address(RVA = "0xB225F0", Offset = "0xB211F0", VA = "0x180B225F0")]
		private void <>xLuaBaseProxy_OnRacingEvent(object P0)
		{
		}

		// Token: 0x040159C2 RID: 88514
		[Token(Token = "0x40159C2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BuffData[] _buffs;

		// Token: 0x040159C3 RID: 88515
		[Token(Token = "0x40159C3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RacingEnemy.RacingMode _mode;

		// Token: 0x040159C4 RID: 88516
		[Token(Token = "0x40159C4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_racingEvent;

		// Token: 0x040159C5 RID: 88517
		[Token(Token = "0x40159C5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x040159C6 RID: 88518
		[Token(Token = "0x40159C6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRacingEvent;

		// Token: 0x040159C7 RID: 88519
		[Token(Token = "0x40159C7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
