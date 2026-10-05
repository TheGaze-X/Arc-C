using System;
using Il2CppDummyDll;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x0200457C RID: 17788
	[Token(Token = "0x200457C")]
	public class RoguelikeTopicDifficultyViewModel
	{
		// Token: 0x17004089 RID: 16521
		// (get) Token: 0x0601B156 RID: 110934 RVA: 0x000A44A8 File Offset: 0x000A26A8
		[Token(Token = "0x17004089")]
		public bool isUnlock
		{
			[Token(Token = "0x601B156")]
			[Address(RVA = "0x629540", Offset = "0x628140", VA = "0x180629540")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700408A RID: 16522
		// (get) Token: 0x0601B157 RID: 110935 RVA: 0x000A44C0 File Offset: 0x000A26C0
		[Token(Token = "0x1700408A")]
		public RoguelikeTopicMode modeDifficulty
		{
			[Token(Token = "0x601B157")]
			[Address(RVA = "0x5BA1B0", Offset = "0x5B8DB0", VA = "0x1805BA1B0")]
			get
			{
				return RoguelikeTopicMode.NONE;
			}
		}

		// Token: 0x1700408B RID: 16523
		// (get) Token: 0x0601B158 RID: 110936 RVA: 0x000A44D8 File Offset: 0x000A26D8
		[Token(Token = "0x1700408B")]
		public int grade
		{
			[Token(Token = "0x601B158")]
			[Address(RVA = "0x1437670", Offset = "0x1436270", VA = "0x181437670")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700408C RID: 16524
		// (get) Token: 0x0601B159 RID: 110937 RVA: 0x000A44F0 File Offset: 0x000A26F0
		[Token(Token = "0x1700408C")]
		public RoguelikeTopicDifficultyID id
		{
			[Token(Token = "0x601B159")]
			[Address(RVA = "0x1437690", Offset = "0x1436290", VA = "0x181437690")]
			get
			{
				return default(RoguelikeTopicDifficultyID);
			}
		}

		// Token: 0x1700408D RID: 16525
		// (get) Token: 0x0601B15A RID: 110938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700408D")]
		public string ruleDescAfterReplacement
		{
			[Token(Token = "0x601B15A")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601B15B RID: 110939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B15B")]
		[Address(RVA = "0x1437580", Offset = "0x1436180", VA = "0x181437580")]
		public void InitRuleDesc()
		{
		}

		// Token: 0x0601B15C RID: 110940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601B15C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public RoguelikeTopicDifficultyViewModel()
		{
		}

		// Token: 0x04022D4C RID: 142668
		[Token(Token = "0x4022D4C")]
		[FieldOffset(Offset = "0x10")]
		public RoguelikeTopicDifficulty diffcultyData;

		// Token: 0x04022D4D RID: 142669
		[Token(Token = "0x4022D4D")]
		[FieldOffset(Offset = "0x18")]
		public PlayerRoguelikeDifficultyStatus status;

		// Token: 0x04022D4E RID: 142670
		[Token(Token = "0x4022D4E")]
		[FieldOffset(Offset = "0x20")]
		public string topicId;

		// Token: 0x04022D4F RID: 142671
		[Token(Token = "0x4022D4F")]
		[FieldOffset(Offset = "0x28")]
		private string m_cachedRuleDesc;
	}
}
