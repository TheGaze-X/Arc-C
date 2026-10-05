using System;
using Il2CppDummyDll;
using Torappu.Battle;
using XLua;

namespace Torappu.UI.SandboxPerm.SandboxV2
{
	// Token: 0x02004377 RID: 17271
	[Token(Token = "0x2004377")]
	public class SandboxV2RacingBattleStartPlugin : BattleStartController.IPlugin, IHotfixable
	{
		// Token: 0x0601A7E9 RID: 108521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7E9")]
		[Address(RVA = "0x1397740", Offset = "0x1396340", VA = "0x181397740", Slot = "4")]
		public void OverrideInParams(ref BattleInOut.InParams inParams, CommonStartBattleResponse response)
		{
		}

		// Token: 0x0601A7EA RID: 108522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601A7EA")]
		[Address(RVA = "0x1397BB0", Offset = "0x13967B0", VA = "0x181397BB0")]
		public SandboxV2RacingBattleStartPlugin()
		{
		}

		// Token: 0x04021B94 RID: 138132
		[Token(Token = "0x4021B94")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_OverrideInParams;

		// Token: 0x04021B95 RID: 138133
		[Token(Token = "0x4021B95")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
