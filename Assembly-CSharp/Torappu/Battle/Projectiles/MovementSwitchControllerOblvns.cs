using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029E3 RID: 10723
	[Token(Token = "0x20029E3")]
	public class MovementSwitchControllerOblvns : MovementSwitchController
	{
		// Token: 0x17002736 RID: 10038
		// (get) Token: 0x06011C71 RID: 72817 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17002736")]
		private EnumIntDictionary<MovementSwitchControllerOblvns.MoveState, Action> moveStateActions
		{
			[Token(Token = "0x6011C71")]
			[Address(RVA = "0x9A1560", Offset = "0x9A0160", VA = "0x1809A1560")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011C72 RID: 72818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C72")]
		[Address(RVA = "0x99FCD0", Offset = "0x99E8D0", VA = "0x18099FCD0", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile, GroupedMovement groupedMovement)
		{
		}

		// Token: 0x06011C73 RID: 72819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C73")]
		[Address(RVA = "0x9A0270", Offset = "0x99EE70", VA = "0x1809A0270", Slot = "6")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011C74 RID: 72820 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C74")]
		[Address(RVA = "0x9A01D0", Offset = "0x99EDD0", VA = "0x1809A01D0", Slot = "5")]
		public override void OnStop()
		{
		}

		// Token: 0x06011C75 RID: 72821 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C75")]
		[Address(RVA = "0x9A0F40", Offset = "0x99FB40", VA = "0x1809A0F40")]
		private void _TryTraceAndSwitchToMove()
		{
		}

		// Token: 0x06011C76 RID: 72822 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C76")]
		[Address(RVA = "0x9A0BA0", Offset = "0x99F7A0", VA = "0x1809A0BA0")]
		private void _KeepMoveIfTargetValid()
		{
		}

		// Token: 0x06011C77 RID: 72823 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C77")]
		[Address(RVA = "0x9A0960", Offset = "0x99F560", VA = "0x1809A0960")]
		private void _HitPassByByTimerAndStopAfterDelay()
		{
		}

		// Token: 0x06011C78 RID: 72824 RVA: 0x0006CDB0 File Offset: 0x0006AFB0
		[Token(Token = "0x6011C78")]
		[Address(RVA = "0x9A05C0", Offset = "0x99F1C0", VA = "0x1809A05C0")]
		private ObjectPtr<Entity> _GetNextTraceTarget()
		{
			return default(ObjectPtr<Entity>);
		}

		// Token: 0x06011C79 RID: 72825 RVA: 0x0006CDC8 File Offset: 0x0006AFC8
		[Token(Token = "0x6011C79")]
		[Address(RVA = "0x9A0AB0", Offset = "0x99F6B0", VA = "0x1809A0AB0")]
		private bool _InNotTraceTime()
		{
			return default(bool);
		}

		// Token: 0x06011C7A RID: 72826 RVA: 0x0006CDE0 File Offset: 0x0006AFE0
		[Token(Token = "0x6011C7A")]
		[Address(RVA = "0x9A0C60", Offset = "0x99F860", VA = "0x1809A0C60")]
		private bool _SwithToSlideIfNecessary()
		{
			return default(bool);
		}

		// Token: 0x06011C7B RID: 72827 RVA: 0x0006CDF8 File Offset: 0x0006AFF8
		[Token(Token = "0x6011C7B")]
		[Address(RVA = "0x9A0D80", Offset = "0x99F980", VA = "0x1809A0D80")]
		private bool _TryEliminateSelfIfSourceNotValid()
		{
			return default(bool);
		}

		// Token: 0x06011C7C RID: 72828 RVA: 0x0006CE10 File Offset: 0x0006B010
		[Token(Token = "0x6011C7C")]
		[Address(RVA = "0x9A1140", Offset = "0x99FD40", VA = "0x1809A1140")]
		private bool _ValidateHitTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x06011C7D RID: 72829 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C7D")]
		[Address(RVA = "0x9A13B0", Offset = "0x99FFB0", VA = "0x1809A13B0")]
		public MovementSwitchControllerOblvns()
		{
		}

		// Token: 0x06011C7F RID: 72831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C7F")]
		[Address(RVA = "0x99E3D0", Offset = "0x99CFD0", VA = "0x18099E3D0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2, GroupedMovement P3)
		{
		}

		// Token: 0x06011C80 RID: 72832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C80")]
		[Address(RVA = "0x99E3E0", Offset = "0x99CFE0", VA = "0x18099E3E0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011C81 RID: 72833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C81")]
		[Address(RVA = "0x9A0440", Offset = "0x99F040", VA = "0x1809A0440")]
		private void <>xLuaBaseProxy_OnStop()
		{
		}

		// Token: 0x04013F48 RID: 81736
		[Token(Token = "0x4013F48")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TargetSelector _selector;

		// Token: 0x04013F49 RID: 81737
		[Token(Token = "0x4013F49")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private bool _traceThoughAndHitPassby;

		// Token: 0x04013F4A RID: 81738
		[Token(Token = "0x4013F4A")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private string _hitPassbyTimeKey;

		// Token: 0x04013F4B RID: 81739
		[Token(Token = "0x4013F4B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private float _hitPassbyTime;

		// Token: 0x04013F4C RID: 81740
		[Token(Token = "0x4013F4C")]
		[FieldOffset(Offset = "0x5C")]
		[SerializeField]
		private bool _useSwitchToTracingTime;

		// Token: 0x04013F4D RID: 81741
		[Token(Token = "0x4013F4D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private float _switchToTracingTime;

		// Token: 0x04013F4E RID: 81742
		[Token(Token = "0x4013F4E")]
		[FieldOffset(Offset = "0x64")]
		[SerializeField]
		private float _tickTime;

		// Token: 0x04013F4F RID: 81743
		[Token(Token = "0x4013F4F")]
		[FieldOffset(Offset = "0x68")]
		private List<ObjectPtr<Entity>> m_hitTargets;

		// Token: 0x04013F50 RID: 81744
		[Token(Token = "0x4013F50")]
		[FieldOffset(Offset = "0x70")]
		private ObjectPtr<Entity> m_target;

		// Token: 0x04013F51 RID: 81745
		[Token(Token = "0x4013F51")]
		[FieldOffset(Offset = "0x80")]
		private MovementSwitchControllerOblvns.MoveState m_moveState;

		// Token: 0x04013F52 RID: 81746
		[Token(Token = "0x4013F52")]
		[FieldOffset(Offset = "0x88")]
		private FP m_hitPassbyTime;

		// Token: 0x04013F53 RID: 81747
		[Token(Token = "0x4013F53")]
		[FieldOffset(Offset = "0x90")]
		private FP m_hitPassbyStartTime;

		// Token: 0x04013F54 RID: 81748
		[Token(Token = "0x4013F54")]
		[FieldOffset(Offset = "0x98")]
		private FP m_passedTime;

		// Token: 0x04013F55 RID: 81749
		[Token(Token = "0x4013F55")]
		[FieldOffset(Offset = "0xA0")]
		private PrecisePeriodicTimer m_tickTimer;

		// Token: 0x04013F56 RID: 81750
		[Token(Token = "0x4013F56")]
		[FieldOffset(Offset = "0xA8")]
		private EnumIntDictionary<MovementSwitchControllerOblvns.MoveState, Action> m_moveStateActions;

		// Token: 0x04013F57 RID: 81751
		[Token(Token = "0x4013F57")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_moveStateActions;

		// Token: 0x04013F58 RID: 81752
		[Token(Token = "0x4013F58")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013F59 RID: 81753
		[Token(Token = "0x4013F59")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013F5A RID: 81754
		[Token(Token = "0x4013F5A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnStop;

		// Token: 0x04013F5B RID: 81755
		[Token(Token = "0x4013F5B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryTraceAndSwitchToMove;

		// Token: 0x04013F5C RID: 81756
		[Token(Token = "0x4013F5C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__KeepMoveIfTargetValid;

		// Token: 0x04013F5D RID: 81757
		[Token(Token = "0x4013F5D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__HitPassByByTimerAndStopAfterDelay;

		// Token: 0x04013F5E RID: 81758
		[Token(Token = "0x4013F5E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GetNextTraceTarget;

		// Token: 0x04013F5F RID: 81759
		[Token(Token = "0x4013F5F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InNotTraceTime;

		// Token: 0x04013F60 RID: 81760
		[Token(Token = "0x4013F60")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__SwithToSlideIfNecessary;

		// Token: 0x04013F61 RID: 81761
		[Token(Token = "0x4013F61")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryEliminateSelfIfSourceNotValid;

		// Token: 0x04013F62 RID: 81762
		[Token(Token = "0x4013F62")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ValidateHitTarget;

		// Token: 0x04013F63 RID: 81763
		[Token(Token = "0x4013F63")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020029E4 RID: 10724
		[Token(Token = "0x20029E4")]
		private enum MoveState
		{
			// Token: 0x04013F65 RID: 81765
			[Token(Token = "0x4013F65")]
			NONE,
			// Token: 0x04013F66 RID: 81766
			[Token(Token = "0x4013F66")]
			TRACING,
			// Token: 0x04013F67 RID: 81767
			[Token(Token = "0x4013F67")]
			STRAIGHT_MOVE_AND_SELECT,
			// Token: 0x04013F68 RID: 81768
			[Token(Token = "0x4013F68")]
			SLIDE_AND_HIT_PASSBY
		}
	}
}
