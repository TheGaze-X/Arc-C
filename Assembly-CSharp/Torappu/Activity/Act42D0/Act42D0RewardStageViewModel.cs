using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x020073B3 RID: 29619
	[Token(Token = "0x20073B3")]
	public class Act42D0RewardStageViewModel
	{
		// Token: 0x06029DB3 RID: 171443 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DB3")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act42D0RewardStageViewModel()
		{
		}

		// Token: 0x0403BFBD RID: 245693
		[Token(Token = "0x403BFBD")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x0403BFBE RID: 245694
		[Token(Token = "0x403BFBE")]
		[FieldOffset(Offset = "0x18")]
		public string stageCode;

		// Token: 0x0403BFBF RID: 245695
		[Token(Token = "0x403BFBF")]
		[FieldOffset(Offset = "0x20")]
		public int sortId;

		// Token: 0x0403BFC0 RID: 245696
		[Token(Token = "0x403BFC0")]
		[FieldOffset(Offset = "0x28")]
		public List<Act42D0RewardStageItemViewModel> items;
	}
}
