using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011DB RID: 4571
	[Token(Token = "0x20011DB")]
	public class RL01CustomizeData
	{
		// Token: 0x06006FC8 RID: 28616 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FC8")]
		[Address(RVA = "0x2109CD0", Offset = "0x21088D0", VA = "0x182109CD0")]
		public RL01CustomizeData()
		{
		}

		// Token: 0x0400621D RID: 25117
		[Token(Token = "0x400621D")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, RoguelikeTopicDev> developments;

		// Token: 0x0400621E RID: 25118
		[Token(Token = "0x400621E")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, RoguelikeTopicDevToken> developmentTokens;

		// Token: 0x0400621F RID: 25119
		[Token(Token = "0x400621F")]
		[FieldOffset(Offset = "0x20")]
		public RL01EndingText endingText;

		// Token: 0x04006220 RID: 25120
		[Token(Token = "0x4006220")]
		[FieldOffset(Offset = "0x28")]
		public List<RL01DifficultyExt> difficulties;
	}
}
