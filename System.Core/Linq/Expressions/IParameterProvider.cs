using System;
using Il2CppDummyDll;

namespace System.Linq.Expressions
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	internal interface IParameterProvider
	{
		// Token: 0x060002AE RID: 686
		[Token(Token = "0x60002AE")]
		ParameterExpression GetParameter(int index);

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060002AF RID: 687
		[Token(Token = "0x17000055")]
		int ParameterCount { [Token(Token = "0x60002AF")] get; }
	}
}
