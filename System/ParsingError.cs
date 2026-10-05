using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000C4 RID: 196
	[Token(Token = "0x20000C4")]
	internal enum ParsingError
	{
		// Token: 0x040002BD RID: 701
		[Token(Token = "0x40002BD")]
		None,
		// Token: 0x040002BE RID: 702
		[Token(Token = "0x40002BE")]
		BadFormat,
		// Token: 0x040002BF RID: 703
		[Token(Token = "0x40002BF")]
		BadScheme,
		// Token: 0x040002C0 RID: 704
		[Token(Token = "0x40002C0")]
		BadAuthority,
		// Token: 0x040002C1 RID: 705
		[Token(Token = "0x40002C1")]
		EmptyUriString,
		// Token: 0x040002C2 RID: 706
		[Token(Token = "0x40002C2")]
		LastRelativeUriOkErrIndex = 4,
		// Token: 0x040002C3 RID: 707
		[Token(Token = "0x40002C3")]
		SchemeLimit,
		// Token: 0x040002C4 RID: 708
		[Token(Token = "0x40002C4")]
		SizeLimit,
		// Token: 0x040002C5 RID: 709
		[Token(Token = "0x40002C5")]
		MustRootedPath,
		// Token: 0x040002C6 RID: 710
		[Token(Token = "0x40002C6")]
		BadHostName,
		// Token: 0x040002C7 RID: 711
		[Token(Token = "0x40002C7")]
		NonEmptyHost,
		// Token: 0x040002C8 RID: 712
		[Token(Token = "0x40002C8")]
		BadPort,
		// Token: 0x040002C9 RID: 713
		[Token(Token = "0x40002C9")]
		BadAuthorityTerminator,
		// Token: 0x040002CA RID: 714
		[Token(Token = "0x40002CA")]
		CannotCreateRelative
	}
}
