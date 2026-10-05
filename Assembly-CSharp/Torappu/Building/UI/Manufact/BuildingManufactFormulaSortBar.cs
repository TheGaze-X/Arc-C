using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001DA2 RID: 7586
	[Token(Token = "0x2001DA2")]
	public class BuildingManufactFormulaSortBar : DataBinder<MFormulaGroupProperty>
	{
		// Token: 0x0600BB19 RID: 47897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB19")]
		[Address(RVA = "0x336BB80", Offset = "0x336A780", VA = "0x18336BB80", Slot = "7")]
		public override void OnValueChanged(MFormulaGroupProperty property)
		{
		}

		// Token: 0x0600BB1A RID: 47898 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB1A")]
		[Address(RVA = "0x336BDC0", Offset = "0x336A9C0", VA = "0x18336BDC0")]
		private void _Init()
		{
		}

		// Token: 0x0600BB1B RID: 47899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB1B")]
		[Address(RVA = "0x336BEF0", Offset = "0x336AAF0", VA = "0x18336BEF0")]
		private void _OnSortClicked(FormulaSortType sortType)
		{
		}

		// Token: 0x0600BB1C RID: 47900 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB1C")]
		[Address(RVA = "0x336BF70", Offset = "0x336AB70", VA = "0x18336BF70")]
		public BuildingManufactFormulaSortBar()
		{
		}

		// Token: 0x0400BA7C RID: 47740
		[Token(Token = "0x400BA7C")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingManufactFormulaSortItem[] _sortItems;

		// Token: 0x0400BA7D RID: 47741
		[Token(Token = "0x400BA7D")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Action<FormulaSortType> onSortClicked;

		// Token: 0x0400BA7E RID: 47742
		[Token(Token = "0x400BA7E")]
		[FieldOffset(Offset = "0x30")]
		private bool m_isInited;

		// Token: 0x0400BA7F RID: 47743
		[Token(Token = "0x400BA7F")]
		[FieldOffset(Offset = "0x34")]
		private FormulaSortType m_sortType;

		// Token: 0x0400BA80 RID: 47744
		[Token(Token = "0x400BA80")]
		[FieldOffset(Offset = "0x38")]
		private bool m_isInverse;

		// Token: 0x0400BA81 RID: 47745
		[Token(Token = "0x400BA81")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400BA82 RID: 47746
		[Token(Token = "0x400BA82")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__Init;

		// Token: 0x0400BA83 RID: 47747
		[Token(Token = "0x400BA83")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnSortClicked;

		// Token: 0x0400BA84 RID: 47748
		[Token(Token = "0x400BA84")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
