using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.Battle.UI
{
	// Token: 0x02003293 RID: 12947
	[Token(Token = "0x2003293")]
	public class HlslpSpHudPlugin : UIPluginTalent.UnitTalentUIPlugin
	{
		// Token: 0x060148DC RID: 84188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148DC")]
		[Address(RVA = "0xCD2500", Offset = "0xCD1100", VA = "0x180CD2500", Slot = "9")]
		protected override void DoAttach(Unit owner, UIPluginTalent uiTalent)
		{
		}

		// Token: 0x060148DD RID: 84189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148DD")]
		[Address(RVA = "0xCD2670", Offset = "0xCD1270", VA = "0x180CD2670")]
		private void Update()
		{
		}

		// Token: 0x060148DE RID: 84190 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148DE")]
		[Address(RVA = "0xCD27E0", Offset = "0xCD13E0", VA = "0x180CD27E0")]
		public HlslpSpHudPlugin()
		{
		}

		// Token: 0x060148DF RID: 84191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60148DF")]
		[Address(RVA = "0xCC3AD0", Offset = "0xCC26D0", VA = "0x180CC3AD0")]
		private void <>xLuaBaseProxy_DoAttach(Unit P0, UIPluginTalent P1)
		{
		}

		// Token: 0x040184F4 RID: 99572
		[Token(Token = "0x40184F4")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private UIFollowSlider _spSlider;

		// Token: 0x040184F5 RID: 99573
		[Token(Token = "0x40184F5")]
		[FieldOffset(Offset = "0x38")]
		private HlslpSpHudPluginTalent m_hudTalent;

		// Token: 0x040184F6 RID: 99574
		[Token(Token = "0x40184F6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_DoAttach;

		// Token: 0x040184F7 RID: 99575
		[Token(Token = "0x40184F7")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_Update;

		// Token: 0x040184F8 RID: 99576
		[Token(Token = "0x40184F8")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
