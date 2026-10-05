using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x0200421E RID: 16926
	[Token(Token = "0x200421E")]
	public abstract class SandboxV2TrackerState : SandboxV2TransparentState
	{
		// Token: 0x0601A1C7 RID: 106951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1C7")]
		[Address(RVA = "0x13113D0", Offset = "0x130FFD0", VA = "0x1813113D0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601A1C8 RID: 106952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1C8")]
		[Address(RVA = "0x13114C0", Offset = "0x13100C0", VA = "0x1813114C0", Slot = "18")]
		protected override void OnExit()
		{
		}

		// Token: 0x0601A1C9 RID: 106953 RVA: 0x000A0410 File Offset: 0x0009E610
		[Token(Token = "0x601A1C9")]
		[Address(RVA = "0x1311360", Offset = "0x130FF60", VA = "0x181311360", Slot = "32")]
		protected override bool DoCustomSetActive(bool active)
		{
			return default(bool);
		}

		// Token: 0x0601A1CA RID: 106954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1CA")]
		[Address(RVA = "0x1311670", Offset = "0x1310270", VA = "0x181311670")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A1CB RID: 106955 RVA: 0x000A0428 File Offset: 0x0009E628
		[Token(Token = "0x601A1CB")]
		[Address(RVA = "0x1311720", Offset = "0x1310320", VA = "0x181311720")]
		protected bool _TryFocusNode(string nodeId, string uniqueId)
		{
			return default(bool);
		}

		// Token: 0x0601A1CC RID: 106956 RVA: 0x000A0440 File Offset: 0x0009E640
		[Token(Token = "0x601A1CC")]
		[Address(RVA = "0x1311980", Offset = "0x1310580", VA = "0x181311980")]
		protected bool _TrySelectNode(string nodeId)
		{
			return default(bool);
		}

		// Token: 0x0601A1CD RID: 106957 RVA: 0x000A0458 File Offset: 0x0009E658
		[Token(Token = "0x601A1CD")]
		[Address(RVA = "0x13118C0", Offset = "0x13104C0", VA = "0x1813118C0")]
		private bool _TryResetDungeonStatus()
		{
			return default(bool);
		}

		// Token: 0x0601A1CE RID: 106958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1CE")]
		[Address(RVA = "0x1311CA0", Offset = "0x13108A0", VA = "0x181311CA0")]
		protected SandboxV2TrackerState()
		{
		}

		// Token: 0x0601A1CF RID: 106959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1CF")]
		[Address(RVA = "0x12A1BB0", Offset = "0x12A07B0", VA = "0x1812A1BB0")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601A1D0 RID: 106960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A1D0")]
		[Address(RVA = "0x1311660", Offset = "0x1310260", VA = "0x181311660")]
		private void <>xLuaBaseProxy_OnExit()
		{
		}

		// Token: 0x0601A1D1 RID: 106961 RVA: 0x000A0470 File Offset: 0x0009E670
		[Token(Token = "0x601A1D1")]
		[Address(RVA = "0x1311650", Offset = "0x1310250", VA = "0x181311650")]
		private bool <>xLuaBaseProxy_DoCustomSetActive(bool P0)
		{
			return default(bool);
		}

		// Token: 0x04020F08 RID: 134920
		[Token(Token = "0x4020F08")]
		[FieldOffset(Offset = "0x70")]
		private bool m_inited;

		// Token: 0x04020F09 RID: 134921
		[Token(Token = "0x4020F09")]
		[FieldOffset(Offset = "0x78")]
		protected SandboxV2DungeonController m_controller;

		// Token: 0x04020F0A RID: 134922
		[Token(Token = "0x4020F0A")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04020F0B RID: 134923
		[Token(Token = "0x4020F0B")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnExit;

		// Token: 0x04020F0C RID: 134924
		[Token(Token = "0x4020F0C")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_DoCustomSetActive;

		// Token: 0x04020F0D RID: 134925
		[Token(Token = "0x4020F0D")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020F0E RID: 134926
		[Token(Token = "0x4020F0E")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__TryFocusNode;

		// Token: 0x04020F0F RID: 134927
		[Token(Token = "0x4020F0F")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__TrySelectNode;

		// Token: 0x04020F10 RID: 134928
		[Token(Token = "0x4020F10")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__TryResetDungeonStatus;

		// Token: 0x04020F11 RID: 134929
		[Token(Token = "0x4020F11")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
