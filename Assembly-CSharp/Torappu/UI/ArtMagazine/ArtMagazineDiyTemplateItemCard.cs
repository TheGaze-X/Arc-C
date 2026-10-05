using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ArtMagazine
{
	// Token: 0x020065A9 RID: 26025
	[Token(Token = "0x20065A9")]
	public class ArtMagazineDiyTemplateItemCard : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700587B RID: 22651
		// (set) Token: 0x06025690 RID: 153232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700587B")]
		public Action<int> onItemClick
		{
			[Token(Token = "0x6025690")]
			[Address(RVA = "0x2064A90", Offset = "0x2063690", VA = "0x182064A90")]
			set
			{
			}
		}

		// Token: 0x06025691 RID: 153233 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025691")]
		[Address(RVA = "0x2064720", Offset = "0x2063320", VA = "0x182064720")]
		public void Render(int position, ArtMagazineDiyTemplateItemCardViewModel itemModel)
		{
		}

		// Token: 0x06025692 RID: 153234 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025692")]
		[Address(RVA = "0x20648C0", Offset = "0x20634C0", VA = "0x1820648C0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x06025693 RID: 153235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6025693")]
		[Address(RVA = "0x2064A30", Offset = "0x2063630", VA = "0x182064A30")]
		public ArtMagazineDiyTemplateItemCard()
		{
		}

		// Token: 0x040347F3 RID: 215027
		[Token(Token = "0x40347F3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RectTransform _itemCardContainer;

		// Token: 0x040347F4 RID: 215028
		[Token(Token = "0x40347F4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _itemCardInvalidAlpha;

		// Token: 0x040347F5 RID: 215029
		[Token(Token = "0x40347F5")]
		[FieldOffset(Offset = "0x28")]
		private UIItemCard m_itemCard;

		// Token: 0x040347F6 RID: 215030
		[Token(Token = "0x40347F6")]
		[FieldOffset(Offset = "0x30")]
		private bool m_hasInited;

		// Token: 0x040347F7 RID: 215031
		[Token(Token = "0x40347F7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_set_onItemClick;

		// Token: 0x040347F8 RID: 215032
		[Token(Token = "0x40347F8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x040347F9 RID: 215033
		[Token(Token = "0x40347F9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040347FA RID: 215034
		[Token(Token = "0x40347FA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
