using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act29sign.View
{
	// Token: 0x02007492 RID: 29842
	[Token(Token = "0x2007492")]
	public class Act29signDynCheckinView : ActivityCheckinEntryView
	{
		// Token: 0x0602A159 RID: 172377 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A159")]
		[Address(RVA = "0x25B53F0", Offset = "0x25B3FF0", VA = "0x1825B53F0", Slot = "4")]
		public override void RenderView(ActivityCommonCheckinViewModel upperViewModel)
		{
		}

		// Token: 0x0602A15A RID: 172378 RVA: 0x000D7670 File Offset: 0x000D5870
		[Token(Token = "0x602A15A")]
		[Address(RVA = "0x25B5390", Offset = "0x25B3F90", VA = "0x1825B5390", Slot = "5")]
		public override ActivityCheckinEntryView.CheckinViewType GetViewType()
		{
			return ActivityCheckinEntryView.CheckinViewType.NONE;
		}

		// Token: 0x0602A15B RID: 172379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A15B")]
		[Address(RVA = "0x25B5330", Offset = "0x25B3F30", VA = "0x1825B5330")]
		public void EventOnCloseBtnClick()
		{
		}

		// Token: 0x0602A15C RID: 172380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A15C")]
		[Address(RVA = "0x25B5600", Offset = "0x25B4200", VA = "0x1825B5600")]
		private void _EnterSecondViewWithChoice(int choiceIndex)
		{
		}

		// Token: 0x0602A15D RID: 172381 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A15D")]
		[Address(RVA = "0x25B5530", Offset = "0x25B4130", VA = "0x1825B5530")]
		private void _EnterInitDayView()
		{
		}

		// Token: 0x0602A15E RID: 172382 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A15E")]
		[Address(RVA = "0x25B5710", Offset = "0x25B4310", VA = "0x1825B5710")]
		private void _EnterViewState(DynViewState state)
		{
		}

		// Token: 0x0602A15F RID: 172383 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A15F")]
		[Address(RVA = "0x25B60E0", Offset = "0x25B4CE0", VA = "0x1825B60E0")]
		private void _RefreshData(ActivityCommonCheckinViewModel upperViewModel)
		{
		}

		// Token: 0x0602A160 RID: 172384 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A160")]
		[Address(RVA = "0x25B54D0", Offset = "0x25B40D0", VA = "0x1825B54D0")]
		private void _CloseDynViewOnly()
		{
		}

		// Token: 0x0602A161 RID: 172385 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A161")]
		[Address(RVA = "0x25B57B0", Offset = "0x25B43B0", VA = "0x1825B57B0")]
		private void _InitIfNot(ActivityCommonCheckinViewModel upperViewModel)
		{
		}

		// Token: 0x0602A162 RID: 172386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A162")]
		[Address(RVA = "0x25B5EE0", Offset = "0x25B4AE0", VA = "0x1825B5EE0")]
		private Sprite _LoadDynRewardSprite(string option)
		{
			return null;
		}

		// Token: 0x0602A163 RID: 172387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A163")]
		[Address(RVA = "0x25B5FE0", Offset = "0x25B4BE0", VA = "0x1825B5FE0")]
		private Sprite _LoadInitDayChoiceSprite(string option)
		{
			return null;
		}

		// Token: 0x0602A164 RID: 172388 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A164")]
		[Address(RVA = "0x25B63E0", Offset = "0x25B4FE0", VA = "0x1825B63E0")]
		private void _SafeConfirmReward(string option)
		{
		}

		// Token: 0x0602A165 RID: 172389 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A165")]
		[Address(RVA = "0x25B65B0", Offset = "0x25B51B0", VA = "0x1825B65B0")]
		public Act29signDynCheckinView()
		{
		}

		// Token: 0x0403C694 RID: 247444
		[Token(Token = "0x403C694")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Act29signDynFirstView _firstView;

		// Token: 0x0403C695 RID: 247445
		[Token(Token = "0x403C695")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Act29signDynSecondView _secondView;

		// Token: 0x0403C696 RID: 247446
		[Token(Token = "0x403C696")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Act29signDynChoiceView _choiceView;

		// Token: 0x0403C697 RID: 247447
		[Token(Token = "0x403C697")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private Act29signProgressView _progressView;

		// Token: 0x0403C698 RID: 247448
		[Token(Token = "0x403C698")]
		[FieldOffset(Offset = "0x70")]
		private Act29signDynProperty m_property;

		// Token: 0x0403C699 RID: 247449
		[Token(Token = "0x403C699")]
		[FieldOffset(Offset = "0x78")]
		private bool m_hasInited;

		// Token: 0x0403C69A RID: 247450
		[Token(Token = "0x403C69A")]
		[FieldOffset(Offset = "0x80")]
		private Act29signDynViewModel m_viewModel;

		// Token: 0x0403C69B RID: 247451
		[Token(Token = "0x403C69B")]
		[FieldOffset(Offset = "0x88")]
		private ActivityCommonCheckinViewModel m_upperViewModel;

		// Token: 0x0403C69C RID: 247452
		[Token(Token = "0x403C69C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x0403C69D RID: 247453
		[Token(Token = "0x403C69D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetViewType;

		// Token: 0x0403C69E RID: 247454
		[Token(Token = "0x403C69E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_EventOnCloseBtnClick;

		// Token: 0x0403C69F RID: 247455
		[Token(Token = "0x403C69F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__EnterSecondViewWithChoice;

		// Token: 0x0403C6A0 RID: 247456
		[Token(Token = "0x403C6A0")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__EnterInitDayView;

		// Token: 0x0403C6A1 RID: 247457
		[Token(Token = "0x403C6A1")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__EnterViewState;

		// Token: 0x0403C6A2 RID: 247458
		[Token(Token = "0x403C6A2")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshData;

		// Token: 0x0403C6A3 RID: 247459
		[Token(Token = "0x403C6A3")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__CloseDynViewOnly;

		// Token: 0x0403C6A4 RID: 247460
		[Token(Token = "0x403C6A4")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403C6A5 RID: 247461
		[Token(Token = "0x403C6A5")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__LoadDynRewardSprite;

		// Token: 0x0403C6A6 RID: 247462
		[Token(Token = "0x403C6A6")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__LoadInitDayChoiceSprite;

		// Token: 0x0403C6A7 RID: 247463
		[Token(Token = "0x403C6A7")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SafeConfirmReward;

		// Token: 0x0403C6A8 RID: 247464
		[Token(Token = "0x403C6A8")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
