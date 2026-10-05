using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x020041F6 RID: 16886
	[Token(Token = "0x20041F6")]
	public class SandboxV2DungeonNodeUpgradeState : PopupFloatState
	{
		// Token: 0x0601A0FF RID: 106751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x601A0FF")]
		[Address(RVA = "0x12EC940", Offset = "0x12EB540", VA = "0x1812EC940", Slot = "9")]
		public override IStateBean GetCacheBean()
		{
			return null;
		}

		// Token: 0x0601A100 RID: 106752 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A100")]
		[Address(RVA = "0x12EC9A0", Offset = "0x12EB5A0", VA = "0x1812EC9A0", Slot = "14")]
		protected override void OnEnter()
		{
		}

		// Token: 0x0601A101 RID: 106753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A101")]
		[Address(RVA = "0x12ECBF0", Offset = "0x12EB7F0", VA = "0x1812ECBF0", Slot = "15")]
		protected override void OnResume()
		{
		}

		// Token: 0x0601A102 RID: 106754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A102")]
		[Address(RVA = "0x12ECE50", Offset = "0x12EBA50", VA = "0x1812ECE50")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A103 RID: 106755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A103")]
		[Address(RVA = "0x12ECDB0", Offset = "0x12EB9B0", VA = "0x1812ECDB0")]
		private void _DismissIfCan()
		{
		}

		// Token: 0x0601A104 RID: 106756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A104")]
		[Address(RVA = "0x12ECFD0", Offset = "0x12EBBD0", VA = "0x1812ECFD0")]
		private void _OpenWorkbench()
		{
		}

		// Token: 0x0601A105 RID: 106757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A105")]
		[Address(RVA = "0x12ED230", Offset = "0x12EBE30", VA = "0x1812ED230")]
		private void _RaiseAVGSignal()
		{
		}

		// Token: 0x0601A106 RID: 106758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A106")]
		[Address(RVA = "0x12ED340", Offset = "0x12EBF40", VA = "0x1812ED340")]
		public SandboxV2DungeonNodeUpgradeState()
		{
		}

		// Token: 0x0601A107 RID: 106759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A107")]
		[Address(RVA = "0xE63450", Offset = "0xE62050", VA = "0x180E63450")]
		private void <>xLuaBaseProxy_OnEnter()
		{
		}

		// Token: 0x0601A108 RID: 106760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A108")]
		[Address(RVA = "0xE0F5F0", Offset = "0xE0E1F0", VA = "0x180E0F5F0")]
		private void <>xLuaBaseProxy_OnResume()
		{
		}

		// Token: 0x04020D40 RID: 134464
		[Token(Token = "0x4020D40")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		private SandboxV2DungeonNodeUpgradeView _nodeUpgradeView;

		// Token: 0x04020D41 RID: 134465
		[Token(Token = "0x4020D41")]
		[FieldOffset(Offset = "0x78")]
		private SandboxV2DungeonNodeUpgradeStateBean m_stateBean;

		// Token: 0x04020D42 RID: 134466
		[Token(Token = "0x4020D42")]
		[FieldOffset(Offset = "0x80")]
		private SandboxV2DungeonNodeUpgradeProperty m_prop;

		// Token: 0x04020D43 RID: 134467
		[Token(Token = "0x4020D43")]
		[FieldOffset(Offset = "0x88")]
		private bool m_hasInited;

		// Token: 0x04020D44 RID: 134468
		[Token(Token = "0x4020D44")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_GetCacheBean;

		// Token: 0x04020D45 RID: 134469
		[Token(Token = "0x4020D45")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_OnEnter;

		// Token: 0x04020D46 RID: 134470
		[Token(Token = "0x4020D46")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnResume;

		// Token: 0x04020D47 RID: 134471
		[Token(Token = "0x4020D47")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020D48 RID: 134472
		[Token(Token = "0x4020D48")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__DismissIfCan;

		// Token: 0x04020D49 RID: 134473
		[Token(Token = "0x4020D49")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0__OpenWorkbench;

		// Token: 0x04020D4A RID: 134474
		[Token(Token = "0x4020D4A")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__RaiseAVGSignal;

		// Token: 0x04020D4B RID: 134475
		[Token(Token = "0x4020D4B")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
