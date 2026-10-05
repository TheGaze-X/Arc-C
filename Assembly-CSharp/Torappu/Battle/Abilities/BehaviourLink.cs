using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C12 RID: 11282
	[Token(Token = "0x2002C12")]
	public class BehaviourLink : AbilityStandard.Behaviour
	{
		// Token: 0x060130DB RID: 78043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130DB")]
		[Address(RVA = "0xB146B0", Offset = "0xB132B0", VA = "0x180B146B0", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x060130DC RID: 78044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130DC")]
		[Address(RVA = "0xB14760", Offset = "0xB13360", VA = "0x180B14760")]
		public BehaviourLink()
		{
		}

		// Token: 0x060130DD RID: 78045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130DD")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x04015843 RID: 88131
		[Token(Token = "0x4015843")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private AbilityStandard.Behaviour _linkedBehaviour;

		// Token: 0x04015844 RID: 88132
		[Token(Token = "0x4015844")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x04015845 RID: 88133
		[Token(Token = "0x4015845")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
