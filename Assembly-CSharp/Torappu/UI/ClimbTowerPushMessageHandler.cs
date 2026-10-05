using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003498 RID: 13464
	[Token(Token = "0x2003498")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class ClimbTowerPushMessageHandler
	{
		// Token: 0x0601577B RID: 87931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601577B")]
		[Address(RVA = "0xDE9A60", Offset = "0xDE8660", VA = "0x180DE9A60")]
		public static void HandleTowerHardModeUnlock(List<ClimbTowerHardModeTowerPushMsg> msgList)
		{
		}

		// Token: 0x0601577C RID: 87932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601577C")]
		[Address(RVA = "0xDE9C50", Offset = "0xDE8850", VA = "0x180DE9C50")]
		private static void _HandleTowerHardModeImpl(List<ClimbTowerHardModeTowerPushMsg> msgList)
		{
		}

		// Token: 0x0601577D RID: 87933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601577D")]
		[Address(RVA = "0xDE9B90", Offset = "0xDE8790", VA = "0x180DE9B90")]
		public static void HandleTowerSweepUnlock(List<ClimbTowerSweepUnlockPushMsg> msgList)
		{
		}

		// Token: 0x0601577E RID: 87934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601577E")]
		[Address(RVA = "0xDE9E00", Offset = "0xDE8A00", VA = "0x180DE9E00")]
		private static void _HandleTowerSweepUnlockTmpl(List<ClimbTowerSweepUnlockPushMsg> msgList)
		{
		}

		// Token: 0x0601577F RID: 87935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601577F")]
		private static void _AddTowerEntryPendingMsg<TMsg>(List<TMsg> content, ClimbTowerPushMessageHandler.MsgHandler<TMsg> handler)
		{
		}

		// Token: 0x06015780 RID: 87936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6015780")]
		private static void _AddTowerSweepPendingMsg<TMsg>(List<TMsg> content, ClimbTowerPushMessageHandler.MsgHandler<TMsg> handler)
		{
		}

		// Token: 0x04019B42 RID: 105282
		[Token(Token = "0x4019B42")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleTowerHardModeUnlock;

		// Token: 0x04019B43 RID: 105283
		[Token(Token = "0x4019B43")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleTowerHardModeImpl;

		// Token: 0x04019B44 RID: 105284
		[Token(Token = "0x4019B44")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleTowerSweepUnlock;

		// Token: 0x04019B45 RID: 105285
		[Token(Token = "0x4019B45")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HandleTowerSweepUnlockTmpl;

		// Token: 0x04019B46 RID: 105286
		[Token(Token = "0x4019B46")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__AddTowerEntryPendingMsg;

		// Token: 0x04019B47 RID: 105287
		[Token(Token = "0x4019B47")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__AddTowerSweepPendingMsg;

		// Token: 0x02003499 RID: 13465
		[Token(Token = "0x2003499")]
		private interface IPendingMsg : IHotfixable
		{
			// Token: 0x06015781 RID: 87937
			[Token(Token = "0x6015781")]
			void Handle();
		}

		// Token: 0x0200349A RID: 13466
		[Token(Token = "0x200349A")]
		private class PendingMsg<TMsg> : ClimbTowerPushMessageHandler.IPendingMsg, IHotfixable
		{
			// Token: 0x06015782 RID: 87938 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015782")]
			public void Handle()
			{
			}

			// Token: 0x06015783 RID: 87939 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015783")]
			public PendingMsg()
			{
			}

			// Token: 0x04019B48 RID: 105288
			[Token(Token = "0x4019B48")]
			[FieldOffset(Offset = "0x0")]
			public List<TMsg> msg;

			// Token: 0x04019B49 RID: 105289
			[Token(Token = "0x4019B49")]
			[FieldOffset(Offset = "0x0")]
			public ClimbTowerPushMessageHandler.MsgHandler<TMsg> handler;

			// Token: 0x04019B4A RID: 105290
			[Token(Token = "0x4019B4A")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Handle;

			// Token: 0x04019B4B RID: 105291
			[Token(Token = "0x4019B4B")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200349B RID: 13467
		// (Invoke) Token: 0x06015785 RID: 87941
		[Token(Token = "0x200349B")]
		private delegate void MsgHandler<TMsg>(List<TMsg> msg);

		// Token: 0x0200349C RID: 13468
		[Token(Token = "0x200349C")]
		private class TowerEntryStatePushMsgTask : UINotificationTasks.MainUITask
		{
			// Token: 0x06015788 RID: 87944 RVA: 0x0008C0E8 File Offset: 0x0008A2E8
			[Token(Token = "0x6015788")]
			[Address(RVA = "0xDEEA50", Offset = "0xDED650", VA = "0x180DEEA50", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x06015789 RID: 87945 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6015789")]
			[Address(RVA = "0xDEEB50", Offset = "0xDED750", VA = "0x180DEEB50", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x0601578A RID: 87946 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601578A")]
			[Address(RVA = "0xDEEC90", Offset = "0xDED890", VA = "0x180DEEC90")]
			public TowerEntryStatePushMsgTask()
			{
			}

			// Token: 0x0601578B RID: 87947 RVA: 0x0008C100 File Offset: 0x0008A300
			[Token(Token = "0x601578B")]
			[Address(RVA = "0xDEB670", Offset = "0xDEA270", VA = "0x180DEB670")]
			private bool <>xLuaBaseProxy_CanConsume()
			{
				return default(bool);
			}

			// Token: 0x04019B4C RID: 105292
			[Token(Token = "0x4019B4C")]
			[FieldOffset(Offset = "0x18")]
			public List<ClimbTowerPushMessageHandler.IPendingMsg> pendingMsgs;

			// Token: 0x04019B4D RID: 105293
			[Token(Token = "0x4019B4D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x04019B4E RID: 105294
			[Token(Token = "0x4019B4E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x04019B4F RID: 105295
			[Token(Token = "0x4019B4F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x0200349D RID: 13469
		[Token(Token = "0x200349D")]
		private class TowerSweepPushMsgTask : UINotificationTasks.MainUITask
		{
			// Token: 0x0601578C RID: 87948 RVA: 0x0008C118 File Offset: 0x0008A318
			[Token(Token = "0x601578C")]
			[Address(RVA = "0xDEED40", Offset = "0xDED940", VA = "0x180DEED40", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x0601578D RID: 87949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601578D")]
			[Address(RVA = "0xDEEDE0", Offset = "0xDED9E0", VA = "0x180DEEDE0", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x0601578E RID: 87950 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601578E")]
			[Address(RVA = "0xDEEF20", Offset = "0xDEDB20", VA = "0x180DEEF20")]
			public TowerSweepPushMsgTask()
			{
			}

			// Token: 0x0601578F RID: 87951 RVA: 0x0008C130 File Offset: 0x0008A330
			[Token(Token = "0x601578F")]
			[Address(RVA = "0xDEB670", Offset = "0xDEA270", VA = "0x180DEB670")]
			private bool <>xLuaBaseProxy_CanConsume()
			{
				return default(bool);
			}

			// Token: 0x04019B50 RID: 105296
			[Token(Token = "0x4019B50")]
			[FieldOffset(Offset = "0x18")]
			public List<ClimbTowerPushMessageHandler.IPendingMsg> pendingMsgs;

			// Token: 0x04019B51 RID: 105297
			[Token(Token = "0x4019B51")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x04019B52 RID: 105298
			[Token(Token = "0x4019B52")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x04019B53 RID: 105299
			[Token(Token = "0x4019B53")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
