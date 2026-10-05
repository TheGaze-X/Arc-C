using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02000760 RID: 1888
	[Token(Token = "0x2000760")]
	public class ChoosePoolUpRequest
	{
		// Token: 0x060063CA RID: 25546 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60063CA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ChoosePoolUpRequest()
		{
		}

		// Token: 0x04002FEC RID: 12268
		[Token(Token = "0x4002FEC")]
		[FieldOffset(Offset = "0x10")]
		public string poolId;

		// Token: 0x04002FED RID: 12269
		[Token(Token = "0x4002FED")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<int, List<string>> chooseChar;
	}
}
