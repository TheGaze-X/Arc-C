using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.Stage
{
	// Token: 0x0200684B RID: 26699
	[Token(Token = "0x200684B")]
	public class ConfirmSixStarRewardRequest
	{
		// Token: 0x06026388 RID: 156552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026388")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ConfirmSixStarRewardRequest()
		{
		}

		// Token: 0x04035DFD RID: 220669
		[Token(Token = "0x4035DFD")]
		[FieldOffset(Offset = "0x10")]
		public string groupId;

		// Token: 0x04035DFE RID: 220670
		[Token(Token = "0x4035DFE")]
		[FieldOffset(Offset = "0x18")]
		public List<string> rewardIds;
	}
}
