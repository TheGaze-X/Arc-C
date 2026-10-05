using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B34 RID: 15156
	[Token(Token = "0x2003B34")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SandboxV2PushMessageController
	{
		// Token: 0x06017D36 RID: 97590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D36")]
		public static void AddInGameDungeonMsgPendingMsgs<TMsg>(List<TMsg> content, SandboxV2PushMessageController.MsgHandler<TMsg> handler, string topicId)
		{
		}

		// Token: 0x06017D37 RID: 97591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D37")]
		public static void AddInGameDungeonAndAdminMsgPendingMsgs<TMsg>(List<TMsg> content, SandboxV2PushMessageController.MsgHandler<TMsg> handler, string topicId)
		{
		}

		// Token: 0x06017D38 RID: 97592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D38")]
		public static void AddInRiftGameDungeonMsgPendingMsgs<TMsg>(List<TMsg> content, SandboxV2PushMessageController.MsgHandler<TMsg> handler, string topicId)
		{
		}

		// Token: 0x06017D39 RID: 97593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017D39")]
		public static void AddMonthPendingMsgs<TMsg>(List<TMsg> content, SandboxV2PushMessageController.MsgHandler<TMsg> handler)
		{
		}

		// Token: 0x0401CC6D RID: 117869
		[Token(Token = "0x401CC6D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_AddInGameDungeonMsgPendingMsgs;

		// Token: 0x0401CC6E RID: 117870
		[Token(Token = "0x401CC6E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AddInGameDungeonAndAdminMsgPendingMsgs;

		// Token: 0x0401CC6F RID: 117871
		[Token(Token = "0x401CC6F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AddInRiftGameDungeonMsgPendingMsgs;

		// Token: 0x0401CC70 RID: 117872
		[Token(Token = "0x401CC70")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_AddMonthPendingMsgs;

		// Token: 0x02003B35 RID: 15157
		[Token(Token = "0x2003B35")]
		private abstract class PendingMsg : IHotfixable
		{
			// Token: 0x06017D3A RID: 97594
			[Token(Token = "0x6017D3A")]
			public abstract void Handle();

			// Token: 0x06017D3B RID: 97595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017D3B")]
			[Address(RVA = "0x1013800", Offset = "0x1012400", VA = "0x181013800")]
			protected PendingMsg()
			{
			}

			// Token: 0x0401CC71 RID: 117873
			[Token(Token = "0x401CC71")]
			[FieldOffset(Offset = "0x10")]
			public long gameId;

			// Token: 0x0401CC72 RID: 117874
			[Token(Token = "0x401CC72")]
			[FieldOffset(Offset = "0x18")]
			public string topicId;

			// Token: 0x0401CC73 RID: 117875
			[Token(Token = "0x401CC73")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003B36 RID: 15158
		[Token(Token = "0x2003B36")]
		private class PendingMsg<TMsg> : SandboxV2PushMessageController.PendingMsg
		{
			// Token: 0x06017D3C RID: 97596 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017D3C")]
			public override void Handle()
			{
			}

			// Token: 0x06017D3D RID: 97597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017D3D")]
			public PendingMsg()
			{
			}

			// Token: 0x0401CC74 RID: 117876
			[Token(Token = "0x401CC74")]
			[FieldOffset(Offset = "0x0")]
			public List<TMsg> msg;

			// Token: 0x0401CC75 RID: 117877
			[Token(Token = "0x401CC75")]
			[FieldOffset(Offset = "0x0")]
			public SandboxV2PushMessageController.MsgHandler<TMsg> handler;

			// Token: 0x0401CC76 RID: 117878
			[Token(Token = "0x401CC76")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Handle;

			// Token: 0x0401CC77 RID: 117879
			[Token(Token = "0x401CC77")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003B37 RID: 15159
		// (Invoke) Token: 0x06017D3F RID: 97599
		[Token(Token = "0x2003B37")]
		public delegate void MsgHandler<TMsg>(List<TMsg> msg);

		// Token: 0x02003B38 RID: 15160
		[Token(Token = "0x2003B38")]
		private class InGameDungeonMsgTask : UINotificationTasks.MainUITask
		{
			// Token: 0x06017D42 RID: 97602 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017D42")]
			[Address(RVA = "0x1012950", Offset = "0x1011550", VA = "0x181012950", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06017D43 RID: 97603 RVA: 0x00098610 File Offset: 0x00096810
			[Token(Token = "0x6017D43")]
			[Address(RVA = "0x10127A0", Offset = "0x10113A0", VA = "0x1810127A0", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x06017D44 RID: 97604 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017D44")]
			[Address(RVA = "0x1012C70", Offset = "0x1011870", VA = "0x181012C70")]
			public InGameDungeonMsgTask()
			{
			}

			// Token: 0x06017D45 RID: 97605 RVA: 0x00098628 File Offset: 0x00096828
			[Token(Token = "0x6017D45")]
			[Address(RVA = "0xDEB670", Offset = "0xDEA270", VA = "0x180DEB670")]
			private bool <>xLuaBaseProxy_CanConsume()
			{
				return default(bool);
			}

			// Token: 0x0401CC78 RID: 117880
			[Token(Token = "0x401CC78")]
			[FieldOffset(Offset = "0x18")]
			public List<SandboxV2PushMessageController.PendingMsg> pendingMsgs;

			// Token: 0x0401CC79 RID: 117881
			[Token(Token = "0x401CC79")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0401CC7A RID: 117882
			[Token(Token = "0x401CC7A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x0401CC7B RID: 117883
			[Token(Token = "0x401CC7B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003B39 RID: 15161
		[Token(Token = "0x2003B39")]
		private class InRiftGameDungeonMsgTask : UINotificationTasks.MainUITask
		{
			// Token: 0x06017D46 RID: 97606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017D46")]
			[Address(RVA = "0x1013040", Offset = "0x1011C40", VA = "0x181013040", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06017D47 RID: 97607 RVA: 0x00098640 File Offset: 0x00096840
			[Token(Token = "0x6017D47")]
			[Address(RVA = "0x1012D20", Offset = "0x1011920", VA = "0x181012D20", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x06017D48 RID: 97608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017D48")]
			[Address(RVA = "0x1013360", Offset = "0x1011F60", VA = "0x181013360")]
			public InRiftGameDungeonMsgTask()
			{
			}

			// Token: 0x06017D49 RID: 97609 RVA: 0x00098658 File Offset: 0x00096858
			[Token(Token = "0x6017D49")]
			[Address(RVA = "0xDEB670", Offset = "0xDEA270", VA = "0x180DEB670")]
			private bool <>xLuaBaseProxy_CanConsume()
			{
				return default(bool);
			}

			// Token: 0x0401CC7C RID: 117884
			[Token(Token = "0x401CC7C")]
			[FieldOffset(Offset = "0x18")]
			public List<SandboxV2PushMessageController.PendingMsg> pendingMsgs;

			// Token: 0x0401CC7D RID: 117885
			[Token(Token = "0x401CC7D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0401CC7E RID: 117886
			[Token(Token = "0x401CC7E")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x0401CC7F RID: 117887
			[Token(Token = "0x401CC7F")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003B3A RID: 15162
		[Token(Token = "0x2003B3A")]
		private class InGameDungeonAndAdminMsgTask : UINotificationTasks.MainUITask
		{
			// Token: 0x06017D4A RID: 97610 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017D4A")]
			[Address(RVA = "0x1012600", Offset = "0x1011200", VA = "0x181012600", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06017D4B RID: 97611 RVA: 0x00098670 File Offset: 0x00096870
			[Token(Token = "0x6017D4B")]
			[Address(RVA = "0x10123E0", Offset = "0x1010FE0", VA = "0x1810123E0", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x06017D4C RID: 97612 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017D4C")]
			[Address(RVA = "0x10126F0", Offset = "0x10112F0", VA = "0x1810126F0")]
			public InGameDungeonAndAdminMsgTask()
			{
			}

			// Token: 0x06017D4D RID: 97613 RVA: 0x00098688 File Offset: 0x00096888
			[Token(Token = "0x6017D4D")]
			[Address(RVA = "0xDEB670", Offset = "0xDEA270", VA = "0x180DEB670")]
			private bool <>xLuaBaseProxy_CanConsume()
			{
				return default(bool);
			}

			// Token: 0x0401CC80 RID: 117888
			[Token(Token = "0x401CC80")]
			[FieldOffset(Offset = "0x18")]
			public List<SandboxV2PushMessageController.PendingMsg> pendingMsgs;

			// Token: 0x0401CC81 RID: 117889
			[Token(Token = "0x401CC81")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0401CC82 RID: 117890
			[Token(Token = "0x401CC82")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x0401CC83 RID: 117891
			[Token(Token = "0x401CC83")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003B3B RID: 15163
		[Token(Token = "0x2003B3B")]
		private class MonthModeMsgTask : UINotificationTasks.MainUITask
		{
			// Token: 0x06017D4E RID: 97614 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017D4E")]
			[Address(RVA = "0x1013610", Offset = "0x1012210", VA = "0x181013610", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06017D4F RID: 97615 RVA: 0x000986A0 File Offset: 0x000968A0
			[Token(Token = "0x6017D4F")]
			[Address(RVA = "0x1013460", Offset = "0x1012060", VA = "0x181013460", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x06017D50 RID: 97616 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017D50")]
			[Address(RVA = "0x1013750", Offset = "0x1012350", VA = "0x181013750")]
			public MonthModeMsgTask()
			{
			}

			// Token: 0x06017D51 RID: 97617 RVA: 0x000986B8 File Offset: 0x000968B8
			[Token(Token = "0x6017D51")]
			[Address(RVA = "0xDEB670", Offset = "0xDEA270", VA = "0x180DEB670")]
			private bool <>xLuaBaseProxy_CanConsume()
			{
				return default(bool);
			}

			// Token: 0x0401CC84 RID: 117892
			[Token(Token = "0x401CC84")]
			[FieldOffset(Offset = "0x18")]
			public List<SandboxV2PushMessageController.PendingMsg> pendingMsgs;

			// Token: 0x0401CC85 RID: 117893
			[Token(Token = "0x401CC85")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0401CC86 RID: 117894
			[Token(Token = "0x401CC86")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x0401CC87 RID: 117895
			[Token(Token = "0x401CC87")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
