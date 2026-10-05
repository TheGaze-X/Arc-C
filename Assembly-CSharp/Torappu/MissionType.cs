using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02001110 RID: 4368
	[Token(Token = "0x2001110")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum MissionType
	{
		// Token: 0x04005D99 RID: 23961
		[Token(Token = "0x4005D99")]
		UNKNOWN,
		// Token: 0x04005D9A RID: 23962
		[Token(Token = "0x4005D9A")]
		MAIN,
		// Token: 0x04005D9B RID: 23963
		[Token(Token = "0x4005D9B")]
		DAILY,
		// Token: 0x04005D9C RID: 23964
		[Token(Token = "0x4005D9C")]
		WEEKLY,
		// Token: 0x04005D9D RID: 23965
		[Token(Token = "0x4005D9D")]
		GUIDE,
		// Token: 0x04005D9E RID: 23966
		[Token(Token = "0x4005D9E")]
		SUB,
		// Token: 0x04005D9F RID: 23967
		[Token(Token = "0x4005D9F")]
		ACTIVITY,
		// Token: 0x04005DA0 RID: 23968
		[Token(Token = "0x4005DA0")]
		OPENSERVER,
		// Token: 0x04005DA1 RID: 23969
		[Token(Token = "0x4005DA1")]
		TOWERSEASON,
		// Token: 0x04005DA2 RID: 23970
		[Token(Token = "0x4005DA2")]
		RETRO,
		// Token: 0x04005DA3 RID: 23971
		[Token(Token = "0x4005DA3")]
		SPECIAL_OPERATOR,
		// Token: 0x04005DA4 RID: 23972
		[Token(Token = "0x4005DA4")]
		SPECIAL_OPERATOR_WEEKLY
	}
}
