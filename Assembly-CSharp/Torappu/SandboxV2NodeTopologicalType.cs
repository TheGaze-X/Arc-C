using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001279 RID: 4729
	[Token(Token = "0x2001279")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum SandboxV2NodeTopologicalType
	{
		// Token: 0x04006841 RID: 26689
		[Token(Token = "0x4006841")]
		NONE,
		// Token: 0x04006842 RID: 26690
		[Token(Token = "0x4006842")]
		TRAFFIC_NODE,
		// Token: 0x04006843 RID: 26691
		[Token(Token = "0x4006843")]
		ENDING_NODE
	}
}
