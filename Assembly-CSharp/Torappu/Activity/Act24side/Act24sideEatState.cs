using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side
{
	// Token: 0x0200757F RID: 30079
	[Token(Token = "0x200757F")]
	public class Act24sideEatState : PopupFadeState, IBaseActStateHolder, IHotfixable, IValueMsgReceiver
	{
		// Token: 0x0602A594 RID: 173460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A594")]
		[Address(RVA = "0x25FEC90", Offset = "0x25FD890", VA = "0x1825FEC90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0602A595 RID: 173461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A595")]
		[Address(RVA = "0x25FE330", Offset = "0x25FCF30", VA = "0x1825FE330", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602A596 RID: 173462 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A596")]
		[Address(RVA = "0x25FE750", Offset = "0x25FD350", VA = "0x1825FE750", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0602A597 RID: 173463 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A597")]
		[Address(RVA = "0x25FE200", Offset = "0x25FCE00", VA = "0x1825FE200", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602A598 RID: 173464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A598")]
		[Address(RVA = "0x25FE180", Offset = "0x25FCD80", VA = "0x1825FE180", Slot = "31")]
		public void BindController(TemplateActivityController controller)
		{
		}

		// Token: 0x0602A599 RID: 173465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A599")]
		[Address(RVA = "0x25FE560", Offset = "0x25FD160", VA = "0x1825FE560", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0602A59A RID: 173466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A59A")]
		[Address(RVA = "0x25FF290", Offset = "0x25FDE90", VA = "0x1825FF290")]
		private void _RefreshEntryEatData()
		{
		}

		// Token: 0x0602A59B RID: 173467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A59B")]
		[Address(RVA = "0x25FF160", Offset = "0x25FDD60", VA = "0x1825FF160")]
		private void _OnMealItemClicked(string mealId)
		{
		}

		// Token: 0x0602A59C RID: 173468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A59C")]
		[Address(RVA = "0x25FEDA0", Offset = "0x25FD9A0", VA = "0x1825FEDA0")]
		private void _OnMealConfirmClicked()
		{
		}

		// Token: 0x0602A59D RID: 173469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A59D")]
		[Address(RVA = "0x25FE260", Offset = "0x25FCE60", VA = "0x1825FE260")]
		public void OnBackClicked()
		{
		}

		// Token: 0x0602A59E RID: 173470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A59E")]
		[Address(RVA = "0x25FF470", Offset = "0x25FE070", VA = "0x1825FF470")]
		public Act24sideEatState()
		{
		}

		// Token: 0x0602A5A0 RID: 173472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A5A0")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0602A5A1 RID: 173473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A5A1")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0403CE7B RID: 249467
		[Token(Token = "0x403CE7B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Act24sideEatView _view;

		// Token: 0x0403CE7C RID: 249468
		[Token(Token = "0x403CE7C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _backPressRt;

		// Token: 0x0403CE7D RID: 249469
		[Token(Token = "0x403CE7D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private UIAnimationLocation _animShow;

		// Token: 0x0403CE7E RID: 249470
		[Token(Token = "0x403CE7E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private float _audioFxDelay;

		// Token: 0x0403CE7F RID: 249471
		[Token(Token = "0x403CE7F")]
		[NonSerialized]
		public const int MSG_MEAL_ITEM_CLICKED = 1;

		// Token: 0x0403CE80 RID: 249472
		[Token(Token = "0x403CE80")]
		[NonSerialized]
		public const int MSG_MEAL_CONFIRM_CLICKED = 2;

		// Token: 0x0403CE81 RID: 249473
		[Token(Token = "0x403CE81")]
		[FieldOffset(Offset = "0x94")]
		private bool m_inited;

		// Token: 0x0403CE82 RID: 249474
		[Token(Token = "0x403CE82")]
		[FieldOffset(Offset = "0x98")]
		private Act24sideEatState.StateBean m_stateBean;

		// Token: 0x0403CE83 RID: 249475
		[Token(Token = "0x403CE83")]
		[FieldOffset(Offset = "0xA0")]
		private TemplateActivityController m_cachedController;

		// Token: 0x0403CE84 RID: 249476
		[Token(Token = "0x403CE84")]
		[FieldOffset(Offset = "0xA8")]
		private Tween m_showTween;

		// Token: 0x0403CE85 RID: 249477
		[Token(Token = "0x403CE85")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0403CE86 RID: 249478
		[Token(Token = "0x403CE86")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403CE87 RID: 249479
		[Token(Token = "0x403CE87")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0403CE88 RID: 249480
		[Token(Token = "0x403CE88")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403CE89 RID: 249481
		[Token(Token = "0x403CE89")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_BindController;

		// Token: 0x0403CE8A RID: 249482
		[Token(Token = "0x403CE8A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0403CE8B RID: 249483
		[Token(Token = "0x403CE8B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RefreshEntryEatData;

		// Token: 0x0403CE8C RID: 249484
		[Token(Token = "0x403CE8C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnMealItemClicked;

		// Token: 0x0403CE8D RID: 249485
		[Token(Token = "0x403CE8D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnMealConfirmClicked;

		// Token: 0x0403CE8E RID: 249486
		[Token(Token = "0x403CE8E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnBackClicked;

		// Token: 0x0403CE8F RID: 249487
		[Token(Token = "0x403CE8F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02007580 RID: 30080
		[Token(Token = "0x2007580")]
		public class StateBean : IStateBean, IHotfixable
		{
			// Token: 0x0602A5A2 RID: 173474 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A5A2")]
			[Address(RVA = "0x26040E0", Offset = "0x2602CE0", VA = "0x1826040E0")]
			public void LoadData(string actId, bool isInit)
			{
			}

			// Token: 0x0602A5A3 RID: 173475 RVA: 0x000D8228 File Offset: 0x000D6428
			[Token(Token = "0x602A5A3")]
			[Address(RVA = "0x26041A0", Offset = "0x2602DA0", VA = "0x1826041A0")]
			public bool SetSelectedItem(string mealId)
			{
				return default(bool);
			}

			// Token: 0x0602A5A4 RID: 173476 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602A5A4")]
			[Address(RVA = "0x2604350", Offset = "0x2602F50", VA = "0x182604350")]
			public StateBean()
			{
			}

			// Token: 0x0403CE90 RID: 249488
			[Token(Token = "0x403CE90")]
			[FieldOffset(Offset = "0x10")]
			public Act24sideEatProperty property;

			// Token: 0x0403CE91 RID: 249489
			[Token(Token = "0x403CE91")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0403CE92 RID: 249490
			[Token(Token = "0x403CE92")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_SetSelectedItem;

			// Token: 0x0403CE93 RID: 249491
			[Token(Token = "0x403CE93")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
