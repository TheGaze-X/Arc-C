using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.Activity;
using UnityEngine;
using XLua;

namespace Torappu.UI.ActivityStage
{
	// Token: 0x02006CA1 RID: 27809
	[Token(Token = "0x2006CA1")]
	public class TemplateActivityMissionState : PopupFloatState, IBaseActStateHolder, IHotfixable
	{
		// Token: 0x06027ABF RID: 162495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027ABF")]
		[Address(RVA = "0x22E7250", Offset = "0x22E5E50", VA = "0x1822E7250", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06027AC0 RID: 162496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AC0")]
		[Address(RVA = "0x22E7480", Offset = "0x22E6080", VA = "0x1822E7480", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06027AC1 RID: 162497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027AC1")]
		[Address(RVA = "0x22E70C0", Offset = "0x22E5CC0", VA = "0x1822E70C0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06027AC2 RID: 162498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027AC2")]
		[Address(RVA = "0x22E7120", Offset = "0x22E5D20", VA = "0x1822E7120")]
		public TemplateActivityMissionGroupViewModel GetMissionViewModel(TemplateActivityController controller)
		{
			return null;
		}

		// Token: 0x06027AC3 RID: 162499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AC3")]
		[Address(RVA = "0x22E68C0", Offset = "0x22E54C0", VA = "0x1822E68C0", Slot = "32")]
		public void BindController(TemplateActivityController controller)
		{
		}

		// Token: 0x06027AC4 RID: 162500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AC4")]
		[Address(RVA = "0x22E7680", Offset = "0x22E6280", VA = "0x1822E7680")]
		private void _InitTopMenu()
		{
		}

		// Token: 0x06027AC5 RID: 162501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AC5")]
		[Address(RVA = "0x22E7850", Offset = "0x22E6450", VA = "0x1822E7850")]
		private void _RefreshData()
		{
		}

		// Token: 0x06027AC6 RID: 162502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AC6")]
		[Address(RVA = "0x22E6A10", Offset = "0x22E5610", VA = "0x1822E6A10")]
		public void EventOnMissionClaimAllClicked()
		{
		}

		// Token: 0x06027AC7 RID: 162503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AC7")]
		[Address(RVA = "0x22E6E00", Offset = "0x22E5A00", VA = "0x1822E6E00")]
		public void EventOnMissionObjClicked(string missionId)
		{
		}

		// Token: 0x06027AC8 RID: 162504 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6027AC8")]
		[Address(RVA = "0x22E77A0", Offset = "0x22E63A0", VA = "0x1822E77A0")]
		private IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList)
		{
			return null;
		}

		// Token: 0x06027AC9 RID: 162505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027AC9")]
		[Address(RVA = "0x22E7970", Offset = "0x22E6570", VA = "0x1822E7970")]
		public TemplateActivityMissionState()
		{
		}

		// Token: 0x06027ACD RID: 162509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027ACD")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06027ACE RID: 162510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6027ACE")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04038446 RID: 230470
		[Token(Token = "0x4038446")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private TemplateActivityMissionHolder _holder;

		// Token: 0x04038447 RID: 230471
		[Token(Token = "0x4038447")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private TemplateActivityMissionView _missionView;

		// Token: 0x04038448 RID: 230472
		[Token(Token = "0x4038448")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private TemplateActivityCoinView _coinView;

		// Token: 0x04038449 RID: 230473
		[Token(Token = "0x4038449")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RectTransform _topMenuContainer;

		// Token: 0x0403844A RID: 230474
		[Token(Token = "0x403844A")]
		[FieldOffset(Offset = "0x90")]
		private CommonTopMenu m_topMenu;

		// Token: 0x0403844B RID: 230475
		[Token(Token = "0x403844B")]
		[FieldOffset(Offset = "0x98")]
		private TemplateActivityController m_cacheController;

		// Token: 0x0403844C RID: 230476
		[Token(Token = "0x403844C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403844D RID: 230477
		[Token(Token = "0x403844D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403844E RID: 230478
		[Token(Token = "0x403844E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403844F RID: 230479
		[Token(Token = "0x403844F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetMissionViewModel;

		// Token: 0x04038450 RID: 230480
		[Token(Token = "0x4038450")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_BindController;

		// Token: 0x04038451 RID: 230481
		[Token(Token = "0x4038451")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitTopMenu;

		// Token: 0x04038452 RID: 230482
		[Token(Token = "0x4038452")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshData;

		// Token: 0x04038453 RID: 230483
		[Token(Token = "0x4038453")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_EventOnMissionClaimAllClicked;

		// Token: 0x04038454 RID: 230484
		[Token(Token = "0x4038454")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_EventOnMissionObjClicked;

		// Token: 0x04038455 RID: 230485
		[Token(Token = "0x4038455")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x04038456 RID: 230486
		[Token(Token = "0x4038456")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
