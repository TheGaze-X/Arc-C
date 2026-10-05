using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Building.BP
{
	// Token: 0x02001A9F RID: 6815
	[Token(Token = "0x2001A9F")]
	public class BlueprintMode : BuildingMode<BlueprintMode>, BLayoutManager.IListener
	{
		// Token: 0x17001454 RID: 5204
		// (get) Token: 0x0600ABE1 RID: 44001 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001454")]
		protected BCameraController bCamController
		{
			[Token(Token = "0x600ABE1")]
			[Address(RVA = "0x327CD40", Offset = "0x327B940", VA = "0x18327CD40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001455 RID: 5205
		// (get) Token: 0x0600ABE2 RID: 44002 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600ABE3 RID: 44003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001455")]
		public BlueprintMode.IPlugin plugin
		{
			[Token(Token = "0x600ABE2")]
			[Address(RVA = "0x327CEE0", Offset = "0x327BAE0", VA = "0x18327CEE0")]
			get
			{
				return null;
			}
			[Token(Token = "0x600ABE3")]
			[Address(RVA = "0x327D140", Offset = "0x327BD40", VA = "0x18327D140")]
			set
			{
			}
		}

		// Token: 0x17001456 RID: 5206
		// (get) Token: 0x0600ABE4 RID: 44004 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001456")]
		public Camera camera
		{
			[Token(Token = "0x600ABE4")]
			[Address(RVA = "0x327CE00", Offset = "0x327BA00", VA = "0x18327CE00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001457 RID: 5207
		// (get) Token: 0x0600ABE5 RID: 44005 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001457")]
		internal BLayoutManager AVGOnly_layout
		{
			[Token(Token = "0x600ABE5")]
			[Address(RVA = "0x327CCE0", Offset = "0x327B8E0", VA = "0x18327CCE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600ABE6 RID: 44006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABE6")]
		[Address(RVA = "0x327BA00", Offset = "0x327A600", VA = "0x18327BA00")]
		public void EnterArchitectureMode()
		{
		}

		// Token: 0x0600ABE7 RID: 44007 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABE7")]
		[Address(RVA = "0x327BB80", Offset = "0x327A780", VA = "0x18327BB80")]
		public void ExitArchitectureMode()
		{
		}

		// Token: 0x0600ABE8 RID: 44008 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABE8")]
		[Address(RVA = "0x327C2A0", Offset = "0x327AEA0", VA = "0x18327C2A0", Slot = "29")]
		public void OnArchitectureRoomSelected(RoomSlotModel room)
		{
		}

		// Token: 0x17001458 RID: 5208
		// (get) Token: 0x0600ABE9 RID: 44009 RVA: 0x00042780 File Offset: 0x00040980
		// (set) Token: 0x0600ABEA RID: 44010 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17001458")]
		public override bool isRaycastBlocked
		{
			[Token(Token = "0x600ABE9")]
			[Address(RVA = "0x327CE60", Offset = "0x327BA60", VA = "0x18327CE60", Slot = "19")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600ABEA")]
			[Address(RVA = "0x327D000", Offset = "0x327BC00", VA = "0x18327D000", Slot = "20")]
			set
			{
			}
		}

		// Token: 0x17001459 RID: 5209
		// (get) Token: 0x0600ABEB RID: 44011 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001459")]
		public override RoomSlotModel selectedRoom
		{
			[Token(Token = "0x600ABEB")]
			[Address(RVA = "0x327CF40", Offset = "0x327BB40", VA = "0x18327CF40", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600ABEC RID: 44012 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABEC")]
		[Address(RVA = "0x327C610", Offset = "0x327B210", VA = "0x18327C610", Slot = "22")]
		protected override void OnRegister()
		{
		}

		// Token: 0x0600ABED RID: 44013 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABED")]
		[Address(RVA = "0x327C340", Offset = "0x327AF40", VA = "0x18327C340", Slot = "23")]
		public override void OnEnter(int lastState)
		{
		}

		// Token: 0x0600ABEE RID: 44014 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABEE")]
		[Address(RVA = "0x327C560", Offset = "0x327B160", VA = "0x18327C560", Slot = "25")]
		public override void OnExit(int nextState)
		{
		}

		// Token: 0x0600ABEF RID: 44015 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600ABEF")]
		[Address(RVA = "0x327BCE0", Offset = "0x327A8E0", VA = "0x18327BCE0", Slot = "28")]
		public override IEnumerator HideCoroutine(BuildingStateMachine.TransitionParam param)
		{
			return null;
		}

		// Token: 0x0600ABF0 RID: 44016 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABF0")]
		[Address(RVA = "0x327B900", Offset = "0x327A500", VA = "0x18327B900")]
		public void CameraZoomToMax()
		{
		}

		// Token: 0x0600ABF1 RID: 44017 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABF1")]
		[Address(RVA = "0x327B550", Offset = "0x327A150", VA = "0x18327B550")]
		public void CameraTweenOnModeInit()
		{
		}

		// Token: 0x0600ABF2 RID: 44018 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABF2")]
		[Address(RVA = "0x327B5F0", Offset = "0x327A1F0", VA = "0x18327B5F0")]
		public void CameraTweenTo(float toZoom, bool tweenToLeft, BlueprintMode.CameraTweenConfig tweenConfig)
		{
		}

		// Token: 0x0600ABF3 RID: 44019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABF3")]
		[Address(RVA = "0x327C710", Offset = "0x327B310", VA = "0x18327C710")]
		private void _TweenBPCamPosTo(Vector3 targetPos, bool forceStart, BlueprintMode.CameraTweenConfig config)
		{
		}

		// Token: 0x0600ABF4 RID: 44020 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABF4")]
		[Address(RVA = "0x327BDD0", Offset = "0x327A9D0", VA = "0x18327BDD0")]
		public void HilightRoomSlots(List<string> slotIds, BuildingToDoCategory selectedCategory, BuildingData.BuildingToDoType selectedType)
		{
		}

		// Token: 0x0600ABF5 RID: 44021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABF5")]
		[Address(RVA = "0x327C0C0", Offset = "0x327ACC0", VA = "0x18327C0C0")]
		public void NotifySettleEffects(BuildingData.RoomType roomType)
		{
		}

		// Token: 0x0600ABF6 RID: 44022 RVA: 0x00042798 File Offset: 0x00040998
		[Token(Token = "0x600ABF6")]
		[Address(RVA = "0x327BC50", Offset = "0x327A850", VA = "0x18327BC50")]
		public Vector2 GetRoomAnchor(string slotId)
		{
			return default(Vector2);
		}

		// Token: 0x0600ABF7 RID: 44023 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABF7")]
		[Address(RVA = "0x327BAD0", Offset = "0x327A6D0", VA = "0x18327BAD0")]
		public void EventOnHilightedMaskClicked()
		{
		}

		// Token: 0x0600ABF8 RID: 44024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600ABF8")]
		[Address(RVA = "0x327CBC0", Offset = "0x327B7C0", VA = "0x18327CBC0")]
		public BlueprintMode()
		{
		}

		// Token: 0x0400A403 RID: 41987
		[Token(Token = "0x400A403")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private BLayoutManager _layout;

		// Token: 0x0400A404 RID: 41988
		[Token(Token = "0x400A404")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Camera _camera;

		// Token: 0x0400A405 RID: 41989
		[Token(Token = "0x400A405")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform _raycastBlocker;

		// Token: 0x0400A406 RID: 41990
		[Token(Token = "0x400A406")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("Used to block others when some rooms are hilighted")]
		private CanvasGroup _hilightMask;

		// Token: 0x0400A407 RID: 41991
		[Token(Token = "0x400A407")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BlueprintMode.CameraTweenConfig _tweenOnInitConfig;

		// Token: 0x0400A408 RID: 41992
		[Token(Token = "0x400A408")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private BlueprintMode.CameraTweenConfig _tweenToMaxConfig;

		// Token: 0x0400A409 RID: 41993
		[Token(Token = "0x400A409")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private bool _blockRaycastInTween;

		// Token: 0x0400A40A RID: 41994
		[Token(Token = "0x400A40A")]
		[FieldOffset(Offset = "0x60")]
		private BRoomHilightViewModel m_hilightModel;

		// Token: 0x0400A40B RID: 41995
		[Token(Token = "0x400A40B")]
		[FieldOffset(Offset = "0x68")]
		private FadeSwitchTween m_hilightMaskTween;

		// Token: 0x0400A40C RID: 41996
		[Token(Token = "0x400A40C")]
		[FieldOffset(Offset = "0x70")]
		private Tween m_sharedBPPositionTween;

		// Token: 0x0400A40D RID: 41997
		[Token(Token = "0x400A40D")]
		[FieldOffset(Offset = "0x78")]
		private BCameraController m_bCamController;

		// Token: 0x0400A40E RID: 41998
		[Token(Token = "0x400A40E")]
		[FieldOffset(Offset = "0x80")]
		private BlueprintMode.IPlugin m_plugin;

		// Token: 0x0400A40F RID: 41999
		[Token(Token = "0x400A40F")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_bCamController;

		// Token: 0x0400A410 RID: 42000
		[Token(Token = "0x400A410")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_plugin;

		// Token: 0x0400A411 RID: 42001
		[Token(Token = "0x400A411")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_set_plugin;

		// Token: 0x0400A412 RID: 42002
		[Token(Token = "0x400A412")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_camera;

		// Token: 0x0400A413 RID: 42003
		[Token(Token = "0x400A413")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_AVGOnly_layout;

		// Token: 0x0400A414 RID: 42004
		[Token(Token = "0x400A414")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_EnterArchitectureMode;

		// Token: 0x0400A415 RID: 42005
		[Token(Token = "0x400A415")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_ExitArchitectureMode;

		// Token: 0x0400A416 RID: 42006
		[Token(Token = "0x400A416")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_OnArchitectureRoomSelected;

		// Token: 0x0400A417 RID: 42007
		[Token(Token = "0x400A417")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_isRaycastBlocked;

		// Token: 0x0400A418 RID: 42008
		[Token(Token = "0x400A418")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_isRaycastBlocked;

		// Token: 0x0400A419 RID: 42009
		[Token(Token = "0x400A419")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_selectedRoom;

		// Token: 0x0400A41A RID: 42010
		[Token(Token = "0x400A41A")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_OnRegister;

		// Token: 0x0400A41B RID: 42011
		[Token(Token = "0x400A41B")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x0400A41C RID: 42012
		[Token(Token = "0x400A41C")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x0400A41D RID: 42013
		[Token(Token = "0x400A41D")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0_HideCoroutine;

		// Token: 0x0400A41E RID: 42014
		[Token(Token = "0x400A41E")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_CameraZoomToMax;

		// Token: 0x0400A41F RID: 42015
		[Token(Token = "0x400A41F")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_CameraTweenOnModeInit;

		// Token: 0x0400A420 RID: 42016
		[Token(Token = "0x400A420")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_CameraTweenTo;

		// Token: 0x0400A421 RID: 42017
		[Token(Token = "0x400A421")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0__TweenBPCamPosTo;

		// Token: 0x0400A422 RID: 42018
		[Token(Token = "0x400A422")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_HilightRoomSlots;

		// Token: 0x0400A423 RID: 42019
		[Token(Token = "0x400A423")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_NotifySettleEffects;

		// Token: 0x0400A424 RID: 42020
		[Token(Token = "0x400A424")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_GetRoomAnchor;

		// Token: 0x0400A425 RID: 42021
		[Token(Token = "0x400A425")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_EventOnHilightedMaskClicked;

		// Token: 0x0400A426 RID: 42022
		[Token(Token = "0x400A426")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001AA0 RID: 6816
		[Token(Token = "0x2001AA0")]
		[Serializable]
		public struct CameraTweenConfig
		{
			// Token: 0x0400A427 RID: 42023
			[Token(Token = "0x400A427")]
			[FieldOffset(Offset = "0x0")]
			public float duration;

			// Token: 0x0400A428 RID: 42024
			[Token(Token = "0x400A428")]
			[FieldOffset(Offset = "0x4")]
			public float delay;

			// Token: 0x0400A429 RID: 42025
			[Token(Token = "0x400A429")]
			[FieldOffset(Offset = "0x8")]
			public Ease ease;
		}

		// Token: 0x02001AA1 RID: 6817
		[Token(Token = "0x2001AA1")]
		public interface IPlugin
		{
			// Token: 0x0600ABFA RID: 44026
			[Token(Token = "0x600ABFA")]
			void OnAdded(BlueprintMode mode);

			// Token: 0x0600ABFB RID: 44027
			[Token(Token = "0x600ABFB")]
			void OnRemoved(BlueprintMode mode);

			// Token: 0x0600ABFC RID: 44028
			[Token(Token = "0x600ABFC")]
			void OnRoomSelect(RoomSlotModel room);
		}
	}
}
