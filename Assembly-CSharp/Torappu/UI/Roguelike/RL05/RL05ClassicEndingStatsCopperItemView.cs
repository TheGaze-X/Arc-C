using System;
using Il2CppDummyDll;
using Torappu.UI.Roguelike.Copper;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Roguelike.RL05
{
	// Token: 0x02005578 RID: 21880
	[Token(Token = "0x2005578")]
	public class RL05ClassicEndingStatsCopperItemView : MonoBehaviour, IHotfixable
	{
		// Token: 0x06020278 RID: 131704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020278")]
		[Address(RVA = "0x1A33A70", Offset = "0x1A32670", VA = "0x181A33A70")]
		public void Render(ILoadAsset iLoadAsset, RL05ClassicEndingStatsCopperItemModel itemModel)
		{
		}

		// Token: 0x06020279 RID: 131705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6020279")]
		[Address(RVA = "0x1A33C60", Offset = "0x1A32860", VA = "0x181A33C60")]
		public RL05ClassicEndingStatsCopperItemView()
		{
		}

		// Token: 0x0402B6EE RID: 177902
		[Token(Token = "0x402B6EE")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _inBagBg;

		// Token: 0x0402B6EF RID: 177903
		[Token(Token = "0x402B6EF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _copperItemContainer;

		// Token: 0x0402B6F0 RID: 177904
		[Token(Token = "0x402B6F0")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0402B6F1 RID: 177905
		[Token(Token = "0x402B6F1")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameObject _countObj;

		// Token: 0x0402B6F2 RID: 177906
		[Token(Token = "0x402B6F2")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _countText;

		// Token: 0x0402B6F3 RID: 177907
		[Token(Token = "0x402B6F3")]
		[FieldOffset(Offset = "0x40")]
		private RoguelikeAbstractCopperItemCard m_itemCard;

		// Token: 0x0402B6F4 RID: 177908
		[Token(Token = "0x402B6F4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0402B6F5 RID: 177909
		[Token(Token = "0x402B6F5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
