using System;
using Il2CppDummyDll;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000348 RID: 840
	[Token(Token = "0x2000348")]
	internal abstract class X509CertificateImpl : System.IDisposable
	{
		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06001BD9 RID: 7129
		[Token(Token = "0x17000313")]
		public abstract bool IsValid { [Token(Token = "0x6001BD9")] get; }

		// Token: 0x06001BDA RID: 7130 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BDA")]
		[Address(RVA = "0x4B6A2C0", Offset = "0x4B68EC0", VA = "0x184B6A2C0")]
		protected void ThrowIfContextInvalid()
		{
		}

		// Token: 0x06001BDB RID: 7131
		[Token(Token = "0x6001BDB")]
		public abstract X509CertificateImpl Clone();

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x06001BDC RID: 7132
		[Token(Token = "0x17000314")]
		public abstract string Issuer { [Token(Token = "0x6001BDC")] get; }

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06001BDD RID: 7133
		[Token(Token = "0x17000315")]
		public abstract string Subject { [Token(Token = "0x6001BDD")] get; }

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06001BDE RID: 7134
		[Token(Token = "0x17000316")]
		public abstract byte[] RawData { [Token(Token = "0x6001BDE")] get; }

		// Token: 0x17000317 RID: 791
		// (get) Token: 0x06001BDF RID: 7135
		[Token(Token = "0x17000317")]
		public abstract System.DateTime NotAfter { [Token(Token = "0x6001BDF")] get; }

		// Token: 0x17000318 RID: 792
		// (get) Token: 0x06001BE0 RID: 7136
		[Token(Token = "0x17000318")]
		public abstract System.DateTime NotBefore { [Token(Token = "0x6001BE0")] get; }

		// Token: 0x17000319 RID: 793
		// (get) Token: 0x06001BE1 RID: 7137
		[Token(Token = "0x17000319")]
		public abstract byte[] Thumbprint { [Token(Token = "0x6001BE1")] get; }

		// Token: 0x06001BE2 RID: 7138 RVA: 0x00012858 File Offset: 0x00010A58
		[Token(Token = "0x6001BE2")]
		[Address(RVA = "0x4B6A200", Offset = "0x4B68E00", VA = "0x184B6A200", Slot = "2")]
		public sealed override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06001BE3 RID: 7139
		[Token(Token = "0x1700031A")]
		public abstract string KeyAlgorithm { [Token(Token = "0x6001BE3")] get; }

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06001BE4 RID: 7140
		[Token(Token = "0x1700031B")]
		public abstract byte[] KeyAlgorithmParameters { [Token(Token = "0x6001BE4")] get; }

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06001BE5 RID: 7141
		[Token(Token = "0x1700031C")]
		public abstract byte[] PublicKeyValue { [Token(Token = "0x6001BE5")] get; }

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06001BE6 RID: 7142
		[Token(Token = "0x1700031D")]
		public abstract byte[] SerialNumber { [Token(Token = "0x6001BE6")] get; }

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06001BE7 RID: 7143
		[Token(Token = "0x1700031E")]
		public abstract bool HasPrivateKey { [Token(Token = "0x6001BE7")] get; }

		// Token: 0x06001BE8 RID: 7144
		[Token(Token = "0x6001BE8")]
		public abstract RSA GetRSAPrivateKey();

		// Token: 0x06001BE9 RID: 7145
		[Token(Token = "0x6001BE9")]
		public abstract DSA GetDSAPrivateKey();

		// Token: 0x06001BEA RID: 7146
		[Token(Token = "0x6001BEA")]
		public abstract byte[] Export(X509ContentType contentType, SafePasswordHandle password);

		// Token: 0x06001BEB RID: 7147
		[Token(Token = "0x6001BEB")]
		public abstract X509CertificateImpl CopyWithPrivateKey(RSA privateKey);

		// Token: 0x06001BEC RID: 7148 RVA: 0x00012870 File Offset: 0x00010A70
		[Token(Token = "0x6001BEC")]
		[Address(RVA = "0x4B69FC0", Offset = "0x4B68BC0", VA = "0x184B69FC0", Slot = "0")]
		public sealed override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001BED RID: 7149 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BED")]
		[Address(RVA = "0x4B69F50", Offset = "0x4B68B50", VA = "0x184B69F50", Slot = "4")]
		public void Dispose()
		{
		}

		// Token: 0x06001BEE RID: 7150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BEE")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "22")]
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x06001BEF RID: 7151 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BEF")]
		[Address(RVA = "0x4B6A180", Offset = "0x4B68D80", VA = "0x184B6A180", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x06001BF0 RID: 7152 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BF0")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		protected X509CertificateImpl()
		{
		}
	}
}
