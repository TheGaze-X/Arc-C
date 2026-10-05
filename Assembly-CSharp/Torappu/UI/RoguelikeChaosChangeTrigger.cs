using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B14 RID: 15124
	[Token(Token = "0x2003B14")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikeChaosChangeTrigger
	{
		// Token: 0x06017D04 RID: 97540 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D04")]
		[Address(RVA = "0x1013B50", Offset = "0x1012750", VA = "0x181013B50")]
		public static void HandleMessage(List<RoguelikeChaosChangePushMsg> msgList)
		{
		}

		// Token: 0x06017D05 RID: 97541 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D05")]
		[Address(RVA = "0x1013C30", Offset = "0x1012830", VA = "0x181013C30")]
		private static void _HandleMessage(List<RoguelikeChaosChangePushMsg> msgList)
		{
		}

		// Token: 0x06017D06 RID: 97542 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D06")]
		[Address(RVA = "0x1013E40", Offset = "0x1012A40", VA = "0x181013E40")]
		private static void _HandleSingleMessage(RoguelikeChaosChangePushMsg msg)
		{
		}

		// Token: 0x0401CC3A RID: 117818
		[Token(Token = "0x401CC3A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;

		// Token: 0x0401CC3B RID: 117819
		[Token(Token = "0x401CC3B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC3C RID: 117820
		[Token(Token = "0x401CC3C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__HandleSingleMessage;
	}
}
