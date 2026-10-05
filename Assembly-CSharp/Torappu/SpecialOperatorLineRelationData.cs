using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001345 RID: 4933
	[Token(Token = "0x2001345")]
	public class SpecialOperatorLineRelationData
	{
		// Token: 0x06007302 RID: 29442 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007302")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SpecialOperatorLineRelationData()
		{
		}

		// Token: 0x04006D4E RID: 27982
		[Token(Token = "0x4006D4E")]
		[FieldOffset(Offset = "0x10")]
		public List<string> startPointList;

		// Token: 0x04006D4F RID: 27983
		[Token(Token = "0x4006D4F")]
		[FieldOffset(Offset = "0x18")]
		public List<string> endPointList;
	}
}
