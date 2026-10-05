using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200344A RID: 13386
	[Token(Token = "0x200344A")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act27sideUnlockLaunchTrigger
	{
		// Token: 0x0601566A RID: 87658 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601566A")]
		[Address(RVA = "0xDDCBE0", Offset = "0xDDB7E0", VA = "0x180DDCBE0")]
		public static void HandleMessage(List<Act27sideUnlockLaunchPushMessage> msgList)
		{
		}

		// Token: 0x040199D7 RID: 104919
		[Token(Token = "0x40199D7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;

		// Token: 0x0200344B RID: 13387
		[Token(Token = "0x200344B")]
		private class ToastTask : UINotificationTasks.Task
		{
			// Token: 0x0601566B RID: 87659 RVA: 0x0008BB60 File Offset: 0x00089D60
			[Token(Token = "0x601566B")]
			[Address(RVA = "0xDED8F0", Offset = "0xDEC4F0", VA = "0x180DED8F0", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x0601566C RID: 87660 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601566C")]
			[Address(RVA = "0xDEDB10", Offset = "0xDEC710", VA = "0x180DEDB10", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x0601566D RID: 87661 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601566D")]
			[Address(RVA = "0xDEE630", Offset = "0xDED230", VA = "0x180DEE630")]
			public ToastTask()
			{
			}

			// Token: 0x040199D8 RID: 104920
			[Token(Token = "0x40199D8")]
			[FieldOffset(Offset = "0x10")]
			public List<Act27sideUnlockLaunchPushMessage> msgList;

			// Token: 0x040199D9 RID: 104921
			[Token(Token = "0x40199D9")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x040199DA RID: 104922
			[Token(Token = "0x40199DA")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x040199DB RID: 104923
			[Token(Token = "0x40199DB")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
