using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x0200299E RID: 10654
	[Token(Token = "0x200299E")]
	public class MultiHitBehaviour : HitBehaviour
	{
		// Token: 0x06011A3C RID: 72252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A3C")]
		[Address(RVA = "0x9790D0", Offset = "0x977CD0", VA = "0x1809790D0", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011A3D RID: 72253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A3D")]
		[Address(RVA = "0x9791C0", Offset = "0x977DC0", VA = "0x1809791C0", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011A3E RID: 72254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A3E")]
		[Address(RVA = "0x9795B0", Offset = "0x9781B0", VA = "0x1809795B0")]
		private void _DoTargetStay(IPtrObject obj)
		{
		}

		// Token: 0x06011A3F RID: 72255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A3F")]
		[Address(RVA = "0x979390", Offset = "0x977F90", VA = "0x180979390")]
		private void OnTriggerStay2D(Collider2D collision)
		{
		}

		// Token: 0x06011A40 RID: 72256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A40")]
		[Address(RVA = "0x979760", Offset = "0x978360", VA = "0x180979760")]
		private void _UpdateRigidBody()
		{
		}

		// Token: 0x06011A41 RID: 72257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A41")]
		[Address(RVA = "0x979020", Offset = "0x977C20", VA = "0x180979020", Slot = "15")]
		protected override void DealHitTarget(Entity target, bool force)
		{
		}

		// Token: 0x06011A42 RID: 72258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A42")]
		[Address(RVA = "0x9798A0", Offset = "0x9784A0", VA = "0x1809798A0")]
		public MultiHitBehaviour()
		{
		}

		// Token: 0x06011A43 RID: 72259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A43")]
		[Address(RVA = "0x9795A0", Offset = "0x9781A0", VA = "0x1809795A0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011A44 RID: 72260 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A44")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011A45 RID: 72261 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A45")]
		[Address(RVA = "0x979590", Offset = "0x978190", VA = "0x180979590")]
		private void <>xLuaBaseProxy_DealHitTarget(Entity P0, bool P1)
		{
		}

		// Token: 0x04013BFC RID: 80892
		[Token(Token = "0x4013BFC")]
		private const int RIGIDBODY_TICK_INTERVAL = 10;

		// Token: 0x04013BFD RID: 80893
		[Token(Token = "0x4013BFD")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Multi")]
		private bool _hitAfterReached;

		// Token: 0x04013BFE RID: 80894
		[Token(Token = "0x4013BFE")]
		[FieldOffset(Offset = "0xB0")]
		private Collider2D[] m_colliders;

		// Token: 0x04013BFF RID: 80895
		[Token(Token = "0x4013BFF")]
		[FieldOffset(Offset = "0xB8")]
		private PeriodicTicker m_triggerTicker;

		// Token: 0x04013C00 RID: 80896
		[Token(Token = "0x4013C00")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013C01 RID: 80897
		[Token(Token = "0x4013C01")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013C02 RID: 80898
		[Token(Token = "0x4013C02")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__DoTargetStay;

		// Token: 0x04013C03 RID: 80899
		[Token(Token = "0x4013C03")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnTriggerStay2D;

		// Token: 0x04013C04 RID: 80900
		[Token(Token = "0x4013C04")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateRigidBody;

		// Token: 0x04013C05 RID: 80901
		[Token(Token = "0x4013C05")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DealHitTarget;

		// Token: 0x04013C06 RID: 80902
		[Token(Token = "0x4013C06")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
