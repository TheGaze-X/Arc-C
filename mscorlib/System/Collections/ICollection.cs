using System;
using Il2CppDummyDll;

namespace System.Collections
{
	// Token: 0x020005B9 RID: 1465
	[Token(Token = "0x20005B9")]
	public interface ICollection : IEnumerable
	{
		// Token: 0x06002B8F RID: 11151
		[Token(Token = "0x6002B8F")]
		void CopyTo(System.Array array, int index);

		// Token: 0x170006B5 RID: 1717
		// (get) Token: 0x06002B90 RID: 11152
		[Token(Token = "0x170006B5")]
		int Count { [Token(Token = "0x6002B90")] get; }

		// Token: 0x170006B6 RID: 1718
		// (get) Token: 0x06002B91 RID: 11153
		[Token(Token = "0x170006B6")]
		object SyncRoot { [Token(Token = "0x6002B91")] get; }

		// Token: 0x170006B7 RID: 1719
		// (get) Token: 0x06002B92 RID: 11154
		[Token(Token = "0x170006B7")]
		bool IsSynchronized { [Token(Token = "0x6002B92")] get; }
	}
}
