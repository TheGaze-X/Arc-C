using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CB2 RID: 19634
	[Token(Token = "0x2004CB2")]
	public class GroceryHomeShopView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D6C6 RID: 120518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6C6")]
		[Address(RVA = "0x16F63E0", Offset = "0x16F4FE0", VA = "0x1816F63E0")]
		public void Render(GroceryHomeShopModel viewModel, bool showSplitLine)
		{
		}

		// Token: 0x0601D6C7 RID: 120519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6C7")]
		[Address(RVA = "0x16F64E0", Offset = "0x16F50E0", VA = "0x1816F64E0")]
		public GroceryHomeShopView()
		{
		}

		// Token: 0x04026C26 RID: 158758
		[Token(Token = "0x4026C26")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _iconShop;

		// Token: 0x04026C27 RID: 158759
		[Token(Token = "0x4026C27")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelSplitLine;

		// Token: 0x04026C28 RID: 158760
		[Token(Token = "0x4026C28")]
		[FieldOffset(Offset = "0x28")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026C29 RID: 158761
		[Token(Token = "0x4026C29")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026C2A RID: 158762
		[Token(Token = "0x4026C2A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
