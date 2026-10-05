using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200012A RID: 298
	[Token(Token = "0x200012A")]
	public class YieldSemaphore<Param>
	{
		// Token: 0x06000720 RID: 1824 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000720")]
		public IEnumerator Wait(YieldSemaphore<Param>.Options options)
		{
			return null;
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000721")]
		public void Release(Param param)
		{
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000722")]
		public void Reset()
		{
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x000020FA File Offset: 0x000002FA
		[Token(Token = "0x6000723")]
		public YieldSemaphore()
		{
		}

		// Token: 0x04000626 RID: 1574
		[Token(Token = "0x4000626")]
		private const int DEFAULT_TIMEOUT_FRAME_CNT = 120;

		// Token: 0x04000627 RID: 1575
		[Token(Token = "0x4000627")]
		[FieldOffset(Offset = "0x0")]
		private List<YieldSemaphore<Param>.WaitTask> m_waitingTasks;

		// Token: 0x0200012B RID: 299
		[Token(Token = "0x200012B")]
		public struct Options
		{
			// Token: 0x04000628 RID: 1576
			[Token(Token = "0x4000628")]
			[FieldOffset(Offset = "0x0")]
			public Func<Param, bool> condition;

			// Token: 0x04000629 RID: 1577
			[Token(Token = "0x4000629")]
			[FieldOffset(Offset = "0x0")]
			public Action onRelease;

			// Token: 0x0400062A RID: 1578
			[Token(Token = "0x400062A")]
			[FieldOffset(Offset = "0x0")]
			public int overrideTimeoutFrameCount;

			// Token: 0x0400062B RID: 1579
			[Token(Token = "0x400062B")]
			[FieldOffset(Offset = "0x0")]
			public Action onTimeout;
		}

		// Token: 0x0200012C RID: 300
		[Token(Token = "0x200012C")]
		private class WaitTask
		{
			// Token: 0x17000096 RID: 150
			// (get) Token: 0x06000724 RID: 1828 RVA: 0x0000677C File Offset: 0x0000497C
			// (set) Token: 0x06000725 RID: 1829 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x17000096")]
			public bool isDisposed
			{
				[Token(Token = "0x6000724")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6000725")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x06000726 RID: 1830 RVA: 0x00006794 File Offset: 0x00004994
			[Token(Token = "0x17000097")]
			public bool keepWaiting
			{
				[Token(Token = "0x6000726")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06000727 RID: 1831 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000727")]
			public void Dispose()
			{
			}

			// Token: 0x06000728 RID: 1832 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000728")]
			public void StopWait()
			{
			}

			// Token: 0x06000729 RID: 1833 RVA: 0x000020FA File Offset: 0x000002FA
			[Token(Token = "0x6000729")]
			public WaitTask()
			{
			}

			// Token: 0x0400062C RID: 1580
			[Token(Token = "0x400062C")]
			[FieldOffset(Offset = "0x0")]
			private bool m_keepWaiting;

			// Token: 0x0400062D RID: 1581
			[Token(Token = "0x400062D")]
			[FieldOffset(Offset = "0x0")]
			public int timeoutFrameCnt;

			// Token: 0x0400062E RID: 1582
			[Token(Token = "0x400062E")]
			[FieldOffset(Offset = "0x0")]
			public Func<Param, bool> condition;
		}
	}
}
