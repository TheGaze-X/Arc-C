using System;
using Il2CppDummyDll;

namespace Mono.Security
{
	// Token: 0x02000004 RID: 4
	[Token(Token = "0x2000004")]
	public static class ASN1Convert
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000014")]
		[Address(RVA = "0x4A73F40", Offset = "0x4A72B40", VA = "0x184A73F40")]
		public static ASN1 FromInt32(int value)
		{
			return null;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000015")]
		[Address(RVA = "0x4A74340", Offset = "0x4A72F40", VA = "0x184A74340")]
		public static ASN1 FromOid(string oid)
		{
			return null;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000016")]
		[Address(RVA = "0x4A74430", Offset = "0x4A73030", VA = "0x184A74430")]
		public static ASN1 FromUnsignedBigInteger(byte[] big)
		{
			return null;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000020D0 File Offset: 0x000002D0
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x4A74B80", Offset = "0x4A73780", VA = "0x184A74B80")]
		public static int ToInt32(ASN1 asn1)
		{
			return 0;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x4A74CC0", Offset = "0x4A738C0", VA = "0x184A74CC0")]
		public static string ToOid(ASN1 asn1)
		{
			return null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000020E8 File Offset: 0x000002E8
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x4A74560", Offset = "0x4A73160", VA = "0x184A74560")]
		public static DateTime ToDateTime(ASN1 time)
		{
			return default(DateTime);
		}
	}
}
