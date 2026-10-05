using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Utilities.Collections
{
	// Token: 0x02000150 RID: 336
	[Token(Token = "0x2000150")]
	public sealed class EmptyEnumerator : IEnumerator
	{
		// Token: 0x060007D6 RID: 2006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		private EmptyEnumerator()
		{
		}

		// Token: 0x060007D7 RID: 2007 RVA: 0x00005850 File Offset: 0x00003A50
		[Token(Token = "0x60007D7")]
		[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
		public bool MoveNext()
		{
			return default(bool);
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D8")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "6")]
		public void Reset()
		{
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060007D9 RID: 2009 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170000D1")]
		public object Current
		{
			[Token(Token = "0x60007D9")]
			[Address(RVA = "0x545D910", Offset = "0x545C510", VA = "0x18545D910", Slot = "5")]
			get
			{
				return null;
			}
		}

		// Token: 0x040007CF RID: 1999
		[Token(Token = "0x40007CF")]
		[FieldOffset(Offset = "0x0")]
		public static readonly IEnumerator Instance;
	}
}
