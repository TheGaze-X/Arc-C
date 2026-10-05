using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003447 RID: 13383
	[Token(Token = "0x2003447")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act27sideUnlockSaleTrigger
	{
		// Token: 0x06015666 RID: 87654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015666")]
		[Address(RVA = "0xDDCCA0", Offset = "0xDDB8A0", VA = "0x180DDCCA0")]
		public static void HandleMessage(List<Act27sideUnlockSalePushMessage> msgList)
		{
		}

		// Token: 0x040199D0 RID: 104912
		[Token(Token = "0x40199D0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;

		// Token: 0x02003448 RID: 13384
		[Token(Token = "0x2003448")]
		private class ToastTask : UINotificationTasks.Task
		{
			// Token: 0x06015667 RID: 87655 RVA: 0x0008BB48 File Offset: 0x00089D48
			[Token(Token = "0x6015667")]
			[Address(RVA = "0xDED600", Offset = "0xDEC200", VA = "0x180DED600", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x06015668 RID: 87656 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015668")]
			[Address(RVA = "0xDEDA80", Offset = "0xDEC680", VA = "0x180DEDA80", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06015669 RID: 87657 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015669")]
			[Address(RVA = "0xDEE9A0", Offset = "0xDED5A0", VA = "0x180DEE9A0")]
			public ToastTask()
			{
			}

			// Token: 0x040199D1 RID: 104913
			[Token(Token = "0x40199D1")]
			[FieldOffset(Offset = "0x10")]
			public List<Act27sideUnlockSalePushMessage> msgList;

			// Token: 0x040199D2 RID: 104914
			[Token(Token = "0x40199D2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x040199D3 RID: 104915
			[Token(Token = "0x40199D3")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x040199D4 RID: 104916
			[Token(Token = "0x40199D4")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
