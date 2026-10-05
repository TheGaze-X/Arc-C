using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x0200345F RID: 13407
	[Token(Token = "0x200345F")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act42sidePushMessage
	{
		// Token: 0x06015689 RID: 87689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015689")]
		[Address(RVA = "0xDDE2B0", Offset = "0xDDCEB0", VA = "0x180DDE2B0")]
		public static void HandleItemUnlockMessage(List<Act42sideItemUnlockPushMessage> msgList)
		{
		}

		// Token: 0x0601568A RID: 87690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601568A")]
		[Address(RVA = "0xDDE650", Offset = "0xDDD250", VA = "0x180DDE650")]
		public static void HandleOuterUnlockMessage(List<Act42sideOuterUnlockPushMessage> msgList)
		{
		}

		// Token: 0x0601568B RID: 87691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601568B")]
		[Address(RVA = "0xDDE750", Offset = "0xDDD350", VA = "0x180DDE750")]
		public static void HandleTaskCompleteMessage(List<Act42sideTaskCompletePushMessage> msgList)
		{
		}

		// Token: 0x04019A1A RID: 104986
		[Token(Token = "0x4019A1A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleItemUnlockMessage;

		// Token: 0x04019A1B RID: 104987
		[Token(Token = "0x4019A1B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleOuterUnlockMessage;

		// Token: 0x04019A1C RID: 104988
		[Token(Token = "0x4019A1C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleTaskCompleteMessage;

		// Token: 0x02003460 RID: 13408
		[Token(Token = "0x2003460")]
		private class Act42sideStagePageTask : UINotificationTasks.StagePageUITask
		{
			// Token: 0x0601568C RID: 87692 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601568C")]
			[Address(RVA = "0xDDE990", Offset = "0xDDD590", VA = "0x180DDE990", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x0601568D RID: 87693 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601568D")]
			[Address(RVA = "0xDDEA10", Offset = "0xDDD610", VA = "0x180DDEA10")]
			public Act42sideStagePageTask()
			{
			}

			// Token: 0x04019A1D RID: 104989
			[Token(Token = "0x4019A1D")]
			[FieldOffset(Offset = "0x18")]
			public string actId;

			// Token: 0x04019A1E RID: 104990
			[Token(Token = "0x4019A1E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x04019A1F RID: 104991
			[Token(Token = "0x4019A1F")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
