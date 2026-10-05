using System;
using Il2CppDummyDll;

namespace Torappu
{
	// Token: 0x020006AD RID: 1709
	[Token(Token = "0x20006AD")]
	public class CampaignConfirmBreakRewardRequest
	{
		// Token: 0x060062E9 RID: 25321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60062E9")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public CampaignConfirmBreakRewardRequest()
		{
		}

		// Token: 0x04002E94 RID: 11924
		[Token(Token = "0x4002E94")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x04002E95 RID: 11925
		[Token(Token = "0x4002E95")]
		[FieldOffset(Offset = "0x18")]
		public int[] indexList;
	}
}
