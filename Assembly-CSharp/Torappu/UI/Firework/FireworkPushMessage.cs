using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Firework
{
	// Token: 0x02004E45 RID: 20037
	[Token(Token = "0x2004E45")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class FireworkPushMessage
	{
		// Token: 0x0601DEBC RID: 122556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEBC")]
		[Address(RVA = "0x17723E0", Offset = "0x1770FE0", VA = "0x1817723E0")]
		public static void HandleFireworkUnlock(List<FireworkUnlockPushMessage> msgList)
		{
		}

		// Token: 0x0601DEBD RID: 122557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEBD")]
		[Address(RVA = "0x17722F0", Offset = "0x1770EF0", VA = "0x1817722F0")]
		public static void HandleFireworkPlateUnlock(List<FireworkPlateUnlockPushMessage> msgList)
		{
		}

		// Token: 0x0601DEBE RID: 122558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601DEBE")]
		[Address(RVA = "0x1772200", Offset = "0x1770E00", VA = "0x181772200")]
		public static void HandleFireworkAnimalUnlock(List<FireworkAnimalUnlockPushMessage> msgList)
		{
		}

		// Token: 0x04027B71 RID: 162673
		[Token(Token = "0x4027B71")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_HandleFireworkUnlock;

		// Token: 0x04027B72 RID: 162674
		[Token(Token = "0x4027B72")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleFireworkPlateUnlock;

		// Token: 0x04027B73 RID: 162675
		[Token(Token = "0x4027B73")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HandleFireworkAnimalUnlock;

		// Token: 0x02004E46 RID: 20038
		[Token(Token = "0x2004E46")]
		private interface IPendingMsg : IHotfixable
		{
			// Token: 0x0601DEBF RID: 122559
			[Token(Token = "0x601DEBF")]
			void Handle();
		}

		// Token: 0x02004E47 RID: 20039
		[Token(Token = "0x2004E47")]
		private class PushMsgTask : UINotificationTasks.MainUITask, IHotfixable
		{
			// Token: 0x0601DEC0 RID: 122560 RVA: 0x000ACE78 File Offset: 0x000AB078
			[Token(Token = "0x601DEC0")]
			[Address(RVA = "0x17B0780", Offset = "0x17AF380", VA = "0x1817B0780", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x0601DEC1 RID: 122561 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DEC1")]
			[Address(RVA = "0x17B0820", Offset = "0x17AF420", VA = "0x1817B0820", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x0601DEC2 RID: 122562 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DEC2")]
			[Address(RVA = "0x17B0900", Offset = "0x17AF500", VA = "0x1817B0900")]
			public PushMsgTask()
			{
			}

			// Token: 0x0601DEC3 RID: 122563 RVA: 0x000ACE90 File Offset: 0x000AB090
			[Token(Token = "0x601DEC3")]
			[Address(RVA = "0xDEB670", Offset = "0xDEA270", VA = "0x180DEB670")]
			private bool <>xLuaBaseProxy_CanConsume()
			{
				return default(bool);
			}

			// Token: 0x04027B74 RID: 162676
			[Token(Token = "0x4027B74")]
			[FieldOffset(Offset = "0x18")]
			public List<FireworkPushMessage.IPendingMsg> pendingMsgList;

			// Token: 0x04027B75 RID: 162677
			[Token(Token = "0x4027B75")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x04027B76 RID: 162678
			[Token(Token = "0x4027B76")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x04027B77 RID: 162679
			[Token(Token = "0x4027B77")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004E48 RID: 20040
		[Token(Token = "0x2004E48")]
		private class FireworkUnlockMessage : FireworkPushMessage.IPendingMsg, IHotfixable
		{
			// Token: 0x0601DEC4 RID: 122564 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DEC4")]
			[Address(RVA = "0x17AE4D0", Offset = "0x17AD0D0", VA = "0x1817AE4D0", Slot = "4")]
			public void Handle()
			{
			}

			// Token: 0x0601DEC5 RID: 122565 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DEC5")]
			[Address(RVA = "0x17AE5A0", Offset = "0x17AD1A0", VA = "0x1817AE5A0")]
			public FireworkUnlockMessage()
			{
			}

			// Token: 0x04027B78 RID: 162680
			[Token(Token = "0x4027B78")]
			[FieldOffset(Offset = "0x10")]
			public List<FireworkUnlockPushMessage> msgList;

			// Token: 0x04027B79 RID: 162681
			[Token(Token = "0x4027B79")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Handle;

			// Token: 0x04027B7A RID: 162682
			[Token(Token = "0x4027B7A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004E49 RID: 20041
		[Token(Token = "0x2004E49")]
		private class FireworkPlateUnlockMessage : FireworkPushMessage.IPendingMsg, IHotfixable
		{
			// Token: 0x0601DEC6 RID: 122566 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DEC6")]
			[Address(RVA = "0x17A2640", Offset = "0x17A1240", VA = "0x1817A2640", Slot = "4")]
			public void Handle()
			{
			}

			// Token: 0x0601DEC7 RID: 122567 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DEC7")]
			[Address(RVA = "0x17A28D0", Offset = "0x17A14D0", VA = "0x1817A28D0")]
			public FireworkPlateUnlockMessage()
			{
			}

			// Token: 0x04027B7B RID: 162683
			[Token(Token = "0x4027B7B")]
			[FieldOffset(Offset = "0x10")]
			public List<FireworkPlateUnlockPushMessage> msgList;

			// Token: 0x04027B7C RID: 162684
			[Token(Token = "0x4027B7C")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Handle;

			// Token: 0x04027B7D RID: 162685
			[Token(Token = "0x4027B7D")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02004E4A RID: 20042
		[Token(Token = "0x2004E4A")]
		private class FireworkAnimalUnlockMessage : FireworkPushMessage.IPendingMsg, IHotfixable
		{
			// Token: 0x0601DEC8 RID: 122568 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DEC8")]
			[Address(RVA = "0x1799AE0", Offset = "0x17986E0", VA = "0x181799AE0", Slot = "4")]
			public void Handle()
			{
			}

			// Token: 0x0601DEC9 RID: 122569 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601DEC9")]
			[Address(RVA = "0x1799CC0", Offset = "0x17988C0", VA = "0x181799CC0")]
			public FireworkAnimalUnlockMessage()
			{
			}

			// Token: 0x04027B7E RID: 162686
			[Token(Token = "0x4027B7E")]
			[FieldOffset(Offset = "0x10")]
			public List<FireworkAnimalUnlockPushMessage> msgList;

			// Token: 0x04027B7F RID: 162687
			[Token(Token = "0x4027B7F")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Handle;

			// Token: 0x04027B80 RID: 162688
			[Token(Token = "0x4027B80")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
