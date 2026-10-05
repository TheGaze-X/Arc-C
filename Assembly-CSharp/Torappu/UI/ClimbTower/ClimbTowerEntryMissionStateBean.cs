using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D2E RID: 23854
	[Token(Token = "0x2005D2E")]
	public class ClimbTowerEntryMissionStateBean : IStateBean, IHotfixable
	{
		// Token: 0x060228AC RID: 141484 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228AC")]
		[Address(RVA = "0x1D038A0", Offset = "0x1D024A0", VA = "0x181D038A0")]
		public ClimbTowerEntryMissionStateBean()
		{
		}

		// Token: 0x0402F7B2 RID: 194482
		[Token(Token = "0x402F7B2")]
		[FieldOffset(Offset = "0x10")]
		public ClimbTowerEntryMissionProperty property;

		// Token: 0x0402F7B3 RID: 194483
		[Token(Token = "0x402F7B3")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
