using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BitBenderGames;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Torappu.UI
{
	// Token: 0x020037C9 RID: 14281
	[Token(Token = "0x20037C9")]
	public class TorappuTouchInputController : AbstractTouchInputController
	{
		// Token: 0x17003628 RID: 13864
		// (get) Token: 0x06016A31 RID: 92721 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06016A32 RID: 92722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17003628")]
		private List<Vector3> DragFinalMomentumVector
		{
			[Token(Token = "0x6016A31")]
			[Address(RVA = "0xF0A850", Offset = "0xF09450", VA = "0x180F0A850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6016A32")]
			[Address(RVA = "0xF0A890", Offset = "0xF09490", VA = "0x180F0A890")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17003629 RID: 13865
		// (get) Token: 0x06016A33 RID: 92723 RVA: 0x00092118 File Offset: 0x00090318
		[Token(Token = "0x17003629")]
		public bool LongTapStartsDrag
		{
			[Token(Token = "0x6016A33")]
			[Address(RVA = "0xF0A860", Offset = "0xF09460", VA = "0x180F0A860")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700362A RID: 13866
		// (get) Token: 0x06016A34 RID: 92724 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700362A")]
		protected override GameObject scrollWheelRaycastContent
		{
			[Token(Token = "0x6016A34")]
			[Address(RVA = "0xF0A870", Offset = "0xF09470", VA = "0x180F0A870", Slot = "6")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700362B RID: 13867
		// (get) Token: 0x06016A35 RID: 92725 RVA: 0x00092130 File Offset: 0x00090330
		// (set) Token: 0x06016A36 RID: 92726 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700362B")]
		public bool AllowDragOrPinch
		{
			[Token(Token = "0x6016A35")]
			[Address(RVA = "0xF0A840", Offset = "0xF09440", VA = "0x180F0A840")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6016A36")]
			[Address(RVA = "0xF0A880", Offset = "0xF09480", VA = "0x180F0A880")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06016A37 RID: 92727 RVA: 0x00092148 File Offset: 0x00090348
		[Token(Token = "0x6016A37")]
		[Address(RVA = "0xF09C20", Offset = "0xF08820", VA = "0x180F09C20")]
		private bool _CheckTouchLegal(Vector3 touchPosition)
		{
			return default(bool);
		}

		// Token: 0x06016A38 RID: 92728 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A38")]
		[Address(RVA = "0xF09F20", Offset = "0xF08B20", VA = "0x180F09F20")]
		private void _UpdateTouchInfo()
		{
		}

		// Token: 0x06016A39 RID: 92729 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A39")]
		[Address(RVA = "0xF09F10", Offset = "0xF08B10", VA = "0x180F09F10")]
		private void _SetBlockerActive(bool active)
		{
		}

		// Token: 0x06016A3A RID: 92730 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A3A")]
		[Address(RVA = "0xF074A0", Offset = "0xF060A0", VA = "0x180F074A0", Slot = "7")]
		protected override void Awake()
		{
		}

		// Token: 0x06016A3B RID: 92731 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A3B")]
		[Address(RVA = "0xF09000", Offset = "0xF07C00", VA = "0x180F09000")]
		public void Update()
		{
		}

		// Token: 0x06016A3C RID: 92732 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A3C")]
		[Address(RVA = "0xF07F50", Offset = "0xF06B50", VA = "0x180F07F50")]
		private void StartPinch()
		{
		}

		// Token: 0x06016A3D RID: 92733 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A3D")]
		[Address(RVA = "0xF083D0", Offset = "0xF06FD0", VA = "0x180F083D0")]
		private void UpdatePinch()
		{
		}

		// Token: 0x06016A3E RID: 92734 RVA: 0x00092160 File Offset: 0x00090360
		[Token(Token = "0x6016A3E")]
		[Address(RVA = "0xF07D70", Offset = "0xF06970", VA = "0x180F07D70")]
		private float GetPinchDistance(Vector3 pos0, Vector3 pos1)
		{
			return 0f;
		}

		// Token: 0x06016A3F RID: 92735 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A3F")]
		[Address(RVA = "0xF08350", Offset = "0xF06F50", VA = "0x180F08350")]
		private void StopPinch()
		{
		}

		// Token: 0x06016A40 RID: 92736 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A40")]
		[Address(RVA = "0xF078E0", Offset = "0xF064E0", VA = "0x180F078E0")]
		private void DragStart(Vector3 pos, bool isLongTap, bool isInitialDrag)
		{
		}

		// Token: 0x06016A41 RID: 92737 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A41")]
		[Address(RVA = "0xF07B70", Offset = "0xF06770", VA = "0x180F07B70")]
		private void DragUpdate(Vector3 pos)
		{
		}

		// Token: 0x06016A42 RID: 92738 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A42")]
		[Address(RVA = "0xF07990", Offset = "0xF06590", VA = "0x180F07990")]
		private void DragStop(Vector3 pos)
		{
		}

		// Token: 0x06016A43 RID: 92739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A43")]
		[Address(RVA = "0xF07D10", Offset = "0xF06910", VA = "0x180F07D10")]
		private void FingerDown(Vector3 pos)
		{
		}

		// Token: 0x06016A44 RID: 92740 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A44")]
		[Address(RVA = "0xF07D50", Offset = "0xF06950", VA = "0x180F07D50")]
		private void FingerUp()
		{
		}

		// Token: 0x06016A45 RID: 92741 RVA: 0x00092178 File Offset: 0x00090378
		[Token(Token = "0x6016A45")]
		[Address(RVA = "0xF07EE0", Offset = "0xF06AE0", VA = "0x180F07EE0")]
		private Vector3 GetTouchPositionRelative(Vector3 touchPosScreen)
		{
			return default(Vector3);
		}

		// Token: 0x06016A46 RID: 92742 RVA: 0x00092190 File Offset: 0x00090390
		[Token(Token = "0x6016A46")]
		[Address(RVA = "0xF07E10", Offset = "0xF06A10", VA = "0x180F07E10")]
		private float GetRelativeDragDistance(Vector3 pos0, Vector3 pos1)
		{
			return 0f;
		}

		// Token: 0x06016A47 RID: 92743 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6016A47")]
		[Address(RVA = "0xF0A5D0", Offset = "0xF091D0", VA = "0x180F0A5D0")]
		public TorappuTouchInputController()
		{
		}

		// Token: 0x0401B49A RID: 111770
		[Token(Token = "0x401B49A")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		[Tooltip("When the finger is held on an item for at least this duration without moving, the gesture is recognized as a long tap.")]
		private float clickDurationThreshold;

		// Token: 0x0401B49B RID: 111771
		[Token(Token = "0x401B49B")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		[Tooltip("A double click gesture is recognized when the time between two consecutive taps is shorter than this duration.")]
		private float doubleclickDurationThreshold;

		// Token: 0x0401B49C RID: 111772
		[Token(Token = "0x401B49C")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Tooltip("This value controls how close to a vertical line the user has to perform a tilt gesture for it to be recognized as such.")]
		private float tiltMoveDotTreshold;

		// Token: 0x0401B49D RID: 111773
		[Token(Token = "0x401B49D")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		[Tooltip("Threshold value for detecting whether the fingers are horizontal enough for starting the tilt. Using this value you can prevent vertical finger placement to be counted as tilt gesture.")]
		private float tiltHorizontalDotThreshold;

		// Token: 0x0401B49E RID: 111774
		[Token(Token = "0x401B49E")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Tooltip("A drag is started as soon as the user moves his finger over a longer distance than this value. The value is defined as normalized value. Dragging the entire width of the screen equals 1. Dragging the entire height of the screen also equals 1.")]
		private float dragStartDistanceThresholdRelative;

		// Token: 0x0401B49F RID: 111775
		[Token(Token = "0x401B49F")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		[Tooltip("When this flag is enabled the drag started event is invoked immediately when the long tap time is succeeded.")]
		private bool longTapStartsDrag;

		// Token: 0x0401B4A0 RID: 111776
		[Token(Token = "0x401B4A0")]
		[FieldOffset(Offset = "0x98")]
		private float lastFingerDownTimeReal;

		// Token: 0x0401B4A1 RID: 111777
		[Token(Token = "0x401B4A1")]
		[FieldOffset(Offset = "0x9C")]
		private float lastClickTimeReal;

		// Token: 0x0401B4A2 RID: 111778
		[Token(Token = "0x401B4A2")]
		[FieldOffset(Offset = "0xA0")]
		private bool wasFingerDownLastFrame;

		// Token: 0x0401B4A3 RID: 111779
		[Token(Token = "0x401B4A3")]
		[FieldOffset(Offset = "0xA4")]
		private Vector3 lastFinger0DownPos;

		// Token: 0x0401B4A4 RID: 111780
		[Token(Token = "0x401B4A4")]
		private const float dragDurationThreshold = 0.01f;

		// Token: 0x0401B4A5 RID: 111781
		[Token(Token = "0x401B4A5")]
		[FieldOffset(Offset = "0xB0")]
		private bool isDragging;

		// Token: 0x0401B4A6 RID: 111782
		[Token(Token = "0x401B4A6")]
		[FieldOffset(Offset = "0xB4")]
		private Vector3 dragStartPos;

		// Token: 0x0401B4A7 RID: 111783
		[Token(Token = "0x401B4A7")]
		[FieldOffset(Offset = "0xC0")]
		private Vector3 dragStartOffset;

		// Token: 0x0401B4A9 RID: 111785
		[Token(Token = "0x401B4A9")]
		private const int momentumSamplesCount = 5;

		// Token: 0x0401B4AA RID: 111786
		[Token(Token = "0x401B4AA")]
		[FieldOffset(Offset = "0xD8")]
		private float pinchStartDistance;

		// Token: 0x0401B4AB RID: 111787
		[Token(Token = "0x401B4AB")]
		[FieldOffset(Offset = "0xE0")]
		private List<Vector3> pinchStartPositions;

		// Token: 0x0401B4AC RID: 111788
		[Token(Token = "0x401B4AC")]
		[FieldOffset(Offset = "0xE8")]
		private List<Vector3> touchPositionLastFrame;

		// Token: 0x0401B4AD RID: 111789
		[Token(Token = "0x401B4AD")]
		[FieldOffset(Offset = "0xF0")]
		private Vector3 pinchRotationVectorStart;

		// Token: 0x0401B4AE RID: 111790
		[Token(Token = "0x401B4AE")]
		[FieldOffset(Offset = "0xFC")]
		private Vector3 pinchVectorLastFrame;

		// Token: 0x0401B4AF RID: 111791
		[Token(Token = "0x401B4AF")]
		[FieldOffset(Offset = "0x108")]
		private float totalFingerMovement;

		// Token: 0x0401B4B0 RID: 111792
		[Token(Token = "0x401B4B0")]
		[FieldOffset(Offset = "0x10C")]
		private bool wasDraggingLastFrame;

		// Token: 0x0401B4B1 RID: 111793
		[Token(Token = "0x401B4B1")]
		[FieldOffset(Offset = "0x10D")]
		private bool wasPinchingLastFrame;

		// Token: 0x0401B4B2 RID: 111794
		[Token(Token = "0x401B4B2")]
		[FieldOffset(Offset = "0x10E")]
		private bool isPinching;

		// Token: 0x0401B4B3 RID: 111795
		[Token(Token = "0x401B4B3")]
		[FieldOffset(Offset = "0x110")]
		private float timeSinceDragStart;

		// Token: 0x0401B4B4 RID: 111796
		[Token(Token = "0x401B4B4")]
		[FieldOffset(Offset = "0x114")]
		private bool isClickPrevented;

		// Token: 0x0401B4B5 RID: 111797
		[Token(Token = "0x401B4B5")]
		[FieldOffset(Offset = "0x115")]
		private bool isFingerDown;

		// Token: 0x0401B4B6 RID: 111798
		[Token(Token = "0x401B4B6")]
		[FieldOffset(Offset = "0x118")]
		[SerializeField]
		[Tooltip("The root of game objects that will be shown in a mobile touch camera. When a touch occurs, the camera will perform a raycast from the touch position on the screen. If this raycast hits one of the root's child, the mobile touch camera will response to the touch.")]
		private GameObject _touchCameraContent;

		// Token: 0x0401B4B7 RID: 111799
		[Token(Token = "0x401B4B7")]
		[FieldOffset(Offset = "0x120")]
		[SerializeField]
		[Tooltip("When a touch is recognized as mobile touch camera drag or pinch, this object will be set active to prevent touch events bubbling to the game object hierarchy of the mobile touch camera content.")]
		private GameObject _touchCameraRaycastBlocker;

		// Token: 0x0401B4B8 RID: 111800
		[Token(Token = "0x401B4B8")]
		[FieldOffset(Offset = "0x128")]
		private List<int> m_touchIdList;

		// Token: 0x0401B4B9 RID: 111801
		[Token(Token = "0x401B4B9")]
		[FieldOffset(Offset = "0x130")]
		private List<int> m_endedTouchIds;

		// Token: 0x0401B4BA RID: 111802
		[Token(Token = "0x401B4BA")]
		[FieldOffset(Offset = "0x138")]
		private List<WrappedTouch> m_legalTouches;

		// Token: 0x0401B4BB RID: 111803
		[Token(Token = "0x401B4BB")]
		[FieldOffset(Offset = "0x140")]
		private Dictionary<int, bool> m_touchLegalInfo;

		// Token: 0x0401B4BC RID: 111804
		[Token(Token = "0x401B4BC")]
		[FieldOffset(Offset = "0x148")]
		private List<RaycastResult> m_raycastResults;
	}
}
