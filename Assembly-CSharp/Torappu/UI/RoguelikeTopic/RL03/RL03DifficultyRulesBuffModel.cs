using System;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic.RL03
{
	// Token: 0x020045BE RID: 17854
	[Token(Token = "0x20045BE")]
	public class RL03DifficultyRulesBuffModel
	{
		// Token: 0x170040BA RID: 16570
		// (get) Token: 0x0601B2B5 RID: 111285 RVA: 0x000A48B0 File Offset: 0x000A2AB0
		[Token(Token = "0x170040BA")]
		public RoguelikeTopicDifficultyID diffId
		{
			[Token(Token = "0x601B2B5")]
			[Address(RVA = "0x14472D0", Offset = "0x1445ED0", VA = "0x1814472D0")]
			get
			{
				return default(RoguelikeTopicDifficultyID);
			}
		}

		// Token: 0x0601B2B6 RID: 111286 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B2B6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RL03DifficultyRulesBuffModel()
		{
		}

		// Token: 0x04022FE6 RID: 143334
		[Token(Token = "0x4022FE6")]
		[FieldOffset(Offset = "0x10")]
		public string buffId;

		// Token: 0x04022FE7 RID: 143335
		[Token(Token = "0x4022FE7")]
		[FieldOffset(Offset = "0x18")]
		public RL03Development buffData;

		// Token: 0x04022FE8 RID: 143336
		[Token(Token = "0x4022FE8")]
		[FieldOffset(Offset = "0x20")]
		public RoguelikeTopicDifficulty diffData;
	}
}
