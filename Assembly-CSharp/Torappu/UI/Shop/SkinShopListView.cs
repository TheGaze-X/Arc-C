using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B60 RID: 23392
	[Token(Token = "0x2005B60")]
	public class SkinShopListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021F42 RID: 139074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F42")]
		[Address(RVA = "0x1C7C140", Offset = "0x1C7AD40", VA = "0x181C7C140")]
		public void Render(List<ISkinShopItemViewModel> shopItemList)
		{
		}

		// Token: 0x06021F43 RID: 139075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F43")]
		[Address(RVA = "0x1C7C3D0", Offset = "0x1C7AFD0", VA = "0x181C7C3D0")]
		private void _OnScrollRectValueChanged(Vector2 pos)
		{
		}

		// Token: 0x06021F44 RID: 139076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F44")]
		[Address(RVA = "0x1C7BF20", Offset = "0x1C7AB20", VA = "0x181C7BF20")]
		protected void OnEnable()
		{
		}

		// Token: 0x06021F45 RID: 139077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F45")]
		[Address(RVA = "0x1C7BE00", Offset = "0x1C7AA00", VA = "0x181C7BE00")]
		protected void OnDisable()
		{
		}

		// Token: 0x06021F46 RID: 139078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021F46")]
		[Address(RVA = "0x1C7C4E0", Offset = "0x1C7B0E0", VA = "0x181C7C4E0")]
		public SkinShopListView()
		{
		}

		// Token: 0x0402E839 RID: 190521
		[Token(Token = "0x402E839")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SkinShopListAdapter _adapter;

		// Token: 0x0402E83A RID: 190522
		[Token(Token = "0x402E83A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private LoopScrollRect _scrollRect;

		// Token: 0x0402E83B RID: 190523
		[Token(Token = "0x402E83B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E83C RID: 190524
		[Token(Token = "0x402E83C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__OnScrollRectValueChanged;

		// Token: 0x0402E83D RID: 190525
		[Token(Token = "0x402E83D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnEnable;

		// Token: 0x0402E83E RID: 190526
		[Token(Token = "0x402E83E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDisable;

		// Token: 0x0402E83F RID: 190527
		[Token(Token = "0x402E83F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
