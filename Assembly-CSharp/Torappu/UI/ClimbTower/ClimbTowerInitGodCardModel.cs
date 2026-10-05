using System;
using Il2CppDummyDll;
using UnityEngine;
using XLua;

namespace Torappu.UI.ClimbTower
{
	// Token: 0x02005D47 RID: 23879
	[Token(Token = "0x2005D47")]
	public class ClimbTowerInitGodCardModel : IHotfixable
	{
		// Token: 0x17005164 RID: 20836
		// (get) Token: 0x0602294C RID: 141644 RVA: 0x000BDEE8 File Offset: 0x000BC0E8
		[Token(Token = "0x17005164")]
		public bool hasRelatedTower
		{
			[Token(Token = "0x602294C")]
			[Address(RVA = "0x1D198D0", Offset = "0x1D184D0", VA = "0x181D198D0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17005165 RID: 20837
		// (get) Token: 0x0602294D RID: 141645 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005165")]
		public Sprite iconSprite
		{
			[Token(Token = "0x602294D")]
			[Address(RVA = "0x1D19930", Offset = "0x1D18530", VA = "0x181D19930")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005166 RID: 20838
		// (get) Token: 0x0602294E RID: 141646 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005166")]
		public string relatedTowerName
		{
			[Token(Token = "0x602294E")]
			[Address(RVA = "0x1D19990", Offset = "0x1D18590", VA = "0x181D19990")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005167 RID: 20839
		// (get) Token: 0x0602294F RID: 141647 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005167")]
		public string cardId
		{
			[Token(Token = "0x602294F")]
			[Address(RVA = "0x1D197D0", Offset = "0x1D183D0", VA = "0x181D197D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17005168 RID: 20840
		// (get) Token: 0x06022950 RID: 141648 RVA: 0x000BDF00 File Offset: 0x000BC100
		[Token(Token = "0x17005168")]
		public int sortId
		{
			[Token(Token = "0x6022950")]
			[Address(RVA = "0x1D19A20", Offset = "0x1D18620", VA = "0x181D19A20")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17005169 RID: 20841
		// (get) Token: 0x06022951 RID: 141649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17005169")]
		public string cardName
		{
			[Token(Token = "0x6022951")]
			[Address(RVA = "0x1D19840", Offset = "0x1D18440", VA = "0x181D19840")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700516A RID: 20842
		// (get) Token: 0x06022952 RID: 141650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700516A")]
		public string cardDesc
		{
			[Token(Token = "0x6022952")]
			[Address(RVA = "0x1D19740", Offset = "0x1D18340", VA = "0x181D19740")]
			get
			{
				return null;
			}
		}

		// Token: 0x06022953 RID: 141651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022953")]
		[Address(RVA = "0x1D192E0", Offset = "0x1D17EE0", VA = "0x181D192E0")]
		public void Init(UIPage page, string cardId)
		{
		}

		// Token: 0x06022954 RID: 141652 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022954")]
		[Address(RVA = "0x1D19600", Offset = "0x1D18200", VA = "0x181D19600")]
		private void _TryGetRelatedTowerData()
		{
		}

		// Token: 0x06022955 RID: 141653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6022955")]
		[Address(RVA = "0x1D196E0", Offset = "0x1D182E0", VA = "0x181D196E0")]
		public ClimbTowerInitGodCardModel()
		{
		}

		// Token: 0x0402F872 RID: 194674
		[Token(Token = "0x402F872")]
		[FieldOffset(Offset = "0x10")]
		private ClimbTowerMainCardData m_godCardData;

		// Token: 0x0402F873 RID: 194675
		[Token(Token = "0x402F873")]
		[FieldOffset(Offset = "0x18")]
		private ClimbTowerSingleTowerData m_towerData;

		// Token: 0x0402F874 RID: 194676
		[Token(Token = "0x402F874")]
		[FieldOffset(Offset = "0x20")]
		private Sprite m_iconSprite;

		// Token: 0x0402F875 RID: 194677
		[Token(Token = "0x402F875")]
		[FieldOffset(Offset = "0x28")]
		private string m_seasonId;

		// Token: 0x0402F876 RID: 194678
		[Token(Token = "0x402F876")]
		[FieldOffset(Offset = "0x0")]
		private static DelegateBridge __Hotfix0_get_hasRelatedTower;

		// Token: 0x0402F877 RID: 194679
		[Token(Token = "0x402F877")]
		[FieldOffset(Offset = "0x8")]
		private static DelegateBridge __Hotfix0_get_iconSprite;

		// Token: 0x0402F878 RID: 194680
		[Token(Token = "0x402F878")]
		[FieldOffset(Offset = "0x10")]
		private static DelegateBridge __Hotfix0_get_relatedTowerName;

		// Token: 0x0402F879 RID: 194681
		[Token(Token = "0x402F879")]
		[FieldOffset(Offset = "0x18")]
		private static DelegateBridge __Hotfix0_get_cardId;

		// Token: 0x0402F87A RID: 194682
		[Token(Token = "0x402F87A")]
		[FieldOffset(Offset = "0x20")]
		private static DelegateBridge __Hotfix0_get_sortId;

		// Token: 0x0402F87B RID: 194683
		[Token(Token = "0x402F87B")]
		[FieldOffset(Offset = "0x28")]
		private static DelegateBridge __Hotfix0_get_cardName;

		// Token: 0x0402F87C RID: 194684
		[Token(Token = "0x402F87C")]
		[FieldOffset(Offset = "0x30")]
		private static DelegateBridge __Hotfix0_get_cardDesc;

		// Token: 0x0402F87D RID: 194685
		[Token(Token = "0x402F87D")]
		[FieldOffset(Offset = "0x38")]
		private static DelegateBridge __Hotfix0_Init;

		// Token: 0x0402F87E RID: 194686
		[Token(Token = "0x402F87E")]
		[FieldOffset(Offset = "0x40")]
		private static DelegateBridge __Hotfix0__TryGetRelatedTowerData;

		// Token: 0x0402F87F RID: 194687
		[Token(Token = "0x402F87F")]
		[FieldOffset(Offset = "0x48")]
		private static DelegateBridge _c__Hotfix0_ctor;
	}
}
