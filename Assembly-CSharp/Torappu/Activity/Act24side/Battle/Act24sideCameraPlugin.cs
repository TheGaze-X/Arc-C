using System;
using DG.Tweening;
using Il2CppDummyDll;
using Torappu.Battle;
using UnityEngine;
using XLua;

namespace Torappu.Activity.Act24side.Battle
{
	// Token: 0x0200761C RID: 30236
	[Token(Token = "0x200761C")]
	public class Act24sideCameraPlugin : CameraController.Plugin
	{
		// Token: 0x17006423 RID: 25635
		// (get) Token: 0x0602A907 RID: 174343 RVA: 0x000D9020 File Offset: 0x000D7220
		[Token(Token = "0x17006423")]
		private Vector3 cameraOffset
		{
			[Token(Token = "0x602A907")]
			[Address(RVA = "0x265DB00", Offset = "0x265C700", VA = "0x18265DB00")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x0602A908 RID: 174344 RVA: 0x000D9038 File Offset: 0x000D7238
		[Token(Token = "0x602A908")]
		[Address(RVA = "0x265CFE0", Offset = "0x265BBE0", VA = "0x18265CFE0", Slot = "8")]
		public override Vector3 CalculateCameraFocusPos(Vector3 targetPos)
		{
			return default(Vector3);
		}

		// Token: 0x0602A909 RID: 174345 RVA: 0x000D9050 File Offset: 0x000D7250
		[Token(Token = "0x602A909")]
		[Address(RVA = "0x265D0D0", Offset = "0x265BCD0", VA = "0x18265D0D0", Slot = "9")]
		public override Vector3 CalculateCameraOffset(Vector3 originPos)
		{
			return default(Vector3);
		}

		// Token: 0x0602A90A RID: 174346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A90A")]
		[Address(RVA = "0x265D1C0", Offset = "0x265BDC0", VA = "0x18265D1C0", Slot = "7")]
		public override Tween DoMoveCameraDirectly(Vector3 offset, bool tween = true)
		{
			return null;
		}

		// Token: 0x0602A90B RID: 174347 RVA: 0x000D9068 File Offset: 0x000D7268
		[Token(Token = "0x602A90B")]
		[Address(RVA = "0x265D540", Offset = "0x265C140", VA = "0x18265D540", Slot = "10")]
		public override bool TrySetCameraPosition(CameraController.CameraPosition cameraPos, bool tween = true)
		{
			return default(bool);
		}

		// Token: 0x0602A90C RID: 174348 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A90C")]
		[Address(RVA = "0x265DA30", Offset = "0x265C630", VA = "0x18265DA30")]
		private void _OnUpdateCameraMove()
		{
		}

		// Token: 0x0602A90D RID: 174349 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A90D")]
		[Address(RVA = "0x265D970", Offset = "0x265C570", VA = "0x18265D970")]
		private void _OnFinishCameraMove()
		{
		}

		// Token: 0x0602A90E RID: 174350 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602A90E")]
		[Address(RVA = "0x265DAA0", Offset = "0x265C6A0", VA = "0x18265DAA0")]
		public Act24sideCameraPlugin()
		{
		}

		// Token: 0x0602A90F RID: 174351 RVA: 0x000D9080 File Offset: 0x000D7280
		[Token(Token = "0x602A90F")]
		[Address(RVA = "0x961F40", Offset = "0x960B40", VA = "0x180961F40")]
		private Vector3 <>xLuaBaseProxy_CalculateCameraFocusPos(Vector3 P0)
		{
			return default(Vector3);
		}

		// Token: 0x0602A910 RID: 174352 RVA: 0x000D9098 File Offset: 0x000D7298
		[Token(Token = "0x602A910")]
		[Address(RVA = "0x961F90", Offset = "0x960B90", VA = "0x180961F90")]
		private Vector3 <>xLuaBaseProxy_CalculateCameraOffset(Vector3 P0)
		{
			return default(Vector3);
		}

		// Token: 0x0602A911 RID: 174353 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x602A911")]
		[Address(RVA = "0x961FE0", Offset = "0x960BE0", VA = "0x180961FE0")]
		private Tween <>xLuaBaseProxy_DoMoveCameraDirectly(Vector3 P0, bool P1)
		{
			return null;
		}

		// Token: 0x0602A912 RID: 174354 RVA: 0x000D90B0 File Offset: 0x000D72B0
		[Token(Token = "0x602A912")]
		[Address(RVA = "0x962010", Offset = "0x960C10", VA = "0x180962010")]
		private bool <>xLuaBaseProxy_TrySetCameraPosition(CameraController.CameraPosition P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x0403D496 RID: 251030
		[Token(Token = "0x403D496")]
		private const float MOVE_TIME = 5f;

		// Token: 0x0403D497 RID: 251031
		[Token(Token = "0x403D497")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cameraOffset;

		// Token: 0x0403D498 RID: 251032
		[Token(Token = "0x403D498")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CalculateCameraFocusPos;

		// Token: 0x0403D499 RID: 251033
		[Token(Token = "0x403D499")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CalculateCameraOffset;

		// Token: 0x0403D49A RID: 251034
		[Token(Token = "0x403D49A")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoMoveCameraDirectly;

		// Token: 0x0403D49B RID: 251035
		[Token(Token = "0x403D49B")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_TrySetCameraPosition;

		// Token: 0x0403D49C RID: 251036
		[Token(Token = "0x403D49C")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OnUpdateCameraMove;

		// Token: 0x0403D49D RID: 251037
		[Token(Token = "0x403D49D")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__OnFinishCameraMove;

		// Token: 0x0403D49E RID: 251038
		[Token(Token = "0x403D49E")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
