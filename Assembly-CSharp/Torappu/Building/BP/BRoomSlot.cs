using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Torappu.Building.BP
{
	// Token: 0x02001AA6 RID: 6822
	[Token(Token = "0x2001AA6")]
	[RequireComponent(typeof(RectTransform))]
	public class BRoomSlot : AbstractRoomSlot
	{
		// Token: 0x17001460 RID: 5216
		// (get) Token: 0x0600AC1A RID: 44058 RVA: 0x00042810 File Offset: 0x00040A10
		// (set) Token: 0x0600AC1B RID: 44059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001460")]
		public override bool isOn
		{
			[Token(Token = "0x600AC1A")]
			[Address(RVA = "0x6DF210", Offset = "0x6DDE10", VA = "0x1806DF210", Slot = "7")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600AC1B")]
			[Address(RVA = "0x3276480", Offset = "0x3275080", VA = "0x183276480", Slot = "8")]
			set
			{
			}
		}

		// Token: 0x17001461 RID: 5217
		// (get) Token: 0x0600AC1C RID: 44060 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001461")]
		public RectTransform rectTrans
		{
			[Token(Token = "0x600AC1C")]
			[Address(RVA = "0x32763E0", Offset = "0x3274FE0", VA = "0x1832763E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001462 RID: 5218
		// (get) Token: 0x0600AC1D RID: 44061 RVA: 0x00042828 File Offset: 0x00040A28
		[Token(Token = "0x17001462")]
		public Vector2 center
		{
			[Token(Token = "0x600AC1D")]
			[Address(RVA = "0x3276350", Offset = "0x3274F50", VA = "0x183276350")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x17001463 RID: 5219
		// (get) Token: 0x0600AC1E RID: 44062 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AC1F RID: 44063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001463")]
		public BLayoutManager layout
		{
			[Token(Token = "0x600AC1E")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600AC1F")]
			[Address(RVA = "0xEDF350", Offset = "0xEDDF50", VA = "0x180EDF350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600AC20 RID: 44064 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC20")]
		[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
		public BRoom BLayoutManager_GetRoom()
		{
			return null;
		}

		// Token: 0x0600AC21 RID: 44065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC21")]
		[Address(RVA = "0x3275300", Offset = "0x3273F00", VA = "0x183275300")]
		public void Init(RoomSlotModel model, BLayoutManager layout)
		{
		}

		// Token: 0x0600AC22 RID: 44066 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC22")]
		[Address(RVA = "0x3275360", Offset = "0x3273F60", VA = "0x183275360", Slot = "12")]
		public override void OnContentChange(RoomSlotModel model)
		{
		}

		// Token: 0x0600AC23 RID: 44067 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC23")]
		[Address(RVA = "0x32755F0", Offset = "0x32741F0", VA = "0x1832755F0", Slot = "13")]
		public override void OnPostLayoutContentChanged()
		{
		}

		// Token: 0x0600AC24 RID: 44068 RVA: 0x00042840 File Offset: 0x00040A40
		[Token(Token = "0x600AC24")]
		[Address(RVA = "0x3275770", Offset = "0x3274370", VA = "0x183275770")]
		public bool OverrideRoomClickedNormalMode()
		{
			return default(bool);
		}

		// Token: 0x0600AC25 RID: 44069 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC25")]
		[Address(RVA = "0x3275670", Offset = "0x3274270", VA = "0x183275670")]
		public void OnRoomClick(PointerEventData eventData)
		{
		}

		// Token: 0x0600AC26 RID: 44070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC26")]
		[Address(RVA = "0x3275270", Offset = "0x3273E70", VA = "0x183275270")]
		public void ActiveArchitecture(bool active)
		{
		}

		// Token: 0x0600AC27 RID: 44071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AC27")]
		[Address(RVA = "0x3275080", Offset = "0x3273C80", VA = "0x183275080")]
		public Button AVGOnly_RegisterTutorialBtn()
		{
			return null;
		}

		// Token: 0x0600AC28 RID: 44072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC28")]
		[Address(RVA = "0x3275410", Offset = "0x3274010", VA = "0x183275410", Slot = "10")]
		protected override void OnInit()
		{
		}

		// Token: 0x0600AC29 RID: 44073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC29")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "14")]
		protected virtual void OnSelect()
		{
		}

		// Token: 0x0600AC2A RID: 44074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC2A")]
		[Address(RVA = "0x4F7A70", Offset = "0x4F6670", VA = "0x1804F7A70", Slot = "15")]
		protected virtual void OnDeselect()
		{
		}

		// Token: 0x0600AC2B RID: 44075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC2B")]
		[Address(RVA = "0x3275400", Offset = "0x3274000", VA = "0x183275400", Slot = "16")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x0600AC2C RID: 44076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC2C")]
		[Address(RVA = "0x3275AE0", Offset = "0x32746E0", VA = "0x183275AE0")]
		private void _UpdateContent(RoomSlotModel model)
		{
		}

		// Token: 0x0600AC2D RID: 44077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC2D")]
		[Address(RVA = "0x32759D0", Offset = "0x32745D0", VA = "0x1832759D0")]
		private void _SetOnInternal(bool isOn)
		{
		}

		// Token: 0x0600AC2E RID: 44078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC2E")]
		[Address(RVA = "0x3275A50", Offset = "0x3274650", VA = "0x183275A50")]
		private void _SetupUpdatePanel(RoomSlotModel slotModel)
		{
		}

		// Token: 0x0600AC2F RID: 44079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC2F")]
		[Address(RVA = "0x32759A0", Offset = "0x32745A0", VA = "0x1832759A0")]
		public void _OnUpgradeComplete()
		{
		}

		// Token: 0x0600AC30 RID: 44080 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC30")]
		[Address(RVA = "0x32758B0", Offset = "0x32744B0", VA = "0x1832758B0")]
		private void _ClearRoom()
		{
		}

		// Token: 0x0600AC31 RID: 44081 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AC31")]
		[Address(RVA = "0x5B5830", Offset = "0x5B4430", VA = "0x1805B5830")]
		public BRoomSlot()
		{
		}

		// Token: 0x0400A449 RID: 42057
		[Token(Token = "0x400A449")]
		private const string NAME_DUMMY_TUTORIAL_BTN = "broom_tutorial_btn";

		// Token: 0x0400A44A RID: 42058
		[Token(Token = "0x400A44A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _roomContainer;

		// Token: 0x0400A44B RID: 42059
		[Token(Token = "0x400A44B")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private GameObject _selectEffect;

		// Token: 0x0400A44C RID: 42060
		[Token(Token = "0x400A44C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private BUpgradePanel _upgradePanel;

		// Token: 0x0400A44D RID: 42061
		[Token(Token = "0x400A44D")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _tutorialBtnPrefab;

		// Token: 0x0400A44E RID: 42062
		[Token(Token = "0x400A44E")]
		[FieldOffset(Offset = "0x40")]
		private BRoom m_room;

		// Token: 0x0400A44F RID: 42063
		[Token(Token = "0x400A44F")]
		[FieldOffset(Offset = "0x48")]
		private Action<object> m_roomPlayerChangedListener;

		// Token: 0x0400A450 RID: 42064
		[Token(Token = "0x400A450")]
		[FieldOffset(Offset = "0x50")]
		private RectTransform m_rectTransform;

		// Token: 0x0400A451 RID: 42065
		[Token(Token = "0x400A451")]
		[FieldOffset(Offset = "0x58")]
		private bool m_isOn;

		// Token: 0x0400A452 RID: 42066
		[Token(Token = "0x400A452")]
		[FieldOffset(Offset = "0x60")]
		private string m_cachedPrefabId;

		// Token: 0x0400A453 RID: 42067
		[Token(Token = "0x400A453")]
		[FieldOffset(Offset = "0x68")]
		private bool m_archActiveCache;

		// Token: 0x0400A454 RID: 42068
		[Token(Token = "0x400A454")]
		[FieldOffset(Offset = "0x70")]
		private Button m_dummyTutorialBtn;
	}
}
