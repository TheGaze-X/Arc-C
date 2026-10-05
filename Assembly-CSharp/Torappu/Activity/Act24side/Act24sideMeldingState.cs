using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x020075AC RID: 30124
	[Token(Token = "0x20075AC")]
	public class Act24sideMeldingState : PopupFadeState, IBaseActStateHolder, IHotfixable, IValueMsgReceiver
	{
		// Token: 0x0602A638 RID: 173624 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A638")]
		[Address(RVA = "0x260DD00", Offset = "0x260C900", VA = "0x18260DD00", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602A639 RID: 173625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A639")]
		[Address(RVA = "0x260DE50", Offset = "0x260CA50", VA = "0x18260DE50", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602A63A RID: 173626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A63A")]
		[Address(RVA = "0x260E980", Offset = "0x260D580", VA = "0x18260E980", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0602A63B RID: 173627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A63B")]
		[Address(RVA = "0x260DC80", Offset = "0x260C880", VA = "0x18260DC80", Slot = "31")]
		public void BindController(TemplateActivityController controller)
		{
		}

		// Token: 0x0602A63C RID: 173628 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A63C")]
		[Address(RVA = "0x260EA30", Offset = "0x260D630", VA = "0x18260EA30", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602A63D RID: 173629 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A63D")]
		[Address(RVA = "0x260FC70", Offset = "0x260E870", VA = "0x18260FC70")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A63E RID: 173630 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A63E")]
		[Address(RVA = "0x26104D0", Offset = "0x260F0D0", VA = "0x1826104D0")]
		private void _SendMeldRequest()
		{
		}

		// Token: 0x0602A63F RID: 173631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A63F")]
		[Address(RVA = "0x2610260", Offset = "0x260EE60", VA = "0x182610260")]
		private void _RefreshAfterClaimRewards()
		{
		}

		// Token: 0x0602A640 RID: 173632 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A640")]
		[Address(RVA = "0x260FE00", Offset = "0x260EA00", VA = "0x18260FE00")]
		private IEnumerator _MeldingSuc(string gachaBoxId, List<Act24sideMeldingProgressChangeInfo> progressChangesList, List<RewardItemModel> rewardList, Action onConfirm)
		{
			return null;
		}

		// Token: 0x0602A641 RID: 173633 RVA: 0x000D83A8 File Offset: 0x000D65A8
		[Token(Token = "0x602A641")]
		[Address(RVA = "0x260F190", Offset = "0x260DD90", VA = "0x18260F190")]
		private bool _CheckIsTransiting()
		{
			return default(bool);
		}

		// Token: 0x0602A642 RID: 173634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A642")]
		[Address(RVA = "0x2610350", Offset = "0x260EF50", VA = "0x182610350")]
		private void _RefreshStageMeldingData()
		{
		}

		// Token: 0x0602A643 RID: 173635 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A643")]
		[Address(RVA = "0x260E160", Offset = "0x260CD60", VA = "0x18260E160", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602A644 RID: 173636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A644")]
		[Address(RVA = "0x260DD60", Offset = "0x260C960", VA = "0x18260DD60")]
		public void OnBackClicked()
		{
		}

		// Token: 0x0602A645 RID: 173637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A645")]
		[Address(RVA = "0x260FAF0", Offset = "0x260E6F0", VA = "0x18260FAF0")]
		private void _EventOnSwitch()
		{
		}

		// Token: 0x0602A646 RID: 173638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A646")]
		[Address(RVA = "0x260F7B0", Offset = "0x260E3B0", VA = "0x18260F7B0")]
		private void _EventOnItemLongPressAdd(string meldingItemId)
		{
		}

		// Token: 0x0602A647 RID: 173639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A647")]
		[Address(RVA = "0x260F6D0", Offset = "0x260E2D0", VA = "0x18260F6D0")]
		private void _EventOnItemAdd(string meldingItemId)
		{
		}

		// Token: 0x0602A648 RID: 173640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A648")]
		[Address(RVA = "0x260EC10", Offset = "0x260D810", VA = "0x18260EC10")]
		private void _AddItem(string meldingItemId, int tryAddCount)
		{
		}

		// Token: 0x0602A649 RID: 173641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A649")]
		[Address(RVA = "0x260F830", Offset = "0x260E430", VA = "0x18260F830")]
		private void _EventOnItemLongPressMinus(string meldingItemId)
		{
		}

		// Token: 0x0602A64A RID: 173642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A64A")]
		[Address(RVA = "0x260F8B0", Offset = "0x260E4B0", VA = "0x18260F8B0")]
		private void _EventOnItemMinus(string meldingItemId)
		{
		}

		// Token: 0x0602A64B RID: 173643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A64B")]
		[Address(RVA = "0x260FF30", Offset = "0x260EB30", VA = "0x18260FF30")]
		private void _MinusItem(string meldingItemId, int count)
		{
		}

		// Token: 0x0602A64C RID: 173644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A64C")]
		[Address(RVA = "0x260F560", Offset = "0x260E160", VA = "0x18260F560")]
		private void _EventOnFastInputMaterial(string gachaBoxId)
		{
		}

		// Token: 0x0602A64D RID: 173645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A64D")]
		[Address(RVA = "0x260F450", Offset = "0x260E050", VA = "0x18260F450")]
		private void _EventOnClearAllInputMaterial()
		{
		}

		// Token: 0x0602A64E RID: 173646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A64E")]
		[Address(RVA = "0x260F930", Offset = "0x260E530", VA = "0x18260F930")]
		private void _EventOnMeldClick(string gachaBoxId)
		{
		}

		// Token: 0x0602A64F RID: 173647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A64F")]
		[Address(RVA = "0x260F380", Offset = "0x260DF80", VA = "0x18260F380")]
		private void _EventOnChooseDetailShow(long show)
		{
		}

		// Token: 0x0602A650 RID: 173648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A650")]
		[Address(RVA = "0x2610A10", Offset = "0x260F610", VA = "0x182610A10")]
		public Act24sideMeldingState()
		{
		}

		// Token: 0x0602A651 RID: 173649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A651")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602A652 RID: 173650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A652")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0602A653 RID: 173651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A653")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0403CFE4 RID: 249828
		[Token(Token = "0x403CFE4")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act24sideMeldingView _view;

		// Token: 0x0403CFE5 RID: 249829
		[Token(Token = "0x403CFE5")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backPressRt;

		// Token: 0x0403CFE6 RID: 249830
		[Token(Token = "0x403CFE6")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x0403CFE7 RID: 249831
		[Token(Token = "0x403CFE7")]
		[NonSerialized]
		public const int MSG_SWITCH_CLICKED = 1;

		// Token: 0x0403CFE8 RID: 249832
		[Token(Token = "0x403CFE8")]
		[NonSerialized]
		public const int MSG_ITEM_ADD_CLICKED = 2;

		// Token: 0x0403CFE9 RID: 249833
		[Token(Token = "0x403CFE9")]
		[NonSerialized]
		public const int MSG_ITEM_MINUS_CLICKED = 3;

		// Token: 0x0403CFEA RID: 249834
		[Token(Token = "0x403CFEA")]
		[NonSerialized]
		public const int MSG_FAST_INPUT_CLICKED = 4;

		// Token: 0x0403CFEB RID: 249835
		[Token(Token = "0x403CFEB")]
		[NonSerialized]
		public const int MSG_MELDING_CLICKED = 5;

		// Token: 0x0403CFEC RID: 249836
		[Token(Token = "0x403CFEC")]
		[NonSerialized]
		public const int MSG_CHOOSE_DETAIL_SHOW_CLICKED = 6;

		// Token: 0x0403CFED RID: 249837
		[Token(Token = "0x403CFED")]
		[NonSerialized]
		public const int MSG_ITEM_ADD_LONG_PRESS = 7;

		// Token: 0x0403CFEE RID: 249838
		[Token(Token = "0x403CFEE")]
		[NonSerialized]
		public const int MSG_ITEM_MINUS_LONG_PRESS = 8;

		// Token: 0x0403CFEF RID: 249839
		[Token(Token = "0x403CFEF")]
		[NonSerialized]
		public const int MSG_CLEAR_ALL_INPUT_CLICKED = 9;

		// Token: 0x0403CFF0 RID: 249840
		[Token(Token = "0x403CFF0")]
		[FieldOffset(Offset = "0x90")]
		private bool m_inited;

		// Token: 0x0403CFF1 RID: 249841
		[Token(Token = "0x403CFF1")]
		[FieldOffset(Offset = "0x98")]
		private Act24sideMeldingProperty m_property;

		// Token: 0x0403CFF2 RID: 249842
		[Token(Token = "0x403CFF2")]
		[FieldOffset(Offset = "0xA0")]
		private TemplateActivityController m_cachedController;

		// Token: 0x0403CFF3 RID: 249843
		[Token(Token = "0x403CFF3")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_showTween;

		// Token: 0x0403CFF4 RID: 249844
		[Token(Token = "0x403CFF4")]
		private const int LONG_PRESS_MAX_CHANGE_COUNT = 4;

		// Token: 0x0403CFF5 RID: 249845
		[Token(Token = "0x403CFF5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403CFF6 RID: 249846
		[Token(Token = "0x403CFF6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403CFF7 RID: 249847
		[Token(Token = "0x403CFF7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0403CFF8 RID: 249848
		[Token(Token = "0x403CFF8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_BindController;

		// Token: 0x0403CFF9 RID: 249849
		[Token(Token = "0x403CFF9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403CFFA RID: 249850
		[Token(Token = "0x403CFFA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CFFB RID: 249851
		[Token(Token = "0x403CFFB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__SendMeldRequest;

		// Token: 0x0403CFFC RID: 249852
		[Token(Token = "0x403CFFC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__RefreshAfterClaimRewards;

		// Token: 0x0403CFFD RID: 249853
		[Token(Token = "0x403CFFD")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__MeldingSuc;

		// Token: 0x0403CFFE RID: 249854
		[Token(Token = "0x403CFFE")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__CheckIsTransiting;

		// Token: 0x0403CFFF RID: 249855
		[Token(Token = "0x403CFFF")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RefreshStageMeldingData;

		// Token: 0x0403D000 RID: 249856
		[Token(Token = "0x403D000")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403D001 RID: 249857
		[Token(Token = "0x403D001")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnBackClicked;

		// Token: 0x0403D002 RID: 249858
		[Token(Token = "0x403D002")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__EventOnSwitch;

		// Token: 0x0403D003 RID: 249859
		[Token(Token = "0x403D003")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__EventOnItemLongPressAdd;

		// Token: 0x0403D004 RID: 249860
		[Token(Token = "0x403D004")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__EventOnItemAdd;

		// Token: 0x0403D005 RID: 249861
		[Token(Token = "0x403D005")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__AddItem;

		// Token: 0x0403D006 RID: 249862
		[Token(Token = "0x403D006")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__EventOnItemLongPressMinus;

		// Token: 0x0403D007 RID: 249863
		[Token(Token = "0x403D007")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__EventOnItemMinus;

		// Token: 0x0403D008 RID: 249864
		[Token(Token = "0x403D008")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__MinusItem;

		// Token: 0x0403D009 RID: 249865
		[Token(Token = "0x403D009")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__EventOnFastInputMaterial;

		// Token: 0x0403D00A RID: 249866
		[Token(Token = "0x403D00A")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__EventOnClearAllInputMaterial;

		// Token: 0x0403D00B RID: 249867
		[Token(Token = "0x403D00B")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__EventOnMeldClick;

		// Token: 0x0403D00C RID: 249868
		[Token(Token = "0x403D00C")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__EventOnChooseDetailShow;

		// Token: 0x0403D00D RID: 249869
		[Token(Token = "0x403D00D")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
