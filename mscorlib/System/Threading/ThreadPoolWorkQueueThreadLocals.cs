using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x02000230 RID: 560
	[Token(Token = "0x2000230")]
	internal sealed class ThreadPoolWorkQueueThreadLocals
	{
		// Token: 0x0600131A RID: 4890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131A")]
		[Address(RVA = "0x4AEE100", Offset = "0x4AECD00", VA = "0x184AEE100")]
		public ThreadPoolWorkQueueThreadLocals(ThreadPoolWorkQueue tpq)
		{
		}

		// Token: 0x0600131B RID: 4891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131B")]
		[Address(RVA = "0x4AEDF40", Offset = "0x4AECB40", VA = "0x184AEDF40")]
		private void CleanUp()
		{
		}

		// Token: 0x0600131C RID: 4892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600131C")]
		[Address(RVA = "0x4AEE070", Offset = "0x4AECC70", VA = "0x184AEE070", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x04000AB1 RID: 2737
		[Token(Token = "0x4000AB1")]
		[System.ThreadStatic]
		public static ThreadPoolWorkQueueThreadLocals threadLocals;

		// Token: 0x04000AB2 RID: 2738
		[Token(Token = "0x4000AB2")]
		[FieldOffset(Offset = "0x10")]
		public readonly ThreadPoolWorkQueue workQueue;

		// Token: 0x04000AB3 RID: 2739
		[Token(Token = "0x4000AB3")]
		[FieldOffset(Offset = "0x18")]
		public readonly ThreadPoolWorkQueue.WorkStealingQueue workStealingQueue;

		// Token: 0x04000AB4 RID: 2740
		[Token(Token = "0x4000AB4")]
		[FieldOffset(Offset = "0x20")]
		public readonly System.Random random;
	}
}
