using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003333 RID: 13107
	[Token(Token = "0x2003333")]
	public class CommonCameraMovePlugin : CameraController.Plugin
	{
		// Token: 0x1700319C RID: 12700
		// (get) Token: 0x06014E82 RID: 85634 RVA: 0x00089448 File Offset: 0x00087648
		[Token(Token = "0x1700319C")]
		private Vector3 cameraOffset
		{
			[Token(Token = "0x6014E82")]
			[Address(RVA = "0xD567E0", Offset = "0xD553E0", VA = "0x180D567E0")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06014E83 RID: 85635 RVA: 0x00089460 File Offset: 0x00087660
		[Token(Token = "0x6014E83")]
		[Address(RVA = "0xD55CD0", Offset = "0xD548D0", VA = "0x180D55CD0", Slot = "8")]
		public override Vector3 CalculateCameraFocusPos(Vector3 targetPos)
		{
			return default(Vector3);
		}

		// Token: 0x06014E84 RID: 85636 RVA: 0x00089478 File Offset: 0x00087678
		[Token(Token = "0x6014E84")]
		[Address(RVA = "0xD55DC0", Offset = "0xD549C0", VA = "0x180D55DC0", Slot = "9")]
		public override Vector3 CalculateCameraOffset(Vector3 originPos)
		{
			return default(Vector3);
		}

		// Token: 0x06014E85 RID: 85637 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014E85")]
		[Address(RVA = "0xD55EB0", Offset = "0xD54AB0", VA = "0x180D55EB0", Slot = "7")]
		public override Tween DoMoveCameraDirectly(Vector3 offset, bool tween = true)
		{
			return null;
		}

		// Token: 0x06014E86 RID: 85638 RVA: 0x00089490 File Offset: 0x00087690
		[Token(Token = "0x6014E86")]
		[Address(RVA = "0xD56210", Offset = "0xD54E10", VA = "0x180D56210", Slot = "10")]
		public override bool TrySetCameraPosition(CameraController.CameraPosition cameraPos, bool tween = true)
		{
			return default(bool);
		}

		// Token: 0x06014E87 RID: 85639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E87")]
		[Address(RVA = "0xD56700", Offset = "0xD55300", VA = "0x180D56700")]
		private void _OnUpdateCameraMove()
		{
		}

		// Token: 0x06014E88 RID: 85640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E88")]
		[Address(RVA = "0xD56640", Offset = "0xD55240", VA = "0x180D56640")]
		private void _OnFinishCameraMove()
		{
		}

		// Token: 0x06014E89 RID: 85641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E89")]
		[Address(RVA = "0xD56770", Offset = "0xD55370", VA = "0x180D56770")]
		public CommonCameraMovePlugin()
		{
		}

		// Token: 0x06014E8A RID: 85642 RVA: 0x000894A8 File Offset: 0x000876A8
		[Token(Token = "0x6014E8A")]
		[Address(RVA = "0x961F40", Offset = "0x960B40", VA = "0x180961F40")]
		private Vector3 <>xLuaBaseProxy_CalculateCameraFocusPos(Vector3 P0)
		{
			return default(Vector3);
		}

		// Token: 0x06014E8B RID: 85643 RVA: 0x000894C0 File Offset: 0x000876C0
		[Token(Token = "0x6014E8B")]
		[Address(RVA = "0x961F90", Offset = "0x960B90", VA = "0x180961F90")]
		private Vector3 <>xLuaBaseProxy_CalculateCameraOffset(Vector3 P0)
		{
			return default(Vector3);
		}

		// Token: 0x06014E8C RID: 85644 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014E8C")]
		[Address(RVA = "0x961FE0", Offset = "0x960BE0", VA = "0x180961FE0")]
		private Tween <>xLuaBaseProxy_DoMoveCameraDirectly(Vector3 P0, bool P1)
		{
			return null;
		}

		// Token: 0x06014E8D RID: 85645 RVA: 0x000894D8 File Offset: 0x000876D8
		[Token(Token = "0x6014E8D")]
		[Address(RVA = "0x962010", Offset = "0x960C10", VA = "0x180962010")]
		private bool <>xLuaBaseProxy_TrySetCameraPosition(CameraController.CameraPosition P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x04018DE4 RID: 101860
		[Token(Token = "0x4018DE4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float move_time;

		// Token: 0x04018DE5 RID: 101861
		[Token(Token = "0x4018DE5")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cameraOffset;

		// Token: 0x04018DE6 RID: 101862
		[Token(Token = "0x4018DE6")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CalculateCameraFocusPos;

		// Token: 0x04018DE7 RID: 101863
		[Token(Token = "0x4018DE7")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CalculateCameraOffset;

		// Token: 0x04018DE8 RID: 101864
		[Token(Token = "0x4018DE8")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoMoveCameraDirectly;

		// Token: 0x04018DE9 RID: 101865
		[Token(Token = "0x4018DE9")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TrySetCameraPosition;

		// Token: 0x04018DEA RID: 101866
		[Token(Token = "0x4018DEA")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnUpdateCameraMove;

		// Token: 0x04018DEB RID: 101867
		[Token(Token = "0x4018DEB")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnFinishCameraMove;

		// Token: 0x04018DEC RID: 101868
		[Token(Token = "0x4018DEC")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
