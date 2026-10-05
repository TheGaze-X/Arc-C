using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D53 RID: 23891
	[Token(Token = "0x2005D53")]
	public class ClimbTowerRecruitSubGodModel : IHotfixable
	{
		// Token: 0x1700517B RID: 20859
		// (get) Token: 0x0602298A RID: 141706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700517B")]
		public string selectedSubId
		{
			[Token(Token = "0x602298A")]
			[Address(RVA = "0x1D1D8D0", Offset = "0x1D1C4D0", VA = "0x181D1D8D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700517C RID: 20860
		// (get) Token: 0x0602298B RID: 141707 RVA: 0x000BDFD8 File Offset: 0x000BC1D8
		[Token(Token = "0x1700517C")]
		public bool haveSubSelected
		{
			[Token(Token = "0x602298B")]
			[Address(RVA = "0x1D1D7D0", Offset = "0x1D1C3D0", VA = "0x181D1D7D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700517D RID: 20861
		// (get) Token: 0x0602298C RID: 141708 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700517D")]
		public string towerId
		{
			[Token(Token = "0x602298C")]
			[Address(RVA = "0x1D1D990", Offset = "0x1D1C590", VA = "0x181D1D990")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700517E RID: 20862
		// (get) Token: 0x0602298D RID: 141709 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700517E")]
		public string mainCardName
		{
			[Token(Token = "0x602298D")]
			[Address(RVA = "0x1D1D840", Offset = "0x1D1C440", VA = "0x181D1D840")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700517F RID: 20863
		// (get) Token: 0x0602298E RID: 141710 RVA: 0x000BDFF0 File Offset: 0x000BC1F0
		[Token(Token = "0x1700517F")]
		public int currentFloor
		{
			[Token(Token = "0x602298E")]
			[Address(RVA = "0x1D1D770", Offset = "0x1D1C370", VA = "0x181D1D770")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005180 RID: 20864
		// (get) Token: 0x0602298F RID: 141711 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005180")]
		public List<ClimbTowerRecruitSubGodItemModel> subCardList
		{
			[Token(Token = "0x602298F")]
			[Address(RVA = "0x1D1D930", Offset = "0x1D1C530", VA = "0x181D1D930")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022990 RID: 141712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022990")]
		[Address(RVA = "0x1D1D1E0", Offset = "0x1D1BDE0", VA = "0x181D1D1E0")]
		public void LoadData(UIPage page)
		{
		}

		// Token: 0x06022991 RID: 141713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022991")]
		[Address(RVA = "0x1D1D640", Offset = "0x1D1C240", VA = "0x181D1D640")]
		public void SelectSubCard(string subCardId)
		{
		}

		// Token: 0x06022992 RID: 141714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022992")]
		[Address(RVA = "0x1D1D6C0", Offset = "0x1D1C2C0", VA = "0x181D1D6C0")]
		public ClimbTowerRecruitSubGodModel()
		{
		}

		// Token: 0x0402F8D8 RID: 194776
		[Token(Token = "0x402F8D8")]
		[FieldOffset(Offset = "0x10")]
		private List<ClimbTowerRecruitSubGodItemModel> m_subItemList;

		// Token: 0x0402F8D9 RID: 194777
		[Token(Token = "0x402F8D9")]
		[FieldOffset(Offset = "0x18")]
		private ClimbTowerMainCardData m_mainCardData;

		// Token: 0x0402F8DA RID: 194778
		[Token(Token = "0x402F8DA")]
		[FieldOffset(Offset = "0x20")]
		private string m_selectSubId;

		// Token: 0x0402F8DB RID: 194779
		[Token(Token = "0x402F8DB")]
		[FieldOffset(Offset = "0x28")]
		private string m_towerId;

		// Token: 0x0402F8DC RID: 194780
		[Token(Token = "0x402F8DC")]
		[FieldOffset(Offset = "0x30")]
		private int m_currentFloor;

		// Token: 0x0402F8DD RID: 194781
		[Token(Token = "0x402F8DD")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_selectedSubId;

		// Token: 0x0402F8DE RID: 194782
		[Token(Token = "0x402F8DE")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_haveSubSelected;

		// Token: 0x0402F8DF RID: 194783
		[Token(Token = "0x402F8DF")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_towerId;

		// Token: 0x0402F8E0 RID: 194784
		[Token(Token = "0x402F8E0")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_mainCardName;

		// Token: 0x0402F8E1 RID: 194785
		[Token(Token = "0x402F8E1")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_currentFloor;

		// Token: 0x0402F8E2 RID: 194786
		[Token(Token = "0x402F8E2")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_subCardList;

		// Token: 0x0402F8E3 RID: 194787
		[Token(Token = "0x402F8E3")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402F8E4 RID: 194788
		[Token(Token = "0x402F8E4")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SelectSubCard;

		// Token: 0x0402F8E5 RID: 194789
		[Token(Token = "0x402F8E5")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
