using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act12side.UI
{
	// Token: 0x02007AAA RID: 31402
	[Token(Token = "0x2007AAA")]
	public class Act12sideMapZoneGroupView : DataBinder<Act12sideZoneDescGroupViewProperty>
	{
		// Token: 0x0602BFD7 RID: 180183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFD7")]
		[Address(RVA = "0x27DB490", Offset = "0x27DA090", VA = "0x1827DB490", Slot = "7")]
		public override void OnValueChanged(Act12sideZoneDescGroupViewProperty property)
		{
		}

		// Token: 0x0602BFD8 RID: 180184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BFD8")]
		[Address(RVA = "0x27DB6A0", Offset = "0x27DA2A0", VA = "0x1827DB6A0")]
		public Act12sideMapZoneGroupView()
		{
		}

		// Token: 0x0403FB90 RID: 261008
		[Token(Token = "0x403FB90")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Act12sideMapZoneView> _zoneViewList;

		// Token: 0x0403FB91 RID: 261009
		[Token(Token = "0x403FB91")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _missionTrackPointRoot;

		// Token: 0x0403FB92 RID: 261010
		[Token(Token = "0x403FB92")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403FB93 RID: 261011
		[Token(Token = "0x403FB93")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
