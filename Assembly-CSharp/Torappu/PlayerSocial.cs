using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x02000A19 RID: 2585
	[Token(Token = "0x2000A19")]
	public class PlayerSocial
	{
		// Token: 0x060066D9 RID: 26329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60066D9")]
		[Address(RVA = "0x1EFEAF0", Offset = "0x1EFD6F0", VA = "0x181EFEAF0")]
		public PlayerSocial()
		{
		}

		// Token: 0x040037A8 RID: 14248
		[Token(Token = "0x40037A8")]
		[FieldOffset(Offset = "0x10")]
		[JsonProperty(PropertyName = "yCrisisSs")]
		public string yesterdayCrisisSeasonId;

		// Token: 0x040037A9 RID: 14249
		[Token(Token = "0x40037A9")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty(PropertyName = "yCrisisV2Ss")]
		public string yesterdayCrisisV2SeasonId;

		// Token: 0x040037AA RID: 14250
		[Token(Token = "0x40037AA")]
		[FieldOffset(Offset = "0x20")]
		public List<PlayerFriendAssist> assistCharList;

		// Token: 0x040037AB RID: 14251
		[Token(Token = "0x40037AB")]
		[FieldOffset(Offset = "0x28")]
		public PlayerSocialReward yesterdayReward;

		// Token: 0x040037AC RID: 14252
		[Token(Token = "0x40037AC")]
		[FieldOffset(Offset = "0x30")]
		public PlayerMedalBoard medalBoard;

		// Token: 0x040037AD RID: 14253
		[Token(Token = "0x40037AD")]
		[FieldOffset(Offset = "0x38")]
		public int starFriendFlag;
	}
}
