using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001013 RID: 4115
	[Token(Token = "0x2001013")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum KeyCodeType
	{
		// Token: 0x0400576D RID: 22381
		[Token(Token = "0x400576D")]
		KEYBOARD,
		// Token: 0x0400576E RID: 22382
		[Token(Token = "0x400576E")]
		MOUSE
	}
}
