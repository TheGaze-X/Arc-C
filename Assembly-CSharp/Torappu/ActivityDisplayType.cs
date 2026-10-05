using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000E75 RID: 3701
	[Token(Token = "0x2000E75")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ActivityDisplayType
	{
		// Token: 0x04004DC1 RID: 19905
		[Token(Token = "0x4004DC1")]
		NONE,
		// Token: 0x04004DC2 RID: 19906
		[Token(Token = "0x4004DC2")]
		SIDESTORY,
		// Token: 0x04004DC3 RID: 19907
		[Token(Token = "0x4004DC3")]
		BRANCHLINE,
		// Token: 0x04004DC4 RID: 19908
		[Token(Token = "0x4004DC4")]
		MINISTORY
	}
}
