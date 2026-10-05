using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020036B4 RID: 14004
	[Token(Token = "0x20036B4")]
	[Serializable]
	public class BattleTechData
	{
		// Token: 0x06016413 RID: 91155 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016413")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BattleTechData()
		{
		}

		// Token: 0x0401AC34 RID: 109620
		[Token(Token = "0x401AC34")]
		[FieldOffset(Offset = "0x10")]
		public List<string> techBranchList;
	}
}
