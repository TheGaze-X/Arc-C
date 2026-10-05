using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003469 RID: 13417
	[Token(Token = "0x2003469")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act46SidePushMessage
	{
		// Token: 0x06015694 RID: 87700 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015694")]
		[Address(RVA = "0xDDF190", Offset = "0xDDDD90", VA = "0x180DDF190")]
		public static void HandleOuterOpenMsg(List<Act46SideOuterOpenPushMessage> msgList)
		{
		}

		// Token: 0x06015695 RID: 87701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015695")]
		[Address(RVA = "0xDDF0F0", Offset = "0xDDDCF0", VA = "0x180DDF0F0")]
		public static void HandleMonoStageUnlockMsg(List<Act46SideMonoStageUnlockPushMessage> msgList)
		{
		}

		// Token: 0x04019A2B RID: 105003
		[Token(Token = "0x4019A2B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleOuterOpenMsg;

		// Token: 0x04019A2C RID: 105004
		[Token(Token = "0x4019A2C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleMonoStageUnlockMsg;

		// Token: 0x0200346A RID: 13418
		[Token(Token = "0x200346A")]
		private class Act46SideStagePageOuterOpenTask : UINotificationTasks.MainUITask
		{
			// Token: 0x06015696 RID: 87702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015696")]
			[Address(RVA = "0xDDF360", Offset = "0xDDDF60", VA = "0x180DDF360", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06015697 RID: 87703 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015697")]
			[Address(RVA = "0xDDF400", Offset = "0xDDE000", VA = "0x180DDF400")]
			public Act46SideStagePageOuterOpenTask()
			{
			}

			// Token: 0x04019A2D RID: 105005
			[Token(Token = "0x4019A2D")]
			[FieldOffset(Offset = "0x18")]
			public string actId;

			// Token: 0x04019A2E RID: 105006
			[Token(Token = "0x4019A2E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x04019A2F RID: 105007
			[Token(Token = "0x4019A2F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200346B RID: 13419
		[Token(Token = "0x200346B")]
		private class Act46SideStagePageMonoStageUnlockTask : UINotificationTasks.MainUITask
		{
			// Token: 0x06015698 RID: 87704 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015698")]
			[Address(RVA = "0xDDF280", Offset = "0xDDDE80", VA = "0x180DDF280", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06015699 RID: 87705 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015699")]
			[Address(RVA = "0xDDF300", Offset = "0xDDDF00", VA = "0x180DDF300")]
			public Act46SideStagePageMonoStageUnlockTask()
			{
			}

			// Token: 0x04019A30 RID: 105008
			[Token(Token = "0x4019A30")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x04019A31 RID: 105009
			[Token(Token = "0x4019A31")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
