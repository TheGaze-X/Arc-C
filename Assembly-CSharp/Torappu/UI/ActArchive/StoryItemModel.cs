using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C23 RID: 27683
	[Token(Token = "0x2006C23")]
	public class StoryItemModel : ArchiveItemModel
	{
		// Token: 0x06027864 RID: 161892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027864")]
		[Address(RVA = "0x22BBB20", Offset = "0x22BA720", VA = "0x1822BBB20", Slot = "4")]
		public override string GetFuncId()
		{
			return null;
		}

		// Token: 0x06027865 RID: 161893 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027865")]
		[Address(RVA = "0x22BBA90", Offset = "0x22BA690", VA = "0x1822BBA90", Slot = "5")]
		public override string GetDesc()
		{
			return null;
		}

		// Token: 0x06027866 RID: 161894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027866")]
		[Address(RVA = "0x22BBB80", Offset = "0x22BA780", VA = "0x1822BBB80")]
		public StoryItemModel()
		{
		}

		// Token: 0x040380A1 RID: 229537
		[Token(Token = "0x40380A1")]
		[FieldOffset(Offset = "0x30")]
		public ActArchiveResData.StoryArchiveResItemData storyItemData;

		// Token: 0x040380A2 RID: 229538
		[Token(Token = "0x40380A2")]
		[FieldOffset(Offset = "0x38")]
		public string storyId;

		// Token: 0x040380A3 RID: 229539
		[Token(Token = "0x40380A3")]
		[FieldOffset(Offset = "0x40")]
		public int sortId;

		// Token: 0x040380A4 RID: 229540
		[Token(Token = "0x40380A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetFuncId;

		// Token: 0x040380A5 RID: 229541
		[Token(Token = "0x40380A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetDesc;

		// Token: 0x040380A6 RID: 229542
		[Token(Token = "0x40380A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
