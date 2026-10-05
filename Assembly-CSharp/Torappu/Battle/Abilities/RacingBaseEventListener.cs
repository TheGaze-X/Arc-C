using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C3E RID: 11326
	[Token(Token = "0x2002C3E")]
	public abstract class RacingBaseEventListener : AbilityStandard.Behaviour
	{
		// Token: 0x17002A06 RID: 10758
		// (get) Token: 0x0601320C RID: 78348 RVA: 0x00074A60 File Offset: 0x00072C60
		[Token(Token = "0x17002A06")]
		protected ObjectPtr<RacingEnemy> racingEnemy
		{
			[Token(Token = "0x601320C")]
			[Address(RVA = "0xB22DE0", Offset = "0xB219E0", VA = "0x180B22DE0")]
			get
			{
				return default(ObjectPtr<RacingEnemy>);
			}
		}

		// Token: 0x17002A07 RID: 10759
		// (get) Token: 0x0601320D RID: 78349
		[Token(Token = "0x17002A07")]
		protected abstract RacingEnemy.RacingEvent racingEvent { [Token(Token = "0x601320D")] get; }

		// Token: 0x0601320E RID: 78350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601320E")]
		[Address(RVA = "0xB22C70", Offset = "0xB21870", VA = "0x180B22C70", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x0601320F RID: 78351 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601320F")]
		[Address(RVA = "0xB22BA0", Offset = "0xB217A0", VA = "0x180B22BA0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06013210 RID: 78352 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013210")]
		[Address(RVA = "0xB228C0", Offset = "0xB214C0", VA = "0x180B228C0", Slot = "17")]
		protected virtual void OnAttached()
		{
		}

		// Token: 0x06013211 RID: 78353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013211")]
		[Address(RVA = "0xB22A30", Offset = "0xB21630", VA = "0x180B22A30", Slot = "18")]
		protected virtual void OnDetached()
		{
		}

		// Token: 0x06013212 RID: 78354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013212")]
		[Address(RVA = "0xB225F0", Offset = "0xB211F0", VA = "0x180B225F0", Slot = "19")]
		protected virtual void OnRacingEvent(object arg)
		{
		}

		// Token: 0x06013213 RID: 78355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013213")]
		[Address(RVA = "0xB22D80", Offset = "0xB21980", VA = "0x180B22D80")]
		protected RacingBaseEventListener()
		{
		}

		// Token: 0x06013214 RID: 78356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013214")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x06013215 RID: 78357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013215")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x040159AB RID: 88491
		[Token(Token = "0x40159AB")]
		[FieldOffset(Offset = "0x20")]
		private ObjectPtr<RacingEnemy> m_racingEnemy;

		// Token: 0x040159AC RID: 88492
		[Token(Token = "0x40159AC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_racingEnemy;

		// Token: 0x040159AD RID: 88493
		[Token(Token = "0x40159AD")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x040159AE RID: 88494
		[Token(Token = "0x40159AE")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x040159AF RID: 88495
		[Token(Token = "0x40159AF")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x040159B0 RID: 88496
		[Token(Token = "0x40159B0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x040159B1 RID: 88497
		[Token(Token = "0x40159B1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnRacingEvent;

		// Token: 0x040159B2 RID: 88498
		[Token(Token = "0x40159B2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
