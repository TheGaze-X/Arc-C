using System;
using Il2CppDummyDll;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DA4 RID: 23972
	[Token(Token = "0x2005DA4")]
	public class ClimbTowerSquadExpansionCharModel
	{
		// Token: 0x17005222 RID: 21026
		// (get) Token: 0x06022C20 RID: 142368 RVA: 0x000BEB90 File Offset: 0x000BCD90
		[Token(Token = "0x17005222")]
		public bool isNpc
		{
			[Token(Token = "0x6022C20")]
			[Address(RVA = "0x4E7E60", Offset = "0x4E6A60", VA = "0x1804E7E60")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005223 RID: 21027
		// (get) Token: 0x06022C21 RID: 142369 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005223")]
		public string charId
		{
			[Token(Token = "0x6022C21")]
			[Address(RVA = "0x4E5A80", Offset = "0x4E4680", VA = "0x1804E5A80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005224 RID: 21028
		// (get) Token: 0x06022C22 RID: 142370 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005224")]
		public CharacterData charData
		{
			[Token(Token = "0x6022C22")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005225 RID: 21029
		// (get) Token: 0x06022C23 RID: 142371 RVA: 0x000BEBA8 File Offset: 0x000BCDA8
		[Token(Token = "0x17005225")]
		public EvolvePhase evolvePhase
		{
			[Token(Token = "0x6022C23")]
			[Address(RVA = "0x4EF610", Offset = "0x4EE210", VA = "0x1804EF610")]
			get
			{
				return EvolvePhase.PHASE_0;
			}
		}

		// Token: 0x17005226 RID: 21030
		// (get) Token: 0x06022C24 RID: 142372 RVA: 0x000BEBC0 File Offset: 0x000BCDC0
		[Token(Token = "0x17005226")]
		public int level
		{
			[Token(Token = "0x6022C24")]
			[Address(RVA = "0x4FD4B0", Offset = "0x4FC0B0", VA = "0x1804FD4B0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005227 RID: 21031
		// (get) Token: 0x06022C25 RID: 142373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005227")]
		public string portraitId
		{
			[Token(Token = "0x6022C25")]
			[Address(RVA = "0x4EA8A0", Offset = "0x4E94A0", VA = "0x1804EA8A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022C26 RID: 142374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C26")]
		[Address(RVA = "0x1D58170", Offset = "0x1D56D70", VA = "0x181D58170")]
		public void SetData(TowerCurrent.GameCard playerChar)
		{
		}

		// Token: 0x06022C27 RID: 142375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C27")]
		[Address(RVA = "0x4F65E0", Offset = "0x4F51E0", VA = "0x1804F65E0")]
		public ClimbTowerSquadExpansionCharModel()
		{
		}

		// Token: 0x0402FC6E RID: 195694
		[Token(Token = "0x402FC6E")]
		[FieldOffset(Offset = "0x10")]
		private TowerCurrent.TowerCardType m_cardType;

		// Token: 0x0402FC6F RID: 195695
		[Token(Token = "0x402FC6F")]
		[FieldOffset(Offset = "0x18")]
		private string m_charId;

		// Token: 0x0402FC70 RID: 195696
		[Token(Token = "0x402FC70")]
		[FieldOffset(Offset = "0x20")]
		private CharacterData m_charData;

		// Token: 0x0402FC71 RID: 195697
		[Token(Token = "0x402FC71")]
		[FieldOffset(Offset = "0x28")]
		private EvolvePhase m_evolvePhase;

		// Token: 0x0402FC72 RID: 195698
		[Token(Token = "0x402FC72")]
		[FieldOffset(Offset = "0x2C")]
		private int m_level;

		// Token: 0x0402FC73 RID: 195699
		[Token(Token = "0x402FC73")]
		[FieldOffset(Offset = "0x30")]
		private string m_portraitId;
	}
}
