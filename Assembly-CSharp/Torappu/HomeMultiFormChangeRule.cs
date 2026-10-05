using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000FE4 RID: 4068
	[Token(Token = "0x2000FE4")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum HomeMultiFormChangeRule
	{
		// Token: 0x0400563F RID: 22079
		[Token(Token = "0x400563F")]
		NONE,
		// Token: 0x04005640 RID: 22080
		[Token(Token = "0x4005640")]
		TIME
	}
}
