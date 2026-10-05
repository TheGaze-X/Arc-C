using System;
using System.Collections;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003A5 RID: 933
	[Token(Token = "0x20003A5")]
	public class BerOctetString : DerOctetString, IEnumerable
	{
		// Token: 0x06001FA7 RID: 8103 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA7")]
		[Address(RVA = "0x5316B10", Offset = "0x5315710", VA = "0x185316B10")]
		public static BerOctetString FromSequence(Asn1Sequence seq)
		{
			return null;
		}

		// Token: 0x06001FA8 RID: 8104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FA8")]
		[Address(RVA = "0x5317190", Offset = "0x5315D90", VA = "0x185317190")]
		private static byte[] ToBytes(IEnumerable octs)
		{
			return null;
		}

		// Token: 0x06001FA9 RID: 8105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FA9")]
		[Address(RVA = "0x53175B0", Offset = "0x53161B0", VA = "0x1853175B0")]
		public BerOctetString(byte[] str)
		{
		}

		// Token: 0x06001FAA RID: 8106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FAA")]
		[Address(RVA = "0x5317560", Offset = "0x5316160", VA = "0x185317560")]
		public BerOctetString(IEnumerable octets)
		{
		}

		// Token: 0x06001FAB RID: 8107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FAB")]
		[Address(RVA = "0x5317550", Offset = "0x5316150", VA = "0x185317550")]
		public BerOctetString(Asn1Object obj)
		{
		}

		// Token: 0x06001FAC RID: 8108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FAC")]
		[Address(RVA = "0x53175C0", Offset = "0x53161C0", VA = "0x1853175C0")]
		public BerOctetString(Asn1Encodable obj)
		{
		}

		// Token: 0x06001FAD RID: 8109 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FAD")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "10")]
		public override byte[] GetOctets()
		{
			return null;
		}

		// Token: 0x06001FAE RID: 8110 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FAE")]
		[Address(RVA = "0x53170C0", Offset = "0x5315CC0", VA = "0x1853170C0", Slot = "11")]
		public IEnumerator GetEnumerator()
		{
			return null;
		}

		// Token: 0x06001FAF RID: 8111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FAF")]
		[Address(RVA = "0x5317130", Offset = "0x5315D30", VA = "0x185317130")]
		[Obsolete("Use GetEnumerator() instead")]
		public IEnumerator GetObjects()
		{
			return null;
		}

		// Token: 0x06001FB0 RID: 8112 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FB0")]
		[Address(RVA = "0x5316EB0", Offset = "0x5315AB0", VA = "0x185316EB0")]
		private IList GenerateOcts()
		{
			return null;
		}

		// Token: 0x06001FB1 RID: 8113 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB1")]
		[Address(RVA = "0x53166B0", Offset = "0x53152B0", VA = "0x1853166B0", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x04001113 RID: 4371
		[Token(Token = "0x4001113")]
		private const int MaxLength = 1000;

		// Token: 0x04001114 RID: 4372
		[Token(Token = "0x4001114")]
		[FieldOffset(Offset = "0x18")]
		private readonly IEnumerable octs;
	}
}
