using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020011DD RID: 4573
	[Token(Token = "0x20011DD")]
	public class RL03CustomizeData
	{
		// Token: 0x06006FCA RID: 28618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6006FCA")]
		[Address(RVA = "0x210C230", Offset = "0x210AE30", VA = "0x18210C230")]
		public RL03CustomizeData()
		{
		}

		// Token: 0x04006227 RID: 25127
		[Token(Token = "0x4006227")]
		[FieldOffset(Offset = "0x10")]
		public Dictionary<string, RL03Development> developments;

		// Token: 0x04006228 RID: 25128
		[Token(Token = "0x4006228")]
		[FieldOffset(Offset = "0x18")]
		public Dictionary<string, RoguelikeTopicDevToken> developmentsTokens;

		// Token: 0x04006229 RID: 25129
		[Token(Token = "0x4006229")]
		[FieldOffset(Offset = "0x20")]
		public List<RL03DevRawTextBuffGroup> developmentRawTextGroup;

		// Token: 0x0400622A RID: 25130
		[Token(Token = "0x400622A")]
		[FieldOffset(Offset = "0x28")]
		public Dictionary<string, RL03DevDifficultyNodeInfo> developmentsDifficultyNodeInfos;

		// Token: 0x0400622B RID: 25131
		[Token(Token = "0x400622B")]
		[FieldOffset(Offset = "0x30")]
		public RL03EndingText endingText;

		// Token: 0x0400622C RID: 25132
		[Token(Token = "0x400622C")]
		[FieldOffset(Offset = "0x38")]
		public List<RL03DifficultyExt> difficulties;
	}
}
