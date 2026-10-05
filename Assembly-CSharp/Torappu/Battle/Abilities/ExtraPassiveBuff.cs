using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BE2 RID: 11234
	[Token(Token = "0x2002BE2")]
	public class ExtraPassiveBuff : AbilityStandard.Behaviour, IBuffSource
	{
		// Token: 0x06012F85 RID: 77701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F85")]
		[Address(RVA = "0xAE2E80", Offset = "0xAE1A80", VA = "0x180AE2E80", Slot = "16")]
		public void GatherBuffs(List<BuffData> results)
		{
		}

		// Token: 0x06012F86 RID: 77702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F86")]
		[Address(RVA = "0xAE2F10", Offset = "0xAE1B10", VA = "0x180AE2F10", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012F87 RID: 77703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F87")]
		[Address(RVA = "0xAE3110", Offset = "0xAE1D10", VA = "0x180AE3110")]
		public ExtraPassiveBuff()
		{
		}

		// Token: 0x06012F88 RID: 77704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F88")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x040156A9 RID: 87721
		[Token(Token = "0x40156A9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuffData[] _passiveBuffs;

		// Token: 0x040156AA RID: 87722
		[Token(Token = "0x40156AA")]
		[FieldOffset(Offset = "0x28")]
		private List<uint> m_buffUids;

		// Token: 0x040156AB RID: 87723
		[Token(Token = "0x40156AB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GatherBuffs;

		// Token: 0x040156AC RID: 87724
		[Token(Token = "0x40156AC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x040156AD RID: 87725
		[Token(Token = "0x40156AD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
