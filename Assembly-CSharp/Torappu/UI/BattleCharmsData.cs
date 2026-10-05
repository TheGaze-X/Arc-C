using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020036B2 RID: 14002
	[Token(Token = "0x20036B2")]
	[Serializable]
	public class BattleCharmsData
	{
		// Token: 0x06016411 RID: 91153 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016411")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BattleCharmsData()
		{
		}

		// Token: 0x0401AC32 RID: 109618
		[Token(Token = "0x401AC32")]
		[FieldOffset(Offset = "0x10")]
		public List<string> charmList;
	}
}
