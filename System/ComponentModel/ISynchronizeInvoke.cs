using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x02000165 RID: 357
	[Token(Token = "0x2000165")]
	public interface ISynchronizeInvoke
	{
		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000913 RID: 2323
		[Token(Token = "0x170001C7")]
		bool InvokeRequired { [Token(Token = "0x6000913")] get; }

		// Token: 0x06000914 RID: 2324
		[Token(Token = "0x6000914")]
		IAsyncResult BeginInvoke(Delegate method, object[] args);

		// Token: 0x06000915 RID: 2325
		[Token(Token = "0x6000915")]
		object EndInvoke(IAsyncResult result);

		// Token: 0x06000916 RID: 2326
		[Token(Token = "0x6000916")]
		object Invoke(Delegate method, object[] args);
	}
}
