using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003A6 RID: 934
	[Token(Token = "0x20003A6")]
	public class BerOctetStringParser : Asn1OctetStringParser, IAsn1Convertible
	{
		// Token: 0x06001FB2 RID: 8114 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001FB2")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		internal BerOctetStringParser(Asn1StreamParser parser)
		{
		}

		// Token: 0x06001FB3 RID: 8115 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FB3")]
		[Address(RVA = "0x53164C0", Offset = "0x53150C0", VA = "0x1853164C0", Slot = "4")]
		public Stream GetOctetStream()
		{
			return null;
		}

		// Token: 0x06001FB4 RID: 8116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001FB4")]
		[Address(RVA = "0x5316540", Offset = "0x5315140", VA = "0x185316540", Slot = "5")]
		public Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x04001115 RID: 4373
		[Token(Token = "0x4001115")]
		[FieldOffset(Offset = "0x10")]
		private readonly Asn1StreamParser _parser;
	}
}
