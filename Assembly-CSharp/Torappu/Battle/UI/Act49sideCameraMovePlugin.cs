using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003289 RID: 12937
	[Token(Token = "0x2003289")]
	public class Act49sideCameraMovePlugin : CameraController.Plugin
	{
		// Token: 0x1700309B RID: 12443
		// (get) Token: 0x0601487F RID: 84095 RVA: 0x00087558 File Offset: 0x00085758
		[Token(Token = "0x1700309B")]
		private Vector3 cameraOffset
		{
			[Token(Token = "0x601487F")]
			[Address(RVA = "0xCAF450", Offset = "0xCAE050", VA = "0x180CAF450")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06014880 RID: 84096 RVA: 0x00087570 File Offset: 0x00085770
		[Token(Token = "0x6014880")]
		[Address(RVA = "0xCAE7D0", Offset = "0xCAD3D0", VA = "0x180CAE7D0", Slot = "8")]
		public override Vector3 CalculateCameraFocusPos(Vector3 targetPos)
		{
			return default(Vector3);
		}

		// Token: 0x06014881 RID: 84097 RVA: 0x00087588 File Offset: 0x00085788
		[Token(Token = "0x6014881")]
		[Address(RVA = "0xCAE910", Offset = "0xCAD510", VA = "0x180CAE910", Slot = "9")]
		public override Vector3 CalculateCameraOffset(Vector3 originPos)
		{
			return default(Vector3);
		}

		// Token: 0x06014882 RID: 84098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014882")]
		[Address(RVA = "0xCAEA50", Offset = "0xCAD650", VA = "0x180CAEA50", Slot = "7")]
		public override Tween DoMoveCameraDirectly(Vector3 offset, bool tween = true)
		{
			return null;
		}

		// Token: 0x06014883 RID: 84099 RVA: 0x000875A0 File Offset: 0x000857A0
		[Token(Token = "0x6014883")]
		[Address(RVA = "0xCAEDD0", Offset = "0xCAD9D0", VA = "0x180CAEDD0", Slot = "10")]
		public override bool TrySetCameraPosition(CameraController.CameraPosition cameraPos, bool tween = true)
		{
			return default(bool);
		}

		// Token: 0x06014884 RID: 84100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014884")]
		[Address(RVA = "0xCAF340", Offset = "0xCADF40", VA = "0x180CAF340")]
		private void _OnUpdateCameraMove()
		{
		}

		// Token: 0x06014885 RID: 84101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014885")]
		[Address(RVA = "0xCAF280", Offset = "0xCADE80", VA = "0x180CAF280")]
		private void _OnFinishCameraMove()
		{
		}

		// Token: 0x06014886 RID: 84102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014886")]
		[Address(RVA = "0xCAF3B0", Offset = "0xCADFB0", VA = "0x180CAF3B0")]
		public Act49sideCameraMovePlugin()
		{
		}

		// Token: 0x06014887 RID: 84103 RVA: 0x000875B8 File Offset: 0x000857B8
		[Token(Token = "0x6014887")]
		[Address(RVA = "0x961F40", Offset = "0x960B40", VA = "0x180961F40")]
		private Vector3 <>xLuaBaseProxy_CalculateCameraFocusPos(Vector3 P0)
		{
			return default(Vector3);
		}

		// Token: 0x06014888 RID: 84104 RVA: 0x000875D0 File Offset: 0x000857D0
		[Token(Token = "0x6014888")]
		[Address(RVA = "0x961F90", Offset = "0x960B90", VA = "0x180961F90")]
		private Vector3 <>xLuaBaseProxy_CalculateCameraOffset(Vector3 P0)
		{
			return default(Vector3);
		}

		// Token: 0x06014889 RID: 84105 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014889")]
		[Address(RVA = "0x961FE0", Offset = "0x960BE0", VA = "0x180961FE0")]
		private Tween <>xLuaBaseProxy_DoMoveCameraDirectly(Vector3 P0, bool P1)
		{
			return null;
		}

		// Token: 0x0601488A RID: 84106 RVA: 0x000875E8 File Offset: 0x000857E8
		[Token(Token = "0x601488A")]
		[Address(RVA = "0x962010", Offset = "0x960C10", VA = "0x180962010")]
		private bool <>xLuaBaseProxy_TrySetCameraPosition(CameraController.CameraPosition P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x0401845F RID: 99423
		[Token(Token = "0x401845F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float move_time;

		// Token: 0x04018460 RID: 99424
		[Token(Token = "0x4018460")]
		[FieldOffset(Offset = "0x24")]
		private Vector3 m_cachedOffset;

		// Token: 0x04018461 RID: 99425
		[Token(Token = "0x4018461")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cameraOffset;

		// Token: 0x04018462 RID: 99426
		[Token(Token = "0x4018462")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CalculateCameraFocusPos;

		// Token: 0x04018463 RID: 99427
		[Token(Token = "0x4018463")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CalculateCameraOffset;

		// Token: 0x04018464 RID: 99428
		[Token(Token = "0x4018464")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoMoveCameraDirectly;

		// Token: 0x04018465 RID: 99429
		[Token(Token = "0x4018465")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TrySetCameraPosition;

		// Token: 0x04018466 RID: 99430
		[Token(Token = "0x4018466")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnUpdateCameraMove;

		// Token: 0x04018467 RID: 99431
		[Token(Token = "0x4018467")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnFinishCameraMove;

		// Token: 0x04018468 RID: 99432
		[Token(Token = "0x4018468")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
