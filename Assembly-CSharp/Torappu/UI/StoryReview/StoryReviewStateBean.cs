using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048FF RID: 18687
	[Token(Token = "0x20048FF")]
	public class StoryReviewStateBean : IStateBean, IHotfixable
	{
		// Token: 0x0601C30B RID: 115467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C30B")]
		[Address(RVA = "0x15A8030", Offset = "0x15A6C30", VA = "0x1815A8030")]
		public void LoadData()
		{
		}

		// Token: 0x0601C30C RID: 115468 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C30C")]
		[Address(RVA = "0x15A7F90", Offset = "0x15A6B90", VA = "0x1815A7F90")]
		public List<StoryReviewChapterViewModel> LoadDataByEntry(StoryReviewEntryType entry)
		{
			return null;
		}

		// Token: 0x0601C30D RID: 115469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C30D")]
		[Address(RVA = "0x15A7DC0", Offset = "0x15A69C0", VA = "0x1815A7DC0")]
		public List<string> GetActiveActIdList()
		{
			return null;
		}

		// Token: 0x0601C30E RID: 115470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C30E")]
		[Address(RVA = "0x15A8100", Offset = "0x15A6D00", VA = "0x1815A8100")]
		public StoryReviewStateBean()
		{
		}

		// Token: 0x04024D88 RID: 150920
		[Token(Token = "0x4024D88")]
		[FieldOffset(Offset = "0x10")]
		public readonly StoryReviewProperty entryProp;

		// Token: 0x04024D89 RID: 150921
		[Token(Token = "0x4024D89")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x04024D8A RID: 150922
		[Token(Token = "0x4024D8A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadDataByEntry;

		// Token: 0x04024D8B RID: 150923
		[Token(Token = "0x4024D8B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetActiveActIdList;

		// Token: 0x04024D8C RID: 150924
		[Token(Token = "0x4024D8C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
