using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Shop
{
	// Token: 0x02005AAD RID: 23213
	[Token(Token = "0x2005AAD")]
	public class ShopDetailItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06021C2A RID: 138282 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C2A")]
		[Address(RVA = "0x1C3C9F0", Offset = "0x1C3B5F0", VA = "0x181C3C9F0")]
		public void Render(ItemBundle item, SpecialItemInfo specialInfo)
		{
		}

		// Token: 0x06021C2B RID: 138283 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C2B")]
		[Address(RVA = "0x1C3CC80", Offset = "0x1C3B880", VA = "0x181C3CC80")]
		public void Render(string itemName, string itemDescription)
		{
		}

		// Token: 0x06021C2C RID: 138284 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C2C")]
		[Address(RVA = "0x1C3C960", Offset = "0x1C3B560", VA = "0x181C3C960")]
		public void Onclick()
		{
		}

		// Token: 0x06021C2D RID: 138285 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021C2D")]
		[Address(RVA = "0x1C3CE10", Offset = "0x1C3BA10", VA = "0x181C3CE10")]
		public ShopDetailItemView()
		{
		}

		// Token: 0x0402E315 RID: 189205
		[Token(Token = "0x402E315")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text _itemName;

		// Token: 0x0402E316 RID: 189206
		[Token(Token = "0x402E316")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _itemCount;

		// Token: 0x0402E317 RID: 189207
		[Token(Token = "0x402E317")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelSpecial;

		// Token: 0x0402E318 RID: 189208
		[Token(Token = "0x402E318")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _panelPreview;

		// Token: 0x0402E319 RID: 189209
		[Token(Token = "0x402E319")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _specialDesc;

		// Token: 0x0402E31A RID: 189210
		[Token(Token = "0x402E31A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _btnText;

		// Token: 0x0402E31B RID: 189211
		[Token(Token = "0x402E31B")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public UIStringEvent onPreviewClick;

		// Token: 0x0402E31C RID: 189212
		[Token(Token = "0x402E31C")]
		[FieldOffset(Offset = "0x50")]
		private UIItemViewModel m_cachedItemViewModel;

		// Token: 0x0402E31D RID: 189213
		[Token(Token = "0x402E31D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402E31E RID: 189214
		[Token(Token = "0x402E31E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix1_Render;

		// Token: 0x0402E31F RID: 189215
		[Token(Token = "0x402E31F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Onclick;

		// Token: 0x0402E320 RID: 189216
		[Token(Token = "0x402E320")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
