using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004209 RID: 16905
	[Token(Token = "0x2004209")]
	public class SandboxV2TopBarFloatPanelView : MonoBehaviour, IHotfixable
	{
		// Token: 0x0601A14F RID: 106831 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A14F")]
		[Address(RVA = "0x12F6F50", Offset = "0x12F5B50", VA = "0x1812F6F50")]
		public void Render(SandboxV2DungeonViewModel viewModel)
		{
		}

		// Token: 0x0601A150 RID: 106832 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A150")]
		[Address(RVA = "0x12F7220", Offset = "0x12F5E20", VA = "0x1812F7220")]
		private void _InitIfNot()
		{
		}

		// Token: 0x0601A151 RID: 106833 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A151")]
		[Address(RVA = "0x12F6C30", Offset = "0x12F5830", VA = "0x1812F6C30")]
		public void OnExpeditionClick()
		{
		}

		// Token: 0x0601A152 RID: 106834 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A152")]
		[Address(RVA = "0x12F6AE0", Offset = "0x12F56E0", VA = "0x1812F6AE0")]
		public void OnEventClick()
		{
		}

		// Token: 0x0601A153 RID: 106835 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A153")]
		[Address(RVA = "0x12F6EC0", Offset = "0x12F5AC0", VA = "0x1812F6EC0")]
		public void OnSphereClick()
		{
		}

		// Token: 0x0601A154 RID: 106836 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A154")]
		[Address(RVA = "0x12F6DA0", Offset = "0x12F59A0", VA = "0x1812F6DA0")]
		public void OnLogisticsClick()
		{
		}

		// Token: 0x0601A155 RID: 106837 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A155")]
		[Address(RVA = "0x12F6E30", Offset = "0x12F5A30", VA = "0x1812F6E30")]
		public void OnRiftEffectsClick()
		{
		}

		// Token: 0x0601A156 RID: 106838 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A156")]
		[Address(RVA = "0x12F72F0", Offset = "0x12F5EF0", VA = "0x1812F72F0")]
		public SandboxV2TopBarFloatPanelView()
		{
		}

		// Token: 0x04020DEC RID: 134636
		[Token(Token = "0x4020DEC")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SandboxV2DungeonExpeditionEffectFloatPanel _expeditionFloatPanel;

		// Token: 0x04020DED RID: 134637
		[Token(Token = "0x4020DED")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SandboxV2DungeonEventEffectFloatPanel _eventFloatPanel;

		// Token: 0x04020DEE RID: 134638
		[Token(Token = "0x4020DEE")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private SandboxV2DungeonLogisticsEffectFloatPanel _logisticsFloatPanel;

		// Token: 0x04020DEF RID: 134639
		[Token(Token = "0x4020DEF")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private SandboxV2DungeonSphereFloatPanel _sphereFloatPanel;

		// Token: 0x04020DF0 RID: 134640
		[Token(Token = "0x4020DF0")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private SandboxV2DungeonRiftEffectFloatPanel _riftEffectFloatPanel;

		// Token: 0x04020DF1 RID: 134641
		[Token(Token = "0x4020DF1")]
		[FieldOffset(Offset = "0x40")]
		private bool m_isInited;

		// Token: 0x04020DF2 RID: 134642
		[Token(Token = "0x4020DF2")]
		[FieldOffset(Offset = "0x48")]
		private SandboxV2DungeonViewModel m_cachedViewModel;

		// Token: 0x04020DF3 RID: 134643
		[Token(Token = "0x4020DF3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x04020DF4 RID: 134644
		[Token(Token = "0x4020DF4")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0__InitIfNot;

		// Token: 0x04020DF5 RID: 134645
		[Token(Token = "0x4020DF5")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_OnExpeditionClick;

		// Token: 0x04020DF6 RID: 134646
		[Token(Token = "0x4020DF6")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_OnEventClick;

		// Token: 0x04020DF7 RID: 134647
		[Token(Token = "0x4020DF7")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_OnSphereClick;

		// Token: 0x04020DF8 RID: 134648
		[Token(Token = "0x4020DF8")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_OnLogisticsClick;

		// Token: 0x04020DF9 RID: 134649
		[Token(Token = "0x4020DF9")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_OnRiftEffectsClick;

		// Token: 0x04020DFA RID: 134650
		[Token(Token = "0x4020DFA")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
