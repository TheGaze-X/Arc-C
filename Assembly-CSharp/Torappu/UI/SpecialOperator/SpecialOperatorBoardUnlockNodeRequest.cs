using System;
using Il2CppDummyDll;

namespace Torappu.UI.SpecialOperator
{
	// Token: 0x02003E54 RID: 15956
	[Token(Token = "0x2003E54")]
	public class SpecialOperatorBoardUnlockNodeRequest
	{
		// Token: 0x06018D0E RID: 101646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018D0E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public SpecialOperatorBoardUnlockNodeRequest()
		{
		}

		// Token: 0x0401E81D RID: 124957
		[Token(Token = "0x401E81D")]
		[FieldOffset(Offset = "0x10")]
		public string instId;

		// Token: 0x0401E81E RID: 124958
		[Token(Token = "0x401E81E")]
		[FieldOffset(Offset = "0x18")]
		public string nodeId;
	}
}
