using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AB2 RID: 15026
	[Token(Token = "0x2003AB2")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class FifthAnnivExplorePushMessageController
	{
		// Token: 0x06017B99 RID: 97177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B99")]
		[Address(RVA = "0xFEA1C0", Offset = "0xFE8DC0", VA = "0x180FEA1C0")]
		public static void HandleFifthExploreUnlockPendingMessage(List<FifthAnnivExploreUnlockPushMsg> msgList)
		{
		}

		// Token: 0x06017B9A RID: 97178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B9A")]
		[Address(RVA = "0xFEA3F0", Offset = "0xFE8FF0", VA = "0x180FEA3F0")]
		private static void _HandleFifthExploreUnlockPendingMessage(List<FifthAnnivExploreUnlockPushMsg> msgList)
		{
		}

		// Token: 0x06017B9B RID: 97179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B9B")]
		[Address(RVA = "0xFEA060", Offset = "0xFE8C60", VA = "0x180FEA060")]
		public static void HandleFifthExploreStageUnlockPendingMessage(List<FifthAnnivExploreStageUnlockPushMsg> msgList)
		{
		}

		// Token: 0x06017B9C RID: 97180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017B9C")]
		[Address(RVA = "0xFEA320", Offset = "0xFE8F20", VA = "0x180FEA320")]
		private static void _HandleFifthExploreStageUnlockPendingMessage(List<FifthAnnivExploreStageUnlockPushMsg> msgList)
		{
		}

		// Token: 0x0401CA2A RID: 117290
		[Token(Token = "0x401CA2A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleFifthExploreUnlockPendingMessage;

		// Token: 0x0401CA2B RID: 117291
		[Token(Token = "0x401CA2B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleFifthExploreUnlockPendingMessage;

		// Token: 0x0401CA2C RID: 117292
		[Token(Token = "0x401CA2C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleFifthExploreStageUnlockPendingMessage;

		// Token: 0x0401CA2D RID: 117293
		[Token(Token = "0x401CA2D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HandleFifthExploreStageUnlockPendingMessage;

		// Token: 0x02003AB3 RID: 15027
		[Token(Token = "0x2003AB3")]
		private interface IPendingMsg : IHotfixable
		{
			// Token: 0x06017B9D RID: 97181
			[Token(Token = "0x6017B9D")]
			void Handle();
		}

		// Token: 0x02003AB4 RID: 15028
		// (Invoke) Token: 0x06017B9F RID: 97183
		[Token(Token = "0x2003AB4")]
		private delegate void MsgHandler<TMsg>(List<TMsg> msg);

		// Token: 0x02003AB5 RID: 15029
		[Token(Token = "0x2003AB5")]
		private class PendingMsg<TMsg> : FifthAnnivExplorePushMessageController.IPendingMsg, IHotfixable
		{
			// Token: 0x06017BA2 RID: 97186 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017BA2")]
			public void Handle()
			{
			}

			// Token: 0x06017BA3 RID: 97187 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017BA3")]
			public PendingMsg()
			{
			}

			// Token: 0x0401CA2E RID: 117294
			[Token(Token = "0x401CA2E")]
			[FieldOffset(Offset = "0x0")]
			public List<TMsg> msg;

			// Token: 0x0401CA2F RID: 117295
			[Token(Token = "0x401CA2F")]
			[FieldOffset(Offset = "0x0")]
			public FifthAnnivExplorePushMessageController.MsgHandler<TMsg> handler;

			// Token: 0x0401CA30 RID: 117296
			[Token(Token = "0x401CA30")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Handle;

			// Token: 0x0401CA31 RID: 117297
			[Token(Token = "0x401CA31")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003AB6 RID: 15030
		[Token(Token = "0x2003AB6")]
		private class PushMsgTask : UINotificationTasks.StagePageUITask
		{
			// Token: 0x06017BA4 RID: 97188 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017BA4")]
			[Address(RVA = "0xFEE0D0", Offset = "0xFECCD0", VA = "0x180FEE0D0", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06017BA5 RID: 97189 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017BA5")]
			[Address(RVA = "0xFEE2C0", Offset = "0xFECEC0", VA = "0x180FEE2C0")]
			public PushMsgTask()
			{
			}

			// Token: 0x0401CA32 RID: 117298
			[Token(Token = "0x401CA32")]
			[FieldOffset(Offset = "0x18")]
			public List<FifthAnnivExplorePushMessageController.IPendingMsg> pendingMsgs;

			// Token: 0x0401CA33 RID: 117299
			[Token(Token = "0x401CA33")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0401CA34 RID: 117300
			[Token(Token = "0x401CA34")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
