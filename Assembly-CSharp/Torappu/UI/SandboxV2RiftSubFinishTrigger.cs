using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B46 RID: 15174
	[Token(Token = "0x2003B46")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxV2RiftSubFinishTrigger
	{
		// Token: 0x06017D66 RID: 97638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D66")]
		[Address(RVA = "0x1019330", Offset = "0x1017F30", VA = "0x181019330")]
		private static void _HandleMessage(List<SandboxV2RiftTargetPushMsg> msgList)
		{
		}

		// Token: 0x06017D67 RID: 97639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D67")]
		[Address(RVA = "0x1019210", Offset = "0x1017E10", VA = "0x181019210")]
		public static void HandleMessage(List<SandboxV2RiftTargetPushMsg> msgList)
		{
		}

		// Token: 0x0401CCA0 RID: 117920
		[Token(Token = "0x401CCA0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CCA1 RID: 117921
		[Token(Token = "0x401CCA1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
