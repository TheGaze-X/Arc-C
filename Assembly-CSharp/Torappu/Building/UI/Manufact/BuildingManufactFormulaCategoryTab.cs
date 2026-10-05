using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001D9C RID: 7580
	[Token(Token = "0x2001D9C")]
	public class BuildingManufactFormulaCategoryTab : DataBinder<MFormulaGroupProperty>
	{
		// Token: 0x0600BB06 RID: 47878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB06")]
		[Address(RVA = "0x336AA90", Offset = "0x3369690", VA = "0x18336AA90", Slot = "7")]
		public override void OnValueChanged(MFormulaGroupProperty property)
		{
		}

		// Token: 0x0600BB07 RID: 47879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB07")]
		[Address(RVA = "0x336AA20", Offset = "0x3369620", VA = "0x18336AA20")]
		public void EventOnItemTypeClicked()
		{
		}

		// Token: 0x0600BB08 RID: 47880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB08")]
		[Address(RVA = "0x336AB40", Offset = "0x3369740", VA = "0x18336AB40")]
		public BuildingManufactFormulaCategoryTab()
		{
		}

		// Token: 0x0400BA51 RID: 47697
		[Token(Token = "0x400BA51")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x0400BA52 RID: 47698
		[Token(Token = "0x400BA52")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuildingData.FormulaItemType _itemType;

		// Token: 0x0400BA53 RID: 47699
		[Token(Token = "0x400BA53")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Action<BuildingData.FormulaItemType> onItemTypeClicked;

		// Token: 0x0400BA54 RID: 47700
		[Token(Token = "0x400BA54")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400BA55 RID: 47701
		[Token(Token = "0x400BA55")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnItemTypeClicked;

		// Token: 0x0400BA56 RID: 47702
		[Token(Token = "0x400BA56")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
