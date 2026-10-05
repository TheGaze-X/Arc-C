using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Cooperate
{
	// Token: 0x020026D3 RID: 9939
	[Token(Token = "0x20026D3")]
	public class CooperateFortressCameraPlugin : DraggableCameraPlugin
	{
		// Token: 0x060102FE RID: 66302 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102FE")]
		[Address(RVA = "0x7E4F60", Offset = "0x7E3B60", VA = "0x1807E4F60", Slot = "13")]
		protected override void _InitIfNot()
		{
		}

		// Token: 0x060102FF RID: 66303 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60102FF")]
		[Address(RVA = "0x7E4E50", Offset = "0x7E3A50", VA = "0x1807E4E50", Slot = "16")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x06010300 RID: 66304 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010300")]
		[Address(RVA = "0x7E51C0", Offset = "0x7E3DC0", VA = "0x1807E51C0", Slot = "15")]
		protected override void _UpdateCamera()
		{
		}

		// Token: 0x06010301 RID: 66305 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010301")]
		[Address(RVA = "0x7E5090", Offset = "0x7E3C90", VA = "0x1807E5090", Slot = "14")]
		protected override void _OnBeginDrag(object arg)
		{
		}

		// Token: 0x06010302 RID: 66306 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010302")]
		[Address(RVA = "0x7E5230", Offset = "0x7E3E30", VA = "0x1807E5230")]
		public CooperateFortressCameraPlugin()
		{
		}

		// Token: 0x06010303 RID: 66307 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010303")]
		[Address(RVA = "0x7E4F30", Offset = "0x7E3B30", VA = "0x1807E4F30")]
		private void <>xLuaBaseProxy__InitIfNot()
		{
		}

		// Token: 0x06010304 RID: 66308 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010304")]
		[Address(RVA = "0x7E4F20", Offset = "0x7E3B20", VA = "0x1807E4F20")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x06010305 RID: 66309 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010305")]
		[Address(RVA = "0x7E4F50", Offset = "0x7E3B50", VA = "0x1807E4F50")]
		private void <>xLuaBaseProxy__UpdateCamera()
		{
		}

		// Token: 0x06010306 RID: 66310 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6010306")]
		[Address(RVA = "0x7E4F40", Offset = "0x7E3B40", VA = "0x1807E4F40")]
		private void <>xLuaBaseProxy__OnBeginDrag(object P0)
		{
		}

		// Token: 0x04012110 RID: 74000
		[Token(Token = "0x4012110")]
		[FieldOffset(Offset = "0xC0")]
		private CooperateMoveCameraAVGCommand m_moveCameraAVGCommand;

		// Token: 0x04012111 RID: 74001
		[Token(Token = "0x4012111")]
		[FieldOffset(Offset = "0xC8")]
		private CooperateLockCameraAVGCommand m_lockCameraAVGCommand;

		// Token: 0x04012112 RID: 74002
		[Token(Token = "0x4012112")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04012113 RID: 74003
		[Token(Token = "0x4012113")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x04012114 RID: 74004
		[Token(Token = "0x4012114")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__UpdateCamera;

		// Token: 0x04012115 RID: 74005
		[Token(Token = "0x4012115")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__OnBeginDrag;

		// Token: 0x04012116 RID: 74006
		[Token(Token = "0x4012116")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
