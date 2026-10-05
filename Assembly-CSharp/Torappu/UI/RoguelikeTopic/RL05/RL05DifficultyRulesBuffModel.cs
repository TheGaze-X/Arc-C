using System;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic.RL05
{
	// Token: 0x0200459C RID: 17820
	[Token(Token = "0x200459C")]
	public class RL05DifficultyRulesBuffModel
	{
		// Token: 0x170040A6 RID: 16550
		// (get) Token: 0x0601B214 RID: 111124 RVA: 0x000A4730 File Offset: 0x000A2930
		[Token(Token = "0x170040A6")]
		public RoguelikeTopicDifficultyID diffId
		{
			[Token(Token = "0x601B214")]
			[Address(RVA = "0x144E320", Offset = "0x144CF20", VA = "0x18144E320")]
			get
			{
				return default(RoguelikeTopicDifficultyID);
			}
		}

		// Token: 0x0601B215 RID: 111125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B215")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RL05DifficultyRulesBuffModel()
		{
		}

		// Token: 0x04022EAC RID: 143020
		[Token(Token = "0x4022EAC")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeCommonDevelopment buffData;

		// Token: 0x04022EAD RID: 143021
		[Token(Token = "0x4022EAD")]
		[FieldOffset(Offset = "0x18")]
		public RoguelikeTopicDifficulty diffData;
	}
}
