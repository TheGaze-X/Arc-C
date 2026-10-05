using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A75 RID: 23157
	[Token(Token = "0x2005A75")]
	public class CashStateBean : MonoBehaviour, IStateBean, IHotfixable
	{
		// Token: 0x06021B0B RID: 137995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B0B")]
		[Address(RVA = "0x1C177A0", Offset = "0x1C163A0", VA = "0x181C177A0")]
		public void ApplyResponse(List<CashShopObject> objList)
		{
		}

		// Token: 0x06021B0C RID: 137996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B0C")]
		[Address(RVA = "0x1C179A0", Offset = "0x1C165A0", VA = "0x181C179A0")]
		public CashStateBean()
		{
		}

		// Token: 0x0402E120 RID: 188704
		[Token(Token = "0x402E120")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<CashItemViewModel> viewModelList;

		// Token: 0x0402E121 RID: 188705
		[Token(Token = "0x402E121")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyResponse;

		// Token: 0x0402E122 RID: 188706
		[Token(Token = "0x402E122")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
