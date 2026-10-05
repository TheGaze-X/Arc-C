using System;
using Il2CppDummyDll;

namespace System.Collections
{
	// Token: 0x020005C0 RID: 1472
	[Token(Token = "0x20005C0")]
	public interface IList : ICollection, IEnumerable
	{
		// Token: 0x170006C1 RID: 1729
		[Token(Token = "0x170006C1")]
		object this[int index]
		{
			[Token(Token = "0x6002BA8")]
			get;
			[Token(Token = "0x6002BA9")]
			set;
		}

		// Token: 0x06002BAA RID: 11178
		[Token(Token = "0x6002BAA")]
		int Add(object value);

		// Token: 0x06002BAB RID: 11179
		[Token(Token = "0x6002BAB")]
		bool Contains(object value);

		// Token: 0x06002BAC RID: 11180
		[Token(Token = "0x6002BAC")]
		void Clear();

		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x06002BAD RID: 11181
		[Token(Token = "0x170006C2")]
		bool IsReadOnly { [Token(Token = "0x6002BAD")] get; }

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x06002BAE RID: 11182
		[Token(Token = "0x170006C3")]
		bool IsFixedSize { [Token(Token = "0x6002BAE")] get; }

		// Token: 0x06002BAF RID: 11183
		[Token(Token = "0x6002BAF")]
		int IndexOf(object value);

		// Token: 0x06002BB0 RID: 11184
		[Token(Token = "0x6002BB0")]
		void Insert(int index, object value);

		// Token: 0x06002BB1 RID: 11185
		[Token(Token = "0x6002BB1")]
		void Remove(object value);

		// Token: 0x06002BB2 RID: 11186
		[Token(Token = "0x6002BB2")]
		void RemoveAt(int index);
	}
}
