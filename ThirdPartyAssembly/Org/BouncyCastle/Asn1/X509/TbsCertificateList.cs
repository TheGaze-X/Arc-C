using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000415 RID: 1045
	[Token(Token = "0x2000415")]
	public class TbsCertificateList : Asn1Encodable
	{
		// Token: 0x06002276 RID: 8822 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002276")]
		[Address(RVA = "0x5343530", Offset = "0x5342130", VA = "0x185343530")]
		public static TbsCertificateList GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x06002277 RID: 8823 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002277")]
		[Address(RVA = "0x5343550", Offset = "0x5342150", VA = "0x185343550")]
		public static TbsCertificateList GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06002278 RID: 8824 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002278")]
		[Address(RVA = "0x5343970", Offset = "0x5342570", VA = "0x185343970")]
		internal TbsCertificateList(Asn1Sequence seq)
		{
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06002279 RID: 8825 RVA: 0x0000F888 File Offset: 0x0000DA88
		[Token(Token = "0x17000489")]
		public int Version
		{
			[Token(Token = "0x6002279")]
			[Address(RVA = "0x5343EB0", Offset = "0x5342AB0", VA = "0x185343EB0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x0600227A RID: 8826 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048A")]
		public DerInteger VersionNumber
		{
			[Token(Token = "0x600227A")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x0600227B RID: 8827 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048B")]
		public AlgorithmIdentifier Signature
		{
			[Token(Token = "0x600227B")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x0600227C RID: 8828 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048C")]
		public X509Name Issuer
		{
			[Token(Token = "0x600227C")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x0600227D RID: 8829 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048D")]
		public Time ThisUpdate
		{
			[Token(Token = "0x600227D")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x0600227E RID: 8830 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048E")]
		public Time NextUpdate
		{
			[Token(Token = "0x600227E")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600227F RID: 8831 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600227F")]
		[Address(RVA = "0x53437D0", Offset = "0x53423D0", VA = "0x1853437D0")]
		public CrlEntry[] GetRevokedCertificates()
		{
			return null;
		}

		// Token: 0x06002280 RID: 8832 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002280")]
		[Address(RVA = "0x5343720", Offset = "0x5342320", VA = "0x185343720")]
		public IEnumerable GetRevokedCertificateEnumeration()
		{
			return null;
		}

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06002281 RID: 8833 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700048F")]
		public X509Extensions Extensions
		{
			[Token(Token = "0x6002281")]
			[Address(RVA = "0x4EE940", Offset = "0x4ED540", VA = "0x1804EE940")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002282 RID: 8834 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002282")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x04001227 RID: 4647
		[Token(Token = "0x4001227")]
		[FieldOffset(Offset = "0x10")]
		internal Asn1Sequence seq;

		// Token: 0x04001228 RID: 4648
		[Token(Token = "0x4001228")]
		[FieldOffset(Offset = "0x18")]
		internal DerInteger version;

		// Token: 0x04001229 RID: 4649
		[Token(Token = "0x4001229")]
		[FieldOffset(Offset = "0x20")]
		internal AlgorithmIdentifier signature;

		// Token: 0x0400122A RID: 4650
		[Token(Token = "0x400122A")]
		[FieldOffset(Offset = "0x28")]
		internal X509Name issuer;

		// Token: 0x0400122B RID: 4651
		[Token(Token = "0x400122B")]
		[FieldOffset(Offset = "0x30")]
		internal Time thisUpdate;

		// Token: 0x0400122C RID: 4652
		[Token(Token = "0x400122C")]
		[FieldOffset(Offset = "0x38")]
		internal Time nextUpdate;

		// Token: 0x0400122D RID: 4653
		[Token(Token = "0x400122D")]
		[FieldOffset(Offset = "0x40")]
		internal Asn1Sequence revokedCertificates;

		// Token: 0x0400122E RID: 4654
		[Token(Token = "0x400122E")]
		[FieldOffset(Offset = "0x48")]
		internal X509Extensions crlExtensions;

		// Token: 0x02000416 RID: 1046
		[Token(Token = "0x2000416")]
		private class RevokedCertificatesEnumeration : IEnumerable
		{
			// Token: 0x06002283 RID: 8835 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002283")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			internal RevokedCertificatesEnumeration(IEnumerable en)
			{
			}

			// Token: 0x06002284 RID: 8836 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002284")]
			[Address(RVA = "0x5342450", Offset = "0x5341050", VA = "0x185342450", Slot = "4")]
			public IEnumerator GetEnumerator()
			{
				return null;
			}

			// Token: 0x0400122F RID: 4655
			[Token(Token = "0x400122F")]
			[FieldOffset(Offset = "0x10")]
			private readonly IEnumerable en;

			// Token: 0x02000417 RID: 1047
			[Token(Token = "0x2000417")]
			private class RevokedCertificatesEnumerator : IEnumerator
			{
				// Token: 0x06002285 RID: 8837 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002285")]
				[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
				internal RevokedCertificatesEnumerator(IEnumerator e)
				{
				}

				// Token: 0x06002286 RID: 8838 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
				[Token(Token = "0x6002286")]
				[Address(RVA = "0x53424F0", Offset = "0x53410F0", VA = "0x1853424F0", Slot = "4")]
				public bool MoveNext()
				{
					return default(bool);
				}

				// Token: 0x06002287 RID: 8839 RVA: 0x00002053 File Offset: 0x00000253
				[Token(Token = "0x6002287")]
				[Address(RVA = "0x5342540", Offset = "0x5341140", VA = "0x185342540", Slot = "6")]
				public void Reset()
				{
				}

				// Token: 0x17000490 RID: 1168
				// (get) Token: 0x06002288 RID: 8840 RVA: 0x00002050 File Offset: 0x00000250
				[Token(Token = "0x17000490")]
				public object Current
				{
					[Token(Token = "0x6002288")]
					[Address(RVA = "0x5342590", Offset = "0x5341190", VA = "0x185342590", Slot = "5")]
					get
					{
						return null;
					}
				}

				// Token: 0x04001230 RID: 4656
				[Token(Token = "0x4001230")]
				[FieldOffset(Offset = "0x10")]
				private readonly IEnumerator e;
			}
		}
	}
}
