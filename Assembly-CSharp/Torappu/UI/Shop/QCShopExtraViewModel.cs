using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B04 RID: 23300
	[Token(Token = "0x2005B04")]
	public class QCShopExtraViewModel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021DAF RID: 138671 RVA: 0x000BB6F8 File Offset: 0x000B98F8
		[Token(Token = "0x6021DAF")]
		[Address(RVA = "0x1C4AA10", Offset = "0x1C49610", VA = "0x181C4AA10")]
		public bool CheckAndCalcIfNewFlagChanged(long lastClick)
		{
			return default(bool);
		}

		// Token: 0x06021DB0 RID: 138672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DB0")]
		[Address(RVA = "0x1C4A650", Offset = "0x1C49250", VA = "0x181C4A650")]
		public void ApplyData(GetExtraGoodListResponse response)
		{
		}

		// Token: 0x06021DB1 RID: 138673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DB1")]
		[Address(RVA = "0x1C4AC00", Offset = "0x1C49800", VA = "0x181C4AC00")]
		public QCShopExtraViewModel()
		{
		}

		// Token: 0x0402E5FC RID: 189948
		[Token(Token = "0x402E5FC")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<QCShopExtraObj> commonObjList;

		// Token: 0x0402E5FD RID: 189949
		[Token(Token = "0x402E5FD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_CheckAndCalcIfNewFlagChanged;

		// Token: 0x0402E5FE RID: 189950
		[Token(Token = "0x402E5FE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E5FF RID: 189951
		[Token(Token = "0x402E5FF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
