using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003444 RID: 13380
	[Token(Token = "0x2003444")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act25sideUnlockToolTrigger
	{
		// Token: 0x06015661 RID: 87649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015661")]
		[Address(RVA = "0xDDCB20", Offset = "0xDDB720", VA = "0x180DDCB20")]
		public static void HandleMessage(List<Act25sideUnlockAreaPushMessage> msgList)
		{
		}

		// Token: 0x040199CA RID: 104906
		[Token(Token = "0x40199CA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;

		// Token: 0x02003445 RID: 13381
		[Token(Token = "0x2003445")]
		private class ToastTask : UINotificationTasks.Task
		{
			// Token: 0x06015662 RID: 87650 RVA: 0x0008BB30 File Offset: 0x00089D30
			[Token(Token = "0x6015662")]
			[Address(RVA = "0xDED790", Offset = "0xDEC390", VA = "0x180DED790", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x06015663 RID: 87651 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015663")]
			[Address(RVA = "0xDEE170", Offset = "0xDECD70", VA = "0x180DEE170", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06015664 RID: 87652 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015664")]
			[Address(RVA = "0xDEE790", Offset = "0xDED390", VA = "0x180DEE790")]
			public ToastTask()
			{
			}

			// Token: 0x040199CB RID: 104907
			[Token(Token = "0x40199CB")]
			[FieldOffset(Offset = "0x10")]
			public List<Act25sideUnlockAreaPushMessage> msgList;

			// Token: 0x040199CC RID: 104908
			[Token(Token = "0x40199CC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x040199CD RID: 104909
			[Token(Token = "0x40199CD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x040199CE RID: 104910
			[Token(Token = "0x40199CE")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
