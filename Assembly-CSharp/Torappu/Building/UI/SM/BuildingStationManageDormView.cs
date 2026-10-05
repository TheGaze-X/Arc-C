using System;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CC9 RID: 7369
	[Token(Token = "0x2001CC9")]
	public class BuildingStationManageDormView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0600B67D RID: 46717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B67D")]
		[Address(RVA = "0x33083D0", Offset = "0x3306FD0", VA = "0x1833083D0")]
		public void Render(StationManageRestViewModel viewModel, StationRoomStructModel selectedRoom)
		{
		}

		// Token: 0x0600B67E RID: 46718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B67E")]
		[Address(RVA = "0x33082B0", Offset = "0x3306EB0", VA = "0x1833082B0")]
		public void OnBatchActiveClicked()
		{
		}

		// Token: 0x0600B67F RID: 46719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B67F")]
		[Address(RVA = "0x3308340", Offset = "0x3306F40", VA = "0x183308340")]
		public void OnBatchInactiveClicked()
		{
		}

		// Token: 0x0600B680 RID: 46720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B680")]
		[Address(RVA = "0x3308B80", Offset = "0x3307780", VA = "0x183308B80")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B681 RID: 46721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B681")]
		[Address(RVA = "0x3308D10", Offset = "0x3307910", VA = "0x183308D10")]
		public BuildingStationManageDormView()
		{
		}

		// Token: 0x0400B39E RID: 45982
		[Token(Token = "0x400B39E")]
		private const float LOCK_EDIT_BKG_ALPHA = 0.5f;

		// Token: 0x0400B39F RID: 45983
		[Token(Token = "0x400B39F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BuildingSMStationNumView _dormNumView;

		// Token: 0x0400B3A0 RID: 45984
		[Token(Token = "0x400B3A0")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BuildingSMRoomGroupListView _roomGroupList;

		// Token: 0x0400B3A1 RID: 45985
		[Token(Token = "0x400B3A1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Text _roomCntText;

		// Token: 0x0400B3A2 RID: 45986
		[Token(Token = "0x400B3A2")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Group("Room Info")]
		private GameObject _panelNoSelectedRoom;

		// Token: 0x0400B3A3 RID: 45987
		[Token(Token = "0x400B3A3")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Group("Room Info")]
		private GameObject _panelHasSelectedRoom;

		// Token: 0x0400B3A4 RID: 45988
		[Token(Token = "0x400B3A4")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Room Info")]
		private Text _roomName;

		// Token: 0x0400B3A5 RID: 45989
		[Token(Token = "0x400B3A5")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Room Info")]
		private Text _roomIndex;

		// Token: 0x0400B3A6 RID: 45990
		[Token(Token = "0x400B3A6")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Room Info")]
		private Text _comfort;

		// Token: 0x0400B3A7 RID: 45991
		[Token(Token = "0x400B3A7")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Room Info")]
		private Text _ap;

		// Token: 0x0400B3A8 RID: 45992
		[Token(Token = "0x400B3A8")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("Room Info")]
		private Text _apBuff;

		// Token: 0x0400B3A9 RID: 45993
		[Token(Token = "0x400B3A9")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Room Info")]
		private BuildingSMRoomInfoList _charInfoList;

		// Token: 0x0400B3AA RID: 45994
		[Token(Token = "0x400B3AA")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Edit Lock")]
		private GameObject _bottomBatchGroup;

		// Token: 0x0400B3AB RID: 45995
		[Token(Token = "0x400B3AB")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Batch")]
		private GameObject _batchBtnActive;

		// Token: 0x0400B3AC RID: 45996
		[Token(Token = "0x400B3AC")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Batch")]
		private GameObject _batchBtnInactive;

		// Token: 0x0400B3AD RID: 45997
		[Token(Token = "0x400B3AD")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Group("Batch")]
		private Text _tiredText;

		// Token: 0x0400B3AE RID: 45998
		[Token(Token = "0x400B3AE")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Group("Batch")]
		private Text _notFullext;

		// Token: 0x0400B3AF RID: 45999
		[Token(Token = "0x400B3AF")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Group("Batch")]
		private GameObject _editLockBtn;

		// Token: 0x0400B3B0 RID: 46000
		[Token(Token = "0x400B3B0")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Group("Edit Lock")]
		private CanvasGroup _editLockBkg;

		// Token: 0x0400B3B1 RID: 46001
		[Token(Token = "0x400B3B1")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		[Group("Edit Lock")]
		private CanvasGroup _editLockPanel;

		// Token: 0x0400B3B2 RID: 46002
		[Token(Token = "0x400B3B2")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		[Group("Edit Lock")]
		private Text _lockNumText;

		// Token: 0x0400B3B3 RID: 46003
		[Token(Token = "0x400B3B3")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		[Group("Edit Lock")]
		private GameObject _enterEditTrackPoint;

		// Token: 0x0400B3B4 RID: 46004
		[Token(Token = "0x400B3B4")]
		[FieldOffset(Offset = "0xC0")]
		private UIStateFinder m_stateFinder;

		// Token: 0x0400B3B5 RID: 46005
		[Token(Token = "0x400B3B5")]
		[FieldOffset(Offset = "0xD0")]
		private bool m_isInited;

		// Token: 0x0400B3B6 RID: 46006
		[Token(Token = "0x400B3B6")]
		[FieldOffset(Offset = "0xD8")]
		private FadeSwitchTween m_lockBkgTween;

		// Token: 0x0400B3B7 RID: 46007
		[Token(Token = "0x400B3B7")]
		[FieldOffset(Offset = "0xE0")]
		private FadeSwitchTween m_lockGroupTween;

		// Token: 0x0400B3B8 RID: 46008
		[Token(Token = "0x400B3B8")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0400B3B9 RID: 46009
		[Token(Token = "0x400B3B9")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnBatchActiveClicked;

		// Token: 0x0400B3BA RID: 46010
		[Token(Token = "0x400B3BA")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnBatchInactiveClicked;

		// Token: 0x0400B3BB RID: 46011
		[Token(Token = "0x400B3BB")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B3BC RID: 46012
		[Token(Token = "0x400B3BC")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
