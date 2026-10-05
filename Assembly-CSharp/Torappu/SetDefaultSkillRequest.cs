using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000839 RID: 2105
	[Token(Token = "0x2000839")]
	public class SetDefaultSkillRequest
	{
		// Token: 0x060064D1 RID: 25809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60064D1")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SetDefaultSkillRequest()
		{
		}

		// Token: 0x0400313E RID: 12606
		[Token(Token = "0x400313E")]
		[FieldOffset(Offset = "0x10")]
		public int charInstId;

		// Token: 0x0400313F RID: 12607
		[Token(Token = "0x400313F")]
		[FieldOffset(Offset = "0x14")]
		public int defaultSkillIndex;
	}
}
