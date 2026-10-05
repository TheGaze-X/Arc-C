using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.TemplateMission
{
	// Token: 0x02003D81 RID: 15745
	[Token(Token = "0x2003D81")]
	public class TemplateMissionCommonConfirmResponse : PlayerDeltaResponse
	{
		// Token: 0x060187E9 RID: 100329 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60187E9")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public TemplateMissionCommonConfirmResponse()
		{
		}

		// Token: 0x0401E032 RID: 122930
		[Token(Token = "0x401E032")]
		[FieldOffset(Offset = "0x28")]
		public List<RewardItemModel> items;
	}
}
