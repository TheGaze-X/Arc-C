using System;
using Il2CppDummyDll;

namespace System.Collections.Generic
{
	// Token: 0x02000608 RID: 1544
	[Token(Token = "0x2000608")]
	public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable
	{
		// Token: 0x17000792 RID: 1938
		[Token(Token = "0x17000792")]
		T this[int index]
		{
			[Token(Token = "0x6002E86")]
			get;
			[Token(Token = "0x6002E87")]
			set;
		}

		// Token: 0x06002E88 RID: 11912
		[Token(Token = "0x6002E88")]
		int IndexOf(T item);

		// Token: 0x06002E89 RID: 11913
		[Token(Token = "0x6002E89")]
		void Insert(int index, T item);

		// Token: 0x06002E8A RID: 11914
		[Token(Token = "0x6002E8A")]
		void RemoveAt(int index);
	}
}
