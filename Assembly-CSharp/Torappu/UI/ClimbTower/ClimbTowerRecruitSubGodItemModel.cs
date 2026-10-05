using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D52 RID: 23890
	[Token(Token = "0x2005D52")]
	public class ClimbTowerRecruitSubGodItemModel : IHotfixable
	{
		// Token: 0x17005177 RID: 20855
		// (get) Token: 0x06022984 RID: 141700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005177")]
		public string cardId
		{
			[Token(Token = "0x6022984")]
			[Address(RVA = "0x1D1CB90", Offset = "0x1D1B790", VA = "0x181D1CB90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005178 RID: 20856
		// (get) Token: 0x06022985 RID: 141701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005178")]
		public string cardName
		{
			[Token(Token = "0x6022985")]
			[Address(RVA = "0x1D1CC00", Offset = "0x1D1B800", VA = "0x181D1CC00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005179 RID: 20857
		// (get) Token: 0x06022986 RID: 141702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005179")]
		public string cardDesc
		{
			[Token(Token = "0x6022986")]
			[Address(RVA = "0x1D1CB00", Offset = "0x1D1B700", VA = "0x181D1CB00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700517A RID: 20858
		// (get) Token: 0x06022987 RID: 141703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700517A")]
		public Sprite cardSprite
		{
			[Token(Token = "0x6022987")]
			[Address(RVA = "0x1D1CC90", Offset = "0x1D1B890", VA = "0x181D1CC90")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022988 RID: 141704 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022988")]
		[Address(RVA = "0x1D1C980", Offset = "0x1D1B580", VA = "0x181D1C980")]
		public void LoadData(UIPage page, string subCardId)
		{
		}

		// Token: 0x06022989 RID: 141705 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022989")]
		[Address(RVA = "0x1D1CAA0", Offset = "0x1D1B6A0", VA = "0x181D1CAA0")]
		public ClimbTowerRecruitSubGodItemModel()
		{
		}

		// Token: 0x0402F8D0 RID: 194768
		[Token(Token = "0x402F8D0")]
		[FieldOffset(Offset = "0x10")]
		private ClimbTowerSubCardData m_subCardData;

		// Token: 0x0402F8D1 RID: 194769
		[Token(Token = "0x402F8D1")]
		[FieldOffset(Offset = "0x18")]
		private Sprite m_cardSprite;

		// Token: 0x0402F8D2 RID: 194770
		[Token(Token = "0x402F8D2")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_cardId;

		// Token: 0x0402F8D3 RID: 194771
		[Token(Token = "0x402F8D3")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_cardName;

		// Token: 0x0402F8D4 RID: 194772
		[Token(Token = "0x402F8D4")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_cardDesc;

		// Token: 0x0402F8D5 RID: 194773
		[Token(Token = "0x402F8D5")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_cardSprite;

		// Token: 0x0402F8D6 RID: 194774
		[Token(Token = "0x402F8D6")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_LoadData;

		// Token: 0x0402F8D7 RID: 194775
		[Token(Token = "0x402F8D7")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
