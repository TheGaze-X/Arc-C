using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CF7 RID: 19703
	[Token(Token = "0x2004CF7")]
	public class GrocerySellInquireFloatPanelItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D878 RID: 120952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D878")]
		[Address(RVA = "0x1716A80", Offset = "0x1715680", VA = "0x181716A80")]
		public void Render(Act27SideData.Act27SideInquireData data)
		{
		}

		// Token: 0x0601D879 RID: 120953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D879")]
		[Address(RVA = "0x1716BE0", Offset = "0x17157E0", VA = "0x181716BE0")]
		public GrocerySellInquireFloatPanelItemView()
		{
		}

		// Token: 0x04026F52 RID: 159570
		[Token(Token = "0x4026F52")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _textPoint;

		// Token: 0x04026F53 RID: 159571
		[Token(Token = "0x4026F53")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textDesc;

		// Token: 0x04026F54 RID: 159572
		[Token(Token = "0x4026F54")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026F55 RID: 159573
		[Token(Token = "0x4026F55")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
