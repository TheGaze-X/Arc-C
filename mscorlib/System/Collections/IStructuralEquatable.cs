using System;
using Il2CppDummyDll;

namespace System.Collections
{
	// Token: 0x020005C2 RID: 1474
	[Token(Token = "0x20005C2")]
	public interface IStructuralEquatable
	{
		// Token: 0x06002BB4 RID: 11188
		[Token(Token = "0x6002BB4")]
		bool Equals(object other, IEqualityComparer comparer);

		// Token: 0x06002BB5 RID: 11189
		[Token(Token = "0x6002BB5")]
		int GetHashCode(IEqualityComparer comparer);
	}
}
