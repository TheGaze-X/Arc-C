using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000F9 RID: 249
	[Token(Token = "0x20000F9")]
	public interface IObserver<in T>
	{
		// Token: 0x0600080E RID: 2062
		[Token(Token = "0x600080E")]
		void OnNext(T value);

		// Token: 0x0600080F RID: 2063
		[Token(Token = "0x600080F")]
		void OnError(System.Exception error);

		// Token: 0x06000810 RID: 2064
		[Token(Token = "0x6000810")]
		void OnCompleted();
	}
}
