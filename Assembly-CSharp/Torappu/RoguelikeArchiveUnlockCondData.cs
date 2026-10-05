using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001207 RID: 4615
	[Token(Token = "0x2001207")]
	public class RoguelikeArchiveUnlockCondData
	{
		// Token: 0x06006FFD RID: 28669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FFD")]
		[Address(RVA = "0x21105D0", Offset = "0x210F1D0", VA = "0x1821105D0")]
		public RoguelikeArchiveUnlockCondData()
		{
		}

		// Token: 0x04006356 RID: 25430
		[Token(Token = "0x4006356")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, RoguelikeArchiveUnlockCondDesc> unlockCondDesc;

		// Token: 0x04006357 RID: 25431
		[Token(Token = "0x4006357")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, RoguelikeArchiveEnroll> enroll;
	}
}
