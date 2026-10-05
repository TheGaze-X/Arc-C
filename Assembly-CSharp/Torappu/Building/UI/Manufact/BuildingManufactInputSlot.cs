using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001DA4 RID: 7588
	[Token(Token = "0x2001DA4")]
	public class BuildingManufactInputSlot : DataBinder<MItemInputSlotProperty>
	{
		// Token: 0x0600BB1E RID: 47902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB1E")]
		[Address(RVA = "0x33911B0", Offset = "0x338FDB0", VA = "0x1833911B0")]
		private void Start()
		{
		}

		// Token: 0x0600BB1F RID: 47903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB1F")]
		[Address(RVA = "0x3391000", Offset = "0x338FC00", VA = "0x183391000", Slot = "7")]
		public override void OnValueChanged(MItemInputSlotProperty property)
		{
		}

		// Token: 0x0600BB20 RID: 47904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB20")]
		[Address(RVA = "0x3391260", Offset = "0x338FE60", VA = "0x183391260")]
		private void _Init()
		{
		}

		// Token: 0x0600BB21 RID: 47905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB21")]
		[Address(RVA = "0x3391440", Offset = "0x3390040", VA = "0x183391440")]
		private void _UpdateActive()
		{
		}

		// Token: 0x0600BB22 RID: 47906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB22")]
		[Address(RVA = "0x3391750", Offset = "0x3390350", VA = "0x183391750")]
		private void _UpdateAutoLayouts()
		{
		}

		// Token: 0x0600BB23 RID: 47907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB23")]
		[Address(RVA = "0x3391840", Offset = "0x3390440", VA = "0x183391840")]
		public BuildingManufactInputSlot()
		{
		}

		// Token: 0x0400BA85 RID: 47749
		[Token(Token = "0x400BA85")]
		private const int LARGE_NUMBER = 999;

		// Token: 0x0400BA86 RID: 47750
		[Token(Token = "0x400BA86")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelActive;

		// Token: 0x0400BA87 RID: 47751
		[Token(Token = "0x400BA87")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelInactive;

		// Token: 0x0400BA88 RID: 47752
		[Token(Token = "0x400BA88")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0400BA89 RID: 47753
		[Token(Token = "0x400BA89")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textCount;

		// Token: 0x0400BA8A RID: 47754
		[Token(Token = "0x400BA8A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Text _textCost;

		// Token: 0x0400BA8B RID: 47755
		[Token(Token = "0x400BA8B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textReserve;

		// Token: 0x0400BA8C RID: 47756
		[Token(Token = "0x400BA8C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Item Card")]
		private RectTransform _itemCardContainer;

		// Token: 0x0400BA8D RID: 47757
		[Token(Token = "0x400BA8D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Item Card")]
		private float _itemScale;

		// Token: 0x0400BA8E RID: 47758
		[Token(Token = "0x400BA8E")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private RectTransform[] _autoLayouts;

		// Token: 0x0400BA8F RID: 47759
		[Token(Token = "0x400BA8F")]
		[FieldOffset(Offset = "0x68")]
		private bool m_isInited;

		// Token: 0x0400BA90 RID: 47760
		[Token(Token = "0x400BA90")]
		[FieldOffset(Offset = "0x70")]
		private UIItemCard m_itemCard;

		// Token: 0x0400BA91 RID: 47761
		[Token(Token = "0x400BA91")]
		[FieldOffset(Offset = "0x78")]
		private MItemInputSlotStruct m_itemStruct;

		// Token: 0x0400BA92 RID: 47762
		[Token(Token = "0x400BA92")]
		[FieldOffset(Offset = "0x90")]
		private UIItemViewModel m_itemViewModel;

		// Token: 0x0400BA93 RID: 47763
		[Token(Token = "0x400BA93")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400BA94 RID: 47764
		[Token(Token = "0x400BA94")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400BA95 RID: 47765
		[Token(Token = "0x400BA95")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x0400BA96 RID: 47766
		[Token(Token = "0x400BA96")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__UpdateActive;

		// Token: 0x0400BA97 RID: 47767
		[Token(Token = "0x400BA97")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__UpdateAutoLayouts;

		// Token: 0x0400BA98 RID: 47768
		[Token(Token = "0x400BA98")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
