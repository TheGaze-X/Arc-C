using System;
using System.Collections;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001AB RID: 427
	[Token(Token = "0x20001AB")]
	[MergableProperty(false)]
	public interface IListSource
	{
		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000B0C RID: 2828
		[Token(Token = "0x17000237")]
		bool ContainsListCollection { [Token(Token = "0x6000B0C")] get; }

		// Token: 0x06000B0D RID: 2829
		[Token(Token = "0x6000B0D")]
		IList GetList();
	}
}
