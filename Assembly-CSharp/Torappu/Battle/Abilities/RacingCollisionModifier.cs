using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C3F RID: 11327
	[Token(Token = "0x2002C3F")]
	public class RacingCollisionModifier : RacingBaseEventListener
	{
		// Token: 0x17002A08 RID: 10760
		// (get) Token: 0x06013216 RID: 78358 RVA: 0x00074A78 File Offset: 0x00072C78
		[Token(Token = "0x17002A08")]
		protected override RacingEnemy.RacingEvent racingEvent
		{
			[Token(Token = "0x6013216")]
			[Address(RVA = "0xB23120", Offset = "0xB21D20", VA = "0x180B23120", Slot = "16")]
			get
			{
				return RacingEnemy.RacingEvent.ON_SWITCH_RACING_MODE;
			}
		}

		// Token: 0x06013217 RID: 78359 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013217")]
		[Address(RVA = "0xB22F70", Offset = "0xB21B70", VA = "0x180B22F70", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x06013218 RID: 78360 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013218")]
		[Address(RVA = "0xB22E60", Offset = "0xB21A60", VA = "0x180B22E60", Slot = "19")]
		protected override void OnRacingEvent(object arg)
		{
		}

		// Token: 0x06013219 RID: 78361 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013219")]
		[Address(RVA = "0xB23070", Offset = "0xB21C70", VA = "0x180B23070")]
		public RacingCollisionModifier()
		{
		}

		// Token: 0x0601321A RID: 78362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601321A")]
		[Address(RVA = "0xB23060", Offset = "0xB21C60", VA = "0x180B23060")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0601321B RID: 78363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601321B")]
		[Address(RVA = "0xB225F0", Offset = "0xB211F0", VA = "0x180B225F0")]
		private void <>xLuaBaseProxy_OnRacingEvent(object P0)
		{
		}

		// Token: 0x040159B3 RID: 88499
		[Token(Token = "0x40159B3")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _speedLossScaler;

		// Token: 0x040159B4 RID: 88500
		[Token(Token = "0x40159B4")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _isCollisionWithTile;

		// Token: 0x040159B5 RID: 88501
		[Token(Token = "0x40159B5")]
		[FieldOffset(Offset = "0x38")]
		private FP m_speedLossScaler;

		// Token: 0x040159B6 RID: 88502
		[Token(Token = "0x40159B6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_racingEvent;

		// Token: 0x040159B7 RID: 88503
		[Token(Token = "0x40159B7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040159B8 RID: 88504
		[Token(Token = "0x40159B8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRacingEvent;

		// Token: 0x040159B9 RID: 88505
		[Token(Token = "0x40159B9")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
