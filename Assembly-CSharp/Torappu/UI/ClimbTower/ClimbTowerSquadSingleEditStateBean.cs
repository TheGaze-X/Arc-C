using System;
using Il2CppDummyDll;
using Torappu.UI.CharSelect;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D8F RID: 23951
	[Token(Token = "0x2005D8F")]
	public class ClimbTowerSquadSingleEditStateBean : IStateBean, IHotfixable
	{
		// Token: 0x170051F7 RID: 20983
		// (get) Token: 0x06022B8E RID: 142222 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051F7")]
		public ClimbTowerSquadSingleEditProp squadProp
		{
			[Token(Token = "0x6022B8E")]
			[Address(RVA = "0x1D44A00", Offset = "0x1D43600", VA = "0x181D44A00")]
			get
			{
				return null;
			}
		}

		// Token: 0x170051F8 RID: 20984
		// (get) Token: 0x06022B8F RID: 142223 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051F8")]
		public CharAttrViewProperty attrProp
		{
			[Token(Token = "0x6022B8F")]
			[Address(RVA = "0x1D449A0", Offset = "0x1D435A0", VA = "0x181D449A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022B90 RID: 142224 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B90")]
		[Address(RVA = "0x1D44240", Offset = "0x1D42E40", VA = "0x181D44240")]
		public void SelectCard(int cardId)
		{
		}

		// Token: 0x06022B91 RID: 142225 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B91")]
		[Address(RVA = "0x1D43B40", Offset = "0x1D42740", VA = "0x181D43B40")]
		public void InitData(UIPage page)
		{
		}

		// Token: 0x06022B92 RID: 142226 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B92")]
		[Address(RVA = "0x1D44560", Offset = "0x1D43160", VA = "0x181D44560")]
		public void UpdateAttrProp(int cardId)
		{
		}

		// Token: 0x06022B93 RID: 142227 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B93")]
		[Address(RVA = "0x1D442B0", Offset = "0x1D42EB0", VA = "0x181D442B0")]
		public void SelectSkill(string skillId)
		{
		}

		// Token: 0x06022B94 RID: 142228 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B94")]
		[Address(RVA = "0x1D43FC0", Offset = "0x1D42BC0", VA = "0x181D43FC0")]
		public void SelectBranch(string equipId)
		{
		}

		// Token: 0x06022B95 RID: 142229 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B95")]
		[Address(RVA = "0x1D43C00", Offset = "0x1D42800", VA = "0x181D43C00")]
		public void SaveEditDict()
		{
		}

		// Token: 0x06022B96 RID: 142230 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022B96")]
		[Address(RVA = "0x1D44880", Offset = "0x1D43480", VA = "0x181D44880")]
		public ClimbTowerSquadSingleEditStateBean()
		{
		}

		// Token: 0x0402FBB6 RID: 195510
		[Token(Token = "0x402FBB6")]
		[FieldOffset(Offset = "0x10")]
		private ClimbTowerSquadSingleEditProp m_squadProp;

		// Token: 0x0402FBB7 RID: 195511
		[Token(Token = "0x402FBB7")]
		[FieldOffset(Offset = "0x18")]
		private CharAttrViewProperty m_attrPop;

		// Token: 0x0402FBB8 RID: 195512
		[Token(Token = "0x402FBB8")]
		[FieldOffset(Offset = "0x20")]
		private int m_selectCardId;

		// Token: 0x0402FBB9 RID: 195513
		[Token(Token = "0x402FBB9")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_squadProp;

		// Token: 0x0402FBBA RID: 195514
		[Token(Token = "0x402FBBA")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_attrProp;

		// Token: 0x0402FBBB RID: 195515
		[Token(Token = "0x402FBBB")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_SelectCard;

		// Token: 0x0402FBBC RID: 195516
		[Token(Token = "0x402FBBC")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_InitData;

		// Token: 0x0402FBBD RID: 195517
		[Token(Token = "0x402FBBD")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_UpdateAttrProp;

		// Token: 0x0402FBBE RID: 195518
		[Token(Token = "0x402FBBE")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_SelectSkill;

		// Token: 0x0402FBBF RID: 195519
		[Token(Token = "0x402FBBF")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_SelectBranch;

		// Token: 0x0402FBC0 RID: 195520
		[Token(Token = "0x402FBC0")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_SaveEditDict;

		// Token: 0x0402FBC1 RID: 195521
		[Token(Token = "0x402FBC1")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
