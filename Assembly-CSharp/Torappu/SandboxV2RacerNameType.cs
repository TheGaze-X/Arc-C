using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001286 RID: 4742
	[Token(Token = "0x2001286")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2RacerNameType
	{
		// Token: 0x04006897 RID: 26775
		[Token(Token = "0x4006897")]
		PREFIX,
		// Token: 0x04006898 RID: 26776
		[Token(Token = "0x4006898")]
		SUFFIX
	}
}
