using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200333D RID: 13117
	[Token(Token = "0x200333D")]
	public class CameraRoguelikePluginRL04Boss4 : CameraController.Plugin
	{
		// Token: 0x170031A7 RID: 12711
		// (get) Token: 0x06014EC8 RID: 85704 RVA: 0x00089670 File Offset: 0x00087870
		[Token(Token = "0x170031A7")]
		private Vector3 cameraOffset
		{
			[Token(Token = "0x6014EC8")]
			[Address(RVA = "0xD55C10", Offset = "0xD54810", VA = "0x180D55C10")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06014EC9 RID: 85705 RVA: 0x00089688 File Offset: 0x00087888
		[Token(Token = "0x6014EC9")]
		[Address(RVA = "0xD55110", Offset = "0xD53D10", VA = "0x180D55110", Slot = "8")]
		public override Vector3 CalculateCameraFocusPos(Vector3 targetPos)
		{
			return default(Vector3);
		}

		// Token: 0x06014ECA RID: 85706 RVA: 0x000896A0 File Offset: 0x000878A0
		[Token(Token = "0x6014ECA")]
		[Address(RVA = "0xD55200", Offset = "0xD53E00", VA = "0x180D55200", Slot = "9")]
		public override Vector3 CalculateCameraOffset(Vector3 originPos)
		{
			return default(Vector3);
		}

		// Token: 0x06014ECB RID: 85707 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014ECB")]
		[Address(RVA = "0xD552F0", Offset = "0xD53EF0", VA = "0x180D552F0", Slot = "7")]
		public override Tween DoMoveCameraDirectly(Vector3 offset, bool tween = true)
		{
			return null;
		}

		// Token: 0x06014ECC RID: 85708 RVA: 0x000896B8 File Offset: 0x000878B8
		[Token(Token = "0x6014ECC")]
		[Address(RVA = "0xD55650", Offset = "0xD54250", VA = "0x180D55650", Slot = "10")]
		public override bool TrySetCameraPosition(CameraController.CameraPosition cameraPos, bool tween = true)
		{
			return default(bool);
		}

		// Token: 0x06014ECD RID: 85709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014ECD")]
		[Address(RVA = "0xD55B40", Offset = "0xD54740", VA = "0x180D55B40")]
		private void _OnUpdateCameraMove()
		{
		}

		// Token: 0x06014ECE RID: 85710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014ECE")]
		[Address(RVA = "0xD55A80", Offset = "0xD54680", VA = "0x180D55A80")]
		private void _OnFinishCameraMove()
		{
		}

		// Token: 0x06014ECF RID: 85711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014ECF")]
		[Address(RVA = "0xD55BB0", Offset = "0xD547B0", VA = "0x180D55BB0")]
		public CameraRoguelikePluginRL04Boss4()
		{
		}

		// Token: 0x06014ED0 RID: 85712 RVA: 0x000896D0 File Offset: 0x000878D0
		[Token(Token = "0x6014ED0")]
		[Address(RVA = "0x961F40", Offset = "0x960B40", VA = "0x180961F40")]
		private Vector3 <>xLuaBaseProxy_CalculateCameraFocusPos(Vector3 P0)
		{
			return default(Vector3);
		}

		// Token: 0x06014ED1 RID: 85713 RVA: 0x000896E8 File Offset: 0x000878E8
		[Token(Token = "0x6014ED1")]
		[Address(RVA = "0x961F90", Offset = "0x960B90", VA = "0x180961F90")]
		private Vector3 <>xLuaBaseProxy_CalculateCameraOffset(Vector3 P0)
		{
			return default(Vector3);
		}

		// Token: 0x06014ED2 RID: 85714 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6014ED2")]
		[Address(RVA = "0x961FE0", Offset = "0x960BE0", VA = "0x180961FE0")]
		private Tween <>xLuaBaseProxy_DoMoveCameraDirectly(Vector3 P0, bool P1)
		{
			return null;
		}

		// Token: 0x06014ED3 RID: 85715 RVA: 0x00089700 File Offset: 0x00087900
		[Token(Token = "0x6014ED3")]
		[Address(RVA = "0x962010", Offset = "0x960C10", VA = "0x180962010")]
		private bool <>xLuaBaseProxy_TrySetCameraPosition(CameraController.CameraPosition P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x04018E2A RID: 101930
		[Token(Token = "0x4018E2A")]
		private const float MOVE_TIME = 5f;

		// Token: 0x04018E2B RID: 101931
		[Token(Token = "0x4018E2B")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cameraOffset;

		// Token: 0x04018E2C RID: 101932
		[Token(Token = "0x4018E2C")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CalculateCameraFocusPos;

		// Token: 0x04018E2D RID: 101933
		[Token(Token = "0x4018E2D")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CalculateCameraOffset;

		// Token: 0x04018E2E RID: 101934
		[Token(Token = "0x4018E2E")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoMoveCameraDirectly;

		// Token: 0x04018E2F RID: 101935
		[Token(Token = "0x4018E2F")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TrySetCameraPosition;

		// Token: 0x04018E30 RID: 101936
		[Token(Token = "0x4018E30")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnUpdateCameraMove;

		// Token: 0x04018E31 RID: 101937
		[Token(Token = "0x4018E31")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnFinishCameraMove;

		// Token: 0x04018E32 RID: 101938
		[Token(Token = "0x4018E32")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
