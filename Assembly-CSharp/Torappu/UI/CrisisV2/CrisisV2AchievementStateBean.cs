using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.CrisisV2
{
	// Token: 0x02005941 RID: 22849
	[Token(Token = "0x2005941")]
	public class CrisisV2AchievementStateBean : IStateBean, IHotfixable
	{
		// Token: 0x06021496 RID: 136342 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6021496")]
		[Address(RVA = "0x1BA1560", Offset = "0x1BA0160", VA = "0x181BA1560")]
		public CrisisV2AchievementStateBean()
		{
		}

		// Token: 0x0402D624 RID: 185892
		[Token(Token = "0x402D624")]
		[FieldOffset(Offset = "0x10")]
		public CrisisV2AchievementProperty property;

		// Token: 0x0402D625 RID: 185893
		[Token(Token = "0x402D625")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
