using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005A93 RID: 23187
	[Token(Token = "0x2005A93")]
	public class ShopFurnDetailGroupText : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021B7A RID: 138106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B7A")]
		[Address(RVA = "0x1C244C0", Offset = "0x1C230C0", VA = "0x181C244C0")]
		public void SetText(string text)
		{
		}

		// Token: 0x06021B7B RID: 138107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021B7B")]
		[Address(RVA = "0x1C24560", Offset = "0x1C23160", VA = "0x181C24560")]
		public ShopFurnDetailGroupText()
		{
		}

		// Token: 0x0402E1ED RID: 188909
		[Token(Token = "0x402E1ED")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _furnDetailText;

		// Token: 0x0402E1EE RID: 188910
		[Token(Token = "0x402E1EE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_SetText;

		// Token: 0x0402E1EF RID: 188911
		[Token(Token = "0x402E1EF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
