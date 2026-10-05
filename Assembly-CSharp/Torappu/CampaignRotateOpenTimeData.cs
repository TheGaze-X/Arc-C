using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F45 RID: 3909
	[Token(Token = "0x2000F45")]
	[Serializable]
	public class CampaignRotateOpenTimeData
	{
		// Token: 0x06006C50 RID: 27728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C50")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CampaignRotateOpenTimeData()
		{
		}

		// Token: 0x0400531B RID: 21275
		[Token(Token = "0x400531B")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x0400531C RID: 21276
		[Token(Token = "0x400531C")]
		[FieldOffset(Offset = "0x18")]
		public string stageId;

		// Token: 0x0400531D RID: 21277
		[Token(Token = "0x400531D")]
		[FieldOffset(Offset = "0x20")]
		public string mapId;

		// Token: 0x0400531E RID: 21278
		[Token(Token = "0x400531E")]
		[FieldOffset(Offset = "0x28")]
		public List<string> unknownRegions;

		// Token: 0x0400531F RID: 21279
		[Token(Token = "0x400531F")]
		[FieldOffset(Offset = "0x30")]
		public int duration;

		// Token: 0x04005320 RID: 21280
		[Token(Token = "0x4005320")]
		[FieldOffset(Offset = "0x38")]
		public long startTs;

		// Token: 0x04005321 RID: 21281
		[Token(Token = "0x4005321")]
		[FieldOffset(Offset = "0x40")]
		public long endTs;
	}
}
