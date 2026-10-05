using System;
using Il2CppDummyDll;

namespace System.Collections
{
	// Token: 0x020005BB RID: 1467
	[Token(Token = "0x20005BB")]
	public interface IDictionary : ICollection, IEnumerable
	{
		// Token: 0x170006B8 RID: 1720
		[Token(Token = "0x170006B8")]
		object this[object key]
		{
			[Token(Token = "0x6002B94")]
			get;
			[Token(Token = "0x6002B95")]
			set;
		}

		// Token: 0x170006B9 RID: 1721
		// (get) Token: 0x06002B96 RID: 11158
		[Token(Token = "0x170006B9")]
		ICollection Keys { [Token(Token = "0x6002B96")] get; }

		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06002B97 RID: 11159
		[Token(Token = "0x170006BA")]
		ICollection Values { [Token(Token = "0x6002B97")] get; }

		// Token: 0x06002B98 RID: 11160
		[Token(Token = "0x6002B98")]
		bool Contains(object key);

		// Token: 0x06002B99 RID: 11161
		[Token(Token = "0x6002B99")]
		void Add(object key, object value);

		// Token: 0x06002B9A RID: 11162
		[Token(Token = "0x6002B9A")]
		void Clear();

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x06002B9B RID: 11163
		[Token(Token = "0x170006BB")]
		bool IsReadOnly { [Token(Token = "0x6002B9B")] get; }

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x06002B9C RID: 11164
		[Token(Token = "0x170006BC")]
		bool IsFixedSize { [Token(Token = "0x6002B9C")] get; }

		// Token: 0x06002B9D RID: 11165
		[Token(Token = "0x6002B9D")]
		IDictionaryEnumerator GetEnumerator();

		// Token: 0x06002B9E RID: 11166
		[Token(Token = "0x6002B9E")]
		void Remove(object key);
	}
}
