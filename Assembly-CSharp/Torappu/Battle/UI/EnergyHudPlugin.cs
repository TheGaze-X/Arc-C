using System;
using Il2CppDummyDll;
using Torappu.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x0200328F RID: 12943
	[Token(Token = "0x200328F")]
	public class EnergyHudPlugin : UIPluginTalent.UnitTalentUIPlugin
	{
		// Token: 0x060148BD RID: 84157 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148BD")]
		[Address(RVA = "0xCCCCE0", Offset = "0xCCB8E0", VA = "0x180CCCCE0", Slot = "9")]
		protected override void DoAttach(Unit owner, UIPluginTalent talent)
		{
		}

		// Token: 0x060148BE RID: 84158 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148BE")]
		[Address(RVA = "0xCCCE40", Offset = "0xCCBA40", VA = "0x180CCCE40", Slot = "10")]
		protected override void DoDetach()
		{
		}

		// Token: 0x060148BF RID: 84159 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148BF")]
		[Address(RVA = "0xCCCEB0", Offset = "0xCCBAB0", VA = "0x180CCCEB0")]
		private void Update()
		{
		}

		// Token: 0x060148C0 RID: 84160 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148C0")]
		[Address(RVA = "0xCCD210", Offset = "0xCCBE10", VA = "0x180CCD210")]
		public EnergyHudPlugin()
		{
		}

		// Token: 0x060148C1 RID: 84161 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148C1")]
		[Address(RVA = "0xCC3AD0", Offset = "0xCC26D0", VA = "0x180CC3AD0")]
		private void <>xLuaBaseProxy_DoAttach(Unit P0, UIPluginTalent P1)
		{
		}

		// Token: 0x060148C2 RID: 84162 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148C2")]
		[Address(RVA = "0xCCC680", Offset = "0xCCB280", VA = "0x180CCC680")]
		private void <>xLuaBaseProxy_DoDetach()
		{
		}

		// Token: 0x040184BE RID: 99518
		[Token(Token = "0x40184BE")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIBulletBar _energyBar;

		// Token: 0x040184BF RID: 99519
		[Token(Token = "0x40184BF")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private UITextSlider _energyCastSlider;

		// Token: 0x040184C0 RID: 99520
		[Token(Token = "0x40184C0")]
		[FieldOffset(Offset = "0x40")]
		private EnergyHudPluginTalent m_hudTalent;

		// Token: 0x040184C1 RID: 99521
		[Token(Token = "0x40184C1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x040184C2 RID: 99522
		[Token(Token = "0x40184C2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_DoDetach;

		// Token: 0x040184C3 RID: 99523
		[Token(Token = "0x40184C3")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040184C4 RID: 99524
		[Token(Token = "0x40184C4")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
