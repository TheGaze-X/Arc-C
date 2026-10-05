using System;
using Il2CppDummyDll;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Utilities.Collections;

namespace Org.BouncyCastle.X509
{
	// Token: 0x02000119 RID: 281
	[Token(Token = "0x2000119")]
	public interface IX509Extension
	{
		// Token: 0x060005DA RID: 1498
		[Token(Token = "0x60005DA")]
		ISet GetCriticalExtensionOids();

		// Token: 0x060005DB RID: 1499
		[Token(Token = "0x60005DB")]
		ISet GetNonCriticalExtensionOids();

		// Token: 0x060005DC RID: 1500
		[Token(Token = "0x60005DC")]
		[Obsolete("Use version taking a DerObjectIdentifier instead")]
		Asn1OctetString GetExtensionValue(string oid);

		// Token: 0x060005DD RID: 1501
		[Token(Token = "0x60005DD")]
		Asn1OctetString GetExtensionValue(DerObjectIdentifier oid);
	}
}
