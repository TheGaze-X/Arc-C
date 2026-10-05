using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000DA2 RID: 3490
	[Token(Token = "0x2000DA2")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum ActAutoChessBondActiveConditionType
	{
		// Token: 0x040047EE RID: 18414
		[Token(Token = "0x40047EE")]
		BOARD,
		// Token: 0x040047EF RID: 18415
		[Token(Token = "0x40047EF")]
		BOARD_AND_DECK,
		// Token: 0x040047F0 RID: 18416
		[Token(Token = "0x40047F0")]
		DECK,
		// Token: 0x040047F1 RID: 18417
		[Token(Token = "0x40047F1")]
		BOARD_ALL_CHESS
	}
}
