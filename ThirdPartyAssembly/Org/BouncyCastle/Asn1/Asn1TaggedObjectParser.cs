using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Asn1
{
	// Token: 0x0200039F RID: 927
	[Token(Token = "0x200039F")]
	public interface Asn1TaggedObjectParser : IAsn1Convertible
	{
		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001F92 RID: 8082
		[Token(Token = "0x17000423")]
		int TagNo { [Token(Token = "0x6001F92")] get; }

		// Token: 0x06001F93 RID: 8083
		[Token(Token = "0x6001F93")]
		IAsn1Convertible GetObjectParser(int tag, bool isExplicit);
	}
}
