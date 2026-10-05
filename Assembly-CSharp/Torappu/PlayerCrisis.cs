using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000A97 RID: 2711
	[Token(Token = "0x2000A97")]
	public class PlayerCrisis
	{
		// Token: 0x0600675B RID: 26459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600675B")]
		[Address(RVA = "0x1EF4630", Offset = "0x1EF3230", VA = "0x181EF4630")]
		public PlayerCrisis()
		{
		}

		// Token: 0x04003948 RID: 14664
		[Token(Token = "0x4003948")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty(PropertyName = "current")]
		public string currentSeason;

		// Token: 0x04003949 RID: 14665
		[Token(Token = "0x4003949")]
		[FieldOffset(Offset = "0x18")]
		public PlayerCrisisShop shop;

		// Token: 0x0400394A RID: 14666
		[Token(Token = "0x400394A")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, PlayerCrisisSeason> season;
	}
}
