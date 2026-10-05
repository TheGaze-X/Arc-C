using System;
using Il2CppDummyDll;

namespace Internal.Cryptography.Pal
{
	// Token: 0x020000AC RID: 172
	[Token(Token = "0x20000AC")]
	internal enum GeneralNameType
	{
		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		OtherName,
		// Token: 0x040001E8 RID: 488
		[Token(Token = "0x40001E8")]
		Rfc822Name,
		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		Email = 1,
		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		DnsName,
		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		X400Address,
		// Token: 0x040001EC RID: 492
		[Token(Token = "0x40001EC")]
		DirectoryName,
		// Token: 0x040001ED RID: 493
		[Token(Token = "0x40001ED")]
		EdiPartyName,
		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		UniformResourceIdentifier,
		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		IPAddress,
		// Token: 0x040001F0 RID: 496
		[Token(Token = "0x40001F0")]
		RegisteredId
	}
}
