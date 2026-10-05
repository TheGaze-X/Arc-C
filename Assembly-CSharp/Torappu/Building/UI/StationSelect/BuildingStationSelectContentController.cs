using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C91 RID: 7313
	[Token(Token = "0x2001C91")]
	public class BuildingStationSelectContentController : DataBinder<StationCharGroupProperty>
	{
		// Token: 0x0600B58E RID: 46478 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B58E")]
		[Address(RVA = "0x3310BA0", Offset = "0x330F7A0", VA = "0x183310BA0", Slot = "7")]
		public override void OnValueChanged(StationCharGroupProperty property)
		{
		}

		// Token: 0x0600B58F RID: 46479 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B58F")]
		[Address(RVA = "0x3310C50", Offset = "0x330F850", VA = "0x183310C50")]
		public BuildingStationSelectContentController()
		{
		}

		// Token: 0x0400B1FF RID: 45567
		[Token(Token = "0x400B1FF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _panelContent;

		// Token: 0x0400B200 RID: 45568
		[Token(Token = "0x400B200")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _panelEmpty;

		// Token: 0x0400B201 RID: 45569
		[Token(Token = "0x400B201")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400B202 RID: 45570
		[Token(Token = "0x400B202")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
