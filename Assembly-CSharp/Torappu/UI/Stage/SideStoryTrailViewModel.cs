using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage
{
	// Token: 0x0200680D RID: 26637
	[Token(Token = "0x200680D")]
	public class SideStoryTrailViewModel : IHotfixable
	{
		// Token: 0x060262AE RID: 156334 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262AE")]
		[Address(RVA = "0x2136850", Offset = "0x2135450", VA = "0x182136850")]
		public void InitData(int totalCount, RetroTrailRewardItem i_data, bool i_isAlreadyGet)
		{
		}

		// Token: 0x060262AF RID: 156335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60262AF")]
		[Address(RVA = "0x2136950", Offset = "0x2135550", VA = "0x182136950")]
		public SideStoryTrailViewModel()
		{
		}

		// Token: 0x04035C41 RID: 220225
		[Token(Token = "0x4035C41")]
		[FieldOffset(Offset = "0x10")]
		public RetroTrailRewardItem data;

		// Token: 0x04035C42 RID: 220226
		[Token(Token = "0x4035C42")]
		[FieldOffset(Offset = "0x18")]
		public bool isAvail;

		// Token: 0x04035C43 RID: 220227
		[Token(Token = "0x4035C43")]
		[FieldOffset(Offset = "0x19")]
		public bool isAlreadyGet;

		// Token: 0x04035C44 RID: 220228
		[Token(Token = "0x4035C44")]
		[FieldOffset(Offset = "0x1A")]
		public bool isAchieve;

		// Token: 0x04035C45 RID: 220229
		[Token(Token = "0x4035C45")]
		[FieldOffset(Offset = "0x20")]
		public UniCollectionInfo uniCollectionInfo;

		// Token: 0x04035C46 RID: 220230
		[Token(Token = "0x4035C46")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x04035C47 RID: 220231
		[Token(Token = "0x4035C47")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
