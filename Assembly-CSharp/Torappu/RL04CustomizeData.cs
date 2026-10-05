using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011DF RID: 4575
	[Token(Token = "0x20011DF")]
	public class RL04CustomizeData
	{
		// Token: 0x06006FCC RID: 28620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FCC")]
		[Address(RVA = "0x210E670", Offset = "0x210D270", VA = "0x18210E670")]
		public RL04CustomizeData()
		{
		}

		// Token: 0x04006231 RID: 25137
		[Token(Token = "0x4006231")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeCommonDevelopmentData commonDevelopment;

		// Token: 0x04006232 RID: 25138
		[Token(Token = "0x4006232")]
		[FieldOffset(Offset = "0x18")]
		public List<RL04DifficultyExt> difficulties;

		// Token: 0x04006233 RID: 25139
		[Token(Token = "0x4006233")]
		[FieldOffset(Offset = "0x20")]
		public RL04EndingText endingText;
	}
}
