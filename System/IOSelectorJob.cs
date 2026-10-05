using System;
using System.Runtime.InteropServices;
using System.Threading;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	[StructLayout(0)]
	internal class IOSelectorJob : IThreadPoolWorkItem
	{
		// Token: 0x06000457 RID: 1111 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000457")]
		[Address(RVA = "0x43CCED0", Offset = "0x43CBAD0", VA = "0x1843CCED0")]
		public IOSelectorJob(IOOperation operation, IOAsyncCallback callback, IOAsyncResult state)
		{
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000458")]
		[Address(RVA = "0x50EAC50", Offset = "0x50E9850", VA = "0x1850EAC50", Slot = "4")]
		private void ExecuteWorkItem()
		{
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000459")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		private void MarkAborted(ThreadAbortException tae)
		{
		}

		// Token: 0x0600045A RID: 1114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600045A")]
		[Address(RVA = "0x50EAC10", Offset = "0x50E9810", VA = "0x1850EAC10")]
		public void MarkDisposed()
		{
		}

		// Token: 0x0400032E RID: 814
		[Token(Token = "0x400032E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private IOOperation operation;

		// Token: 0x0400032F RID: 815
		[Token(Token = "0x400032F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private IOAsyncCallback callback;

		// Token: 0x04000330 RID: 816
		[Token(Token = "0x4000330")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private IOAsyncResult state;
	}
}
