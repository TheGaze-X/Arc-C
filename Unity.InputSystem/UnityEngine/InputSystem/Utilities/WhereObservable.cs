using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x02000251 RID: 593
	[Token(Token = "0x2000251")]
	internal class WhereObservable<TValue> : IObservable<TValue>
	{
		// Token: 0x0600155C RID: 5468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600155C")]
		public WhereObservable(IObservable<TValue> source, Func<TValue, bool> predicate)
		{
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600155D")]
		public IDisposable Subscribe(IObserver<TValue> observer)
		{
			return null;
		}

		// Token: 0x04000C49 RID: 3145
		[Token(Token = "0x4000C49")]
		[FieldOffset(Offset = "0x0")]
		private readonly IObservable<TValue> m_Source;

		// Token: 0x04000C4A RID: 3146
		[Token(Token = "0x4000C4A")]
		[FieldOffset(Offset = "0x0")]
		private readonly Func<TValue, bool> m_Predicate;

		// Token: 0x02000252 RID: 594
		[Token(Token = "0x2000252")]
		private class Where : IObserver<TValue>
		{
			// Token: 0x0600155E RID: 5470 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600155E")]
			public Where(WhereObservable<TValue> observable, IObserver<TValue> observer)
			{
			}

			// Token: 0x0600155F RID: 5471 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600155F")]
			public void OnCompleted()
			{
			}

			// Token: 0x06001560 RID: 5472 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001560")]
			public void OnError(Exception error)
			{
			}

			// Token: 0x06001561 RID: 5473 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001561")]
			public void OnNext(TValue evt)
			{
			}

			// Token: 0x04000C4B RID: 3147
			[Token(Token = "0x4000C4B")]
			[FieldOffset(Offset = "0x0")]
			private WhereObservable<TValue> m_Observable;

			// Token: 0x04000C4C RID: 3148
			[Token(Token = "0x4000C4C")]
			[FieldOffset(Offset = "0x0")]
			private readonly IObserver<TValue> m_Observer;
		}
	}
}
