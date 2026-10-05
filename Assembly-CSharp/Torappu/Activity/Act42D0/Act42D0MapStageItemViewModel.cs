using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Activity.Act42D0
{
	// Token: 0x02007395 RID: 29589
	[Token(Token = "0x2007395")]
	public class Act42D0MapStageItemViewModel : IHotfixable
	{
		// Token: 0x06029D43 RID: 171331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029D43")]
		[Address(RVA = "0x2571EC0", Offset = "0x2570AC0", VA = "0x182571EC0")]
		public Act42D0MapStageItemViewModel()
		{
		}

		// Token: 0x0403BE8B RID: 245387
		[Token(Token = "0x403BE8B")]
		[FieldOffset(Offset = "0x10")]
		public string stageId;

		// Token: 0x0403BE8C RID: 245388
		[Token(Token = "0x403BE8C")]
		[FieldOffset(Offset = "0x18")]
		public string areaCode;

		// Token: 0x0403BE8D RID: 245389
		[Token(Token = "0x403BE8D")]
		[FieldOffset(Offset = "0x20")]
		public int ratingGot;

		// Token: 0x0403BE8E RID: 245390
		[Token(Token = "0x403BE8E")]
		[FieldOffset(Offset = "0x28")]
		public string ratingIconId;

		// Token: 0x0403BE8F RID: 245391
		[Token(Token = "0x403BE8F")]
		[FieldOffset(Offset = "0x30")]
		public int ratingMax;

		// Token: 0x0403BE90 RID: 245392
		[Token(Token = "0x403BE90")]
		[FieldOffset(Offset = "0x34")]
		public bool isKeyStage;

		// Token: 0x0403BE91 RID: 245393
		[Token(Token = "0x403BE91")]
		[FieldOffset(Offset = "0x38")]
		public Act42D0Data.Act42D0StageInfoData stageInfoData;

		// Token: 0x0403BE92 RID: 245394
		[Token(Token = "0x403BE92")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
