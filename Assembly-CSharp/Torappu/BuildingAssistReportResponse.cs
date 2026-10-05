using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000667 RID: 1639
	[Token(Token = "0x2000667")]
	public class BuildingAssistReportResponse
	{
		// Token: 0x06006295 RID: 25237 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006295")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BuildingAssistReportResponse()
		{
		}

		// Token: 0x04002E26 RID: 11814
		[Token(Token = "0x4002E26")]
		[FieldOffset(Offset = "0x10")]
		public List<BuildingDailyReport> reports;
	}
}
