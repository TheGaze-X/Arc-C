using System;
using Il2CppDummyDll;
using Torappu.Battle.UI;
using UnityEngine;
using XLua;

namespace Torappu.Battle.Abilities
{
	// Token: 0x02002C14 RID: 11284
	[Token(Token = "0x2002C14")]
	public class BossSpHudCtrlRL3 : AbilityStandard.Behaviour, IHotfixable
	{
		// Token: 0x060130E3 RID: 78051 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130E3")]
		[Address(RVA = "0xB14B00", Offset = "0xB13700", VA = "0x180B14B00", Slot = "10")]
		public override void OnEvent(AbilityStandard.Event ev)
		{
		}

		// Token: 0x060130E4 RID: 78052 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130E4")]
		[Address(RVA = "0xB14DE0", Offset = "0xB139E0", VA = "0x180B14DE0")]
		public BossSpHudCtrlRL3()
		{
		}

		// Token: 0x060130E5 RID: 78053 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60130E5")]
		[Address(RVA = "0xAC2A40", Offset = "0xAC1640", VA = "0x180AC2A40")]
		private void <>xLuaBaseProxy_OnEvent(AbilityStandard.Event P0)
		{
		}

		// Token: 0x0401584A RID: 88138
		[Token(Token = "0x401584A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _isLeft;

		// Token: 0x0401584B RID: 88139
		[Token(Token = "0x401584B")]
		[FieldOffset(Offset = "0x28")]
		private UIBossHudRL3 m_hud;

		// Token: 0x0401584C RID: 88140
		[Token(Token = "0x401584C")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OnEvent;

		// Token: 0x0401584D RID: 88141
		[Token(Token = "0x401584D")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
