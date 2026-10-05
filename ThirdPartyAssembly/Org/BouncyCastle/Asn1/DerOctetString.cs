using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003C2 RID: 962
	[Token(Token = "0x20003C2")]
	public class DerOctetString : Asn1OctetString
	{
		// Token: 0x06002098 RID: 8344 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002098")]
		[Address(RVA = "0x53348B0", Offset = "0x53334B0", VA = "0x1853348B0")]
		public DerOctetString(byte[] str)
		{
		}

		// Token: 0x06002099 RID: 8345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002099")]
		[Address(RVA = "0x53348A0", Offset = "0x53334A0", VA = "0x1853348A0")]
		public DerOctetString(Asn1Encodable obj)
		{
		}

		// Token: 0x0600209A RID: 8346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600209A")]
		[Address(RVA = "0x5334740", Offset = "0x5333340", VA = "0x185334740", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x0600209B RID: 8347 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600209B")]
		[Address(RVA = "0x53347F0", Offset = "0x53333F0", VA = "0x1853347F0")]
		internal static void Encode(DerOutputStream derOut, byte[] bytes, int offset, int length)
		{
		}
	}
}
