using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020007DC RID: 2012
	[Token(Token = "0x20007DC")]
	public class RetroTrailRewardRequest
	{
		// Token: 0x06006467 RID: 25703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006467")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RetroTrailRewardRequest()
		{
		}

		// Token: 0x040030FD RID: 12541
		[Token(Token = "0x40030FD")]
		[FieldOffset(Offset = "0x10")]
		public string retroId;

		// Token: 0x040030FE RID: 12542
		[Token(Token = "0x40030FE")]
		[FieldOffset(Offset = "0x18")]
		public string rewardId;
	}
}
