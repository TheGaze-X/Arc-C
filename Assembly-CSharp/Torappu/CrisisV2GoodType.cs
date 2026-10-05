using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000FB4 RID: 4020
	[Token(Token = "0x2000FB4")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CrisisV2GoodType
	{
		// Token: 0x0400554B RID: 21835
		[Token(Token = "0x400554B")]
		NONE,
		// Token: 0x0400554C RID: 21836
		[Token(Token = "0x400554C")]
		NORMAL,
		// Token: 0x0400554D RID: 21837
		[Token(Token = "0x400554D")]
		PROGRESS
	}
}
