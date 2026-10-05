using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x0200299B RID: 10651
	[Token(Token = "0x200299B")]
	[RequireComponent(typeof(BoxCollider2D))]
	public class LaserHitBehaviour : Projectile.Behaviour
	{
		// Token: 0x06011A18 RID: 72216 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A18")]
		[Address(RVA = "0x976C30", Offset = "0x975830", VA = "0x180976C30", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011A19 RID: 72217 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A19")]
		[Address(RVA = "0x9777A0", Offset = "0x9763A0", VA = "0x1809777A0")]
		private void _UpdateBoxCollider()
		{
		}

		// Token: 0x06011A1A RID: 72218 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A1A")]
		[Address(RVA = "0x976F90", Offset = "0x975B90", VA = "0x180976F90", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011A1B RID: 72219 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A1B")]
		[Address(RVA = "0x976F20", Offset = "0x975B20", VA = "0x180976F20", Slot = "9")]
		public override void OnProjectileReached()
		{
		}

		// Token: 0x06011A1C RID: 72220 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A1C")]
		[Address(RVA = "0x976B30", Offset = "0x975730", VA = "0x180976B30", Slot = "15")]
		protected virtual void DealHitTarget(Entity target, bool force)
		{
		}

		// Token: 0x06011A1D RID: 72221 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A1D")]
		[Address(RVA = "0x977470", Offset = "0x976070", VA = "0x180977470")]
		private void _DoTargetEnter(IPtrObject obj)
		{
		}

		// Token: 0x06011A1E RID: 72222 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A1E")]
		[Address(RVA = "0x977640", Offset = "0x976240", VA = "0x180977640")]
		private void _DoTargetExit(IPtrObject obj)
		{
		}

		// Token: 0x06011A1F RID: 72223 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A1F")]
		[Address(RVA = "0x977060", Offset = "0x975C60", VA = "0x180977060")]
		private void OnTriggerEnter2D(Collider2D collision)
		{
		}

		// Token: 0x06011A20 RID: 72224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A20")]
		[Address(RVA = "0x977290", Offset = "0x975E90", VA = "0x180977290")]
		private void OnTriggerExit2D(Collider2D collision)
		{
		}

		// Token: 0x06011A21 RID: 72225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A21")]
		[Address(RVA = "0x977B10", Offset = "0x976710", VA = "0x180977B10")]
		public LaserHitBehaviour()
		{
		}

		// Token: 0x06011A22 RID: 72226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A22")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011A23 RID: 72227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A23")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011A24 RID: 72228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A24")]
		[Address(RVA = "0x970BF0", Offset = "0x96F7F0", VA = "0x180970BF0")]
		private void <>xLuaBaseProxy_OnProjectileReached()
		{
		}

		// Token: 0x04013BCF RID: 80847
		[Token(Token = "0x4013BCF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _overridePurposeMaskWithTargetOptions;

		// Token: 0x04013BD0 RID: 80848
		[Token(Token = "0x4013BD0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected TargetOptions _targetOptions;

		// Token: 0x04013BD1 RID: 80849
		[Token(Token = "0x4013BD1")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private bool _exceptTraceTarget;

		// Token: 0x04013BD2 RID: 80850
		[Token(Token = "0x4013BD2")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float _laserWidth;

		// Token: 0x04013BD3 RID: 80851
		[Token(Token = "0x4013BD3")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private bool _ignoreCamouflage;

		// Token: 0x04013BD4 RID: 80852
		[Token(Token = "0x4013BD4")]
		[FieldOffset(Offset = "0x99")]
		[SerializeField]
		private bool _useStartMapPosAsSource;

		// Token: 0x04013BD5 RID: 80853
		[Token(Token = "0x4013BD5")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		private float _updateBoxColliderInterval;

		// Token: 0x04013BD6 RID: 80854
		[Token(Token = "0x4013BD6")]
		[FieldOffset(Offset = "0xA0")]
		protected int m_layerMask;

		// Token: 0x04013BD7 RID: 80855
		[Token(Token = "0x4013BD7")]
		[FieldOffset(Offset = "0xA8")]
		private BoxCollider2D m_collider;

		// Token: 0x04013BD8 RID: 80856
		[Token(Token = "0x4013BD8")]
		[FieldOffset(Offset = "0xB0")]
		private PeriodicTimer m_updateBoxColliderTicker;

		// Token: 0x04013BD9 RID: 80857
		[Token(Token = "0x4013BD9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013BDA RID: 80858
		[Token(Token = "0x4013BDA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__UpdateBoxCollider;

		// Token: 0x04013BDB RID: 80859
		[Token(Token = "0x4013BDB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013BDC RID: 80860
		[Token(Token = "0x4013BDC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnProjectileReached;

		// Token: 0x04013BDD RID: 80861
		[Token(Token = "0x4013BDD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DealHitTarget;

		// Token: 0x04013BDE RID: 80862
		[Token(Token = "0x4013BDE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__DoTargetEnter;

		// Token: 0x04013BDF RID: 80863
		[Token(Token = "0x4013BDF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__DoTargetExit;

		// Token: 0x04013BE0 RID: 80864
		[Token(Token = "0x4013BE0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnTriggerEnter2D;

		// Token: 0x04013BE1 RID: 80865
		[Token(Token = "0x4013BE1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnTriggerExit2D;

		// Token: 0x04013BE2 RID: 80866
		[Token(Token = "0x4013BE2")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
