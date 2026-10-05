using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007392 RID: 29586
	[Token(Token = "0x2007392")]
	public class NewestProgress : IHotfixable
	{
		// Token: 0x06029D35 RID: 171317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D35")]
		[Address(RVA = "0x2580460", Offset = "0x257F060", VA = "0x182580460")]
		public NewestProgress()
		{
		}

		// Token: 0x0403BE6D RID: 245357
		[Token(Token = "0x403BE6D")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x0403BE6E RID: 245358
		[Token(Token = "0x403BE6E")]
		[FieldOffset(Offset = "0x18")]
		public string areaId;

		// Token: 0x0403BE6F RID: 245359
		[Token(Token = "0x403BE6F")]
		[FieldOffset(Offset = "0x20")]
		public Act42D0Data.Act42D0AreaDifficulty difficulty;

		// Token: 0x0403BE70 RID: 245360
		[Token(Token = "0x403BE70")]
		[FieldOffset(Offset = "0x28")]
		public string areaCode;

		// Token: 0x0403BE71 RID: 245361
		[Token(Token = "0x403BE71")]
		[FieldOffset(Offset = "0x30")]
		public string stageCode;

		// Token: 0x0403BE72 RID: 245362
		[Token(Token = "0x403BE72")]
		[FieldOffset(Offset = "0x38")]
		public string progressShortName;

		// Token: 0x0403BE73 RID: 245363
		[Token(Token = "0x403BE73")]
		[FieldOffset(Offset = "0x40")]
		public string rateDesc;

		// Token: 0x0403BE74 RID: 245364
		[Token(Token = "0x403BE74")]
		[FieldOffset(Offset = "0x48")]
		public string achieveIcon;

		// Token: 0x0403BE75 RID: 245365
		[Token(Token = "0x403BE75")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
