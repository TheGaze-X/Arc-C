using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011DE RID: 4574
	[Token(Token = "0x20011DE")]
	public class RoguelikeCommonDevelopmentData
	{
		// Token: 0x06006FCB RID: 28619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FCB")]
		[Address(RVA = "0x21109D0", Offset = "0x210F5D0", VA = "0x1821109D0")]
		public RoguelikeCommonDevelopmentData()
		{
		}

		// Token: 0x0400622D RID: 25133
		[Token(Token = "0x400622D")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, RoguelikeCommonDevelopment> developments;

		// Token: 0x0400622E RID: 25134
		[Token(Token = "0x400622E")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, RoguelikeTopicDevToken> developmentsTokens;

		// Token: 0x0400622F RID: 25135
		[Token(Token = "0x400622F")]
		[FieldOffset(Offset = "0x20")]
		public List<RoguelikeCommonDevRawTextBuffGroup> developmentRawTextGroup;

		// Token: 0x04006230 RID: 25136
		[Token(Token = "0x4006230")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, RoguelikeCommonDevDifficultyNodeInfo> developmentsDifficultyNodeInfos;
	}
}
