using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BA6 RID: 11174
	[Token(Token = "0x2002BA6")]
	public class MhwrctSkill_1 : AbstractAnimatedAbility
	{
		// Token: 0x06012D7E RID: 77182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012D7E")]
		[Address(RVA = "0xAC5360", Offset = "0xAC3F60", VA = "0x180AC5360", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012D7F RID: 77183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012D7F")]
		[Address(RVA = "0xAC53D0", Offset = "0xAC3FD0", VA = "0x180AC53D0", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012D80 RID: 77184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D80")]
		[Address(RVA = "0xAC52A0", Offset = "0xAC3EA0", VA = "0x180AC52A0", Slot = "47")]
		public override void GatherProjectiles(List<string> projectiles)
		{
		}

		// Token: 0x06012D81 RID: 77185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D81")]
		[Address(RVA = "0xAC5460", Offset = "0xAC4060", VA = "0x180AC5460", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x06012D82 RID: 77186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D82")]
		[Address(RVA = "0xAC51B0", Offset = "0xAC3DB0", VA = "0x180AC51B0", Slot = "64")]
		public override void ClearProjectile()
		{
		}

		// Token: 0x06012D83 RID: 77187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D83")]
		[Address(RVA = "0xAC5AD0", Offset = "0xAC46D0", VA = "0x180AC5AD0")]
		private void _CreateProjectile(Entity from)
		{
		}

		// Token: 0x06012D84 RID: 77188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D84")]
		[Address(RVA = "0xAC5C40", Offset = "0xAC4840", VA = "0x180AC5C40")]
		public MhwrctSkill_1()
		{
		}

		// Token: 0x06012D85 RID: 77189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D85")]
		[Address(RVA = "0xA4B080", Offset = "0xA49C80", VA = "0x180A4B080")]
		private void <>xLuaBaseProxy_GatherProjectiles(List<string> P0)
		{
		}

		// Token: 0x06012D86 RID: 77190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D86")]
		[Address(RVA = "0xA25740", Offset = "0xA24340", VA = "0x180A25740")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x06012D87 RID: 77191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012D87")]
		[Address(RVA = "0xA4B070", Offset = "0xA49C70", VA = "0x180A4B070")]
		private void <>xLuaBaseProxy_ClearProjectile()
		{
		}

		// Token: 0x04015434 RID: 87092
		[Token(Token = "0x4015434")]
		[FieldOffset(Offset = "0x1C8")]
		[SerializeField]
		private string _projectileKey;

		// Token: 0x04015435 RID: 87093
		[Token(Token = "0x4015435")]
		[FieldOffset(Offset = "0x1D0")]
		private ObjectPtr<Projectile> m_projectile;

		// Token: 0x04015436 RID: 87094
		[Token(Token = "0x4015436")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04015437 RID: 87095
		[Token(Token = "0x4015437")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04015438 RID: 87096
		[Token(Token = "0x4015438")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GatherProjectiles;

		// Token: 0x04015439 RID: 87097
		[Token(Token = "0x4015439")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x0401543A RID: 87098
		[Token(Token = "0x401543A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ClearProjectile;

		// Token: 0x0401543B RID: 87099
		[Token(Token = "0x401543B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__CreateProjectile;

		// Token: 0x0401543C RID: 87100
		[Token(Token = "0x401543C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
