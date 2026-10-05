using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001CF8 RID: 7416
	[Token(Token = "0x2001CF8")]
	public class BuildingShopFormulaCategoryTab : DataBinder<SFormulaGroupProperty>
	{
		// Token: 0x0600B740 RID: 46912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B740")]
		[Address(RVA = "0x333F3D0", Offset = "0x333DFD0", VA = "0x18333F3D0", Slot = "7")]
		public override void OnValueChanged(SFormulaGroupProperty property)
		{
		}

		// Token: 0x0600B741 RID: 46913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B741")]
		[Address(RVA = "0x333F360", Offset = "0x333DF60", VA = "0x18333F360")]
		public void EventOnItemTypeClicked()
		{
		}

		// Token: 0x0600B742 RID: 46914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B742")]
		[Address(RVA = "0x333F480", Offset = "0x333E080", VA = "0x18333F480")]
		public BuildingShopFormulaCategoryTab()
		{
		}

		// Token: 0x0400B515 RID: 46357
		[Token(Token = "0x400B515")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x0400B516 RID: 46358
		[Token(Token = "0x400B516")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuildingData.FormulaItemType _itemType;

		// Token: 0x0400B517 RID: 46359
		[Token(Token = "0x400B517")]
		[FieldOffset(Offset = "0x30")]
		[NonSerialized]
		public Action<BuildingData.FormulaItemType> onItemTypeClicked;

		// Token: 0x0400B518 RID: 46360
		[Token(Token = "0x400B518")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400B519 RID: 46361
		[Token(Token = "0x400B519")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_EventOnItemTypeClicked;

		// Token: 0x0400B51A RID: 46362
		[Token(Token = "0x400B51A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
