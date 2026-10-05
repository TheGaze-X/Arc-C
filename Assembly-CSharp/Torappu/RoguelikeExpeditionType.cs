using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x020011C9 RID: 4553
	[Token(Token = "0x20011C9")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeExpeditionType
	{
		// Token: 0x04006187 RID: 24967
		[Token(Token = "0x4006187")]
		NORMAL,
		// Token: 0x04006188 RID: 24968
		[Token(Token = "0x4006188")]
		CANDLE,
		// Token: 0x04006189 RID: 24969
		[Token(Token = "0x4006189")]
		GUIDED
	}
}
