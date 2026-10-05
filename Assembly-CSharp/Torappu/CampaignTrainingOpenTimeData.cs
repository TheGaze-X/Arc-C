using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000F46 RID: 3910
	[Token(Token = "0x2000F46")]
	[Serializable]
	public class CampaignTrainingOpenTimeData
	{
		// Token: 0x06006C51 RID: 27729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006C51")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CampaignTrainingOpenTimeData()
		{
		}

		// Token: 0x04005322 RID: 21282
		[Token(Token = "0x4005322")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04005323 RID: 21283
		[Token(Token = "0x4005323")]
		[FieldOffset(Offset = "0x18")]
		public List<string> stages;

		// Token: 0x04005324 RID: 21284
		[Token(Token = "0x4005324")]
		[FieldOffset(Offset = "0x20")]
		public long startTs;

		// Token: 0x04005325 RID: 21285
		[Token(Token = "0x4005325")]
		[FieldOffset(Offset = "0x28")]
		public long endTs;
	}
}
