using System;
using Il2CppDummyDll;

namespace System.Runtime.CompilerServices
{
	// Token: 0x02000498 RID: 1176
	[Token(Token = "0x2000498")]
	public interface IAsyncStateMachine
	{
		// Token: 0x060022D6 RID: 8918
		[Token(Token = "0x60022D6")]
		void MoveNext();

		// Token: 0x060022D7 RID: 8919
		[Token(Token = "0x60022D7")]
		void SetStateMachine(IAsyncStateMachine stateMachine);
	}
}
