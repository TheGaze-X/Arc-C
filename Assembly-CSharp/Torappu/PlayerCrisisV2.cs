using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000A9F RID: 2719
	[Token(Token = "0x2000A9F")]
	public class PlayerCrisisV2
	{
		// Token: 0x06006760 RID: 26464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006760")]
		[Address(RVA = "0x1EF4570", Offset = "0x1EF3170", VA = "0x181EF4570")]
		public PlayerCrisisV2()
		{
		}

		// Token: 0x04003967 RID: 14695
		[Token(Token = "0x4003967")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty(PropertyName = "current")]
		public string currentSeason;

		// Token: 0x04003968 RID: 14696
		[Token(Token = "0x4003968")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, PlayerCrisisV2Season> seasons;

		// Token: 0x04003969 RID: 14697
		[Token(Token = "0x4003969")]
		[FieldOffset(Offset = "0x20")]
		public PlayerCrisisShop shop;

		// Token: 0x0400396A RID: 14698
		[Token(Token = "0x400396A")]
		[FieldOffset(Offset = "0x28")]
		public long newRecordTs;

		// Token: 0x0400396B RID: 14699
		[Token(Token = "0x400396B")]
		[FieldOffset(Offset = "0x30")]
		[JsonProperty(PropertyName = "nst")]
		public long nextRefreshTs;
	}
}
