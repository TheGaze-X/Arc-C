using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace BitBenderGames
{
	// Token: 0x02000452 RID: 1106
	[Token(Token = "0x2000452")]
	[RequireComponent(typeof(MobileTouchCamera))]
	public class MobilePickingController : MonoBehaviour
	{
		// Token: 0x17000182 RID: 386
		// (get) Token: 0x06004A49 RID: 19017 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000182")]
		private Component SelectedCollider
		{
			[Token(Token = "0x6004A49")]
			[Address(RVA = "0x168B850", Offset = "0x168A450", VA = "0x18168B850")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x06004A4A RID: 19018 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004A4B RID: 19019 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000183")]
		public List<Component> SelectedColliders
		{
			[Token(Token = "0x6004A4A")]
			[Address(RVA = "0xEB4B80", Offset = "0xEB3780", VA = "0x180EB4B80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A4B")]
			[Address(RVA = "0xEDF350", Offset = "0xEDDF50", VA = "0x180EDF350")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06004A4C RID: 19020 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06004A4D RID: 19021 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000184")]
		public MobileTouchPickable CurrentlyDraggedPickable
		{
			[Token(Token = "0x6004A4C")]
			[Address(RVA = "0xEB4B60", Offset = "0xEB3760", VA = "0x180EB4B60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6004A4D")]
			[Address(RVA = "0x168B8E0", Offset = "0x168A4E0", VA = "0x18168B8E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06004A4E RID: 19022 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000185")]
		private Transform CurrentlyDraggedTransform
		{
			[Token(Token = "0x6004A4E")]
			[Address(RVA = "0x168B7C0", Offset = "0x168A3C0", VA = "0x18168B7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06004A4F RID: 19023 RVA: 0x0002C6E8 File Offset: 0x0002A8E8
		// (set) Token: 0x06004A50 RID: 19024 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000186")]
		public bool SnapToGrid
		{
			[Token(Token = "0x6004A4F")]
			[Address(RVA = "0x4F4E70", Offset = "0x4F3A70", VA = "0x1804F4E70")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A50")]
			[Address(RVA = "0x4F4E80", Offset = "0x4F3A80", VA = "0x1804F4E80")]
			set
			{
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06004A51 RID: 19025 RVA: 0x0002C700 File Offset: 0x0002A900
		// (set) Token: 0x06004A52 RID: 19026 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000187")]
		public SnapAngle SnapAngle
		{
			[Token(Token = "0x6004A51")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return SnapAngle.Straight_0_Degrees;
			}
			[Token(Token = "0x6004A52")]
			[Address(RVA = "0x4EF630", Offset = "0x4EE230", VA = "0x1804EF630")]
			set
			{
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06004A53 RID: 19027 RVA: 0x0002C718 File Offset: 0x0002A918
		// (set) Token: 0x06004A54 RID: 19028 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000188")]
		public float SnapUnitSize
		{
			[Token(Token = "0x6004A53")]
			[Address(RVA = "0xB62660", Offset = "0xB61260", VA = "0x180B62660")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6004A54")]
			[Address(RVA = "0x168B900", Offset = "0x168A500", VA = "0x18168B900")]
			set
			{
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06004A55 RID: 19029 RVA: 0x0002C730 File Offset: 0x0002A930
		// (set) Token: 0x06004A56 RID: 19030 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000189")]
		public Vector2 SnapOffset
		{
			[Token(Token = "0x6004A55")]
			[Address(RVA = "0x168B8C0", Offset = "0x168A4C0", VA = "0x18168B8C0")]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6004A56")]
			[Address(RVA = "0xEFAAF0", Offset = "0xEF96F0", VA = "0x180EFAAF0")]
			set
			{
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06004A57 RID: 19031 RVA: 0x0002C748 File Offset: 0x0002A948
		// (set) Token: 0x06004A58 RID: 19032 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x1700018A")]
		public bool IsMultiSelectionEnabled
		{
			[Token(Token = "0x6004A57")]
			[Address(RVA = "0x4EF600", Offset = "0x4EE200", VA = "0x1804EF600")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6004A58")]
			[Address(RVA = "0x168B8F0", Offset = "0x168A4F0", VA = "0x18168B8F0")]
			set
			{
			}
		}

		// Token: 0x06004A59 RID: 19033 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A59")]
		[Address(RVA = "0x1687DF0", Offset = "0x16869F0", VA = "0x181687DF0")]
		public void Awake()
		{
		}

		// Token: 0x06004A5A RID: 19034 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A5A")]
		[Address(RVA = "0x168B0B0", Offset = "0x1689CB0", VA = "0x18168B0B0")]
		public void Start()
		{
		}

		// Token: 0x06004A5B RID: 19035 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A5B")]
		[Address(RVA = "0x16899C0", Offset = "0x16885C0", VA = "0x1816899C0")]
		public void OnDestroy()
		{
		}

		// Token: 0x06004A5C RID: 19036 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A5C")]
		[Address(RVA = "0x1689970", Offset = "0x1688570", VA = "0x181689970")]
		public void LateUpdate()
		{
		}

		// Token: 0x06004A5D RID: 19037 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A5D")]
		[Address(RVA = "0x168AE30", Offset = "0x1689A30", VA = "0x18168AE30")]
		public void SelectCollider(Component collider)
		{
		}

		// Token: 0x06004A5E RID: 19038 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A5E")]
		[Address(RVA = "0x1688830", Offset = "0x1687430", VA = "0x181688830")]
		public void DeselectSelectedCollider()
		{
		}

		// Token: 0x06004A5F RID: 19039 RVA: 0x0002C760 File Offset: 0x0002A960
		[Token(Token = "0x6004A5F")]
		[Address(RVA = "0x16888A0", Offset = "0x16874A0", VA = "0x1816888A0")]
		private bool Deselect(Component colliderComponent)
		{
			return default(bool);
		}

		// Token: 0x06004A60 RID: 19040 RVA: 0x0002C778 File Offset: 0x0002A978
		[Token(Token = "0x6004A60")]
		[Address(RVA = "0x1688500", Offset = "0x1687100", VA = "0x181688500")]
		public int DeselectAll()
		{
			return 0;
		}

		// Token: 0x06004A61 RID: 19041 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A61")]
		[Address(RVA = "0x1688AD0", Offset = "0x16876D0", VA = "0x181688AD0")]
		public Component GetClosestColliderAtScreenPoint(Vector3 screenPoint, out Vector3 intersectionPoint)
		{
			return null;
		}

		// Token: 0x06004A62 RID: 19042 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A62")]
		[Address(RVA = "0x168A070", Offset = "0x1688C70", VA = "0x18168A070")]
		public void RequestDragPickable(Component colliderComponent)
		{
		}

		// Token: 0x06004A63 RID: 19043 RVA: 0x0002C790 File Offset: 0x0002A990
		[Token(Token = "0x6004A63")]
		[Address(RVA = "0x1688D70", Offset = "0x1687970", VA = "0x181688D70")]
		public Vector3 GetFinger0PosWorld()
		{
			return default(Vector3);
		}

		// Token: 0x06004A64 RID: 19044 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A64")]
		[Address(RVA = "0x168AC40", Offset = "0x1689840", VA = "0x18168AC40")]
		private void SelectColliderInternal(Component colliderComponent, bool isDoubleClick, bool isLongTap)
		{
		}

		// Token: 0x06004A65 RID: 19045 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A65")]
		[Address(RVA = "0x1689830", Offset = "0x1688430", VA = "0x181689830")]
		private void InputControllerOnInputClick(Vector3 clickPosition, bool isDoubleClick, bool isLongTap)
		{
		}

		// Token: 0x06004A66 RID: 19046 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A66")]
		[Address(RVA = "0x168A250", Offset = "0x1688E50", VA = "0x18168A250")]
		private void RequestDragPickable(Vector3 fingerDownPos)
		{
		}

		// Token: 0x06004A67 RID: 19047 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A67")]
		[Address(RVA = "0x168A3A0", Offset = "0x1688FA0", VA = "0x18168A3A0")]
		private void RequestDragPickable(Component colliderComponent, Vector2 fingerDownPos, Vector3 intersectionPoint)
		{
		}

		// Token: 0x06004A68 RID: 19048 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A68")]
		[Address(RVA = "0x16897F0", Offset = "0x16883F0", VA = "0x1816897F0")]
		private void InputControllerOnFingerDown(Vector3 fingerDownPos)
		{
		}

		// Token: 0x06004A69 RID: 19049 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A69")]
		[Address(RVA = "0x1689160", Offset = "0x1687D60", VA = "0x181689160")]
		private void InputControllerOnFingerUp()
		{
		}

		// Token: 0x06004A6A RID: 19050 RVA: 0x0002C7A8 File Offset: 0x0002A9A8
		[Token(Token = "0x6004A6A")]
		[Address(RVA = "0x1688270", Offset = "0x1686E70", VA = "0x181688270")]
		private Vector3 ComputeDragPosition(Vector3 dragPosCurrent, bool clampToGrid)
		{
			return default(Vector3);
		}

		// Token: 0x06004A6B RID: 19051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A6B")]
		[Address(RVA = "0x1688FC0", Offset = "0x1687BC0", VA = "0x181688FC0")]
		private void InputControllerOnDragStart(Vector3 clickPosition, bool isLongTap)
		{
		}

		// Token: 0x06004A6C RID: 19052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A6C")]
		[Address(RVA = "0x1689170", Offset = "0x1687D70", VA = "0x181689170")]
		private void InputControllerOnDragUpdate(Vector3 dragPosStart, Vector3 dragPosCurrent, Vector3 correctionOffset)
		{
		}

		// Token: 0x06004A6D RID: 19053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A6D")]
		[Address(RVA = "0x16898B0", Offset = "0x16884B0", VA = "0x1816898B0")]
		private void InvokePickableMoveStart()
		{
		}

		// Token: 0x06004A6E RID: 19054 RVA: 0x0002C7C0 File Offset: 0x0002A9C0
		[Token(Token = "0x6004A6E")]
		[Address(RVA = "0x1688230", Offset = "0x1686E30", VA = "0x181688230")]
		private float ComputeDistance2d(float x0, float y0, float x1, float y1)
		{
			return 0f;
		}

		// Token: 0x06004A6F RID: 19055 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A6F")]
		[Address(RVA = "0x1689160", Offset = "0x1687D60", VA = "0x181689160")]
		private void InputControllerOnDragStop(Vector3 dragStopPos, Vector3 dragFinalMomentum)
		{
		}

		// Token: 0x06004A70 RID: 19056 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A70")]
		[Address(RVA = "0x16889D0", Offset = "0x16875D0", VA = "0x1816889D0")]
		private void EndPickableTransformMove()
		{
		}

		// Token: 0x06004A71 RID: 19057 RVA: 0x0002C7D8 File Offset: 0x0002A9D8
		[Token(Token = "0x6004A71")]
		[Address(RVA = "0x1687F90", Offset = "0x1686B90", VA = "0x181687F90")]
		private Vector3 ClampDragPosition(MobileTouchPickable draggedPickable, Vector3 position)
		{
			return default(Vector3);
		}

		// Token: 0x06004A72 RID: 19058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A72")]
		[Address(RVA = "0x168ABA0", Offset = "0x16897A0", VA = "0x18168ABA0")]
		private void RotateVector2(ref float x, ref float y, float degrees)
		{
		}

		// Token: 0x06004A73 RID: 19059 RVA: 0x0002C7F0 File Offset: 0x0002A9F0
		[Token(Token = "0x6004A73")]
		[Address(RVA = "0x1688EA0", Offset = "0x1687AA0", VA = "0x181688EA0")]
		private float GetPositionSnapped(float position, float snapOffset)
		{
			return 0f;
		}

		// Token: 0x06004A74 RID: 19060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A74")]
		[Address(RVA = "0x1689FB0", Offset = "0x1688BB0", VA = "0x181689FB0")]
		private void OnSelectedColliderChanged(MobilePickingController.SelectionAction selectionAction, MobileTouchPickable mobileTouchPickable)
		{
		}

		// Token: 0x06004A75 RID: 19061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A75")]
		[Address(RVA = "0x1689EC0", Offset = "0x1688AC0", VA = "0x181689EC0")]
		private void OnSelectedColliderChangedExtended(MobilePickingController.SelectionAction selectionAction, MobileTouchPickable mobileTouchPickable, bool isDoubleClick, bool isLongTap)
		{
		}

		// Token: 0x06004A76 RID: 19062 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A76")]
		[Address(RVA = "0x1689920", Offset = "0x1688520", VA = "0x181689920")]
		private void InvokeTransformActionSafe(UnityEventWithTransform eventAction, Transform selectionTransform)
		{
		}

		// Token: 0x06004A77 RID: 19063 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A77")]
		private void InvokeGenericActionSafe<T1, T2>(T1 eventAction, T2 eventArgs) where T1 : UnityEvent<T2>
		{
		}

		// Token: 0x06004A78 RID: 19064 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A78")]
		[Address(RVA = "0x168AE70", Offset = "0x1689A70", VA = "0x18168AE70")]
		private void Select(Component colliderComponent, bool isDoubleClick, bool isLongTap)
		{
		}

		// Token: 0x06004A79 RID: 19065 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A79")]
		[Address(RVA = "0x168B5B0", Offset = "0x168A1B0", VA = "0x18168B5B0")]
		public MobilePickingController()
		{
		}

		// Token: 0x04000E74 RID: 3700
		[Token(Token = "0x4000E74")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		[Tooltip("When set to true, the position of dragged items snaps to discrete units.")]
		private bool snapToGrid;

		// Token: 0x04000E75 RID: 3701
		[Token(Token = "0x4000E75")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		[Tooltip("Size of the snap units when snapToGrid is enabled.")]
		private float snapUnitSize;

		// Token: 0x04000E76 RID: 3702
		[Token(Token = "0x4000E76")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Tooltip("When snapping is enabled, this value defines a position offset that is added to the center of the object when dragging. When a top-down camera is used, these 2 values are applied to the X/Z position.")]
		private Vector2 snapOffset;

		// Token: 0x04000E77 RID: 3703
		[Token(Token = "0x4000E77")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("When set to Straight, picked items will be snapped to a perfectly horizontal and vertical grid in world space. Diagonal snaps the items on a 45 degree grid.")]
		private SnapAngle snapAngle;

		// Token: 0x04000E78 RID: 3704
		[Token(Token = "0x4000E78")]
		[FieldOffset(Offset = "0x2C")]
		[Header("Advanced")]
		[SerializeField]
		[Tooltip("When this flag is enabled, more than one item can be selected and moved at the same time.")]
		private bool isMultiSelectionEnabled;

		// Token: 0x04000E79 RID: 3705
		[Token(Token = "0x4000E79")]
		[FieldOffset(Offset = "0x2D")]
		[SerializeField]
		[Tooltip("When setting this variable to true, pickables can only be moved by long tapping on them first.")]
		private bool requireLongTapForMove;

		// Token: 0x04000E7A RID: 3706
		[Token(Token = "0x4000E7A")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("Here you can set up callbacks to be invoked when a pickable transform is selected.")]
		[Header("Event Callbacks")]
		[SerializeField]
		private UnityEventWithTransform OnPickableTransformSelected;

		// Token: 0x04000E7B RID: 3707
		[Token(Token = "0x4000E7B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[Tooltip("Here you can set up callbacks to be invoked when a pickable transform is selected through a long tap.")]
		private UnityEventWithPickableSelected OnPickableTransformSelectedExtended;

		// Token: 0x04000E7C RID: 3708
		[Token(Token = "0x4000E7C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Here you can set up callbacks to be invoked when a pickable transform is deselected.")]
		private UnityEventWithTransform OnPickableTransformDeselected;

		// Token: 0x04000E7D RID: 3709
		[Token(Token = "0x4000E7D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Tooltip("Here you can set up callbacks to be invoked when the moving of a pickable transform is started.")]
		private UnityEventWithTransform OnPickableTransformMoveStarted;

		// Token: 0x04000E7E RID: 3710
		[Token(Token = "0x4000E7E")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Tooltip("Here you can set up callbacks to be invoked when a pickable transform is moved to a new position.")]
		private UnityEventWithTransform OnPickableTransformMoved;

		// Token: 0x04000E7F RID: 3711
		[Token(Token = "0x4000E7F")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		[Tooltip("Here you can set up callbacks to be invoked when the moving of a pickable transform is ended. The event requires 2 parameters. The first is the start position of the drag. The second is the dragged transform. The start position can be used to reset the transform in case the drag has ended on an invalid position.")]
		private UnityEventWithPositionAndTransform OnPickableTransformMoveEnded;

		// Token: 0x04000E80 RID: 3712
		[Token(Token = "0x4000E80")]
		[FieldOffset(Offset = "0x60")]
		[Header("Expert Mode")]
		[SerializeField]
		private bool expertModeEnabled;

		// Token: 0x04000E81 RID: 3713
		[Token(Token = "0x4000E81")]
		[FieldOffset(Offset = "0x61")]
		[SerializeField]
		[Tooltip("When setting this to false, pickables will not become deselected when the user clicks somewhere on the screen, except when he clicks on another pickable.")]
		private bool deselectPreviousColliderOnClick;

		// Token: 0x04000E82 RID: 3714
		[Token(Token = "0x4000E82")]
		[FieldOffset(Offset = "0x62")]
		[SerializeField]
		[Tooltip("When setting this to false, the OnPickableTransformSelect event will only be sent once when clicking on the same pickable repeatedly.")]
		private bool repeatEventSelectedOnClick;

		// Token: 0x04000E83 RID: 3715
		[Token(Token = "0x4000E83")]
		[FieldOffset(Offset = "0x63")]
		[SerializeField]
		[Tooltip("Previous versions of this asset may have fired the OnPickableTransformMoveStarted too early, when it hasn't actually been moved.")]
		private bool useLegacyTransformMovedEventOrder;

		// Token: 0x04000E84 RID: 3716
		[Token(Token = "0x4000E84")]
		[FieldOffset(Offset = "0x68")]
		private TouchInputController touchInputController;

		// Token: 0x04000E85 RID: 3717
		[Token(Token = "0x4000E85")]
		[FieldOffset(Offset = "0x70")]
		private MobileTouchCamera mobileTouchCam;

		// Token: 0x04000E87 RID: 3719
		[Token(Token = "0x4000E87")]
		[FieldOffset(Offset = "0x80")]
		private bool isSelectedViaLongTap;

		// Token: 0x04000E89 RID: 3721
		[Token(Token = "0x4000E89")]
		[FieldOffset(Offset = "0x90")]
		private Vector3 draggedTransformOffset;

		// Token: 0x04000E8A RID: 3722
		[Token(Token = "0x4000E8A")]
		[FieldOffset(Offset = "0x9C")]
		private Vector3 draggedTransformHeightOffset;

		// Token: 0x04000E8B RID: 3723
		[Token(Token = "0x4000E8B")]
		[FieldOffset(Offset = "0xA8")]
		private Vector3 draggedItemCustomOffset;

		// Token: 0x04000E8C RID: 3724
		[Token(Token = "0x4000E8C")]
		public const float snapAngleDiagonal = 0.7853982f;

		// Token: 0x04000E8D RID: 3725
		[Token(Token = "0x4000E8D")]
		[FieldOffset(Offset = "0xB4")]
		private Vector3 currentlyDraggedTransformPosition;

		// Token: 0x04000E8E RID: 3726
		[Token(Token = "0x4000E8E")]
		private const float transformMovedDistanceThreshold = 0.001f;

		// Token: 0x04000E8F RID: 3727
		[Token(Token = "0x4000E8F")]
		[FieldOffset(Offset = "0xC0")]
		private Vector3 currentDragStartPos;

		// Token: 0x04000E90 RID: 3728
		[Token(Token = "0x4000E90")]
		[FieldOffset(Offset = "0xCC")]
		private bool invokeMoveStartedOnDrag;

		// Token: 0x04000E91 RID: 3729
		[Token(Token = "0x4000E91")]
		[FieldOffset(Offset = "0xCD")]
		private bool invokeMoveEndedOnDrag;

		// Token: 0x04000E92 RID: 3730
		[Token(Token = "0x4000E92")]
		[FieldOffset(Offset = "0xD0")]
		private Vector3 itemInitialDragOffsetWorld;

		// Token: 0x04000E93 RID: 3731
		[Token(Token = "0x4000E93")]
		[FieldOffset(Offset = "0xDC")]
		private bool isManualSelectionRequest;

		// Token: 0x04000E94 RID: 3732
		[Token(Token = "0x4000E94")]
		[FieldOffset(Offset = "0xE0")]
		private Dictionary<Component, Vector3> selectionPositionOffsets;

		// Token: 0x02000453 RID: 1107
		[Token(Token = "0x2000453")]
		public enum SelectionAction
		{
			// Token: 0x04000E96 RID: 3734
			[Token(Token = "0x4000E96")]
			Select,
			// Token: 0x04000E97 RID: 3735
			[Token(Token = "0x4000E97")]
			Deselect
		}
	}
}
