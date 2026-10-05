using System;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000052 RID: 82
	[Token(Token = "0x2000052")]
	public interface IArgumentProvider
	{
		// Token: 0x060002AC RID: 684
		[Token(Token = "0x60002AC")]
		Expression GetArgument(int index);

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060002AD RID: 685
		[Token(Token = "0x17000054")]
		int ArgumentCount { [Token(Token = "0x60002AD")] get; }
	}
}
