using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020008E6 RID: 2278
	[Token(Token = "0x20008E6")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PlayerAvatarType
	{
		// Token: 0x04003329 RID: 13097
		[Token(Token = "0x4003329")]
		NONE,
		// Token: 0x0400332A RID: 13098
		[Token(Token = "0x400332A")]
		ASSISTANT,
		// Token: 0x0400332B RID: 13099
		[Token(Token = "0x400332B")]
		ICON,
		// Token: 0x0400332C RID: 13100
		[Token(Token = "0x400332C")]
		DEFAULT
	}
}
