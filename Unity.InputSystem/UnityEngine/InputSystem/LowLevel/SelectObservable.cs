using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.LowLevel
{
	// Token: 0x020001DD RID: 477
	[Token(Token = "0x20001DD")]
	internal class SelectObservable<TSource, TResult> : IObservable<TResult>
	{
		// Token: 0x060011BA RID: 4538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60011BA")]
		public SelectObservable(IObservable<TSource> source, Func<TSource, TResult> filter)
		{
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60011BB")]
		public IDisposable Subscribe(IObserver<TResult> observer)
		{
			return null;
		}

		// Token: 0x04000A8A RID: 2698
		[Token(Token = "0x4000A8A")]
		[FieldOffset(Offset = "0x0")]
		private readonly IObservable<TSource> m_Source;

		// Token: 0x04000A8B RID: 2699
		[Token(Token = "0x4000A8B")]
		[FieldOffset(Offset = "0x0")]
		private readonly Func<TSource, TResult> m_Filter;

		// Token: 0x020001DE RID: 478
		[Token(Token = "0x20001DE")]
		private class Select : IObserver<TSource>
		{
			// Token: 0x060011BC RID: 4540 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60011BC")]
			public Select(SelectObservable<TSource, TResult> observable, IObserver<TResult> observer)
			{
			}

			// Token: 0x060011BD RID: 4541 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60011BD")]
			public void OnCompleted()
			{
			}

			// Token: 0x060011BE RID: 4542 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60011BE")]
			public void OnError(Exception error)
			{
			}

			// Token: 0x060011BF RID: 4543 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60011BF")]
			public void OnNext(TSource evt)
			{
			}

			// Token: 0x04000A8C RID: 2700
			[Token(Token = "0x4000A8C")]
			[FieldOffset(Offset = "0x0")]
			private SelectObservable<TSource, TResult> m_Observable;

			// Token: 0x04000A8D RID: 2701
			[Token(Token = "0x4000A8D")]
			[FieldOffset(Offset = "0x0")]
			private readonly IObserver<TResult> m_Observer;
		}
	}
}
