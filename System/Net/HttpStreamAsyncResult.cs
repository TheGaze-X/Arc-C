using System;
using System.Threading;
using Il2CppDummyDll;

namespace System.Net
{
	// Token: 0x0200031C RID: 796
	[Token(Token = "0x200031C")]
	internal class HttpStreamAsyncResult : IAsyncResult
	{
		// Token: 0x06001600 RID: 5632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001600")]
		[Address(RVA = "0x507C8A0", Offset = "0x507B4A0", VA = "0x18507C8A0")]
		public void Complete(Exception e)
		{
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001601")]
		[Address(RVA = "0x507C7D0", Offset = "0x507B3D0", VA = "0x18507C7D0")]
		public void Complete()
		{
		}

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001602 RID: 5634 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004AF")]
		public object AsyncState
		{
			[Token(Token = "0x6001602")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001603 RID: 5635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170004B0")]
		public WaitHandle AsyncWaitHandle
		{
			[Token(Token = "0x6001603")]
			[Address(RVA = "0x507C940", Offset = "0x507B540", VA = "0x18507C940", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001604 RID: 5636 RVA: 0x0000A1A0 File Offset: 0x000083A0
		[Token(Token = "0x170004B1")]
		public bool CompletedSynchronously
		{
			[Token(Token = "0x6001604")]
			[Address(RVA = "0x507CA50", Offset = "0x507B650", VA = "0x18507CA50", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001605 RID: 5637 RVA: 0x0000A1B8 File Offset: 0x000083B8
		[Token(Token = "0x170004B2")]
		public bool IsCompleted
		{
			[Token(Token = "0x6001605")]
			[Address(RVA = "0x507CA60", Offset = "0x507B660", VA = "0x18507CA60", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001606")]
		[Address(RVA = "0x507C8D0", Offset = "0x507B4D0", VA = "0x18507C8D0")]
		public HttpStreamAsyncResult()
		{
		}

		// Token: 0x04000C2A RID: 3114
		[Token(Token = "0x4000C2A")]
		[FieldOffset(Offset = "0x10")]
		private object locker;

		// Token: 0x04000C2B RID: 3115
		[Token(Token = "0x4000C2B")]
		[FieldOffset(Offset = "0x18")]
		private ManualResetEvent handle;

		// Token: 0x04000C2C RID: 3116
		[Token(Token = "0x4000C2C")]
		[FieldOffset(Offset = "0x20")]
		private bool completed;

		// Token: 0x04000C2D RID: 3117
		[Token(Token = "0x4000C2D")]
		[FieldOffset(Offset = "0x28")]
		internal byte[] Buffer;

		// Token: 0x04000C2E RID: 3118
		[Token(Token = "0x4000C2E")]
		[FieldOffset(Offset = "0x30")]
		internal int Offset;

		// Token: 0x04000C2F RID: 3119
		[Token(Token = "0x4000C2F")]
		[FieldOffset(Offset = "0x34")]
		internal int Count;

		// Token: 0x04000C30 RID: 3120
		[Token(Token = "0x4000C30")]
		[FieldOffset(Offset = "0x38")]
		internal AsyncCallback Callback;

		// Token: 0x04000C31 RID: 3121
		[Token(Token = "0x4000C31")]
		[FieldOffset(Offset = "0x40")]
		internal object State;

		// Token: 0x04000C32 RID: 3122
		[Token(Token = "0x4000C32")]
		[FieldOffset(Offset = "0x48")]
		internal int SynchRead;

		// Token: 0x04000C33 RID: 3123
		[Token(Token = "0x4000C33")]
		[FieldOffset(Offset = "0x50")]
		internal Exception Error;
	}
}
