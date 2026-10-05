using System;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x0200024F RID: 591
	[Token(Token = "0x200024F")]
	internal class TakeNObservable<TValue> : IObservable<TValue>
	{
		// Token: 0x06001556 RID: 5462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001556")]
		public TakeNObservable(IObservable<TValue> source, int count)
		{
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001557")]
		public IDisposable Subscribe(IObserver<TValue> observer)
		{
			return null;
		}

		// Token: 0x04000C45 RID: 3141
		[Token(Token = "0x4000C45")]
		[FieldOffset(Offset = "0x0")]
		private IObservable<TValue> m_Source;

		// Token: 0x04000C46 RID: 3142
		[Token(Token = "0x4000C46")]
		[FieldOffset(Offset = "0x0")]
		private int m_Count;

		// Token: 0x02000250 RID: 592
		[Token(Token = "0x2000250")]
		private class Take : IObserver<TValue>
		{
			// Token: 0x06001558 RID: 5464 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001558")]
			public Take(TakeNObservable<TValue> observable, IObserver<TValue> observer)
			{
			}

			// Token: 0x06001559 RID: 5465 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001559")]
			public void OnCompleted()
			{
			}

			// Token: 0x0600155A RID: 5466 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600155A")]
			public void OnError(Exception error)
			{
			}

			// Token: 0x0600155B RID: 5467 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600155B")]
			public void OnNext(TValue evt)
			{
			}

			// Token: 0x04000C47 RID: 3143
			[Token(Token = "0x4000C47")]
			[FieldOffset(Offset = "0x0")]
			private IObserver<TValue> m_Observer;

			// Token: 0x04000C48 RID: 3144
			[Token(Token = "0x4000C48")]
			[FieldOffset(Offset = "0x0")]
			private int m_Remaining;
		}
	}
}
