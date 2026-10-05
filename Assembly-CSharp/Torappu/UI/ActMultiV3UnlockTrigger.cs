using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003477 RID: 13431
	[Token(Token = "0x2003477")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ActMultiV3UnlockTrigger
	{
		// Token: 0x060156F1 RID: 87793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60156F1")]
		[Address(RVA = "0xDDFEA0", Offset = "0xDDEAA0", VA = "0x180DDFEA0")]
		public static void HandleMessage(List<ActMultiV3NewUnlockPushMessage> msgList)
		{
		}

		// Token: 0x04019A9A RID: 105114
		[Token(Token = "0x4019A9A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;

		// Token: 0x02003478 RID: 13432
		[Token(Token = "0x2003478")]
		private class ToastTask : UINotificationTasks.Task
		{
			// Token: 0x060156F2 RID: 87794 RVA: 0x0008BEC0 File Offset: 0x0008A0C0
			[Token(Token = "0x60156F2")]
			[Address(RVA = "0xDED4B0", Offset = "0xDEC0B0", VA = "0x180DED4B0", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x060156F3 RID: 87795 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60156F3")]
			[Address(RVA = "0xDEE490", Offset = "0xDED090", VA = "0x180DEE490")]
			private string _GenMapTypeUnlockToast(ActMultiV3Data actData, string modeId)
			{
				return null;
			}

			// Token: 0x060156F4 RID: 87796 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60156F4")]
			[Address(RVA = "0xDEDE20", Offset = "0xDECA20", VA = "0x180DEDE20", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x060156F5 RID: 87797 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60156F5")]
			[Address(RVA = "0xDEE8F0", Offset = "0xDED4F0", VA = "0x180DEE8F0")]
			public ToastTask()
			{
			}

			// Token: 0x04019A9B RID: 105115
			[Token(Token = "0x4019A9B")]
			[FieldOffset(Offset = "0x10")]
			public List<ActMultiV3NewUnlockPushMessage> msgList;

			// Token: 0x04019A9C RID: 105116
			[Token(Token = "0x4019A9C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x04019A9D RID: 105117
			[Token(Token = "0x4019A9D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0__GenMapTypeUnlockToast;

			// Token: 0x04019A9E RID: 105118
			[Token(Token = "0x4019A9E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x04019A9F RID: 105119
			[Token(Token = "0x4019A9F")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
