using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B4F RID: 15183
	[Token(Token = "0x2003B4F")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxV2AchievementTrigger
	{
		// Token: 0x06017D75 RID: 97653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D75")]
		[Address(RVA = "0x1017370", Offset = "0x1015F70", VA = "0x181017370")]
		public static void HandleMessage(List<SandboxV2AchievementPushMsg> msgList)
		{
		}

		// Token: 0x0401CCB4 RID: 117940
		[Token(Token = "0x401CCB4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;

		// Token: 0x02003B50 RID: 15184
		[Token(Token = "0x2003B50")]
		private class AchievementTask : UINotificationTasks.MainUITask
		{
			// Token: 0x06017D76 RID: 97654 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017D76")]
			[Address(RVA = "0x1011910", Offset = "0x1010510", VA = "0x181011910", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06017D77 RID: 97655 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017D77")]
			[Address(RVA = "0x1011BC0", Offset = "0x10107C0", VA = "0x181011BC0")]
			public AchievementTask()
			{
			}

			// Token: 0x0401CCB5 RID: 117941
			[Token(Token = "0x401CCB5")]
			[FieldOffset(Offset = "0x18")]
			public List<string> achievementIds;

			// Token: 0x0401CCB6 RID: 117942
			[Token(Token = "0x401CCB6")]
			[FieldOffset(Offset = "0x20")]
			public string topicId;

			// Token: 0x0401CCB7 RID: 117943
			[Token(Token = "0x401CCB7")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0401CCB8 RID: 117944
			[Token(Token = "0x401CCB8")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
