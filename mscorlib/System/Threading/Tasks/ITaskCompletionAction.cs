using System;
using Il2CppDummyDll;

namespace System.Threading.Tasks
{
	// Token: 0x02000267 RID: 615
	[Token(Token = "0x2000267")]
	internal interface ITaskCompletionAction
	{
		// Token: 0x060014B2 RID: 5298
		[Token(Token = "0x60014B2")]
		void Invoke(Task completingTask);

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060014B3 RID: 5299
		[Token(Token = "0x17000206")]
		bool InvokeMayRunArbitraryCode { [Token(Token = "0x60014B3")] get; }
	}
}
