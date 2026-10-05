using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003A2 RID: 930
	[Token(Token = "0x20003A2")]
	public class BerApplicationSpecificParser : IAsn1ApplicationSpecificParser, IAsn1Convertible
	{
		// Token: 0x06001F96 RID: 8086 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001F96")]
		[Address(RVA = "0x3437250", Offset = "0x3435E50", VA = "0x183437250")]
		internal BerApplicationSpecificParser(int tag, Asn1StreamParser parser)
		{
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F97")]
		[Address(RVA = "0x94E1F0", Offset = "0x94CDF0", VA = "0x18094E1F0", Slot = "4")]
		public IAsn1Convertible ReadObject()
		{
			return null;
		}

		// Token: 0x06001F98 RID: 8088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F98")]
		[Address(RVA = "0x5315B90", Offset = "0x5314790", VA = "0x185315B90", Slot = "5")]
		public Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x0400110E RID: 4366
		[Token(Token = "0x400110E")]
		[FieldOffset(Offset = "0x10")]
		private readonly int tag;

		// Token: 0x0400110F RID: 4367
		[Token(Token = "0x400110F")]
		[FieldOffset(Offset = "0x18")]
		private readonly Asn1StreamParser parser;
	}
}
