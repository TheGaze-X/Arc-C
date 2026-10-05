using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x020005FE RID: 1534
	[Token(Token = "0x20005FE")]
	public interface ICollection<T> : IEnumerable<T>, IEnumerable
	{
		// Token: 0x1700078C RID: 1932
		// (get) Token: 0x06002E72 RID: 11890
		[Token(Token = "0x1700078C")]
		int Count { [Token(Token = "0x6002E72")] get; }

		// Token: 0x1700078D RID: 1933
		// (get) Token: 0x06002E73 RID: 11891
		[Token(Token = "0x1700078D")]
		bool IsReadOnly { [Token(Token = "0x6002E73")] get; }

		// Token: 0x06002E74 RID: 11892
		[Token(Token = "0x6002E74")]
		void Add(T item);

		// Token: 0x06002E75 RID: 11893
		[Token(Token = "0x6002E75")]
		void Clear();

		// Token: 0x06002E76 RID: 11894
		[Token(Token = "0x6002E76")]
		bool Contains(T item);

		// Token: 0x06002E77 RID: 11895
		[Token(Token = "0x6002E77")]
		void CopyTo(T[] array, int arrayIndex);

		// Token: 0x06002E78 RID: 11896
		[Token(Token = "0x6002E78")]
		bool Remove(T item);
	}
}
