using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.Field
{
	// Token: 0x0200017A RID: 378
	[Token(Token = "0x200017A")]
	public interface IPolynomialExtensionField : IExtensionField, IFiniteField
	{
		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000A31 RID: 2609
		[Token(Token = "0x170000EE")]
		IPolynomial MinimalPolynomial { [Token(Token = "0x6000A31")] get; }
	}
}
