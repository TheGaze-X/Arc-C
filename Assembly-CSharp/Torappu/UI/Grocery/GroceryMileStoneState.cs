using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004D43 RID: 19779
	[Token(Token = "0x2004D43")]
	public class GroceryMileStoneState : PopupFadeState, IValueMsgReceiver, IHotfixable
	{
		// Token: 0x0601D998 RID: 121240 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D998")]
		[Address(RVA = "0x172FB10", Offset = "0x172E710", VA = "0x18172FB10", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601D999 RID: 121241 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D999")]
		[Address(RVA = "0x172FB70", Offset = "0x172E770", VA = "0x18172FB70", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601D99A RID: 121242 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D99A")]
		[Address(RVA = "0x172FDC0", Offset = "0x172E9C0", VA = "0x18172FDC0", Slot = "23")]
		protected override IEnumerator ShowCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x0601D99B RID: 121243 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D99B")]
		[Address(RVA = "0x172FCD0", Offset = "0x172E8D0", VA = "0x18172FCD0", Slot = "31")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x0601D99C RID: 121244 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D99C")]
		[Address(RVA = "0x1730660", Offset = "0x172F260", VA = "0x181730660")]
		private void _OnItemClick(string mileStoneId)
		{
		}

		// Token: 0x0601D99D RID: 121245 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D99D")]
		[Address(RVA = "0x1730320", Offset = "0x172EF20", VA = "0x181730320")]
		private void _OnGetAllClick()
		{
		}

		// Token: 0x0601D99E RID: 121246 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D99E")]
		[Address(RVA = "0x172FF10", Offset = "0x172EB10", VA = "0x18172FF10")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601D99F RID: 121247 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D99F")]
		[Address(RVA = "0x1730020", Offset = "0x172EC20", VA = "0x181730020")]
		private void _LoadData()
		{
		}

		// Token: 0x0601D9A0 RID: 121248 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9A0")]
		[Address(RVA = "0x1730B20", Offset = "0x172F720", VA = "0x181730B20")]
		private void _RefreshData()
		{
		}

		// Token: 0x0601D9A1 RID: 121249 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D9A1")]
		[Address(RVA = "0x1730A30", Offset = "0x172F630", VA = "0x181730A30")]
		private static IEnumerator _ReceiveItemsCoroutine(List<RewardItemModel> rewardList, UIGainItemFloatPanel.Style style = UIGainItemFloatPanel.Style.DEFAULT, [Optional] Action onConfirm)
		{
			return null;
		}

		// Token: 0x0601D9A2 RID: 121250 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9A2")]
		[Address(RVA = "0x1730220", Offset = "0x172EE20", VA = "0x181730220")]
		private void _OnBackBtnClicked()
		{
		}

		// Token: 0x0601D9A3 RID: 121251 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9A3")]
		[Address(RVA = "0x1730C40", Offset = "0x172F840", VA = "0x181730C40")]
		public GroceryMileStoneState()
		{
		}

		// Token: 0x0601D9A5 RID: 121253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D9A5")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601D9A6 RID: 121254 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601D9A6")]
		[Address(RVA = "0x1089D20", Offset = "0x1088920", VA = "0x181089D20")]
		private IEnumerator <>xLuaBaseProxy_ShowCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x04027195 RID: 160149
		[Token(Token = "0x4027195")]
		[NonSerialized]
		public const int ON_MSG_MILE_STONE_ITEM_CLICKED = 0;

		// Token: 0x04027196 RID: 160150
		[Token(Token = "0x4027196")]
		[NonSerialized]
		public const int ON_MSG_MILE_STONE_ALL_CLICKED = 1;

		// Token: 0x04027197 RID: 160151
		[Token(Token = "0x4027197")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private GroceryMileStoneView _view;

		// Token: 0x04027198 RID: 160152
		[Token(Token = "0x4027198")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private RectTransform _topMenu;

		// Token: 0x04027199 RID: 160153
		[Token(Token = "0x4027199")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private GroceryMileStoneStateBean m_stateBean;

		// Token: 0x0402719A RID: 160154
		[Token(Token = "0x402719A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0402719B RID: 160155
		[Token(Token = "0x402719B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		private string m_actId;

		// Token: 0x0402719C RID: 160156
		[Token(Token = "0x402719C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402719D RID: 160157
		[Token(Token = "0x402719D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402719E RID: 160158
		[Token(Token = "0x402719E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0402719F RID: 160159
		[Token(Token = "0x402719F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x040271A0 RID: 160160
		[Token(Token = "0x40271A0")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__OnItemClick;

		// Token: 0x040271A1 RID: 160161
		[Token(Token = "0x40271A1")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnGetAllClick;

		// Token: 0x040271A2 RID: 160162
		[Token(Token = "0x40271A2")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040271A3 RID: 160163
		[Token(Token = "0x40271A3")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__LoadData;

		// Token: 0x040271A4 RID: 160164
		[Token(Token = "0x40271A4")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__RefreshData;

		// Token: 0x040271A5 RID: 160165
		[Token(Token = "0x40271A5")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ReceiveItemsCoroutine;

		// Token: 0x040271A6 RID: 160166
		[Token(Token = "0x40271A6")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OnBackBtnClicked;

		// Token: 0x040271A7 RID: 160167
		[Token(Token = "0x40271A7")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
