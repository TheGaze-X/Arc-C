using System;
using System.Collections.Generic;
using AdvancedInspector;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.EventSystems;
using XLua;

namespace Torappu.Battle
{
	// Token: 0x020021A9 RID: 8617
	[Token(Token = "0x20021A9")]
	public class DraggableCameraPlugin : CameraController.Plugin
	{
		// Token: 0x17001A25 RID: 6693
		// (get) Token: 0x0600D719 RID: 55065 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001A25")]
		protected DraggableCameraPlugin.DragStatus status
		{
			[Token(Token = "0x600D719")]
			[Address(RVA = "0x35D7620", Offset = "0x35D6220", VA = "0x1835D7620")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A26 RID: 6694
		// (get) Token: 0x0600D71A RID: 55066 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001A26")]
		protected ConvexHull mapHull
		{
			[Token(Token = "0x600D71A")]
			[Address(RVA = "0x35D75C0", Offset = "0x35D61C0", VA = "0x1835D75C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17001A27 RID: 6695
		// (get) Token: 0x0600D71B RID: 55067 RVA: 0x0004DC70 File Offset: 0x0004BE70
		[Token(Token = "0x17001A27")]
		public bool dragEnabled
		{
			[Token(Token = "0x600D71B")]
			[Address(RVA = "0x35D7550", Offset = "0x35D6150", VA = "0x1835D7550")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600D71C RID: 55068 RVA: 0x0004DC88 File Offset: 0x0004BE88
		[Token(Token = "0x600D71C")]
		[Address(RVA = "0x35D4060", Offset = "0x35D2C60", VA = "0x1835D4060", Slot = "9")]
		public override Vector3 CalculateCameraOffset(Vector3 originPos)
		{
			return default(Vector3);
		}

		// Token: 0x17001A28 RID: 6696
		// (get) Token: 0x0600D71D RID: 55069 RVA: 0x0004DCA0 File Offset: 0x0004BEA0
		[Token(Token = "0x17001A28")]
		public override Vector2 audioVolumeSyncCameraPosRange
		{
			[Token(Token = "0x600D71D")]
			[Address(RVA = "0x35D74E0", Offset = "0x35D60E0", VA = "0x1835D74E0", Slot = "4")]
			get
			{
				return default(Vector2);
			}
		}

		// Token: 0x0600D71E RID: 55070 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D71E")]
		[Address(RVA = "0x35D4780", Offset = "0x35D3380", VA = "0x1835D4780")]
		public void PauseDrag(DraggableCameraPlugin.DragPauseReason reason, bool pause)
		{
		}

		// Token: 0x0600D71F RID: 55071 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D71F")]
		[Address(RVA = "0x35D5770", Offset = "0x35D4370", VA = "0x1835D5770", Slot = "13")]
		protected virtual void _InitIfNot()
		{
		}

		// Token: 0x0600D720 RID: 55072 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D720")]
		[Address(RVA = "0x35D5270", Offset = "0x35D3E70", VA = "0x1835D5270")]
		[Inspect]
		public void UpdateHull()
		{
		}

		// Token: 0x0600D721 RID: 55073 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D721")]
		[Address(RVA = "0x35D5320", Offset = "0x35D3F20", VA = "0x1835D5320")]
		private void Update()
		{
		}

		// Token: 0x0600D722 RID: 55074 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D722")]
		[Address(RVA = "0x35D6750", Offset = "0x35D5350", VA = "0x1835D6750", Slot = "14")]
		protected virtual void _OnBeginDrag(object arg)
		{
		}

		// Token: 0x0600D723 RID: 55075 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D723")]
		[Address(RVA = "0x35D6AF0", Offset = "0x35D56F0", VA = "0x1835D6AF0", Slot = "15")]
		protected virtual void _UpdateCamera()
		{
		}

		// Token: 0x0600D724 RID: 55076 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D724")]
		[Address(RVA = "0x35D6B50", Offset = "0x35D5750", VA = "0x1835D6B50")]
		private void _UpdateDragCamera()
		{
		}

		// Token: 0x0600D725 RID: 55077 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D725")]
		[Address(RVA = "0x35D4D00", Offset = "0x35D3900", VA = "0x1835D4D00")]
		protected void ResetCameraWithinHull()
		{
		}

		// Token: 0x0600D726 RID: 55078 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D726")]
		[Address(RVA = "0x35D6990", Offset = "0x35D5590", VA = "0x1835D6990")]
		private void _ReleaseDrag()
		{
		}

		// Token: 0x0600D727 RID: 55079 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D727")]
		[Address(RVA = "0x35D5CB0", Offset = "0x35D48B0", VA = "0x1835D5CB0")]
		private void _MoveCamera(Vector2 screenPosCurFrame)
		{
		}

		// Token: 0x0600D728 RID: 55080 RVA: 0x0004DCB8 File Offset: 0x0004BEB8
		[Token(Token = "0x600D728")]
		[Address(RVA = "0x35D5410", Offset = "0x35D4010", VA = "0x1835D5410")]
		private Vector2 _CalcScreenDragOffset(Vector2 screenPosCurFrame, float deltaTime)
		{
			return default(Vector2);
		}

		// Token: 0x0600D729 RID: 55081 RVA: 0x0004DCD0 File Offset: 0x0004BED0
		[Token(Token = "0x600D729")]
		[Address(RVA = "0x35D4420", Offset = "0x35D3020", VA = "0x1835D4420", Slot = "12")]
		public override bool IsValidPut(int touchId)
		{
			return default(bool);
		}

		// Token: 0x0600D72A RID: 55082 RVA: 0x0004DCE8 File Offset: 0x0004BEE8
		[Token(Token = "0x600D72A")]
		[Address(RVA = "0x35D41F0", Offset = "0x35D2DF0", VA = "0x1835D41F0")]
		public Vector2 GetPosInHull(Vector2 targetPos)
		{
			return default(Vector2);
		}

		// Token: 0x0600D72B RID: 55083 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D72B")]
		[Address(RVA = "0x35D4830", Offset = "0x35D3430", VA = "0x1835D4830", Slot = "11")]
		public override void PutDown(Transform ts)
		{
		}

		// Token: 0x0600D72C RID: 55084 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D72C")]
		[Address(RVA = "0x35D4720", Offset = "0x35D3320", VA = "0x1835D4720", Slot = "16")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x0600D72D RID: 55085 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D72D")]
		[Address(RVA = "0x35D6A50", Offset = "0x35D5650", VA = "0x1835D6A50")]
		protected void _ResetControllerTween()
		{
		}

		// Token: 0x0600D72E RID: 55086 RVA: 0x0004DD00 File Offset: 0x0004BF00
		[Token(Token = "0x600D72E")]
		[Address(RVA = "0x35D3CA0", Offset = "0x35D28A0", VA = "0x1835D3CA0", Slot = "8")]
		public override Vector3 CalculateCameraFocusPos(Vector3 targetPos)
		{
			return default(Vector3);
		}

		// Token: 0x0600D72F RID: 55087 RVA: 0x0004DD18 File Offset: 0x0004BF18
		[Token(Token = "0x600D72F")]
		[Address(RVA = "0x35D5B80", Offset = "0x35D4780", VA = "0x1835D5B80")]
		private bool _IsDragStateValid(out Vector2 screenPos)
		{
			return default(bool);
		}

		// Token: 0x0600D730 RID: 55088 RVA: 0x0004DD30 File Offset: 0x0004BF30
		[Token(Token = "0x600D730")]
		[Address(RVA = "0x35D4390", Offset = "0x35D2F90", VA = "0x1835D4390", Slot = "17")]
		protected virtual bool IsDragValidState()
		{
			return default(bool);
		}

		// Token: 0x0600D731 RID: 55089 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600D731")]
		[Address(RVA = "0x35D55A0", Offset = "0x35D41A0", VA = "0x1835D55A0")]
		private List<Vector2> _GetMapCorners()
		{
			return null;
		}

		// Token: 0x0600D732 RID: 55090 RVA: 0x0004DD48 File Offset: 0x0004BF48
		[Token(Token = "0x600D732")]
		[Address(RVA = "0x35D59F0", Offset = "0x35D45F0", VA = "0x1835D59F0")]
		private bool _IsCornerVertex(int row, int col)
		{
			return default(bool);
		}

		// Token: 0x0600D733 RID: 55091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D733")]
		[Address(RVA = "0x35D4130", Offset = "0x35D2D30", VA = "0x1835D4130", Slot = "6")]
		public override void DoAdaptCameraPosition()
		{
		}

		// Token: 0x0600D734 RID: 55092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D734")]
		[Address(RVA = "0x35D72C0", Offset = "0x35D5EC0", VA = "0x1835D72C0")]
		public DraggableCameraPlugin()
		{
		}

		// Token: 0x0600D735 RID: 55093 RVA: 0x0004DD60 File Offset: 0x0004BF60
		[Token(Token = "0x600D735")]
		[Address(RVA = "0x35D5010", Offset = "0x35D3C10", VA = "0x1835D5010")]
		private Vector3 <>xLuaBaseProxy_CalculateCameraOffset(Vector3 P0)
		{
			return default(Vector3);
		}

		// Token: 0x0600D736 RID: 55094 RVA: 0x0004DD78 File Offset: 0x0004BF78
		[Token(Token = "0x600D736")]
		[Address(RVA = "0x35D51E0", Offset = "0x35D3DE0", VA = "0x1835D51E0")]
		private Vector2 <>xLuaBaseProxy_get_audioVolumeSyncCameraPosRange()
		{
			return default(Vector2);
		}

		// Token: 0x0600D737 RID: 55095 RVA: 0x0004DD90 File Offset: 0x0004BF90
		[Token(Token = "0x600D737")]
		[Address(RVA = "0x35D5110", Offset = "0x35D3D10", VA = "0x1835D5110")]
		private bool <>xLuaBaseProxy_IsValidPut(int P0)
		{
			return default(bool);
		}

		// Token: 0x0600D738 RID: 55096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D738")]
		[Address(RVA = "0x35D5180", Offset = "0x35D3D80", VA = "0x1835D5180")]
		private void <>xLuaBaseProxy_PutDown(Transform P0)
		{
		}

		// Token: 0x0600D739 RID: 55097 RVA: 0x0004DDA8 File Offset: 0x0004BFA8
		[Token(Token = "0x600D739")]
		[Address(RVA = "0x35D4F70", Offset = "0x35D3B70", VA = "0x1835D4F70")]
		private Vector3 <>xLuaBaseProxy_CalculateCameraFocusPos(Vector3 P0)
		{
			return default(Vector3);
		}

		// Token: 0x0600D73A RID: 55098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600D73A")]
		[Address(RVA = "0x35D50B0", Offset = "0x35D3CB0", VA = "0x1835D50B0")]
		private void <>xLuaBaseProxy_DoAdaptCameraPosition()
		{
		}

		// Token: 0x0400E768 RID: 59240
		[Token(Token = "0x400E768")]
		private const string BANNED_PUTDOWN_UI_TAG = "BattleUICard";

		// Token: 0x0400E769 RID: 59241
		[Token(Token = "0x400E769")]
		protected const int RELEASE_FRAME = 5;

		// Token: 0x0400E76A RID: 59242
		[Token(Token = "0x400E76A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _enableSlowMotion;

		// Token: 0x0400E76B RID: 59243
		[Token(Token = "0x400E76B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private float _dragScale;

		// Token: 0x0400E76C RID: 59244
		[Token(Token = "0x400E76C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _focusDistance;

		// Token: 0x0400E76D RID: 59245
		[Token(Token = "0x400E76D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _focusTime;

		// Token: 0x0400E76E RID: 59246
		[Token(Token = "0x400E76E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _focusRange;

		// Token: 0x0400E76F RID: 59247
		[Token(Token = "0x400E76F")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Ease _easeType;

		// Token: 0x0400E770 RID: 59248
		[Token(Token = "0x400E770")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _fallBackSmoothTime;

		// Token: 0x0400E771 RID: 59249
		[Token(Token = "0x400E771")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private Vector2 _resizeWH;

		// Token: 0x0400E772 RID: 59250
		[Token(Token = "0x400E772")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private float _resolutionWidth;

		// Token: 0x0400E773 RID: 59251
		[Token(Token = "0x400E773")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private DraggableCameraPlugin.DragMode _dragMode;

		// Token: 0x0400E774 RID: 59252
		[Token(Token = "0x400E774")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private Vector2 _audioVolumeSyncCameraPosRange;

		// Token: 0x0400E775 RID: 59253
		[Token(Token = "0x400E775")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[Group("SmoothScroll")]
		private bool _enableSmooth;

		// Token: 0x0400E776 RID: 59254
		[Token(Token = "0x400E776")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Group("SmoothScroll")]
		private float _smoothFollowFactor;

		// Token: 0x0400E777 RID: 59255
		[Token(Token = "0x400E777")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		[Group("ScreenDragMode")]
		private AnimationCurve _smoothStepCurve;

		// Token: 0x0400E778 RID: 59256
		[Token(Token = "0x400E778")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Group("ScreenDragMode")]
		private float _smoothStepScale;

		// Token: 0x0400E779 RID: 59257
		[Token(Token = "0x400E779")]
		[FieldOffset(Offset = "0x6C")]
		[SerializeField]
		[Group("ScreenDragMode")]
		private float _cameHeightFactor;

		// Token: 0x0400E77A RID: 59258
		[Token(Token = "0x400E77A")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private AnimationCurve _releaseCurve;

		// Token: 0x0400E77B RID: 59259
		[Token(Token = "0x400E77B")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private float _releaseTime;

		// Token: 0x0400E77C RID: 59260
		[Token(Token = "0x400E77C")]
		[FieldOffset(Offset = "0x80")]
		private Tween m_tween;

		// Token: 0x0400E77D RID: 59261
		[Token(Token = "0x400E77D")]
		[FieldOffset(Offset = "0x88")]
		private bool m_inited;

		// Token: 0x0400E77E RID: 59262
		[Token(Token = "0x400E77E")]
		[FieldOffset(Offset = "0x89")]
		private bool m_dragEnabled;

		// Token: 0x0400E77F RID: 59263
		[Token(Token = "0x400E77F")]
		[FieldOffset(Offset = "0x8C")]
		private int m_dragPausedMask;

		// Token: 0x0400E780 RID: 59264
		[Token(Token = "0x400E780")]
		[FieldOffset(Offset = "0x90")]
		private PointerEventData m_pointer;

		// Token: 0x0400E781 RID: 59265
		[Token(Token = "0x400E781")]
		[FieldOffset(Offset = "0x98")]
		private List<RaycastResult> m_rayCastCache;

		// Token: 0x0400E782 RID: 59266
		[Token(Token = "0x400E782")]
		[FieldOffset(Offset = "0xA0")]
		private float m_resolutionScale;

		// Token: 0x0400E783 RID: 59267
		[Token(Token = "0x400E783")]
		[FieldOffset(Offset = "0xA4")]
		private Vector3 m_followCurrentVelocity;

		// Token: 0x0400E784 RID: 59268
		[Token(Token = "0x400E784")]
		[FieldOffset(Offset = "0xB0")]
		private DraggableCameraPlugin.DragStatus m_status;

		// Token: 0x0400E785 RID: 59269
		[Token(Token = "0x400E785")]
		[FieldOffset(Offset = "0xB8")]
		private ConvexHull m_mapHull;

		// Token: 0x0400E786 RID: 59270
		[Token(Token = "0x400E786")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_status;

		// Token: 0x0400E787 RID: 59271
		[Token(Token = "0x400E787")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_mapHull;

		// Token: 0x0400E788 RID: 59272
		[Token(Token = "0x400E788")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_dragEnabled;

		// Token: 0x0400E789 RID: 59273
		[Token(Token = "0x400E789")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CalculateCameraOffset;

		// Token: 0x0400E78A RID: 59274
		[Token(Token = "0x400E78A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_audioVolumeSyncCameraPosRange;

		// Token: 0x0400E78B RID: 59275
		[Token(Token = "0x400E78B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_PauseDrag;

		// Token: 0x0400E78C RID: 59276
		[Token(Token = "0x400E78C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0400E78D RID: 59277
		[Token(Token = "0x400E78D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_UpdateHull;

		// Token: 0x0400E78E RID: 59278
		[Token(Token = "0x400E78E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x0400E78F RID: 59279
		[Token(Token = "0x400E78F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0__OnBeginDrag;

		// Token: 0x0400E790 RID: 59280
		[Token(Token = "0x400E790")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0__UpdateCamera;

		// Token: 0x0400E791 RID: 59281
		[Token(Token = "0x400E791")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0__UpdateDragCamera;

		// Token: 0x0400E792 RID: 59282
		[Token(Token = "0x400E792")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge __Hotfix0_ResetCameraWithinHull;

		// Token: 0x0400E793 RID: 59283
		[Token(Token = "0x400E793")]
		[FieldOffset(Offset = "0x68")]
		private static DelegateBridge __Hotfix0__ReleaseDrag;

		// Token: 0x0400E794 RID: 59284
		[Token(Token = "0x400E794")]
		[FieldOffset(Offset = "0x70")]
		private static DelegateBridge __Hotfix0__MoveCamera;

		// Token: 0x0400E795 RID: 59285
		[Token(Token = "0x400E795")]
		[FieldOffset(Offset = "0x78")]
		private static DelegateBridge __Hotfix0__CalcScreenDragOffset;

		// Token: 0x0400E796 RID: 59286
		[Token(Token = "0x400E796")]
		[FieldOffset(Offset = "0x80")]
		private static DelegateBridge __Hotfix0_IsValidPut;

		// Token: 0x0400E797 RID: 59287
		[Token(Token = "0x400E797")]
		[FieldOffset(Offset = "0x88")]
		private static DelegateBridge __Hotfix0_GetPosInHull;

		// Token: 0x0400E798 RID: 59288
		[Token(Token = "0x400E798")]
		[FieldOffset(Offset = "0x90")]
		private static DelegateBridge __Hotfix0_PutDown;

		// Token: 0x0400E799 RID: 59289
		[Token(Token = "0x400E799")]
		[FieldOffset(Offset = "0x98")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0400E79A RID: 59290
		[Token(Token = "0x400E79A")]
		[FieldOffset(Offset = "0xA0")]
		private static DelegateBridge __Hotfix0__ResetControllerTween;

		// Token: 0x0400E79B RID: 59291
		[Token(Token = "0x400E79B")]
		[FieldOffset(Offset = "0xA8")]
		private static DelegateBridge __Hotfix0_CalculateCameraFocusPos;

		// Token: 0x0400E79C RID: 59292
		[Token(Token = "0x400E79C")]
		[FieldOffset(Offset = "0xB0")]
		private static DelegateBridge __Hotfix0__IsDragStateValid;

		// Token: 0x0400E79D RID: 59293
		[Token(Token = "0x400E79D")]
		[FieldOffset(Offset = "0xB8")]
		private static DelegateBridge __Hotfix0_IsDragValidState;

		// Token: 0x0400E79E RID: 59294
		[Token(Token = "0x400E79E")]
		[FieldOffset(Offset = "0xC0")]
		private static DelegateBridge __Hotfix0__GetMapCorners;

		// Token: 0x0400E79F RID: 59295
		[Token(Token = "0x400E79F")]
		[FieldOffset(Offset = "0xC8")]
		private static DelegateBridge __Hotfix0__IsCornerVertex;

		// Token: 0x0400E7A0 RID: 59296
		[Token(Token = "0x400E7A0")]
		[FieldOffset(Offset = "0xD0")]
		private static DelegateBridge __Hotfix0_DoAdaptCameraPosition;

		// Token: 0x0400E7A1 RID: 59297
		[Token(Token = "0x400E7A1")]
		[FieldOffset(Offset = "0xD8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x020021AA RID: 8618
		[Token(Token = "0x20021AA")]
		protected enum DragMode
		{
			// Token: 0x0400E7A3 RID: 59299
			[Token(Token = "0x400E7A3")]
			SCREEN_MODE,
			// Token: 0x0400E7A4 RID: 59300
			[Token(Token = "0x400E7A4")]
			WORLD_MODE
		}

		// Token: 0x020021AB RID: 8619
		[Token(Token = "0x20021AB")]
		public enum DragPauseReason
		{
			// Token: 0x0400E7A6 RID: 59302
			[Token(Token = "0x400E7A6")]
			NONE,
			// Token: 0x0400E7A7 RID: 59303
			[Token(Token = "0x400E7A7")]
			BATTLE_AVG,
			// Token: 0x0400E7A8 RID: 59304
			[Token(Token = "0x400E7A8")]
			BATTLE_AVG_OLD_MOVE_CAMERA,
			// Token: 0x0400E7A9 RID: 59305
			[Token(Token = "0x400E7A9")]
			BATTLE_AVG_OLD_LOCK_CAMERA,
			// Token: 0x0400E7AA RID: 59306
			[Token(Token = "0x400E7AA")]
			CONSTRUCT_UI_LOCK,
			// Token: 0x0400E7AB RID: 59307
			[Token(Token = "0x400E7AB")]
			LEVEL_INVALID,
			// Token: 0x0400E7AC RID: 59308
			[Token(Token = "0x400E7AC")]
			FOLLOW_TARGET
		}

		// Token: 0x020021AC RID: 8620
		[Token(Token = "0x20021AC")]
		protected class DragStatus
		{
			// Token: 0x0600D73B RID: 55099 RVA: 0x0004DDC0 File Offset: 0x0004BFC0
			[Token(Token = "0x600D73B")]
			[Address(RVA = "0x4E6300", Offset = "0x4E4F00", VA = "0x1804E6300")]
			public bool IsValid()
			{
				return default(bool);
			}

			// Token: 0x0600D73C RID: 55100 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x600D73C")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public DragStatus()
			{
			}

			// Token: 0x0400E7AD RID: 59309
			[Token(Token = "0x400E7AD")]
			[FieldOffset(Offset = "0x10")]
			public bool isDragging;

			// Token: 0x0400E7AE RID: 59310
			[Token(Token = "0x400E7AE")]
			[FieldOffset(Offset = "0x11")]
			public bool isInFocus;

			// Token: 0x0400E7AF RID: 59311
			[Token(Token = "0x400E7AF")]
			[FieldOffset(Offset = "0x14")]
			public int fingerId;

			// Token: 0x0400E7B0 RID: 59312
			[Token(Token = "0x400E7B0")]
			[FieldOffset(Offset = "0x18")]
			public float time;

			// Token: 0x0400E7B1 RID: 59313
			[Token(Token = "0x400E7B1")]
			[FieldOffset(Offset = "0x1C")]
			public Vector2 lastPos;

			// Token: 0x0400E7B2 RID: 59314
			[Token(Token = "0x400E7B2")]
			[FieldOffset(Offset = "0x24")]
			public Vector3 startPos;

			// Token: 0x0400E7B3 RID: 59315
			[Token(Token = "0x400E7B3")]
			[FieldOffset(Offset = "0x30")]
			public Vector3 startCamPos;

			// Token: 0x0400E7B4 RID: 59316
			[Token(Token = "0x400E7B4")]
			[FieldOffset(Offset = "0x3C")]
			public Vector3 targetCamPos;

			// Token: 0x0400E7B5 RID: 59317
			[Token(Token = "0x400E7B5")]
			[FieldOffset(Offset = "0x48")]
			public List<Vector2> movementQueue;
		}

		// Token: 0x020021AD RID: 8621
		[Token(Token = "0x20021AD")]
		[Hotfix(HotfixFlag.Stateless)]
		protected static class WorldDragMode
		{
			// Token: 0x0600D73D RID: 55101 RVA: 0x0004DDD8 File Offset: 0x0004BFD8
			[Token(Token = "0x600D73D")]
			[Address(RVA = "0x35D9C60", Offset = "0x35D8860", VA = "0x1835D9C60")]
			public static Vector2 CalcDragOffset(Camera camera, DraggableCameraPlugin.DragStatus status, Vector2 screenPosCurFrame, Vector3 camPosCurFrame)
			{
				return default(Vector2);
			}

			// Token: 0x0600D73E RID: 55102 RVA: 0x0004DDF0 File Offset: 0x0004BFF0
			[Token(Token = "0x600D73E")]
			[Address(RVA = "0x35D9E50", Offset = "0x35D8A50", VA = "0x1835D9E50")]
			private static bool _ConvertToWorldPos(Camera camera, Vector3 screenPos, out Vector3 worldPos)
			{
				return default(bool);
			}

			// Token: 0x0400E7B6 RID: 59318
			[Token(Token = "0x400E7B6")]
			[FieldOffset(Offset = "0x0")]
			private static readonly Plane WORLD_PLANE;

			// Token: 0x0400E7B7 RID: 59319
			[Token(Token = "0x400E7B7")]
			[FieldOffset(Offset = "0x10")]
			private static DelegateBridge __Hotfix0_CalcDragOffset;

			// Token: 0x0400E7B8 RID: 59320
			[Token(Token = "0x400E7B8")]
			[FieldOffset(Offset = "0x18")]
			private static DelegateBridge __Hotfix0__ConvertToWorldPos;
		}
	}
}
