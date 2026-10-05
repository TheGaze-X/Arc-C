using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.Stage.MixStory
{
	// Token: 0x02006A76 RID: 27254
	[Token(Token = "0x2006A76")]
	public class ChapterViewModel : IComparable<ChapterViewModel>, IHotfixable
	{
		// Token: 0x06026F4E RID: 159566 RVA: 0x000CCF30 File Offset: 0x000CB130
		[Token(Token = "0x6026F4E")]
		[Address(RVA = "0x2218420", Offset = "0x2217020", VA = "0x182218420", Slot = "4")]
		public int CompareTo(ChapterViewModel other)
		{
			return 0;
		}

		// Token: 0x06026F4F RID: 159567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6026F4F")]
		[Address(RVA = "0x22184B0", Offset = "0x22170B0", VA = "0x1822184B0")]
		public ChapterViewModel()
		{
		}

		// Token: 0x040371A4 RID: 225700
		[Token(Token = "0x40371A4")]
		[FieldOffset(Offset = "0x10")]
		public ChapterData chapterData;

		// Token: 0x040371A5 RID: 225701
		[Token(Token = "0x40371A5")]
		[FieldOffset(Offset = "0x18")]
		public bool isUnlock;

		// Token: 0x040371A6 RID: 225702
		[Token(Token = "0x40371A6")]
		[FieldOffset(Offset = "0x19")]
		public bool isPass;

		// Token: 0x040371A7 RID: 225703
		[Token(Token = "0x40371A7")]
		[FieldOffset(Offset = "0x20")]
		public string curGoingMainlineStageId;

		// Token: 0x040371A8 RID: 225704
		[Token(Token = "0x40371A8")]
		[FieldOffset(Offset = "0x28")]
		public StageData mainlinePreposedStageData;

		// Token: 0x040371A9 RID: 225705
		[Token(Token = "0x40371A9")]
		[FieldOffset(Offset = "0x30")]
		public string lastStageId;

		// Token: 0x040371AA RID: 225706
		[Token(Token = "0x40371AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x040371AB RID: 225707
		[Token(Token = "0x40371AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
