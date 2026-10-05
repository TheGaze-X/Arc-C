using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C42 RID: 11330
	[Token(Token = "0x2002C42")]
	public class RacingOutputForceModifier : RacingBaseEventListener
	{
		// Token: 0x17002A0B RID: 10763
		// (get) Token: 0x06013227 RID: 78375 RVA: 0x00074AC0 File Offset: 0x00072CC0
		[Token(Token = "0x17002A0B")]
		protected override RacingEnemy.RacingEvent racingEvent
		{
			[Token(Token = "0x6013227")]
			[Address(RVA = "0xB23CE0", Offset = "0xB228E0", VA = "0x180B23CE0", Slot = "16")]
			get
			{
				return RacingEnemy.RacingEvent.ON_SWITCH_RACING_MODE;
			}
		}

		// Token: 0x06013228 RID: 78376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013228")]
		[Address(RVA = "0xB23B90", Offset = "0xB22790", VA = "0x180B23B90", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x06013229 RID: 78377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013229")]
		[Address(RVA = "0xB23AC0", Offset = "0xB226C0", VA = "0x180B23AC0", Slot = "19")]
		protected override void OnRacingEvent(object arg)
		{
		}

		// Token: 0x0601322A RID: 78378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601322A")]
		[Address(RVA = "0xB23C40", Offset = "0xB22840", VA = "0x180B23C40")]
		public RacingOutputForceModifier()
		{
		}

		// Token: 0x0601322B RID: 78379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601322B")]
		[Address(RVA = "0xB23060", Offset = "0xB21C60", VA = "0x180B23060")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0601322C RID: 78380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601322C")]
		[Address(RVA = "0xB225F0", Offset = "0xB211F0", VA = "0x180B225F0")]
		private void <>xLuaBaseProxy_OnRacingEvent(object P0)
		{
		}

		// Token: 0x040159C8 RID: 88520
		[Token(Token = "0x40159C8")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private int _forceLevelAddition;

		// Token: 0x040159C9 RID: 88521
		[Token(Token = "0x40159C9")]
		[FieldOffset(Offset = "0x34")]
		private int m_forceLevelAdd;

		// Token: 0x040159CA RID: 88522
		[Token(Token = "0x40159CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_racingEvent;

		// Token: 0x040159CB RID: 88523
		[Token(Token = "0x40159CB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040159CC RID: 88524
		[Token(Token = "0x40159CC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnRacingEvent;

		// Token: 0x040159CD RID: 88525
		[Token(Token = "0x40159CD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
