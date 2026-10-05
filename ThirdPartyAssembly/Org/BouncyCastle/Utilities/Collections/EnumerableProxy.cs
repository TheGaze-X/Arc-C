using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.Collections
{
	// Token: 0x02000151 RID: 337
	[Token(Token = "0x2000151")]
	public sealed class EnumerableProxy : IEnumerable
	{
		// Token: 0x060007DB RID: 2011 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007DB")]
		[Address(RVA = "0x545D9C0", Offset = "0x545C5C0", VA = "0x18545D9C0")]
		public EnumerableProxy(IEnumerable inner)
		{
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007DC")]
		[Address(RVA = "0x545D970", Offset = "0x545C570", VA = "0x18545D970", Slot = "4")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x040007D0 RID: 2000
		[Token(Token = "0x40007D0")]
		[FieldOffset(Offset = "0x10")]
		private readonly IEnumerable inner;
	}
}
