using System;
using Il2CppDummyDll;

namespace Mono.Btls
{
	// Token: 0x020000A1 RID: 161
	[Token(Token = "0x20000A1")]
	internal enum MonoBtlsX509StoreType
	{
		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		Custom,
		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		MachineTrustedRoots,
		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		MachineIntermediateCA,
		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		MachineUntrusted,
		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		UserTrustedRoots,
		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		UserIntermediateCA,
		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		UserUntrusted
	}
}
