using System;
using System.Collections;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act1BossRush.Battle
{
	// Token: 0x020070CE RID: 28878
	[Token(Token = "0x20070CE")]
	public class BossRushCameraPlugin : CameraController.Plugin
	{
		// Token: 0x17006143 RID: 24899
		// (get) Token: 0x06029098 RID: 168088 RVA: 0x000D4250 File Offset: 0x000D2450
		[Token(Token = "0x17006143")]
		private Vector3 cameraOffset
		{
			[Token(Token = "0x6029098")]
			[Address(RVA = "0x2475C80", Offset = "0x2474880", VA = "0x182475C80")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06029099 RID: 168089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6029099")]
		[Address(RVA = "0x24750B0", Offset = "0x2473CB0", VA = "0x1824750B0", Slot = "6")]
		public override void DoAdaptCameraPosition()
		{
		}

		// Token: 0x0602909A RID: 168090 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602909A")]
		[Address(RVA = "0x2475340", Offset = "0x2473F40", VA = "0x182475340", Slot = "7")]
		public override Tween DoMoveCameraDirectly(Vector3 targetPos, bool tween = true)
		{
			return null;
		}

		// Token: 0x0602909B RID: 168091 RVA: 0x000D4268 File Offset: 0x000D2468
		[Token(Token = "0x602909B")]
		[Address(RVA = "0x2474ED0", Offset = "0x2473AD0", VA = "0x182474ED0", Slot = "8")]
		public override Vector3 CalculateCameraFocusPos(Vector3 targetPos)
		{
			return default(Vector3);
		}

		// Token: 0x0602909C RID: 168092 RVA: 0x000D4280 File Offset: 0x000D2480
		[Token(Token = "0x602909C")]
		[Address(RVA = "0x2474FC0", Offset = "0x2473BC0", VA = "0x182474FC0", Slot = "9")]
		public override Vector3 CalculateCameraOffset(Vector3 originPos)
		{
			return default(Vector3);
		}

		// Token: 0x0602909D RID: 168093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602909D")]
		[Address(RVA = "0x2475B50", Offset = "0x2474750", VA = "0x182475B50")]
		public IEnumerator WaitMoveCameraFinished(Tweener cameraTweener)
		{
			return null;
		}

		// Token: 0x0602909E RID: 168094 RVA: 0x000D4298 File Offset: 0x000D2498
		[Token(Token = "0x602909E")]
		[Address(RVA = "0x2475710", Offset = "0x2474310", VA = "0x182475710", Slot = "10")]
		public override bool TrySetCameraPosition(CameraController.CameraPosition cameraPos, bool tween = true)
		{
			return default(bool);
		}

		// Token: 0x0602909F RID: 168095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602909F")]
		[Address(RVA = "0x2475C20", Offset = "0x2474820", VA = "0x182475C20")]
		public BossRushCameraPlugin()
		{
		}

		// Token: 0x060290A0 RID: 168096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60290A0")]
		[Address(RVA = "0x2475B40", Offset = "0x2474740", VA = "0x182475B40")]
		private void <>xLuaBaseProxy_DoAdaptCameraPosition()
		{
		}

		// Token: 0x060290A1 RID: 168097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60290A1")]
		[Address(RVA = "0x961FE0", Offset = "0x960BE0", VA = "0x180961FE0")]
		private Tween <>xLuaBaseProxy_DoMoveCameraDirectly(Vector3 P0, bool P1)
		{
			return null;
		}

		// Token: 0x060290A2 RID: 168098 RVA: 0x000D42B0 File Offset: 0x000D24B0
		[Token(Token = "0x60290A2")]
		[Address(RVA = "0x961F40", Offset = "0x960B40", VA = "0x180961F40")]
		private Vector3 <>xLuaBaseProxy_CalculateCameraFocusPos(Vector3 P0)
		{
			return default(Vector3);
		}

		// Token: 0x060290A3 RID: 168099 RVA: 0x000D42C8 File Offset: 0x000D24C8
		[Token(Token = "0x60290A3")]
		[Address(RVA = "0x961F90", Offset = "0x960B90", VA = "0x180961F90")]
		private Vector3 <>xLuaBaseProxy_CalculateCameraOffset(Vector3 P0)
		{
			return default(Vector3);
		}

		// Token: 0x060290A4 RID: 168100 RVA: 0x000D42E0 File Offset: 0x000D24E0
		[Token(Token = "0x60290A4")]
		[Address(RVA = "0x962010", Offset = "0x960C10", VA = "0x180962010")]
		private bool <>xLuaBaseProxy_TrySetCameraPosition(CameraController.CameraPosition P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x0403A95C RID: 239964
		[Token(Token = "0x403A95C")]
		private const float MOVE_TIME = 5f;

		// Token: 0x0403A95D RID: 239965
		[Token(Token = "0x403A95D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cameraOffset;

		// Token: 0x0403A95E RID: 239966
		[Token(Token = "0x403A95E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoAdaptCameraPosition;

		// Token: 0x0403A95F RID: 239967
		[Token(Token = "0x403A95F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoMoveCameraDirectly;

		// Token: 0x0403A960 RID: 239968
		[Token(Token = "0x403A960")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_CalculateCameraFocusPos;

		// Token: 0x0403A961 RID: 239969
		[Token(Token = "0x403A961")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_CalculateCameraOffset;

		// Token: 0x0403A962 RID: 239970
		[Token(Token = "0x403A962")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_WaitMoveCameraFinished;

		// Token: 0x0403A963 RID: 239971
		[Token(Token = "0x403A963")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_TrySetCameraPosition;

		// Token: 0x0403A964 RID: 239972
		[Token(Token = "0x403A964")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
