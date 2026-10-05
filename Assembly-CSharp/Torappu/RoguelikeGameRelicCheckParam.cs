using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001245 RID: 4677
	[Token(Token = "0x2001245")]
	public class RoguelikeGameRelicCheckParam
	{
		// Token: 0x06007038 RID: 28728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007038")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeGameRelicCheckParam()
		{
		}

		// Token: 0x0400652E RID: 25902
		[Token(Token = "0x400652E")]
		[FieldOffset(Offset = "0x10")]
		public ProfessionCategory valueProfessionMask;

		// Token: 0x0400652F RID: 25903
		[Token(Token = "0x400652F")]
		[FieldOffset(Offset = "0x18")]
		public List<string> valueStrs;

		// Token: 0x04006530 RID: 25904
		[Token(Token = "0x4006530")]
		[FieldOffset(Offset = "0x20")]
		public int valueInt;
	}
}
