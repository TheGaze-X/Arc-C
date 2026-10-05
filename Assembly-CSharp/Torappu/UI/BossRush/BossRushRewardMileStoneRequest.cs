using System;
using Il2CppDummyDll;

namespace Torappu.UI.BossRush
{
	// Token: 0x02006173 RID: 24947
	[Token(Token = "0x2006173")]
	public class BossRushRewardMileStoneRequest
	{
		// Token: 0x06024002 RID: 147458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6024002")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public BossRushRewardMileStoneRequest()
		{
		}

		// Token: 0x04032032 RID: 204850
		[Token(Token = "0x4032032")]
		[FieldOffset(Offset = "0x10")]
		public string activityId;

		// Token: 0x04032033 RID: 204851
		[Token(Token = "0x4032033")]
		[FieldOffset(Offset = "0x18")]
		public string milestoneId;
	}
}
