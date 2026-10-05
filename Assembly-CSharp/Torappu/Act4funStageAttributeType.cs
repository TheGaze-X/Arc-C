using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000E9E RID: 3742
	[Token(Token = "0x2000E9E")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum Act4funStageAttributeType
	{
		// Token: 0x04004F03 RID: 20227
		[Token(Token = "0x4004F03")]
		POS,
		// Token: 0x04004F04 RID: 20228
		[Token(Token = "0x4004F04")]
		NEG
	}
}
