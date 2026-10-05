using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.ItemRepo
{
	// Token: 0x02005EB5 RID: 24245
	[Token(Token = "0x2005EB5")]
	public class ItemRepoUseApSupplyItem : MonoBehaviour, IHotfixable
	{
		// Token: 0x060231B8 RID: 143800 RVA: 0x000BFF40 File Offset: 0x000BE140
		[Token(Token = "0x60231B8")]
		[Address(RVA = "0x1DA1170", Offset = "0x1D9FD70", VA = "0x181DA1170")]
		public int GetMaxCount()
		{
			return 0;
		}

		// Token: 0x060231B9 RID: 143801 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231B9")]
		[Address(RVA = "0x1DA13D0", Offset = "0x1D9FFD0", VA = "0x181DA13D0")]
		public void RenderAp(UIItemViewModel itemViewModel)
		{
		}

		// Token: 0x060231BA RID: 143802 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231BA")]
		[Address(RVA = "0x1DA18A0", Offset = "0x1DA04A0", VA = "0x181DA18A0")]
		public void RenderCurrentBuyCount(int buyCount)
		{
		}

		// Token: 0x060231BB RID: 143803 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231BB")]
		[Address(RVA = "0x1DA10D0", Offset = "0x1D9FCD0", VA = "0x181DA10D0")]
		public void CheckAndRender(int newCount)
		{
		}

		// Token: 0x060231BC RID: 143804 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231BC")]
		[Address(RVA = "0x1DA12F0", Offset = "0x1D9FEF0", VA = "0x181DA12F0")]
		public void MinusCount()
		{
		}

		// Token: 0x060231BD RID: 143805 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231BD")]
		[Address(RVA = "0x1DA1060", Offset = "0x1D9FC60", VA = "0x181DA1060")]
		public void AddCount()
		{
		}

		// Token: 0x060231BE RID: 143806 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231BE")]
		[Address(RVA = "0x1DA20C0", Offset = "0x1DA0CC0", VA = "0x181DA20C0")]
		public void ToMaxCount()
		{
		}

		// Token: 0x060231BF RID: 143807 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231BF")]
		[Address(RVA = "0x1DA2130", Offset = "0x1DA0D30", VA = "0x181DA2130")]
		public void ToMinCount()
		{
		}

		// Token: 0x060231C0 RID: 143808 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231C0")]
		[Address(RVA = "0x1DA1360", Offset = "0x1D9FF60", VA = "0x181DA1360")]
		public void OnSendService()
		{
		}

		// Token: 0x060231C1 RID: 143809 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231C1")]
		[Address(RVA = "0x1DA1C30", Offset = "0x1DA0830", VA = "0x181DA1C30")]
		public void SendUseApItemService(UIItemViewModel itemViewModel, int count)
		{
		}

		// Token: 0x060231C2 RID: 143810 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60231C2")]
		[Address(RVA = "0x1DA21F0", Offset = "0x1DA0DF0", VA = "0x181DA21F0")]
		public ItemRepoUseApSupplyItem()
		{
		}

		// Token: 0x0403063F RID: 198207
		[Token(Token = "0x403063F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ItemRepoActionPointViewModelWithBuyApCount _buyApCount;

		// Token: 0x04030640 RID: 198208
		[Token(Token = "0x4030640")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _buyCount;

		// Token: 0x04030641 RID: 198209
		[Token(Token = "0x4030641")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _buyDetail;

		// Token: 0x04030642 RID: 198210
		[Token(Token = "0x4030642")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _cannotUseMore;

		// Token: 0x04030643 RID: 198211
		[Token(Token = "0x4030643")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UnityEvent _dismissAction;

		// Token: 0x04030644 RID: 198212
		[Token(Token = "0x4030644")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _canUsePart;

		// Token: 0x04030645 RID: 198213
		[Token(Token = "0x4030645")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _cannotUsePart;

		// Token: 0x04030646 RID: 198214
		[Token(Token = "0x4030646")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private AddApNotifyView _notifyView;

		// Token: 0x04030647 RID: 198215
		[Token(Token = "0x4030647")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _title;

		// Token: 0x04030648 RID: 198216
		[Token(Token = "0x4030648")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private Text _itemCount;

		// Token: 0x04030649 RID: 198217
		[Token(Token = "0x4030649")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _onTimePart;

		// Token: 0x0403064A RID: 198218
		[Token(Token = "0x403064A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private Text _onTimeText;

		// Token: 0x0403064B RID: 198219
		[Token(Token = "0x403064B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private CanvasGroup _buyCanvas;

		// Token: 0x0403064C RID: 198220
		[Token(Token = "0x403064C")]
		[FieldOffset(Offset = "0x80")]
		private UIItemViewModel m_cacheViewModel;

		// Token: 0x0403064D RID: 198221
		[Token(Token = "0x403064D")]
		[FieldOffset(Offset = "0x88")]
		private int m_currentBuyCount;

		// Token: 0x0403064E RID: 198222
		[Token(Token = "0x403064E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetMaxCount;

		// Token: 0x0403064F RID: 198223
		[Token(Token = "0x403064F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderAp;

		// Token: 0x04030650 RID: 198224
		[Token(Token = "0x4030650")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_RenderCurrentBuyCount;

		// Token: 0x04030651 RID: 198225
		[Token(Token = "0x4030651")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CheckAndRender;

		// Token: 0x04030652 RID: 198226
		[Token(Token = "0x4030652")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_MinusCount;

		// Token: 0x04030653 RID: 198227
		[Token(Token = "0x4030653")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_AddCount;

		// Token: 0x04030654 RID: 198228
		[Token(Token = "0x4030654")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ToMaxCount;

		// Token: 0x04030655 RID: 198229
		[Token(Token = "0x4030655")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_ToMinCount;

		// Token: 0x04030656 RID: 198230
		[Token(Token = "0x4030656")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnSendService;

		// Token: 0x04030657 RID: 198231
		[Token(Token = "0x4030657")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_SendUseApItemService;

		// Token: 0x04030658 RID: 198232
		[Token(Token = "0x4030658")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
