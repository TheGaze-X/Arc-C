using System;
using Il2CppDummyDll;
using Newtonsoft.Json;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005C93 RID: 23699
	[Token(Token = "0x2005C93")]
	public class ClimbTowerBattleFinishResponse : DefaultFinishBattleResponse
	{
		// Token: 0x06022511 RID: 140561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022511")]
		[Address(RVA = "0x1CB8E10", Offset = "0x1CB7A10", VA = "0x181CB8E10")]
		public ClimbTowerBattleFinishResponse()
		{
		}

		// Token: 0x0402F1DC RID: 192988
		[Token(Token = "0x402F1DC")]
		[FieldOffset(Offset = "0xA0")]
		public bool isNewRecord;

		// Token: 0x0402F1DD RID: 192989
		[Token(Token = "0x402F1DD")]
		[FieldOffset(Offset = "0xA8")]
		public ClimbTowerBattleFinishDropInfo[] drop;

		// Token: 0x0402F1DE RID: 192990
		[Token(Token = "0x402F1DE")]
		[FieldOffset(Offset = "0xB0")]
		public ClimbTowerBattleFinishDropInfo[] offer;

		// Token: 0x0402F1DF RID: 192991
		[Token(Token = "0x402F1DF")]
		[FieldOffset(Offset = "0xB8")]
		public string show;

		// Token: 0x0402F1E0 RID: 192992
		[Token(Token = "0x402F1E0")]
		[FieldOffset(Offset = "0xC0")]
		public ClimbTowerBattleFinishTrapInfo[] trap;

		// Token: 0x0402F1E1 RID: 192993
		[Token(Token = "0x402F1E1")]
		[FieldOffset(Offset = "0xC8")]
		public ClimbTowerBattleFinishResponse.ClimbTowerSettleGameReward reward;

		// Token: 0x02005C94 RID: 23700
		[Token(Token = "0x2005C94")]
		public class ClimbTowerBattleFinishGameItemDelta
		{
			// Token: 0x06022512 RID: 140562 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022512")]
			[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
			public ClimbTowerBattleFinishGameItemDelta()
			{
			}

			// Token: 0x0402F1E2 RID: 192994
			[Token(Token = "0x402F1E2")]
			[FieldOffset(Offset = "0x10")]
			public int from;

			// Token: 0x0402F1E3 RID: 192995
			[Token(Token = "0x402F1E3")]
			[FieldOffset(Offset = "0x14")]
			public int to;
		}

		// Token: 0x02005C95 RID: 23701
		[Token(Token = "0x2005C95")]
		public class ClimbTowerSettleGameReward
		{
			// Token: 0x06022513 RID: 140563 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6022513")]
			[Address(RVA = "0x1CC2C40", Offset = "0x1CC1840", VA = "0x181CC2C40")]
			public ClimbTowerSettleGameReward()
			{
			}

			// Token: 0x0402F1E4 RID: 192996
			[Token(Token = "0x402F1E4")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty(PropertyName = "low")]
			public ClimbTowerBattleFinishResponse.ClimbTowerBattleFinishGameItemDelta lowerItem;

			// Token: 0x0402F1E5 RID: 192997
			[Token(Token = "0x402F1E5")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty(PropertyName = "high")]
			public ClimbTowerBattleFinishResponse.ClimbTowerBattleFinishGameItemDelta higherItem;
		}
	}
}
