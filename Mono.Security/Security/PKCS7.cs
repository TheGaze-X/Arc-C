using System;
using System.Collections;
using Il2CppDummyDll;
using Mono.Security.X509;

namespace Mono.Security
{
	// Token: 0x02000006 RID: 6
	[Token(Token = "0x2000006")]
	public sealed class PKCS7
	{
		// Token: 0x02000007 RID: 7
		[Token(Token = "0x2000007")]
		public class ContentInfo
		{
			// Token: 0x06000023 RID: 35 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000023")]
			[Address(RVA = "0x4A7A2F0", Offset = "0x4A78EF0", VA = "0x184A7A2F0")]
			public ContentInfo()
			{
			}

			// Token: 0x06000024 RID: 36 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000024")]
			[Address(RVA = "0x4A7A400", Offset = "0x4A79000", VA = "0x184A7A400")]
			public ContentInfo(string oid)
			{
			}

			// Token: 0x06000025 RID: 37 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000025")]
			[Address(RVA = "0x4A7A380", Offset = "0x4A78F80", VA = "0x184A7A380")]
			public ContentInfo(byte[] data)
			{
			}

			// Token: 0x06000026 RID: 38 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000026")]
			[Address(RVA = "0x4A7A430", Offset = "0x4A79030", VA = "0x184A7A430")]
			public ContentInfo(ASN1 asn1)
			{
			}

