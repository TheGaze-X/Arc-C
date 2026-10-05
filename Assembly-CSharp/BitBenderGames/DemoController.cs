using System;
using System.Collections;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace BitBenderGames
{
	// Token: 0x0200044E RID: 1102
	[Token(Token = "0x200044E")]
	public class DemoController : MonoBehaviour
	{
		// Token: 0x06004A16 RID: 18966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A16")]
		[Address(RVA = "0x167CD40", Offset = "0x167B940", VA = "0x18167CD40")]
		public void Awake()
		{
		}

		// Token: 0x06004A17 RID: 18967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A17")]
		[Address(RVA = "0x167E8E0", Offset = "0x167D4E0", VA = "0x18167E8E0")]
		public void OnPickItem(RaycastHit hitInfo)
		{
		}

		// Token: 0x06004A18 RID: 18968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A18")]
		[Address(RVA = "0x167E7A0", Offset = "0x167D3A0", VA = "0x18167E7A0")]
		public void OnPickItem2D(RaycastHit2D hitInfo2D)
		{
		}

		// Token: 0x06004A19 RID: 18969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A19")]
		[Address(RVA = "0x167EF40", Offset = "0x167DB40", VA = "0x18167EF40")]
		public void OnPickableTransformSelected(Transform pickableTransform)
		{
		}

		// Token: 0x06004A1A RID: 18970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A1A")]
		[Address(RVA = "0x167EE20", Offset = "0x167DA20", VA = "0x18167EE20")]
		public void OnPickableTransformSelectedExtended(PickableSelectedData data)
		{
		}

		// Token: 0x06004A1B RID: 18971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A1B")]
		[Address(RVA = "0x167EA20", Offset = "0x167D620", VA = "0x18167EA20")]
		public void OnPickableTransformDeselected(Transform pickableTransform)
		{
		}

		// Token: 0x06004A1C RID: 18972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A1C")]
		[Address(RVA = "0x167ED40", Offset = "0x167D940", VA = "0x18167ED40")]
		public void OnPickableTransformMoveStarted(Transform pickableTransform)
		{
		}

		// Token: 0x06004A1D RID: 18973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A1D")]
		[Address(RVA = "0x167ED70", Offset = "0x167D970", VA = "0x18167ED70")]
		public void OnPickableTransformMoved(Transform pickableTransform)
		{
		}

		// Token: 0x06004A1E RID: 18974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A1E")]
		[Address(RVA = "0x167ECB0", Offset = "0x167D8B0", VA = "0x18167ECB0")]
		public void OnPickableTransformMoveEnded(Vector3 startPos, Transform pickableTransform)
		{
		}

		// Token: 0x06004A1F RID: 18975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A1F")]
		[Address(RVA = "0x167FB20", Offset = "0x167E720", VA = "0x18167FB20")]
		private void SetItemColor(Transform itemTransform, Color color)
		{
		}

		// Token: 0x06004A20 RID: 18976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A20")]
		[Address(RVA = "0x167F760", Offset = "0x167E360", VA = "0x18167F760")]
		private void RevertToOriginalItemColor(Transform itemTransform)
		{
		}

		// Token: 0x06004A21 RID: 18977 RVA: 0x0002C688 File Offset: 0x0002A888
		[Token(Token = "0x6004A21")]
		[Address(RVA = "0x167D4E0", Offset = "0x167C0E0", VA = "0x18167D4E0")]
		private bool GetTransformPositionValid(Transform pickableTransform)
		{
			return default(bool);
		}

		// Token: 0x06004A22 RID: 18978 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A22")]
		[Address(RVA = "0x167CCC0", Offset = "0x167B8C0", VA = "0x18167CCC0")]
		private IEnumerator AnimateScaleForSelection(Transform pickableTransform)
		{
			return null;
		}

		// Token: 0x06004A23 RID: 18979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A23")]
		[Address(RVA = "0x167F910", Offset = "0x167E510", VA = "0x18167F910")]
		public void SetCameraModeOrtho()
		{
		}

		// Token: 0x06004A24 RID: 18980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A24")]
		[Address(RVA = "0x167FA60", Offset = "0x167E660", VA = "0x18167FA60")]
		public void SetCameraModePerspective()
		{
		}

		// Token: 0x06004A25 RID: 18981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A25")]
		[Address(RVA = "0x167F9A0", Offset = "0x167E5A0", VA = "0x18167F9A0")]
		public void SetCameraModePerspectiveTranslation()
		{
		}

		// Token: 0x06004A26 RID: 18982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A26")]
		[Address(RVA = "0x167F6B0", Offset = "0x167E2B0", VA = "0x18167F6B0")]
		private void ResetCamPosition(float distance)
		{
		}

		// Token: 0x06004A27 RID: 18983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A27")]
		[Address(RVA = "0x167FDB0", Offset = "0x167E9B0", VA = "0x18167FDB0")]
		public void SetSnapAngleStraight()
		{
		}

		// Token: 0x06004A28 RID: 18984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A28")]
		[Address(RVA = "0x167FD90", Offset = "0x167E990", VA = "0x18167FD90")]
		public void SetSnapAngleDiagonal()
		{
		}

		// Token: 0x06004A29 RID: 18985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A29")]
		[Address(RVA = "0x167FDD0", Offset = "0x167E9D0", VA = "0x18167FDD0")]
		public void SetSnappingEnabled(bool flag)
		{
		}

		// Token: 0x06004A2A RID: 18986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2A")]
		[Address(RVA = "0x167FD70", Offset = "0x167E970", VA = "0x18167FD70")]
		public void SetRotationEnabled(bool flag)
		{
		}

		// Token: 0x06004A2B RID: 18987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2B")]
		[Address(RVA = "0x167FEA0", Offset = "0x167EAA0", VA = "0x18167FEA0")]
		public void SetTiltEnabled(bool flag)
		{
		}

		// Token: 0x06004A2C RID: 18988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2C")]
		[Address(RVA = "0x1680050", Offset = "0x167EC50", VA = "0x181680050")]
		public void ToggleGameObjectActive(GameObject go)
		{
		}

		// Token: 0x06004A2D RID: 18989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2D")]
		[Address(RVA = "0x1680020", Offset = "0x167EC20", VA = "0x181680020")]
		public void ToggleCamAngle(bool angle)
		{
		}

		// Token: 0x06004A2E RID: 18990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2E")]
		[Address(RVA = "0x167FB00", Offset = "0x167E700", VA = "0x18167FB00")]
		public void SetInputOnLockedArea()
		{
		}

		// Token: 0x06004A2F RID: 18991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A2F")]
		[Address(RVA = "0x167FEC0", Offset = "0x167EAC0", VA = "0x18167FEC0")]
		private void ShowInfoText(string message, float onScreenTime)
		{
		}

		// Token: 0x06004A30 RID: 18992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004A30")]
		[Address(RVA = "0x167D900", Offset = "0x167C500", VA = "0x18167D900")]
		private IEnumerator HideInfoText(float delay)
		{
			return null;
		}

		// Token: 0x06004A31 RID: 18993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A31")]
		[Address(RVA = "0x167FDF0", Offset = "0x167E9F0", VA = "0x18167FDF0")]
		private void SetTextDetail(string message)
		{
		}

		// Token: 0x06004A32 RID: 18994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A32")]
		[Address(RVA = "0x167E1B0", Offset = "0x167CDB0", VA = "0x18167E1B0")]
		private void OnInputClick(Vector3 clickScreenPosition, bool isDoubleClick, bool isLongTap)
		{
		}

		// Token: 0x06004A33 RID: 18995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A33")]
		[Address(RVA = "0x167F380", Offset = "0x167DF80", VA = "0x18167F380")]
		private void OnPinchUpdate(PinchUpdateData pinchUpdateData)
		{
		}

		// Token: 0x06004A34 RID: 18996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A34")]
		[Address(RVA = "0x167F340", Offset = "0x167DF40", VA = "0x18167F340")]
		private void OnPinchStop()
		{
		}

		// Token: 0x06004A35 RID: 18997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A35")]
		[Address(RVA = "0x167F0D0", Offset = "0x167DCD0", VA = "0x18167F0D0")]
		private void OnPinchStart(Vector3 pinchCenter, float pinchDistance)
		{
		}

		// Token: 0x06004A36 RID: 18998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A36")]
		[Address(RVA = "0x167E120", Offset = "0x167CD20", VA = "0x18167E120")]
		private void OnFingerDown(Vector3 screenPosition)
		{
		}

		// Token: 0x06004A37 RID: 18999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A37")]
		[Address(RVA = "0x167DEA0", Offset = "0x167CAA0", VA = "0x18167DEA0")]
		private void OnDragUpdate(Vector3 dragPosStart, Vector3 dragPosCurrent, Vector3 correctionOffset)
		{
		}

		// Token: 0x06004A38 RID: 19000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A38")]
		[Address(RVA = "0x167DC20", Offset = "0x167C820", VA = "0x18167DC20")]
		private void OnDragStop(Vector3 dragStopPos, Vector3 dragFinalMomentum)
		{
		}

		// Token: 0x06004A39 RID: 19001 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A39")]
		[Address(RVA = "0x167D990", Offset = "0x167C590", VA = "0x18167D990")]
		private void OnDragStart(Vector3 pos, bool isLongTap)
		{
		}

		// Token: 0x06004A3A RID: 19002 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004A3A")]
		[Address(RVA = "0x1680090", Offset = "0x167EC90", VA = "0x181680090")]
		public DemoController()
		{
		}

		// Token: 0x04000E61 RID: 3681
		[Token(Token = "0x4000E61")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private Text textInfo;

		// Token: 0x04000E62 RID: 3682
		[Token(Token = "0x4000E62")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Text textDetail;

		// Token: 0x04000E63 RID: 3683
		[Token(Token = "0x4000E63")]
		[FieldOffset(Offset = "0x28")]
		private TouchInputController touchInputController;

		// Token: 0x04000E64 RID: 3684
		[Token(Token = "0x4000E64")]
		[FieldOffset(Offset = "0x30")]
		private MobileTouchCamera mobileTouchCamera;

		// Token: 0x04000E65 RID: 3685
		[Token(Token = "0x4000E65")]
		[FieldOffset(Offset = "0x38")]
		private MobilePickingController mobilePickingController;

		// Token: 0x04000E66 RID: 3686
		[Token(Token = "0x4000E66")]
		[FieldOffset(Offset = "0x40")]
		private Camera cam;

		// Token: 0x04000E67 RID: 3687
		[Token(Token = "0x4000E67")]
		[FieldOffset(Offset = "0x48")]
		private Coroutine coroutineHideInfoText;

		// Token: 0x04000E68 RID: 3688
		[Token(Token = "0x4000E68")]
		[FieldOffset(Offset = "0x50")]
		private Transform selectedPickableTransform;

		// Token: 0x04000E69 RID: 3689
		[Token(Token = "0x4000E69")]
		[FieldOffset(Offset = "0x58")]
		private Dictionary<Renderer, List<Color>> originalItemColorCache;

		// Token: 0x04000E6A RID: 3690
		[Token(Token = "0x4000E6A")]
		[FieldOffset(Offset = "0x60")]
		public float introTextOnScreenTime;
	}
}
