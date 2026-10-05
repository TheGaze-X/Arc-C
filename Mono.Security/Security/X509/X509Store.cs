using System;
using System.Collections;
using Il2CppDummyDll;

namespace Mono.Security.X509
{
	// Token: 0x02000018 RID: 24
	[Token(Token = "0x2000018")]
	public class X509Store
	{
		// Token: 0x060000D5 RID: 213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000D5")]
		[Address(RVA = "0x4A8FAC0", Offset = "0x4A8E6C0", VA = "0x184A8FAC0")]
		internal X509Store(string path, bool crl, bool newFormat)
		{
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x060000D6 RID: 214 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000042")]
		public X509CertificateCollection Certificates
		{
			[Token(Token = "0x60000D6")]
			[Address(RVA = "0x4A8FB20", Offset = "0x4A8E720", VA = "0x184A8FB20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000043")]
		public ArrayList Crls
		{
			[Token(Token = "0x60000D7")]
			[Address(RVA = "0x4A8FB60", Offset = "0x4A8E760", VA = "0x184A8FB60")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D8")]
		[Address(RVA = "0x4A8F910", Offset = "0x4A8E510", VA = "0x184A8F910")]
		private byte[] Load(string filename)
		{
			return null;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000D9")]
		[Address(RVA = "0x4A8F710", Offset = "0x4A8E310", VA = "0x184A8F710")]
		private X509Certificate LoadCertificate(string filename)
		{
			return null;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DA")]
		[Address(RVA = "0x4A8F790", Offset = "0x4A8E390", VA = "0x184A8F790")]
		private X509Crl LoadCrl(string filename)
		{
			return null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00002508 File Offset: 0x00000708
		[Token(Token = "0x60000DB")]
		[Address(RVA = "0x4A8F6B0", Offset = "0x4A8E2B0", VA = "0x184A8F6B0")]
		private bool CheckStore(string path, bool throwException)
		{
			return default(bool);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DC")]
		[Address(RVA = "0x4A8F350", Offset = "0x4A8DF50", VA = "0x184A8F350")]
		private X509CertificateCollection BuildCertificatesCollection(string storeName)
		{
			return null;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000DD")]
		[Address(RVA = "0x4A8F560", Offset = "0x4A8E160", VA = "0x184A8F560")]
		private ArrayList BuildCrlsCollection(string storeName)
		{
			return null;
		}

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x10")]
		private string _storePath;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x18")]
		private X509CertificateCollection _certificates;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x20")]
		private ArrayList _crls;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x28")]
		private bool _crl;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x29")]
		private bool _newFormat;
	}
}
