using System;
using Il2CppDummyDll;

namespace System.Collections
{
	// Token: 0x020005BC RID: 1468
	[Token(Token = "0x20005BC")]
	public interface IDictionaryEnumerator : IEnumerator
	{
		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x06002B9F RID: 11167
		[Token(Token = "0x170006BD")]
		object Key { [Token(Token = "0x6002B9F")] get; }

		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x06002BA0 RID: 11168
		[Token(Token = "0x170006BE")]
		object Value { [Token(Token = "0x6002BA0")] get; }

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06002BA1 RID: 11169
		[Token(Token = "0x170006BF")]
		DictionaryEntry Entry { [Token(Token = "0x6002BA1")] get; }
	}
}
