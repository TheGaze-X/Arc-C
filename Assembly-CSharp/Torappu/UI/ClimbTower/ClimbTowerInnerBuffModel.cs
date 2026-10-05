using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DC9 RID: 24009
	[Token(Token = "0x2005DC9")]
	public class ClimbTowerInnerBuffModel : IHotfixable
	{
		// Token: 0x06022CA0 RID: 142496 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CA0")]
		[Address(RVA = "0x1D558E0", Offset = "0x1D544E0", VA = "0x181D558E0")]
		public void LoadData(string buff)
		{
		}

		// Token: 0x06022CA1 RID: 142497 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022CA1")]
		[Address(RVA = "0x1D55820", Offset = "0x1D54420", VA = "0x181D55820")]
		public string GetProfessionIconName()
		{
			return null;
		}

		// Token: 0x06022CA2 RID: 142498 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022CA2")]
		[Address(RVA = "0x1D55760", Offset = "0x1D54360", VA = "0x181D55760")]
		public string GetBuffName()
		{
			return null;
		}

		// Token: 0x06022CA3 RID: 142499 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CA3")]
		[Address(RVA = "0x1D55A00", Offset = "0x1D54600", VA = "0x181D55A00")]
		public ClimbTowerInnerBuffModel()
		{
		}

		// Token: 0x0402FDA3 RID: 196003
		[Token(Token = "0x402FDA3")]
		[FieldOffset(Offset = "0x10")]
		public string buffId;

		// Token: 0x0402FDA4 RID: 196004
		[Token(Token = "0x402FDA4")]
		[FieldOffset(Offset = "0x18")]
		public string buffDesc;

		// Token: 0x0402FDA5 RID: 196005
		[Token(Token = "0x402FDA5")]
		[FieldOffset(Offset = "0x20")]
		public int professionOrder;

		// Token: 0x0402FDA6 RID: 196006
		[Token(Token = "0x402FDA6")]
		[FieldOffset(Offset = "0x24")]
		public int sortId;

		// Token: 0x0402FDA7 RID: 196007
		[Token(Token = "0x402FDA7")]
		[FieldOffset(Offset = "0x28")]
		public ProfessionCategory buffProfession;

		// Token: 0x0402FDA8 RID: 196008
		[Token(Token = "0x402FDA8")]
		[FieldOffset(Offset = "0x2C")]
		public ClimbTowerTaticalBuffType buffType;

		// Token: 0x0402FDA9 RID: 196009
		[Token(Token = "0x402FDA9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FDAA RID: 196010
		[Token(Token = "0x402FDAA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_GetProfessionIconName;

		// Token: 0x0402FDAB RID: 196011
		[Token(Token = "0x402FDAB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_GetBuffName;

		// Token: 0x0402FDAC RID: 196012
		[Token(Token = "0x402FDAC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
