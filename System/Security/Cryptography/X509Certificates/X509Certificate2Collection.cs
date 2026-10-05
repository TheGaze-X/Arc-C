using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200013A RID: 314
	[Token(Token = "0x200013A")]
	public class X509Certificate2Collection : X509CertificateCollection
	{
		// Token: 0x0600078C RID: 1932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600078C")]
		[Address(RVA = "0x4A887E0", Offset = "0x4A873E0", VA = "0x184A887E0")]
		public X509Certificate2Collection()
		{
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600078D")]
		[Address(RVA = "0x5128D10", Offset = "0x5127910", VA = "0x185128D10")]
		public X509Certificate2Collection(X509Certificate2Collection certificates)
		{
		}

		// Token: 0x1700015D RID: 349
		[Token(Token = "0x1700015D")]
		public X509Certificate2 this[int index]
		{
			[Token(Token = "0x600078E")]
			[Address(RVA = "0x5128DD0", Offset = "0x51279D0", VA = "0x185128DD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x00004ED8 File Offset: 0x000030D8
		[Token(Token = "0x600078F")]
		[Address(RVA = "0x51275F0", Offset = "0x51261F0", VA = "0x1851275F0")]
		public int Add(X509Certificate2 certificate)
		{
			return 0;
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000790")]
		[Address(RVA = "0x5127540", Offset = "0x5126140", VA = "0x185127540")]
		[MonoTODO("Method isn't transactional (like documented)")]
		public void AddRange(X509Certificate2Collection certificates)
		{
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x00004EF0 File Offset: 0x000030F0
		[Token(Token = "0x6000791")]
		[Address(RVA = "0x51276A0", Offset = "0x51262A0", VA = "0x1851276A0")]
		public bool Contains(X509Certificate2 certificate)
		{
			return default(bool);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000792")]
		[Address(RVA = "0x5128B70", Offset = "0x5127770", VA = "0x185128B70")]
		private string GetKeyIdentifier(X509Certificate2 x)
		{
			return null;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000793")]
		[Address(RVA = "0x51279E0", Offset = "0x51265E0", VA = "0x1851279E0")]
		[MonoTODO("Does not support X509FindType.FindByTemplateName, FindByApplicationPolicy and FindByCertificatePolicy")]
		public X509Certificate2Collection Find(X509FindType findType, object findValue, bool validOnly)
		{
			return null;
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000794")]
		[Address(RVA = "0x5128AD0", Offset = "0x51276D0", VA = "0x185128AD0")]
		public new X509Certificate2Enumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x040005B6 RID: 1462
		[Token(Token = "0x40005B6")]
		[FieldOffset(Offset = "0x0")]
		private static string[] newline_split;
	}
}
