using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020036B7 RID: 14007
	[Token(Token = "0x20036B7")]
	[Serializable]
	public class BattlePerformanceData
	{
		// Token: 0x06016416 RID: 91158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016416")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BattlePerformanceData()
		{
		}

		// Token: 0x0401AC37 RID: 109623
		[Token(Token = "0x401AC37")]
		[FieldOffset(Offset = "0x10")]
		public List<string> battlePerformanceList;
	}
}
