using System;
using Il2CppDummyDll;
using Torappu.UI;

namespace Torappu.Activity.Act42side
{
	// Token: 0x02007303 RID: 29443
	[Token(Token = "0x2007303")]
	public class Act42sideRewardDetailItemViewModel
	{
		// Token: 0x06029A6C RID: 170604 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029A6C")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act42sideRewardDetailItemViewModel()
		{
		}

		// Token: 0x0403B94C RID: 244044
		[Token(Token = "0x403B94C")]
		[FieldOffset(Offset = "0x10")]
		public string title;

		// Token: 0x0403B94D RID: 244045
		[Token(Token = "0x403B94D")]
		[FieldOffset(Offset = "0x18")]
		public Act42sideRewardState rewardState;

		// Token: 0x0403B94E RID: 244046
		[Token(Token = "0x403B94E")]
		[FieldOffset(Offset = "0x20")]
		public UIItemViewModel rewardItem;
	}
}
