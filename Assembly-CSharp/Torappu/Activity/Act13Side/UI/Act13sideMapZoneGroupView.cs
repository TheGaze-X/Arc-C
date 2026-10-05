using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI.ActivityStage;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act13Side.UI
{
	// Token: 0x02007A4F RID: 31311
	[Token(Token = "0x2007A4F")]
	public class Act13sideMapZoneGroupView : DataBinder<Act13sideZoneDescGroupViewProperty>
	{
		// Token: 0x0602BDDC RID: 179676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDDC")]
		[Address(RVA = "0x27CB8E0", Offset = "0x27CA4E0", VA = "0x1827CB8E0", Slot = "7")]
		public override void OnValueChanged(Act13sideZoneDescGroupViewProperty property)
		{
		}

		// Token: 0x0602BDDD RID: 179677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602BDDD")]
		[Address(RVA = "0x27CBAF0", Offset = "0x27CA6F0", VA = "0x1827CBAF0")]
		public Act13sideMapZoneGroupView()
		{
		}

		// Token: 0x0403F861 RID: 260193
		[Token(Token = "0x403F861")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<Act13sideMapZoneView> _zoneViewList;

		// Token: 0x0403F862 RID: 260194
		[Token(Token = "0x403F862")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _missionTrackPointRoot;

		// Token: 0x0403F863 RID: 260195
		[Token(Token = "0x403F863")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0403F864 RID: 260196
		[Token(Token = "0x403F864")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
