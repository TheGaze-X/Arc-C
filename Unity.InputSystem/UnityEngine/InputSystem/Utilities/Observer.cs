using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;

namespace UnityEngine.InputSystem.Utilities
{
	// Token: 0x0200024C RID: 588
	[Token(Token = "0x200024C")]
	internal class Observer<TValue> : IObserver<TValue>
	{
		// Token: 0x0600154C RID: 5452 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600154C")]
		public Observer(Action<TValue> onNext, [Optional] Action onCompleted)
		{
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600154D")]
		public void OnCompleted()
		{
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600154E")]
		public void OnError(Exception error)
		{
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600154F")]
		public void OnNext(TValue evt)
		{
		}

		// Token: 0x04000C3F RID: 3135
		[Token(Token = "0x4000C3F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action<TValue> m_OnNext;

		// Token: 0x04000C40 RID: 3136
		[Token(Token = "0x4000C40")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private Action m_OnCompleted;
	}
}
