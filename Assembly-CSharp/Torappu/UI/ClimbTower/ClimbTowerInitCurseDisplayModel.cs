using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D3E RID: 23870
	[Token(Token = "0x2005D3E")]
	public class ClimbTowerInitCurseDisplayModel : IHotfixable
	{
		// Token: 0x17005158 RID: 20824
		// (get) Token: 0x0602291B RID: 141595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005158")]
		public List<ClimbTowerCurseCardModel> curseCardList
		{
			[Token(Token = "0x602291B")]
			[Address(RVA = "0x1D17CF0", Offset = "0x1D168F0", VA = "0x181D17CF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x0602291C RID: 141596 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602291C")]
		[Address(RVA = "0x1D17890", Offset = "0x1D16490", VA = "0x181D17890")]
		public void InitData()
		{
		}

		// Token: 0x0602291D RID: 141597 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602291D")]
		[Address(RVA = "0x1D17C40", Offset = "0x1D16840", VA = "0x181D17C40")]
		public ClimbTowerInitCurseDisplayModel()
		{
		}

		// Token: 0x0402F836 RID: 194614
		[Token(Token = "0x402F836")]
		[FieldOffset(Offset = "0x10")]
		private List<ClimbTowerCurseCardModel> m_curseCardList;

		// Token: 0x0402F837 RID: 194615
		[Token(Token = "0x402F837")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_curseCardList;

		// Token: 0x0402F838 RID: 194616
		[Token(Token = "0x402F838")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402F839 RID: 194617
		[Token(Token = "0x402F839")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
