using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Shop
{
	// Token: 0x02001CFB RID: 7419
	[Token(Token = "0x2001CFB")]
	public class BuildingShopFormulaList : DataBinder<SFormulaGroupProperty>
	{
		// Token: 0x0600B74B RID: 46923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B74B")]
		[Address(RVA = "0x333FCD0", Offset = "0x333E8D0", VA = "0x18333FCD0", Slot = "7")]
		public override void OnValueChanged(SFormulaGroupProperty property)
		{
		}

		// Token: 0x0600B74C RID: 46924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B74C")]
		[Address(RVA = "0x333FF60", Offset = "0x333EB60", VA = "0x18333FF60")]
		public BuildingShopFormulaList()
		{
		}

		// Token: 0x0400B531 RID: 46385
		[Token(Token = "0x400B531")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingShopFormulaAdapter _adapter;

		// Token: 0x0400B532 RID: 46386
		[Token(Token = "0x400B532")]
		[FieldOffset(Offset = "0x28")]
		[NonSerialized]
		public Action<SFormulaViewModel> onFormulaClicked;

		// Token: 0x0400B533 RID: 46387
		[Token(Token = "0x400B533")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400B534 RID: 46388
		[Token(Token = "0x400B534")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
