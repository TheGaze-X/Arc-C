using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B92 RID: 23442
	[Token(Token = "0x2005B92")]
	public class UIShopCashIconText : MonoBehaviour, IHotfixable
	{
		// Token: 0x06022059 RID: 139353 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022059")]
		[Address(RVA = "0x1C84BB0", Offset = "0x1C837B0", VA = "0x181C84BB0")]
		public void Init(Image image)
		{
		}

		// Token: 0x0602205A RID: 139354 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602205A")]
		[Address(RVA = "0x1C84ED0", Offset = "0x1C83AD0", VA = "0x181C84ED0")]
		public void Render(string currency, Color color)
		{
		}

		// Token: 0x0602205B RID: 139355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602205B")]
		[Address(RVA = "0x1C84FE0", Offset = "0x1C83BE0", VA = "0x181C84FE0")]
		public void SetEnabled(bool isEnabled)
		{
		}

		// Token: 0x0602205C RID: 139356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602205C")]
		[Address(RVA = "0x1C85080", Offset = "0x1C83C80", VA = "0x181C85080")]
		public UIShopCashIconText()
		{
		}

		// Token: 0x0402EA29 RID: 191017
		[Token(Token = "0x402EA29")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _text;

		// Token: 0x0402EA2A RID: 191018
		[Token(Token = "0x402EA2A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402EA2B RID: 191019
		[Token(Token = "0x402EA2B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402EA2C RID: 191020
		[Token(Token = "0x402EA2C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetEnabled;

		// Token: 0x0402EA2D RID: 191021
		[Token(Token = "0x402EA2D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
