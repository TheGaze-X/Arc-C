using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act3D0
{
	// Token: 0x020073D6 RID: 29654
	[Token(Token = "0x20073D6")]
	public class Act3D0GachaResponse : PlayerDeltaResponse
	{
		// Token: 0x06029E38 RID: 171576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029E38")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public Act3D0GachaResponse()
		{
		}

		// Token: 0x0403C090 RID: 245904
		[Token(Token = "0x403C090")]
		[FieldOffset(Offset = "0x28")]
		public List<ActivityItemModel> items;

		// Token: 0x0403C091 RID: 245905
		[Token(Token = "0x403C091")]
		[FieldOffset(Offset = "0x30")]
		public List<string> unlock;

		// Token: 0x0403C092 RID: 245906
		[Token(Token = "0x403C092")]
		[FieldOffset(Offset = "0x38")]
		public List<string> clues;
	}
}
