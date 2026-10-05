using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D51 RID: 23889
	[Token(Token = "0x2005D51")]
	public class ClimbTowerRecruitSubGodStateBean : IStateBean, IHotfixable
	{
		// Token: 0x17005176 RID: 20854
		// (get) Token: 0x06022982 RID: 141698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005176")]
		public ClimbTowerRecruitSubGodProp prop
		{
			[Token(Token = "0x6022982")]
			[Address(RVA = "0x1D1DB40", Offset = "0x1D1C740", VA = "0x181D1DB40")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022983 RID: 141699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022983")]
		[Address(RVA = "0x1D1DA50", Offset = "0x1D1C650", VA = "0x181D1DA50")]
		public ClimbTowerRecruitSubGodStateBean()
		{
		}

		// Token: 0x0402F8CD RID: 194765
		[Token(Token = "0x402F8CD")]
		[FieldOffset(Offset = "0x10")]
		private ClimbTowerRecruitSubGodProp m_prop;

		// Token: 0x0402F8CE RID: 194766
		[Token(Token = "0x402F8CE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x0402F8CF RID: 194767
		[Token(Token = "0x402F8CF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
