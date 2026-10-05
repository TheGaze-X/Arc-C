using System;
using DG.Tweening;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003334 RID: 13108
	[Token(Token = "0x2003334")]
	public class CommonDitherCameraPlugin : CameraController.Plugin
	{
		// Token: 0x06014E8E RID: 85646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E8E")]
		[Address(RVA = "0xD57190", Offset = "0xD55D90", VA = "0x180D57190", Slot = "5")]
		public override void OnCreate(CameraController controller)
		{
		}

		// Token: 0x06014E8F RID: 85647 RVA: 0x000894F0 File Offset: 0x000876F0
		[Token(Token = "0x6014E8F")]
		[Address(RVA = "0xD572E0", Offset = "0xD55EE0", VA = "0x180D572E0", Slot = "10")]
		public override bool TrySetCameraPosition(CameraController.CameraPosition cameraPos, bool tween = true)
		{
			return default(bool);
		}

		// Token: 0x06014E90 RID: 85648 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E90")]
		[Address(RVA = "0xD57260", Offset = "0xD55E60", VA = "0x180D57260")]
		private void OnDestroy()
		{
		}

		// Token: 0x06014E91 RID: 85649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E91")]
		[Address(RVA = "0xD573B0", Offset = "0xD55FB0", VA = "0x180D573B0")]
		private void _SetDither(bool isDither, bool tween = false, bool isInit = false)
		{
		}

		// Token: 0x06014E92 RID: 85650 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E92")]
		[Address(RVA = "0xD57800", Offset = "0xD56400", VA = "0x180D57800")]
		public CommonDitherCameraPlugin()
		{
		}

		// Token: 0x06014E94 RID: 85652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6014E94")]
		[Address(RVA = "0xD573A0", Offset = "0xD55FA0", VA = "0x180D573A0")]
		private void <>xLuaBaseProxy_OnCreate(CameraController P0)
		{
		}

		// Token: 0x06014E95 RID: 85653 RVA: 0x00089508 File Offset: 0x00087708
		[Token(Token = "0x6014E95")]
		[Address(RVA = "0x962010", Offset = "0x960C10", VA = "0x180962010")]
		private bool <>xLuaBaseProxy_TrySetCameraPosition(CameraController.CameraPosition P0, bool P1)
		{
			return default(bool);
		}

		// Token: 0x04018DED RID: 101869
		[Token(Token = "0x4018DED")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int IS_GLOBAL_DITHER_ID;

		// Token: 0x04018DEE RID: 101870
		[Token(Token = "0x4018DEE")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int GLOBAL_DITHER_ID;

		// Token: 0x04018DEF RID: 101871
		[Token(Token = "0x4018DEF")]
		[FieldOffset(Offset = "0x20")]
		private Tweener m_ditherTweener;

		// Token: 0x04018DF0 RID: 101872
		[Token(Token = "0x4018DF0")]
		[FieldOffset(Offset = "0x28")]
		private bool m_isDither;

		// Token: 0x04018DF1 RID: 101873
		[Token(Token = "0x4018DF1")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnCreate;

		// Token: 0x04018DF2 RID: 101874
		[Token(Token = "0x4018DF2")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_TrySetCameraPosition;

		// Token: 0x04018DF3 RID: 101875
		[Token(Token = "0x4018DF3")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04018DF4 RID: 101876
		[Token(Token = "0x4018DF4")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__SetDither;

		// Token: 0x04018DF5 RID: 101877
		[Token(Token = "0x4018DF5")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
