using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E57 RID: 24151
	[Token(Token = "0x2005E57")]
	public class ItemRepoIssueVoucherState : PopupFloatState, IValueMsgReceiver
	{
		// Token: 0x06022FD2 RID: 143314 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022FD2")]
		[Address(RVA = "0x1D82E60", Offset = "0x1D81A60", VA = "0x181D82E60", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022FD3 RID: 143315 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022FD3")]
		[Address(RVA = "0x1D82EC0", Offset = "0x1D81AC0", VA = "0x181D82EC0", Slot = "24")]
		protected override IEnumerator HideCoroutine(UIPopupState.TransactionContext context)
		{
			return null;
		}

		// Token: 0x06022FD4 RID: 143316 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FD4")]
		[Address(RVA = "0x1D83010", Offset = "0x1D81C10", VA = "0x181D83010", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022FD5 RID: 143317 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FD5")]
		[Address(RVA = "0x1D835B0", Offset = "0x1D821B0", VA = "0x181D835B0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06022FD6 RID: 143318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FD6")]
		[Address(RVA = "0x1D83630", Offset = "0x1D82230", VA = "0x181D83630", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06022FD7 RID: 143319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FD7")]
		[Address(RVA = "0x1D82CF0", Offset = "0x1D818F0", VA = "0x181D82CF0")]
		public void BackToChoosePartOrDismissSelf()
		{
		}

		// Token: 0x06022FD8 RID: 143320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FD8")]
		[Address(RVA = "0x1D83CF0", Offset = "0x1D828F0", VA = "0x181D83CF0")]
		private void _ChooseConfirm()
		{
		}

		// Token: 0x06022FD9 RID: 143321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FD9")]
		[Address(RVA = "0x1D83DD0", Offset = "0x1D829D0", VA = "0x181D83DD0")]
		private void _OutputCancel()
		{
		}

		// Token: 0x06022FDA RID: 143322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FDA")]
		[Address(RVA = "0x1D83EB0", Offset = "0x1D82AB0", VA = "0x181D83EB0")]
		private void _OutputConfirm()
		{
		}

		// Token: 0x06022FDB RID: 143323 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022FDB")]
		[Address(RVA = "0x1D83C20", Offset = "0x1D82820", VA = "0x181D83C20")]
		private IEnumerator _AfterConfirmItem(UIPage page)
		{
			return null;
		}

		// Token: 0x06022FDC RID: 143324 RVA: 0x000BFAD8 File Offset: 0x000BDCD8
		[Token(Token = "0x6022FDC")]
		[Address(RVA = "0x1D842A0", Offset = "0x1D82EA0", VA = "0x181D842A0")]
		private bool _SelectItem(int index, int count)
		{
			return default(bool);
		}

		// Token: 0x06022FDD RID: 143325 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022FDD")]
		[Address(RVA = "0x1D841D0", Offset = "0x1D82DD0", VA = "0x181D841D0")]
		private static IEnumerator _ReceiveItems(List<ItemGet> rewardList, [Optional] Action onConfirm)
		{
			return null;
		}

		// Token: 0x06022FDE RID: 143326 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FDE")]
		[Address(RVA = "0x1D84430", Offset = "0x1D83030", VA = "0x181D84430")]
		public ItemRepoIssueVoucherState()
		{
		}

		// Token: 0x06022FE2 RID: 143330 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022FE2")]
		[Address(RVA = "0x15A4170", Offset = "0x15A2D70", VA = "0x1815A4170")]
		private IEnumerator <>xLuaBaseProxy_HideCoroutine(UIPopupState.TransactionContext P0)
		{
			return null;
		}

		// Token: 0x06022FE3 RID: 143331 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FE3")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06022FE4 RID: 143332 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022FE4")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04030337 RID: 197431
		[Token(Token = "0x4030337")]
		public const int MESSAGE_CHOOSE_CONFIRM = 0;

		// Token: 0x04030338 RID: 197432
		[Token(Token = "0x4030338")]
		public const int MESSAGE_OUTPUT_CANCEL = 1;

		// Token: 0x04030339 RID: 197433
		[Token(Token = "0x4030339")]
		public const int MESSAGE_OUTPUT_CONFIRM = 2;

		// Token: 0x0403033A RID: 197434
		[Token(Token = "0x403033A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ItemRepoIssueVoucherView _view;

		// Token: 0x0403033B RID: 197435
		[Token(Token = "0x403033B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _backPart;

		// Token: 0x0403033C RID: 197436
		[Token(Token = "0x403033C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ItemRepoIssueVoucherStateBean m_stateBean;

		// Token: 0x0403033D RID: 197437
		[Token(Token = "0x403033D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403033E RID: 197438
		[Token(Token = "0x403033E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0403033F RID: 197439
		[Token(Token = "0x403033F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04030340 RID: 197440
		[Token(Token = "0x4030340")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04030341 RID: 197441
		[Token(Token = "0x4030341")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04030342 RID: 197442
		[Token(Token = "0x4030342")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_BackToChoosePartOrDismissSelf;

		// Token: 0x04030343 RID: 197443
		[Token(Token = "0x4030343")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__ChooseConfirm;

		// Token: 0x04030344 RID: 197444
		[Token(Token = "0x4030344")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OutputCancel;

		// Token: 0x04030345 RID: 197445
		[Token(Token = "0x4030345")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OutputConfirm;

		// Token: 0x04030346 RID: 197446
		[Token(Token = "0x4030346")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__AfterConfirmItem;

		// Token: 0x04030347 RID: 197447
		[Token(Token = "0x4030347")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__SelectItem;

		// Token: 0x04030348 RID: 197448
		[Token(Token = "0x4030348")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__ReceiveItems;

		// Token: 0x04030349 RID: 197449
		[Token(Token = "0x4030349")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
