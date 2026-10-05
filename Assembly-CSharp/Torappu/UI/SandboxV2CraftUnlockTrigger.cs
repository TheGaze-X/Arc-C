using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B4D RID: 15181
	[Token(Token = "0x2003B4D")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxV2CraftUnlockTrigger
	{
		// Token: 0x06017D72 RID: 97650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D72")]
		[Address(RVA = "0x1017990", Offset = "0x1016590", VA = "0x181017990")]
		private static void _HandleMessage(List<SandboxV2CraftUnlockPushMsg> msgList)
		{
		}

		// Token: 0x06017D73 RID: 97651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D73")]
		[Address(RVA = "0x1017880", Offset = "0x1016480", VA = "0x181017880")]
		public static void HandleMessage(List<SandboxV2CraftUnlockPushMsg> msgList)
		{
		}

		// Token: 0x0401CCB0 RID: 117936
		[Token(Token = "0x401CCB0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CCB1 RID: 117937
		[Token(Token = "0x401CCB1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
