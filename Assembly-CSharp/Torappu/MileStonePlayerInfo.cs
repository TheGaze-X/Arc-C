using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020008FD RID: 2301
	[Token(Token = "0x20008FD")]
	public class MileStonePlayerInfo
	{
		// Token: 0x060065D5 RID: 26069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065D5")]
		[Address(RVA = "0x1EEB3F0", Offset = "0x1EE9FF0", VA = "0x181EEB3F0")]
		public MileStonePlayerInfo()
		{
		}

		// Token: 0x04003396 RID: 13206
		[Token(Token = "0x4003396")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, int> points;

		// Token: 0x04003397 RID: 13207
		[Token(Token = "0x4003397")]
		[FieldOffset(Offset = "0x18")]
		[JsonProperty("got")]
		public Dictionary<string, MileStonePlayerInfo.MileStoneRewardTicketItem> rewards;

		// Token: 0x020008FE RID: 2302
		[Token(Token = "0x20008FE")]
		public class MileStoneRewardTicketItem
		{
			// Token: 0x060065D6 RID: 26070 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065D6")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public MileStoneRewardTicketItem()
			{
			}

			// Token: 0x04003398 RID: 13208
			[Token(Token = "0x4003398")]
			[FieldOffset(Offset = "0x10")]
			public long ts;

			// Token: 0x04003399 RID: 13209
			[Token(Token = "0x4003399")]
			[FieldOffset(Offset = "0x18")]
			public int count;
		}
	}
}
