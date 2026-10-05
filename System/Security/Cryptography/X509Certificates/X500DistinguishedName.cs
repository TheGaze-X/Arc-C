using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000137 RID: 311
	[Token(Token = "0x2000137")]
	[MonoTODO("Some X500DistinguishedNameFlags options aren't supported, like DoNotUsePlusSign, DoNotUseQuotes and ForceUTF8Encoding")]
	public sealed class X500DistinguishedName : AsnEncodedData
	{
		// Token: 0x0600075C RID: 1884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075C")]
		[Address(RVA = "0x5126650", Offset = "0x5125250", VA = "0x185126650")]
		public X500DistinguishedName(byte[] encodedDistinguishedName)
		{
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075D")]
		[Address(RVA = "0x5126370", Offset = "0x5124F70", VA = "0x185126370")]
		public X500DistinguishedName(string distinguishedName)
		{
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600075E")]
		[Address(RVA = "0x5126380", Offset = "0x5124F80", VA = "0x185126380")]
		public X500DistinguishedName(string distinguishedName, X500DistinguishedNameFlags flag)
		{
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014B")]
		public string Name
		{
			[Token(Token = "0x600075F")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000760")]
		[Address(RVA = "0x51260D0", Offset = "0x5124CD0", VA = "0x1851260D0")]
		public string Decode(X500DistinguishedNameFlags flag)
		{
			return null;
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000761")]
		[Address(RVA = "0x5126290", Offset = "0x5124E90", VA = "0x185126290", Slot = "5")]
		public override string Format(bool multiLine)
		{
			return null;
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000762")]
		[Address(RVA = "0x5126300", Offset = "0x5124F00", VA = "0x185126300")]
		private static string GetSeparator(X500DistinguishedNameFlags flag)
		{
			return null;
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000763")]
		[Address(RVA = "0x5125FC0", Offset = "0x5124BC0", VA = "0x185125FC0")]
		private void DecodeRawData()
		{
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000764")]
		[Address(RVA = "0x5125DD0", Offset = "0x51249D0", VA = "0x185125DD0")]
		private static string Canonize(string s)
		{
			return null;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x00004DD0 File Offset: 0x00002FD0
		[Token(Token = "0x6000765")]
		[Address(RVA = "0x5125BB0", Offset = "0x51247B0", VA = "0x185125BB0")]
		internal static bool AreEqual(X500DistinguishedName name1, X500DistinguishedName name2)
		{
			return default(bool);
		}

		// Token: 0x040005A6 RID: 1446
		[Token(Token = "0x40005A6")]
		[FieldOffset(Offset = "0x20")]
		private string name;

		// Token: 0x040005A7 RID: 1447
		[Token(Token = "0x40005A7")]
		[FieldOffset(Offset = "0x28")]
		private byte[] canonEncoding;
	}
}
