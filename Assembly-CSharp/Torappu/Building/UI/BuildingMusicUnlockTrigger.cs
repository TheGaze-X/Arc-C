using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B9B RID: 7067
	[Token(Token = "0x2001B9B")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class BuildingMusicUnlockTrigger
	{
		// Token: 0x0600B07E RID: 45182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B07E")]
		[Address(RVA = "0x32A4960", Offset = "0x32A3560", VA = "0x1832A4960")]
		public static void HandleMessage(List<BuildingMusicUnlockPushMsg> msgList)
		{
		}

		// Token: 0x0400AAE9 RID: 43753
		[Token(Token = "0x400AAE9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleMessage;

		// Token: 0x02001B9C RID: 7068
		[Token(Token = "0x2001B9C")]
		private class ToastTask : UINotificationTasks.UIAndBattleFinishTask
		{
			// Token: 0x0600B07F RID: 45183 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B07F")]
			[Address(RVA = "0x32B0FD0", Offset = "0x32AFBD0", VA = "0x1832B0FD0", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x0600B080 RID: 45184 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B080")]
			[Address(RVA = "0x32B11A0", Offset = "0x32AFDA0", VA = "0x1832B11A0")]
			public ToastTask()
			{
			}

			// Token: 0x0400AAEA RID: 43754
			[Token(Token = "0x400AAEA")]
			[FieldOffset(Offset = "0x20")]
			public string firstName;

			// Token: 0x0400AAEB RID: 43755
			[Token(Token = "0x400AAEB")]
			[FieldOffset(Offset = "0x28")]
			public int musicCnt;

			// Token: 0x0400AAEC RID: 43756
			[Token(Token = "0x400AAEC")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0400AAED RID: 43757
			[Token(Token = "0x400AAED")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
