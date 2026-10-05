using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AAB RID: 10923
	[Token(Token = "0x2002AAB")]
	public class DuoRangedAttack : RangedAttack
	{
		// Token: 0x06012289 RID: 74377 RVA: 0x0006F468 File Offset: 0x0006D668
		[Token(Token = "0x6012289")]
		[Address(RVA = "0xA39F10", Offset = "0xA38B10", VA = "0x180A39F10", Slot = "85")]
		protected override bool DoCastOnTargets(IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
			return default(bool);
		}

		// Token: 0x0601228A RID: 74378 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601228A")]
		[Address(RVA = "0xA3A110", Offset = "0xA38D10", VA = "0x180A3A110", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x0601228B RID: 74379 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601228B")]
		[Address(RVA = "0xA39D90", Offset = "0xA38990", VA = "0x180A39D90", Slot = "113")]
		protected override Projectile CreateProjectile(ILocatable target, out Projectile fakeProjectile)
		{
			return null;
		}

		// Token: 0x0601228C RID: 74380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601228C")]
		[Address(RVA = "0xA3A050", Offset = "0xA38C50", VA = "0x180A3A050", Slot = "47")]
		public override void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x0601228D RID: 74381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601228D")]
		[Address(RVA = "0xA3A200", Offset = "0xA38E00", VA = "0x180A3A200")]
		public DuoRangedAttack()
		{
		}

		// Token: 0x0601228E RID: 74382 RVA: 0x0006F480 File Offset: 0x0006D680
		[Token(Token = "0x601228E")]
		[Address(RVA = "0xA39D20", Offset = "0xA38920", VA = "0x180A39D20")]
		private bool <>xLuaBaseProxy_DoCastOnTargets(IList<ActionNode> P0, IList<BuffData> P1, IList<IAbilityAttachment> P2)
		{
			return default(bool);
		}

		// Token: 0x0601228F RID: 74383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601228F")]
		[Address(RVA = "0xA36000", Offset = "0xA34C00", VA = "0x180A36000")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x06012290 RID: 74384 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012290")]
		[Address(RVA = "0xA37170", Offset = "0xA35D70", VA = "0x180A37170")]
		private Projectile <>xLuaBaseProxy_CreateProjectile(ILocatable P0, out Projectile P1)
		{
			return null;
		}

		// Token: 0x06012291 RID: 74385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012291")]
		[Address(RVA = "0xA35F90", Offset = "0xA34B90", VA = "0x180A35F90")]
		private void <>xLuaBaseProxy_GatherProjectiles(List<string> P0)
		{
		}

		// Token: 0x040148AE RID: 84142
		[Token(Token = "0x40148AE")]
		private const int DUO_ATTACK_SPLIT_FACTOR = 2;

		// Token: 0x040148AF RID: 84143
		[Token(Token = "0x40148AF")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		[Group("Duo")]
		private string _duoProjectileKey;

		// Token: 0x040148B0 RID: 84144
		[Token(Token = "0x40148B0")]
		[FieldOffset(Offset = "0x270")]
		[SerializeField]
		[Group("Duo")]
		private Entity.MountPointType _duoMountPointType;

		// Token: 0x040148B1 RID: 84145
		[Token(Token = "0x40148B1")]
		[FieldOffset(Offset = "0x274")]
		[SerializeField]
		[Group("Duo")]
		[Tooltip("If there is only one target, hit it with two projectiles")]
		private bool _lastTargetDuoAttack;

		// Token: 0x040148B2 RID: 84146
		[Token(Token = "0x40148B2")]
		[FieldOffset(Offset = "0x278")]
		private int m_targetCount;

		// Token: 0x040148B3 RID: 84147
		[Token(Token = "0x40148B3")]
		[FieldOffset(Offset = "0x280")]
		private ObjectPtr<Entity> m_cachedTarget;

		// Token: 0x040148B4 RID: 84148
		[Token(Token = "0x40148B4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoCastOnTargets;

		// Token: 0x040148B5 RID: 84149
		[Token(Token = "0x40148B5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x040148B6 RID: 84150
		[Token(Token = "0x40148B6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CreateProjectile;

		// Token: 0x040148B7 RID: 84151
		[Token(Token = "0x40148B7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x040148B8 RID: 84152
		[Token(Token = "0x40148B8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
