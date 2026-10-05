using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D48 RID: 23880
	[Token(Token = "0x2005D48")]
	public class ClimbTowerInitGodDisplayModel : IHotfixable
	{
		// Token: 0x1700516B RID: 20843
		// (get) Token: 0x06022956 RID: 141654 RVA: 0x000BDF18 File Offset: 0x000BC118
		[Token(Token = "0x1700516B")]
		public int totalStepCount
		{
			[Token(Token = "0x6022956")]
			[Address(RVA = "0x1D1A3D0", Offset = "0x1D18FD0", VA = "0x181D1A3D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700516C RID: 20844
		// (get) Token: 0x06022957 RID: 141655 RVA: 0x000BDF30 File Offset: 0x000BC130
		[Token(Token = "0x1700516C")]
		public int selectedIdx
		{
			[Token(Token = "0x6022957")]
			[Address(RVA = "0x1D1A370", Offset = "0x1D18F70", VA = "0x181D1A370")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700516D RID: 20845
		// (get) Token: 0x06022958 RID: 141656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700516D")]
		public ClimbTowerInitGodCardModel selectedCardModel
		{
			[Token(Token = "0x6022958")]
			[Address(RVA = "0x1D1A2F0", Offset = "0x1D18EF0", VA = "0x181D1A2F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700516E RID: 20846
		// (get) Token: 0x06022959 RID: 141657 RVA: 0x000BDF48 File Offset: 0x000BC148
		[Token(Token = "0x1700516E")]
		public int currentStep
		{
			[Token(Token = "0x6022959")]
			[Address(RVA = "0x1D1A1D0", Offset = "0x1D18DD0", VA = "0x181D1A1D0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x1700516F RID: 20847
		// (get) Token: 0x0602295A RID: 141658 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700516F")]
		public List<ClimbTowerInitGodCardModel> godCardList
		{
			[Token(Token = "0x602295A")]
			[Address(RVA = "0x1D1A230", Offset = "0x1D18E30", VA = "0x181D1A230")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005170 RID: 20848
		// (get) Token: 0x0602295B RID: 141659 RVA: 0x000BDF60 File Offset: 0x000BC160
		[Token(Token = "0x17005170")]
		public bool isHard
		{
			[Token(Token = "0x602295B")]
			[Address(RVA = "0x1D1A290", Offset = "0x1D18E90", VA = "0x181D1A290")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0602295C RID: 141660 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602295C")]
		[Address(RVA = "0x1D19A90", Offset = "0x1D18690", VA = "0x181D19A90")]
		public void InitData(UIPage page)
		{
		}

		// Token: 0x0602295D RID: 141661 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602295D")]
		[Address(RVA = "0x1D19E50", Offset = "0x1D18A50", VA = "0x181D19E50")]
		public void SelectItem(int index)
		{
		}

		// Token: 0x0602295E RID: 141662 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602295E")]
		[Address(RVA = "0x1D19EF0", Offset = "0x1D18AF0", VA = "0x181D19EF0")]
		private void _GenerateGodCardIdList(PlayerTower playerTower)
		{
		}

		// Token: 0x0602295F RID: 141663 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x602295F")]
		[Address(RVA = "0x1D1A0D0", Offset = "0x1D18CD0", VA = "0x181D1A0D0")]
		public ClimbTowerInitGodDisplayModel()
		{
		}

		// Token: 0x0402F880 RID: 194688
		[Token(Token = "0x402F880")]
		[FieldOffset(Offset = "0x10")]
		private List<ClimbTowerInitGodCardModel> m_godCardList;

		// Token: 0x0402F881 RID: 194689
		[Token(Token = "0x402F881")]
		[FieldOffset(Offset = "0x18")]
		private List<string> m_godCardIdList;

		// Token: 0x0402F882 RID: 194690
		[Token(Token = "0x402F882")]
		[FieldOffset(Offset = "0x20")]
		private int m_totalStepCount;

		// Token: 0x0402F883 RID: 194691
		[Token(Token = "0x402F883")]
		[FieldOffset(Offset = "0x24")]
		private int m_currentStep;

		// Token: 0x0402F884 RID: 194692
		[Token(Token = "0x402F884")]
		[FieldOffset(Offset = "0x28")]
		private int m_selectedIdx;

		// Token: 0x0402F885 RID: 194693
		[Token(Token = "0x402F885")]
		[FieldOffset(Offset = "0x2C")]
		private bool m_isHard;

		// Token: 0x0402F886 RID: 194694
		[Token(Token = "0x402F886")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_totalStepCount;

		// Token: 0x0402F887 RID: 194695
		[Token(Token = "0x402F887")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_selectedIdx;

		// Token: 0x0402F888 RID: 194696
		[Token(Token = "0x402F888")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_selectedCardModel;

		// Token: 0x0402F889 RID: 194697
		[Token(Token = "0x402F889")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_currentStep;

		// Token: 0x0402F88A RID: 194698
		[Token(Token = "0x402F88A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_godCardList;

		// Token: 0x0402F88B RID: 194699
		[Token(Token = "0x402F88B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_isHard;

		// Token: 0x0402F88C RID: 194700
		[Token(Token = "0x402F88C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402F88D RID: 194701
		[Token(Token = "0x402F88D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SelectItem;

		// Token: 0x0402F88E RID: 194702
		[Token(Token = "0x402F88E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__GenerateGodCardIdList;

		// Token: 0x0402F88F RID: 194703
		[Token(Token = "0x402F88F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
