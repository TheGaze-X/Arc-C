using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020001C9 RID: 457
	[Token(Token = "0x20001C9")]
	internal interface TypeIdentifier : TypeName, System.IEquatable<TypeName>
	{
		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060010AE RID: 4270
		[Token(Token = "0x1700017F")]
		string InternalName { [Token(Token = "0x60010AE")] get; }
	}
}
