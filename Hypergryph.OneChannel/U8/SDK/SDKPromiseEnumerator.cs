using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace U8.SDK
{
	// Token: 0x0200007D RID: 125
	[Token(Token = "0x200007D")]
	public class SDKPromiseEnumerator<T>
	{
		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600026B RID: 619 RVA: 0x00002864 File Offset: 0x00000A64
		[Token(Token = "0x17000040")]
		public bool isFulfilled
		{
			[Token(Token = "0x600026B")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600026C RID: 620 RVA: 0x000020C6 File Offset: 0x000002C6
		// (set) Token: 0x0600026D RID: 621 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000041")]
		public T result
		{
			[Token(Token = "0x600026C")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600026D")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600026E RID: 622 RVA: 0x000020C6 File Offset: 0x000002C6
		// (set) Token: 0x0600026F RID: 623 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x17000042")]
		public object reject
		{
			[Token(Token = "0x600026E")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600026F")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x000020C6 File Offset: 0x000002C6
		[Token(Token = "0x6000270")]
		public IEnumerator Yield()
		{
			return null;
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000271")]
		public SDKPromiseEnumerator(SDKPromise<T> promise)
		{
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000272")]
		private void _OnFulfilled(T result)
		{
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00002096 File Offset: 0x00000296
		[Token(Token = "0x6000273")]
		private void _OnRejected(object rejectInfo)
		{
		}

		// Token: 0x0400022A RID: 554
		[Token(Token = "0x400022A")]
		[FieldOffset(Offset = "0x0")]
		private SDKPromiseEnumerator<T>.State m_state;

		// Token: 0x0200007E RID: 126
		[Token(Token = "0x200007E")]
		private enum State
		{
			// Token: 0x0400022E RID: 558
			[Token(Token = "0x400022E")]
			NONE,
			// Token: 0x0400022F RID: 559
			[Token(Token = "0x400022F")]
			FULFILL,
			// Token: 0x04000230 RID: 560
			[Token(Token = "0x4000230")]
			REJECT
		}
	}
}
