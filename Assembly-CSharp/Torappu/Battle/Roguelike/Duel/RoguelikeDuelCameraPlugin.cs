using System;
using DG.Tweening;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Roguelike.Duel
{
	// Token: 0x0200292E RID: 10542
	[Token(Token = "0x200292E")]
	public class RoguelikeDuelCameraPlugin : CameraController.Plugin
	{
		// Token: 0x170026AC RID: 9900
		// (get) Token: 0x060117A7 RID: 71591 RVA: 0x0006B8B0 File Offset: 0x00069AB0
		[Token(Token = "0x170026AC")]
		private Vector3 cameraOffset
		{
			[Token(Token = "0x60117A7")]
			[Address(RVA = "0x962080", Offset = "0x960C80", VA = "0x180962080")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x060117A8 RID: 71592 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60117A8")]
		[Address(RVA = "0x9615D0", Offset = "0x9601D0", VA = "0x1809615D0", Slot = "7")]
		public override Tween DoMoveCameraDirectly(Vector3 targetPos, bool tween = true)
		{
			return null;
		}

		// Token: 0x060117A9 RID: 71593 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117A9")]
		[Address(RVA = "0x961E40", Offset = "0x960A40", VA = "0x180961E40")]
		private void _OnTweenComplete()
		{
		}

		// Token: 0x060117AA RID: 71594 RVA: 0x0006B8C8 File Offset: 0x00069AC8
		[Token(Token = "0x60117AA")]
		[Address(RVA = "0x9613F0", Offset = "0x95FFF0", VA = "0x1809613F0", Slot = "8")]
		public override Vector3 CalculateCameraFocusPos(Vector3 targetPos)
		{
			return default(Vector3);
		}

		// Token: 0x060117AB RID: 71595 RVA: 0x0006B8E0 File Offset: 0x00069AE0
		[Token(Token = "0x60117AB")]
		[Address(RVA = "0x9614E0", Offset = "0x9600E0", VA = "0x1809614E0", Slot = "9")]
		public override Vector3 CalculateCameraOffset(Vector3 originPos)
		{
			return default(Vector3);
		}

		// Token: 0x060117AC RID: 71596 RVA: 0x0006B8F8 File Offset: 0x00069AF8
		[Token(Token = "0x60117AC")]
		[Address(RVA = "0x961970", Offset = "0x960570", VA = "0x180961970", Slot = "10")]
		public override bool TrySetCameraPosition(CameraController.CameraPosition cameraPos, bool tween = true)
		{
			return default(bool);
		}

		// Token: 0x060117AD RID: 71597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60117AD")]
		[Address(RVA = "0x962020", Offset = "0x960C20", VA = "0x180962020")]
		public RoguelikeDuelCameraPlugin()
		{
		}

		// Token: 0x060117AF RID: 71599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60117AF")]
		[Address(RVA = "0x961FE0", Offset = "0x960BE0", VA = "0x180961FE0")]
		private Tween <>xLuaBaseProxy_DoMoveCameraDirectly(Vector3 P0, bool P1)
		{
			return null;
		}

		// Token: 0x060117B0 RID: 71600 RVA: 0x0006B910 File Offset: 0x00069B10
		[Token(Token = "0x60117B0")]
		[Address(RVA = "0x961F40", Offset = "0x960B40", VA = "0x180961F40")]
		private Vector3 <>xLuaBaseProxy_CalculateCameraFocusPos(Vector3 P0)
		{
			return default(Vector3);
		}

		// Token: 0x060117B1 RID: 71601 RVA: 0x0006B928 File Offset: 0x00069B28
		[Token(Token = "0x60117B1")]
		[Address(RVA = "0x961F90", Offset = "0x960B90", VA = "0x180961F90")]
		private Vector3 <>xLuaBaseProxy_CalculateCameraOffset(Vector3 P0)
		{
			return default(Vector3);
		}

		// Token: 0x060117B2 RID: 71602 RVA: 0x0006B940 File Offset: 0x00069B40
		[Token(Token = "0x60117B2")]
		[Address(RVA = "0x962010", Offset = "0x960C10", VA = "0x180962010")]
		private bool <>xLuaBaseProxy_TrySetCameraPosition(CameraController.CameraPosition P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x040138B4 RID: 80052
		[Token(Token = "0x40138B4")]
		private const float MOVE_TIME = 5f;

		// Token: 0x040138B5 RID: 80053
		[Token(Token = "0x40138B5")]
		[FieldOffset(Offset = "0x20")]
		private Tween m_cachedCameraTween;

		// Token: 0x040138B6 RID: 80054
		[Token(Token = "0x40138B6")]
		[FieldOffset(Offset = "0x28")]
		private Tween m_cachedSequence;

		// Token: 0x040138B7 RID: 80055
		[Token(Token = "0x40138B7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cameraOffset;

		// Token: 0x040138B8 RID: 80056
		[Token(Token = "0x40138B8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoMoveCameraDirectly;

		// Token: 0x040138B9 RID: 80057
		[Token(Token = "0x40138B9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__OnTweenComplete;

		// Token: 0x040138BA RID: 80058
		[Token(Token = "0x40138BA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CalculateCameraFocusPos;

		// Token: 0x040138BB RID: 80059
		[Token(Token = "0x40138BB")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CalculateCameraOffset;

		// Token: 0x040138BC RID: 80060
		[Token(Token = "0x40138BC")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_TrySetCameraPosition;

		// Token: 0x040138BD RID: 80061
		[Token(Token = "0x40138BD")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
