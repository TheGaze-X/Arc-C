using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Grocery
{
	// Token: 0x02004CAE RID: 19630
	[Token(Token = "0x2004CAE")]
	public class GroceryHomeGoodItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601D6BB RID: 120507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6BB")]
		[Address(RVA = "0x16F5030", Offset = "0x16F3C30", VA = "0x1816F5030")]
		public void Render(GroceryHomeGoodItemModel model)
		{
		}

		// Token: 0x0601D6BC RID: 120508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601D6BC")]
		[Address(RVA = "0x16F51A0", Offset = "0x16F3DA0", VA = "0x1816F51A0")]
		public GroceryHomeGoodItemView()
		{
		}

		// Token: 0x04026C02 RID: 158722
		[Token(Token = "0x4026C02")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Image _imgGoodIcon;

		// Token: 0x04026C03 RID: 158723
		[Token(Token = "0x4026C03")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelGoodCount;

		// Token: 0x04026C04 RID: 158724
		[Token(Token = "0x4026C04")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textGoodCount;

		// Token: 0x04026C05 RID: 158725
		[Token(Token = "0x4026C05")]
		[FieldOffset(Offset = "0x30")]
		private UIStateFinder m_stateFinder;

		// Token: 0x04026C06 RID: 158726
		[Token(Token = "0x4026C06")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04026C07 RID: 158727
		[Token(Token = "0x4026C07")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
