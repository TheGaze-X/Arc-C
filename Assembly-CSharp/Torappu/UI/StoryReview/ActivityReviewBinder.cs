using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x02004902 RID: 18690
	[Token(Token = "0x2004902")]
	public class ActivityReviewBinder : DataBinder<StoryReviewProperty>, IHotfixable
	{
		// Token: 0x0601C313 RID: 115475 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C313")]
		[Address(RVA = "0x15AA580", Offset = "0x15A9180", VA = "0x1815AA580", Slot = "7")]
		public override void OnValueChanged(StoryReviewProperty property)
		{
		}

		// Token: 0x0601C314 RID: 115476 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C314")]
		[Address(RVA = "0x15AA630", Offset = "0x15A9230", VA = "0x1815AA630")]
		public void SetCallbacks(Action<string> onReviewChapterClicked, Action<string> onChapterRewardsGain)
		{
		}

		// Token: 0x0601C315 RID: 115477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C315")]
		[Address(RVA = "0x15AA6F0", Offset = "0x15A92F0", VA = "0x1815AA6F0")]
		public ActivityReviewBinder()
		{
		}

		// Token: 0x04024D95 RID: 150933
		[Token(Token = "0x4024D95")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private ActivityReviewAdapter _activityReviewAdapter;

		// Token: 0x04024D96 RID: 150934
		[Token(Token = "0x4024D96")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04024D97 RID: 150935
		[Token(Token = "0x4024D97")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_SetCallbacks;

		// Token: 0x04024D98 RID: 150936
		[Token(Token = "0x4024D98")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
