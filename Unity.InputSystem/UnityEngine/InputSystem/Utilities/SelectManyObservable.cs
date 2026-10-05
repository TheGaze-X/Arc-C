using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x0200024D RID: 589
	[Token(Token = "0x200024D")]
	internal class SelectManyObservable<TSource, TResult> : IObservable<TResult>
	{
		// Token: 0x06001550 RID: 5456 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001550")]
		public SelectManyObservable(IObservable<TSource> source, Func<TSource, IEnumerable<TResult>> filter)
		{
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001551")]
		public IDisposable Subscribe(IObserver<TResult> observer)
		{
			return null;
		}

		// Token: 0x04000C41 RID: 3137
		[Token(Token = "0x4000C41")]
		[FieldOffset(Offset = "0x0")]
		private readonly IObservable<TSource> m_Source;

		// Token: 0x04000C42 RID: 3138
		[Token(Token = "0x4000C42")]
		[FieldOffset(Offset = "0x0")]
		private readonly Func<TSource, IEnumerable<TResult>> m_Filter;

		// Token: 0x0200024E RID: 590
		[Token(Token = "0x200024E")]
		private class Select : IObserver<TSource>
		{
			// Token: 0x06001552 RID: 5458 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001552")]
			public Select(SelectManyObservable<TSource, TResult> observable, IObserver<TResult> observer)
			{
			}

			// Token: 0x06001553 RID: 5459 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001553")]
			public void OnCompleted()
			{
			}

			// Token: 0x06001554 RID: 5460 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001554")]
			public void OnError(Exception error)
			{
			}

			// Token: 0x06001555 RID: 5461 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001555")]
			public void OnNext(TSource evt)
			{
			}

			// Token: 0x04000C43 RID: 3139
			[Token(Token = "0x4000C43")]
			[FieldOffset(Offset = "0x0")]
			private SelectManyObservable<TSource, TResult> m_Observable;

			// Token: 0x04000C44 RID: 3140
			[Token(Token = "0x4000C44")]
			[FieldOffset(Offset = "0x0")]
			private readonly IObserver<TResult> m_Observer;
		}
	}
}
