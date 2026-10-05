using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B41 RID: 15169
	[Token(Token = "0x2003B41")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxV2QuestFinishTrigger
	{
		// Token: 0x06017D5A RID: 97626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D5A")]
		[Address(RVA = "0x10180D0", Offset = "0x1016CD0", VA = "0x1810180D0")]
		private static void _HandleMessage(List<SandboxV2QuestFinishPushMsg> msgList)
		{
		}

		// Token: 0x06017D5B RID: 97627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D5B")]
		[Address(RVA = "0x1017FB0", Offset = "0x1016BB0", VA = "0x181017FB0")]
		public static void HandleMessage(List<SandboxV2QuestFinishPushMsg> msgList)
		{
		}

		// Token: 0x0401CC93 RID: 117907
		[Token(Token = "0x401CC93")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC94 RID: 117908
		[Token(Token = "0x401CC94")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
