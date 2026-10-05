using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200116B RID: 4459
	[Token(Token = "0x200116B")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeItemType
	{
		// Token: 0x04005F85 RID: 24453
		[Token(Token = "0x4005F85")]
		NONE,
		// Token: 0x04005F86 RID: 24454
		[Token(Token = "0x4005F86")]
		HP,
		// Token: 0x04005F87 RID: 24455
		[Token(Token = "0x4005F87")]
		GOLD,
		// Token: 0x04005F88 RID: 24456
		[Token(Token = "0x4005F88")]
		POPULATION,
		// Token: 0x04005F89 RID: 24457
		[Token(Token = "0x4005F89")]
		SQUAD_CAPACITY,
		// Token: 0x04005F8A RID: 24458
		[Token(Token = "0x4005F8A")]
		RECRUIT_TICKET,
		// Token: 0x04005F8B RID: 24459
		[Token(Token = "0x4005F8B")]
		UPGRADE_TICKET,
		// Token: 0x04005F8C RID: 24460
		[Token(Token = "0x4005F8C")]
		RELIC,
		// Token: 0x04005F8D RID: 24461
		[Token(Token = "0x4005F8D")]
		TOTEM_EFFECT
	}
}
