using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A74 RID: 23156
	[Token(Token = "0x2005A74")]
	public class CashShopListView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021B09 RID: 137993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B09")]
		[Address(RVA = "0x1C17580", Offset = "0x1C16180", VA = "0x181C17580")]
		public void ApplyData(List<CashItemViewModel> itemList)
		{
		}

		// Token: 0x06021B0A RID: 137994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B0A")]
		[Address(RVA = "0x1C17740", Offset = "0x1C16340", VA = "0x181C17740")]
		public CashShopListView()
		{
		}

		// Token: 0x0402E11B RID: 188699
		[Token(Token = "0x402E11B")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CashShopItemObject _obj;

		// Token: 0x0402E11C RID: 188700
		[Token(Token = "0x402E11C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0402E11D RID: 188701
		[Token(Token = "0x402E11D")]
		[FieldOffset(Offset = "0x28")]
		private List<CashShopItemObject> m_objList;

		// Token: 0x0402E11E RID: 188702
		[Token(Token = "0x402E11E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E11F RID: 188703
		[Token(Token = "0x402E11F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
