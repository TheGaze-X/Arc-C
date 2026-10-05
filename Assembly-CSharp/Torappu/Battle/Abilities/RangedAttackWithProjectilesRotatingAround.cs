using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using Torappu.Battle.Projectiles;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AC6 RID: 10950
	[Token(Token = "0x2002AC6")]
	public class RangedAttackWithProjectilesRotatingAround : RangedAttack
	{
		// Token: 0x17002800 RID: 10240
		// (get) Token: 0x060123C6 RID: 74694 RVA: 0x0006FC78 File Offset: 0x0006DE78
		[Token(Token = "0x17002800")]
		public int managedProjectileCount
		{
			[Token(Token = "0x60123C6")]
			[Address(RVA = "0xA49500", Offset = "0xA48100", VA = "0x180A49500")]
			get
			{
				return 0;
			}
		}

		// Token: 0x060123C7 RID: 74695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60123C7")]
		[Address(RVA = "0xA48280", Offset = "0xA46E80", VA = "0x180A48280")]
		public RangedAttackWithProjectilesRotatingAround.ProjectileWrapper GetProjectileWrapper(int index)
		{
			return null;
		}

		// Token: 0x060123C8 RID: 74696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123C8")]
		[Address(RVA = "0xA47F80", Offset = "0xA46B80", VA = "0x180A47F80", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060123C9 RID: 74697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123C9")]
		[Address(RVA = "0xA48340", Offset = "0xA46F40", VA = "0x180A48340", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x060123CA RID: 74698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123CA")]
		[Address(RVA = "0xA48F40", Offset = "0xA47B40", VA = "0x180A48F40")]
		private void _CreateProjectile(ILocatable target)
		{
		}

		// Token: 0x060123CB RID: 74699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123CB")]
		[Address(RVA = "0xA48BD0", Offset = "0xA477D0", VA = "0x180A48BD0")]
		private void _CreateProjectileEnemyMain14(ILocatable target)
		{
		}

		// Token: 0x060123CC RID: 74700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123CC")]
		[Address(RVA = "0xA48D80", Offset = "0xA47980", VA = "0x180A48D80")]
		private void _CreateProjectileLrtsia(ILocatable target)
		{
		}

		// Token: 0x060123CD RID: 74701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60123CD")]
		[Address(RVA = "0xA492C0", Offset = "0xA47EC0", VA = "0x180A492C0")]
		private Projectile _GenerateProjectile(ILocatable target, ILocatable startPoint, out Projectile fakeProjectile)
		{
			return null;
		}

		// Token: 0x060123CE RID: 74702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123CE")]
		[Address(RVA = "0xA48630", Offset = "0xA47230", VA = "0x180A48630")]
		private void _CalculateProjectileGeneratePos(ILocatable target)
		{
		}

		// Token: 0x060123CF RID: 74703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123CF")]
		[Address(RVA = "0xA483F0", Offset = "0xA46FF0", VA = "0x180A483F0", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x060123D0 RID: 74704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123D0")]
		[Address(RVA = "0xA493E0", Offset = "0xA47FE0", VA = "0x180A493E0")]
		public RangedAttackWithProjectilesRotatingAround()
		{
		}

		// Token: 0x060123D1 RID: 74705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123D1")]
		[Address(RVA = "0xA25D00", Offset = "0xA24900", VA = "0x180A25D00")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060123D2 RID: 74706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123D2")]
		[Address(RVA = "0xA36000", Offset = "0xA34C00", VA = "0x180A36000")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x060123D3 RID: 74707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123D3")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x04014A04 RID: 84484
		[Token(Token = "0x4014A04")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		private float _radius;

		// Token: 0x04014A05 RID: 84485
		[Token(Token = "0x4014A05")]
		[FieldOffset(Offset = "0x270")]
		[SerializeField]
		private string _radiusKey;

		// Token: 0x04014A06 RID: 84486
		[Token(Token = "0x4014A06")]
		[FieldOffset(Offset = "0x278")]
		[SerializeField]
		private int _initCount;

		// Token: 0x04014A07 RID: 84487
		[Token(Token = "0x4014A07")]
		[FieldOffset(Offset = "0x280")]
		[SerializeField]
		private string _initCountKey;

		// Token: 0x04014A08 RID: 84488
		[Token(Token = "0x4014A08")]
		[FieldOffset(Offset = "0x288")]
		[SerializeField]
		protected RangedAttackWithProjectilesRotatingAround.ProjectileType _projectileType;

		// Token: 0x04014A09 RID: 84489
		[Token(Token = "0x4014A09")]
		[FieldOffset(Offset = "0x28C")]
		protected float m_radius;

		// Token: 0x04014A0A RID: 84490
		[Token(Token = "0x4014A0A")]
		[FieldOffset(Offset = "0x290")]
		protected float m_speed;

		// Token: 0x04014A0B RID: 84491
		[Token(Token = "0x4014A0B")]
		[FieldOffset(Offset = "0x294")]
		protected int m_maxprojectileNum;

		// Token: 0x04014A0C RID: 84492
		[Token(Token = "0x4014A0C")]
		[FieldOffset(Offset = "0x298")]
		protected int m_initCount;

		// Token: 0x04014A0D RID: 84493
		[Token(Token = "0x4014A0D")]
		[FieldOffset(Offset = "0x29C")]
		protected float m_projectileRadius;

		// Token: 0x04014A0E RID: 84494
		[Token(Token = "0x4014A0E")]
		[FieldOffset(Offset = "0x2A0")]
		protected List<RangedAttackWithProjectilesRotatingAround.ProjectileWrapper> m_ProjectileWrapperList;

		// Token: 0x04014A0F RID: 84495
		[Token(Token = "0x4014A0F")]
		[FieldOffset(Offset = "0x2A8")]
		protected List<ILocatable> m_projectileStartPos;

		// Token: 0x04014A10 RID: 84496
		[Token(Token = "0x4014A10")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_managedProjectileCount;

		// Token: 0x04014A11 RID: 84497
		[Token(Token = "0x4014A11")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetProjectileWrapper;

		// Token: 0x04014A12 RID: 84498
		[Token(Token = "0x4014A12")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014A13 RID: 84499
		[Token(Token = "0x4014A13")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x04014A14 RID: 84500
		[Token(Token = "0x4014A14")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__CreateProjectile;

		// Token: 0x04014A15 RID: 84501
		[Token(Token = "0x4014A15")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CreateProjectileEnemyMain14;

		// Token: 0x04014A16 RID: 84502
		[Token(Token = "0x4014A16")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CreateProjectileLrtsia;

		// Token: 0x04014A17 RID: 84503
		[Token(Token = "0x4014A17")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenerateProjectile;

		// Token: 0x04014A18 RID: 84504
		[Token(Token = "0x4014A18")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__CalculateProjectileGeneratePos;

		// Token: 0x04014A19 RID: 84505
		[Token(Token = "0x4014A19")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04014A1A RID: 84506
		[Token(Token = "0x4014A1A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02002AC7 RID: 10951
		[Token(Token = "0x2002AC7")]
		public enum ProjectileType
		{
			// Token: 0x04014A1C RID: 84508
			[Token(Token = "0x4014A1C")]
			ENEMY_MAINLINE_14,
			// Token: 0x04014A1D RID: 84509
			[Token(Token = "0x4014A1D")]
			ENEMY_LRTSIA
		}

		// Token: 0x02002AC8 RID: 10952
		[Token(Token = "0x2002AC8")]
		public abstract class ProjectileWrapper
		{
			// Token: 0x060123D4 RID: 74708
			[Token(Token = "0x60123D4")]
			public abstract Projectile GetProjectile();

			// Token: 0x060123D5 RID: 74709
			[Token(Token = "0x60123D5")]
			public abstract Projectile GetGraphicProjectile();

			// Token: 0x060123D6 RID: 74710
			[Token(Token = "0x60123D6")]
			public abstract void SetProjectile(Projectile projectile);

			// Token: 0x060123D7 RID: 74711
			[Token(Token = "0x60123D7")]
			public abstract void SetGraphicProjectile(Projectile projectile);

			// Token: 0x060123D8 RID: 74712 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60123D8")]
			[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "8")]
			public virtual void SetProjectilePsition()
			{
			}

			// Token: 0x060123D9 RID: 74713 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60123D9")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			protected ProjectileWrapper()
			{
			}

			// Token: 0x04014A1E RID: 84510
			[Token(Token = "0x4014A1E")]
			[FieldOffset(Offset = "0x10")]
			protected Projectile m_projectile;

			// Token: 0x04014A1F RID: 84511
			[Token(Token = "0x4014A1F")]
			[FieldOffset(Offset = "0x18")]
			protected Projectile m_graphicProjectile;
		}

		// Token: 0x02002AC9 RID: 10953
		[Token(Token = "0x2002AC9")]
		public class EnemyMainline14ProjectileWrapper : RangedAttackWithProjectilesRotatingAround.ProjectileWrapper
		{
			// Token: 0x060123DA RID: 74714 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60123DA")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			public override Projectile GetGraphicProjectile()
			{
				return null;
			}

			// Token: 0x060123DB RID: 74715 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60123DB")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			public override Projectile GetProjectile()
			{
				return null;
			}

			// Token: 0x060123DC RID: 74716 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60123DC")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670", Slot = "7")]
			public override void SetGraphicProjectile(Projectile projectile)
			{
			}

			// Token: 0x060123DD RID: 74717 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60123DD")]
			[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40", Slot = "6")]
			public override void SetProjectile(Projectile projectile)
			{
			}

			// Token: 0x060123DE RID: 74718 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60123DE")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public EnemyMainline14ProjectileWrapper()
			{
			}
		}

		// Token: 0x02002ACA RID: 10954
		[Token(Token = "0x2002ACA")]
		public class LrtsiaProjectileWrapper : RangedAttackWithProjectilesRotatingAround.ProjectileWrapper
		{
			// Token: 0x17002801 RID: 10241
			// (get) Token: 0x060123DF RID: 74719 RVA: 0x0006FC90 File Offset: 0x0006DE90
			[Token(Token = "0x17002801")]
			public bool isActive
			{
				[Token(Token = "0x60123DF")]
				[Address(RVA = "0xA3D7A0", Offset = "0xA3C3A0", VA = "0x180A3D7A0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x17002802 RID: 10242
			// (get) Token: 0x060123E0 RID: 74720 RVA: 0x0006FCA8 File Offset: 0x0006DEA8
			[Token(Token = "0x17002802")]
			public float radius
			{
				[Token(Token = "0x60123E0")]
				[Address(RVA = "0x7E7500", Offset = "0x7E6100", VA = "0x1807E7500")]
				get
				{
					return 0f;
				}
			}

			// Token: 0x060123E1 RID: 74721 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60123E1")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "5")]
			public override Projectile GetGraphicProjectile()
			{
				return null;
			}

			// Token: 0x060123E2 RID: 74722 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60123E2")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
			public override Projectile GetProjectile()
			{
				return null;
			}

			// Token: 0x060123E3 RID: 74723 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60123E3")]
			[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670", Slot = "7")]
			public override void SetGraphicProjectile(Projectile projectile)
			{
			}

			// Token: 0x060123E4 RID: 74724 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60123E4")]
			[Address(RVA = "0xA3D6D0", Offset = "0xA3C2D0", VA = "0x180A3D6D0", Slot = "6")]
			public override void SetProjectile(Projectile projectile)
			{
			}

			// Token: 0x060123E5 RID: 74725 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60123E5")]
			[Address(RVA = "0x7E7510", Offset = "0x7E6110", VA = "0x1807E7510")]
			public void SetRadius(float radius)
			{
			}

			// Token: 0x060123E6 RID: 74726 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60123E6")]
			[Address(RVA = "0xA3D790", Offset = "0xA3C390", VA = "0x180A3D790")]
			public LrtsiaProjectileWrapper()
			{
			}

			// Token: 0x04014A20 RID: 84512
			[Token(Token = "0x4014A20")]
			[FieldOffset(Offset = "0x20")]
			private CoolDownAfterHitBehaviour m_coolDownHitBehaviour;

			// Token: 0x04014A21 RID: 84513
			[Token(Token = "0x4014A21")]
			[FieldOffset(Offset = "0x28")]
			private float m_radius;
		}
	}
}
