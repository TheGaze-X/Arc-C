using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003455 RID: 13397
	[Token(Token = "0x2003455")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class Act42D0PushMsgHandler
	{
		// Token: 0x06015674 RID: 87668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015674")]
		[Address(RVA = "0xDDDCB0", Offset = "0xDDC8B0", VA = "0x180DDDCB0")]
		public static void HandleAreaUnlock(List<Act42D0UnlockAreaPushMsg> msgList)
		{
		}

		// Token: 0x06015675 RID: 87669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015675")]
		[Address(RVA = "0xDDDE30", Offset = "0xDDCA30", VA = "0x180DDDE30")]
		public static void HandleCanUseBuff(List<Act42D0CanUseBuffPushMsg> msgList)
		{
		}

		// Token: 0x06015676 RID: 87670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015676")]
		[Address(RVA = "0xDDDF50", Offset = "0xDDCB50", VA = "0x180DDDF50")]
		private static void _HandleUnlockAreaImpl(List<Act42D0UnlockAreaPushMsg> msgList)
		{
		}

		// Token: 0x06015677 RID: 87671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015677")]
		[Address(RVA = "0xDDE130", Offset = "0xDDCD30", VA = "0x180DDE130")]
		private static void _ShowAreaUnlockDialog(string actId, string areaId)
		{
		}

		// Token: 0x06015678 RID: 87672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015678")]
		private static void _AddPendingMsg<TMsg>(List<TMsg> content, Act42D0PushMsgHandler.MsgHandler<TMsg> handler)
		{
		}

		// Token: 0x040199EB RID: 104939
		[Token(Token = "0x40199EB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleAreaUnlock;

		// Token: 0x040199EC RID: 104940
		[Token(Token = "0x40199EC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleCanUseBuff;

		// Token: 0x040199ED RID: 104941
		[Token(Token = "0x40199ED")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__HandleUnlockAreaImpl;

		// Token: 0x040199EE RID: 104942
		[Token(Token = "0x40199EE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__ShowAreaUnlockDialog;

		// Token: 0x040199EF RID: 104943
		[Token(Token = "0x40199EF")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__AddPendingMsg;

		// Token: 0x02003456 RID: 13398
		[Token(Token = "0x2003456")]
		private interface IPendingMsg : IHotfixable
		{
			// Token: 0x06015679 RID: 87673
			[Token(Token = "0x6015679")]
			void Handle();
		}

		// Token: 0x02003457 RID: 13399
		[Token(Token = "0x2003457")]
		private class PendingMsg<TMsg> : Act42D0PushMsgHandler.IPendingMsg, IHotfixable
		{
			// Token: 0x0601567A RID: 87674 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601567A")]
			public void Handle()
			{
			}

			// Token: 0x0601567B RID: 87675 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601567B")]
			public PendingMsg()
			{
			}

			// Token: 0x040199F0 RID: 104944
			[Token(Token = "0x40199F0")]
			[FieldOffset(Offset = "0x0")]
			public List<TMsg> msg;

			// Token: 0x040199F1 RID: 104945
			[Token(Token = "0x40199F1")]
			[FieldOffset(Offset = "0x0")]
			public Act42D0PushMsgHandler.MsgHandler<TMsg> handler;

			// Token: 0x040199F2 RID: 104946
			[Token(Token = "0x40199F2")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Handle;

			// Token: 0x040199F3 RID: 104947
			[Token(Token = "0x40199F3")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003458 RID: 13400
		// (Invoke) Token: 0x0601567D RID: 87677
		[Token(Token = "0x2003458")]
		private delegate void MsgHandler<TMsg>(List<TMsg> msg);

		// Token: 0x02003459 RID: 13401
		[Token(Token = "0x2003459")]
		private class PushMsgTask : UINotificationTasks.MainUITask
		{
			// Token: 0x06015680 RID: 87680 RVA: 0x0008BB78 File Offset: 0x00089D78
			[Token(Token = "0x6015680")]
			[Address(RVA = "0xDEB490", Offset = "0xDEA090", VA = "0x180DEB490", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x06015681 RID: 87681 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015681")]
			[Address(RVA = "0xDEB530", Offset = "0xDEA130", VA = "0x180DEB530", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06015682 RID: 87682 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015682")]
			[Address(RVA = "0xDEB680", Offset = "0xDEA280", VA = "0x180DEB680")]
			public PushMsgTask()
			{
			}

			// Token: 0x06015683 RID: 87683 RVA: 0x0008BB90 File Offset: 0x00089D90
			[Token(Token = "0x6015683")]
			[Address(RVA = "0xDEB670", Offset = "0xDEA270", VA = "0x180DEB670")]
			private bool <>xLuaBaseProxy_CanConsume()
			{
				return default(bool);
			}

			// Token: 0x040199F4 RID: 104948
			[Token(Token = "0x40199F4")]
			[FieldOffset(Offset = "0x18")]
			public List<Act42D0PushMsgHandler.IPendingMsg> pendingMsgs;

			// Token: 0x040199F5 RID: 104949
			[Token(Token = "0x40199F5")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x040199F6 RID: 104950
			[Token(Token = "0x40199F6")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x040199F7 RID: 104951
			[Token(Token = "0x40199F7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
