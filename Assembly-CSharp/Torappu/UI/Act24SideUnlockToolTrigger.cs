using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200343E RID: 13374
	[Token(Token = "0x200343E")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act24SideUnlockToolTrigger
	{
		// Token: 0x06015653 RID: 87635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015653")]
		[Address(RVA = "0xDDC0D0", Offset = "0xDDACD0", VA = "0x180DDC0D0")]
		public static void HandleMessage(List<Act24SideUnlockToolPushMessage> msgList)
		{
		}

		// Token: 0x040199A2 RID: 104866
		[Token(Token = "0x40199A2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;

		// Token: 0x0200343F RID: 13375
		[Token(Token = "0x200343F")]
		private class ToastTask : UINotificationTasks.Task
		{
			// Token: 0x06015654 RID: 87636 RVA: 0x0008BB00 File Offset: 0x00089D00
			[Token(Token = "0x6015654")]
			[Address(RVA = "0xDED360", Offset = "0xDEBF60", VA = "0x180DED360", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x06015655 RID: 87637 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015655")]
			[Address(RVA = "0xDEDBA0", Offset = "0xDEC7A0", VA = "0x180DEDBA0", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06015656 RID: 87638 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015656")]
			[Address(RVA = "0xDEE840", Offset = "0xDED440", VA = "0x180DEE840")]
			public ToastTask()
			{
			}

			// Token: 0x040199A3 RID: 104867
			[Token(Token = "0x40199A3")]
			[FieldOffset(Offset = "0x10")]
			public List<Act24SideUnlockToolPushMessage> msgList;

			// Token: 0x040199A4 RID: 104868
			[Token(Token = "0x40199A4")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x040199A5 RID: 104869
			[Token(Token = "0x40199A5")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x040199A6 RID: 104870
			[Token(Token = "0x40199A6")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
