using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Effects
{
	// Token: 0x0200322F RID: 12847
	[Token(Token = "0x200322F")]
	public class FollowMountPoint : Effect.Behaviour
	{
		// Token: 0x060145FD RID: 83453 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145FD")]
		[Address(RVA = "0xC9E200", Offset = "0xC9CE00", VA = "0x180C9E200", Slot = "5")]
		public override void OnPlay()
		{
		}

		// Token: 0x060145FE RID: 83454 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145FE")]
		[Address(RVA = "0xC9E130", Offset = "0xC9CD30", VA = "0x180C9E130")]
		private void LateUpdate()
		{
		}

		// Token: 0x060145FF RID: 83455 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60145FF")]
		[Address(RVA = "0xC9E2E0", Offset = "0xC9CEE0", VA = "0x180C9E2E0")]
		private void _FollowMountPoint(Entity owner)
		{
		}

		// Token: 0x06014600 RID: 83456 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014600")]
		[Address(RVA = "0xC9E5D0", Offset = "0xC9D1D0", VA = "0x180C9E5D0")]
		public FollowMountPoint()
		{
		}

		// Token: 0x06014601 RID: 83457 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014601")]
		[Address(RVA = "0xC99160", Offset = "0xC97D60", VA = "0x180C99160")]
		private void <>xLuaBaseProxy_OnPlay()
		{
		}

		// Token: 0x040180AC RID: 98476
		[Token(Token = "0x40180AC")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Entity.MountPointType _mountPointType;

		// Token: 0x040180AD RID: 98477
		[Token(Token = "0x40180AD")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _followScaleSign;

		// Token: 0x040180AE RID: 98478
		[Token(Token = "0x40180AE")]
		[FieldOffset(Offset = "0x25")]
		[SerializeField]
		private bool _followScale;

		// Token: 0x040180AF RID: 98479
		[Token(Token = "0x40180AF")]
		[FieldOffset(Offset = "0x26")]
		[SerializeField]
		private bool _pauseWhenMountPointInvalid;

		// Token: 0x040180B0 RID: 98480
		[Token(Token = "0x40180B0")]
		[FieldOffset(Offset = "0x27")]
		[SerializeField]
		private bool _onlyPauseWhenMountPointInvalid;

		// Token: 0x040180B1 RID: 98481
		[Token(Token = "0x40180B1")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private bool _keepOriginRotation;

		// Token: 0x040180B2 RID: 98482
		[Token(Token = "0x40180B2")]
		[FieldOffset(Offset = "0x29")]
		[SerializeField]
		private bool _useBehaviourPause;

		// Token: 0x040180B3 RID: 98483
		[Token(Token = "0x40180B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnPlay;

		// Token: 0x040180B4 RID: 98484
		[Token(Token = "0x40180B4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LateUpdate;

		// Token: 0x040180B5 RID: 98485
		[Token(Token = "0x40180B5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__FollowMountPoint;

		// Token: 0x040180B6 RID: 98486
		[Token(Token = "0x40180B6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
