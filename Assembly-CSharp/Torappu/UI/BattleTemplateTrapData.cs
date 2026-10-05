using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI
{
	// Token: 0x020036B3 RID: 14003
	[Token(Token = "0x20036B3")]
	[Serializable]
	public class BattleTemplateTrapData
	{
		// Token: 0x06016412 RID: 91154 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016412")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BattleTemplateTrapData()
		{
		}

		// Token: 0x0401AC33 RID: 109619
		[Token(Token = "0x401AC33")]
		[FieldOffset(Offset = "0x10")]
		public List<string> trapList;
	}
}
