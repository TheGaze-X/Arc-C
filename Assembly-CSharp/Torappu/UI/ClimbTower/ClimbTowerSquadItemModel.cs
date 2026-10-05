using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D6F RID: 23919
	[Token(Token = "0x2005D6F")]
	public class ClimbTowerSquadItemModel : ISquadMemberCompInfo, IHotfixable
	{
		// Token: 0x170051BB RID: 20923
		// (get) Token: 0x06022A9C RID: 141980 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051BB")]
		public CharacterCardViewModel cardModel
		{
			[Token(Token = "0x6022A9C")]
			[Address(RVA = "0x1D3AFF0", Offset = "0x1D39BF0", VA = "0x181D3AFF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170051BC RID: 20924
		// (get) Token: 0x06022A9D RID: 141981 RVA: 0x000BE4E8 File Offset: 0x000BC6E8
		[Token(Token = "0x170051BC")]
		public int cardId
		{
			[Token(Token = "0x6022A9D")]
			[Address(RVA = "0x1D3AF90", Offset = "0x1D39B90", VA = "0x181D3AF90")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170051BD RID: 20925
		// (get) Token: 0x06022A9E RID: 141982 RVA: 0x000BE500 File Offset: 0x000BC700
		[Token(Token = "0x170051BD")]
		public TowerCurrent.TowerCardType cardType
		{
			[Token(Token = "0x6022A9E")]
			[Address(RVA = "0x1D3B050", Offset = "0x1D39C50", VA = "0x181D3B050")]
			get
			{
				return TowerCurrent.TowerCardType.CHAR;
			}
		}

		// Token: 0x170051BE RID: 20926
		// (get) Token: 0x06022A9F RID: 141983 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170051BE")]
		public Sprite charMarkSprite
		{
			[Token(Token = "0x6022A9F")]
			[Address(RVA = "0x1D3B0B0", Offset = "0x1D39CB0", VA = "0x181D3B0B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022AA0 RID: 141984 RVA: 0x000BE518 File Offset: 0x000BC718
		[Token(Token = "0x6022AA0")]
		[Address(RVA = "0x1D3ABC0", Offset = "0x1D397C0", VA = "0x181D3ABC0")]
		private int _GetCurSkillIndex()
		{
			return 0;
		}

		// Token: 0x06022AA1 RID: 141985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AA1")]
		[Address(RVA = "0x1D3A990", Offset = "0x1D39590", VA = "0x181D3A990")]
		public void LoadData(UIPage page, TowerCurrent.GameCard playerCard, ClimbTowerCharEditCacheModel editModel)
		{
		}

		// Token: 0x06022AA2 RID: 141986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AA2")]
		[Address(RVA = "0x1D3ACF0", Offset = "0x1D398F0", VA = "0x181D3ACF0")]
		private void _LoadCharMarkSprite(UIPage page)
		{
		}

		// Token: 0x06022AA3 RID: 141987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AA3")]
		[Address(RVA = "0x1D3A8F0", Offset = "0x1D394F0", VA = "0x181D3A8F0")]
		public void LoadDataFromPredefined(CharacterCardViewModel charModel)
		{
		}

		// Token: 0x06022AA4 RID: 141988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AA4")]
		[Address(RVA = "0x1D3AAE0", Offset = "0x1D396E0", VA = "0x181D3AAE0")]
		public void UpdateEditInfo(ClimbTowerCharEditCacheModel editModel)
		{
		}

		// Token: 0x06022AA5 RID: 141989 RVA: 0x000BE530 File Offset: 0x000BC730
		[Token(Token = "0x6022AA5")]
		[Address(RVA = "0x1D3A760", Offset = "0x1D39360", VA = "0x181D3A760", Slot = "5")]
		public int ExtraTmplCount()
		{
			return 0;
		}

		// Token: 0x06022AA6 RID: 141990 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022AA6")]
		[Address(RVA = "0x1D3A7E0", Offset = "0x1D393E0", VA = "0x181D3A7E0", Slot = "4")]
		public IEnumerator<KeyValuePair<string, PlayerSquadTmpl>> ExtraTmplInfo()
		{
			return null;
		}

		// Token: 0x06022AA7 RID: 141991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6022AA7")]
		[Address(RVA = "0x1D3A890", Offset = "0x1D39490", VA = "0x181D3A890", Slot = "6")]
		public string GetDefaultEquipId()
		{
			return null;
		}

		// Token: 0x06022AA8 RID: 141992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022AA8")]
		[Address(RVA = "0x1D3AF30", Offset = "0x1D39B30", VA = "0x181D3AF30")]
		public ClimbTowerSquadItemModel()
		{
		}

		// Token: 0x0402FA40 RID: 195136
		[Token(Token = "0x402FA40")]
		[FieldOffset(Offset = "0x10")]
		private CharacterCardViewModel m_cardModel;

		// Token: 0x0402FA41 RID: 195137
		[Token(Token = "0x402FA41")]
		[FieldOffset(Offset = "0x18")]
		private string m_defaultEquipId;

		// Token: 0x0402FA42 RID: 195138
		[Token(Token = "0x402FA42")]
		[FieldOffset(Offset = "0x20")]
		private TowerCurrent.TowerCardType m_cardType;

		// Token: 0x0402FA43 RID: 195139
		[Token(Token = "0x402FA43")]
		[FieldOffset(Offset = "0x24")]
		private int m_cardId;

		// Token: 0x0402FA44 RID: 195140
		[Token(Token = "0x402FA44")]
		[FieldOffset(Offset = "0x28")]
		private Sprite m_charMarkSprite;

		// Token: 0x0402FA45 RID: 195141
		[Token(Token = "0x402FA45")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cardModel;

		// Token: 0x0402FA46 RID: 195142
		[Token(Token = "0x402FA46")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cardId;

		// Token: 0x0402FA47 RID: 195143
		[Token(Token = "0x402FA47")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_cardType;

		// Token: 0x0402FA48 RID: 195144
		[Token(Token = "0x402FA48")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_charMarkSprite;

		// Token: 0x0402FA49 RID: 195145
		[Token(Token = "0x402FA49")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0__GetCurSkillIndex;

		// Token: 0x0402FA4A RID: 195146
		[Token(Token = "0x402FA4A")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402FA4B RID: 195147
		[Token(Token = "0x402FA4B")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0__LoadCharMarkSprite;

		// Token: 0x0402FA4C RID: 195148
		[Token(Token = "0x402FA4C")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_LoadDataFromPredefined;

		// Token: 0x0402FA4D RID: 195149
		[Token(Token = "0x402FA4D")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0_UpdateEditInfo;

		// Token: 0x0402FA4E RID: 195150
		[Token(Token = "0x402FA4E")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge __Hotfix0_ExtraTmplCount;

		// Token: 0x0402FA4F RID: 195151
		[Token(Token = "0x402FA4F")]
		[FieldOffset(Offset = "0x50")]
		private static DelegateBridge __Hotfix0_ExtraTmplInfo;

		// Token: 0x0402FA50 RID: 195152
		[Token(Token = "0x402FA50")]
		[FieldOffset(Offset = "0x58")]
		private static DelegateBridge __Hotfix0_GetDefaultEquipId;

		// Token: 0x0402FA51 RID: 195153
		[Token(Token = "0x402FA51")]
		[FieldOffset(Offset = "0x60")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
