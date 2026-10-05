using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AA6 RID: 10918
	[Token(Token = "0x2002AA6")]
	public class BurstRangedAttack : RangedAttackWithConditionalActions
	{
		// Token: 0x0601224B RID: 74315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601224B")]
		[Address(RVA = "0xA36E40", Offset = "0xA35A40", VA = "0x180A36E40", Slot = "114")]
		protected override string GetProjectileKey()
		{
			return null;
		}

		// Token: 0x0601224C RID: 74316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601224C")]
		[Address(RVA = "0xA36D70", Offset = "0xA35970", VA = "0x180A36D70", Slot = "47")]
		public override void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x0601224D RID: 74317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601224D")]
		[Address(RVA = "0xA36F10", Offset = "0xA35B10", VA = "0x180A36F10", Slot = "51")]
		protected override void OnCastEnd(Ability.FinishReason reason)
		{
		}

		// Token: 0x0601224E RID: 74318 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601224E")]
		[Address(RVA = "0xA36CB0", Offset = "0xA358B0", VA = "0x180A36CB0", Slot = "113")]
		protected override Projectile CreateProjectile(ILocatable target, out Projectile fakeProjectile)
		{
			return null;
		}

		// Token: 0x0601224F RID: 74319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601224F")]
		[Address(RVA = "0xA36FC0", Offset = "0xA35BC0", VA = "0x180A36FC0", Slot = "63")]
		protected override void PreprocessActionsForProjectile(IList<ActionNode> projectileActions)
		{
		}

		// Token: 0x06012250 RID: 74320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012250")]
		[Address(RVA = "0xA371A0", Offset = "0xA35DA0", VA = "0x180A371A0")]
		private void _StackActionsByRemainingCount(IList<ActionNode> projectileActions)
		{
		}

		// Token: 0x06012251 RID: 74321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012251")]
		[Address(RVA = "0xA372C0", Offset = "0xA35EC0", VA = "0x180A372C0")]
		public BurstRangedAttack()
		{
		}

		// Token: 0x06012252 RID: 74322 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012252")]
		[Address(RVA = "0xA35FA0", Offset = "0xA34BA0", VA = "0x180A35FA0")]
		private string <>xLuaBaseProxy_GetProjectileKey()
		{
			return null;
		}

		// Token: 0x06012253 RID: 74323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012253")]
		[Address(RVA = "0xA35F90", Offset = "0xA34B90", VA = "0x180A35F90")]
		private void <>xLuaBaseProxy_GatherProjectiles(List<string> P0)
		{
		}

		// Token: 0x06012254 RID: 74324 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012254")]
		[Address(RVA = "0xA37180", Offset = "0xA35D80", VA = "0x180A37180")]
		private void <>xLuaBaseProxy_OnCastEnd(Ability.FinishReason P0)
		{
		}

		// Token: 0x06012255 RID: 74325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012255")]
		[Address(RVA = "0xA37170", Offset = "0xA35D70", VA = "0x180A37170")]
		private Projectile <>xLuaBaseProxy_CreateProjectile(ILocatable P0, out Projectile P1)
		{
			return null;
		}

		// Token: 0x06012256 RID: 74326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012256")]
		[Address(RVA = "0xA37190", Offset = "0xA35D90", VA = "0x180A37190")]
		private void <>xLuaBaseProxy_PreprocessActionsForProjectile(IList<ActionNode> P0)
		{
		}

		// Token: 0x04014877 RID: 84087
		[Token(Token = "0x4014877")]
		[FieldOffset(Offset = "0x270")]
		[SerializeField]
		private AbilityEventCounter _abilityEventCounter;

		// Token: 0x04014878 RID: 84088
		[Token(Token = "0x4014878")]
		[FieldOffset(Offset = "0x278")]
		private List<ActionNode> s_actionsBuffer;

		// Token: 0x04014879 RID: 84089
		[Token(Token = "0x4014879")]
		[FieldOffset(Offset = "0x280")]
		[SerializeField]
		private List<string> _burstProjectiles;

		// Token: 0x0401487A RID: 84090
		[Token(Token = "0x401487A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetProjectileKey;

		// Token: 0x0401487B RID: 84091
		[Token(Token = "0x401487B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x0401487C RID: 84092
		[Token(Token = "0x401487C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnCastEnd;

		// Token: 0x0401487D RID: 84093
		[Token(Token = "0x401487D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CreateProjectile;

		// Token: 0x0401487E RID: 84094
		[Token(Token = "0x401487E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_PreprocessActionsForProjectile;

		// Token: 0x0401487F RID: 84095
		[Token(Token = "0x401487F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__StackActionsByRemainingCount;

		// Token: 0x04014880 RID: 84096
		[Token(Token = "0x4014880")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
