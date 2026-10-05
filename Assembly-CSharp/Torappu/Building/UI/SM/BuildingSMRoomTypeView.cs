using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CC6 RID: 7366
	[Token(Token = "0x2001CC6")]
	public class BuildingSMRoomTypeView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B676 RID: 46710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B676")]
		[Address(RVA = "0x3307600", Offset = "0x3306200", VA = "0x183307600")]
		public void Render(StationManageWorkViewModel workViewModel, StationRoomStructModel selectedRoom)
		{
		}

		// Token: 0x0600B677 RID: 46711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B677")]
		[Address(RVA = "0x3307820", Offset = "0x3306420", VA = "0x183307820")]
		public BuildingSMRoomTypeView()
		{
		}

		// Token: 0x0400B38C RID: 45964
		[Token(Token = "0x400B38C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private GameObject _roomTypePanel;

		// Token: 0x0400B38D RID: 45965
		[Token(Token = "0x400B38D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingSMRoomTypeView.RoomTypeView[] _roomTypeViews;

		// Token: 0x0400B38E RID: 45966
		[Token(Token = "0x400B38E")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B38F RID: 45967
		[Token(Token = "0x400B38F")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001CC7 RID: 7367
		[Token(Token = "0x2001CC7")]
		[Serializable]
		private class RoomTypeView
		{
			// Token: 0x0600B678 RID: 46712 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B678")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RoomTypeView()
			{
			}

			// Token: 0x0400B390 RID: 45968
			[Token(Token = "0x400B390")]
			[FieldOffset(Offset = "0x10")]
			public BuildingData.RoomType roomType;

			// Token: 0x0400B391 RID: 45969
			[Token(Token = "0x400B391")]
			[FieldOffset(Offset = "0x18")]
			public BuildingSMSingleRoomTypeView view;
		}
	}
}
