using System;
using AdvancedInspector;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002ABA RID: 10938
	[Token(Token = "0x2002ABA")]
	public class MultiRangedAttackWithSalvo : MultiRangedAttack
	{
		// Token: 0x170027EF RID: 10223
		// (get) Token: 0x06012352 RID: 74578 RVA: 0x0006F948 File Offset: 0x0006DB48
		[Token(Token = "0x170027EF")]
		public bool useSalvo
		{
			[Token(Token = "0x6012352")]
			[Address(RVA = "0xA43020", Offset = "0xA41C20", VA = "0x180A43020")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170027F0 RID: 10224
		// (get) Token: 0x06012353 RID: 74579 RVA: 0x0006F960 File Offset: 0x0006DB60
		[Token(Token = "0x170027F0")]
		public bool useTargetPosOffset
		{
			[Token(Token = "0x6012353")]
			[Address(RVA = "0xA43080", Offset = "0xA41C80", VA = "0x180A43080")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06012354 RID: 74580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012354")]
		[Address(RVA = "0xA42B00", Offset = "0xA41700", VA = "0x180A42B00", Slot = "116")]
		protected override void AfterCastOnTarget(Entity target)
		{
		}

		// Token: 0x06012355 RID: 74581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012355")]
		[Address(RVA = "0xA42F40", Offset = "0xA41B40", VA = "0x180A42F40", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x06012356 RID: 74582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012356")]
		[Address(RVA = "0xA42DE0", Offset = "0xA419E0", VA = "0x180A42DE0", Slot = "113")]
		protected override Projectile CreateProjectile(ILocatable target, out Projectile fakeProjectile)
		{
			return null;
		}

		// Token: 0x06012357 RID: 74583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012357")]
		[Address(RVA = "0xA42FC0", Offset = "0xA41BC0", VA = "0x180A42FC0")]
		public MultiRangedAttackWithSalvo()
		{
		}

		// Token: 0x06012358 RID: 74584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012358")]
		[Address(RVA = "0xA42FB0", Offset = "0xA41BB0", VA = "0x180A42FB0")]
		private void <>xLuaBaseProxy_AfterCastOnTarget(Entity P0)
		{
		}

		// Token: 0x06012359 RID: 74585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012359")]
		[Address(RVA = "0xA3CEE0", Offset = "0xA3BAE0", VA = "0x180A3CEE0")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x0601235A RID: 74586 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601235A")]
		[Address(RVA = "0xA3CEC0", Offset = "0xA3BAC0", VA = "0x180A3CEC0")]
		private Projectile <>xLuaBaseProxy_CreateProjectile(ILocatable P0, out Projectile P1)
		{
			return null;
		}

		// Token: 0x04014977 RID: 84343
		[Token(Token = "0x4014977")]
		[FieldOffset(Offset = "0x2D8")]
		[SerializeField]
		[Group("Salvo")]
		private bool _useSalvo;

		// Token: 0x04014978 RID: 84344
		[Token(Token = "0x4014978")]
		[FieldOffset(Offset = "0x2E0")]
		[SerializeField]
		[Group("Salvo")]
		[Inspect("useSalvo")]
		private int[] _salvoCount;

		// Token: 0x04014979 RID: 84345
		[Token(Token = "0x4014979")]
		[FieldOffset(Offset = "0x2E8")]
		[SerializeField]
		[Group("Salvo")]
		private bool _useTargetPosOffset;

		// Token: 0x0401497A RID: 84346
		[Token(Token = "0x401497A")]
		[FieldOffset(Offset = "0x2F0")]
		[Group("Salvo")]
		[Inspect("useTargetPosOffset")]
		[SerializeField]
		private float[] _targetPosOffsets;

		// Token: 0x0401497B RID: 84347
		[Token(Token = "0x401497B")]
		[FieldOffset(Offset = "0x2F8")]
		private int m_projectileCount;

		// Token: 0x0401497C RID: 84348
		[Token(Token = "0x401497C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_useSalvo;

		// Token: 0x0401497D RID: 84349
		[Token(Token = "0x401497D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_useTargetPosOffset;

		// Token: 0x0401497E RID: 84350
		[Token(Token = "0x401497E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AfterCastOnTarget;

		// Token: 0x0401497F RID: 84351
		[Token(Token = "0x401497F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04014980 RID: 84352
		[Token(Token = "0x4014980")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CreateProjectile;

		// Token: 0x04014981 RID: 84353
		[Token(Token = "0x4014981")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
