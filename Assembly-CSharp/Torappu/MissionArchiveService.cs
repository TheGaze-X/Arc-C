using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007C3 RID: 1987
	[Token(Token = "0x20007C3")]
	public class MissionArchiveService
	{
		// Token: 0x06006444 RID: 25668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006444")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public MissionArchiveService()
		{
		}

		// Token: 0x020007C4 RID: 1988
		[Token(Token = "0x20007C4")]
		public interface IMissionArchiveClaimEntryRewardResponse
		{
			// Token: 0x06006445 RID: 25669
			[Token(Token = "0x6006445")]
			List<ItemGet> GetReward();
		}

		// Token: 0x020007C5 RID: 1989
		[Token(Token = "0x20007C5")]
		public interface IMissionArchiveClaimNodeRewardResponse
		{
			// Token: 0x06006446 RID: 25670
			[Token(Token = "0x6006446")]
			List<ItemGet> GetReward();
		}
	}
}
