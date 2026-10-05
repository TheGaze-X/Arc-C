using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DA3 RID: 23971
	[Token(Token = "0x2005DA3")]
	public class ClimbTowerSquadExpansionCharSlotModel : IClimbTowerExpansionSlot
	{
		// Token: 0x1700521D RID: 21021
		// (get) Token: 0x06022C18 RID: 142360 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700521D")]
		public string groupId
		{
			[Token(Token = "0x6022C18")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700521E RID: 21022
		// (get) Token: 0x06022C19 RID: 142361 RVA: 0x000BEB48 File Offset: 0x000BCD48
		[Token(Token = "0x1700521E")]
		public TowerCurrent.TowerCardType cardType
		{
			[Token(Token = "0x6022C19")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return TowerCurrent.TowerCardType.CHAR;
			}
		}

		// Token: 0x1700521F RID: 21023
		// (get) Token: 0x06022C1A RID: 142362 RVA: 0x000BEB60 File Offset: 0x000BCD60
		[Token(Token = "0x1700521F")]
		public bool isGroup
		{
			[Token(Token = "0x6022C1A")]
			[Address(RVA = "0x1D58690", Offset = "0x1D57290", VA = "0x181D58690")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005220 RID: 21024
		// (get) Token: 0x06022C1B RID: 142363 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005220")]
		public List<ClimbTowerSquadExpansionCharModel> charList
		{
			[Token(Token = "0x6022C1B")]
			[Address(RVA = "0x4E5A70", Offset = "0x4E4670", VA = "0x1804E5A70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005221 RID: 21025
		// (get) Token: 0x06022C1C RID: 142364 RVA: 0x000BEB78 File Offset: 0x000BCD78
		[Token(Token = "0x17005221")]
		public bool isGiveUpSlot
		{
			[Token(Token = "0x6022C1C")]
			[Address(RVA = "0x4F1E40", Offset = "0x4F0A40", VA = "0x1804F1E40", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06022C1D RID: 142365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022C1D")]
		[Address(RVA = "0x1D583F0", Offset = "0x1D56FF0", VA = "0x181D583F0")]
		public ClimbTowerSquadExpansionCharModel FindFirstNormalCharModel()
		{
			return null;
		}

		// Token: 0x06022C1E RID: 142366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C1E")]
		[Address(RVA = "0x1D584A0", Offset = "0x1D570A0", VA = "0x181D584A0")]
		public void SetData(TowerCurrent.HalftimeCandidateGroup candidate)
		{
		}

		// Token: 0x06022C1F RID: 142367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C1F")]
		[Address(RVA = "0x1D58600", Offset = "0x1D57200", VA = "0x181D58600")]
		public ClimbTowerSquadExpansionCharSlotModel()
		{
		}

		// Token: 0x0402FC6B RID: 195691
		[Token(Token = "0x402FC6B")]
		[FieldOffset(Offset = "0x10")]
		private string m_groupId;

		// Token: 0x0402FC6C RID: 195692
		[Token(Token = "0x402FC6C")]
		[FieldOffset(Offset = "0x18")]
		private TowerCurrent.TowerCardType m_cardType;

		// Token: 0x0402FC6D RID: 195693
		[Token(Token = "0x402FC6D")]
		[FieldOffset(Offset = "0x20")]
		private List<ClimbTowerSquadExpansionCharModel> m_charList;
	}
}
