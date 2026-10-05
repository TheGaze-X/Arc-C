using System;
using Il2CppDummyDll;

namespace Org.BouncyCastle.Math.Field
{
	// Token: 0x02000177 RID: 375
	[Token(Token = "0x2000177")]
	public interface IExtensionField : IFiniteField
	{
		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000A2B RID: 2603
		[Token(Token = "0x170000E9")]
		IFiniteField Subfield { [Token(Token = "0x6000A2B")] get; }

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000A2C RID: 2604
		[Token(Token = "0x170000EA")]
		int Degree { [Token(Token = "0x6000A2C")] get; }
	}
}
