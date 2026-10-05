using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act10D5
{
	// Token: 0x02007B2E RID: 31534
	[Token(Token = "0x2007B2E")]
	public class Act10D5EntryZoneGroupView : DataBinder<Act10D5ZoneDescGroupViewProperty>
	{
		// Token: 0x0602C262 RID: 180834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C262")]
		[Address(RVA = "0x2804C10", Offset = "0x2803810", VA = "0x182804C10", Slot = "7")]
		public override void OnValueChanged(Act10D5ZoneDescGroupViewProperty property)
		{
		}

		// Token: 0x0602C263 RID: 180835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602C263")]
		[Address(RVA = "0x2804E20", Offset = "0x2803A20", VA = "0x182804E20")]
		public Act10D5EntryZoneGroupView()
		{
		}

		// Token: 0x0403FFE1 RID: 262113
		[Token(Token = "0x403FFE1")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelAllTimeout;

		// Token: 0x0403FFE2 RID: 262114
		[Token(Token = "0x403FFE2")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Act10D5EntryZoneView> _zoneViewList;

		// Token: 0x0403FFE3 RID: 262115
		[Token(Token = "0x403FFE3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403FFE4 RID: 262116
		[Token(Token = "0x403FFE4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
