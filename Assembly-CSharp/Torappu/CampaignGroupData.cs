using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F42 RID: 3906
	[Token(Token = "0x2000F42")]
	[Serializable]
	public class CampaignGroupData
	{
		// Token: 0x06006C4D RID: 27725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C4D")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CampaignGroupData()
		{
		}

		// Token: 0x04005311 RID: 21265
		[Token(Token = "0x4005311")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04005312 RID: 21266
		[Token(Token = "0x4005312")]
		[FieldOffset(Offset = "0x18")]
		public string[] activeCamps;

		// Token: 0x04005313 RID: 21267
		[Token(Token = "0x4005313")]
		[FieldOffset(Offset = "0x20")]
		public long startTs;

		// Token: 0x04005314 RID: 21268
		[Token(Token = "0x4005314")]
		[FieldOffset(Offset = "0x28")]
		public long endTs;
	}
}
