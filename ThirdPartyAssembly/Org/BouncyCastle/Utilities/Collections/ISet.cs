using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.Collections
{
	// Token: 0x02000153 RID: 339
	[Token(Token = "0x2000153")]
	public interface ISet : ICollection, IEnumerable
	{
		// Token: 0x060007ED RID: 2029
		[Token(Token = "0x60007ED")]
		void Add(object o);

		// Token: 0x060007EE RID: 2030
		[Token(Token = "0x60007EE")]
		void AddAll(IEnumerable e);

		// Token: 0x060007EF RID: 2031
		[Token(Token = "0x60007EF")]
		void Clear();

		// Token: 0x060007F0 RID: 2032
		[Token(Token = "0x60007F0")]
		bool Contains(object o);

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060007F1 RID: 2033
		[Token(Token = "0x170000D8")]
		bool IsEmpty { [Token(Token = "0x60007F1")] get; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060007F2 RID: 2034
		[Token(Token = "0x170000D9")]
		bool IsFixedSize { [Token(Token = "0x60007F2")] get; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060007F3 RID: 2035
		[Token(Token = "0x170000DA")]
		bool IsReadOnly { [Token(Token = "0x60007F3")] get; }

		// Token: 0x060007F4 RID: 2036
		[Token(Token = "0x60007F4")]
		void Remove(object o);

		// Token: 0x060007F5 RID: 2037
		[Token(Token = "0x60007F5")]
		void RemoveAll(IEnumerable e);
	}
}
