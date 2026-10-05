using System;
using System.Collections.Generic;
using Il2CppDummyDll;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D7F RID: 23935
	[Token(Token = "0x2005D7F")]
	public class ClimbTowerSquadMultiEditModel
	{
		// Token: 0x170051D5 RID: 20949
		// (get) Token: 0x06022B11 RID: 142097 RVA: 0x000BE710 File Offset: 0x000BC910
		[Token(Token = "0x170051D5")]
		public ClimbTowerSquadMultiEditModel.EditType editType
		{
			[Token(Token = "0x6022B11")]
			[Address(RVA = "0x4EA860", Offset = "0x4E9460", VA = "0x1804EA860")]
			get
			{
				return ClimbTowerSquadMultiEditModel.EditType.SKILL;
			}
		}

		// Token: 0x170051D6 RID: 20950
		// (get) Token: 0x06022B12 RID: 142098 RVA: 0x000BE728 File Offset: 0x000BC928
		[Token(Token = "0x170051D6")]
		public int viewIndex
		{
			[Token(Token = "0x6022B12")]
			[Address(RVA = "0x4EA880", Offset = "0x4E9480", VA = "0x1804EA880")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170051D7 RID: 20951
		// (get) Token: 0x06022B13 RID: 142099 RVA: 0x000BE740 File Offset: 0x000BC940
		[Token(Token = "0x170051D7")]
		public float columnIndex
		{
			[Token(Token = "0x6022B13")]
			[Address(RVA = "0x621E40", Offset = "0x620A40", VA = "0x180621E40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170051D8 RID: 20952
		// (get) Token: 0x06022B14 RID: 142100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051D8")]
		public List<ClimbTowerSquadMultiEditCharModel> charEditList
		{
			[Token(Token = "0x6022B14")]
			[Address(RVA = "0x4EC5A0", Offset = "0x4EB1A0", VA = "0x1804EC5A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170051D9 RID: 20953
		// (get) Token: 0x06022B15 RID: 142101 RVA: 0x000BE758 File Offset: 0x000BC958
		[Token(Token = "0x170051D9")]
		public long gameStartTs
		{
			[Token(Token = "0x6022B15")]
			[Address(RVA = "0x4E4070", Offset = "0x4E2C70", VA = "0x1804E4070")]
			get
			{
				return 0L;
			}
		}

		// Token: 0x06022B16 RID: 142102 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B16")]
		[Address(RVA = "0x1D3E750", Offset = "0x1D3D350", VA = "0x181D3E750")]
		public void SetFocusIndex(int viewIndex, float columnIndex)
		{
		}

		// Token: 0x06022B17 RID: 142103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B17")]
		[Address(RVA = "0x1D3E760", Offset = "0x1D3D360", VA = "0x181D3E760")]
		public void ToggleEditType()
		{
		}

		// Token: 0x06022B18 RID: 142104 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022B18")]
		[Address(RVA = "0x1D3E380", Offset = "0x1D3CF80", VA = "0x181D3E380")]
		public ClimbTowerSquadMultiEditCharModel FindCharModelByCardId(int cardId)
		{
			return null;
		}

		// Token: 0x06022B19 RID: 142105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B19")]
		[Address(RVA = "0x1D3E430", Offset = "0x1D3D030", VA = "0x181D3E430")]
		public void LoadData(UIPage page, Dictionary<string, TowerCurrent.GameCard> cards, Dictionary<int, ClimbTowerCharEditCacheModel> editDict)
		{
		}

		// Token: 0x06022B1A RID: 142106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B1A")]
		[Address(RVA = "0x1D3E770", Offset = "0x1D3D370", VA = "0x181D3E770")]
		public ClimbTowerSquadMultiEditModel()
		{
		}

		// Token: 0x0402FB19 RID: 195353
		[Token(Token = "0x402FB19")]
		[FieldOffset(Offset = "0x10")]
		private List<ClimbTowerSquadMultiEditCharModel> m_charEditList;

		// Token: 0x0402FB1A RID: 195354
		[Token(Token = "0x402FB1A")]
		[FieldOffset(Offset = "0x18")]
		private ClimbTowerSquadMultiEditModel.EditType m_editType;

		// Token: 0x0402FB1B RID: 195355
		[Token(Token = "0x402FB1B")]
		[FieldOffset(Offset = "0x1C")]
		private int m_viewIndex;

		// Token: 0x0402FB1C RID: 195356
		[Token(Token = "0x402FB1C")]
		[FieldOffset(Offset = "0x20")]
		private float m_columnIndex;

		// Token: 0x0402FB1D RID: 195357
		[Token(Token = "0x402FB1D")]
		[FieldOffset(Offset = "0x28")]
		private long m_gameStartTs;

		// Token: 0x02005D80 RID: 23936
		[Token(Token = "0x2005D80")]
		public enum EditType
		{
			// Token: 0x0402FB1F RID: 195359
			[Token(Token = "0x402FB1F")]
			SKILL,
			// Token: 0x0402FB20 RID: 195360
			[Token(Token = "0x402FB20")]
			UNIEQUIP
		}
	}
}
