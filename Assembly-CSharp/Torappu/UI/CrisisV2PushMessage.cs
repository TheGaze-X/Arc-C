using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003A4C RID: 14924
	[Token(Token = "0x2003A4C")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class CrisisV2PushMessage
	{
		// Token: 0x06017988 RID: 96648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017988")]
		[Address(RVA = "0xFE3E00", Offset = "0xFE2A00", VA = "0x180FE3E00")]
		public static void HandleDailyRuneUnlock(List<CrisisV2UnlockDailyRunePushMsg> msgList)
		{
		}

		// Token: 0x06017989 RID: 96649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017989")]
		[Address(RVA = "0xFE3EC0", Offset = "0xFE2AC0", VA = "0x180FE3EC0")]
		private static void _HandleDailyRuneUnlock(List<CrisisV2UnlockDailyRunePushMsg> msgList)
		{
		}

		// Token: 0x0601798A RID: 96650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601798A")]
		private static void _AddPendingMsg<TMsg>(List<TMsg> content, CrisisV2PushMessage.MsgHandler<TMsg> handler)
		{
		}

		// Token: 0x0401C798 RID: 116632
		[Token(Token = "0x401C798")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleDailyRuneUnlock;

		// Token: 0x0401C799 RID: 116633
		[Token(Token = "0x401C799")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleDailyRuneUnlock;

		// Token: 0x0401C79A RID: 116634
		[Token(Token = "0x401C79A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__AddPendingMsg;

		// Token: 0x02003A4D RID: 14925
		[Token(Token = "0x2003A4D")]
		private interface IPendingMsg : IHotfixable
		{
			// Token: 0x0601798B RID: 96651
			[Token(Token = "0x601798B")]
			void Handle();
		}

		// Token: 0x02003A4E RID: 14926
		[Token(Token = "0x2003A4E")]
		private class PendingMsg<TMsg> : CrisisV2PushMessage.IPendingMsg, IHotfixable
		{
			// Token: 0x0601798C RID: 96652 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601798C")]
			public void Handle()
			{
			}

			// Token: 0x0601798D RID: 96653 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601798D")]
			public PendingMsg()
			{
			}

			// Token: 0x0401C79B RID: 116635
			[Token(Token = "0x401C79B")]
			[FieldOffset(Offset = "0x0")]
			public List<TMsg> msg;

			// Token: 0x0401C79C RID: 116636
			[Token(Token = "0x401C79C")]
			[FieldOffset(Offset = "0x0")]
			public CrisisV2PushMessage.MsgHandler<TMsg> handler;

			// Token: 0x0401C79D RID: 116637
			[Token(Token = "0x401C79D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Handle;

			// Token: 0x0401C79E RID: 116638
			[Token(Token = "0x401C79E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003A4F RID: 14927
		// (Invoke) Token: 0x0601798F RID: 96655
		[Token(Token = "0x2003A4F")]
		private delegate void MsgHandler<TMsg>(List<TMsg> msg);

		// Token: 0x02003A50 RID: 14928
		[Token(Token = "0x2003A50")]
		private class PushMsgTask : UINotificationTasks.MainUITask
		{
			// Token: 0x06017992 RID: 96658 RVA: 0x000975C0 File Offset: 0x000957C0
			[Token(Token = "0x6017992")]
			[Address(RVA = "0xFEDEF0", Offset = "0xFECAF0", VA = "0x180FEDEF0", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x06017993 RID: 96659 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017993")]
			[Address(RVA = "0xFEDF90", Offset = "0xFECB90", VA = "0x180FEDF90", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06017994 RID: 96660 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017994")]
			[Address(RVA = "0xFEE210", Offset = "0xFECE10", VA = "0x180FEE210")]
			public PushMsgTask()
			{
			}

			// Token: 0x06017995 RID: 96661 RVA: 0x000975D8 File Offset: 0x000957D8
			[Token(Token = "0x6017995")]
			[Address(RVA = "0xDEB670", Offset = "0xDEA270", VA = "0x180DEB670")]
			private bool <>xLuaBaseProxy_CanConsume()
			{
				return default(bool);
			}

			// Token: 0x0401C79F RID: 116639
			[Token(Token = "0x401C79F")]
			[FieldOffset(Offset = "0x18")]
			public List<CrisisV2PushMessage.IPendingMsg> pendingMsgs;

			// Token: 0x0401C7A0 RID: 116640
			[Token(Token = "0x401C7A0")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x0401C7A1 RID: 116641
			[Token(Token = "0x401C7A1")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0401C7A2 RID: 116642
			[Token(Token = "0x401C7A2")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
