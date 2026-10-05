using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.SandboxPerm.SandboxV2;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B45 RID: 15173
	[Token(Token = "0x2003B45")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxV2RiftMainFinishTrigger
	{
		// Token: 0x06017D63 RID: 97635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D63")]
		[Address(RVA = "0x1018CF0", Offset = "0x10178F0", VA = "0x181018CF0")]
		private static void _HandleMessage(List<SandboxV2RiftTargetPushMsg> msgList)
		{
		}

		// Token: 0x06017D64 RID: 97636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D64")]
		[Address(RVA = "0x1018E20", Offset = "0x1017A20", VA = "0x181018E20")]
		private static void _HandleSingleMessage(string riftMainTargetId, SandboxV2DungeonPushMessageController messageController)
		{
		}

		// Token: 0x06017D65 RID: 97637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D65")]
		[Address(RVA = "0x1018BD0", Offset = "0x10177D0", VA = "0x181018BD0")]
		public static void HandleMessage(List<SandboxV2RiftTargetPushMsg> msgList)
		{
		}

		// Token: 0x0401CC9D RID: 117917
		[Token(Token = "0x401CC9D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleMessage;

		// Token: 0x0401CC9E RID: 117918
		[Token(Token = "0x401CC9E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleSingleMessage;

		// Token: 0x0401CC9F RID: 117919
		[Token(Token = "0x401CC9F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleMessage;
	}
}
