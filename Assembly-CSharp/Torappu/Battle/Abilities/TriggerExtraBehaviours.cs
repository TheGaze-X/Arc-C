using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C2C RID: 11308
	[Token(Token = "0x2002C2C")]
	public class TriggerExtraBehaviours : AbilityStandard.Behaviour
	{
		// Token: 0x06013191 RID: 78225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013191")]
		[Address(RVA = "0xB26C70", Offset = "0xB25870", VA = "0x180B26C70", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x06013192 RID: 78226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013192")]
		[Address(RVA = "0xB26D90", Offset = "0xB25990", VA = "0x180B26D90")]
		public TriggerExtraBehaviours()
		{
		}

		// Token: 0x06013193 RID: 78227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6013193")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x04015908 RID: 88328
		[Token(Token = "0x4015908")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<AbilityStandard.Behaviour> _behaviours;

		// Token: 0x04015909 RID: 88329
		[Token(Token = "0x4015909")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0401590A RID: 88330
		[Token(Token = "0x401590A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
