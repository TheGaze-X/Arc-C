using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AF7 RID: 23287
	[Token(Token = "0x2005AF7")]
	public class QCShopClassicViewModel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021D7D RID: 138621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D7D")]
		[Address(RVA = "0x1C46260", Offset = "0x1C44E60", VA = "0x181C46260")]
		public void ApplyData(GetClassicGoodListResponse response)
		{
		}

		// Token: 0x06021D7E RID: 138622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D7E")]
		[Address(RVA = "0x1C46AE0", Offset = "0x1C456E0", VA = "0x181C46AE0")]
		private void CollectItemBase(ItemBundle item)
		{
		}

		// Token: 0x06021D7F RID: 138623 RVA: 0x000BB638 File Offset: 0x000B9838
		[Token(Token = "0x6021D7F")]
		[Address(RVA = "0x1C468D0", Offset = "0x1C454D0", VA = "0x181C468D0")]
		public bool CheckShopChanged()
		{
			return default(bool);
		}

		// Token: 0x06021D80 RID: 138624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021D80")]
		[Address(RVA = "0x1C46C20", Offset = "0x1C45820", VA = "0x181C46C20")]
		public QCShopClassicViewModel()
		{
		}

		// Token: 0x0402E58A RID: 189834
		[Token(Token = "0x402E58A")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<QCCommonObj> commonObjList;

		// Token: 0x0402E58B RID: 189835
		[Token(Token = "0x402E58B")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public Dictionary<string, PlayerGacha.PlayerFesClassicGacha> fesGachaCurrent;

		// Token: 0x0402E58C RID: 189836
		[Token(Token = "0x402E58C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E58D RID: 189837
		[Token(Token = "0x402E58D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CollectItemBase;

		// Token: 0x0402E58E RID: 189838
		[Token(Token = "0x402E58E")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckShopChanged;

		// Token: 0x0402E58F RID: 189839
		[Token(Token = "0x402E58F")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
