using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Carving
{
	// Token: 0x020060A2 RID: 24738
	[Token(Token = "0x20060A2")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class CarvingPushMessage
	{
		// Token: 0x06023CA7 RID: 146599 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CA7")]
		[Address(RVA = "0x1E7C220", Offset = "0x1E7AE20", VA = "0x181E7C220")]
		public static void HandleChallengeUnlock(List<CarvingChallengeUnlockPushMsg> msgList)
		{
		}

		// Token: 0x06023CA8 RID: 146600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CA8")]
		[Address(RVA = "0x1E7C2E0", Offset = "0x1E7AEE0", VA = "0x181E7C2E0")]
		private static void _HandleChallengeUnlock(List<CarvingChallengeUnlockPushMsg> msgList)
		{
		}

		// Token: 0x06023CA9 RID: 146601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CA9")]
		private static void _AddCarvingPagePendingMsg<TMsg>(List<TMsg> content, CarvingPushMessage.MsgHandler<TMsg> handler)
		{
		}

		// Token: 0x06023CAA RID: 146602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023CAA")]
		[Address(RVA = "0x1E7C160", Offset = "0x1E7AD60", VA = "0x181E7C160")]
		public static void HandleCarvingUnlock(List<CarvingUnlockPushMsg> msgList)
		{
		}

		// Token: 0x04031A07 RID: 203271
		[Token(Token = "0x4031A07")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleChallengeUnlock;

		// Token: 0x04031A08 RID: 203272
		[Token(Token = "0x4031A08")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__HandleChallengeUnlock;

		// Token: 0x04031A09 RID: 203273
		[Token(Token = "0x4031A09")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__AddCarvingPagePendingMsg;

		// Token: 0x04031A0A RID: 203274
		[Token(Token = "0x4031A0A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_HandleCarvingUnlock;

		// Token: 0x020060A3 RID: 24739
		[Token(Token = "0x20060A3")]
		private interface IPendingMsg : IHotfixable
		{
			// Token: 0x06023CAB RID: 146603
			[Token(Token = "0x6023CAB")]
			void Handle();
		}

		// Token: 0x020060A4 RID: 24740
		[Token(Token = "0x20060A4")]
		private class PendingMsg<TMsg> : CarvingPushMessage.IPendingMsg, IHotfixable
		{
			// Token: 0x06023CAC RID: 146604 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023CAC")]
			public void Handle()
			{
			}

			// Token: 0x06023CAD RID: 146605 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023CAD")]
			public PendingMsg()
			{
			}

			// Token: 0x04031A0B RID: 203275
			[Token(Token = "0x4031A0B")]
			[FieldOffset(Offset = "0x0")]
			public List<TMsg> msg;

			// Token: 0x04031A0C RID: 203276
			[Token(Token = "0x4031A0C")]
			[FieldOffset(Offset = "0x0")]
			public CarvingPushMessage.MsgHandler<TMsg> handler;

			// Token: 0x04031A0D RID: 203277
			[Token(Token = "0x4031A0D")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Handle;

			// Token: 0x04031A0E RID: 203278
			[Token(Token = "0x4031A0E")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020060A5 RID: 24741
		// (Invoke) Token: 0x06023CAF RID: 146607
		[Token(Token = "0x20060A5")]
		private delegate void MsgHandler<TMsg>(List<TMsg> msg);

		// Token: 0x020060A6 RID: 24742
		[Token(Token = "0x20060A6")]
		private class PushMsgTask : UINotificationTasks.MainUITask
		{
			// Token: 0x06023CB2 RID: 146610 RVA: 0x000C20D0 File Offset: 0x000C02D0
			[Token(Token = "0x6023CB2")]
			[Address(RVA = "0x1E80B30", Offset = "0x1E7F730", VA = "0x181E80B30", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x06023CB3 RID: 146611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023CB3")]
			[Address(RVA = "0x1E80C40", Offset = "0x1E7F840", VA = "0x181E80C40", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06023CB4 RID: 146612 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023CB4")]
			[Address(RVA = "0x1E80D20", Offset = "0x1E7F920", VA = "0x181E80D20")]
			public PushMsgTask()
			{
			}

			// Token: 0x06023CB5 RID: 146613 RVA: 0x000C20E8 File Offset: 0x000C02E8
			[Token(Token = "0x6023CB5")]
			[Address(RVA = "0xDEB670", Offset = "0xDEA270", VA = "0x180DEB670")]
			private bool <>xLuaBaseProxy_CanConsume()
			{
				return default(bool);
			}

			// Token: 0x04031A0F RID: 203279
			[Token(Token = "0x4031A0F")]
			[FieldOffset(Offset = "0x18")]
			public List<CarvingPushMessage.IPendingMsg> pendingMsgList;

			// Token: 0x04031A10 RID: 203280
			[Token(Token = "0x4031A10")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x04031A11 RID: 203281
			[Token(Token = "0x4031A11")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x04031A12 RID: 203282
			[Token(Token = "0x4031A12")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x020060A7 RID: 24743
		[Token(Token = "0x20060A7")]
		private class CarvingUnlockMessage : UINotificationTasks.DefaultMainUITask.ICall
		{
			// Token: 0x06023CB6 RID: 146614 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023CB6")]
			[Address(RVA = "0x1E7D950", Offset = "0x1E7C550", VA = "0x181E7D950", Slot = "4")]
			public void Call()
			{
			}

			// Token: 0x06023CB7 RID: 146615 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6023CB7")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public CarvingUnlockMessage()
			{
			}

			// Token: 0x04031A13 RID: 203283
			[Token(Token = "0x4031A13")]
			[FieldOffset(Offset = "0x10")]
			public List<CarvingUnlockPushMsg> msgList;
		}
	}
}
