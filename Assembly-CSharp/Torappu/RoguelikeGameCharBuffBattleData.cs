using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001232 RID: 4658
	[Token(Token = "0x2001232")]
	public class RoguelikeGameCharBuffBattleData
	{
		// Token: 0x06007031 RID: 28721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6007031")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeGameCharBuffBattleData()
		{
		}

		// Token: 0x04006487 RID: 25735
		[Token(Token = "0x4006487")]
		[FieldOffset(Offset = "0x10")]
		public string charBuffId;

		// Token: 0x04006488 RID: 25736
		[Token(Token = "0x4006488")]
		[FieldOffset(Offset = "0x18")]
		public List<uint> charUniqueIds;

		// Token: 0x04006489 RID: 25737
		[Token(Token = "0x4006489")]
		[FieldOffset(Offset = "0x20")]
		public List<RoguelikeBuff> buffs;
	}
}
