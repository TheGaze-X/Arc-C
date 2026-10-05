using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001D9D RID: 7581
	[Token(Token = "0x2001D9D")]
	public class BuildingManufactFormulaCostItem : MonoBehaviour
	{
		// Token: 0x0600BB09 RID: 47881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB09")]
		[Address(RVA = "0x336ABB0", Offset = "0x33697B0", VA = "0x18336ABB0")]
		public void Render(FormulaCostStruct cost)
		{
		}

		// Token: 0x0600BB0A RID: 47882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB0A")]
		[Address(RVA = "0x336ACD0", Offset = "0x33698D0", VA = "0x18336ACD0")]
		private void _Init()
		{
		}

		// Token: 0x0600BB0B RID: 47883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB0B")]
		[Address(RVA = "0x336AE80", Offset = "0x3369A80", VA = "0x18336AE80")]
		private void _RenderActive(FormulaCostStruct cost)
		{
		}

		// Token: 0x0600BB0C RID: 47884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB0C")]
		[Address(RVA = "0x336B0E0", Offset = "0x3369CE0", VA = "0x18336B0E0")]
		public BuildingManufactFormulaCostItem()
		{
		}

		// Token: 0x0400BA57 RID: 47703
		[Token(Token = "0x400BA57")]
		private const int MAX_COUNT_LENGTH = 7;

		// Token: 0x0400BA58 RID: 47704
		[Token(Token = "0x400BA58")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x0400BA59 RID: 47705
		[Token(Token = "0x400BA59")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0400BA5A RID: 47706
		[Token(Token = "0x400BA5A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private RectTransform _itemContainer;

		// Token: 0x0400BA5B RID: 47707
		[Token(Token = "0x400BA5B")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _itemScale;

		// Token: 0x0400BA5C RID: 47708
		[Token(Token = "0x400BA5C")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0400BA5D RID: 47709
		[Token(Token = "0x400BA5D")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelLack;

		// Token: 0x0400BA5E RID: 47710
		[Token(Token = "0x400BA5E")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Color _lackColor;

		// Token: 0x0400BA5F RID: 47711
		[Token(Token = "0x400BA5F")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isInited;

		// Token: 0x0400BA60 RID: 47712
		[Token(Token = "0x400BA60")]
		[FieldOffset(Offset = "0x60")]
		private FormulaCostStruct m_cacheCost;

		// Token: 0x0400BA61 RID: 47713
		[Token(Token = "0x400BA61")]
		[FieldOffset(Offset = "0x78")]
		private UIItemCard m_itemCard;

		// Token: 0x0400BA62 RID: 47714
		[Token(Token = "0x400BA62")]
		[FieldOffset(Offset = "0x80")]
		private UIItemViewModel m_itemModel;
	}
}
