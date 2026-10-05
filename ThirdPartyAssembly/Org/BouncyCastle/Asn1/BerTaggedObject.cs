using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003AE RID: 942
	[Token(Token = "0x20003AE")]
	public class BerTaggedObject : DerTaggedObject
	{
		// Token: 0x06001FD0 RID: 8144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FD0")]
		[Address(RVA = "0x5319460", Offset = "0x5318060", VA = "0x185319460")]
		public BerTaggedObject(int tagNo, Asn1Encodable obj)
		{
		}

		// Token: 0x06001FD1 RID: 8145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FD1")]
		[Address(RVA = "0x5319470", Offset = "0x5318070", VA = "0x185319470")]
		public BerTaggedObject(bool explicitly, int tagNo, Asn1Encodable obj)
		{
		}

		// Token: 0x06001FD2 RID: 8146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FD2")]
		[Address(RVA = "0x5319480", Offset = "0x5318080", VA = "0x185319480")]
		public BerTaggedObject(int tagNo)
		{
		}

		// Token: 0x06001FD3 RID: 8147 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FD3")]
		[Address(RVA = "0x5318E90", Offset = "0x5317A90", VA = "0x185318E90", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}
	}
}
