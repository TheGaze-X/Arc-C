using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x02001246 RID: 4678
	[Token(Token = "0x2001246")]
	public class RoguelikeDifficultyUpgradeRelicGroupData
	{
		// Token: 0x06007039 RID: 28729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007039")]
		[Address(RVA = "0x2110F90", Offset = "0x210FB90", VA = "0x182110F90")]
		public string GetRelicItemIdByEquivalentGrade(int grade)
		{
			return null;
		}

		// Token: 0x0600703A RID: 28730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600703A")]
		[Address(RVA = "0x21110B0", Offset = "0x210FCB0", VA = "0x1821110B0")]
		public RoguelikeDifficultyUpgradeRelicGroupData()
		{
		}

		// Token: 0x04006531 RID: 25905
		[Token(Token = "0x4006531")]
		[FieldOffset(Offset = "0x10")]
		public List<RoguelikeDifficultyUpgradeRelicData> relicData;
	}
}
