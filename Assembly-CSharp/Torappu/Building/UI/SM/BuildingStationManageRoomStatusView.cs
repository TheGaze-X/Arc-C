using System;
using System.Collections.Generic;
using AdvancedInspector;
using Il2CppDummyDll;
using Torappu.DataBind;
using Torappu.UI;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.UI.SM
{
	// Token: 0x02001CD3 RID: 7379
	[Token(Token = "0x2001CD3")]
	public class BuildingStationManageRoomStatusView : DataBinder<StationManageEditQueueViewProp>, IHotfixable
	{
		// Token: 0x170015EC RID: 5612
		// (get) Token: 0x0600B6A6 RID: 46758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170015EC")]
		public BuildingCharSelectRoomConfig roomConfig
		{
			[Token(Token = "0x600B6A6")]
			[Address(RVA = "0x334A640", Offset = "0x3349240", VA = "0x18334A640")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600B6A7 RID: 46759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6A7")]
		[Address(RVA = "0x3349D60", Offset = "0x3348960", VA = "0x183349D60")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0600B6A8 RID: 46760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6A8")]
		[Address(RVA = "0x33481A0", Offset = "0x3346DA0", VA = "0x1833481A0", Slot = "7")]
		public override void OnValueChanged(StationManageEditQueueViewProp property)
		{
		}

		// Token: 0x0600B6A9 RID: 46761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6A9")]
		[Address(RVA = "0x33488E0", Offset = "0x33474E0", VA = "0x1833488E0")]
		public void ScrollToFirst()
		{
		}

		// Token: 0x0600B6AA RID: 46762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B6AA")]
		[Address(RVA = "0x3349BF0", Offset = "0x33487F0", VA = "0x183349BF0")]
		private BuildingStationManageRoomStatusView.RoomStyle _GetCurRoomStyle()
		{
			return null;
		}

		// Token: 0x0600B6AB RID: 46763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6AB")]
		[Address(RVA = "0x3349ED0", Offset = "0x3348AD0", VA = "0x183349ED0")]
		private void _LoadPreQueue(BuildingStationManageRoomStatusView.RoomStyle roomStyle)
		{
		}

		// Token: 0x0600B6AC RID: 46764 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600B6AC")]
		[Address(RVA = "0x33489A0", Offset = "0x33475A0", VA = "0x1833489A0")]
		private BuildingStationManageRoomPreQueueEditView _CreateNewQueueItem()
		{
			return null;
		}

		// Token: 0x0600B6AD RID: 46765 RVA: 0x00044F70 File Offset: 0x00043170
		[Token(Token = "0x600B6AD")]
		[Address(RVA = "0x3349600", Offset = "0x3348200", VA = "0x183349600")]
		private StationManageEditRoomQueueStructModel _GenQueueStructModel(BuildingStationManageRoomStatusView.RoomStyle roomStyle, bool isUpdateByMsg)
		{
			return default(StationManageEditRoomQueueStructModel);
		}

		// Token: 0x0600B6AE RID: 46766 RVA: 0x00044F88 File Offset: 0x00043188
		[Token(Token = "0x600B6AE")]
		[Address(RVA = "0x3348F10", Offset = "0x3347B10", VA = "0x183348F10")]
		private StationManageEditRoomQueueStructModel _GenQueueStructModelByPreQueue(RoomSlotModel roomSlotModel, List<int> preQueueList, BuildingStationManageRoomStatusView.RoomStyle roomStyle)
		{
			return default(StationManageEditRoomQueueStructModel);
		}

		// Token: 0x0600B6AF RID: 46767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6AF")]
		[Address(RVA = "0x334A4B0", Offset = "0x33490B0", VA = "0x18334A4B0")]
		private void _UpdateRoomByRoomType()
		{
		}

		// Token: 0x0600B6B0 RID: 46768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6B0")]
		[Address(RVA = "0x3348040", Offset = "0x3346C40", VA = "0x183348040")]
		public void EventOnAddPreQueueClicked()
		{
		}

		// Token: 0x0600B6B1 RID: 46769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6B1")]
		[Address(RVA = "0x3348AB0", Offset = "0x33476B0", VA = "0x183348AB0")]
		private void _EventOnApplyQueueClicked(int preQueueIndex)
		{
		}

		// Token: 0x0600B6B2 RID: 46770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6B2")]
		[Address(RVA = "0x3348CA0", Offset = "0x33478A0", VA = "0x183348CA0")]
		private void _EventOnDeleteQueueClicked(int preQueueIndex)
		{
		}

		// Token: 0x0600B6B3 RID: 46771 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600B6B3")]
		[Address(RVA = "0x334A5D0", Offset = "0x33491D0", VA = "0x18334A5D0")]
		public BuildingStationManageRoomStatusView()
		{
		}

		// Token: 0x0400B411 RID: 46097
		[Token(Token = "0x400B411")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private UIColorGraphic _mainColorComp;

		// Token: 0x0400B412 RID: 46098
		[Token(Token = "0x400B412")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BuildingStationManageRoomStatusView.RoomStyle[] _roomStyles;

		// Token: 0x0400B413 RID: 46099
		[Token(Token = "0x400B413")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Text _textRoomName;

		// Token: 0x0400B414 RID: 46100
		[Token(Token = "0x400B414")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Text _textRoomNameIndex;

		// Token: 0x0400B415 RID: 46101
		[Token(Token = "0x400B415")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _panelOrderTarget;

		// Token: 0x0400B416 RID: 46102
		[Token(Token = "0x400B416")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Text _textOrderTarget;

		// Token: 0x0400B417 RID: 46103
		[Token(Token = "0x400B417")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private GameObject _iconRoomStopped;

		// Token: 0x0400B418 RID: 46104
		[Token(Token = "0x400B418")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private Text _textRoomIndex;

		// Token: 0x0400B419 RID: 46105
		[Token(Token = "0x400B419")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private BuildingStationManageRoomQueueView _queueView;

		// Token: 0x0400B41A RID: 46106
		[Token(Token = "0x400B41A")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("Pre Queue Edit")]
		private BuildingStationManageRoomPreQueueEditView _queueEditViewPrefab;

		// Token: 0x0400B41B RID: 46107
		[Token(Token = "0x400B41B")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		[Group("Pre Queue Edit")]
		private Text _textQueueCount;

		// Token: 0x0400B41C RID: 46108
		[Token(Token = "0x400B41C")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		[Group("Pre Queue Edit")]
		private Transform _queueEditItemHolder;

		// Token: 0x0400B41D RID: 46109
		[Token(Token = "0x400B41D")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Group("Pre Queue Edit")]
		private ScrollRect _preQueueScrollRect;

		// Token: 0x0400B41E RID: 46110
		[Token(Token = "0x400B41E")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		private GameObject _panelAddPreQueue;

		// Token: 0x0400B41F RID: 46111
		[Token(Token = "0x400B41F")]
		[FieldOffset(Offset = "0x90")]
		[NonSerialized]
		public Action<BuildingCharModel, object> onQueueCharClicked;

		// Token: 0x0400B420 RID: 46112
		[Token(Token = "0x400B420")]
		[FieldOffset(Offset = "0x98")]
		[NonSerialized]
		public Action<BuildingCharModel, object> onPreQueueCharClicked;

		// Token: 0x0400B421 RID: 46113
		[Token(Token = "0x400B421")]
		[FieldOffset(Offset = "0xA0")]
		[NonSerialized]
		public Action<RoomSlotModel, int> onApplyPreQueueClicked;

		// Token: 0x0400B422 RID: 46114
		[Token(Token = "0x400B422")]
		[FieldOffset(Offset = "0xA8")]
		private bool m_isInited;

		// Token: 0x0400B423 RID: 46115
		[Token(Token = "0x400B423")]
		[FieldOffset(Offset = "0xB0")]
		private List<BuildingStationManageRoomPreQueueEditView> m_queueEditItems;

		// Token: 0x0400B424 RID: 46116
		[Token(Token = "0x400B424")]
		[FieldOffset(Offset = "0xB8")]
		private RoomSlotModel m_curRoomSlotModel;

		// Token: 0x0400B425 RID: 46117
		[Token(Token = "0x400B425")]
		[FieldOffset(Offset = "0xC0")]
		private BuildingModel m_curBuildingModel;

		// Token: 0x0400B426 RID: 46118
		[Token(Token = "0x400B426")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_roomConfig;

		// Token: 0x0400B427 RID: 46119
		[Token(Token = "0x400B427")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400B428 RID: 46120
		[Token(Token = "0x400B428")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnValueChanged;

		// Token: 0x0400B429 RID: 46121
		[Token(Token = "0x400B429")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_ScrollToFirst;

		// Token: 0x0400B42A RID: 46122
		[Token(Token = "0x400B42A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetCurRoomStyle;

		// Token: 0x0400B42B RID: 46123
		[Token(Token = "0x400B42B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__LoadPreQueue;

		// Token: 0x0400B42C RID: 46124
		[Token(Token = "0x400B42C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__CreateNewQueueItem;

		// Token: 0x0400B42D RID: 46125
		[Token(Token = "0x400B42D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0__GenQueueStructModel;

		// Token: 0x0400B42E RID: 46126
		[Token(Token = "0x400B42E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenQueueStructModelByPreQueue;

		// Token: 0x0400B42F RID: 46127
		[Token(Token = "0x400B42F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__UpdateRoomByRoomType;

		// Token: 0x0400B430 RID: 46128
		[Token(Token = "0x400B430")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_EventOnAddPreQueueClicked;

		// Token: 0x0400B431 RID: 46129
		[Token(Token = "0x400B431")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__EventOnApplyQueueClicked;

		// Token: 0x0400B432 RID: 46130
		[Token(Token = "0x400B432")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0__EventOnDeleteQueueClicked;

		// Token: 0x0400B433 RID: 46131
		[Token(Token = "0x400B433")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001CD4 RID: 7380
		[Token(Token = "0x2001CD4")]
		[Serializable]
		private class RoomStyle
		{
			// Token: 0x0600B6B4 RID: 46772 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600B6B4")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public RoomStyle()
			{
			}

			// Token: 0x0400B434 RID: 46132
			[Token(Token = "0x400B434")]
			[FieldOffset(Offset = "0x10")]
			public BuildingData.RoomType roomId;

			// Token: 0x0400B435 RID: 46133
			[Token(Token = "0x400B435")]
			[FieldOffset(Offset = "0x18")]
			public Sprite bkgImg;
		}
	}
}
