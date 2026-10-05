using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D90 RID: 23952
	[Token(Token = "0x2005D90")]
	public class ClimbTowerSquadSingleEditModel
	{
		// Token: 0x170051F9 RID: 20985
		// (get) Token: 0x06022B97 RID: 142231 RVA: 0x000BE9B0 File Offset: 0x000BCBB0
		// (set) Token: 0x06022B98 RID: 142232 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170051F9")]
		public int selectCardId
		{
			[Token(Token = "0x6022B97")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6022B98")]
			[Address(RVA = "0x4EA9A0", Offset = "0x4E95A0", VA = "0x1804EA9A0")]
			set
			{
			}
		}

		// Token: 0x170051FA RID: 20986
		// (get) Token: 0x06022B99 RID: 142233 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051FA")]
		public List<ClimbTowerSquadItemModel> squadItemList
		{
			[Token(Token = "0x6022B99")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022B9A RID: 142234 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022B9A")]
		[Address(RVA = "0x1D43680", Offset = "0x1D42280", VA = "0x181D43680")]
		public ClimbTowerSquadItemModel FindCharModel(int cardId)
		{
			return null;
		}

		// Token: 0x06022B9B RID: 142235 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B9B")]
		[Address(RVA = "0x1D43790", Offset = "0x1D42390", VA = "0x181D43790")]
		public void LoadData(UIPage page, int cardId)
		{
		}

		// Token: 0x06022B9C RID: 142236 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B9C")]
		[Address(RVA = "0x1D43A50", Offset = "0x1D42650", VA = "0x181D43A50")]
		public ClimbTowerSquadSingleEditModel()
		{
		}

		// Token: 0x0402FBC2 RID: 195522
		[Token(Token = "0x402FBC2")]
		[FieldOffset(Offset = "0x10")]
		private List<ClimbTowerSquadItemModel> m_squadItemList;

		// Token: 0x0402FBC3 RID: 195523
		[Token(Token = "0x402FBC3")]
		[FieldOffset(Offset = "0x18")]
		private int m_selectCardId;

		// Token: 0x0402FBC4 RID: 195524
		[Token(Token = "0x402FBC4")]
		[FieldOffset(Offset = "0x20")]
		public long gameStartTs;
	}
}
