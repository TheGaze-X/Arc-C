using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B1D RID: 15133
	[Token(Token = "0x2003B1D")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeFragmentBagWeightUpgradeTrigger
	{
		// Token: 0x06017D13 RID: 97555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D13")]
		[Address(RVA = "0x1015270", Offset = "0x1013E70", VA = "0x181015270")]
		private static void _HandleMessage(List<RoguelikeFragmentBagWeightUpgradePushMsg> msgList)
		{
		}

		// Token: 0x06017D14 RID: 97556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D14")]
		[Address(RVA = "0x1015190", Offset = "0x1013D90", VA = "0x181015190")]
		public static void HandleMessage(List<RoguelikeFragmentBagWeightUpgradePushMsg> msgList)
		{
		}

		// Token: 0x0401CC4C RID: 117836
		[Token(Token = "0x401CC4C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC4D RID: 117837
		[Token(Token = "0x401CC4D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
