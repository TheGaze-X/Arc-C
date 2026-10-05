using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000138 RID: 312
	[Token(Token = "0x2000138")]
	public sealed class X509BasicConstraintsExtension : X509Extension
	{
		// Token: 0x06000766 RID: 1894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000766")]
		[Address(RVA = "0x51271E0", Offset = "0x5125DE0", VA = "0x1851271E0")]
		public X509BasicConstraintsExtension()
		{
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000767")]
		[Address(RVA = "0x51272B0", Offset = "0x5125EB0", VA = "0x1851272B0")]
		public X509BasicConstraintsExtension(AsnEncodedData encodedBasicConstraints, bool critical)
		{
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000768")]
		[Address(RVA = "0x5126F40", Offset = "0x5125B40", VA = "0x185126F40")]
		public X509BasicConstraintsExtension(bool certificateAuthority, bool hasPathLengthConstraint, int pathLengthConstraint, bool critical)
		{
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x00004DE8 File Offset: 0x00002FE8
		[Token(Token = "0x1700014C")]
		public bool CertificateAuthority
		{
			[Token(Token = "0x6000769")]
			[Address(RVA = "0x51273C0", Offset = "0x5125FC0", VA = "0x1851273C0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x0600076A RID: 1898 RVA: 0x00004E00 File Offset: 0x00003000
		[Token(Token = "0x1700014D")]
		public bool HasPathLengthConstraint
		{
			[Token(Token = "0x600076A")]
			[Address(RVA = "0x5127440", Offset = "0x5126040", VA = "0x185127440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x0600076B RID: 1899 RVA: 0x00004E18 File Offset: 0x00003018
		[Token(Token = "0x1700014E")]
		public int PathLengthConstraint
		{
			[Token(Token = "0x600076B")]
			[Address(RVA = "0x51274C0", Offset = "0x51260C0", VA = "0x1851274C0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600076C")]
		[Address(RVA = "0x5126790", Offset = "0x5125390", VA = "0x185126790", Slot = "4")]
		public override void CopyFrom(AsnEncodedData asnEncodedData)
		{
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x00004E30 File Offset: 0x00003030
		[Token(Token = "0x600076D")]
		[Address(RVA = "0x5126A00", Offset = "0x5125600", VA = "0x185126A00")]
		internal AsnDecodeStatus Decode(byte[] extension)
		{
			return AsnDecodeStatus.Ok;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600076E")]
		[Address(RVA = "0x5126B60", Offset = "0x5125760", VA = "0x185126B60")]
		internal byte[] Encode()
		{
			return null;
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600076F")]
		[Address(RVA = "0x5126CE0", Offset = "0x51258E0", VA = "0x185126CE0", Slot = "6")]
		internal override string ToString(bool multiLine)
		{
			return null;
		}

		// Token: 0x040005A8 RID: 1448
		[Token(Token = "0x40005A8")]
		internal const string oid = "2.5.29.19";

		// Token: 0x040005A9 RID: 1449
		[Token(Token = "0x40005A9")]
		internal const string friendlyName = "Basic Constraints";

		// Token: 0x040005AA RID: 1450
		[Token(Token = "0x40005AA")]
		[FieldOffset(Offset = "0x28")]
		private bool _certificateAuthority;

		// Token: 0x040005AB RID: 1451
		[Token(Token = "0x40005AB")]
		[FieldOffset(Offset = "0x29")]
		private bool _hasPathLengthConstraint;

		// Token: 0x040005AC RID: 1452
		[Token(Token = "0x40005AC")]
		[FieldOffset(Offset = "0x2C")]
		private int _pathLengthConstraint;

		// Token: 0x040005AD RID: 1453
		[Token(Token = "0x40005AD")]
		[FieldOffset(Offset = "0x30")]
		private AsnDecodeStatus _status;
	}
}
