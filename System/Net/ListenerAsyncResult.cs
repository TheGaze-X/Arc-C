using System;
using System.Threading;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x02000327 RID: 807
	[Token(Token = "0x2000327")]
	internal class ListenerAsyncResult : IAsyncResult
	{
		// Token: 0x06001683 RID: 5763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001683")]
		[Address(RVA = "0x5085650", Offset = "0x5084250", VA = "0x185085650")]
		public ListenerAsyncResult(AsyncCallback cb, object state)
		{
		}

		// Token: 0x06001684 RID: 5764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001684")]
		[Address(RVA = "0x5085270", Offset = "0x5083E70", VA = "0x185085270")]
		internal void Complete(Exception exc)
		{
		}

		// Token: 0x06001685 RID: 5765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001685")]
		[Address(RVA = "0x50854C0", Offset = "0x50840C0", VA = "0x1850854C0")]
		private static void InvokeCallback(object o)
		{
		}

		// Token: 0x06001686 RID: 5766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001686")]
		[Address(RVA = "0x5084D80", Offset = "0x5083980", VA = "0x185084D80")]
		internal void Complete(HttpListenerContext context)
		{
		}

		// Token: 0x06001687 RID: 5767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001687")]
		[Address(RVA = "0x5084D90", Offset = "0x5083990", VA = "0x185084D90")]
		internal void Complete(HttpListenerContext context, bool synch)
		{
		}

		// Token: 0x06001688 RID: 5768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001688")]
		[Address(RVA = "0x5085470", Offset = "0x5084070", VA = "0x185085470")]
		internal HttpListenerContext GetContext()
		{
			return null;
		}

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001689 RID: 5769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004E2")]
		public object AsyncState
		{
			[Token(Token = "0x6001689")]
			[Address(RVA = "0x5085700", Offset = "0x5084300", VA = "0x185085700", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x0600168A RID: 5770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004E3")]
		public WaitHandle AsyncWaitHandle
		{
			[Token(Token = "0x600168A")]
			[Address(RVA = "0x5085720", Offset = "0x5084320", VA = "0x185085720", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x0600168B RID: 5771 RVA: 0x0000A470 File Offset: 0x00008670
		[Token(Token = "0x170004E4")]
		public bool CompletedSynchronously
		{
			[Token(Token = "0x600168B")]
			[Address(RVA = "0x5085850", Offset = "0x5084450", VA = "0x185085850", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x0600168C RID: 5772 RVA: 0x0000A488 File Offset: 0x00008688
		[Token(Token = "0x170004E5")]
		public bool IsCompleted
		{
			[Token(Token = "0x600168C")]
			[Address(RVA = "0x5085870", Offset = "0x5084470", VA = "0x185085870", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x04000CAC RID: 3244
		[Token(Token = "0x4000CAC")]
		[FieldOffset(Offset = "0x10")]
		private ManualResetEvent handle;

		// Token: 0x04000CAD RID: 3245
		[Token(Token = "0x4000CAD")]
		[FieldOffset(Offset = "0x18")]
		private bool synch;

		// Token: 0x04000CAE RID: 3246
		[Token(Token = "0x4000CAE")]
		[FieldOffset(Offset = "0x19")]
		private bool completed;

		// Token: 0x04000CAF RID: 3247
		[Token(Token = "0x4000CAF")]
		[FieldOffset(Offset = "0x20")]
		private AsyncCallback cb;

		// Token: 0x04000CB0 RID: 3248
		[Token(Token = "0x4000CB0")]
		[FieldOffset(Offset = "0x28")]
		private object state;

		// Token: 0x04000CB1 RID: 3249
		[Token(Token = "0x4000CB1")]
		[FieldOffset(Offset = "0x30")]
		private Exception exception;

		// Token: 0x04000CB2 RID: 3250
		[Token(Token = "0x4000CB2")]
		[FieldOffset(Offset = "0x38")]
		private HttpListenerContext context;

		// Token: 0x04000CB3 RID: 3251
		[Token(Token = "0x4000CB3")]
		[FieldOffset(Offset = "0x40")]
		private object locker;

		// Token: 0x04000CB4 RID: 3252
		[Token(Token = "0x4000CB4")]
		[FieldOffset(Offset = "0x48")]
		private ListenerAsyncResult forward;

		// Token: 0x04000CB5 RID: 3253
		[Token(Token = "0x4000CB5")]
		[FieldOffset(Offset = "0x50")]
		internal bool EndCalled;

		// Token: 0x04000CB6 RID: 3254
		[Token(Token = "0x4000CB6")]
		[FieldOffset(Offset = "0x51")]
		internal bool InGet;

		// Token: 0x04000CB7 RID: 3255
		[Token(Token = "0x4000CB7")]
		[FieldOffset(Offset = "0x0")]
		private static WaitCallback InvokeCB;
	}
}
