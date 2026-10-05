using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200344E RID: 13390
	[Token(Token = "0x200344E")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act29sideUnlockTuningTrigger
	{
		// Token: 0x0601566E RID: 87662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601566E")]
		[Address(RVA = "0xDDD050", Offset = "0xDDBC50", VA = "0x180DDD050")]
		public static void HandleMessage(List<Act29sideUnlockTuningPushMessage> msgList)
		{
		}

		// Token: 0x040199DE RID: 104926
		[Token(Token = "0x40199DE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;

		// Token: 0x0200344F RID: 13391
		[Token(Token = "0x200344F")]
		private class ToastTask : UINotificationTasks.StagePageUITask
		{
			// Token: 0x0601566F RID: 87663 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601566F")]
			[Address(RVA = "0xDEE3E0", Offset = "0xDECFE0", VA = "0x180DEE3E0", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06015670 RID: 87664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015670")]
			[Address(RVA = "0xDEE6E0", Offset = "0xDED2E0", VA = "0x180DEE6E0")]
			public ToastTask()
			{
			}

			// Token: 0x040199DF RID: 104927
			[Token(Token = "0x40199DF")]
			[FieldOffset(Offset = "0x18")]
			public List<Act29sideUnlockTuningPushMessage> msgList;

			// Token: 0x040199E0 RID: 104928
			[Token(Token = "0x40199E0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x040199E1 RID: 104929
			[Token(Token = "0x40199E1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
