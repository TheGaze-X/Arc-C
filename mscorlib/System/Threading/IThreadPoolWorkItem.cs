using System;
using Il2CppDummyDll;

namespace System.Threading
{
	// Token: 0x02000228 RID: 552
	[Token(Token = "0x2000228")]
	internal interface IThreadPoolWorkItem
	{
		// Token: 0x060012FA RID: 4858
		[Token(Token = "0x60012FA")]
		void ExecuteWorkItem();

		// Token: 0x060012FB RID: 4859
		[Token(Token = "0x60012FB")]
		void MarkAborted(ThreadAbortException tae);
	}
}
