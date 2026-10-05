using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000E5C RID: 3676
	[Token(Token = "0x2000E5C")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ActVecBreakV2StageOrderType
	{
		// Token: 0x04004CEF RID: 19695
		[Token(Token = "0x4004CEF")]
		NONE,
		// Token: 0x04004CF0 RID: 19696
		[Token(Token = "0x4004CF0")]
		A,
		// Token: 0x04004CF1 RID: 19697
		[Token(Token = "0x4004CF1")]
		B,
		// Token: 0x04004CF2 RID: 19698
		[Token(Token = "0x4004CF2")]
		C,
		// Token: 0x04004CF3 RID: 19699
		[Token(Token = "0x4004CF3")]
		D
	}
}
