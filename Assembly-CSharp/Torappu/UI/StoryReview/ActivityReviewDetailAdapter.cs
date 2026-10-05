using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x02004904 RID: 18692
	[Token(Token = "0x2004904")]
	public class ActivityReviewDetailAdapter : LoopScrollAdapter<ActivityReviewDetailItemHolder, StoryReviewViewModel>, IHotfixable
	{
		// Token: 0x0601C317 RID: 115479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C317")]
		[Address(RVA = "0x15AA760", Offset = "0x15A9360", VA = "0x1815AA760", Slot = "8")]
		public override GameObject CreateView(Transform parent)
		{
			return null;
		}

		// Token: 0x0601C318 RID: 115480 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C318")]
		[Address(RVA = "0x15AA890", Offset = "0x15A9490", VA = "0x1815AA890", Slot = "13")]
		public override void UpdateView(int position, GameObject view, ActivityReviewDetailItemHolder holder, StoryReviewViewModel data)
		{
		}

		// Token: 0x0601C319 RID: 115481 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C319")]
		[Address(RVA = "0x15AAA00", Offset = "0x15A9600", VA = "0x1815AAA00")]
		public ActivityReviewDetailAdapter()
		{
		}

		// Token: 0x04024D9B RID: 150939
		[Token(Token = "0x4024D9B")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private GameObject _itemTemplate;

		// Token: 0x04024D9C RID: 150940
		[Token(Token = "0x4024D9C")]
		[FieldOffset(Offset = "0x60")]
		[NonSerialized]
		public Action<string> onReviewStoryClicked;

		// Token: 0x04024D9D RID: 150941
		[Token(Token = "0x4024D9D")]
		[FieldOffset(Offset = "0x68")]
		[NonSerialized]
		public Action<string> onUnlockStoryClicked;

		// Token: 0x04024D9E RID: 150942
		[Token(Token = "0x4024D9E")]
		[FieldOffset(Offset = "0x70")]
		[NonSerialized]
		public Action<string> onStoryRead;

		// Token: 0x04024D9F RID: 150943
		[Token(Token = "0x4024D9F")]
		[FieldOffset(Offset = "0x78")]
		[NonSerialized]
		public bool m_ActivityOutOfTime;

		// Token: 0x04024DA0 RID: 150944
		[Token(Token = "0x4024DA0")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CreateView;

		// Token: 0x04024DA1 RID: 150945
		[Token(Token = "0x4024DA1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_UpdateView;

		// Token: 0x04024DA2 RID: 150946
		[Token(Token = "0x4024DA2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
