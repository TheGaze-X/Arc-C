using System;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Activity.ActMultiV3
{
	// Token: 0x02006F90 RID: 28560
	[Token(Token = "0x2006F90")]
	public class ActMultiV3MatchingView : DataBinder<ActMultiV3QuickMatchProp>
	{
		// Token: 0x06028894 RID: 166036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028894")]
		[Address(RVA = "0x23D9FC0", Offset = "0x23D8BC0", VA = "0x1823D9FC0", Slot = "7")]
		public override void OnValueChanged(ActMultiV3QuickMatchProp property)
		{
		}

		// Token: 0x06028895 RID: 166037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028895")]
		[Address(RVA = "0x23DB450", Offset = "0x23DA050", VA = "0x1823DB450")]
		private void _RenderSuccessView(ActMultiV3QuickMatchModel matchModel)
		{
		}

		// Token: 0x06028896 RID: 166038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028896")]
		[Address(RVA = "0x23DA770", Offset = "0x23D9370", VA = "0x1823DA770")]
		private void _PlayMatchingAnimIfNeed(ActMultiV3QuickMatchModel matchModel)
		{
		}

		// Token: 0x06028897 RID: 166039 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028897")]
		[Address(RVA = "0x23DB000", Offset = "0x23D9C00", VA = "0x1823DB000")]
		private void _RenderMatchingView(ActMultiV3QuickMatchModel matchModel)
		{
		}

		// Token: 0x06028898 RID: 166040 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028898")]
		[Address(RVA = "0x23DA1C0", Offset = "0x23D8DC0", VA = "0x1823DA1C0")]
		public void SetVisible(bool isVisible)
		{
		}

		// Token: 0x06028899 RID: 166041 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6028899")]
		[Address(RVA = "0x23DA480", Offset = "0x23D9080", VA = "0x1823DA480")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602889A RID: 166042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602889A")]
		[Address(RVA = "0x23DA380", Offset = "0x23D8F80", VA = "0x1823DA380")]
		private FadeSwitchTween _CreateSwitchTween(CanvasGroup alphaHandler, float duration)
		{
			return null;
		}

		// Token: 0x0602889B RID: 166043 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602889B")]
		[Address(RVA = "0x23DAA80", Offset = "0x23D9680", VA = "0x1823DAA80")]
		private void _PlayMatchingEnterAnim()
		{
		}

		// Token: 0x0602889C RID: 166044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602889C")]
		[Address(RVA = "0x23DAC00", Offset = "0x23D9800", VA = "0x1823DAC00")]
		private void _PlayResultAnim(ActMultiV3MatchResult matchResult)
		{
		}

		// Token: 0x0602889D RID: 166045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602889D")]
		[Address(RVA = "0x23DA5C0", Offset = "0x23D91C0", VA = "0x1823DA5C0")]
		private void _OnDisablePanel()
		{
		}

		// Token: 0x0602889E RID: 166046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602889E")]
		[Address(RVA = "0x23DA620", Offset = "0x23D9220", VA = "0x1823DA620")]
		private void _OnResultShowCallback()
		{
		}

		// Token: 0x0602889F RID: 166047 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602889F")]
		[Address(RVA = "0x23DA250", Offset = "0x23D8E50", VA = "0x1823DA250")]
		private Tween _CreateResultEnterTween(ActMultiV3MatchResult matchResult)
		{
			return null;
		}

		// Token: 0x060288A0 RID: 166048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288A0")]
		[Address(RVA = "0x23D9F30", Offset = "0x23D8B30", VA = "0x1823D9F30")]
		public void EventOnBtnCancelClick()
		{
		}

		// Token: 0x060288A1 RID: 166049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60288A1")]
		[Address(RVA = "0x23DB6B0", Offset = "0x23DA2B0", VA = "0x1823DB6B0")]
		public ActMultiV3MatchingView()
		{
		}

		// Token: 0x04039B79 RID: 236409
		[Token(Token = "0x4039B79")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CanvasGroup _rootPanel;

		// Token: 0x04039B7A RID: 236410
		[Token(Token = "0x4039B7A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CanvasGroup _matchingPanel;

		// Token: 0x04039B7B RID: 236411
		[Token(Token = "0x4039B7B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIAnimationLocation _animMatchingEnter;

		// Token: 0x04039B7C RID: 236412
		[Token(Token = "0x4039B7C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private CanvasGroup _cancelPanel;

		// Token: 0x04039B7D RID: 236413
		[Token(Token = "0x4039B7D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private UIAnimationLocation _animCancelEnter;

		// Token: 0x04039B7E RID: 236414
		[Token(Token = "0x4039B7E")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private CanvasGroup _timecountPanel;

		// Token: 0x04039B7F RID: 236415
		[Token(Token = "0x4039B7F")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private UIAnimationLocation _animTimeoutEnter;

		// Token: 0x04039B80 RID: 236416
		[Token(Token = "0x4039B80")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _successPanel;

		// Token: 0x04039B81 RID: 236417
		[Token(Token = "0x4039B81")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAnimationLocation _animSuccessEnter;

		// Token: 0x04039B82 RID: 236418
		[Token(Token = "0x4039B82")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private SimpleLayoutContent _modeList;

		// Token: 0x04039B83 RID: 236419
		[Token(Token = "0x4039B83")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _panelFadeDuration;

		// Token: 0x04039B84 RID: 236420
		[Token(Token = "0x4039B84")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		private float _rootFadeDuratioin;

		// Token: 0x04039B85 RID: 236421
		[Token(Token = "0x4039B85")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Text _textWaitSec;

		// Token: 0x04039B86 RID: 236422
		[Token(Token = "0x4039B86")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _textTip;

		// Token: 0x04039B87 RID: 236423
		[Token(Token = "0x4039B87")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private Text _textSuccessDesc;

		// Token: 0x04039B88 RID: 236424
		[Token(Token = "0x4039B88")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private GameObject _partnerStudentGO;

		// Token: 0x04039B89 RID: 236425
		[Token(Token = "0x4039B89")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private GameObject _partnerCoachGO;

		// Token: 0x04039B8A RID: 236426
		[Token(Token = "0x4039B8A")]
		[FieldOffset(Offset = "0xC0")]
		private int m_cacheSeqNum;

		// Token: 0x04039B8B RID: 236427
		[Token(Token = "0x4039B8B")]
		[FieldOffset(Offset = "0xC8")]
		private Tween m_tween;

		// Token: 0x04039B8C RID: 236428
		[Token(Token = "0x4039B8C")]
		[FieldOffset(Offset = "0xD0")]
		private FadeSwitchTween m_rootSwitchTween;

		// Token: 0x04039B8D RID: 236429
		[Token(Token = "0x4039B8D")]
		[FieldOffset(Offset = "0xD8")]
		private FadeSwitchTween m_matchingTween;

		// Token: 0x04039B8E RID: 236430
		[Token(Token = "0x4039B8E")]
		[FieldOffset(Offset = "0xE0")]
		private FadeSwitchTween m_cancelTween;

		// Token: 0x04039B8F RID: 236431
		[Token(Token = "0x4039B8F")]
		[FieldOffset(Offset = "0xE8")]
		private FadeSwitchTween m_timeoutTween;

		// Token: 0x04039B90 RID: 236432
		[Token(Token = "0x4039B90")]
		[FieldOffset(Offset = "0xF0")]
		private FadeSwitchTween m_successTween;

		// Token: 0x04039B91 RID: 236433
		[Token(Token = "0x4039B91")]
		[FieldOffset(Offset = "0xF8")]
		private bool m_hasInited;

		// Token: 0x04039B92 RID: 236434
		[Token(Token = "0x4039B92")]
		[FieldOffset(Offset = "0x100")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04039B93 RID: 236435
		[Token(Token = "0x4039B93")]
		[FieldOffset(Offset = "0x110")]
		private ActMultiV3MatchingView.ModeListAdapter m_modeListAdapter;

		// Token: 0x04039B94 RID: 236436
		[Token(Token = "0x4039B94")]
		[FieldOffset(Offset = "0x118")]
		private ActMultiV3QuickMatchModel m_matchModel;

		// Token: 0x04039B95 RID: 236437
		[Token(Token = "0x4039B95")]
		[FieldOffset(Offset = "0x120")]
		private int m_tipLastSec;

		// Token: 0x04039B96 RID: 236438
		[Token(Token = "0x4039B96")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x04039B97 RID: 236439
		[Token(Token = "0x4039B97")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__RenderSuccessView;

		// Token: 0x04039B98 RID: 236440
		[Token(Token = "0x4039B98")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayMatchingAnimIfNeed;

		// Token: 0x04039B99 RID: 236441
		[Token(Token = "0x4039B99")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderMatchingView;

		// Token: 0x04039B9A RID: 236442
		[Token(Token = "0x4039B9A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetVisible;

		// Token: 0x04039B9B RID: 236443
		[Token(Token = "0x4039B9B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04039B9C RID: 236444
		[Token(Token = "0x4039B9C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CreateSwitchTween;

		// Token: 0x04039B9D RID: 236445
		[Token(Token = "0x4039B9D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__PlayMatchingEnterAnim;

		// Token: 0x04039B9E RID: 236446
		[Token(Token = "0x4039B9E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__PlayResultAnim;

		// Token: 0x04039B9F RID: 236447
		[Token(Token = "0x4039B9F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnDisablePanel;

		// Token: 0x04039BA0 RID: 236448
		[Token(Token = "0x4039BA0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnResultShowCallback;

		// Token: 0x04039BA1 RID: 236449
		[Token(Token = "0x4039BA1")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__CreateResultEnterTween;

		// Token: 0x04039BA2 RID: 236450
		[Token(Token = "0x4039BA2")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_EventOnBtnCancelClick;

		// Token: 0x04039BA3 RID: 236451
		[Token(Token = "0x4039BA3")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02006F91 RID: 28561
		[Token(Token = "0x2006F91")]
		private class ModeListAdapter : SimpleLayoutAdapter
		{
			// Token: 0x060288A2 RID: 166050 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60288A2")]
			[Address(RVA = "0x23EB420", Offset = "0x23EA020", VA = "0x1823EB420")]
			public void UpdateData(ActMultiV3QuickMatchModel matchModel)
			{
			}

			// Token: 0x17005F96 RID: 24470
			// (get) Token: 0x060288A3 RID: 166051 RVA: 0x000D20A8 File Offset: 0x000D02A8
			[Token(Token = "0x17005F96")]
			public override int count
			{
				[Token(Token = "0x60288A3")]
				[Address(RVA = "0x23EB800", Offset = "0x23EA400", VA = "0x1823EB800", Slot = "4")]
				get
				{
					return 0;
				}
			}

			// Token: 0x060288A4 RID: 166052 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60288A4")]
			[Address(RVA = "0x23EB280", Offset = "0x23E9E80", VA = "0x1823EB280", Slot = "5")]
			public override GameObject RenderView(int position, GameObject prefab, Transform parent)
			{
				return null;
			}

			// Token: 0x060288A5 RID: 166053 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60288A5")]
			[Address(RVA = "0x23EB750", Offset = "0x23EA350", VA = "0x1823EB750")]
			public ModeListAdapter()
			{
			}

			// Token: 0x04039BA4 RID: 236452
			[Token(Token = "0x4039BA4")]
			[FieldOffset(Offset = "0x20")]
			private ActMultiV3QuickMatchModel m_matchModel;

			// Token: 0x04039BA5 RID: 236453
			[Token(Token = "0x4039BA5")]
			[FieldOffset(Offset = "0x28")]
			private List<ActMultiV3MatchModeGroupModel> m_modeGroupList;

			// Token: 0x04039BA6 RID: 236454
			[Token(Token = "0x4039BA6")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_UpdateData;

			// Token: 0x04039BA7 RID: 236455
			[Token(Token = "0x4039BA7")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_count;

			// Token: 0x04039BA8 RID: 236456
			[Token(Token = "0x4039BA8")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_RenderView;

			// Token: 0x04039BA9 RID: 236457
			[Token(Token = "0x4039BA9")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
