using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002BD6 RID: 11222
	[Token(Token = "0x2002BD6")]
	public class DefaultBlackboardBehaviour : AbilityStandard.Behaviour
	{
		// Token: 0x06012F35 RID: 77621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F35")]
		[Address(RVA = "0xAE1740", Offset = "0xAE0340", VA = "0x180AE1740", Slot = "6")]
		public override void SetData(Blackboard blackboard)
		{
		}

		// Token: 0x06012F36 RID: 77622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F36")]
		[Address(RVA = "0xAE1910", Offset = "0xAE0510", VA = "0x180AE1910")]
		public DefaultBlackboardBehaviour()
		{
		}

		// Token: 0x06012F37 RID: 77623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012F37")]
		[Address(RVA = "0xAC3250", Offset = "0xAC1E50", VA = "0x180AC3250")]
		private void <>xLuaBaseProxy_SetData(Blackboard P0)
		{
		}

		// Token: 0x0401563E RID: 87614
		[Token(Token = "0x401563E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Blackboard.DataPair> _defaultPairs;

		// Token: 0x0401563F RID: 87615
		[Token(Token = "0x401563F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetData;

		// Token: 0x04015640 RID: 87616
		[Token(Token = "0x4015640")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
