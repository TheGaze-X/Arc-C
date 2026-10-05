using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI
{
	// Token: 0x02003B61 RID: 15201
	[Token(Token = "0x2003B61")]
	[Hotfix(HotfixFlag.Stateless)]
	public static class SiracusaPushMessageHandler
	{
		// Token: 0x06017DA5 RID: 97701 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DA5")]
		[Address(RVA = "0x101C770", Offset = "0x101B370", VA = "0x18101C770")]
		private static void _HandleTaskCompleteImpl(List<SiracusaTaskCompletePushMsg> msgList)
		{
		}

		// Token: 0x06017DA6 RID: 97702 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DA6")]
		[Address(RVA = "0x101C450", Offset = "0x101B050", VA = "0x18101C450")]
		public static void HandleTaskComplete(List<SiracusaTaskCompletePushMsg> msgList)
		{
		}

		// Token: 0x06017DA7 RID: 97703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DA7")]
		[Address(RVA = "0x101C9D0", Offset = "0x101B5D0", VA = "0x18101C9D0")]
		private static void _ShowCharCardDialog(string charId, bool isUnlock)
		{
		}

		// Token: 0x06017DA8 RID: 97704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DA8")]
		[Address(RVA = "0x101C670", Offset = "0x101B270", VA = "0x18101C670")]
		private static void _HandleCharCardStateImpl(List<SiracusaCharCardStatePushMsg> msgList)
		{
		}

		// Token: 0x06017DA9 RID: 97705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DA9")]
		[Address(RVA = "0x101C390", Offset = "0x101AF90", VA = "0x18101C390")]
		public static void HandleCharCardState(List<SiracusaCharCardStatePushMsg> msgList)
		{
		}

		// Token: 0x06017DAA RID: 97706 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DAA")]
		[Address(RVA = "0x101C2D0", Offset = "0x101AED0", VA = "0x18101C2D0")]
		public static void HandleAreaUnlock(List<SiracusaAreaUnlockPushMsg> msgList)
		{
		}

		// Token: 0x06017DAB RID: 97707 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DAB")]
		[Address(RVA = "0x101C510", Offset = "0x101B110", VA = "0x18101C510")]
		private static void _HandleAreaUnlockImpl(List<SiracusaAreaUnlockPushMsg> msgList)
		{
		}

		// Token: 0x06017DAC RID: 97708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DAC")]
		[Address(RVA = "0x101C8E0", Offset = "0x101B4E0", VA = "0x18101C8E0")]
		private static void _ShowAreaUnlockDialog(string areaId)
		{
		}

		// Token: 0x06017DAD RID: 97709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6017DAD")]
		private static void _AddPendingMsg<TMsg>(List<TMsg> content, SiracusaPushMessageHandler.MsgHandler<TMsg> handler)
		{
		}

		// Token: 0x0401CD0B RID: 118027
		[Token(Token = "0x401CD0B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__HandleTaskCompleteImpl;

		// Token: 0x0401CD0C RID: 118028
		[Token(Token = "0x401CD0C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HandleTaskComplete;

		// Token: 0x0401CD0D RID: 118029
		[Token(Token = "0x401CD0D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__ShowCharCardDialog;

		// Token: 0x0401CD0E RID: 118030
		[Token(Token = "0x401CD0E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__HandleCharCardStateImpl;

		// Token: 0x0401CD0F RID: 118031
		[Token(Token = "0x401CD0F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HandleCharCardState;

		// Token: 0x0401CD10 RID: 118032
		[Token(Token = "0x401CD10")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_HandleAreaUnlock;

		// Token: 0x0401CD11 RID: 118033
		[Token(Token = "0x401CD11")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__HandleAreaUnlockImpl;

		// Token: 0x0401CD12 RID: 118034
		[Token(Token = "0x401CD12")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ShowAreaUnlockDialog;

		// Token: 0x0401CD13 RID: 118035
		[Token(Token = "0x401CD13")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__AddPendingMsg;

		// Token: 0x02003B62 RID: 15202
		[Token(Token = "0x2003B62")]
		private interface IPendingMsg : IHotfixable
		{
			// Token: 0x06017DAE RID: 97710
			[Token(Token = "0x6017DAE")]
			void Handle();
		}

		// Token: 0x02003B63 RID: 15203
		[Token(Token = "0x2003B63")]
		private class PendingMsg<TMsg> : SiracusaPushMessageHandler.IPendingMsg, IHotfixable
		{
			// Token: 0x06017DAF RID: 97711 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017DAF")]
			public void Handle()
			{
			}

			// Token: 0x06017DB0 RID: 97712 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017DB0")]
			public PendingMsg()
			{
			}

			// Token: 0x0401CD14 RID: 118036
			[Token(Token = "0x401CD14")]
			[FieldOffset(Offset = "0x0")]
			public List<TMsg> msg;

			// Token: 0x0401CD15 RID: 118037
			[Token(Token = "0x401CD15")]
			[FieldOffset(Offset = "0x0")]
			public SiracusaPushMessageHandler.MsgHandler<TMsg> handler;

			// Token: 0x0401CD16 RID: 118038
			[Token(Token = "0x401CD16")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_Handle;

			// Token: 0x0401CD17 RID: 118039
			[Token(Token = "0x401CD17")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02003B64 RID: 15204
		// (Invoke) Token: 0x06017DB2 RID: 97714
		[Token(Token = "0x2003B64")]
		private delegate void MsgHandler<TMsg>(List<TMsg> msg);

		// Token: 0x02003B65 RID: 15205
		[Token(Token = "0x2003B65")]
		private class PushMsgTask : UINotificationTasks.MainUITask
		{
			// Token: 0x06017DB5 RID: 97717 RVA: 0x000986E8 File Offset: 0x000968E8
			[Token(Token = "0x6017DB5")]
			[Address(RVA = "0x1013860", Offset = "0x1012460", VA = "0x181013860", Slot = "4")]
			public override bool CanConsume()
			{
				return default(bool);
			}

			// Token: 0x06017DB6 RID: 97718 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017DB6")]
			[Address(RVA = "0x1013960", Offset = "0x1012560", VA = "0x181013960", Slot = "5")]
			public override void Consume()
			{
			}

			// Token: 0x06017DB7 RID: 97719 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6017DB7")]
			[Address(RVA = "0x1013AA0", Offset = "0x10126A0", VA = "0x181013AA0")]
			public PushMsgTask()
			{
			}

			// Token: 0x06017DB8 RID: 97720 RVA: 0x00098700 File Offset: 0x00096900
			[Token(Token = "0x6017DB8")]
			[Address(RVA = "0xDEB670", Offset = "0xDEA270", VA = "0x180DEB670")]
			private bool <>xLuaBaseProxy_CanConsume()
			{
				return default(bool);
			}

			// Token: 0x0401CD18 RID: 118040
			[Token(Token = "0x401CD18")]
			[FieldOffset(Offset = "0x18")]
			public List<SiracusaPushMessageHandler.IPendingMsg> pendingMsgs;

			// Token: 0x0401CD19 RID: 118041
			[Token(Token = "0x401CD19")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_CanConsume;

			// Token: 0x0401CD1A RID: 118042
			[Token(Token = "0x401CD1A")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_Consume;

			// Token: 0x0401CD1B RID: 118043
			[Token(Token = "0x401CD1B")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
