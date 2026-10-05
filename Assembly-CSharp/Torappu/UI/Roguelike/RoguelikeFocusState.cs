using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.UI.EnemyHandBook;
using UnityEngine;
using XLua;

namespace Torappu.UI.Roguelike
{
	// Token: 0x02005230 RID: 21040
	[Token(Token = "0x2005230")]
	public class RoguelikeFocusState : PopupFadeState, IPopupCustomActive
	{
		// Token: 0x0601F0BB RID: 127163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F0BB")]
		[Address(RVA = "0x18BB890", Offset = "0x18BA490", VA = "0x1818BB890")]
		private RoguelikeFocusView _InitFocusView(string topicId)
		{
			return null;
		}

		// Token: 0x0601F0BC RID: 127164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F0BC")]
		[Address(RVA = "0x18BB230", Offset = "0x18B9E30", VA = "0x1818BB230", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601F0BD RID: 127165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F0BD")]
		[Address(RVA = "0x18BA960", Offset = "0x18B9560", VA = "0x1818BA960", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601F0BE RID: 127166 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0BE")]
		[Address(RVA = "0x18BB370", Offset = "0x18B9F70", VA = "0x1818BB370", Slot = "25")]
		protected override void ShowImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601F0BF RID: 127167 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0BF")]
		[Address(RVA = "0x18BAAA0", Offset = "0x18B96A0", VA = "0x1818BAAA0", Slot = "26")]
		protected override void HideImmediately(UIPopupState.TransactionContext context)
		{
		}

		// Token: 0x0601F0C0 RID: 127168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F0C0")]
		[Address(RVA = "0x18BA900", Offset = "0x18B9500", VA = "0x1818BA900", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601F0C1 RID: 127169 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0C1")]
		[Address(RVA = "0x18BB900", Offset = "0x18BA500", VA = "0x1818BB900")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601F0C2 RID: 127170 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0C2")]
		[Address(RVA = "0x18BABC0", Offset = "0x18B97C0", VA = "0x1818BABC0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601F0C3 RID: 127171 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0C3")]
		[Address(RVA = "0x18BAF00", Offset = "0x18B9B00", VA = "0x1818BAF00", Slot = "16")]
		protected override void OnPreResume(bool isFromStack)
		{
		}

		// Token: 0x0601F0C4 RID: 127172 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0C4")]
		[Address(RVA = "0x18BAF80", Offset = "0x18B9B80", VA = "0x1818BAF80", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601F0C5 RID: 127173 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0C5")]
		[Address(RVA = "0x18BAE90", Offset = "0x18B9A90", VA = "0x1818BAE90", Slot = "17")]
		protected override void OnPause()
		{
		}

		// Token: 0x0601F0C6 RID: 127174 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0C6")]
		[Address(RVA = "0x18BAE20", Offset = "0x18B9A20", VA = "0x1818BAE20", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601F0C7 RID: 127175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F0C7")]
		[Address(RVA = "0x18BB120", Offset = "0x18B9D20", VA = "0x1818BB120", Slot = "20")]
		public override ITransAction PickDynamicTransAction(State otherState, TransitionType transType)
		{
			return null;
		}

		// Token: 0x0601F0C8 RID: 127176 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0C8")]
		[Address(RVA = "0x18BD9E0", Offset = "0x18BC5E0", VA = "0x1818BD9E0")]
		private void _SetEffectVisible(bool isVisible)
		{
		}

		// Token: 0x0601F0C9 RID: 127177 RVA: 0x000B0BE0 File Offset: 0x000AEDE0
		[Token(Token = "0x601F0C9")]
		[Address(RVA = "0x18BA020", Offset = "0x18B8C20", VA = "0x1818BA020", Slot = "31")]
		public bool CustomSetActive(bool active)
		{
			return default(bool);
		}

		// Token: 0x0601F0CA RID: 127178 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0CA")]
		[Address(RVA = "0x18BA0C0", Offset = "0x18B8CC0", VA = "0x1818BA0C0")]
		public void EventOnConfirmClicked()
		{
		}

		// Token: 0x0601F0CB RID: 127179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0CB")]
		[Address(RVA = "0x18BC4C0", Offset = "0x18BB0C0", VA = "0x1818BC4C0")]
		private void _OnFocusingNode(RoguelikeDungeonNode focusNode, RoguelikeDungeonController controller, IStateEngine stateEngine)
		{
		}

		// Token: 0x0601F0CC RID: 127180 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0CC")]
		[Address(RVA = "0x18BC8E0", Offset = "0x18BB4E0", VA = "0x1818BC8E0")]
		private void _OnFragmentModule(RoguelikeDungeonNode focusNode, RoguelikeDungeonController controller, IStateEngine stateEngine)
		{
		}

		// Token: 0x0601F0CD RID: 127181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0CD")]
		[Address(RVA = "0x18BC5A0", Offset = "0x18BB1A0", VA = "0x1818BC5A0")]
		private void _OnFragmentDialogConfirm(RoguelikeDungeonNode focusNode, bool isHeavy, bool isOverLoad)
		{
		}

		// Token: 0x0601F0CE RID: 127182 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0CE")]
		[Address(RVA = "0x18BC3D0", Offset = "0x18BAFD0", VA = "0x1818BC3D0")]
		private void _OnFocusingNodeImpl(RoguelikeDungeonNode focusNode, RoguelikeDungeonController controller, IStateEngine stateEngine)
		{
		}

		// Token: 0x0601F0CF RID: 127183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0CF")]
		[Address(RVA = "0x18BD510", Offset = "0x18BC110", VA = "0x1818BD510")]
		private void _OnSendConfirmRequest(RoguelikeDungeonNode focusNode, RoguelikeDungeonController controller)
		{
		}

		// Token: 0x0601F0D0 RID: 127184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0D0")]
		[Address(RVA = "0x18BD220", Offset = "0x18BBE20", VA = "0x1818BD220")]
		private void _OnSendConfirmRequestImpl(RoguelikeDungeonNode focusNode, RoguelikeDungeonController controller)
		{
		}

		// Token: 0x0601F0D1 RID: 127185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0D1")]
		[Address(RVA = "0x18BA320", Offset = "0x18B8F20", VA = "0x1818BA320")]
		public void EventOnEnemyBookClicked()
		{
		}

		// Token: 0x0601F0D2 RID: 127186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0D2")]
		[Address(RVA = "0x18BA440", Offset = "0x18B9040", VA = "0x1818BA440")]
		public void EventOnRollNodeClicked()
		{
		}

		// Token: 0x0601F0D3 RID: 127187 RVA: 0x000B0BF8 File Offset: 0x000AEDF8
		[Token(Token = "0x601F0D3")]
		[Address(RVA = "0x18BCC40", Offset = "0x18BB840", VA = "0x1818BCC40")]
		public bool _OnRollNodeConfirm()
		{
			return default(bool);
		}

		// Token: 0x0601F0D4 RID: 127188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0D4")]
		[Address(RVA = "0x18BB4A0", Offset = "0x18BA0A0", VA = "0x1818BB4A0")]
		private void _EventOnBackClicked()
		{
		}

		// Token: 0x0601F0D5 RID: 127189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0D5")]
		[Address(RVA = "0x18BD790", Offset = "0x18BC390", VA = "0x1818BD790")]
		private void _RefreshInfo()
		{
		}

		// Token: 0x0601F0D6 RID: 127190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0D6")]
		[Address(RVA = "0x18BB760", Offset = "0x18BA360", VA = "0x1818BB760")]
		private void _ConfigureWidgets()
		{
		}

		// Token: 0x0601F0D7 RID: 127191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F0D7")]
		[Address(RVA = "0x18BBDF0", Offset = "0x18BA9F0", VA = "0x1818BBDF0")]
		private List<EnemyHandBookEverViewModel> _MakeEnemyHandBookList()
		{
			return null;
		}

		// Token: 0x0601F0D8 RID: 127192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0D8")]
		[Address(RVA = "0x18BB650", Offset = "0x18BA250", VA = "0x1818BB650")]
		private void _BindNodeUnlockStrategies()
		{
		}

		// Token: 0x0601F0D9 RID: 127193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0D9")]
		[Address(RVA = "0x18BDAA0", Offset = "0x18BC6A0", VA = "0x1818BDAA0")]
		private void _TryUnlockNodeByCost(RoguelikeDungeonNode focusNode, RoguelikeDungeonController controller)
		{
		}

		// Token: 0x0601F0DA RID: 127194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0DA")]
		[Address(RVA = "0x18BDD70", Offset = "0x18BC970", VA = "0x1818BDD70")]
		public RoguelikeFocusState()
		{
		}

		// Token: 0x0601F0DC RID: 127196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F0DC")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0601F0DD RID: 127197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F0DD")]
		[Address(RVA = "0x180FDD0", Offset = "0x180E9D0", VA = "0x18180FDD0")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x0601F0DE RID: 127198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0DE")]
		[Address(RVA = "0x12B83C0", Offset = "0x12B6FC0", VA = "0x1812B83C0")]
		private void <>xLuaBaseProxy_ShowImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x0601F0DF RID: 127199 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0DF")]
		[Address(RVA = "0x180FE00", Offset = "0x180EA00", VA = "0x18180FE00")]
		private void <>xLuaBaseProxy_HideImmediately(UIPopupState.TransactionContext P0)
		{
		}

		// Token: 0x0601F0E0 RID: 127200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0E0")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601F0E1 RID: 127201 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0E1")]
		[Address(RVA = "0x1061490", Offset = "0x1060090", VA = "0x181061490")]
		private void <>xLuaBaseProxy_OnPreResume(bool P0)
		{
		}

		// Token: 0x0601F0E2 RID: 127202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0E2")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0601F0E3 RID: 127203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0E3")]
		[Address(RVA = "0xF807D0", Offset = "0xF7F3D0", VA = "0x180F807D0")]
		private void <>xLuaBaseProxy_OnPause()
		{
		}

		// Token: 0x0601F0E4 RID: 127204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601F0E4")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0601F0E5 RID: 127205 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601F0E5")]
		[Address(RVA = "0x18BB490", Offset = "0x18BA090", VA = "0x1818BB490")]
		private ITransAction <>xLuaBaseProxy_PickDynamicTransAction(State P0, TransitionType P1)
		{
			return null;
		}

		// Token: 0x04029A54 RID: 170580
		[Token(Token = "0x4029A54")]
		private const float FADE_IN_FOCUS_TIME = 0.5f;

		// Token: 0x04029A55 RID: 170581
		[Token(Token = "0x4029A55")]
		private const float FADE_IN_DELAY = 0.2f;

		// Token: 0x04029A56 RID: 170582
		[Token(Token = "0x4029A56")]
		private const float SHOW_DURATION = 0.3f;

		// Token: 0x04029A57 RID: 170583
		[Token(Token = "0x4029A57")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private RectTransform _panelTopMenu;

		// Token: 0x04029A58 RID: 170584
		[Token(Token = "0x4029A58")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _panelRaycastBlock;

		// Token: 0x04029A59 RID: 170585
		[Token(Token = "0x4029A59")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Transform _container;

		// Token: 0x04029A5A RID: 170586
		[Token(Token = "0x4029A5A")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private RoguelikeNodeCheckUnlockStrategyFactory _nodeCheckUnlockStrategyFactory;

		// Token: 0x04029A5B RID: 170587
		[Token(Token = "0x4029A5B")]
		[FieldOffset(Offset = "0x90")]
		private RoguelikeFocusView m_view;

		// Token: 0x04029A5C RID: 170588
		[Token(Token = "0x4029A5C")]
		[FieldOffset(Offset = "0x98")]
		private RoguelikeFocusStatePlugin m_statePlugin;

		// Token: 0x04029A5D RID: 170589
		[Token(Token = "0x4029A5D")]
		[FieldOffset(Offset = "0xA0")]
		private bool m_inited;

		// Token: 0x04029A5E RID: 170590
		[Token(Token = "0x4029A5E")]
		[FieldOffset(Offset = "0xA8")]
		private RoguelikeFocusState.ShowSwitchTween m_showSwitchTween;

		// Token: 0x04029A5F RID: 170591
		[Token(Token = "0x4029A5F")]
		[FieldOffset(Offset = "0xB0")]
		private RoguelikeFocusState.MenuAdapter m_menuAdapter;

		// Token: 0x04029A60 RID: 170592
		[Token(Token = "0x4029A60")]
		[FieldOffset(Offset = "0xB8")]
		private RoguelikeFocusState.ForwardOutTransition m_forwardOutTrans;

		// Token: 0x04029A61 RID: 170593
		[Token(Token = "0x4029A61")]
		[FieldOffset(Offset = "0xC0")]
		private GameObject m_effectPrefab;

		// Token: 0x04029A62 RID: 170594
		[Token(Token = "0x4029A62")]
		[FieldOffset(Offset = "0xC8")]
		private GameObject m_effectInst;

		// Token: 0x04029A63 RID: 170595
		[Token(Token = "0x4029A63")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitFocusView;

		// Token: 0x04029A64 RID: 170596
		[Token(Token = "0x4029A64")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x04029A65 RID: 170597
		[Token(Token = "0x4029A65")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x04029A66 RID: 170598
		[Token(Token = "0x4029A66")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ShowImmediately;

		// Token: 0x04029A67 RID: 170599
		[Token(Token = "0x4029A67")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_HideImmediately;

		// Token: 0x04029A68 RID: 170600
		[Token(Token = "0x4029A68")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04029A69 RID: 170601
		[Token(Token = "0x4029A69")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04029A6A RID: 170602
		[Token(Token = "0x4029A6A")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04029A6B RID: 170603
		[Token(Token = "0x4029A6B")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnPreResume;

		// Token: 0x04029A6C RID: 170604
		[Token(Token = "0x4029A6C")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04029A6D RID: 170605
		[Token(Token = "0x4029A6D")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnPause;

		// Token: 0x04029A6E RID: 170606
		[Token(Token = "0x4029A6E")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04029A6F RID: 170607
		[Token(Token = "0x4029A6F")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_PickDynamicTransAction;

		// Token: 0x04029A70 RID: 170608
		[Token(Token = "0x4029A70")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__SetEffectVisible;

		// Token: 0x04029A71 RID: 170609
		[Token(Token = "0x4029A71")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_CustomSetActive;

		// Token: 0x04029A72 RID: 170610
		[Token(Token = "0x4029A72")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_EventOnConfirmClicked;

		// Token: 0x04029A73 RID: 170611
		[Token(Token = "0x4029A73")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0__OnFocusingNode;

		// Token: 0x04029A74 RID: 170612
		[Token(Token = "0x4029A74")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0__OnFragmentModule;

		// Token: 0x04029A75 RID: 170613
		[Token(Token = "0x4029A75")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnFragmentDialogConfirm;

		// Token: 0x04029A76 RID: 170614
		[Token(Token = "0x4029A76")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnFocusingNodeImpl;

		// Token: 0x04029A77 RID: 170615
		[Token(Token = "0x4029A77")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnSendConfirmRequest;

		// Token: 0x04029A78 RID: 170616
		[Token(Token = "0x4029A78")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__OnSendConfirmRequestImpl;

		// Token: 0x04029A79 RID: 170617
		[Token(Token = "0x4029A79")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_EventOnEnemyBookClicked;

		// Token: 0x04029A7A RID: 170618
		[Token(Token = "0x4029A7A")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_EventOnRollNodeClicked;

		// Token: 0x04029A7B RID: 170619
		[Token(Token = "0x4029A7B")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__OnRollNodeConfirm;

		// Token: 0x04029A7C RID: 170620
		[Token(Token = "0x4029A7C")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__EventOnBackClicked;

		// Token: 0x04029A7D RID: 170621
		[Token(Token = "0x4029A7D")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0__RefreshInfo;

		// Token: 0x04029A7E RID: 170622
		[Token(Token = "0x4029A7E")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__ConfigureWidgets;

		// Token: 0x04029A7F RID: 170623
		[Token(Token = "0x4029A7F")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__MakeEnemyHandBookList;

		// Token: 0x04029A80 RID: 170624
		[Token(Token = "0x4029A80")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__BindNodeUnlockStrategies;

		// Token: 0x04029A81 RID: 170625
		[Token(Token = "0x4029A81")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0__TryUnlockNodeByCost;

		// Token: 0x04029A82 RID: 170626
		[Token(Token = "0x4029A82")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005231 RID: 21041
		[Token(Token = "0x2005231")]
		private class MenuAdapter : RoguelikeMenuAdapter
		{
			// Token: 0x170048A0 RID: 18592
			// (get) Token: 0x0601F0E6 RID: 127206 RVA: 0x000B0C10 File Offset: 0x000AEE10
			[Token(Token = "0x170048A0")]
			public override bool showStatusBar
			{
				[Token(Token = "0x601F0E6")]
				[Address(RVA = "0x18C79C0", Offset = "0x18C65C0", VA = "0x1818C79C0", Slot = "5")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170048A1 RID: 18593
			// (get) Token: 0x0601F0E7 RID: 127207 RVA: 0x000B0C28 File Offset: 0x000AEE28
			[Token(Token = "0x170048A1")]
			public override bool showBottomBar
			{
				[Token(Token = "0x601F0E7")]
				[Address(RVA = "0x18C7960", Offset = "0x18C6560", VA = "0x1818C7960", Slot = "4")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x170048A2 RID: 18594
			// (get) Token: 0x0601F0E8 RID: 127208 RVA: 0x000B0C40 File Offset: 0x000AEE40
			[Token(Token = "0x170048A2")]
			public override RoguelikeMenuTotemObjectStatus totemMenuObjectStatus
			{
				[Token(Token = "0x601F0E8")]
				[Address(RVA = "0x18C7A20", Offset = "0x18C6620", VA = "0x1818C7A20", Slot = "10")]
				get
				{
					return RoguelikeMenuTotemObjectStatus.NORMAL;
				}
			}

			// Token: 0x0601F0E9 RID: 127209 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F0E9")]
			[Address(RVA = "0x18C7900", Offset = "0x18C6500", VA = "0x1818C7900")]
			public MenuAdapter()
			{
			}

			// Token: 0x0601F0EA RID: 127210 RVA: 0x000B0C58 File Offset: 0x000AEE58
			[Token(Token = "0x601F0EA")]
			[Address(RVA = "0x189EFF0", Offset = "0x189DBF0", VA = "0x18189EFF0")]
			private bool <>xLuaBaseProxy_get_showStatusBar()
			{
				return default(bool);
			}

			// Token: 0x0601F0EB RID: 127211 RVA: 0x000B0C70 File Offset: 0x000AEE70
			[Token(Token = "0x601F0EB")]
			[Address(RVA = "0x189EFE0", Offset = "0x189DBE0", VA = "0x18189EFE0")]
			private bool <>xLuaBaseProxy_get_showBottomBar()
			{
				return default(bool);
			}

			// Token: 0x0601F0EC RID: 127212 RVA: 0x000B0C88 File Offset: 0x000AEE88
			[Token(Token = "0x601F0EC")]
			[Address(RVA = "0x18C78F0", Offset = "0x18C64F0", VA = "0x1818C78F0")]
			private RoguelikeMenuTotemObjectStatus <>xLuaBaseProxy_get_totemMenuObjectStatus()
			{
				return RoguelikeMenuTotemObjectStatus.NORMAL;
			}

			// Token: 0x04029A83 RID: 170627
			[Token(Token = "0x4029A83")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge __Hotfix0_get_showStatusBar;

			// Token: 0x04029A84 RID: 170628
			[Token(Token = "0x4029A84")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_get_showBottomBar;

			// Token: 0x04029A85 RID: 170629
			[Token(Token = "0x4029A85")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_get_totemMenuObjectStatus;

			// Token: 0x04029A86 RID: 170630
			[Token(Token = "0x4029A86")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge _c__Hotfix0_ctor;
		}

		// Token: 0x02005232 RID: 21042
		[Token(Token = "0x2005232")]
		public class ShowSwitchTween : UISwitchTween
		{
			// Token: 0x0601F0ED RID: 127213 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F0ED")]
			[Address(RVA = "0x18DBFC0", Offset = "0x18DABC0", VA = "0x1818DBFC0")]
			public ShowSwitchTween(RoguelikeFocusState closure)
			{
			}

			// Token: 0x0601F0EE RID: 127214 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F0EE")]
			[Address(RVA = "0x18DBB00", Offset = "0x18DA700", VA = "0x1818DBB00", Slot = "4")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfShow()
			{
				return null;
			}

			// Token: 0x0601F0EF RID: 127215 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x601F0EF")]
			[Address(RVA = "0x18DB9F0", Offset = "0x18DA5F0", VA = "0x1818DB9F0", Slot = "5")]
			protected override UISwitchTween.ITweenHandler GenerateTweenOfHide()
			{
				return null;
			}

			// Token: 0x0601F0F0 RID: 127216 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F0F0")]
			[Address(RVA = "0x18DB700", Offset = "0x18DA300", VA = "0x1818DB700", Slot = "9")]
			protected override void AfterHideEffect()
			{
			}

			// Token: 0x0601F0F1 RID: 127217 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F0F1")]
			[Address(RVA = "0x18DB7D0", Offset = "0x18DA3D0", VA = "0x1818DB7D0", Slot = "6")]
			protected override void BeforeShowEffect()
			{
			}

			// Token: 0x0601F0F2 RID: 127218 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F0F2")]
			[Address(RVA = "0x18DBE40", Offset = "0x18DAA40", VA = "0x1818DBE40", Slot = "10")]
			protected override void ResetToState(bool isShow)
			{
			}

			// Token: 0x0601F0F3 RID: 127219 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F0F3")]
			[Address(RVA = "0x9C2DA0", Offset = "0x9C19A0", VA = "0x1809C2DA0")]
			private void <>xLuaBaseProxy_AfterHideEffect()
			{
			}

			// Token: 0x0601F0F4 RID: 127220 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F0F4")]
			[Address(RVA = "0xDFAF10", Offset = "0xDF9B10", VA = "0x180DFAF10")]
			private void <>xLuaBaseProxy_BeforeShowEffect()
			{
			}

			// Token: 0x0601F0F5 RID: 127221 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F0F5")]
			[Address(RVA = "0x9B38B0", Offset = "0x9B24B0", VA = "0x1809B38B0")]
			private void <>xLuaBaseProxy_ResetToState(bool P0)
			{
			}

			// Token: 0x04029A87 RID: 170631
			[Token(Token = "0x4029A87")]
			[FieldOffset(Offset = "0x48")]
			private RoguelikeFocusState m_closure;

			// Token: 0x04029A88 RID: 170632
			[Token(Token = "0x4029A88")]
			[FieldOffset(Offset = "0x0")]
			private static DelegateBridge _c__Hotfix0_ctor;

			// Token: 0x04029A89 RID: 170633
			[Token(Token = "0x4029A89")]
			[FieldOffset(Offset = "0x8")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfShow;

			// Token: 0x04029A8A RID: 170634
			[Token(Token = "0x4029A8A")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_GenerateTweenOfHide;

			// Token: 0x04029A8B RID: 170635
			[Token(Token = "0x4029A8B")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0_AfterHideEffect;

			// Token: 0x04029A8C RID: 170636
			[Token(Token = "0x4029A8C")]
			[FieldOffset(Offset = "0x20")]
			private static DelegateBridge __Hotfix0_BeforeShowEffect;

			// Token: 0x04029A8D RID: 170637
			[Token(Token = "0x4029A8D")]
			[FieldOffset(Offset = "0x28")]
			private static DelegateBridge __Hotfix0_ResetToState;
		}

		// Token: 0x02005233 RID: 21043
		[Token(Token = "0x2005233")]
		private class ForwardOutTransition : ITransAction
		{
			// Token: 0x0601F0F6 RID: 127222 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F0F6")]
			[Address(RVA = "0x557D40", Offset = "0x556940", VA = "0x180557D40")]
			public ForwardOutTransition(RoguelikeFocusState closure)
			{
			}

			// Token: 0x170048A3 RID: 18595
			// (get) Token: 0x0601F0F7 RID: 127223 RVA: 0x000B0CA0 File Offset: 0x000AEEA0
			[Token(Token = "0x170048A3")]
			public TransActionType ActionType
			{
				[Token(Token = "0x601F0F7")]
				[Address(RVA = "0x557C40", Offset = "0x556840", VA = "0x180557C40", Slot = "6")]
				get
				{
					return TransActionType.SEQUENTIAL;
				}
			}

			// Token: 0x0601F0F8 RID: 127224 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F0F8")]
			[Address(RVA = "0x18C78B0", Offset = "0x18C64B0", VA = "0x1818C78B0", Slot = "4")]
			public void Execute(State fromState, State toState, TransActionListener mustInvokeEnd)
			{
			}

			// Token: 0x0601F0F9 RID: 127225 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x601F0F9")]
			[Address(RVA = "0x18C7870", Offset = "0x18C6470", VA = "0x1818C7870", Slot = "5")]
			public void ExecuteFastMode(State fromState, State toState, TransActionListener mustInvokeEnd)
			{
			}

			// Token: 0x04029A8E RID: 170638
			[Token(Token = "0x4029A8E")]
			[FieldOffset(Offset = "0x10")]
			private RoguelikeFocusState m_closure;
		}
	}
}
