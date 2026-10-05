using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020011B7 RID: 4535
	[Token(Token = "0x20011B7")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeCopperDivineResultType
	{
		// Token: 0x04006114 RID: 24852
		[Token(Token = "0x4006114")]
		NONE,
		// Token: 0x04006115 RID: 24853
		[Token(Token = "0x4006115")]
		GOOD,
		// Token: 0x04006116 RID: 24854
		[Token(Token = "0x4006116")]
		NORMAL,
		// Token: 0x04006117 RID: 24855
		[Token(Token = "0x4006117")]
		BAD
	}
}
