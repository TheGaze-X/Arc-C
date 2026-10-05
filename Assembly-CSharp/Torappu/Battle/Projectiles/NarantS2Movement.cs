using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029E5 RID: 10725
	[Token(Token = "0x20029E5")]
	public class NarantS2Movement : AdvancedMovement
	{
		// Token: 0x06011C82 RID: 72834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C82")]
		[Address(RVA = "0x9A2290", Offset = "0x9A0E90", VA = "0x1809A2290", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011C83 RID: 72835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C83")]
		[Address(RVA = "0x9A24E0", Offset = "0x9A10E0", VA = "0x1809A24E0", Slot = "6")]
		public override void OnProjectileBorn()
		{
		}

		// Token: 0x06011C84 RID: 72836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C84")]
		[Address(RVA = "0x9A25A0", Offset = "0x9A11A0", VA = "0x1809A25A0", Slot = "5")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x06011C85 RID: 72837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C85")]
		[Address(RVA = "0x9A21F0", Offset = "0x9A0DF0", VA = "0x1809A21F0", Slot = "19")]
		protected override void DoCheckReached()
		{
		}

		// Token: 0x06011C86 RID: 72838 RVA: 0x0006CE40 File Offset: 0x0006B040
		[Token(Token = "0x6011C86")]
		[Address(RVA = "0x9A20E0", Offset = "0x9A0CE0", VA = "0x1809A20E0", Slot = "22")]
		protected override bool DoCheckReachedInternal()
		{
			return default(bool);
		}

		// Token: 0x06011C87 RID: 72839 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C87")]
		[Address(RVA = "0x9A2C50", Offset = "0x9A1850", VA = "0x1809A2C50")]
		private void _SwitchToNextMoveState(NarantS2Movement.MoveState newState)
		{
		}

		// Token: 0x06011C88 RID: 72840 RVA: 0x0006CE58 File Offset: 0x0006B058
		[Token(Token = "0x6011C88")]
		[Address(RVA = "0x9A2820", Offset = "0x9A1420", VA = "0x1809A2820")]
		private Vector3 _CalculateNextPosition(float deltaTime, bool forceToResetDir)
		{
			return default(Vector3);
		}

		// Token: 0x06011C89 RID: 72841 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C89")]
		[Address(RVA = "0x9A2EF0", Offset = "0x9A1AF0", VA = "0x1809A2EF0")]
		public NarantS2Movement()
		{
		}

		// Token: 0x06011C8A RID: 72842 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C8A")]
		[Address(RVA = "0x9936C0", Offset = "0x9922C0", VA = "0x1809936C0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011C8B RID: 72843 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C8B")]
		[Address(RVA = "0x94DC40", Offset = "0x94C840", VA = "0x18094DC40")]
		private void <>xLuaBaseProxy_OnProjectileBorn()
		{
		}

		// Token: 0x06011C8C RID: 72844 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C8C")]
		[Address(RVA = "0x994070", Offset = "0x992C70", VA = "0x180994070")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011C8D RID: 72845 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011C8D")]
		[Address(RVA = "0x998220", Offset = "0x996E20", VA = "0x180998220")]
		private void <>xLuaBaseProxy_DoCheckReached()
		{
		}

		// Token: 0x06011C8E RID: 72846 RVA: 0x0006CE70 File Offset: 0x0006B070
		[Token(Token = "0x6011C8E")]
		[Address(RVA = "0x9989F0", Offset = "0x9975F0", VA = "0x1809989F0")]
		private bool <>xLuaBaseProxy_DoCheckReachedInternal()
		{
			return default(bool);
		}

		// Token: 0x04013F69 RID: 81769
		[Token(Token = "0x4013F69")]
		private const float DIRECTION_ZERO_TOLERANCE = 0.01f;

		// Token: 0x04013F6A RID: 81770
		[Token(Token = "0x4013F6A")]
		private const string COMEBACK_AUDIO = "narant_projectile_comeback";

		// Token: 0x04013F6B RID: 81771
		[Token(Token = "0x4013F6B")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		private string _moveAheadTimeKey;

		// Token: 0x04013F6C RID: 81772
		[Token(Token = "0x4013F6C")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		private float _moveAheadTime;

		// Token: 0x04013F6D RID: 81773
		[Token(Token = "0x4013F6D")]
		[FieldOffset(Offset = "0x14C")]
		[SerializeField]
		private float _moveAheadSpeed;

		// Token: 0x04013F6E RID: 81774
		[Token(Token = "0x4013F6E")]
		[FieldOffset(Offset = "0x150")]
		private float m_moveAheadTime;

		// Token: 0x04013F6F RID: 81775
		[Token(Token = "0x4013F6F")]
		[FieldOffset(Offset = "0x154")]
		private NarantS2Movement.MoveState m_moveState;

		// Token: 0x04013F70 RID: 81776
		[Token(Token = "0x4013F70")]
		[FieldOffset(Offset = "0x158")]
		private PeriodicTimer m_aheadStateTimer;

		// Token: 0x04013F71 RID: 81777
		[Token(Token = "0x4013F71")]
		[FieldOffset(Offset = "0x160")]
		private PeriodicTimer m_aheadBackStateTimer;

		// Token: 0x04013F72 RID: 81778
		[Token(Token = "0x4013F72")]
		[FieldOffset(Offset = "0x168")]
		private NarantS2HitBehaviour m_hitBehaviour;

		// Token: 0x04013F73 RID: 81779
		[Token(Token = "0x4013F73")]
		[FieldOffset(Offset = "0x170")]
		private Animator m_mainEffectAnimator;

		// Token: 0x04013F74 RID: 81780
		[Token(Token = "0x4013F74")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013F75 RID: 81781
		[Token(Token = "0x4013F75")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnProjectileBorn;

		// Token: 0x04013F76 RID: 81782
		[Token(Token = "0x4013F76")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013F77 RID: 81783
		[Token(Token = "0x4013F77")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoCheckReached;

		// Token: 0x04013F78 RID: 81784
		[Token(Token = "0x4013F78")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoCheckReachedInternal;

		// Token: 0x04013F79 RID: 81785
		[Token(Token = "0x4013F79")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__SwitchToNextMoveState;

		// Token: 0x04013F7A RID: 81786
		[Token(Token = "0x4013F7A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CalculateNextPosition;

		// Token: 0x04013F7B RID: 81787
		[Token(Token = "0x4013F7B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020029E6 RID: 10726
		[Token(Token = "0x20029E6")]
		private enum MoveState
		{
			// Token: 0x04013F7D RID: 81789
			[Token(Token = "0x4013F7D")]
			NORMAL,
			// Token: 0x04013F7E RID: 81790
			[Token(Token = "0x4013F7E")]
			AHEAD,
			// Token: 0x04013F7F RID: 81791
			[Token(Token = "0x4013F7F")]
			COMEBACK
		}
	}
}
