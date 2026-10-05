using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.SandboxPerm.SandboxV2;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B49 RID: 15177
	[Token(Token = "0x2003B49")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxV2ZoneUnlockTrigger
	{
		// Token: 0x06017D6C RID: 97644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D6C")]
		[Address(RVA = "0x101B5F0", Offset = "0x101A1F0", VA = "0x18101B5F0")]
		private static void _HandleMessage(List<SandboxV2ZoneUnlockPushMsg> msgList)
		{
		}

		// Token: 0x06017D6D RID: 97645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D6D")]
		[Address(RVA = "0x101B720", Offset = "0x101A320", VA = "0x18101B720")]
		private static void _HandleSingleMessage(string zoneId, SandboxV2DungeonPushMessageController messageController)
		{
		}

		// Token: 0x06017D6E RID: 97646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D6E")]
		[Address(RVA = "0x101B4D0", Offset = "0x101A0D0", VA = "0x18101B4D0")]
		public static void HandleMessage(List<SandboxV2ZoneUnlockPushMsg> msgList)
		{
		}

		// Token: 0x0401CCA7 RID: 117927
		[Token(Token = "0x401CCA7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CCA8 RID: 117928
		[Token(Token = "0x401CCA8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleSingleMessage;

		// Token: 0x0401CCA9 RID: 117929
		[Token(Token = "0x401CCA9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
