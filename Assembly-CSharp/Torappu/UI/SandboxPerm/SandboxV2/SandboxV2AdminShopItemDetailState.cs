using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004100 RID: 16640
	[Token(Token = "0x2004100")]
	public class SandboxV2AdminShopItemDetailState : PopupFloatState, IValueMsgReceiver, IHotfixable
	{
		// Token: 0x06019BBC RID: 105404 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BBC")]
		[Address(RVA = "0x1291600", Offset = "0x1290200", VA = "0x181291600", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06019BBD RID: 105405 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6019BBD")]
		[Address(RVA = "0x12915A0", Offset = "0x12901A0", VA = "0x1812915A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06019BBE RID: 105406 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BBE")]
		[Address(RVA = "0x12917D0", Offset = "0x12903D0", VA = "0x1812917D0", Slot = "32")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06019BBF RID: 105407 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BBF")]
		[Address(RVA = "0x12914E0", Offset = "0x12900E0", VA = "0x1812914E0")]
		public void EventOnBackClicked()
		{
		}

		// Token: 0x06019BC0 RID: 105408 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BC0")]
		[Address(RVA = "0x1291A90", Offset = "0x1290690", VA = "0x181291A90")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06019BC1 RID: 105409 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BC1")]
		[Address(RVA = "0x12922C0", Offset = "0x1290EC0", VA = "0x1812922C0")]
		private void _OnIncreaseBtnClicked()
		{
		}

		// Token: 0x06019BC2 RID: 105410 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BC2")]
		[Address(RVA = "0x12920E0", Offset = "0x1290CE0", VA = "0x1812920E0")]
		private void _OnDecreaseBtnClicked()
		{
		}

		// Token: 0x06019BC3 RID: 105411 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BC3")]
		[Address(RVA = "0x1291B60", Offset = "0x1290760", VA = "0x181291B60")]
		private void _OnBuyItem()
		{
		}

		// Token: 0x06019BC4 RID: 105412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BC4")]
		[Address(RVA = "0x1291DF0", Offset = "0x12909F0", VA = "0x181291DF0")]
		private void _OnBuyRequestProceed(SandboxV2ShopBuyResponse response)
		{
		}

		// Token: 0x06019BC5 RID: 105413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BC5")]
		[Address(RVA = "0x1292200", Offset = "0x1290E00", VA = "0x181292200")]
		private void _OnGainItemDialogClicked()
		{
		}

		// Token: 0x06019BC6 RID: 105414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BC6")]
		[Address(RVA = "0x12923F0", Offset = "0x1290FF0", VA = "0x1812923F0")]
		public SandboxV2AdminShopItemDetailState()
		{
		}

		// Token: 0x06019BC7 RID: 105415 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019BC7")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0402038F RID: 131983
		[Token(Token = "0x402038F")]
		[NonSerialized]
		public const int ON_INCREASE_BUY_COUNT = 1;

		// Token: 0x04020390 RID: 131984
		[Token(Token = "0x4020390")]
		[NonSerialized]
		public const int ON_DECREASE_BUY_COUNT = 2;

		// Token: 0x04020391 RID: 131985
		[Token(Token = "0x4020391")]
		[NonSerialized]
		public const int ON_BUY_ITEM = 3;

		// Token: 0x04020392 RID: 131986
		[Token(Token = "0x4020392")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2AdminShopItemDetailView _itemView;

		// Token: 0x04020393 RID: 131987
		[Token(Token = "0x4020393")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private SandboxV2AdminShopItemDetailTopBarView _topBarView;

		// Token: 0x04020394 RID: 131988
		[Token(Token = "0x4020394")]
		[FieldOffset(Offset = "0x80")]
		private SandboxV2AdminShopItemDetailStateBean m_stateBean;

		// Token: 0x04020395 RID: 131989
		[Token(Token = "0x4020395")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x04020396 RID: 131990
		[Token(Token = "0x4020396")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04020397 RID: 131991
		[Token(Token = "0x4020397")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04020398 RID: 131992
		[Token(Token = "0x4020398")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x04020399 RID: 131993
		[Token(Token = "0x4020399")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_EventOnBackClicked;

		// Token: 0x0402039A RID: 131994
		[Token(Token = "0x402039A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0402039B RID: 131995
		[Token(Token = "0x402039B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnIncreaseBtnClicked;

		// Token: 0x0402039C RID: 131996
		[Token(Token = "0x402039C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnDecreaseBtnClicked;

		// Token: 0x0402039D RID: 131997
		[Token(Token = "0x402039D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__OnBuyItem;

		// Token: 0x0402039E RID: 131998
		[Token(Token = "0x402039E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OnBuyRequestProceed;

		// Token: 0x0402039F RID: 131999
		[Token(Token = "0x402039F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnGainItemDialogClicked;

		// Token: 0x040203A0 RID: 132000
		[Token(Token = "0x40203A0")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
