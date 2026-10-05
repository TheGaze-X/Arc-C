using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.Float
{
	// Token: 0x02001DF8 RID: 7672
	[Token(Token = "0x2001DF8")]
	public class BuildingFloatSlideModeToggle : DataBinder<BuildingFloatSlideModeProperty>
	{
		// Token: 0x0600BD7A RID: 48506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD7A")]
		[Address(RVA = "0x33A2830", Offset = "0x33A1430", VA = "0x1833A2830", Slot = "7")]
		public override void OnValueChanged(BuildingFloatSlideModeProperty property)
		{
		}

		// Token: 0x0600BD7B RID: 48507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600BD7B")]
		[Address(RVA = "0x33A28D0", Offset = "0x33A14D0", VA = "0x1833A28D0")]
		public BuildingFloatSlideModeToggle()
		{
		}

		// Token: 0x0400BDEA RID: 48618
		[Token(Token = "0x400BDEA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TwoStateToggle _toggle;

		// Token: 0x0400BDEB RID: 48619
		[Token(Token = "0x400BDEB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuildingFloatSlideMode _slideMode;

		// Token: 0x0400BDEC RID: 48620
		[Token(Token = "0x400BDEC")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400BDED RID: 48621
		[Token(Token = "0x400BDED")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
