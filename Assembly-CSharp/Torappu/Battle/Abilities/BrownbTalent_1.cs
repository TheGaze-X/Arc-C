using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002B88 RID: 11144
	[Token(Token = "0x2002B88")]
	public class BrownbTalent_1 : PassiveBuffAbility, IAbilityAttachment
	{
		// Token: 0x06012BEF RID: 76783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012BEF")]
		[Address(RVA = "0xAB13C0", Offset = "0xAAFFC0", VA = "0x180AB13C0", Slot = "42")]
		protected override IList<BuffData> GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012BF0 RID: 76784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BF0")]
		[Address(RVA = "0xAB12E0", Offset = "0xAAFEE0", VA = "0x180AB12E0", Slot = "26")]
		protected override void DoSetData(Entity owner, Ability.Options options)
		{
		}

		// Token: 0x06012BF1 RID: 76785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BF1")]
		[Address(RVA = "0xAB1120", Offset = "0xAAFD20", VA = "0x180AB1120", Slot = "29")]
		protected override void DoAttach(Entity owner)
		{
		}

		// Token: 0x06012BF2 RID: 76786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BF2")]
		[Address(RVA = "0xAB0E20", Offset = "0xAAFA20", VA = "0x180AB0E20", Slot = "96")]
		public void Apply(Entity target, Entity owner, Ability ability, Blackboard externalBlackboard)
		{
		}

		// Token: 0x06012BF3 RID: 76787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BF3")]
		[Address(RVA = "0xAB1420", Offset = "0xAB0020", VA = "0x180AB1420", Slot = "52")]
		protected override void OnAttached()
		{
		}

		// Token: 0x06012BF4 RID: 76788 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BF4")]
		[Address(RVA = "0xAB14B0", Offset = "0xAB00B0", VA = "0x180AB14B0", Slot = "53")]
		protected override void OnDetached()
		{
		}

		// Token: 0x06012BF5 RID: 76789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BF5")]
		[Address(RVA = "0xAB1540", Offset = "0xAB0140", VA = "0x180AB1540")]
		public BrownbTalent_1()
		{
		}

		// Token: 0x06012BF6 RID: 76790 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6012BF6")]
		[Address(RVA = "0xAB1530", Offset = "0xAB0130", VA = "0x180AB1530")]
		private IList<BuffData> <>xLuaBaseProxy_GetPassiveBuffs()
		{
			return null;
		}

		// Token: 0x06012BF7 RID: 76791 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BF7")]
		[Address(RVA = "0xA1E4E0", Offset = "0xA1D0E0", VA = "0x180A1E4E0")]
		private void <>xLuaBaseProxy_DoSetData(Entity P0, Ability.Options P1)
		{
		}

		// Token: 0x06012BF8 RID: 76792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BF8")]
		[Address(RVA = "0xA64260", Offset = "0xA62E60", VA = "0x180A64260")]
		private void <>xLuaBaseProxy_DoAttach(Entity P0)
		{
		}

		// Token: 0x06012BF9 RID: 76793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BF9")]
		[Address(RVA = "0xA225F0", Offset = "0xA211F0", VA = "0x180A225F0")]
		private void <>xLuaBaseProxy_OnAttached()
		{
		}

		// Token: 0x06012BFA RID: 76794 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012BFA")]
		[Address(RVA = "0xA22600", Offset = "0xA21200", VA = "0x180A22600")]
		private void <>xLuaBaseProxy_OnDetached()
		{
		}

		// Token: 0x040152E7 RID: 86759
		[Token(Token = "0x40152E7")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		protected BuffData _stackBuff;

		// Token: 0x040152E8 RID: 86760
		[Token(Token = "0x40152E8")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		private Ability.FamilyGroupMask _targetFamilyMask;

		// Token: 0x040152E9 RID: 86761
		[Token(Token = "0x40152E9")]
		[FieldOffset(Offset = "0x124")]
		[SerializeField]
		private bool _onlyApplyOnFirstSpell;

		// Token: 0x040152EA RID: 86762
		[Token(Token = "0x40152EA")]
		[FieldOffset(Offset = "0x125")]
		[SerializeField]
		private bool _ignoreOwnerAsTarget;

		// Token: 0x040152EB RID: 86763
		[Token(Token = "0x40152EB")]
		[FieldOffset(Offset = "0x128")]
		private string m_overrideKey;

		// Token: 0x040152EC RID: 86764
		[Token(Token = "0x40152EC")]
		[FieldOffset(Offset = "0x130")]
		private int m_additionalStackCnt;

		// Token: 0x040152ED RID: 86765
		[Token(Token = "0x40152ED")]
		[FieldOffset(Offset = "0x138")]
		private ObjectPtr<Entity> m_lastTarget;

		// Token: 0x040152EE RID: 86766
		[Token(Token = "0x40152EE")]
		[FieldOffset(Offset = "0x148")]
		private Buff.OverrideGroup m_lastOverrideGroup;

		// Token: 0x040152EF RID: 86767
		[Token(Token = "0x40152EF")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetPassiveBuffs;

		// Token: 0x040152F0 RID: 86768
		[Token(Token = "0x40152F0")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoSetData;

		// Token: 0x040152F1 RID: 86769
		[Token(Token = "0x40152F1")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x040152F2 RID: 86770
		[Token(Token = "0x40152F2")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_Apply;

		// Token: 0x040152F3 RID: 86771
		[Token(Token = "0x40152F3")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnAttached;

		// Token: 0x040152F4 RID: 86772
		[Token(Token = "0x40152F4")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDetached;

		// Token: 0x040152F5 RID: 86773
		[Token(Token = "0x40152F5")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
