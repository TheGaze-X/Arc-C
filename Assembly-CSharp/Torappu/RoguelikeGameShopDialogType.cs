using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x0200123E RID: 4670
	[Token(Token = "0x200123E")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum RoguelikeGameShopDialogType
	{
		// Token: 0x040064EE RID: 25838
		[Token(Token = "0x40064EE")]
		NONE,
		// Token: 0x040064EF RID: 25839
		[Token(Token = "0x40064EF")]
		BUY_SELECT,
		// Token: 0x040064F0 RID: 25840
		[Token(Token = "0x40064F0")]
		RECYCLE_SELECT,
		// Token: 0x040064F1 RID: 25841
		[Token(Token = "0x40064F1")]
		BUY_CHANGE,
		// Token: 0x040064F2 RID: 25842
		[Token(Token = "0x40064F2")]
		RECYCLE_CHANGE,
		// Token: 0x040064F3 RID: 25843
		[Token(Token = "0x40064F3")]
		BUY_CONFIRM,
		// Token: 0x040064F4 RID: 25844
		[Token(Token = "0x40064F4")]
		RECYCLE_CONFIRM,
		// Token: 0x040064F5 RID: 25845
		[Token(Token = "0x40064F5")]
		BANK_ENTRY,
		// Token: 0x040064F6 RID: 25846
		[Token(Token = "0x40064F6")]
		BANK_INVEST,
		// Token: 0x040064F7 RID: 25847
		[Token(Token = "0x40064F7")]
		BANK_WITHDRAWAL,
		// Token: 0x040064F8 RID: 25848
		[Token(Token = "0x40064F8")]
		BANK_FAULTY,
		// Token: 0x040064F9 RID: 25849
		[Token(Token = "0x40064F9")]
		BANK_REWARD_UNLOCK,
		// Token: 0x040064FA RID: 25850
		[Token(Token = "0x40064FA")]
		OUTER_NORMAL,
		// Token: 0x040064FB RID: 25851
		[Token(Token = "0x40064FB")]
		OUTER_REWARD,
		// Token: 0x040064FC RID: 25852
		[Token(Token = "0x40064FC")]
		FIGHT_BOSS
	}
}
