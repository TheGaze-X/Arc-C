using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B52 RID: 15186
	[Token(Token = "0x2003B52")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxV2ChallengeUnlockTrigger
	{
		// Token: 0x06017D79 RID: 97657 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D79")]
		[Address(RVA = "0x10174E0", Offset = "0x10160E0", VA = "0x1810174E0")]
		public static void HandleMessage(List<SandboxV2ChallengeUnlockPushMsg> msgList)
		{
		}

		// Token: 0x0401CCBA RID: 117946
		[Token(Token = "0x401CCBA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;

		// Token: 0x02003B53 RID: 15187
		[Token(Token = "0x2003B53")]
		private class ChallengeUnlockTask : UINotificationTasks.MainUITask
		{
			// Token: 0x06017D7A RID: 97658 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017D7A")]
			[Address(RVA = "0x1011C70", Offset = "0x1010870", VA = "0x181011C70", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06017D7B RID: 97659 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017D7B")]
			[Address(RVA = "0x1011DD0", Offset = "0x10109D0", VA = "0x181011DD0")]
			public ChallengeUnlockTask()
			{
			}

			// Token: 0x0401CCBB RID: 117947
			[Token(Token = "0x401CCBB")]
			[FieldOffset(Offset = "0x18")]
			public string topicId;

			// Token: 0x0401CCBC RID: 117948
			[Token(Token = "0x401CCBC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0401CCBD RID: 117949
			[Token(Token = "0x401CCBD")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
