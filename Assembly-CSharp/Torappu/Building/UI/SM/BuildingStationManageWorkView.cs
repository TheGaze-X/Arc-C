using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CCB RID: 7371
	[Token(Token = "0x2001CCB")]
	public class BuildingStationManageWorkView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B686 RID: 46726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B686")]
		[Address(RVA = "0x334A7F0", Offset = "0x33493F0", VA = "0x18334A7F0")]
		public void Render(StationManageWorkViewModel viewModel, StationRoomStructModel selectedRoom)
		{
		}

		// Token: 0x0600B687 RID: 46727 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B687")]
		[Address(RVA = "0x334A6D0", Offset = "0x33492D0", VA = "0x18334A6D0")]
		public void OnBatchActiveClicked()
		{
		}

		// Token: 0x0600B688 RID: 46728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B688")]
		[Address(RVA = "0x334A760", Offset = "0x3349360", VA = "0x18334A760")]
		public void OnBatchInactiveClicked()
		{
		}

		// Token: 0x0600B689 RID: 46729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B689")]
		[Address(RVA = "0x334AC50", Offset = "0x3349850", VA = "0x18334AC50")]
		public BuildingStationManageWorkView()
		{
		}

		// Token: 0x0400B3CD RID: 46029
		[Token(Token = "0x400B3CD")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildingSMStationNumView _workNumView;

		// Token: 0x0400B3CE RID: 46030
		[Token(Token = "0x400B3CE")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingSMRoomGroupListView _roomGroupList;

		// Token: 0x0400B3CF RID: 46031
		[Token(Token = "0x400B3CF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _roomCntText;

		// Token: 0x0400B3D0 RID: 46032
		[Token(Token = "0x400B3D0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Room Info")]
		private GameObject _panelNoSelectedRoom;

		// Token: 0x0400B3D1 RID: 46033
		[Token(Token = "0x400B3D1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Room Info")]
		private GameObject _panelHasSelectedRoom;

		// Token: 0x0400B3D2 RID: 46034
		[Token(Token = "0x400B3D2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Room Info")]
		private Text _roomName;

		// Token: 0x0400B3D3 RID: 46035
		[Token(Token = "0x400B3D3")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Room Info")]
		private Text _roomIndex;

		// Token: 0x0400B3D4 RID: 46036
		[Token(Token = "0x400B3D4")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Room Info")]
		private BuildingSMRoomTypeView _panelRoomType;

		// Token: 0x0400B3D5 RID: 46037
		[Token(Token = "0x400B3D5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Room Info")]
		private BuildingSMRoomInfoList _charInfoList;

		// Token: 0x0400B3D6 RID: 46038
		[Token(Token = "0x400B3D6")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Batch")]
		private GameObject _batchBtnActive;

		// Token: 0x0400B3D7 RID: 46039
		[Token(Token = "0x400B3D7")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Batch")]
		private GameObject _batchBtnInactive;

		// Token: 0x0400B3D8 RID: 46040
		[Token(Token = "0x400B3D8")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Batch")]
		private GameObject _stopCnt;

		// Token: 0x0400B3D9 RID: 46041
		[Token(Token = "0x400B3D9")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Batch")]
		private Text _stopCntText;

		// Token: 0x0400B3DA RID: 46042
		[Token(Token = "0x400B3DA")]
		[FieldOffset(Offset = "0x80")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0400B3DB RID: 46043
		[Token(Token = "0x400B3DB")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B3DC RID: 46044
		[Token(Token = "0x400B3DC")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBatchActiveClicked;

		// Token: 0x0400B3DD RID: 46045
		[Token(Token = "0x400B3DD")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBatchInactiveClicked;

		// Token: 0x0400B3DE RID: 46046
		[Token(Token = "0x400B3DE")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
