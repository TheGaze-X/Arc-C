using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A6B RID: 6763
	[Token(Token = "0x2001A6B")]
	public class VLayoutManager : MonoBehaviour, IHotfixable
	{
		// Token: 0x1700140A RID: 5130
		// (get) Token: 0x0600AA5E RID: 43614 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AA5F RID: 43615 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700140A")]
		public VRoomSlot selectedRoom
		{
			[Token(Token = "0x600AA5E")]
			[Address(RVA = "0x32642D0", Offset = "0x3262ED0", VA = "0x1832642D0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600AA5F")]
			[Address(RVA = "0x3264520", Offset = "0x3263120", VA = "0x183264520")]
			set
			{
			}
		}

		// Token: 0x1700140B RID: 5131
		// (get) Token: 0x0600AA60 RID: 43616 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700140B")]
		public Transform roomContainer
		{
			[Token(Token = "0x600AA60")]
			[Address(RVA = "0x3264090", Offset = "0x3262C90", VA = "0x183264090")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700140C RID: 5132
		// (get) Token: 0x0600AA61 RID: 43617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700140C")]
		public List<VRoomSlot> rooms
		{
			[Token(Token = "0x600AA61")]
			[Address(RVA = "0x32640F0", Offset = "0x3262CF0", VA = "0x1832640F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700140D RID: 5133
		// (get) Token: 0x0600AA62 RID: 43618 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600AA63 RID: 43619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700140D")]
		public VRoom.Object selectedObject
		{
			[Token(Token = "0x600AA62")]
			[Address(RVA = "0x3264270", Offset = "0x3262E70", VA = "0x183264270")]
			get
			{
				return null;
			}
			[Token(Token = "0x600AA63")]
			[Address(RVA = "0x32643B0", Offset = "0x3262FB0", VA = "0x1832643B0")]
			set
			{
			}
		}

		// Token: 0x1700140E RID: 5134
		// (get) Token: 0x0600AA64 RID: 43620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700140E")]
		public VCharacter selectedCharacter
		{
			[Token(Token = "0x600AA64")]
			[Address(RVA = "0x3264150", Offset = "0x3262D50", VA = "0x183264150")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700140F RID: 5135
		// (get) Token: 0x0600AA65 RID: 43621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700140F")]
		public BaseRaycaster raycster
		{
			[Token(Token = "0x600AA65")]
			[Address(RVA = "0x3264030", Offset = "0x3262C30", VA = "0x183264030")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001410 RID: 5136
		// (get) Token: 0x0600AA66 RID: 43622 RVA: 0x00041F88 File Offset: 0x00040188
		// (set) Token: 0x0600AA67 RID: 43623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001410")]
		public Rect visibleRect
		{
			[Token(Token = "0x600AA66")]
			[Address(RVA = "0x3264330", Offset = "0x3262F30", VA = "0x183264330")]
			[CompilerGenerated]
			get
			{
				return default(Rect);
			}
			[Token(Token = "0x600AA67")]
			[Address(RVA = "0x3264700", Offset = "0x3263300", VA = "0x183264700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600AA68 RID: 43624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA68")]
		[Address(RVA = "0x3262230", Offset = "0x3260E30", VA = "0x183262230")]
		public void Init(List<RoomSlotModel> layout, VaultMode state)
		{
		}

		// Token: 0x0600AA69 RID: 43625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA69")]
		[Address(RVA = "0x3262A80", Offset = "0x3261680", VA = "0x183262A80")]
		public void OnEnter()
		{
		}

		// Token: 0x0600AA6A RID: 43626 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA6A")]
		[Address(RVA = "0x3262B70", Offset = "0x3261770", VA = "0x183262B70")]
		public void OnExit()
		{
		}

		// Token: 0x0600AA6B RID: 43627 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA6B")]
		[Address(RVA = "0x32631D0", Offset = "0x3261DD0", VA = "0x1832631D0")]
		public void StopAllMusicInteractFurniture()
		{
		}

		// Token: 0x0600AA6C RID: 43628 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA6C")]
		[Address(RVA = "0x3262D90", Offset = "0x3261990", VA = "0x183262D90")]
		public void OnRoomClicked(VRoomSlot room, bool willFocus)
		{
		}

		// Token: 0x0600AA6D RID: 43629 RVA: 0x00041FA0 File Offset: 0x000401A0
		[Token(Token = "0x600AA6D")]
		[Address(RVA = "0x3263360", Offset = "0x3261F60", VA = "0x183263360")]
		public bool TryGetRoomByModel(RoomSlotModel model, out VRoomSlot value)
		{
			return default(bool);
		}

		// Token: 0x0600AA6E RID: 43630 RVA: 0x00041FB8 File Offset: 0x000401B8
		[Token(Token = "0x600AA6E")]
		[Address(RVA = "0x3261F00", Offset = "0x3260B00", VA = "0x183261F00")]
		public Rect GetVisibleRect()
		{
			return default(Rect);
		}

		// Token: 0x0600AA6F RID: 43631 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA6F")]
		[Address(RVA = "0x3262C40", Offset = "0x3261840", VA = "0x183262C40")]
		public void OnFixedUpdate(float deltaTime)
		{
		}

		// Token: 0x0600AA70 RID: 43632 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA70")]
		[Address(RVA = "0x3263B20", Offset = "0x3262720", VA = "0x183263B20")]
		private void _OnLayoutUpdate()
		{
		}

		// Token: 0x0600AA71 RID: 43633 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA71")]
		[Address(RVA = "0x3263AB0", Offset = "0x32626B0", VA = "0x183263AB0")]
		private void _OnLayoutDragOrPinch()
		{
		}

		// Token: 0x0600AA72 RID: 43634 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA72")]
		[Address(RVA = "0x3263E50", Offset = "0x3262A50", VA = "0x183263E50")]
		private void _OnLayoutZoomUpdate(float oldSize, float newSize)
		{
		}

		// Token: 0x0600AA73 RID: 43635 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600AA73")]
		[Address(RVA = "0x3263510", Offset = "0x3262110", VA = "0x183263510")]
		private VRoomSlot _CreateRoomSlot(RoomSlotModel model)
		{
			return null;
		}

		// Token: 0x0600AA74 RID: 43636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA74")]
		[Address(RVA = "0x32635F0", Offset = "0x32621F0", VA = "0x1832635F0")]
		private void _InitLayout(List<RoomSlotModel> layout)
		{
		}

		// Token: 0x0600AA75 RID: 43637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA75")]
		[Address(RVA = "0x3263410", Offset = "0x3262010", VA = "0x183263410")]
		private void _ClearAll()
		{
		}

		// Token: 0x0600AA76 RID: 43638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA76")]
		[Address(RVA = "0x3263050", Offset = "0x3261C50", VA = "0x183263050")]
		private void Start()
		{
		}

		// Token: 0x0600AA77 RID: 43639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA77")]
		[Address(RVA = "0x32628E0", Offset = "0x32614E0", VA = "0x1832628E0")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600AA78 RID: 43640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600AA78")]
		[Address(RVA = "0x3263F00", Offset = "0x3262B00", VA = "0x183263F00")]
		public VLayoutManager()
		{
		}

		// Token: 0x0400A29C RID: 41628
		[Token(Token = "0x400A29C")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Transform _viewport;

		// Token: 0x0400A29D RID: 41629
		[Token(Token = "0x400A29D")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Transform _container;

		// Token: 0x0400A29E RID: 41630
		[Token(Token = "0x400A29E")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private VWallGenerator _wallGenerator;

		// Token: 0x0400A29F RID: 41631
		[Token(Token = "0x400A29F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private VRoomSlot _roomSlot;

		// Token: 0x0400A2A0 RID: 41632
		[Token(Token = "0x400A2A0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private BaseRaycaster _raycaster;

		// Token: 0x0400A2A1 RID: 41633
		[Token(Token = "0x400A2A1")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private float _paddingX;

		// Token: 0x0400A2A2 RID: 41634
		[Token(Token = "0x400A2A2")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _paddingY;

		// Token: 0x0400A2A3 RID: 41635
		[Token(Token = "0x400A2A3")]
		[FieldOffset(Offset = "0x48")]
		private VaultMode m_state;

		// Token: 0x0400A2A4 RID: 41636
		[Token(Token = "0x400A2A4")]
		[FieldOffset(Offset = "0x50")]
		private List<VRoomSlot> m_rooms;

		// Token: 0x0400A2A5 RID: 41637
		[Token(Token = "0x400A2A5")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<RoomSlotModel, VRoomSlot> m_modelToRoomMap;

		// Token: 0x0400A2A6 RID: 41638
		[Token(Token = "0x400A2A6")]
		[FieldOffset(Offset = "0x60")]
		private VRoomSlot m_currentSelectedRoom;

		// Token: 0x0400A2A7 RID: 41639
		[Token(Token = "0x400A2A7")]
		[FieldOffset(Offset = "0x68")]
		private VRoom.Object m_currentSelectedObject;

		// Token: 0x0400A2A8 RID: 41640
		[Token(Token = "0x400A2A8")]
		[FieldOffset(Offset = "0x70")]
		private Vector3[] m_frustumCorners;

		// Token: 0x0400A2AA RID: 41642
		[Token(Token = "0x400A2AA")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedRoom;

		// Token: 0x0400A2AB RID: 41643
		[Token(Token = "0x400A2AB")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_set_selectedRoom;

		// Token: 0x0400A2AC RID: 41644
		[Token(Token = "0x400A2AC")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_roomContainer;

		// Token: 0x0400A2AD RID: 41645
		[Token(Token = "0x400A2AD")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_rooms;

		// Token: 0x0400A2AE RID: 41646
		[Token(Token = "0x400A2AE")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selectedObject;

		// Token: 0x0400A2AF RID: 41647
		[Token(Token = "0x400A2AF")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_set_selectedObject;

		// Token: 0x0400A2B0 RID: 41648
		[Token(Token = "0x400A2B0")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_selectedCharacter;

		// Token: 0x0400A2B1 RID: 41649
		[Token(Token = "0x400A2B1")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_raycster;

		// Token: 0x0400A2B2 RID: 41650
		[Token(Token = "0x400A2B2")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_visibleRect;

		// Token: 0x0400A2B3 RID: 41651
		[Token(Token = "0x400A2B3")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_visibleRect;

		// Token: 0x0400A2B4 RID: 41652
		[Token(Token = "0x400A2B4")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0400A2B5 RID: 41653
		[Token(Token = "0x400A2B5")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400A2B6 RID: 41654
		[Token(Token = "0x400A2B6")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0400A2B7 RID: 41655
		[Token(Token = "0x400A2B7")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_StopAllMusicInteractFurniture;

		// Token: 0x0400A2B8 RID: 41656
		[Token(Token = "0x400A2B8")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_OnRoomClicked;

		// Token: 0x0400A2B9 RID: 41657
		[Token(Token = "0x400A2B9")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_TryGetRoomByModel;

		// Token: 0x0400A2BA RID: 41658
		[Token(Token = "0x400A2BA")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_GetVisibleRect;

		// Token: 0x0400A2BB RID: 41659
		[Token(Token = "0x400A2BB")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_OnFixedUpdate;

		// Token: 0x0400A2BC RID: 41660
		[Token(Token = "0x400A2BC")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__OnLayoutUpdate;

		// Token: 0x0400A2BD RID: 41661
		[Token(Token = "0x400A2BD")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__OnLayoutDragOrPinch;

		// Token: 0x0400A2BE RID: 41662
		[Token(Token = "0x400A2BE")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__OnLayoutZoomUpdate;

		// Token: 0x0400A2BF RID: 41663
		[Token(Token = "0x400A2BF")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0__CreateRoomSlot;

		// Token: 0x0400A2C0 RID: 41664
		[Token(Token = "0x400A2C0")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__InitLayout;

		// Token: 0x0400A2C1 RID: 41665
		[Token(Token = "0x400A2C1")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__ClearAll;

		// Token: 0x0400A2C2 RID: 41666
		[Token(Token = "0x400A2C2")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400A2C3 RID: 41667
		[Token(Token = "0x400A2C3")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400A2C4 RID: 41668
		[Token(Token = "0x400A2C4")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
