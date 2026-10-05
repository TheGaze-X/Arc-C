using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005DA1 RID: 23969
	[Token(Token = "0x2005DA1")]
	public class ClimbTowerSquadExpansionModel
	{
		// Token: 0x17005212 RID: 21010
		// (get) Token: 0x06022C09 RID: 142345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005212")]
		public string selectGroupId
		{
			[Token(Token = "0x6022C09")]
			[Address(RVA = "0x4EA850", Offset = "0x4E9450", VA = "0x1804EA850")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005213 RID: 21011
		// (get) Token: 0x06022C0A RID: 142346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005213")]
		public string selectCharId
		{
			[Token(Token = "0x6022C0A")]
			[Address(RVA = "0x4EE950", Offset = "0x4ED550", VA = "0x1804EE950")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005214 RID: 21012
		// (get) Token: 0x06022C0B RID: 142347 RVA: 0x000BEAB8 File Offset: 0x000BCCB8
		[Token(Token = "0x17005214")]
		public bool haveAnySelect
		{
			[Token(Token = "0x6022C0B")]
			[Address(RVA = "0x1D58C50", Offset = "0x1D57850", VA = "0x181D58C50")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005215 RID: 21013
		// (get) Token: 0x06022C0C RID: 142348 RVA: 0x000BEAD0 File Offset: 0x000BCCD0
		[Token(Token = "0x17005215")]
		public bool isGiveUpSelected
		{
			[Token(Token = "0x6022C0C")]
			[Address(RVA = "0x1D58C80", Offset = "0x1D57880", VA = "0x181D58C80")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005216 RID: 21014
		// (get) Token: 0x06022C0D RID: 142349 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005216")]
		public List<IClimbTowerExpansionSlot> slotList
		{
			[Token(Token = "0x6022C0D")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005217 RID: 21015
		// (get) Token: 0x06022C0E RID: 142350 RVA: 0x000BEAE8 File Offset: 0x000BCCE8
		[Token(Token = "0x17005217")]
		public int currentStep
		{
			[Token(Token = "0x6022C0E")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005218 RID: 21016
		// (get) Token: 0x06022C0F RID: 142351 RVA: 0x000BEB00 File Offset: 0x000BCD00
		[Token(Token = "0x17005218")]
		public int totalStep
		{
			[Token(Token = "0x6022C0F")]
			[Address(RVA = "0x4EA890", Offset = "0x4E9490", VA = "0x1804EA890")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005219 RID: 21017
		// (get) Token: 0x06022C10 RID: 142352 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005219")]
		public string towerName
		{
			[Token(Token = "0x6022C10")]
			[Address(RVA = "0x1D58C90", Offset = "0x1D57890", VA = "0x181D58C90")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700521A RID: 21018
		// (get) Token: 0x06022C11 RID: 142353 RVA: 0x000BEB18 File Offset: 0x000BCD18
		[Token(Token = "0x1700521A")]
		public int currentFloor
		{
			[Token(Token = "0x6022C11")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700521B RID: 21019
		// (get) Token: 0x06022C12 RID: 142354 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700521B")]
		public string towerId
		{
			[Token(Token = "0x6022C12")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022C13 RID: 142355 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C13")]
		[Address(RVA = "0x1D586E0", Offset = "0x1D572E0", VA = "0x181D586E0")]
		public void SetData()
		{
		}

		// Token: 0x06022C14 RID: 142356 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C14")]
		[Address(RVA = "0x1D58B80", Offset = "0x1D57780", VA = "0x181D58B80")]
		public void SetSelect(bool isGiveUp, string groupId, string charId)
		{
		}

		// Token: 0x06022C15 RID: 142357 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022C15")]
		[Address(RVA = "0x1D58BC0", Offset = "0x1D577C0", VA = "0x181D58BC0")]
		public ClimbTowerSquadExpansionModel()
		{
		}

		// Token: 0x0402FC61 RID: 195681
		[Token(Token = "0x402FC61")]
		[FieldOffset(Offset = "0x10")]
		private string m_towerId;

		// Token: 0x0402FC62 RID: 195682
		[Token(Token = "0x402FC62")]
		[FieldOffset(Offset = "0x18")]
		private int m_floor;

		// Token: 0x0402FC63 RID: 195683
		[Token(Token = "0x402FC63")]
		[FieldOffset(Offset = "0x1C")]
		private int m_currentStep;

		// Token: 0x0402FC64 RID: 195684
		[Token(Token = "0x402FC64")]
		[FieldOffset(Offset = "0x20")]
		private int m_totalStep;

		// Token: 0x0402FC65 RID: 195685
		[Token(Token = "0x402FC65")]
		[FieldOffset(Offset = "0x28")]
		private List<IClimbTowerExpansionSlot> m_slotList;

		// Token: 0x0402FC66 RID: 195686
		[Token(Token = "0x402FC66")]
		[FieldOffset(Offset = "0x30")]
		private ClimbTowerSingleTowerData m_towerData;

		// Token: 0x0402FC67 RID: 195687
		[Token(Token = "0x402FC67")]
		[FieldOffset(Offset = "0x38")]
		private string m_selectGroupId;

		// Token: 0x0402FC68 RID: 195688
		[Token(Token = "0x402FC68")]
		[FieldOffset(Offset = "0x40")]
		private string m_selectCharId;

		// Token: 0x0402FC69 RID: 195689
		[Token(Token = "0x402FC69")]
		[FieldOffset(Offset = "0x48")]
		private bool m_canGiveUp;

		// Token: 0x0402FC6A RID: 195690
		[Token(Token = "0x402FC6A")]
		[FieldOffset(Offset = "0x49")]
		private bool m_isGiveUpSelected;
	}
}
