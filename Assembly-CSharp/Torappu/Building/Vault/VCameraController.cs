using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AdvancedInspector;
using BitBenderGames;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using XLua;

namespace Torappu.Building.Vault
{
	// Token: 0x02001A5C RID: 6748
	[Token(Token = "0x2001A5C")]
	public class VCameraController : SingletonMonoBehaviour<VCameraController>, ISingletonNotAutoCreate, ILODHolder
	{
		// Token: 0x170013E6 RID: 5094
		// (get) Token: 0x0600A9C4 RID: 43460 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013E6")]
		public ScrollWheelHandler handler
		{
			[Token(Token = "0x600A9C4")]
			[Address(RVA = "0x323E0B0", Offset = "0x323CCB0", VA = "0x18323E0B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013E7 RID: 5095
		// (get) Token: 0x0600A9C5 RID: 43461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170013E7")]
		public Camera camera
		{
			[Token(Token = "0x600A9C5")]
			[Address(RVA = "0x323DFD0", Offset = "0x323CBD0", VA = "0x18323DFD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170013E8 RID: 5096
		// (get) Token: 0x0600A9C6 RID: 43462 RVA: 0x00041B20 File Offset: 0x0003FD20
		// (set) Token: 0x0600A9C7 RID: 43463 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170013E8")]
		public bool enableTouchCamera
		{
			[Token(Token = "0x600A9C6")]
			[Address(RVA = "0x323E040", Offset = "0x323CC40", VA = "0x18323E040")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600A9C7")]
			[Address(RVA = "0x323E2D0", Offset = "0x323CED0", VA = "0x18323E2D0")]
			set
			{
			}
		}

		// Token: 0x170013E9 RID: 5097
		// (get) Token: 0x0600A9C8 RID: 43464 RVA: 0x00041B38 File Offset: 0x0003FD38
		[Token(Token = "0x170013E9")]
		public bool isTweening
		{
			[Token(Token = "0x600A9C8")]
			[Address(RVA = "0x323E180", Offset = "0x323CD80", VA = "0x18323E180")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170013EA RID: 5098
		// (get) Token: 0x0600A9C9 RID: 43465 RVA: 0x00041B50 File Offset: 0x0003FD50
		[Token(Token = "0x170013EA")]
		public bool isDraggingOrPinching
		{
			[Token(Token = "0x600A9C9")]
			[Address(RVA = "0x323E110", Offset = "0x323CD10", VA = "0x18323E110")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170013EB RID: 5099
		// (get) Token: 0x0600A9CA RID: 43466 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600A9CB RID: 43467 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170013EB")]
		public LODState lodState
		{
			[Token(Token = "0x600A9CA")]
			[Address(RVA = "0x323E1F0", Offset = "0x323CDF0", VA = "0x18323E1F0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600A9CB")]
			[Address(RVA = "0x323E380", Offset = "0x323CF80", VA = "0x18323E380")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170013EC RID: 5100
		// (get) Token: 0x0600A9CC RID: 43468 RVA: 0x00041B68 File Offset: 0x0003FD68
		// (set) Token: 0x0600A9CD RID: 43469 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170013EC")]
		public float camZoom
		{
			[Token(Token = "0x600A9CC")]
			[Address(RVA = "0x323DF60", Offset = "0x323CB60", VA = "0x18323DF60")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600A9CD")]
			[Address(RVA = "0x323E250", Offset = "0x323CE50", VA = "0x18323E250")]
			set
			{
			}
		}

		// Token: 0x170013ED RID: 5101
		// (get) Token: 0x0600A9CE RID: 43470 RVA: 0x00041B80 File Offset: 0x0003FD80
		[Token(Token = "0x170013ED")]
		public float camZoomMax
		{
			[Token(Token = "0x600A9CE")]
			[Address(RVA = "0x323DE80", Offset = "0x323CA80", VA = "0x18323DE80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170013EE RID: 5102
		// (get) Token: 0x0600A9CF RID: 43471 RVA: 0x00041B98 File Offset: 0x0003FD98
		[Token(Token = "0x170013EE")]
		public float camZoomMin
		{
			[Token(Token = "0x600A9CF")]
			[Address(RVA = "0x323DEF0", Offset = "0x323CAF0", VA = "0x18323DEF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600A9D0 RID: 43472 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9D0")]
		[Address(RVA = "0x323C500", Offset = "0x323B100", VA = "0x18323C500")]
		public void SetBoundingBox(Rect boundingBox, bool moveToCenter)
		{
		}

		// Token: 0x0600A9D1 RID: 43473 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A9D1")]
		[Address(RVA = "0x323B330", Offset = "0x3239F30", VA = "0x18323B330")]
		public Tween Focus(VRoomSlot room, bool tween = true)
		{
			return null;
		}

		// Token: 0x0600A9D2 RID: 43474 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A9D2")]
		[Address(RVA = "0x323B3F0", Offset = "0x3239FF0", VA = "0x18323B3F0")]
		public Tween Focus(VRoom.Object roomObject, float worldY, float worldZ, bool tween = true, bool force = false)
		{
			return null;
		}

		// Token: 0x0600A9D3 RID: 43475 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A9D3")]
		[Address(RVA = "0x323BAC0", Offset = "0x323A6C0", VA = "0x18323BAC0")]
		public Tween ForcusCharacter(VCharacter roomChar, bool tween = true)
		{
			return null;
		}

		// Token: 0x0600A9D4 RID: 43476 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A9D4")]
		[Address(RVA = "0x323BC90", Offset = "0x323A890", VA = "0x18323BC90")]
		public Tween ForcusCharacter(VCharacter roomChar, float targetZ, bool tween = true, bool force = false)
		{
			return null;
		}

		// Token: 0x0600A9D5 RID: 43477 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9D5")]
		[Address(RVA = "0x323B6A0", Offset = "0x323A2A0", VA = "0x18323B6A0")]
		public void ForcusCharacterInControl(VCharacter roomChar, float targetX, float targetZ, float maxDist)
		{
		}

		// Token: 0x0600A9D6 RID: 43478 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A9D6")]
		[Address(RVA = "0x323BDE0", Offset = "0x323A9E0", VA = "0x18323BDE0")]
		public Tween ForcusFurniture(VFurnitureEntity roomfurnitue, bool tween = true)
		{
			return null;
		}

		// Token: 0x0600A9D7 RID: 43479 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A9D7")]
		[Address(RVA = "0x323B270", Offset = "0x3239E70", VA = "0x18323B270")]
		public Tween Focus(Vector3 pos, bool tween = true)
		{
			return null;
		}

		// Token: 0x0600A9D8 RID: 43480 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A9D8")]
		[Address(RVA = "0x323B030", Offset = "0x3239C30", VA = "0x18323B030")]
		public Tween FlashIn(VRoomSlot room, bool tween = true, bool fromInitPos = false)
		{
			return null;
		}

		// Token: 0x0600A9D9 RID: 43481 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A9D9")]
		[Address(RVA = "0x323B1D0", Offset = "0x3239DD0", VA = "0x18323B1D0")]
		public Tween FlashOut(bool tween = true)
		{
			return null;
		}

		// Token: 0x0600A9DA RID: 43482 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9DA")]
		[Address(RVA = "0x323C450", Offset = "0x323B050", VA = "0x18323C450")]
		public void ResetCameraPosition()
		{
		}

		// Token: 0x0600A9DB RID: 43483 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9DB")]
		[Address(RVA = "0x323D1E0", Offset = "0x323BDE0", VA = "0x18323D1E0")]
		public void UpdateTouchCamera()
		{
		}

		// Token: 0x0600A9DC RID: 43484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9DC")]
		[Address(RVA = "0x323AD70", Offset = "0x3239970", VA = "0x18323AD70", Slot = "9")]
		public void AddLODListener(ILODListener listener)
		{
		}

		// Token: 0x0600A9DD RID: 43485 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9DD")]
		[Address(RVA = "0x323C340", Offset = "0x323AF40", VA = "0x18323C340", Slot = "10")]
		public void RemoveLODListener(ILODListener listener)
		{
		}

		// Token: 0x0600A9DE RID: 43486 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9DE")]
		[Address(RVA = "0x323CF80", Offset = "0x323BB80", VA = "0x18323CF80")]
		public void UpdateLOD(int lod)
		{
		}

		// Token: 0x0600A9DF RID: 43487 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9DF")]
		[Address(RVA = "0x323D8A0", Offset = "0x323C4A0", VA = "0x18323D8A0")]
		private void _NotifyLODLevelChanged()
		{
		}

		// Token: 0x0600A9E0 RID: 43488 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9E0")]
		[Address(RVA = "0x323DBC0", Offset = "0x323C7C0", VA = "0x18323DBC0")]
		private void _UpdateLOD()
		{
		}

		// Token: 0x0600A9E1 RID: 43489 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600A9E1")]
		[Address(RVA = "0x323D470", Offset = "0x323C070", VA = "0x18323D470")]
		private Tween _FocusInternal(Vector3 pos, bool tween, float time, Ease easeType)
		{
			return null;
		}

		// Token: 0x0600A9E2 RID: 43490 RVA: 0x00041BB0 File Offset: 0x0003FDB0
		[Token(Token = "0x600A9E2")]
		[Address(RVA = "0x323AED0", Offset = "0x3239AD0", VA = "0x18323AED0")]
		public Vector3 CalculateFocusPosition(VRoomSlot room)
		{
			return default(Vector3);
		}

		// Token: 0x0600A9E3 RID: 43491 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9E3")]
		[Address(RVA = "0x323DB40", Offset = "0x323C740", VA = "0x18323DB40")]
		private void _StopTween()
		{
		}

		// Token: 0x0600A9E4 RID: 43492 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9E4")]
		[Address(RVA = "0x323D9F0", Offset = "0x323C5F0", VA = "0x18323D9F0")]
		private void _OnDragOrPinch()
		{
		}

		// Token: 0x0600A9E5 RID: 43493 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9E5")]
		[Address(RVA = "0x323DA80", Offset = "0x323C680", VA = "0x18323DA80")]
		private void _OnZoomUpdate(float oldSize, float newSize)
		{
		}

		// Token: 0x0600A9E6 RID: 43494 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9E6")]
		[Address(RVA = "0x323C6C0", Offset = "0x323B2C0", VA = "0x18323C6C0")]
		private void Start()
		{
		}

		// Token: 0x0600A9E7 RID: 43495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9E7")]
		[Address(RVA = "0x323D7E0", Offset = "0x323C3E0", VA = "0x18323D7E0")]
		private void _InitCamera(Camera cam)
		{
		}

		// Token: 0x0600A9E8 RID: 43496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9E8")]
		[Address(RVA = "0x323D320", Offset = "0x323BF20", VA = "0x18323D320")]
		private void Update()
		{
		}

		// Token: 0x0600A9E9 RID: 43497 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9E9")]
		[Address(RVA = "0x323C080", Offset = "0x323AC80", VA = "0x18323C080")]
		private void OnWheelTo(Vector2 delta)
		{
		}

		// Token: 0x0600A9EA RID: 43498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9EA")]
		[Address(RVA = "0x323AE40", Offset = "0x3239A40", VA = "0x18323AE40")]
		public void BindListener(ScrollWheelHandler handler)
		{
		}

		// Token: 0x0600A9EB RID: 43499 RVA: 0x00041BC8 File Offset: 0x0003FDC8
		[Token(Token = "0x600A9EB")]
		[Address(RVA = "0x323C020", Offset = "0x323AC20", VA = "0x18323C020")]
		public WheelSorting GetWheelSorting()
		{
			return WheelSorting.BASE;
		}

		// Token: 0x0600A9EC RID: 43500 RVA: 0x00041BE0 File Offset: 0x0003FDE0
		[Token(Token = "0x600A9EC")]
		[Address(RVA = "0x323CC10", Offset = "0x323B810", VA = "0x18323CC10")]
		public Vector2 TreatValue(PointerEventData eventData)
		{
			return default(Vector2);
		}

		// Token: 0x0600A9ED RID: 43501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600A9ED")]
		[Address(RVA = "0x323DCD0", Offset = "0x323C8D0", VA = "0x18323DCD0")]
		public VCameraController()
		{
		}

		// Token: 0x0400A1C9 RID: 41417
		[Token(Token = "0x400A1C9")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private MobileTouchCamera _touchCamera;

		// Token: 0x0400A1CA RID: 41418
		[Token(Token = "0x400A1CA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Group("Focus")]
		private VCameraController.FocusMatchType _matchType;

		// Token: 0x0400A1CB RID: 41419
		[Token(Token = "0x400A1CB")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		[Group("Focus")]
		private Vector2 _focsusZRange;

		// Token: 0x0400A1CC RID: 41420
		[Token(Token = "0x400A1CC")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		[Group("Focus")]
		private Vector2 _roomWidthRange;

		// Token: 0x0400A1CD RID: 41421
		[Token(Token = "0x400A1CD")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[Group("Focus")]
		private Vector2 _roomHeightRange;

		// Token: 0x0400A1CE RID: 41422
		[Token(Token = "0x400A1CE")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		[Group("Focus")]
		private float _planeHeightOffset;

		// Token: 0x0400A1CF RID: 41423
		[Token(Token = "0x400A1CF")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Group("Tween", Priority = 1)]
		private float _focusTime;

		// Token: 0x0400A1D0 RID: 41424
		[Token(Token = "0x400A1D0")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Group("Tween")]
		private Ease _focusEaseType;

		// Token: 0x0400A1D1 RID: 41425
		[Token(Token = "0x400A1D1")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Group("Tween")]
		private float _flashInTime;

		// Token: 0x0400A1D2 RID: 41426
		[Token(Token = "0x400A1D2")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		[Group("Tween")]
		private Ease _flashInEaseType;

		// Token: 0x0400A1D3 RID: 41427
		[Token(Token = "0x400A1D3")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Group("Tween")]
		private float _flashInFromZ;

		// Token: 0x0400A1D4 RID: 41428
		[Token(Token = "0x400A1D4")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[Group("Tween")]
		private float _flashOutTime;

		// Token: 0x0400A1D5 RID: 41429
		[Token(Token = "0x400A1D5")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("Tween")]
		private Ease _flashOutEaseType;

		// Token: 0x0400A1D6 RID: 41430
		[Token(Token = "0x400A1D6")]
		[FieldOffset(Offset = "0x60")]
		private Tween m_tween;

		// Token: 0x0400A1D7 RID: 41431
		[Token(Token = "0x400A1D7")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 m_initialPosition;

		// Token: 0x0400A1D8 RID: 41432
		[Token(Token = "0x400A1D8")]
		[FieldOffset(Offset = "0x78")]
		private ScrollWheelHandler m_handler;

		// Token: 0x0400A1D9 RID: 41433
		[Token(Token = "0x400A1D9")]
		[FieldOffset(Offset = "0x80")]
		public UnityEvent onDragOrPinch;

		// Token: 0x0400A1DA RID: 41434
		[Token(Token = "0x400A1DA")]
		[FieldOffset(Offset = "0x88")]
		public VCameraController.OnZoomUpdateEvent onZoomUpdate;

		// Token: 0x0400A1DB RID: 41435
		[Token(Token = "0x400A1DB")]
		[FieldOffset(Offset = "0x90")]
		private List<ILODListener> m_lodListeners;

		// Token: 0x0400A1DD RID: 41437
		[Token(Token = "0x400A1DD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_handler;

		// Token: 0x0400A1DE RID: 41438
		[Token(Token = "0x400A1DE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_camera;

		// Token: 0x0400A1DF RID: 41439
		[Token(Token = "0x400A1DF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_enableTouchCamera;

		// Token: 0x0400A1E0 RID: 41440
		[Token(Token = "0x400A1E0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_set_enableTouchCamera;

		// Token: 0x0400A1E1 RID: 41441
		[Token(Token = "0x400A1E1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_isTweening;

		// Token: 0x0400A1E2 RID: 41442
		[Token(Token = "0x400A1E2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isDraggingOrPinching;

		// Token: 0x0400A1E3 RID: 41443
		[Token(Token = "0x400A1E3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_lodState;

		// Token: 0x0400A1E4 RID: 41444
		[Token(Token = "0x400A1E4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_set_lodState;

		// Token: 0x0400A1E5 RID: 41445
		[Token(Token = "0x400A1E5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_get_camZoom;

		// Token: 0x0400A1E6 RID: 41446
		[Token(Token = "0x400A1E6")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_set_camZoom;

		// Token: 0x0400A1E7 RID: 41447
		[Token(Token = "0x400A1E7")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_get_camZoomMax;

		// Token: 0x0400A1E8 RID: 41448
		[Token(Token = "0x400A1E8")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_get_camZoomMin;

		// Token: 0x0400A1E9 RID: 41449
		[Token(Token = "0x400A1E9")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_SetBoundingBox;

		// Token: 0x0400A1EA RID: 41450
		[Token(Token = "0x400A1EA")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0_Focus;

		// Token: 0x0400A1EB RID: 41451
		[Token(Token = "0x400A1EB")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix1_Focus;

		// Token: 0x0400A1EC RID: 41452
		[Token(Token = "0x400A1EC")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0_ForcusCharacter;

		// Token: 0x0400A1ED RID: 41453
		[Token(Token = "0x400A1ED")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix1_ForcusCharacter;

		// Token: 0x0400A1EE RID: 41454
		[Token(Token = "0x400A1EE")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_ForcusCharacterInControl;

		// Token: 0x0400A1EF RID: 41455
		[Token(Token = "0x400A1EF")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_ForcusFurniture;

		// Token: 0x0400A1F0 RID: 41456
		[Token(Token = "0x400A1F0")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix2_Focus;

		// Token: 0x0400A1F1 RID: 41457
		[Token(Token = "0x400A1F1")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0_FlashIn;

		// Token: 0x0400A1F2 RID: 41458
		[Token(Token = "0x400A1F2")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_FlashOut;

		// Token: 0x0400A1F3 RID: 41459
		[Token(Token = "0x400A1F3")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0_ResetCameraPosition;

		// Token: 0x0400A1F4 RID: 41460
		[Token(Token = "0x400A1F4")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_UpdateTouchCamera;

		// Token: 0x0400A1F5 RID: 41461
		[Token(Token = "0x400A1F5")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0_AddLODListener;

		// Token: 0x0400A1F6 RID: 41462
		[Token(Token = "0x400A1F6")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0_RemoveLODListener;

		// Token: 0x0400A1F7 RID: 41463
		[Token(Token = "0x400A1F7")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_UpdateLOD;

		// Token: 0x0400A1F8 RID: 41464
		[Token(Token = "0x400A1F8")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge __Hotfix0__NotifyLODLevelChanged;

		// Token: 0x0400A1F9 RID: 41465
		[Token(Token = "0x400A1F9")]
		[FieldOffset(Offset = "0xE0")]
		private static DelegateBridge __Hotfix0__UpdateLOD;

		// Token: 0x0400A1FA RID: 41466
		[Token(Token = "0x400A1FA")]
		[FieldOffset(Offset = "0xE8")]
		private static DelegateBridge __Hotfix0__FocusInternal;

		// Token: 0x0400A1FB RID: 41467
		[Token(Token = "0x400A1FB")]
		[FieldOffset(Offset = "0xF0")]
		private static DelegateBridge __Hotfix0_CalculateFocusPosition;

		// Token: 0x0400A1FC RID: 41468
		[Token(Token = "0x400A1FC")]
		[FieldOffset(Offset = "0xF8")]
		private static DelegateBridge __Hotfix0__StopTween;

		// Token: 0x0400A1FD RID: 41469
		[Token(Token = "0x400A1FD")]
		[FieldOffset(Offset = "0x100")]
		private static DelegateBridge __Hotfix0__OnDragOrPinch;

		// Token: 0x0400A1FE RID: 41470
		[Token(Token = "0x400A1FE")]
		[FieldOffset(Offset = "0x108")]
		private static DelegateBridge __Hotfix0__OnZoomUpdate;

		// Token: 0x0400A1FF RID: 41471
		[Token(Token = "0x400A1FF")]
		[FieldOffset(Offset = "0x110")]
		private static DelegateBridge __Hotfix0_Start;

		// Token: 0x0400A200 RID: 41472
		[Token(Token = "0x400A200")]
		[FieldOffset(Offset = "0x118")]
		private static DelegateBridge __Hotfix0__InitCamera;

		// Token: 0x0400A201 RID: 41473
		[Token(Token = "0x400A201")]
		[FieldOffset(Offset = "0x120")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400A202 RID: 41474
		[Token(Token = "0x400A202")]
		[FieldOffset(Offset = "0x128")]
		private static DelegateBridge __Hotfix0_OnWheelTo;

		// Token: 0x0400A203 RID: 41475
		[Token(Token = "0x400A203")]
		[FieldOffset(Offset = "0x130")]
		private static DelegateBridge __Hotfix0_BindListener;

		// Token: 0x0400A204 RID: 41476
		[Token(Token = "0x400A204")]
		[FieldOffset(Offset = "0x138")]
		private static DelegateBridge __Hotfix0_GetWheelSorting;

		// Token: 0x0400A205 RID: 41477
		[Token(Token = "0x400A205")]
		[FieldOffset(Offset = "0x140")]
		private static DelegateBridge __Hotfix0_TreatValue;

		// Token: 0x0400A206 RID: 41478
		[Token(Token = "0x400A206")]
		[FieldOffset(Offset = "0x148")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02001A5D RID: 6749
		[Token(Token = "0x2001A5D")]
		[Serializable]
		public class OnZoomUpdateEvent : UnityEvent<float, float>
		{
			// Token: 0x0600A9F3 RID: 43507 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600A9F3")]
			[Address(RVA = "0x3251670", Offset = "0x3250270", VA = "0x183251670")]
			public OnZoomUpdateEvent()
			{
			}
		}

		// Token: 0x02001A5E RID: 6750
		[Token(Token = "0x2001A5E")]
		public enum FocusMatchType
		{
			// Token: 0x0400A208 RID: 41480
			[Token(Token = "0x400A208")]
			WIDTH,
			// Token: 0x0400A209 RID: 41481
			[Token(Token = "0x400A209")]
			HEIGHT
		}
	}
}