			// Token: 0x17000006 RID: 6
			// (get) Token: 0x06000027 RID: 39 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000006")]
			public ASN1 ASN1
			{
				[Token(Token = "0x6000027")]
				[Address(RVA = "0x4A7A130", Offset = "0x4A78D30", VA = "0x184A7A130")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000007 RID: 7
			// (get) Token: 0x06000028 RID: 40 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06000029 RID: 41 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000007")]
			public ASN1 Content
			{
				[Token(Token = "0x6000028")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
				[Token(Token = "0x6000029")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				set
				{
				}
			}

			// Token: 0x17000008 RID: 8
			// (get) Token: 0x0600002A RID: 42 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600002B RID: 43 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000008")]
			public string ContentType
			{
				[Token(Token = "0x600002A")]
				[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
				get
				{
					return null;
				}
				[Token(Token = "0x600002B")]
				[Address(RVA = "0x4EEA40", Offset = "0x4ED640", VA = "0x1804EEA40")]
				set
				{
				}
			}

			// Token: 0x0600002C RID: 44 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600002C")]
			[Address(RVA = "0x4A7A130", Offset = "0x4A78D30", VA = "0x184A7A130")]
			internal ASN1 GetASN1()
			{
				return null;
			}

			// Token: 0x04000004 RID: 4
			[Token(Token = "0x4000004")]
			[FieldOffset(Offset = "0x10")]
			private string contentType;

			// Token: 0x04000005 RID: 5
			[Token(Token = "0x4000005")]
			[FieldOffset(Offset = "0x18")]
			private ASN1 content;
		}

		// Token: 0x02000008 RID: 8
		[Token(Token = "0x2000008")]
		public class EncryptedData
		{
			// Token: 0x0600002D RID: 45 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600002D")]
			[Address(RVA = "0x4A7B1B0", Offset = "0x4A79DB0", VA = "0x184A7B1B0")]
			public EncryptedData()
			{
			}

			// Token: 0x0600002E RID: 46 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600002E")]
			[Address(RVA = "0x4A7B1D0", Offset = "0x4A79DD0", VA = "0x184A7B1D0")]
			public EncryptedData(ASN1 asn1)
			{
			}

			// Token: 0x17000009 RID: 9
			// (get) Token: 0x0600002F RID: 47 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000009")]
			public PKCS7.ContentInfo EncryptionAlgorithm
			{
				[Token(Token = "0x600002F")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000030 RID: 48 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700000A")]
			public byte[] EncryptedContent
			{
				[Token(Token = "0x6000030")]
				[Address(RVA = "0x4A7B640", Offset = "0x4A7A240", VA = "0x184A7B640")]
				get
				{
					return null;
				}
			}

			// Token: 0x04000006 RID: 6
			[Token(Token = "0x4000006")]
			[FieldOffset(Offset = "0x10")]
			private byte _version;

			// Token: 0x04000007 RID: 7
			[Token(Token = "0x4000007")]
			[FieldOffset(Offset = "0x18")]
			private PKCS7.ContentInfo _content;

			// Token: 0x04000008 RID: 8
			[Token(Token = "0x4000008")]
			[FieldOffset(Offset = "0x20")]
			private PKCS7.ContentInfo _encryptionAlgorithm;

			// Token: 0x04000009 RID: 9
			[Token(Token = "0x4000009")]
			[FieldOffset(Offset = "0x28")]
			private byte[] _encrypted;
		}

		// Token: 0x02000009 RID: 9
		[Token(Token = "0x2000009")]
		public class SignedData
		{
			// Token: 0x06000031 RID: 49 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000031")]
			[Address(RVA = "0x4A84310", Offset = "0x4A82F10", VA = "0x184A84310")]
			public SignedData(ASN1 asn1)
			{
			}

			// Token: 0x1700000B RID: 11
			// (get) Token: 0x06000032 RID: 50 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700000B")]
			public X509CertificateCollection Certificates
			{
				[Token(Token = "0x6000032")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700000C RID: 12
			// (get) Token: 0x06000033 RID: 51 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700000C")]
			public PKCS7.ContentInfo ContentInfo
			{
				[Token(Token = "0x6000033")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				get
				{
					return null;
				}
			}

			// Token: 0x1700000D RID: 13
			// (set) Token: 0x06000034 RID: 52 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700000D")]
			public string HashName
			{
				[Token(Token = "0x6000034")]
				[Address(RVA = "0x4A84BF0", Offset = "0x4A837F0", VA = "0x184A84BF0")]
				set
				{
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000035 RID: 53 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700000E")]
			public PKCS7.SignerInfo SignerInfo
			{
				[Token(Token = "0x6000035")]
				[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
				get
				{
					return null;
				}
			}

			// Token: 0x06000036 RID: 54 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000036")]
			[Address(RVA = "0x4A84180", Offset = "0x4A82D80", VA = "0x184A84180")]
			internal string OidToName(string oid)
			{
				return null;
			}

			// Token: 0x0400000A RID: 10
			[Token(Token = "0x400000A")]
			[FieldOffset(Offset = "0x10")]
			private byte version;

			// Token: 0x0400000B RID: 11
			[Token(Token = "0x400000B")]
			[FieldOffset(Offset = "0x18")]
			private string hashAlgorithm;

			// Token: 0x0400000C RID: 12
			[Token(Token = "0x400000C")]
			[FieldOffset(Offset = "0x20")]
			private PKCS7.ContentInfo contentInfo;

			// Token: 0x0400000D RID: 13
			[Token(Token = "0x400000D")]
			[FieldOffset(Offset = "0x28")]
			private X509CertificateCollection certs;

			// Token: 0x0400000E RID: 14
			[Token(Token = "0x400000E")]
			[FieldOffset(Offset = "0x30")]
			private ArrayList crls;

			// Token: 0x0400000F RID: 15
			[Token(Token = "0x400000F")]
			[FieldOffset(Offset = "0x38")]
			private PKCS7.SignerInfo signerInfo;

			// Token: 0x04000010 RID: 16
			[Token(Token = "0x4000010")]
			[FieldOffset(Offset = "0x40")]
			private bool mda;
		}

		// Token: 0x0200000A RID: 10
		[Token(Token = "0x200000A")]
		public class SignerInfo
		{
			// Token: 0x06000037 RID: 55 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000037")]
			[Address(RVA = "0x4A84C40", Offset = "0x4A83840", VA = "0x184A84C40")]
			public SignerInfo()
			{
			}

			// Token: 0x06000038 RID: 56 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6000038")]
			[Address(RVA = "0x4A84CF0", Offset = "0x4A838F0", VA = "0x184A84CF0")]
			public SignerInfo(ASN1 asn1)
			{
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000039 RID: 57 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x1700000F")]
			public string IssuerName
			{
				[Token(Token = "0x6000039")]
				[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x0600003A RID: 58 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000010")]
			public byte[] SerialNumber
			{
				[Token(Token = "0x600003A")]
				[Address(RVA = "0x4A85220", Offset = "0x4A83E20", VA = "0x184A85220")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x0600003B RID: 59 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000011")]
			public ArrayList AuthenticatedAttributes
			{
				[Token(Token = "0x600003B")]
				[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x0600003C RID: 60 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600003D RID: 61 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000012")]
			public string HashName
			{
				[Token(Token = "0x600003C")]
				[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
				get
				{
					return null;
				}
				[Token(Token = "0x600003D")]
				[Address(RVA = "0x4EC670", Offset = "0x4EB270", VA = "0x1804EC670")]
				set
				{
				}
			}

			// Token: 0x17000013 RID: 19
			// (get) Token: 0x0600003E RID: 62 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000013")]
			public byte[] Signature
			{
				[Token(Token = "0x600003E")]
				[Address(RVA = "0x4A852A0", Offset = "0x4A83EA0", VA = "0x184A852A0")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x0600003F RID: 63 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x17000014")]
			public ArrayList UnauthenticatedAttributes
			{
				[Token(Token = "0x600003F")]
				[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
				get
				{
					return null;
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000040 RID: 64 RVA: 0x00002148 File Offset: 0x00000348
			[Token(Token = "0x17000015")]
			public byte Version
			{
				[Token(Token = "0x6000040")]
				[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
				get
				{
					return 0;
				}
			}

			// Token: 0x04000011 RID: 17
			[Token(Token = "0x4000011")]
			[FieldOffset(Offset = "0x10")]
			private byte version;

			// Token: 0x04000012 RID: 18
			[Token(Token = "0x4000012")]
			[FieldOffset(Offset = "0x18")]
			private string hashAlgorithm;

			// Token: 0x04000013 RID: 19
			[Token(Token = "0x4000013")]
			[FieldOffset(Offset = "0x20")]
			private ArrayList authenticatedAttributes;

			// Token: 0x04000014 RID: 20
			[Token(Token = "0x4000014")]
			[FieldOffset(Offset = "0x28")]
			private ArrayList unauthenticatedAttributes;

			// Token: 0x04000015 RID: 21
			[Token(Token = "0x4000015")]
			[FieldOffset(Offset = "0x30")]
			private byte[] signature;

			// Token: 0x04000016 RID: 22
			[Token(Token = "0x4000016")]
			[FieldOffset(Offset = "0x38")]
			private string issuer;

			// Token: 0x04000017 RID: 23
			[Token(Token = "0x4000017")]
			[FieldOffset(Offset = "0x40")]
			private byte[] serial;

			// Token: 0x04000018 RID: 24
			[Token(Token = "0x4000018")]
			[FieldOffset(Offset = "0x48")]
			private byte[] ski;
		}
	}
}
