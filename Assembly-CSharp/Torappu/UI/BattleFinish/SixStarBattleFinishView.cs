using System;
using System.Collections;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.BattleFinish
{
	// Token: 0x02006222 RID: 25122
	[Token(Token = "0x2006222")]
	public class SixStarBattleFinishView : DynBattleFinishView
	{
		// Token: 0x060243E2 RID: 148450 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243E2")]
		[Address(RVA = "0x1F1D6B0", Offset = "0x1F1C2B0", VA = "0x181F1D6B0", Slot = "6")]
		protected override void OnInit()
		{
		}

		// Token: 0x060243E3 RID: 148451 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60243E3")]
		[Address(RVA = "0x1F1DD10", Offset = "0x1F1C910", VA = "0x181F1DD10", Slot = "7")]
		public override IEnumerator ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x060243E4 RID: 148452 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243E4")]
		[Address(RVA = "0x1F1E010", Offset = "0x1F1CC10", VA = "0x181F1E010")]
		private void _PlayEntryAnim()
		{
		}

		// Token: 0x060243E5 RID: 148453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243E5")]
		[Address(RVA = "0x1F1E230", Offset = "0x1F1CE30", VA = "0x181F1E230")]
		private void _RenderStageInfo()
		{
		}

		// Token: 0x060243E6 RID: 148454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243E6")]
		[Address(RVA = "0x1F1E160", Offset = "0x1F1CD60", VA = "0x181F1E160")]
		private void _RenderRankInfo()
		{
		}

		// Token: 0x060243E7 RID: 148455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243E7")]
		[Address(RVA = "0x1F1E0E0", Offset = "0x1F1CCE0", VA = "0x181F1E0E0")]
		private void _RenderCharInfo()
		{
		}

		// Token: 0x060243E8 RID: 148456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243E8")]
		[Address(RVA = "0x1F1DEE0", Offset = "0x1F1CAE0", VA = "0x181F1DEE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x060243E9 RID: 148457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243E9")]
		[Address(RVA = "0x1F1E400", Offset = "0x1F1D000", VA = "0x181F1E400")]
		private void _ResetAnim()
		{
		}

		// Token: 0x060243EA RID: 148458 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243EA")]
		[Address(RVA = "0x1F1E5E0", Offset = "0x1F1D1E0", VA = "0x181F1E5E0")]
		private void _TimerTickCallBack()
		{
		}

		// Token: 0x060243EB RID: 148459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243EB")]
		[Address(RVA = "0x1F1E490", Offset = "0x1F1D090", VA = "0x181F1E490")]
		private void _StartTimer()
		{
		}

		// Token: 0x060243EC RID: 148460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243EC")]
		[Address(RVA = "0x1F1DE50", Offset = "0x1F1CA50", VA = "0x181F1DE50")]
		private void _ClearTimer()
		{
		}

		// Token: 0x060243ED RID: 148461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243ED")]
		[Address(RVA = "0x1F1D5D0", Offset = "0x1F1C1D0", VA = "0x181F1D5D0")]
		public void EventOnViewClicked()
		{
		}

		// Token: 0x060243EE RID: 148462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243EE")]
		[Address(RVA = "0x1F1D650", Offset = "0x1F1C250", VA = "0x181F1D650")]
		private void OnDestroy()
		{
		}

		// Token: 0x060243EF RID: 148463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60243EF")]
		[Address(RVA = "0x1F1E6D0", Offset = "0x1F1D2D0", VA = "0x181F1E6D0")]
		public SixStarBattleFinishView()
		{
		}

		// Token: 0x060243F0 RID: 148464 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60243F0")]
		[Address(RVA = "0x1F1DDC0", Offset = "0x1F1C9C0", VA = "0x181F1DDC0")]
		private IEnumerator <>xLuaBaseProxy_ShowEnterEffectCoroutine()
		{
			return null;
		}

		// Token: 0x04032651 RID: 206417
		[Token(Token = "0x4032651")]
		private const float TWEEN_DELAY = 0.25f;

		// Token: 0x04032652 RID: 206418
		[Token(Token = "0x4032652")]
		private const float TICK_TIME = 0.5f;

		// Token: 0x04032653 RID: 206419
		[Token(Token = "0x4032653")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIFullScreenImage _blurBackground;

		// Token: 0x04032654 RID: 206420
		[Token(Token = "0x4032654")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Group("stage Info")]
		private Text _textStageName;

		// Token: 0x04032655 RID: 206421
		[Token(Token = "0x4032655")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("stage Info")]
		private Text _textStageCode;

		// Token: 0x04032656 RID: 206422
		[Token(Token = "0x4032656")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Rank")]
		private TwoStateToggle _rankPanelState;

		// Token: 0x04032657 RID: 206423
		[Token(Token = "0x4032657")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Rank")]
		private RectTransform _rankPanelRoot;

		// Token: 0x04032658 RID: 206424
		[Token(Token = "0x4032658")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private SixStarBattleFinishTimeTickListener[] _timerTickListeners;

		// Token: 0x04032659 RID: 206425
		[Token(Token = "0x4032659")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BattleFinishIllustView _ilustView;

		// Token: 0x0403265A RID: 206426
		[Token(Token = "0x403265A")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIAnimationLocation _entryAnim;

		// Token: 0x0403265B RID: 206427
		[Token(Token = "0x403265B")]
		[FieldOffset(Offset = "0x68")]
		private SixStarBattleFinishViewModel m_viewModel;

		// Token: 0x0403265C RID: 206428
		[Token(Token = "0x403265C")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_entryAnimTween;

		// Token: 0x0403265D RID: 206429
		[Token(Token = "0x403265D")]
		[FieldOffset(Offset = "0x78")]
		private int m_targetTimerLoopCount;

		// Token: 0x0403265E RID: 206430
		[Token(Token = "0x403265E")]
		[FieldOffset(Offset = "0x7C")]
		private bool m_isInited;

		// Token: 0x0403265F RID: 206431
		[Token(Token = "0x403265F")]
		[FieldOffset(Offset = "0x80")]
		private int m_timerId;

		// Token: 0x04032660 RID: 206432
		[Token(Token = "0x4032660")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x04032661 RID: 206433
		[Token(Token = "0x4032661")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowEnterEffectCoroutine;

		// Token: 0x04032662 RID: 206434
		[Token(Token = "0x4032662")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__PlayEntryAnim;

		// Token: 0x04032663 RID: 206435
		[Token(Token = "0x4032663")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__RenderStageInfo;

		// Token: 0x04032664 RID: 206436
		[Token(Token = "0x4032664")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__RenderRankInfo;

		// Token: 0x04032665 RID: 206437
		[Token(Token = "0x4032665")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__RenderCharInfo;

		// Token: 0x04032666 RID: 206438
		[Token(Token = "0x4032666")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04032667 RID: 206439
		[Token(Token = "0x4032667")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ResetAnim;

		// Token: 0x04032668 RID: 206440
		[Token(Token = "0x4032668")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TimerTickCallBack;

		// Token: 0x04032669 RID: 206441
		[Token(Token = "0x4032669")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__StartTimer;

		// Token: 0x0403266A RID: 206442
		[Token(Token = "0x403266A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ClearTimer;

		// Token: 0x0403266B RID: 206443
		[Token(Token = "0x403266B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_EventOnViewClicked;

		// Token: 0x0403266C RID: 206444
		[Token(Token = "0x403266C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403266D RID: 206445
		[Token(Token = "0x403266D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
