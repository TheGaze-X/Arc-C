using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act9D0
{
	// Token: 0x0200716A RID: 29034
	[Token(Token = "0x200716A")]
	public class Act9D0MapZoneGroupView : DataBinder<Act9D0ZoneDescGroupViewProperty>
	{
		// Token: 0x0602938E RID: 168846 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602938E")]
		[Address(RVA = "0x2497B00", Offset = "0x2496700", VA = "0x182497B00", Slot = "7")]
		public override void OnValueChanged(Act9D0ZoneDescGroupViewProperty property)
		{
		}

		// Token: 0x0602938F RID: 168847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602938F")]
		[Address(RVA = "0x2497D10", Offset = "0x2496910", VA = "0x182497D10")]
		public Act9D0MapZoneGroupView()
		{
		}

		// Token: 0x0403ADC4 RID: 241092
		[Token(Token = "0x403ADC4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Act9D0MapZoneView> _zoneViewList;

		// Token: 0x0403ADC5 RID: 241093
		[Token(Token = "0x403ADC5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403ADC6 RID: 241094
		[Token(Token = "0x403ADC6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
