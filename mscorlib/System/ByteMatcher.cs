using System;
using System.Collections;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001C4 RID: 452
	[Token(Token = "0x20001C4")]
	internal class ByteMatcher
	{
		// Token: 0x0600109D RID: 4253 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600109D")]
		[Address(RVA = "0x4D2F2B0", Offset = "0x4D2DEB0", VA = "0x184D2F2B0")]
		public void AddMapping(TermInfoStrings key, byte[] val)
		{
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600109E")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70")]
		public void Sort()
		{
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x0000D878 File Offset: 0x0000BA78
		[Token(Token = "0x600109F")]
		[Address(RVA = "0x4D2F730", Offset = "0x4D2E330", VA = "0x184D2F730")]
		public bool StartsWith(int c)
		{
			return default(bool);
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x0000D890 File Offset: 0x0000BA90
		[Token(Token = "0x60010A0")]
		[Address(RVA = "0x4D2F400", Offset = "0x4D2E000", VA = "0x184D2F400")]
		public TermInfoStrings Match(char[] buffer, int offset, int length, out int used)
		{
			return TermInfoStrings.BackTab;
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60010A1")]
		[Address(RVA = "0x4D2F7C0", Offset = "0x4D2E3C0", VA = "0x184D2F7C0")]
		public ByteMatcher()
		{
		}

		// Token: 0x040007B7 RID: 1975
		[Token(Token = "0x40007B7")]
		[FieldOffset(Offset = "0x10")]
		private System.Collections.Hashtable map;

		// Token: 0x040007B8 RID: 1976
		[Token(Token = "0x40007B8")]
		[FieldOffset(Offset = "0x18")]
		private System.Collections.Hashtable starts;
	}
}
