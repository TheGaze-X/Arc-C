using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DCA RID: 24010
	[Token(Token = "0x2005DCA")]
	public class ClimbTowerInnerBuffListModel : IHotfixable
	{
		// Token: 0x06022CA4 RID: 142500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CA4")]
		[Address(RVA = "0x1D55260", Offset = "0x1D53E60", VA = "0x181D55260")]
		public void LoadData()
		{
		}

		// Token: 0x06022CA5 RID: 142501 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CA5")]
		[Address(RVA = "0x1D556B0", Offset = "0x1D542B0", VA = "0x181D556B0")]
		public ClimbTowerInnerBuffListModel()
		{
		}

		// Token: 0x0402FDAD RID: 196013
		[Token(Token = "0x402FDAD")]
		[FieldOffset(Offset = "0x10")]
		public List<ClimbTowerInnerBuffModel> buffs;

		// Token: 0x0402FDAE RID: 196014
		[Token(Token = "0x402FDAE")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FDAF RID: 196015
		[Token(Token = "0x402FDAF")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
