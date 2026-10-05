using System;
using Il2CppDummyDll;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x020073B5 RID: 29621
	[Token(Token = "0x20073B5")]
	public class Act42D0RewardAreaViewModel
	{
		// Token: 0x06029DB6 RID: 171446 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029DB6")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public Act42D0RewardAreaViewModel()
		{
		}

		// Token: 0x0403BFC3 RID: 245699
		[Token(Token = "0x403BFC3")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, Act42D0RewardTitleViewModel> titles;

		// Token: 0x0403BFC4 RID: 245700
		[Token(Token = "0x403BFC4")]
		[FieldOffset(Offset = "0x18")]
		public ListDict<string, Act42D0RewardStageViewModel> stages;

		// Token: 0x0403BFC5 RID: 245701
		[Token(Token = "0x403BFC5")]
		[FieldOffset(Offset = "0x20")]
		public string areaId;

		// Token: 0x0403BFC6 RID: 245702
		[Token(Token = "0x403BFC6")]
		[FieldOffset(Offset = "0x28")]
		public string areaCode;

		// Token: 0x0403BFC7 RID: 245703
		[Token(Token = "0x403BFC7")]
		[FieldOffset(Offset = "0x30")]
		public int sortId;

		// Token: 0x0403BFC8 RID: 245704
		[Token(Token = "0x403BFC8")]
		[FieldOffset(Offset = "0x34")]
		public bool isClear;
	}
}
