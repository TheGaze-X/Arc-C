using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu
{
	// Token: 0x020008F2 RID: 2290
	[Token(Token = "0x20008F2")]
	[Serializable]
	public class PlayerCheckIn
	{
		// Token: 0x060065B8 RID: 26040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60065B8")]
		[Address(RVA = "0x1EF3BD0", Offset = "0x1EF27D0", VA = "0x181EF3BD0")]
		public PlayerCheckIn()
		{
		}

		// Token: 0x0400334B RID: 13131
		[Token(Token = "0x400334B")]
		[FieldOffset(Offset = "0x10")]
		public bool canCheckIn;

		// Token: 0x0400334C RID: 13132
		[Token(Token = "0x400334C")]
		[FieldOffset(Offset = "0x18")]
		public string checkInGroupId;

		// Token: 0x0400334D RID: 13133
		[Token(Token = "0x400334D")]
		[FieldOffset(Offset = "0x20")]
		public int checkInRewardIndex;

		// Token: 0x0400334E RID: 13134
		[Token(Token = "0x400334E")]
		[FieldOffset(Offset = "0x28")]
		public List<bool> checkInHistory;

		// Token: 0x0400334F RID: 13135
		[Token(Token = "0x400334F")]
		[FieldOffset(Offset = "0x30")]
		public PlayerCheckIn.PlayerNewbiePackage newbiePackage;

		// Token: 0x04003350 RID: 13136
		[Token(Token = "0x4003350")]
		[FieldOffset(Offset = "0x38")]
		public Dictionary<string, PlayerCheckIn.PlayerNewbieChoosePackage> newbieChooseGP;

		// Token: 0x04003351 RID: 13137
		[Token(Token = "0x4003351")]
		[FieldOffset(Offset = "0x40")]
		public int showCount;

		// Token: 0x04003352 RID: 13138
		[Token(Token = "0x4003352")]
		[FieldOffset(Offset = "0x48")]
		public Dictionary<string, int> longTermRecvRecord;

		// Token: 0x020008F3 RID: 2291
		[Token(Token = "0x20008F3")]
		public class PlayerNewbiePackage
		{
			// Token: 0x060065B9 RID: 26041 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065B9")]
			[Address(RVA = "0x1EFBEC0", Offset = "0x1EFAAC0", VA = "0x181EFBEC0")]
			public PlayerNewbiePackage()
			{
			}

			// Token: 0x04003353 RID: 13139
			[Token(Token = "0x4003353")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty(PropertyName = "open")]
			public bool isOpen;

			// Token: 0x04003354 RID: 13140
			[Token(Token = "0x4003354")]
			[FieldOffset(Offset = "0x18")]
			public string groupId;

			// Token: 0x04003355 RID: 13141
			[Token(Token = "0x4003355")]
			[FieldOffset(Offset = "0x20")]
			public List<long> checkInHistory;

			// Token: 0x04003356 RID: 13142
			[Token(Token = "0x4003356")]
			[FieldOffset(Offset = "0x28")]
			[JsonProperty(PropertyName = "finish")]
			public long checkinFinTs;

			// Token: 0x04003357 RID: 13143
			[Token(Token = "0x4003357")]
			[FieldOffset(Offset = "0x30")]
			[JsonProperty(PropertyName = "stopSale")]
			public long stopSaleTs;
		}

		// Token: 0x020008F4 RID: 2292
		[Token(Token = "0x20008F4")]
		public class PlayerNewbieChoosePackage
		{
			// Token: 0x060065BA RID: 26042 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60065BA")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public PlayerNewbieChoosePackage()
			{
			}

			// Token: 0x04003358 RID: 13144
			[Token(Token = "0x4003358")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty(PropertyName = "stopSale")]
			public long stopSaleTs;
		}
	}
}
