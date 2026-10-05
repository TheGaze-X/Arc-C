using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000C87 RID: 3207
	[Token(Token = "0x2000C87")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Act1VHalfIdlePlotCombineType
	{
		// Token: 0x0400417B RID: 16763
		[Token(Token = "0x400417B")]
		NONE,
		// Token: 0x0400417C RID: 16764
		[Token(Token = "0x400417C")]
		SINGLE,
		// Token: 0x0400417D RID: 16765
		[Token(Token = "0x400417D")]
		PLUS,
		// Token: 0x0400417E RID: 16766
		[Token(Token = "0x400417E")]
		PLUS_OR
	}
}
