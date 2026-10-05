using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000666 RID: 1638
	[Token(Token = "0x2000666")]
	public class BuildingDailyReport
	{
		// Token: 0x06006294 RID: 25236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006294")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingDailyReport()
		{
		}

		// Token: 0x04002E22 RID: 11810
		[Token(Token = "0x4002E22")]
		[FieldOffset(Offset = "0x10")]
		public long ts;

		// Token: 0x04002E23 RID: 11811
		[Token(Token = "0x4002E23")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, BuildingManuFactureItemReport> manufacture;

		// Token: 0x04002E24 RID: 11812
		[Token(Token = "0x4002E24")]
		[FieldOffset(Offset = "0x20")]
		public Dictionary<string, BuildingTradingReport> trading;

		// Token: 0x04002E25 RID: 11813
		[Token(Token = "0x4002E25")]
		[FieldOffset(Offset = "0x28")]
		public List<BuildingFavorReport> favor;
	}
}
