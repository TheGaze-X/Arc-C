using System;
using Il2CppDummyDll;
using Torappu.DataBind;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.StationSelect
{
	// Token: 0x02001C94 RID: 7316
	[Token(Token = "0x2001C94")]
	public class BuildingStationSelectRoomInfoView : DataBinder<StationSelectRoomStatusModelProperty>
	{
		// Token: 0x0600B596 RID: 46486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B596")]
		[Address(RVA = "0x3311A30", Offset = "0x3310630", VA = "0x183311A30", Slot = "7")]
		public override void OnValueChanged(StationSelectRoomStatusModelProperty property)
		{
		}

		// Token: 0x0600B597 RID: 46487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B597")]
		[Address(RVA = "0x3311C90", Offset = "0x3310890", VA = "0x183311C90")]
		public BuildingStationSelectRoomInfoView()
		{
		}

		// Token: 0x0400B213 RID: 45587
		[Token(Token = "0x400B213")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text _textName;

		// Token: 0x0400B214 RID: 45588
		[Token(Token = "0x400B214")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _textRoomIndex;

		// Token: 0x0400B215 RID: 45589
		[Token(Token = "0x400B215")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textRoomTarget;

		// Token: 0x0400B216 RID: 45590
		[Token(Token = "0x400B216")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400B217 RID: 45591
		[Token(Token = "0x400B217")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
