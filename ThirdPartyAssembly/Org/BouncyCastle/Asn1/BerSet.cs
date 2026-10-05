using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003AB RID: 939
	[Token(Token = "0x20003AB")]
	public class BerSet : DerSet
	{
		// Token: 0x06001FC3 RID: 8131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC3")]
		[Address(RVA = "0x5318790", Offset = "0x5317390", VA = "0x185318790")]
		public new static BerSet FromVector(Asn1EncodableVector v)
		{
			return null;
		}

		// Token: 0x06001FC4 RID: 8132 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FC4")]
		[Address(RVA = "0x53188A0", Offset = "0x53174A0", VA = "0x1853188A0")]
		internal new static BerSet FromVector(Asn1EncodableVector v, bool needsSorting)
		{
			return null;
		}

		// Token: 0x06001FC5 RID: 8133 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC5")]
		[Address(RVA = "0x5318A80", Offset = "0x5317680", VA = "0x185318A80")]
		public BerSet()
		{
		}

		// Token: 0x06001FC6 RID: 8134 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC6")]
		[Address(RVA = "0x5318B30", Offset = "0x5317730", VA = "0x185318B30")]
		public BerSet(Asn1Encodable obj)
		{
		}

		// Token: 0x06001FC7 RID: 8135 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC7")]
		[Address(RVA = "0x5318AD0", Offset = "0x53176D0", VA = "0x185318AD0")]
		public BerSet(Asn1EncodableVector v)
		{
		}

		// Token: 0x06001FC8 RID: 8136 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC8")]
		[Address(RVA = "0x5318B90", Offset = "0x5317790", VA = "0x185318B90")]
		internal BerSet(Asn1EncodableVector v, bool needsSorting)
		{
		}

		// Token: 0x06001FC9 RID: 8137 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FC9")]
		[Address(RVA = "0x5318360", Offset = "0x5316F60", VA = "0x185318360", Slot = "6")]
		internal override void Encode(DerOutputStream derOut)
		{
		}

		// Token: 0x04001118 RID: 4376
		[Token(Token = "0x4001118")]
		[FieldOffset(Offset = "0x0")]
		public new static readonly BerSet Empty;
	}
}
