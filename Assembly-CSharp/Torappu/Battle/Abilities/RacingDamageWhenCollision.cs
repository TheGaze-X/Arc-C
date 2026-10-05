using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C40 RID: 11328
	[Token(Token = "0x2002C40")]
	public class RacingDamageWhenCollision : RacingBaseEventListener
	{
		// Token: 0x17002A09 RID: 10761
		// (get) Token: 0x0601321C RID: 78364 RVA: 0x00074A90 File Offset: 0x00072C90
		[Token(Token = "0x17002A09")]
		protected override RacingEnemy.RacingEvent racingEvent
		{
			[Token(Token = "0x601321C")]
			[Address(RVA = "0xB236A0", Offset = "0xB222A0", VA = "0x180B236A0", Slot = "16")]
			get
			{
				return RacingEnemy.RacingEvent.ON_SWITCH_RACING_MODE;
			}
		}

		// Token: 0x0601321D RID: 78365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601321D")]
		[Address(RVA = "0xB23470", Offset = "0xB22070", VA = "0x180B23470", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0601321E RID: 78366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601321E")]
		[Address(RVA = "0xB23180", Offset = "0xB21D80", VA = "0x180B23180", Slot = "19")]
		protected override void OnRacingEvent(object arg)
		{
		}

		// Token: 0x0601321F RID: 78367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601321F")]
		[Address(RVA = "0xB235D0", Offset = "0xB221D0", VA = "0x180B235D0")]
		public RacingDamageWhenCollision()
		{
		}

		// Token: 0x06013220 RID: 78368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013220")]
		[Address(RVA = "0xB23060", Offset = "0xB21C60", VA = "0x180B23060")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x06013221 RID: 78369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013221")]
		[Address(RVA = "0xB225F0", Offset = "0xB211F0", VA = "0x180B225F0")]
		private void <>xLuaBaseProxy_OnRacingEvent(object P0)
		{
		}

		// Token: 0x040159BA RID: 88506
		[Token(Token = "0x40159BA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private DamageType _damageType;

		// Token: 0x040159BB RID: 88507
		[Token(Token = "0x40159BB")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private bool _scaleByForce;

		// Token: 0x040159BC RID: 88508
		[Token(Token = "0x40159BC")]
		[FieldOffset(Offset = "0x38")]
		private FP m_damageValue;

		// Token: 0x040159BD RID: 88509
		[Token(Token = "0x40159BD")]
		[FieldOffset(Offset = "0x40")]
		private FP m_damageScale;

		// Token: 0x040159BE RID: 88510
		[Token(Token = "0x40159BE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_racingEvent;

		// Token: 0x040159BF RID: 88511
		[Token(Token = "0x40159BF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040159C0 RID: 88512
		[Token(Token = "0x40159C0")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRacingEvent;

		// Token: 0x040159C1 RID: 88513
		[Token(Token = "0x40159C1")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
