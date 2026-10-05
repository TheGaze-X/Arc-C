using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AC2 RID: 15042
	[Token(Token = "0x2003AC2")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class NewThemeGetTrigger
	{
		// Token: 0x06017BB9 RID: 97209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017BB9")]
		[Address(RVA = "0x1000AB0", Offset = "0xFFF6B0", VA = "0x181000AB0")]
		public static void HandleMessage(List<NewThemePushMsg> msgList)
		{
		}

		// Token: 0x0401CA5C RID: 117340
		[Token(Token = "0x401CA5C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;

		// Token: 0x02003AC3 RID: 15043
		[Token(Token = "0x2003AC3")]
		private class ToastTask : UINotificationTasks.UIAndBattleFinishTask
		{
			// Token: 0x06017BBA RID: 97210 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017BBA")]
			[Address(RVA = "0x100E480", Offset = "0x100D080", VA = "0x18100E480", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06017BBB RID: 97211 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017BBB")]
			[Address(RVA = "0x100E900", Offset = "0x100D500", VA = "0x18100E900")]
			public ToastTask()
			{
			}

			// Token: 0x0401CA5D RID: 117341
			[Token(Token = "0x401CA5D")]
			[FieldOffset(Offset = "0x20")]
			public List<string> getThemes;

			// Token: 0x0401CA5E RID: 117342
			[Token(Token = "0x401CA5E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0401CA5F RID: 117343
			[Token(Token = "0x401CA5F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
