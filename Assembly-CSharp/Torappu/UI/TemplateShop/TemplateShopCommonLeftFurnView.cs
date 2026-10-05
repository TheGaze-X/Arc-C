using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.TemplateShop
{
	// Token: 0x02003D54 RID: 15700
	[Token(Token = "0x2003D54")]
	public class TemplateShopCommonLeftFurnView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06018741 RID: 100161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018741")]
		[Address(RVA = "0x10EEDE0", Offset = "0x10ED9E0", VA = "0x1810EEDE0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06018742 RID: 100162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018742")]
		[Address(RVA = "0x10EE960", Offset = "0x10ED560", VA = "0x1810EE960")]
		public void Render(TemplateCommonShopGoodViewModel shopViewModel)
		{
		}

		// Token: 0x06018743 RID: 100163 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6018743")]
		[Address(RVA = "0x10EEF60", Offset = "0x10EDB60", VA = "0x1810EEF60")]
		public TemplateShopCommonLeftFurnView()
		{
		}

		// Token: 0x0401DEDF RID: 122591
		[Token(Token = "0x401DEDF")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _itemDetailName;

		// Token: 0x0401DEE0 RID: 122592
		[Token(Token = "0x401DEE0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _addText;

		// Token: 0x0401DEE1 RID: 122593
		[Token(Token = "0x401DEE1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Transform _itemContainer;

		// Token: 0x0401DEE2 RID: 122594
		[Token(Token = "0x401DEE2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIItemCard _itemCard;

		// Token: 0x0401DEE3 RID: 122595
		[Token(Token = "0x401DEE3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _scaleCount;

		// Token: 0x0401DEE4 RID: 122596
		[Token(Token = "0x401DEE4")]
		[FieldOffset(Offset = "0x40")]
		private UIItemCard m_itemCard;

		// Token: 0x0401DEE5 RID: 122597
		[Token(Token = "0x401DEE5")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isInited;

		// Token: 0x0401DEE6 RID: 122598
		[Token(Token = "0x401DEE6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401DEE7 RID: 122599
		[Token(Token = "0x401DEE7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401DEE8 RID: 122600
		[Token(Token = "0x401DEE8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
