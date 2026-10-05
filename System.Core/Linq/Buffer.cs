using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace System.Linq
{
	// Token: 0x0200002E RID: 46
	[Token(Token = "0x200002E")]
	internal struct Buffer<TElement>
	{
		// Token: 0x06000154 RID: 340 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000154")]
		internal Buffer(IEnumerable<TElement> source)
		{
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000155")]
		internal TElement[] ToArray()
		{
			return null;
		}

		// Token: 0x040000C6 RID: 198
		[Token(Token = "0x40000C6")]
		[FieldOffset(Offset = "0x0")]
		internal TElement[] items;

		// Token: 0x040000C7 RID: 199
		[Token(Token = "0x40000C7")]
		[FieldOffset(Offset = "0x0")]
		internal int count;
	}
}
