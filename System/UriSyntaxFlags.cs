using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000CD RID: 205
	[Token(Token = "0x20000CD")]
	[Flags]
	internal enum UriSyntaxFlags
	{
		// Token: 0x04000308 RID: 776
		[Token(Token = "0x4000308")]
		None = 0,
		// Token: 0x04000309 RID: 777
		[Token(Token = "0x4000309")]
		MustHaveAuthority = 1,
		// Token: 0x0400030A RID: 778
		[Token(Token = "0x400030A")]
		OptionalAuthority = 2,
		// Token: 0x0400030B RID: 779
		[Token(Token = "0x400030B")]
		MayHaveUserInfo = 4,
		// Token: 0x0400030C RID: 780
		[Token(Token = "0x400030C")]
		MayHavePort = 8,
		// Token: 0x0400030D RID: 781
		[Token(Token = "0x400030D")]
		MayHavePath = 16,
		// Token: 0x0400030E RID: 782
		[Token(Token = "0x400030E")]
		MayHaveQuery = 32,
		// Token: 0x0400030F RID: 783
		[Token(Token = "0x400030F")]
		MayHaveFragment = 64,
		// Token: 0x04000310 RID: 784
		[Token(Token = "0x4000310")]
		AllowEmptyHost = 128,
		// Token: 0x04000311 RID: 785
		[Token(Token = "0x4000311")]
		AllowUncHost = 256,
		// Token: 0x04000312 RID: 786
		[Token(Token = "0x4000312")]
		AllowDnsHost = 512,
		// Token: 0x04000313 RID: 787
		[Token(Token = "0x4000313")]
		AllowIPv4Host = 1024,
		// Token: 0x04000314 RID: 788
		[Token(Token = "0x4000314")]
		AllowIPv6Host = 2048,
		// Token: 0x04000315 RID: 789
		[Token(Token = "0x4000315")]
		AllowAnInternetHost = 3584,
		// Token: 0x04000316 RID: 790
		[Token(Token = "0x4000316")]
		AllowAnyOtherHost = 4096,
		// Token: 0x04000317 RID: 791
		[Token(Token = "0x4000317")]
		FileLikeUri = 8192,
		// Token: 0x04000318 RID: 792
		[Token(Token = "0x4000318")]
		MailToLikeUri = 16384,
		// Token: 0x04000319 RID: 793
		[Token(Token = "0x4000319")]
		V1_UnknownUri = 65536,
		// Token: 0x0400031A RID: 794
		[Token(Token = "0x400031A")]
		SimpleUserSyntax = 131072,
		// Token: 0x0400031B RID: 795
		[Token(Token = "0x400031B")]
		BuiltInSyntax = 262144,
		// Token: 0x0400031C RID: 796
		[Token(Token = "0x400031C")]
		ParserSchemeOnly = 524288,
		// Token: 0x0400031D RID: 797
		[Token(Token = "0x400031D")]
		AllowDOSPath = 1048576,
		// Token: 0x0400031E RID: 798
		[Token(Token = "0x400031E")]
		PathIsRooted = 2097152,
		// Token: 0x0400031F RID: 799
		[Token(Token = "0x400031F")]
		ConvertPathSlashes = 4194304,
		// Token: 0x04000320 RID: 800
		[Token(Token = "0x4000320")]
		CompressPath = 8388608,
		// Token: 0x04000321 RID: 801
		[Token(Token = "0x4000321")]
		CanonicalizeAsFilePath = 16777216,
		// Token: 0x04000322 RID: 802
		[Token(Token = "0x4000322")]
		UnEscapeDotsAndSlashes = 33554432,
		// Token: 0x04000323 RID: 803
		[Token(Token = "0x4000323")]
		AllowIdn = 67108864,
		// Token: 0x04000324 RID: 804
		[Token(Token = "0x4000324")]
		AllowIriParsing = 268435456
	}
}
