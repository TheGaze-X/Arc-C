using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000505 RID: 1285
	[Token(Token = "0x2000505")]
	[System.Flags]
	public enum MemberTypes
	{
		// Token: 0x040014E5 RID: 5349
		[Token(Token = "0x40014E5")]
		Constructor = 1,
		// Token: 0x040014E6 RID: 5350
		[Token(Token = "0x40014E6")]
		Event = 2,
		// Token: 0x040014E7 RID: 5351
		[Token(Token = "0x40014E7")]
		Field = 4,
		// Token: 0x040014E8 RID: 5352
		[Token(Token = "0x40014E8")]
		Method = 8,
		// Token: 0x040014E9 RID: 5353
		[Token(Token = "0x40014E9")]
		Property = 16,
		// Token: 0x040014EA RID: 5354
		[Token(Token = "0x40014EA")]
		TypeInfo = 32,
		// Token: 0x040014EB RID: 5355
		[Token(Token = "0x40014EB")]
		Custom = 64,
		// Token: 0x040014EC RID: 5356
		[Token(Token = "0x40014EC")]
		NestedType = 128,
		// Token: 0x040014ED RID: 5357
		[Token(Token = "0x40014ED")]
		All = 191
	}
}
