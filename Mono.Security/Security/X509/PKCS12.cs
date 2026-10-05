using System;
using System.Collections;
using System.Security.Cryptography;
using Il2CppDummyDll;
using Mono.Security.Cryptography;

namespace Mono.Security.X509
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public class PKCS12 : ICloneable
	{
		// Token: 0x06000044 RID: 68 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000044")]
		[Address(RVA = "0x4A83340", Offset = "0x4A81F40", VA = "0x184A83340")]
		public PKCS12()
		{
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000045")]
		[Address(RVA = "0x4A832B0", Offset = "0x4A81EB0", VA = "0x184A832B0")]
		public PKCS12(byte[] data)
		{
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000046")]
		[Address(RVA = "0x4A83260", Offset = "0x4A81E60", VA = "0x184A83260")]
		public PKCS12(byte[] data, string password)
		{
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000047")]
		[Address(RVA = "0x4A7D130", Offset = "0x4A7BD30", VA = "0x184A7D130")]
		private void Decode(byte[] data)
		{
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000048")]
		[Address(RVA = "0x4A7E490", Offset = "0x4A7D090", VA = "0x184A7E490", Slot = "1")]
		protected override void Finalize()
		{
		}

		// Token: 0x17000018 RID: 24
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000018")]
		public string Password
		{
			[Token(Token = "0x6000049")]
			[Address(RVA = "0x4A83F70", Offset = "0x4A82B70", VA = "0x184A83F70")]
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600004A RID: 74 RVA: 0x00002160 File Offset: 0x00000360
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000019")]
		public int IterationCount
		{
			[Token(Token = "0x600004A")]
			[Address(RVA = "0x22FB140", Offset = "0x22F9D40", VA = "0x1822FB140")]
			get
			{
				return 0;
			}
			[Token(Token = "0x600004B")]
			[Address(RVA = "0x4A83F60", Offset = "0x4A82B60", VA = "0x184A83F60")]
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600004C RID: 76 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001A")]
		public ArrayList Keys
		{
			[Token(Token = "0x600004C")]
			[Address(RVA = "0x4A83870", Offset = "0x4A82470", VA = "0x184A83870")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600004D RID: 77 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001B")]
		public X509CertificateCollection Certificates
		{
			[Token(Token = "0x600004D")]
			[Address(RVA = "0x4A83460", Offset = "0x4A82060", VA = "0x184A83460")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600004E RID: 78 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700001C")]
		internal RandomNumberGenerator RNG
		{
			[Token(Token = "0x600004E")]
			[Address(RVA = "0x4A83F30", Offset = "0x4A82B30", VA = "0x184A83F30")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x600004F")]
		[Address(RVA = "0x4A7D0C0", Offset = "0x4A7BCC0", VA = "0x184A7D0C0")]
		private bool Compare(byte[] expected, byte[] actual)
		{
			return default(bool);
		}

		// Token: 0x06000050 RID: 80 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000050")]
		[Address(RVA = "0x4A80DD0", Offset = "0x4A7F9D0", VA = "0x184A80DD0")]
		private SymmetricAlgorithm GetSymmetricAlgorithm(string algorithmOid, byte[] salt, int iterationCount)
		{
			return null;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000051")]
		[Address(RVA = "0x4A7DC40", Offset = "0x4A7C840", VA = "0x184A7DC40")]
		public byte[] Decrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] encryptedData)
		{
			return null;
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000052")]
		[Address(RVA = "0x4A7DB10", Offset = "0x4A7C710", VA = "0x184A7DB10")]
		public byte[] Decrypt(PKCS7.EncryptedData ed)
		{
			return null;
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000053")]
		[Address(RVA = "0x4A7DDA0", Offset = "0x4A7C9A0", VA = "0x184A7DDA0")]
		public byte[] Encrypt(string algorithmOid, byte[] salt, int iterationCount, byte[] data)
		{
			return null;
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x6000054")]
		[Address(RVA = "0x4A80AC0", Offset = "0x4A7F6C0", VA = "0x184A80AC0")]
		private DSAParameters GetExistingParameters(out bool found)
		{
			return default(DSAParameters);
		}

		// Token: 0x06000055 RID: 85 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000055")]
		[Address(RVA = "0x4A7C0A0", Offset = "0x4A7ACA0", VA = "0x184A7C0A0")]
		private void AddPrivateKey(PKCS8.PrivateKeyInfo pki)
		{
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000056")]
		[Address(RVA = "0x4A82350", Offset = "0x4A80F50", VA = "0x184A82350")]
		private void ReadSafeBag(ASN1 safeBag)
		{
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000057")]
		[Address(RVA = "0x4A815E0", Offset = "0x4A801E0", VA = "0x184A815E0")]
		private ASN1 Pkcs8ShroudedKeyBagSafeBag(AsymmetricAlgorithm aa, IDictionary attributes)
		{
			return null;
		}

		// Token: 0x06000058 RID: 88 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000058")]
		[Address(RVA = "0x4A7C350", Offset = "0x4A7AF50", VA = "0x184A7C350")]
		private ASN1 CertificateSafeBag(X509Certificate x509, IDictionary attributes)
		{
			return null;
		}

		// Token: 0x06000059 RID: 89 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000059")]
		[Address(RVA = "0x4A81400", Offset = "0x4A80000", VA = "0x184A81400")]
		private byte[] MAC(byte[] password, byte[] salt, int iterations, byte[] data)
		{
			return null;
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005A")]
		[Address(RVA = "0x4A7E520", Offset = "0x4A7D120", VA = "0x184A7E520")]
		public byte[] GetBytes()
		{
			return null;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600005B")]
		[Address(RVA = "0x4A7DF10", Offset = "0x4A7CB10", VA = "0x184A7DF10")]
		private PKCS7.ContentInfo EncryptedContentInfo(ASN1 safeBags, string algorithmOid)
		{
			return null;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600005C")]
		[Address(RVA = "0x4A7B8E0", Offset = "0x4A7A4E0", VA = "0x184A7B8E0")]
		public void AddCertificate(X509Certificate cert)
		{
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600005D")]
		[Address(RVA = "0x4A7B8F0", Offset = "0x4A7A4F0", VA = "0x184A7B8F0")]
		public void AddCertificate(X509Certificate cert, IDictionary attributes)
		{
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600005E")]
		[Address(RVA = "0x4A83210", Offset = "0x4A81E10", VA = "0x184A83210")]
		public void RemoveCertificate(X509Certificate cert)
		{
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600005F")]
		[Address(RVA = "0x4A82C70", Offset = "0x4A81870", VA = "0x184A82C70")]
		public void RemoveCertificate(X509Certificate cert, IDictionary attrs)
		{
		}

		// Token: 0x06000060 RID: 96 RVA: 0x000021A8 File Offset: 0x000003A8
		[Token(Token = "0x6000060")]
		[Address(RVA = "0x4A7CFB0", Offset = "0x4A7BBB0", VA = "0x184A7CFB0")]
		private bool CompareAsymmetricAlgorithm(AsymmetricAlgorithm a1, AsymmetricAlgorithm a2)
		{
			return default(bool);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000061")]
		[Address(RVA = "0x4A7BC50", Offset = "0x4A7A850", VA = "0x184A7BC50")]
		public void AddPkcs8ShroudedKeyBag(AsymmetricAlgorithm aa, IDictionary attributes)
		{
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000062")]
		[Address(RVA = "0x4A7CE30", Offset = "0x4A7BA30", VA = "0x184A7CE30", Slot = "4")]
		public object Clone()
		{
			return null;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000063 RID: 99 RVA: 0x000021C0 File Offset: 0x000003C0
		[Token(Token = "0x1700001D")]
		public static int MaximumPasswordLength
		{
			[Token(Token = "0x6000063")]
			[Address(RVA = "0x4A83EE0", Offset = "0x4A82AE0", VA = "0x184A83EE0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x10")]
		private byte[] _password;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x18")]
		private ArrayList _keyBags;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x20")]
		private ArrayList _secretBags;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x28")]
		private X509CertificateCollection _certs;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x30")]
		private bool _keyBagsChanged;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x31")]
		private bool _secretBagsChanged;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x32")]
		private bool _certsChanged;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x34")]
		private int _iterations;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x38")]
		private ArrayList _safeBags;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x40")]
		private RandomNumberGenerator _rng;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x0")]
		private static int password_max_length;

		// Token: 0x0200000D RID: 13
		[Token(Token = "0x200000D")]
		public class DeriveBytes
		{
			// Token: 0x06000065 RID: 101 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000065")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DeriveBytes()
			{
			}

			// Token: 0x1700001E RID: 30
			// (set) Token: 0x06000066 RID: 102 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700001E")]
			public string HashName
			{
				[Token(Token = "0x6000066")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				set
				{
				}
			}

			// Token: 0x1700001F RID: 31
			// (set) Token: 0x06000067 RID: 103 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700001F")]
			public int IterationCount
			{
				[Token(Token = "0x6000067")]
				[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
				set
				{
				}
			}

			// Token: 0x17000020 RID: 32
			// (set) Token: 0x06000068 RID: 104 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000020")]
			public byte[] Password
			{
				[Token(Token = "0x6000068")]
				[Address(RVA = "0x4A7AEE0", Offset = "0x4A79AE0", VA = "0x184A7AEE0")]
				set
				{
				}
			}

			// Token: 0x17000021 RID: 33
			// (set) Token: 0x06000069 RID: 105 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000021")]
			public byte[] Salt
			{
				[Token(Token = "0x6000069")]
				[Address(RVA = "0x4A7AFC0", Offset = "0x4A79BC0", VA = "0x184A7AFC0")]
				set
				{
				}
			}

			// Token: 0x0600006A RID: 106 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x4A7A6F0", Offset = "0x4A792F0", VA = "0x184A7A6F0")]
			private void Adjust(byte[] a, int aOff, byte[] b)
			{
			}

			// Token: 0x0600006B RID: 107 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x4A7A8F0", Offset = "0x4A794F0", VA = "0x184A7A8F0")]
			private byte[] Derive(byte[] diversifier, int n)
			{
				return null;
			}

			// Token: 0x0600006C RID: 108 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600006C")]
			[Address(RVA = "0x4A7A810", Offset = "0x4A79410", VA = "0x184A7A810")]
			public byte[] DeriveKey(int size)
			{
				return null;
			}

			// Token: 0x0600006D RID: 109 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600006D")]
			[Address(RVA = "0x4A7A7A0", Offset = "0x4A793A0", VA = "0x184A7A7A0")]
			public byte[] DeriveIV(int size)
			{
				return null;
			}

			// Token: 0x0600006E RID: 110 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600006E")]
			[Address(RVA = "0x4A7A880", Offset = "0x4A79480", VA = "0x184A7A880")]
			public byte[] DeriveMAC(int size)
			{
				return null;
			}

			// Token: 0x04000026 RID: 38
			[Token(Token = "0x4000026")]
			[FieldOffset(Offset = "0x0")]
			private static byte[] keyDiversifier;

			// Token: 0x04000027 RID: 39
			[Token(Token = "0x4000027")]
			[FieldOffset(Offset = "0x8")]
			private static byte[] ivDiversifier;

			// Token: 0x04000028 RID: 40
			[Token(Token = "0x4000028")]
			[FieldOffset(Offset = "0x10")]
			private static byte[] macDiversifier;

			// Token: 0x04000029 RID: 41
			[Token(Token = "0x4000029")]
			[FieldOffset(Offset = "0x10")]
			private string _hashName;

			// Token: 0x0400002A RID: 42
			[Token(Token = "0x400002A")]
			[FieldOffset(Offset = "0x18")]
			private int _iterations;

			// Token: 0x0400002B RID: 43
			[Token(Token = "0x400002B")]
			[FieldOffset(Offset = "0x20")]
			private byte[] _password;

			// Token: 0x0400002C RID: 44
			[Token(Token = "0x400002C")]
			[FieldOffset(Offset = "0x28")]
			private byte[] _salt;
		}
	}
}
