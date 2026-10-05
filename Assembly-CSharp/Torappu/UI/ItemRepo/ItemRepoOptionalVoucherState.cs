using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E5D RID: 24157
	[Token(Token = "0x2005E5D")]
	public class ItemRepoOptionalVoucherState : PopupFloatState
	{
		// Token: 0x06023001 RID: 143361 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023001")]
		[Address(RVA = "0x1D850D0", Offset = "0x1D83CD0", VA = "0x181D850D0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06023002 RID: 143362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023002")]
		[Address(RVA = "0x1D85280", Offset = "0x1D83E80", VA = "0x181D85280", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06023003 RID: 143363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023003")]
		[Address(RVA = "0x1D85830", Offset = "0x1D84430", VA = "0x181D85830", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x06023004 RID: 143364 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023004")]
		[Address(RVA = "0x1D858B0", Offset = "0x1D844B0", VA = "0x181D858B0", Slot = "10")]
		public override Dictionary<Type, Action<IStateBean>> RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x06023005 RID: 143365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023005")]
		[Address(RVA = "0x1D869B0", Offset = "0x1D855B0", VA = "0x181D869B0")]
		private void _ToDetailState(IStateBean stateBean)
		{
		}

		// Token: 0x06023006 RID: 143366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023006")]
		[Address(RVA = "0x1D84E10", Offset = "0x1D83A10", VA = "0x181D84E10")]
		public void AddPickItem(string itemId)
		{
		}

		// Token: 0x06023007 RID: 143367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023007")]
		[Address(RVA = "0x1D85130", Offset = "0x1D83D30", VA = "0x181D85130")]
		public void MinusPickItem(string itemId)
		{
		}

		// Token: 0x06023008 RID: 143368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023008")]
		[Address(RVA = "0x1D85A10", Offset = "0x1D84610", VA = "0x181D85A10")]
		public void ShowItemDetail(string itemId)
		{
		}

		// Token: 0x06023009 RID: 143369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023009")]
		[Address(RVA = "0x1D86200", Offset = "0x1D84E00", VA = "0x181D86200")]
		private void _InitView()
		{
		}

		// Token: 0x0602300A RID: 143370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602300A")]
		[Address(RVA = "0x1D86190", Offset = "0x1D84D90", VA = "0x181D86190")]
		private void _ChooseConfirm()
		{
		}

		// Token: 0x0602300B RID: 143371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602300B")]
		[Address(RVA = "0x1D863C0", Offset = "0x1D84FC0", VA = "0x181D863C0")]
		private void _OutputCancel()
		{
		}

		// Token: 0x0602300C RID: 143372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602300C")]
		[Address(RVA = "0x1D86430", Offset = "0x1D85030", VA = "0x181D86430")]
		private void _OutputConfirm()
		{
		}

		// Token: 0x0602300D RID: 143373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602300D")]
		[Address(RVA = "0x1D860C0", Offset = "0x1D84CC0", VA = "0x181D860C0")]
		private IEnumerator _AfterConfirmItem(UIPage page)
		{
			return null;
		}

		// Token: 0x0602300E RID: 143374 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602300E")]
		[Address(RVA = "0x1D868E0", Offset = "0x1D854E0", VA = "0x181D868E0")]
		private static IEnumerator _ReceiveItems(List<ItemGet> rewardList, [Optional] Action onConfirm)
		{
			return null;
		}

		// Token: 0x0602300F RID: 143375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602300F")]
		[Address(RVA = "0x1D84EA0", Offset = "0x1D83AA0", VA = "0x181D84EA0")]
		public void BackToChoosePartOrDismissSelf()
		{
		}

		// Token: 0x06023010 RID: 143376 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023010")]
		[Address(RVA = "0x1D86C30", Offset = "0x1D85830", VA = "0x181D86C30")]
		public ItemRepoOptionalVoucherState()
		{
		}

		// Token: 0x06023013 RID: 143379 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023013")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06023014 RID: 143380 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023014")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x06023015 RID: 143381 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023015")]
		[Address(RVA = "0xE63480", Offset = "0xE62080", VA = "0x180E63480")]
		private Dictionary<Type, Action<IStateBean>> <>xLuaBaseProxy_RegisterToDataListener()
		{
			return null;
		}

		// Token: 0x04030366 RID: 197478
		[Token(Token = "0x4030366")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ItemRepoOptionalVoucherView _view;

		// Token: 0x04030367 RID: 197479
		[Token(Token = "0x4030367")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		[SerializeField]
		private GameObject _backImg;

		// Token: 0x04030368 RID: 197480
		[Token(Token = "0x4030368")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		private ItemRepoOptionalVoucherStateBean m_stateBean;

		// Token: 0x04030369 RID: 197481
		[Token(Token = "0x4030369")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x0403036A RID: 197482
		[Token(Token = "0x403036A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0403036B RID: 197483
		[Token(Token = "0x403036B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0403036C RID: 197484
		[Token(Token = "0x403036C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0403036D RID: 197485
		[Token(Token = "0x403036D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_RegisterToDataListener;

		// Token: 0x0403036E RID: 197486
		[Token(Token = "0x403036E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__ToDetailState;

		// Token: 0x0403036F RID: 197487
		[Token(Token = "0x403036F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AddPickItem;

		// Token: 0x04030370 RID: 197488
		[Token(Token = "0x4030370")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_MinusPickItem;

		// Token: 0x04030371 RID: 197489
		[Token(Token = "0x4030371")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ShowItemDetail;

		// Token: 0x04030372 RID: 197490
		[Token(Token = "0x4030372")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__InitView;

		// Token: 0x04030373 RID: 197491
		[Token(Token = "0x4030373")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ChooseConfirm;

		// Token: 0x04030374 RID: 197492
		[Token(Token = "0x4030374")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__OutputCancel;

		// Token: 0x04030375 RID: 197493
		[Token(Token = "0x4030375")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__OutputConfirm;

		// Token: 0x04030376 RID: 197494
		[Token(Token = "0x4030376")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__AfterConfirmItem;

		// Token: 0x04030377 RID: 197495
		[Token(Token = "0x4030377")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ReceiveItems;

		// Token: 0x04030378 RID: 197496
		[Token(Token = "0x4030378")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_BackToChoosePartOrDismissSelf;

		// Token: 0x04030379 RID: 197497
		[Token(Token = "0x4030379")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
