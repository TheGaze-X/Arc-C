using System;
using System.IO;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x020003C3 RID: 963
	[Token(Token = "0x20003C3")]
	public class DerOctetStringParser : Asn1OctetStringParser, IAsn1Convertible
	{
		// Token: 0x0600209C RID: 8348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600209C")]
		[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
		internal DerOctetStringParser(DefiniteLengthInputStream stream)
		{
		}

		// Token: 0x0600209D RID: 8349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209D")]
		[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0", Slot = "4")]
		public Stream GetOctetStream()
		{
			return null;
		}

		// Token: 0x0600209E RID: 8350 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600209E")]
		[Address(RVA = "0x5334620", Offset = "0x5333220", VA = "0x185334620", Slot = "5")]
		public Asn1Object ToAsn1Object()
		{
			return null;
		}

		// Token: 0x04001144 RID: 4420
		[Token(Token = "0x4001144")]
		[FieldOffset(Offset = "0x10")]
		private readonly DefiniteLengthInputStream stream;
	}
}
