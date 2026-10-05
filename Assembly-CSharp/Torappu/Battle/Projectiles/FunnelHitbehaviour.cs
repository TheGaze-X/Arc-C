using System;
using Il2CppDummyDll;
using Torappu.Battle.Abilities;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x02002996 RID: 10646
	[Token(Token = "0x2002996")]
	public class FunnelHitbehaviour : Projectile.Behaviour
	{
		// Token: 0x060119E1 RID: 72161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119E1")]
		[Address(RVA = "0x971BD0", Offset = "0x9707D0", VA = "0x180971BD0", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x060119E2 RID: 72162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119E2")]
		[Address(RVA = "0x972050", Offset = "0x970C50", VA = "0x180972050", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060119E3 RID: 72163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119E3")]
		[Address(RVA = "0x9723C0", Offset = "0x970FC0", VA = "0x1809723C0")]
		private void _DealHitTarget()
		{
		}

		// Token: 0x060119E4 RID: 72164 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119E4")]
		[Address(RVA = "0x971F50", Offset = "0x970B50", VA = "0x180971F50", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x060119E5 RID: 72165 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119E5")]
		[Address(RVA = "0x971EC0", Offset = "0x970AC0", VA = "0x180971EC0", Slot = "12")]
		public override void OnAttackTimeChanged(FP newValue)
		{
		}

		// Token: 0x060119E6 RID: 72166 RVA: 0x0006C3C0 File Offset: 0x0006A5C0
		[Token(Token = "0x60119E6")]
		[Address(RVA = "0x972180", Offset = "0x970D80", VA = "0x180972180")]
		private bool _CheckProjectileInValid()
		{
			return default(bool);
		}

		// Token: 0x060119E7 RID: 72167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119E7")]
		[Address(RVA = "0x972590", Offset = "0x971190", VA = "0x180972590")]
		public FunnelHitbehaviour()
		{
		}

		// Token: 0x060119E8 RID: 72168 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119E8")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x060119E9 RID: 72169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119E9")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x060119EA RID: 72170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119EA")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x060119EB RID: 72171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119EB")]
		[Address(RVA = "0x972170", Offset = "0x970D70", VA = "0x180972170")]
		private void <>xLuaBaseProxy_OnAttackTimeChanged(FP P0)
		{
		}

		// Token: 0x04013B71 RID: 80753
		[Token(Token = "0x4013B71")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TargetOptions _targetOptions;

		// Token: 0x04013B72 RID: 80754
		[Token(Token = "0x4013B72")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private bool _waitFirstPeriod;

		// Token: 0x04013B73 RID: 80755
		[Token(Token = "0x4013B73")]
		[FieldOffset(Offset = "0x90")]
		private PeriodicTimer m_periodTimer;

		// Token: 0x04013B74 RID: 80756
		[Token(Token = "0x4013B74")]
		[FieldOffset(Offset = "0x98")]
		private CammouTrait m_trait;

		// Token: 0x04013B75 RID: 80757
		[Token(Token = "0x4013B75")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013B76 RID: 80758
		[Token(Token = "0x4013B76")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013B77 RID: 80759
		[Token(Token = "0x4013B77")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__DealHitTarget;

		// Token: 0x04013B78 RID: 80760
		[Token(Token = "0x4013B78")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013B79 RID: 80761
		[Token(Token = "0x4013B79")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnAttackTimeChanged;

		// Token: 0x04013B7A RID: 80762
		[Token(Token = "0x4013B7A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CheckProjectileInValid;

		// Token: 0x04013B7B RID: 80763
		[Token(Token = "0x4013B7B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
