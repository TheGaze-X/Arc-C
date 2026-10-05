using System;
using Il2CppDummyDll;

namespace System.Reflection
{
	// Token: 0x02000506 RID: 1286
	[Token(Token = "0x2000506")]
	[System.Flags]
	public enum MethodAttributes
	{
		// Token: 0x040014EF RID: 5359
		[Token(Token = "0x40014EF")]
		MemberAccessMask = 7,
		// Token: 0x040014F0 RID: 5360
		[Token(Token = "0x40014F0")]
		PrivateScope = 0,
		// Token: 0x040014F1 RID: 5361
		[Token(Token = "0x40014F1")]
		Private = 1,
		// Token: 0x040014F2 RID: 5362
		[Token(Token = "0x40014F2")]
		FamANDAssem = 2,
		// Token: 0x040014F3 RID: 5363
		[Token(Token = "0x40014F3")]
		Assembly = 3,
		// Token: 0x040014F4 RID: 5364
		[Token(Token = "0x40014F4")]
		Family = 4,
		// Token: 0x040014F5 RID: 5365
		[Token(Token = "0x40014F5")]
		FamORAssem = 5,
		// Token: 0x040014F6 RID: 5366
		[Token(Token = "0x40014F6")]
		Public = 6,
		// Token: 0x040014F7 RID: 5367
		[Token(Token = "0x40014F7")]
		Static = 16,
		// Token: 0x040014F8 RID: 5368
		[Token(Token = "0x40014F8")]
		Final = 32,
		// Token: 0x040014F9 RID: 5369
		[Token(Token = "0x40014F9")]
		Virtual = 64,
		// Token: 0x040014FA RID: 5370
		[Token(Token = "0x40014FA")]
		HideBySig = 128,
		// Token: 0x040014FB RID: 5371
		[Token(Token = "0x40014FB")]
		CheckAccessOnOverride = 512,
		// Token: 0x040014FC RID: 5372
		[Token(Token = "0x40014FC")]
		VtableLayoutMask = 256,
		// Token: 0x040014FD RID: 5373
		[Token(Token = "0x40014FD")]
		ReuseSlot = 0,
		// Token: 0x040014FE RID: 5374
		[Token(Token = "0x40014FE")]
		NewSlot = 256,
		// Token: 0x040014FF RID: 5375
		[Token(Token = "0x40014FF")]
		Abstract = 1024,
		// Token: 0x04001500 RID: 5376
		[Token(Token = "0x4001500")]
		SpecialName = 2048,
		// Token: 0x04001501 RID: 5377
		[Token(Token = "0x4001501")]
		PinvokeImpl = 8192,
		// Token: 0x04001502 RID: 5378
		[Token(Token = "0x4001502")]
		UnmanagedExport = 8,
		// Token: 0x04001503 RID: 5379
		[Token(Token = "0x4001503")]
		RTSpecialName = 4096,
		// Token: 0x04001504 RID: 5380
		[Token(Token = "0x4001504")]
		HasSecurity = 16384,
		// Token: 0x04001505 RID: 5381
		[Token(Token = "0x4001505")]
		RequireSecObject = 32768,
		// Token: 0x04001506 RID: 5382
		[Token(Token = "0x4001506")]
		ReservedMask = 53248
	}
}
