using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D9B RID: 3483
	[Token(Token = "0x2000D9B")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AutoChessTrophyGetType
	{
		// Token: 0x040047CC RID: 18380
		[Token(Token = "0x40047CC")]
		ROUND,
		// Token: 0x040047CD RID: 18381
		[Token(Token = "0x40047CD")]
		BOSS
	}
}
