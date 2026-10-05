using System;
using Il2CppDummyDll;

namespace System
{
	// Token: 0x020000C1 RID: 193
	[Token(Token = "0x20000C1")]
	[Flags]
	public enum UriComponents
	{
		// Token: 0x040002A3 RID: 675
		[Token(Token = "0x40002A3")]
		Scheme = 1,
		// Token: 0x040002A4 RID: 676
		[Token(Token = "0x40002A4")]
		UserInfo = 2,
		// Token: 0x040002A5 RID: 677
		[Token(Token = "0x40002A5")]
		Host = 4,
		// Token: 0x040002A6 RID: 678
		[Token(Token = "0x40002A6")]
		Port = 8,
		// Token: 0x040002A7 RID: 679
		[Token(Token = "0x40002A7")]
		Path = 16,
		// Token: 0x040002A8 RID: 680
		[Token(Token = "0x40002A8")]
		Query = 32,
		// Token: 0x040002A9 RID: 681
		[Token(Token = "0x40002A9")]
		Fragment = 64,
		// Token: 0x040002AA RID: 682
		[Token(Token = "0x40002AA")]
		StrongPort = 128,
		// Token: 0x040002AB RID: 683
		[Token(Token = "0x40002AB")]
		NormalizedHost = 256,
		// Token: 0x040002AC RID: 684
		[Token(Token = "0x40002AC")]
		KeepDelimiter = 1073741824,
		// Token: 0x040002AD RID: 685
		[Token(Token = "0x40002AD")]
		SerializationInfoString = -2147483648,
		// Token: 0x040002AE RID: 686
		[Token(Token = "0x40002AE")]
		AbsoluteUri = 127,
		// Token: 0x040002AF RID: 687
		[Token(Token = "0x40002AF")]
		HostAndPort = 132,
		// Token: 0x040002B0 RID: 688
		[Token(Token = "0x40002B0")]
		StrongAuthority = 134,
		// Token: 0x040002B1 RID: 689
		[Token(Token = "0x40002B1")]
		SchemeAndServer = 13,
		// Token: 0x040002B2 RID: 690
		[Token(Token = "0x40002B2")]
		HttpRequestUrl = 61,
		// Token: 0x040002B3 RID: 691
		[Token(Token = "0x40002B3")]
		PathAndQuery = 48
	}
}
