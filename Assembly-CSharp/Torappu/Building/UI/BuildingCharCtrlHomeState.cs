using System;
using Il2CppDummyDll;
using Torappu.Building.Vault;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001AEB RID: 6891
	[Token(Token = "0x2001AEB")]
	public class BuildingCharCtrlHomeState : State, IMoveHolder, IValueMsgReceiver
	{
		// Token: 0x0600AE26 RID: 44582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AE26")]
		[Address(RVA = "0x328B5F0", Offset = "0x328A1F0", VA = "0x18328B5F0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0600AE27 RID: 44583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE27")]
		[Address(RVA = "0x328B9D0", Offset = "0x328A5D0", VA = "0x18328B9D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0600AE28 RID: 44584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE28")]
		[Address(RVA = "0x328BFE0", Offset = "0x328ABE0", VA = "0x18328BFE0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0600AE29 RID: 44585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE29")]
		[Address(RVA = "0x328BF50", Offset = "0x328AB50", VA = "0x18328BF50", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0600AE2A RID: 44586 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE2A")]
		[Address(RVA = "0x328C2D0", Offset = "0x328AED0", VA = "0x18328C2D0")]
		private void Update()
		{
		}

		// Token: 0x0600AE2B RID: 44587 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE2B")]
		[Address(RVA = "0x328C6C0", Offset = "0x328B2C0", VA = "0x18328C6C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600AE2C RID: 44588 RVA: 0x000431A0 File Offset: 0x000413A0
		[Token(Token = "0x600AE2C")]
		[Address(RVA = "0x328C4E0", Offset = "0x328B0E0", VA = "0x18328C4E0")]
		private Vector2 _GetAxis()
		{
			return default(Vector2);
		}

		// Token: 0x0600AE2D RID: 44589 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE2D")]
		[Address(RVA = "0x328C9E0", Offset = "0x328B5E0", VA = "0x18328C9E0")]
		private void _ShowOrHideArrow(bool isShow)
		{
		}

		// Token: 0x0600AE2E RID: 44590 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE2E")]
		[Address(RVA = "0x328CAF0", Offset = "0x328B6F0", VA = "0x18328CAF0")]
		private void _ShowOrHideEmojiPanel()
		{
		}

		// Token: 0x0600AE2F RID: 44591 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE2F")]
		[Address(RVA = "0x328C860", Offset = "0x328B460", VA = "0x18328C860")]
		private void _OnEmojiListBtnClick(string emojiId)
		{
		}

		// Token: 0x0600AE30 RID: 44592 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE30")]
		[Address(RVA = "0x328CBB0", Offset = "0x328B7B0", VA = "0x18328CBB0")]
		private void _TryToSendSendEmojiRequest(string emojiId)
		{
		}

		// Token: 0x0600AE31 RID: 44593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE31")]
		[Address(RVA = "0x328B650", Offset = "0x328A250", VA = "0x18328B650")]
		public void OnBackBtnClicked()
		{
		}

		// Token: 0x0600AE32 RID: 44594 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE32")]
		[Address(RVA = "0x328C130", Offset = "0x328AD30", VA = "0x18328C130")]
		public void OnTouchBtnClicked()
		{
		}

		// Token: 0x0600AE33 RID: 44595 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE33")]
		[Address(RVA = "0x328C1B0", Offset = "0x328ADB0", VA = "0x18328C1B0")]
		public void OnUpstairsBtnClicked()
		{
		}

		// Token: 0x0600AE34 RID: 44596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE34")]
		[Address(RVA = "0x328B7E0", Offset = "0x328A3E0", VA = "0x18328B7E0")]
		public void OnDownstairsBtnClicked()
		{
		}

		// Token: 0x0600AE35 RID: 44597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE35")]
		[Address(RVA = "0x328B8E0", Offset = "0x328A4E0", VA = "0x18328B8E0")]
		public void OnEmojiBtnClicked()
		{
		}

		// Token: 0x0600AE36 RID: 44598 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE36")]
		[Address(RVA = "0x328C070", Offset = "0x328AC70", VA = "0x18328C070")]
		public void OnShowAndHideBtnClicked()
		{
		}

		// Token: 0x1700149B RID: 5275
		// (get) Token: 0x0600AE37 RID: 44599 RVA: 0x000431B8 File Offset: 0x000413B8
		// (set) Token: 0x0600AE38 RID: 44600 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700149B")]
		public Vector2 moveDir
		{
			[Token(Token = "0x600AE37")]
			[Address(RVA = "0x328CFA0", Offset = "0x328BBA0", VA = "0x18328CFA0", Slot = "23")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x600AE38")]
			[Address(RVA = "0x328D000", Offset = "0x328BC00", VA = "0x18328D000", Slot = "24")]
			set
			{
			}
		}

		// Token: 0x0600AE39 RID: 44601 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE39")]
		[Address(RVA = "0x328BEE0", Offset = "0x328AAE0", VA = "0x18328BEE0", Slot = "25")]
		public void OnMoverStateChanged()
		{
		}

		// Token: 0x0600AE3A RID: 44602 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE3A")]
		[Address(RVA = "0x328BCA0", Offset = "0x328A8A0", VA = "0x18328BCA0", Slot = "26")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0600AE3B RID: 44603 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE3B")]
		[Address(RVA = "0x328CDA0", Offset = "0x328B9A0", VA = "0x18328CDA0")]
		public BuildingCharCtrlHomeState()
		{
		}

		// Token: 0x0600AE3D RID: 44605 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE3D")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0600AE3E RID: 44606 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE3E")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0600AE3F RID: 44607 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AE3F")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x0400A685 RID: 42629
		[Token(Token = "0x400A685")]
		private const float ARROW_HIDE_GAP = 0.2f;

		// Token: 0x0400A686 RID: 42630
		[Token(Token = "0x400A686")]
		[NonSerialized]
		public const int MSG_EMOJI_LIST_BTN_CLICK = 1;

		// Token: 0x0400A687 RID: 42631
		[Token(Token = "0x400A687")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private BuildingCharCtrlHomeView _homeView;

		// Token: 0x0400A688 RID: 42632
		[Token(Token = "0x400A688")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private BuildingCharCtrlRoomTitleView _roomTitle;

		// Token: 0x0400A689 RID: 42633
		[Token(Token = "0x400A689")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform _rectTransformBack;

		// Token: 0x0400A68A RID: 42634
		[Token(Token = "0x400A68A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private RectTransform _rectTransformArrow;

		// Token: 0x0400A68B RID: 42635
		[Token(Token = "0x400A68B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private CanvasGroup _canvasGroupArrow;

		// Token: 0x0400A68C RID: 42636
		[Token(Token = "0x400A68C")]
		[FieldOffset(Offset = "0x78")]
		private BuildingCharCtrlHomeState.BuildingCharCtrlHomeStateBean m_stateBean;

		// Token: 0x0400A68D RID: 42637
		[Token(Token = "0x400A68D")]
		[FieldOffset(Offset = "0x80")]
		private FadeSwitchTween m_arrowFadeTween;

		// Token: 0x0400A68E RID: 42638
		[Token(Token = "0x400A68E")]
		[FieldOffset(Offset = "0x88")]
		private long m_cachedNextRequestTs;

		// Token: 0x0400A68F RID: 42639
		[Token(Token = "0x400A68F")]
		[FieldOffset(Offset = "0x90")]
		private bool m_isInited;

		// Token: 0x0400A690 RID: 42640
		[Token(Token = "0x400A690")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0400A691 RID: 42641
		[Token(Token = "0x400A691")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400A692 RID: 42642
		[Token(Token = "0x400A692")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0400A693 RID: 42643
		[Token(Token = "0x400A693")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x0400A694 RID: 42644
		[Token(Token = "0x400A694")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400A695 RID: 42645
		[Token(Token = "0x400A695")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400A696 RID: 42646
		[Token(Token = "0x400A696")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__GetAxis;

		// Token: 0x0400A697 RID: 42647
		[Token(Token = "0x400A697")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ShowOrHideArrow;

		// Token: 0x0400A698 RID: 42648
		[Token(Token = "0x400A698")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__ShowOrHideEmojiPanel;

		// Token: 0x0400A699 RID: 42649
		[Token(Token = "0x400A699")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnEmojiListBtnClick;

		// Token: 0x0400A69A RID: 42650
		[Token(Token = "0x400A69A")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__TryToSendSendEmojiRequest;

		// Token: 0x0400A69B RID: 42651
		[Token(Token = "0x400A69B")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnBackBtnClicked;

		// Token: 0x0400A69C RID: 42652
		[Token(Token = "0x400A69C")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnTouchBtnClicked;

		// Token: 0x0400A69D RID: 42653
		[Token(Token = "0x400A69D")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnUpstairsBtnClicked;

		// Token: 0x0400A69E RID: 42654
		[Token(Token = "0x400A69E")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnDownstairsBtnClicked;

		// Token: 0x0400A69F RID: 42655
		[Token(Token = "0x400A69F")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_OnEmojiBtnClicked;

		// Token: 0x0400A6A0 RID: 42656
		[Token(Token = "0x400A6A0")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_OnShowAndHideBtnClicked;

		// Token: 0x0400A6A1 RID: 42657
		[Token(Token = "0x400A6A1")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_get_moveDir;

		// Token: 0x0400A6A2 RID: 42658
		[Token(Token = "0x400A6A2")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_set_moveDir;

		// Token: 0x0400A6A3 RID: 42659
		[Token(Token = "0x400A6A3")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnMoverStateChanged;

		// Token: 0x0400A6A4 RID: 42660
		[Token(Token = "0x400A6A4")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0400A6A5 RID: 42661
		[Token(Token = "0x400A6A5")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001AEC RID: 6892
		[Token(Token = "0x2001AEC")]
		private class BuildingCharCtrlHomeStateBean : IStateBean, IHotfixable
		{
			// Token: 0x0600AE40 RID: 44608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE40")]
			[Address(RVA = "0x328B020", Offset = "0x3289C20", VA = "0x18328B020")]
			public void LoadData()
			{
			}

			// Token: 0x0600AE41 RID: 44609 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE41")]
			[Address(RVA = "0x328B2D0", Offset = "0x3289ED0", VA = "0x18328B2D0")]
			public void UpdateData()
			{
			}

			// Token: 0x0600AE42 RID: 44610 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AE42")]
			[Address(RVA = "0x328B480", Offset = "0x328A080", VA = "0x18328B480")]
			public BuildingCharCtrlHomeStateBean()
			{
			}

			// Token: 0x0400A6A6 RID: 42662
			[Token(Token = "0x400A6A6")]
			[FieldOffset(Offset = "0x10")]
			public BuildingCharCtrlHomeViewModelProperty property;

			// Token: 0x0400A6A7 RID: 42663
			[Token(Token = "0x400A6A7")]
			[FieldOffset(Offset = "0x18")]
			public CommonBasicRoomViewProperty basicRoomProperty;

			// Token: 0x0400A6A8 RID: 42664
			[Token(Token = "0x400A6A8")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_LoadData;

			// Token: 0x0400A6A9 RID: 42665
			[Token(Token = "0x400A6A9")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_UpdateData;

			// Token: 0x0400A6AA RID: 42666
			[Token(Token = "0x400A6AA")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}
	}
}
