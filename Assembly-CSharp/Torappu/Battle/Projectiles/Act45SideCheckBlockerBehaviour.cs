using System;
using Il2CppDummyDll;
using Torappu.Battle.Abilities;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x02002985 RID: 10629
	[Token(Token = "0x2002985")]
	public class Act45SideCheckBlockerBehaviour : Projectile.Behaviour
	{
		// Token: 0x06011951 RID: 72017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011951")]
		[Address(RVA = "0x966050", Offset = "0x964C50", VA = "0x180966050", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011952 RID: 72018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011952")]
		[Address(RVA = "0x966240", Offset = "0x964E40", VA = "0x180966240", Slot = "10")]
		public override void OnHitTarget(Entity target)
		{
		}

		// Token: 0x06011953 RID: 72019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011953")]
		[Address(RVA = "0x966420", Offset = "0x965020", VA = "0x180966420", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011954 RID: 72020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011954")]
		[Address(RVA = "0x966570", Offset = "0x965170", VA = "0x180966570")]
		public Act45SideCheckBlockerBehaviour()
		{
		}

		// Token: 0x06011955 RID: 72021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011955")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011956 RID: 72022 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011956")]
		[Address(RVA = "0x966560", Offset = "0x965160", VA = "0x180966560")]
		private void <>xLuaBaseProxy_OnHitTarget(Entity P0)
		{
		}

		// Token: 0x06011957 RID: 72023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011957")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x04013A7A RID: 80506
		[Token(Token = "0x4013A7A")]
		[FieldOffset(Offset = "0x28")]
		private Act45SideLineAbility m_lineAbility;

		// Token: 0x04013A7B RID: 80507
		[Token(Token = "0x4013A7B")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasBlocker;

		// Token: 0x04013A7C RID: 80508
		[Token(Token = "0x4013A7C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013A7D RID: 80509
		[Token(Token = "0x4013A7D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnHitTarget;

		// Token: 0x04013A7E RID: 80510
		[Token(Token = "0x4013A7E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013A7F RID: 80511
		[Token(Token = "0x4013A7F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
