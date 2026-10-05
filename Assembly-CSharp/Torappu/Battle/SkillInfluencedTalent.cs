using System;
using Il2CppDummyDll;

namespace Torappu.Battle
{
	// Token: 0x02002497 RID: 9367
	[Token(Token = "0x2002497")]
	[Obsolete("Use |_influenceSkillBlackboard| in |Talent| instead")]
	public class SkillInfluencedTalent : Talent
	{
		// Token: 0x0600F0E8 RID: 61672 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600F0E8")]
		[Address(RVA = "0x697210", Offset = "0x695E10", VA = "0x180697210", Slot = "23")]
		public override Blackboard GetSkillBlackboardFromRawData(TalentData data)
		{
			return null;
		}

		// Token: 0x0600F0E9 RID: 61673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600F0E9")]
		[Address(RVA = "0x697270", Offset = "0x695E70", VA = "0x180697270")]
		public SkillInfluencedTalent()
		{
		}
	}
}
