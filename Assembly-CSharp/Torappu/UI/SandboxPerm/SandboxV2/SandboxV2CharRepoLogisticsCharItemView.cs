using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004020 RID: 16416
	[Token(Token = "0x2004020")]
	public class SandboxV2CharRepoLogisticsCharItemView : SandboxV2CharRepoAbstractItemView
	{
		// Token: 0x06019699 RID: 104089 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6019699")]
		[Address(RVA = "0x121D3E0", Offset = "0x121BFE0", VA = "0x18121D3E0", Slot = "4")]
		public override void Render(int position, SandboxV2CharViewModel charModel, bool isCookClickable)
		{
		}

		// Token: 0x0601969A RID: 104090 RVA: 0x0009DF80 File Offset: 0x0009C180
		[Token(Token = "0x601969A")]
		[Address(RVA = "0x121D370", Offset = "0x121BF70", VA = "0x18121D370", Slot = "8")]
		protected override bool CheckShowSupplyStatusPanel(SandboxV2CharViewModel charModel)
		{
			return default(bool);
		}

		// Token: 0x0601969B RID: 104091 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601969B")]
		[Address(RVA = "0x121D550", Offset = "0x121C150", VA = "0x18121D550")]
		private void _RenderCharLogisticsBeanInfo(SandboxV2CharViewModel charModel)
		{
		}

		// Token: 0x0601969C RID: 104092 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601969C")]
		[Address(RVA = "0x121D620", Offset = "0x121C220", VA = "0x18121D620")]
		public SandboxV2CharRepoLogisticsCharItemView()
		{
		}

		// Token: 0x0601969D RID: 104093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601969D")]
		[Address(RVA = "0x121D540", Offset = "0x121C140", VA = "0x18121D540")]
		private void <>xLuaBaseProxy_Render(int P0, SandboxV2CharViewModel P1, bool P2)
		{
		}

		// Token: 0x0601969E RID: 104094 RVA: 0x0009DF98 File Offset: 0x0009C198
		[Token(Token = "0x601969E")]
		[Address(RVA = "0x121D530", Offset = "0x121C130", VA = "0x18121D530")]
		private bool <>xLuaBaseProxy_CheckShowSupplyStatusPanel(SandboxV2CharViewModel P0)
		{
			return default(bool);
		}

		// Token: 0x0401F9E6 RID: 129510
		[Token(Token = "0x401F9E6")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		private SandboxV2LogisticsCharBeanView _charBeanView;

		// Token: 0x0401F9E7 RID: 129511
		[Token(Token = "0x401F9E7")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_Render;

		// Token: 0x0401F9E8 RID: 129512
		[Token(Token = "0x401F9E8")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_CheckShowSupplyStatusPanel;

		// Token: 0x0401F9E9 RID: 129513
		[Token(Token = "0x401F9E9")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0__RenderCharLogisticsBeanInfo;

		// Token: 0x0401F9EA RID: 129514
		[Token(Token = "0x401F9EA")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
