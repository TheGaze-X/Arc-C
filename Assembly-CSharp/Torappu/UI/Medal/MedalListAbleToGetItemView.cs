using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.UI.Medal
{
	// Token: 0x0200497B RID: 18811
	[Token(Token = "0x200497B")]
	public class MedalListAbleToGetItemView : MonoBehaviour, IHotfixable, MedalListItemHolder.IMedalListItem
	{
		// Token: 0x0601C59B RID: 116123 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C59B")]
		[Address(RVA = "0x15CEFB0", Offset = "0x15CDBB0", VA = "0x1815CEFB0")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601C59C RID: 116124 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C59C")]
		[Address(RVA = "0x15CEB80", Offset = "0x15CD780", VA = "0x1815CEB80", Slot = "4")]
		public void RenderView(MedalCommonViewModel viewModel)
		{
		}

		// Token: 0x0601C59D RID: 116125 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C59D")]
		[Address(RVA = "0x15CEAF0", Offset = "0x15CD6F0", VA = "0x1815CEAF0")]
		public void OnClick()
		{
		}

		// Token: 0x0601C59E RID: 116126 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601C59E")]
		[Address(RVA = "0x15CF120", Offset = "0x15CDD20", VA = "0x1815CF120")]
		public MedalListAbleToGetItemView()
		{
		}

		// Token: 0x040251A3 RID: 151971
		[Token(Token = "0x40251A3")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _itemCardContainer;

		// Token: 0x040251A4 RID: 151972
		[Token(Token = "0x40251A4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _name;

		// Token: 0x040251A5 RID: 151973
		[Token(Token = "0x40251A5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040251A6 RID: 151974
		[Token(Token = "0x40251A6")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _itemNameCount;

		// Token: 0x040251A7 RID: 151975
		[Token(Token = "0x40251A7")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _scaler;

		// Token: 0x040251A8 RID: 151976
		[Token(Token = "0x40251A8")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _itemRewardContainer;

		// Token: 0x040251A9 RID: 151977
		[Token(Token = "0x40251A9")]
		[FieldOffset(Offset = "0x48")]
		[NonSerialized]
		public UIMedalEvent clickMedalEvent;

		// Token: 0x040251AA RID: 151978
		[Token(Token = "0x40251AA")]
		[FieldOffset(Offset = "0x50")]
		private MedalCommonViewModel m_viewModelCache;

		// Token: 0x040251AB RID: 151979
		[Token(Token = "0x40251AB")]
		[FieldOffset(Offset = "0x58")]
		private UIItemCard m_itemCard;

		// Token: 0x040251AC RID: 151980
		[Token(Token = "0x40251AC")]
		[FieldOffset(Offset = "0x60")]
		private bool m_isInited;

		// Token: 0x040251AD RID: 151981
		[Token(Token = "0x40251AD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x040251AE RID: 151982
		[Token(Token = "0x40251AE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_RenderView;

		// Token: 0x040251AF RID: 151983
		[Token(Token = "0x40251AF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnClick;

		// Token: 0x040251B0 RID: 151984
		[Token(Token = "0x40251B0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
