using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000C86 RID: 3206
	[Token(Token = "0x2000C86")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Act1VHalfIdlePlotType
	{
		// Token: 0x04004175 RID: 16757
		[Token(Token = "0x4004175")]
		NONE,
		// Token: 0x04004176 RID: 16758
		[Token(Token = "0x4004176")]
		LANDSCAPE,
		// Token: 0x04004177 RID: 16759
		[Token(Token = "0x4004177")]
		ROAD,
		// Token: 0x04004178 RID: 16760
		[Token(Token = "0x4004178")]
		ROADSIDE,
		// Token: 0x04004179 RID: 16761
		[Token(Token = "0x4004179")]
		SPECIAL
	}
}
