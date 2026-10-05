using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003462 RID: 13410
	[Token(Token = "0x2003462")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act44sidePushMessage
	{
		// Token: 0x0601568F RID: 87695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601568F")]
		[Address(RVA = "0xDDEA70", Offset = "0xDDD670", VA = "0x180DDEA70")]
		public static void HandleOuterOpenMessage(List<Act44sideOuterOpenPushMessage> msgList)
		{
		}

		// Token: 0x04019A21 RID: 104993
		[Token(Token = "0x4019A21")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleOuterOpenMessage;

		// Token: 0x02003463 RID: 13411
		[Token(Token = "0x2003463")]
		private class Act44sideStagePageTask : UINotificationTasks.StagePageUITask
		{
			// Token: 0x06015690 RID: 87696 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015690")]
			[Address(RVA = "0xDDEB40", Offset = "0xDDD740", VA = "0x180DDEB40", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06015691 RID: 87697 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015691")]
			[Address(RVA = "0xDDEC10", Offset = "0xDDD810", VA = "0x180DDEC10")]
			public Act44sideStagePageTask()
			{
			}

			// Token: 0x04019A22 RID: 104994
			[Token(Token = "0x4019A22")]
			[FieldOffset(Offset = "0x18")]
			public string actId;

			// Token: 0x04019A23 RID: 104995
			[Token(Token = "0x4019A23")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x04019A24 RID: 104996
			[Token(Token = "0x4019A24")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
