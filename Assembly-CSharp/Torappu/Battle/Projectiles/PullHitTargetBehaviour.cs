using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029A6 RID: 10662
	[Token(Token = "0x20029A6")]
	public class PullHitTargetBehaviour : Projectile.Behaviour
	{
		// Token: 0x06011A7A RID: 72314 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A7A")]
		[Address(RVA = "0x9804A0", Offset = "0x97F0A0", VA = "0x1809804A0", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011A7B RID: 72315 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A7B")]
		[Address(RVA = "0x980A80", Offset = "0x97F680", VA = "0x180980A80", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011A7C RID: 72316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A7C")]
		[Address(RVA = "0x9805A0", Offset = "0x97F1A0", VA = "0x1809805A0", Slot = "10")]
		public override void OnHitTarget(Entity target)
		{
		}

		// Token: 0x06011A7D RID: 72317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A7D")]
		[Address(RVA = "0x9807D0", Offset = "0x97F3D0", VA = "0x1809807D0", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011A7E RID: 72318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6011A7E")]
		[Address(RVA = "0x980B80", Offset = "0x97F780", VA = "0x180980B80")]
		private IEnumerator _DoLink(Enemy target)
		{
			return null;
		}

		// Token: 0x06011A7F RID: 72319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A7F")]
		[Address(RVA = "0x980C50", Offset = "0x97F850", VA = "0x180980C50")]
		public PullHitTargetBehaviour()
		{
		}

		// Token: 0x06011A80 RID: 72320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A80")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011A81 RID: 72321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A81")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011A82 RID: 72322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A82")]
		[Address(RVA = "0x966560", Offset = "0x965160", VA = "0x180966560")]
		private void <>xLuaBaseProxy_OnHitTarget(Entity P0)
		{
		}

		// Token: 0x06011A83 RID: 72323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A83")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x04013C5E RID: 80990
		[Token(Token = "0x4013C5E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _pullSourceOffset;

		// Token: 0x04013C5F RID: 80991
		[Token(Token = "0x4013C5F")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _pullDuration;

		// Token: 0x04013C60 RID: 80992
		[Token(Token = "0x4013C60")]
		[FieldOffset(Offset = "0x30")]
		private int m_pullForceLevel;

		// Token: 0x04013C61 RID: 80993
		[Token(Token = "0x4013C61")]
		[FieldOffset(Offset = "0x38")]
		private FP m_pullRemainingTime;

		// Token: 0x04013C62 RID: 80994
		[Token(Token = "0x4013C62")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013C63 RID: 80995
		[Token(Token = "0x4013C63")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013C64 RID: 80996
		[Token(Token = "0x4013C64")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnHitTarget;

		// Token: 0x04013C65 RID: 80997
		[Token(Token = "0x4013C65")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013C66 RID: 80998
		[Token(Token = "0x4013C66")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DoLink;

		// Token: 0x04013C67 RID: 80999
		[Token(Token = "0x4013C67")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
