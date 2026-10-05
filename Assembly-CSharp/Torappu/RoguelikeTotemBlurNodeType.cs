using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001197 RID: 4503
	[Token(Token = "0x2001197")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeTotemBlurNodeType
	{
		// Token: 0x04006071 RID: 24689
		[Token(Token = "0x4006071")]
		NONE,
		// Token: 0x04006072 RID: 24690
		[Token(Token = "0x4006072")]
		BATTLE,
		// Token: 0x04006073 RID: 24691
		[Token(Token = "0x4006073")]
		NO_BATTLE
	}
}
