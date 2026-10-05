using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AC2 RID: 23234
	[Token(Token = "0x2005AC2")]
	public class ShopFurnitureStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x06021C67 RID: 138343 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C67")]
		[Address(RVA = "0x1C41170", Offset = "0x1C3FD70", VA = "0x181C41170")]
		public ShopFurnitureStateBean()
		{
		}

		// Token: 0x0402E399 RID: 189337
		[Token(Token = "0x402E399")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<FurnViewModel> furnViewModelList;

		// Token: 0x0402E39A RID: 189338
		[Token(Token = "0x402E39A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
