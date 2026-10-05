using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AAD RID: 10925
	[Token(Token = "0x2002AAD")]
	public class FunnelNormalAttack : RangedAttack
	{
		// Token: 0x060122AC RID: 74412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122AC")]
		[Address(RVA = "0xA3B8A0", Offset = "0xA3A4A0", VA = "0x180A3B8A0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060122AD RID: 74413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122AD")]
		[Address(RVA = "0xA3BA70", Offset = "0xA3A670", VA = "0x180A3BA70", Slot = "73")]
		protected override void OnCastOnTarget(Entity target, IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
		}

		// Token: 0x060122AE RID: 74414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122AE")]
		[Address(RVA = "0xA3BBE0", Offset = "0xA3A7E0", VA = "0x180A3BBE0")]
		public FunnelNormalAttack()
		{
		}

		// Token: 0x060122AF RID: 74415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122AF")]
		[Address(RVA = "0xA25D00", Offset = "0xA24900", VA = "0x180A25D00")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060122B0 RID: 74416 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122B0")]
		[Address(RVA = "0xA36000", Offset = "0xA34C00", VA = "0x180A36000")]
		private void <>xLuaBaseProxy_OnCastOnTarget(Entity P0, IList<ActionNode> P1, IList<BuffData> P2, IList<IAbilityAttachment> P3)
		{
		}

		// Token: 0x040148D5 RID: 84181
		[Token(Token = "0x40148D5")]
		[FieldOffset(Offset = "0x268")]
		private CammouTrait m_trait;

		// Token: 0x040148D6 RID: 84182
		[Token(Token = "0x40148D6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040148D7 RID: 84183
		[Token(Token = "0x40148D7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCastOnTarget;

		// Token: 0x040148D8 RID: 84184
		[Token(Token = "0x40148D8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
