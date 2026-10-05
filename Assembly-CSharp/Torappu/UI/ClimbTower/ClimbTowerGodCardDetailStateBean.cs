using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D31 RID: 23857
	[Token(Token = "0x2005D31")]
	public class ClimbTowerGodCardDetailStateBean : IStateBean, IHotfixable
	{
		// Token: 0x060228B7 RID: 141495 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60228B7")]
		[Address(RVA = "0x1D06C90", Offset = "0x1D05890", VA = "0x181D06C90")]
		public ClimbTowerGodCardDetailStateBean()
		{
		}

		// Token: 0x0402F7C4 RID: 194500
		[Token(Token = "0x402F7C4")]
		[FieldOffset(Offset = "0x10")]
		public ClimbTowerEntryGodCardDetailProperty property;

		// Token: 0x0402F7C5 RID: 194501
		[Token(Token = "0x402F7C5")]
		[FieldOffset(Offset = "0x18")]
		public string selectCardId;

		// Token: 0x0402F7C6 RID: 194502
		[Token(Token = "0x402F7C6")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
