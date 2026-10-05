using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B29 RID: 15145
	[Token(Token = "0x2003B29")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeMutateWrathTrigger
	{
		// Token: 0x06017D25 RID: 97573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D25")]
		[Address(RVA = "0x10169D0", Offset = "0x10155D0", VA = "0x1810169D0")]
		private static void _HandMessage(List<RoguelikeMutateWrathPushMsg> msgList)
		{
		}

		// Token: 0x06017D26 RID: 97574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D26")]
		[Address(RVA = "0x10168F0", Offset = "0x10154F0", VA = "0x1810168F0")]
		public static void HandleMessage(List<RoguelikeMutateWrathPushMsg> msgList)
		{
		}

		// Token: 0x0401CC5F RID: 117855
		[Token(Token = "0x401CC5F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandMessage;

		// Token: 0x0401CC60 RID: 117856
		[Token(Token = "0x401CC60")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
