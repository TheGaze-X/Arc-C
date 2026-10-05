using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005E62 RID: 24162
	[Token(Token = "0x2005E62")]
	public class ItemRepoUseVoucherItemState : PopupFloatState
	{
		// Token: 0x06023029 RID: 143401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023029")]
		[Address(RVA = "0x1D87680", Offset = "0x1D86280", VA = "0x181D87680", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0602302A RID: 143402 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602302A")]
		[Address(RVA = "0x1D879A0", Offset = "0x1D865A0", VA = "0x181D879A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0602302B RID: 143403 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602302B")]
		[Address(RVA = "0x1D876E0", Offset = "0x1D862E0", VA = "0x181D876E0")]
		public void InitRender()
		{
		}

		// Token: 0x0602302C RID: 143404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602302C")]
		[Address(RVA = "0x1D87450", Offset = "0x1D86050", VA = "0x181D87450")]
		public void CheckAndRender(int count)
		{
		}

		// Token: 0x0602302D RID: 143405 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602302D")]
		[Address(RVA = "0x1D87940", Offset = "0x1D86540", VA = "0x181D87940")]
		public void MinusCount()
		{
		}

		// Token: 0x0602302E RID: 143406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602302E")]
		[Address(RVA = "0x1D873F0", Offset = "0x1D85FF0", VA = "0x181D873F0")]
		public void AddCount()
		{
		}

		// Token: 0x0602302F RID: 143407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602302F")]
		[Address(RVA = "0x1D87DB0", Offset = "0x1D869B0", VA = "0x181D87DB0")]
		public void ToMaxCount()
		{
		}

		// Token: 0x06023030 RID: 143408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023030")]
		[Address(RVA = "0x1D87E30", Offset = "0x1D86A30", VA = "0x181D87E30")]
		public void ToMinCount()
		{
		}

		// Token: 0x06023031 RID: 143409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023031")]
		[Address(RVA = "0x1D87B10", Offset = "0x1D86710", VA = "0x181D87B10")]
		public void SendItemVoucherRequest()
		{
		}

		// Token: 0x06023032 RID: 143410 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6023032")]
		[Address(RVA = "0x1D88050", Offset = "0x1D86C50", VA = "0x181D88050")]
		private static IEnumerator _ReceiveItems(List<ItemGet> rewardList, UIGainItemFloatPanel.Style style = UIGainItemFloatPanel.Style.DEFAULT, [Optional] Action onConfirm)
		{
			return null;
		}

		// Token: 0x06023033 RID: 143411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023033")]
		[Address(RVA = "0x1D88140", Offset = "0x1D86D40", VA = "0x181D88140")]
		public ItemRepoUseVoucherItemState()
		{
		}

		// Token: 0x06023036 RID: 143414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6023036")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0403038A RID: 197514
		[Token(Token = "0x403038A")]
		public const int USE_MAX_COUNT = 99;

		// Token: 0x0403038B RID: 197515
		[Token(Token = "0x403038B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ItemRepoUseVoucherItemStateBean _stateBean;

		// Token: 0x0403038C RID: 197516
		[Token(Token = "0x403038C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x78")]
		private int m_currentBuyCount;

		// Token: 0x0403038D RID: 197517
		[Token(Token = "0x403038D")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x80")]
		[SerializeField]
		private Text _countText;

		// Token: 0x0403038E RID: 197518
		[Token(Token = "0x403038E")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x88")]
		[SerializeField]
		private Text _detailText;

		// Token: 0x0403038F RID: 197519
		[Token(Token = "0x403038F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x90")]
		[SerializeField]
		private Image _itemImage;

		// Token: 0x04030390 RID: 197520
		[Token(Token = "0x4030390")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x98")]
		[SerializeField]
		private Image _backImage;

		// Token: 0x04030391 RID: 197521
		[Token(Token = "0x4030391")]
		[Il2CppDummyDll.FieldOffset(Offset = "0xA0")]
		[SerializeField]
		private Text _currentCount;

		// Token: 0x04030392 RID: 197522
		[Token(Token = "0x4030392")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04030393 RID: 197523
		[Token(Token = "0x4030393")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04030394 RID: 197524
		[Token(Token = "0x4030394")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_InitRender;

		// Token: 0x04030395 RID: 197525
		[Token(Token = "0x4030395")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckAndRender;

		// Token: 0x04030396 RID: 197526
		[Token(Token = "0x4030396")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_MinusCount;

		// Token: 0x04030397 RID: 197527
		[Token(Token = "0x4030397")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AddCount;

		// Token: 0x04030398 RID: 197528
		[Token(Token = "0x4030398")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ToMaxCount;

		// Token: 0x04030399 RID: 197529
		[Token(Token = "0x4030399")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ToMinCount;

		// Token: 0x0403039A RID: 197530
		[Token(Token = "0x403039A")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_SendItemVoucherRequest;

		// Token: 0x0403039B RID: 197531
		[Token(Token = "0x403039B")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__ReceiveItems;

		// Token: 0x0403039C RID: 197532
		[Token(Token = "0x403039C")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
