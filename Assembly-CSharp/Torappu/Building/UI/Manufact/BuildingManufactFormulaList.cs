using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Manufact
{
	// Token: 0x02001DA1 RID: 7585
	[Token(Token = "0x2001DA1")]
	public class BuildingManufactFormulaList : DataBinder<MFormulaGroupProperty>
	{
		// Token: 0x0600BB17 RID: 47895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB17")]
		[Address(RVA = "0x336B890", Offset = "0x336A490", VA = "0x18336B890", Slot = "7")]
		public override void OnValueChanged(MFormulaGroupProperty property)
		{
		}

		// Token: 0x0600BB18 RID: 47896 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BB18")]
		[Address(RVA = "0x336BB10", Offset = "0x336A710", VA = "0x18336BB10")]
		public BuildingManufactFormulaList()
		{
		}

		// Token: 0x0400BA78 RID: 47736
		[Token(Token = "0x400BA78")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingManufactListAdapter _adapter;

		// Token: 0x0400BA79 RID: 47737
		[Token(Token = "0x400BA79")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Action<MFormulaViewModel> onFormulaClicked;

		// Token: 0x0400BA7A RID: 47738
		[Token(Token = "0x400BA7A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400BA7B RID: 47739
		[Token(Token = "0x400BA7B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
