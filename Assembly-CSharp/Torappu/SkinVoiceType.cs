using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001325 RID: 4901
	[Token(Token = "0x2001325")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SkinVoiceType
	{
		// Token: 0x04006CB1 RID: 27825
		[Token(Token = "0x4006CB1")]
		NONE,
		// Token: 0x04006CB2 RID: 27826
		[Token(Token = "0x4006CB2")]
		ILLUST,
		// Token: 0x04006CB3 RID: 27827
		[Token(Token = "0x4006CB3")]
		ALL
	}
}
