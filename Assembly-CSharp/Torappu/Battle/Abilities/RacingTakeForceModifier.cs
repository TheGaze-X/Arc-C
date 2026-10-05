using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C43 RID: 11331
	[Token(Token = "0x2002C43")]
	public class RacingTakeForceModifier : RacingBaseEventListener
	{
		// Token: 0x17002A0C RID: 10764
		// (get) Token: 0x0601322D RID: 78381 RVA: 0x00074AD8 File Offset: 0x00072CD8
		[Token(Token = "0x17002A0C")]
		protected override RacingEnemy.RacingEvent racingEvent
		{
			[Token(Token = "0x601322D")]
			[Address(RVA = "0xB23F60", Offset = "0xB22B60", VA = "0x180B23F60", Slot = "16")]
			get
			{
				return RacingEnemy.RacingEvent.ON_SWITCH_RACING_MODE;
			}
		}

		// Token: 0x0601322E RID: 78382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601322E")]
		[Address(RVA = "0xB23E10", Offset = "0xB22A10", VA = "0x180B23E10", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0601322F RID: 78383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601322F")]
		[Address(RVA = "0xB23D40", Offset = "0xB22940", VA = "0x180B23D40", Slot = "19")]
		protected override void OnRacingEvent(object arg)
		{
		}

		// Token: 0x06013230 RID: 78384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013230")]
		[Address(RVA = "0xB23EC0", Offset = "0xB22AC0", VA = "0x180B23EC0")]
		public RacingTakeForceModifier()
		{
		}

		// Token: 0x06013231 RID: 78385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013231")]
		[Address(RVA = "0xB23060", Offset = "0xB21C60", VA = "0x180B23060")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x06013232 RID: 78386 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013232")]
		[Address(RVA = "0xB225F0", Offset = "0xB211F0", VA = "0x180B225F0")]
		private void <>xLuaBaseProxy_OnRacingEvent(object P0)
		{
		}

		// Token: 0x040159CE RID: 88526
		[Token(Token = "0x40159CE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _forceLevelAddition;

		// Token: 0x040159CF RID: 88527
		[Token(Token = "0x40159CF")]
		[FieldOffset(Offset = "0x34")]
		private int m_forceLevelAdd;

		// Token: 0x040159D0 RID: 88528
		[Token(Token = "0x40159D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_racingEvent;

		// Token: 0x040159D1 RID: 88529
		[Token(Token = "0x40159D1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040159D2 RID: 88530
		[Token(Token = "0x40159D2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRacingEvent;

		// Token: 0x040159D3 RID: 88531
		[Token(Token = "0x40159D3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
