using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AD9 RID: 10969
	[Token(Token = "0x2002AD9")]
	public abstract class CastOnProjectileAbility : AbstractAnimatedAbility
	{
		// Token: 0x0601248F RID: 74895 RVA: 0x00070050 File Offset: 0x0006E250
		[Token(Token = "0x601248F")]
		[Address(RVA = "0xA51620", Offset = "0xA50220", VA = "0x180A51620", Slot = "85")]
		protected override bool DoCastOnTargets(IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
			return default(bool);
		}

		// Token: 0x06012490 RID: 74896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012490")]
		[Address(RVA = "0xA51580", Offset = "0xA50180", VA = "0x180A51580", Slot = "41")]
		protected override void CleanupForNextCast()
		{
		}

		// Token: 0x06012491 RID: 74897 RVA: 0x00070068 File Offset: 0x0006E268
		[Token(Token = "0x6012491")]
		[Address(RVA = "0xA51900", Offset = "0xA50500", VA = "0x180A51900", Slot = "86")]
		protected override bool UpdateTargets(bool updateInputPos = false)
		{
			return default(bool);
		}

		// Token: 0x06012492 RID: 74898
		[Token(Token = "0x6012492")]
		protected abstract void OnCastOnProjectile(Projectile projectile, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments);

		// Token: 0x06012493 RID: 74899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012493")]
		[Address(RVA = "0xA517F0", Offset = "0xA503F0", VA = "0x180A517F0", Slot = "72")]
		protected override IList<ActionNode> GetEventActions(AbilityStandard.Event ev)
		{
			return null;
		}

		// Token: 0x06012494 RID: 74900 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012494")]
		[Address(RVA = "0xA51860", Offset = "0xA50460", VA = "0x180A51860", Slot = "44")]
		public override IList<ActionNode> GetProjectileActions(Projectile.Event ev, Projectile projectile)
		{
			return null;
		}

		// Token: 0x06012495 RID: 74901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012495")]
		[Address(RVA = "0xA52190", Offset = "0xA50D90", VA = "0x180A52190")]
		protected CastOnProjectileAbility()
		{
		}

		// Token: 0x06012496 RID: 74902 RVA: 0x00070080 File Offset: 0x0006E280
		[Token(Token = "0x6012496")]
		[Address(RVA = "0xA25730", Offset = "0xA24330", VA = "0x180A25730")]
		private bool <>xLuaBaseProxy_DoCastOnTargets(IList<ActionNode> P0, IList<BuffData> P1, IList<IAbilityAttachment> P2)
		{
			return default(bool);
		}

		// Token: 0x06012497 RID: 74903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012497")]
		[Address(RVA = "0xA518F0", Offset = "0xA504F0", VA = "0x180A518F0")]
		private void <>xLuaBaseProxy_CleanupForNextCast()
		{
		}

		// Token: 0x06012498 RID: 74904 RVA: 0x00070098 File Offset: 0x0006E298
		[Token(Token = "0x6012498")]
		[Address(RVA = "0xA25D30", Offset = "0xA24930", VA = "0x180A25D30")]
		private bool <>xLuaBaseProxy_UpdateTargets(bool P0)
		{
			return default(bool);
		}

		// Token: 0x04014ACA RID: 84682
		[Token(Token = "0x4014ACA")]
		[FieldOffset(Offset = "0x1C8")]
		private List<ObjectPtr<Projectile>> m_castProjectiles;

		// Token: 0x04014ACB RID: 84683
		[Token(Token = "0x4014ACB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoCastOnTargets;

		// Token: 0x04014ACC RID: 84684
		[Token(Token = "0x4014ACC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CleanupForNextCast;

		// Token: 0x04014ACD RID: 84685
		[Token(Token = "0x4014ACD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_UpdateTargets;

		// Token: 0x04014ACE RID: 84686
		[Token(Token = "0x4014ACE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetEventActions;

		// Token: 0x04014ACF RID: 84687
		[Token(Token = "0x4014ACF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_GetProjectileActions;

		// Token: 0x04014AD0 RID: 84688
		[Token(Token = "0x4014AD0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
