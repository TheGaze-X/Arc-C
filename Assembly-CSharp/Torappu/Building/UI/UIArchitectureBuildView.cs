using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Building.UI
{
	// Token: 0x02001B4A RID: 6986
	[Token(Token = "0x2001B4A")]
	public class UIArchitectureBuildView : UIArchitectureBaseView<UIArchitectureBuildView.Argument>
	{
		// Token: 0x170014D2 RID: 5330
		// (get) Token: 0x0600AF92 RID: 44946 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014D2")]
		public RoomSlotModel.RoomPanelInfo currentRoomPanelInfo
		{
			[Token(Token = "0x600AF92")]
			[Address(RVA = "0x32B5170", Offset = "0x32B3D70", VA = "0x1832B5170")]
			get
			{
				return null;
			}
		}

		// Token: 0x170014D3 RID: 5331
		// (get) Token: 0x0600AF93 RID: 44947 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170014D3")]
		public UIArchitectureBuildRoomPanel currentRoomPanel
		{
			[Token(Token = "0x600AF93")]
			[Address(RVA = "0x32B5210", Offset = "0x32B3E10", VA = "0x1832B5210")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600AF94 RID: 44948 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AF94")]
		[Address(RVA = "0x32B40E0", Offset = "0x32B2CE0", VA = "0x1832B40E0")]
		private UIRoomIconSpriteHub _GetIconSpriteHub()
		{
			return null;
		}

		// Token: 0x0600AF95 RID: 44949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF95")]
		[Address(RVA = "0x32B4250", Offset = "0x32B2E50", VA = "0x1832B4250")]
		private void _SetupPanel(GameObject inst, string slotId, BuildingData.RoomData roomData, RoomLevelConditionCheckingResult checkingResult)
		{
		}

		// Token: 0x0600AF96 RID: 44950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF96")]
		[Address(RVA = "0x32B3CB0", Offset = "0x32B28B0", VA = "0x1832B3CB0")]
		private void SetRoomListLocateIndex(int index, bool easeMove)
		{
		}

		// Token: 0x0600AF97 RID: 44951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF97")]
		[Address(RVA = "0x32B3450", Offset = "0x32B2050", VA = "0x1832B3450", Slot = "14")]
		protected override void DoSetup(UIArchitectureBuildView.Argument arg)
		{
		}

		// Token: 0x0600AF98 RID: 44952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF98")]
		[Address(RVA = "0x32B3A90", Offset = "0x32B2690", VA = "0x1832B3A90")]
		public void OnLeftButtonPressed()
		{
		}

		// Token: 0x0600AF99 RID: 44953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF99")]
		[Address(RVA = "0x32B3C40", Offset = "0x32B2840", VA = "0x1832B3C40")]
		public void OnRightButtonPressed()
		{
		}

		// Token: 0x0600AF9A RID: 44954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF9A")]
		[Address(RVA = "0x32B3B00", Offset = "0x32B2700", VA = "0x1832B3B00", Slot = "15")]
		protected override void OnPlayerDataChanged(object _)
		{
		}

		// Token: 0x0600AF9B RID: 44955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AF9B")]
		[Address(RVA = "0x32B5010", Offset = "0x32B3C10", VA = "0x1832B5010")]
		public UIArchitectureBuildView()
		{
		}

		// Token: 0x0400A95F RID: 43359
		[Token(Token = "0x400A95F")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _roomPanelProtoElectric;

		// Token: 0x0400A960 RID: 43360
		[Token(Token = "0x400A960")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private RectTransform _listRoot;

		// Token: 0x0400A961 RID: 43361
		[Token(Token = "0x400A961")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private UIArchitectureRoomListLocator _locator;

		// Token: 0x0400A962 RID: 43362
		[Token(Token = "0x400A962")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		private GameObject _leftButton;

		// Token: 0x0400A963 RID: 43363
		[Token(Token = "0x400A963")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		private GameObject _rightButton;

		// Token: 0x0400A964 RID: 43364
		[Token(Token = "0x400A964")]
		[FieldOffset(Offset = "0x70")]
		private UIRoomIconSpriteHub m_roomIconSpriteHub;

		// Token: 0x0400A965 RID: 43365
		[Token(Token = "0x400A965")]
		[FieldOffset(Offset = "0x78")]
		private List<RoomSlotModel.RoomPanelInfo> m_roomPanelInfos;

		// Token: 0x0400A966 RID: 43366
		[Token(Token = "0x400A966")]
		[FieldOffset(Offset = "0x80")]
		private List<UIArchitectureBuildRoomPanel> m_roomPanels;

		// Token: 0x0400A967 RID: 43367
		[Token(Token = "0x400A967")]
		[FieldOffset(Offset = "0x88")]
		private BuildingLaborViewModel m_laborModel;

		// Token: 0x0400A968 RID: 43368
		[Token(Token = "0x400A968")]
		[FieldOffset(Offset = "0x90")]
		private int m_curIndex;

		// Token: 0x0400A969 RID: 43369
		[Token(Token = "0x400A969")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_currentRoomPanelInfo;

		// Token: 0x0400A96A RID: 43370
		[Token(Token = "0x400A96A")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_currentRoomPanel;

		// Token: 0x0400A96B RID: 43371
		[Token(Token = "0x400A96B")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__GetIconSpriteHub;

		// Token: 0x0400A96C RID: 43372
		[Token(Token = "0x400A96C")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__SetupPanel;

		// Token: 0x0400A96D RID: 43373
		[Token(Token = "0x400A96D")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_SetRoomListLocateIndex;

		// Token: 0x0400A96E RID: 43374
		[Token(Token = "0x400A96E")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_DoSetup;

		// Token: 0x0400A96F RID: 43375
		[Token(Token = "0x400A96F")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnLeftButtonPressed;

		// Token: 0x0400A970 RID: 43376
		[Token(Token = "0x400A970")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnRightButtonPressed;

		// Token: 0x0400A971 RID: 43377
		[Token(Token = "0x400A971")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnPlayerDataChanged;

		// Token: 0x0400A972 RID: 43378
		[Token(Token = "0x400A972")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001B4B RID: 6987
		[Token(Token = "0x2001B4B")]
		public class Argument
		{
			// Token: 0x0600AF9C RID: 44956 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600AF9C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public Argument()
			{
			}

			// Token: 0x0400A973 RID: 43379
			[Token(Token = "0x400A973")]
			[FieldOffset(Offset = "0x10")]
			public RoomSlotModel slotModel;
		}
	}
}
