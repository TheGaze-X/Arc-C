using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001014 RID: 4116
	[Token(Token = "0x2001014")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum KeySettingGroup
	{
		// Token: 0x04005770 RID: 22384
		[Token(Token = "0x4005770")]
		BATTLE,
		// Token: 0x04005771 RID: 22385
		[Token(Token = "0x4005771")]
		NORMAL
	}
}
