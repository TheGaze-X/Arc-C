using System;
using Il2CppDummyDll;

namespace System.ComponentModel
{
	// Token: 0x020001F1 RID: 497
	[Token(Token = "0x20001F1")]
	public interface IEditableObject
	{
		// Token: 0x06000D32 RID: 3378
		[Token(Token = "0x6000D32")]
		void BeginEdit();

		// Token: 0x06000D33 RID: 3379
		[Token(Token = "0x6000D33")]
		void EndEdit();

		// Token: 0x06000D34 RID: 3380
		[Token(Token = "0x6000D34")]
		void CancelEdit();
	}
}
