using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CF8 RID: 19704
	[Token(Token = "0x2004CF8")]
	public abstract class GrocerySellShopButtonBaseView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D87A RID: 120954
		[Token(Token = "0x601D87A")]
		public abstract void Render(GrocerySellResultShopModel viewModel, bool showSplitLine, bool canInquire);

		// Token: 0x0601D87B RID: 120955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D87B")]
		[Address(RVA = "0x171BA10", Offset = "0x171A610", VA = "0x18171BA10")]
		protected GrocerySellShopButtonBaseView()
		{
		}

		// Token: 0x04026F56 RID: 159574
		[Token(Token = "0x4026F56")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
