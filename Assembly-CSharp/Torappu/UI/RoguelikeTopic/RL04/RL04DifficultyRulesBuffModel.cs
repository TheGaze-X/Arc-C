using System;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic.RL04
{
	// Token: 0x020046D2 RID: 18130
	[Token(Token = "0x20046D2")]
	public class RL04DifficultyRulesBuffModel
	{
		// Token: 0x17004174 RID: 16756
		// (get) Token: 0x0601B7E9 RID: 112617 RVA: 0x000A5600 File Offset: 0x000A3800
		[Token(Token = "0x17004174")]
		public RoguelikeTopicDifficultyID diffId
		{
			[Token(Token = "0x601B7E9")]
			[Address(RVA = "0x14C48B0", Offset = "0x14C34B0", VA = "0x1814C48B0")]
			get
			{
				return default(RoguelikeTopicDifficultyID);
			}
		}

		// Token: 0x0601B7EA RID: 112618 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B7EA")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RL04DifficultyRulesBuffModel()
		{
		}

		// Token: 0x040239CF RID: 145871
		[Token(Token = "0x40239CF")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeCommonDevelopment buffData;

		// Token: 0x040239D0 RID: 145872
		[Token(Token = "0x40239D0")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeTopicDifficulty diffData;
	}
}
