using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048FD RID: 18685
	[Token(Token = "0x20048FD")]
	public class StoryReviewViewModel : IHotfixable, IComparable<StoryReviewViewModel>
	{
		// Token: 0x0601C308 RID: 115464 RVA: 0x000A7838 File Offset: 0x000A5A38
		[Token(Token = "0x601C308")]
		[Address(RVA = "0x15A81F0", Offset = "0x15A6DF0", VA = "0x1815A81F0", Slot = "4")]
		public int CompareTo(StoryReviewViewModel viewModel)
		{
			return 0;
		}

		// Token: 0x0601C309 RID: 115465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C309")]
		[Address(RVA = "0x15A8270", Offset = "0x15A6E70", VA = "0x1815A8270")]
		public StoryReviewViewModel()
		{
		}

		// Token: 0x04024D62 RID: 150882
		[Token(Token = "0x4024D62")]
		[FieldOffset(Offset = "0x10")]
		public string storyId;

		// Token: 0x04024D63 RID: 150883
		[Token(Token = "0x4024D63")]
		[FieldOffset(Offset = "0x18")]
		public string storyGroup;

		// Token: 0x04024D64 RID: 150884
		[Token(Token = "0x4024D64")]
		[FieldOffset(Offset = "0x20")]
		public int storySort;

		// Token: 0x04024D65 RID: 150885
		[Token(Token = "0x4024D65")]
		[FieldOffset(Offset = "0x28")]
		public string storyName;

		// Token: 0x04024D66 RID: 150886
		[Token(Token = "0x4024D66")]
		[FieldOffset(Offset = "0x30")]
		public string storyPic;

		// Token: 0x04024D67 RID: 150887
		[Token(Token = "0x4024D67")]
		[FieldOffset(Offset = "0x38")]
		public string storyInfo;

		// Token: 0x04024D68 RID: 150888
		[Token(Token = "0x4024D68")]
		[FieldOffset(Offset = "0x40")]
		public string storyText;

		// Token: 0x04024D69 RID: 150889
		[Token(Token = "0x4024D69")]
		[FieldOffset(Offset = "0x48")]
		public string avgTag;

		// Token: 0x04024D6A RID: 150890
		[Token(Token = "0x4024D6A")]
		[FieldOffset(Offset = "0x50")]
		public string storyMainPicId;

		// Token: 0x04024D6B RID: 150891
		[Token(Token = "0x4024D6B")]
		[FieldOffset(Offset = "0x58")]
		public StoryReviewUnlockType unlockType;

		// Token: 0x04024D6C RID: 150892
		[Token(Token = "0x4024D6C")]
		[FieldOffset(Offset = "0x5C")]
		public ItemType costItemType;

		// Token: 0x04024D6D RID: 150893
		[Token(Token = "0x4024D6D")]
		[FieldOffset(Offset = "0x60")]
		public string costItemId;

		// Token: 0x04024D6E RID: 150894
		[Token(Token = "0x4024D6E")]
		[FieldOffset(Offset = "0x68")]
		public int costItemCount;

		// Token: 0x04024D6F RID: 150895
		[Token(Token = "0x4024D6F")]
		[FieldOffset(Offset = "0x70")]
		public string storyCode;

		// Token: 0x04024D70 RID: 150896
		[Token(Token = "0x4024D70")]
		[FieldOffset(Offset = "0x78")]
		public string storyDependence;

		// Token: 0x04024D71 RID: 150897
		[Token(Token = "0x4024D71")]
		[FieldOffset(Offset = "0x80")]
		public StoryData.Condition.StageCondition[] requiredStages;

		// Token: 0x04024D72 RID: 150898
		[Token(Token = "0x4024D72")]
		[FieldOffset(Offset = "0x88")]
		public bool isLocked;

		// Token: 0x04024D73 RID: 150899
		[Token(Token = "0x4024D73")]
		[FieldOffset(Offset = "0x89")]
		public bool isRead;

		// Token: 0x04024D74 RID: 150900
		[Token(Token = "0x4024D74")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CompareTo;

		// Token: 0x04024D75 RID: 150901
		[Token(Token = "0x4024D75")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
