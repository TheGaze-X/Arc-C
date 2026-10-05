using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000F4D RID: 3917
	[Token(Token = "0x2000F4D")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CGGalleryCGSource
	{
		// Token: 0x0400534D RID: 21325
		[Token(Token = "0x400534D")]
		IMAGE,
		// Token: 0x0400534E RID: 21326
		[Token(Token = "0x400534E")]
		BACKGROUND,
		// Token: 0x0400534F RID: 21327
		[Token(Token = "0x400534F")]
		ITEM
	}
}
