using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace System.Buffers
{
	// Token: 0x02000635 RID: 1589
	[Token(Token = "0x2000635")]
	public abstract class ArrayPool<T>
	{
		// Token: 0x170007BB RID: 1979
		// (get) Token: 0x06002FD0 RID: 12240 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x170007BB")]
		public static ArrayPool<T> Shared
		{
			[Token(Token = "0x6002FD0")]
			[System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06002FD1 RID: 12241
		[Token(Token = "0x6002FD1")]
		public abstract T[] Rent(int minimumLength);

		// Token: 0x06002FD2 RID: 12242
		[Token(Token = "0x6002FD2")]
		public abstract void Return(T[] array, bool clearArray = false);

		// Token: 0x06002FD3 RID: 12243 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FD3")]
		protected ArrayPool()
		{
		}
	}
}
