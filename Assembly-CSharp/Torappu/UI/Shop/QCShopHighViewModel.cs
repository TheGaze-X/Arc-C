using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B0A RID: 23306
	[Token(Token = "0x2005B0A")]
	public class QCShopHighViewModel : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021DC0 RID: 138688 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DC0")]
		[Address(RVA = "0x1C58840", Offset = "0x1C57440", VA = "0x181C58840")]
		public void ApplyData(GetHighGoodListResponse response)
		{
		}

		// Token: 0x06021DC1 RID: 138689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DC1")]
		[Address(RVA = "0x1C590A0", Offset = "0x1C57CA0", VA = "0x181C590A0")]
		private void CollectItemBase(ItemBundle item)
		{
		}

		// Token: 0x06021DC2 RID: 138690 RVA: 0x000BB728 File Offset: 0x000B9928
		[Token(Token = "0x6021DC2")]
		[Address(RVA = "0x1C58E90", Offset = "0x1C57A90", VA = "0x181C58E90")]
		public bool CheckShopChanged()
		{
			return default(bool);
		}

		// Token: 0x06021DC3 RID: 138691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DC3")]
		[Address(RVA = "0x1C591E0", Offset = "0x1C57DE0", VA = "0x181C591E0")]
		public QCShopHighViewModel()
		{
		}

		// Token: 0x0402E619 RID: 189977
		[Token(Token = "0x402E619")]
		[FieldOffset(Offset = "0x18")]
		[NonSerialized]
		public List<QCCommonObj> commonObjList;

		// Token: 0x0402E61A RID: 189978
		[Token(Token = "0x402E61A")]
		[FieldOffset(Offset = "0x20")]
		[NonSerialized]
		public Dictionary<string, PlayerGacha.PlayerFesClassicGacha> fesGachaCurrent;

		// Token: 0x0402E61B RID: 189979
		[Token(Token = "0x402E61B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_ApplyData;

		// Token: 0x0402E61C RID: 189980
		[Token(Token = "0x402E61C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CollectItemBase;

		// Token: 0x0402E61D RID: 189981
		[Token(Token = "0x402E61D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CheckShopChanged;

		// Token: 0x0402E61E RID: 189982
		[Token(Token = "0x402E61E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
