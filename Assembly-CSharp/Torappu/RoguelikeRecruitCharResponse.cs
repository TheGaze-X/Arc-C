using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x0200080C RID: 2060
	[Token(Token = "0x200080C")]
	public class RoguelikeRecruitCharResponse : PlayerDeltaResponse
	{
		// Token: 0x06006497 RID: 25751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006497")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public RoguelikeRecruitCharResponse()
		{
		}

		// Token: 0x04003118 RID: 12568
		[Token(Token = "0x4003118")]
		[FieldOffset(Offset = "0x28")]
		public List<PlayerRoguelikeCharacter> chars;
	}
}
