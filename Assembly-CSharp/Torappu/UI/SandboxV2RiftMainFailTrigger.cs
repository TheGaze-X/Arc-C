using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.SandboxPerm.SandboxV2;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B47 RID: 15175
	[Token(Token = "0x2003B47")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxV2RiftMainFailTrigger
	{
		// Token: 0x06017D68 RID: 97640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D68")]
		[Address(RVA = "0x10189D0", Offset = "0x10175D0", VA = "0x1810189D0")]
		private static void _HandleMessage(List<SandboxV2RiftTargetPushMsg> msgList)
		{
		}

		// Token: 0x06017D69 RID: 97641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D69")]
		[Address(RVA = "0x1018B00", Offset = "0x1017700", VA = "0x181018B00")]
		private static void _HandleSingleMessage(string riftMainTargetId, SandboxV2DungeonPushMessageController messageController)
		{
		}

		// Token: 0x06017D6A RID: 97642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D6A")]
		[Address(RVA = "0x10188B0", Offset = "0x10174B0", VA = "0x1810188B0")]
		public static void HandleMessage(List<SandboxV2RiftTargetPushMsg> msgList)
		{
		}

		// Token: 0x0401CCA2 RID: 117922
		[Token(Token = "0x401CCA2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CCA3 RID: 117923
		[Token(Token = "0x401CCA3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleSingleMessage;

		// Token: 0x0401CCA4 RID: 117924
		[Token(Token = "0x401CCA4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
