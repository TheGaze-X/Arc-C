using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000F85 RID: 3973
	[Token(Token = "0x2000F85")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum FestivalVoiceTimeType
	{
		// Token: 0x04005476 RID: 21622
		[Token(Token = "0x4005476")]
		NONE,
		// Token: 0x04005477 RID: 21623
		[Token(Token = "0x4005477")]
		FESTIVAL,
		// Token: 0x04005478 RID: 21624
		[Token(Token = "0x4005478")]
		BIRTHDAY
	}
}
