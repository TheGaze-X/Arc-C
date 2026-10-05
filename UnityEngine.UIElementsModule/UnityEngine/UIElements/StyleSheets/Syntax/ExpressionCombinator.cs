using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements.StyleSheets.Syntax
{
	// Token: 0x02000301 RID: 769
	[Token(Token = "0x2000301")]
	internal enum ExpressionCombinator
	{
		// Token: 0x04000C8D RID: 3213
		[Token(Token = "0x4000C8D")]
		None,
		// Token: 0x04000C8E RID: 3214
		[Token(Token = "0x4000C8E")]
		Or,
		// Token: 0x04000C8F RID: 3215
		[Token(Token = "0x4000C8F")]
		OrOr,
		// Token: 0x04000C90 RID: 3216
		[Token(Token = "0x4000C90")]
		AndAnd,
		// Token: 0x04000C91 RID: 3217
		[Token(Token = "0x4000C91")]
		Juxtaposition,
		// Token: 0x04000C92 RID: 3218
		[Token(Token = "0x4000C92")]
		Group
	}
}
