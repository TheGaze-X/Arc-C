using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x0200299A RID: 10650
	[Token(Token = "0x200299A")]
	public class Hsgma2SlowDownBehaviour : Projectile.Behaviour
	{
		// Token: 0x06011A11 RID: 72209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A11")]
		[Address(RVA = "0x976590", Offset = "0x975190", VA = "0x180976590", Slot = "6")]
		public override void OnProjectileBorn()
		{
		}

		// Token: 0x06011A12 RID: 72210 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A12")]
		[Address(RVA = "0x9768A0", Offset = "0x9754A0", VA = "0x1809768A0", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011A13 RID: 72211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A13")]
		[Address(RVA = "0x976670", Offset = "0x975270", VA = "0x180976670", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011A14 RID: 72212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A14")]
		[Address(RVA = "0x976AC0", Offset = "0x9756C0", VA = "0x180976AC0")]
		public Hsgma2SlowDownBehaviour()
		{
		}

		// Token: 0x06011A15 RID: 72213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A15")]
		[Address(RVA = "0x94DC40", Offset = "0x94C840", VA = "0x18094DC40")]
		private void <>xLuaBaseProxy_OnProjectileBorn()
		{
		}

		// Token: 0x06011A16 RID: 72214 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A16")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011A17 RID: 72215 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A17")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x04013BC6 RID: 80838
		[Token(Token = "0x4013BC6")]
		[FieldOffset(Offset = "0x28")]
		private RotateAroundMovement m_rotateAroundMovement;

		// Token: 0x04013BC7 RID: 80839
		[Token(Token = "0x4013BC7")]
		[FieldOffset(Offset = "0x30")]
		private AuraHitBehaviour m_auraHitBehaviour;

		// Token: 0x04013BC8 RID: 80840
		[Token(Token = "0x4013BC8")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isAlreadySlowDown;

		// Token: 0x04013BC9 RID: 80841
		[Token(Token = "0x4013BC9")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private float _slowDownRatio;

		// Token: 0x04013BCA RID: 80842
		[Token(Token = "0x4013BCA")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _MaxRotateAngle;

		// Token: 0x04013BCB RID: 80843
		[Token(Token = "0x4013BCB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnProjectileBorn;

		// Token: 0x04013BCC RID: 80844
		[Token(Token = "0x4013BCC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013BCD RID: 80845
		[Token(Token = "0x4013BCD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013BCE RID: 80846
		[Token(Token = "0x4013BCE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
