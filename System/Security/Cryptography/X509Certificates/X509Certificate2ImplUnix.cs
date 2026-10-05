using System;
using System.Collections.Generic;
using System.Text;
using Il2CppDummyDll;
using Internal.Cryptography.Pal;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x0200013E RID: 318
	[Token(Token = "0x200013E")]
	internal abstract class X509Certificate2ImplUnix : X509Certificate2Impl
	{
		// Token: 0x060007BB RID: 1979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007BB")]
		[Address(RVA = "0x512AB90", Offset = "0x5129790", VA = "0x18512AB90")]
		private void EnsureCertData()
		{
		}

		// Token: 0x060007BC RID: 1980
		[Token(Token = "0x60007BC")]
		protected abstract byte[] GetRawCertData();

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x060007BD RID: 1981 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016D")]
		public sealed override string KeyAlgorithm
		{
			[Token(Token = "0x60007BD")]
			[Address(RVA = "0x512B4A0", Offset = "0x512A0A0", VA = "0x18512B4A0", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x060007BE RID: 1982 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016E")]
		public sealed override byte[] KeyAlgorithmParameters
		{
			[Token(Token = "0x60007BE")]
			[Address(RVA = "0x512B480", Offset = "0x512A080", VA = "0x18512B480", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x060007BF RID: 1983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700016F")]
		public sealed override byte[] PublicKeyValue
		{
			[Token(Token = "0x60007BF")]
			[Address(RVA = "0x512B580", Offset = "0x512A180", VA = "0x18512B580", Slot = "15")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x060007C0 RID: 1984 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000170")]
		public sealed override byte[] SerialNumber
		{
			[Token(Token = "0x60007C0")]
			[Address(RVA = "0x512B5C0", Offset = "0x512A1C0", VA = "0x18512B5C0", Slot = "16")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x060007C1 RID: 1985 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000171")]
		public sealed override string SignatureAlgorithm
		{
			[Token(Token = "0x60007C1")]
			[Address(RVA = "0x512B5E0", Offset = "0x512A1E0", VA = "0x18512B5E0", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x060007C2 RID: 1986 RVA: 0x00004F80 File Offset: 0x00003180
		[Token(Token = "0x17000172")]
		public sealed override int Version
		{
			[Token(Token = "0x60007C2")]
			[Address(RVA = "0x512B740", Offset = "0x512A340", VA = "0x18512B740", Slot = "29")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x060007C3 RID: 1987 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000173")]
		public sealed override X500DistinguishedName SubjectName
		{
			[Token(Token = "0x60007C3")]
			[Address(RVA = "0x512B600", Offset = "0x512A200", VA = "0x18512B600", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x060007C4 RID: 1988 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000174")]
		public sealed override X500DistinguishedName IssuerName
		{
			[Token(Token = "0x60007C4")]
			[Address(RVA = "0x512B410", Offset = "0x512A010", VA = "0x18512B410", Slot = "24")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x060007C5 RID: 1989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000175")]
		public sealed override string Subject
		{
			[Token(Token = "0x60007C5")]
			[Address(RVA = "0x512B620", Offset = "0x512A220", VA = "0x18512B620", Slot = "8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x060007C6 RID: 1990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000176")]
		public sealed override string Issuer
		{
			[Token(Token = "0x60007C6")]
			[Address(RVA = "0x512B430", Offset = "0x512A030", VA = "0x18512B430", Slot = "7")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x060007C7 RID: 1991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000177")]
		public sealed override byte[] RawData
		{
			[Token(Token = "0x60007C7")]
			[Address(RVA = "0x512B5A0", Offset = "0x512A1A0", VA = "0x18512B5A0", Slot = "9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x060007C8 RID: 1992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000178")]
		public sealed override byte[] Thumbprint
		{
			[Token(Token = "0x60007C8")]
			[Address(RVA = "0x512B670", Offset = "0x512A270", VA = "0x18512B670", Slot = "12")]
			get
			{
				return null;
			}
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007C9")]
		[Address(RVA = "0x512B3B0", Offset = "0x5129FB0", VA = "0x18512B3B0", Slot = "31")]
		public sealed override string GetNameInfo(X509NameType nameType, bool forIssuer)
		{
			return null;
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x060007CA RID: 1994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000179")]
		public sealed override IEnumerable<X509Extension> Extensions
		{
			[Token(Token = "0x60007CA")]
			[Address(RVA = "0x512B3F0", Offset = "0x5129FF0", VA = "0x18512B3F0", Slot = "23")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x060007CB RID: 1995 RVA: 0x00004F98 File Offset: 0x00003198
		[Token(Token = "0x1700017A")]
		public sealed override DateTime NotAfter
		{
			[Token(Token = "0x60007CB")]
			[Address(RVA = "0x512B4C0", Offset = "0x512A0C0", VA = "0x18512B4C0", Slot = "10")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060007CC RID: 1996 RVA: 0x00004FB0 File Offset: 0x000031B0
		[Token(Token = "0x1700017B")]
		public sealed override DateTime NotBefore
		{
			[Token(Token = "0x60007CC")]
			[Address(RVA = "0x512B520", Offset = "0x512A120", VA = "0x18512B520", Slot = "11")]
			get
			{
				return default(DateTime);
			}
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007CD")]
		[Address(RVA = "0x512AAF0", Offset = "0x51296F0", VA = "0x18512AAF0", Slot = "33")]
		public sealed override void AppendPrivateKeyInfo(StringBuilder sb)
		{
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CE")]
		[Address(RVA = "0x512B1F0", Offset = "0x5129DF0", VA = "0x18512B1F0", Slot = "20")]
		public sealed override byte[] Export(X509ContentType contentType, SafePasswordHandle password)
		{
			return null;
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007CF")]
		[Address(RVA = "0x512ACB0", Offset = "0x51298B0", VA = "0x18512ACB0")]
		private byte[] ExportPkcs12(SafePasswordHandle password)
		{
			return null;
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60007D0")]
		[Address(RVA = "0x512AD20", Offset = "0x5129920", VA = "0x18512AD20")]
		private byte[] ExportPkcs12(string password)
		{
			return null;
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60007D1")]
		[Address(RVA = "0x4E9D30", Offset = "0x4E8930", VA = "0x1804E9D30")]
		protected X509Certificate2ImplUnix()
		{
		}

		// Token: 0x040005BC RID: 1468
		[Token(Token = "0x40005BC")]
		[FieldOffset(Offset = "0x10")]
		private bool readCertData;

		// Token: 0x040005BD RID: 1469
		[Token(Token = "0x40005BD")]
		[FieldOffset(Offset = "0x18")]
		private CertificateData certData;
	}
}
