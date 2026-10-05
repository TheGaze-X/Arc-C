using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005B0C RID: 23308
	[Token(Token = "0x2005B0C")]
	public class QCShopLMTGSDetailView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021DC7 RID: 138695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DC7")]
		[Address(RVA = "0x1C59F50", Offset = "0x1C58B50", VA = "0x181C59F50")]
		public void Render()
		{
		}

		// Token: 0x06021DC8 RID: 138696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021DC8")]
		[Address(RVA = "0x1C5A0A0", Offset = "0x1C58CA0", VA = "0x181C5A0A0")]
		public QCShopLMTGSDetailView()
		{
		}

		// Token: 0x0402E621 RID: 189985
		[Token(Token = "0x402E621")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _constTextPart1;

		// Token: 0x0402E622 RID: 189986
		[Token(Token = "0x402E622")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _constTextPart2;

		// Token: 0x0402E623 RID: 189987
		[Token(Token = "0x402E623")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E624 RID: 189988
		[Token(Token = "0x402E624")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
