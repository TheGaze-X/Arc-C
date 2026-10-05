using System;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000D1 RID: 209
	[Token(Token = "0x20000D1")]
	[StructLayout(0)]
	internal abstract class IOAsyncResult : IAsyncResult
	{
		// Token: 0x0600044C RID: 1100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600044C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected IOAsyncResult()
		{
		}

		// Token: 0x0600044D RID: 1101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600044D")]
		[Address(RVA = "0x50EAA20", Offset = "0x50E9620", VA = "0x1850EAA20")]
		protected void Init(AsyncCallback async_callback, object async_state)
		{
		}

		// Token: 0x0600044E RID: 1102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600044E")]
		[Address(RVA = "0x4ECFE0", Offset = "0x4EBBE0", VA = "0x1804ECFE0")]
		protected IOAsyncResult(AsyncCallback async_callback, object async_state)
		{
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BC")]
		public AsyncCallback AsyncCallback
		{
			[Token(Token = "0x600044F")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000450 RID: 1104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BD")]
		public object AsyncState
		{
			[Token(Token = "0x6000450")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000451 RID: 1105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000BE")]
		public WaitHandle AsyncWaitHandle
		{
			[Token(Token = "0x6000451")]
			[Address(RVA = "0x50EAA70", Offset = "0x50E9670", VA = "0x1850EAA70", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000452 RID: 1106 RVA: 0x00003948 File Offset: 0x00001B48
		// (set) Token: 0x06000453 RID: 1107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000BF")]
		public bool CompletedSynchronously
		{
			[Token(Token = "0x6000452")]
			[Address(RVA = "0x73B8F0", Offset = "0x73A4F0", VA = "0x18073B8F0", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000453")]
			[Address(RVA = "0x73B920", Offset = "0x73A520", VA = "0x18073B920")]
			protected set
			{
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000454 RID: 1108 RVA: 0x00003960 File Offset: 0x00001B60
		// (set) Token: 0x06000455 RID: 1109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170000C0")]
		public bool IsCompleted
		{
			[Token(Token = "0x6000454")]
			[Address(RVA = "0x1636A10", Offset = "0x1635610", VA = "0x181636A10", Slot = "4")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000455")]
			[Address(RVA = "0x50EAB70", Offset = "0x50E9770", VA = "0x1850EAB70")]
			protected set
			{
			}
		}

		// Token: 0x06000456 RID: 1110
		[Token(Token = "0x6000456")]
		internal abstract void CompleteDisposed();

		// Token: 0x04000329 RID: 809
		[Token(Token = "0x4000329")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private AsyncCallback async_callback;

		// Token: 0x0400032A RID: 810
		[Token(Token = "0x400032A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private object async_state;

		// Token: 0x0400032B RID: 811
		[Token(Token = "0x400032B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private ManualResetEvent wait_handle;

		// Token: 0x0400032C RID: 812
		[Token(Token = "0x400032C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private bool completed_synchronously;

		// Token: 0x0400032D RID: 813
		[Token(Token = "0x400032D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x29")]
		private bool completed;
	}
}
