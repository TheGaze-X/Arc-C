using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000DA1 RID: 3489
	[Token(Token = "0x2000DA1")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ActAutoChessBondActiveType
	{
		// Token: 0x040047EA RID: 18410
		[Token(Token = "0x40047EA")]
		BATTLE,
		// Token: 0x040047EB RID: 18411
		[Token(Token = "0x40047EB")]
		ALL,
		// Token: 0x040047EC RID: 18412
		[Token(Token = "0x40047EC")]
		MANI
	}
}
