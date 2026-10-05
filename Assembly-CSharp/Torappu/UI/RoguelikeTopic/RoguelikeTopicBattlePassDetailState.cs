using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.RoguelikeTopic
{
	// Token: 0x02004480 RID: 17536
	[Token(Token = "0x2004480")]
	public class RoguelikeTopicBattlePassDetailState : PopupFloatState
	{
		// Token: 0x0601ACAE RID: 109742 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACAE")]
		[Address(RVA = "0x13F24F0", Offset = "0x13F10F0", VA = "0x1813F24F0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601ACAF RID: 109743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ACAF")]
		[Address(RVA = "0x13F1CE0", Offset = "0x13F08E0", VA = "0x1813F1CE0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601ACB0 RID: 109744 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACB0")]
		[Address(RVA = "0x13F1FB0", Offset = "0x13F0BB0", VA = "0x1813F1FB0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601ACB1 RID: 109745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACB1")]
		[Address(RVA = "0x13F2A50", Offset = "0x13F1650", VA = "0x1813F2A50")]
		private void _UpdateStyle(RoguelikeTopicBattlePassStyle topicStyle)
		{
		}

		// Token: 0x0601ACB2 RID: 109746 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ACB2")]
		[Address(RVA = "0x13F2370", Offset = "0x13F0F70", VA = "0x1813F2370", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x0601ACB3 RID: 109747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACB3")]
		[Address(RVA = "0x13F2620", Offset = "0x13F1220", VA = "0x1813F2620")]
		private void _OnJumpToPurchaseState(IStateBean stateBean)
		{
		}

		// Token: 0x0601ACB4 RID: 109748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACB4")]
		[Address(RVA = "0x13F2820", Offset = "0x13F1420", VA = "0x1813F2820")]
		private void _RenderView()
		{
		}

		// Token: 0x0601ACB5 RID: 109749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACB5")]
		[Address(RVA = "0x13F1D60", Offset = "0x13F0960", VA = "0x1813F1D60")]
		public void OnBackClick()
		{
		}

		// Token: 0x0601ACB6 RID: 109750 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACB6")]
		[Address(RVA = "0x13F1DF0", Offset = "0x13F09F0", VA = "0x1813F1DF0")]
		public void OnBpPurchaseClick()
		{
		}

		// Token: 0x0601ACB7 RID: 109751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACB7")]
		[Address(RVA = "0x13F2D70", Offset = "0x13F1970", VA = "0x1813F2D70")]
		public RoguelikeTopicBattlePassDetailState()
		{
		}

		// Token: 0x0601ACB9 RID: 109753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601ACB9")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601ACBA RID: 109754 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601ACBA")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04022443 RID: 140355
		[Token(Token = "0x4022443")]
		[FieldOffset(Offset = "0x0")]
		private static readonly Color BP_PURCHASE_TEXT_COLOR_AVAILABLE;

		// Token: 0x04022444 RID: 140356
		[Token(Token = "0x4022444")]
		[FieldOffset(Offset = "0x10")]
		private static readonly Color BP_PURCHASE_TEXT_COLOR_DISABLED;

		// Token: 0x04022445 RID: 140357
		[Token(Token = "0x4022445")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _backBtn;

		// Token: 0x04022446 RID: 140358
		[Token(Token = "0x4022446")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private UIAtlasImage _imgIcon;

		// Token: 0x04022447 RID: 140359
		[Token(Token = "0x4022447")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private GameObject _pnlPlaceholder;

		// Token: 0x04022448 RID: 140360
		[Token(Token = "0x4022448")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _pnlBpPurchase;

		// Token: 0x04022449 RID: 140361
		[Token(Token = "0x4022449")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		private GameObject _pnlBpPurchaseDisabled;

		// Token: 0x0402244A RID: 140362
		[Token(Token = "0x402244A")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		private GameObject _pnlBpPurchaseEnabled;

		// Token: 0x0402244B RID: 140363
		[Token(Token = "0x402244B")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private GameObject _pnlBtnBpPurchaseEnabled;

		// Token: 0x0402244C RID: 140364
		[Token(Token = "0x402244C")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		private GameObject _pnlBtnBpPurchaseDisabled;

		// Token: 0x0402244D RID: 140365
		[Token(Token = "0x402244D")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		private Text _textPurchase;

		// Token: 0x0402244E RID: 140366
		[Token(Token = "0x402244E")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		private Text[] _textLabelDescList;

		// Token: 0x0402244F RID: 140367
		[Token(Token = "0x402244F")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		private UIAtlasImage _imgBtnPurchase;

		// Token: 0x04022450 RID: 140368
		[Token(Token = "0x4022450")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private Text _textMonthTeam;

		// Token: 0x04022451 RID: 140369
		[Token(Token = "0x4022451")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		private UIAtlasImage _imgTeamIcon;

		// Token: 0x04022452 RID: 140370
		[Token(Token = "0x4022452")]
		[FieldOffset(Offset = "0xD8")]
		[SerializeField]
		private Text _textPromoteCaption;

		// Token: 0x04022453 RID: 140371
		[Token(Token = "0x4022453")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		private Text _textNormalModeCaption;

		// Token: 0x04022454 RID: 140372
		[Token(Token = "0x4022454")]
		[FieldOffset(Offset = "0xE8")]
		private RoguelikeTopicBattlePassDetailState.StateBean m_stateBean;

		// Token: 0x04022455 RID: 140373
		[Token(Token = "0x4022455")]
		[FieldOffset(Offset = "0xF0")]
		private bool m_isInited;

		// Token: 0x04022456 RID: 140374
		[Token(Token = "0x4022456")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04022457 RID: 140375
		[Token(Token = "0x4022457")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04022458 RID: 140376
		[Token(Token = "0x4022458")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04022459 RID: 140377
		[Token(Token = "0x4022459")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__UpdateStyle;

		// Token: 0x0402245A RID: 140378
		[Token(Token = "0x402245A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0402245B RID: 140379
		[Token(Token = "0x402245B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnJumpToPurchaseState;

		// Token: 0x0402245C RID: 140380
		[Token(Token = "0x402245C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__RenderView;

		// Token: 0x0402245D RID: 140381
		[Token(Token = "0x402245D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnBackClick;

		// Token: 0x0402245E RID: 140382
		[Token(Token = "0x402245E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnBpPurchaseClick;

		// Token: 0x0402245F RID: 140383
		[Token(Token = "0x402245F")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02004481 RID: 17537
		[Token(Token = "0x2004481")]
		public class StateBean : IStateBean, IHotfixable
		{
			// Token: 0x0601ACBB RID: 109755 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601ACBB")]
			[Address(RVA = "0x13FFC90", Offset = "0x13FE890", VA = "0x1813FFC90")]
			public StateBean()
			{
			}

			// Token: 0x04022460 RID: 140384
			[Token(Token = "0x4022460")]
			[FieldOffset(Offset = "0x10")]
			public RoguelikeTopicBattlePassViewModel battlePassModel;

			// Token: 0x04022461 RID: 140385
			[Token(Token = "0x4022461")]
			[FieldOffset(Offset = "0x18")]
			public RoguelikeTopicBPGrandPrizeViewModel greatRewardModel;

			// Token: 0x04022462 RID: 140386
			[Token(Token = "0x4022462")]
			[FieldOffset(Offset = "0x20")]
			public string topicId;

			// Token: 0x04022463 RID: 140387
			[Token(Token = "0x4022463")]
			[FieldOffset(Offset = "0x28")]
			public bool bpPurchaseSystemUnlocked;

			// Token: 0x04022464 RID: 140388
			[Token(Token = "0x4022464")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
