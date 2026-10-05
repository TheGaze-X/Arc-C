using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x0200041E RID: 1054
	[Token(Token = "0x200041E")]
	public abstract class X509NameEntryConverter
	{
		// Token: 0x060022DE RID: 8926 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022DE")]
		[Address(RVA = "0x53800E0", Offset = "0x537ECE0", VA = "0x1853800E0")]
		protected Asn1Object ConvertHexEncoded(string hexString, int offset)
		{
			return null;
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x0000F9A8 File Offset: 0x0000DBA8
		[Token(Token = "0x60022DF")]
		[Address(RVA = "0x53800D0", Offset = "0x537ECD0", VA = "0x1853800D0")]
		protected bool CanBePrintable(string str)
		{
			return default(bool);
		}

		// Token: 0x060022E0 RID: 8928
		[Token(Token = "0x60022E0")]
		public abstract Asn1Object GetConvertedValue(DerObjectIdentifier oid, string value);

		// Token: 0x060022E1 RID: 8929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected X509NameEntryConverter()
		{
		}
	}
}
