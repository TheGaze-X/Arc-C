using System;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DAB RID: 23979
	[Token(Token = "0x2005DAB")]
	public class ClimbTowerSweepEndingStateBean : IStateBean, IHotfixable
	{
		// Token: 0x1700522E RID: 21038
		// (get) Token: 0x06022C4B RID: 142411 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700522E")]
		public ClimbTowerSweepEndingProperty prop
		{
			[Token(Token = "0x6022C4B")]
			[Address(RVA = "0x1D59EC0", Offset = "0x1D58AC0", VA = "0x181D59EC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022C4C RID: 142412 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C4C")]
		[Address(RVA = "0x1D59CC0", Offset = "0x1D588C0", VA = "0x181D59CC0")]
		public void LoadData()
		{
		}

		// Token: 0x06022C4D RID: 142413 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C4D")]
		[Address(RVA = "0x1D59D50", Offset = "0x1D58950", VA = "0x181D59D50")]
		public void SetDataSource(ClimbTowerSweepResponse input)
		{
		}

		// Token: 0x06022C4E RID: 142414 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C4E")]
		[Address(RVA = "0x1D59DD0", Offset = "0x1D589D0", VA = "0x181D59DD0")]
		public ClimbTowerSweepEndingStateBean()
		{
		}

		// Token: 0x0402FCA7 RID: 195751
		[Token(Token = "0x402FCA7")]
		[FieldOffset(Offset = "0x10")]
		private ClimbTowerSweepEndingProperty m_prop;

		// Token: 0x0402FCA8 RID: 195752
		[Token(Token = "0x402FCA8")]
		[FieldOffset(Offset = "0x18")]
		private ClimbTowerSweepResponse m_inputRes;

		// Token: 0x0402FCA9 RID: 195753
		[Token(Token = "0x402FCA9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_prop;

		// Token: 0x0402FCAA RID: 195754
		[Token(Token = "0x402FCAA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FCAB RID: 195755
		[Token(Token = "0x402FCAB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SetDataSource;

		// Token: 0x0402FCAC RID: 195756
		[Token(Token = "0x402FCAC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
