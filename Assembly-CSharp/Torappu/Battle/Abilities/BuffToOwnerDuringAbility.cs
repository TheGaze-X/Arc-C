using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BE0 RID: 11232
	[Token(Token = "0x2002BE0")]
	public class BuffToOwnerDuringAbility : AbilityStandard.Behaviour, IEffectSource, IBuffSource
	{
		// Token: 0x06012F79 RID: 77689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F79")]
		[Address(RVA = "0xADD0F0", Offset = "0xADBCF0", VA = "0x180ADD0F0", Slot = "16")]
		public void GatherEffects(List<string> effects)
		{
		}

		// Token: 0x06012F7A RID: 77690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F7A")]
		[Address(RVA = "0xADD060", Offset = "0xADBC60", VA = "0x180ADD060", Slot = "17")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012F7B RID: 77691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F7B")]
		[Address(RVA = "0xADD390", Offset = "0xADBF90", VA = "0x180ADD390")]
		private void _AddBuffs()
		{
		}

		// Token: 0x06012F7C RID: 77692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F7C")]
		[Address(RVA = "0xADD4F0", Offset = "0xADC0F0", VA = "0x180ADD4F0")]
		private void _ClearBuffs()
		{
		}

		// Token: 0x06012F7D RID: 77693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F7D")]
		[Address(RVA = "0xADD160", Offset = "0xADBD60", VA = "0x180ADD160", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012F7E RID: 77694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F7E")]
		[Address(RVA = "0xADD5E0", Offset = "0xADC1E0", VA = "0x180ADD5E0")]
		public BuffToOwnerDuringAbility()
		{
		}

		// Token: 0x06012F7F RID: 77695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F7F")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x04015695 RID: 87701
		[Token(Token = "0x4015695")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AbilityStandard.Event _startEvent;

		// Token: 0x04015696 RID: 87702
		[Token(Token = "0x4015696")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private AbilityStandard.Event _endEvent;

		// Token: 0x04015697 RID: 87703
		[Token(Token = "0x4015697")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuffData[] _buffs;

		// Token: 0x04015698 RID: 87704
		[Token(Token = "0x4015698")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private bool _forceFinishBuffOnCastEnd;

		// Token: 0x04015699 RID: 87705
		[Token(Token = "0x4015699")]
		[FieldOffset(Offset = "0x38")]
		private List<uint> m_buffUid;

		// Token: 0x0401569A RID: 87706
		[Token(Token = "0x401569A")]
		[FieldOffset(Offset = "0x40")]
		private bool m_buffAdded;

		// Token: 0x0401569B RID: 87707
		[Token(Token = "0x401569B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GatherEffects;

		// Token: 0x0401569C RID: 87708
		[Token(Token = "0x401569C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x0401569D RID: 87709
		[Token(Token = "0x401569D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__AddBuffs;

		// Token: 0x0401569E RID: 87710
		[Token(Token = "0x401569E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ClearBuffs;

		// Token: 0x0401569F RID: 87711
		[Token(Token = "0x401569F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x040156A0 RID: 87712
		[Token(Token = "0x40156A0")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
