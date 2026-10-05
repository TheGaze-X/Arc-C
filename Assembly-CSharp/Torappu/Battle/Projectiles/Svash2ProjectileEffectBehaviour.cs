using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Effects;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x020029BE RID: 10686
	[Token(Token = "0x20029BE")]
	public class Svash2ProjectileEffectBehaviour : Projectile.Behaviour, IEffectSource
	{
		// Token: 0x06011B1D RID: 72477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B1D")]
		[Address(RVA = "0x98C470", Offset = "0x98B070", VA = "0x18098C470", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011B1E RID: 72478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B1E")]
		[Address(RVA = "0x98C700", Offset = "0x98B300", VA = "0x18098C700", Slot = "6")]
		public override void OnProjectileBorn()
		{
		}

		// Token: 0x06011B1F RID: 72479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B1F")]
		[Address(RVA = "0x98CD80", Offset = "0x98B980", VA = "0x18098CD80")]
		private void _CreateAlignToProjectileEffect()
		{
		}

		// Token: 0x06011B20 RID: 72480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B20")]
		[Address(RVA = "0x98D0C0", Offset = "0x98BCC0", VA = "0x18098D0C0")]
		private void _CreateAlignToTargetEff()
		{
		}

		// Token: 0x06011B21 RID: 72481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B21")]
		[Address(RVA = "0x98C780", Offset = "0x98B380", VA = "0x18098C780", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011B22 RID: 72482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B22")]
		[Address(RVA = "0x98CA30", Offset = "0x98B630", VA = "0x18098CA30", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011B23 RID: 72483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B23")]
		[Address(RVA = "0x98C3B0", Offset = "0x98AFB0", VA = "0x18098C3B0", Slot = "15")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06011B24 RID: 72484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B24")]
		[Address(RVA = "0x98D470", Offset = "0x98C070", VA = "0x18098D470")]
		public Svash2ProjectileEffectBehaviour()
		{
		}

		// Token: 0x06011B25 RID: 72485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B25")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011B26 RID: 72486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B26")]
		[Address(RVA = "0x94DC40", Offset = "0x94C840", VA = "0x18094DC40")]
		private void <>xLuaBaseProxy_OnProjectileBorn()
		{
		}

		// Token: 0x06011B27 RID: 72487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B27")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x06011B28 RID: 72488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011B28")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x04013D62 RID: 81250
		[Token(Token = "0x4013D62")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private string[] _effectsAlignToTargetDirection;

		// Token: 0x04013D63 RID: 81251
		[Token(Token = "0x4013D63")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private string[] _effectsAlignToProjectileDirectionWhenDirRight;

		// Token: 0x04013D64 RID: 81252
		[Token(Token = "0x4013D64")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private string[] _effectsAlignToProjectileDirection;

		// Token: 0x04013D65 RID: 81253
		[Token(Token = "0x4013D65")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private bool _useTargetAsMountPoint;

		// Token: 0x04013D66 RID: 81254
		[Token(Token = "0x4013D66")]
		[FieldOffset(Offset = "0x48")]
		protected List<ObjectPtr<Effect>> m_effectsToTarget;

		// Token: 0x04013D67 RID: 81255
		[Token(Token = "0x4013D67")]
		[FieldOffset(Offset = "0x50")]
		protected List<ObjectPtr<Effect>> m_effectsFollowProjectile;

		// Token: 0x04013D68 RID: 81256
		[Token(Token = "0x4013D68")]
		[FieldOffset(Offset = "0x58")]
		private SharedConsts.Direction m_lastTargetDirection;

		// Token: 0x04013D69 RID: 81257
		[Token(Token = "0x4013D69")]
		[FieldOffset(Offset = "0x60")]
		private MountPoint m_mountPoint;

		// Token: 0x04013D6A RID: 81258
		[Token(Token = "0x4013D6A")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInit;

		// Token: 0x04013D6B RID: 81259
		[Token(Token = "0x4013D6B")]
		[FieldOffset(Offset = "0x6C")]
		private Vector2 m_sourceToTargetDirection;

		// Token: 0x04013D6C RID: 81260
		[Token(Token = "0x4013D6C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013D6D RID: 81261
		[Token(Token = "0x4013D6D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnProjectileBorn;

		// Token: 0x04013D6E RID: 81262
		[Token(Token = "0x4013D6E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__CreateAlignToProjectileEffect;

		// Token: 0x04013D6F RID: 81263
		[Token(Token = "0x4013D6F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__CreateAlignToTargetEff;

		// Token: 0x04013D70 RID: 81264
		[Token(Token = "0x4013D70")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013D71 RID: 81265
		[Token(Token = "0x4013D71")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013D72 RID: 81266
		[Token(Token = "0x4013D72")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x04013D73 RID: 81267
		[Token(Token = "0x4013D73")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
