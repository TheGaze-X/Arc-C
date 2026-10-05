using System;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x02002990 RID: 10640
	[Token(Token = "0x2002990")]
	public class CoolDownAfterHitBehaviour : Projectile.Behaviour
	{
		// Token: 0x170026E5 RID: 9957
		// (get) Token: 0x060119AA RID: 72106 RVA: 0x0006C360 File Offset: 0x0006A560
		[Token(Token = "0x170026E5")]
		public bool canHit
		{
			[Token(Token = "0x60119AA")]
			[Address(RVA = "0x96EB80", Offset = "0x96D780", VA = "0x18096EB80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060119AB RID: 72107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119AB")]
		[Address(RVA = "0x96DAE0", Offset = "0x96C6E0", VA = "0x18096DAE0", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060119AC RID: 72108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119AC")]
		[Address(RVA = "0x96D390", Offset = "0x96BF90", VA = "0x18096D390", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x060119AD RID: 72109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119AD")]
		[Address(RVA = "0x96DE30", Offset = "0x96CA30", VA = "0x18096DE30")]
		private void OnTriggerEnter2D(Collider2D collision)
		{
		}

		// Token: 0x060119AE RID: 72110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119AE")]
		[Address(RVA = "0x96E250", Offset = "0x96CE50", VA = "0x18096E250")]
		private void OnTriggerStay2D(Collider2D collision)
		{
		}

		// Token: 0x060119AF RID: 72111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119AF")]
		[Address(RVA = "0x96E070", Offset = "0x96CC70", VA = "0x18096E070")]
		private void OnTriggerExit2D(Collider2D collision)
		{
		}

		// Token: 0x060119B0 RID: 72112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119B0")]
		[Address(RVA = "0x96E7B0", Offset = "0x96D3B0", VA = "0x18096E7B0")]
		private void _DoTargetStay(IPtrObject obj)
		{
		}

		// Token: 0x060119B1 RID: 72113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119B1")]
		[Address(RVA = "0x96E440", Offset = "0x96D040", VA = "0x18096E440")]
		private void _DoTargetEnter(IPtrObject obj)
		{
		}

		// Token: 0x060119B2 RID: 72114 RVA: 0x0006C378 File Offset: 0x0006A578
		[Token(Token = "0x60119B2")]
		[Address(RVA = "0x96E9C0", Offset = "0x96D5C0", VA = "0x18096E9C0")]
		private bool _VerifyTarget(Entity target)
		{
			return default(bool);
		}

		// Token: 0x060119B3 RID: 72115 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119B3")]
		[Address(RVA = "0x96D0B0", Offset = "0x96BCB0", VA = "0x18096D0B0", Slot = "15")]
		protected virtual void DealHitTarget(Entity target, bool force)
		{
		}

		// Token: 0x060119B4 RID: 72116 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119B4")]
		[Address(RVA = "0x96E650", Offset = "0x96D250", VA = "0x18096E650")]
		private void _DoTargetExit(IPtrObject obj)
		{
		}

		// Token: 0x060119B5 RID: 72117 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119B5")]
		[Address(RVA = "0x96D9F0", Offset = "0x96C5F0", VA = "0x18096D9F0", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x060119B6 RID: 72118 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119B6")]
		[Address(RVA = "0x96D650", Offset = "0x96C250", VA = "0x18096D650", Slot = "6")]
		public override void OnProjectileBorn()
		{
		}

		// Token: 0x060119B7 RID: 72119 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119B7")]
		[Address(RVA = "0x96EAC0", Offset = "0x96D6C0", VA = "0x18096EAC0")]
		public CoolDownAfterHitBehaviour()
		{
		}

		// Token: 0x060119B8 RID: 72120 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119B8")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x060119B9 RID: 72121 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119B9")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x060119BA RID: 72122 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119BA")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x060119BB RID: 72123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60119BB")]
		[Address(RVA = "0x94DC40", Offset = "0x94C840", VA = "0x18094DC40")]
		private void <>xLuaBaseProxy_OnProjectileBorn()
		{
		}

		// Token: 0x04013B10 RID: 80656
		[Token(Token = "0x4013B10")]
		private const string PROJECTILE_CAN_HIT_AUDIO = "_cooldown_ready";

		// Token: 0x04013B11 RID: 80657
		[Token(Token = "0x4013B11")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		protected TargetOptions _targetOptions;

		// Token: 0x04013B12 RID: 80658
		[Token(Token = "0x4013B12")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private FP _coolDown;

		// Token: 0x04013B13 RID: 80659
		[Token(Token = "0x4013B13")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private string _coolDownEffect;

		// Token: 0x04013B14 RID: 80660
		[Token(Token = "0x4013B14")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private string _hitEffectOnProjectilePos;

		// Token: 0x04013B15 RID: 80661
		[Token(Token = "0x4013B15")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private string _coolDownReadyEffectOnProjectilePos;

		// Token: 0x04013B16 RID: 80662
		[Token(Token = "0x4013B16")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private bool _ignoreCamouflage;

		// Token: 0x04013B17 RID: 80663
		[Token(Token = "0x4013B17")]
		[FieldOffset(Offset = "0xA9")]
		[SerializeField]
		private bool _exceptTraceTarget;

		// Token: 0x04013B18 RID: 80664
		[Token(Token = "0x4013B18")]
		[FieldOffset(Offset = "0xAA")]
		[SerializeField]
		private bool _allowEmptyMainEffect;

		// Token: 0x04013B19 RID: 80665
		[Token(Token = "0x4013B19")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private TargetValidator _targetValidator;

		// Token: 0x04013B1A RID: 80666
		[Token(Token = "0x4013B1A")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private bool _setAsHitEffectParent;

		// Token: 0x04013B1B RID: 80667
		[Token(Token = "0x4013B1B")]
		[FieldOffset(Offset = "0xB9")]
		[SerializeField]
		private bool _setBodyTransformAsCoolDownEffectParent;

		// Token: 0x04013B1C RID: 80668
		[Token(Token = "0x4013B1C")]
		[FieldOffset(Offset = "0xC0")]
		private ObjectPtr<Effect> m_coolDownEffect;

		// Token: 0x04013B1D RID: 80669
		[Token(Token = "0x4013B1D")]
		[FieldOffset(Offset = "0xD0")]
		private ObjectPtr<Effect> m_coolDownReadyEffect;

		// Token: 0x04013B1E RID: 80670
		[Token(Token = "0x4013B1E")]
		[FieldOffset(Offset = "0xE0")]
		private ParticleEffect m_mainEffect;

		// Token: 0x04013B1F RID: 80671
		[Token(Token = "0x4013B1F")]
		[FieldOffset(Offset = "0xE8")]
		private FP m_coolDown;

		// Token: 0x04013B20 RID: 80672
		[Token(Token = "0x4013B20")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_canHit;

		// Token: 0x04013B21 RID: 80673
		[Token(Token = "0x4013B21")]
		[FieldOffset(Offset = "0xF4")]
		protected int m_layerMask;

		// Token: 0x04013B22 RID: 80674
		[Token(Token = "0x4013B22")]
		[FieldOffset(Offset = "0xF8")]
		private string m_projectileAudio;

		// Token: 0x04013B23 RID: 80675
		[Token(Token = "0x4013B23")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_canHit;

		// Token: 0x04013B24 RID: 80676
		[Token(Token = "0x4013B24")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013B25 RID: 80677
		[Token(Token = "0x4013B25")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013B26 RID: 80678
		[Token(Token = "0x4013B26")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTriggerEnter2D;

		// Token: 0x04013B27 RID: 80679
		[Token(Token = "0x4013B27")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnTriggerStay2D;

		// Token: 0x04013B28 RID: 80680
		[Token(Token = "0x4013B28")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTriggerExit2D;

		// Token: 0x04013B29 RID: 80681
		[Token(Token = "0x4013B29")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DoTargetStay;

		// Token: 0x04013B2A RID: 80682
		[Token(Token = "0x4013B2A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__DoTargetEnter;

		// Token: 0x04013B2B RID: 80683
		[Token(Token = "0x4013B2B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__VerifyTarget;

		// Token: 0x04013B2C RID: 80684
		[Token(Token = "0x4013B2C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_DealHitTarget;

		// Token: 0x04013B2D RID: 80685
		[Token(Token = "0x4013B2D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__DoTargetExit;

		// Token: 0x04013B2E RID: 80686
		[Token(Token = "0x4013B2E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013B2F RID: 80687
		[Token(Token = "0x4013B2F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnProjectileBorn;

		// Token: 0x04013B30 RID: 80688
		[Token(Token = "0x4013B30")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
