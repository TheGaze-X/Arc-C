using System;
using System.Collections;
using Il2CppDummyDll;
using Torappu.Building.DIY;
using Torappu.GraphicEffect.Reflection;
using UnityEngine;
using XLua;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A58 RID: 6744
	[Token(Token = "0x2001A58")]
	public class VaultMode : BuildingMode<VaultMode>
	{
		// Token: 0x170013D9 RID: 5081
		// (get) Token: 0x0600A997 RID: 43415 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013D9")]
		public Camera camera
		{
			[Token(Token = "0x600A997")]
			[Address(RVA = "0x324EED0", Offset = "0x324DAD0", VA = "0x18324EED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013DA RID: 5082
		// (get) Token: 0x0600A998 RID: 43416 RVA: 0x00041AA8 File Offset: 0x0003FCA8
		// (set) Token: 0x0600A999 RID: 43417 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170013DA")]
		public override bool isRaycastBlocked
		{
			[Token(Token = "0x600A998")]
			[Address(RVA = "0x324EFD0", Offset = "0x324DBD0", VA = "0x18324EFD0", Slot = "19")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A999")]
			[Address(RVA = "0x324F330", Offset = "0x324DF30", VA = "0x18324F330", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x170013DB RID: 5083
		// (get) Token: 0x0600A99A RID: 43418 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013DB")]
		public Transform roomContainer
		{
			[Token(Token = "0x600A99A")]
			[Address(RVA = "0x324F0B0", Offset = "0x324DCB0", VA = "0x18324F0B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013DC RID: 5084
		// (get) Token: 0x0600A99B RID: 43419 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013DC")]
		public override RoomSlotModel selectedRoom
		{
			[Token(Token = "0x600A99B")]
			[Address(RVA = "0x324F1D0", Offset = "0x324DDD0", VA = "0x18324F1D0", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013DD RID: 5085
		// (get) Token: 0x0600A99C RID: 43420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013DD")]
		public VRoomSlot selectedRoomSlot
		{
			[Token(Token = "0x600A99C")]
			[Address(RVA = "0x324F120", Offset = "0x324DD20", VA = "0x18324F120")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013DE RID: 5086
		// (get) Token: 0x0600A99D RID: 43421 RVA: 0x00041AC0 File Offset: 0x0003FCC0
		[Token(Token = "0x170013DE")]
		public bool isActiveAndDisplayed
		{
			[Token(Token = "0x600A99D")]
			[Address(RVA = "0x324EF30", Offset = "0x324DB30", VA = "0x18324EF30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170013DF RID: 5087
		// (get) Token: 0x0600A99E RID: 43422 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013DF")]
		public VLayoutManager layout
		{
			[Token(Token = "0x600A99E")]
			[Address(RVA = "0x324F050", Offset = "0x324DC50", VA = "0x18324F050")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600A99F RID: 43423 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A99F")]
		[Address(RVA = "0x324E410", Offset = "0x324D010", VA = "0x18324E410", Slot = "22")]
		protected override void OnRegister()
		{
		}

		// Token: 0x0600A9A0 RID: 43424 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9A0")]
		[Address(RVA = "0x324E210", Offset = "0x324CE10", VA = "0x18324E210", Slot = "23")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x0600A9A1 RID: 43425 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9A1")]
		[Address(RVA = "0x324E370", Offset = "0x324CF70", VA = "0x18324E370", Slot = "25")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x0600A9A2 RID: 43426 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9A2")]
		[Address(RVA = "0x324E4C0", Offset = "0x324D0C0", VA = "0x18324E4C0", Slot = "24")]
		public override void OnTick(FP deltaTimeFp)
		{
		}

		// Token: 0x0600A9A3 RID: 43427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9A3")]
		[Address(RVA = "0x324E7D0", Offset = "0x324D3D0", VA = "0x18324E7D0")]
		public void StopAllMusicInteractFurniture()
		{
		}

		// Token: 0x0600A9A4 RID: 43428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9A4")]
		[Address(RVA = "0x324E5B0", Offset = "0x324D1B0", VA = "0x18324E5B0")]
		public void RegisterCharacter(VCharacter character)
		{
		}

		// Token: 0x0600A9A5 RID: 43429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9A5")]
		[Address(RVA = "0x324E8E0", Offset = "0x324D4E0", VA = "0x18324E8E0")]
		public void UnregisterCharacter(VCharacter character)
		{
		}

		// Token: 0x0600A9A6 RID: 43430 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A9A6")]
		[Address(RVA = "0x324E6E0", Offset = "0x324D2E0", VA = "0x18324E6E0", Slot = "27")]
		public override IEnumerator ShowCoroutine(BuildingStateMachine.TransitionParam param)
		{
			return null;
		}

		// Token: 0x0600A9A7 RID: 43431 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A9A7")]
		[Address(RVA = "0x324E130", Offset = "0x324CD30", VA = "0x18324E130", Slot = "28")]
		public override IEnumerator HideCoroutine(BuildingStateMachine.TransitionParam param)
		{
			return null;
		}

		// Token: 0x0600A9A8 RID: 43432 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9A8")]
		[Address(RVA = "0x324E960", Offset = "0x324D560", VA = "0x18324E960")]
		public void ZoomInToRoom(RoomSlotModel targetRoom)
		{
		}

		// Token: 0x0600A9A9 RID: 43433 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9A9")]
		[Address(RVA = "0x324E630", Offset = "0x324D230", VA = "0x18324E630")]
		public void SelectRoomWithoutFocus(RoomSlotModel targetRoom)
		{
		}

		// Token: 0x0600A9AA RID: 43434 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A9AA")]
		[Address(RVA = "0x324EA20", Offset = "0x324D620", VA = "0x18324EA20")]
		protected VaultReflectionConfigHolder _EnsureReflectConfig()
		{
			return null;
		}

		// Token: 0x0600A9AB RID: 43435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A9AB")]
		[Address(RVA = "0x324DF00", Offset = "0x324CB00", VA = "0x18324DF00")]
		public DIYRoom.IRefectionMaterialFilter GetRefectFilter()
		{
			return null;
		}

		// Token: 0x0600A9AC RID: 43436 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A9AC")]
		[Address(RVA = "0x324DFB0", Offset = "0x324CBB0", VA = "0x18324DFB0")]
		public ReflectCameraHolder GetReflectCameraHolder(VDIYRoom vRoom)
		{
			return null;
		}

		// Token: 0x0600A9AD RID: 43437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A9AD")]
		[Address(RVA = "0x324E080", Offset = "0x324CC80", VA = "0x18324E080")]
		public VRoomSlot GetRoom(RoomSlotModel slotModel)
		{
			return null;
		}

		// Token: 0x0600A9AE RID: 43438 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A9AE")]
		[Address(RVA = "0x324ED90", Offset = "0x324D990", VA = "0x18324ED90")]
		private IEnumerator _FocusRoomCoroutine(RoomSlotModel targetRoom)
		{
			return null;
		}

		// Token: 0x0600A9AF RID: 43439 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9AF")]
		[Address(RVA = "0x324DE40", Offset = "0x324CA40", VA = "0x18324DE40", Slot = "6")]
		protected override void Awake()
		{
		}

		// Token: 0x0600A9B0 RID: 43440 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9B0")]
		[Address(RVA = "0x324EE60", Offset = "0x324DA60", VA = "0x18324EE60")]
		public VaultMode()
		{
		}

		// Token: 0x0400A19E RID: 41374
		[Token(Token = "0x400A19E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private VLayoutManager _layout;

		// Token: 0x0400A19F RID: 41375
		[Token(Token = "0x400A19F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Camera _camera;

		// Token: 0x0400A1A0 RID: 41376
		[Token(Token = "0x400A1A0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _raycastBlocker;

		// Token: 0x0400A1A1 RID: 41377
		[Token(Token = "0x400A1A1")]
		[FieldOffset(Offset = "0x38")]
		private VCharacterManager m_characterMgr;

		// Token: 0x0400A1A2 RID: 41378
		[Token(Token = "0x400A1A2")]
		[FieldOffset(Offset = "0x40")]
		private VaultReflectionConfigHolder m_reflectConfig;

		// Token: 0x0400A1A3 RID: 41379
		[Token(Token = "0x400A1A3")]
		[FieldOffset(Offset = "0x48")]
		private bool m_isReflectConfigUnavailable;

		// Token: 0x0400A1A4 RID: 41380
		[Token(Token = "0x400A1A4")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_camera;

		// Token: 0x0400A1A5 RID: 41381
		[Token(Token = "0x400A1A5")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_isRaycastBlocked;

		// Token: 0x0400A1A6 RID: 41382
		[Token(Token = "0x400A1A6")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_isRaycastBlocked;

		// Token: 0x0400A1A7 RID: 41383
		[Token(Token = "0x400A1A7")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_roomContainer;

		// Token: 0x0400A1A8 RID: 41384
		[Token(Token = "0x400A1A8")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_selectedRoom;

		// Token: 0x0400A1A9 RID: 41385
		[Token(Token = "0x400A1A9")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_selectedRoomSlot;

		// Token: 0x0400A1AA RID: 41386
		[Token(Token = "0x400A1AA")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_isActiveAndDisplayed;

		// Token: 0x0400A1AB RID: 41387
		[Token(Token = "0x400A1AB")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_get_layout;

		// Token: 0x0400A1AC RID: 41388
		[Token(Token = "0x400A1AC")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_OnRegister;

		// Token: 0x0400A1AD RID: 41389
		[Token(Token = "0x400A1AD")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400A1AE RID: 41390
		[Token(Token = "0x400A1AE")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0400A1AF RID: 41391
		[Token(Token = "0x400A1AF")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnTick;

		// Token: 0x0400A1B0 RID: 41392
		[Token(Token = "0x400A1B0")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_StopAllMusicInteractFurniture;

		// Token: 0x0400A1B1 RID: 41393
		[Token(Token = "0x400A1B1")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_RegisterCharacter;

		// Token: 0x0400A1B2 RID: 41394
		[Token(Token = "0x400A1B2")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_UnregisterCharacter;

		// Token: 0x0400A1B3 RID: 41395
		[Token(Token = "0x400A1B3")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ShowCoroutine;

		// Token: 0x0400A1B4 RID: 41396
		[Token(Token = "0x400A1B4")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0400A1B5 RID: 41397
		[Token(Token = "0x400A1B5")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_ZoomInToRoom;

		// Token: 0x0400A1B6 RID: 41398
		[Token(Token = "0x400A1B6")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_SelectRoomWithoutFocus;

		// Token: 0x0400A1B7 RID: 41399
		[Token(Token = "0x400A1B7")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0__EnsureReflectConfig;

		// Token: 0x0400A1B8 RID: 41400
		[Token(Token = "0x400A1B8")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_GetRefectFilter;

		// Token: 0x0400A1B9 RID: 41401
		[Token(Token = "0x400A1B9")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetReflectCameraHolder;

		// Token: 0x0400A1BA RID: 41402
		[Token(Token = "0x400A1BA")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_GetRoom;

		// Token: 0x0400A1BB RID: 41403
		[Token(Token = "0x400A1BB")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0__FocusRoomCoroutine;

		// Token: 0x0400A1BC RID: 41404
		[Token(Token = "0x400A1BC")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_Awake;

		// Token: 0x0400A1BD RID: 41405
		[Token(Token = "0x400A1BD")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
