using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ActArchive
{
	// Token: 0x02006C27 RID: 27687
	[Token(Token = "0x2006C27")]
	public class StoryCompInfo : ActArchiveCompInfo
	{
		// Token: 0x06027870 RID: 161904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027870")]
		[Address(RVA = "0x22BBA20", Offset = "0x22BA620", VA = "0x1822BBA20")]
		public StoryCompInfo(ActArchiveInfo archiveInfo)
		{
		}

		// Token: 0x06027871 RID: 161905 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027871")]
		[Address(RVA = "0x22BB4E0", Offset = "0x22BA0E0", VA = "0x1822BB4E0")]
		public StoryItemModel GetStoryItemInfo(string storyId)
		{
			return null;
		}

		// Token: 0x06027872 RID: 161906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027872")]
		[Address(RVA = "0x22BB870", Offset = "0x22BA470", VA = "0x1822BB870")]
		public void SetSelectedStoryItem(string storyID, bool isInit)
		{
		}

		// Token: 0x06027873 RID: 161907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027873")]
		[Address(RVA = "0x22BB650", Offset = "0x22BA250", VA = "0x1822BB650", Slot = "4")]
		public override void LoadData(string archiveId)
		{
		}

		// Token: 0x06027874 RID: 161908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027874")]
		[Address(RVA = "0x22BB2C0", Offset = "0x22B9EC0", VA = "0x1822BB2C0", Slot = "5")]
		public override void ApplyDataBundle(DataBundle data)
		{
		}

		// Token: 0x06027875 RID: 161909 RVA: 0x000CEA30 File Offset: 0x000CCC30
		[Token(Token = "0x6027875")]
		[Address(RVA = "0x22BB5D0", Offset = "0x22BA1D0", VA = "0x1822BB5D0", Slot = "6")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06027876 RID: 161910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027876")]
		[Address(RVA = "0x22BB7C0", Offset = "0x22BA3C0", VA = "0x1822BB7C0", Slot = "7")]
		public override void NotifyUpdate()
		{
		}

		// Token: 0x040380B1 RID: 229553
		[Token(Token = "0x40380B1")]
		[FieldOffset(Offset = "0x18")]
		public StoryProperty story;

		// Token: 0x040380B2 RID: 229554
		[Token(Token = "0x40380B2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x040380B3 RID: 229555
		[Token(Token = "0x40380B3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetStoryItemInfo;

		// Token: 0x040380B4 RID: 229556
		[Token(Token = "0x40380B4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetSelectedStoryItem;

		// Token: 0x040380B5 RID: 229557
		[Token(Token = "0x40380B5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x040380B6 RID: 229558
		[Token(Token = "0x40380B6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ApplyDataBundle;

		// Token: 0x040380B7 RID: 229559
		[Token(Token = "0x40380B7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_IsValid;

		// Token: 0x040380B8 RID: 229560
		[Token(Token = "0x40380B8")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_NotifyUpdate;
	}
}
