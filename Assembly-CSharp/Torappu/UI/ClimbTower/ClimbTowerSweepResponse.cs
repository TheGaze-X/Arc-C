using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C9A RID: 23706
	[Token(Token = "0x2005C9A")]
	public class ClimbTowerSweepResponse : PlayerDeltaResponse
	{
		// Token: 0x06022518 RID: 140568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022518")]
		[Address(RVA = "0x1022FA0", Offset = "0x1021BA0", VA = "0x181022FA0")]
		public ClimbTowerSweepResponse()
		{
		}

		// Token: 0x0402F1F0 RID: 193008
		[Token(Token = "0x402F1F0")]
		[FieldOffset(Offset = "0x28")]
		public ClimbTowerSweepResponse.ClimbTowerSettleGameReward reward;

		// Token: 0x0402F1F1 RID: 193009
		[Token(Token = "0x402F1F1")]
		[FieldOffset(Offset = "0x30")]
		public long ts;

		// Token: 0x0402F1F2 RID: 193010
		[Token(Token = "0x402F1F2")]
		[FieldOffset(Offset = "0x38")]
		public string tower;

		// Token: 0x0402F1F3 RID: 193011
		[Token(Token = "0x402F1F3")]
		[FieldOffset(Offset = "0x40")]
		public bool isHard;

		// Token: 0x0402F1F4 RID: 193012
		[Token(Token = "0x402F1F4")]
		[FieldOffset(Offset = "0x44")]
		public int best;

		// Token: 0x02005C9B RID: 23707
		[Token(Token = "0x2005C9B")]
		public class ClimbTowerBattleFinishGameItemDelta
		{
			// Token: 0x06022519 RID: 140569 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022519")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ClimbTowerBattleFinishGameItemDelta()
			{
			}

			// Token: 0x0402F1F5 RID: 193013
			[Token(Token = "0x402F1F5")]
			[FieldOffset(Offset = "0x10")]
			public int from;

			// Token: 0x0402F1F6 RID: 193014
			[Token(Token = "0x402F1F6")]
			[FieldOffset(Offset = "0x14")]
			public int to;
		}

		// Token: 0x02005C9C RID: 23708
		[Token(Token = "0x2005C9C")]
		public class ClimbTowerSettleGameReward
		{
			// Token: 0x0602251A RID: 140570 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x602251A")]
			[Address(RVA = "0x1CC2BA0", Offset = "0x1CC17A0", VA = "0x181CC2BA0")]
			public ClimbTowerSettleGameReward()
			{
			}

			// Token: 0x0402F1F7 RID: 193015
			[Token(Token = "0x402F1F7")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty(PropertyName = "low")]
			public ClimbTowerSweepResponse.ClimbTowerBattleFinishGameItemDelta lowerItem;

			// Token: 0x0402F1F8 RID: 193016
			[Token(Token = "0x402F1F8")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty(PropertyName = "high")]
			public ClimbTowerSweepResponse.ClimbTowerBattleFinishGameItemDelta higherItem;
		}
	}
}
