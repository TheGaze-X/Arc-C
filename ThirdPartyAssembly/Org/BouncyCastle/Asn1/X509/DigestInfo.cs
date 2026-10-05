using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000408 RID: 1032
	[Token(Token = "0x2000408")]
	public class DigestInfo : Asn1Encodable
	{
		// Token: 0x06002203 RID: 8707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002203")]
		[Address(RVA = "0x533A510", Offset = "0x5339110", VA = "0x18533A510")]
		public static DigestInfo GetInstance(Asn1TaggedObject obj, bool explicitly)
		{
			return null;
		}

		// Token: 0x06002204 RID: 8708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002204")]
		[Address(RVA = "0x533A270", Offset = "0x5338E70", VA = "0x18533A270")]
		public static DigestInfo GetInstance(object obj)
		{
			return null;
		}

		// Token: 0x06002205 RID: 8709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002205")]
		[Address(RVA = "0x533A840", Offset = "0x5339440", VA = "0x18533A840")]
		public DigestInfo(AlgorithmIdentifier algID, byte[] digest)
		{
		}

		// Token: 0x06002206 RID: 8710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002206")]
		[Address(RVA = "0x533A6C0", Offset = "0x53392C0", VA = "0x18533A6C0")]
		private DigestInfo(Asn1Sequence seq)
		{
		}

		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06002207 RID: 8711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000465")]
		public AlgorithmIdentifier AlgorithmID
		{
			[Token(Token = "0x6002207")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002208 RID: 8712 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002208")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
		public byte[] GetDigest()
		{
			return null;
		}

		// Token: 0x06002209 RID: 8713 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002209")]
		[Address(RVA = "0x533A530", Offset = "0x5339130", VA = "0x18533A530", Slot = "5")]
		public override Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x040011E2 RID: 4578
		[Token(Token = "0x40011E2")]
		[FieldOffset(Offset = "0x10")]
		private readonly byte[] digest;

		// Token: 0x040011E3 RID: 4579
		[Token(Token = "0x40011E3")]
		[FieldOffset(Offset = "0x18")]
		private readonly AlgorithmIdentifier algID;
	}
}
