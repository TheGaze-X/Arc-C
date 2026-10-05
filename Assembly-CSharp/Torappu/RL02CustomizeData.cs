using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011DC RID: 4572
	[Token(Token = "0x20011DC")]
	public class RL02CustomizeData
	{
		// Token: 0x06006FC9 RID: 28617 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FC9")]
		[Address(RVA = "0x210C070", Offset = "0x210AC70", VA = "0x18210C070")]
		public RL02CustomizeData()
		{
		}

		// Token: 0x04006221 RID: 25121
		[Token(Token = "0x4006221")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, RL02Development> developments;

		// Token: 0x04006222 RID: 25122
		[Token(Token = "0x4006222")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, RoguelikeTopicDevToken> developmentTokens;

		// Token: 0x04006223 RID: 25123
		[Token(Token = "0x4006223")]
		[FieldOffset(Offset = "0x20")]
		public List<RL02DevRawTextBuffGroup> developmentRawTextGroup;

		// Token: 0x04006224 RID: 25124
		[Token(Token = "0x4006224")]
		[FieldOffset(Offset = "0x28")]
		public List<RL02DevelopmentLine> developmentLines;

		// Token: 0x04006225 RID: 25125
		[Token(Token = "0x4006225")]
		[FieldOffset(Offset = "0x30")]
		public RL02EndingText endingText;

		// Token: 0x04006226 RID: 25126
		[Token(Token = "0x4006226")]
		[FieldOffset(Offset = "0x38")]
		public List<RL02DifficultyExt> difficulties;
	}
}
