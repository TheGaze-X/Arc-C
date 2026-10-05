using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003ABF RID: 15039
	[Token(Token = "0x2003ABF")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class NewBackgroundGetTrigger
	{
		// Token: 0x06017BB6 RID: 97206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BB6")]
		[Address(RVA = "0x1000850", Offset = "0xFFF450", VA = "0x181000850")]
		public static void HandleMessage(List<NewBackgroundPushMsg> msgList)
		{
		}

		// Token: 0x0401CA57 RID: 117335
		[Token(Token = "0x401CA57")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;

		// Token: 0x02003AC0 RID: 15040
		[Token(Token = "0x2003AC0")]
		private class ToastTask : UINotificationTasks.UIAndBattleFinishTask
		{
			// Token: 0x06017BB7 RID: 97207 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017BB7")]
			[Address(RVA = "0x100E6B0", Offset = "0x100D2B0", VA = "0x18100E6B0", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06017BB8 RID: 97208 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017BB8")]
			[Address(RVA = "0x100EA00", Offset = "0x100D600", VA = "0x18100EA00")]
			public ToastTask()
			{
			}

			// Token: 0x0401CA58 RID: 117336
			[Token(Token = "0x401CA58")]
			[FieldOffset(Offset = "0x20")]
			public List<string> getBgs;

			// Token: 0x0401CA59 RID: 117337
			[Token(Token = "0x401CA59")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0401CA5A RID: 117338
			[Token(Token = "0x401CA5A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
