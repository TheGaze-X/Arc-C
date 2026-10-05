using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C24 RID: 27684
	[Token(Token = "0x2006C24")]
	public class ArchiveStoryModel : IHotfixable
	{
		// Token: 0x06027867 RID: 161895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027867")]
		[Address(RVA = "0x22B5BF0", Offset = "0x22B47F0", VA = "0x1822B5BF0")]
		public void LoadData(string archiveId, ActArchiveComponentData compData, ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027868 RID: 161896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027868")]
		[Address(RVA = "0x22B61F0", Offset = "0x22B4DF0", VA = "0x1822B61F0")]
		private ActArchiveResData.StoryArchiveResItemData _getArchiveStoryResData(string storyId)
		{
			return null;
		}

		// Token: 0x06027869 RID: 161897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027869")]
		[Address(RVA = "0x22B59D0", Offset = "0x22B45D0", VA = "0x1822B59D0")]
		public string GetDefaultItemID()
		{
			return null;
		}

		// Token: 0x0602786A RID: 161898 RVA: 0x000CEA00 File Offset: 0x000CCC00
		[Token(Token = "0x602786A")]
		[Address(RVA = "0x22B5B60", Offset = "0x22B4760", VA = "0x1822B5B60")]
		public int GetSelectedIndex(string selectedItemId)
		{
			return 0;
		}

		// Token: 0x0602786B RID: 161899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602786B")]
		[Address(RVA = "0x22B6140", Offset = "0x22B4D40", VA = "0x1822B6140")]
		public ArchiveStoryModel()
		{
		}

		// Token: 0x040380A7 RID: 229543
		[Token(Token = "0x40380A7")]
		[FieldOffset(Offset = "0x10")]
		public ListDict<string, StoryItemModel> storyItems;

		// Token: 0x040380A8 RID: 229544
		[Token(Token = "0x40380A8")]
		[FieldOffset(Offset = "0x18")]
		public string selectedStoryId;

		// Token: 0x040380A9 RID: 229545
		[Token(Token = "0x40380A9")]
		[FieldOffset(Offset = "0x20")]
		public bool isInit;

		// Token: 0x040380AA RID: 229546
		[Token(Token = "0x40380AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040380AB RID: 229547
		[Token(Token = "0x40380AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__getArchiveStoryResData;

		// Token: 0x040380AC RID: 229548
		[Token(Token = "0x40380AC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetDefaultItemID;

		// Token: 0x040380AD RID: 229549
		[Token(Token = "0x40380AD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetSelectedIndex;

		// Token: 0x040380AE RID: 229550
		[Token(Token = "0x40380AE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
