using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x0200298D RID: 10637
	[Token(Token = "0x200298D")]
	public class ChangeForceWhenHitTgtBehaviour : Projectile.Behaviour
	{
		// Token: 0x06011995 RID: 72085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011995")]
		[Address(RVA = "0x96BC50", Offset = "0x96A850", VA = "0x18096BC50", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011996 RID: 72086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011996")]
		[Address(RVA = "0x96BDA0", Offset = "0x96A9A0", VA = "0x18096BDA0", Slot = "10")]
		public override void OnHitTarget(Entity target)
		{
		}

		// Token: 0x06011997 RID: 72087 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011997")]
		[Address(RVA = "0x96BE30", Offset = "0x96AA30", VA = "0x18096BE30")]
		private void _OnBeforeHitTarget(Entity target)
		{
		}

		// Token: 0x06011998 RID: 72088 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011998")]
		[Address(RVA = "0x96C0C0", Offset = "0x96ACC0", VA = "0x18096C0C0")]
		public ChangeForceWhenHitTgtBehaviour()
		{
		}

		// Token: 0x06011999 RID: 72089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011999")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x0601199A RID: 72090 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601199A")]
		[Address(RVA = "0x966560", Offset = "0x965160", VA = "0x180966560")]
		private void <>xLuaBaseProxy_OnHitTarget(Entity P0)
		{
		}

		// Token: 0x04013AF1 RID: 80625
		[Token(Token = "0x4013AF1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _radius;

		// Token: 0x04013AF2 RID: 80626
		[Token(Token = "0x4013AF2")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private int _deltaForceLevel;

		// Token: 0x04013AF3 RID: 80627
		[Token(Token = "0x4013AF3")]
		[FieldOffset(Offset = "0x30")]
		private float m_radius;

		// Token: 0x04013AF4 RID: 80628
		[Token(Token = "0x4013AF4")]
		[FieldOffset(Offset = "0x34")]
		private int m_deltaForceLevel;

		// Token: 0x04013AF5 RID: 80629
		[Token(Token = "0x4013AF5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013AF6 RID: 80630
		[Token(Token = "0x4013AF6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnHitTarget;

		// Token: 0x04013AF7 RID: 80631
		[Token(Token = "0x4013AF7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnBeforeHitTarget;

		// Token: 0x04013AF8 RID: 80632
		[Token(Token = "0x4013AF8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
