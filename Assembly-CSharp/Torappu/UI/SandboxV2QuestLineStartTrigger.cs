using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.SandboxPerm.SandboxV2;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B3F RID: 15167
	[Token(Token = "0x2003B3F")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxV2QuestLineStartTrigger
	{
		// Token: 0x06017D56 RID: 97622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D56")]
		[Address(RVA = "0x10186B0", Offset = "0x10172B0", VA = "0x1810186B0")]
		private static void _HandleMessage(List<SandboxV2QuestLineNotifyPushMsg> msgList)
		{
		}

		// Token: 0x06017D57 RID: 97623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D57")]
		[Address(RVA = "0x10187E0", Offset = "0x10173E0", VA = "0x1810187E0")]
		private static void _HandleSingleMessage(string questLineId, SandboxV2DungeonPushMessageController messageController)
		{
		}

		// Token: 0x06017D58 RID: 97624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D58")]
		[Address(RVA = "0x1018590", Offset = "0x1017190", VA = "0x181018590")]
		public static void HandleMessage(List<SandboxV2QuestLineNotifyPushMsg> msgList)
		{
		}

		// Token: 0x0401CC8E RID: 117902
		[Token(Token = "0x401CC8E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC8F RID: 117903
		[Token(Token = "0x401CC8F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleSingleMessage;

		// Token: 0x0401CC90 RID: 117904
		[Token(Token = "0x401CC90")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
