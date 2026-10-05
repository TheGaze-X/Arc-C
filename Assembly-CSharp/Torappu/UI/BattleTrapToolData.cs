using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020036B6 RID: 14006
	[Token(Token = "0x20036B6")]
	[Serializable]
	public class BattleTrapToolData
	{
		// Token: 0x06016415 RID: 91157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016415")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BattleTrapToolData()
		{
		}

		// Token: 0x0401AC36 RID: 109622
		[Token(Token = "0x401AC36")]
		[FieldOffset(Offset = "0x10")]
		public List<string> trapList;
	}
}
