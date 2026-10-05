using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001237 RID: 4663
	[Token(Token = "0x2001237")]
	public class RoguelikeBattleSummeryDescriptionData
	{
		// Token: 0x06007036 RID: 28726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007036")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeBattleSummeryDescriptionData()
		{
		}

		// Token: 0x0400649F RID: 25759
		[Token(Token = "0x400649F")]
		[FieldOffset(Offset = "0x10")]
		public List<string> randomDescriptionList;
	}
}
