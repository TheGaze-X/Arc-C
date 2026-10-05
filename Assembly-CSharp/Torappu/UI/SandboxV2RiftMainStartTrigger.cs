using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.SandboxPerm.SandboxV2;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B44 RID: 15172
	[Token(Token = "0x2003B44")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxV2RiftMainStartTrigger
	{
		// Token: 0x06017D60 RID: 97632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D60")]
		[Address(RVA = "0x1019010", Offset = "0x1017C10", VA = "0x181019010")]
		private static void _HandleMessage(List<SandboxV2RiftTargetPushMsg> msgList)
		{
		}

		// Token: 0x06017D61 RID: 97633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D61")]
		[Address(RVA = "0x1019140", Offset = "0x1017D40", VA = "0x181019140")]
		private static void _HandleSingleMessage(string riftMainTargetId, SandboxV2DungeonPushMessageController messageController)
		{
		}

		// Token: 0x06017D62 RID: 97634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D62")]
		[Address(RVA = "0x1018EF0", Offset = "0x1017AF0", VA = "0x181018EF0")]
		public static void HandleMessage(List<SandboxV2RiftTargetPushMsg> msgList)
		{
		}

		// Token: 0x0401CC9A RID: 117914
		[Token(Token = "0x401CC9A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC9B RID: 117915
		[Token(Token = "0x401CC9B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleSingleMessage;

		// Token: 0x0401CC9C RID: 117916
		[Token(Token = "0x401CC9C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
