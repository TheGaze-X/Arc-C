using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041F4 RID: 16884
	[Token(Token = "0x20041F4")]
	public class SandboxV2DungeonNodeStagePreviewState : PopupFloatState
	{
		// Token: 0x0601A0F8 RID: 106744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A0F8")]
		[Address(RVA = "0x12EC3A0", Offset = "0x12EAFA0", VA = "0x1812EC3A0", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601A0F9 RID: 106745 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0F9")]
		[Address(RVA = "0x12EC400", Offset = "0x12EB000", VA = "0x1812EC400", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601A0FA RID: 106746 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0FA")]
		[Address(RVA = "0x12EC690", Offset = "0x12EB290", VA = "0x1812EC690")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A0FB RID: 106747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0FB")]
		[Address(RVA = "0x12EC5F0", Offset = "0x12EB1F0", VA = "0x1812EC5F0")]
		private void _DismissIfCan()
		{
		}

		// Token: 0x0601A0FC RID: 106748 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0FC")]
		[Address(RVA = "0x12EC7C0", Offset = "0x12EB3C0", VA = "0x1812EC7C0")]
		public SandboxV2DungeonNodeStagePreviewState()
		{
		}

		// Token: 0x0601A0FD RID: 106749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A0FD")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x04020D34 RID: 134452
		[Token(Token = "0x4020D34")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2DungeonNodeStagePreviewView _view;

		// Token: 0x04020D35 RID: 134453
		[Token(Token = "0x4020D35")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2DungeonNodeStagePreviewStateBean m_stateBean;

		// Token: 0x04020D36 RID: 134454
		[Token(Token = "0x4020D36")]
		[FieldOffset(Offset = "0x80")]
		private SandboxV2DungeonNodeStagePreviewProperty m_prop;

		// Token: 0x04020D37 RID: 134455
		[Token(Token = "0x4020D37")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x04020D38 RID: 134456
		[Token(Token = "0x4020D38")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04020D39 RID: 134457
		[Token(Token = "0x4020D39")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04020D3A RID: 134458
		[Token(Token = "0x4020D3A")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020D3B RID: 134459
		[Token(Token = "0x4020D3B")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__DismissIfCan;

		// Token: 0x04020D3C RID: 134460
		[Token(Token = "0x4020D3C")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
