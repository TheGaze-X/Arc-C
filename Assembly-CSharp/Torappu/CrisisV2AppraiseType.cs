using System;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Torappu
{
	// Token: 0x02000FB0 RID: 4016
	[Token(Token = "0x2000FB0")]
	[JsonConverter(typeof(StringEnumConverter))]
	public enum CrisisV2AppraiseType
	{
		// Token: 0x04005536 RID: 21814
		[Token(Token = "0x4005536")]
		RANK_D,
		// Token: 0x04005537 RID: 21815
		[Token(Token = "0x4005537")]
		RANK_C,
		// Token: 0x04005538 RID: 21816
		[Token(Token = "0x4005538")]
		RANK_B,
		// Token: 0x04005539 RID: 21817
		[Token(Token = "0x4005539")]
		RANK_A,
		// Token: 0x0400553A RID: 21818
		[Token(Token = "0x400553A")]
		RANK_S,
		// Token: 0x0400553B RID: 21819
		[Token(Token = "0x400553B")]
		RANK_SS,
		// Token: 0x0400553C RID: 21820
		[Token(Token = "0x400553C")]
		RANK_SSS
	}
}
