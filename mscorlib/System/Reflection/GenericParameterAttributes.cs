using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x020004FD RID: 1277
	[Token(Token = "0x20004FD")]
	[System.Flags]
	public enum GenericParameterAttributes
	{
		// Token: 0x040014D9 RID: 5337
		[Token(Token = "0x40014D9")]
		None = 0,
		// Token: 0x040014DA RID: 5338
		[Token(Token = "0x40014DA")]
		VarianceMask = 3,
		// Token: 0x040014DB RID: 5339
		[Token(Token = "0x40014DB")]
		Covariant = 1,
		// Token: 0x040014DC RID: 5340
		[Token(Token = "0x40014DC")]
		Contravariant = 2,
		// Token: 0x040014DD RID: 5341
		[Token(Token = "0x40014DD")]
		SpecialConstraintMask = 28,
		// Token: 0x040014DE RID: 5342
		[Token(Token = "0x40014DE")]
		ReferenceTypeConstraint = 4,
		// Token: 0x040014DF RID: 5343
		[Token(Token = "0x40014DF")]
		NotNullableValueTypeConstraint = 8,
		// Token: 0x040014E0 RID: 5344
		[Token(Token = "0x40014E0")]
		DefaultConstructorConstraint = 16
	}
}
