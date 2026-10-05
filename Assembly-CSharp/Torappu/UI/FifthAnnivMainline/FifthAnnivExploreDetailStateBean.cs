using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.FifthAnnivMainline
{
	// Token: 0x02004EA8 RID: 20136
	[Token(Token = "0x2004EA8")]
	public class FifthAnnivExploreDetailStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17004683 RID: 18051
		// (get) Token: 0x0601E0AD RID: 123053 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17004683")]
		public FifthAnnivExploreDecisionProp decisionProp
		{
			[Token(Token = "0x601E0AD")]
			[Address(RVA = "0x17B8610", Offset = "0x17B7210", VA = "0x1817B8610")]
			get
			{
				return null;
			}
		}

		// Token: 0x0601E0AE RID: 123054 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x601E0AE")]
		[Address(RVA = "0x17B8520", Offset = "0x17B7120", VA = "0x1817B8520")]
		public FifthAnnivExploreDetailStateBean()
		{
		}

		// Token: 0x04027F2F RID: 163631
		[Token(Token = "0x4027F2F")]
		[FieldOffset(Offset = "0x10")]
		private FifthAnnivExploreDecisionProp m_decisionProp;

		// Token: 0x04027F30 RID: 163632
		[Token(Token = "0x4027F30")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_decisionProp;

		// Token: 0x04027F31 RID: 163633
		[Token(Token = "0x4027F31")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
