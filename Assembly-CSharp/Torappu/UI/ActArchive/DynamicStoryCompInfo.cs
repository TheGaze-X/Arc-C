using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C28 RID: 27688
	[Token(Token = "0x2006C28")]
	public class DynamicStoryCompInfo : ActArchiveCompInfo
	{
		// Token: 0x06027877 RID: 161911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027877")]
		[Address(RVA = "0x22B9420", Offset = "0x22B8020", VA = "0x1822B9420")]
		public DynamicStoryCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027878 RID: 161912 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027878")]
		[Address(RVA = "0x22B8EE0", Offset = "0x22B7AE0", VA = "0x1822B8EE0")]
		public StoryItemModel GetStoryItemInfo(string storyId)
		{
			return null;
		}

		// Token: 0x06027879 RID: 161913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027879")]
		[Address(RVA = "0x22B9270", Offset = "0x22B7E70", VA = "0x1822B9270")]
		public void SetSelectedStoryItem(string storyID, bool isInit)
		{
		}

		// Token: 0x0602787A RID: 161914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602787A")]
		[Address(RVA = "0x22B9050", Offset = "0x22B7C50", VA = "0x1822B9050", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x0602787B RID: 161915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602787B")]
		[Address(RVA = "0x22B8CC0", Offset = "0x22B78C0", VA = "0x1822B8CC0", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x0602787C RID: 161916 RVA: 0x000CEA48 File Offset: 0x000CCC48
		[Token(Token = "0x602787C")]
		[Address(RVA = "0x22B8FD0", Offset = "0x22B7BD0", VA = "0x1822B8FD0", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x0602787D RID: 161917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602787D")]
		[Address(RVA = "0x22B91C0", Offset = "0x22B7DC0", VA = "0x1822B91C0", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x040380B9 RID: 229561
		[Token(Token = "0x40380B9")]
		[FieldOffset(Offset = "0x18")]
		public StoryProperty story;

		// Token: 0x040380BA RID: 229562
		[Token(Token = "0x40380BA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040380BB RID: 229563
		[Token(Token = "0x40380BB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetStoryItemInfo;

		// Token: 0x040380BC RID: 229564
		[Token(Token = "0x40380BC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelectedStoryItem;

		// Token: 0x040380BD RID: 229565
		[Token(Token = "0x40380BD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040380BE RID: 229566
		[Token(Token = "0x40380BE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x040380BF RID: 229567
		[Token(Token = "0x40380BF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x040380C0 RID: 229568
		[Token(Token = "0x40380C0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;
	}
}
