using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F47 RID: 3911
	[Token(Token = "0x2000F47")]
	[Serializable]
	public class CampaignTrainingAllOpenTimeData
	{
		// Token: 0x06006C52 RID: 27730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C52")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CampaignTrainingAllOpenTimeData()
		{
		}

		// Token: 0x04005326 RID: 21286
		[Token(Token = "0x4005326")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04005327 RID: 21287
		[Token(Token = "0x4005327")]
		[FieldOffset(Offset = "0x18")]
		public long startTs;

		// Token: 0x04005328 RID: 21288
		[Token(Token = "0x4005328")]
		[FieldOffset(Offset = "0x20")]
		public long endTs;
	}
}
