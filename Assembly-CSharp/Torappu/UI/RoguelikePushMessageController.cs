using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003AFD RID: 15101
	[Token(Token = "0x2003AFD")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class RoguelikePushMessageController
	{
		// Token: 0x06017CC8 RID: 97480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CC8")]
		public static void AddInGamePendingToast<TMsg>(List<TMsg> content, RoguelikePushMessageController.MsgHandler<TMsg> handler)
		{
		}

		// Token: 0x06017CC9 RID: 97481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017CC9")]
		public static void AddTopicPendingToast<TMsg>(List<TMsg> content, RoguelikePushMessageController.MsgHandler<TMsg> handler)
		{
		}

		// Token: 0x0401CBFE RID: 117758
		[Token(Token = "0x401CBFE")]
		[FieldOffset(Offset = "0x0")]
		private static List<RoguelikePushMessageController.PendingMsg> s_pendingMsgs;

		// Token: 0x0401CBFF RID: 117759
		[Token(Token = "0x401CBFF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_AddInGamePendingToast;

		// Token: 0x0401CC00 RID: 117760
		[Token(Token = "0x401CC00")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_AddTopicPendingToast;

		// Token: 0x02003AFE RID: 15102
		[Token(Token = "0x2003AFE")]
		private abstract class PendingMsg : IHotfixable
		{
			// Token: 0x06017CCB RID: 97483
			[Token(Token = "0x6017CCB")]
			public abstract void Handle();

			// Token: 0x06017CCC RID: 97484 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017CCC")]
			[Address(RVA = "0x1000D50", Offset = "0xFFF950", VA = "0x181000D50")]
			protected PendingMsg()
			{
			}

			// Token: 0x0401CC01 RID: 117761
			[Token(Token = "0x401CC01")]
			[FieldOffset(Offset = "0x10")]
			public long gameId;

			// Token: 0x0401CC02 RID: 117762
			[Token(Token = "0x401CC02")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003AFF RID: 15103
		[Token(Token = "0x2003AFF")]
		private class PendingMsg<TMsg> : RoguelikePushMessageController.PendingMsg
		{
			// Token: 0x06017CCD RID: 97485 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017CCD")]
			public override void Handle()
			{
			}

			// Token: 0x06017CCE RID: 97486 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017CCE")]
			public PendingMsg()
			{
			}

			// Token: 0x0401CC03 RID: 117763
			[Token(Token = "0x401CC03")]
			[FieldOffset(Offset = "0x0")]
			public List<TMsg> msg;

			// Token: 0x0401CC04 RID: 117764
			[Token(Token = "0x401CC04")]
			[FieldOffset(Offset = "0x0")]
			public RoguelikePushMessageController.MsgHandler<TMsg> handler;

			// Token: 0x0401CC05 RID: 117765
			[Token(Token = "0x401CC05")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Handle;

			// Token: 0x0401CC06 RID: 117766
			[Token(Token = "0x401CC06")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003B00 RID: 15104
		// (Invoke) Token: 0x06017CD0 RID: 97488
		[Token(Token = "0x2003B00")]
		public delegate void MsgHandler<TMsg>(List<TMsg> msg);

		// Token: 0x02003B01 RID: 15105
		[Token(Token = "0x2003B01")]
		private class InGameMsgTask : UINotificationTasks.MainUITask
		{
			// Token: 0x06017CD3 RID: 97491 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017CD3")]
			[Address(RVA = "0xFFB060", Offset = "0xFF9C60", VA = "0x180FFB060", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06017CD4 RID: 97492 RVA: 0x00098568 File Offset: 0x00096768
			[Token(Token = "0x6017CD4")]
			[Address(RVA = "0xFFAF10", Offset = "0xFF9B10", VA = "0x180FFAF10", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x06017CD5 RID: 97493 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017CD5")]
			[Address(RVA = "0xFFB220", Offset = "0xFF9E20", VA = "0x180FFB220")]
			public InGameMsgTask()
			{
			}

			// Token: 0x06017CD6 RID: 97494 RVA: 0x00098580 File Offset: 0x00096780
			[Token(Token = "0x6017CD6")]
			[Address(RVA = "0xDEB670", Offset = "0xDEA270", VA = "0x180DEB670")]
			private bool <>xLuaBaseProxy_CanConsume()
			{
				return default(bool);
			}

			// Token: 0x0401CC07 RID: 117767
			[Token(Token = "0x401CC07")]
			[FieldOffset(Offset = "0x18")]
			public List<RoguelikePushMessageController.PendingMsg> pendingMsgs;

			// Token: 0x0401CC08 RID: 117768
			[Token(Token = "0x401CC08")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0401CC09 RID: 117769
			[Token(Token = "0x401CC09")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x0401CC0A RID: 117770
			[Token(Token = "0x401CC0A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003B02 RID: 15106
		[Token(Token = "0x2003B02")]
		private class TopicMsgTask : UINotificationTasks.MainUITask
		{
			// Token: 0x06017CD7 RID: 97495 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017CD7")]
			[Address(RVA = "0x100EBA0", Offset = "0x100D7A0", VA = "0x18100EBA0", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06017CD8 RID: 97496 RVA: 0x00098598 File Offset: 0x00096798
			[Token(Token = "0x6017CD8")]
			[Address(RVA = "0x100EB00", Offset = "0x100D700", VA = "0x18100EB00", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x06017CD9 RID: 97497 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017CD9")]
			[Address(RVA = "0x100ECE0", Offset = "0x100D8E0", VA = "0x18100ECE0")]
			public TopicMsgTask()
			{
			}

			// Token: 0x06017CDA RID: 97498 RVA: 0x000985B0 File Offset: 0x000967B0
			[Token(Token = "0x6017CDA")]
			[Address(RVA = "0xDEB670", Offset = "0xDEA270", VA = "0x180DEB670")]
			private bool <>xLuaBaseProxy_CanConsume()
			{
				return default(bool);
			}

			// Token: 0x0401CC0B RID: 117771
			[Token(Token = "0x401CC0B")]
			[FieldOffset(Offset = "0x18")]
			public List<RoguelikePushMessageController.PendingMsg> pendingMsgs;

			// Token: 0x0401CC0C RID: 117772
			[Token(Token = "0x401CC0C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0401CC0D RID: 117773
			[Token(Token = "0x401CC0D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x0401CC0E RID: 117774
			[Token(Token = "0x401CC0E")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
