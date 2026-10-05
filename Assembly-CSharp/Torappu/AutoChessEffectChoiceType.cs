using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000D9F RID: 3487
	[Token(Token = "0x2000D9F")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum AutoChessEffectChoiceType
	{
		// Token: 0x040047DF RID: 18399
		[Token(Token = "0x40047DF")]
		EQUIP_FREE,
		// Token: 0x040047E0 RID: 18400
		[Token(Token = "0x40047E0")]
		EQUIP_PAID,
		// Token: 0x040047E1 RID: 18401
		[Token(Token = "0x40047E1")]
		BOUNTY_HUNT,
		// Token: 0x040047E2 RID: 18402
		[Token(Token = "0x40047E2")]
		BUFF_SELECT,
		// Token: 0x040047E3 RID: 18403
		[Token(Token = "0x40047E3")]
		PERSONAL_CHOOSE
	}
}
