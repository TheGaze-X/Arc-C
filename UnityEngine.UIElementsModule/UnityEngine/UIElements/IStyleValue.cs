using System;
using Il2CppDummyDll;

namespace UnityEngine.UIElements
{
	// Token: 0x02000238 RID: 568
	[Token(Token = "0x2000238")]
	internal interface IStyleValue<T>
	{
		// Token: 0x170003DE RID: 990
		// (get) Token: 0x0600100B RID: 4107
		[Token(Token = "0x170003DE")]
		T value { [Token(Token = "0x600100B")] get; }

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x0600100C RID: 4108
		[Token(Token = "0x170003DF")]
		StyleKeyword keyword { [Token(Token = "0x600100C")] get; }
	}
}
