using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x020004FB RID: 1275
	[Token(Token = "0x20004FB")]
	[System.Flags]
	public enum FieldAttributes
	{
		// Token: 0x040014C5 RID: 5317
		[Token(Token = "0x40014C5")]
		FieldAccessMask = 7,
		// Token: 0x040014C6 RID: 5318
		[Token(Token = "0x40014C6")]
		PrivateScope = 0,
		// Token: 0x040014C7 RID: 5319
		[Token(Token = "0x40014C7")]
		Private = 1,
		// Token: 0x040014C8 RID: 5320
		[Token(Token = "0x40014C8")]
		FamANDAssem = 2,
		// Token: 0x040014C9 RID: 5321
		[Token(Token = "0x40014C9")]
		Assembly = 3,
		// Token: 0x040014CA RID: 5322
		[Token(Token = "0x40014CA")]
		Family = 4,
		// Token: 0x040014CB RID: 5323
		[Token(Token = "0x40014CB")]
		FamORAssem = 5,
		// Token: 0x040014CC RID: 5324
		[Token(Token = "0x40014CC")]
		Public = 6,
		// Token: 0x040014CD RID: 5325
		[Token(Token = "0x40014CD")]
		Static = 16,
		// Token: 0x040014CE RID: 5326
		[Token(Token = "0x40014CE")]
		InitOnly = 32,
		// Token: 0x040014CF RID: 5327
		[Token(Token = "0x40014CF")]
		Literal = 64,
		// Token: 0x040014D0 RID: 5328
		[Token(Token = "0x40014D0")]
		NotSerialized = 128,
		// Token: 0x040014D1 RID: 5329
		[Token(Token = "0x40014D1")]
		SpecialName = 512,
		// Token: 0x040014D2 RID: 5330
		[Token(Token = "0x40014D2")]
		PinvokeImpl = 8192,
		// Token: 0x040014D3 RID: 5331
		[Token(Token = "0x40014D3")]
		RTSpecialName = 1024,
		// Token: 0x040014D4 RID: 5332
		[Token(Token = "0x40014D4")]
		HasFieldMarshal = 4096,
		// Token: 0x040014D5 RID: 5333
		[Token(Token = "0x40014D5")]
		HasDefault = 32768,
		// Token: 0x040014D6 RID: 5334
		[Token(Token = "0x40014D6")]
		HasFieldRVA = 256,
		// Token: 0x040014D7 RID: 5335
		[Token(Token = "0x40014D7")]
		ReservedMask = 38144
	}
}
