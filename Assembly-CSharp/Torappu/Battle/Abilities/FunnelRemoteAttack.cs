using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Battle.Action;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002AAE RID: 10926
	[Token(Token = "0x2002AAE")]
	public class FunnelRemoteAttack : RangedAttack
	{
		// Token: 0x060122B1 RID: 74417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122B1")]
		[Address(RVA = "0xA3C200", Offset = "0xA3AE00", VA = "0x180A3C200", Slot = "40")]
		protected override void Reset()
		{
		}

		// Token: 0x060122B2 RID: 74418 RVA: 0x0006F570 File Offset: 0x0006D770
		[Token(Token = "0x60122B2")]
		[Address(RVA = "0xA3BD60", Offset = "0xA3A960", VA = "0x180A3BD60", Slot = "85")]
		protected override bool DoCastOnTargets(IList<ActionNode> actions, IList<BuffData> buffs, IList<IAbilityAttachment> attachments)
		{
			return default(bool);
		}

		// Token: 0x060122B3 RID: 74419 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122B3")]
		[Address(RVA = "0xA3BC40", Offset = "0xA3A840", VA = "0x180A3BC40", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x060122B4 RID: 74420 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122B4")]
		[Address(RVA = "0xA3BEB0", Offset = "0xA3AAB0", VA = "0x180A3BEB0", Slot = "30")]
		protected override void DoDetach()
		{
		}

		// Token: 0x060122B5 RID: 74421 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122B5")]
		[Address(RVA = "0xA3C020", Offset = "0xA3AC20", VA = "0x180A3C020", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x060122B6 RID: 74422 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122B6")]
		[Address(RVA = "0xA3C280", Offset = "0xA3AE80", VA = "0x180A3C280")]
		private void _RecycleFunnel(object param)
		{
		}

		// Token: 0x060122B7 RID: 74423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122B7")]
		[Address(RVA = "0xA3C100", Offset = "0xA3AD00", VA = "0x180A3C100", Slot = "54")]
		public override void OnTick(FP deltaTime)
		{
		}

		// Token: 0x060122B8 RID: 74424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122B8")]
		[Address(RVA = "0xA3C2F0", Offset = "0xA3AEF0", VA = "0x180A3C2F0")]
		public FunnelRemoteAttack()
		{
		}

		// Token: 0x060122B9 RID: 74425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122B9")]
		[Address(RVA = "0xA36020", Offset = "0xA34C20", VA = "0x180A36020")]
		private void <>xLuaBaseProxy_Reset()
		{
		}

		// Token: 0x060122BA RID: 74426 RVA: 0x0006F588 File Offset: 0x0006D788
		[Token(Token = "0x60122BA")]
		[Address(RVA = "0xA39D20", Offset = "0xA38920", VA = "0x180A39D20")]
		private bool <>xLuaBaseProxy_DoCastOnTargets(IList<ActionNode> P0, IList<BuffData> P1, IList<IAbilityAttachment> P2)
		{
			return default(bool);
		}

		// Token: 0x060122BB RID: 74427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122BB")]
		[Address(RVA = "0xA27580", Offset = "0xA26180", VA = "0x180A27580")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x060122BC RID: 74428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122BC")]
		[Address(RVA = "0xA3C270", Offset = "0xA3AE70", VA = "0x180A3C270")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x060122BD RID: 74429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122BD")]
		[Address(RVA = "0xA25D00", Offset = "0xA24900", VA = "0x180A25D00")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x060122BE RID: 74430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60122BE")]
		[Address(RVA = "0xA38EF0", Offset = "0xA37AF0", VA = "0x180A38EF0")]
		private void <>xLuaBaseProxy_OnTick(FP P0)
		{
		}

		// Token: 0x040148D9 RID: 84185
		[Token(Token = "0x40148D9")]
		[FieldOffset(Offset = "0x268")]
		[SerializeField]
		private Ability _funnelAction;

		// Token: 0x040148DA RID: 84186
		[Token(Token = "0x40148DA")]
		[FieldOffset(Offset = "0x270")]
		private bool m_hasFireFunnel;

		// Token: 0x040148DB RID: 84187
		[Token(Token = "0x40148DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Reset;

		// Token: 0x040148DC RID: 84188
		[Token(Token = "0x40148DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoCastOnTargets;

		// Token: 0x040148DD RID: 84189
		[Token(Token = "0x40148DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x040148DE RID: 84190
		[Token(Token = "0x40148DE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x040148DF RID: 84191
		[Token(Token = "0x40148DF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040148E0 RID: 84192
		[Token(Token = "0x40148E0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RecycleFunnel;

		// Token: 0x040148E1 RID: 84193
		[Token(Token = "0x40148E1")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x040148E2 RID: 84194
		[Token(Token = "0x40148E2")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
