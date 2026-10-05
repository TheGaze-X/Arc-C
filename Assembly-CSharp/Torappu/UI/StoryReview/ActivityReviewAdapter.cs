using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x02004901 RID: 18689
	[Token(Token = "0x2004901")]
	public class ActivityReviewAdapter : LoopScrollAdapter<ActivityReviewItemHolder, StoryReviewChapterViewModel>, IHotfixable
	{
		// Token: 0x0601C310 RID: 115472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C310")]
		[Address(RVA = "0x15AA3C0", Offset = "0x15A8FC0", VA = "0x1815AA3C0", Slot = "13")]
		public override void UpdateView(int position, GameObject view, ActivityReviewItemHolder holder, StoryReviewChapterViewModel data)
		{
		}

		// Token: 0x0601C311 RID: 115473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C311")]
		[Address(RVA = "0x15AA290", Offset = "0x15A8E90", VA = "0x1815AA290", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601C312 RID: 115474 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C312")]
		[Address(RVA = "0x15AA510", Offset = "0x15A9110", VA = "0x1815AA510")]
		public ActivityReviewAdapter()
		{
		}

		// Token: 0x04024D8F RID: 150927
		[Token(Token = "0x4024D8F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _itemTemplate;

		// Token: 0x04024D90 RID: 150928
		[Token(Token = "0x4024D90")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public Action<string> onReviewClicked;

		// Token: 0x04024D91 RID: 150929
		[Token(Token = "0x4024D91")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action<string> onRewardsGain;

		// Token: 0x04024D92 RID: 150930
		[Token(Token = "0x4024D92")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04024D93 RID: 150931
		[Token(Token = "0x4024D93")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04024D94 RID: 150932
		[Token(Token = "0x4024D94")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
