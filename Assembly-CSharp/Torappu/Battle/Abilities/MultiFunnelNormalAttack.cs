using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AB3 RID: 10931
	[Token(Token = "0x2002AB3")]
	public class MultiFunnelNormalAttack : RangedAttack
	{
		// Token: 0x060122F6 RID: 74486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122F6")]
		[Address(RVA = "0xA3FA20", Offset = "0xA3E620", VA = "0x180A3FA20", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060122F7 RID: 74487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122F7")]
		[Address(RVA = "0xA3FBF0", Offset = "0xA3E7F0", VA = "0x180A3FBF0", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x060122F8 RID: 74488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122F8")]
		[Address(RVA = "0xA3FD60", Offset = "0xA3E960", VA = "0x180A3FD60", Slot = "93")]
		protected override void OnOutputAttackOrHeal()
		{
		}

		// Token: 0x060122F9 RID: 74489 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122F9")]
		[Address(RVA = "0xA3FDD0", Offset = "0xA3E9D0", VA = "0x180A3FDD0")]
		public MultiFunnelNormalAttack()
		{
		}

		// Token: 0x060122FA RID: 74490 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122FA")]
		[Address(RVA = "0xA25D00", Offset = "0xA24900", VA = "0x180A25D00")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060122FB RID: 74491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122FB")]
		[Address(RVA = "0xA36000", Offset = "0xA34C00", VA = "0x180A36000")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x060122FC RID: 74492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122FC")]
		[Address(RVA = "0xA3FDC0", Offset = "0xA3E9C0", VA = "0x180A3FDC0")]
		private void <>xLuaBaseProxy_OnOutputAttackOrHeal()
		{
		}

		// Token: 0x04014920 RID: 84256
		[Token(Token = "0x4014920")]
		[FieldOffset(Offset = "0x268")]
		private MultiFunnelTrait m_trait;

		// Token: 0x04014921 RID: 84257
		[Token(Token = "0x4014921")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x04014922 RID: 84258
		[Token(Token = "0x4014922")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x04014923 RID: 84259
		[Token(Token = "0x4014923")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnOutputAttackOrHeal;

		// Token: 0x04014924 RID: 84260
		[Token(Token = "0x4014924")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
