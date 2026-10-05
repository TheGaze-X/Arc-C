using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200123D RID: 4669
	[Token(Token = "0x200123D")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeTopicBankRewardType
	{
		// Token: 0x040064E7 RID: 25831
		[Token(Token = "0x40064E7")]
		NONE,
		// Token: 0x040064E8 RID: 25832
		[Token(Token = "0x40064E8")]
		UNLOCK_ITEM,
		// Token: 0x040064E9 RID: 25833
		[Token(Token = "0x40064E9")]
		ADD_SHOP_POS,
		// Token: 0x040064EA RID: 25834
		[Token(Token = "0x40064EA")]
		UNLOCK_WITHDRAW,
		// Token: 0x040064EB RID: 25835
		[Token(Token = "0x40064EB")]
		UNLOCK_SHOP_BATTLE,
		// Token: 0x040064EC RID: 25836
		[Token(Token = "0x40064EC")]
		UNLOCK_SHOP_REFRESH
	}
}
