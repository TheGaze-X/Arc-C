using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;

namespace BitBenderGames
{
	// Token: 0x0200046B RID: 1131
	[Token(Token = "0x200046B")]
	public class TouchInputController : AbstractTouchInputController
	{
		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06004B5C RID: 19292 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004B5D RID: 19293 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001BE")]
		private List<Vector3> DragFinalMomentumVector
		{
			[Token(Token = "0x6004B5C")]
			[Address(RVA = "0xF0A850", Offset = "0xF09450", VA = "0x180F0A850")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004B5D")]
			[Address(RVA = "0xF0A890", Offset = "0xF09490", VA = "0x180F0A890")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06004B5E RID: 19294 RVA: 0x0002CE20 File Offset: 0x0002B020
		[Token(Token = "0x170001BF")]
		public bool LongTapStartsDrag
		{
			[Token(Token = "0x6004B5E")]
			[Address(RVA = "0x9069B0", Offset = "0x9055B0", VA = "0x1809069B0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06004B5F RID: 19295 RVA: 0x0002CE38 File Offset: 0x0002B038
		// (set) Token: 0x06004B60 RID: 19296 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170001C0")]
		public bool IsInputOnLockedArea
		{
			[Token(Token = "0x6004B5F")]
			[Address(RVA = "0x1697770", Offset = "0x1696370", VA = "0x181697770")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004B60")]
			[Address(RVA = "0x1697780", Offset = "0x1696380", VA = "0x181697780")]
			set
			{
			}
		}

		// Token: 0x06004B61 RID: 19297 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B61")]
		[Address(RVA = "0x1694F70", Offset = "0x1693B70", VA = "0x181694F70", Slot = "7")]
		protected override void Awake()
		{
		}

		// Token: 0x06004B62 RID: 19298 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B62")]
		[Address(RVA = "0x1695870", Offset = "0x1694470", VA = "0x181695870")]
		public void OnEventTriggerPointerDown(BaseEventData baseEventData)
		{
		}

		// Token: 0x06004B63 RID: 19299 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B63")]
		[Address(RVA = "0x1696940", Offset = "0x1695540", VA = "0x181696940")]
		public void Update()
		{
		}

		// Token: 0x06004B64 RID: 19300 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B64")]
		[Address(RVA = "0x1695880", Offset = "0x1694480", VA = "0x181695880")]
		private void StartPinch()
		{
		}

		// Token: 0x06004B65 RID: 19301 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B65")]
		[Address(RVA = "0x1695CF0", Offset = "0x16948F0", VA = "0x181695CF0")]
		private void UpdatePinch()
		{
		}

		// Token: 0x06004B66 RID: 19302 RVA: 0x0002CE50 File Offset: 0x0002B050
		[Token(Token = "0x6004B66")]
		[Address(RVA = "0xF07D70", Offset = "0xF06970", VA = "0x180F07D70")]
		private float GetPinchDistance(Vector3 pos0, Vector3 pos1)
		{
			return 0f;
		}

		// Token: 0x06004B67 RID: 19303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B67")]
		[Address(RVA = "0x1695C80", Offset = "0x1694880", VA = "0x181695C80")]
		private void StopPinch()
		{
		}

		// Token: 0x06004B68 RID: 19304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B68")]
		[Address(RVA = "0x1695460", Offset = "0x1694060", VA = "0x181695460")]
		private void DragStart(Vector3 pos, bool isLongTap, bool isInitialDrag)
		{
		}

		// Token: 0x06004B69 RID: 19305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B69")]
		[Address(RVA = "0x16956D0", Offset = "0x16942D0", VA = "0x1816956D0")]
		private void DragUpdate(Vector3 pos)
		{
		}

		// Token: 0x06004B6A RID: 19306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B6A")]
		[Address(RVA = "0x1695500", Offset = "0x1694100", VA = "0x181695500")]
		private void DragStop(Vector3 pos)
		{
		}

		// Token: 0x06004B6B RID: 19307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B6B")]
		[Address(RVA = "0xF07D10", Offset = "0xF06910", VA = "0x180F07D10")]
		private void FingerDown(Vector3 pos)
		{
		}

		// Token: 0x06004B6C RID: 19308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B6C")]
		[Address(RVA = "0xF07D50", Offset = "0xF06950", VA = "0x180F07D50")]
		private void FingerUp()
		{
		}

		// Token: 0x06004B6D RID: 19309 RVA: 0x0002CE68 File Offset: 0x0002B068
		[Token(Token = "0x6004B6D")]
		[Address(RVA = "0xF07EE0", Offset = "0xF06AE0", VA = "0x180F07EE0")]
		private Vector3 GetTouchPositionRelative(Vector3 touchPosScreen)
		{
			return default(Vector3);
		}

		// Token: 0x06004B6E RID: 19310 RVA: 0x0002CE80 File Offset: 0x0002B080
		[Token(Token = "0x6004B6E")]
		[Address(RVA = "0xF07E10", Offset = "0xF06A10", VA = "0x180F07E10")]
		private float GetRelativeDragDistance(Vector3 pos0, Vector3 pos1)
		{
			return 0f;
		}

		// Token: 0x06004B6F RID: 19311 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004B6F")]
		[Address(RVA = "0x16976A0", Offset = "0x16962A0", VA = "0x1816976A0")]
		public TouchInputController()
		{
		}

		// Token: 0x04000F25 RID: 3877
		[Token(Token = "0x4000F25")]
		[FieldOffset(Offset = "0x80")]
		[Header("Expert Mode")]
		[SerializeField]
		private bool expertModeEnabled;

		// Token: 0x04000F26 RID: 3878
		[Token(Token = "0x4000F26")]
		[FieldOffset(Offset = "0x84")]
		[SerializeField]
		[Tooltip("When the finger is held on an item for at least this duration without moving, the gesture is recognized as a long tap.")]
		private float clickDurationThreshold;

		// Token: 0x04000F27 RID: 3879
		[Token(Token = "0x4000F27")]
		[FieldOffset(Offset = "0x88")]
		[SerializeField]
		[Tooltip("A double click gesture is recognized when the time between two consecutive taps is shorter than this duration.")]
		private float doubleclickDurationThreshold;

		// Token: 0x04000F28 RID: 3880
		[Token(Token = "0x4000F28")]
		[FieldOffset(Offset = "0x8C")]
		[SerializeField]
		[Tooltip("This value controls how close to a vertical line the user has to perform a tilt gesture for it to be recognized as such.")]
		private float tiltMoveDotTreshold;

		// Token: 0x04000F29 RID: 3881
		[Token(Token = "0x4000F29")]
		[FieldOffset(Offset = "0x90")]
		[SerializeField]
		[Tooltip("Threshold value for detecting whether the fingers are horizontal enough for starting the tilt. Using this value you can prevent vertical finger placement to be counted as tilt gesture.")]
		private float tiltHorizontalDotThreshold;

		// Token: 0x04000F2A RID: 3882
		[Token(Token = "0x4000F2A")]
		[FieldOffset(Offset = "0x94")]
		[SerializeField]
		[Tooltip("A drag is started as soon as the user moves his finger over a longer distance than this value. The value is defined as normalized value. Dragging the entire width of the screen equals 1. Dragging the entire height of the screen also equals 1.")]
		private float dragStartDistanceThresholdRelative;

		// Token: 0x04000F2B RID: 3883
		[Token(Token = "0x4000F2B")]
		[FieldOffset(Offset = "0x98")]
		[SerializeField]
		[Tooltip("When this flag is enabled the drag started event is invoked immediately when the long tap time is succeeded.")]
		private bool longTapStartsDrag;

		// Token: 0x04000F2C RID: 3884
		[Token(Token = "0x4000F2C")]
		[FieldOffset(Offset = "0x9C")]
		private float lastFingerDownTimeReal;

		// Token: 0x04000F2D RID: 3885
		[Token(Token = "0x4000F2D")]
		[FieldOffset(Offset = "0xA0")]
		private float lastClickTimeReal;

		// Token: 0x04000F2E RID: 3886
		[Token(Token = "0x4000F2E")]
		[FieldOffset(Offset = "0xA4")]
		private bool wasFingerDownLastFrame;

		// Token: 0x04000F2F RID: 3887
		[Token(Token = "0x4000F2F")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3 lastFinger0DownPos;

		// Token: 0x04000F30 RID: 3888
		[Token(Token = "0x4000F30")]
		private const float dragDurationThreshold = 0.01f;

		// Token: 0x04000F31 RID: 3889
		[Token(Token = "0x4000F31")]
		[FieldOffset(Offset = "0xB4")]
		private bool isDragging;

		// Token: 0x04000F32 RID: 3890
		[Token(Token = "0x4000F32")]
		[FieldOffset(Offset = "0xB8")]
		private Vector3 dragStartPos;

		// Token: 0x04000F33 RID: 3891
		[Token(Token = "0x4000F33")]
		[FieldOffset(Offset = "0xC4")]
		private Vector3 dragStartOffset;

		// Token: 0x04000F35 RID: 3893
		[Token(Token = "0x4000F35")]
		private const int momentumSamplesCount = 5;

		// Token: 0x04000F36 RID: 3894
		[Token(Token = "0x4000F36")]
		[FieldOffset(Offset = "0xD8")]
		private float pinchStartDistance;

		// Token: 0x04000F37 RID: 3895
		[Token(Token = "0x4000F37")]
		[FieldOffset(Offset = "0xE0")]
		private List<Vector3> pinchStartPositions;

		// Token: 0x04000F38 RID: 3896
		[Token(Token = "0x4000F38")]
		[FieldOffset(Offset = "0xE8")]
		private List<Vector3> touchPositionLastFrame;

		// Token: 0x04000F39 RID: 3897
		[Token(Token = "0x4000F39")]
		[FieldOffset(Offset = "0xF0")]
		private Vector3 pinchRotationVectorStart;

		// Token: 0x04000F3A RID: 3898
		[Token(Token = "0x4000F3A")]
		[FieldOffset(Offset = "0xFC")]
		private Vector3 pinchVectorLastFrame;

		// Token: 0x04000F3B RID: 3899
		[Token(Token = "0x4000F3B")]
		[FieldOffset(Offset = "0x108")]
		private float totalFingerMovement;

		// Token: 0x04000F3C RID: 3900
		[Token(Token = "0x4000F3C")]
		[FieldOffset(Offset = "0x10C")]
		private bool wasDraggingLastFrame;

		// Token: 0x04000F3D RID: 3901
		[Token(Token = "0x4000F3D")]
		[FieldOffset(Offset = "0x10D")]
		private bool wasPinchingLastFrame;

		// Token: 0x04000F3E RID: 3902
		[Token(Token = "0x4000F3E")]
		[FieldOffset(Offset = "0x10E")]
		private bool isPinching;

		// Token: 0x04000F3F RID: 3903
		[Token(Token = "0x4000F3F")]
		[FieldOffset(Offset = "0x10F")]
		private bool isInputOnLockedArea;

		// Token: 0x04000F40 RID: 3904
		[Token(Token = "0x4000F40")]
		[FieldOffset(Offset = "0x110")]
		private float timeSinceDragStart;

		// Token: 0x04000F41 RID: 3905
		[Token(Token = "0x4000F41")]
		[FieldOffset(Offset = "0x114")]
		private bool isClickPrevented;

		// Token: 0x04000F42 RID: 3906
		[Token(Token = "0x4000F42")]
		[FieldOffset(Offset = "0x115")]
		private bool isFingerDown;
	}
}
