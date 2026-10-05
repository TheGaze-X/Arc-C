using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.Collections
{
	// Token: 0x0200014F RID: 335
	[Token(Token = "0x200014F")]
	public sealed class EmptyEnumerable : IEnumerable
	{
		// Token: 0x060007D3 RID: 2003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private EmptyEnumerable()
		{
		}

		// Token: 0x060007D4 RID: 2004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D4")]
		[Address(RVA = "0x545D7C0", Offset = "0x545C3C0", VA = "0x18545D7C0", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x040007CE RID: 1998
		[Token(Token = "0x40007CE")]
		[FieldOffset(Offset = "0x0")]
		public static readonly IEnumerable Instance;
	}
}
