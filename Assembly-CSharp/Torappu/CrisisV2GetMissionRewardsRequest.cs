using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006E5 RID: 1765
	[Token(Token = "0x20006E5")]
	public class CrisisV2GetMissionRewardsRequest
	{
		// Token: 0x06006334 RID: 25396 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006334")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CrisisV2GetMissionRewardsRequest()
		{
		}

		// Token: 0x04002EF8 RID: 12024
		[Token(Token = "0x4002EF8")]
		[FieldOffset(Offset = "0x10")]
		public string mapId;

		// Token: 0x04002EF9 RID: 12025
		[Token(Token = "0x4002EF9")]
		[FieldOffset(Offset = "0x18")]
		public List<CrisisV2MissionInfo> missions;
	}
}
