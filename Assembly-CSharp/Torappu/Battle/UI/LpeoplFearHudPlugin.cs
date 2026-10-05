using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003294 RID: 12948
	[Token(Token = "0x2003294")]
	public class LpeoplFearHudPlugin : UIPluginTalent.UnitTalentUIPlugin
	{
		// Token: 0x060148E0 RID: 84192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148E0")]
		[Address(RVA = "0xCD2840", Offset = "0xCD1440", VA = "0x180CD2840", Slot = "9")]
		protected override void DoAttach(Unit owner, UIPluginTalent uiTalent)
		{
		}

		// Token: 0x060148E1 RID: 84193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148E1")]
		[Address(RVA = "0xCD29B0", Offset = "0xCD15B0", VA = "0x180CD29B0")]
		private void Update()
		{
		}

		// Token: 0x060148E2 RID: 84194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148E2")]
		[Address(RVA = "0xCD2C20", Offset = "0xCD1820", VA = "0x180CD2C20")]
		public LpeoplFearHudPlugin()
		{
		}

		// Token: 0x060148E3 RID: 84195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148E3")]
		[Address(RVA = "0xCC3AD0", Offset = "0xCC26D0", VA = "0x180CC3AD0")]
		private void <>xLuaBaseProxy_DoAttach(Unit P0, UIPluginTalent P1)
		{
		}

		// Token: 0x040184F9 RID: 99577
		[Token(Token = "0x40184F9")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIFollowSlider _fearSlider;

		// Token: 0x040184FA RID: 99578
		[Token(Token = "0x40184FA")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _fullFearUI;

		// Token: 0x040184FB RID: 99579
		[Token(Token = "0x40184FB")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private GameObject _fullNotFearUI;

		// Token: 0x040184FC RID: 99580
		[Token(Token = "0x40184FC")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Image _icon;

		// Token: 0x040184FD RID: 99581
		[Token(Token = "0x40184FD")]
		[FieldOffset(Offset = "0x50")]
		private LpeoplFearHudPluginTalent m_hudTalent;

		// Token: 0x040184FE RID: 99582
		[Token(Token = "0x40184FE")]
		private const float initAlpha = 0.2f;

		// Token: 0x040184FF RID: 99583
		[Token(Token = "0x40184FF")]
		private const float deltaAlpha = 1.2f;

		// Token: 0x04018500 RID: 99584
		[Token(Token = "0x4018500")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x04018501 RID: 99585
		[Token(Token = "0x4018501")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x04018502 RID: 99586
		[Token(Token = "0x4018502")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
