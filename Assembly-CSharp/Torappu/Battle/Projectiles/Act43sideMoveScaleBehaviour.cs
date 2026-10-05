using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x02002984 RID: 10628
	[Token(Token = "0x2002984")]
	public class Act43sideMoveScaleBehaviour : Projectile.Behaviour
	{
		// Token: 0x170026DA RID: 9946
		// (get) Token: 0x06011947 RID: 72007 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170026DA")]
		private Act43SideBattleManager battleManager
		{
			[Token(Token = "0x6011947")]
			[Address(RVA = "0x94DDF0", Offset = "0x94C9F0", VA = "0x18094DDF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011948 RID: 72008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011948")]
		[Address(RVA = "0x94D8C0", Offset = "0x94C4C0", VA = "0x18094D8C0", Slot = "6")]
		public override void OnProjectileBorn()
		{
		}

		// Token: 0x06011949 RID: 72009 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011949")]
		[Address(RVA = "0x94DA50", Offset = "0x94C650", VA = "0x18094DA50", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x0601194A RID: 72010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601194A")]
		[Address(RVA = "0x94D9E0", Offset = "0x94C5E0", VA = "0x18094D9E0", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x0601194B RID: 72011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601194B")]
		[Address(RVA = "0x94DC70", Offset = "0x94C870", VA = "0x18094DC70")]
		private void _OnEnterShootingArea()
		{
		}

		// Token: 0x0601194C RID: 72012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601194C")]
		[Address(RVA = "0x94DD00", Offset = "0x94C900", VA = "0x18094DD00")]
		private void _OnExitShootingArea()
		{
		}

		// Token: 0x0601194D RID: 72013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601194D")]
		[Address(RVA = "0x94DD90", Offset = "0x94C990", VA = "0x18094DD90")]
		public Act43sideMoveScaleBehaviour()
		{
		}

		// Token: 0x0601194E RID: 72014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601194E")]
		[Address(RVA = "0x94DC40", Offset = "0x94C840", VA = "0x18094DC40")]
		private void <>xLuaBaseProxy_OnProjectileBorn()
		{
		}

		// Token: 0x0601194F RID: 72015 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601194F")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011950 RID: 72016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011950")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x04013A70 RID: 80496
		[Token(Token = "0x4013A70")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isScaled;

		// Token: 0x04013A71 RID: 80497
		[Token(Token = "0x4013A71")]
		[FieldOffset(Offset = "0x30")]
		private FP m_shootingAreaSpeedScale;

		// Token: 0x04013A72 RID: 80498
		[Token(Token = "0x4013A72")]
		[FieldOffset(Offset = "0x38")]
		private Act43SideBattleManager m_battleManager;

		// Token: 0x04013A73 RID: 80499
		[Token(Token = "0x4013A73")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_battleManager;

		// Token: 0x04013A74 RID: 80500
		[Token(Token = "0x4013A74")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnProjectileBorn;

		// Token: 0x04013A75 RID: 80501
		[Token(Token = "0x4013A75")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013A76 RID: 80502
		[Token(Token = "0x4013A76")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013A77 RID: 80503
		[Token(Token = "0x4013A77")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnEnterShootingArea;

		// Token: 0x04013A78 RID: 80504
		[Token(Token = "0x4013A78")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnExitShootingArea;

		// Token: 0x04013A79 RID: 80505
		[Token(Token = "0x4013A79")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
