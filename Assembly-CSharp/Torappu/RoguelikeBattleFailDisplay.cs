using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000B1B RID: 2843
	[Token(Token = "0x2000B1B")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeBattleFailDisplay
	{
		// Token: 0x04003B73 RID: 15219
		[Token(Token = "0x4003B73")]
		NORMAL,
		// Token: 0x04003B74 RID: 15220
		[Token(Token = "0x4003B74")]
		FAIL_R5_SKY
	}
}
