using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041F9 RID: 16889
	[Token(Token = "0x20041F9")]
	public abstract class SandboxV2TransparentState : PopupFadeState, IPopupCustomActive
	{
		// Token: 0x0601A118 RID: 106776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A118")]
		[Address(RVA = "0x12FA000", Offset = "0x12F8C00", VA = "0x1812FA000", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601A119 RID: 106777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A119")]
		[Address(RVA = "0x12FA0E0", Offset = "0x12F8CE0", VA = "0x1812FA0E0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601A11A RID: 106778 RVA: 0x000A0350 File Offset: 0x0009E550
		[Token(Token = "0x601A11A")]
		[Address(RVA = "0x12F9E70", Offset = "0x12F8A70", VA = "0x1812F9E70", Slot = "31")]
		public bool CustomSetActive(bool active)
		{
			return default(bool);
		}

		// Token: 0x0601A11B RID: 106779 RVA: 0x000A0368 File Offset: 0x0009E568
		[Token(Token = "0x601A11B")]
		[Address(RVA = "0x12F9F90", Offset = "0x12F8B90", VA = "0x1812F9F90", Slot = "32")]
		protected virtual bool DoCustomSetActive(bool active)
		{
			return default(bool);
		}

		// Token: 0x0601A11C RID: 106780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A11C")]
		[Address(RVA = "0x12FA1C0", Offset = "0x12F8DC0", VA = "0x1812FA1C0")]
		protected SandboxV2TransparentState()
		{
		}

		// Token: 0x0601A11D RID: 106781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A11D")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601A11E RID: 106782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A11E")]
		[Address(RVA = "0xE63460", Offset = "0xE62060", VA = "0x180E63460")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x04020D5D RID: 134493
		[Token(Token = "0x4020D5D")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04020D5E RID: 134494
		[Token(Token = "0x4020D5E")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04020D5F RID: 134495
		[Token(Token = "0x4020D5F")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_CustomSetActive;

		// Token: 0x04020D60 RID: 134496
		[Token(Token = "0x4020D60")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_DoCustomSetActive;

		// Token: 0x04020D61 RID: 134497
		[Token(Token = "0x4020D61")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
