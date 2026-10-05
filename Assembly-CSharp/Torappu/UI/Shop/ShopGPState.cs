using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AD5 RID: 23253
	[Token(Token = "0x2005AD5")]
	public class ShopGPState : ShopCommonState, IValueMsgReceiver
	{
		// Token: 0x06021CDA RID: 138458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6021CDA")]
		[Address(RVA = "0x1C53CE0", Offset = "0x1C528E0", VA = "0x181C53CE0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06021CDB RID: 138459 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CDB")]
		[Address(RVA = "0x1C542B0", Offset = "0x1C52EB0", VA = "0x181C542B0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06021CDC RID: 138460 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CDC")]
		[Address(RVA = "0x1C53D40", Offset = "0x1C52940", VA = "0x181C53D40", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06021CDD RID: 138461 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CDD")]
		[Address(RVA = "0x1C54120", Offset = "0x1C52D20", VA = "0x181C54120", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06021CDE RID: 138462 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CDE")]
		[Address(RVA = "0x1C54440", Offset = "0x1C53040", VA = "0x181C54440")]
		private void _NotifyEnter()
		{
		}

		// Token: 0x06021CDF RID: 138463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CDF")]
		[Address(RVA = "0x1C54DE0", Offset = "0x1C539E0", VA = "0x181C54DE0")]
		private void _UpdateGPState()
		{
		}

		// Token: 0x06021CE0 RID: 138464 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CE0")]
		[Address(RVA = "0x1C54930", Offset = "0x1C53530", VA = "0x181C54930")]
		private void _TryOpenItemDetail()
		{
		}

		// Token: 0x06021CE1 RID: 138465 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CE1")]
		[Address(RVA = "0x1C54540", Offset = "0x1C53140", VA = "0x181C54540")]
		protected void _OnOpenDetail(string goodId)
		{
		}

		// Token: 0x06021CE2 RID: 138466 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CE2")]
		[Address(RVA = "0x1C54C40", Offset = "0x1C53840", VA = "0x181C54C40")]
		protected void _TryOpenMonthCard(ShopGPViewModel viewModel, ShopGPCommonItemViewModel itemViewModel)
		{
		}

		// Token: 0x06021CE3 RID: 138467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CE3")]
		[Address(RVA = "0x1C53BD0", Offset = "0x1C527D0", VA = "0x181C53BD0")]
		public void ApplyData(GetGPGoodListResponse response)
		{
		}

		// Token: 0x06021CE4 RID: 138468 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CE4")]
		[Address(RVA = "0x1C53FB0", Offset = "0x1C52BB0", VA = "0x181C53FB0", Slot = "29")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06021CE5 RID: 138469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CE5")]
		[Address(RVA = "0x1C54860", Offset = "0x1C53460", VA = "0x181C54860")]
		private void _SelectTab(string tabId)
		{
		}

		// Token: 0x06021CE6 RID: 138470 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CE6")]
		[Address(RVA = "0x1C54F00", Offset = "0x1C53B00", VA = "0x181C54F00")]
		public ShopGPState()
		{
		}

		// Token: 0x06021CE8 RID: 138472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CE8")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06021CE9 RID: 138473 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021CE9")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0402E46C RID: 189548
		[Token(Token = "0x402E46C")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private ShopGPStateBean _stateBean;

		// Token: 0x0402E46D RID: 189549
		[Token(Token = "0x402E46D")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private ShopGPRightPanelView _rightPanel;

		// Token: 0x0402E46E RID: 189550
		[Token(Token = "0x402E46E")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ShopGPLeftTabListView _leftTabList;

		// Token: 0x0402E46F RID: 189551
		[Token(Token = "0x402E46F")]
		[FieldOffset(Offset = "0x80")]
		private bool m_isInited;

		// Token: 0x0402E470 RID: 189552
		[Token(Token = "0x402E470")]
		[FieldOffset(Offset = "0x84")]
		private int m_enterSeqNum;

		// Token: 0x0402E471 RID: 189553
		[Token(Token = "0x402E471")]
		public const int SHOP_GP_TAB_CLICK = 0;

		// Token: 0x0402E472 RID: 189554
		[Token(Token = "0x402E472")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402E473 RID: 189555
		[Token(Token = "0x402E473")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402E474 RID: 189556
		[Token(Token = "0x402E474")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402E475 RID: 189557
		[Token(Token = "0x402E475")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402E476 RID: 189558
		[Token(Token = "0x402E476")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__NotifyEnter;

		// Token: 0x0402E477 RID: 189559
		[Token(Token = "0x402E477")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateGPState;

		// Token: 0x0402E478 RID: 189560
		[Token(Token = "0x402E478")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryOpenItemDetail;

		// Token: 0x0402E479 RID: 189561
		[Token(Token = "0x402E479")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnOpenDetail;

		// Token: 0x0402E47A RID: 189562
		[Token(Token = "0x402E47A")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TryOpenMonthCard;

		// Token: 0x0402E47B RID: 189563
		[Token(Token = "0x402E47B")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E47C RID: 189564
		[Token(Token = "0x402E47C")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402E47D RID: 189565
		[Token(Token = "0x402E47D")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__SelectTab;

		// Token: 0x0402E47E RID: 189566
		[Token(Token = "0x402E47E")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
