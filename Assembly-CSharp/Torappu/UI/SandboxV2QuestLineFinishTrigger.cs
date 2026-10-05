using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.SandboxPerm.SandboxV2;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B42 RID: 15170
	[Token(Token = "0x2003B42")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxV2QuestLineFinishTrigger
	{
		// Token: 0x06017D5C RID: 97628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D5C")]
		[Address(RVA = "0x1018390", Offset = "0x1016F90", VA = "0x181018390")]
		private static void _HandleMessage(List<SandboxV2QuestLineNotifyPushMsg> msgList)
		{
		}

		// Token: 0x06017D5D RID: 97629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D5D")]
		[Address(RVA = "0x10184C0", Offset = "0x10170C0", VA = "0x1810184C0")]
		private static void _HandleSingleMessage(string questLineId, SandboxV2DungeonPushMessageController messageController)
		{
		}

		// Token: 0x06017D5E RID: 97630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D5E")]
		[Address(RVA = "0x1018270", Offset = "0x1016E70", VA = "0x181018270")]
		public static void HandleMessage(List<SandboxV2QuestLineNotifyPushMsg> msgList)
		{
		}

		// Token: 0x0401CC95 RID: 117909
		[Token(Token = "0x401CC95")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC96 RID: 117910
		[Token(Token = "0x401CC96")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleSingleMessage;

		// Token: 0x0401CC97 RID: 117911
		[Token(Token = "0x401CC97")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
