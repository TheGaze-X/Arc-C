using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DD3 RID: 24019
	[Token(Token = "0x2005DD3")]
	public class ClimbTowerRewardModel : IHotfixable
	{
		// Token: 0x06022CB8 RID: 142520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CB8")]
		[Address(RVA = "0x1D58000", Offset = "0x1D56C00", VA = "0x181D58000")]
		public void LoadData(ClimbTowerSingleTowerData.ClimbTowerTaskRewardData rewardItem, TowerOuter.TowerData towerPlayerData)
		{
		}

		// Token: 0x06022CB9 RID: 142521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022CB9")]
		[Address(RVA = "0x1D58110", Offset = "0x1D56D10", VA = "0x181D58110")]
		public ClimbTowerRewardModel()
		{
		}

		// Token: 0x0402FDDE RID: 196062
		[Token(Token = "0x402FDDE")]
		[FieldOffset(Offset = "0x10")]
		public int levelNum;

		// Token: 0x0402FDDF RID: 196063
		[Token(Token = "0x402FDDF")]
		[FieldOffset(Offset = "0x18")]
		public List<ItemBundle> rewards;

		// Token: 0x0402FDE0 RID: 196064
		[Token(Token = "0x402FDE0")]
		[FieldOffset(Offset = "0x20")]
		public ClimbTowerRewardModel.State state;

		// Token: 0x0402FDE1 RID: 196065
		[Token(Token = "0x402FDE1")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FDE2 RID: 196066
		[Token(Token = "0x402FDE2")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge _c__Hotfix0_ctor;

		// Token: 0x02005DD4 RID: 24020
		[Token(Token = "0x2005DD4")]
		public enum State
		{
			// Token: 0x0402FDE4 RID: 196068
			[Token(Token = "0x402FDE4")]
			STATE_CAN_RECEIVE,
			// Token: 0x0402FDE5 RID: 196069
			[Token(Token = "0x402FDE5")]
			STATE_INCOMPLETED,
			// Token: 0x0402FDE6 RID: 196070
			[Token(Token = "0x402FDE6")]
			STATE_COMPLETED
		}
	}
}
