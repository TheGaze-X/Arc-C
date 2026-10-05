using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu
{
	// Token: 0x02000FDC RID: 4060
	[Token(Token = "0x2000FDC")]
	public class CrisisV2CacheServerData : IHotfixable
	{
		// Token: 0x06006D32 RID: 27954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006D32")]
		[Address(RVA = "0x2100C40", Offset = "0x20FF840", VA = "0x182100C40")]
		public CrisisV2CacheServerData()
		{
		}

		// Token: 0x04005623 RID: 22051
		[Token(Token = "0x4005623")]
		[FieldOffset(Offset = "0x10")]
		public string seasonId;

		// Token: 0x04005624 RID: 22052
		[Token(Token = "0x4005624")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, CrisisV2MapStageData> mapStageDataMap;

		// Token: 0x04005625 RID: 22053
		[Token(Token = "0x4005625")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, CrisisV2MapDetailData> mapDetailDataMap;

		// Token: 0x04005626 RID: 22054
		[Token(Token = "0x4005626")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, CrisisV2AchievementData> achievementDataMap;

		// Token: 0x04005627 RID: 22055
		[Token(Token = "0x4005627")]
		[FieldOffset(Offset = "0x30")]
		public CrisisV2SeasonConstData seasonConst;

		// Token: 0x04005628 RID: 22056
		[Token(Token = "0x4005628")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
