using System;
using Il2CppDummyDll;
using Torappu.Battle.Abilities;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Projectiles
{
	// Token: 0x0200299D RID: 10653
	[Token(Token = "0x200299D")]
	public class MultiFunnelHitBehaviour : Projectile.Behaviour
	{
		// Token: 0x170026EA RID: 9962
		// (get) Token: 0x06011A2F RID: 72239 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170026EA")]
		protected MultiFunnelTrait trait
		{
			[Token(Token = "0x6011A2F")]
			[Address(RVA = "0x978FC0", Offset = "0x977BC0", VA = "0x180978FC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06011A30 RID: 72240 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A30")]
		[Address(RVA = "0x9784D0", Offset = "0x9770D0", VA = "0x1809784D0", Slot = "4")]
		public override void Init(ILocatable start, ILocatable target, Projectile projectile)
		{
		}

		// Token: 0x06011A31 RID: 72241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A31")]
		[Address(RVA = "0x978AB0", Offset = "0x9776B0", VA = "0x180978AB0", Slot = "5")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x06011A32 RID: 72242 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A32")]
		[Address(RVA = "0x978BC0", Offset = "0x9777C0", VA = "0x180978BC0")]
		protected void StopProjectile()
		{
		}

		// Token: 0x06011A33 RID: 72243 RVA: 0x0006C450 File Offset: 0x0006A650
		[Token(Token = "0x6011A33")]
		[Address(RVA = "0x978330", Offset = "0x976F30", VA = "0x180978330", Slot = "15")]
		protected virtual bool DealHitTarget()
		{
			return default(bool);
		}

		// Token: 0x06011A34 RID: 72244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A34")]
		[Address(RVA = "0x978910", Offset = "0x977510", VA = "0x180978910", Slot = "7")]
		public override void OnProjectileStop()
		{
		}

		// Token: 0x06011A35 RID: 72245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A35")]
		[Address(RVA = "0x978810", Offset = "0x977410", VA = "0x180978810", Slot = "12")]
		public override void OnAttackTimeChanged(FP newValue)
		{
		}

		// Token: 0x06011A36 RID: 72246 RVA: 0x0006C468 File Offset: 0x0006A668
		[Token(Token = "0x6011A36")]
		[Address(RVA = "0x978CD0", Offset = "0x9778D0", VA = "0x180978CD0", Slot = "16")]
		protected virtual bool _CheckProjectileInValid()
		{
			return default(bool);
		}

		// Token: 0x06011A37 RID: 72247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A37")]
		[Address(RVA = "0x978F10", Offset = "0x977B10", VA = "0x180978F10")]
		public MultiFunnelHitBehaviour()
		{
		}

		// Token: 0x06011A38 RID: 72248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A38")]
		[Address(RVA = "0x5EEAD0", Offset = "0x5ED6D0", VA = "0x1805EEAD0")]
		private void <>xLuaBaseProxy_Init(ILocatable P0, ILocatable P1, Projectile P2)
		{
		}

		// Token: 0x06011A39 RID: 72249 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A39")]
		[Address(RVA = "0x94DC60", Offset = "0x94C860", VA = "0x18094DC60")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x06011A3A RID: 72250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A3A")]
		[Address(RVA = "0x94DC50", Offset = "0x94C850", VA = "0x18094DC50")]
		private void <>xLuaBaseProxy_OnProjectileStop()
		{
		}

		// Token: 0x06011A3B RID: 72251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6011A3B")]
		[Address(RVA = "0x972170", Offset = "0x970D70", VA = "0x180972170")]
		private void <>xLuaBaseProxy_OnAttackTimeChanged(FP P0)
		{
		}

		// Token: 0x04013BEE RID: 80878
		[Token(Token = "0x4013BEE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TargetOptions _targetOptions;

		// Token: 0x04013BEF RID: 80879
		[Token(Token = "0x4013BEF")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private bool _waitFirstPeriod;

		// Token: 0x04013BF0 RID: 80880
		[Token(Token = "0x4013BF0")]
		[FieldOffset(Offset = "0x90")]
		protected readonly PeriodicTimer m_periodTimer;

		// Token: 0x04013BF1 RID: 80881
		[Token(Token = "0x4013BF1")]
		[FieldOffset(Offset = "0x98")]
		private MultiFunnelTrait m_trait;

		// Token: 0x04013BF2 RID: 80882
		[Token(Token = "0x4013BF2")]
		[FieldOffset(Offset = "0xA0")]
		private FP m_remainingTime;

		// Token: 0x04013BF3 RID: 80883
		[Token(Token = "0x4013BF3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_trait;

		// Token: 0x04013BF4 RID: 80884
		[Token(Token = "0x4013BF4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x04013BF5 RID: 80885
		[Token(Token = "0x4013BF5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x04013BF6 RID: 80886
		[Token(Token = "0x4013BF6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_StopProjectile;

		// Token: 0x04013BF7 RID: 80887
		[Token(Token = "0x4013BF7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DealHitTarget;

		// Token: 0x04013BF8 RID: 80888
		[Token(Token = "0x4013BF8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnProjectileStop;

		// Token: 0x04013BF9 RID: 80889
		[Token(Token = "0x4013BF9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnAttackTimeChanged;

		// Token: 0x04013BFA RID: 80890
		[Token(Token = "0x4013BFA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CheckProjectileInValid;

		// Token: 0x04013BFB RID: 80891
		[Token(Token = "0x4013BFB")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
