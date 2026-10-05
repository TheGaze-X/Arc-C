using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000151 RID: 337
	[Token(Token = "0x2000151")]
	public sealed class X509SubjectKeyIdentifierExtension : X509Extension
	{
		// Token: 0x0600087D RID: 2173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600087D")]
		[Address(RVA = "0x5139440", Offset = "0x5138040", VA = "0x185139440")]
		public X509SubjectKeyIdentifierExtension()
		{
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600087E")]
		[Address(RVA = "0x5138E00", Offset = "0x5137A00", VA = "0x185138E00")]
		public X509SubjectKeyIdentifierExtension(AsnEncodedData encodedSubjectKeyIdentifier, bool critical)
		{
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600087F")]
		[Address(RVA = "0x5138F10", Offset = "0x5137B10", VA = "0x185138F10")]
		public X509SubjectKeyIdentifierExtension(byte[] subjectKeyIdentifier, bool critical)
		{
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000880")]
		[Address(RVA = "0x5139150", Offset = "0x5137D50", VA = "0x185139150")]
		public X509SubjectKeyIdentifierExtension(string subjectKeyIdentifier, bool critical)
		{
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000881")]
		[Address(RVA = "0x5138DE0", Offset = "0x51379E0", VA = "0x185138DE0")]
		public X509SubjectKeyIdentifierExtension(PublicKey key, bool critical)
		{
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000882")]
		[Address(RVA = "0x5138970", Offset = "0x5137570", VA = "0x185138970")]
		public X509SubjectKeyIdentifierExtension(PublicKey key, X509SubjectKeyIdentifierHashAlgorithm algorithm, bool critical)
		{
		}

		// Token: 0x170001AC RID: 428
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001AC")]
		public string SubjectKeyIdentifier
		{
			[Token(Token = "0x6000883")]
			[Address(RVA = "0x5139510", Offset = "0x5138110", VA = "0x185139510")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000884")]
		[Address(RVA = "0x51380A0", Offset = "0x5136CA0", VA = "0x1851380A0", Slot = "4")]
		public override void CopyFrom(AsnEncodedData asnEncodedData)
		{
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x00005340 File Offset: 0x00003540
		[Token(Token = "0x6000885")]
		[Address(RVA = "0x51384F0", Offset = "0x51370F0", VA = "0x1851384F0")]
		internal static byte FromHexChar(char c)
		{
			return 0;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x00005358 File Offset: 0x00003558
		[Token(Token = "0x6000886")]
		[Address(RVA = "0x5138520", Offset = "0x5137120", VA = "0x185138520")]
		internal static byte FromHexChars(char c1, char c2)
		{
			return 0;
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000887")]
		[Address(RVA = "0x51385A0", Offset = "0x51371A0", VA = "0x1851385A0")]
		internal static byte[] FromHex(string hex)
		{
			return null;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00005370 File Offset: 0x00003570
		[Token(Token = "0x6000888")]
		[Address(RVA = "0x5138310", Offset = "0x5136F10", VA = "0x185138310")]
		internal AsnDecodeStatus Decode(byte[] extension)
		{
			return AsnDecodeStatus.Ok;
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000889")]
		[Address(RVA = "0x5138460", Offset = "0x5137060", VA = "0x185138460")]
		internal byte[] Encode()
		{
			return null;
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600088A")]
		[Address(RVA = "0x5138720", Offset = "0x5137320", VA = "0x185138720", Slot = "6")]
		internal override string ToString(bool multiLine)
		{
			return null;
		}

		// Token: 0x040005F2 RID: 1522
		[Token(Token = "0x40005F2")]
		internal const string oid = "2.5.29.14";

		// Token: 0x040005F3 RID: 1523
		[Token(Token = "0x40005F3")]
		internal const string friendlyName = "Subject Key Identifier";

		// Token: 0x040005F4 RID: 1524
		[Token(Token = "0x40005F4")]
		[FieldOffset(Offset = "0x28")]
		private byte[] _subjectKeyIdentifier;

		// Token: 0x040005F5 RID: 1525
		[Token(Token = "0x40005F5")]
		[FieldOffset(Offset = "0x30")]
		private string _ski;

		// Token: 0x040005F6 RID: 1526
		[Token(Token = "0x40005F6")]
		[FieldOffset(Offset = "0x38")]
		private AsnDecodeStatus _status;
	}
}
