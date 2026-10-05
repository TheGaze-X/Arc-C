using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D57 RID: 15703
	[Token(Token = "0x2003D57")]
	public class TemplateShopCommonRightSingleView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018759 RID: 100185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018759")]
		[Address(RVA = "0x10F11C0", Offset = "0x10EFDC0", VA = "0x1810F11C0")]
		public void Render(TemplateCommonShopGoodViewModel viewModel, bool isReplicate = false, [Optional] ItemBundle item)
		{
		}

		// Token: 0x0601875A RID: 100186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601875A")]
		[Address(RVA = "0x10F19C0", Offset = "0x10F05C0", VA = "0x1810F19C0")]
		public TemplateShopCommonRightSingleView()
		{
		}

		// Token: 0x0401DF1F RID: 122655
		[Token(Token = "0x401DF1F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _itemDetailText;

		// Token: 0x0401DF20 RID: 122656
		[Token(Token = "0x401DF20")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _itemDetailCount;

		// Token: 0x0401DF21 RID: 122657
		[Token(Token = "0x401DF21")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _alreadyHaveCount;

		// Token: 0x0401DF22 RID: 122658
		[Token(Token = "0x401DF22")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _singlePrice;

		// Token: 0x0401DF23 RID: 122659
		[Token(Token = "0x401DF23")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _priceTotal;

		// Token: 0x0401DF24 RID: 122660
		[Token(Token = "0x401DF24")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _constText;

		// Token: 0x0401DF25 RID: 122661
		[Token(Token = "0x401DF25")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _colorIcon;

		// Token: 0x0401DF26 RID: 122662
		[Token(Token = "0x401DF26")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Image _blackIcon;

		// Token: 0x0401DF27 RID: 122663
		[Token(Token = "0x401DF27")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Image _buyColor;

		// Token: 0x0401DF28 RID: 122664
		[Token(Token = "0x401DF28")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DF29 RID: 122665
		[Token(Token = "0x401DF29")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
