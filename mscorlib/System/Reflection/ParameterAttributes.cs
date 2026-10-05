using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x0200050C RID: 1292
	[Token(Token = "0x200050C")]
	[System.Flags]
	public enum ParameterAttributes
	{
		// Token: 0x0400151E RID: 5406
		[Token(Token = "0x400151E")]
		None = 0,
		// Token: 0x0400151F RID: 5407
		[Token(Token = "0x400151F")]
		In = 1,
		// Token: 0x04001520 RID: 5408
		[Token(Token = "0x4001520")]
		Out = 2,
		// Token: 0x04001521 RID: 5409
		[Token(Token = "0x4001521")]
		Lcid = 4,
		// Token: 0x04001522 RID: 5410
		[Token(Token = "0x4001522")]
		Retval = 8,
		// Token: 0x04001523 RID: 5411
		[Token(Token = "0x4001523")]
		Optional = 16,
		// Token: 0x04001524 RID: 5412
		[Token(Token = "0x4001524")]
		HasDefault = 4096,
		// Token: 0x04001525 RID: 5413
		[Token(Token = "0x4001525")]
		HasFieldMarshal = 8192,
		// Token: 0x04001526 RID: 5414
		[Token(Token = "0x4001526")]
		Reserved3 = 16384,
		// Token: 0x04001527 RID: 5415
		[Token(Token = "0x4001527")]
		Reserved4 = 32768,
		// Token: 0x04001528 RID: 5416
		[Token(Token = "0x4001528")]
		ReservedMask = 61440
	}
}
