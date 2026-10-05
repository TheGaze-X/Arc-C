using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CFB RID: 19707
	[Token(Token = "0x2004CFB")]
	public class GrocerySellShopIconView : GrocerySellShopButtonBaseView, IHotfixable
	{
		// Token: 0x0601D88D RID: 120973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D88D")]
		[Address(RVA = "0x171C090", Offset = "0x171AC90", VA = "0x18171C090", Slot = "4")]
		public override void Render(GrocerySellResultShopModel viewModel, bool showSplitLine, bool canInquire)
		{
		}

		// Token: 0x0601D88E RID: 120974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D88E")]
		[Address(RVA = "0x171C180", Offset = "0x171AD80", VA = "0x18171C180")]
		public GrocerySellShopIconView()
		{
		}

		// Token: 0x04026F72 RID: 159602
		[Token(Token = "0x4026F72")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _iconShop;

		// Token: 0x04026F73 RID: 159603
		[Token(Token = "0x4026F73")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelLine;

		// Token: 0x04026F74 RID: 159604
		[Token(Token = "0x4026F74")]
		[FieldOffset(Offset = "0x28")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026F75 RID: 159605
		[Token(Token = "0x4026F75")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026F76 RID: 159606
		[Token(Token = "0x4026F76")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
