using System;
using System.Collections;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.BattleFinish;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1Lock.BattleFinish
{
	// Token: 0x020078E6 RID: 30950
	[Token(Token = "0x20078E6")]
	public class Act1LockBattleFinishView : ActivityBattleFinishView
	{
		// Token: 0x0602B66E RID: 177774 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B66E")]
		[Address(RVA = "0x2757FA0", Offset = "0x2756BA0", VA = "0x182757FA0", Slot = "11")]
		protected override void OnInit()
		{
		}

		// Token: 0x0602B66F RID: 177775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B66F")]
		[Address(RVA = "0x2757DD0", Offset = "0x27569D0", VA = "0x182757DD0")]
		public void EventOnPageClicked()
		{
		}

		// Token: 0x0602B670 RID: 177776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B670")]
		[Address(RVA = "0x27582F0", Offset = "0x2756EF0", VA = "0x1827582F0")]
		private void _EventOnConfirmDefendClicked()
		{
		}

		// Token: 0x0602B671 RID: 177777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B671")]
		[Address(RVA = "0x2758270", Offset = "0x2756E70", VA = "0x182758270")]
		private void _EventOnCancelDefendClicked()
		{
		}

		// Token: 0x0602B672 RID: 177778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B672")]
		[Address(RVA = "0x2758550", Offset = "0x2757150", VA = "0x182758550")]
		private void _EventOnDefendSucClicked()
		{
		}

		// Token: 0x0602B673 RID: 177779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B673")]
		[Address(RVA = "0x2757EE0", Offset = "0x2756AE0", VA = "0x182757EE0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0602B674 RID: 177780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B674")]
		[Address(RVA = "0x27585D0", Offset = "0x27571D0", VA = "0x1827585D0")]
		private void _Init()
		{
		}

		// Token: 0x0602B675 RID: 177781 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B675")]
		[Address(RVA = "0x2758D10", Offset = "0x2757910", VA = "0x182758D10")]
		private IEnumerator _UpdateStateCoroutine()
		{
			return null;
		}

		// Token: 0x0602B676 RID: 177782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B676")]
		[Address(RVA = "0x2758A50", Offset = "0x2757650", VA = "0x182758A50")]
		private IEnumerator _ShowDefendView()
		{
			return null;
		}

		// Token: 0x0602B677 RID: 177783 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B677")]
		[Address(RVA = "0x2758C60", Offset = "0x2757860", VA = "0x182758C60")]
		private IEnumerator _ShowIllustAndBattleInfo()
		{
			return null;
		}

		// Token: 0x0602B678 RID: 177784 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B678")]
		[Address(RVA = "0x2758BB0", Offset = "0x27577B0", VA = "0x182758BB0")]
		private IEnumerator _ShowFinalStagePoint()
		{
			return null;
		}

		// Token: 0x0602B679 RID: 177785 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B679")]
		[Address(RVA = "0x2758DC0", Offset = "0x27579C0", VA = "0x182758DC0")]
		private IEnumerator _WaitFinalStagePoint()
		{
			return null;
		}

		// Token: 0x0602B67A RID: 177786 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602B67A")]
		[Address(RVA = "0x2758B00", Offset = "0x2757700", VA = "0x182758B00")]
		private IEnumerator _ShowDropInfo()
		{
			return null;
		}

		// Token: 0x0602B67B RID: 177787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602B67B")]
		[Address(RVA = "0x2758E70", Offset = "0x2757A70", VA = "0x182758E70")]
		public Act1LockBattleFinishView()
		{
		}

		// Token: 0x0403EC35 RID: 257077
		[Token(Token = "0x403EC35")]
		private const float COMMON_WAIT_TIME = 0.2f;

		// Token: 0x0403EC36 RID: 257078
		[Token(Token = "0x403EC36")]
		private const float WAIT_FINAL_STAGE_POINT_TIME = 5f;

		// Token: 0x0403EC37 RID: 257079
		[Token(Token = "0x403EC37")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIFullScreenImage _blurBackground;

		// Token: 0x0403EC38 RID: 257080
		[Token(Token = "0x403EC38")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UIExpBar _playerExpBar;

		// Token: 0x0403EC39 RID: 257081
		[Token(Token = "0x403EC39")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BattleFinishInfoView _battleInfoView;

		// Token: 0x0403EC3A RID: 257082
		[Token(Token = "0x403EC3A")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private BattleFinishDropInfoView _dropInfoView;

		// Token: 0x0403EC3B RID: 257083
		[Token(Token = "0x403EC3B")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BattleFinishIllustView _illustView;

		// Token: 0x0403EC3C RID: 257084
		[Token(Token = "0x403EC3C")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Animator _favorAnimator;

		// Token: 0x0403EC3D RID: 257085
		[Token(Token = "0x403EC3D")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _panelResult;

		// Token: 0x0403EC3E RID: 257086
		[Token(Token = "0x403EC3E")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private CanvasGroup _dropInfoCanvas;

		// Token: 0x0403EC3F RID: 257087
		[Token(Token = "0x403EC3F")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act1LockBattleFinishTotalPointView _pointView;

		// Token: 0x0403EC40 RID: 257088
		[Token(Token = "0x403EC40")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private Act1LockBattleFinishDefendView _defendView;

		// Token: 0x0403EC41 RID: 257089
		[Token(Token = "0x403EC41")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Act1LockBattleFinishDefendView _defendReplaceView;

		// Token: 0x0403EC42 RID: 257090
		[Token(Token = "0x403EC42")]
		[FieldOffset(Offset = "0x88")]
		private Act1LockBattleFinishViewModel m_viewModel;

		// Token: 0x0403EC43 RID: 257091
		[Token(Token = "0x403EC43")]
		[FieldOffset(Offset = "0x90")]
		[Inspect]
		private new Act1LockBattleFinishView.InternalState m_state;

		// Token: 0x0403EC44 RID: 257092
		[Token(Token = "0x403EC44")]
		[FieldOffset(Offset = "0x98")]
		private UIExpBarController m_expBarController;

		// Token: 0x0403EC45 RID: 257093
		[Token(Token = "0x403EC45")]
		[FieldOffset(Offset = "0xA0")]
		private Coroutine m_updateStateCoroutine;

		// Token: 0x0403EC46 RID: 257094
		[Token(Token = "0x403EC46")]
		[FieldOffset(Offset = "0xA8")]
		private Coroutine m_showPointViewCoroutine;

		// Token: 0x0403EC47 RID: 257095
		[Token(Token = "0x403EC47")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnInit;

		// Token: 0x0403EC48 RID: 257096
		[Token(Token = "0x403EC48")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnPageClicked;

		// Token: 0x0403EC49 RID: 257097
		[Token(Token = "0x403EC49")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__EventOnConfirmDefendClicked;

		// Token: 0x0403EC4A RID: 257098
		[Token(Token = "0x403EC4A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EventOnCancelDefendClicked;

		// Token: 0x0403EC4B RID: 257099
		[Token(Token = "0x403EC4B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EventOnDefendSucClicked;

		// Token: 0x0403EC4C RID: 257100
		[Token(Token = "0x403EC4C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0403EC4D RID: 257101
		[Token(Token = "0x403EC4D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x0403EC4E RID: 257102
		[Token(Token = "0x403EC4E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateStateCoroutine;

		// Token: 0x0403EC4F RID: 257103
		[Token(Token = "0x403EC4F")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ShowDefendView;

		// Token: 0x0403EC50 RID: 257104
		[Token(Token = "0x403EC50")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ShowIllustAndBattleInfo;

		// Token: 0x0403EC51 RID: 257105
		[Token(Token = "0x403EC51")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__ShowFinalStagePoint;

		// Token: 0x0403EC52 RID: 257106
		[Token(Token = "0x403EC52")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__WaitFinalStagePoint;

		// Token: 0x0403EC53 RID: 257107
		[Token(Token = "0x403EC53")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__ShowDropInfo;

		// Token: 0x0403EC54 RID: 257108
		[Token(Token = "0x403EC54")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020078E7 RID: 30951
		[Token(Token = "0x20078E7")]
		private enum InternalState
		{
			// Token: 0x0403EC56 RID: 257110
			[Token(Token = "0x403EC56")]
			NONE,
			// Token: 0x0403EC57 RID: 257111
			[Token(Token = "0x403EC57")]
			SHOW_INTERLOCK_STAGE_DEFEND,
			// Token: 0x0403EC58 RID: 257112
			[Token(Token = "0x403EC58")]
			WAIT_INTERLOCK_STAGE_DEFEND,
			// Token: 0x0403EC59 RID: 257113
			[Token(Token = "0x403EC59")]
			PLAY_INTERLOCK_STAGE_DEFEND_SUC_ANIM,
			// Token: 0x0403EC5A RID: 257114
			[Token(Token = "0x403EC5A")]
			WAIT_INTERLOCK_STAGE_DEFEND_SUC_ANIM,
			// Token: 0x0403EC5B RID: 257115
			[Token(Token = "0x403EC5B")]
			FINISH_INTERLOCK_STAGE_DEFEND,
			// Token: 0x0403EC5C RID: 257116
			[Token(Token = "0x403EC5C")]
			SHOW_ILLUST_AND_BATTLE_INFO,
			// Token: 0x0403EC5D RID: 257117
			[Token(Token = "0x403EC5D")]
			SHOW_FINAL_STAGE_POINT,
			// Token: 0x0403EC5E RID: 257118
			[Token(Token = "0x403EC5E")]
			WAIT_FINAL_STAGE_POINT,
			// Token: 0x0403EC5F RID: 257119
			[Token(Token = "0x403EC5F")]
			HIDE_FINAL_STAGE_POINT,
			// Token: 0x0403EC60 RID: 257120
			[Token(Token = "0x403EC60")]
			SHOW_DROP_INFO,
			// Token: 0x0403EC61 RID: 257121
			[Token(Token = "0x403EC61")]
			END
		}
	}
}
