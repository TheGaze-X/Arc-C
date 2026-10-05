using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BE8 RID: 11240
	[Token(Token = "0x2002BE8")]
	public class DiscardRemainingCount : AbilityStandard.Behaviour
	{
		// Token: 0x06012FBD RID: 77757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FBD")]
		[Address(RVA = "0xAE19C0", Offset = "0xAE05C0", VA = "0x180AE19C0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06012FBE RID: 77758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FBE")]
		[Address(RVA = "0xAE1B10", Offset = "0xAE0710", VA = "0x180AE1B10")]
		public DiscardRemainingCount()
		{
		}

		// Token: 0x06012FBF RID: 77759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012FBF")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x04015704 RID: 87812
		[Token(Token = "0x4015704")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AbilityStandard.Event _discardEvent;

		// Token: 0x04015705 RID: 87813
		[Token(Token = "0x4015705")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AbilityEventCounter _counterBehaviour;

		// Token: 0x04015706 RID: 87814
		[Token(Token = "0x4015706")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015707 RID: 87815
		[Token(Token = "0x4015707")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
