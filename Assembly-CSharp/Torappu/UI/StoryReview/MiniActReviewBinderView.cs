using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.StoryReview
{
	// Token: 0x020048C0 RID: 18624
	[Token(Token = "0x20048C0")]
	public class MiniActReviewBinderView : DataBinder<StoryReviewProperty>
	{
		// Token: 0x170042AA RID: 17066
		// (get) Token: 0x0601C182 RID: 115074 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042AA")]
		public UICommonTrackPoint newTrialTrackPoint
		{
			[Token(Token = "0x601C182")]
			[Address(RVA = "0x1595F90", Offset = "0x1594B90", VA = "0x181595F90")]
			get
			{
				return null;
			}
		}

		// Token: 0x170042AB RID: 17067
		// (get) Token: 0x0601C183 RID: 115075 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042AB")]
		public UICommonTrackPoint collectTrialTrackPoint
		{
			[Token(Token = "0x601C183")]
			[Address(RVA = "0x1595E70", Offset = "0x1594A70", VA = "0x181595E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x170042AC RID: 17068
		// (get) Token: 0x0601C184 RID: 115076 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042AC")]
		public GameObject trialBtnPanelGo
		{
			[Token(Token = "0x601C184")]
			[Address(RVA = "0x1595FF0", Offset = "0x1594BF0", VA = "0x181595FF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170042AD RID: 17069
		// (get) Token: 0x0601C185 RID: 115077 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042AD")]
		public LoopScrollRect loopScrollRect
		{
			[Token(Token = "0x601C185")]
			[Address(RVA = "0x1595F30", Offset = "0x1594B30", VA = "0x181595F30")]
			get
			{
				return null;
			}
		}

		// Token: 0x170042AE RID: 17070
		// (get) Token: 0x0601C186 RID: 115078 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170042AE")]
		public GridLayoutGroup itemGridLayout
		{
			[Token(Token = "0x601C186")]
			[Address(RVA = "0x1595ED0", Offset = "0x1594AD0", VA = "0x181595ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601C187 RID: 115079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C187")]
		[Address(RVA = "0x1595BC0", Offset = "0x15947C0", VA = "0x181595BC0", Slot = "7")]
		public override void OnValueChanged(StoryReviewProperty property)
		{
		}

		// Token: 0x0601C188 RID: 115080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C188")]
		[Address(RVA = "0x1595C70", Offset = "0x1594870", VA = "0x181595C70")]
		public void SetCallbacks(Action<string> onReviewChapterClicked, Action<string> onChapterRewardsGain, Action onBtnTrial, Action onBtnRule)
		{
		}

		// Token: 0x0601C189 RID: 115081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C189")]
		[Address(RVA = "0x1595B50", Offset = "0x1594750", VA = "0x181595B50")]
		public void OnBtnTrial()
		{
		}

		// Token: 0x0601C18A RID: 115082 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C18A")]
		[Address(RVA = "0x1595AE0", Offset = "0x15946E0", VA = "0x181595AE0")]
		public void OnBtnRule()
		{
		}

		// Token: 0x0601C18B RID: 115083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C18B")]
		[Address(RVA = "0x1595E00", Offset = "0x1594A00", VA = "0x181595E00")]
		public MiniActReviewBinderView()
		{
		}

		// Token: 0x04024B70 RID: 150384
		[Token(Token = "0x4024B70")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private MiniActReviewListAdapter _reviewListAdapter;

		// Token: 0x04024B71 RID: 150385
		[Token(Token = "0x4024B71")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private UICommonTrackPoint _newTrialTrackPoint;

		// Token: 0x04024B72 RID: 150386
		[Token(Token = "0x4024B72")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UICommonTrackPoint _collectTrialTrackPoint;

		// Token: 0x04024B73 RID: 150387
		[Token(Token = "0x4024B73")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _trialBtnPanelGo;

		// Token: 0x04024B74 RID: 150388
		[Token(Token = "0x4024B74")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private LoopScrollRect _loopScrollRect;

		// Token: 0x04024B75 RID: 150389
		[Token(Token = "0x4024B75")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GridLayoutGroup _itemGridLayout;

		// Token: 0x04024B76 RID: 150390
		[Token(Token = "0x4024B76")]
		[FieldOffset(Offset = "0x50")]
		private Action m_onBtnTrial;

		// Token: 0x04024B77 RID: 150391
		[Token(Token = "0x4024B77")]
		[FieldOffset(Offset = "0x58")]
		private Action m_onBtnRule;

		// Token: 0x04024B78 RID: 150392
		[Token(Token = "0x4024B78")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_newTrialTrackPoint;

		// Token: 0x04024B79 RID: 150393
		[Token(Token = "0x4024B79")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_collectTrialTrackPoint;

		// Token: 0x04024B7A RID: 150394
		[Token(Token = "0x4024B7A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_trialBtnPanelGo;

		// Token: 0x04024B7B RID: 150395
		[Token(Token = "0x4024B7B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_loopScrollRect;

		// Token: 0x04024B7C RID: 150396
		[Token(Token = "0x4024B7C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_itemGridLayout;

		// Token: 0x04024B7D RID: 150397
		[Token(Token = "0x4024B7D")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04024B7E RID: 150398
		[Token(Token = "0x4024B7E")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SetCallbacks;

		// Token: 0x04024B7F RID: 150399
		[Token(Token = "0x4024B7F")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnBtnTrial;

		// Token: 0x04024B80 RID: 150400
		[Token(Token = "0x4024B80")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnBtnRule;

		// Token: 0x04024B81 RID: 150401
		[Token(Token = "0x4024B81")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
