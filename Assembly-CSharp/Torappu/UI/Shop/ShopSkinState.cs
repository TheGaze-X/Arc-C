using System;
using System.Collections;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B90 RID: 23440
	[Token(Token = "0x2005B90")]
	public class ShopSkinState : ShopCommonState, IValueMsgReceiver
	{
		// Token: 0x06022045 RID: 139333 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022045")]
		[Address(RVA = "0x1C75320", Offset = "0x1C73F20", VA = "0x181C75320", Slot = "29")]
		public void OnMessage(int key, ValueBundle msg)
		{
		}

		// Token: 0x06022046 RID: 139334 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022046")]
		[Address(RVA = "0x1C750E0", Offset = "0x1C73CE0", VA = "0x181C750E0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x06022047 RID: 139335 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022047")]
		[Address(RVA = "0x1C751C0", Offset = "0x1C73DC0", VA = "0x181C751C0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x06022048 RID: 139336 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022048")]
		[Address(RVA = "0x1C75530", Offset = "0x1C74130", VA = "0x181C75530", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x06022049 RID: 139337 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022049")]
		[Address(RVA = "0x1C75140", Offset = "0x1C73D40", VA = "0x181C75140")]
		public void OnClick(string skinId)
		{
		}

		// Token: 0x0602204A RID: 139338 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602204A")]
		[Address(RVA = "0x1C75AB0", Offset = "0x1C746B0", VA = "0x181C75AB0")]
		private void _UpdateShopSkinState()
		{
		}

		// Token: 0x0602204B RID: 139339 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602204B")]
		[Address(RVA = "0x1C74DA0", Offset = "0x1C739A0", VA = "0x181C74DA0")]
		public void ApplyData(GetSkinGoodListResponse response)
		{
		}

		// Token: 0x0602204C RID: 139340 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602204C")]
		[Address(RVA = "0x1C759E0", Offset = "0x1C745E0", VA = "0x181C759E0")]
		private IEnumerator _ShowSkinDetailCoroutine(string goodId)
		{
			return null;
		}

		// Token: 0x0602204D RID: 139341 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602204D")]
		[Address(RVA = "0x1C75910", Offset = "0x1C74510", VA = "0x181C75910")]
		private void _OpenSkinDetailPage(string skinId)
		{
		}

		// Token: 0x0602204E RID: 139342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602204E")]
		[Address(RVA = "0x1C75800", Offset = "0x1C74400", VA = "0x181C75800")]
		private void _OpenBlindboxDetailPage(string blindboxGoodId)
		{
		}

		// Token: 0x0602204F RID: 139343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602204F")]
		[Address(RVA = "0x1C75BD0", Offset = "0x1C747D0", VA = "0x181C75BD0")]
		public ShopSkinState()
		{
		}

		// Token: 0x06022051 RID: 139345 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022051")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x06022052 RID: 139346 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022052")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x0402EA16 RID: 190998
		[Token(Token = "0x402EA16")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private SkinShopStateBean _stateBean;

		// Token: 0x0402EA17 RID: 190999
		[Token(Token = "0x402EA17")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SkinShopListView _skinShopView;

		// Token: 0x0402EA18 RID: 191000
		[Token(Token = "0x402EA18")]
		[NonSerialized]
		public const int OPEN_SKIN_DETAIL_EVENT = 0;

		// Token: 0x0402EA19 RID: 191001
		[Token(Token = "0x402EA19")]
		[NonSerialized]
		public const int OPEN_BLINDBOX_DETAIL_EVENT = 1;

		// Token: 0x0402EA1A RID: 191002
		[Token(Token = "0x402EA1A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnMessage;

		// Token: 0x0402EA1B RID: 191003
		[Token(Token = "0x402EA1B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x0402EA1C RID: 191004
		[Token(Token = "0x402EA1C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0402EA1D RID: 191005
		[Token(Token = "0x402EA1D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x0402EA1E RID: 191006
		[Token(Token = "0x402EA1E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x0402EA1F RID: 191007
		[Token(Token = "0x402EA1F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__UpdateShopSkinState;

		// Token: 0x0402EA20 RID: 191008
		[Token(Token = "0x402EA20")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402EA21 RID: 191009
		[Token(Token = "0x402EA21")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__ShowSkinDetailCoroutine;

		// Token: 0x0402EA22 RID: 191010
		[Token(Token = "0x402EA22")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__OpenSkinDetailPage;

		// Token: 0x0402EA23 RID: 191011
		[Token(Token = "0x402EA23")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OpenBlindboxDetailPage;

		// Token: 0x0402EA24 RID: 191012
		[Token(Token = "0x402EA24")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
