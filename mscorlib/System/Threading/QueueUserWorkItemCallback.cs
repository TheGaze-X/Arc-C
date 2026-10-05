using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x02000232 RID: 562
	[Token(Token = "0x2000232")]
	internal sealed class QueueUserWorkItemCallback : IThreadPoolWorkItem
	{
		// Token: 0x0600131E RID: 4894 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131E")]
		[Address(RVA = "0x4ADFA50", Offset = "0x4ADE650", VA = "0x184ADFA50")]
		internal QueueUserWorkItemCallback(WaitCallback waitCallback, object stateObj, bool compressStack, ref StackCrawlMark stackMark)
		{
		}

		// Token: 0x0600131F RID: 4895 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131F")]
		[Address(RVA = "0x4ADF850", Offset = "0x4ADE450", VA = "0x184ADF850", Slot = "4")]
		private void ExecuteWorkItem()
		{
		}

		// Token: 0x06001320 RID: 4896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001320")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "5")]
		private void MarkAborted(ThreadAbortException tae)
		{
		}

		// Token: 0x06001321 RID: 4897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001321")]
		[Address(RVA = "0x4ADF940", Offset = "0x4ADE540", VA = "0x184ADF940")]
		private static void WaitCallback_Context(object state)
		{
		}

		// Token: 0x04000AB5 RID: 2741
		[Token(Token = "0x4000AB5")]
		[FieldOffset(Offset = "0x10")]
		private WaitCallback callback;

		// Token: 0x04000AB6 RID: 2742
		[Token(Token = "0x4000AB6")]
		[FieldOffset(Offset = "0x18")]
		private ExecutionContext context;

		// Token: 0x04000AB7 RID: 2743
		[Token(Token = "0x4000AB7")]
		[FieldOffset(Offset = "0x20")]
		private object state;

		// Token: 0x04000AB8 RID: 2744
		[Token(Token = "0x4000AB8")]
		[FieldOffset(Offset = "0x0")]
		internal static ContextCallback ccb;
	}
}
