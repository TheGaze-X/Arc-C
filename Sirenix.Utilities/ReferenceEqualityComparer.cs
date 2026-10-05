using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Sirenix.Utilities
{
	// Token: 0x0200007E RID: 126
	[Token(Token = "0x200007E")]
	public class ReferenceEqualityComparer<T> : IEqualityComparer<T> where T : class
	{
		// Token: 0x060003AC RID: 940 RVA: 0x0000395C File Offset: 0x00001B5C
		[Token(Token = "0x60003AC")]
		public bool Equals(T x, T y)
		{
			return default(bool);
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00003974 File Offset: 0x00001B74
		[Token(Token = "0x60003AD")]
		public int GetHashCode(T obj)
		{
			return 0;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x000020CA File Offset: 0x000002CA
		[Token(Token = "0x60003AE")]
		public ReferenceEqualityComparer()
		{
		}

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0x0")]
		public static readonly ReferenceEqualityComparer<T> Default;
	}
}
