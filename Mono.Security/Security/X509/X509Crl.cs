using System;
using System.Collections;
using System.Reflection;
using System.Security.Cryptography;
using Il2CppDummyDll;

namespace Mono.Security.X509
{
	// Token: 0x0200000F RID: 15
	[Token(Token = "0x200000F")]
	[DefaultMember("Item")]
	public class X509Crl
	{
		// Token: 0x0600007D RID: 125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600007D")]
		[Address(RVA = "0x4A8D480", Offset = "0x4A8C080", VA = "0x184A8D480")]
		public X509Crl(byte[] crl)
		{
		}

		// Token: 0x0600007E RID: 126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600007E")]
		[Address(RVA = "0x4A8C4F0", Offset = "0x4A8B0F0", VA = "0x184A8C4F0")]
		private void Parse(byte[] crl)
		{
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600007F RID: 127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000022")]
		public X509ExtensionCollection Extensions
		{
			[Token(Token = "0x600007F")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000023")]
		public byte[] Hash
		{
			[Token(Token = "0x6000080")]
			[Address(RVA = "0x4A8D5C0", Offset = "0x4A8C1C0", VA = "0x184A8D5C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000024")]
		public string IssuerName
		{
			[Token(Token = "0x6000081")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x17000025")]
		public DateTime NextUpdate
		{
			[Token(Token = "0x6000082")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x6000083")]
		[Address(RVA = "0x4A88440", Offset = "0x4A87040", VA = "0x184A88440")]
		private bool Compare(byte[] array1, byte[] array2)
		{
			return default(bool);
		}

		// Token: 0x06000084 RID: 132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000084")]
		[Address(RVA = "0x4A8C1D0", Offset = "0x4A8ADD0", VA = "0x184A8C1D0")]
		public X509Crl.X509CrlEntry GetCrlEntry(X509Certificate x509)
		{
			return null;
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000085")]
		[Address(RVA = "0x4A8C280", Offset = "0x4A8AE80", VA = "0x184A8C280")]
		public X509Crl.X509CrlEntry GetCrlEntry(byte[] serialNumber)
		{
			return null;
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x6000086")]
		[Address(RVA = "0x4A8D160", Offset = "0x4A8BD60", VA = "0x184A8D160")]
		internal bool VerifySignature(DSA dsa)
		{
			return default(bool);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x6000087")]
		[Address(RVA = "0x4A8D050", Offset = "0x4A8BC50", VA = "0x184A8D050")]
		internal bool VerifySignature(RSA rsa)
		{
			return default(bool);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x6000088")]
		[Address(RVA = "0x4A8CCF0", Offset = "0x4A8B8F0", VA = "0x184A8CCF0")]
		public bool VerifySignature(AsymmetricAlgorithm aa)
		{
			return default(bool);
		}

		// Token: 0x0400003D RID: 61
		[Token(Token = "0x400003D")]
		[FieldOffset(Offset = "0x10")]
		private string issuer;

		// Token: 0x0400003E RID: 62
		[Token(Token = "0x400003E")]
		[FieldOffset(Offset = "0x18")]
		private byte version;

		// Token: 0x0400003F RID: 63
		[Token(Token = "0x400003F")]
		[FieldOffset(Offset = "0x20")]
		private DateTime thisUpdate;

		// Token: 0x04000040 RID: 64
		[Token(Token = "0x4000040")]
		[FieldOffset(Offset = "0x28")]
		private DateTime nextUpdate;

		// Token: 0x04000041 RID: 65
		[Token(Token = "0x4000041")]
		[FieldOffset(Offset = "0x30")]
		private ArrayList entries;

		// Token: 0x04000042 RID: 66
		[Token(Token = "0x4000042")]
		[FieldOffset(Offset = "0x38")]
		private string signatureOID;

		// Token: 0x04000043 RID: 67
		[Token(Token = "0x4000043")]
		[FieldOffset(Offset = "0x40")]
		private byte[] signature;

		// Token: 0x04000044 RID: 68
		[Token(Token = "0x4000044")]
		[FieldOffset(Offset = "0x48")]
		private X509ExtensionCollection extensions;

		// Token: 0x04000045 RID: 69
		[Token(Token = "0x4000045")]
		[FieldOffset(Offset = "0x50")]
		private byte[] encoded;

		// Token: 0x04000046 RID: 70
		[Token(Token = "0x4000046")]
		[FieldOffset(Offset = "0x58")]
		private byte[] hash_value;

		// Token: 0x02000010 RID: 16
		[Token(Token = "0x2000010")]
		public class X509CrlEntry
		{
			// Token: 0x06000089 RID: 137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000089")]
			[Address(RVA = "0x4A8C040", Offset = "0x4A8AC40", VA = "0x184A8C040")]
			internal X509CrlEntry(ASN1 entry)
			{
			}

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x0600008A RID: 138 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000026")]
			public byte[] SerialNumber
			{
				[Token(Token = "0x600008A")]
				[Address(RVA = "0x4A8C150", Offset = "0x4A8AD50", VA = "0x184A8C150")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x0600008B RID: 139 RVA: 0x000022B0 File Offset: 0x000004B0
			[Token(Token = "0x17000027")]
			public DateTime RevocationDate
			{
				[Token(Token = "0x600008B")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return default(DateTime);
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x0600008C RID: 140 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000028")]
			public X509ExtensionCollection Extensions
			{
				[Token(Token = "0x600008C")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				get
				{
					return null;
				}
			}

			// Token: 0x04000047 RID: 71
			[Token(Token = "0x4000047")]
			[FieldOffset(Offset = "0x10")]
			private byte[] sn;

			// Token: 0x04000048 RID: 72
			[Token(Token = "0x4000048")]
			[FieldOffset(Offset = "0x18")]
			private DateTime revocationDate;

			// Token: 0x04000049 RID: 73
			[Token(Token = "0x4000049")]
			[FieldOffset(Offset = "0x20")]
			private X509ExtensionCollection extensions;
		}
	}
}
