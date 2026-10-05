using System;
using Il2CppDummyDll;

namespace Mono.Security.X509
{
	// Token: 0x02000014 RID: 20
	[Token(Token = "0x2000014")]
	public class X509Chain
	{
		// Token: 0x060000BB RID: 187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x4A8BF30", Offset = "0x4A8AB30", VA = "0x184A8BF30")]
		public X509Chain()
		{
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700003D")]
		public X509CertificateCollection TrustAnchors
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x4A8BFA0", Offset = "0x4A8ABA0", VA = "0x184A8BFA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060000BD RID: 189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x4A8BEC0", Offset = "0x4A8AAC0", VA = "0x184A8BEC0")]
		public void LoadCertificates(X509CertificateCollection collection)
		{
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002448 File Offset: 0x00000648
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x4A8B190", Offset = "0x4A89D90", VA = "0x184A8B190")]
		public bool Build(X509Certificate leaf)
		{
			return default(bool);
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x4A8BEE0", Offset = "0x4A8AAE0", VA = "0x184A8BEE0")]
		public void Reset()
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002460 File Offset: 0x00000660
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x4A8BD10", Offset = "0x4A8A910", VA = "0x184A8BD10")]
		private bool IsValid(X509Certificate cert)
		{
			return default(bool);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x4A8B5E0", Offset = "0x4A8A1E0", VA = "0x184A8B5E0")]
		private X509Certificate FindCertificateParent(X509Certificate child)
		{
			return null;
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x4A8B800", Offset = "0x4A8A400", VA = "0x184A8B800")]
		private X509Certificate FindCertificateRoot(X509Certificate potentialRoot)
		{
			return null;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002478 File Offset: 0x00000678
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x4A8BCD0", Offset = "0x4A8A8D0", VA = "0x184A8BCD0")]
		private bool IsTrusted(X509Certificate potentialTrusted)
		{
			return default(bool);
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002490 File Offset: 0x00000690
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x4A8BA40", Offset = "0x4A8A640", VA = "0x184A8BA40")]
		private bool IsParent(X509Certificate child, X509Certificate parent)
		{
			return default(bool);
		}

		// Token: 0x04000062 RID: 98
		[Token(Token = "0x4000062")]
		[FieldOffset(Offset = "0x10")]
		private X509CertificateCollection roots;

		// Token: 0x04000063 RID: 99
		[Token(Token = "0x4000063")]
		[FieldOffset(Offset = "0x18")]
		private X509CertificateCollection certs;

		// Token: 0x04000064 RID: 100
		[Token(Token = "0x4000064")]
		[FieldOffset(Offset = "0x20")]
		private X509Certificate _root;

		// Token: 0x04000065 RID: 101
		[Token(Token = "0x4000065")]
		[FieldOffset(Offset = "0x28")]
		private X509CertificateCollection _chain;

		// Token: 0x04000066 RID: 102
		[Token(Token = "0x4000066")]
		[FieldOffset(Offset = "0x30")]
		private X509ChainStatusFlags _status;
	}
}
