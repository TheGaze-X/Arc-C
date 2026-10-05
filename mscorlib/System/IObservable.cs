using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000F8 RID: 248
	[Token(Token = "0x20000F8")]
	public interface IObservable<out T>
	{
		// Token: 0x0600080D RID: 2061
		[Token(Token = "0x600080D")]
		System.IDisposable Subscribe(System.IObserver<T> observer);
	}
}
