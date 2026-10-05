using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x02004905 RID: 18693
	[Token(Token = "0x2004905")]
	public class ActivityReviewDetailBinder : DataBinder<ActivityReviewDetailProperty>, IHotfixable
	{
		// Token: 0x0601C31A RID: 115482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C31A")]
		[Address(RVA = "0x15AAE70", Offset = "0x15A9A70", VA = "0x1815AAE70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C31B RID: 115483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C31B")]
		[Address(RVA = "0x15AAA80", Offset = "0x15A9680", VA = "0x1815AAA80", Slot = "7")]
		public override void OnValueChanged(ActivityReviewDetailProperty property)
		{
		}

		// Token: 0x0601C31C RID: 115484 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601C31C")]
		[Address(RVA = "0x15AADB0", Offset = "0x15A99B0", VA = "0x1815AADB0")]
		private string _GenLockedContent(bool outOfTime)
		{
			return null;
		}

		// Token: 0x0601C31D RID: 115485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C31D")]
		[Address(RVA = "0x15AACD0", Offset = "0x15A98D0", VA = "0x1815AACD0")]
		public void SetCallbacks(Action<string> onReviewStoryClicked, Action<string> onUnlockStoryClicked, Action<string> onStoryRead)
		{
		}

		// Token: 0x0601C31E RID: 115486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C31E")]
		[Address(RVA = "0x15AAEF0", Offset = "0x15A9AF0", VA = "0x1815AAEF0")]
		public ActivityReviewDetailBinder()
		{
		}

		// Token: 0x04024DA3 RID: 150947
		[Token(Token = "0x4024DA3")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _lockedPanel;

		// Token: 0x04024DA4 RID: 150948
		[Token(Token = "0x4024DA4")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _lockedContent;

		// Token: 0x04024DA5 RID: 150949
		[Token(Token = "0x4024DA5")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _maskContainer;

		// Token: 0x04024DA6 RID: 150950
		[Token(Token = "0x4024DA6")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private ActivityReviewDetailAdapter _activityReviewAdapter;

		// Token: 0x04024DA7 RID: 150951
		[Token(Token = "0x4024DA7")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x04024DA8 RID: 150952
		[Token(Token = "0x4024DA8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04024DA9 RID: 150953
		[Token(Token = "0x4024DA9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04024DAA RID: 150954
		[Token(Token = "0x4024DAA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GenLockedContent;

		// Token: 0x04024DAB RID: 150955
		[Token(Token = "0x4024DAB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_SetCallbacks;

		// Token: 0x04024DAC RID: 150956
		[Token(Token = "0x4024DAC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
