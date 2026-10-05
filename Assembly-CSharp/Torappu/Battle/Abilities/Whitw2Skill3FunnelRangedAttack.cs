using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002ACB RID: 10955
	[Token(Token = "0x2002ACB")]
	public class Whitw2Skill3FunnelRangedAttack : RangedAttack
	{
		// Token: 0x060123E7 RID: 74727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123E7")]
		[Address(RVA = "0xA61C50", Offset = "0xA60850", VA = "0x180A61C50", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060123E8 RID: 74728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123E8")]
		[Address(RVA = "0xA61850", Offset = "0xA60450", VA = "0x180A61850", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x060123E9 RID: 74729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123E9")]
		[Address(RVA = "0xA61E90", Offset = "0xA60A90", VA = "0x180A61E90", Slot = "50")]
		protected override void OnCastStart()
		{
		}

		// Token: 0x060123EA RID: 74730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123EA")]
		[Address(RVA = "0xA61DF0", Offset = "0xA609F0", VA = "0x180A61DF0", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x060123EB RID: 74731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123EB")]
		[Address(RVA = "0xA62E30", Offset = "0xA61A30", VA = "0x180A62E30")]
		private void _DoPlayAttack(Entity target)
		{
		}

		// Token: 0x060123EC RID: 74732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123EC")]
		[Address(RVA = "0xA61FD0", Offset = "0xA60BD0", VA = "0x180A61FD0", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x060123ED RID: 74733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123ED")]
		[Address(RVA = "0xA62380", Offset = "0xA60F80", VA = "0x180A62380", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x060123EE RID: 74734 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123EE")]
		[Address(RVA = "0xA625C0", Offset = "0xA611C0", VA = "0x180A625C0")]
		public void UpdateActiveCntIfAdded()
		{
		}

		// Token: 0x060123EF RID: 74735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123EF")]
		[Address(RVA = "0xA62460", Offset = "0xA61060", VA = "0x180A62460")]
		public void RuntimeApplyAttack(Entity target)
		{
		}

		// Token: 0x060123F0 RID: 74736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60123F0")]
		[Address(RVA = "0xA62CB0", Offset = "0xA618B0", VA = "0x180A62CB0")]
		private Projectile _CreateAroundProjectile(ILocatable target, out Projectile fakeProjectile, int projectileIndex)
		{
			return null;
		}

		// Token: 0x060123F1 RID: 74737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123F1")]
		[Address(RVA = "0xA626F0", Offset = "0xA612F0", VA = "0x180A626F0")]
		private void _CalculateProjectilesStartPos(Entity target)
		{
		}

		// Token: 0x060123F2 RID: 74738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123F2")]
		[Address(RVA = "0xA61340", Offset = "0xA5FF40", VA = "0x180A61340")]
		public void AttachFunnelProjectileToTarget(Unit target, int projectileIndex)
		{
		}

		// Token: 0x060123F3 RID: 74739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123F3")]
		[Address(RVA = "0xA63280", Offset = "0xA61E80", VA = "0x180A63280")]
		public Whitw2Skill3FunnelRangedAttack()
		{
		}

		// Token: 0x060123F4 RID: 74740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123F4")]
		[Address(RVA = "0xA25D00", Offset = "0xA24900", VA = "0x180A25D00")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060123F5 RID: 74741 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123F5")]
		[Address(RVA = "0xA27580", Offset = "0xA26180", VA = "0x180A27580")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x060123F6 RID: 74742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123F6")]
		[Address(RVA = "0xA36010", Offset = "0xA34C10", VA = "0x180A36010")]
		private void <>xLuaBaseProxy_OnCastStart()
		{
		}

		// Token: 0x060123F7 RID: 74743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123F7")]
		[Address(RVA = "0xA36000", Offset = "0xA34C00", VA = "0x180A36000")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x060123F8 RID: 74744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123F8")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x060123F9 RID: 74745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60123F9")]
		[Address(RVA = "0xA36020", Offset = "0xA34C20", VA = "0x180A36020")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x04014A22 RID: 84514
		[Token(Token = "0x4014A22")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		[Group("ExtraFunnelConfig")]
		private bool _useExtraActiveCntAbility;

		// Token: 0x04014A23 RID: 84515
		[Token(Token = "0x4014A23")]
		[FieldOffset(Offset = "0x26C")]
		[SerializeField]
		[Group("Projectile")]
		private float _projectileInitRadius;

		// Token: 0x04014A24 RID: 84516
		[Token(Token = "0x4014A24")]
		[FieldOffset(Offset = "0x270")]
		[SerializeField]
		[Group("Projectile")]
		private bool _clearProjectilesWhenDetached;

		// Token: 0x04014A25 RID: 84517
		[Token(Token = "0x4014A25")]
		[FieldOffset(Offset = "0x278")]
		[SerializeField]
		[Group("Projectile")]
		private string[] _cruiseProjectileKeys;

		// Token: 0x04014A26 RID: 84518
		[Token(Token = "0x4014A26")]
		[FieldOffset(Offset = "0x280")]
		[SerializeField]
		[Group("Projectile")]
		private string[] _funnelProjectileKeys;

		// Token: 0x04014A27 RID: 84519
		[Token(Token = "0x4014A27")]
		[FieldOffset(Offset = "0x288")]
		[SerializeField]
		private Ability[] _funnelActions;

		// Token: 0x04014A28 RID: 84520
		[Token(Token = "0x4014A28")]
		[FieldOffset(Offset = "0x290")]
		private int m_activeCnt;

		// Token: 0x04014A29 RID: 84521
		[Token(Token = "0x4014A29")]
		[FieldOffset(Offset = "0x294")]
		private int m_alreadyAttackCnt;

		// Token: 0x04014A2A RID: 84522
		[Token(Token = "0x4014A2A")]
		[FieldOffset(Offset = "0x298")]
		private MultiFunnelExtraActiveCntAbility m_extraActiveCntStorage;

		// Token: 0x04014A2B RID: 84523
		[Token(Token = "0x4014A2B")]
		[FieldOffset(Offset = "0x2A0")]
		private List<ILocatable> m_projectileStartPos;

		// Token: 0x04014A2C RID: 84524
		[Token(Token = "0x4014A2C")]
		[FieldOffset(Offset = "0x2A8")]
		private float m_projectileAroundRadius;

		// Token: 0x04014A2D RID: 84525
		[Token(Token = "0x4014A2D")]
		[FieldOffset(Offset = "0x2B0")]
		private List<ObjectPtr<Projectile>> m_cruiseProjectile;

		// Token: 0x04014A2E RID: 84526
		[Token(Token = "0x4014A2E")]
		[FieldOffset(Offset = "0x2B8")]
		private List<ObjectPtr<Projectile>> m_funnelProjectile;

		// Token: 0x04014A2F RID: 84527
		[Token(Token = "0x4014A2F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014A30 RID: 84528
		[Token(Token = "0x4014A30")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04014A31 RID: 84529
		[Token(Token = "0x4014A31")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastStart;

		// Token: 0x04014A32 RID: 84530
		[Token(Token = "0x4014A32")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x04014A33 RID: 84531
		[Token(Token = "0x4014A33")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DoPlayAttack;

		// Token: 0x04014A34 RID: 84532
		[Token(Token = "0x4014A34")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x04014A35 RID: 84533
		[Token(Token = "0x4014A35")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x04014A36 RID: 84534
		[Token(Token = "0x4014A36")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateActiveCntIfAdded;

		// Token: 0x04014A37 RID: 84535
		[Token(Token = "0x4014A37")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RuntimeApplyAttack;

		// Token: 0x04014A38 RID: 84536
		[Token(Token = "0x4014A38")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CreateAroundProjectile;

		// Token: 0x04014A39 RID: 84537
		[Token(Token = "0x4014A39")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__CalculateProjectilesStartPos;

		// Token: 0x04014A3A RID: 84538
		[Token(Token = "0x4014A3A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_AttachFunnelProjectileToTarget;

		// Token: 0x04014A3B RID: 84539
		[Token(Token = "0x4014A3B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
