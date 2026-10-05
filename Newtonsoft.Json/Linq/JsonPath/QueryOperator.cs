using System;
using Il2CppDummyDll;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Linq.JsonPath
{
	// Token: 0x020000EE RID: 238
	[Token(Token = "0x20000EE")]
	[Preserve]
	internal enum QueryOperator
	{
		// Token: 0x040003D1 RID: 977
		[Token(Token = "0x40003D1")]
		None,
		// Token: 0x040003D2 RID: 978
		[Token(Token = "0x40003D2")]
		Equals,
		// Token: 0x040003D3 RID: 979
		[Token(Token = "0x40003D3")]
		NotEquals,
		// Token: 0x040003D4 RID: 980
		[Token(Token = "0x40003D4")]
		Exists,
		// Token: 0x040003D5 RID: 981
		[Token(Token = "0x40003D5")]
		LessThan,
		// Token: 0x040003D6 RID: 982
		[Token(Token = "0x40003D6")]
		LessThanOrEquals,
		// Token: 0x040003D7 RID: 983
		[Token(Token = "0x40003D7")]
		GreaterThan,
		// Token: 0x040003D8 RID: 984
		[Token(Token = "0x40003D8")]
		GreaterThanOrEquals,
		// Token: 0x040003D9 RID: 985
		[Token(Token = "0x40003D9")]
		And,
		// Token: 0x040003DA RID: 986
		[Token(Token = "0x40003DA")]
		Or
	}
}
