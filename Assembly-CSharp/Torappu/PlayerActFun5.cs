using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000B7F RID: 2943
	[Token(Token = "0x2000B7F")]
	public class PlayerActFun5
	{
		// Token: 0x0600681E RID: 26654 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600681E")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public PlayerActFun5()
		{
		}

		// Token: 0x04003D0D RID: 15629
		[Token(Token = "0x4003D0D")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, int> stageState;

		// Token: 0x04003D0E RID: 15630
		[Token(Token = "0x4003D0E")]
		[FieldOffset(Offset = "0x18")]
		public int highScore;
	}
}
