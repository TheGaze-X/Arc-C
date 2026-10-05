using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020011CC RID: 4556
	[Token(Token = "0x20011CC")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeBankRewardCountType
	{
		// Token: 0x040061A0 RID: 24992
		[Token(Token = "0x40061A0")]
		HIGHEST_RECORD,
		// Token: 0x040061A1 RID: 24993
		[Token(Token = "0x40061A1")]
		TOTAL_SUM
	}
}
