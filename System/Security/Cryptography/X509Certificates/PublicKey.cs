using System;
using Il2CppDummyDll;

namespace System.Security.Cryptography.X509Certificates
{
	// Token: 0x02000136 RID: 310
	[Token(Token = "0x2000136")]
	public sealed class PublicKey
	{
		// Token: 0x06000753 RID: 1875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000753")]
		[Address(RVA = "0x5125350", Offset = "0x5123F50", VA = "0x185125350")]
		public PublicKey(Oid oid, AsnEncodedData parameters, AsnEncodedData keyValue)
		{
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000147")]
		public AsnEncodedData EncodedKeyValue
		{
			[Token(Token = "0x6000754")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000755 RID: 1877 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000148")]
		public AsnEncodedData EncodedParameters
		{
			[Token(Token = "0x6000755")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000756 RID: 1878 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000149")]
		public AsymmetricAlgorithm Key
		{
			[Token(Token = "0x6000756")]
			[Address(RVA = "0x51255A0", Offset = "0x51241A0", VA = "0x1851255A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x06000757 RID: 1879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700014A")]
		public Oid Oid
		{
			[Token(Token = "0x6000757")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000758")]
		[Address(RVA = "0x5125240", Offset = "0x5123E40", VA = "0x185125240")]
		private static byte[] GetUnsignedBigInteger(byte[] integer)
		{
			return null;
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000759")]
		[Address(RVA = "0x51249A0", Offset = "0x51235A0", VA = "0x1851249A0")]
		internal static DSA DecodeDSA(byte[] rawPublicKey, byte[] rawParameters)
		{
			return null;
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600075A")]
		[Address(RVA = "0x5124EC0", Offset = "0x5123AC0", VA = "0x185124EC0")]
		internal static RSA DecodeRSA(byte[] rawPublicKey)
		{
			return null;
		}

		// Token: 0x040005A2 RID: 1442
		[Token(Token = "0x40005A2")]
		[FieldOffset(Offset = "0x10")]
		private AsnEncodedData _keyValue;

		// Token: 0x040005A3 RID: 1443
		[Token(Token = "0x40005A3")]
		[FieldOffset(Offset = "0x18")]
		private AsnEncodedData _params;

		// Token: 0x040005A4 RID: 1444
		[Token(Token = "0x40005A4")]
		[FieldOffset(Offset = "0x20")]
		private Oid _oid;

		// Token: 0x040005A5 RID: 1445
		[Token(Token = "0x40005A5")]
		[FieldOffset(Offset = "0x0")]
		private static byte[] Empty;
	}
}
