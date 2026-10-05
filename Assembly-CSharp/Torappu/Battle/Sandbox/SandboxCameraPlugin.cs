using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.Battle.Sandbox
{
	// Token: 0x02002A81 RID: 10881
	[Token(Token = "0x2002A81")]
	public class SandboxCameraPlugin : DraggableCameraPlugin
	{
		// Token: 0x06012149 RID: 74057 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6012149")]
		[Address(RVA = "0xA2B5F0", Offset = "0xA2A1F0", VA = "0x180A2B5F0", Slot = "13")]
		protected override void _InitIfNot()
		{
		}

		// Token: 0x0601214A RID: 74058 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601214A")]
		[Address(RVA = "0xA2B520", Offset = "0xA2A120", VA = "0x180A2B520", Slot = "16")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0601214B RID: 74059 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601214B")]
		[Address(RVA = "0xA2B720", Offset = "0xA2A320", VA = "0x180A2B720")]
		public SandboxCameraPlugin()
		{
		}

		// Token: 0x0601214C RID: 74060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601214C")]
		[Address(RVA = "0x7E4F30", Offset = "0x7E3B30", VA = "0x1807E4F30")]
		private void <>xLuaBaseProxy__InitIfNot()
		{
		}

		// Token: 0x0601214D RID: 74061 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601214D")]
		[Address(RVA = "0x7E4F20", Offset = "0x7E3B20", VA = "0x1807E4F20")]
		private void <>xLuaBaseProxy_OnDestroy()
		{
		}

		// Token: 0x04014728 RID: 83752
		[Token(Token = "0x4014728")]
		[FieldOffset(Offset = "0xC0")]
		private SandboxMoveCameraAVGCommand m_moveCameraAVGCommand;

		// Token: 0x04014729 RID: 83753
		[Token(Token = "0x4014729")]
		[FieldOffset(Offset = "0xC8")]
		private SandboxLockCameraAVGCommand m_lockCameraAVGCommand;

		// Token: 0x0401472A RID: 83754
		[Token(Token = "0x401472A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x0401472B RID: 83755
		[Token(Token = "0x401472B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnDestroy;

		// Token: 0x0401472C RID: 83756
		[Token(Token = "0x401472C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
