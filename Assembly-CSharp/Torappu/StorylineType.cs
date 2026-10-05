using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001378 RID: 4984
	[Token(Token = "0x2001378")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum StorylineType
	{
		// Token: 0x04006E97 RID: 28311
		[Token(Token = "0x4006E97")]
		CONTINUE,
		// Token: 0x04006E98 RID: 28312
		[Token(Token = "0x4006E98")]
		DISCRETE
	}
}
